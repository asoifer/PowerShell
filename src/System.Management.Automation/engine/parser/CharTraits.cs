// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Language
{
    internal static class SpecialChars
    {
        internal const char
        NoBreakSpace = (char)0x00a0
        ;

        internal const char
        NextLine = (char)0x0085
        ;

        internal const char
        EnDash = (char)0x2013
        ;

        internal const char
        EmDash = (char)0x2014
        ;

        internal const char
        HorizontalBar = (char)0x2015
        ;

        internal const char
        QuoteSingleLeft = (char)0x2018
        ;

        internal const char
        QuoteSingleRight = (char)0x2019
        ;

        internal const char
        QuoteSingleBase = (char)0x201a
        ;

        internal const char
        QuoteReversed = (char)0x201b
        ;

        internal const char
        QuoteDoubleLeft = (char)0x201c
        ;

        internal const char
        QuoteDoubleRight = (char)0x201d
        ;

        internal const char
        QuoteLowDoubleLeft = (char)0x201E
        ;

        static SpecialChars()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1544, 156, 1234);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 259, 286);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 317, 340);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 400, 421);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 452, 473);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 504, 532);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 592, 622);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 683, 714);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 776, 806);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 868, 896);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 968, 998);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 1059, 1090);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 1152, 1185);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1544, 156, 1234);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 156, 1234);
        }

    }

    [Flags]
    internal enum CharTraits
    {
        /// <summary>
        /// No specific character traits.
        /// </summary>
        None = 0x0000,

        /// <summary>
        /// For identifiers, the first character must be a letter or underscore.
        /// </summary>
        IdentifierStart = 0x0002,

        /// <summary>
        /// The character is a valid first character of a multiplier.
        /// </summary>
        MultiplierStart = 0x0004,

        /// <summary>
        /// The character is a valid type suffix for numeric literals.
        /// </summary>
        TypeSuffix = 0x0008,

        /// <summary>
        /// The character is a whitespace character.
        /// </summary>
        Whitespace = 0x0010,

        /// <summary>
        /// The character terminates a line.
        /// </summary>
        Newline = 0x0020,

        /// <summary>
        /// The character is a hexadecimal digit.
        /// </summary>
        HexDigit = 0x0040,

        /// <summary>
        /// The character is a decimal digit.
        /// </summary>
        Digit = 0x0080,

        /// <summary>
        /// The character is allowed as the first character in an unbraced variable name.
        /// </summary>
        VarNameFirst = 0x0100,

        /// <summary>
        /// The character is not part of the token being scanned.
        /// </summary>
        ForceStartNewToken = 0x0200,

        /// <summary>
        /// The character is not part of the token being scanned, when the token is known to be part of an assembly name.
        /// </summary>
        ForceStartNewAssemblyNameSpecToken = 0x0400,

        /// <summary>
        /// The character is the first character of some operator (and hence is not part of a token that starts a number).
        /// </summary>
        ForceStartNewTokenAfterNumber = 0x0800,
    }
    internal static class CharExtensions
    {
        static CharExtensions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1544, 3218, 3366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 3415, 12141);
                s_traits = new CharTraits[]
                        {
/*      0x0 */ CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0x1 */ CharTraits.None,
/*      0x2 */ CharTraits.None,
/*      0x3 */ CharTraits.None,
/*      0x4 */ CharTraits.None,
/*      0x5 */ CharTraits.None,
/*      0x6 */ CharTraits.None,
/*      0x7 */ CharTraits.None,
/*      0x8 */ CharTraits.None,
/*      0x9 */ CharTraits.Whitespace | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0xA */ CharTraits.Newline | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0xB */ CharTraits.Whitespace | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0xC */ CharTraits.Whitespace | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0xD */ CharTraits.Newline | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*      0xE */ CharTraits.None,
/*      0xF */ CharTraits.None,
/*     0x10 */ CharTraits.None,
/*     0x11 */ CharTraits.None,
/*     0x12 */ CharTraits.None,
/*     0x13 */ CharTraits.None,
/*     0x14 */ CharTraits.None,
/*     0x15 */ CharTraits.None,
/*     0x16 */ CharTraits.None,
/*     0x17 */ CharTraits.None,
/*     0x18 */ CharTraits.None,
/*     0x19 */ CharTraits.None,
/*     0x1A */ CharTraits.None,
/*     0x1B */ CharTraits.None,
/*     0x1C */ CharTraits.None,
/*     0x1D */ CharTraits.None,
/*     0x1E */ CharTraits.None,
/*     0x1F */ CharTraits.None,
/*          */ CharTraits.Whitespace | CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*        ! */ CharTraits.ForceStartNewTokenAfterNumber,
/*        " */ CharTraits.None,
/*        # */ CharTraits.ForceStartNewTokenAfterNumber,
/*        $ */ CharTraits.VarNameFirst,
/*        % */ CharTraits.ForceStartNewTokenAfterNumber,
/*        & */ CharTraits.ForceStartNewToken,
/*        ' */ CharTraits.None,
/*        ( */ CharTraits.ForceStartNewToken,
/*        ) */ CharTraits.ForceStartNewToken,
/*        * */ CharTraits.ForceStartNewTokenAfterNumber,
/*        + */ CharTraits.ForceStartNewTokenAfterNumber,
/*        , */ CharTraits.ForceStartNewToken | CharTraits.ForceStartNewAssemblyNameSpecToken,
/*        - */ CharTraits.ForceStartNewTokenAfterNumber,
/*        . */ CharTraits.ForceStartNewTokenAfterNumber,
/*        / */ CharTraits.ForceStartNewTokenAfterNumber,
/*        0 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        1 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        2 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        3 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        4 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        5 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        6 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        7 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        8 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        9 */ CharTraits.Digit | CharTraits.HexDigit | CharTraits.VarNameFirst,
/*        : */ CharTraits.VarNameFirst,
/*        ; */ CharTraits.ForceStartNewToken,
/*        < */ CharTraits.ForceStartNewTokenAfterNumber,
/*        = */ CharTraits.ForceStartNewAssemblyNameSpecToken | CharTraits.ForceStartNewTokenAfterNumber,
/*        > */ CharTraits.ForceStartNewTokenAfterNumber,
/*        ? */ CharTraits.VarNameFirst,
/*        @ */ CharTraits.None,
/*        A */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        B */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        C */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        D */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit | CharTraits.TypeSuffix,
/*        E */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        F */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        G */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        H */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        I */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        J */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        K */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        L */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        M */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        N */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        O */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        P */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        Q */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        R */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        S */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        T */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        U */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        V */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        W */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        X */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        Y */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        Z */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        [ */ CharTraits.None,
/*        \ */ CharTraits.None,
/*        ] */ CharTraits.ForceStartNewAssemblyNameSpecToken | CharTraits.ForceStartNewTokenAfterNumber,
/*        ^ */ CharTraits.VarNameFirst,
/*        _ */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        ` */ CharTraits.None,
/*        a */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        b */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        c */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        d */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit | CharTraits.TypeSuffix,
/*        e */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        f */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.HexDigit,
/*        g */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        h */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        i */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        j */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        k */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        l */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        m */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        n */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        o */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        p */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        q */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        r */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        s */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        t */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.MultiplierStart,
/*        u */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        v */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        w */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        x */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        y */ CharTraits.IdentifierStart | CharTraits.VarNameFirst | CharTraits.TypeSuffix,
/*        z */ CharTraits.IdentifierStart | CharTraits.VarNameFirst,
/*        { */ CharTraits.ForceStartNewToken,
/*        | */ CharTraits.ForceStartNewToken,
/*        } */ CharTraits.ForceStartNewToken,
/*        ~ */ CharTraits.None,
/*     0x7F */ CharTraits.None,
                        };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 3266, 3355);

                f_1544_3266_3354(f_1544_3285_3300(s_traits) == 128, "Extension methods rely on this table size.");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1544, 3218, 3366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 3218, 3366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 3218, 3366);
            }
        }

        private static readonly CharTraits[] s_traits;

        public static bool IsCurlyBracket(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 12154, 12261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12220, 12250);

                return (c == '{' || (DynAbs.Tracing.TraceSender.Expression_False(1544, 12228, 12248) || c == '}'));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 12154, 12261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 12154, 12261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 12154, 12261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsWhitespace(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 12382, 12789);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12453, 12563) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 12453, 12563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12498, 12548);

                    return (s_traits[c] & CharTraits.Whitespace) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 12453, 12563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12579, 12735) || true) && (c <= 256)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 12579, 12735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12625, 12720);

                    return (c == SpecialChars.NoBreakSpace
                    || (DynAbs.Tracing.TraceSender.Expression_False(1544, 12633, 12718) || c == SpecialChars.NextLine));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 12579, 12735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12751, 12778);

                return f_1544_12758_12777(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 12382, 12789);

                bool
                f_1544_12758_12777(char
                c)
                {
                    var return_v = char.IsSeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 12758, 12777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 12382, 12789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 12382, 12789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDash(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 12903, 13139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 12968, 13128);

                return (c == '-'
                || (DynAbs.Tracing.TraceSender.Expression_False(1544, 12976, 13029) || c == SpecialChars.EnDash
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 12976, 13074) || c == SpecialChars.EmDash
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 12976, 13126) || c == SpecialChars.HorizontalBar));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 12903, 13139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 12903, 13139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 12903, 13139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSingleQuote(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 13261, 13578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 13333, 13567);

                return (c == '\''
                || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13341, 13404) || c == SpecialChars.QuoteSingleLeft
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13341, 13459) || c == SpecialChars.QuoteSingleRight
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13341, 13513) || c == SpecialChars.QuoteSingleBase
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13341, 13565) || c == SpecialChars.QuoteReversed));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 13261, 13578);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 13261, 13578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 13261, 13578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDoubleQuote(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 13700, 13967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 13772, 13956);

                return (c == '"'
                || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13780, 13842) || c == SpecialChars.QuoteDoubleLeft
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13780, 13897) || c == SpecialChars.QuoteDoubleRight
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1544, 13780, 13954) || c == SpecialChars.QuoteLowDoubleLeft));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 13700, 13967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 13700, 13967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 13700, 13967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVariableStart(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 14110, 14354);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14184, 14296) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 14184, 14296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14229, 14281);

                    return (s_traits[c] & CharTraits.VarNameFirst) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 14184, 14296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14312, 14343);

                return f_1544_14319_14342(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 14110, 14354);

                bool
                f_1544_14319_14342(char
                c)
                {
                    var return_v = char.IsLetterOrDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 14319, 14342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 14110, 14354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 14110, 14354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIdentifierStart(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 14473, 14715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14549, 14664) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 14549, 14664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14594, 14649);

                    return (s_traits[c] & CharTraits.IdentifierStart) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 14549, 14664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14680, 14704);

                return f_1544_14687_14703(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 14473, 14715);

                bool
                f_1544_14687_14703(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 14687, 14703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 14473, 14715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 14473, 14715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsIdentifierFollow(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 14838, 15109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14915, 15051) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 14915, 15051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 14960, 15036);

                    return (s_traits[c] & (CharTraits.IdentifierStart | CharTraits.Digit)) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 14915, 15051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15067, 15098);

                return f_1544_15074_15097(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 14838, 15109);

                bool
                f_1544_15074_15097(char
                c)
                {
                    var return_v = char.IsLetterOrDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 15074, 15097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 14838, 15109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 14838, 15109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsHexDigit(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 15186, 15403);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15255, 15363) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 15255, 15363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15300, 15348);

                    return (s_traits[c] & CharTraits.HexDigit) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 15255, 15363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15379, 15392);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 15186, 15403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 15186, 15403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 15186, 15403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDecimalDigit(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1544, 15526, 15549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15529, 15549);
                return (uint)(c - '0') <= 9;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1544, 15526, 15549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 15526, 15549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 15526, 15549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBinaryDigit(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1544, 15945, 15968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 15948, 15968);
                return (uint)(c - '0') <= 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1544, 15945, 15968);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 15945, 15968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 15945, 15968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsTypeSuffix(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 16051, 16272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16122, 16232) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 16122, 16232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16167, 16217);

                    return (s_traits[c] & CharTraits.TypeSuffix) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 16122, 16232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16248, 16261);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 16051, 16272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 16051, 16272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 16051, 16272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsMultiplierStart(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 16365, 16596);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16441, 16556) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 16441, 16556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16486, 16541);

                    return (s_traits[c] & CharTraits.MultiplierStart) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 16441, 16556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16572, 16585);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 16365, 16596);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 16365, 16596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 16365, 16596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ForceStartNewToken(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 16884, 17130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 16961, 17079) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 16961, 17079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 17006, 17064);

                    return (s_traits[c] & CharTraits.ForceStartNewToken) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 16961, 17079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 17095, 17119);

                return f_1544_17102_17118(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 16884, 17130);

                bool
                f_1544_17102_17118(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 17102, 17118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 16884, 17130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 16884, 17130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ForceStartNewTokenAfterNumber(this char c, bool forceEndNumberOnTernaryOperatorChars)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 17748, 18212);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 17879, 18167) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 17879, 18167);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 17924, 18062) || true) && ((s_traits[c] & CharTraits.ForceStartNewTokenAfterNumber) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 17924, 18062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18031, 18043);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 17924, 18062);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18082, 18152);

                    return forceEndNumberOnTernaryOperatorChars && (DynAbs.Tracing.TraceSender.Expression_True(1544, 18089, 18151) && (c == '?' || (DynAbs.Tracing.TraceSender.Expression_False(1544, 18130, 18150) || c == ':')));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 17879, 18167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18183, 18201);

                return f_1544_18190_18200(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 17748, 18212);

                bool
                f_1544_18190_18200(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 18190, 18200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 17748, 18212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 17748, 18212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ForceStartNewTokenInAssemblyNameSpec(this char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1544, 18350, 18630);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18445, 18579) || true) && (c < 128)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1544, 18445, 18579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18490, 18564);

                    return (s_traits[c] & CharTraits.ForceStartNewAssemblyNameSpecToken) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1544, 18445, 18579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1544, 18595, 18619);

                return f_1544_18602_18618(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1544, 18350, 18630);

                bool
                f_1544_18602_18618(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 18602, 18618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1544, 18350, 18630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1544, 18350, 18630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static int
        f_1544_3285_3300(System.Management.Automation.Language.CharTraits[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1544, 3285, 3300);
            return return_v;
        }


        static int
        f_1544_3266_3354(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1544, 3266, 3354);
            return 0;
        }

    }
}
