// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation;
using System.Text;

// TODO/FIXME: move this to Microsoft.PowerShell.Cim namespace (and move in source depot folder as well)

namespace Microsoft.PowerShell.Cmdletization.Cim
{
    internal class WildcardPatternToCimQueryParser : WildcardPatternParser
    {
        private readonly StringBuilder _result;

        private bool _needClientSideFiltering;

        protected override void AppendLiteralCharacter(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 1057, 1599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1136, 1588);

                switch (c)
                {

                    case '%':
                    case '_':
                    case '[': // no need to escape ']' character
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 1136, 1588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1299, 1329);

                        f_1069_1299_1328(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1351, 1401);

                        f_1069_1351_1400(this, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1423, 1451);

                        f_1069_1423_1450(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1069, 1473, 1479);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 1136, 1588);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 1136, 1588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1527, 1545);

                        f_1069_1527_1544(_result, c);
                        DynAbs.Tracing.TraceSender.TraceBreak(1069, 1567, 1573);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 1136, 1588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 1057, 1599);

                int
                f_1069_1299_1328(Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                this_param)
                {
                    this_param.BeginBracketExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1299, 1328);
                    return 0;
                }


                int
                f_1069_1351_1400(Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                this_param, char
                c)
                {
                    this_param.AppendLiteralCharacterToBracketExpression(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1351, 1400);
                    return 0;
                }


                int
                f_1069_1423_1450(Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                this_param)
                {
                    this_param.EndBracketExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1423, 1450);
                    return 0;
                }


                System.Text.StringBuilder
                f_1069_1527_1544(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1527, 1544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 1057, 1599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 1057, 1599);
            }
        }

        protected override void AppendAsterix()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 1611, 1706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1675, 1695);

                f_1069_1675_1694(_result, '%');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 1611, 1706);

                System.Text.StringBuilder
                f_1069_1675_1694(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1675, 1694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 1611, 1706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 1611, 1706);
            }
        }

        protected override void AppendQuestionMark()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 1718, 1818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1787, 1807);

                f_1069_1787_1806(_result, '_');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 1718, 1818);

                System.Text.StringBuilder
                f_1069_1787_1806(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1787, 1806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 1718, 1818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 1718, 1818);
            }
        }

        protected override void BeginBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 1830, 1934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1903, 1923);

                f_1069_1903_1922(_result, '[');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 1830, 1934);

                System.Text.StringBuilder
                f_1069_1903_1922(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 1903, 1922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 1830, 1934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 1830, 1934);
            }
        }

        protected override void AppendLiteralCharacterToBracketExpression(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 1946, 2399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2044, 2388);

                switch (c)
                {

                    case '^':
                    case ']':
                    case '-':
                    case '\\':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 2044, 2388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2200, 2251);

                        f_1069_2200_2250(this, c, c);
                        DynAbs.Tracing.TraceSender.TraceBreak(1069, 2273, 2279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 2044, 2388);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 2044, 2388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2327, 2345);

                        f_1069_2327_2344(_result, c);
                        DynAbs.Tracing.TraceSender.TraceBreak(1069, 2367, 2373);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 2044, 2388);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 1946, 2399);

                int
                f_1069_2200_2250(Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                this_param, char
                startOfCharacterRange, char
                endOfCharacterRange)
                {
                    this_param.AppendCharacterRangeToBracketExpression(startOfCharacterRange, endOfCharacterRange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 2200, 2250);
                    return 0;
                }


                System.Text.StringBuilder
                f_1069_2327_2344(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 2327, 2344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 1946, 2399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 1946, 2399);
            }
        }

        protected override void AppendCharacterRangeToBracketExpression(char startOfCharacterRange, char endOfCharacterRange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 2411, 3669);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2691, 2889) || true) && ((91 <= startOfCharacterRange) && (DynAbs.Tracing.TraceSender.Expression_True(1069, 2695, 2757) && (startOfCharacterRange <= 94)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 2691, 2889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2791, 2824);

                    startOfCharacterRange = (char)90;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2842, 2874);

                    _needClientSideFiltering = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 2691, 2889);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 2905, 3097) || true) && ((91 <= endOfCharacterRange) && (DynAbs.Tracing.TraceSender.Expression_True(1069, 2909, 2967) && (endOfCharacterRange <= 94)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 2905, 3097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3001, 3032);

                    endOfCharacterRange = (char)95;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3050, 3082);

                    _needClientSideFiltering = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 2905, 3097);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3182, 3345) || true) && (startOfCharacterRange == 45)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 3182, 3345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3247, 3280);

                    startOfCharacterRange = (char)44;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3298, 3330);

                    _needClientSideFiltering = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 3182, 3345);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3361, 3520) || true) && (endOfCharacterRange == 45)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1069, 3361, 3520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3424, 3455);

                    endOfCharacterRange = (char)46;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3473, 3505);

                    _needClientSideFiltering = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1069, 3361, 3520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3536, 3574);

                f_1069_3536_3573(
                            _result, startOfCharacterRange);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3588, 3608);

                f_1069_3588_3607(_result, '-');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3622, 3658);

                f_1069_3622_3657(_result, endOfCharacterRange);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 2411, 3669);

                System.Text.StringBuilder
                f_1069_3536_3573(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 3536, 3573);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1069_3588_3607(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 3588, 3607);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1069_3622_3657(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 3622, 3657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 2411, 3669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 2411, 3669);
            }
        }

        protected override void EndBracketExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1069, 3681, 3783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 3752, 3772);

                f_1069_3752_3771(_result, ']');
                DynAbs.Tracing.TraceSender.TraceExitMethod(1069, 3681, 3783);

                System.Text.StringBuilder
                f_1069_3752_3771(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 3752, 3771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 3681, 3783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 3681, 3783);
            }
        }

        internal static string Parse(WildcardPattern wildcardPattern, out bool needsClientSideFiltering)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1069, 4100, 4470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 4221, 4272);

                var
                parser = f_1069_4234_4271()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 4286, 4339);

                f_1069_4286_4338(wildcardPattern, parser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 4353, 4412);

                needsClientSideFiltering = parser._needClientSideFiltering;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 4426, 4459);

                return f_1069_4433_4458(parser._result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1069, 4100, 4470);

                Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                f_1069_4234_4271()
                {
                    var return_v = new Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 4234, 4271);
                    return return_v;
                }


                int
                f_1069_4286_4338(System.Management.Automation.WildcardPattern
                pattern, Microsoft.PowerShell.Cmdletization.Cim.WildcardPatternToCimQueryParser
                parser)
                {
                    WildcardPatternParser.Parse(pattern, (System.Management.Automation.WildcardPatternParser)parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 4286, 4338);
                    return 0;
                }


                string
                f_1069_4433_4458(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 4433, 4458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1069, 4100, 4470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 4100, 4470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WildcardPatternToCimQueryParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1069, 849, 4477);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 967, 996);
            this._result = f_1069_977_996();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1069, 1020, 1044);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1069, 849, 4477);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 849, 4477);
        }


        static WildcardPatternToCimQueryParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1069, 849, 4477);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1069, 849, 4477);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1069, 849, 4477);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1069, 849, 4477);

        System.Text.StringBuilder
        f_1069_977_996()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1069, 977, 996);
            return return_v;
        }

    }
}
