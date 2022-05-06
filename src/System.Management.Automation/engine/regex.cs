// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Management.Automation.Internal;
using System.Runtime.Serialization;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    /// <summary>
    /// Provides enumerated values to use to set wildcard pattern
    /// matching options.
    /// </summary>
    [Flags]
    public enum WildcardOptions
    {
        /// <summary>
        /// Indicates that no special processing is required.
        /// </summary>
        None = 0,

        /// <summary>
        /// Specifies that the wildcard pattern is compiled to an assembly.
        /// This yields faster execution but increases startup time.
        /// </summary>
        Compiled = 1,

        /// <summary>
        /// Specifies case-insensitive matching.
        /// </summary>
        IgnoreCase = 2,

        /// <summary>
        /// Specifies culture-invariant matching.
        /// </summary>
        CultureInvariant = 4
    };
    public sealed class WildcardPattern
    {
        private const char
        escapeChar = '`'
        ;

        private const int
        StackAllocThreshold = 256
        ;

        private Predicate<string> _isMatch;

        private static readonly char[] s_specialChars;

        private static readonly Predicate<string> s_matchAll;

        internal string Pattern { get; }

        internal WildcardOptions Options { get; }

        internal string PatternConvertedToRegex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 2521, 2681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 2557, 2617);

                    var
                    patternRegex = f_1329_2576_2616(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 2635, 2666);

                    return f_1329_2642_2665(patternRegex);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 2521, 2681);

                    System.Text.RegularExpressions.Regex
                    f_1329_2576_2616(System.Management.Automation.WildcardPattern
                    wildcardPattern)
                    {
                        var return_v = WildcardPatternToRegexParser.Parse(wildcardPattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 2576, 2616);
                        return return_v;
                    }


                    string
                    f_1329_2642_2665(System.Text.RegularExpressions.Regex
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 2642, 2665);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 2457, 2692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 2457, 2692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WildcardPattern(string pattern) : this(f_1329_3059_3066_C(pattern), WildcardOptions.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 3013, 3111);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 3013, 3111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 3013, 3111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 3013, 3111);
            }
        }

        public WildcardPattern(string pattern, WildcardOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 3554, 3849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 1786, 1794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 2161, 2193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 2299, 2340);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 3642, 3772) || true) && (pattern == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 3642, 3772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 3695, 3757);

                    throw f_1329_3701_3756(nameof(pattern));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 3642, 3772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 3788, 3806);

                Pattern = pattern;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 3820, 3838);

                Options = options;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 3554, 3849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 3554, 3849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 3554, 3849);
            }
        }

        private static readonly WildcardPattern s_matchAllIgnoreCasePattern;

        public static WildcardPattern Get(string pattern, WildcardOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 4247, 4626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4346, 4440) || true) && (pattern == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 4346, 4440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4384, 4440);

                    throw f_1329_4390_4439("pattern");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 4346, 4440);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4456, 4554) || true) && (f_1329_4460_4474(pattern) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1329, 4460, 4500) && f_1329_4483_4493(pattern, 0) == '*'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 4456, 4554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4519, 4554);

                    return s_matchAllIgnoreCasePattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 4456, 4554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4570, 4615);

                return f_1329_4577_4614(pattern, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 4247, 4626);

                System.Management.Automation.PSArgumentNullException
                f_1329_4390_4439(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 4390, 4439);
                    return return_v;
                }


                int
                f_1329_4460_4474(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 4460, 4474);
                    return return_v;
                }


                char
                f_1329_4483_4493(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 4483, 4493);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1329_4577_4614(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = new System.Management.Automation.WildcardPattern(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 4577, 4614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 4247, 4626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 4247, 4626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Init()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 4819, 7172);

                StringComparison GetStringComparison()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 4863, 6029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4934, 4968);

                        StringComparison
                        stringComparison
                        = default(StringComparison);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 4986, 5970) || true) && (f_1329_4990_5033(f_1329_4990_4997(), WildcardOptions.IgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 4986, 5970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 5075, 5680);

                            stringComparison = (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 5094, 5143) || ((f_1329_5094_5143(f_1329_5094_5101(), WildcardOptions.CultureInvariant) && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 5171, 5214)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 5242, 5679))) ? StringComparison.InvariantCultureIgnoreCase
                            : (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 5242, 5331) || ((f_1329_5242_5331(f_1329_5242_5273(f_1329_5242_5268()), "en-US-POSIX", StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 5572, 5606)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 5638, 5679))) ? StringComparison.OrdinalIgnoreCase
                            : StringComparison.CurrentCultureIgnoreCase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 4986, 5970);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 4986, 5970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 5762, 5951);

                            stringComparison = (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 5781, 5830) || ((f_1329_5781_5830(f_1329_5781_5788(), WildcardOptions.CultureInvariant) && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 5858, 5891)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 5919, 5950))) ? StringComparison.InvariantCulture
                            : StringComparison.CurrentCulture;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 4986, 5970);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 5990, 6014);

                        return stringComparison;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 4863, 6029);

                        System.Management.Automation.WildcardOptions
                        f_1329_4990_4997()
                        {
                            var return_v = Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 4990, 4997);
                            return return_v;
                        }


                        bool
                        f_1329_4990_5033(System.Management.Automation.WildcardOptions
                        this_param, System.Management.Automation.WildcardOptions
                        flag)
                        {
                            var return_v = this_param.HasFlag((System.Enum)flag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 4990, 5033);
                            return return_v;
                        }


                        System.Management.Automation.WildcardOptions
                        f_1329_5094_5101()
                        {
                            var return_v = Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 5094, 5101);
                            return return_v;
                        }


                        bool
                        f_1329_5094_5143(System.Management.Automation.WildcardOptions
                        this_param, System.Management.Automation.WildcardOptions
                        flag)
                        {
                            var return_v = this_param.HasFlag((System.Enum)flag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 5094, 5143);
                            return return_v;
                        }


                        System.Globalization.CultureInfo
                        f_1329_5242_5268()
                        {
                            var return_v = CultureInfo.CurrentCulture;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 5242, 5268);
                            return return_v;
                        }


                        string
                        f_1329_5242_5273(System.Globalization.CultureInfo
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 5242, 5273);
                            return return_v;
                        }


                        bool
                        f_1329_5242_5331(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.Equals(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 5242, 5331);
                            return return_v;
                        }


                        System.Management.Automation.WildcardOptions
                        f_1329_5781_5788()
                        {
                            var return_v = Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 5781, 5788);
                            return return_v;
                        }


                        bool
                        f_1329_5781_5830(System.Management.Automation.WildcardOptions
                        this_param, System.Management.Automation.WildcardOptions
                        flag)
                        {
                            var return_v = this_param.HasFlag((System.Enum)flag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 5781, 5830);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 4863, 6029);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 4863, 6029);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6045, 6121) || true) && (_isMatch != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 6045, 6121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6099, 6106);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 6045, 6121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6137, 6277) || true) && (f_1329_6141_6155(f_1329_6141_6148()) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1329, 6141, 6181) && f_1329_6164_6174(f_1329_6164_6171(), 0) == '*'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 6137, 6277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6215, 6237);

                    _isMatch = s_matchAll;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6255, 6262);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 6137, 6277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6293, 6340);

                int
                index = f_1329_6305_6339(f_1329_6305_6312(), s_specialChars)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6354, 6617) || true) && (index == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 6354, 6617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6508, 6577);

                    _isMatch = str => string.Equals(str, Pattern, GetStringComparison());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6595, 6602);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 6354, 6617);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6633, 7057) || true) && (index == f_1329_6646_6660(f_1329_6646_6653()) - 1 && (DynAbs.Tracing.TraceSender.Expression_True(1329, 6637, 6689) && f_1329_6668_6682(f_1329_6668_6675(), index) == '*'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 6633, 7057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6841, 6905);

                    var
                    patternWithoutAsterisk = f_1329_6870_6888(f_1329_6870_6877()).Slice(0, index)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 6923, 7017);

                    _isMatch = str => str.AsSpan().StartsWith(patternWithoutAsterisk.Span, GetStringComparison());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 7035, 7042);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 6633, 7057);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 7073, 7120);

                var
                matcher = f_1329_7087_7119(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 7134, 7161);

                _isMatch = matcher.IsMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 4819, 7172);

                string
                f_1329_6141_6148()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6141, 6148);
                    return return_v;
                }


                int
                f_1329_6141_6155(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6141, 6155);
                    return return_v;
                }


                string
                f_1329_6164_6171()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6164, 6171);
                    return return_v;
                }


                char
                f_1329_6164_6174(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6164, 6174);
                    return return_v;
                }


                string
                f_1329_6305_6312()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6305, 6312);
                    return return_v;
                }


                int
                f_1329_6305_6339(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 6305, 6339);
                    return return_v;
                }


                string
                f_1329_6646_6653()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6646, 6653);
                    return return_v;
                }


                int
                f_1329_6646_6660(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6646, 6660);
                    return return_v;
                }


                string
                f_1329_6668_6675()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6668, 6675);
                    return return_v;
                }


                char
                f_1329_6668_6682(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6668, 6682);
                    return return_v;
                }


                string
                f_1329_6870_6877()
                {
                    var return_v = Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 6870, 6877);
                    return return_v;
                }


                System.ReadOnlyMemory<char>
                f_1329_6870_6888(string
                text)
                {
                    var return_v = text.AsMemory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 6870, 6888);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternMatcher
                f_1329_7087_7119(System.Management.Automation.WildcardPattern
                wildcardPattern)
                {
                    var return_v = new System.Management.Automation.WildcardPatternMatcher(wildcardPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 7087, 7119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 4819, 7172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 4819, 7172);
            }
        }

        public bool IsMatch(string input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 7545, 7675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 7603, 7610);

                f_1329_7603_7609(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 7624, 7664);

                return input != null && (DynAbs.Tracing.TraceSender.Expression_True(1329, 7631, 7663) && f_1329_7648_7663(this, input));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 7545, 7675);

                int
                f_1329_7603_7609(System.Management.Automation.WildcardPattern
                this_param)
                {
                    this_param.Init();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 7603, 7609);
                    return 0;
                }


                bool
                f_1329_7648_7663(System.Management.Automation.WildcardPattern
                this_param, string
                obj)
                {
                    var return_v = this_param._isMatch(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 7648, 7663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 7545, 7675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 7545, 7675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Escape(string pattern, char[] charsNotToEscape)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 8283, 9674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8378, 8508) || true) && (pattern == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 8378, 8508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8431, 8493);

                    throw f_1329_8437_8492(nameof(pattern));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 8378, 8508);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8524, 8672) || true) && (charsNotToEscape == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 8524, 8672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8586, 8657);

                    throw f_1329_8592_8656(nameof(charsNotToEscape));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 8524, 8672);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8688, 8779) || true) && (pattern == string.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 8688, 8779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8749, 8764);

                    return pattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 8688, 8779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8795, 8927);

                Span<char>
                temp = (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 8813, 8849) || ((f_1329_8813_8827(pattern) < StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 8852, 8891)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 8894, 8926))) ? stackalloc char[f_1329_8868_8882(pattern) * 2 + 1] : new char[f_1329_8903_8917(pattern) * 2 + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8941, 8959);

                int
                tempIndex = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8984, 8989);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 8975, 9391) || true) && (i < f_1329_8995_9009(pattern))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9011, 9014)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 8975, 9391))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 8975, 9391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9048, 9069);

                        char
                        ch = f_1329_9058_9068(pattern, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9185, 9333) || true) && (f_1329_9189_9207(ch) && (DynAbs.Tracing.TraceSender.Expression_True(1329, 9189, 9241) && !f_1329_9212_9241(charsNotToEscape, ch)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 9185, 9333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9283, 9314);

                            temp[tempIndex++] = escapeChar;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 9185, 9333);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9353, 9376);

                        temp[tempIndex++] = ch;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9407, 9423);

                string
                s = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9439, 9638) || true) && (tempIndex == f_1329_9456_9470(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 9439, 9638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9504, 9516);

                    s = pattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 9439, 9638);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 9439, 9638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9582, 9623);

                    s = f_1329_9586_9622(temp.Slice(0, tempIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 9439, 9638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 9654, 9663);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 8283, 9674);

                System.Management.Automation.PSArgumentNullException
                f_1329_8437_8492(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 8437, 8492);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1329_8592_8656(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 8592, 8656);
                    return return_v;
                }


                int
                f_1329_8813_8827(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 8813, 8827);
                    return return_v;
                }


                int
                f_1329_8868_8882(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 8868, 8882);
                    return return_v;
                }


                int
                f_1329_8903_8917(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 8903, 8917);
                    return return_v;
                }


                int
                f_1329_8995_9009(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 8995, 9009);
                    return return_v;
                }


                char
                f_1329_9058_9068(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 9058, 9068);
                    return return_v;
                }


                bool
                f_1329_9189_9207(char
                ch)
                {
                    var return_v = IsWildcardChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 9189, 9207);
                    return return_v;
                }


                bool
                f_1329_9212_9241(char[]
                source, char
                value)
                {
                    var return_v = source.Contains<char>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 9212, 9241);
                    return return_v;
                }


                int
                f_1329_9456_9470(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 9456, 9470);
                    return return_v;
                }


                string
                f_1329_9586_9622(System.Span<char>
                value)
                {
                    var return_v = new string((System.ReadOnlySpan<char>)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 9586, 9622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 8283, 9674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 8283, 9674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Escape(string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 10054, 10177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10122, 10166);

                return f_1329_10129_10165(pattern, f_1329_10145_10164());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 10054, 10177);

                char[]
                f_1329_10145_10164()
                {
                    var return_v = Array.Empty<char>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 10145, 10164);
                    return return_v;
                }


                string
                f_1329_10129_10165(string
                pattern, char[]
                charsNotToEscape)
                {
                    var return_v = Escape(pattern, charsNotToEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 10129, 10165);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 10054, 10177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 10054, 10177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsWildcardCharacters(string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 10713, 11453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10799, 10894) || true) && (f_1329_10803_10832(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 10799, 10894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10866, 10879);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 10799, 10894);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10910, 10930);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10955, 10964);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10946, 11412) || true) && (index < f_1329_10974_10988(pattern))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 10990, 10997)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 10946, 11412))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 10946, 11412);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 11031, 11168) || true) && (f_1329_11035_11065(f_1329_11050_11064(pattern, index)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 11031, 11168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 11107, 11121);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1329, 11143, 11149);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 11031, 11168);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 11296, 11397) || true) && (f_1329_11300_11314(pattern, index) == escapeChar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 11296, 11397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 11370, 11378);

                            ++index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 11296, 11397);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 11428, 11442);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 10713, 11453);

                bool
                f_1329_10803_10832(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 10803, 10832);
                    return return_v;
                }


                int
                f_1329_10974_10988(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 10974, 10988);
                    return return_v;
                }


                char
                f_1329_11050_11064(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 11050, 11064);
                    return return_v;
                }


                bool
                f_1329_11035_11065(char
                ch)
                {
                    var return_v = IsWildcardChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 11035, 11065);
                    return return_v;
                }


                char
                f_1329_11300_11314(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 11300, 11314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 10713, 11453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 10713, 11453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Unescape(string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 11991, 13954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12061, 12191) || true) && (pattern == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12061, 12191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12114, 12176);

                    throw f_1329_12120_12175(nameof(pattern));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12061, 12191);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12207, 12298) || true) && (pattern == string.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12207, 12298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12268, 12283);

                    return pattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12207, 12298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12314, 12430);

                Span<char>
                temp = (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 12332, 12368) || ((f_1329_12332_12346(pattern) < StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 12371, 12402)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 12405, 12429))) ? stackalloc char[f_1329_12387_12401(pattern)] : new char[f_1329_12414_12428(pattern)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12446, 12464);

                int
                tempIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12478, 12513);

                bool
                prevCharWasEscapeChar = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12538, 12543);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12529, 13400) || true) && (i < f_1329_12549_12563(pattern))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12565, 12568)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12529, 13400))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12529, 13400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12602, 12623);

                        char
                        ch = f_1329_12612_12622(pattern, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12643, 13061) || true) && (ch == escapeChar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12643, 13061);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12705, 13009) || true) && (prevCharWasEscapeChar)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12705, 13009);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12780, 12803);

                                temp[tempIndex++] = ch;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12829, 12859);

                                prevCharWasEscapeChar = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12705, 13009);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 12705, 13009);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 12957, 12986);

                                prevCharWasEscapeChar = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12705, 13009);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13033, 13042);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 12643, 13061);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13081, 13294) || true) && (prevCharWasEscapeChar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 13081, 13294);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13148, 13275) || true) && (!f_1329_13153_13171(ch))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 13148, 13275);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13221, 13252);

                                temp[tempIndex++] = escapeChar;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 13148, 13275);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 13081, 13294);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13314, 13337);

                        temp[tempIndex++] = ch;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13355, 13385);

                        prevCharWasEscapeChar = false;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 872);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13518, 13671) || true) && (prevCharWasEscapeChar)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 13518, 13671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13577, 13608);

                    temp[tempIndex++] = escapeChar;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13626, 13656);

                    prevCharWasEscapeChar = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 13518, 13671);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13687, 13703);

                string
                s = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13719, 13918) || true) && (tempIndex == f_1329_13736_13750(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 13719, 13918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13784, 13796);

                    s = pattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 13719, 13918);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 13719, 13918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13862, 13903);

                    s = f_1329_13866_13902(temp.Slice(0, tempIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 13719, 13918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 13934, 13943);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 11991, 13954);

                System.Management.Automation.PSArgumentNullException
                f_1329_12120_12175(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 12120, 12175);
                    return return_v;
                }


                int
                f_1329_12332_12346(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 12332, 12346);
                    return return_v;
                }


                int
                f_1329_12387_12401(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 12387, 12401);
                    return return_v;
                }


                int
                f_1329_12414_12428(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 12414, 12428);
                    return return_v;
                }


                int
                f_1329_12549_12563(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 12549, 12563);
                    return return_v;
                }


                char
                f_1329_12612_12622(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 12612, 12622);
                    return return_v;
                }


                bool
                f_1329_13153_13171(char
                ch)
                {
                    var return_v = IsWildcardChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 13153, 13171);
                    return return_v;
                }


                int
                f_1329_13736_13750(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 13736, 13750);
                    return return_v;
                }


                string
                f_1329_13866_13902(System.Span<char>
                value)
                {
                    var return_v = new string((System.ReadOnlySpan<char>)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 13866, 13902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 11991, 13954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 11991, 13954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsWildcardChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 13966, 14109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14034, 14098);

                return (ch == '*') || (DynAbs.Tracing.TraceSender.Expression_False(1329, 14041, 14067) || (ch == '?')) || (DynAbs.Tracing.TraceSender.Expression_False(1329, 14041, 14082) || (ch == '[')) || (DynAbs.Tracing.TraceSender.Expression_False(1329, 14041, 14097) || (ch == ']'));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 13966, 14109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 13966, 14109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 13966, 14109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToWql()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 14382, 15085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14428, 14458);

                bool
                needsClientSideFiltering
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14472, 14606);

                string
                likeOperand = f_1329_14493_14605(this, out needsClientSideFiltering)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14620, 15074) || true) && (!needsClientSideFiltering)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 14620, 15074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14683, 14702);

                    return likeOperand;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 14620, 15074);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 14620, 15074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 14768, 15059);

                    throw f_1329_14774_15058("UnsupportedWildcardToWqlConversion", null, f_1329_14909_14948(), f_1329_14971_14983(this), f_1329_15006_15029(f_1329_15006_15020(this)), "WQL");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 14620, 15074);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 14382, 15085);

                string
                f_1329_14493_14605(System.Management.Automation.WildcardPattern
                wildcardPattern, out bool
                needsClientSideFiltering)
                {
                    var return_v = Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser.Parse(wildcardPattern, out needsClientSideFiltering);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 14493, 14605);
                    return return_v;
                }


                string
                f_1329_14909_14948()
                {
                    var return_v = ExtendedTypeSystem.InvalidCastException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 14909, 14948);
                    return return_v;
                }


                string
                f_1329_14971_14983(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 14971, 14983);
                    return return_v;
                }


                System.Type
                f_1329_15006_15020(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 15006, 15020);
                    return return_v;
                }


                string
                f_1329_15006_15029(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 15006, 15029);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1329_14774_15058(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 14774, 15058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 14382, 15085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 14382, 15085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WildcardPattern()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 1405, 15092);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 1520, 1536);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 1665, 1690);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 1906, 1956);
            s_specialChars = new[] { '*', '?', '[', ']', '`' };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 2097, 2119);
            s_matchAll = _ => true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 3901, 3977);
            s_matchAllIgnoreCasePattern = f_1329_3931_3977("*", WildcardOptions.None);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 1405, 15092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 1405, 15092);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 1405, 15092);

        static string
        f_1329_3059_3066_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1329, 3013, 3111);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1329_3701_3756(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 3701, 3756);
            return return_v;
        }


        static System.Management.Automation.WildcardPattern
        f_1329_3931_3977(string
        pattern, System.Management.Automation.WildcardOptions
        options)
        {
            var return_v = new System.Management.Automation.WildcardPattern(pattern, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 3931, 3977);
            return return_v;
        }

    }
    [Serializable]
    public class WildcardPatternException : RuntimeException
    {
        internal WildcardPatternException(ErrorRecord errorRecord)
        : base(f_1329_15850_15878_C(f_1329_15850_15878(errorRecord)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 15771, 16077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16134, 16146);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 15904, 16023) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 15904, 16023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 15961, 16008);

                    throw f_1329_15967_16007("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 15904, 16023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16039, 16066);

                _errorRecord = errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 15771, 16077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 15771, 16077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 15771, 16077);
            }
        }

        [NonSerialized]
        private ErrorRecord _errorRecord;

        public WildcardPatternException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 16282, 16337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16134, 16146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 16282, 16337);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 16282, 16337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 16282, 16337);
            }
        }

        public WildcardPatternException(string message) : base(f_1329_16691_16698_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 16636, 16721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16134, 16146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 16636, 16721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 16636, 16721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 16636, 16721);
            }
        }

        public WildcardPatternException(string message,
                                                Exception innerException)
        : base(f_1329_17236_17243_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 17101, 17282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16134, 16146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 17101, 17282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 17101, 17282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 17101, 17282);
            }
        }

        protected WildcardPatternException(SerializationInfo info,
                                                StreamingContext context)
        : base(f_1329_17695_17699_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 17549, 17731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 16134, 16146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 17549, 17731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 17549, 17731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 17549, 17731);
            }
        }

        static WildcardPatternException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 15191, 17738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 15191, 17738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 15191, 17738);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 15191, 17738);

        static string
        f_1329_15850_15878(System.Management.Automation.ErrorRecord
        errorRecord)
        {
            var return_v = RetrieveMessage(errorRecord);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 15850, 15878);
            return return_v;
        }


        System.ArgumentNullException
        f_1329_15967_16007(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 15967, 16007);
            return return_v;
        }


        static string
        f_1329_15850_15878_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1329, 15771, 16077);
            return return_v;
        }


        static string
        f_1329_16691_16698_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1329, 16636, 16721);
            return return_v;
        }


        static string
        f_1329_17236_17243_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1329, 17101, 17282);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1329_17695_17699_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1329, 17549, 17731);
            return return_v;
        }

    }
    internal abstract class WildcardPatternParser
    {
        protected virtual void BeginWildcardPattern(WildcardPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 18420, 18510);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 18420, 18510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 18420, 18510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 18420, 18510);
            }
        }

        protected abstract void AppendLiteralCharacter(char c);

        protected abstract void AppendAsterix();

        protected abstract void AppendQuestionMark();

        protected virtual void EndWildcardPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 19549, 19614);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 19549, 19614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 19549, 19614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 19549, 19614);
            }
        }

        protected abstract void BeginBracketExpression();

        protected abstract void AppendLiteralCharacterToBracketExpression(char c);

        protected abstract void AppendCharacterRangeToBracketExpression(
                                char startOfCharacterRange,
                                char endOfCharacterRange);

        protected abstract void EndBracketExpression();

        internal void AppendBracketExpression(string brackedExpressionContents, string bracketExpressionOperators, string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 22046, 23192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22193, 22223);

                f_1329_22193_22222(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22239, 22249);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22263, 23137) || true) && (i < f_1329_22274_22306(brackedExpressionContents))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 22263, 23137);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22340, 23122) || true) && (((i + 2) < f_1329_22355_22387(brackedExpressionContents)) && (DynAbs.Tracing.TraceSender.Expression_True(1329, 22344, 22467) && (f_1329_22426_22459(bracketExpressionOperators, i + 1) == '-')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 22340, 23122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22509, 22556);

                            char
                            lowerBound = f_1329_22527_22555(brackedExpressionContents, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22578, 22629);

                            char
                            upperBound = f_1329_22596_22628(brackedExpressionContents, i + 2)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22651, 22658);

                            i += 3;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22682, 22825) || true) && (lowerBound > upperBound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 22682, 22825);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22759, 22802);

                                throw f_1329_22765_22801(pattern);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 22682, 22825);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 22849, 22918);

                            f_1329_22849_22917(
                                                this, lowerBound, upperBound);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 22340, 23122);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 22340, 23122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23000, 23077);

                            f_1329_23000_23076(this, f_1329_23047_23075(brackedExpressionContents, i));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23099, 23103);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 22340, 23122);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 22263, 23137);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 22263, 23137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 22263, 23137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23153, 23181);

                f_1329_23153_23180(
                            this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 22046, 23192);

                int
                f_1329_22193_22222(System.Management.Automation.WildcardPatternParser
                this_param)
                {
                    this_param.BeginBracketExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 22193, 22222);
                    return 0;
                }


                int
                f_1329_22274_22306(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 22274, 22306);
                    return return_v;
                }


                int
                f_1329_22355_22387(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 22355, 22387);
                    return return_v;
                }


                char
                f_1329_22426_22459(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 22426, 22459);
                    return return_v;
                }


                char
                f_1329_22527_22555(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 22527, 22555);
                    return return_v;
                }


                char
                f_1329_22596_22628(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 22596, 22628);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternException
                f_1329_22765_22801(string
                invalidPattern)
                {
                    var return_v = NewWildcardPatternException(invalidPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 22765, 22801);
                    return return_v;
                }


                int
                f_1329_22849_22917(System.Management.Automation.WildcardPatternParser
                this_param, char
                startOfCharacterRange, char
                endOfCharacterRange)
                {
                    this_param.AppendCharacterRangeToBracketExpression(startOfCharacterRange, endOfCharacterRange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 22849, 22917);
                    return 0;
                }


                char
                f_1329_23047_23075(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 23047, 23075);
                    return return_v;
                }


                int
                f_1329_23000_23076(System.Management.Automation.WildcardPatternParser
                this_param, char
                c)
                {
                    this_param.AppendLiteralCharacterToBracketExpression(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 23000, 23076);
                    return 0;
                }


                int
                f_1329_23153_23180(System.Management.Automation.WildcardPatternParser
                this_param)
                {
                    this_param.EndBracketExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 23153, 23180);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 22046, 23192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 22046, 23192);
            }
        }

        public static void Parse(WildcardPattern pattern, WildcardPatternParser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 23495, 26972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23599, 23636);

                f_1329_23599_23635(parser, pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23652, 23693);

                bool
                previousCharacterIsAnEscape = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23707, 23762);

                bool
                previousCharacterStartedBracketExpression = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23776, 23810);

                bool
                insideCharacterRange = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23824, 23868);

                StringBuilder
                characterRangeContents = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23882, 23927);

                StringBuilder
                characterRangeOperators = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 23941, 26417);
                    foreach (char c in f_1329_23960_23975_I(f_1329_23960_23975(pattern)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 23941, 26417);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24009, 26307) || true) && (insideCharacterRange)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 24009, 26307);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24075, 25254) || true) && (c == ']' && (DynAbs.Tracing.TraceSender.Expression_True(1329, 24079, 24133) && !previousCharacterStartedBracketExpression) && (DynAbs.Tracing.TraceSender.Expression_True(1329, 24079, 24165) && !previousCharacterIsAnEscape))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 24075, 25254);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24655, 24684);

                                insideCharacterRange = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24710, 24829);

                                f_1329_24710_24828(parser, f_1329_24741_24774(characterRangeContents), f_1329_24776_24810(characterRangeOperators), f_1329_24812_24827(pattern));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24855, 24885);

                                characterRangeContents = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24911, 24942);

                                characterRangeOperators = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 24075, 25254);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 24075, 25254);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 24992, 25254) || true) && (c != '`' || (DynAbs.Tracing.TraceSender.Expression_False(1329, 24996, 25035) || previousCharacterIsAnEscape))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 24992, 25254);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25085, 25118);

                                    f_1329_25085_25117(characterRangeContents, c);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25144, 25231);

                                    f_1329_25144_25230(characterRangeOperators, (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 25175, 25217) || (((c == '-') && (DynAbs.Tracing.TraceSender.Expression_True(1329, 25175, 25217) && !previousCharacterIsAnEscape) && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 25220, 25223)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 25226, 25229))) ? '-' : ' ');
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 24992, 25254);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 24075, 25254);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25278, 25328);

                            previousCharacterStartedBracketExpression = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 24009, 26307);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 24009, 26307);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25410, 26288) || true) && (c == '*' && (DynAbs.Tracing.TraceSender.Expression_True(1329, 25414, 25454) && !previousCharacterIsAnEscape))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25410, 26288);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25504, 25527);

                                f_1329_25504_25526(parser);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25410, 26288);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25410, 26288);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25577, 26288) || true) && (c == '?' && (DynAbs.Tracing.TraceSender.Expression_True(1329, 25581, 25621) && !previousCharacterIsAnEscape))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25577, 26288);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25671, 25699);

                                    f_1329_25671_25698(parser);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25577, 26288);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25577, 26288);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25749, 26288) || true) && (c == '[' && (DynAbs.Tracing.TraceSender.Expression_True(1329, 25753, 25793) && !previousCharacterIsAnEscape))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25749, 26288);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25843, 25871);

                                        insideCharacterRange = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25897, 25942);

                                        characterRangeContents = f_1329_25922_25941();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 25968, 26014);

                                        characterRangeOperators = f_1329_25994_26013();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26040, 26089);

                                        previousCharacterStartedBracketExpression = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25749, 26288);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 25749, 26288);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26139, 26288) || true) && (c != '`' || (DynAbs.Tracing.TraceSender.Expression_False(1329, 26143, 26182) || previousCharacterIsAnEscape))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 26139, 26288);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26232, 26265);

                                            f_1329_26232_26264(parser, c);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 26139, 26288);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25749, 26288);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25577, 26288);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 25410, 26288);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 24009, 26307);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26327, 26402);

                        previousCharacterIsAnEscape = (c == '`') && (DynAbs.Tracing.TraceSender.Expression_True(1329, 26357, 26401) && (!previousCharacterIsAnEscape));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 23941, 26417);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 2477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 2477);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26433, 26557) || true) && (insideCharacterRange)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 26433, 26557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26491, 26542);

                    throw f_1329_26497_26541(f_1329_26525_26540(pattern));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 26433, 26557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26573, 26917) || true) && (previousCharacterIsAnEscape)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 26573, 26917);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26638, 26902) || true) && (!f_1329_26643_26696(f_1329_26643_26658(pattern), "`", StringComparison.Ordinal))
                    ) // Win7 backcompatibility requires treating '`' pattern as '' pattern

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 26638, 26902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26808, 26883);

                        f_1329_26808_26882(parser, f_1329_26838_26881(f_1329_26838_26853(pattern), f_1329_26854_26876(f_1329_26854_26869(pattern)) - 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 26638, 26902);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 26573, 26917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 26933, 26961);

                f_1329_26933_26960(
                            parser);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 23495, 26972);

                int
                f_1329_23599_23635(System.Management.Automation.WildcardPatternParser
                this_param, System.Management.Automation.WildcardPattern
                pattern)
                {
                    this_param.BeginWildcardPattern(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 23599, 23635);
                    return 0;
                }


                string
                f_1329_23960_23975(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 23960, 23975);
                    return return_v;
                }


                string
                f_1329_24741_24774(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 24741, 24774);
                    return return_v;
                }


                string
                f_1329_24776_24810(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 24776, 24810);
                    return return_v;
                }


                string
                f_1329_24812_24827(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 24812, 24827);
                    return return_v;
                }


                int
                f_1329_24710_24828(System.Management.Automation.WildcardPatternParser
                this_param, string
                brackedExpressionContents, string
                bracketExpressionOperators, string
                pattern)
                {
                    this_param.AppendBracketExpression(brackedExpressionContents, bracketExpressionOperators, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 24710, 24828);
                    return 0;
                }


                System.Text.StringBuilder
                f_1329_25085_25117(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25085, 25117);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_25144_25230(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25144, 25230);
                    return return_v;
                }


                int
                f_1329_25504_25526(System.Management.Automation.WildcardPatternParser
                this_param)
                {
                    this_param.AppendAsterix();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25504, 25526);
                    return 0;
                }


                int
                f_1329_25671_25698(System.Management.Automation.WildcardPatternParser
                this_param)
                {
                    this_param.AppendQuestionMark();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25671, 25698);
                    return 0;
                }


                System.Text.StringBuilder
                f_1329_25922_25941()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25922, 25941);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_25994_26013()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 25994, 26013);
                    return return_v;
                }


                int
                f_1329_26232_26264(System.Management.Automation.WildcardPatternParser
                this_param, char
                c)
                {
                    this_param.AppendLiteralCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 26232, 26264);
                    return 0;
                }


                string
                f_1329_23960_23975_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 23960, 23975);
                    return return_v;
                }


                string
                f_1329_26525_26540(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26525, 26540);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternException
                f_1329_26497_26541(string
                invalidPattern)
                {
                    var return_v = NewWildcardPatternException(invalidPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 26497, 26541);
                    return return_v;
                }


                string
                f_1329_26643_26658(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26643, 26658);
                    return return_v;
                }


                bool
                f_1329_26643_26696(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 26643, 26696);
                    return return_v;
                }


                string
                f_1329_26838_26853(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26838, 26853);
                    return return_v;
                }


                string
                f_1329_26854_26869(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26854, 26869);
                    return return_v;
                }


                int
                f_1329_26854_26876(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26854, 26876);
                    return return_v;
                }


                char
                f_1329_26838_26881(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 26838, 26881);
                    return return_v;
                }


                int
                f_1329_26808_26882(System.Management.Automation.WildcardPatternParser
                this_param, char
                c)
                {
                    this_param.AppendLiteralCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 26808, 26882);
                    return 0;
                }


                int
                f_1329_26933_26960(System.Management.Automation.WildcardPatternParser
                this_param)
                {
                    this_param.EndWildcardPattern();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 26933, 26960);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 23495, 26972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 23495, 26972);
            }
        }

        internal static WildcardPatternException NewWildcardPatternException(string invalidPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 26984, 27736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 27100, 27246);

                string
                message =
                f_1329_27134_27245(f_1329_27152_27189(), invalidPattern)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 27262, 27368);

                ParentContainsErrorRecordException
                pce =
                f_1329_27320_27367(message)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 27384, 27605);

                ErrorRecord
                er =
                f_1329_27418_27604(pce, "WildcardPattern_Invalid", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 27621, 27700);

                WildcardPatternException
                e =
                f_1329_27667_27699(er)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 27716, 27725);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 26984, 27736);

                string
                f_1329_27152_27189()
                {
                    var return_v = WildcardPatternStrings.InvalidPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 27152, 27189);
                    return return_v;
                }


                string
                f_1329_27134_27245(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 27134, 27245);
                    return return_v;
                }


                System.Management.Automation.ParentContainsErrorRecordException
                f_1329_27320_27367(string
                message)
                {
                    var return_v = new System.Management.Automation.ParentContainsErrorRecordException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 27320, 27367);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1329_27418_27604(System.Management.Automation.ParentContainsErrorRecordException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 27418, 27604);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternException
                f_1329_27667_27699(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.WildcardPatternException(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 27667, 27699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 26984, 27736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 26984, 27736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WildcardPatternParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 17862, 27744);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 17862, 27744);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 17862, 27744);
        }


        static WildcardPatternParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 17862, 27744);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 17862, 27744);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 17862, 27744);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 17862, 27744);
    }
    ; internal class WildcardPatternToRegexParser : WildcardPatternParser
    {
        private StringBuilder _regexPattern;

        private RegexOptions _regexOptions;

        private const string
        regexChars = "()[.?*{}^$+|\\"
        ;

        private static bool IsRegexChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 28521, 28813);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28595, 28600);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28586, 28773) || true) && (i < f_1329_28606_28623(regexChars))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28625, 28628)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 28586, 28773))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 28586, 28773);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28662, 28758) || true) && (ch == f_1329_28672_28685(regexChars, i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 28662, 28758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28727, 28739);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 28662, 28758);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 188);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28789, 28802);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 28521, 28813);

                int
                f_1329_28606_28623(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 28606, 28623);
                    return return_v;
                }


                char
                f_1329_28672_28685(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 28672, 28685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 28521, 28813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 28521, 28813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RegexOptions TranslateWildcardOptionsIntoRegexOptions(WildcardOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 28825, 29538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28944, 28996);

                RegexOptions
                regexOptions = RegexOptions.Singleline
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29012, 29144) || true) && ((options & WildcardOptions.Compiled) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 29012, 29144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29091, 29129);

                    regexOptions |= RegexOptions.Compiled;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 29012, 29144);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29160, 29296) || true) && ((options & WildcardOptions.IgnoreCase) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 29160, 29296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29241, 29281);

                    regexOptions |= RegexOptions.IgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 29160, 29296);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29312, 29491) || true) && ((options & WildcardOptions.CultureInvariant) == WildcardOptions.CultureInvariant)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 29312, 29491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29430, 29476);

                    regexOptions |= RegexOptions.CultureInvariant;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 29312, 29491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29507, 29527);

                return regexOptions;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 28825, 29538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 28825, 29538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 28825, 29538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void BeginWildcardPattern(WildcardPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 29550, 29851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29644, 29710);

                _regexPattern = f_1329_29660_29709(f_1329_29678_29700(f_1329_29678_29693(pattern)) * 2 + 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29724, 29750);

                f_1329_29724_29749(_regexPattern, '^');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29766, 29840);

                _regexOptions = f_1329_29782_29839(f_1329_29823_29838(pattern));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 29550, 29851);

                string
                f_1329_29678_29693(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 29678, 29693);
                    return return_v;
                }


                int
                f_1329_29678_29700(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 29678, 29700);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_29660_29709(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 29660, 29709);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_29724_29749(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 29724, 29749);
                    return return_v;
                }


                System.Management.Automation.WildcardOptions
                f_1329_29823_29838(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 29823, 29838);
                    return return_v;
                }


                System.Text.RegularExpressions.RegexOptions
                f_1329_29782_29839(System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = TranslateWildcardOptionsIntoRegexOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 29782, 29839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 29550, 29851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 29550, 29851);
            }
        }

        internal static void AppendLiteralCharacter(StringBuilder regexPattern, char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 29863, 30110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 29967, 30060) || true) && (f_1329_29971_29985(c))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 29967, 30060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30019, 30045);

                    f_1329_30019_30044(regexPattern, '\\');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 29967, 30060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30076, 30099);

                f_1329_30076_30098(
                            regexPattern, c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 29863, 30110);

                bool
                f_1329_29971_29985(char
                ch)
                {
                    var return_v = IsRegexChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 29971, 29985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_30019_30044(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30019, 30044);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_30076_30098(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30076, 30098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 29863, 30110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 29863, 30110);
            }
        }

        protected override void AppendLiteralCharacter(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 30122, 30253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30201, 30242);

                f_1329_30201_30241(_regexPattern, c);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 30122, 30253);

                int
                f_1329_30201_30241(System.Text.StringBuilder
                regexPattern, char
                c)
                {
                    AppendLiteralCharacter(regexPattern, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30201, 30241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 30122, 30253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 30122, 30253);
            }
        }

        protected override void AppendAsterix()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 30265, 30367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30329, 30356);

                f_1329_30329_30355(_regexPattern, ".*");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 30265, 30367);

                System.Text.StringBuilder
                f_1329_30329_30355(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30329, 30355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 30265, 30367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 30265, 30367);
            }
        }

        protected override void AppendQuestionMark()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 30379, 30485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30448, 30474);

                f_1329_30448_30473(_regexPattern, '.');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 30379, 30485);

                System.Text.StringBuilder
                f_1329_30448_30473(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30448, 30473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 30379, 30485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 30379, 30485);
            }
        }

        protected override void EndWildcardPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 30497, 31461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30566, 30592);

                f_1329_30566_30591(_regexPattern, '$');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30829, 30882);

                string
                regexPatternString = f_1329_30857_30881(_regexPattern)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30896, 31450) || true) && (f_1329_30900_30959(regexPatternString, "^.*$", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 30896, 31450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 30993, 31020);

                    f_1329_30993_31019(_regexPattern, 0, 4);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 30896, 31450);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 30896, 31450);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31086, 31240) || true) && (f_1329_31090_31152(regexPatternString, "^.*", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31086, 31240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31194, 31221);

                        f_1329_31194_31220(_regexPattern, 0, 3);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31086, 31240);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31260, 31435) || true) && (f_1329_31264_31324(regexPatternString, ".*$", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31260, 31435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31366, 31416);

                        f_1329_31366_31415(_regexPattern, f_1329_31387_31407(_regexPattern) - 3, 3);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31260, 31435);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 30896, 31450);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 30497, 31461);

                System.Text.StringBuilder
                f_1329_30566_30591(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30566, 30591);
                    return return_v;
                }


                string
                f_1329_30857_30881(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30857, 30881);
                    return return_v;
                }


                bool
                f_1329_30900_30959(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30900, 30959);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_30993_31019(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 30993, 31019);
                    return return_v;
                }


                bool
                f_1329_31090_31152(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31090, 31152);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_31194_31220(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31194, 31220);
                    return return_v;
                }


                bool
                f_1329_31264_31324(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31264, 31324);
                    return return_v;
                }


                int
                f_1329_31387_31407(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 31387, 31407);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_31366_31415(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31366, 31415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 30497, 31461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 30497, 31461);
            }
        }

        protected override void BeginBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 31473, 31583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31546, 31572);

                f_1329_31546_31571(_regexPattern, '[');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 31473, 31583);

                System.Text.StringBuilder
                f_1329_31546_31571(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31546, 31571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 31473, 31583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 31473, 31583);
            }
        }

        internal static void AppendLiteralCharacterToBracketExpression(StringBuilder regexPattern, char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 31595, 32137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31718, 32126) || true) && (c == '[')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31718, 32126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31764, 31789);

                    f_1329_31764_31788(regexPattern, '[');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31718, 32126);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31718, 32126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31823, 32126) || true) && (c == ']')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31823, 32126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31869, 31896);

                        f_1329_31869_31895(regexPattern, @"\]");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31823, 32126);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31823, 32126);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31930, 32126) || true) && (c == '-')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31930, 32126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 31976, 32005);

                            f_1329_31976_32004(regexPattern, @"\x2d");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31930, 32126);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 31930, 32126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32071, 32111);

                            f_1329_32071_32110(regexPattern, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31930, 32126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31823, 32126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 31718, 32126);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 31595, 32137);

                System.Text.StringBuilder
                f_1329_31764_31788(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31764, 31788);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_31869_31895(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31869, 31895);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1329_31976_32004(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 31976, 32004);
                    return return_v;
                }


                int
                f_1329_32071_32110(System.Text.StringBuilder
                regexPattern, char
                c)
                {
                    AppendLiteralCharacter(regexPattern, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32071, 32110);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 31595, 32137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 31595, 32137);
            }
        }

        protected override void AppendLiteralCharacterToBracketExpression(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 32149, 32318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32247, 32307);

                f_1329_32247_32306(_regexPattern, c);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 32149, 32318);

                int
                f_1329_32247_32306(System.Text.StringBuilder
                regexPattern, char
                c)
                {
                    AppendLiteralCharacterToBracketExpression(regexPattern, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32247, 32306);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 32149, 32318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 32149, 32318);
            }
        }

        internal static void AppendCharacterRangeToBracketExpression(
                                StringBuilder regexPattern,
                                char startOfCharacterRange,
                                char endOfCharacterRange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 32330, 32793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32573, 32652);

                f_1329_32573_32651(regexPattern, startOfCharacterRange);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32666, 32691);

                f_1329_32666_32690(regexPattern, '-');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32705, 32782);

                f_1329_32705_32781(regexPattern, endOfCharacterRange);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 32330, 32793);

                int
                f_1329_32573_32651(System.Text.StringBuilder
                regexPattern, char
                c)
                {
                    AppendLiteralCharacterToBracketExpression(regexPattern, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32573, 32651);
                    return 0;
                }


                System.Text.StringBuilder
                f_1329_32666_32690(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32666, 32690);
                    return return_v;
                }


                int
                f_1329_32705_32781(System.Text.StringBuilder
                regexPattern, char
                c)
                {
                    AppendLiteralCharacterToBracketExpression(regexPattern, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32705, 32781);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 32330, 32793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 32330, 32793);
            }
        }

        protected override void AppendCharacterRangeToBracketExpression(
                                char startOfCharacterRange,
                                char endOfCharacterRange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 32805, 33108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 32998, 33097);

                f_1329_32998_33096(_regexPattern, startOfCharacterRange, endOfCharacterRange);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 32805, 33108);

                int
                f_1329_32998_33096(System.Text.StringBuilder
                regexPattern, char
                startOfCharacterRange, char
                endOfCharacterRange)
                {
                    AppendCharacterRangeToBracketExpression(regexPattern, startOfCharacterRange, endOfCharacterRange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 32998, 33096);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 32805, 33108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 32805, 33108);
            }
        }

        protected override void EndBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 33120, 33228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 33191, 33217);

                f_1329_33191_33216(_regexPattern, ']');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 33120, 33228);

                System.Text.StringBuilder
                f_1329_33191_33216(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33191, 33216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 33120, 33228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 33120, 33228);
            }
        }

        public static Regex Parse(WildcardPattern wildcardPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 33549, 34097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 33632, 33705);

                WildcardPatternToRegexParser
                parser = f_1329_33670_33704()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 33719, 33772);

                f_1329_33719_33771(wildcardPattern, parser);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 33822, 33903);

                    return f_1329_33829_33902(f_1329_33848_33879(parser._regexPattern), parser._regexOptions);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1329, 33932, 34086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 33990, 34071);

                    throw f_1329_33996_34070(f_1329_34046_34069(wildcardPattern));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1329, 33932, 34086);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 33549, 34097);

                System.Management.Automation.WildcardPatternToRegexParser
                f_1329_33670_33704()
                {
                    var return_v = new System.Management.Automation.WildcardPatternToRegexParser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33670, 33704);
                    return return_v;
                }


                int
                f_1329_33719_33771(System.Management.Automation.WildcardPattern
                pattern, System.Management.Automation.WildcardPatternToRegexParser
                parser)
                {
                    WildcardPatternParser.Parse(pattern, (System.Management.Automation.WildcardPatternParser)parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33719, 33771);
                    return 0;
                }


                string
                f_1329_33848_33879(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33848, 33879);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1329_33829_33902(string
                patternString, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = ParserOps.NewRegex(patternString, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33829, 33902);
                    return return_v;
                }


                string
                f_1329_34046_34069(System.Management.Automation.WildcardPattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 34046, 34069);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternException
                f_1329_33996_34070(string
                invalidPattern)
                {
                    var return_v = WildcardPatternParser.NewWildcardPatternException(invalidPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 33996, 34070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 33549, 34097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 33549, 34097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WildcardPatternToRegexParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 28254, 34104);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28360, 28373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28405, 28418);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 28254, 34104);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 28254, 34104);
        }


        static WildcardPatternToRegexParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 28254, 34104);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 28452, 28481);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 28254, 34104);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 28254, 34104);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 28254, 34104);
    }
    internal class WildcardPatternMatcher
    {
        private readonly PatternElement[] _patternElements;

        private readonly CharacterNormalizer _characterNormalizer;

        internal WildcardPatternMatcher(WildcardPattern wildcardPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 34297, 34630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 34200, 34216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 34386, 34458);

                _characterNormalizer = f_1329_34409_34457(f_1329_34433_34456(wildcardPattern));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 34472, 34619);

                _patternElements = f_1329_34491_34618(wildcardPattern, _characterNormalizer);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 34297, 34630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 34297, 34630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 34297, 34630);
            }
        }

        internal bool IsMatch(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 34642, 38261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 35844, 35965);

                var
                patternPositionsForCurrentStringPosition =
                f_1329_35912_35964(f_1329_35940_35963(_patternElements))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 35979, 36027);

                f_1329_35979_36026(patternPositionsForCurrentStringPosition, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36043, 36161);

                var
                patternPositionsForNextStringPosition =
                f_1329_36108_36160(f_1329_36136_36159(_patternElements))
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36222, 36247);
                        for (int
        currentStringPosition = 0
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36213, 37598) || true) && (currentStringPosition < f_1329_36294_36304(str))
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36327, 36350)
        , currentStringPosition++, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 36213, 37598))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 36213, 37598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36392, 36481);

                            char
                            currentStringCharacter = _characterNormalizer.Normalize(f_1329_36453_36479(str, currentStringPosition))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36503, 36583);

                            patternPositionsForCurrentStringPosition.StringPosition = currentStringPosition;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36605, 36686);

                            patternPositionsForNextStringPosition.StringPosition = currentStringPosition + 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36710, 36730);

                            int
                            patternPosition
                            = default(int);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36752, 37198) || true) && (f_1329_36759_36829(patternPositionsForCurrentStringPosition, out patternPosition))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 36752, 37198);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 36879, 37175);

                                    f_1329_36879_37174(_patternElements[patternPosition], currentStringCharacter, patternPosition, patternPositionsForCurrentStringPosition, patternPositionsForNextStringPosition);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 36752, 37198);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 36752, 37198);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 36752, 37198);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37359, 37410);

                            var
                            tmp = patternPositionsForCurrentStringPosition
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37432, 37513);

                            patternPositionsForCurrentStringPosition = patternPositionsForNextStringPosition;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37535, 37579);

                            patternPositionsForNextStringPosition = tmp;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 1386);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 1386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37618, 37639);

                    int
                    patternPosition2
                    = default(int);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37657, 37961) || true) && (f_1329_37664_37735(patternPositionsForCurrentStringPosition, out patternPosition2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 37657, 37961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37777, 37942);

                            f_1329_37777_37941(_patternElements[patternPosition2], patternPosition2, patternPositionsForCurrentStringPosition);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 37657, 37961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 37657, 37961);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 37657, 37961);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 37981, 38049);

                    return f_1329_37988_38048(patternPositionsForCurrentStringPosition);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1329, 38078, 38250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38118, 38169);

                    f_1329_38118_38168(patternPositionsForCurrentStringPosition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38187, 38235);

                    f_1329_38187_38234(patternPositionsForNextStringPosition);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1329, 38078, 38250);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 34642, 38261);

                int
                f_1329_35940_35963(System.Management.Automation.WildcardPatternMatcher.PatternElement[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 35940, 35963);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                f_1329_35912_35964(int
                lengthOfPattern)
                {
                    var return_v = new System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor(lengthOfPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 35912, 35964);
                    return return_v;
                }


                int
                f_1329_35979_36026(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param, int
                patternPosition)
                {
                    this_param.Add(patternPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 35979, 36026);
                    return 0;
                }


                int
                f_1329_36136_36159(System.Management.Automation.WildcardPatternMatcher.PatternElement[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 36136, 36159);
                    return return_v;
                }


                System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                f_1329_36108_36160(int
                lengthOfPattern)
                {
                    var return_v = new System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor(lengthOfPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 36108, 36160);
                    return return_v;
                }


                int
                f_1329_36294_36304(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 36294, 36304);
                    return return_v;
                }


                char
                f_1329_36453_36479(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 36453, 36479);
                    return return_v;
                }


                bool
                f_1329_36759_36829(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param, out int
                patternPosition)
                {
                    var return_v = this_param.MoveNext(out patternPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 36759, 36829);
                    return return_v;
                }


                int
                f_1329_36879_37174(System.Management.Automation.WildcardPatternMatcher.PatternElement
                this_param, char
                currentStringCharacter, int
                currentPatternPosition, System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                patternPositionsForCurrentStringPosition, System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                patternPositionsForNextStringPosition)
                {
                    this_param.ProcessStringCharacter(currentStringCharacter, currentPatternPosition, patternPositionsForCurrentStringPosition, patternPositionsForNextStringPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 36879, 37174);
                    return 0;
                }


                bool
                f_1329_37664_37735(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param, out int
                patternPosition)
                {
                    var return_v = this_param.MoveNext(out patternPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 37664, 37735);
                    return return_v;
                }


                int
                f_1329_37777_37941(System.Management.Automation.WildcardPatternMatcher.PatternElement
                this_param, int
                currentPatternPosition, System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                patternPositionsForEndOfStringPosition)
                {
                    this_param.ProcessEndOfString(currentPatternPosition, patternPositionsForEndOfStringPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 37777, 37941);
                    return 0;
                }


                bool
                f_1329_37988_38048(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param)
                {
                    var return_v = this_param.ReachedEndOfPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 37988, 38048);
                    return return_v;
                }


                int
                f_1329_38118_38168(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 38118, 38168);
                    return 0;
                }


                int
                f_1329_38187_38234(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 38187, 38234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 34642, 38261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 34642, 38261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class PatternPositionsVisitor : IDisposable
        {
            private readonly int _lengthOfPattern;

            private readonly int[] _isPatternPositionVisitedMarker;

            private readonly int[] _patternPositionsForFurtherProcessing;

            private int _patternPositionsForFurtherProcessingCount;

            public PatternPositionsVisitor(int lengthOfPattern)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 38620, 39286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38370, 38386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38426, 38457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38497, 38534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38561, 38603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39571, 39618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38704, 38782);

                    f_1329_38704_38781(lengthOfPattern >= 0, "Caller should verify lengthOfPattern >= 0");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38802, 38837);

                    _lengthOfPattern = lengthOfPattern;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38857, 38940);

                    _isPatternPositionVisitedMarker = f_1329_38891_38939(f_1329_38891_38912(), _lengthOfPattern + 1);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38967, 38972);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38958, 39101) || true) && (i <= _lengthOfPattern)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 38997, 39000)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 38958, 39101))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 38958, 39101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39042, 39082);

                            _isPatternPositionVisitedMarker[i] = -1;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1329, 1, 144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1329, 1, 144);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39121, 39206);

                    _patternPositionsForFurtherProcessing = f_1329_39161_39205(f_1329_39161_39182(), _lengthOfPattern);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39224, 39271);

                    _patternPositionsForFurtherProcessingCount = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 38620, 39286);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 38620, 39286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 38620, 39286);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 39302, 39555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39356, 39436);

                    f_1329_39356_39435(f_1329_39356_39377(), _isPatternPositionVisitedMarker, clearArray: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39454, 39540);

                    f_1329_39454_39539(f_1329_39454_39475(), _patternPositionsForFurtherProcessing, clearArray: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 39302, 39555);

                    System.Buffers.ArrayPool<int>
                    f_1329_39356_39377()
                    {
                        var return_v = ArrayPool<int>.Shared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 39356, 39377);
                        return return_v;
                    }


                    int
                    f_1329_39356_39435(System.Buffers.ArrayPool<int>
                    this_param, int[]
                    array, bool
                    clearArray)
                    {
                        this_param.Return(array, clearArray: clearArray);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 39356, 39435);
                        return 0;
                    }


                    System.Buffers.ArrayPool<int>
                    f_1329_39454_39475()
                    {
                        var return_v = ArrayPool<int>.Shared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 39454, 39475);
                        return return_v;
                    }


                    int
                    f_1329_39454_39539(System.Buffers.ArrayPool<int>
                    this_param, int[]
                    array, bool
                    clearArray)
                    {
                        this_param.Return(array, clearArray: clearArray);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 39454, 39539);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 39302, 39555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 39302, 39555);
                }
            }

            public int StringPosition { private get; set; }

            public void Add(int patternPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 39634, 40941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39703, 39781);

                    f_1329_39703_39780(patternPosition >= 0, "Caller should verify patternPosition >= 0");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 39799, 39963);

                    f_1329_39799_39962(patternPosition <= _lengthOfPattern, "Caller should verify patternPosition <= this._lengthOfPattern");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40039, 40182) || true) && (_isPatternPositionVisitedMarker[patternPosition] == f_1329_40095_40114(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 40039, 40182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40156, 40163);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 40039, 40182);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40254, 40325);

                    _isPatternPositionVisitedMarker[patternPosition] = f_1329_40305_40324(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40421, 40926) || true) && (patternPosition < _lengthOfPattern)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 40421, 40926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40501, 40601);

                        _patternPositionsForFurtherProcessing[_patternPositionsForFurtherProcessingCount] = patternPosition;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40623, 40668);

                        _patternPositionsForFurtherProcessingCount++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 40690, 40907);

                        f_1329_40690_40906(_patternPositionsForFurtherProcessingCount <= _lengthOfPattern, "There should never be more elements in the queue than the length of the pattern");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 40421, 40926);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 39634, 40941);

                    int
                    f_1329_39703_39780(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 39703, 39780);
                        return 0;
                    }


                    int
                    f_1329_39799_39962(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 39799, 39962);
                        return 0;
                    }


                    int
                    f_1329_40095_40114(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param)
                    {
                        var return_v = this_param.StringPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 40095, 40114);
                        return return_v;
                    }


                    int
                    f_1329_40305_40324(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param)
                    {
                        var return_v = this_param.StringPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 40305, 40324);
                        return return_v;
                    }


                    int
                    f_1329_40690_40906(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 40690, 40906);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 39634, 40941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 39634, 40941);
                }
            }

            public bool ReachedEndOfPattern
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 41021, 41164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41065, 41145);

                        return _isPatternPositionVisitedMarker[_lengthOfPattern] >= f_1329_41125_41144(this);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 41021, 41164);

                        int
                        f_1329_41125_41144(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                        this_param)
                        {
                            var return_v = this_param.StringPosition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 41125, 41144);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 40957, 41179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 40957, 41179);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext(out int patternPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 41316, 42004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41394, 41588);

                    f_1329_41394_41587(_patternPositionsForFurtherProcessingCount >= 0, "There should never be more elements in the queue than the length of the pattern");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41608, 41776) || true) && (_patternPositionsForFurtherProcessingCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 41608, 41776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41701, 41722);

                        patternPosition = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41744, 41757);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 41608, 41776);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41796, 41841);

                    _patternPositionsForFurtherProcessingCount--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41859, 41959);

                    patternPosition = _patternPositionsForFurtherProcessing[_patternPositionsForFurtherProcessingCount];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 41977, 41989);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 41316, 42004);

                    int
                    f_1329_41394_41587(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 41394, 41587);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 41316, 42004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 41316, 42004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PatternPositionsVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 38273, 42015);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 38273, 42015);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 38273, 42015);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 38273, 42015);

            int
            f_1329_38704_38781(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Dbg.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 38704, 38781);
                return 0;
            }


            System.Buffers.ArrayPool<int>
            f_1329_38891_38912()
            {
                var return_v = ArrayPool<int>.Shared;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 38891, 38912);
                return return_v;
            }


            int[]
            f_1329_38891_38939(System.Buffers.ArrayPool<int>
            this_param, int
            minimumLength)
            {
                var return_v = this_param.Rent(minimumLength);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 38891, 38939);
                return return_v;
            }


            System.Buffers.ArrayPool<int>
            f_1329_39161_39182()
            {
                var return_v = ArrayPool<int>.Shared;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 39161, 39182);
                return return_v;
            }


            int[]
            f_1329_39161_39205(System.Buffers.ArrayPool<int>
            this_param, int
            minimumLength)
            {
                var return_v = this_param.Rent(minimumLength);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 39161, 39205);
                return return_v;
            }

        }
        private abstract class PatternElement
        {
            public abstract void ProcessStringCharacter(
                                        char currentStringCharacter,
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForCurrentStringPosition,
                                        PatternPositionsVisitor patternPositionsForNextStringPosition);

            public abstract void ProcessEndOfString(
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForEndOfStringPosition);

            public PatternElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 42027, 42654);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 42027, 42654);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 42027, 42654);
            }


            static PatternElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 42027, 42654);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 42027, 42654);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 42027, 42654);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 42027, 42654);
        }
        private class QuestionMarkElement : PatternElement
        {
            public override void ProcessStringCharacter(
                                        char currentStringCharacter,
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForCurrentStringPosition,
                                        PatternPositionsVisitor patternPositionsForNextStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 42741, 43310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 43225, 43295);

                    f_1329_43225_43294(                // '?' : (patternPosition, stringPosition) => (patternPosition + 1, stringPosition + 1)
                                    patternPositionsForNextStringPosition, currentPatternPosition + 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 42741, 43310);

                    int
                    f_1329_43225_43294(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param, int
                    patternPosition)
                    {
                        this_param.Add(patternPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 43225, 43294);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 42741, 43310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 42741, 43310);
                }
            }

            public override void ProcessEndOfString(
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForEndOfStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 43326, 43676);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 43326, 43676);
                    // '?' : (patternPosition, endOfString) => <no transitions out of this state - cannot move beyond end of string>
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 43326, 43676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 43326, 43676);
                }
            }

            public QuestionMarkElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 42666, 43687);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 42666, 43687);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 42666, 43687);
            }


            static QuestionMarkElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 42666, 43687);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 42666, 43687);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 42666, 43687);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 42666, 43687);
        }
        private class LiteralCharacterElement : QuestionMarkElement
        {
            private readonly char _literalCharacter;

            public LiteralCharacterElement(char literalCharacter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 43839, 43977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 43805, 43822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 43925, 43962);

                    _literalCharacter = literalCharacter;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 43839, 43977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 43839, 43977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 43839, 43977);
                }
            }

            public override void ProcessStringCharacter(
                                        char currentStringCharacter,
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForCurrentStringPosition,
                                        PatternPositionsVisitor patternPositionsForNextStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 43993, 44769);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 44372, 44754) || true) && (_literalCharacter == currentStringCharacter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 44372, 44754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 44461, 44735);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessStringCharacter(currentStringCharacter, currentPatternPosition, patternPositionsForCurrentStringPosition, patternPositionsForNextStringPosition), 1329, 44461, 44734);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 44372, 44754);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 43993, 44769);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 43993, 44769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 43993, 44769);
                }
            }

            static LiteralCharacterElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 43699, 44780);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 43699, 44780);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 43699, 44780);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 43699, 44780);
        }
        private class BracketExpressionElement : QuestionMarkElement
        {
            private readonly Regex _regex;

            public BracketExpressionElement(Regex regex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 44923, 45112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 44900, 44906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 45000, 45064);

                    f_1329_45000_45063(regex != null, "Caller should verify regex != null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 45082, 45097);

                    _regex = regex;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 44923, 45112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 44923, 45112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 44923, 45112);
                }
            }

            public override void ProcessStringCharacter(
                                        char currentStringCharacter,
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForCurrentStringPosition,
                                        PatternPositionsVisitor patternPositionsForNextStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 45128, 45895);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 45507, 45880) || true) && (f_1329_45511_45564(_regex, f_1329_45526_45563(currentStringCharacter, 1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 45507, 45880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 45606, 45861);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessStringCharacter(currentStringCharacter, currentPatternPosition, patternPositionsForCurrentStringPosition, patternPositionsForNextStringPosition), 1329, 45606, 45860);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 45507, 45880);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 45128, 45895);

                    string
                    f_1329_45526_45563(char
                    c, int
                    count)
                    {
                        var return_v = new string(c, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 45526, 45563);
                        return return_v;
                    }


                    bool
                    f_1329_45511_45564(System.Text.RegularExpressions.Regex
                    this_param, string
                    input)
                    {
                        var return_v = this_param.IsMatch(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 45511, 45564);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 45128, 45895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 45128, 45895);
                }
            }

            static BracketExpressionElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 44792, 45906);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 44792, 45906);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 44792, 45906);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 44792, 45906);

            int
            f_1329_45000_45063(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Dbg.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 45000, 45063);
                return 0;
            }

        }
        private class AsterixElement : PatternElement
        {
            public override void ProcessStringCharacter(
                                        char currentStringCharacter,
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForCurrentStringPosition,
                                        PatternPositionsVisitor patternPositionsForNextStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 45988, 46743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 46468, 46541);

                    f_1329_46468_46540(                // '*' : (patternPosition, stringPosition) => (patternPosition + 1, stringPosition)
                                    patternPositionsForCurrentStringPosition, currentPatternPosition + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 46662, 46728);

                    f_1329_46662_46727(
                                    // '*' : (patternPosition, stringPosition) => (patternPosition, stringPosition + 1)
                                    patternPositionsForNextStringPosition, currentPatternPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 45988, 46743);

                    int
                    f_1329_46468_46540(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param, int
                    patternPosition)
                    {
                        this_param.Add(patternPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 46468, 46540);
                        return 0;
                    }


                    int
                    f_1329_46662_46727(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param, int
                    patternPosition)
                    {
                        this_param.Add(patternPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 46662, 46727);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 45988, 46743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 45988, 46743);
                }
            }

            public override void ProcessEndOfString(
                                        int currentPatternPosition,
                                        PatternPositionsVisitor patternPositionsForEndOfStringPosition)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 46759, 47163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 47077, 47148);

                    f_1329_47077_47147(                // '*' : (patternPosition, endOfString) => (patternPosition + 1, endOfString)
                                    patternPositionsForEndOfStringPosition, currentPatternPosition + 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 46759, 47163);

                    int
                    f_1329_47077_47147(System.Management.Automation.WildcardPatternMatcher.PatternPositionsVisitor
                    this_param, int
                    patternPosition)
                    {
                        this_param.Add(patternPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 47077, 47147);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 46759, 47163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 46759, 47163);
                }
            }

            public AsterixElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 45918, 47174);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 45918, 47174);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 45918, 47174);
            }


            static AsterixElement()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 45918, 47174);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 45918, 47174);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 45918, 47174);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 45918, 47174);
        }
        private class MyWildcardPatternParser : WildcardPatternParser
        {
            private readonly List<PatternElement> _patternElements;

            private CharacterNormalizer _characterNormalizer;

            private RegexOptions _regexOptions;

            private StringBuilder _bracketExpressionBuilder;

            public static PatternElement[] Parse(
                                        WildcardPattern pattern,
                                        CharacterNormalizer characterNormalizer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 47546, 48146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 47740, 48009);

                    var
                    parser = new MyWildcardPatternParser
                    {
                        _characterNormalizer = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => characterNormalizer, 1329, 47753, 48008),
                        _regexOptions = f_1329_47902_47988(f_1329_47972_47987(pattern))
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48027, 48072);

                    f_1329_48027_48071(pattern, parser);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48090, 48131);

                    return f_1329_48097_48130(parser._patternElements);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 47546, 48146);

                    System.Management.Automation.WildcardOptions
                    f_1329_47972_47987(System.Management.Automation.WildcardPattern
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 47972, 47987);
                        return return_v;
                    }


                    System.Text.RegularExpressions.RegexOptions
                    f_1329_47902_47988(System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPatternToRegexParser.TranslateWildcardOptionsIntoRegexOptions(options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 47902, 47988);
                        return return_v;
                    }


                    int
                    f_1329_48027_48071(System.Management.Automation.WildcardPattern
                    pattern, System.Management.Automation.WildcardPatternMatcher.MyWildcardPatternParser
                    parser)
                    {
                        WildcardPatternParser.Parse(pattern, (System.Management.Automation.WildcardPatternParser)parser);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48027, 48071);
                        return 0;
                    }


                    System.Management.Automation.WildcardPatternMatcher.PatternElement[]
                    f_1329_48097_48130(System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48097, 48130);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 47546, 48146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 47546, 48146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override void AppendLiteralCharacter(char c)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 48162, 48373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48249, 48287);

                    c = _characterNormalizer.Normalize(c);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48305, 48358);

                    f_1329_48305_48357(_patternElements, f_1329_48326_48356(c));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 48162, 48373);

                    System.Management.Automation.WildcardPatternMatcher.LiteralCharacterElement
                    f_1329_48326_48356(char
                    literalCharacter)
                    {
                        var return_v = new System.Management.Automation.WildcardPatternMatcher.LiteralCharacterElement(literalCharacter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48326, 48356);
                        return return_v;
                    }


                    int
                    f_1329_48305_48357(System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
                    this_param, System.Management.Automation.WildcardPatternMatcher.LiteralCharacterElement
                    item)
                    {
                        this_param.Add((System.Management.Automation.WildcardPatternMatcher.PatternElement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48305, 48357);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 48162, 48373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 48162, 48373);
                }
            }

            protected override void AppendAsterix()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 48389, 48519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48461, 48504);

                    f_1329_48461_48503(_patternElements, f_1329_48482_48502());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 48389, 48519);

                    System.Management.Automation.WildcardPatternMatcher.AsterixElement
                    f_1329_48482_48502()
                    {
                        var return_v = new System.Management.Automation.WildcardPatternMatcher.AsterixElement();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48482, 48502);
                        return return_v;
                    }


                    int
                    f_1329_48461_48503(System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
                    this_param, System.Management.Automation.WildcardPatternMatcher.AsterixElement
                    item)
                    {
                        this_param.Add((System.Management.Automation.WildcardPatternMatcher.PatternElement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48461, 48503);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 48389, 48519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 48389, 48519);
                }
            }

            protected override void AppendQuestionMark()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 48535, 48675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48612, 48660);

                    f_1329_48612_48659(_patternElements, f_1329_48633_48658());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 48535, 48675);

                    System.Management.Automation.WildcardPatternMatcher.QuestionMarkElement
                    f_1329_48633_48658()
                    {
                        var return_v = new System.Management.Automation.WildcardPatternMatcher.QuestionMarkElement();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48633, 48658);
                        return return_v;
                    }


                    int
                    f_1329_48612_48659(System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
                    this_param, System.Management.Automation.WildcardPatternMatcher.QuestionMarkElement
                    item)
                    {
                        this_param.Add((System.Management.Automation.WildcardPatternMatcher.PatternElement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48612, 48659);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 48535, 48675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 48535, 48675);
                }
            }

            protected override void BeginBracketExpression()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 48691, 48891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48772, 48820);

                    _bracketExpressionBuilder = f_1329_48800_48819();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 48838, 48876);

                    f_1329_48838_48875(_bracketExpressionBuilder, '[');
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 48691, 48891);

                    System.Text.StringBuilder
                    f_1329_48800_48819()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48800, 48819);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1329_48838_48875(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 48838, 48875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 48691, 48891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 48691, 48891);
                }
            }

            protected override void AppendLiteralCharacterToBracketExpression(char c)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 48907, 49172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 49013, 49157);

                    f_1329_49013_49156(_bracketExpressionBuilder, c);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 48907, 49172);

                    int
                    f_1329_49013_49156(System.Text.StringBuilder
                    regexPattern, char
                    c)
                    {
                        WildcardPatternToRegexParser.AppendLiteralCharacterToBracketExpression(regexPattern, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49013, 49156);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 48907, 49172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 48907, 49172);
                }
            }

            protected override void AppendCharacterRangeToBracketExpression(
                                        char startOfCharacterRange,
                                        char endOfCharacterRange)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 49188, 49616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 49397, 49601);

                    f_1329_49397_49600(_bracketExpressionBuilder, startOfCharacterRange, endOfCharacterRange);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 49188, 49616);

                    int
                    f_1329_49397_49600(System.Text.StringBuilder
                    regexPattern, char
                    startOfCharacterRange, char
                    endOfCharacterRange)
                    {
                        WildcardPatternToRegexParser.AppendCharacterRangeToBracketExpression(regexPattern, startOfCharacterRange, endOfCharacterRange);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49397, 49600);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 49188, 49616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 49188, 49616);
                }
            }

            protected override void EndBracketExpression()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 49632, 49944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 49711, 49749);

                    f_1329_49711_49748(_bracketExpressionBuilder, ']');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 49767, 49853);

                    Regex
                    regex = f_1329_49781_49852(f_1329_49800_49836(_bracketExpressionBuilder), _regexOptions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 49871, 49929);

                    f_1329_49871_49928(_patternElements, f_1329_49892_49927(regex));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 49632, 49944);

                    System.Text.StringBuilder
                    f_1329_49711_49748(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49711, 49748);
                        return return_v;
                    }


                    string
                    f_1329_49800_49836(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49800, 49836);
                        return return_v;
                    }


                    System.Text.RegularExpressions.Regex
                    f_1329_49781_49852(string
                    patternString, System.Text.RegularExpressions.RegexOptions
                    options)
                    {
                        var return_v = ParserOps.NewRegex(patternString, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49781, 49852);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPatternMatcher.BracketExpressionElement
                    f_1329_49892_49927(System.Text.RegularExpressions.Regex
                    regex)
                    {
                        var return_v = new System.Management.Automation.WildcardPatternMatcher.BracketExpressionElement(regex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49892, 49927);
                        return return_v;
                    }


                    int
                    f_1329_49871_49928(System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
                    this_param, System.Management.Automation.WildcardPatternMatcher.BracketExpressionElement
                    item)
                    {
                        this_param.Add((System.Management.Automation.WildcardPatternMatcher.PatternElement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 49871, 49928);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 49632, 49944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 49632, 49944);
                }
            }

            public MyWildcardPatternParser()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 47186, 49955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 47310, 47355);
                this._patternElements = f_1329_47329_47355();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 47454, 47467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 47504, 47529);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 47186, 49955);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 47186, 49955);
            }


            static MyWildcardPatternParser()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 47186, 49955);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 47186, 49955);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 47186, 49955);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 47186, 49955);

            System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>
            f_1329_47329_47355()
            {
                var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPatternMatcher.PatternElement>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 47329, 47355);
                return return_v;
            }

        }

        private struct CharacterNormalizer
        {

            private readonly CultureInfo _cultureInfo;

            private readonly bool _caseInsensitive;

            public CharacterNormalizer(WildcardOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 50137, 50750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50221, 50284);

                    _caseInsensitive = 0 != (options & WildcardOptions.IgnoreCase);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50302, 50735) || true) && (_caseInsensitive)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 50302, 50735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50364, 50539);

                        _cultureInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(1329, 50379, 50428) || ((0 != (options & WildcardOptions.CultureInvariant)
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1329, 50456, 50484)) || DynAbs.Tracing.TraceSender.Conditional_F3(1329, 50512, 50538))) ? f_1329_50456_50484() : f_1329_50512_50538();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 50302, 50735);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 50302, 50735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50696, 50716);

                        _cultureInfo = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 50302, 50735);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 50137, 50750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 50137, 50750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 50137, 50750);
                }
            }

            [Pure]
            public char Normalize(char x)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 50766, 51013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50848, 50969) || true) && (_caseInsensitive)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1329, 50848, 50969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50910, 50950);

                        return f_1329_50917_50949(f_1329_50917_50938(_cultureInfo), x);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1329, 50848, 50969);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 50989, 50998);

                    return x;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 50766, 51013);

                    System.Globalization.TextInfo
                    f_1329_50917_50938(System.Globalization.CultureInfo
                    this_param)
                    {
                        var return_v = this_param.TextInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 50917, 50938);
                        return return_v;
                    }


                    char
                    f_1329_50917_50949(System.Globalization.TextInfo
                    this_param, char
                    c)
                    {
                        var return_v = this_param.ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 50917, 50949);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 50766, 51013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 50766, 51013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static CharacterNormalizer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 49967, 51024);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 49967, 51024);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 49967, 51024);
            }

            static System.Globalization.CultureInfo
            f_1329_50456_50484()
            {
                var return_v = CultureInfo.InvariantCulture
                ;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 50456, 50484);
                return return_v;
            }


            static System.Globalization.CultureInfo
            f_1329_50512_50538()
            {
                var return_v = CultureInfo.CurrentCulture;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 50512, 50538);
                return return_v;
            }

        }

        static WildcardPatternMatcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 34112, 51031);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 34112, 51031);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 34112, 51031);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 34112, 51031);

        System.Management.Automation.WildcardOptions
        f_1329_34433_34456(System.Management.Automation.WildcardPattern
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1329, 34433, 34456);
            return return_v;
        }


        System.Management.Automation.WildcardPatternMatcher.CharacterNormalizer
        f_1329_34409_34457(System.Management.Automation.WildcardOptions
        options)
        {
            var return_v = new System.Management.Automation.WildcardPatternMatcher.CharacterNormalizer(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 34409, 34457);
            return return_v;
        }


        System.Management.Automation.WildcardPatternMatcher.PatternElement[]
        f_1329_34491_34618(System.Management.Automation.WildcardPattern
        pattern, System.Management.Automation.WildcardPatternMatcher.CharacterNormalizer
        characterNormalizer)
        {
            var return_v = MyWildcardPatternParser.Parse(pattern, characterNormalizer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 34491, 34618);
            return return_v;
        }

    }
    internal class WildcardPatternToDosWildcardParser : WildcardPatternParser
    {
        private readonly StringBuilder _result;

        protected override void AppendLiteralCharacter(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51314, 51422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 51393, 51411);

                f_1329_51393_51410(_result, c);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51314, 51422);

                System.Text.StringBuilder
                f_1329_51393_51410(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 51393, 51410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51314, 51422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51314, 51422);
            }
        }

        protected override void AppendAsterix()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51434, 51529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 51498, 51518);

                f_1329_51498_51517(_result, '*');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51434, 51529);

                System.Text.StringBuilder
                f_1329_51498_51517(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 51498, 51517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51434, 51529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51434, 51529);
            }
        }

        protected override void AppendQuestionMark()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51541, 51641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 51610, 51630);

                f_1329_51610_51629(_result, '?');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51541, 51641);

                System.Text.StringBuilder
                f_1329_51610_51629(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 51610, 51629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51541, 51641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51541, 51641);
            }
        }

        protected override void BeginBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51653, 51723);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51653, 51723);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51653, 51723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51653, 51723);
            }
        }

        protected override void AppendLiteralCharacterToBracketExpression(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51735, 51830);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51735, 51830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51735, 51830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51735, 51830);
            }
        }

        protected override void AppendCharacterRangeToBracketExpression(char startOfCharacterRange, char endOfCharacterRange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51842, 51981);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51842, 51981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51842, 51981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51842, 51981);
            }
        }

        protected override void EndBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1329, 51993, 52095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 52064, 52084);

                f_1329_52064_52083(_result, '?');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1329, 51993, 52095);

                System.Text.StringBuilder
                f_1329_52064_52083(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 52064, 52083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 51993, 52095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51993, 52095);
            }
        }

        internal static string Parse(WildcardPattern wildcardPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1329, 52232, 52497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 52318, 52372);

                var
                parser = f_1329_52331_52371()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 52386, 52439);

                f_1329_52386_52438(wildcardPattern, parser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 52453, 52486);

                return f_1329_52460_52485(parser._result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1329, 52232, 52497);

                System.Management.Automation.WildcardPatternToDosWildcardParser
                f_1329_52331_52371()
                {
                    var return_v = new System.Management.Automation.WildcardPatternToDosWildcardParser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 52331, 52371);
                    return return_v;
                }


                int
                f_1329_52386_52438(System.Management.Automation.WildcardPattern
                pattern, System.Management.Automation.WildcardPatternToDosWildcardParser
                parser)
                {
                    WildcardPatternParser.Parse(pattern, (System.Management.Automation.WildcardPatternParser)parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 52386, 52438);
                    return 0;
                }


                string
                f_1329_52460_52485(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 52460, 52485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1329, 52232, 52497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 52232, 52497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WildcardPatternToDosWildcardParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1329, 51151, 52504);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1329, 51272, 51301);
            this._result = f_1329_51282_51301();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1329, 51151, 52504);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51151, 52504);
        }


        static WildcardPatternToDosWildcardParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1329, 51151, 52504);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1329, 51151, 52504);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1329, 51151, 52504);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1329, 51151, 52504);

        System.Text.StringBuilder
        f_1329_51282_51301()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1329, 51282, 51301);
            return return_v;
        }

    }
}

