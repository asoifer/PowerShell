// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class FlagsExpression<T> where T : struct, IConvertible
    {
        public FlagsExpression(string expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 894, 1866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11380, 11397);
                this._underType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11462, 11502);
                this.Root = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 960, 1215) || true) && (f_1269_964_981_M(!typeof(T).IsEnum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 960, 1215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1015, 1200);

                    throw f_1269_1021_1199(expression, typeof(RuntimeException), null, "InvalidGenericType", f_1269_1149_1198());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 960, 1215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1231, 1278);

                _underType = f_1269_1244_1277(typeof(T));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1294, 1565) || true) && (f_1269_1298_1335(expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 1294, 1565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1369, 1550);

                    throw f_1269_1375_1549(expression, typeof(RuntimeException), null, "EmptyInputString", f_1269_1501_1548());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 1294, 1565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1581, 1631);

                List<Token>
                tokenList = f_1269_1605_1630(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1714, 1753);

                f_1269_1714_1752(            // Append an OR at the end of the list for construction
                            tokenList, f_1269_1728_1751(TokenKind.Or));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1769, 1797);

                f_1269_1769_1796(this, tokenList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 1813, 1855);

                Root = f_1269_1820_1854(this, tokenList);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 894, 1866);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 894, 1866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 894, 1866);
            }
        }

        public FlagsExpression(object[] expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 2208, 3799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11380, 11397);
                this._underType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11462, 11502);
                this.Root = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2276, 2531) || true) && (f_1269_2280_2297_M(!typeof(T).IsEnum))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 2276, 2531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2331, 2516);

                    throw f_1269_2337_2515(expression, typeof(RuntimeException), null, "InvalidGenericType", f_1269_2465_2514());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 2276, 2531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2547, 2594);

                _underType = f_1269_2560_2593(typeof(T));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2610, 2861) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 2610, 2861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2666, 2846);

                    throw f_1269_2672_2845(null, typeof(ArgumentNullException), null, "EmptyInputString", f_1269_2797_2844());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 2610, 2861);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2877, 3255);
                    foreach (string inputClause in f_1269_2908_2918_I(expression))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 2877, 3255);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 2952, 3240) || true) && (f_1269_2956_2994(inputClause))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 2952, 3240);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3036, 3221);

                            throw f_1269_3042_3220(expression, typeof(RuntimeException), null, "EmptyInputString", f_1269_3172_3219());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 2952, 3240);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 2877, 3255);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 1, 379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 1, 379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3271, 3313);

                List<Token>
                tokenList = f_1269_3295_3312()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3329, 3517);
                    foreach (string orClause in f_1269_3357_3367_I(expression))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 3329, 3517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3401, 3445);

                        f_1269_3401_3444(tokenList, f_1269_3420_3443(this, orClause));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3463, 3502);

                        f_1269_3463_3501(tokenList, f_1269_3477_3500(TokenKind.Or));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 3329, 3517);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3609, 3686);

                f_1269_3609_3685(f_1269_3622_3637(tokenList) > 0, "Input must not all be white characters.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3702, 3730);

                f_1269_3702_3729(this, tokenList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 3746, 3788);

                Root = f_1269_3753_3787(this, tokenList);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 2208, 3799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 2208, 3799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 2208, 3799);
            }
        }



        internal enum TokenKind
        {
            Identifier,
            And,
            Or,
            Not
        }
        internal class Token
        {
            public string Text { get; set; }

            public TokenKind Kind { get; set; }

            internal Token(TokenKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 4144, 4778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4045, 4077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4093, 4128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4207, 4219);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4237, 4763);

                    switch (kind)
                    {

                        case TokenKind.Or:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 4237, 4763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4335, 4347);

                            Text = "OR";
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 4373, 4379);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 4237, 4763);

                        case TokenKind.And:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 4237, 4763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4446, 4459);

                            Text = "AND";
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 4485, 4491);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 4237, 4763);

                        case TokenKind.Not:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 4237, 4763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4558, 4571);

                            Text = "NOT";
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 4597, 4603);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 4237, 4763);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 4237, 4763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4659, 4712);

                            f_1269_4659_4711(false, "Invalid token kind passed in.");
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 4738, 4744);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 4237, 4763);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 4144, 4778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 4144, 4778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 4144, 4778);
                }
            }

            internal Token(string identifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 4794, 4939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4045, 4077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4093, 4128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4860, 4888);

                    Kind = TokenKind.Identifier;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 4906, 4924);

                    Text = identifier;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 4794, 4939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 4794, 4939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 4794, 4939);
                }
            }

            static Token()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 4000, 4950);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 4000, 4950);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 4000, 4950);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 4000, 4950);

            int
            f_1269_4659_4711(bool
            condition, string
            message)
            {
                Debug.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 4659, 4711);
                return 0;
            }

        }
        internal abstract class Node
        {
            public Node Operand1 { get; set; }

            internal abstract bool Eval(object val);

            internal abstract bool ExistEnum(object enumVal);

            public Node()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 5131, 5413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 5249, 5283);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 5131, 5413);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5131, 5413);
            }


            static Node()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 5131, 5413);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 5131, 5413);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5131, 5413);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 5131, 5413);
        }
        internal class OrNode : Node
        {
            public Node Operand2 { get; set; }

            public OrNode(Node n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 5633, 5715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 5583, 5617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 5687, 5700);

                    Operand2 = n;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 5633, 5715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 5633, 5715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5633, 5715);
                }
            }

            internal override bool Eval(object val)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 5731, 5938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 5834, 5890);

                    bool
                    satisfy = f_1269_5849_5867(f_1269_5849_5857(), val) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 5849, 5889) || f_1269_5871_5889(f_1269_5871_5879(), val))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 5908, 5923);

                    return satisfy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 5731, 5938);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_5849_5857()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 5849, 5857);
                        return return_v;
                    }


                    bool
                    f_1269_5849_5867(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    val)
                    {
                        var return_v = this_param.Eval(val);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 5849, 5867);
                        return return_v;
                    }


                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_5871_5879()
                    {
                        var return_v = Operand2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 5871, 5879);
                        return return_v;
                    }


                    bool
                    f_1269_5871_5889(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    val)
                    {
                        var return_v = this_param.Eval(val);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 5871, 5889);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 5731, 5938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5731, 5938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool ExistEnum(object enumVal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 5954, 6153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6035, 6107);

                    bool
                    exist = f_1269_6048_6075(f_1269_6048_6056(), enumVal) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 6048, 6106) || f_1269_6079_6106(f_1269_6079_6087(), enumVal))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6125, 6138);

                    return exist;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 5954, 6153);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6048_6056()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6048, 6056);
                        return return_v;
                    }


                    bool
                    f_1269_6048_6075(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    enumVal)
                    {
                        var return_v = this_param.ExistEnum(enumVal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6048, 6075);
                        return return_v;
                    }


                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6079_6087()
                    {
                        var return_v = Operand2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6079, 6087);
                        return return_v;
                    }


                    bool
                    f_1269_6079_6106(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    enumVal)
                    {
                        var return_v = this_param.ExistEnum(enumVal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6079, 6106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 5954, 6153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5954, 6153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static OrNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 5530, 6164);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 5530, 6164);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 5530, 6164);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 5530, 6164);
        }
        internal class AndNode : Node
        {
            public Node Operand2 { get; set; }

            public AndNode(Node n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 6397, 6480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6347, 6381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6452, 6465);

                    Operand2 = n;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 6397, 6480);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 6397, 6480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 6397, 6480);
                }
            }

            internal override bool Eval(object val)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 6496, 6704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6600, 6656);

                    bool
                    satisfy = f_1269_6615_6633(f_1269_6615_6623(), val) && (DynAbs.Tracing.TraceSender.Expression_True(1269, 6615, 6655) && f_1269_6637_6655(f_1269_6637_6645(), val))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6674, 6689);

                    return satisfy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 6496, 6704);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6615_6623()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6615, 6623);
                        return return_v;
                    }


                    bool
                    f_1269_6615_6633(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    val)
                    {
                        var return_v = this_param.Eval(val);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6615, 6633);
                        return return_v;
                    }


                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6637_6645()
                    {
                        var return_v = Operand2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6637, 6645);
                        return return_v;
                    }


                    bool
                    f_1269_6637_6655(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    val)
                    {
                        var return_v = this_param.Eval(val);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6637, 6655);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 6496, 6704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 6496, 6704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool ExistEnum(object enumVal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 6720, 6919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6801, 6873);

                    bool
                    exist = f_1269_6814_6841(f_1269_6814_6822(), enumVal) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 6814, 6872) || f_1269_6845_6872(f_1269_6845_6853(), enumVal))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 6891, 6904);

                    return exist;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 6720, 6919);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6814_6822()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6814, 6822);
                        return return_v;
                    }


                    bool
                    f_1269_6814_6841(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    enumVal)
                    {
                        var return_v = this_param.ExistEnum(enumVal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6814, 6841);
                        return return_v;
                    }


                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_6845_6853()
                    {
                        var return_v = Operand2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 6845, 6853);
                        return return_v;
                    }


                    bool
                    f_1269_6845_6872(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    enumVal)
                    {
                        var return_v = this_param.ExistEnum(enumVal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 6845, 6872);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 6720, 6919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 6720, 6919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AndNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 6293, 6930);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 6293, 6930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 6293, 6930);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 6293, 6930);
        }
        internal class NotNode : Node
        {
            internal override bool Eval(object val)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 7119, 7308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7223, 7260);

                    bool
                    satisfy = !(f_1269_7240_7258(f_1269_7240_7248(), val))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7278, 7293);

                    return satisfy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 7119, 7308);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_7240_7248()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 7240, 7248);
                        return return_v;
                    }


                    bool
                    f_1269_7240_7258(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    val)
                    {
                        var return_v = this_param.Eval(val);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 7240, 7258);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 7119, 7308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7119, 7308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool ExistEnum(object enumVal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 7324, 7492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7405, 7446);

                    bool
                    exist = f_1269_7418_7445(f_1269_7418_7426(), enumVal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7464, 7477);

                    return exist;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 7324, 7492);

                    System.Management.Automation.FlagsExpression<T>.Node
                    f_1269_7418_7426()
                    {
                        var return_v = Operand1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 7418, 7426);
                        return return_v;
                    }


                    bool
                    f_1269_7418_7445(System.Management.Automation.FlagsExpression<T>.Node
                    this_param, object
                    enumVal)
                    {
                        var return_v = this_param.ExistEnum(enumVal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 7418, 7445);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 7324, 7492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7324, 7492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 7065, 7503);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 7065, 7503);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7065, 7503);
            }


            static NotNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 7065, 7503);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 7065, 7503);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7065, 7503);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 7065, 7503);
        }
        internal class OperandNode : Node
        {
            internal object _operandValue;

            public object OperandValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 7773, 7857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7817, 7838);

                        return _operandValue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 7773, 7857);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 7714, 7977);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7714, 7977);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 7877, 7962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7921, 7943);

                        _operandValue = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 7877, 7962);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 7714, 7977);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7714, 7977);
                    }
                }
            }

            internal OperandNode(string enumString)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1269, 8264, 8647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 7684, 7697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8336, 8362);

                    Type
                    enumType = typeof(T)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8380, 8430);

                    Type
                    underType = f_1269_8397_8429(enumType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8448, 8499);

                    FieldInfo
                    enumItem = f_1269_8469_8498(enumType, enumString)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8517, 8632);

                    _operandValue = f_1269_8533_8631(f_1269_8562_8589(enumItem, enumType), underType, f_1269_8602_8630());
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1269, 8264, 8647);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 8264, 8647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 8264, 8647);
                }
            }

            internal override bool Eval(object val)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 8663, 9863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8735, 8786);

                    Type
                    underType = f_1269_8752_8785(typeof(T))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8845, 8866);

                    bool
                    satisfy = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8884, 9813) || true) && (f_1269_8888_8909(this, underType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 8884, 9813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 8951, 9058);

                        ulong
                        valueToCheck = (ulong)f_1269_8979_9057(val, typeof(ulong), f_1269_9028_9056())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9080, 9197);

                        ulong
                        operandValue = (ulong)f_1269_9108_9196(_operandValue, typeof(ulong), f_1269_9167_9195())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9219, 9277);

                        satisfy = (operandValue == (valueToCheck & operandValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 8884, 9813);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 8884, 9813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9474, 9578);

                        long
                        valueToCheck = (long)f_1269_9500_9577(val, typeof(long), f_1269_9548_9576())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9600, 9714);

                        long
                        operandValue = (long)f_1269_9626_9713(_operandValue, typeof(long), f_1269_9684_9712())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9736, 9794);

                        satisfy = (operandValue == (valueToCheck & operandValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 8884, 9813);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9833, 9848);

                    return satisfy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 8663, 9863);

                    System.Type
                    f_1269_8752_8785(System.Type
                    enumType)
                    {
                        var return_v = Enum.GetUnderlyingType(enumType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8752, 8785);
                        return return_v;
                    }


                    bool
                    f_1269_8888_8909(System.Management.Automation.FlagsExpression<T>.OperandNode
                    this_param, System.Type
                    type)
                    {
                        var return_v = this_param.isUnsigned(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8888, 8909);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_9028_9056()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 9028, 9056);
                        return return_v;
                    }


                    object
                    f_1269_8979_9057(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8979, 9057);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_9167_9195()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 9167, 9195);
                        return return_v;
                    }


                    object
                    f_1269_9108_9196(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 9108, 9196);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_9548_9576()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 9548, 9576);
                        return return_v;
                    }


                    object
                    f_1269_9500_9577(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 9500, 9577);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_9684_9712()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 9684, 9712);
                        return return_v;
                    }


                    object
                    f_1269_9626_9713(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 9626, 9713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 8663, 9863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 8663, 9863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool ExistEnum(object enumVal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 9879, 11084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 9960, 10011);

                    Type
                    underType = f_1269_9977_10010(typeof(T))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10070, 10089);

                    bool
                    exist = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10107, 11036) || true) && (f_1269_10111_10132(this, underType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 10107, 11036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10174, 10285);

                        ulong
                        valueToCheck = (ulong)f_1269_10202_10284(enumVal, typeof(ulong), f_1269_10255_10283())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10307, 10424);

                        ulong
                        operandValue = (ulong)f_1269_10335_10423(_operandValue, typeof(ulong), f_1269_10394_10422())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10446, 10500);

                        exist = valueToCheck == (valueToCheck & operandValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 10107, 11036);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 10107, 11036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10697, 10805);

                        long
                        valueToCheck = (long)f_1269_10723_10804(enumVal, typeof(long), f_1269_10775_10803())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10827, 10941);

                        long
                        operandValue = (long)f_1269_10853_10940(_operandValue, typeof(long), f_1269_10911_10939())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 10963, 11017);

                        exist = valueToCheck == (valueToCheck & operandValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 10107, 11036);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11056, 11069);

                    return exist;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 9879, 11084);

                    System.Type
                    f_1269_9977_10010(System.Type
                    enumType)
                    {
                        var return_v = Enum.GetUnderlyingType(enumType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 9977, 10010);
                        return return_v;
                    }


                    bool
                    f_1269_10111_10132(System.Management.Automation.FlagsExpression<T>.OperandNode
                    this_param, System.Type
                    type)
                    {
                        var return_v = this_param.isUnsigned(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 10111, 10132);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_10255_10283()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 10255, 10283);
                        return return_v;
                    }


                    object
                    f_1269_10202_10284(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 10202, 10284);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_10394_10422()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 10394, 10422);
                        return return_v;
                    }


                    object
                    f_1269_10335_10423(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 10335, 10423);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_10775_10803()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 10775, 10803);
                        return return_v;
                    }


                    object
                    f_1269_10723_10804(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 10723, 10804);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1269_10911_10939()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 10911, 10939);
                        return return_v;
                    }


                    object
                    f_1269_10853_10940(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 10853, 10940);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 9879, 11084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 9879, 11084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool isUnsigned(Type type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 11100, 11287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11167, 11272);

                    return (type == typeof(ulong) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 11175, 11220) || type == typeof(uint)) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 11175, 11246) || type == typeof(ushort)) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 11175, 11270) || type == typeof(byte)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 11100, 11287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 11100, 11287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 11100, 11287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static OperandNode()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 7610, 11298);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 7610, 11298);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 7610, 11298);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 7610, 11298);

            System.Type
            f_1269_8397_8429(System.Type
            enumType)
            {
                var return_v = Enum.GetUnderlyingType(enumType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8397, 8429);
                return return_v;
            }


            System.Reflection.FieldInfo?
            f_1269_8469_8498(System.Type
            this_param, string
            name)
            {
                var return_v = this_param.GetField(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8469, 8498);
                return return_v;
            }


            object?
            f_1269_8562_8589(System.Reflection.FieldInfo
            this_param, System.Type
            obj)
            {
                var return_v = this_param.GetValue((object)obj);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8562, 8589);
                return return_v;
            }


            System.Globalization.CultureInfo
            f_1269_8602_8630()
            {
                var return_v = CultureInfo.InvariantCulture;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 8602, 8630);
                return return_v;
            }


            object
            f_1269_8533_8631(object
            valueToConvert, System.Type
            resultType, System.Globalization.CultureInfo
            formatProvider)
            {
                var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 8533, 8631);
                return return_v;
            }

        }

        private Type _underType;

        internal Node Root { get; set; }

        public bool Evaluate(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 11900, 12092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 11954, 12045);

                object
                val = f_1269_11967_12044(value, _underType, f_1269_12015_12043())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 12059, 12081);

                return f_1269_12066_12080(f_1269_12066_12070(), val);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 11900, 12092);

                System.Globalization.CultureInfo
                f_1269_12015_12043()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 12015, 12043);
                    return return_v;
                }


                object
                f_1269_11967_12044(T
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 11967, 12044);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_12066_12070()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 12066, 12070);
                    return return_v;
                }


                bool
                f_1269_12066_12080(System.Management.Automation.FlagsExpression<T>.Node
                this_param, object
                val)
                {
                    var return_v = this_param.Eval(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 12066, 12080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 11900, 12092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 11900, 12092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ExistsInExpression(T flagName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 12764, 13040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 12833, 12852);

                bool
                exist = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 12866, 12960);

                object
                val = f_1269_12879_12959(flagName, _underType, f_1269_12930_12958())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 12974, 13002);

                exist = f_1269_12982_13001(f_1269_12982_12986(), val);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13016, 13029);

                return exist;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 12764, 13040);

                System.Globalization.CultureInfo
                f_1269_12930_12958()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 12930, 12958);
                    return return_v;
                }


                object
                f_1269_12879_12959(T
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 12879, 12959);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_12982_12986()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 12982, 12986);
                    return return_v;
                }


                bool
                f_1269_12982_13001(System.Management.Automation.FlagsExpression<T>.Node
                this_param, object
                enumVal)
                {
                    var return_v = this_param.ExistEnum(enumVal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 12982, 13001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 12764, 13040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 12764, 13040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<Token> TokenizeInput(string input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 13503, 13972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13575, 13617);

                List<Token>
                tokenList = f_1269_13599_13616()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13631, 13647);

                int
                _offset = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13663, 13928) || true) && (_offset < f_1269_13680_13692(input))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 13663, 13928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13726, 13760);

                        f_1269_13726_13759(this, input, ref _offset);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13778, 13913) || true) && (_offset < f_1269_13792_13804(input))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 13778, 13913);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13846, 13894);

                            f_1269_13846_13893(tokenList, f_1269_13860_13892(this, input, ref _offset));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 13778, 13913);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 13663, 13928);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 13663, 13928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 13663, 13928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 13944, 13961);

                return tokenList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 13503, 13972);

                System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                f_1269_13599_13616()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 13599, 13616);
                    return return_v;
                }


                int
                f_1269_13680_13692(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 13680, 13692);
                    return return_v;
                }


                int
                f_1269_13726_13759(System.Management.Automation.FlagsExpression<T>
                this_param, string
                input, ref int
                _offset)
                {
                    this_param.FindNextToken(input, ref _offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 13726, 13759);
                    return 0;
                }


                int
                f_1269_13792_13804(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 13792, 13804);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_13860_13892(System.Management.Automation.FlagsExpression<T>
                this_param, string
                input, ref int
                _offset)
                {
                    var return_v = this_param.GetNextToken(input, ref _offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 13860, 13892);
                    return return_v;
                }


                int
                f_1269_13846_13893(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                this_param, System.Management.Automation.FlagsExpression<T>.Token
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 13846, 13893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 13503, 13972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 13503, 13972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FindNextToken(string input, ref int _offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 14301, 14642);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 14383, 14631) || true) && (_offset < f_1269_14400_14412(input))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 14383, 14631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 14446, 14473);

                        char
                        cc = f_1269_14456_14472(input, _offset++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 14491, 14616) || true) && (!f_1269_14496_14517(cc))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 14491, 14616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 14559, 14569);

                            _offset--;
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 14591, 14597);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 14491, 14616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 14383, 14631);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 14383, 14631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 14383, 14631);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 14301, 14642);

                int
                f_1269_14400_14412(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 14400, 14412);
                    return return_v;
                }


                char
                f_1269_14456_14472(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 14456, 14472);
                    return return_v;
                }


                bool
                f_1269_14496_14517(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 14496, 14517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 14301, 14642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 14301, 14642);
            }
        }

        private Token GetNextToken(string input, ref int _offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 15168, 17960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15250, 15289);

                StringBuilder
                sb = f_1269_15269_15288()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15389, 15420);

                bool
                readingIdentifier = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15434, 16053) || true) && (_offset < f_1269_15451_15463(input))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 15434, 16053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15497, 15524);

                        char
                        cc = f_1269_15507_15523(input, _offset++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15542, 16038) || true) && ((cc == ',') || (DynAbs.Tracing.TraceSender.Expression_False(1269, 15546, 15572) || (cc == '+')) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 15546, 15587) || (cc == '!')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 15542, 16038);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15629, 15846) || true) && (!readingIdentifier)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 15629, 15846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15701, 15715);

                                f_1269_15701_15714(sb, cc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 15629, 15846);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 15629, 15846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15813, 15823);

                                _offset--;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 15629, 15846);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1269, 15870, 15876);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 15542, 16038);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 15542, 16038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15958, 15972);

                            f_1269_15958_15971(sb, cc);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 15994, 16019);

                            readingIdentifier = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 15542, 16038);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 15434, 16053);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 15434, 16053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 15434, 16053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16069, 16106);

                string
                result = f_1269_16085_16105(f_1269_16085_16098(sb))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16263, 16538) || true) && (f_1269_16267_16280(result) >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(1269, 16267, 16441) && ((f_1269_16308_16317(result, 0) == '\'' && (DynAbs.Tracing.TraceSender.Expression_True(1269, 16308, 16362) && f_1269_16329_16354(result, f_1269_16336_16349(result) - 1) == '\'')) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 16307, 16440) || (f_1269_16385_16394(result, 0) == '\"' && (DynAbs.Tracing.TraceSender.Expression_True(1269, 16385, 16439) && f_1269_16406_16431(result, f_1269_16413_16426(result) - 1) == '\"'))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 16263, 16538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16475, 16523);

                    result = f_1269_16484_16522(result, 1, f_1269_16504_16517(result) - 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 16263, 16538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16554, 16577);

                result = f_1269_16563_16576(result);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16684, 17488) || true) && (f_1269_16688_16721(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 16684, 17488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 16755, 17004);

                    throw f_1269_16761_17003(input, typeof(RuntimeException), null, "EmptyTokenString", f_1269_16882_16929(), f_1269_16952_17002(typeof(T)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 16684, 17488);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 16684, 17488);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17038, 17488) || true) && (f_1269_17042_17051(result, 0) == '(')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17038, 17488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17092, 17137);

                        int
                        matchIndex = f_1269_17109_17136(input, ')', _offset)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17155, 17473) || true) && (f_1269_17159_17184(result, f_1269_17166_17179(result) - 1) == ')' || (DynAbs.Tracing.TraceSender.Expression_False(1269, 17159, 17210) || matchIndex >= 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17155, 17473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17252, 17454);

                            throw f_1269_17258_17453(input, typeof(RuntimeException), null, "NoIdentifierGroupingAllowed", f_1269_17394_17452());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17155, 17473);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17038, 17488);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 16684, 17488);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17504, 17949) || true) && (f_1269_17508_17526(result, ","))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17504, 17949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17560, 17593);

                    return (f_1269_17568_17591(TokenKind.Or));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17504, 17949);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17504, 17949);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17627, 17949) || true) && (f_1269_17631_17649(result, "+"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17627, 17949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17683, 17717);

                        return (f_1269_17691_17715(TokenKind.And));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17627, 17949);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17627, 17949);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17751, 17949) || true) && (f_1269_17755_17773(result, "!"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17751, 17949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17807, 17841);

                            return (f_1269_17815_17839(TokenKind.Not));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17751, 17949);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 17751, 17949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 17907, 17934);

                            return (f_1269_17915_17932(result));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17751, 17949);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17627, 17949);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 17504, 17949);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 15168, 17960);

                System.Text.StringBuilder
                f_1269_15269_15288()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 15269, 15288);
                    return return_v;
                }


                int
                f_1269_15451_15463(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 15451, 15463);
                    return return_v;
                }


                char
                f_1269_15507_15523(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 15507, 15523);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1269_15701_15714(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 15701, 15714);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1269_15958_15971(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 15958, 15971);
                    return return_v;
                }


                string
                f_1269_16085_16098(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16085, 16098);
                    return return_v;
                }


                string
                f_1269_16085_16105(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16085, 16105);
                    return return_v;
                }


                int
                f_1269_16267_16280(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16267, 16280);
                    return return_v;
                }


                char
                f_1269_16308_16317(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16308, 16317);
                    return return_v;
                }


                int
                f_1269_16336_16349(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16336, 16349);
                    return return_v;
                }


                char
                f_1269_16329_16354(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16329, 16354);
                    return return_v;
                }


                char
                f_1269_16385_16394(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16385, 16394);
                    return return_v;
                }


                int
                f_1269_16413_16426(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16413, 16426);
                    return return_v;
                }


                char
                f_1269_16406_16431(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16406, 16431);
                    return return_v;
                }


                int
                f_1269_16504_16517(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16504, 16517);
                    return return_v;
                }


                string
                f_1269_16484_16522(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16484, 16522);
                    return return_v;
                }


                string
                f_1269_16563_16576(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16563, 16576);
                    return return_v;
                }


                bool
                f_1269_16688_16721(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16688, 16721);
                    return return_v;
                }


                string
                f_1269_16882_16929()
                {
                    var return_v = EnumExpressionEvaluatorStrings.EmptyTokenString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 16882, 16929);
                    return return_v;
                }


                string
                f_1269_16952_17002(System.Type
                enumType)
                {
                    var return_v = EnumMinimumDisambiguation.EnumAllValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16952, 17002);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1269_16761_17003(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 16761, 17003);
                    return return_v;
                }


                char
                f_1269_17042_17051(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 17042, 17051);
                    return return_v;
                }


                int
                f_1269_17109_17136(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17109, 17136);
                    return return_v;
                }


                int
                f_1269_17166_17179(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 17166, 17179);
                    return return_v;
                }


                char
                f_1269_17159_17184(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 17159, 17184);
                    return return_v;
                }


                string
                f_1269_17394_17452()
                {
                    var return_v = EnumExpressionEvaluatorStrings.NoIdentifierGroupingAllowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 17394, 17452);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1269_17258_17453(string
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17258, 17453);
                    return return_v;
                }


                bool
                f_1269_17508_17526(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17508, 17526);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_17568_17591(System.Management.Automation.FlagsExpression<T>.TokenKind
                kind)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17568, 17591);
                    return return_v;
                }


                bool
                f_1269_17631_17649(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17631, 17649);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_17691_17715(System.Management.Automation.FlagsExpression<T>.TokenKind
                kind)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17691, 17715);
                    return return_v;
                }


                bool
                f_1269_17755_17773(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17755, 17773);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_17815_17839(System.Management.Automation.FlagsExpression<T>.TokenKind
                kind)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17815, 17839);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_17915_17932(string
                identifier)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.Token(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 17915, 17932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 15168, 17960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 15168, 17960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckSyntaxError(List<Token> tokenList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 18241, 20543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18370, 18404);

                TokenKind
                previous = TokenKind.Or
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18429, 18434);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18420, 20532) || true) && (i < f_1269_18440_18455(tokenList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18457, 18460)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 18420, 20532))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 18420, 20532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18494, 18521);

                        Token
                        token = f_1269_18508_18520(tokenList, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18645, 20236) || true) && (previous == TokenKind.Or || (DynAbs.Tracing.TraceSender.Expression_False(1269, 18649, 18702) || previous == TokenKind.And))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 18645, 20236);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18744, 19103) || true) && ((f_1269_18749_18759(token) == TokenKind.Or) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 18748, 18809) || (f_1269_18781_18791(token) == TokenKind.And)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 18744, 19103);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 18859, 19080);

                                throw f_1269_18865_19079(null, typeof(RuntimeException), null, "SyntaxErrorUnexpectedBinaryOperator", f_1269_19012_19078());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 18744, 19103);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 18645, 20236);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 18645, 20236);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19245, 20236) || true) && (previous == TokenKind.Not)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 19245, 20236);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19316, 19636) || true) && (f_1269_19320_19330(token) != TokenKind.Identifier)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 19316, 19636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19404, 19613);

                                    throw f_1269_19410_19612(null, typeof(RuntimeException), null, "SyntaxErrorIdentifierExpected", f_1269_19551_19611());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 19316, 19636);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 19245, 20236);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 19245, 20236);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19776, 20236) || true) && (previous == TokenKind.Identifier)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 19776, 20236);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19854, 20217) || true) && ((f_1269_19859_19869(token) == TokenKind.Identifier) || (DynAbs.Tracing.TraceSender.Expression_False(1269, 19858, 19927) || (f_1269_19899_19909(token) == TokenKind.Not)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 19854, 20217);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 19977, 20194);

                                        throw f_1269_19983_20193(null, typeof(RuntimeException), null, "SyntaxErrorBinaryOperatorExpected", f_1269_20128_20192());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 19854, 20217);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 19776, 20236);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 19245, 20236);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 18645, 20236);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20256, 20475) || true) && (f_1269_20260_20270(token) == TokenKind.Identifier)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 20256, 20475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20336, 20361);

                            string
                            text = f_1269_20350_20360(token)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20383, 20456);

                            token.Text = f_1269_20396_20455(text, typeof(T));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 20256, 20475);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20495, 20517);

                        previous = f_1269_20506_20516(token);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 1, 2113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 1, 2113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 18241, 20543);

                int
                f_1269_18440_18455(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 18440, 18455);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_18508_18520(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 18508, 18520);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_18749_18759(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 18749, 18759);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_18781_18791(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 18781, 18791);
                    return return_v;
                }


                string
                f_1269_19012_19078()
                {
                    var return_v = EnumExpressionEvaluatorStrings.SyntaxErrorUnexpectedBinaryOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 19012, 19078);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1269_18865_19079(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 18865, 19079);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_19320_19330(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 19320, 19330);
                    return return_v;
                }


                string
                f_1269_19551_19611()
                {
                    var return_v = EnumExpressionEvaluatorStrings.SyntaxErrorIdentifierExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 19551, 19611);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1269_19410_19612(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 19410, 19612);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_19859_19869(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 19859, 19869);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_19899_19909(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 19899, 19909);
                    return return_v;
                }


                string
                f_1269_20128_20192()
                {
                    var return_v = EnumExpressionEvaluatorStrings.SyntaxErrorBinaryOperatorExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 20128, 20192);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1269_19983_20193(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 19983, 20193);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_20260_20270(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 20260, 20270);
                    return return_v;
                }


                string
                f_1269_20350_20360(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 20350, 20360);
                    return return_v;
                }


                string
                f_1269_20396_20455(string
                text, System.Type
                enumType)
                {
                    var return_v = EnumMinimumDisambiguation.EnumDisambiguate(text, enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 20396, 20455);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_20506_20516(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 20506, 20516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 18241, 20543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 18241, 20543);
            }
        }

        private Node ConstructExpressionTree(List<Token> tokenList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1269, 20802, 23043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20886, 20907);

                bool
                notFlag = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20921, 20962);

                Queue<Node>
                andQueue = f_1269_20944_20961()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 20976, 21016);

                Queue<Node>
                orQueue = f_1269_20998_21015()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21041, 21046);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21032, 22626) || true) && (i < f_1269_21052_21067(tokenList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21069, 21072)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21032, 22626))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21032, 22626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21106, 21133);

                        Token
                        token = f_1269_21120_21132(tokenList, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21151, 21179);

                        TokenKind
                        kind = f_1269_21168_21178(token)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21197, 22611) || true) && (kind == TokenKind.Identifier)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21197, 22611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21271, 21313);

                            Node
                            idNode = f_1269_21285_21312(f_1269_21301_21311(token))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21335, 21750) || true) && (notFlag)
                            )    // identifier preceded by NOT

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21335, 21750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21429, 21458);

                                Node
                                notNode = f_1269_21444_21457()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21484, 21510);

                                notNode.Operand1 = idNode;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21536, 21552);

                                notFlag = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21578, 21604);

                                f_1269_21578_21603(andQueue, notNode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21335, 21750);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21335, 21750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21702, 21727);

                                f_1269_21702_21726(andQueue, idNode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21335, 21750);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21197, 22611);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21197, 22611);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21792, 22611) || true) && (kind == TokenKind.Not)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21792, 22611);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21859, 21874);

                                notFlag = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21792, 22611);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21792, 22611);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 21916, 22611) || true) && (kind == TokenKind.And)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21916, 22611);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21916, 22611);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 21916, 22611);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22038, 22611) || true) && (kind == TokenKind.Or)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 22038, 22611);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22233, 22270);

                                        Node
                                        andCurrent = f_1269_22251_22269(andQueue)
                                        ;
                                        try
                                        {
                                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22292, 22540) || true) && (f_1269_22299_22313(andQueue) > 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 22292, 22540);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22367, 22406);

                                                Node
                                                andNode = f_1269_22382_22405(andCurrent)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22432, 22470);

                                                andNode.Operand1 = f_1269_22451_22469(andQueue);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22496, 22517);

                                                andCurrent = andNode;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 22292, 22540);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 22292, 22540);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 22292, 22540);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22564, 22592);

                                        f_1269_22564_22591(
                                                            orQueue, andCurrent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 22038, 22611);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21916, 22611);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21792, 22611);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 21197, 22611);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 1, 1595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 1, 1595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22750, 22785);

                Node
                orCurrent = f_1269_22767_22784(orQueue)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22799, 22999) || true) && (f_1269_22806_22819(orQueue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1269, 22799, 22999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22857, 22893);

                        Node
                        orNode = f_1269_22871_22892(orCurrent)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22911, 22947);

                        orNode.Operand1 = f_1269_22929_22946(orQueue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 22965, 22984);

                        orCurrent = orNode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1269, 22799, 22999);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1269, 22799, 22999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1269, 22799, 22999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1269, 23015, 23032);

                return orCurrent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1269, 20802, 23043);

                System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                f_1269_20944_20961()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 20944, 20961);
                    return return_v;
                }


                System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                f_1269_20998_21015()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 20998, 21015);
                    return return_v;
                }


                int
                f_1269_21052_21067(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 21052, 21067);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Token
                f_1269_21120_21132(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 21120, 21132);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.TokenKind
                f_1269_21168_21178(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 21168, 21178);
                    return return_v;
                }


                string
                f_1269_21301_21311(System.Management.Automation.FlagsExpression<T>.Token
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 21301, 21311);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.OperandNode
                f_1269_21285_21312(string
                enumString)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.OperandNode(enumString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 21285, 21312);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.NotNode
                f_1269_21444_21457()
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.NotNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 21444, 21457);
                    return return_v;
                }


                int
                f_1269_21578_21603(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param, System.Management.Automation.FlagsExpression<T>.Node
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 21578, 21603);
                    return 0;
                }


                int
                f_1269_21702_21726(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param, System.Management.Automation.FlagsExpression<T>.Node
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 21702, 21726);
                    return 0;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_22251_22269(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22251, 22269);
                    return return_v;
                }


                int
                f_1269_22299_22313(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 22299, 22313);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.AndNode
                f_1269_22382_22405(System.Management.Automation.FlagsExpression<T>.Node
                n)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.AndNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22382, 22405);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_22451_22469(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22451, 22469);
                    return return_v;
                }


                int
                f_1269_22564_22591(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param, System.Management.Automation.FlagsExpression<T>.Node
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22564, 22591);
                    return 0;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_22767_22784(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22767, 22784);
                    return return_v;
                }


                int
                f_1269_22806_22819(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 22806, 22819);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.OrNode
                f_1269_22871_22892(System.Management.Automation.FlagsExpression<T>.Node
                n)
                {
                    var return_v = new System.Management.Automation.FlagsExpression<T>.OrNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22871, 22892);
                    return return_v;
                }


                System.Management.Automation.FlagsExpression<T>.Node
                f_1269_22929_22946(System.Collections.Generic.Queue<System.Management.Automation.FlagsExpression<T>.Node>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 22929, 22946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1269, 20802, 23043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 20802, 23043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FlagsExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1269, 547, 23072);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1269, 547, 23072);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1269, 547, 23072);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1269, 547, 23072);

        bool
        f_1269_964_981_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 964, 981);
            return return_v;
        }


        string
        f_1269_1149_1198()
        {
            var return_v = EnumExpressionEvaluatorStrings.InvalidGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 1149, 1198);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1269_1021_1199(string
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1021, 1199);
            return return_v;
        }


        System.Type
        f_1269_1244_1277(System.Type
        enumType)
        {
            var return_v = Enum.GetUnderlyingType(enumType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1244, 1277);
            return return_v;
        }


        bool
        f_1269_1298_1335(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1298, 1335);
            return return_v;
        }


        string
        f_1269_1501_1548()
        {
            var return_v = EnumExpressionEvaluatorStrings.EmptyInputString;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 1501, 1548);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1269_1375_1549(string
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1375, 1549);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        f_1269_1605_1630(System.Management.Automation.FlagsExpression<T>
        this_param, string
        input)
        {
            var return_v = this_param.TokenizeInput(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1605, 1630);
            return return_v;
        }


        System.Management.Automation.FlagsExpression<T>.Token
        f_1269_1728_1751(System.Management.Automation.FlagsExpression<T>.TokenKind
        kind)
        {
            var return_v = new System.Management.Automation.FlagsExpression<T>.Token(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1728, 1751);
            return return_v;
        }


        int
        f_1269_1714_1752(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        this_param, System.Management.Automation.FlagsExpression<T>.Token
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1714, 1752);
            return 0;
        }


        int
        f_1269_1769_1796(System.Management.Automation.FlagsExpression<T>
        this_param, System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        tokenList)
        {
            this_param.CheckSyntaxError(tokenList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1769, 1796);
            return 0;
        }


        System.Management.Automation.FlagsExpression<T>.Node
        f_1269_1820_1854(System.Management.Automation.FlagsExpression<T>
        this_param, System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        tokenList)
        {
            var return_v = this_param.ConstructExpressionTree(tokenList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 1820, 1854);
            return return_v;
        }


        bool
        f_1269_2280_2297_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 2280, 2297);
            return return_v;
        }


        string
        f_1269_2465_2514()
        {
            var return_v = EnumExpressionEvaluatorStrings.InvalidGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 2465, 2514);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1269_2337_2515(object[]
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 2337, 2515);
            return return_v;
        }


        System.Type
        f_1269_2560_2593(System.Type
        enumType)
        {
            var return_v = Enum.GetUnderlyingType(enumType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 2560, 2593);
            return return_v;
        }


        string
        f_1269_2797_2844()
        {
            var return_v = EnumExpressionEvaluatorStrings.EmptyInputString;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 2797, 2844);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1269_2672_2845(object
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 2672, 2845);
            return return_v;
        }


        bool
        f_1269_2956_2994(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 2956, 2994);
            return return_v;
        }


        string
        f_1269_3172_3219()
        {
            var return_v = EnumExpressionEvaluatorStrings.EmptyInputString;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 3172, 3219);
            return return_v;
        }


        System.Management.Automation.RuntimeException
        f_1269_3042_3220(object[]
        targetObject, System.Type
        exceptionType, System.Management.Automation.Language.IScriptExtent
        errorPosition, string
        resourceIdAndErrorId, string
        resourceString, params object[]
        args)
        {
            var return_v = InterpreterError.NewInterpreterException((object)targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3042, 3220);
            return return_v;
        }


        object[]
        f_1269_2908_2918_I(object[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 2908, 2918);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        f_1269_3295_3312()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3295, 3312);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        f_1269_3420_3443(System.Management.Automation.FlagsExpression<T>
        this_param, string
        input)
        {
            var return_v = this_param.TokenizeInput(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3420, 3443);
            return return_v;
        }


        int
        f_1269_3401_3444(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        this_param, System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        collection)
        {
            this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.FlagsExpression<T>.Token>)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3401, 3444);
            return 0;
        }


        System.Management.Automation.FlagsExpression<T>.Token
        f_1269_3477_3500(System.Management.Automation.FlagsExpression<T>.TokenKind
        kind)
        {
            var return_v = new System.Management.Automation.FlagsExpression<T>.Token(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3477, 3500);
            return return_v;
        }


        int
        f_1269_3463_3501(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        this_param, System.Management.Automation.FlagsExpression<T>.Token
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3463, 3501);
            return 0;
        }


        object[]
        f_1269_3357_3367_I(object[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3357, 3367);
            return return_v;
        }


        int
        f_1269_3622_3637(System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1269, 3622, 3637);
            return return_v;
        }


        int
        f_1269_3609_3685(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3609, 3685);
            return 0;
        }


        int
        f_1269_3702_3729(System.Management.Automation.FlagsExpression<T>
        this_param, System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        tokenList)
        {
            this_param.CheckSyntaxError(tokenList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3702, 3729);
            return 0;
        }


        System.Management.Automation.FlagsExpression<T>.Node
        f_1269_3753_3787(System.Management.Automation.FlagsExpression<T>
        this_param, System.Collections.Generic.List<System.Management.Automation.FlagsExpression<T>.Token>
        tokenList)
        {
            var return_v = this_param.ConstructExpressionTree(tokenList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1269, 3753, 3787);
            return return_v;
        }

    }
}
