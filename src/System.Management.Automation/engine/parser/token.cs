// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Text;

namespace System.Management.Automation.Language
{
    /// <summary>
    /// The specific kind of token.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
    public enum TokenKind
    {
        // When adding any new tokens, be sure to update the following tables:
        //     * TokenTraits.StaticTokenFlags
        //     * TokenTraits.Text


        /// <summary>An unknown token, signifies an error condition.</summary>
        Unknown = 0,

        /// <summary>
        /// A variable token, always begins with '$' and followed by the variable name, possibly enclose in curly braces.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.VariableToken"/>.
        /// </summary>
        Variable = 1,

        /// <summary>
        /// A splatted variable token, always begins with '@' and followed by the variable name.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.VariableToken"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        SplattedVariable = 2,

        /// <summary>
        /// A parameter to a command, always begins with a dash ('-'), followed by the parameter name.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.ParameterToken"/>.
        /// </summary>
        Parameter = 3,

        /// <summary>
        /// Any numerical literal token.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.NumberToken"/>.
        /// </summary>
        Number = 4,

        /// <summary>
        /// A label token - always begins with ':', followed by the label name.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.LabelToken"/>.
        /// </summary>
        Label = 5,

        /// <summary>
        /// A simple identifier, always begins with a letter or '_', and is followed by letters, numbers, or '_'.
        /// </summary>
        Identifier = 6,

        /// <summary>
        /// A token that is only valid as a command name, command argument, function name, or configuration name.  It may contain
        /// characters not allowed in identifiers.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.StringLiteralToken"/>
        /// or <see cref="System.Management.Automation.Language.StringExpandableToken"/> if the token contains variable
        /// references or subexpressions.
        /// </summary>
        Generic = 7,

        /// <summary>A newline (one of '\n', '\r', or '\r\n').</summary>
        NewLine = 8,

        /// <summary>A line continuation (backtick followed by newline).</summary>
        LineContinuation = 9,

        /// <summary>A single line comment, or a delimited comment.</summary>
        Comment = 10,

        /// <summary>Marks the end of the input script or file.</summary>
        EndOfInput = 11,



        /// <summary>
        /// A single quoted string literal.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.StringLiteralToken"/>.
        /// </summary>
        StringLiteral = 12,

        /// <summary>
        /// A double quoted string literal.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.StringExpandableToken"/>
        /// even if there are no nested tokens to expand.
        /// </summary>
        StringExpandable = 13,

        /// <summary>
        /// A single quoted here string literal.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.StringLiteralToken"/>.
        /// </summary>
        HereStringLiteral = 14,

        /// <summary>
        /// A double quoted here string literal.
        /// Tokens with this kind are always instances of <see cref="System.Management.Automation.Language.StringExpandableToken"/>.
        /// even if there are no nested tokens to expand.
        /// </summary>
        HereStringExpandable = 15,



        /// <summary>The opening parenthesis token '('.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        LParen = 16,

        /// <summary>The closing parenthesis token ')'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        RParen = 17,

        /// <summary>The opening curly brace token '{'.</summary>
        LCurly = 18,

        /// <summary>The closing curly brace token '}'.</summary>
        RCurly = 19,

        /// <summary>The opening square brace token '['.</summary>
        LBracket = 20,

        /// <summary>The closing square brace token ']'.</summary>
        RBracket = 21,

        /// <summary>The opening token of an array expression '@('.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        AtParen = 22,

        /// <summary>The opening token of a hash expression '@{'.</summary>
        AtCurly = 23,

        /// <summary>The opening token of a sub-expression '$('.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        DollarParen = 24,

        /// <summary>The statement terminator ';'.</summary>
        Semi = 25,



        /// <summary>The (unimplemented) operator '&amp;&amp;'.</summary>
        AndAnd = 26,

        /// <summary>The (unimplemented) operator '||'.</summary>
        OrOr = 27,

        /// <summary>The invocation operator '&amp;'.</summary>
        Ampersand = 28,

        /// <summary>The pipe operator '|'.</summary>
        Pipe = 29,

        /// <summary>The unary or binary array operator ','.</summary>
        Comma = 30,

        /// <summary>The pre-decrement operator '--'.</summary>
        MinusMinus = 31,

        /// <summary>The pre-increment operator '++'.</summary>
        PlusPlus = 32,

        /// <summary>The range operator '..'.</summary>
        DotDot = 33,

        /// <summary>The static member access operator '::'.</summary>
        ColonColon = 34,

        /// <summary>The instance member access or dot source invocation operator '.'.</summary>
        Dot = 35,

        /// <summary>The logical not operator '!'.</summary>
        Exclaim = 36,

        /// <summary>The multiplication operator '*'.</summary>
        Multiply = 37,

        /// <summary>The division operator '/'.</summary>
        Divide = 38,

        /// <summary>The modulo division (remainder) operator '%'.</summary>
        Rem = 39,

        /// <summary>The addition operator '+'.</summary>
        Plus = 40,

        /// <summary>The substraction operator '-'.</summary>
        Minus = 41,

        /// <summary>The assignment operator '='.</summary>
        Equals = 42,

        /// <summary>The addition assignment operator '+='.</summary>
        PlusEquals = 43,

        /// <summary>The subtraction assignment operator '-='.</summary>
        MinusEquals = 44,

        /// <summary>The multiplication assignment operator '*='.</summary>
        MultiplyEquals = 45,

        /// <summary>The division assignment operator '/='.</summary>
        DivideEquals = 46,

        /// <summary>The modulo division (remainder) assignment operator '%='.</summary>
        RemainderEquals = 47,

        /// <summary>A redirection operator such as '2>&amp;1' or '>>'.</summary>
        Redirection = 48,

        /// <summary>The (unimplemented) stdin redirection operator '&lt;'.</summary>
        RedirectInStd = 49,

        /// <summary>The string format operator '-f'.</summary>
        Format = 50,

        /// <summary>The logical not operator '-not'.</summary>
        Not = 51,

        /// <summary>The bitwise not operator '-bnot'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Bnot = 52,

        /// <summary>The logical and operator '-and'.</summary>
        And = 53,

        /// <summary>The logical or operator '-or'.</summary>
        Or = 54,

        /// <summary>The logical exclusive or operator '-xor'.</summary>
        Xor = 55,

        /// <summary>The bitwise and operator '-band'.</summary>
        Band = 56,

        /// <summary>The bitwise or operator '-bor'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Bor = 57,

        /// <summary>The bitwise exclusive or operator '-xor'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Bxor = 58,

        /// <summary>The join operator '-join'.</summary>
        Join = 59,

        /// <summary>The case insensitive equal operator '-ieq' or '-eq'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ieq = 60,

        /// <summary>The case insensitive not equal operator '-ine' or '-ne'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ine = 61,

        /// <summary>The case insensitive greater than or equal operator '-ige' or '-ge'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ige = 62,

        /// <summary>The case insensitive greater than operator '-igt' or '-gt'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Igt = 63,

        /// <summary>The case insensitive less than operator '-ilt' or '-lt'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ilt = 64,

        /// <summary>The case insensitive less than or equal operator '-ile' or '-le'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ile = 65,

        /// <summary>The case insensitive like operator '-ilike' or '-like'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ilike = 66,

        /// <summary>The case insensitive not like operator '-inotlike' or '-notlike'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Inotlike = 67,

        /// <summary>The case insensitive match operator '-imatch' or '-match'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Imatch = 68,

        /// <summary>The case insensitive not match operator '-inotmatch' or '-notmatch'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Inotmatch = 69,

        /// <summary>The case insensitive replace operator '-ireplace' or '-replace'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ireplace = 70,

        /// <summary>The case insensitive contains operator '-icontains' or '-contains'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Icontains = 71,

