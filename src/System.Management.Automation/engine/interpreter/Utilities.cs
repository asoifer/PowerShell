// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

using AstUtils = System.Management.Automation.Interpreter.Utils;

namespace System.Management.Automation.Interpreter
{
    internal static class TypeUtils
    {
        internal static Type GetNonNullableType(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 465, 694);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 545, 655) || true) && (f_1523_549_569(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 545, 655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 603, 640);

                    return f_1523_610_636(type)[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 545, 655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 671, 683);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 465, 694);

                bool
                f_1523_549_569(System.Type
                type)
                {
                    var return_v = IsNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 549, 569);
                    return return_v;
                }


                System.Type[]
                f_1523_610_636(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 610, 636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 465, 694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 465, 694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type GetNullableType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 706, 1023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 778, 828);

                f_1523_778_827(type != null, "type cannot be null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 842, 984) || true) && (f_1523_846_862(type) && (DynAbs.Tracing.TraceSender.Expression_True(1523, 846, 887) && !f_1523_867_887(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 842, 984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 921, 969);

                    return f_1523_928_968(typeof(Nullable<>), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 842, 984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1000, 1012);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 706, 1023);

                int
                f_1523_778_827(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 778, 827);
                    return 0;
                }


                bool
                f_1523_846_862(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 846, 862);
                    return return_v;
                }


                bool
                f_1523_867_887(System.Type
                type)
                {
                    var return_v = IsNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 867, 887);
                    return return_v;
                }


                System.Type
                f_1523_928_968(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 928, 968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 706, 1023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 706, 1023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNullableType(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 1035, 1200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1106, 1189);

                return f_1523_1113_1131(type) && (DynAbs.Tracing.TraceSender.Expression_True(1523, 1113, 1188) && f_1523_1135_1166(type) == typeof(Nullable<>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 1035, 1200);

                bool
                f_1523_1113_1131(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 1113, 1131);
                    return return_v;
                }


                System.Type
                f_1523_1135_1166(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 1135, 1166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 1035, 1200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 1035, 1200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBool(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 1212, 1334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1275, 1323);

                return f_1523_1282_1306(type) == typeof(bool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 1212, 1334);

                System.Type
                f_1523_1282_1306(System.Type
                type)
                {
                    var return_v = type.GetNonNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 1282, 1306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 1212, 1334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 1212, 1334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNumeric(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 1346, 2131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1412, 1444);

                type = f_1523_1419_1443(type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1458, 2091) || true) && (f_1523_1462_1474_M(!type.IsEnum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 1458, 2091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 1508, 2076);

                    switch (f_1523_1516_1534(type))
                    {

                        case TypeCode.Char:
                        case TypeCode.SByte:
                        case TypeCode.Byte:
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Double:
                        case TypeCode.Single:
                        case TypeCode.UInt16:
                        case TypeCode.UInt32:
                        case TypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 1508, 2076);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2045, 2057);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 1508, 2076);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 1458, 2091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2107, 2120);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 1346, 2131);

                System.Type
                f_1523_1419_1443(System.Type
                type)
                {
                    var return_v = type.GetNonNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 1419, 1443);
                    return return_v;
                }


                bool
                f_1523_1462_1474_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 1462, 1474);
                    return return_v;
                }


                System.TypeCode
                f_1523_1516_1534(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 1516, 1534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 1346, 2131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 1346, 2131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNumeric(TypeCode typeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 2143, 2759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2217, 2719);

                switch (typeCode)
                {

                    case TypeCode.Char:
                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Double:
                    case TypeCode.Single:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 2217, 2719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2692, 2704);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 2217, 2719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2735, 2748);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 2143, 2759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 2143, 2759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 2143, 2759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsArithmetic(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 2771, 3435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2840, 2872);

                type = f_1523_2847_2871(type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2886, 3395) || true) && (f_1523_2890_2902_M(!type.IsEnum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 2886, 3395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 2936, 3380);

                    switch (f_1523_2944_2962(type))
                    {

                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Double:
                        case TypeCode.Single:
                        case TypeCode.UInt16:
                        case TypeCode.UInt32:
                        case TypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 2936, 3380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3349, 3361);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 2936, 3380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 2886, 3395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3411, 3424);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 2771, 3435);

                System.Type
                f_1523_2847_2871(System.Type
                type)
                {
                    var return_v = type.GetNonNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 2847, 2871);
                    return return_v;
                }


                bool
                f_1523_2890_2902_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 2890, 2902);
                    return return_v;
                }


                System.TypeCode
                f_1523_2944_2962(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 2944, 2962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 2771, 3435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 2771, 3435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 417, 3442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 417, 3442);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 417, 3442);
        }

    }
    internal static class ArrayUtils
    {
        internal static T[] AddLast<T>(this IList<T> list, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 3499, 3721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3582, 3614);

                T[]
                res = new T[f_1523_3598_3608(list) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3628, 3648);

                f_1523_3628_3647(list, res, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3662, 3685);

                res[f_1523_3666_3676(list)] = item;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3699, 3710);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 3499, 3721);

                int
                f_1523_3598_3608(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 3598, 3608);
                    return return_v;
                }


                int
                f_1523_3628_3647(System.Collections.Generic.IList<T>
                this_param, T[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 3628, 3647);
                    return 0;
                }


                int
                f_1523_3666_3676(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 3666, 3676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 3499, 3721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 3499, 3721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 3450, 3728);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 3450, 3728);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 3450, 3728);
        }

    }
    internal static partial class DelegateHelpers
    {
        private const int
        MaximumArity = 17
        ;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
        internal static Type MakeDelegate(Type[] types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 4089, 8707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4410, 4458);

                f_1523_4410_4457(types != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 4423, 4456) && f_1523_4440_4452(types) > 0));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4632, 4820) || true) && (f_1523_4636_4648(types) > MaximumArity || (DynAbs.Tracing.TraceSender.Expression_False(1523, 4636, 4692) || f_1523_4667_4692(types, t => t.IsByRef)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 4632, 4820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4726, 4751);

                    throw f_1523_4732_4750();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 4632, 4820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4836, 4878);

                Type
                returnType = types[f_1523_4860_4872(types) - 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4892, 8655) || true) && (returnType == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 4892, 8655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 4956, 4998);

                    f_1523_4956_4997(ref types, f_1523_4980_4992(types) - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5016, 6793);

                    switch (f_1523_5024_5036(types))
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5086, 5108);

                            return typeof(Action);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5350, 5397);

                            return f_1523_5357_5396(typeof(Action<>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5427, 5475);

                            return f_1523_5434_5474(typeof(Action<,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5505, 5554);

                            return f_1523_5512_5553(typeof(Action<,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 4:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5584, 5634);

                            return f_1523_5591_5633(typeof(Action<,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 5:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5664, 5715);

                            return f_1523_5671_5714(typeof(Action<,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 6:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5745, 5797);

                            return f_1523_5752_5796(typeof(Action<,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 7:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5827, 5880);

                            return f_1523_5834_5879(typeof(Action<,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5910, 5964);

                            return f_1523_5917_5963(typeof(Action<,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 9:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 5994, 6049);

                            return f_1523_6001_6048(typeof(Action<,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 10:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6080, 6136);

                            return f_1523_6087_6135(typeof(Action<,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 11:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6167, 6224);

                            return f_1523_6174_6223(typeof(Action<,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 12:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6255, 6313);

                            return f_1523_6262_6312(typeof(Action<,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 13:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6344, 6403);

                            return f_1523_6351_6402(typeof(Action<,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 14:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6434, 6494);

                            return f_1523_6441_6493(typeof(Action<,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 15:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6525, 6586);

                            return f_1523_6532_6585(typeof(Action<,,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                        case 16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 5016, 6793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6617, 6679);

                            return f_1523_6624_6678(typeof(Action<,,,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 5016, 6793);

                            // *** END GENERATED CODE ***

                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 4892, 8655);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 4892, 8655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 6859, 8640);

                    switch (f_1523_6867_6879(types))
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7137, 7182);

                            return f_1523_7144_7181(typeof(Func<>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7212, 7258);

                            return f_1523_7219_7257(typeof(Func<,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7288, 7335);

                            return f_1523_7295_7334(typeof(Func<,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 4:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7365, 7413);

                            return f_1523_7372_7412(typeof(Func<,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 5:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7443, 7492);

                            return f_1523_7450_7491(typeof(Func<,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 6:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7522, 7572);

                            return f_1523_7529_7571(typeof(Func<,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 7:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7602, 7653);

                            return f_1523_7609_7652(typeof(Func<,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7683, 7735);

                            return f_1523_7690_7734(typeof(Func<,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 9:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7765, 7818);

                            return f_1523_7772_7817(typeof(Func<,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 10:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7849, 7903);

                            return f_1523_7856_7902(typeof(Func<,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 11:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 7934, 7989);

                            return f_1523_7941_7988(typeof(Func<,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 12:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8020, 8076);

                            return f_1523_8027_8075(typeof(Func<,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 13:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8107, 8164);

                            return f_1523_8114_8163(typeof(Func<,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 14:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8195, 8253);

                            return f_1523_8202_8252(typeof(Func<,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 15:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8284, 8343);

                            return f_1523_8291_8342(typeof(Func<,,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8374, 8434);

                            return f_1523_8381_8433(typeof(Func<,,,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                        case 17:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 6859, 8640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8465, 8526);

                            return f_1523_8472_8525(typeof(Func<,,,,,,,,,,,,,,,,>), types);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 6859, 8640);

                            // *** END GENERATED CODE ***

                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 4892, 8655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8671, 8696);

                throw f_1523_8677_8695();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 4089, 8707);

                int
                f_1523_4440_4452(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 4440, 4452);
                    return return_v;
                }


                int
                f_1523_4410_4457(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 4410, 4457);
                    return 0;
                }


                int
                f_1523_4636_4648(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 4636, 4648);
                    return return_v;
                }


                bool
                f_1523_4667_4692(System.Type[]
                source, System.Func<System.Type, bool>
                predicate)
                {
                    var return_v = source.Any<System.Type>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 4667, 4692);
                    return return_v;
                }


                System.Exception
                f_1523_4732_4750()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 4732, 4750);
                    return return_v;
                }


                int
                f_1523_4860_4872(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 4860, 4872);
                    return return_v;
                }


                int
                f_1523_4980_4992(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 4980, 4992);
                    return return_v;
                }


                int
                f_1523_4956_4997(ref System.Type[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 4956, 4997);
                    return 0;
                }


                int
                f_1523_5024_5036(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 5024, 5036);
                    return return_v;
                }


                System.Type
                f_1523_5357_5396(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5357, 5396);
                    return return_v;
                }


                System.Type
                f_1523_5434_5474(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5434, 5474);
                    return return_v;
                }


                System.Type
                f_1523_5512_5553(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5512, 5553);
                    return return_v;
                }


                System.Type
                f_1523_5591_5633(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5591, 5633);
                    return return_v;
                }


                System.Type
                f_1523_5671_5714(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5671, 5714);
                    return return_v;
                }


                System.Type
                f_1523_5752_5796(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5752, 5796);
                    return return_v;
                }


                System.Type
                f_1523_5834_5879(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5834, 5879);
                    return return_v;
                }


                System.Type
                f_1523_5917_5963(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 5917, 5963);
                    return return_v;
                }


                System.Type
                f_1523_6001_6048(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6001, 6048);
                    return return_v;
                }


                System.Type
                f_1523_6087_6135(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6087, 6135);
                    return return_v;
                }


                System.Type
                f_1523_6174_6223(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6174, 6223);
                    return return_v;
                }


                System.Type
                f_1523_6262_6312(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6262, 6312);
                    return return_v;
                }


                System.Type
                f_1523_6351_6402(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6351, 6402);
                    return return_v;
                }


                System.Type
                f_1523_6441_6493(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6441, 6493);
                    return return_v;
                }


                System.Type
                f_1523_6532_6585(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6532, 6585);
                    return return_v;
                }


                System.Type
                f_1523_6624_6678(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 6624, 6678);
                    return return_v;
                }


                int
                f_1523_6867_6879(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 6867, 6879);
                    return return_v;
                }


                System.Type
                f_1523_7144_7181(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7144, 7181);
                    return return_v;
                }


                System.Type
                f_1523_7219_7257(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7219, 7257);
                    return return_v;
                }


                System.Type
                f_1523_7295_7334(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7295, 7334);
                    return return_v;
                }


                System.Type
                f_1523_7372_7412(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7372, 7412);
                    return return_v;
                }


                System.Type
                f_1523_7450_7491(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7450, 7491);
                    return return_v;
                }


                System.Type
                f_1523_7529_7571(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7529, 7571);
                    return return_v;
                }


                System.Type
                f_1523_7609_7652(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7609, 7652);
                    return return_v;
                }


                System.Type
                f_1523_7690_7734(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7690, 7734);
                    return return_v;
                }


                System.Type
                f_1523_7772_7817(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7772, 7817);
                    return return_v;
                }


                System.Type
                f_1523_7856_7902(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7856, 7902);
                    return return_v;
                }


                System.Type
                f_1523_7941_7988(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 7941, 7988);
                    return return_v;
                }


                System.Type
                f_1523_8027_8075(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8027, 8075);
                    return return_v;
                }


                System.Type
                f_1523_8114_8163(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8114, 8163);
                    return return_v;
                }


                System.Type
                f_1523_8202_8252(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8202, 8252);
                    return return_v;
                }


                System.Type
                f_1523_8291_8342(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8291, 8342);
                    return return_v;
                }


                System.Type
                f_1523_8381_8433(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8381, 8433);
                    return return_v;
                }


                System.Type
                f_1523_8472_8525(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 8472, 8525);
                    return return_v;
                }


                System.Exception
                f_1523_8677_8695()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 8677, 8695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 4089, 8707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 4089, 8707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DelegateHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 3736, 8714);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 3996, 4013);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 3736, 8714);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 3736, 8714);
        }

    }
    internal class ScriptingRuntimeHelpers
    {
        internal static object Int32ToObject(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 8777, 8865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8845, 8854);

                return i;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 8777, 8865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 8777, 8865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 8777, 8865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BooleanToObject(bool b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 8877, 8983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 8948, 8972);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1523, 8955, 8956) || ((b && DynAbs.Tracing.TraceSender.Conditional_F2(1523, 8959, 8963)) || DynAbs.Tracing.TraceSender.Conditional_F3(1523, 8966, 8971))) ? True : False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 8877, 8983);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 8877, 8983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 8877, 8983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static readonly MethodInfo BooleanToObjectMethod;

        internal static readonly MethodInfo Int32ToObjectMethod;

        internal static object True;

        internal static object False;

        internal static object GetPrimitiveDefaultValue(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 9349, 10681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9432, 10670);

                switch (f_1523_9440_9458(type))
                {

                    case TypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9515, 9552);

                        return ScriptingRuntimeHelpers.False;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9591, 9613);

                        return default(sbyte);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9651, 9672);

                        return default(byte);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9710, 9731);

                        return default(char);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9770, 9792);

                        return default(Int16);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9831, 9879);

                        return f_1523_9838_9878(0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9918, 9940);

                        return default(Int64);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9980, 10003);

                        return default(UInt16);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10043, 10066);

                        return default(UInt32);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10106, 10129);

                        return default(UInt64);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10169, 10192);

                        return default(Single);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10232, 10255);

                        return default(double);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10297, 10322);

                        return default(DateTime);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    case TypeCode.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10363, 10387);

                        return default(Decimal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 9432, 10670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 10643, 10655);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 9432, 10670);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 9349, 10681);

                System.TypeCode
                f_1523_9440_9458(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 9440, 9458);
                    return return_v;
                }


                object
                f_1523_9838_9878(int
                i)
                {
                    var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 9838, 9878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 9349, 10681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 9349, 10681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ScriptingRuntimeHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 8722, 10688);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 8722, 10688);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 8722, 10688);
        }


        static ScriptingRuntimeHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 8722, 10688);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9031, 9115);
            BooleanToObjectMethod = f_1523_9055_9115(typeof(ScriptingRuntimeHelpers), "BooleanToObject");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9162, 9242);
            Int32ToObjectMethod = f_1523_9184_9242(typeof(ScriptingRuntimeHelpers), "Int32ToObject");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9278, 9289);
            True = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 9323, 9336);
            False = false;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 8722, 10688);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 8722, 10688);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 8722, 10688);

        static System.Reflection.MethodInfo?
        f_1523_9055_9115(System.Type
        this_param, string
        name)
        {
            var return_v = this_param.GetMethod(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 9055, 9115);
            return return_v;
        }


        static System.Reflection.MethodInfo?
        f_1523_9184_9242(System.Type
        this_param, string
        name)
        {
            var return_v = this_param.GetMethod(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 9184, 9242);
            return return_v;
        }

    }
    internal sealed class ArgumentArray
    {
        private readonly object[] _arguments;

        private readonly int _first;

        internal ArgumentArray(object[] arguments, int first, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 11280, 11460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11059, 11069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11183, 11189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11472, 11497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11369, 11392);

                _arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11406, 11421);

                _first = first;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11435, 11449);

                Count = count;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 11280, 11460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 11280, 11460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 11280, 11460);
            }
        }

        public int Count { get; }

        public object GetArgument(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 11509, 11693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11648, 11682);

                return _arguments[_first + index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 11509, 11693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 11509, 11693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 11509, 11693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DynamicMetaObject GetMetaObject(Expression parameter, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 11705, 12106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 11801, 12095);

                return f_1523_11808_12094(f_1523_11851_11869(this, index), f_1523_11888_12079(s_getArgMethod, f_1523_11963_12013(parameter, typeof(ArgumentArray)), f_1523_12036_12060(index)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 11705, 12106);

                object
                f_1523_11851_11869(System.Management.Automation.Interpreter.ArgumentArray
                this_param, int
                index)
                {
                    var return_v = this_param.GetArgument(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 11851, 11869);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1523_11963_12013(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = AstUtils.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 11963, 12013);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1523_12036_12060(int
                value)
                {
                    var return_v = AstUtils.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 12036, 12060);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1523_11888_12079(System.Reflection.MethodInfo
                method, System.Linq.Expressions.Expression
                arg0, System.Linq.Expressions.Expression
                arg1)
                {
                    var return_v = Expression.Call(method, arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 11888, 12079);
                    return return_v;
                }


                System.Dynamic.DynamicMetaObject
                f_1523_11808_12094(object
                value, System.Linq.Expressions.MethodCallExpression
                expression)
                {
                    var return_v = DynamicMetaObject.Create(value, (System.Linq.Expressions.Expression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 11808, 12094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 11705, 12106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 11705, 12106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object GetArg(ArgumentArray array, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 12152, 12293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 12236, 12282);

                return array._arguments[array._first + index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 12152, 12293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 12152, 12293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 12152, 12293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly MethodInfo s_getArgMethod;

        static ArgumentArray()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 10981, 12425);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 12340, 12417);
            s_getArgMethod = f_1523_12357_12417(new Func<ArgumentArray, int, object>(GetArg));
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 10981, 12425);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 10981, 12425);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 10981, 12425);

        static System.Reflection.MethodInfo?
        f_1523_12357_12417(System.Func<System.Management.Automation.Interpreter.ArgumentArray, int, object>
        del)
        {
            var return_v = del.GetMethodInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 12357, 12417);
            return return_v;
        }

    }
    internal static class ExceptionHelpers
    {
        private const string
        prevStackTraces = "PreviousStackTraces"
        ;

        public static Exception UpdateForRethrow(Exception rethrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 12741, 13335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 12843, 12865);

                List<StackTrace>
                prev
                = default(List<StackTrace>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13012, 13058);

                StackTrace
                st = f_1523_13028_13057(rethrow, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13074, 13258) || true) && (!f_1523_13079_13125(rethrow, out prev))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 13074, 13258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13159, 13189);

                    prev = f_1523_13166_13188();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13207, 13243);

                    f_1523_13207_13242(rethrow, prev);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 13074, 13258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13274, 13287);

                f_1523_13274_13286(
                            prev, st);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13309, 13324);

                return rethrow;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 12741, 13335);

                System.Diagnostics.StackTrace
                f_1523_13028_13057(System.Exception
                e, bool
                fNeedFileInfo)
                {
                    var return_v = new System.Diagnostics.StackTrace(e, fNeedFileInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13028, 13057);
                    return return_v;
                }


                bool
                f_1523_13079_13125(System.Exception
                e, out System.Collections.Generic.List<System.Diagnostics.StackTrace>
                traces)
                {
                    var return_v = TryGetAssociatedStackTraces(e, out traces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13079, 13125);
                    return return_v;
                }


                System.Collections.Generic.List<System.Diagnostics.StackTrace>
                f_1523_13166_13188()
                {
                    var return_v = new System.Collections.Generic.List<System.Diagnostics.StackTrace>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13166, 13188);
                    return return_v;
                }


                int
                f_1523_13207_13242(System.Exception
                e, System.Collections.Generic.List<System.Diagnostics.StackTrace>
                traces)
                {
                    AssociateStackTraces(e, traces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13207, 13242);
                    return 0;
                }


                int
                f_1523_13274_13286(System.Collections.Generic.List<System.Diagnostics.StackTrace>
                this_param, System.Diagnostics.StackTrace
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13274, 13286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 12741, 13335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 12741, 13335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IList<StackTrace> GetExceptionStackTraces(Exception rethrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 13466, 13686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13565, 13589);

                List<StackTrace>
                result
                = default(List<StackTrace>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13603, 13675);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1523, 13610, 13658) || ((f_1523_13610_13658(rethrow, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(1523, 13661, 13667)) || DynAbs.Tracing.TraceSender.Conditional_F3(1523, 13670, 13674))) ? result : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 13466, 13686);

                bool
                f_1523_13610_13658(System.Exception
                e, out System.Collections.Generic.List<System.Diagnostics.StackTrace>
                traces)
                {
                    var return_v = TryGetAssociatedStackTraces(e, out traces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 13610, 13658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 13466, 13686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 13466, 13686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AssociateStackTraces(Exception e, List<StackTrace> traces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 13698, 13845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13801, 13834);

                f_1523_13801_13807(e)[prevStackTraces] = traces;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 13698, 13845);

                System.Collections.IDictionary
                f_1523_13801_13807(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 13801, 13807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 13698, 13845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 13698, 13845);
            }
        }

        private static bool TryGetAssociatedStackTraces(Exception e, out List<StackTrace> traces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 13857, 14071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 13971, 14024);

                traces = f_1523_13980_14003(f_1523_13980_13986(e), prevStackTraces) as List<StackTrace>;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14038, 14060);

                return traces != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 13857, 14071);

                System.Collections.IDictionary
                f_1523_13980_13986(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 13980, 13986);
                    return return_v;
                }


                object
                f_1523_13980_14003(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 13980, 14003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 13857, 14071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 13857, 14071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExceptionHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 12433, 14078);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 12509, 12548);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 12433, 14078);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 12433, 14078);
        }

    }
    internal class HybridReferenceDictionary<TKey, TValue> where TKey : class
    {
        private KeyValuePair<TKey, TValue>[] _keysAndValues;

        private Dictionary<TKey, TValue> _dict;

        private int _count;

        private const int
        _arraySize = 10
        ;

        public HybridReferenceDictionary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 14473, 14529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14324, 14338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14382, 14387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14410, 14416);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 14473, 14529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 14473, 14529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 14473, 14529);
            }
        }

        public HybridReferenceDictionary(int initialCapacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 14541, 14896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14324, 14338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14382, 14387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14410, 14416);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14619, 14885) || true) && (initialCapacity > _arraySize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 14619, 14885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14685, 14739);

                    _dict = f_1523_14693_14738(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 14619, 14885);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 14619, 14885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14805, 14870);

                    _keysAndValues = new KeyValuePair<TKey, TValue>[initialCapacity];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 14619, 14885);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 14541, 14896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 14541, 14896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 14541, 14896);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 14908, 15587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14984, 15010);

                f_1523_14984_15009(key != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15026, 15509) || true) && (_dict != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15026, 15509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15077, 15118);

                    return f_1523_15084_15117(_dict, key, out value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15026, 15509);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15026, 15509);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15152, 15509) || true) && (_keysAndValues != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15152, 15509);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15221, 15226);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15212, 15494) || true) && (i < f_1523_15232_15253(_keysAndValues))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15255, 15258)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15212, 15494))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15212, 15494);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15300, 15475) || true) && (_keysAndValues[i].Key == key)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15300, 15475);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15382, 15414);

                                    value = _keysAndValues[i].Value;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15440, 15452);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15300, 15475);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 283);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 283);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15152, 15509);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15026, 15509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15525, 15549);

                value = default(TValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15563, 15576);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 14908, 15587);

                int
                f_1523_14984_15009(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 14984, 15009);
                    return 0;
                }


                bool
                f_1523_15084_15117(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key, out TValue
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 15084, 15117);
                    return return_v;
                }


                int
                f_1523_15232_15253(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 15232, 15253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 14908, 15587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 14908, 15587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Remove(TKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 15599, 16257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15652, 15678);

                f_1523_15652_15677(key != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15694, 16217) || true) && (_dict != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15694, 16217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15745, 15770);

                    return f_1523_15752_15769(_dict, key);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15694, 16217);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15694, 16217);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15804, 16217) || true) && (_keysAndValues != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15804, 16217);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15873, 15878);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15864, 16202) || true) && (i < f_1523_15884_15905(_keysAndValues))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15907, 15910)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15864, 16202))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15864, 16202);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 15952, 16183) || true) && (_keysAndValues[i].Key == key)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 15952, 16183);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16034, 16087);

                                    _keysAndValues[i] = f_1523_16054_16086();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16113, 16122);

                                    _count--;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16148, 16160);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15952, 16183);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 339);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 339);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15804, 16217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 15694, 16217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16233, 16246);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 15599, 16257);

                int
                f_1523_15652_15677(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 15652, 15677);
                    return 0;
                }


                bool
                f_1523_15752_15769(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 15752, 15769);
                    return return_v;
                }


                int
                f_1523_15884_15905(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 15884, 15905);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<TKey, TValue>
                f_1523_16054_16086()
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<TKey, TValue>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 16054, 16086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 15599, 16257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 15599, 16257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContainsKey(TKey key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 16269, 16823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16327, 16353);

                f_1523_16327_16352(key != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16369, 16783) || true) && (_dict != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16369, 16783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16420, 16450);

                    return f_1523_16427_16449(_dict, key);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16369, 16783);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16369, 16783);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16484, 16783) || true) && (_keysAndValues != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16484, 16783);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16553, 16558);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16544, 16768) || true) && (i < f_1523_16564_16585(_keysAndValues))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16587, 16590)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16544, 16768))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16544, 16768);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16632, 16749) || true) && (_keysAndValues[i].Key == key)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16632, 16749);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16714, 16726);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16632, 16749);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 225);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 225);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16484, 16783);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16369, 16783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16799, 16812);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 16269, 16823);

                int
                f_1523_16327_16352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 16327, 16352);
                    return 0;
                }


                bool
                f_1523_16427_16449(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param, TKey
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 16427, 16449);
                    return return_v;
                }


                int
                f_1523_16564_16585(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 16564, 16585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 16269, 16823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 16269, 16823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 16876, 17058);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16912, 17009) || true) && (_dict != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 16912, 17009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 16971, 16990);

                        return f_1523_16978_16989(_dict);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 16912, 17009);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17029, 17043);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 16876, 17058);

                    int
                    f_1523_16978_16989(System.Collections.Generic.Dictionary<TKey, TValue>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 16978, 16989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 16835, 17069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 16835, 17069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 17081, 17319);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17168, 17263) || true) && (_dict != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 17168, 17263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17219, 17248);

                    return f_1523_17226_17247(_dict);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 17168, 17263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17279, 17308);

                return f_1523_17286_17307(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 17081, 17319);

                System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator
                f_1523_17226_17247(System.Collections.Generic.Dictionary<TKey, TValue>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 17226, 17247);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                f_1523_17286_17307(System.Management.Automation.Interpreter.HybridReferenceDictionary<TKey, TValue>
                this_param)
                {
                    var return_v = this_param.GetEnumeratorWorker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 17286, 17307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 17081, 17319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 17081, 17319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 17331, 17755);

                var listYield = new List<KeyValuePair<TKey, TValue>>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17425, 17744) || true) && (_keysAndValues != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 17425, 17744);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17494, 17499);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17485, 17729) || true) && (i < f_1523_17505_17526(_keysAndValues))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17528, 17531)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 17485, 17729))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 17485, 17729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17573, 17710) || true) && (_keysAndValues[i].Key != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 17573, 17710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17656, 17687);

                                listYield.Add(_keysAndValues[i]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 17573, 17710);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 17425, 17744);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 17331, 17755);

                return listYield.GetEnumerator();

                int
                f_1523_17505_17526(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 17505, 17526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 17331, 17755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 17331, 17755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TValue this[TKey key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 17820, 18100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17856, 17882);

                    f_1523_17856_17881(key != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17902, 17913);

                    TValue
                    res
                    = default(TValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 17931, 18032) || true) && (f_1523_17935_17960(this, key, out res))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 17931, 18032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18002, 18013);

                        return res;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 17931, 18032);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18052, 18085);

                    throw f_1523_18058_18084();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 17820, 18100);

                    int
                    f_1523_17856_17881(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 17856, 17881);
                        return 0;
                    }


                    bool
                    f_1523_17935_17960(System.Management.Automation.Interpreter.HybridReferenceDictionary<TKey, TValue>
                    this_param, TKey
                    key, out TValue
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 17935, 17960);
                        return return_v;
                    }


                    System.Collections.Generic.KeyNotFoundException
                    f_1523_18058_18084()
                    {
                        var return_v = new System.Collections.Generic.KeyNotFoundException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 18058, 18084);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 17820, 18100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 17820, 18100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 18116, 19953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18152, 18178);

                    f_1523_18152_18177(key != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18198, 19938) || true) && (_dict != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18198, 19938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18257, 18276);

                        _dict[key] = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18198, 19938);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18198, 19938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18358, 18368);

                        int
                        index
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18390, 19259) || true) && (_keysAndValues != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18390, 19259);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18466, 18477);

                            index = -1;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18512, 18517);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18503, 19042) || true) && (i < f_1523_18523_18544(_keysAndValues))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18546, 18549)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18503, 19042))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18503, 19042);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18607, 19015) || true) && (_keysAndValues[i].Key == key)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18607, 19015);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18705, 18768);

                                        _keysAndValues[i] = f_1523_18725_18767(key, value);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18802, 18809);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18607, 19015);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18607, 19015);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18875, 19015) || true) && (_keysAndValues[i].Key == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18875, 19015);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 18974, 18984);

                                            index = i;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18875, 19015);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18607, 19015);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 540);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 540);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18390, 19259);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 18390, 19259);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19140, 19200);

                            _keysAndValues = new KeyValuePair<TKey, TValue>[_arraySize];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19226, 19236);

                            index = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18390, 19259);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19283, 19919) || true) && (index != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 19283, 19919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19348, 19357);

                            _count++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19383, 19450);

                            _keysAndValues[index] = f_1523_19407_19449(key, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 19283, 19919);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 19283, 19919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19548, 19587);

                            _dict = f_1523_19556_19586();
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19622, 19627);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19613, 19799) || true) && (i < f_1523_19633_19654(_keysAndValues))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19656, 19659)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 19613, 19799))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 19613, 19799);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19717, 19772);

                                    _dict[_keysAndValues[i].Key] = _keysAndValues[i].Value;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 187);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 187);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19827, 19849);

                            _keysAndValues = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 19877, 19896);

                            _dict[key] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 19283, 19919);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 18198, 19938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 18116, 19953);

                    int
                    f_1523_18152_18177(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 18152, 18177);
                        return 0;
                    }


                    int
                    f_1523_18523_18544(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 18523, 18544);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<TKey, TValue>
                    f_1523_18725_18767(TKey
                    key, TValue
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<TKey, TValue>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 18725, 18767);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<TKey, TValue>
                    f_1523_19407_19449(TKey
                    key, TValue
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<TKey, TValue>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 19407, 19449);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<TKey, TValue>
                    f_1523_19556_19586()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<TKey, TValue>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 19556, 19586);
                        return return_v;
                    }


                    int
                    f_1523_19633_19654(System.Collections.Generic.KeyValuePair<TKey, TValue>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 19633, 19654);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 18116, 19953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 18116, 19953);
                }
            }
        }

        static HybridReferenceDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 14197, 19971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 14445, 14460);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 14197, 19971);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 14197, 19971);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 14197, 19971);

        System.Collections.Generic.Dictionary<TKey, TValue>
        f_1523_14693_14738(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<TKey, TValue>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 14693, 14738);
            return return_v;
        }

    }
    internal class CacheDict<TKey, TValue>
    {
        private readonly Dictionary<TKey, KeyInfo> _dict;

        private readonly LinkedList<TKey> _list;

        private readonly int _maxSize;

        public CacheDict(int maxSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 20672, 20756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 20311, 20350);
                this._dict = f_1523_20319_20350();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 20395, 20425);
                this._list = f_1523_20403_20425();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 20457, 20465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 20726, 20745);

                _maxSize = maxSize;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 20672, 20756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 20672, 20756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 20672, 20756);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 20947, 21573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21023, 21043);

                KeyInfo
                storedValue
                = default(KeyInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21057, 21495) || true) && (f_1523_21061_21100(_dict, key, out storedValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 21057, 21495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21134, 21179);

                    LinkedListNode<TKey>
                    node = storedValue.List
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21197, 21404) || true) && (f_1523_21201_21214(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 21197, 21404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21323, 21342);

                        f_1523_21323_21341(                    // move us to the head of the list...
                                            _list, node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21364, 21385);

                        f_1523_21364_21384(_list, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 21197, 21404);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21424, 21450);

                    value = storedValue.Value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21468, 21480);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 21057, 21495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21511, 21535);

                value = default(TValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21549, 21562);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 20947, 21573);

                bool
                f_1523_21061_21100(System.Collections.Generic.Dictionary<TKey, System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo>
                this_param, TKey
                key, out System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 21061, 21100);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<TKey>
                f_1523_21201_21214(System.Collections.Generic.LinkedListNode<TKey>
                this_param)
                {
                    var return_v = this_param.Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 21201, 21214);
                    return return_v;
                }


                int
                f_1523_21323_21341(System.Collections.Generic.LinkedList<TKey>
                this_param, System.Collections.Generic.LinkedListNode<TKey>
                node)
                {
                    this_param.Remove(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 21323, 21341);
                    return 0;
                }


                int
                f_1523_21364_21384(System.Collections.Generic.LinkedList<TKey>
                this_param, System.Collections.Generic.LinkedListNode<TKey>
                node)
                {
                    this_param.AddFirst(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 21364, 21384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 20947, 21573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 20947, 21573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(TKey key, TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 21763, 22662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21827, 21843);

                KeyInfo
                keyInfo
                = default(KeyInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21857, 22372) || true) && (f_1523_21861_21896(_dict, key, out keyInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 21857, 22372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 21993, 22020);

                    f_1523_21993_22019(                // remove original entry from the linked list
                                    _list, keyInfo.List);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 21857, 22372);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 21857, 22372);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22054, 22372) || true) && (f_1523_22058_22069(_list) == _maxSize)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 22054, 22372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22191, 22230);

                        LinkedListNode<TKey>
                        node = f_1523_22219_22229(_list)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22248, 22267);

                        f_1523_22248_22266(_list);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22285, 22321);

                        bool
                        res = f_1523_22296_22320(_dict, f_1523_22309_22319(node))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22339, 22357);

                        f_1523_22339_22356(res);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 22054, 22372);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 21857, 22372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22470, 22532);

                LinkedListNode<TKey>
                listNode = f_1523_22502_22531(key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22546, 22571);

                f_1523_22546_22570(_list, listNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 22585, 22651);

                _dict[key] = f_1523_22598_22650(value, listNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 21763, 22662);

                bool
                f_1523_21861_21896(System.Collections.Generic.Dictionary<TKey, System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo>
                this_param, TKey
                key, out System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 21861, 21896);
                    return return_v;
                }


                int
                f_1523_21993_22019(System.Collections.Generic.LinkedList<TKey>
                this_param, System.Collections.Generic.LinkedListNode<TKey>
                node)
                {
                    this_param.Remove(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 21993, 22019);
                    return 0;
                }


                int
                f_1523_22058_22069(System.Collections.Generic.LinkedList<TKey>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 22058, 22069);
                    return return_v;
                }


                System.Collections.Generic.LinkedListNode<TKey>
                f_1523_22219_22229(System.Collections.Generic.LinkedList<TKey>
                this_param)
                {
                    var return_v = this_param.Last;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 22219, 22229);
                    return return_v;
                }


                int
                f_1523_22248_22266(System.Collections.Generic.LinkedList<TKey>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22248, 22266);
                    return 0;
                }


                TKey
                f_1523_22309_22319(System.Collections.Generic.LinkedListNode<TKey>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 22309, 22319);
                    return return_v;
                }


                bool
                f_1523_22296_22320(System.Collections.Generic.Dictionary<TKey, System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo>
                this_param, TKey
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22296, 22320);
                    return return_v;
                }


                int
                f_1523_22339_22356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22339, 22356);
                    return 0;
                }


                System.Collections.Generic.LinkedListNode<TKey>
                f_1523_22502_22531(TKey
                value)
                {
                    var return_v = new System.Collections.Generic.LinkedListNode<TKey>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22502, 22531);
                    return return_v;
                }


                int
                f_1523_22546_22570(System.Collections.Generic.LinkedList<TKey>
                this_param, System.Collections.Generic.LinkedListNode<TKey>
                node)
                {
                    this_param.AddFirst(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22546, 22570);
                    return 0;
                }


                System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo
                f_1523_22598_22650(TValue
                value, System.Collections.Generic.LinkedListNode<TKey>
                list)
                {
                    var return_v = new System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo(value, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 22598, 22650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 21763, 22662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 21763, 22662);
            }
        }

        /// <summary>
        /// Returns the value associated with the given key, or throws KeyNotFoundException
        /// if the key is not present.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
        public TValue this[TKey key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 23038, 23272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23074, 23085);

                    TValue
                    res
                    = default(TValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23103, 23204) || true) && (f_1523_23107_23132(this, key, out res))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 23103, 23204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23174, 23185);

                        return res;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 23103, 23204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23224, 23257);

                    throw f_1523_23230_23256();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 23038, 23272);

                    bool
                    f_1523_23107_23132(System.Management.Automation.Interpreter.CacheDict<TKey, TValue>
                    this_param, TKey
                    key, out TValue
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 23107, 23132);
                        return return_v;
                    }


                    System.Collections.Generic.KeyNotFoundException
                    f_1523_23230_23256()
                    {
                        var return_v = new System.Collections.Generic.KeyNotFoundException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 23230, 23256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 23038, 23272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 23038, 23272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 23288, 23355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23324, 23340);

                    f_1523_23324_23339(this, key, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 23288, 23355);

                    int
                    f_1523_23324_23339(System.Management.Automation.Interpreter.CacheDict<TKey, TValue>
                    this_param, TKey
                    key, TValue
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 23324, 23339);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 23288, 23355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 23288, 23355);
                }
            }
        }

        private struct KeyInfo
        {

            internal readonly TValue Value;

            internal readonly LinkedListNode<TKey> List;

            internal KeyInfo(TValue value, LinkedListNode<TKey> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 23530, 23679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23620, 23634);

                    Value = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23652, 23664);

                    List = list;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 23530, 23679);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 23530, 23679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 23530, 23679);
                }
            }
            static KeyInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 23378, 23690);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 23378, 23690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 23378, 23690);
            }
        }

        static CacheDict()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 20213, 23697);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 20213, 23697);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 20213, 23697);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 20213, 23697);

        System.Collections.Generic.Dictionary<TKey, System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo>
        f_1523_20319_20350()
        {
            var return_v = new System.Collections.Generic.Dictionary<TKey, System.Management.Automation.Interpreter.CacheDict<TKey, TValue>.KeyInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 20319, 20350);
            return return_v;
        }


        System.Collections.Generic.LinkedList<TKey>
        f_1523_20403_20425()
        {
            var return_v = new System.Collections.Generic.LinkedList<TKey>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 20403, 20425);
            return return_v;
        }

    }
    internal class ThreadLocal<T>
    {
        private StorageInfo[] _stores;

        private static readonly StorageInfo[] s_updating;

        private readonly bool _refCounted;

        public ThreadLocal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 24057, 24099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23773, 23780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 24033, 24044);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 24057, 24099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 24057, 24099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 24057, 24099);
            }
        }

        public ThreadLocal(bool refCounted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 24690, 24786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23773, 23780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 24033, 24044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 24750, 24775);

                _refCounted = refCounted;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 24690, 24786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 24690, 24786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 24690, 24786);
            }
        }

        public T Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 24974, 25055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25010, 25040);

                    return f_1523_25017_25033(this).Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 24974, 25055);

                    System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                    f_1523_25017_25033(System.Management.Automation.Interpreter.ThreadLocal<T>
                    this_param)
                    {
                        var return_v = this_param.GetStorageInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25017, 25033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 24935, 25164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 24935, 25164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 25071, 25153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25107, 25138);

                    f_1523_25107_25123(this).Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 25071, 25153);

                    System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                    f_1523_25107_25123(System.Management.Automation.Interpreter.ThreadLocal<T>
                    this_param)
                    {
                        var return_v = this_param.GetStorageInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25107, 25123);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 24935, 25164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 24935, 25164);
                }
            }
        }

        public T GetOrCreate(Func<T> func)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 25345, 25646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25404, 25425);

                f_1523_25404_25424(func);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25441, 25475);

                StorageInfo
                si = f_1523_25458_25474(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25489, 25506);

                T
                res = si.Value
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25520, 25608) || true) && (res == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 25520, 25608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25569, 25593);

                    si.Value = res = f_1523_25586_25592(func);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 25520, 25608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25624, 25635);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 25345, 25646);

                int
                f_1523_25404_25424(System.Func<T>
                var)
                {
                    Assert.NotNull((object)var);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25404, 25424);
                    return 0;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_25458_25474(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param)
                {
                    var return_v = this_param.GetStorageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25458, 25474);
                    return return_v;
                }


                T
                f_1523_25586_25592(System.Func<T>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25586, 25592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 25345, 25646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 25345, 25646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public T Update(Func<T, T> updater)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 25853, 26048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25913, 25937);

                f_1523_25913_25936(updater);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 25953, 25987);

                StorageInfo
                si = f_1523_25970_25986(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26001, 26037);

                return si.Value = f_1523_26019_26036(updater, si.Value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 25853, 26048);

                int
                f_1523_25913_25936(System.Func<T, T>
                var)
                {
                    Assert.NotNull((object)var);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25913, 25936);
                    return 0;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_25970_25986(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param)
                {
                    var return_v = this_param.GetStorageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 25970, 25986);
                    return return_v;
                }


                T
                f_1523_26019_26036(System.Func<T, T>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 26019, 26036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 25853, 26048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 25853, 26048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public T Update(T newValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 26189, 26388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26241, 26275);

                StorageInfo
                si = f_1523_26258_26274(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26289, 26313);

                var
                oldValue = si.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26327, 26347);

                si.Value = newValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26361, 26377);

                return oldValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 26189, 26388);

                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_26258_26274(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param)
                {
                    var return_v = this_param.GetStorageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 26258, 26274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 26189, 26388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 26189, 26388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public StorageInfo GetStorageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 26569, 26671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26629, 26660);

                return f_1523_26636_26659(this, _stores);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 26569, 26671);

                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_26636_26659(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param, System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                curStorage)
                {
                    var return_v = this_param.GetStorageInfo(curStorage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 26636, 26659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 26569, 26671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 26569, 26671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StorageInfo GetStorageInfo(StorageInfo[] curStorage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 26683, 27277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26768, 26820);

                int
                threadId = f_1523_26783_26819(f_1523_26783_26803())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26902, 27206) || true) && (curStorage != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 26906, 26956) && f_1523_26928_26945(curStorage) > threadId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 26902, 27206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 26990, 27029);

                    StorageInfo
                    res = curStorage[threadId]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27049, 27191) || true) && (res != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 27053, 27119) && (_refCounted || (DynAbs.Tracing.TraceSender.Expression_False(1523, 27069, 27118) || res.Thread == f_1523_27098_27118()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 27049, 27191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27161, 27172);

                        return res;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 27049, 27191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 26902, 27206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27222, 27266);

                return f_1523_27229_27265(this, curStorage);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 26683, 27277);

                System.Threading.Thread
                f_1523_26783_26803()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 26783, 26803);
                    return return_v;
                }


                int
                f_1523_26783_26819(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.ManagedThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 26783, 26819);
                    return return_v;
                }


                int
                f_1523_26928_26945(System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 26928, 26945);
                    return return_v;
                }


                System.Threading.Thread
                f_1523_27098_27118()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 27098, 27118);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_27229_27265(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param, System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                curStorage)
                {
                    var return_v = this_param.RetryOrCreateStorageInfo(curStorage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 27229, 27265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 26683, 27277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 26683, 27277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StorageInfo RetryOrCreateStorageInfo(StorageInfo[] curStorage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 27559, 28153);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27654, 28013) || true) && (curStorage == s_updating)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 27654, 28013);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27753, 27873) || true) && ((curStorage = _stores) == s_updating)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 27753, 27873);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27838, 27854);

                            f_1523_27838_27853(0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 27753, 27873);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 27753, 27873);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 27753, 27873);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 27964, 27998);

                    return f_1523_27971_27997(this, curStorage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 27654, 28013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28115, 28142);

                return f_1523_28122_28141(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 27559, 28153);

                int
                f_1523_27838_27853(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 27838, 27853);
                    return 0;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_27971_27997(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param, System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                curStorage)
                {
                    var return_v = this_param.GetStorageInfo(curStorage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 27971, 27997);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_28122_28141(System.Management.Automation.Interpreter.ThreadLocal<T>
                this_param)
                {
                    var return_v = this_param.CreateStorageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 28122, 28141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 27559, 28153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 27559, 28153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StorageInfo CreateStorageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 28296, 30565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28446, 28475);

                f_1523_28446_28474();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28491, 28529);

                StorageInfo[]
                curStorage = s_updating
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28579, 28631);

                    int
                    threadId = f_1523_28594_28630(f_1523_28594_28614())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28649, 28709);

                    StorageInfo
                    newInfo = f_1523_28671_28708(f_1523_28687_28707())
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 28864, 29084) || true) && ((curStorage = f_1523_28885_28930(ref _stores, s_updating)) == s_updating)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 28864, 29084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29049, 29065);

                            f_1523_29049_29064(0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 28864, 29084);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 28864, 29084);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 28864, 29084);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29187, 29911) || true) && (curStorage == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 29187, 29911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29251, 29294);

                        curStorage = new StorageInfo[threadId + 1];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 29187, 29911);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 29187, 29911);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29336, 29911) || true) && (f_1523_29340_29357(curStorage) <= threadId)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 29336, 29911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29411, 29468);

                            StorageInfo[]
                            newStorage = new StorageInfo[threadId + 1]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29499, 29504);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29490, 29844) || true) && (i < f_1523_29510_29527(curStorage))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29529, 29532)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 29490, 29844))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 29490, 29844);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29649, 29821) || true) && (curStorage[i] != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 29653, 29706) && f_1523_29678_29706(curStorage[i].Thread)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 29649, 29821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29764, 29794);

                                        newStorage[i] = curStorage[i];
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 29649, 29821);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 355);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 355);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 29868, 29892);

                            curStorage = newStorage;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 29336, 29911);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 29187, 29911);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 30072, 30170);

                    f_1523_30072_30169(curStorage[threadId] == null || (DynAbs.Tracing.TraceSender.Expression_False(1523, 30085, 30168) || curStorage[threadId].Thread != f_1523_30148_30168()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 30190, 30228);

                    return curStorage[threadId] = newInfo;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1523, 30257, 30554);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 30297, 30492) || true) && (curStorage != s_updating)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 30297, 30492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 30427, 30473);

                        f_1523_30427_30472(ref _stores, curStorage);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 30297, 30492);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 30512, 30539);

                    f_1523_30512_30538();
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1523, 30257, 30554);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 28296, 30565);

                int
                f_1523_28446_28474()
                {
                    Thread.BeginCriticalRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 28446, 28474);
                    return 0;
                }


                System.Threading.Thread
                f_1523_28594_28614()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 28594, 28614);
                    return return_v;
                }


                int
                f_1523_28594_28630(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.ManagedThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 28594, 28630);
                    return return_v;
                }


                System.Threading.Thread
                f_1523_28687_28707()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 28687, 28707);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo
                f_1523_28671_28708(System.Threading.Thread
                curThread)
                {
                    var return_v = new System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo(curThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 28671, 28708);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                f_1523_28885_28930(ref System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                location1, System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 28885, 28930);
                    return return_v;
                }


                int
                f_1523_29049_29064(int
                millisecondsTimeout)
                {
                    Thread.Sleep(millisecondsTimeout);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 29049, 29064);
                    return 0;
                }


                int
                f_1523_29340_29357(System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 29340, 29357);
                    return return_v;
                }


                int
                f_1523_29510_29527(System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 29510, 29527);
                    return return_v;
                }


                bool
                f_1523_29678_29706(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.IsAlive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 29678, 29706);
                    return return_v;
                }


                System.Threading.Thread
                f_1523_30148_30168()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 30148, 30168);
                    return return_v;
                }


                int
                f_1523_30072_30169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 30072, 30169);
                    return 0;
                }


                System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                f_1523_30427_30472(ref System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                location1, System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 30427, 30472);
                    return return_v;
                }


                int
                f_1523_30512_30538()
                {
                    Thread.EndCriticalRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 30512, 30538);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 28296, 30565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 28296, 30565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")] // TODO
        internal sealed class StorageInfo
        {
            internal readonly Thread Thread;

            public T Value;

            internal StorageInfo(Thread curThread)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 31184, 31335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31002, 31008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31088, 31093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31255, 31281);

                    f_1523_31255_31280(curThread);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31301, 31320);

                    Thread = curThread;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 31184, 31335);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 31184, 31335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 31184, 31335);
                }
            }

            static StorageInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 30792, 31346);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 30792, 31346);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 30792, 31346);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 30792, 31346);

            int
            f_1523_31255_31280(System.Threading.Thread
            var)
            {
                Assert.NotNull((object)var);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 31255, 31280);
                return 0;
            }

        }

        static ThreadLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 23705, 31375);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 23918, 23957);
            s_updating = f_1523_23931_23957();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 23705, 31375);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 23705, 31375);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 23705, 31375);

        static System.Management.Automation.Interpreter.ThreadLocal<T>.StorageInfo[]
        f_1523_23931_23957()
        {
            var return_v = Array.Empty<StorageInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 23931, 23957);
            return return_v;
        }

    }
    internal static class Assert
    {
        internal static Exception Unreachable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 31490, 31666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31526, 31561);

                    f_1523_31526_31560(false, "Unreachable");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31579, 31651);

                    return f_1523_31586_31650("Code supposed to be unreachable");
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 31490, 31666);

                    int
                    f_1523_31526_31560(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 31526, 31560);
                        return 0;
                    }


                    System.InvalidOperationException
                    f_1523_31586_31650(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 31586, 31650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 31428, 31677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 31428, 31677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG")]
        public static void NotNull(object var)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 31689, 31821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31784, 31810);

                f_1523_31784_31809(var != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 31689, 31821);

                int
                f_1523_31784_31809(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 31784, 31809);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 31689, 31821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 31689, 31821);
            }
        }

        [Conditional("DEBUG")]
        public static void NotNull(object var1, object var2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 31833, 31996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 31942, 31985);

                f_1523_31942_31984(var1 != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 31955, 31983) && var2 != null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 31833, 31996);

                int
                f_1523_31942_31984(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 31942, 31984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 31833, 31996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 31833, 31996);
            }
        }

        [Conditional("DEBUG")]
        public static void NotNull(object var1, object var2, object var3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 32008, 32200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32130, 32189);

                f_1523_32130_32188(var1 != null && (DynAbs.Tracing.TraceSender.Expression_True(1523, 32143, 32171) && var2 != null) && (DynAbs.Tracing.TraceSender.Expression_True(1523, 32143, 32187) && var3 != null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 32008, 32200);

                int
                f_1523_32130_32188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32130, 32188);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 32008, 32200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 32008, 32200);
            }
        }

        [Conditional("DEBUG")]
        public static void NotNullItems<T>(IEnumerable<T> items) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 32212, 32499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32341, 32369);

                f_1523_32341_32368(items != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32383, 32488);
                    foreach (object item in f_1523_32407_32412_I(items))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 32383, 32488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32446, 32473);

                        f_1523_32446_32472(item != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 32383, 32488);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 106);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 32212, 32499);

                int
                f_1523_32341_32368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32341, 32368);
                    return 0;
                }


                int
                f_1523_32446_32472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32446, 32472);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1523_32407_32412_I(System.Collections.Generic.IEnumerable<T>
                i)

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32407, 32412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 32212, 32499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 32212, 32499);
            }
        }

        [Conditional("DEBUG")]
        public static void NotEmpty(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 32511, 32659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32607, 32648);

                f_1523_32607_32647(!f_1523_32621_32646(str));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 32511, 32659);

                bool
                f_1523_32621_32646(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32621, 32646);
                    return return_v;
                }


                int
                f_1523_32607_32647(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32607, 32647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 32511, 32659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 32511, 32659);
            }
        }

        static Assert()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 31383, 32666);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 31383, 32666);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 31383, 32666);
        }

    }

    [Flags]
    internal enum ExpressionAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        ReadWrite = Read | Write,
    }
    internal static class Utils
    {
        internal static Expression Constant(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 32876, 32995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 32950, 32984);

                return f_1523_32957_32983(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 32876, 32995);

                System.Linq.Expressions.ConstantExpression
                f_1523_32957_32983(object
                value)
                {
                    var return_v = Expression.Constant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 32957, 32983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 32876, 32995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 32876, 32995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly DefaultExpression s_voidInstance;

        public static DefaultExpression Empty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 33097, 33194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33161, 33183);

                return s_voidInstance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 33097, 33194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 33097, 33194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 33097, 33194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Expression Void(Expression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 33206, 33536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33356, 33458) || true) && (f_1523_33360_33375(expression) == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 33356, 33458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33425, 33443);

                    return expression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 33356, 33458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33474, 33525);

                return f_1523_33481_33524(expression, f_1523_33510_33523());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 33206, 33536);

                System.Type
                f_1523_33360_33375(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 33360, 33375);
                    return return_v;
                }


                System.Linq.Expressions.DefaultExpression
                f_1523_33510_33523()
                {
                    var return_v = Utils.Empty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 33510, 33523);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1523_33481_33524(System.Linq.Expressions.Expression
                arg0, System.Linq.Expressions.DefaultExpression
                arg1)
                {
                    var return_v = Expression.Block(arg0, (System.Linq.Expressions.Expression)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 33481, 33524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 33206, 33536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 33206, 33536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DefaultExpression Default(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 33548, 33770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33623, 33711) || true) && (type == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 33623, 33711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33681, 33696);

                    return f_1523_33688_33695();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 33623, 33711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33727, 33759);

                return f_1523_33734_33758(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 33548, 33770);

                System.Linq.Expressions.DefaultExpression
                f_1523_33688_33695()
                {
                    var return_v = Empty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 33688, 33695);
                    return return_v;
                }


                System.Linq.Expressions.DefaultExpression
                f_1523_33734_33758(System.Type
                type)
                {
                    var return_v = Expression.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 33734, 33758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 33548, 33770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 33548, 33770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Expression Convert(Expression expression, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 33782, 34652);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33948, 34042) || true) && (f_1523_33952_33967(expression) == type)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 33948, 34042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34009, 34027);

                    return expression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 33948, 34042);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34058, 34199) || true) && (f_1523_34062_34077(expression) == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34058, 34199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34127, 34184);

                    return f_1523_34134_34183(expression, f_1523_34163_34182(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34058, 34199);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34215, 34312) || true) && (type == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34215, 34312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34273, 34297);

                    return f_1523_34280_34296(expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34215, 34312);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34483, 34581) || true) && (type == typeof(object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34483, 34581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34543, 34566);

                    return f_1523_34550_34565(expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34483, 34581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34597, 34641);

                return f_1523_34604_34640(expression, type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 33782, 34652);

                System.Type
                f_1523_33952_33967(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 33952, 33967);
                    return return_v;
                }


                System.Type
                f_1523_34062_34077(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 34062, 34077);
                    return return_v;
                }


                System.Linq.Expressions.DefaultExpression
                f_1523_34163_34182(System.Type
                type)
                {
                    var return_v = Utils.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 34163, 34182);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1523_34134_34183(System.Linq.Expressions.Expression
                arg0, System.Linq.Expressions.DefaultExpression
                arg1)
                {
                    var return_v = Expression.Block(arg0, (System.Linq.Expressions.Expression)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 34134, 34183);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1523_34280_34296(System.Linq.Expressions.Expression
                expression)
                {
                    var return_v = Void(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 34280, 34296);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1523_34550_34565(System.Linq.Expressions.Expression
                expression)
                {
                    var return_v = Box(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 34550, 34565);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1523_34604_34640(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 34604, 34640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 33782, 34652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 33782, 34652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Expression Box(Expression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 34664, 35210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34740, 34753);

                MethodInfo
                m
                = default(MethodInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34767, 35126) || true) && (f_1523_34771_34786(expression) == typeof(int))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34767, 35126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34835, 34883);

                    m = ScriptingRuntimeHelpers.Int32ToObjectMethod;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34767, 35126);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34767, 35126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34917, 35126) || true) && (f_1523_34921_34936(expression) == typeof(bool))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34917, 35126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 34986, 35036);

                        m = ScriptingRuntimeHelpers.BooleanToObjectMethod;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34917, 35126);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 34917, 35126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 35102, 35111);

                        m = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34917, 35126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 34767, 35126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 35142, 35199);

                return f_1523_35149_35198(expression, typeof(object), m);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 34664, 35210);

                System.Type
                f_1523_34771_34786(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 34771, 34786);
                    return return_v;
                }


                System.Type
                f_1523_34921_34936(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 34921, 34936);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1523_35149_35198(System.Linq.Expressions.Expression
                expression, System.Type
                type, System.Reflection.MethodInfo
                method)
                {
                    var return_v = Expression.Convert(expression, type, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 35149, 35198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 34664, 35210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 34664, 35210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsReadWriteAssignment(this ExpressionType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 35222, 36469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 35313, 36429);

                switch (type)
                {

                    case ExpressionType.PostDecrementAssign:
                    case ExpressionType.PostIncrementAssign:
                    case ExpressionType.PreDecrementAssign:
                    case ExpressionType.PreIncrementAssign:

                    // binary - compound:
                    case ExpressionType.AddAssign:
                    case ExpressionType.AddAssignChecked:
                    case ExpressionType.AndAssign:
                    case ExpressionType.DivideAssign:
                    case ExpressionType.ExclusiveOrAssign:
                    case ExpressionType.LeftShiftAssign:
                    case ExpressionType.ModuloAssign:
                    case ExpressionType.MultiplyAssign:
                    case ExpressionType.MultiplyAssignChecked:
                    case ExpressionType.OrAssign:
                    case ExpressionType.PowerAssign:
                    case ExpressionType.RightShiftAssign:
                    case ExpressionType.SubtractAssign:
                    case ExpressionType.SubtractAssignChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 35313, 36429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36402, 36414);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 35313, 36429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36445, 36458);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 35222, 36469);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 35222, 36469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 35222, 36469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Utils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 32832, 36476);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 33049, 33084);
            s_voidInstance = f_1523_33066_33084();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 32832, 36476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 32832, 36476);
        }


        static System.Linq.Expressions.DefaultExpression
        f_1523_33066_33084()
        {
            var return_v = Expression.Empty();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 33066, 33084);
            return return_v;
        }

    }
    internal static class CollectionExtension
    {
        internal static bool TrueForAll<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 36542, 36955);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36803, 36916);
                    foreach (T item in f_1523_36822_36832_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 36803, 36916);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36866, 36901) || true) && (!f_1523_36871_36886(predicate, item))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 36866, 36901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36888, 36901);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 36866, 36901);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 36803, 36916);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 36932, 36944);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 36542, 36955);

                bool
                f_1523_36871_36886(System.Predicate<T>
                this_param, T
                obj)
                {
                    var return_v = this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 36871, 36886);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1523_36822_36832_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 36822, 36832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 36542, 36955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 36542, 36955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static U[] Map<T, U>(this ICollection<T> collection, Func<T, U> select)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 36967, 37323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37072, 37101);

                int
                count = f_1523_37084_37100(collection)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37115, 37141);

                U[]
                result = new U[count]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37155, 37165);

                count = 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37179, 37282);
                    foreach (T t in f_1523_37195_37205_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 37179, 37282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37239, 37267);

                        result[count++] = f_1523_37257_37266(select, t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 37179, 37282);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37298, 37312);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 36967, 37323);

                int
                f_1523_37084_37100(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 37084, 37100);
                    return return_v;
                }


                U
                f_1523_37257_37266(System.Func<T, U>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 37257, 37266);
                    return return_v;
                }


                System.Collections.Generic.ICollection<T>
                f_1523_37195_37205_I(System.Collections.Generic.ICollection<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 37195, 37205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 36967, 37323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 36967, 37323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int ListHashCode<T>(this IEnumerable<T> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 37390, 37695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37476, 37514);

                var
                cmp = f_1523_37486_37513()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37528, 37541);

                int
                h = 6551
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37555, 37659);
                    foreach (T t in f_1523_37571_37575_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 37555, 37659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37609, 37644);

                        h ^= (h << 5) ^ f_1523_37625_37643(cmp, t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 37555, 37659);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37675, 37684);

                return h;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 37390, 37695);

                System.Collections.Generic.EqualityComparer<T>
                f_1523_37486_37513()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 37486, 37513);
                    return return_v;
                }


                int
                f_1523_37625_37643(System.Collections.Generic.EqualityComparer<T>
                this_param, T
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 37625, 37643);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1523_37571_37575_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 37571, 37575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 37390, 37695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 37390, 37695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ListEquals<T>(this ICollection<T> first, ICollection<T> second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1523, 37707, 38317);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37816, 37909) || true) && (f_1523_37820_37831(first) != f_1523_37835_37847(second))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 37816, 37909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37881, 37894);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 37816, 37909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37925, 37963);

                var
                cmp = f_1523_37935_37962()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 37977, 38007);

                var
                f = f_1523_37985_38006(first)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38021, 38052);

                var
                s = f_1523_38029_38051(second)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38066, 38278) || true) && (f_1523_38073_38085(f))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 38066, 38278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38119, 38132);

                        f_1523_38119_38131(s);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38152, 38263) || true) && (!f_1523_38157_38189(cmp, f_1523_38168_38177(f), f_1523_38179_38188(s)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1523, 38152, 38263);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38231, 38244);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 38152, 38263);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1523, 38066, 38278);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1523, 38066, 38278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1523, 38066, 38278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38294, 38306);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1523, 37707, 38317);

                int
                f_1523_37820_37831(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 37820, 37831);
                    return return_v;
                }


                int
                f_1523_37835_37847(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 37835, 37847);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<T>
                f_1523_37935_37962()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 37935, 37962);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_1523_37985_38006(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 37985, 38006);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_1523_38029_38051(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38029, 38051);
                    return return_v;
                }


                bool
                f_1523_38073_38085(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38073, 38085);
                    return return_v;
                }


                bool
                f_1523_38119_38131(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38119, 38131);
                    return return_v;
                }


                T
                f_1523_38168_38177(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 38168, 38177);
                    return return_v;
                }


                T
                f_1523_38179_38188(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1523, 38179, 38188);
                    return return_v;
                }


                bool
                f_1523_38157_38189(System.Collections.Generic.EqualityComparer<T>
                this_param, T
                x, T
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38157, 38189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 37707, 38317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 37707, 38317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CollectionExtension()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 36484, 38324);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 36484, 38324);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 36484, 38324);
        }

    }
    internal sealed class ListEqualityComparer<T> : EqualityComparer<ICollection<T>>
    {
        internal static readonly ListEqualityComparer<T> Instance;

        private ListEqualityComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1523, 38531, 38565);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1523, 38531, 38565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 38531, 38565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 38531, 38565);
            }
        }

        public override bool Equals(ICollection<T> x, ICollection<T> y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 38649, 38771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38737, 38760);

                return f_1523_38744_38759(x, y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 38649, 38771);

                bool
                f_1523_38744_38759(System.Collections.Generic.ICollection<T>
                first, System.Collections.Generic.ICollection<T>
                second)
                {
                    var return_v = first.ListEquals<T>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38744, 38759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 38649, 38771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 38649, 38771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode(ICollection<T> obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1523, 38783, 38896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38859, 38885);

                return f_1523_38866_38884(obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1523, 38783, 38896);

                int
                f_1523_38866_38884(System.Collections.Generic.ICollection<T>
                list)
                {
                    var return_v = list.ListHashCode<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38866, 38884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1523, 38783, 38896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 38783, 38896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ListEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1523, 38332, 38903);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1523, 38478, 38518);
            Instance = f_1523_38489_38518();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1523, 38332, 38903);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1523, 38332, 38903);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1523, 38332, 38903);

        static System.Management.Automation.Interpreter.ListEqualityComparer<T>
        f_1523_38489_38518()
        {
            var return_v = new System.Management.Automation.Interpreter.ListEqualityComparer<T>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1523, 38489, 38518);
            return return_v;
        }

    }
}
