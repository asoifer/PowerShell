// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Management.Automation
{
    internal static class ExtensionMethods
    {
        public static void SafeInvoke(this EventHandler eventHandler, object sender, EventArgs eventArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 325, 563);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 447, 552) || true) && (eventHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 447, 552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 505, 537);

                    f_1010_505_536(eventHandler, sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 447, 552);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 325, 563);

                int
                f_1010_505_536(System.EventHandler
                this_param, object
                sender, System.EventArgs
                e)
                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 505, 536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 325, 563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 325, 563);
            }
        }

        public static void SafeInvoke<T>(this EventHandler<T> eventHandler, object sender, T eventArgs) where T : EventArgs
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 575, 831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 715, 820) || true) && (eventHandler != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 715, 820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 773, 805);

                    f_1010_773_804(eventHandler, sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 715, 820);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 575, 831);

                int
                f_1010_773_804(System.EventHandler<T>
                this_param, object
                sender, T
                e) 

                {
                    this_param.Invoke(sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 773, 804);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 575, 831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 575, 831);
            }
        }

        static ExtensionMethods()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1010, 270, 838);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1010, 270, 838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 270, 838);
        }

    }
    internal static class EnumerableExtensions
    {
        internal static IEnumerable<T> Prepend<T>(this IEnumerable<T> collection, T element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 905, 1120);

                var listYield = new List<T>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1014, 1035);

                listYield.Add(element);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1049, 1109);
                    foreach (T t in f_1010_1065_1075_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 1049, 1109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1094, 1109);

                        listYield.Add(t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 1049, 1109);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1010, 1, 61);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1010, 1, 61);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 905, 1120);

                return listYield;

                System.Collections.Generic.IEnumerable<T>
                f_1010_1065_1075_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 1065, 1075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 905, 1120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 905, 1120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int SequenceGetHashCode<T>(this IEnumerable<T> xs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 1132, 1912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1372, 1468) || true) && (xs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 1372, 1468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1420, 1436);

                    return 82460653;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 1372, 1468);
                }

                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1526, 1540);

                    int
                    hash = 41
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1589, 1854);
                        foreach (T x in f_1010_1605_1607_I(xs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 1589, 1854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1649, 1666);

                            hash = hash * 59;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1719, 1835) || true) && (x != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 1719, 1835);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1782, 1812);

                                hash = hash + f_1010_1796_1811(x);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 1719, 1835);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 1589, 1854);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1010, 1, 266);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1010, 1, 266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 1874, 1886);

                    return hash;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 1132, 1912);

                int
                f_1010_1796_1811(T
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 1796, 1811);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1010_1605_1607_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 1605, 1607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 1132, 1912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 1132, 1912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumerableExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1010, 846, 1919);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1010, 846, 1919);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 846, 1919);
        }

    }
    internal static partial class PSTypeExtensions
    {
        internal static bool HasDefaultCtor(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 2755, 3214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 2831, 2961);

                var
                ctor = f_1010_2842_2960(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 2975, 3174) || true) && (ctor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 2975, 3174);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3025, 3159) || true) && (f_1010_3029_3042(ctor) || (DynAbs.Tracing.TraceSender.Expression_False(1010, 3029, 3059) || f_1010_3046_3059(ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(1010, 3029, 3086) || f_1010_3063_3086(ctor)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1010, 3025, 3159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3128, 3140);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 3025, 3159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1010, 2975, 3174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3190, 3203);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 2755, 3214);

                System.Reflection.ConstructorInfo?
                f_1010_2842_2960(System.Type
                this_param, System.Reflection.BindingFlags
                bindingAttr, System.Reflection.Binder?
                binder, System.Type[]
                types, System.Reflection.ParameterModifier[]?
                modifiers)
                {
                    var return_v = this_param.GetConstructor(bindingAttr, binder, types, modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 2842, 2960);
                    return return_v;
                }


                bool
                f_1010_3029_3042(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.IsPublic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 3029, 3042);
                    return return_v;
                }


                bool
                f_1010_3046_3059(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.IsFamily;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 3046, 3059);
                    return return_v;
                }


                bool
                f_1010_3063_3086(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.IsFamilyOrAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 3063, 3086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 2755, 3214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 2755, 3214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNumeric(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 3226, 3382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3297, 3371);

                return f_1010_3304_3370(f_1010_3333_3369(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 3226, 3382);

                System.TypeCode
                f_1010_3333_3369(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3333, 3369);
                    return return_v;
                }


                bool
                f_1010_3304_3370(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3304, 3370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 3226, 3382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 3226, 3382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNumericOrPrimitive(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 3394, 3581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3476, 3570);

                return f_1010_3483_3499(type) || (DynAbs.Tracing.TraceSender.Expression_False(1010, 3483, 3569) || f_1010_3503_3569(f_1010_3532_3568(type)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 3394, 3581);

                bool
                f_1010_3483_3499(System.Type
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 3483, 3499);
                    return return_v;
                }


                System.TypeCode
                f_1010_3532_3568(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3532, 3568);
                    return return_v;
                }


                bool
                f_1010_3503_3569(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3503, 3569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 3394, 3581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 3394, 3581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSafePrimitive(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 3593, 3762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3670, 3751);

                return f_1010_3677_3693(type) && (DynAbs.Tracing.TraceSender.Expression_True(1010, 3677, 3721) && (type != typeof(IntPtr))) && (DynAbs.Tracing.TraceSender.Expression_True(1010, 3677, 3750) && (type != typeof(UIntPtr)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 3593, 3762);

                bool
                f_1010_3677_3693(System.Type
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 3677, 3693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 3593, 3762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 3593, 3762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsFloating(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 3774, 3932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 3846, 3921);

                return f_1010_3853_3920(f_1010_3883_3919(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 3774, 3932);

                System.TypeCode
                f_1010_3883_3919(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3883, 3919);
                    return return_v;
                }


                bool
                f_1010_3853_3920(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsFloating(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 3853, 3920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 3774, 3932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 3774, 3932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInteger(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 3944, 4100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4015, 4089);

                return f_1010_4022_4088(f_1010_4051_4087(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 3944, 4100);

                System.TypeCode
                f_1010_4051_4087(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 4051, 4087);
                    return return_v;
                }


                bool
                f_1010_4022_4088(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsInteger(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 4022, 4088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 3944, 4100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 3944, 4100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static TypeCode GetTypeCode(this Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 4112, 4290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4249, 4279);

                return f_1010_4256_4278(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 4112, 4290);

                System.TypeCode
                f_1010_4256_4278(System.Type
                type)
                {
                    var return_v = Type.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1010, 4256, 4278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 4112, 4290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 4112, 4290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<T> GetCustomAttributes<T>(this Type type, bool inherit)
                    where T : Attribute
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 4302, 4590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4443, 4579);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from attr in type.GetCustomAttributes(typeof(T), inherit)
                                                                               where attr is T
                                                                               select (T)attr, 1010, 4450, 4578);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 4302, 4590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 4302, 4590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 4302, 4590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSTypeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1010, 2408, 4597);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1010, 2408, 4597);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 2408, 4597);
        }

    }
    internal static class WeakReferenceExtensions
    {
        internal static bool TryGetTarget<T>(this WeakReference weakReference, out T target) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1010, 4667, 4900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4792, 4821);

                var
                t = f_1010_4800_4820(weakReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4835, 4851);

                target = t as T;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1010, 4865, 4889);

                return (target != null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1010, 4667, 4900);

                object
                f_1010_4800_4820(System.WeakReference
                this_param)

                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1010, 4800, 4820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1010, 4667, 4900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 4667, 4900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WeakReferenceExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1010, 4605, 4907);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1010, 4605, 4907);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1010, 4605, 4907);
        }

    }
}