        /// <summary>The case insensitive notcontains operator '-inotcontains' or '-notcontains'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Inotcontains = 72,

        /// <summary>The case insensitive in operator '-iin' or '-in'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Iin = 73,

        /// <summary>The case insensitive notin operator '-inotin' or '-notin'</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Inotin = 74,

        /// <summary>The case insensitive split operator '-isplit' or '-split'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Isplit = 75,

        /// <summary>The case sensitive equal operator '-ceq'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ceq = 76,

        /// <summary>The case sensitive not equal operator '-cne'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cne = 77,

        /// <summary>The case sensitive greater than or equal operator '-cge'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cge = 78,

        /// <summary>The case sensitive greater than operator '-cgt'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cgt = 79,

        /// <summary>The case sensitive less than operator '-clt'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Clt = 80,

        /// <summary>The case sensitive less than or equal operator '-cle'.</summary>
        Cle = 81,

        /// <summary>The case sensitive like operator '-clike'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Clike = 82,

        /// <summary>The case sensitive notlike operator '-cnotlike'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cnotlike = 83,

        /// <summary>The case sensitive match operator '-cmatch'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cmatch = 84,

        /// <summary>The case sensitive not match operator '-cnotmatch'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cnotmatch = 85,

        /// <summary>The case sensitive replace operator '-creplace'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Creplace = 86,

        /// <summary>The case sensitive contains operator '-ccontains'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Ccontains = 87,

        /// <summary>The case sensitive not contains operator '-cnotcontains'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cnotcontains = 88,

        /// <summary>The case sensitive in operator '-cin'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cin = 89,

        /// <summary>The case sensitive not in operator '-notin'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Cnotin = 90,

        /// <summary>The case sensitive split operator '-csplit'.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Csplit = 91,

        /// <summary>The type test operator '-is'.</summary>
        Is = 92,

        /// <summary>The type test operator '-isnot'.</summary>
        IsNot = 93,

        /// <summary>The type conversion operator '-as'.</summary>
        As = 94,

        /// <summary>The post-increment operator '++'.</summary>
        PostfixPlusPlus = 95,

        /// <summary>The post-decrement operator '--'.</summary>
        PostfixMinusMinus = 96,

        /// <summary>The shift left operator.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Shl = 97,

        /// <summary>The shift right operator.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Shr = 98,

        /// <summary>The PS class base class and implemented interfaces operator ':'. Also used in base class ctor calls.</summary>
        Colon = 99,

        /// <summary>The ternary operator '?'.</summary>
        QuestionMark = 100,

        /// <summary>The null conditional assignment operator '??='.</summary>
        QuestionQuestionEquals = 101,

        /// <summary>The null coalesce operator '??'.</summary>
        QuestionQuestion = 102,

        /// <summary>The null conditional member access operator '?.'.</summary>
        QuestionDot = 103,

        /// <summary>The null conditional index access operator '?[]'.</summary>
        QuestionLBracket = 104,



        /// <summary>The 'begin' keyword.</summary>
        Begin = 119,

        /// <summary>The 'break' keyword.</summary>
        Break = 120,

        /// <summary>The 'catch' keyword.</summary>
        Catch = 121,

        /// <summary>The 'class' keyword.</summary>
        Class = 122,

        /// <summary>The 'continue' keyword.</summary>
        Continue = 123,

        /// <summary>The 'data' keyword.</summary>
        Data = 124,

        /// <summary>The (unimplemented) 'define' keyword.</summary>
        Define = 125,

        /// <summary>The 'do' keyword.</summary>
        Do = 126,

        /// <summary>The 'dynamicparam' keyword.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Dynamicparam = 127,

        /// <summary>The 'else' keyword.</summary>
        Else = 128,

        /// <summary>The 'elseif' keyword.</summary>
        ElseIf = 129,

        /// <summary>The 'end' keyword.</summary>
        End = 130,

        /// <summary>The 'exit' keyword.</summary>
        Exit = 131,

        /// <summary>The 'filter' keyword.</summary>
        Filter = 132,

        /// <summary>The 'finally' keyword.</summary>
        Finally = 133,

        /// <summary>The 'for' keyword.</summary>
        For = 134,

        /// <summary>The 'foreach' keyword.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Foreach = 135,

        /// <summary>The (unimplemented) 'from' keyword.</summary>
        From = 136,

        /// <summary>The 'function' keyword.</summary>
        Function = 137,

        /// <summary>The 'if' keyword.</summary>
        If = 138,

        /// <summary>The 'in' keyword.</summary>
        In = 139,

        /// <summary>The 'param' keyword.</summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        Param = 140,

        /// <summary>The 'process' keyword.</summary>
        Process = 141,

        /// <summary>The 'return' keyword.</summary>
        Return = 142,

        /// <summary>The 'switch' keyword.</summary>
        Switch = 143,

        /// <summary>The 'throw' keyword.</summary>
        Throw = 144,

        /// <summary>The 'trap' keyword.</summary>
        Trap = 145,

        /// <summary>The 'try' keyword.</summary>
        Try = 146,

        /// <summary>The 'until' keyword.</summary>
        Until = 147,

        /// <summary>The (unimplemented) 'using' keyword.</summary>
        Using = 148,

        /// <summary>The (unimplemented) 'var' keyword.</summary>
        Var = 149,

        /// <summary>The 'while' keyword.</summary>
        While = 150,

        /// <summary>The 'workflow' keyword.</summary>
        Workflow = 151,

        /// <summary>The 'parallel' keyword.</summary>
        Parallel = 152,

        /// <summary>The 'sequence' keyword.</summary>
        Sequence = 153,

        /// <summary>The 'InlineScript' keyword</summary>
        InlineScript = 154,

        /// <summary>The "configuration" keyword</summary>
        Configuration = 155,

        /// <summary>The token kind for dynamic keywords</summary>
        DynamicKeyword = 156,

        /// <summary>The 'public' keyword</summary>
        Public = 157,

        /// <summary>The 'private' keyword</summary>
        Private = 158,

        /// <summary>The 'static' keyword</summary>
        Static = 159,

        /// <summary>The 'interface' keyword</summary>
        Interface = 160,

        /// <summary>The 'enum' keyword</summary>
        Enum = 161,

        /// <summary>The 'namespace' keyword</summary>
        Namespace = 162,

        /// <summary>The 'module' keyword</summary>
        Module = 163,

        /// <summary>The 'type' keyword</summary>
        Type = 164,

        /// <summary>The 'assembly' keyword</summary>
        Assembly = 165,

        /// <summary>The 'command' keyword</summary>
        Command = 166,

        /// <summary>The 'hidden' keyword</summary>
        Hidden = 167,

        /// <summary>The 'base' keyword</summary>
        Base = 168,

    }

    /// <summary>
    /// Flags that specify additional information about a given token.
    /// </summary>
    [Flags]
    public enum TokenFlags
    {
        /// <summary>
        /// The token has no flags.
        /// </summary>
        None = 0x00000000,


        /// <summary>
        /// The precedence of the logical operators '-and', '-or', and '-xor'.
        /// </summary>
        BinaryPrecedenceLogical = 0x1,

        /// <summary>
        /// The precedence of the bitwise operators '-band', '-bor', and '-bxor'
        /// </summary>
        BinaryPrecedenceBitwise = 0x2,

        /// <summary>
        /// The precedence of comparison operators including: '-eq', '-ne', '-ge', '-gt', '-lt', '-le', '-like', '-notlike',
        /// '-match', '-notmatch', '-replace', '-contains', '-notcontains', '-in', '-notin', '-split', '-join', '-is', '-isnot', '-as',
        /// and all of the case sensitive variants of these operators, if they exists.
        /// </summary>
        BinaryPrecedenceComparison = 0x5,

