// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    internal static class EnumMinimumDisambiguation
    {
        static EnumMinimumDisambiguation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1270, 562, 1014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4931, 4992);
                s_specialDisambiguateCases = f_1270_4960_4992();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 851, 1003);

                f_1270_851_1002(            // Add special minimum disambiguation cases here for certain enum types.
                                            // The current implementation assumes that special names in each type can be
                                            // differentiated by their first letter.
                            s_specialDisambiguateCases, typeof(System.IO.FileAttributes), new string[] { "Directory", "ReadOnly", "System" });
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1270, 562, 1014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1270, 562, 1014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1270, 562, 1014);
            }
        }

        internal static string EnumDisambiguate(string text, Type enumType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1270, 1219, 4020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1369, 1414);

                string[]
                enumNames = f_1270_1390_1413(enumType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1491, 1549);

                List<string>
                namesWithMatchingPrefix = f_1270_1530_1548()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1563, 1801);
                    foreach (string name in f_1270_1587_1596_I(enumNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 1563, 1801);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1630, 1786) || true) && (f_1270_1634_1691(name, text, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 1630, 1786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1733, 1767);

                            f_1270_1733_1766(namesWithMatchingPrefix, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 1630, 1786);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 1563, 1801);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1270, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1270, 1, 239);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1869, 4009) || true) && (f_1270_1873_1902(namesWithMatchingPrefix) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 1869, 4009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 1941, 2145);

                    throw f_1270_1947_2144(null, typeof(RuntimeException), null, "NoEnumNameMatch", f_1270_2066_2112(), text, f_1270_2120_2143(enumType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 1869, 4009);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 1869, 4009);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2241, 4009) || true) && (f_1270_2245_2274(namesWithMatchingPrefix) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2241, 4009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2313, 2347);

                        return f_1270_2320_2346(namesWithMatchingPrefix, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2241, 4009);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2241, 4009);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2497, 2762);
                            foreach (string matchName in f_1270_2526_2549_I(namesWithMatchingPrefix))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2497, 2762);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2591, 2743) || true) && (f_1270_2595_2653(matchName, text, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2591, 2743);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2703, 2720);

                                    return matchName;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2591, 2743);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2497, 2762);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1270, 1, 266);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1270, 1, 266);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2829, 2859);

                        string[]
                        minDisambiguateNames
                        = default(string[]);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2877, 3294) || true) && (f_1270_2881_2955(s_specialDisambiguateCases, enumType, out minDisambiguateNames))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2877, 3294);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 2997, 3275);
                                foreach (string tName in f_1270_3022_3042_I(minDisambiguateNames))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 2997, 3275);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3092, 3252) || true) && (f_1270_3096_3154(tName, text, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 3092, 3252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3212, 3225);

                                        return tName;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 3092, 3252);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2997, 3275);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1270, 1, 279);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1270, 1, 279);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2877, 3294);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3390, 3464);

                        StringBuilder
                        matchListSB = f_1270_3418_3463(f_1270_3436_3462(namesWithMatchingPrefix, 0))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3482, 3506);

                        string
                        separator = ", "
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3533, 3538);
                            for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3524, 3738) || true) && (i < f_1270_3544_3573(namesWithMatchingPrefix))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3575, 3578)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 3524, 3738))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 3524, 3738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3620, 3650);

                                f_1270_3620_3649(matchListSB, separator);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3672, 3719);

                                f_1270_3672_3718(matchListSB, f_1270_3691_3717(namesWithMatchingPrefix, i));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1270, 1, 215);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1270, 1, 215);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 3758, 3994);

                        throw f_1270_3764_3993(null, typeof(RuntimeException), null, "MultipleEnumNameMatch", f_1270_3889_3941(), text, f_1270_3970_3992(matchListSB));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 2241, 4009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 1869, 4009);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1270, 1219, 4020);

                string[]
                f_1270_1390_1413(System.Type
                enumType)
                {
                    var return_v = Enum.GetNames(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1390, 1413);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1270_1530_1548()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1530, 1548);
                    return return_v;
                }


                bool
                f_1270_1634_1691(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1634, 1691);
                    return return_v;
                }


                int
                f_1270_1733_1766(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1733, 1766);
                    return 0;
                }


                string[]
                f_1270_1587_1596_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1587, 1596);
                    return return_v;
                }


                int
                f_1270_1873_1902(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 1873, 1902);
                    return return_v;
                }


                string
                f_1270_2066_2112()
                {
                    var return_v = EnumExpressionEvaluatorStrings.NoEnumNameMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 2066, 2112);
                    return return_v;
                }


                string
                f_1270_2120_2143(System.Type
                enumType)
                {
                    var return_v = EnumAllValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 2120, 2143);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1270_1947_2144(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 1947, 2144);
                    return return_v;
                }


                int
                f_1270_2245_2274(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 2245, 2274);
                    return return_v;
                }


                string
                f_1270_2320_2346(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 2320, 2346);
                    return return_v;
                }


                bool
                f_1270_2595_2653(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 2595, 2653);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1270_2526_2549_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 2526, 2549);
                    return return_v;
                }


                bool
                f_1270_2881_2955(System.Collections.Generic.Dictionary<System.Type, string[]>
                this_param, System.Type
                key, out string[]
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 2881, 2955);
                    return return_v;
                }


                bool
                f_1270_3096_3154(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3096, 3154);
                    return return_v;
                }


                string[]
                f_1270_3022_3042_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3022, 3042);
                    return return_v;
                }


                string
                f_1270_3436_3462(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 3436, 3462);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_3418_3463(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3418, 3463);
                    return return_v;
                }


                int
                f_1270_3544_3573(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 3544, 3573);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_3620_3649(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3620, 3649);
                    return return_v;
                }


                string
                f_1270_3691_3717(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 3691, 3717);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_3672_3718(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3672, 3718);
                    return return_v;
                }


                string
                f_1270_3889_3941()
                {
                    var return_v = EnumExpressionEvaluatorStrings.MultipleEnumNameMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 3889, 3941);
                    return return_v;
                }


                string
                f_1270_3970_3992(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3970, 3992);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1270_3764_3993(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 3764, 3993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1270, 1219, 4020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1270, 1219, 4020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string EnumAllValues(Type enumType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1270, 4244, 4877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4320, 4361);

                string[]
                names = f_1270_4337_4360(enumType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4375, 4399);

                string
                separator = ", "
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4413, 4461);

                StringBuilder
                returnValue = f_1270_4441_4460()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4475, 4820) || true) && (f_1270_4479_4491(names) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 4475, 4820);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4539, 4544);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4530, 4709) || true) && (i < f_1270_4550_4562(names))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4564, 4567)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 4530, 4709))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1270, 4530, 4709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4609, 4638);

                            f_1270_4609_4637(returnValue, names[i]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4660, 4690);

                            f_1270_4660_4689(returnValue, separator);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1270, 1, 180);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1270, 1, 180);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4729, 4805);

                    f_1270_4729_4804(
                                    returnValue, f_1270_4748_4766(returnValue) - f_1270_4769_4785(separator), f_1270_4787_4803(separator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1270, 4475, 4820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1270, 4836, 4866);

                return f_1270_4843_4865(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1270, 4244, 4877);

                string[]
                f_1270_4337_4360(System.Type
                enumType)
                {
                    var return_v = Enum.GetNames(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4337, 4360);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_4441_4460()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4441, 4460);
                    return return_v;
                }


                int
                f_1270_4479_4491(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 4479, 4491);
                    return return_v;
                }


                int
                f_1270_4550_4562(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 4550, 4562);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_4609_4637(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4609, 4637);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_4660_4689(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4660, 4689);
                    return return_v;
                }


                int
                f_1270_4748_4766(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 4748, 4766);
                    return return_v;
                }


                int
                f_1270_4769_4785(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 4769, 4785);
                    return return_v;
                }


                int
                f_1270_4787_4803(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1270, 4787, 4803);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1270_4729_4804(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4729, 4804);
                    return return_v;
                }


                string
                f_1270_4843_4865(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4843, 4865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1270, 4244, 4877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1270, 4244, 4877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<Type, string[]> s_specialDisambiguateCases;

        static int
        f_1270_851_1002(System.Collections.Generic.Dictionary<System.Type, string[]>
        this_param, System.Type
        key, string[]
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 851, 1002);
            return 0;
        }


        static System.Collections.Generic.Dictionary<System.Type, string[]>
        f_1270_4960_4992()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Type, string[]>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1270, 4960, 4992);
            return return_v;
        }

    }
}
