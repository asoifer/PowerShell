// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

// ReSharper disable UnusedMember.Global

namespace System.Management.Automation
{
    using Dbg = Diagnostics;
    internal static class StringOps
    {
        internal static string Add(string lhs, string rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 441, 558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 516, 547);

                return f_1666_523_546(lhs, rhs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 441, 558);

                string
                f_1666_523_546(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 523, 546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 441, 558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 441, 558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Add(string lhs, char rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 570, 685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 643, 674);

                return f_1666_650_673(lhs, rhs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 570, 685);

                string
                f_1666_650_673(string
                arg0, char
                arg1)
                {
                    var return_v = string.Concat((object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 650, 673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 570, 685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 570, 685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Multiply(string s, int times)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 697, 2288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 774, 845);

                f_1666_774_844(s != null, "caller to verify argument is not null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 861, 1028) || true) && (times < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1666, 861, 1028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 966, 1013);

                    throw f_1666_972_1012("times");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1666, 861, 1028);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1044, 1144) || true) && (times == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1666, 1048, 1075) || f_1666_1062_1070(s) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1666, 1044, 1144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1109, 1129);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1666, 1044, 1144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1160, 1217);

                var
                context = f_1666_1174_1216()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1231, 1607) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1666, 1235, 1328) && f_1666_1271_1291(context) == PSLanguageMode.RestrictedLanguage) && (DynAbs.Tracing.TraceSender.Expression_True(1666, 1235, 1357) && (f_1666_1333_1341(s) * times) > 1024))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1666, 1231, 1607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1391, 1592);

                    throw f_1666_1397_1591(times, typeof(RuntimeException), null, "StringMultiplyToolongInDataSection", f_1666_1536_1584(), 1024);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1666, 1231, 1607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1623, 1809) || true) && (f_1666_1627_1635(s) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1666, 1623, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 1763, 1794);

                    return f_1666_1770_1793(f_1666_1781_1785(s, 0), times);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1666, 1623, 1809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 2210, 2277);

                return f_1666_2217_2276(f_1666_2228_2275(f_1666_2246_2261(s), times));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 697, 2288);

                int
                f_1666_774_844(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 774, 844);
                    return 0;
                }


                System.ArgumentOutOfRangeException
                f_1666_972_1012(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 972, 1012);
                    return return_v;
                }


                int
                f_1666_1062_1070(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1062, 1070);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1666_1174_1216()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 1174, 1216);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1666_1271_1291(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1271, 1291);
                    return return_v;
                }


                int
                f_1666_1333_1341(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1333, 1341);
                    return return_v;
                }


                string
                f_1666_1536_1584()
                {
                    var return_v = ParserStrings.StringMultiplyToolongInDataSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1536, 1584);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1666_1397_1591(int
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 1397, 1591);
                    return return_v;
                }


                int
                f_1666_1627_1635(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1627, 1635);
                    return return_v;
                }


                char
                f_1666_1781_1785(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 1781, 1785);
                    return return_v;
                }


                string
                f_1666_1770_1793(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 1770, 1793);
                    return return_v;
                }


                char[]
                f_1666_2246_2261(string
                this_param)
                {
                    var return_v = this_param.ToCharArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2246, 2261);
                    return return_v;
                }


                char[]
                f_1666_2228_2275(char[]
                array, int
                times)
                {
                    var return_v = ArrayOps.Multiply(array, (uint)times);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2228, 2275);
                    return return_v;
                }


                string
                f_1666_2217_2276(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2217, 2276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 697, 2288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 697, 2288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatOperator(string formatString, object formatArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 2300, 3063);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 2438, 2488);

                    object[]
                    formatArgsArray = formatArgs as object[]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 2506, 2690);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1666, 2513, 2536) || ((formatArgsArray != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1666, 2567, 2615)) || DynAbs.Tracing.TraceSender.Conditional_F3(1666, 2646, 2689))) ? f_1666_2567_2615(formatString, formatArgsArray) : f_1666_2646_2689(formatString, formatArgs);
                }
                catch (FormatException sfe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1666, 2719, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 2843, 3037);

                    throw f_1666_2849_3036(formatString, typeof(RuntimeException), f_1666_2951_2980(), "FormatError", f_1666_2997_3022(), f_1666_3024_3035(sfe));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1666, 2719, 3052);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 2300, 3063);

                string
                f_1666_2567_2615(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2567, 2615);
                    return return_v;
                }


                string
                f_1666_2646_2689(string
                formatSpec, object
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2646, 2689);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1666_2951_2980()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 2951, 2980);
                    return return_v;
                }


                string
                f_1666_2997_3022()
                {
                    var return_v = ParserStrings.FormatError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 2997, 3022);
                    return return_v;
                }


                string
                f_1666_3024_3035(System.FormatException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 3024, 3035);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1666_2849_3036(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 2849, 3036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 2300, 3063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 2300, 3063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int Compare(string strA, string strB, CultureInfo culture, CompareOptions option)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 3519, 3806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 3641, 3726);

                f_1666_3641_3725(culture != null, "Caller makes sure that 'culture' is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 3740, 3795);

                return f_1666_3747_3794(f_1666_3747_3766(culture), strA, strB, option);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 3519, 3806);

                int
                f_1666_3641_3725(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 3641, 3725);
                    return 0;
                }


                System.Globalization.CompareInfo
                f_1666_3747_3766(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CompareInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 3747, 3766);
                    return return_v;
                }


                int
                f_1666_3747_3794(System.Globalization.CompareInfo
                this_param, string
                string1, string
                string2, System.Globalization.CompareOptions
                options)
                {
                    var return_v = this_param.Compare(string1, string2, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 3747, 3794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 3519, 3806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 3519, 3806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Equals(string strA, string strB, CultureInfo culture, CompareOptions option)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1666, 4142, 4434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 4264, 4349);

                f_1666_4264_4348(culture != null, "Caller makes sure that 'culture' is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1666, 4363, 4423);

                return f_1666_4370_4417(f_1666_4370_4389(culture), strA, strB, option) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1666, 4142, 4434);

                int
                f_1666_4264_4348(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 4264, 4348);
                    return 0;
                }


                System.Globalization.CompareInfo
                f_1666_4370_4389(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CompareInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1666, 4370, 4389);
                    return return_v;
                }


                int
                f_1666_4370_4417(System.Globalization.CompareInfo
                this_param, string
                string1, string
                string2, System.Globalization.CompareOptions
                options)
                {
                    var return_v = this_param.Compare(string1, string2, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1666, 4370, 4417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1666, 4142, 4434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 4142, 4434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1666, 393, 4441);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1666, 393, 4441);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1666, 393, 4441);
        }

    }
}