        /// <summary>
        /// The precedence of null coalesce operator '??'.
        /// </summary>
        BinaryPrecedenceCoalesce = 0x7,

        /// <summary>
        /// The precedence of the binary operators '+' and '-'.
        /// </summary>
        BinaryPrecedenceAdd = 0x9,

        /// <summary>
        /// The precedence of the operators '*', '/', and '%'.
        /// </summary>
        BinaryPrecedenceMultiply = 0xa,

        /// <summary>
        /// The precedence of the '-f' operator.
        /// </summary>
        BinaryPrecedenceFormat = 0xc,

        /// <summary>
        /// The precedence of the '..' operator.
        /// </summary>
        BinaryPrecedenceRange = 0xd,


        /// <summary>
        /// A bitmask to get the precedence of binary operators.
        /// </summary>
        BinaryPrecedenceMask = 0x0000000f,

        /// <summary>
        /// The token is a keyword.
        /// </summary>
        Keyword = 0x00000010,

        /// <summary>
        /// The token one of the keywords that is a part of a script block: 'begin', 'process', 'end', or 'dynamicparam'.
        /// </summary>
        ScriptBlockBlockName = 0x00000020,

        /// <summary>
        /// The token is a binary operator.
        /// </summary>
        BinaryOperator = 0x00000100,

        /// <summary>
        /// The token is a unary operator.
        /// </summary>
        UnaryOperator = 0x00000200,

        /// <summary>
        /// The token is a case sensitive operator such as '-ceq' or '-ccontains'.
        /// </summary>
        CaseSensitiveOperator = 0x00000400,

        /// <summary>
        /// The token is a ternary operator '?'.
        /// </summary>
        TernaryOperator = 0x00000800,

        /// <summary>
        /// The operators '&amp;', '|', and the member access operators ':' and '::'.
        /// </summary>
        SpecialOperator = 0x00001000,

        /// <summary>
        /// The token is one of the assignment operators: '=', '+=', '-=', '*=', '/=', '%=' or '??='
        /// </summary>
        AssignmentOperator = 0x00002000,

        /// <summary>
        /// The token is scanned identically in expression mode or command mode.
        /// </summary>
        ParseModeInvariant = 0x00008000,

        /// <summary>
        /// The token has some error associated with it.  For example, it may be a string missing it's terminator.
        /// </summary>
        TokenInError = 0x00010000,

        /// <summary>
        /// The operator is not allowed in restricted language mode or in the data language.
        /// </summary>
        DisallowedInRestrictedMode = 0x00020000,

        /// <summary>
        /// The token is either a prefix or postfix '++' or '--'.
        /// </summary>
        PrefixOrPostfixOperator = 0x00040000,

        /// <summary>
        /// The token names a command in a pipeline.
        /// </summary>
        CommandName = 0x00080000,

        /// <summary>
        /// The token names a member of a class.
        /// </summary>
        MemberName = 0x00100000,

        /// <summary>
        /// The token names a type.
        /// </summary>
        TypeName = 0x00200000,

        /// <summary>
        /// The token names an attribute.
        /// </summary>
        AttributeName = 0x00400000,

        /// <summary>
        /// The token is a valid operator to use when doing constant folding.
        /// </summary>
        // Some operators that could be marked with this flag aren't because the current implementation depends
        // on the execution context (e.g. -split, -join, -like, etc.)
        // If the operator is culture sensitive (e.g. -f), then it shouldn't be marked as suitable for constant
        // folding because evaluation of the operator could differ if the thread's culture changes.
        CanConstantFold = 0x00800000,

        /// <summary>
        /// The token is a statement but does not support attributes.
        /// </summary>
        StatementDoesntSupportAttributes = 0x01000000,
    }
    public static class TokenTraits
    {
        private static readonly TokenFlags[] s_staticTokenFlags;

        private static readonly string[] s_tokenText;

