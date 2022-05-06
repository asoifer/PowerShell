// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Language
{
    public static class CodeGeneration
    {
        public static string EscapeSingleQuotedStringContent(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1524, 800, 1389);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 891, 991) || true) && (f_1524_895_922(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 891, 991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 956, 976);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 891, 991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1007, 1058);

                StringBuilder
                sb = f_1524_1026_1057(f_1524_1044_1056(value))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1072, 1341);
                    foreach (char c in f_1524_1091_1096_I(value))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 1072, 1341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1130, 1143);

                        f_1524_1130_1142(sb, c);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1161, 1326) || true) && (f_1524_1165_1196(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 1161, 1326);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1294, 1307);

                            f_1524_1294_1306(                    // double-up quotes to escape them
                                                sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 1161, 1326);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 1072, 1341);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1524, 1, 270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1524, 1, 270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1357, 1378);

                return f_1524_1364_1377(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1524, 800, 1389);

                bool
                f_1524_895_922(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 895, 922);
                    return return_v;
                }


                int
                f_1524_1044_1056(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1524, 1044, 1056);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_1026_1057(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1026, 1057);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_1130_1142(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1130, 1142);
                    return return_v;
                }


                bool
                f_1524_1165_1196(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1165, 1196);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_1294_1306(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1294, 1306);
                    return return_v;
                }


                string
                f_1524_1091_1096_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1091, 1096);
                    return return_v;
                }


                string
                f_1524_1364_1377(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1364, 1377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1524, 800, 1389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1524, 800, 1389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string EscapeBlockCommentContent(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1524, 1786, 2089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1871, 1971) || true) && (f_1524_1875_1902(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 1871, 1971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1936, 1956);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 1871, 1971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 1987, 2078);

                return f_1524_1994_2077(f_1524_1994_2038(value
                , "<#", "<`#"), "#>", "#`>");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1524, 1786, 2089);

                bool
                f_1524_1875_1902(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1875, 1902);
                    return return_v;
                }


                string
                f_1524_1994_2038(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1994, 2038);
                    return return_v;
                }


                string
                f_1524_1994_2077(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 1994, 2077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1524, 1786, 2089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1524, 1786, 2089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string EscapeFormatStringContent(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1524, 2685, 3277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 2770, 2870) || true) && (f_1524_2774_2801(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 2770, 2870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 2835, 2855);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 2770, 2870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 2886, 2937);

                StringBuilder
                sb = f_1524_2905_2936(f_1524_2923_2935(value))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 2951, 3229);
                    foreach (char c in f_1524_2970_2975_I(value))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 2951, 3229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3009, 3022);

                        f_1524_3009_3021(sb, c);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3040, 3214) || true) && (f_1524_3044_3076(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 3040, 3214);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3182, 3195);

                            f_1524_3182_3194(                    // double-up curly brackets to escape them
                                                sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 3040, 3214);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 2951, 3229);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1524, 1, 279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1524, 1, 279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3245, 3266);

                return f_1524_3252_3265(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1524, 2685, 3277);

                bool
                f_1524_2774_2801(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 2774, 2801);
                    return return_v;
                }


                int
                f_1524_2923_2935(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1524, 2923, 2935);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_2905_2936(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 2905, 2936);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_3009_3021(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 3009, 3021);
                    return return_v;
                }


                bool
                f_1524_3044_3076(char
                c)
                {
                    var return_v = CharExtensions.IsCurlyBracket(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 3044, 3076);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1524_3182_3194(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 3182, 3194);
                    return return_v;
                }


                string
                f_1524_2970_2975_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 2970, 2975);
                    return return_v;
                }


                string
                f_1524_3252_3265(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 3252, 3265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1524, 2685, 3277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1524, 2685, 3277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string EscapeVariableName(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1524, 3807, 4136);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3885, 3985) || true) && (f_1524_3889_3916(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1524, 3885, 3985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 3950, 3970);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1524, 3885, 3985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1524, 4001, 4125);

                return f_1524_4008_4124(f_1524_4008_4087(f_1524_4008_4050(value
                , "`", "``"), "}", "`}"), "{", "`{");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1524, 3807, 4136);

                bool
                f_1524_3889_3916(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 3889, 3916);
                    return return_v;
                }


                string
                f_1524_4008_4050(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 4008, 4050);
                    return return_v;
                }


                string
                f_1524_4008_4087(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 4008, 4087);
                    return return_v;
                }


                string
                f_1524_4008_4124(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1524, 4008, 4124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1524, 3807, 4136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1524, 3807, 4136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CodeGeneration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1524, 363, 4143);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1524, 363, 4143);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1524, 363, 4143);
        }

    }
}
