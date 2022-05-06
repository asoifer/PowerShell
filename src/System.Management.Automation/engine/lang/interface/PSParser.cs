// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
/********************************************************************++

    Project:     PowerShell

    Contents:    PowerShell parser interface for syntax editors

    Classes:     System.Management.Automation.PSParser

--********************************************************************/

using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Language;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class PSParser
    {
        private PSParser()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1567, 2926, 2966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3049, 3088);
                this._tokenList = f_1567_3062_3088();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3129, 3136);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1567, 2926, 2966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 2926, 2966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 2926, 2966);
            }
        }

        private readonly List<Language.Token> _tokenList;

        private Language.ParseError[] _errors;

        private void Parse(string script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1567, 3149, 3479);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3243, 3303);

                    var
                    parser = new Language.Parser { ProduceV2Tokens = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1567, 3256, 3302) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3321, 3392);

                    f_1567_3321_3391(parser, null, script, _tokenList, out _errors, ParseMode.Default);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1567, 3421, 3468);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1567, 3421, 3468);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1567, 3149, 3479);

                System.Management.Automation.Language.ScriptBlockAst
                f_1567_3321_3391(System.Management.Automation.Language.Parser
                this_param, string
                fileName, string
                input, System.Collections.Generic.List<System.Management.Automation.Language.Token>
                tokenList, out System.Management.Automation.Language.ParseError[]
                errors, System.Management.Automation.Language.ParseMode
                parseMode)
                {
                    var return_v = this_param.Parse(fileName, input, tokenList, out errors, parseMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 3321, 3391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 3149, 3479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 3149, 3479);
            }
        }

        private Collection<PSToken> Tokens
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1567, 3673, 4092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3709, 3770);

                    Collection<PSToken>
                    resultTokens = f_1567_3744_3769()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3855, 3860);
                        // Skip the last token, it's always EOF.
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3846, 4037) || true) && (i < f_1567_3866_3882(_tokenList) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3888, 3891)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 3846, 4037))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 3846, 4037);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3933, 3959);

                            var
                            token = f_1567_3945_3958(_tokenList, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 3981, 4018);

                            f_1567_3981_4017(resultTokens, f_1567_3998_4016(token));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1567, 1, 192);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1567, 1, 192);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 4057, 4077);

                    return resultTokens;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1567, 3673, 4092);

                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSToken>
                    f_1567_3744_3769()
                    {
                        var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 3744, 3769);
                        return return_v;
                    }


                    int
                    f_1567_3866_3882(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1567, 3866, 3882);
                        return return_v;
                    }


                    System.Management.Automation.Language.Token
                    f_1567_3945_3958(System.Collections.Generic.List<System.Management.Automation.Language.Token>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1567, 3945, 3958);
                        return return_v;
                    }


                    System.Management.Automation.PSToken
                    f_1567_3998_4016(System.Management.Automation.Language.Token
                    token)
                    {
                        var return_v = new System.Management.Automation.PSToken(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 3998, 4016);
                        return return_v;
                    }


                    int
                    f_1567_3981_4017(System.Collections.ObjectModel.Collection<System.Management.Automation.PSToken>
                    this_param, System.Management.Automation.PSToken
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 3981, 4017);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 3614, 4103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 3614, 4103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<PSParseError> Errors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1567, 4301, 4613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 4337, 4408);

                    Collection<PSParseError>
                    resultErrors = f_1567_4377_4407()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 4426, 4558);
                        foreach (var error in f_1567_4448_4455_I(_errors))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 4426, 4558);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 4497, 4539);

                            f_1567_4497_4538(resultErrors, f_1567_4514_4537(error));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 4426, 4558);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1567, 1, 133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1567, 1, 133);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 4578, 4598);

                    return resultErrors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1567, 4301, 4613);

                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSParseError>
                    f_1567_4377_4407()
                    {
                        var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.PSParseError>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 4377, 4407);
                        return return_v;
                    }


                    System.Management.Automation.PSParseError
                    f_1567_4514_4537(System.Management.Automation.Language.ParseError
                    error)
                    {
                        var return_v = new System.Management.Automation.PSParseError(error);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 4514, 4537);
                        return return_v;
                    }


                    int
                    f_1567_4497_4538(System.Collections.ObjectModel.Collection<System.Management.Automation.PSParseError>
                    this_param, System.Management.Automation.PSParseError
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 4497, 4538);
                        return 0;
                    }


                    System.Management.Automation.Language.ParseError[]
                    f_1567_4448_4455_I(System.Management.Automation.Language.ParseError[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 4448, 4455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 4237, 4624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 4237, 4624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static Collection<PSToken> Tokenize(string script, out Collection<PSParseError> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1567, 5618, 6008);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5737, 5829) || true) && (script == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 5737, 5829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5774, 5829);

                    throw f_1567_5780_5828("script");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 5737, 5829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5845, 5880);

                PSParser
                psParser = f_1567_5865_5879()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5896, 5919);

                f_1567_5896_5918(
                            psParser, script);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5933, 5958);

                errors = f_1567_5942_5957(psParser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 5974, 5997);

                return f_1567_5981_5996(psParser);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1567, 5618, 6008);

                System.Management.Automation.PSArgumentNullException
                f_1567_5780_5828(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 5780, 5828);
                    return return_v;
                }


                System.Management.Automation.PSParser
                f_1567_5865_5879()
                {
                    var return_v = new System.Management.Automation.PSParser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 5865, 5879);
                    return return_v;
                }


                int
                f_1567_5896_5918(System.Management.Automation.PSParser
                this_param, string
                script)
                {
                    this_param.Parse(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 5896, 5918);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSParseError>
                f_1567_5942_5957(System.Management.Automation.PSParser
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1567, 5942, 5957);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSToken>
                f_1567_5981_5996(System.Management.Automation.PSParser
                this_param)
                {
                    var return_v = this_param.Tokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1567, 5981, 5996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 5618, 6008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 5618, 6008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Collection<PSToken> Tokenize(object[] script, out Collection<PSParseError> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1567, 6972, 7508);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7093, 7185) || true) && (script == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 7093, 7185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7130, 7185);

                    throw f_1567_7136_7184("script");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 7093, 7185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7201, 7240);

                StringBuilder
                sb = f_1567_7220_7239()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7254, 7438);
                    foreach (object obj in f_1567_7277_7283_I(script))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 7254, 7438);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7317, 7423) || true) && (obj != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1567, 7317, 7423);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7374, 7404);

                            f_1567_7374_7403(sb, f_1567_7388_7402(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 7317, 7423);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1567, 7254, 7438);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1567, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1567, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1567, 7454, 7497);

                return f_1567_7461_7496(f_1567_7470_7483(sb), out errors);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1567, 6972, 7508);

                System.Management.Automation.PSArgumentNullException
                f_1567_7136_7184(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7136, 7184);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1567_7220_7239()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7220, 7239);
                    return return_v;
                }


                string?
                f_1567_7388_7402(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7388, 7402);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1567_7374_7403(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7374, 7403);
                    return return_v;
                }


                object[]
                f_1567_7277_7283_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7277, 7283);
                    return return_v;
                }


                string
                f_1567_7470_7483(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7470, 7483);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSToken>
                f_1567_7461_7496(string
                script, out System.Collections.ObjectModel.Collection<System.Management.Automation.PSParseError>
                errors)
                {
                    var return_v = Tokenize(script, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 7461, 7496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1567, 6972, 7508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 6972, 7508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1567, 2585, 7537);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1567, 2585, 7537);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1567, 2585, 7537);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1567, 2585, 7537);

        System.Collections.Generic.List<System.Management.Automation.Language.Token>
        f_1567_3062_3088()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1567, 3062, 3088);
            return return_v;
        }

    }
}