        static TokenTraits()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 53397, 54916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 27544, 44482);
                s_staticTokenFlags = new TokenFlags[]
                        {
            
            /*              Unknown */ TokenFlags.None,
            /*             Variable */ TokenFlags.None,
            /*     SplattedVariable */ TokenFlags.None,
            /*            Parameter */ TokenFlags.None,
            /*               Number */ TokenFlags.None,
            /*                Label */ TokenFlags.None,
            /*           Identifier */ TokenFlags.None,

            /*              Generic */ TokenFlags.None,
            /*              Newline */ TokenFlags.ParseModeInvariant,
            /*     LineContinuation */ TokenFlags.ParseModeInvariant,
            /*              Comment */ TokenFlags.ParseModeInvariant,
            /*           EndOfInput */ TokenFlags.ParseModeInvariant,

            
            
            /*        StringLiteral */ TokenFlags.ParseModeInvariant,
            /*     StringExpandable */ TokenFlags.ParseModeInvariant,
            /*    HereStringLiteral */ TokenFlags.ParseModeInvariant,
            /* HereStringExpandable */ TokenFlags.ParseModeInvariant,

            
            
            /*               LParen */ TokenFlags.ParseModeInvariant,
            /*               RParen */ TokenFlags.ParseModeInvariant,
            /*               LCurly */ TokenFlags.ParseModeInvariant,
            /*               RCurly */ TokenFlags.ParseModeInvariant,
            /*             LBracket */ TokenFlags.None,
            /*             RBracket */ TokenFlags.ParseModeInvariant,
            /*              AtParen */ TokenFlags.ParseModeInvariant,
            /*              AtCurly */ TokenFlags.ParseModeInvariant,
            /*          DollarParen */ TokenFlags.ParseModeInvariant,
            /*                 Semi */ TokenFlags.ParseModeInvariant,

            
            
            /*               AndAnd */ TokenFlags.ParseModeInvariant,
            /*                 OrOr */ TokenFlags.ParseModeInvariant,
            /*            Ampersand */ TokenFlags.SpecialOperator | TokenFlags.ParseModeInvariant,
            /*                 Pipe */ TokenFlags.SpecialOperator | TokenFlags.ParseModeInvariant,
            /*                Comma */ TokenFlags.UnaryOperator | TokenFlags.ParseModeInvariant,
            /*           MinusMinus */ TokenFlags.UnaryOperator | TokenFlags.PrefixOrPostfixOperator | TokenFlags.DisallowedInRestrictedMode,
            /*             PlusPlus */ TokenFlags.UnaryOperator | TokenFlags.PrefixOrPostfixOperator | TokenFlags.DisallowedInRestrictedMode,
            /*               DotDot */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceRange | TokenFlags.DisallowedInRestrictedMode,
            /*           ColonColon */ TokenFlags.SpecialOperator | TokenFlags.DisallowedInRestrictedMode,
            /*                  Dot */ TokenFlags.SpecialOperator | TokenFlags.DisallowedInRestrictedMode,
            /*              Exclaim */ TokenFlags.UnaryOperator | TokenFlags.CanConstantFold,
            /*             Multiply */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceMultiply | TokenFlags.CanConstantFold,
            /*               Divide */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceMultiply | TokenFlags.CanConstantFold,
            /*                  Rem */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceMultiply | TokenFlags.CanConstantFold,
            /*                 Plus */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceAdd | TokenFlags.UnaryOperator | TokenFlags.CanConstantFold,
            /*                Minus */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceAdd | TokenFlags.UnaryOperator | TokenFlags.CanConstantFold,
            /*               Equals */ TokenFlags.AssignmentOperator,
            /*           PlusEquals */ TokenFlags.AssignmentOperator,
            /*          MinusEquals */ TokenFlags.AssignmentOperator,
            /*       MultiplyEquals */ TokenFlags.AssignmentOperator,
            /*         DivideEquals */ TokenFlags.AssignmentOperator,
            /*      RemainderEquals */ TokenFlags.AssignmentOperator,
            /*          Redirection */ TokenFlags.DisallowedInRestrictedMode,
            /*        RedirectInStd */ TokenFlags.ParseModeInvariant | TokenFlags.DisallowedInRestrictedMode,
            /*               Format */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceFormat | TokenFlags.DisallowedInRestrictedMode,
            /*                  Not */ TokenFlags.UnaryOperator | TokenFlags.CanConstantFold,
            /*                 Bnot */ TokenFlags.UnaryOperator | TokenFlags.CanConstantFold,
            /*                  And */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceLogical | TokenFlags.CanConstantFold,
            /*                   Or */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceLogical | TokenFlags.CanConstantFold,
            /*                  Xor */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceLogical | TokenFlags.CanConstantFold,
            /*                 Band */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceBitwise | TokenFlags.CanConstantFold,
            /*                  Bor */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceBitwise | TokenFlags.CanConstantFold,
            /*                 Bxor */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceBitwise | TokenFlags.CanConstantFold,
            /*                 Join */ TokenFlags.BinaryOperator | TokenFlags.UnaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*                  Ieq */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Ine */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Ige */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Igt */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Ilt */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Ile */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                Ilike */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*             Inotlike */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*               Imatch */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*            Inotmatch */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*             Ireplace */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*            Icontains */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*         Inotcontains */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                  Iin */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*               Inotin */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*               Isplit */ TokenFlags.BinaryOperator | TokenFlags.UnaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*                  Ceq */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Cne */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Cge */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Cgt */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Clt */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Cle */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                Clike */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*             Cnotlike */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*               Cmatch */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator | TokenFlags.DisallowedInRestrictedMode,
            /*            Cnotmatch */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator | TokenFlags.DisallowedInRestrictedMode,
            /*             Creplace */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator | TokenFlags.DisallowedInRestrictedMode,
            /*            Ccontains */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*         Cnotcontains */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*                  Cin */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*               Cnotin */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator,
            /*               Csplit */ TokenFlags.BinaryOperator | TokenFlags.UnaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CaseSensitiveOperator | TokenFlags.DisallowedInRestrictedMode,
            /*                   Is */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                IsNot */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison,
            /*                   As */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.DisallowedInRestrictedMode,
            /*      PostFixPlusPlus */ TokenFlags.UnaryOperator | TokenFlags.PrefixOrPostfixOperator | TokenFlags.DisallowedInRestrictedMode,
            /*    PostFixMinusMinus */ TokenFlags.UnaryOperator | TokenFlags.PrefixOrPostfixOperator | TokenFlags.DisallowedInRestrictedMode,
            /*                  Shl */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CanConstantFold,
            /*                  Shr */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CanConstantFold,
            /*                Colon */ TokenFlags.SpecialOperator | TokenFlags.DisallowedInRestrictedMode,
            /*         QuestionMark */ TokenFlags.TernaryOperator | TokenFlags.DisallowedInRestrictedMode,
          /* QuestionQuestionEquals */ TokenFlags.AssignmentOperator,
            /*     QuestionQuestion */ TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceCoalesce,
            /*          QuestionDot */ TokenFlags.SpecialOperator | TokenFlags.DisallowedInRestrictedMode,
            /*     QuestionLBracket */ TokenFlags.None,
            /*     Reserved slot 7  */ TokenFlags.None,
            /*     Reserved slot 8  */ TokenFlags.None,
            /*     Reserved slot 9  */ TokenFlags.None,
            /*     Reserved slot 10 */ TokenFlags.None,
            /*     Reserved slot 11 */ TokenFlags.None,
            /*     Reserved slot 12 */ TokenFlags.None,
            /*     Reserved slot 13 */ TokenFlags.None,
            /*     Reserved slot 14 */ TokenFlags.None,
            /*     Reserved slot 15 */ TokenFlags.None,
            /*     Reserved slot 16 */ TokenFlags.None,
            /*     Reserved slot 17 */ TokenFlags.None,
            /*     Reserved slot 18 */ TokenFlags.None,
            /*     Reserved slot 19 */ TokenFlags.None,
            /*     Reserved slot 20 */ TokenFlags.None,

            
            
            /*                Begin */ TokenFlags.Keyword | TokenFlags.ScriptBlockBlockName,
            /*                Break */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                Catch */ TokenFlags.Keyword,
            /*                Class */ TokenFlags.Keyword,
            /*             Continue */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                 Data */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*               Define */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                   Do */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*         Dynamicparam */ TokenFlags.Keyword | TokenFlags.ScriptBlockBlockName,
            /*                 Else */ TokenFlags.Keyword,
            /*               ElseIf */ TokenFlags.Keyword,
            /*                  End */ TokenFlags.Keyword | TokenFlags.ScriptBlockBlockName,
            /*                 Exit */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*               Filter */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*              Finally */ TokenFlags.Keyword,
            /*                  For */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*              Foreach */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                 From */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*             Function */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                   If */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                   In */ TokenFlags.Keyword,
            /*                Param */ TokenFlags.Keyword,
            /*              Process */ TokenFlags.Keyword | TokenFlags.ScriptBlockBlockName,
            /*               Return */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*               Switch */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                Throw */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                 Trap */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                  Try */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                Until */ TokenFlags.Keyword,
            /*                Using */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                  Var */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*                While */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*             Workflow */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*             Parallel */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*             Sequence */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*         InlineScript */ TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes,
            /*        Configuration */ TokenFlags.Keyword,
            /*    <dynamic keyword> */ TokenFlags.Keyword,
            /*               Public */ TokenFlags.Keyword,
            /*              Private */ TokenFlags.Keyword,
            /*               Static */ TokenFlags.Keyword,
            /*            Interface */ TokenFlags.Keyword,
            /*                 Enum */ TokenFlags.Keyword,
            /*            Namespace */ TokenFlags.Keyword,
            /*               Module */ TokenFlags.Keyword,
            /*                 Type */ TokenFlags.Keyword,
            /*             Assembly */ TokenFlags.Keyword,
            /*              Command */ TokenFlags.Keyword,
            /*               Hidden */ TokenFlags.Keyword,
            /*                 Base */ TokenFlags.Keyword,

                                    };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 44528, 53373);
                s_tokenText = new string[]
                        {
            
            /*              Unknown */ "unknown",
            /*             Variable */ "var",
            /*     SplattedVariable */ "@var",
            /*            Parameter */ "param",
            /*               Number */ "number",
            /*                Label */ "label",
            /*           Identifier */ "ident",

            /*              Generic */ "generic",
            /*              Newline */ "newline",
            /*     LineContinuation */ "line continuation",
            /*              Comment */ "comment",
            /*           EndOfInput */ "eof",

            
            
            /*        StringLiteral */ "sqstr",
            /*     StringExpandable */ "dqstr",
            /*    HereStringLiteral */ "sq here string",
            /* HereStringExpandable */ "dq here string",

            
            
            /*               LParen */ "(",
            /*               RParen */ ")",
            /*               LCurly */ "{",
            /*               RCurly */ "}",
            /*             LBracket */ "[",
            /*             RBracket */ "]",
            /*              AtParen */ "@(",
            /*              AtCurly */ "@{",
            /*          DollarParen */ "$(",
            /*                 Semi */ ";",

            
            
            /*               AndAnd */ "&&",
            /*                 OrOr */ "||",
            /*            Ampersand */ "&",
            /*                 Pipe */ "|",
            /*                Comma */ ",",
            /*           MinusMinus */ "--",
            /*             PlusPlus */ "++",
            /*               DotDot */ "..",
            /*           ColonColon */ "::",
            /*                  Dot */ ".",
            /*              Exclaim */ "!",
            /*             Multiply */ "*",
            /*               Divide */ "/",
            /*                  Rem */ "%",
            /*                 Plus */ "+",
            /*                Minus */ "-",
            /*               Equals */ "=",
            /*           PlusEquals */ "+=",
            /*          MinusEquals */ "-=",
            /*       MultiplyEquals */ "*=",
            /*         DivideEquals */ "/=",
            /*      RemainderEquals */ "%=",
            /*          Redirection */ "redirection",
            /*        RedirectInStd */ "<",
            /*               Format */ "-f",
            /*                  Not */ "-not",
            /*                 Bnot */ "-bnot",
            /*                  And */ "-and",
            /*                   Or */ "-or",
            /*                  Xor */ "-xor",
            /*                 Band */ "-band",
            /*                  Bor */ "-bor",
            /*                 Bxor */ "-bxor",
            /*                 Join */ "-join",
            /*                  Ieq */ "-eq",
            /*                  Ine */ "-ne",
            /*                  Ige */ "-ge",
            /*                  Igt */ "-gt",
            /*                  Ilt */ "-lt",
            /*                  Ile */ "-le",
            /*                Ilike */ "-ilike",
            /*             Inotlike */ "-inotlike",
            /*               Imatch */ "-imatch",
            /*            Inotmatch */ "-inotmatch",
            /*             Ireplace */ "-ireplace",
            /*            Icontains */ "-icontains",
            /*         Inotcontains */ "-inotcontains",
            /*                  Iin */ "-iin",
            /*               Inotin */ "-inotin",
            /*               Isplit */ "-isplit",
            /*                  Ceq */ "-ceq",
            /*                  Cne */ "-cne",
            /*                  Cge */ "-cge",
            /*                  Cgt */ "-cgt",
            /*                  Clt */ "-clt",
            /*                  Cle */ "-cle",
            /*                Clike */ "-clike",
            /*             Cnotlike */ "-cnotlike",
            /*               Cmatch */ "-cmatch",
            /*            Cnotmatch */ "-cnotmatch",
            /*             Creplace */ "-creplace",
            /*            Ccontains */ "-ccontains",
            /*         Cnotcontains */ "-cnotcontains",
            /*                  Cin */ "-cin",
            /*               Cnotin */ "-cnotin",
            /*               Csplit */ "-csplit",
            /*                   Is */ "-is",
            /*                IsNot */ "-isnot",
            /*                   As */ "-as",
            /*      PostFixPlusPlus */ "++",
            /*    PostFixMinusMinus */ "--",
            /*                  Shl */ "-shl",
            /*                  Shr */ "-shr",
            /*                Colon */ ":",
            /*         QuestionMark */ "?",
          /* QuestionQuestionEquals */ "??=",
            /*     QuestionQuestion */ "??",
            /*          QuestionDot */ "?.",
            /*     QuestionLBracket */ "?[",
            /*    Reserved slot 7   */ string.Empty,
            /*    Reserved slot 8   */ string.Empty,
            /*    Reserved slot 9   */ string.Empty,
            /*    Reserved slot 10  */ string.Empty,
            /*    Reserved slot 11  */ string.Empty,
            /*    Reserved slot 12  */ string.Empty,
            /*    Reserved slot 13  */ string.Empty,
            /*    Reserved slot 14  */ string.Empty,
            /*    Reserved slot 15  */ string.Empty,
            /*    Reserved slot 16  */ string.Empty,
            /*    Reserved slot 17  */ string.Empty,
            /*    Reserved slot 18  */ string.Empty,
            /*    Reserved slot 19  */ string.Empty,
            /*    Reserved slot 20  */ string.Empty,

            
            
            /*                Begin */ "begin",
            /*                Break */ "break",
            /*                Catch */ "catch",
            /*                Class */ "class",
            /*             Continue */ "continue",
            /*                 Data */ "data",
            /*               Define */ "define",
            /*                   Do */ "do",
            /*         Dynamicparam */ "dynamicparam",
            /*                 Else */ "else",
            /*               ElseIf */ "elseif",
            /*                  End */ "end",
            /*                 Exit */ "exit",
            /*               Filter */ "filter",
            /*              Finally */ "finally",
            /*                  For */ "for",
            /*              Foreach */ "foreach",
            /*                 From */ "from",
            /*             Function */ "function",
            /*                   If */ "if",
            /*                   In */ "in",
            /*                Param */ "param",
            /*              Process */ "process",
            /*               Return */ "return",
            /*               Switch */ "switch",
            /*                Throw */ "throw",
            /*                 Trap */ "trap",
            /*                  Try */ "try",
            /*                Until */ "until",
            /*                Using */ "using",
            /*                  Var */ "var",
            /*                While */ "while",
            /*             Workflow */ "workflow",
            /*             Parallel */ "parallel",
            /*             Sequence */ "sequence",
            /*         InlineScript */ "inlinescript",
            /*        Configuration */ "configuration",
            /*    <dynamic keyword> */ "<dynamic keyword>",
            /*               Public */ "public",
            /*              Private */ "private",
            /*               Static */ "static",
            /*            Interface */ "interface",
            /*                 Enum */ "enum",
            /*            Namespace */ "namespace",
            /*               Module */ "module",
            /*                 Type */ "type",
            /*             Assembly */ "assembly",
            /*              Command */ "command",
            /*               Hidden */ "hidden",
            /*                 Base */ "base",

                                    };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 53442, 53605);

                f_1557_53442_53604(f_1557_53461_53486(s_staticTokenFlags) == ((int)TokenKind.Base + 1), "Table size out of sync with enum - _staticTokenFlags");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 53619, 53768);

                f_1557_53619_53767(f_1557_53638_53656(s_tokenText) == ((int)TokenKind.Base + 1), "Table size out of sync with enum - _tokenText");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 53870, 54052);

                f_1557_53870_54051(f_1557_53889_53915(TokenKind.Begin) == (TokenFlags.Keyword | TokenFlags.ScriptBlockBlockName), "Table out of sync with enum - flags Begin");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 54066, 54266);

                f_1557_54066_54265(f_1557_54085_54114(TokenKind.Workflow) == (TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes), "Table out of sync with enum - flags Workflow");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 54280, 54480);

                f_1557_54280_54479(f_1557_54299_54328(TokenKind.Sequence) == (TokenFlags.Keyword | TokenFlags.StatementDoesntSupportAttributes), "Table out of sync with enum - flags Sequence");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 54494, 54714);

                f_1557_54494_54713(f_1557_54513_54537(TokenKind.Shr) == (TokenFlags.BinaryOperator | TokenFlags.BinaryPrecedenceComparison | TokenFlags.CanConstantFold), "Table out of sync with enum - flags Shr");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 54728, 54905);

                f_1557_54728_54904(f_1557_54747_54829(s_tokenText[(int)TokenKind.Shr], "-shr", StringComparison.OrdinalIgnoreCase), "Table out of sync with enum - text Shr");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 53397, 54916);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 53397, 54916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 53397, 54916);
            }
        }

        public static TokenFlags GetTraits(this TokenKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1557, 55051, 55179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 55131, 55168);

                return s_staticTokenFlags[(int)kind];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1557, 55051, 55179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 55051, 55179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 55051, 55179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasTrait(this TokenKind kind, TokenFlags flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1557, 55312, 55464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 55402, 55453);

                return (f_1557_55410_55425(kind) & flag) != TokenFlags.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1557, 55312, 55464);

                System.Management.Automation.Language.TokenFlags
                f_1557_55410_55425(System.Management.Automation.Language.TokenKind
                kind)
                {
                    var return_v = kind.GetTraits();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 55410, 55425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 55312, 55464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 55312, 55464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetBinaryPrecedence(this TokenKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1557, 55476, 55767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 55561, 55664);

                f_1557_55561_55663(f_1557_55580_55621(kind, TokenFlags.BinaryOperator), "Token doesn't have binary precedence.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 55678, 55756);

                return (int)(s_staticTokenFlags[(int)kind] & TokenFlags.BinaryPrecedenceMask);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1557, 55476, 55767);

                bool
                f_1557_55580_55621(System.Management.Automation.Language.TokenKind
                kind, System.Management.Automation.Language.TokenFlags
                flag)
                {
                    var return_v = kind.HasTrait(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 55580, 55621);
                    return return_v;
                }


                int
                f_1557_55561_55663(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 55561, 55663);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 55476, 55767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 55476, 55767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Text(this TokenKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1557, 55889, 56001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 55960, 55990);

                return s_tokenText[(int)kind];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1557, 55889, 56001);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 55889, 56001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 55889, 56001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static int
        f_1557_53461_53486(System.Management.Automation.Language.TokenFlags[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 53461, 53486);
            return return_v;
        }


        static int
        f_1557_53442_53604(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 53442, 53604);
            return 0;
        }


        static int
        f_1557_53638_53656(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 53638, 53656);
            return return_v;
        }


        static int
        f_1557_53619_53767(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 53619, 53767);
            return 0;
        }


        static System.Management.Automation.Language.TokenFlags
        f_1557_53889_53915(System.Management.Automation.Language.TokenKind
        kind)
        {
            var return_v = kind.GetTraits();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 53889, 53915);
            return return_v;
        }


        static int
        f_1557_53870_54051(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 53870, 54051);
            return 0;
        }


        static System.Management.Automation.Language.TokenFlags
        f_1557_54085_54114(System.Management.Automation.Language.TokenKind
        kind)
        {
            var return_v = kind.GetTraits();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54085, 54114);
            return return_v;
        }


        static int
        f_1557_54066_54265(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54066, 54265);
            return 0;
        }


        static System.Management.Automation.Language.TokenFlags
        f_1557_54299_54328(System.Management.Automation.Language.TokenKind
        kind)
        {
            var return_v = kind.GetTraits();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54299, 54328);
            return return_v;
        }


        static int
        f_1557_54280_54479(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54280, 54479);
            return 0;
        }


        static System.Management.Automation.Language.TokenFlags
        f_1557_54513_54537(System.Management.Automation.Language.TokenKind
        kind)
        {
            var return_v = kind.GetTraits();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54513, 54537);
            return return_v;
        }


        static int
        f_1557_54494_54713(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54494, 54713);
            return 0;
        }


        static bool
        f_1557_54747_54829(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54747, 54829);
            return return_v;
        }


        static int
        f_1557_54728_54904(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 54728, 54904);
            return 0;
        }

    }
    public class Token
    {
        private TokenKind _kind;

        private TokenFlags _tokenFlags;

        private readonly InternalScriptExtent _scriptExtent;

        internal Token(InternalScriptExtent scriptExtent, TokenKind kind, TokenFlags tokenFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 56337, 56575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56216, 56221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56251, 56262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56311, 56324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56450, 56479);

                _scriptExtent = scriptExtent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56493, 56506);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56520, 56564);

                _tokenFlags = tokenFlags | f_1557_56547_56563(kind);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 56337, 56575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 56337, 56575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 56337, 56575);
            }
        }

        internal void SetIsCommandArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 56587, 56987);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56868, 56976) || true) && (_kind != TokenKind.Identifier)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1557, 56868, 56976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 56935, 56961);

                    _kind = TokenKind.Generic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1557, 56868, 56976);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 56587, 56987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 56587, 56987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 56587, 56987);
            }
        }

        public string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57139, 57173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57145, 57171);

                    return f_1557_57152_57170(_scriptExtent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57139, 57173);

                    string
                    f_1557_57152_57170(System.Management.Automation.Language.InternalScriptExtent
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 57152, 57170);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57118, 57175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57118, 57175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TokenFlags TokenFlags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57310, 57337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57316, 57335);

                    return _tokenFlags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57310, 57337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57279, 57377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57279, 57377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57338, 57375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57353, 57373);

                    _tokenFlags = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57338, 57375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57279, 57377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57279, 57377);
                }
            }
        }

        public TokenKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57499, 57520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57505, 57518);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57499, 57520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57475, 57522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57475, 57522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57697, 57757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57703, 57755);

                    return (_tokenFlags & TokenFlags.TokenInError) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57697, 57757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57674, 57759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57674, 57759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 57907, 57936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 57913, 57934);

                    return _scriptExtent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 57907, 57936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 57877, 57938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 57877, 57938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 58069, 58194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 58127, 58183);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1557, 58134, 58165) || (((_kind == TokenKind.EndOfInput) && DynAbs.Tracing.TraceSender.Conditional_F2(1557, 58168, 58175)) || DynAbs.Tracing.TraceSender.Conditional_F3(1557, 58178, 58182))) ? "<eof>" : f_1557_58178_58182();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 58069, 58194);

                string
                f_1557_58178_58182()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 58178, 58182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 58069, 58194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 58069, 58194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 58206, 58400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 58280, 58389);

                return f_1557_58287_58388(f_1557_58301_58329(), "{0}{1}: <{2}>", f_1557_58348_58374(indent), _kind, f_1557_58383_58387());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 58206, 58400);

                System.Globalization.CultureInfo
                f_1557_58301_58329()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 58301, 58329);
                    return return_v;
                }


                string
                f_1557_58348_58374(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 58348, 58374);
                    return return_v;
                }


                string
                f_1557_58383_58387()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 58383, 58387);
                    return return_v;
                }


                string
                f_1557_58287_58388(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.Language.TokenKind
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 58287, 58388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 58206, 58400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 58206, 58400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Token()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 56163, 58407);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 56163, 58407);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 56163, 58407);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 56163, 58407);

        System.Management.Automation.Language.TokenFlags
        f_1557_56547_56563(System.Management.Automation.Language.TokenKind
        kind)
        {
            var return_v = kind.GetTraits();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 56547, 56563);
            return return_v;
        }

    }
    public class NumberToken : Token
    {
        private readonly object _value;

        internal NumberToken(InternalScriptExtent scriptExtent, object value, TokenFlags tokenFlags)
        : base(f_1557_58769_58781_C(scriptExtent), TokenKind.Number, tokenFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 58656, 58863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 58637, 58643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 58837, 58852);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 58656, 58863);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 58656, 58863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 58656, 58863);
            }
        }

        internal override string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 58875, 59140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 58950, 59129);

                return f_1557_58957_59128(f_1557_58971_58999(), "{0}{1}: <{2}> Value:<{3}> Type:<{4}>", f_1557_59058_59084(indent), f_1557_59086_59090(), f_1557_59092_59096(), _value, f_1557_59106_59127(f_1557_59106_59122(_value)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 58875, 59140);

                System.Globalization.CultureInfo
                f_1557_58971_58999()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 58971, 58999);
                    return return_v;
                }


                string
                f_1557_59058_59084(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 59058, 59084);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1557_59086_59090()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 59086, 59090);
                    return return_v;
                }


                string
                f_1557_59092_59096()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 59092, 59096);
                    return return_v;
                }


                System.Type
                f_1557_59106_59122(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 59106, 59122);
                    return return_v;
                }


                string
                f_1557_59106_59127(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 59106, 59127);
                    return return_v;
                }


                string
                f_1557_58957_59128(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 58957, 59128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 58875, 59140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 58875, 59140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 59267, 59289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59273, 59287);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 59267, 59289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 59245, 59291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 59245, 59291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static NumberToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 58564, 59298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 58564, 59298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 58564, 59298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 58564, 59298);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_58769_58781_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 58656, 58863);
            return return_v;
        }

    }
    public class ParameterToken : Token
    {
        private readonly string _parameterName;

        private readonly bool _usedColon;

        internal ParameterToken(InternalScriptExtent scriptExtent, string parameterName, bool usedColon)
        : base(f_1557_59682_59694_C(scriptExtent), TokenKind.Parameter, TokenFlags.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 59565, 59948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59495, 59509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59542, 59552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59758, 59855);

                f_1557_59758_59854(!f_1557_59778_59813(parameterName), "parameterName can't be null or empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59869, 59900);

                _parameterName = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 59914, 59937);

                _usedColon = usedColon;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 59565, 59948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 59565, 59948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 59565, 59948);
            }
        }

        public string ParameterName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 60146, 60176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 60152, 60174);

                    return _parameterName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 60146, 60176);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 60116, 60178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 60116, 60178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool UsedColon
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 60492, 60518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 60498, 60516);

                    return _usedColon;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 60492, 60518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 60468, 60520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 60468, 60520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 60532, 60790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 60607, 60779);

                return f_1557_60614_60778(f_1557_60628_60656(), "{0}{1}: <-{2}{3}>", f_1557_60696_60722(indent), f_1557_60724_60728(), _parameterName, (DynAbs.Tracing.TraceSender.Conditional_F1(1557, 60746, 60756) || ((_usedColon && DynAbs.Tracing.TraceSender.Conditional_F2(1557, 60759, 60762)) || DynAbs.Tracing.TraceSender.Conditional_F3(1557, 60765, 60777))) ? ":" : string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 60532, 60790);

                System.Globalization.CultureInfo
                f_1557_60628_60656()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 60628, 60656);
                    return return_v;
                }


                string
                f_1557_60696_60722(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 60696, 60722);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1557_60724_60728()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 60724, 60728);
                    return return_v;
                }


                string
                f_1557_60614_60778(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 60614, 60778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 60532, 60790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 60532, 60790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 59419, 60797);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 59419, 60797);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 59419, 60797);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 59419, 60797);

        bool
        f_1557_59778_59813(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 59778, 59813);
            return return_v;
        }


        int
        f_1557_59758_59854(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 59758, 59854);
            return 0;
        }


        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_59682_59694_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 59565, 59948);
            return return_v;
        }

    }
    public class VariableToken : Token
    {
        internal VariableToken(InternalScriptExtent scriptExtent, VariablePath path, TokenFlags tokenFlags, bool splatted)
        : base(f_1557_61145_61157_C(scriptExtent), (DynAbs.Tracing.TraceSender.Conditional_F1(1557, 61159, 61167) || ((splatted && DynAbs.Tracing.TraceSender.Conditional_F2(1557, 61170, 61196)) || DynAbs.Tracing.TraceSender.Conditional_F3(1557, 61199, 61217))) ? TokenKind.SplattedVariable : TokenKind.Variable, tokenFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 61010, 61286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 61611, 61665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 61255, 61275);

                VariablePath = path;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 61010, 61286);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 61010, 61286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 61010, 61286);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 61454, 61498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 61460, 61496);

                    return f_1557_61467_61495(f_1557_61467_61479());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 61454, 61498);

                    System.Management.Automation.VariablePath
                    f_1557_61467_61479()
                    {
                        var return_v = VariablePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61467, 61479);
                        return return_v;
                    }


                    string
                    f_1557_61467_61495(System.Management.Automation.VariablePath
                    this_param)
                    {
                        var return_v = this_param.UnqualifiedPath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61467, 61495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 61433, 61500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 61433, 61500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public VariablePath VariablePath { get; private set; }

        internal override string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 61677, 61905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 61752, 61894);

                return f_1557_61759_61893(f_1557_61773_61801(), "{0}{1}: <{2}> Name:<{3}>", f_1557_61848_61874(indent), f_1557_61876_61880(), f_1557_61882_61886(), f_1557_61888_61892());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 61677, 61905);

                System.Globalization.CultureInfo
                f_1557_61773_61801()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61773, 61801);
                    return return_v;
                }


                string
                f_1557_61848_61874(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 61848, 61874);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1557_61876_61880()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61876, 61880);
                    return return_v;
                }


                string
                f_1557_61882_61886()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61882, 61886);
                    return return_v;
                }


                string
                f_1557_61888_61892()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 61888, 61892);
                    return return_v;
                }


                string
                f_1557_61759_61893(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 61759, 61893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 61677, 61905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 61677, 61905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VariableToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 60959, 61912);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 60959, 61912);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 60959, 61912);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 60959, 61912);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_61145_61157_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 61010, 61286);
            return return_v;
        }

    }
    public abstract class StringToken : Token
    {
        internal StringToken(InternalScriptExtent scriptExtent, TokenKind kind, TokenFlags tokenFlags, string value)
        : base(f_1557_62265_62277_C(scriptExtent), kind, tokenFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 62136, 62346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 62500, 62528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 62321, 62335);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 62136, 62346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 62136, 62346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 62136, 62346);
            }
        }

        public string Value { get; }

        internal override string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 62540, 62770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 62615, 62759);

                return f_1557_62622_62758(f_1557_62636_62664(), "{0}{1}: <{2}> Value:<{3}>", f_1557_62712_62738(indent), f_1557_62740_62744(), f_1557_62746_62750(), f_1557_62752_62757());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 62540, 62770);

                System.Globalization.CultureInfo
                f_1557_62636_62664()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 62636, 62664);
                    return return_v;
                }


                string
                f_1557_62712_62738(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 62712, 62738);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1557_62740_62744()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 62740, 62744);
                    return return_v;
                }


                string
                f_1557_62746_62750()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 62746, 62750);
                    return return_v;
                }


                string
                f_1557_62752_62757()
                {
                    var return_v = Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 62752, 62757);
                    return return_v;
                }


                string
                f_1557_62622_62758(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 62622, 62758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 62540, 62770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 62540, 62770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 62078, 62777);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 62078, 62777);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 62078, 62777);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 62078, 62777);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_62265_62277_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 62136, 62346);
            return return_v;
        }

    }
    public class StringLiteralToken : StringToken
    {
        internal StringLiteralToken(InternalScriptExtent scriptExtent, TokenFlags flags, TokenKind tokenKind, string value)
        : base(f_1557_63087_63099_C(scriptExtent), tokenKind, flags, value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 62951, 63147);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 62951, 63147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 62951, 63147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 62951, 63147);
            }
        }

        static StringLiteralToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 62889, 63154);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 62889, 63154);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 62889, 63154);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 62889, 63154);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_63087_63099_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 62951, 63147);
            return return_v;
        }

    }
    public class StringExpandableToken : StringToken
    {
        private ReadOnlyCollection<Token> _nestedTokens;

        internal StringExpandableToken(InternalScriptExtent scriptExtent, TokenKind tokenKind, string value, string formatString, List<Token> nestedTokens, TokenFlags flags)
        : base(f_1557_63577_63589_C(scriptExtent), tokenKind, flags, value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 63391, 63864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 63365, 63378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64854, 64891);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 63640, 63809) || true) && (nestedTokens != null && (DynAbs.Tracing.TraceSender.Expression_True(1557, 63644, 63690) && f_1557_63668_63686(nestedTokens) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1557, 63640, 63809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 63724, 63794);

                    _nestedTokens = f_1557_63740_63793(f_1557_63770_63792(nestedTokens));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1557, 63640, 63809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 63825, 63853);

                FormatString = formatString;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 63391, 63864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 63391, 63864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 63391, 63864);
            }
        }

        internal static void ToDebugString(ReadOnlyCollection<Token> nestedTokens,
                                                   StringBuilder sb, int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1557, 63876, 64314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64049, 64110);

                f_1557_64049_64109(nestedTokens != null, "caller to verify");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64126, 64303);
                    foreach (Token token in f_1557_64150_64162_I(nestedTokens))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1557, 64126, 64303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64196, 64227);

                        f_1557_64196_64226(sb, f_1557_64206_64225());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64245, 64288);

                        f_1557_64245_64287(sb, f_1557_64255_64286(token, indent + 4));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1557, 64126, 64303);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1557, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1557, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1557, 63876, 64314);

                int
                f_1557_64049_64109(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64049, 64109);
                    return 0;
                }


                string
                f_1557_64206_64225()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 64206, 64225);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1557_64196_64226(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64196, 64226);
                    return return_v;
                }


                string
                f_1557_64255_64286(System.Management.Automation.Language.Token
                this_param, int
                indent)
                {
                    var return_v = this_param.ToDebugString(indent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64255, 64286);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1557_64245_64287(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64245, 64287);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                f_1557_64150_64162_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64150, 64162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 63876, 64314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 63876, 64314);
            }
        }

        public ReadOnlyCollection<Token> NestedTokens
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 64747, 64776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64753, 64774);

                    return _nestedTokens;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 64747, 64776);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 64677, 64842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 64677, 64842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 64792, 64831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64807, 64829);

                    _nestedTokens = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 64792, 64831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 64677, 64842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 64677, 64842);
                }
            }
        }

        internal string FormatString { get; }

        internal override string ToDebugString(int indent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1557, 64903, 65248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 64978, 65017);

                StringBuilder
                sb = f_1557_64997_65016()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65033, 65071);

                f_1557_65033_65070(
                            sb, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToDebugString(indent), 1557, 65043, 65069));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65085, 65200) || true) && (_nestedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1557, 65085, 65200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65144, 65185);

                    f_1557_65144_65184(_nestedTokens, sb, indent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1557, 65085, 65200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65216, 65237);

                return f_1557_65223_65236(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1557, 64903, 65248);

                System.Text.StringBuilder
                f_1557_64997_65016()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 64997, 65016);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1557_65033_65070(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 65033, 65070);
                    return return_v;
                }


                int
                f_1557_65144_65184(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
                nestedTokens, System.Text.StringBuilder
                sb, int
                indent)
                {
                    ToDebugString(nestedTokens, sb, indent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 65144, 65184);
                    return 0;
                }


                string
                f_1557_65223_65236(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 65223, 65236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 64903, 65248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 64903, 65248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringExpandableToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 63266, 65255);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 63266, 65255);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 63266, 65255);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 63266, 65255);

        int
        f_1557_63668_63686(System.Collections.Generic.List<System.Management.Automation.Language.Token>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1557, 63668, 63686);
            return return_v;
        }


        System.Management.Automation.Language.Token[]
        f_1557_63770_63792(System.Collections.Generic.List<System.Management.Automation.Language.Token>
        this_param)
        {
            var return_v = this_param.ToArray();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 63770, 63792);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>
        f_1557_63740_63793(System.Management.Automation.Language.Token[]
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.Token>((System.Collections.Generic.IList<System.Management.Automation.Language.Token>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1557, 63740, 63793);
            return return_v;
        }


        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_63577_63589_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 63391, 63864);
            return return_v;
        }

    }
    public class LabelToken : Token
    {
        internal LabelToken(InternalScriptExtent scriptExtent, TokenFlags tokenFlags, string labelText)
        : base(f_1557_65466_65478_C(scriptExtent), TokenKind.Label, tokenFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 65350, 65566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65625, 65657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 65533, 65555);

                LabelText = labelText;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 65350, 65566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 65350, 65566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 65350, 65566);
            }
        }

        public string LabelText { get; }

        static LabelToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 65302, 65664);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 65302, 65664);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 65302, 65664);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 65302, 65664);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_65466_65478_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 65350, 65566);
            return return_v;
        }

    }
    public abstract class RedirectionToken : Token
    {
        internal RedirectionToken(InternalScriptExtent scriptExtent, TokenKind kind)
        : base(f_1557_65938_65950_C(scriptExtent), kind, TokenFlags.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 65841, 65996);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 65841, 65996);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 65841, 65996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 65841, 65996);
            }
        }

        static RedirectionToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 65778, 66003);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 65778, 66003);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 65778, 66003);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 65778, 66003);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_65938_65950_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 65841, 65996);
            return return_v;
        }

    }
    public class InputRedirectionToken : RedirectionToken
    {
        internal InputRedirectionToken(InternalScriptExtent scriptExtent)
        : base(f_1557_66264_66276_C(scriptExtent), TokenKind.RedirectInStd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 66178, 66324);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 66178, 66324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 66178, 66324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 66178, 66324);
            }
        }

        static InputRedirectionToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 66108, 66331);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 66108, 66331);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 66108, 66331);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 66108, 66331);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_66264_66276_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 66178, 66324);
            return return_v;
        }

    }
    public class MergingRedirectionToken : RedirectionToken
    {
        internal MergingRedirectionToken(InternalScriptExtent scriptExtent, RedirectionStream from, RedirectionStream to)
        : base(f_1557_66616_66628_C(scriptExtent), TokenKind.Redirection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 66482, 66744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 66845, 66902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 67003, 67058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 66677, 66700);

                this.FromStream = from;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 66714, 66733);

                this.ToStream = to;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 66482, 66744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 66482, 66744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 66482, 66744);
            }
        }

        public RedirectionStream FromStream { get; private set; }

        public RedirectionStream ToStream { get; private set; }

        static MergingRedirectionToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 66410, 67065);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 66410, 67065);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 66410, 67065);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 66410, 67065);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_66616_66628_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 66482, 66744);
            return return_v;
        }

    }
    public class FileRedirectionToken : RedirectionToken
    {
        internal FileRedirectionToken(InternalScriptExtent scriptExtent, RedirectionStream from, bool append)
        : base(f_1557_67332_67344_C(scriptExtent), TokenKind.Redirection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 67210, 67462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 67563, 67620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 67770, 67810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 67393, 67416);

                this.FromStream = from;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 67430, 67451);

                this.Append = append;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 67210, 67462);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 67210, 67462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 67210, 67462);
            }
        }

        public RedirectionStream FromStream { get; private set; }

        public bool Append { get; private set; }

        static FileRedirectionToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 67141, 67817);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 67141, 67817);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 67141, 67817);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 67141, 67817);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_67332_67344_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 67210, 67462);
            return return_v;
        }

    }
    internal class UnscannedSubExprToken : StringLiteralToken
    {
        internal UnscannedSubExprToken(InternalScriptExtent scriptExtent, TokenFlags tokenFlags, string value, BitArray skippedCharOffsets)
        : base(f_1557_68051_68063_C(scriptExtent), tokenFlags, TokenKind.StringLiteral, value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1557, 67899, 68189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 68201, 68259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1557, 68133, 68178);

                this.SkippedCharOffsets = skippedCharOffsets;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1557, 67899, 68189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1557, 67899, 68189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 67899, 68189);
            }
        }

        internal BitArray SkippedCharOffsets { get; private set; }

        static UnscannedSubExprToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1557, 67825, 68266);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1557, 67825, 68266);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1557, 67825, 68266);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1557, 67825, 68266);

        static System.Management.Automation.Language.InternalScriptExtent
        f_1557_68051_68063_C(System.Management.Automation.Language.InternalScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1557, 67899, 68189);
            return return_v;
        }

    }
}
