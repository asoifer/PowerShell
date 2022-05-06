// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    internal static class ArrayOps
    {
        internal static object[] SlicingIndex(object target, object[] indexes, Func<object, object, object> indexer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 397, 1099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 530, 570);

                var
                result = new object[f_1662_554_568(indexes)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 584, 594);

                int
                j = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 608, 848);
                    foreach (object t in f_1662_629_636_I(indexes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 608, 848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 670, 701);

                        var
                        value = f_1662_682_700(indexer, target, t)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 719, 833) || true) && (value != f_1662_732_752())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 719, 833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 794, 814);

                            result[j++] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 719, 833);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 608, 848);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 1, 241);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 864, 1058) || true) && (j != f_1662_873_887(indexes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 864, 1058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 921, 953);

                    var
                    shortResult = new object[j]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 971, 1006);

                    f_1662_971_1005(result, shortResult, j);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1024, 1043);

                    return shortResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 864, 1058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1074, 1088);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 397, 1099);

                int
                f_1662_554_568(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 554, 568);
                    return return_v;
                }


                object
                f_1662_682_700(System.Func<object, object, object>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 682, 700);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1662_732_752()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 732, 752);
                    return return_v;
                }


                object[]
                f_1662_629_636_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 629, 636);
                    return return_v;
                }


                int
                f_1662_873_887(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 873, 887);
                    return return_v;
                }


                int
                f_1662_971_1005(object[]
                sourceArray, object[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 971, 1005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 397, 1099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 397, 1099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] Multiply<T>(T[] array, uint times)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 1448, 3527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1527, 1624);

                f_1662_1527_1623(array != null, "Caller should verify the arguments for array multiplication");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1640, 1716) || true) && (times == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 1640, 1716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1688, 1701);

                    return array;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 1640, 1716);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1732, 1889) || true) && (times == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1662, 1736, 1767) || f_1662_1750_1762(array) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 1732, 1889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1801, 1817);

                    return new T[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 1732, 1889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1905, 1962);

                var
                context = f_1662_1919_1961()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 1976, 2354) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1662, 1980, 2073) && f_1662_2016_2036(context) == PSLanguageMode.RestrictedLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1662, 1980, 2106) && (f_1662_2078_2090(array) * times) > 1024))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 1976, 2354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2140, 2339);

                    throw f_1662_2146_2338(times, typeof(RuntimeException), null, "ArrayMultiplyToolongInDataSection", f_1662_2284_2331(), 1024);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 1976, 2354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2370, 2413);

                var
                uncheckedLength = f_1662_2392_2404(array) * times
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2427, 2445);

                int
                elements = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2495, 2536);

                    elements = checked((int)uncheckedLength);
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1662, 2565, 2713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2623, 2698);

                    f_1662_2623_2697(uncheckedLength, typeof(int));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1662, 2565, 2713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2947, 2976);

                T[]
                result = new T[elements]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 2990, 3022);

                int
                resultLength = f_1662_3009_3021(array)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3036, 3082);

                f_1662_3036_3081(array, 0, result, 0, resultLength);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3096, 3108);

                times >>= 1;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3122, 3312) || true) && (times != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 3122, 3312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3173, 3231);

                        f_1662_3173_3230(result, 0, result, resultLength, resultLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3249, 3267);

                        resultLength *= 2;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3285, 3297);

                        times >>= 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 3122, 3312);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 3122, 3312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 3122, 3312);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3328, 3486) || true) && (f_1662_3332_3345(result) != resultLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 3328, 3486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3395, 3471);

                    f_1662_3395_3470(result, 0, result, resultLength, (f_1662_3440_3453(result) - resultLength));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 3328, 3486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3502, 3516);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 1448, 3527);

                int
                f_1662_1527_1623(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 1527, 1623);
                    return 0;
                }


                int
                f_1662_1750_1762(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 1750, 1762);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1662_1919_1961()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 1919, 1961);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1662_2016_2036(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 2016, 2036);
                    return return_v;
                }


                int
                f_1662_2078_2090(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 2078, 2090);
                    return return_v;
                }


                string
                f_1662_2284_2331()
                {
                    var return_v = ParserStrings.ArrayMultiplyToolongInDataSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 2284, 2331);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1662_2146_2338(uint
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 2146, 2338);
                    return return_v;
                }


                int
                f_1662_2392_2404(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 2392, 2404);
                    return return_v;
                }


                object
                f_1662_2623_2697(long
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 2623, 2697);
                    return return_v;
                }


                int
                f_1662_3009_3021(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3009, 3021);
                    return return_v;
                }


                int
                f_1662_3036_3081(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3036, 3081);
                    return 0;
                }


                int
                f_1662_3173_3230(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3173, 3230);
                    return 0;
                }


                int
                f_1662_3332_3345(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3332, 3345);
                    return return_v;
                }


                int
                f_1662_3440_3453(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3440, 3453);
                    return return_v;
                }


                int
                f_1662_3395_3470(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3395, 3470);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 1448, 3527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 1448, 3527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetMDArrayValue(Array array, int[] indexes, bool slicing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 3539, 4796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3644, 3767) || true) && (f_1662_3648_3658(array) != f_1662_3662_3676(indexes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 3644, 3767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3710, 3752);

                    f_1662_3710_3751(array, indexes, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 3644, 3767);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3792, 3797);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3783, 4655) || true) && (i < f_1662_3803_3817(indexes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3819, 3822)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 3783, 4655))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 3783, 4655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3856, 3888);

                        int
                        ub = f_1662_3865_3887(array, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3906, 3938);

                        int
                        lb = f_1662_3915_3937(array, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 3956, 4069) || true) && (indexes[i] < lb)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 3956, 4069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4017, 4050);

                            indexes[i] = indexes[i] + ub + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 3956, 4069);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4089, 4640) || true) && (indexes[i] < lb || (DynAbs.Tracing.TraceSender.Expression_False(1662, 4093, 4127) || indexes[i] > ub))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 4089, 4640);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4279, 4336);

                            var
                            context = f_1662_4293_4335()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4358, 4621) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1662, 4362, 4408) && !f_1662_4382_4408(context, 3)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 4358, 4621);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4553, 4598);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(1662, 4560, 4567) || ((slicing && DynAbs.Tracing.TraceSender.Conditional_F2(1662, 4570, 4590)) || DynAbs.Tracing.TraceSender.Conditional_F3(1662, 4593, 4597))) ? f_1662_4570_4590() : null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 4358, 4621);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 4089, 4640);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 1, 873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 1, 873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4754, 4785);

                return f_1662_4761_4784(array, indexes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 3539, 4796);

                int
                f_1662_3648_3658(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3648, 3658);
                    return return_v;
                }


                int
                f_1662_3662_3676(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3662, 3676);
                    return return_v;
                }


                int
                f_1662_3710_3751(System.Array
                array, int[]
                index, System.Exception
                reason)
                {
                    ReportIndexingError(array, (object)index, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3710, 3751);
                    return 0;
                }


                int
                f_1662_3803_3817(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 3803, 3817);
                    return return_v;
                }


                int
                f_1662_3865_3887(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3865, 3887);
                    return return_v;
                }


                int
                f_1662_3915_3937(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 3915, 3937);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1662_4293_4335()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 4293, 4335);
                    return return_v;
                }


                bool
                f_1662_4382_4408(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 4382, 4408);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1662_4570_4590()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 4570, 4590);
                    return return_v;
                }


                object?
                f_1662_4761_4784(System.Array
                this_param, params int[]
                indices)
                {
                    var return_v = this_param.GetValue(indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 4761, 4784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 3539, 4796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 3539, 4796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetMDArrayValueOrSlice(Array array, object indexes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 4808, 7973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4907, 4934);

                Exception
                whyFailed = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 4948, 4972);

                int[]
                indexArray = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5022, 5127);

                    indexArray = (int[])f_1662_5042_5126(indexes, typeof(int[]), f_1662_5095_5125());
                }
                catch (InvalidCastException ice)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1662, 5156, 5439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5408, 5424);

                    whyFailed = ice;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1662, 5156, 5439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5455, 5790) || true) && (indexArray != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 5455, 5790);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5511, 5706) || true) && (f_1662_5515_5532(indexArray) != f_1662_5536_5546(array))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 5511, 5706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5645, 5687);

                        f_1662_5645_5686(array, indexes, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 5511, 5706);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5726, 5775);

                    return f_1662_5733_5774(array, indexArray, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 5455, 5790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5806, 5840);

                var
                indexList = f_1662_5822_5839()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5856, 5907);

                var
                ie = f_1662_5865_5906(indexes)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5921, 7190) || true) && (f_1662_5928_5960(null, ie))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 5921, 7190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 5994, 6039);

                        var
                        currentIndex = f_1662_6013_6038(ie)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6101, 6164);

                            indexArray = f_1662_6114_6163(currentIndex);
                        }
                        catch (InvalidCastException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1662, 6201, 6307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6270, 6288);

                            indexArray = null;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1662, 6201, 6307);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6327, 7021) || true) && (indexArray == null || (DynAbs.Tracing.TraceSender.Expression_False(1662, 6331, 6384) || f_1662_6353_6370(indexArray) != f_1662_6374_6384(array)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 6327, 7021);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6426, 6747) || true) && (whyFailed != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 6426, 6747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6591, 6638);

                                f_1662_6591_6637(array, indexes, whyFailed);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6664, 6724);

                                f_1662_6664_6723(false, "ReportIndexingError must throw");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 6426, 6747);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6873, 6920);

                            f_1662_6873_6919(array, currentIndex, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 6942, 7002);

                            f_1662_6942_7001(false, "ReportIndexingError must throw");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 6327, 7021);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7114, 7131);

                        whyFailed = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7149, 7175);

                        f_1662_7149_7174(indexList, indexArray);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 5921, 7190);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 5921, 7190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 5921, 7190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7390, 7431);

                var
                result = new object[f_1662_7414_7429(indexList)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7445, 7455);

                int
                j = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7469, 7721);
                    foreach (var i in f_1662_7487_7496_I(indexList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 7469, 7721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7530, 7574);

                        var
                        value = f_1662_7542_7573(array, i, true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7592, 7706) || true) && (value != f_1662_7605_7625())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 7592, 7706);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7667, 7687);

                            result[j++] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 7592, 7706);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 7469, 7721);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 1, 253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 1, 253);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7737, 7932) || true) && (j != f_1662_7746_7761(indexList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 7737, 7932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7795, 7827);

                    var
                    shortResult = new object[j]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7845, 7880);

                    f_1662_7845_7879(result, shortResult, j);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7898, 7917);

                    return shortResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 7737, 7932);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 7948, 7962);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 4808, 7973);

                System.Globalization.NumberFormatInfo
                f_1662_5095_5125()
                {
                    var return_v = NumberFormatInfo.InvariantInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 5095, 5125);
                    return return_v;
                }


                object
                f_1662_5042_5126(object
                valueToConvert, System.Type
                resultType, System.Globalization.NumberFormatInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5042, 5126);
                    return return_v;
                }


                int
                f_1662_5515_5532(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 5515, 5532);
                    return return_v;
                }


                int
                f_1662_5536_5546(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 5536, 5546);
                    return return_v;
                }


                int
                f_1662_5645_5686(System.Array
                array, object
                index, System.Exception
                reason)
                {
                    ReportIndexingError(array, index, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5645, 5686);
                    return 0;
                }


                object
                f_1662_5733_5774(System.Array
                array, int[]
                indexes, bool
                slicing)
                {
                    var return_v = GetMDArrayValue(array, indexes, slicing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5733, 5774);
                    return return_v;
                }


                System.Collections.Generic.List<int[]>
                f_1662_5822_5839()
                {
                    var return_v = new System.Collections.Generic.List<int[]>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5822, 5839);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1662_5865_5906(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5865, 5906);
                    return return_v;
                }


                bool
                f_1662_5928_5960(System.Management.Automation.ExecutionContext
                context, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = EnumerableOps.MoveNext(context, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 5928, 5960);
                    return return_v;
                }


                object
                f_1662_6013_6038(System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = EnumerableOps.Current(enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6013, 6038);
                    return return_v;
                }


                int[]
                f_1662_6114_6163(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int[]>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6114, 6163);
                    return return_v;
                }


                int
                f_1662_6353_6370(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 6353, 6370);
                    return return_v;
                }


                int
                f_1662_6374_6384(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 6374, 6384);
                    return return_v;
                }


                int
                f_1662_6591_6637(System.Array
                array, object
                index, System.Exception
                reason)
                {
                    ReportIndexingError(array, index, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6591, 6637);
                    return 0;
                }


                int
                f_1662_6664_6723(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6664, 6723);
                    return 0;
                }


                int
                f_1662_6873_6919(System.Array
                array, object
                index, System.Exception
                reason)
                {
                    ReportIndexingError(array, index, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6873, 6919);
                    return 0;
                }


                int
                f_1662_6942_7001(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 6942, 7001);
                    return 0;
                }


                int
                f_1662_7149_7174(System.Collections.Generic.List<int[]>
                this_param, int[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 7149, 7174);
                    return 0;
                }


                int
                f_1662_7414_7429(System.Collections.Generic.List<int[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 7414, 7429);
                    return return_v;
                }


                object
                f_1662_7542_7573(System.Array
                array, int[]
                indexes, bool
                slicing)
                {
                    var return_v = GetMDArrayValue(array, indexes, slicing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 7542, 7573);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1662_7605_7625()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 7605, 7625);
                    return return_v;
                }


                System.Collections.Generic.List<int[]>
                f_1662_7487_7496_I(System.Collections.Generic.List<int[]>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 7487, 7496);
                    return return_v;
                }


                int
                f_1662_7746_7761(System.Collections.Generic.List<int[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 7746, 7761);
                    return return_v;
                }


                int
                f_1662_7845_7879(object[]
                sourceArray, object[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 7845, 7879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 4808, 7973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 4808, 7973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportIndexingError(Array array, object index, Exception reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 7985, 8744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 8167, 8212);

                string
                msgString = f_1662_8186_8211(index)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 8228, 8495) || true) && (reason == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 8228, 8495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 8280, 8480);

                    throw f_1662_8286_8479(index, typeof(RuntimeException), null, "NeedMultidimensionalIndex", f_1662_8416_8455(), f_1662_8457_8467(array), msgString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 8228, 8495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 8511, 8733);

                throw f_1662_8517_8732(index, typeof(RuntimeException), null, "NeedMultidimensionalIndex", f_1662_8661_8700(), reason, f_1662_8710_8720(array), msgString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 7985, 8744);

                string
                f_1662_8186_8211(object
                index)
                {
                    var return_v = IndexStringMessage(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 8186, 8211);
                    return return_v;
                }


                string
                f_1662_8416_8455()
                {
                    var return_v = ParserStrings.NeedMultidimensionalIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 8416, 8455);
                    return return_v;
                }


                int
                f_1662_8457_8467(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 8457, 8467);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1662_8286_8479(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 8286, 8479);
                    return return_v;
                }


                string
                f_1662_8661_8700()
                {
                    var return_v = ParserStrings.NeedMultidimensionalIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 8661, 8700);
                    return return_v;
                }


                int
                f_1662_8710_8720(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 8710, 8720);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1662_8517_8732(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, System.Exception
                innerException, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterExceptionWithInnerException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, innerException, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 8517, 8732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 7985, 8744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 7985, 8744);
            }
        }

        internal static string IndexStringMessage(object index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 8756, 9136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 8909, 8988);

                string
                msgString = f_1662_8928_8987(null, index, ",", null, null, true, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9002, 9094) || true) && (f_1662_9006_9022(msgString) > 20)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 9002, 9094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9046, 9094);

                    msgString = f_1662_9058_9084(msgString, 0, 20) + " ...";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 9002, 9094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9108, 9125);

                return msgString;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 8756, 9136);

                string
                f_1662_8928_8987(System.Management.Automation.ExecutionContext
                context, object
                obj, string
                separator, string
                format, System.IFormatProvider
                formatProvider, bool
                recurse, bool
                unravelEnumeratorOnRecurse)
                {
                    var return_v = PSObject.ToString(context, obj, separator, format, formatProvider, recurse, unravelEnumeratorOnRecurse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 8928, 8987);
                    return return_v;
                }


                int
                f_1662_9006_9022(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 9006, 9022);
                    return return_v;
                }


                string
                f_1662_9058_9084(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 9058, 9084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 8756, 9136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 8756, 9136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object SetMDArrayValue(Array array, int[] indexes, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 9148, 9778);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9253, 9376) || true) && (f_1662_9257_9267(array) != f_1662_9271_9285(indexes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 9253, 9376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9319, 9361);

                    f_1662_9319_9360(array, indexes, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 9253, 9376);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9401, 9406);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9392, 9693) || true) && (i < f_1662_9412_9426(indexes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9428, 9431)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 9392, 9693))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 9392, 9693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9465, 9497);

                        int
                        ub = f_1662_9474_9496(array, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9515, 9547);

                        int
                        lb = f_1662_9524_9546(array, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9565, 9678) || true) && (indexes[i] < lb)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 9565, 9678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9626, 9659);

                            indexes[i] = indexes[i] + ub + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 9565, 9678);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1662, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1662, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9709, 9740);

                f_1662_9709_9739(
                            array, value, indexes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 9754, 9767);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 9148, 9778);

                int
                f_1662_9257_9267(System.Array
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 9257, 9267);
                    return return_v;
                }


                int
                f_1662_9271_9285(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 9271, 9285);
                    return return_v;
                }


                int
                f_1662_9319_9360(System.Array
                array, int[]
                index, System.Exception
                reason)
                {
                    ReportIndexingError(array, (object)index, reason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 9319, 9360);
                    return 0;
                }


                int
                f_1662_9412_9426(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 9412, 9426);
                    return return_v;
                }


                int
                f_1662_9474_9496(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetUpperBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 9474, 9496);
                    return return_v;
                }


                int
                f_1662_9524_9546(System.Array
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLowerBound(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 9524, 9546);
                    return return_v;
                }


                int
                f_1662_9709_9739(System.Array
                this_param, object
                value, params int[]
                indices)
                {
                    this_param.SetValue(value, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 9709, 9739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 9148, 9778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 9148, 9778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetNonIndexable(object target, object[] indices)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1662, 9790, 10968);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10234, 10520) || true) && (f_1662_10238_10252(indices) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 10234, 10520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10291, 10314);

                    var
                    index = indices[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10332, 10505) || true) && (index != null && (DynAbs.Tracing.TraceSender.Expression_True(1662, 10336, 10430) && (f_1662_10354_10389(0, index) || (DynAbs.Tracing.TraceSender.Expression_False(1662, 10354, 10429) || f_1662_10393_10429(-1, index)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 10332, 10505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10472, 10486);

                        return target;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 10332, 10505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 10234, 10520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10536, 10593);

                var
                context = f_1662_10550_10592()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10607, 10734) || true) && (context == null || (DynAbs.Tracing.TraceSender.Expression_False(1662, 10611, 10657) || !f_1662_10631_10657(context, 2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1662, 10607, 10734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10691, 10719);

                    return f_1662_10698_10718();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1662, 10607, 10734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1662, 10750, 10957);

                throw f_1662_10756_10956(target, typeof(RuntimeException), null, "CannotIndex", f_1662_10912_10937(), f_1662_10939_10955(target));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1662, 9790, 10968);

                int
                f_1662_10238_10252(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 10238, 10252);
                    return return_v;
                }


                bool
                f_1662_10354_10389(int
                first, object
                second)
                {
                    var return_v = LanguagePrimitives.Equals((object)first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10354, 10389);
                    return return_v;
                }


                bool
                f_1662_10393_10429(int
                first, object
                second)
                {
                    var return_v = LanguagePrimitives.Equals((object)first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10393, 10429);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1662_10550_10592()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10550, 10592);
                    return return_v;
                }


                bool
                f_1662_10631_10657(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10631, 10657);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1662_10698_10718()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 10698, 10718);
                    return return_v;
                }


                string
                f_1662_10912_10937()
                {
                    var return_v = ParserStrings.CannotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1662, 10912, 10937);
                    return return_v;
                }


                System.Type
                f_1662_10939_10955(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10939, 10955);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1662_10756_10956(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1662, 10756, 10956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1662, 9790, 10968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 9790, 10968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1662, 350, 10975);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1662, 350, 10975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1662, 350, 10975);
        }

    }
}
