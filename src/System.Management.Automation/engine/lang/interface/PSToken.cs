// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
/********************************************************************++

    Project:     PowerShell

    Contents:    PowerShell token interface for syntax editors

    Classes:     System.Management.Automation.PSToken

--********************************************************************/

using System.Management.Automation.Language;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class PSToken
    {
        internal PSToken(Token token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1568, 940, 1348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2234, 2242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3276, 3308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 14444, 14451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 994, 1023);

                Type = f_1568_1001_1022(token);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1037, 1060);

                _extent = f_1568_1047_1059(token);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1074, 1337) || true) && (token is StringToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 1074, 1337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1132, 1170);

                    _content = f_1568_1143_1169(((StringToken)token));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 1074, 1337);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 1074, 1337);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1204, 1337) || true) && (token is VariableToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 1204, 1337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1264, 1322);

                        _content = f_1568_1275_1321(f_1568_1275_1310(((VariableToken)token)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 1204, 1337);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 1074, 1337);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1568, 940, 1348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 940, 1348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 940, 1348);
            }
        }

        internal PSToken(IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1568, 1360, 1493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2234, 2242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3276, 3308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 14444, 14451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1423, 1451);

                Type = PSTokenType.Position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 1465, 1482);

                _extent = extent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1568, 1360, 1493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 1360, 1493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 1360, 1493);
            }
        }

        public string Content
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 2113, 2196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2149, 2181);

                    return _content ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1568, 2156, 2180) ?? f_1568_2168_2180(_extent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 2113, 2196);

                    string
                    f_1568_2168_2180(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 2168, 2180);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 2067, 2207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 2067, 2207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _content;

        public static PSTokenType GetPSTokenType(Token token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1568, 2488, 3192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2566, 2694) || true) && ((f_1568_2571_2587(token) & TokenFlags.CommandName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 2566, 2694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2652, 2679);

                    return PSTokenType.Command;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 2566, 2694);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2710, 2836) || true) && ((f_1568_2715_2731(token) & TokenFlags.MemberName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 2710, 2836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2795, 2821);

                    return PSTokenType.Member;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 2710, 2836);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2852, 2984) || true) && ((f_1568_2857_2873(token) & TokenFlags.AttributeName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 2852, 2984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 2940, 2969);

                    return PSTokenType.Attribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 2852, 2984);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3000, 3122) || true) && ((f_1568_3005_3021(token) & TokenFlags.TypeName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1568, 3000, 3122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3083, 3107);

                    return PSTokenType.Type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1568, 3000, 3122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3138, 3181);

                return s_tokenKindMapping[(int)f_1568_3169_3179(token)];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1568, 2488, 3192);

                System.Management.Automation.Language.TokenFlags
                f_1568_2571_2587(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 2571, 2587);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1568_2715_2731(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 2715, 2731);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1568_2857_2873(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 2857, 2873);
                    return return_v;
                }


                System.Management.Automation.Language.TokenFlags
                f_1568_3005_3021(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.TokenFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 3005, 3021);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1568_3169_3179(System.Management.Automation.Language.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 3169, 3179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 2488, 3192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 2488, 3192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSTokenType Type { get; }

        private static readonly PSTokenType[] s_tokenKindMapping;

        private readonly IScriptExtent _extent;

        public int Start
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 14605, 14640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 14611, 14638);

                    return f_1568_14618_14637(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 14605, 14640);

                    int
                    f_1568_14618_14637(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 14618, 14637);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 14564, 14651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 14564, 14651);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 14803, 14901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 14839, 14886);

                    return f_1568_14846_14863(_extent) - f_1568_14866_14885(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 14803, 14901);

                    int
                    f_1568_14846_14863(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.EndOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 14846, 14863);
                        return return_v;
                    }


                    int
                    f_1568_14866_14885(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 14866, 14885);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 14761, 14912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 14761, 14912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartLine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 15269, 15308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 15275, 15306);

                    return f_1568_15282_15305(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 15269, 15308);

                    int
                    f_1568_15282_15305(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 15282, 15305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 15246, 15310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 15246, 15310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartColumn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 15446, 15487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 15452, 15485);

                    return f_1568_15459_15484(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 15446, 15487);

                    int
                    f_1568_15459_15484(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.StartColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 15459, 15484);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 15421, 15489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 15421, 15489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndLine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 15608, 15645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 15614, 15643);

                    return f_1568_15621_15642(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 15608, 15645);

                    int
                    f_1568_15621_15642(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.EndLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 15621, 15642);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 15587, 15647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 15587, 15647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndColumn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1568, 15777, 15816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 15783, 15814);

                    return f_1568_15790_15813(_extent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1568, 15777, 15816);

                    int
                    f_1568_15790_15813(System.Management.Automation.Language.IScriptExtent
                    this_param)
                    {
                        var return_v = this_param.EndColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 15790, 15813);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1568, 15754, 15818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 15754, 15818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSToken()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1568, 896, 15847);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1568, 3358, 14338);
            s_tokenKindMapping = new PSTokenType[]
                    {
            
            /*              Unknown */ PSTokenType.Unknown,
            /*             Variable */ PSTokenType.Variable,
            /*     SplattedVariable */ PSTokenType.Variable,
            /*            Parameter */ PSTokenType.CommandParameter,
            /*               Number */ PSTokenType.Number,
            /*                Label */ PSTokenType.LoopLabel,
            /*           Identifier */ PSTokenType.CommandArgument,

            /*              Generic */ PSTokenType.CommandArgument,
            /*              Newline */ PSTokenType.NewLine,
            /*     LineContinuation */ PSTokenType.LineContinuation,
            /*              Comment */ PSTokenType.Comment,
            /*           EndOfInput */ PSTokenType.Unknown,

            
            
            /*        StringLiteral */ PSTokenType.String,
            /*     StringExpandable */ PSTokenType.String,
            /*    HereStringLiteral */ PSTokenType.String,
            /* HereStringExpandable */ PSTokenType.String,

            
            
            /*               LParen */ PSTokenType.GroupStart,
            /*               RParen */ PSTokenType.GroupEnd,
            /*               LCurly */ PSTokenType.GroupStart,
            /*               RCurly */ PSTokenType.GroupEnd,
            /*             LBracket */ PSTokenType.Operator,
            /*             RBracket */ PSTokenType.Operator,
            /*              AtParen */ PSTokenType.GroupStart,
            /*              AtCurly */ PSTokenType.GroupStart,
            /*          DollarParen */ PSTokenType.GroupStart,
            /*                 Semi */ PSTokenType.StatementSeparator,

            
            
            /*               AndAnd */ PSTokenType.Operator,
            /*                 OrOr */ PSTokenType.Operator,
            /*            Ampersand */ PSTokenType.Operator,
            /*                 Pipe */ PSTokenType.Operator,
            /*                Comma */ PSTokenType.Operator,
            /*           MinusMinus */ PSTokenType.Operator,
            /*             PlusPlus */ PSTokenType.Operator,
            /*               DotDot */ PSTokenType.Operator,
            /*           ColonColon */ PSTokenType.Operator,
            /*                  Dot */ PSTokenType.Operator,
            /*              Exclaim */ PSTokenType.Operator,
            /*             Multiply */ PSTokenType.Operator,
            /*               Divide */ PSTokenType.Operator,
            /*                  Rem */ PSTokenType.Operator,
            /*                 Plus */ PSTokenType.Operator,
            /*                Minus */ PSTokenType.Operator,
            /*               Equals */ PSTokenType.Operator,
            /*           PlusEquals */ PSTokenType.Operator,
            /*          MinusEquals */ PSTokenType.Operator,
            /*       MultiplyEquals */ PSTokenType.Operator,
            /*         DivideEquals */ PSTokenType.Operator,
            /*      RemainderEquals */ PSTokenType.Operator,
            /*          Redirection */ PSTokenType.Operator,
            /*        RedirectInStd */ PSTokenType.Operator,
            /*               Format */ PSTokenType.Operator,
            /*                  Not */ PSTokenType.Operator,
            /*                 Bnot */ PSTokenType.Operator,
            /*                  And */ PSTokenType.Operator,
            /*                   Or */ PSTokenType.Operator,
            /*                  Xor */ PSTokenType.Operator,
            /*                 Band */ PSTokenType.Operator,
            /*                  Bor */ PSTokenType.Operator,
            /*                 Bxor */ PSTokenType.Operator,
            /*                 Join */ PSTokenType.Operator,
            /*                  Ieq */ PSTokenType.Operator,
            /*                  Ine */ PSTokenType.Operator,
            /*                  Ige */ PSTokenType.Operator,
            /*                  Igt */ PSTokenType.Operator,
            /*                  Ilt */ PSTokenType.Operator,
            /*                  Ile */ PSTokenType.Operator,
            /*                Ilike */ PSTokenType.Operator,
            /*             Inotlike */ PSTokenType.Operator,
            /*               Imatch */ PSTokenType.Operator,
            /*            Inotmatch */ PSTokenType.Operator,
            /*             Ireplace */ PSTokenType.Operator,
            /*            Icontains */ PSTokenType.Operator,
            /*         Inotcontains */ PSTokenType.Operator,
            /*                  Iin */ PSTokenType.Operator,
            /*               Inotin */ PSTokenType.Operator,
            /*               Isplit */ PSTokenType.Operator,
            /*                  Ceq */ PSTokenType.Operator,
            /*                  Cne */ PSTokenType.Operator,
            /*                  Cge */ PSTokenType.Operator,
            /*                  Cgt */ PSTokenType.Operator,
            /*                  Clt */ PSTokenType.Operator,
            /*                  Cle */ PSTokenType.Operator,
            /*                Clike */ PSTokenType.Operator,
            /*             Cnotlike */ PSTokenType.Operator,
            /*               Cmatch */ PSTokenType.Operator,
            /*            Cnotmatch */ PSTokenType.Operator,
            /*             Creplace */ PSTokenType.Operator,
            /*            Ccontains */ PSTokenType.Operator,
            /*         Cnotcontains */ PSTokenType.Operator,
            /*                  Cin */ PSTokenType.Operator,
            /*               Cnotin */ PSTokenType.Operator,
            /*               Csplit */ PSTokenType.Operator,
            /*                   Is */ PSTokenType.Operator,
            /*                IsNot */ PSTokenType.Operator,
            /*                   As */ PSTokenType.Operator,
            /*      PostFixPlusPlus */ PSTokenType.Operator,
            /*    PostFixMinusMinus */ PSTokenType.Operator,
            /*                  Shl */ PSTokenType.Operator,
            /*                  Shr */ PSTokenType.Operator,
            /*    Reserved slot 1   */ PSTokenType.Unknown,
            /*    Reserved slot 2   */ PSTokenType.Unknown,
            /*    Reserved slot 3   */ PSTokenType.Unknown,
            /*    Reserved slot 4   */ PSTokenType.Unknown,
            /*    Reserved slot 5   */ PSTokenType.Unknown,
            /*    Reserved slot 6   */ PSTokenType.Unknown,
            /*    Reserved slot 7   */ PSTokenType.Unknown,
            /*    Reserved slot 8   */ PSTokenType.Unknown,
            /*    Reserved slot 9   */ PSTokenType.Unknown,
            /*    Reserved slot 10  */ PSTokenType.Unknown,
            /*    Reserved slot 11  */ PSTokenType.Unknown,
            /*    Reserved slot 12  */ PSTokenType.Unknown,
            /*    Reserved slot 13  */ PSTokenType.Unknown,
            /*    Reserved slot 14  */ PSTokenType.Unknown,
            /*    Reserved slot 15  */ PSTokenType.Unknown,
            /*    Reserved slot 16  */ PSTokenType.Unknown,
            /*    Reserved slot 17  */ PSTokenType.Unknown,
            /*    Reserved slot 18  */ PSTokenType.Unknown,
            /*    Reserved slot 19  */ PSTokenType.Unknown,
            /*    Reserved slot 20  */ PSTokenType.Unknown,

            
            
            /*                Begin */ PSTokenType.Keyword,
            /*                Break */ PSTokenType.Keyword,
            /*                Catch */ PSTokenType.Keyword,
            /*                Class */ PSTokenType.Keyword,
            /*             Continue */ PSTokenType.Keyword,
            /*                 Data */ PSTokenType.Keyword,
            /*               Define */ PSTokenType.Keyword,
            /*                   Do */ PSTokenType.Keyword,
            /*         Dynamicparam */ PSTokenType.Keyword,
            /*                 Else */ PSTokenType.Keyword,
            /*               ElseIf */ PSTokenType.Keyword,
            /*                  End */ PSTokenType.Keyword,
            /*                 Exit */ PSTokenType.Keyword,
            /*               Filter */ PSTokenType.Keyword,
            /*              Finally */ PSTokenType.Keyword,
            /*                  For */ PSTokenType.Keyword,
            /*              Foreach */ PSTokenType.Keyword,
            /*                 From */ PSTokenType.Keyword,
            /*             Function */ PSTokenType.Keyword,
            /*                   If */ PSTokenType.Keyword,
            /*                   In */ PSTokenType.Keyword,
            /*                Param */ PSTokenType.Keyword,
            /*              Process */ PSTokenType.Keyword,
            /*               Return */ PSTokenType.Keyword,
            /*               Switch */ PSTokenType.Keyword,
            /*                Throw */ PSTokenType.Keyword,
            /*                 Trap */ PSTokenType.Keyword,
            /*                  Try */ PSTokenType.Keyword,
            /*                Until */ PSTokenType.Keyword,
            /*                Using */ PSTokenType.Keyword,
            /*                  Var */ PSTokenType.Keyword,
            /*                While */ PSTokenType.Keyword,
            /*             Workflow */ PSTokenType.Keyword,
            /*             Parallel */ PSTokenType.Keyword,
            /*             Sequence */ PSTokenType.Keyword,
            /*         InlineScript */ PSTokenType.Keyword,
            /*        Configuration */ PSTokenType.Keyword,
            /*       DynamicKeyword */ PSTokenType.Keyword,
            /*               Public */ PSTokenType.Keyword,
            /*              Private */ PSTokenType.Keyword,
            /*               Static */ PSTokenType.Keyword,
            /*            Interface */ PSTokenType.Keyword,
            /*                 Enum */ PSTokenType.Keyword,
            /*            Namespace */ PSTokenType.Keyword,
            /*               Module */ PSTokenType.Keyword,
            /*                 Type */ PSTokenType.Keyword,
            /*             Assembly */ PSTokenType.Keyword,
            /*              Command */ PSTokenType.Keyword,
            /*                  Def */ PSTokenType.Keyword,

            
            /*            LastToken */ PSTokenType.Unknown,
                    };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1568, 896, 15847);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1568, 896, 15847);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1568, 896, 15847);

        System.Management.Automation.PSTokenType
        f_1568_1001_1022(System.Management.Automation.Language.Token
        token)
        {
            var return_v = GetPSTokenType(token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1568, 1001, 1022);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1568_1047_1059(System.Management.Automation.Language.Token
        this_param)
        {
            var return_v = this_param.Extent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 1047, 1059);
            return return_v;
        }


        string
        f_1568_1143_1169(System.Management.Automation.Language.StringToken
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 1143, 1169);
            return return_v;
        }


        System.Management.Automation.VariablePath
        f_1568_1275_1310(System.Management.Automation.Language.VariableToken
        this_param)
        {
            var return_v = this_param.VariablePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1568, 1275, 1310);
            return return_v;
        }


        string
        f_1568_1275_1321(System.Management.Automation.VariablePath
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1568, 1275, 1321);
            return return_v;
        }

    }

    /// <summary>
    /// PowerShell token types.
    /// </summary>
    public enum PSTokenType
    {
        /// <summary>
        /// Unknown token.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Unknown,

        /// <summary>
        /// Command.
        /// </summary>
        /// <remarks>
        /// For example, 'get-process' in
        ///
        ///     get-process -name foo
        /// </remarks>
        Command,

        /// <summary>
        /// Command Parameter.
        /// </summary>
        /// <remarks>
        /// For example, '-name' in
        ///
        ///     get-process -name foo
        /// </remarks>
        CommandParameter,

        /// <summary>
        /// Command Argument.
        /// </summary>
        /// <remarks>
        /// For example, 'foo' in
        ///
        ///     get-process -name foo
        /// </remarks>
        CommandArgument,

        /// <summary>
        /// Number.
        /// </summary>
        /// <remarks>
        /// For example, 12 in
        ///
        ///     $a=12
        /// </remarks>
        Number,

        /// <summary>
        /// String.
        /// </summary>
        /// <remarks>
        /// For example, "12" in
        ///
        ///     $a="12"
        /// </remarks>
        String,

        /// <summary>
        /// Variable.
        /// </summary>
        /// <remarks>
        /// For example, $a in
        ///
        ///     $a="12"
        /// </remarks>
        Variable,

        /// <summary>
        /// Property name or method name.
        /// </summary>
        /// <remarks>
        /// For example, Name in
        ///
        ///     $a.Name
        /// </remarks>
        Member,

        /// <summary>
        /// Loop label.
        /// </summary>
        /// <remarks>
        /// For example, :loop in
        ///
        ///     :loop
        ///     foreach($a in $b)
        ///     {
        ///         $a
        ///     }
        /// </remarks>
        LoopLabel,

        /// <summary>
        /// Attributes.
        /// </summary>
        /// <remarks>
        /// For example, Mandatory in
        ///
        ///     param([Mandatory] $a)
        /// </remarks>
        Attribute,

        /// <summary>
        /// Types.
        /// </summary>
        /// <remarks>
        /// For example, [string] in
        ///
        ///     $a = [string] 12
        /// </remarks>
        Type,

        /// <summary>
        /// Operators.
        /// </summary>
        /// <remarks>
        /// For example, + in
        ///
        ///     $a = 1 + 2
        /// </remarks>
        Operator,

        /// <summary>
        /// Group Starter.
        /// </summary>
        /// <remarks>
        /// For example, { in
        ///
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        GroupStart,

        /// <summary>
        /// Group Ender.
        /// </summary>
        /// <remarks>
        /// For example, } in
        ///
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        GroupEnd,

        /// <summary>
        /// Keyword.
        /// </summary>
        /// <remarks>
        /// For example, if in
        ///
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        Keyword,

        /// <summary>
        /// Comment.
        /// </summary>
        /// <remarks>
        /// For example, #here in
        ///
        ///     #here
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        Comment,

        /// <summary>
        /// Statement separator. This is ';'
        /// </summary>
        /// <remarks>
        /// For example, ; in
        ///
        ///     #here
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        StatementSeparator,

        /// <summary>
        /// New line. This is '\n'
        /// </summary>
        /// <remarks>
        /// For example, \n in
        ///
        ///     #here
        ///     if ($a -gt 4)
        ///     {
        ///         $a++;
        ///     }
        /// </remarks>
        NewLine,

        /// <summary>
        /// Line continuation.
        /// </summary>
        /// <remarks>
        /// For example, ` in
        ///
        ///     get-command -name `
        ///     foo
        /// </remarks>
        LineContinuation,

        /// <summary>
        /// Position token.
        /// </summary>
        /// <remarks>
        /// Position token are bogus tokens generated for identifying a location
        /// in the script.
        /// </remarks>
        Position
    }
}
