// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;

namespace System.Management.Automation.Language
{

    /// <summary>
    /// The types for AstParameterArgumentPair.
    /// </summary>
    internal enum AstParameterArgumentType
    {
        AstPair = 0,
        Switch = 1,
        Fake = 2,
        AstArray = 3,
        PipeObject = 4
    }
    internal abstract class AstParameterArgumentPair
    {
        public CommandParameterAst Parameter { get; protected set; }

        public AstParameterArgumentType ParameterArgumentType { get; protected set; }

        public bool ParameterSpecified { get; protected set; }

        public bool ArgumentSpecified { get; protected set; }

        public string ParameterName { get; protected set; }

        public string ParameterText { get; protected set; }

        public Type ArgumentType { get; protected set; }

        public AstParameterArgumentPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 798, 1951);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 942, 1002);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1093, 1170);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1282, 1345);
            this.ParameterSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1457, 1519);
            this.ArgumentSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1611, 1662);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1754, 1805);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 1896, 1944);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 798, 1951);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 798, 1951);
        }


        static AstParameterArgumentPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 798, 1951);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 798, 1951);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 798, 1951);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 798, 1951);
    }
    internal sealed class PipeObjectPair : AstParameterArgumentPair
    {
        internal PipeObjectPair(string parameterName, Type pipeObjType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 2165, 2685);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2253, 2359) || true) && (parameterName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 2253, 2359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2297, 2359);

                    throw f_1446_2303_2358("parameterName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 2253, 2359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2375, 2392);

                Parameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2406, 2466);

                ParameterArgumentType = AstParameterArgumentType.PipeObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2480, 2506);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2520, 2545);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2559, 2589);

                ParameterName = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2603, 2633);

                ParameterText = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 2647, 2674);

                ArgumentType = pipeObjType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 2165, 2685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 2165, 2685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 2165, 2685);
            }
        }

        static PipeObjectPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 2085, 2692);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 2085, 2692);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 2085, 2692);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 2085, 2692);

        System.Management.Automation.PSArgumentNullException
        f_1446_2303_2358(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 2303, 2358);
            return return_v;
        }

    }
    internal sealed class AstArrayPair : AstParameterArgumentPair
    {
        internal AstArrayPair(string parameterName, ICollection<ExpressionAst> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 2936, 3657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3747, 3795);
                this.Argument = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3042, 3148) || true) && (parameterName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 3042, 3148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3086, 3148);

                    throw f_1446_3092_3147("parameterName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 3042, 3148);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3162, 3284) || true) && (arguments == null || (DynAbs.Tracing.TraceSender.Expression_False(1446, 3166, 3207) || f_1446_3187_3202(arguments) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 3162, 3284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3226, 3284);

                    throw f_1446_3232_3283("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 3162, 3284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3300, 3317);

                Parameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3331, 3389);

                ParameterArgumentType = AstParameterArgumentType.AstArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3403, 3429);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3443, 3468);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3482, 3512);

                ParameterName = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3526, 3556);

                ParameterText = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3570, 3599);

                ArgumentType = typeof(Array);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 3615, 3646);

                Argument = f_1446_3626_3645(arguments);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 2936, 3657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 2936, 3657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 2936, 3657);
            }
        }

        public ExpressionAst[] Argument { get; }

        static AstArrayPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 2858, 3802);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 2858, 3802);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 2858, 3802);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 2858, 3802);

        System.Management.Automation.PSArgumentNullException
        f_1446_3092_3147(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 3092, 3147);
            return return_v;
        }


        int
        f_1446_3187_3202(System.Collections.Generic.ICollection<System.Management.Automation.Language.ExpressionAst>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 3187, 3202);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1446_3232_3283(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 3232, 3283);
            return return_v;
        }


        System.Management.Automation.Language.ExpressionAst[]
        f_1446_3626_3645(System.Collections.Generic.ICollection<System.Management.Automation.Language.ExpressionAst>
        source)
        {
            var return_v = source.ToArray<System.Management.Automation.Language.ExpressionAst>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 3626, 3645);
            return return_v;
        }

    }
    internal sealed class FakePair : AstParameterArgumentPair
    {
        internal FakePair(CommandParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 4000, 4537);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4076, 4180) || true) && (parameterAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 4076, 4180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4119, 4180);

                    throw f_1446_4125_4179("parameterAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 4076, 4180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4196, 4221);

                Parameter = parameterAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4235, 4289);

                ParameterArgumentType = AstParameterArgumentType.Fake;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4303, 4329);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4343, 4368);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4382, 4425);

                ParameterName = f_1446_4398_4424(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4439, 4482);

                ParameterText = f_1446_4455_4481(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4496, 4526);

                ArgumentType = typeof(object);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 4000, 4537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 4000, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 4000, 4537);
            }
        }

        static FakePair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 3926, 4544);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 3926, 4544);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 3926, 4544);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 3926, 4544);

        System.Management.Automation.PSArgumentNullException
        f_1446_4125_4179(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 4125, 4179);
            return return_v;
        }


        string
        f_1446_4398_4424(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 4398, 4424);
            return return_v;
        }


        string
        f_1446_4455_4481(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 4455, 4481);
            return return_v;
        }

    }
    internal sealed class SwitchPair : AstParameterArgumentPair
    {
        internal SwitchPair(CommandParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 4750, 5289);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4828, 4932) || true) && (parameterAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 4828, 4932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4871, 4932);

                    throw f_1446_4877_4931("parameterAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 4828, 4932);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4948, 4973);

                Parameter = parameterAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 4987, 5043);

                ParameterArgumentType = AstParameterArgumentType.Switch;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5057, 5083);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5097, 5122);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5136, 5179);

                ParameterName = f_1446_5152_5178(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5193, 5236);

                ParameterText = f_1446_5209_5235(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5250, 5278);

                ArgumentType = typeof(bool);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 4750, 5289);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 4750, 5289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 4750, 5289);
            }
        }

        public bool Argument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 5424, 5444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5430, 5442);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 5424, 5444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 5379, 5455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 5379, 5455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SwitchPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 4674, 5462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 4674, 5462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 4674, 5462);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 4674, 5462);

        System.Management.Automation.PSArgumentNullException
        f_1446_4877_4931(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 4877, 4931);
            return return_v;
        }


        string
        f_1446_5152_5178(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 5152, 5178);
            return return_v;
        }


        string
        f_1446_5209_5235(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 5209, 5235);
            return return_v;
        }

    }
    internal sealed class AstPair : AstParameterArgumentPair
    {
        internal AstPair(CommandParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 5866, 6547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8540, 8595);
                this.ParameterContainsArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8724, 8783);
                this.ArgumentIsCommandParameterAst = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8873, 8923);
                this.Argument = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 5941, 6074) || true) && (parameterAst == null || (DynAbs.Tracing.TraceSender.Expression_False(1446, 5945, 5998) || f_1446_5969_5990(parameterAst) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 5941, 6074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6017, 6074);

                    throw f_1446_6023_6073("parameterAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 5941, 6074);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6090, 6115);

                Parameter = parameterAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6129, 6186);

                ParameterArgumentType = AstParameterArgumentType.AstPair;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6200, 6226);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6240, 6265);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6279, 6322);

                ParameterName = f_1446_6295_6321(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6336, 6378);

                ParameterText = "-" + f_1446_6358_6371() + ":";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6392, 6440);

                ArgumentType = f_1446_6407_6439(f_1446_6407_6428(parameterAst));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6456, 6489);

                ParameterContainsArgument = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6503, 6536);

                Argument = f_1446_6514_6535(parameterAst);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 5866, 6547);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 5866, 6547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 5866, 6547);
            }
        }

        internal AstPair(CommandParameterAst parameterAst, ExpressionAst argumentAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 6559, 7511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8540, 8595);
                this.ParameterContainsArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8724, 8783);
                this.ArgumentIsCommandParameterAst = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8873, 8923);
                this.Argument = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6661, 6794) || true) && (parameterAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 6665, 6718) && f_1446_6689_6710(parameterAst) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 6661, 6794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6737, 6794);

                    throw f_1446_6743_6793("parameterAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 6661, 6794);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6810, 6936) || true) && (parameterAst == null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 6814, 6857) && argumentAst == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 6810, 6936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6876, 6936);

                    throw f_1446_6882_6935("argumentAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 6810, 6936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6952, 6977);

                Parameter = parameterAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 6991, 7048);

                ParameterArgumentType = AstParameterArgumentType.AstPair;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7062, 7104);

                ParameterSpecified = parameterAst != null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7118, 7158);

                ArgumentSpecified = argumentAst != null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7172, 7245);

                ParameterName = (DynAbs.Tracing.TraceSender.Conditional_F1(1446, 7188, 7208) || ((parameterAst != null && DynAbs.Tracing.TraceSender.Conditional_F2(1446, 7211, 7237)) || DynAbs.Tracing.TraceSender.Conditional_F3(1446, 7240, 7244))) ? f_1446_7211_7237(parameterAst) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7259, 7332);

                ParameterText = (DynAbs.Tracing.TraceSender.Conditional_F1(1446, 7275, 7295) || ((parameterAst != null && DynAbs.Tracing.TraceSender.Conditional_F2(1446, 7298, 7324)) || DynAbs.Tracing.TraceSender.Conditional_F3(1446, 7327, 7331))) ? f_1446_7298_7324(parameterAst) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7346, 7413);

                ArgumentType = (DynAbs.Tracing.TraceSender.Conditional_F1(1446, 7361, 7380) || ((argumentAst != null && DynAbs.Tracing.TraceSender.Conditional_F2(1446, 7383, 7405)) || DynAbs.Tracing.TraceSender.Conditional_F3(1446, 7408, 7412))) ? f_1446_7383_7405(argumentAst) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7429, 7463);

                ParameterContainsArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7477, 7500);

                Argument = argumentAst;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 6559, 7511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 6559, 7511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 6559, 7511);
            }
        }

        internal AstPair(CommandParameterAst parameterAst, CommandElementAst argumentAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 7523, 8402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8540, 8595);
                this.ParameterContainsArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8724, 8783);
                this.ArgumentIsCommandParameterAst = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8873, 8923);
                this.Argument = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7629, 7762) || true) && (parameterAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 7633, 7686) && f_1446_7657_7678(parameterAst) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 7629, 7762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7705, 7762);

                    throw f_1446_7711_7761("parameterAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 7629, 7762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7778, 7904) || true) && (parameterAst == null || (DynAbs.Tracing.TraceSender.Expression_False(1446, 7782, 7825) || argumentAst == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 7778, 7904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7844, 7904);

                    throw f_1446_7850_7903("argumentAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 7778, 7904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7920, 7945);

                Parameter = parameterAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 7959, 8016);

                ParameterArgumentType = AstParameterArgumentType.AstPair;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8030, 8056);

                ParameterSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8070, 8095);

                ArgumentSpecified = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8109, 8152);

                ParameterName = f_1446_8125_8151(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8166, 8209);

                ParameterText = f_1446_8182_8208(parameterAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8223, 8253);

                ArgumentType = typeof(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8269, 8303);

                ParameterContainsArgument = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8317, 8340);

                Argument = argumentAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 8354, 8391);

                ArgumentIsCommandParameterAst = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 7523, 8402);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 7523, 8402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 7523, 8402);
            }
        }

        public bool ParameterContainsArgument { get; }

        public bool ArgumentIsCommandParameterAst { get; }

        public CommandElementAst Argument { get; }

        static AstPair()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 5793, 8930);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 5793, 8930);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 5793, 8930);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 5793, 8930);

        System.Management.Automation.Language.ExpressionAst
        f_1446_5969_5990(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 5969, 5990);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1446_6023_6073(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 6023, 6073);
            return return_v;
        }


        string
        f_1446_6295_6321(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6295, 6321);
            return return_v;
        }


        string
        f_1446_6358_6371()
        {
            var return_v = ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6358, 6371);
            return return_v;
        }


        System.Management.Automation.Language.ExpressionAst
        f_1446_6407_6428(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6407, 6428);
            return return_v;
        }


        System.Type
        f_1446_6407_6439(System.Management.Automation.Language.ExpressionAst
        this_param)
        {
            var return_v = this_param.StaticType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6407, 6439);
            return return_v;
        }


        System.Management.Automation.Language.ExpressionAst
        f_1446_6514_6535(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6514, 6535);
            return return_v;
        }


        System.Management.Automation.Language.ExpressionAst
        f_1446_6689_6710(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 6689, 6710);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1446_6743_6793(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 6743, 6793);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1446_6882_6935(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 6882, 6935);
            return return_v;
        }


        string
        f_1446_7211_7237(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 7211, 7237);
            return return_v;
        }


        string
        f_1446_7298_7324(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 7298, 7324);
            return return_v;
        }


        System.Type
        f_1446_7383_7405(System.Management.Automation.Language.ExpressionAst
        this_param)
        {
            var return_v = this_param.StaticType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 7383, 7405);
            return return_v;
        }


        System.Management.Automation.Language.ExpressionAst
        f_1446_7657_7678(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.Argument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 7657, 7678);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1446_7711_7761(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 7711, 7761);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1446_7850_7903(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 7850, 7903);
            return return_v;
        }


        string
        f_1446_8125_8151(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 8125, 8151);
            return return_v;
        }


        string
        f_1446_8182_8208(System.Management.Automation.Language.CommandParameterAst
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 8182, 8208);
            return return_v;
        }

    }
    public static class StaticParameterBinder
    {
        public static StaticBindingResult BindCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 9522, 9700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 9615, 9635);

                bool
                resolve = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 9649, 9689);

                return f_1446_9656_9688(commandAst, resolve);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 9522, 9700);

                System.Management.Automation.Language.StaticBindingResult
                f_1446_9656_9688(System.Management.Automation.Language.CommandAst
                commandAst, bool
                resolve)
                {
                    var return_v = BindCommand(commandAst, resolve);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 9656, 9688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 9522, 9700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 9522, 9700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StaticBindingResult BindCommand(CommandAst commandAst, bool resolve)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 10188, 10352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 10295, 10341);

                return f_1446_10302_10340(commandAst, resolve, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 10188, 10352);

                System.Management.Automation.Language.StaticBindingResult
                f_1446_10302_10340(System.Management.Automation.Language.CommandAst
                commandAst, bool
                resolve, string[]
                desiredParameters)
                {
                    var return_v = BindCommand(commandAst, resolve, desiredParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 10302, 10340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 10188, 10352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 10188, 10352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StaticBindingResult BindCommand(CommandAst commandAst, bool resolve, string[] desiredParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 11060, 14220);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11291, 12413) || true) && ((desiredParameters != null) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 11295, 11356) && (f_1446_11327_11351(desiredParameters) > 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 11291, 12413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11390, 11431);

                    bool
                    possiblyHadDesiredParameter = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11449, 12201);
                        foreach (CommandParameterAst commandParameter in f_1446_11498_11554_I(f_1446_11498_11554(f_1446_11498_11524(commandAst))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 11449, 12201);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11596, 11656);

                            string
                            actualParameterName = f_1446_11625_11655(commandParameter)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11680, 12048);
                                foreach (string actualParameter in f_1446_11715_11732_I(desiredParameters))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 11680, 12048);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11782, 12025) || true) && (f_1446_11786_11869(actualParameter, actualParameterName, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 11782, 12025);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 11927, 11962);

                                        possiblyHadDesiredParameter = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1446, 11992, 11998);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 11782, 12025);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 11680, 12048);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 369);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 369);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12072, 12182) || true) && (possiblyHadDesiredParameter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12072, 12182);
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 12153, 12159);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12072, 12182);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 11449, 12201);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 753);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 753);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12293, 12398) || true) && (!possiblyHadDesiredParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12293, 12398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12367, 12379);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12293, 12398);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 11291, 12413);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12429, 12539) || true) && (!resolve)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12429, 12539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12475, 12524);

                    return f_1446_12482_12523(commandAst, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12429, 12539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12555, 12594);

                PseudoBindingInfo
                pseudoBinding = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12608, 14135) || true) && (f_1446_12612_12636() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12608, 14135);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 12934, 13421) || true) && (s_bindCommandRunspace == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12934, 13421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13088, 13160);

                        InitialSessionState
                        minimalState = f_1446_13123_13159()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13182, 13209);

                        f_1446_13182_13208(f_1446_13182_13200(minimalState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13231, 13260);

                        f_1446_13231_13259(f_1446_13231_13251(minimalState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13282, 13351);

                        s_bindCommandRunspace = f_1446_13306_13350(minimalState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13373, 13402);

                        f_1446_13373_13401(s_bindCommandRunspace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12934, 13421);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13441, 13490);

                    Runspace.DefaultRunspace = s_bindCommandRunspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13612, 13756);

                    pseudoBinding = f_1446_13628_13755(f_1446_13628_13655(), commandAst, null, null, PseudoParameterBinder.BindingType.ArgumentBinding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13774, 13806);

                    Runspace.DefaultRunspace = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12608, 14135);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 12608, 14135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 13976, 14120);

                    pseudoBinding = f_1446_13992_14119(f_1446_13992_14019(), commandAst, null, null, PseudoParameterBinder.BindingType.ArgumentBinding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 12608, 14135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14151, 14209);

                return f_1446_14158_14208(commandAst, pseudoBinding);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 11060, 14220);

                int
                f_1446_11327_11351(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 11327, 11351);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_11498_11524(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 11498, 11524);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandParameterAst>
                f_1446_11498_11554(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.CommandParameterAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 11498, 11554);
                    return return_v;
                }


                string
                f_1446_11625_11655(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 11625, 11655);
                    return return_v;
                }


                bool
                f_1446_11786_11869(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 11786, 11869);
                    return return_v;
                }


                string[]
                f_1446_11715_11732_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 11715, 11732);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandParameterAst>
                f_1446_11498_11554_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 11498, 11554);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingResult
                f_1446_12482_12523(System.Management.Automation.Language.CommandAst
                commandAst, System.Management.Automation.Language.PseudoBindingInfo
                bindingInfo)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingResult(commandAst, bindingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 12482, 12523);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1446_12612_12636()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 12612, 12636);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1446_13123_13159()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13123, 13159);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                f_1446_13182_13200(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 13182, 13200);
                    return return_v;
                }


                int
                f_1446_13182_13208(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13182, 13208);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
                f_1446_13231_13251(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Formats;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 13231, 13251);
                    return return_v;
                }


                int
                f_1446_13231_13259(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13231, 13259);
                    return 0;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1446_13306_13350(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13306, 13350);
                    return return_v;
                }


                int
                f_1446_13373_13401(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13373, 13401);
                    return 0;
                }


                System.Management.Automation.Language.PseudoParameterBinder
                f_1446_13628_13655()
                {
                    var return_v = new System.Management.Automation.Language.PseudoParameterBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13628, 13655);
                    return return_v;
                }


                System.Management.Automation.Language.PseudoBindingInfo
                f_1446_13628_13755(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.Language.CommandAst
                command, System.Type
                pipeArgumentType, System.Management.Automation.Language.CommandParameterAst
                paramAstAtCursor, System.Management.Automation.Language.PseudoParameterBinder.BindingType
                bindingType)
                {
                    var return_v = this_param.DoPseudoParameterBinding(command, pipeArgumentType, paramAstAtCursor, bindingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13628, 13755);
                    return return_v;
                }


                System.Management.Automation.Language.PseudoParameterBinder
                f_1446_13992_14019()
                {
                    var return_v = new System.Management.Automation.Language.PseudoParameterBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13992, 14019);
                    return return_v;
                }


                System.Management.Automation.Language.PseudoBindingInfo
                f_1446_13992_14119(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.Language.CommandAst
                command, System.Type
                pipeArgumentType, System.Management.Automation.Language.CommandParameterAst
                paramAstAtCursor, System.Management.Automation.Language.PseudoParameterBinder.BindingType
                bindingType)
                {
                    var return_v = this_param.DoPseudoParameterBinding(command, pipeArgumentType, paramAstAtCursor, bindingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 13992, 14119);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingResult
                f_1446_14158_14208(System.Management.Automation.Language.CommandAst
                commandAst, System.Management.Automation.Language.PseudoBindingInfo
                bindingInfo)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingResult(commandAst, bindingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 14158, 14208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 11060, 14220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 11060, 14220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [ThreadStatic]
        static Runspace s_bindCommandRunspace;

        static StaticParameterBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 9158, 14308);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14272, 14300);
            s_bindCommandRunspace = null;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 9158, 14308);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 9158, 14308);
        }

    }
    public class StaticBindingResult
    {
        internal StaticBindingResult(CommandAst commandAst, PseudoBindingInfo bindingInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 14481, 15073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25770, 25789);
                this._bindingInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29885, 29959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30018, 30090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14588, 14687);

                BoundParameters = f_1446_14606_14686(f_1446_14653_14685());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14701, 14798);

                BindingExceptions = f_1446_14721_14797(f_1446_14764_14796());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14814, 15062) || true) && (bindingInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 14814, 15062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14871, 14919);

                    f_1446_14871_14918(this, commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 14814, 15062);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 14814, 15062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 14985, 15047);

                    f_1446_14985_15046(this, commandAst, bindingInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 14814, 15062);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 14481, 15073);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 14481, 15073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 14481, 15073);
            }
        }

        private void CreateBindingResultForSuccessfulBind(CommandAst commandAst, PseudoBindingInfo bindingInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 15085, 24631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 15213, 15240);

                _bindingInfo = bindingInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 15461, 15545);

                bool
                parameterSetSpecified = f_1446_15490_15525(bindingInfo) != UInt32.MaxValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 15559, 15817);

                bool
                remainingParameterSetIncludesDefault =
                                (f_1446_15621_15656(bindingInfo) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 15620, 15816) && ((f_1446_15685_15720(bindingInfo) & f_1446_15723_15758(bindingInfo)) ==
                f_1446_15780_15815(bindingInfo)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 15951, 16179);

                bool
                onlyOneRemainingParameterSet =
                                (f_1446_16005_16040(bindingInfo) != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 16004, 16178) && (f_1446_16068_16103(bindingInfo) &
                                        (f_1446_16132_16167(bindingInfo) - 1)) == 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 16195, 16987) || true) && (parameterSetSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1446, 16199, 16280) && (!remainingParameterSetIncludesDefault)) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 16199, 16332) && (!onlyOneRemainingParameterSet)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 16195, 16987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 16366, 16795);

                    ParameterBindingException
                    bindingException =
                    f_1446_16432_16794(ErrorCategory.InvalidArgument, null, null, null, null, null, f_1446_16699_16743(), "AmbiguousParameterSet")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 16813, 16972);

                    f_1446_16813_16971(f_1446_16813_16830(), f_1446_16835_16876(f_1446_16835_16871(f_1446_16835_16864(f_1446_16835_16861(commandAst), 0))), f_1446_16899_16970(f_1446_16922_16951(f_1446_16922_16948(commandAst), 0), bindingException));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 16195, 16987);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17054, 17362) || true) && (f_1446_17058_17089(bindingInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 17054, 17362);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17131, 17347);
                        foreach (AstParameterArgumentPair duplicateParameter in f_1446_17187_17218_I(f_1446_17187_17218(bindingInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 17131, 17347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17260, 17328);

                            f_1446_17260_17327(this, f_1446_17298_17326(duplicateParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 17131, 17347);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 17054, 17362);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17429, 18320) || true) && (f_1446_17433_17463(bindingInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 17429, 18320);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17505, 18305);
                        foreach (CommandParameterAst parameterNotFound in f_1446_17555_17585_I(f_1446_17555_17585(bindingInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 17505, 18305);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 17627, 18148);

                            ParameterBindingException
                            bindingException =
                            f_1446_17697_18147(ErrorCategory.InvalidArgument, null, f_1446_17852_17883(parameterNotFound), f_1446_17914_17945(parameterNotFound), null, null, f_1446_18046_18091(), "NamedParameterNotFound")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18170, 18286);

                            f_1446_18170_18285(f_1446_18170_18187(), f_1446_18192_18223(parameterNotFound), f_1446_18225_18284(parameterNotFound, bindingException));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 17505, 18305);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 801);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 801);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 17429, 18320);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18387, 18857) || true) && (f_1446_18391_18422(bindingInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 18387, 18857);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18464, 18842);
                        foreach (CommandParameterAst ambiguousParameter in f_1446_18515_18546_I(f_1446_18515_18546(bindingInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 18464, 18842);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18588, 18683);

                            ParameterBindingException
                            bindingException = f_1446_18633_18682(f_1446_18633_18662(bindingInfo), ambiguousParameter)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18705, 18823);

                            f_1446_18705_18822(f_1446_18705_18722(), f_1446_18727_18759(ambiguousParameter), f_1446_18761_18821(ambiguousParameter, bindingException));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 18464, 18842);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 379);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 379);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 18387, 18857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 18933, 19892) || true) && (f_1446_18937_18965(bindingInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 18933, 19892);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 19007, 19877);
                        foreach (AstParameterArgumentPair unboundArgument in f_1446_19060_19088_I(f_1446_19060_19088(bindingInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 19007, 19877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 19130, 19176);

                            AstPair
                            argument = unboundArgument as AstPair
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 19200, 19722);

                            ParameterBindingException
                            bindingException =
                            f_1446_19270_19721(ErrorCategory.InvalidArgument, null, f_1446_19425_19449(f_1446_19425_19442(argument)), f_1446_19480_19509(f_1446_19480_19504(f_1446_19480_19497(argument))), null, null, f_1446_19610_19660(), "PositionalParameterNotFound")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 19744, 19858);

                            f_1446_19744_19857(f_1446_19744_19761(), f_1446_19766_19795(f_1446_19766_19790(f_1446_19766_19783(argument))), f_1446_19797_19856(f_1446_19820_19837(argument), bindingException));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 19007, 19877);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 871);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 871);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 18933, 19892);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 19953, 24620) || true) && (f_1446_19957_19984(bindingInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 19953, 24620);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20026, 24605);
                        foreach (KeyValuePair<string, MergedCompiledCommandParameter> item in f_1446_20096_20123_I(f_1446_20096_20123(bindingInfo)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 20026, 24605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20165, 20223);

                            CompiledCommandParameter
                            parameter = f_1446_20202_20222(item.Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20245, 20276);

                            CommandElementAst
                            value = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20298, 20326);

                            object
                            constantValue = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20400, 20474);

                            AstPair
                            argumentAstPair = f_1446_20426_20462(f_1446_20426_20452(bindingInfo), item.Key) as AstPair
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20496, 20629) || true) && (argumentAstPair != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 20496, 20629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20573, 20606);

                                value = f_1446_20581_20605(argumentAstPair);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 20496, 20629);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20833, 20922);

                            AstArrayPair
                            argumentAstArrayPair = f_1446_20869_20905(f_1446_20869_20895(bindingInfo), item.Key) as AstArrayPair
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 20944, 22208) || true) && (argumentAstArrayPair != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 20944, 22208);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21026, 21084);

                                List<ExpressionAst>
                                arguments = f_1446_21058_21083()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21110, 21881);
                                    foreach (ExpressionAst expression in f_1446_21147_21176_I(f_1446_21147_21176(argumentAstArrayPair)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 21110, 21881);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21234, 21298);

                                        ArrayLiteralAst
                                        expressionArray = expression as ArrayLiteralAst
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21328, 21854) || true) && (expressionArray != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 21328, 21854);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21421, 21645);
                                                foreach (ExpressionAst newExpression in f_1446_21461_21485_I(f_1446_21461_21485(expressionArray)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 21421, 21645);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21559, 21610);

                                                    f_1446_21559_21609(arguments, f_1446_21588_21608(newExpression));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 21421, 21645);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 225);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 225);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 21328, 21854);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 21328, 21854);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21775, 21823);

                                            f_1446_21775_21822(arguments, f_1446_21804_21821(expression));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 21328, 21854);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 21110, 21881);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 772);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 772);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 21989, 22036);

                                IScriptExtent
                                fakeExtent = f_1446_22016_22035(f_1446_22016_22028(arguments, 0))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22062, 22137);

                                ArrayLiteralAst
                                fakeArguments = f_1446_22094_22136(fakeExtent, arguments)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22163, 22185);

                                value = fakeArguments;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 20944, 22208);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22294, 22687) || true) && (f_1446_22298_22312(parameter) == typeof(SwitchParameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 22294, 22687);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22389, 22615) || true) && ((value != null) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 22393, 22521) && (f_1446_22442_22520("$false", f_1446_22466_22483(f_1446_22466_22478(value)), StringComparison.OrdinalIgnoreCase))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 22389, 22615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22579, 22588);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 22389, 22615);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22643, 22664);

                                constantValue = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 22294, 22687);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22766, 24586) || true) && ((value != null) || (DynAbs.Tracing.TraceSender.Expression_False(1446, 22770, 22812) || (constantValue != null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 22766, 24586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 22862, 22953);

                                f_1446_22862_22952(f_1446_22862_22877(), item.Key, f_1446_22892_22951(parameter, value, constantValue));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 22766, 24586);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 22766, 24586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23051, 23087);

                                bool
                                takesValueFromPipeline = false
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23113, 23527);
                                    foreach (ParameterSetSpecificMetadata parameterSet in f_1446_23167_23241_I(f_1446_23167_23241(parameter, f_1446_23205_23240(bindingInfo))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 23113, 23527);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23299, 23500) || true) && (f_1446_23303_23333(parameterSet))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 23299, 23500);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23399, 23429);

                                            takesValueFromPipeline = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1446, 23463, 23469);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 23299, 23500);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 23113, 23527);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 415);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 415);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23555, 24563) || true) && (!takesValueFromPipeline)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 23555, 24563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 23756, 24333);

                                    ParameterBindingException
                                    bindingException =
                                    f_1446_23834_24332(ErrorCategory.InvalidArgument, null, f_1446_24013_24049(f_1446_24013_24042(f_1446_24013_24039(commandAst), 0)), f_1446_24088_24102(parameter), f_1446_24141_24155(parameter), null, f_1446_24237_24275(), "MissingArgument")
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 24365, 24536);

                                    f_1446_24365_24535(f_1446_24365_24382(), f_1446_24387_24428(f_1446_24387_24423(f_1446_24387_24416(f_1446_24387_24413(commandAst), 0))), f_1446_24463_24534(f_1446_24486_24515(f_1446_24486_24512(commandAst), 0), bindingException));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 23555, 24563);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 22766, 24586);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 20026, 24605);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 4580);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 4580);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 19953, 24620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 15085, 24631);

                uint
                f_1446_15490_15525(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 15490, 15525);
                    return return_v;
                }


                uint
                f_1446_15621_15656(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 15621, 15656);
                    return return_v;
                }


                uint
                f_1446_15685_15720(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 15685, 15720);
                    return return_v;
                }


                uint
                f_1446_15723_15758(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 15723, 15758);
                    return return_v;
                }


                uint
                f_1446_15780_15815(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 15780, 15815);
                    return return_v;
                }


                uint
                f_1446_16005_16040(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16005, 16040);
                    return return_v;
                }


                uint
                f_1446_16068_16103(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16068, 16103);
                    return return_v;
                }


                uint
                f_1446_16132_16167(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16132, 16167);
                    return return_v;
                }


                string
                f_1446_16699_16743()
                {
                    var return_v = ParameterBinderStrings.AmbiguousParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16699, 16743);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_16432_16794(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 16432, 16794);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_16813_16830()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16813, 16830);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_16835_16861(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16835, 16861);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_16835_16864(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16835, 16864);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_16835_16871(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16835, 16871);
                    return return_v;
                }


                string
                f_1446_16835_16876(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16835, 16876);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_16922_16948(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16922, 16948);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_16922_16951(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 16922, 16951);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_16899_16970(System.Management.Automation.Language.CommandElementAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError(commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 16899, 16970);
                    return return_v;
                }


                int
                f_1446_16813_16971(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 16813, 16971);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_17058_17089(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.DuplicateParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17058, 17089);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_17187_17218(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.DuplicateParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17187, 17218);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_17298_17326(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17298, 17326);
                    return return_v;
                }


                int
                f_1446_17260_17327(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                duplicateParameter)
                {
                    this_param.AddDuplicateParameterBindingException(duplicateParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 17260, 17327);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_17187_17218_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 17187, 17218);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_17433_17463(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ParametersNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17433, 17463);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_17555_17585(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ParametersNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17555, 17585);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_17852_17883(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ErrorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17852, 17883);
                    return return_v;
                }


                string
                f_1446_17914_17945(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 17914, 17945);
                    return return_v;
                }


                string
                f_1446_18046_18091()
                {
                    var return_v = ParameterBinderStrings.NamedParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18046, 18091);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_17697_18147(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 17697, 18147);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_18170_18187()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18170, 18187);
                    return return_v;
                }


                string
                f_1446_18192_18223(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18192, 18223);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_18225_18284(System.Management.Automation.Language.CommandParameterAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError((System.Management.Automation.Language.CommandElementAst)commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 18225, 18284);
                    return return_v;
                }


                int
                f_1446_18170_18285(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 18170, 18285);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_17555_17585_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 17555, 17585);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_18391_18422(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.AmbiguousParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18391, 18422);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_18515_18546(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.AmbiguousParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18515, 18546);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>
                f_1446_18633_18662(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18633, 18662);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_18633_18682(System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>
                this_param, System.Management.Automation.Language.CommandParameterAst
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18633, 18682);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_18705_18722()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18705, 18722);
                    return return_v;
                }


                string
                f_1446_18727_18759(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18727, 18759);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_18761_18821(System.Management.Automation.Language.CommandParameterAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError((System.Management.Automation.Language.CommandElementAst)commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 18761, 18821);
                    return return_v;
                }


                int
                f_1446_18705_18822(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 18705, 18822);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_18515_18546_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 18515, 18546);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_18937_18965(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 18937, 18965);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_19060_19088(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19060, 19088);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_19425_19442(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19425, 19442);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_19425_19449(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19425, 19449);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_19480_19497(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19480, 19497);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_19480_19504(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19480, 19504);
                    return return_v;
                }


                string
                f_1446_19480_19509(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19480, 19509);
                    return return_v;
                }


                string
                f_1446_19610_19660()
                {
                    var return_v = ParameterBinderStrings.PositionalParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19610, 19660);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_19270_19721(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 19270, 19721);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_19744_19761()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19744, 19761);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_19766_19783(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19766, 19783);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_19766_19790(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19766, 19790);
                    return return_v;
                }


                string
                f_1446_19766_19795(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19766, 19795);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_19820_19837(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19820, 19837);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_19797_19856(System.Management.Automation.Language.CommandElementAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError(commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 19797, 19856);
                    return return_v;
                }


                int
                f_1446_19744_19857(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 19744, 19857);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_19060_19088_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 19060, 19088);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_19957_19984(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 19957, 19984);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_20096_20123(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20096, 20123);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_20202_20222(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20202, 20222);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_20426_20452(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20426, 20452);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_20426_20462(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20426, 20462);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_20581_20605(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20581, 20605);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_20869_20895(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20869, 20895);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_20869_20905(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 20869, 20905);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>
                f_1446_21058_21083()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21058, 21083);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst[]
                f_1446_21147_21176(System.Management.Automation.Language.AstArrayPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 21147, 21176);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1446_21461_21485(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 21461, 21485);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1446_21588_21608(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21588, 21608);
                    return return_v;
                }


                int
                f_1446_21559_21609(System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>
                this_param, System.Management.Automation.Language.Ast
                item)
                {
                    this_param.Add((System.Management.Automation.Language.ExpressionAst)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21559, 21609);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1446_21461_21485_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21461, 21485);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1446_21804_21821(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21804, 21821);
                    return return_v;
                }


                int
                f_1446_21775_21822(System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>
                this_param, System.Management.Automation.Language.Ast
                item)
                {
                    this_param.Add((System.Management.Automation.Language.ExpressionAst)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21775, 21822);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst[]
                f_1446_21147_21176_I(System.Management.Automation.Language.ExpressionAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 21147, 21176);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1446_22016_22028(System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22016, 22028);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_22016_22035(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22016, 22035);
                    return return_v;
                }


                System.Management.Automation.Language.ArrayLiteralAst
                f_1446_22094_22136(System.Management.Automation.Language.IScriptExtent
                extent, System.Collections.Generic.List<System.Management.Automation.Language.ExpressionAst>
                elements)
                {
                    var return_v = new System.Management.Automation.Language.ArrayLiteralAst(extent, (System.Collections.Generic.IList<System.Management.Automation.Language.ExpressionAst>)elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 22094, 22136);
                    return return_v;
                }


                System.Type
                f_1446_22298_22312(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22298, 22312);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_22466_22478(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22466, 22478);
                    return return_v;
                }


                string
                f_1446_22466_22483(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22466, 22483);
                    return return_v;
                }


                bool
                f_1446_22442_22520(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 22442, 22520);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                f_1446_22862_22877()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 22862, 22877);
                    return return_v;
                }


                System.Management.Automation.Language.ParameterBindingResult
                f_1446_22892_22951(System.Management.Automation.CompiledCommandParameter
                parameter, System.Management.Automation.Language.CommandElementAst
                value, object
                constantValue)
                {
                    var return_v = new System.Management.Automation.Language.ParameterBindingResult(parameter, value, constantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 22892, 22951);
                    return return_v;
                }


                int
                f_1446_22862_22952(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                this_param, string
                key, System.Management.Automation.Language.ParameterBindingResult
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 22862, 22952);
                    return 0;
                }


                uint
                f_1446_23205_23240(System.Management.Automation.Language.PseudoBindingInfo
                this_param)
                {
                    var return_v = this_param.ValidParameterSetsFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 23205, 23240);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_23167_23241(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 23167, 23241);
                    return return_v;
                }


                bool
                f_1446_23303_23333(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 23303, 23333);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_23167_23241_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 23167, 23241);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_24013_24039(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24013, 24039);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_24013_24042(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24013, 24042);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_24013_24049(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24013, 24049);
                    return return_v;
                }


                string
                f_1446_24088_24102(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24088, 24102);
                    return return_v;
                }


                System.Type
                f_1446_24141_24155(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24141, 24155);
                    return return_v;
                }


                string
                f_1446_24237_24275()
                {
                    var return_v = ParameterBinderStrings.MissingArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24237, 24275);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_23834_24332(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 23834, 24332);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_24365_24382()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24365, 24382);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_24387_24413(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24387, 24413);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_24387_24416(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24387, 24416);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_24387_24423(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24387, 24423);
                    return return_v;
                }


                string
                f_1446_24387_24428(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24387, 24428);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_24486_24512(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24486, 24512);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_24486_24515(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 24486, 24515);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_24463_24534(System.Management.Automation.Language.CommandElementAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError(commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 24463, 24534);
                    return return_v;
                }


                int
                f_1446_24365_24535(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 24365, 24535);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_20096_20123_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 20096, 20123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 15085, 24631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 15085, 24631);
            }
        }

        private void AddDuplicateParameterBindingException(CommandParameterAst duplicateParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 24643, 25732);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 24758, 24844) || true) && (duplicateParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 24758, 24844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 24822, 24829);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 24758, 24844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 24860, 25338);

                ParameterBindingException
                bindingException =
                f_1446_24922_25337(ErrorCategory.InvalidArgument, null, f_1446_25053_25085(duplicateParameter), f_1446_25108_25140(duplicateParameter), null, null, f_1446_25217_25261(), nameof(ParameterBinderStrings.ParameterAlreadyBound))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25486, 25721) || true) && (!f_1446_25491_25554(f_1446_25491_25508(), f_1446_25521_25553(duplicateParameter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 25486, 25721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25588, 25706);

                    f_1446_25588_25705(f_1446_25588_25605(), f_1446_25610_25642(duplicateParameter), f_1446_25644_25704(duplicateParameter, bindingException));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 25486, 25721);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 24643, 25732);

                System.Management.Automation.Language.IScriptExtent
                f_1446_25053_25085(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ErrorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25053, 25085);
                    return return_v;
                }


                string
                f_1446_25108_25140(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25108, 25140);
                    return return_v;
                }


                string
                f_1446_25217_25261()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25217, 25261);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1446_24922_25337(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 24922, 25337);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_25491_25508()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25491, 25508);
                    return return_v;
                }


                string
                f_1446_25521_25553(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25521, 25553);
                    return return_v;
                }


                bool
                f_1446_25491_25554(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 25491, 25554);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                f_1446_25588_25605()
                {
                    var return_v = BindingExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25588, 25605);
                    return return_v;
                }


                string
                f_1446_25610_25642(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 25610, 25642);
                    return return_v;
                }


                System.Management.Automation.Language.StaticBindingError
                f_1446_25644_25704(System.Management.Automation.Language.CommandParameterAst
                commandElement, System.Management.Automation.ParameterBindingException
                exception)
                {
                    var return_v = new System.Management.Automation.Language.StaticBindingError((System.Management.Automation.Language.CommandElementAst)commandElement, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 25644, 25704);
                    return return_v;
                }


                int
                f_1446_25588_25705(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
                this_param, string
                key, System.Management.Automation.Language.StaticBindingError
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 25588, 25705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 24643, 25732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 24643, 25732);
            }
        }

        private PseudoBindingInfo _bindingInfo;

        private void CreateBindingResultForSyntacticBind(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 25802, 28902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25898, 25924);

                bool
                foundCommand = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25940, 25984);

                CommandParameterAst
                currentParameter = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 25998, 26015);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26029, 26097);

                ParameterBindingResult
                bindingResult = f_1446_26068_26096()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26113, 28629);
                    foreach (CommandElementAst commandElement in f_1446_26158_26184_I(f_1446_26158_26184(commandAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 26113, 28629);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26260, 26389) || true) && (!foundCommand)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 26260, 26389);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26319, 26339);

                            foundCommand = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26361, 26370);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 26260, 26389);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26409, 26479);

                        CommandParameterAst
                        parameter = commandElement as CommandParameterAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26497, 28614) || true) && (parameter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 26497, 28614);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26560, 26858) || true) && (currentParameter != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 26560, 26858);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26689, 26746);

                                f_1446_26689_26745(this, f_1446_26699_26729(currentParameter), bindingResult);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26772, 26835);

                                f_1446_26772_26834(ref currentParameter, ref bindingResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 26560, 26858);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 26952, 26999);

                            string
                            parameterName = f_1446_26975_26998(parameter)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27021, 27053);

                            bindingResult.Value = parameter;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27168, 27759) || true) && (f_1446_27172_27190(parameter) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 27168, 27759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27248, 27289);

                                bindingResult.Value = f_1446_27270_27288(parameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27317, 27376);

                                f_1446_27317_27375(this, parameter, parameterName, bindingResult);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27402, 27465);

                                f_1446_27402_27464(ref currentParameter, ref bindingResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 27168, 27759);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 27168, 27759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27707, 27736);

                                currentParameter = parameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 27168, 27759);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 26497, 28614);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 26497, 28614);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 27929, 28508) || true) && (currentParameter != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 27929, 28508);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28007, 28044);

                                bindingResult.Value = commandElement;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28070, 28153);

                                f_1446_28070_28152(this, currentParameter, f_1446_28106_28136(currentParameter), bindingResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 27929, 28508);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 27929, 28508);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28297, 28334);

                                bindingResult.Value = commandElement;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28360, 28448);

                                f_1446_28360_28447(this, null, f_1446_28384_28431(position, f_1446_28402_28430()), bindingResult);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28474, 28485);

                                position++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 27929, 28508);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28532, 28595);

                            f_1446_28532_28594(ref currentParameter, ref bindingResult);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 26497, 28614);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 26113, 28629);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 2517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 2517);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28714, 28891) || true) && (currentParameter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 28714, 28891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 28819, 28876);

                    f_1446_28819_28875(this, f_1446_28829_28859(currentParameter), bindingResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 28714, 28891);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 25802, 28902);

                System.Management.Automation.Language.ParameterBindingResult
                f_1446_26068_26096()
                {
                    var return_v = new System.Management.Automation.Language.ParameterBindingResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 26068, 26096);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_26158_26184(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 26158, 26184);
                    return return_v;
                }


                string
                f_1446_26699_26729(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 26699, 26729);
                    return return_v;
                }


                int
                f_1446_26689_26745(System.Management.Automation.Language.StaticBindingResult
                this_param, string
                currentParameter, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddSwitch(currentParameter, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 26689, 26745);
                    return 0;
                }


                int
                f_1446_26772_26834(ref System.Management.Automation.Language.CommandParameterAst
                currentParameter, ref System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    ResetCurrentParameter(ref currentParameter, ref bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 26772, 26834);
                    return 0;
                }


                string
                f_1446_26975_26998(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 26975, 26998);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1446_27172_27190(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 27172, 27190);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1446_27270_27288(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 27270, 27288);
                    return return_v;
                }


                int
                f_1446_27317_27375(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                parameter, string
                parameterName, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddBoundParameter(parameter, parameterName, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 27317, 27375);
                    return 0;
                }


                int
                f_1446_27402_27464(ref System.Management.Automation.Language.CommandParameterAst
                currentParameter, ref System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    ResetCurrentParameter(ref currentParameter, ref bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 27402, 27464);
                    return 0;
                }


                string
                f_1446_28106_28136(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 28106, 28136);
                    return return_v;
                }


                int
                f_1446_28070_28152(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                parameter, string
                parameterName, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddBoundParameter(parameter, parameterName, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 28070, 28152);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1446_28402_28430()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 28402, 28430);
                    return return_v;
                }


                string
                f_1446_28384_28431(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 28384, 28431);
                    return return_v;
                }


                int
                f_1446_28360_28447(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                parameter, string
                parameterName, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddBoundParameter(parameter, parameterName, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 28360, 28447);
                    return 0;
                }


                int
                f_1446_28532_28594(ref System.Management.Automation.Language.CommandParameterAst
                currentParameter, ref System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    ResetCurrentParameter(ref currentParameter, ref bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 28532, 28594);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_26158_26184_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 26158, 26184);
                    return return_v;
                }


                string
                f_1446_28829_28859(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 28829, 28859);
                    return return_v;
                }


                int
                f_1446_28819_28875(System.Management.Automation.Language.StaticBindingResult
                this_param, string
                currentParameter, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddSwitch(currentParameter, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 28819, 28875);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 25802, 28902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 25802, 28902);
            }
        }

        private void AddBoundParameter(CommandParameterAst parameter, string parameterName, ParameterBindingResult bindingResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 28914, 29331);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29060, 29320) || true) && (f_1446_29064_29106(f_1446_29064_29079(), parameterName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 29060, 29320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29140, 29189);

                    f_1446_29140_29188(this, parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 29060, 29320);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 29060, 29320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29255, 29305);

                    f_1446_29255_29304(f_1446_29255_29270(), parameterName, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 29060, 29320);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 28914, 29331);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                f_1446_29064_29079()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 29064, 29079);
                    return return_v;
                }


                bool
                f_1446_29064_29106(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 29064, 29106);
                    return return_v;
                }


                int
                f_1446_29140_29188(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                duplicateParameter)
                {
                    this_param.AddDuplicateParameterBindingException(duplicateParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 29140, 29188);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                f_1446_29255_29270()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 29255, 29270);
                    return return_v;
                }


                int
                f_1446_29255_29304(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
                this_param, string
                key, System.Management.Automation.Language.ParameterBindingResult
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 29255, 29304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 28914, 29331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 28914, 29331);
            }
        }

        private static void ResetCurrentParameter(ref CommandParameterAst currentParameter, ref ParameterBindingResult bindingResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 29343, 29587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29493, 29517);

                currentParameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29531, 29576);

                bindingResult = f_1446_29547_29575();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 29343, 29587);

                System.Management.Automation.Language.ParameterBindingResult
                f_1446_29547_29575()
                {
                    var return_v = new System.Management.Automation.Language.ParameterBindingResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 29547, 29575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 29343, 29587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 29343, 29587);
            }
        }

        private void AddSwitch(string currentParameter, ParameterBindingResult bindingResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 29599, 29826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29709, 29744);

                bindingResult.ConstantValue = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 29758, 29815);

                f_1446_29758_29814(this, null, currentParameter, bindingResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 29599, 29826);

                int
                f_1446_29758_29814(System.Management.Automation.Language.StaticBindingResult
                this_param, System.Management.Automation.Language.CommandParameterAst
                parameter, string
                parameterName, System.Management.Automation.Language.ParameterBindingResult
                bindingResult)
                {
                    this_param.AddBoundParameter(parameter, parameterName, bindingResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 29758, 29814);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 29599, 29826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 29599, 29826);
            }
        }

        public Dictionary<string, ParameterBindingResult> BoundParameters { get; }

        public Dictionary<string, StaticBindingError> BindingExceptions { get; }

        static StaticBindingResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 14432, 30097);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 14432, 30097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 14432, 30097);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 14432, 30097);

        System.StringComparer
        f_1446_14653_14685()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 14653, 14685);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>
        f_1446_14606_14686(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.ParameterBindingResult>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 14606, 14686);
            return return_v;
        }


        System.StringComparer
        f_1446_14764_14796()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 14764, 14796);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>
        f_1446_14721_14797(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.StaticBindingError>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 14721, 14797);
            return return_v;
        }


        int
        f_1446_14871_14918(System.Management.Automation.Language.StaticBindingResult
        this_param, System.Management.Automation.Language.CommandAst
        commandAst)
        {
            this_param.CreateBindingResultForSyntacticBind(commandAst);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 14871, 14918);
            return 0;
        }


        int
        f_1446_14985_15046(System.Management.Automation.Language.StaticBindingResult
        this_param, System.Management.Automation.Language.CommandAst
        commandAst, System.Management.Automation.Language.PseudoBindingInfo
        bindingInfo)
        {
            this_param.CreateBindingResultForSuccessfulBind(commandAst, bindingInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 14985, 15046);
            return 0;
        }

    }
    public class ParameterBindingResult
    {
        internal ParameterBindingResult(CompiledCommandParameter parameter, CommandElementAst value, object constantValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 30260, 30542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30668, 30725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31081, 31095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31615, 31621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30399, 30449);

                this.Parameter = f_1446_30416_30448(parameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30463, 30482);

                this.Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30496, 30531);

                this.ConstantValue = constantValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 30260, 30542);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 30260, 30542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 30260, 30542);
            }
        }

        internal ParameterBindingResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 30554, 30609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30668, 30725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31081, 31095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31615, 31621);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 30554, 30609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 30554, 30609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 30554, 30609);
            }
        }

        public ParameterMetadata Parameter { get; internal set; }

        public object ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 30836, 30866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30842, 30864);

                    return _constantValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 30836, 30866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 30784, 31054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 30784, 31054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 30882, 31043);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30927, 31028) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 30927, 31028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 30986, 31009);

                        _constantValue = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 30927, 31028);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 30882, 31043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 30784, 31054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 30784, 31054);
                }
            }
        }

        private object _constantValue;

        public CommandElementAst Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 31210, 31232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31216, 31230);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 31210, 31232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 31155, 31577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 31155, 31577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 31248, 31566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31293, 31308);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31328, 31400);

                    ConstantExpressionAst
                    constantValueAst = value as ConstantExpressionAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31418, 31551) || true) && (constantValueAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 31418, 31551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 31488, 31532);

                        this.ConstantValue = f_1446_31509_31531(constantValueAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 31418, 31551);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 31248, 31566);

                    object
                    f_1446_31509_31531(System.Management.Automation.Language.ConstantExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 31509, 31531);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 31155, 31577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 31155, 31577);
                }
            }
        }

        private CommandElementAst _value;

        static ParameterBindingResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 30208, 31629);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 30208, 31629);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 30208, 31629);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 30208, 31629);

        System.Management.Automation.ParameterMetadata
        f_1446_30416_30448(System.Management.Automation.CompiledCommandParameter
        cmdParameterMD)
        {
            var return_v = new System.Management.Automation.ParameterMetadata(cmdParameterMD);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 30416, 30448);
            return return_v;
        }

    }
    public class StaticBindingError
    {
        internal StaticBindingError(CommandElementAst commandElement, ParameterBindingException exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 32090, 32309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 32432, 32493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 32629, 32700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 32213, 32250);

                this.CommandElement = commandElement;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 32264, 32298);

                this.BindingException = exception;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 32090, 32309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 32090, 32309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 32090, 32309);
            }
        }

        public CommandElementAst CommandElement { get; private set; }

        public ParameterBindingException BindingException { get; private set; }

        static StaticBindingError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 31761, 32707);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 31761, 32707);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 31761, 32707);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 31761, 32707);
    }


    internal enum PseudoBindingInfoType
    {
        PseudoBindingFail = 0,
        PseudoBindingSucceed = 1,
    }
    internal sealed class PseudoBindingInfo
    {
        internal PseudoBindingInfo(
                    CommandInfo commandInfo,
                    uint validParameterSetsFlags,
                    uint defaultParameterSetFlag,
                    Dictionary<string, MergedCompiledCommandParameter> boundParameters,
                    List<MergedCompiledCommandParameter> unboundParameters,
                    Dictionary<string, AstParameterArgumentPair> boundArguments,
                    Collection<string> boundPositionalParameter,
                    Collection<AstParameterArgumentPair> allParsedArguments,
                    Collection<CommandParameterAst> parametersNotFound,
                    Collection<CommandParameterAst> ambiguousParameters,
                    Dictionary<CommandParameterAst, ParameterBindingException> bindingExceptions,
                    Collection<AstParameterArgumentPair> duplicateParameters,
                    Collection<AstParameterArgumentPair> unboundArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 33735, 35391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36401, 36442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36454, 36502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36514, 36560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36572, 36618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36630, 36714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36726, 36798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36810, 36887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36899, 36970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36982, 37043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37055, 37128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37140, 37208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37220, 37289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37301, 37395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37407, 37481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34624, 34650);

                CommandInfo = commandInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34664, 34718);

                InfoType = PseudoBindingInfoType.PseudoBindingSucceed;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34732, 34782);

                ValidParameterSetsFlags = validParameterSetsFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34796, 34846);

                DefaultParameterSetFlag = defaultParameterSetFlag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34860, 34894);

                BoundParameters = boundParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34908, 34946);

                UnboundParameters = unboundParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 34960, 34992);

                BoundArguments = boundArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35006, 35058);

                BoundPositionalParameter = boundPositionalParameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35072, 35112);

                AllParsedArguments = allParsedArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35126, 35166);

                ParametersNotFound = parametersNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35180, 35222);

                AmbiguousParameters = ambiguousParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35236, 35274);

                BindingExceptions = bindingExceptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35288, 35330);

                DuplicateParameters = duplicateParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 35344, 35380);

                UnboundArguments = unboundArguments;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 33735, 35391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 33735, 35391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 33735, 35391);
            }
        }

        internal PseudoBindingInfo(
                    CommandInfo commandInfo,
                    uint defaultParameterSetFlag,
                    Collection<AstParameterArgumentPair> allParsedArguments,
                    List<MergedCompiledCommandParameter> unboundParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 35738, 36282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36401, 36442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36454, 36502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36514, 36560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36572, 36618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36630, 36714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36726, 36798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36810, 36887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36899, 36970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36982, 37043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37055, 37128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37140, 37208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37220, 37289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37301, 37395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 37407, 37481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36010, 36036);

                CommandInfo = commandInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36050, 36101);

                InfoType = PseudoBindingInfoType.PseudoBindingFail;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36115, 36165);

                DefaultParameterSetFlag = defaultParameterSetFlag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36179, 36219);

                AllParsedArguments = allParsedArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36233, 36271);

                UnboundParameters = unboundParameters;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 35738, 36282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 35738, 36282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 35738, 36282);
            }
        }

        internal string CommandName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 36346, 36378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 36352, 36376);

                    return f_1446_36359_36375(f_1446_36359_36370());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 36346, 36378);

                    System.Management.Automation.CommandInfo
                    f_1446_36359_36370()
                    {
                        var return_v = CommandInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 36359, 36370);
                        return return_v;
                    }


                    string
                    f_1446_36359_36375(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 36359, 36375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 36294, 36389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 36294, 36389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandInfo CommandInfo { get; }

        internal PseudoBindingInfoType InfoType { get; }

        internal uint ValidParameterSetsFlags { get; }

        internal uint DefaultParameterSetFlag { get; }

        internal Dictionary<string, MergedCompiledCommandParameter> BoundParameters { get; }

        internal List<MergedCompiledCommandParameter> UnboundParameters { get; }

        internal Dictionary<string, AstParameterArgumentPair> BoundArguments { get; }

        internal Collection<AstParameterArgumentPair> UnboundArguments { get; }

        internal Collection<string> BoundPositionalParameter { get; }

        internal Collection<AstParameterArgumentPair> AllParsedArguments { get; }

        internal Collection<CommandParameterAst> ParametersNotFound { get; }

        internal Collection<CommandParameterAst> AmbiguousParameters { get; }

        internal Dictionary<CommandParameterAst, ParameterBindingException> BindingExceptions { get; }

        internal Collection<AstParameterArgumentPair> DuplicateParameters { get; }

        static PseudoBindingInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 32874, 37488);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 32874, 37488);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 32874, 37488);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 32874, 37488);
    }
    internal class PseudoParameterBinder
    {        /*
        /// <summary>
        /// Get the parameter binding metadata.
        /// </summary>
        /// <param name="possibleParameterSets"></param>
        /// <returns></returns>
        public Dictionary<ParameterMetadata, ExpressionAst> GetPseudoParameterBinding(out Collection<ParameterSetMetadata> possibleParameterSets)
        {
            ExecutionContext contextFromTls =
                System.Management.Automation.Runspaces.LocalPipeline.GetExecutionContextFromTLS();
            return GetPseudoParameterBinding(out possibleParameterSets, contextFromTls, null);
        }
        */

        internal enum BindingType
        {
            /// <summary>
            /// Caller is binding a parameter argument.
            /// </summary>
            ArgumentBinding = 0,

            /// <summary>
            /// Caller is performing completion on a parameter argument.
            /// </summary>
            ArgumentCompletion,

            /// <summary>
            /// Caller is performing completion on a parameter name.
            /// </summary>
            ParameterCompletion
        }

        internal PseudoBindingInfo DoPseudoParameterBinding(CommandAst command, Type pipeArgumentType, CommandParameterAst paramAstAtCursor, BindingType bindingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 39282, 44657);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39464, 39588) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 39464, 39588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39517, 39573);

                    throw f_1446_39523_39572("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 39464, 39588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39657, 39677);

                f_1446_39657_39676(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39691, 39713);

                _commandAst = command;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39727, 39770);

                _commandElements = f_1446_39746_39769(command);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39784, 39883);

                Collection<AstParameterArgumentPair>
                unboundArguments = f_1446_39840_39882()
                ;

                // analyze the command and reparse the arguments
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 39980, 40059);

                    ExecutionContext
                    executionContext = f_1446_40016_40058()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40077, 41340) || true) && (executionContext != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 40077, 41340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40263, 40305);

                        f_1446_40263_40304(this, executionContext);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40329, 40373);

                        PSLanguageMode?
                        previousLanguageMode = null
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40575, 40873) || true) && (f_1446_40579_40638(executionContext))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 40575, 40873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40696, 40749);

                                previousLanguageMode = f_1446_40719_40748(executionContext);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40779, 40846);

                                executionContext.LanguageMode = PSLanguageMode.ConstrainedLanguage;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 40575, 40873);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 40901, 40962);

                            _bindingEffective = f_1446_40921_40961(this, executionContext);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1446, 41007, 41321);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41063, 41240) || true) && (f_1446_41067_41096(previousLanguageMode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 41063, 41240);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41154, 41213);

                                executionContext.LanguageMode = f_1446_41186_41212(previousLanguageMode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 41063, 41240);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41268, 41298);

                            f_1446_41268_41297(this, executionContext);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1446, 41007, 41321);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 40077, 41340);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41371, 41537) || true) && (_bindingEffective && (DynAbs.Tracing.TraceSender.Expression_True(1446, 41375, 41450) && (_isPipelineInputExpected || (DynAbs.Tracing.TraceSender.Expression_False(1446, 41397, 41449) || pipeArgumentType != null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 41371, 41537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41484, 41522);

                    _pipelineInputType = pipeArgumentType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 41371, 41537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41553, 41615);

                _bindingEffective = f_1446_41573_41614(this, paramAstAtCursor);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41631, 43431) || true) && (_bindingEffective)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 41631, 43431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41720, 41761);

                    unboundArguments = f_1446_41739_41760(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41779, 41829);

                    _bindingEffective = _currentParameterSetFlag != 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 41888, 42099);

                    unboundArguments = f_1446_41907_42098(this, unboundArguments, _currentParameterSetFlag, _defaultParameterSetFlag, bindingType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42220, 42403) || true) && (!_function)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 42220, 42403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42276, 42337);

                        unboundArguments = f_1446_42295_42336(this, unboundArguments);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42359, 42384);

                        f_1446_42359_42383(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 42220, 42403);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42626, 42757);

                    bool
                    parameterSetSpecified = (_currentParameterSetFlag != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 42655, 42756) && (_currentParameterSetFlag != UInt32.MaxValue))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42775, 42932);

                    bool
                    onlyOneRemainingParameterSet = (_currentParameterSetFlag != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 42811, 42931) && (_currentParameterSetFlag & (_currentParameterSetFlag - 1)) == 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 42950, 43416) || true) && ((bindingType != BindingType.ParameterCompletion) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 42954, 43027) && parameterSetSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 42954, 43062) && (!onlyOneRemainingParameterSet)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 42950, 43416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43104, 43397);

                        f_1446_43104_43396(_boundParameters, _unboundParameters, null, ref _currentParameterSetFlag, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 42950, 43416);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 41631, 43431);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43478, 44098) || true) && (!_bindingEffective)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 43478, 44098);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43623, 43689) || true) && (_bindableParameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 43623, 43689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43677, 43689);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 43623, 43689);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43757, 43784);

                    f_1446_43757_43783(
                                    // get all bindable parameters
                                    _unboundParameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43802, 43877);

                    f_1446_43802_43876(_unboundParameters, f_1446_43830_43875(f_1446_43830_43868(_bindableParameters)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 43897, 44083);

                    return f_1446_43904_44082(_commandInfo, _defaultParameterSetFlag, _arguments, _unboundParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 43478, 44098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 44114, 44646);

                return f_1446_44121_44645(_commandInfo, _currentParameterSetFlag, _defaultParameterSetFlag, _boundParameters, _unboundParameters, _boundArguments, _boundPositionalParameter, _arguments, _parametersNotFound, _ambiguousParameters, _bindingExceptions, _duplicateParameters, unboundArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 39282, 44657);

                System.Management.Automation.PSArgumentNullException
                f_1446_39523_39572(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 39523, 39572);
                    return return_v;
                }


                int
                f_1446_39657_39676(System.Management.Automation.Language.PseudoParameterBinder
                this_param)
                {
                    this_param.InitializeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 39657, 39676);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1446_39746_39769(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 39746, 39769);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_39840_39882()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 39840, 39882);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1446_40016_40058()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 40016, 40058);
                    return return_v;
                }


                int
                f_1446_40263_40304(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    this_param.SetTemporaryDefaultHost(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 40263, 40304);
                    return 0;
                }


                bool
                f_1446_40579_40638(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.HasRunspaceEverUsedConstrainedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 40579, 40638);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1446_40719_40748(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 40719, 40748);
                    return return_v;
                }


                bool
                f_1446_40921_40961(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = this_param.PrepareCommandElements(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 40921, 40961);
                    return return_v;
                }


                bool
                f_1446_41067_41096(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 41067, 41096);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1446_41186_41212(System.Management.Automation.PSLanguageMode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 41186, 41212);
                    return return_v;
                }


                int
                f_1446_41268_41297(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    this_param.RestoreHost(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 41268, 41297);
                    return 0;
                }


                bool
                f_1446_41573_41614(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.Language.CommandParameterAst
                paramAstAtCursor)
                {
                    var return_v = this_param.ParseParameterArguments(paramAstAtCursor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 41573, 41614);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_41739_41760(System.Management.Automation.Language.PseudoParameterBinder
                this_param)
                {
                    var return_v = this_param.BindNamedParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 41739, 41760);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_41907_42098(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                unboundArguments, uint
                validParameterSetFlags, uint
                defaultParameterSetFlag, System.Management.Automation.Language.PseudoParameterBinder.BindingType
                bindingType)
                {
                    var return_v = this_param.BindPositionalParameter(unboundArguments, validParameterSetFlags, defaultParameterSetFlag, bindingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 41907, 42098);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_42295_42336(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                unboundArguments)
                {
                    var return_v = this_param.BindRemainingParameters(unboundArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 42295, 42336);
                    return return_v;
                }


                int
                f_1446_42359_42383(System.Management.Automation.Language.PseudoParameterBinder
                this_param)
                {
                    this_param.BindPipelineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 42359, 42383);
                    return 0;
                }


                int
                f_1446_43104_43396(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                boundParameters, System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters, ref uint
                _currentParameterSetFlag, System.Management.Automation.Cmdlet
                command)
                {
                    var return_v = CmdletParameterBinderController.ResolveParameterSetAmbiguityBasedOnMandatoryParameters(boundParameters, (System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>)unboundParameters, bindableParameters, ref _currentParameterSetFlag, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 43104, 43396);
                    return return_v;
                }


                int
                f_1446_43757_43783(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 43757, 43783);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_43830_43868(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 43830, 43868);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_43830_43875(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 43830, 43875);
                    return return_v;
                }


                int
                f_1446_43802_43876(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 43802, 43876);
                    return 0;
                }


                System.Management.Automation.Language.PseudoBindingInfo
                f_1446_43904_44082(System.Management.Automation.CommandInfo
                commandInfo, uint
                defaultParameterSetFlag, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                allParsedArguments, System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters)
                {
                    var return_v = new System.Management.Automation.Language.PseudoBindingInfo(commandInfo, defaultParameterSetFlag, allParsedArguments, unboundParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 43904, 44082);
                    return return_v;
                }


                System.Management.Automation.Language.PseudoBindingInfo
                f_1446_44121_44645(System.Management.Automation.CommandInfo
                commandInfo, uint
                validParameterSetsFlags, uint
                defaultParameterSetFlag, System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                boundParameters, System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters, System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                boundArguments, System.Collections.ObjectModel.Collection<string>
                boundPositionalParameter, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                allParsedArguments, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                parametersNotFound, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                ambiguousParameters, System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>
                bindingExceptions, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                duplicateParameters, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                unboundArguments)
                {
                    var return_v = new System.Management.Automation.Language.PseudoBindingInfo(commandInfo, validParameterSetsFlags, defaultParameterSetFlag, boundParameters, unboundParameters, boundArguments, boundPositionalParameter, allParsedArguments, parametersNotFound, ambiguousParameters, bindingExceptions, duplicateParameters, unboundArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 44121, 44645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 39282, 44657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 39282, 44657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetTemporaryDefaultHost(ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 44854, 45678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 44950, 45423) || true) && (f_1446_44954_45003(f_1446_44954_44990(executionContext)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 44950, 45423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 45210, 45275);

                    _restoreHost = f_1446_45225_45274(f_1446_45225_45261(executionContext));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 45355, 45408);

                    f_1446_45355_45407(f_1446_45355_45391(executionContext));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 44950, 45423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 45488, 45667);

                f_1446_45488_45666(f_1446_45488_45524(executionContext), f_1446_45536_45665(f_1446_45591_45617(), f_1446_45636_45664()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 44854, 45678);

                System.Management.Automation.Internal.Host.InternalHost
                f_1446_44954_44990(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 44954, 44990);
                    return return_v;
                }


                bool
                f_1446_44954_45003(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.IsHostRefSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 44954, 45003);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1446_45225_45261(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45225, 45261);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1446_45225_45274(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45225, 45274);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1446_45355_45391(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45355, 45391);
                    return return_v;
                }


                int
                f_1446_45355_45407(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.RevertHostRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 45355, 45407);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1446_45488_45524(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45488, 45524);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1446_45591_45617()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45591, 45617);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1446_45636_45664()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 45636, 45664);
                    return return_v;
                }


                Microsoft.PowerShell.DefaultHost
                f_1446_45536_45665(System.Globalization.CultureInfo
                currentCulture, System.Globalization.CultureInfo
                currentUICulture)
                {
                    var return_v = new Microsoft.PowerShell.DefaultHost(currentCulture, currentUICulture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 45536, 45665);
                    return return_v;
                }


                int
                f_1446_45488_45666(System.Management.Automation.Internal.Host.InternalHost
                this_param, Microsoft.PowerShell.DefaultHost
                psHost)
                {
                    this_param.SetHostRef((System.Management.Automation.Host.PSHost)psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 45488, 45666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 44854, 45678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 44854, 45678);
            }
        }

        private void RestoreHost(ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 45867, 46310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46013, 46066);

                f_1446_46013_46065(f_1446_46013_46049(executionContext));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46126, 46299) || true) && (_restoreHost != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 46126, 46299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46184, 46246);

                    f_1446_46184_46245(f_1446_46184_46220(executionContext), _restoreHost);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46264, 46284);

                    _restoreHost = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 46126, 46299);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 45867, 46310);

                System.Management.Automation.Internal.Host.InternalHost
                f_1446_46013_46049(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 46013, 46049);
                    return return_v;
                }


                int
                f_1446_46013_46065(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.RevertHostRef();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 46013, 46065);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1446_46184_46220(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 46184, 46220);
                    return return_v;
                }


                int
                f_1446_46184_46245(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Host.PSHost
                psHost)
                {
                    this_param.SetHostRef(psHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 46184, 46245);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 45867, 46310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 45867, 46310);
            }
        }

        private PSHost _restoreHost;

        private CommandAst _commandAst;

        private ReadOnlyCollection<CommandElementAst> _commandElements;

        private bool _function;

        private string _commandName;

        private CommandInfo _commandInfo;

        private uint _currentParameterSetFlag;

        private uint _defaultParameterSetFlag;

        private MergedCommandParameterMetadata _bindableParameters;

        private Dictionary<string, MergedCompiledCommandParameter> _boundParameters;

        private Dictionary<string, AstParameterArgumentPair> _boundArguments;

        private Collection<AstParameterArgumentPair> _arguments;

        private Collection<string> _boundPositionalParameter;

        private List<MergedCompiledCommandParameter> _unboundParameters;

        private Type _pipelineInputType;

        private bool _bindingEffective;

        private bool _isPipelineInputExpected;

        private Collection<CommandParameterAst> _parametersNotFound;

        private Collection<CommandParameterAst> _ambiguousParameters;

        private Collection<AstParameterArgumentPair> _duplicateParameters;

        private Dictionary<CommandParameterAst, ParameterBindingException> _bindingExceptions;

        private void InitializeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 47910, 49852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48020, 48038);

                _function = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48052, 48072);

                _commandName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48086, 48127);

                _currentParameterSetFlag = uint.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48141, 48170);

                _defaultParameterSetFlag = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48184, 48211);

                _bindableParameters = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48278, 48348);

                _arguments = _arguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>>(1446, 48291, 48347) ?? f_1446_48305_48347());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48362, 48490);

                _boundParameters = _boundParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>>(1446, 48381, 48489) ?? f_1446_48401_48489(f_1446_48456_48488()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48504, 48624);

                _boundArguments = _boundArguments ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>>(1446, 48522, 48623) ?? f_1446_48541_48623(f_1446_48590_48622()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48638, 48724);

                _unboundParameters = _unboundParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>>(1446, 48659, 48723) ?? f_1446_48681_48723());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48738, 48820);

                _boundPositionalParameter = _boundPositionalParameter ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<string>>(1446, 48766, 48819) ?? f_1446_48795_48819());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48834, 48942);

                _bindingExceptions = _bindingExceptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>>(1446, 48855, 48941) ?? f_1446_48877_48941());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48958, 48977);

                f_1446_48958_48976(
                            _arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 48991, 49016);

                f_1446_48991_49015(_boundParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49030, 49057);

                f_1446_49030_49056(_unboundParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49071, 49095);

                f_1446_49071_49094(_boundArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49109, 49143);

                f_1446_49109_49142(_boundPositionalParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49157, 49184);

                f_1446_49157_49183(_bindingExceptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49259, 49285);

                _pipelineInputType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49299, 49324);

                _bindingEffective = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49338, 49371);

                _isPipelineInputExpected = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49425, 49508);

                _parametersNotFound = _parametersNotFound ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>>(1446, 49447, 49507) ?? f_1446_49470_49507());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49522, 49607);

                _ambiguousParameters = _ambiguousParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>>(1446, 49545, 49606) ?? f_1446_49569_49606());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49621, 49711);

                _duplicateParameters = _duplicateParameters ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>>(1446, 49644, 49710) ?? f_1446_49668_49710());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49727, 49755);

                f_1446_49727_49754(
                            _parametersNotFound);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49769, 49798);

                f_1446_49769_49797(_ambiguousParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49812, 49841);

                f_1446_49812_49840(_duplicateParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 47910, 49852);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_48305_48347()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48305, 48347);
                    return return_v;
                }


                System.StringComparer
                f_1446_48456_48488()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 48456, 48488);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_48401_48489(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48401, 48489);
                    return return_v;
                }


                System.StringComparer
                f_1446_48590_48622()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 48590, 48622);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_48541_48623(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48541, 48623);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_48681_48723()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48681, 48723);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1446_48795_48819()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48795, 48819);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>
                f_1446_48877_48941()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48877, 48941);
                    return return_v;
                }


                int
                f_1446_48958_48976(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48958, 48976);
                    return 0;
                }


                int
                f_1446_48991_49015(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 48991, 49015);
                    return 0;
                }


                int
                f_1446_49030_49056(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49030, 49056);
                    return 0;
                }


                int
                f_1446_49071_49094(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49071, 49094);
                    return 0;
                }


                int
                f_1446_49109_49142(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49109, 49142);
                    return 0;
                }


                int
                f_1446_49157_49183(System.Collections.Generic.Dictionary<System.Management.Automation.Language.CommandParameterAst, System.Management.Automation.ParameterBindingException>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49157, 49183);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_49470_49507()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49470, 49507);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                f_1446_49569_49606()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49569, 49606);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_49668_49710()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49668, 49710);
                    return return_v;
                }


                int
                f_1446_49727_49754(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49727, 49754);
                    return 0;
                }


                int
                f_1446_49769_49797(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49769, 49797);
                    return 0;
                }


                int
                f_1446_49812_49840(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 49812, 49840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 47910, 49852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 47910, 49852);
            }
        }

        private bool PrepareCommandElements(ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 49864, 58235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49950, 49971);

                int
                commandIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 49985, 50050);

                bool
                dotSource = f_1446_50002_50032(_commandAst) == TokenKind.Dot
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50066, 50104);

                CommandProcessorBase
                processor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50118, 50144);

                string
                commandName = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50194, 50296);

                    processor = f_1446_50206_50246(this, context, out commandName) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandProcessorBase>(1446, 50206, 50295) ?? f_1446_50250_50295(context, commandName, dotSource));
                }
                catch (RuntimeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 50325, 50469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50441, 50454);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 50325, 50469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50485, 50538);

                var
                commandProcessor = processor as CommandProcessor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50552, 50614);

                var
                scriptProcessor = processor as ScriptCommandProcessorBase
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50628, 50796);

                bool
                implementsDynamicParameters = commandProcessor != null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 50663, 50795) && f_1446_50739_50795(f_1446_50739_50767(commandProcessor)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 50812, 51038);

                var
                argumentsToGetDynamicParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(1446, 50850, 50877) || ((implementsDynamicParameters
                && DynAbs.Tracing.TraceSender.Conditional_F2(1446, 50935, 50975)) || DynAbs.Tracing.TraceSender.Conditional_F3(1446, 51033, 51037))) ? f_1446_50935_50975(f_1446_50952_50974(_commandElements)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51052, 52971) || true) && (commandProcessor != null || (DynAbs.Tracing.TraceSender.Expression_False(1446, 51056, 51107) || scriptProcessor != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 51052, 52971);
                    try
                    {                // Pre-processing the arguments -- command arguments
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51216, 51230)
        , commandIndex++; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51211, 52956) || true) && (commandIndex < f_1446_51247_51269(_commandElements))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51271, 51285)
        , commandIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 51211, 52956))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 51211, 52956);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51327, 51397);

                            var
                            parameter = f_1446_51343_51373(_commandElements, commandIndex) as CommandParameterAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51419, 52937) || true) && (parameter != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 51419, 52937);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51490, 51677) || true) && (argumentsToGetDynamicParameters != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 51490, 51677);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51591, 51650);

                                    f_1446_51591_51649(argumentsToGetDynamicParameters, f_1446_51627_51648(f_1446_51627_51643(parameter)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 51490, 51677);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51705, 51884);

                                AstPair
                                parameterArg = (DynAbs.Tracing.TraceSender.Conditional_F1(1446, 51728, 51754) || ((f_1446_51728_51746(parameter) != null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(1446, 51786, 51808)) || DynAbs.Tracing.TraceSender.Conditional_F3(1446, 51840, 51883))) ? f_1446_51786_51808(parameter) : f_1446_51840_51883(parameter, (ExpressionAst)null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 51912, 51941);

                                f_1446_51912_51940(
                                                        _arguments, parameterArg);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 51419, 52937);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 51419, 52937);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52039, 52112);

                                var
                                dash = f_1446_52050_52080(_commandElements, commandIndex) as StringConstantExpressionAst
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52138, 52517) || true) && (dash != null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 52142, 52223) && f_1446_52158_52223(f_1446_52158_52175(f_1446_52158_52168(dash)), "-", StringComparison.OrdinalIgnoreCase)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 52138, 52517);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52481, 52490);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 52138, 52517);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52545, 52618);

                                var
                                expressionArgument = f_1446_52570_52600(_commandElements, commandIndex) as ExpressionAst
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52644, 52914) || true) && (expressionArgument != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 52644, 52914);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52732, 52801);

                                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argumentsToGetDynamicParameters, 1446, 52732, 52800)?.Add(f_1446_52769_52799(f_1446_52769_52794(expressionArgument))), 1446, 52764, 52800);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52833, 52887);

                                    f_1446_52833_52886(
                                                                _arguments, f_1446_52848_52885(null, expressionArgument));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 52644, 52914);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 51419, 52937);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 1746);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 1746);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 51052, 52971);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 52987, 57197) || true) && (commandProcessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 52987, 57197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53049, 53067);

                    _function = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53085, 56197) || true) && (implementsDynamicParameters)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 53085, 56197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53158, 53276);

                        f_1446_53158_53275(commandProcessor, f_1446_53233_53274(argumentsToGetDynamicParameters));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53298, 53351);

                        bool
                        retryWithNoArgs = false
                        ,
                        alreadyRetried = false
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 53375, 56178);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53426, 53508);

                                    CommandProcessorBase
                                    oldCurrentCommandProcessor = f_1446_53476_53507(context)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53594, 53645);

                                        context.CurrentCommandProcessor = commandProcessor;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53675, 53726);

                                        f_1446_53675_53725(commandProcessor);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 54092, 54968) || true) && (!retryWithNoArgs)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 54092, 54968);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 54266, 54381);

                                            f_1446_54266_54380(f_1446_54266_54314(commandProcessor), commandProcessor.arguments);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 54092, 54968);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 54092, 54968);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 54643, 54665);

                                            alreadyRetried = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 54699, 54772);

                                            f_1446_54699_54771(f_1446_54699_54747(commandProcessor));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 54806, 54937);

                                            f_1446_54806_54936(f_1446_54806_54854(commandProcessor), f_1446_54893_54935());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 54092, 54968);
                                        }
                                    }
                                    catch (ParameterBindingException e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 55021, 55766);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 55610, 55739) || true) && (f_1446_55614_55623(e) == "MissingArgument" || (DynAbs.Tracing.TraceSender.Expression_False(1446, 55614, 55681) || f_1446_55648_55657(e) == "AmbiguousParameter"))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 55610, 55739);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 55716, 55739);

                                            retryWithNoArgs = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 55610, 55739);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 55021, 55766);
                                    }
                                    catch (Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 55792, 55863);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 55792, 55863);
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1446, 55889, 56111);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 55953, 56014);

                                        context.CurrentCommandProcessor = oldCurrentCommandProcessor;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56044, 56084);

                                        f_1446_56044_56083(commandProcessor);
                                        DynAbs.Tracing.TraceSender.TraceExitFinally(1446, 55889, 56111);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 53375, 56178);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 53375, 56178) || true) && (retryWithNoArgs && (DynAbs.Tracing.TraceSender.Expression_True(1446, 56142, 56176) && !alreadyRetried))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 53375, 56178);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 53375, 56178);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 53085, 56197);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56301, 56345);

                    _commandInfo = f_1446_56316_56344(commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56363, 56412);

                    _commandName = f_1446_56378_56411(f_1446_56378_56406(commandProcessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56430, 56520);

                    _bindableParameters = f_1446_56452_56519(f_1446_56452_56500(commandProcessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56538, 56634);

                    _defaultParameterSetFlag = f_1446_56565_56633(f_1446_56565_56609(f_1446_56565_56593(commandProcessor)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 52987, 57197);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 52987, 57197);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56668, 57197) || true) && (scriptProcessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 56668, 57197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56729, 56746);

                        _function = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56764, 56807);

                        _commandInfo = f_1446_56779_56806(scriptProcessor);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56825, 56873);

                        _commandName = f_1446_56840_56872(f_1446_56840_56867(scriptProcessor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56891, 56980);

                        _bindableParameters = f_1446_56913_56979(f_1446_56913_56960(scriptProcessor));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 56998, 57027);

                        _defaultParameterSetFlag = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 56668, 57197);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 56668, 57197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57169, 57182);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 56668, 57197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 52987, 57197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57213, 57288);

                f_1446_57213_57287(
                            _unboundParameters, f_1446_57241_57286(f_1446_57241_57279(_bindableParameters)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57416, 57452);

                CommandBaseAst
                preCmdBaseAst = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57466, 57511);

                var
                pipe = f_1446_57477_57495(_commandAst) as PipelineAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57525, 57604);

                f_1446_57525_57603(pipe != null, "CommandAst should has a PipelineAst parent");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57618, 58196) || true) && (f_1446_57622_57649(f_1446_57622_57643(pipe)) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 57618, 58196);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57687, 58181);
                        foreach (CommandBaseAst cmdBase in f_1446_57722_57743_I(f_1446_57722_57743(pipe)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 57687, 58181);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57785, 58114) || true) && (f_1446_57789_57810(cmdBase) == f_1446_57814_57839(_commandAst))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 57785, 58114);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57889, 57938);

                                _isPipelineInputExpected = preCmdBaseAst != null;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 57964, 58059) || true) && (_isPipelineInputExpected)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 57964, 58059);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58023, 58059);

                                    _pipelineInputType = typeof(object);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 57964, 58059);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 58085, 58091);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 57785, 58114);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58138, 58162);

                            preCmdBaseAst = cmdBase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 57687, 58181);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 495);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 495);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 57618, 58196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58212, 58224);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 49864, 58235);

                System.Management.Automation.Language.TokenKind
                f_1446_50002_50032(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 50002, 50032);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1446_50206_50246(System.Management.Automation.Language.PseudoParameterBinder
                this_param, System.Management.Automation.ExecutionContext
                context, out string
                resolvedCommandName)
                {
                    var return_v = this_param.PrepareFromAst(context, out resolvedCommandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 50206, 50246);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1446_50250_50295(System.Management.Automation.ExecutionContext
                this_param, string
                command, bool
                dotSource)
                {
                    var return_v = this_param.CreateCommand(command, dotSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 50250, 50295);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1446_50739_50767(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 50739, 50767);
                    return return_v;
                }


                bool
                f_1446_50739_50795(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 50739, 50795);
                    return return_v;
                }


                int
                f_1446_50952_50974(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 50952, 50974);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1446_50935_50975(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<object>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 50935, 50975);
                    return return_v;
                }


                int
                f_1446_51247_51269(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 51247, 51269);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_51343_51373(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 51343, 51373);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_51627_51643(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 51627, 51643);
                    return return_v;
                }


                string
                f_1446_51627_51648(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 51627, 51648);
                    return return_v;
                }


                int
                f_1446_51591_51649(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 51591, 51649);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1446_51728_51746(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 51728, 51746);
                    return return_v;
                }


                System.Management.Automation.Language.AstPair
                f_1446_51786_51808(System.Management.Automation.Language.CommandParameterAst
                parameterAst)
                {
                    var return_v = new System.Management.Automation.Language.AstPair(parameterAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 51786, 51808);
                    return return_v;
                }


                System.Management.Automation.Language.AstPair
                f_1446_51840_51883(System.Management.Automation.Language.CommandParameterAst
                parameterAst, System.Management.Automation.Language.ExpressionAst
                argumentAst)
                {
                    var return_v = new System.Management.Automation.Language.AstPair(parameterAst, argumentAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 51840, 51883);
                    return return_v;
                }


                int
                f_1446_51912_51940(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstPair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 51912, 51940);
                    return 0;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_52050_52080(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 52050, 52080);
                    return return_v;
                }


                string
                f_1446_52158_52168(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 52158, 52168);
                    return return_v;
                }


                string
                f_1446_52158_52175(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 52158, 52175);
                    return return_v;
                }


                bool
                f_1446_52158_52223(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 52158, 52223);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_52570_52600(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 52570, 52600);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1446_52769_52794(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 52769, 52794);
                    return return_v;
                }


                string
                f_1446_52769_52799(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 52769, 52799);
                    return return_v;
                }


                System.Management.Automation.Language.AstPair
                f_1446_52848_52885(System.Management.Automation.Language.CommandParameterAst
                parameterAst, System.Management.Automation.Language.ExpressionAst
                argumentAst)
                {
                    var return_v = new System.Management.Automation.Language.AstPair(parameterAst, argumentAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 52848, 52885);
                    return return_v;
                }


                int
                f_1446_52833_52886(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstPair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 52833, 52886);
                    return 0;
                }


                object[]
                f_1446_53233_53274(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 53233, 53274);
                    return return_v;
                }


                int
                f_1446_53158_53275(System.Management.Automation.CommandProcessor
                commandProcessor, object[]
                arguments)
                {
                    ParameterBinderController.AddArgumentsToCommandProcessor((System.Management.Automation.CommandProcessorBase)commandProcessor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 53158, 53275);
                    return 0;
                }


                System.Management.Automation.CommandProcessorBase
                f_1446_53476_53507(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 53476, 53507);
                    return return_v;
                }


                int
                f_1446_53675_53725(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 53675, 53725);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1446_54266_54314(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 54266, 54314);
                    return return_v;
                }


                int
                f_1446_54266_54380(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParametersNoValidation(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 54266, 54380);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1446_54699_54747(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 54699, 54747);
                    return return_v;
                }


                int
                f_1446_54699_54771(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.ClearUnboundArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 54699, 54771);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1446_54806_54854(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 54806, 54854);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1446_54893_54935()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 54893, 54935);
                    return return_v;
                }


                int
                f_1446_54806_54936(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParametersNoValidation(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 54806, 54936);
                    return 0;
                }


                string
                f_1446_55614_55623(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 55614, 55623);
                    return return_v;
                }


                string
                f_1446_55648_55657(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 55648, 55657);
                    return return_v;
                }


                int
                f_1446_56044_56083(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 56044, 56083);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1446_56316_56344(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56316, 56344);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1446_56378_56406(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56378, 56406);
                    return return_v;
                }


                string
                f_1446_56378_56411(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56378, 56411);
                    return return_v;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1446_56452_56500(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56452, 56500);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1446_56452_56519(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56452, 56519);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1446_56565_56593(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56565, 56593);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1446_56565_56609(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56565, 56609);
                    return return_v;
                }


                uint
                f_1446_56565_56633(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56565, 56633);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1446_56779_56806(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56779, 56806);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1446_56840_56867(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56840, 56867);
                    return return_v;
                }


                string
                f_1446_56840_56872(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56840, 56872);
                    return return_v;
                }


                System.Management.Automation.ScriptParameterBinderController
                f_1446_56913_56960(System.Management.Automation.ScriptCommandProcessorBase
                this_param)
                {
                    var return_v = this_param.ScriptParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56913, 56960);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1446_56913_56979(System.Management.Automation.ScriptParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 56913, 56979);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_57241_57279(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57241, 57279);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_57241_57286(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57241, 57286);
                    return return_v;
                }


                int
                f_1446_57213_57287(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 57213, 57287);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1446_57477_57495(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57477, 57495);
                    return return_v;
                }


                int
                f_1446_57525_57603(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 57525, 57603);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1446_57622_57643(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57622, 57643);
                    return return_v;
                }


                int
                f_1446_57622_57649(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57622, 57649);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1446_57722_57743(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 57722, 57743);
                    return return_v;
                }


                int
                f_1446_57789_57810(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 57789, 57810);
                    return return_v;
                }


                int
                f_1446_57814_57839(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 57814, 57839);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1446_57722_57743_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 57722, 57743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 49864, 58235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 49864, 58235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommandProcessorBase PrepareFromAst(ExecutionContext context, out string resolvedCommandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 58247, 59805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58405, 58464);

                var
                exportVisitor = f_1446_58425_58463(forCompletion: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58478, 58500);

                Ast
                ast = _commandAst
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58514, 58605) || true) && (f_1446_58521_58531(ast) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 58514, 58605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58573, 58590);

                        ast = f_1446_58579_58589(ast);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 58514, 58605);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 58514, 58605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 58514, 58605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58621, 58646);

                f_1446_58621_58645(
                            ast, exportVisitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58662, 58707);

                CommandProcessorBase
                commandProcessor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58723, 58774);

                resolvedCommandName = f_1446_58745_58773(_commandAst);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58788, 59754) || true) && (resolvedCommandName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 58788, 59754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58853, 58866);

                    string
                    alias
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58884, 58911);

                    int
                    resolvedAliasCount = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 58931, 59264) || true) && (f_1446_58938_59013(f_1446_58938_58969(exportVisitor), resolvedCommandName, out alias))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 58931, 59264);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59055, 59079);

                            resolvedAliasCount += 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59101, 59160) || true) && (resolvedAliasCount > 5)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 59101, 59160);
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 59154, 59160);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 59101, 59160);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59217, 59245);

                            resolvedCommandName = alias;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 58931, 59264);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 58931, 59264);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 58931, 59264);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59284, 59328);

                    FunctionDefinitionAst
                    functionDefinitionAst
                    = default(FunctionDefinitionAst);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59346, 59739) || true) && (f_1446_59350_59443(f_1446_59350_59383(exportVisitor), resolvedCommandName, out functionDefinitionAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 59346, 59739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59485, 59574);

                        var
                        scriptBlock = f_1446_59503_59573(functionDefinitionAst, f_1446_59542_59572(functionDefinitionAst))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59596, 59720);

                        commandProcessor = f_1446_59615_59719(scriptBlock, context, true, f_1446_59692_59718(context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 59346, 59739);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 58788, 59754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 59770, 59794);

                return commandProcessor;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 58247, 59805);

                System.Management.Automation.ExportVisitor
                f_1446_58425_58463(bool
                forCompletion)
                {
                    var return_v = new System.Management.Automation.ExportVisitor(forCompletion: forCompletion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 58425, 58463);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1446_58521_58531(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 58521, 58531);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1446_58579_58589(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 58579, 58589);
                    return return_v;
                }


                int
                f_1446_58621_58645(System.Management.Automation.Language.Ast
                this_param, System.Management.Automation.ExportVisitor
                astVisitor)
                {
                    this_param.Visit((System.Management.Automation.Language.AstVisitor)astVisitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 58621, 58645);
                    return 0;
                }


                string
                f_1446_58745_58773(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.GetCommandName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 58745, 58773);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1446_58938_58969(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 58938, 58969);
                    return return_v;
                }


                bool
                f_1446_58938_59013(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 58938, 59013);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.FunctionDefinitionAst>
                f_1446_59350_59383(System.Management.Automation.ExportVisitor
                this_param)
                {
                    var return_v = this_param.DiscoveredFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 59350, 59383);
                    return return_v;
                }


                bool
                f_1446_59350_59443(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.FunctionDefinitionAst>
                this_param, string
                key, out System.Management.Automation.Language.FunctionDefinitionAst
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 59350, 59443);
                    return return_v;
                }


                bool
                f_1446_59542_59572(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.IsFilter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 59542, 59572);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1446_59503_59573(System.Management.Automation.Language.FunctionDefinitionAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 59503, 59573);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1446_59692_59718(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 59692, 59718);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1446_59615_59719(System.Management.Automation.ScriptBlock
                scriptblock, System.Management.Automation.ExecutionContext
                context, bool
                useNewScope, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = CommandDiscovery.CreateCommandProcessorForScript(scriptblock, context, useNewScope, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 59615, 59719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 58247, 59805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 58247, 59805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ParseParameterArguments(CommandParameterAst paramAstAtCursor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 60768, 69075);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 60867, 60933) || true) && (!_bindingEffective)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 60867, 60933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 60908, 60933);

                    return _bindingEffective;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 60867, 60933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 60949, 61005);

                var
                result = f_1446_60962_61004()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61028, 61037);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61019, 69002) || true) && (index < f_1446_61047_61063(_arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61065, 61072)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 61019, 69002))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 61019, 69002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61106, 61160);

                        AstParameterArgumentPair
                        argument = f_1446_61142_61159(_arguments, index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61178, 61417) || true) && (f_1446_61182_61210_M(!argument.ParameterSpecified) || (DynAbs.Tracing.TraceSender.Expression_False(1446, 61182, 61240) || f_1446_61214_61240(argument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 61178, 61417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61346, 61367);

                            f_1446_61346_61366(                    // Add the positional/named arguments back
                                                result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61389, 61398);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 61178, 61417);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61437, 61595);

                        f_1446_61437_61594(f_1446_61456_61483(argument) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 61456, 61514) && f_1446_61487_61514_M(!argument.ArgumentSpecified)), "At this point, the parameters should have no arguments");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61693, 61739);

                        string
                        parameterName = f_1446_61716_61738(argument)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61757, 61813);

                        MergedCompiledCommandParameter
                        matchingParameter = null
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61877, 61940);

                            bool
                            tryExactMatching = f_1446_61901_61919(argument) != paramAstAtCursor
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 61962, 62069);

                            matchingParameter = f_1446_61982_62068(_bindableParameters, parameterName, false, tryExactMatching, null);
                        }
                        catch (ParameterBindingException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 62106, 63117);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 62590, 62931) || true) && (index < f_1446_62602_62618(_arguments) - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 62590, 62931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 62672, 62729);

                                AstParameterArgumentPair
                                nextArg = f_1446_62707_62728(_arguments, index + 1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 62755, 62908) || true) && (f_1446_62759_62786_M(!nextArg.ParameterSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 62759, 62815) && f_1446_62790_62815(nextArg)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 62755, 62908);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 62873, 62881);

                                    index++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 62755, 62908);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 62590, 62931);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 62955, 63000);

                            f_1446_62955_62999(
                                                _ambiguousParameters, f_1446_62980_62998(argument));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 63022, 63065);

                            _bindingExceptions[f_1446_63041_63059(argument)] = e;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 63089, 63098);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 62106, 63117);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 63137, 65836) || true) && (matchingParameter == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 63137, 65836);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 64332, 65534) || true) && (index < f_1446_64344_64360(_arguments) - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 64332, 65534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 64414, 64471);

                                AstParameterArgumentPair
                                nextArg = f_1446_64449_64470(_arguments, index + 1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 64595, 65511) || true) && (f_1446_64599_64626_M(!nextArg.ParameterSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 64599, 64655) && f_1446_64630_64655(nextArg)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 64595, 65511);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 64897, 65484) || true) && (paramAstAtCursor != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 64897, 65484);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65059, 65077);

                                        _arguments = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65111, 65124);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 64897, 65484);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 64897, 65484);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65324, 65332);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65366, 65410);

                                        f_1446_65366_65409(_parametersNotFound, f_1446_65390_65408(argument));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65444, 65453);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 64897, 65484);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 64595, 65511);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 64332, 65534);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65742, 65786);

                            f_1446_65742_65785(
                                                // If the next item is not a pure argument, or the current parameter is the last item,
                                                // ignore this parameter and carry on with the binding
                                                _parametersNotFound, f_1446_65766_65784(argument));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65808, 65817);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 63137, 65836);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 65906, 66157) || true) && (f_1446_65910_65942(f_1446_65910_65937(matchingParameter)) == typeof(SwitchParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 65906, 66157);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66011, 66066);

                            SwitchPair
                            newArg = f_1446_66031_66065(f_1446_66046_66064(argument))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66088, 66107);

                            f_1446_66088_66106(result, newArg);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66129, 66138);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 65906, 66157);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66261, 68987) || true) && (index < f_1446_66273_66289(_arguments) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66261, 68987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66335, 66392);

                            AstParameterArgumentPair
                            nextArg = f_1446_66370_66391(_arguments, index + 1)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66414, 68703) || true) && (f_1446_66418_66444(nextArg))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66414, 68703);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66554, 66725);

                                    MergedCompiledCommandParameter
                                    nextMatchingParameter =
                                    f_1446_66642_66724(_bindableParameters, f_1446_66683_66704(nextArg), false, true, null)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66846, 67570) || true) && (nextMatchingParameter == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66846, 67570);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 66945, 67013);

                                        AstPair
                                        newArg = f_1446_66962_67012(f_1446_66974_66992(argument), f_1446_66994_67011(nextArg))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67047, 67066);

                                        f_1446_67047_67065(result, newArg);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67100, 67108);

                                        index++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66846, 67570);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66846, 67570);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67435, 67486);

                                        FakePair
                                        newArg = f_1446_67453_67485(f_1446_67466_67484(argument))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67520, 67539);

                                        f_1446_67520_67538(result, newArg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66846, 67570);
                                    }
                                }
                                catch (ParameterBindingException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 67623, 67997);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67870, 67921);

                                    FakePair
                                    newArg = f_1446_67888_67920(f_1446_67901_67919(argument))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 67951, 67970);

                                    f_1446_67951_67969(result, newArg);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 67623, 67997);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66414, 68703);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66414, 68703);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68157, 68199);

                                AstPair
                                nextArgument = nextArg as AstPair
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68225, 68314);

                                f_1446_68225_68313(nextArgument != null, "the next item should be a pure argument here");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68340, 68486);

                                f_1446_68340_68485(f_1446_68359_68389(nextArgument) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 68359, 68436) && f_1446_68393_68436_M(!nextArgument.ArgumentIsCommandParameterAst)), "the next item should be a pure argument here");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68514, 68601);

                                AstPair
                                newArg = f_1446_68531_68600(f_1446_68543_68561(argument), (ExpressionAst)f_1446_68578_68599(nextArgument))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68627, 68646);

                                f_1446_68627_68645(result, newArg);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68672, 68680);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66414, 68703);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66261, 68987);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 66261, 68987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68876, 68927);

                            FakePair
                            newArg = f_1446_68894_68926(f_1446_68907_68925(argument))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 68949, 68968);

                            f_1446_68949_68967(result, newArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 66261, 68987);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 7984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 7984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69018, 69038);

                _arguments = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69052, 69064);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 60768, 69075);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_60962_61004()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 60962, 61004);
                    return return_v;
                }


                int
                f_1446_61047_61063(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61047, 61063);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_61142_61159(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61142, 61159);
                    return return_v;
                }


                bool
                f_1446_61182_61210_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61182, 61210);
                    return return_v;
                }


                bool
                f_1446_61214_61240(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61214, 61240);
                    return return_v;
                }


                int
                f_1446_61346_61366(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 61346, 61366);
                    return 0;
                }


                bool
                f_1446_61456_61483(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ParameterSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61456, 61483);
                    return return_v;
                }


                bool
                f_1446_61487_61514_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61487, 61514);
                    return return_v;
                }


                int
                f_1446_61437_61594(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 61437, 61594);
                    return 0;
                }


                string
                f_1446_61716_61738(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61716, 61738);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_61901_61919(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 61901, 61919);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_61982_62068(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 61982, 62068);
                    return return_v;
                }


                int
                f_1446_62602_62618(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 62602, 62618);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_62707_62728(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 62707, 62728);
                    return return_v;
                }


                bool
                f_1446_62759_62786_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 62759, 62786);
                    return return_v;
                }


                bool
                f_1446_62790_62815(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 62790, 62815);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_62980_62998(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 62980, 62998);
                    return return_v;
                }


                int
                f_1446_62955_62999(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param, System.Management.Automation.Language.CommandParameterAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 62955, 62999);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_63041_63059(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 63041, 63059);
                    return return_v;
                }


                int
                f_1446_64344_64360(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 64344, 64360);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_64449_64470(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 64449, 64470);
                    return return_v;
                }


                bool
                f_1446_64599_64626_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 64599, 64626);
                    return return_v;
                }


                bool
                f_1446_64630_64655(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 64630, 64655);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_65390_65408(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 65390, 65408);
                    return return_v;
                }


                int
                f_1446_65366_65409(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param, System.Management.Automation.Language.CommandParameterAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 65366, 65409);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_65766_65784(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 65766, 65784);
                    return return_v;
                }


                int
                f_1446_65742_65785(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param, System.Management.Automation.Language.CommandParameterAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 65742, 65785);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_65910_65937(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 65910, 65937);
                    return return_v;
                }


                System.Type
                f_1446_65910_65942(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 65910, 65942);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_66046_66064(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66046, 66064);
                    return return_v;
                }


                System.Management.Automation.Language.SwitchPair
                f_1446_66031_66065(System.Management.Automation.Language.CommandParameterAst
                parameterAst)
                {
                    var return_v = new System.Management.Automation.Language.SwitchPair(parameterAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 66031, 66065);
                    return return_v;
                }


                int
                f_1446_66088_66106(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.SwitchPair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 66088, 66106);
                    return 0;
                }


                int
                f_1446_66273_66289(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66273, 66289);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_66370_66391(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66370, 66391);
                    return return_v;
                }


                bool
                f_1446_66418_66444(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ParameterSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66418, 66444);
                    return return_v;
                }


                string
                f_1446_66683_66704(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66683, 66704);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_66642_66724(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 66642, 66724);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_66974_66992(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66974, 66992);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_66994_67011(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 66994, 67011);
                    return return_v;
                }


                System.Management.Automation.Language.AstPair
                f_1446_66962_67012(System.Management.Automation.Language.CommandParameterAst
                parameterAst, System.Management.Automation.Language.CommandParameterAst
                argumentAst)
                {
                    var return_v = new System.Management.Automation.Language.AstPair(parameterAst, (System.Management.Automation.Language.CommandElementAst)argumentAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 66962, 67012);
                    return return_v;
                }


                int
                f_1446_67047_67065(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstPair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 67047, 67065);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_67466_67484(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 67466, 67484);
                    return return_v;
                }


                System.Management.Automation.Language.FakePair
                f_1446_67453_67485(System.Management.Automation.Language.CommandParameterAst
                parameterAst)
                {
                    var return_v = new System.Management.Automation.Language.FakePair(parameterAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 67453, 67485);
                    return return_v;
                }


                int
                f_1446_67520_67538(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.FakePair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 67520, 67538);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_67901_67919(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 67901, 67919);
                    return return_v;
                }


                System.Management.Automation.Language.FakePair
                f_1446_67888_67920(System.Management.Automation.Language.CommandParameterAst
                parameterAst)
                {
                    var return_v = new System.Management.Automation.Language.FakePair(parameterAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 67888, 67920);
                    return return_v;
                }


                int
                f_1446_67951_67969(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.FakePair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 67951, 67969);
                    return 0;
                }


                int
                f_1446_68225_68313(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68225, 68313);
                    return 0;
                }


                bool
                f_1446_68359_68389(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 68359, 68389);
                    return return_v;
                }


                bool
                f_1446_68393_68436_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 68393, 68436);
                    return return_v;
                }


                int
                f_1446_68340_68485(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68340, 68485);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_68543_68561(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 68543, 68561);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_68578_68599(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 68578, 68599);
                    return return_v;
                }


                System.Management.Automation.Language.AstPair
                f_1446_68531_68600(System.Management.Automation.Language.CommandParameterAst
                parameterAst, System.Management.Automation.Language.CommandElementAst
                argumentAst)
                {
                    var return_v = new System.Management.Automation.Language.AstPair(parameterAst, (System.Management.Automation.Language.ExpressionAst)argumentAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68531, 68600);
                    return return_v;
                }


                int
                f_1446_68627_68645(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstPair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68627, 68645);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_68907_68925(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 68907, 68925);
                    return return_v;
                }


                System.Management.Automation.Language.FakePair
                f_1446_68894_68926(System.Management.Automation.Language.CommandParameterAst
                parameterAst)
                {
                    var return_v = new System.Management.Automation.Language.FakePair(parameterAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68894, 68926);
                    return return_v;
                }


                int
                f_1446_68949_68967(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.FakePair
                item)
                {
                    this_param.Add((System.Management.Automation.Language.AstParameterArgumentPair)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 68949, 68967);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 60768, 69075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 60768, 69075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<AstParameterArgumentPair> BindNamedParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 69087, 71829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69178, 69267);

                Collection<AstParameterArgumentPair>
                result = f_1446_69224_69266()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69283, 69338) || true) && (!_bindingEffective)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 69283, 69338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69324, 69338);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 69283, 69338);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69354, 71788);
                    foreach (AstParameterArgumentPair argument in f_1446_69400_69410_I(_arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 69354, 71788);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69444, 69589) || true) && (f_1446_69448_69476_M(!argument.ParameterSpecified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 69444, 69589);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69518, 69539);

                            f_1446_69518_69538(result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69561, 69570);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 69444, 69589);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69609, 69657);

                        MergedCompiledCommandParameter
                        parameter = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 69719, 69815);

                            parameter = f_1446_69731_69814(_bindableParameters, f_1446_69772_69794(argument), false, true, null);
                        }
                        catch (ParameterBindingException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 69852, 70318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70223, 70268);

                            f_1446_70223_70267(                    // The parameter name is ambiguous. It's not processed in ParseParameterArguments. Otherwise we
                                                                   // should detect it early. So this argument comes from a CommandParameterAst with argument. We
                                                                   // ignore it and carry on with our binding
                                                _ambiguousParameters, f_1446_70248_70266(argument));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70290, 70299);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 69852, 70318);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70338, 70718) || true) && (parameter == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 70338, 70718);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70624, 70668);

                            f_1446_70624_70667(                    // Cannot find a matching parameter. It's not processed in ParseParameterArguments. It comes from
                                                                   // a CommandParameterAst with argument. We ignore it and carry on with our binding
                                                _parametersNotFound, f_1446_70648_70666(argument));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70690, 70699);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 70338, 70718);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70738, 71024) || true) && (f_1446_70742_70796(_boundParameters, f_1446_70771_70795(f_1446_70771_70790(parameter))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 70738, 71024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70939, 70974);

                            f_1446_70939_70973(                    // This parameter is already bound. We ignore it and carry on with the binding.
                                                _duplicateParameters, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 70996, 71005);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 70738, 71024);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71150, 71323) || true) && (f_1446_71154_71191(f_1446_71154_71173(parameter)) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 71150, 71323);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71238, 71304);

                            _currentParameterSetFlag &= f_1446_71266_71303(f_1446_71266_71285(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 71150, 71323);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71343, 71380);

                        f_1446_71343_71379(
                                        _unboundParameters, parameter);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71400, 71578) || true) && (!f_1446_71405_71459(_boundParameters, f_1446_71434_71458(f_1446_71434_71453(parameter))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 71400, 71578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71501, 71559);

                            f_1446_71501_71558(_boundParameters, f_1446_71522_71546(f_1446_71522_71541(parameter)), parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 71400, 71578);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71598, 71773) || true) && (!f_1446_71603_71656(_boundArguments, f_1446_71631_71655(f_1446_71631_71650(parameter))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 71598, 71773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71698, 71754);

                            f_1446_71698_71753(_boundArguments, f_1446_71718_71742(f_1446_71718_71737(parameter)), argument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 71598, 71773);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 69354, 71788);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 2435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 2435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 71804, 71818);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 69087, 71829);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_69224_69266()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 69224, 69266);
                    return return_v;
                }


                bool
                f_1446_69448_69476_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 69448, 69476);
                    return return_v;
                }


                int
                f_1446_69518_69538(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 69518, 69538);
                    return 0;
                }


                string
                f_1446_69772_69794(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 69772, 69794);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_69731_69814(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 69731, 69814);
                    return return_v;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_70248_70266(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 70248, 70266);
                    return return_v;
                }


                int
                f_1446_70223_70267(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param, System.Management.Automation.Language.CommandParameterAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 70223, 70267);
                    return 0;
                }


                System.Management.Automation.Language.CommandParameterAst
                f_1446_70648_70666(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 70648, 70666);
                    return return_v;
                }


                int
                f_1446_70624_70667(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.CommandParameterAst>
                this_param, System.Management.Automation.Language.CommandParameterAst
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 70624, 70667);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_70771_70790(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 70771, 70790);
                    return return_v;
                }


                string
                f_1446_70771_70795(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 70771, 70795);
                    return return_v;
                }


                bool
                f_1446_70742_70796(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 70742, 70796);
                    return return_v;
                }


                int
                f_1446_70939_70973(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 70939, 70973);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71154_71173(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71154, 71173);
                    return return_v;
                }


                uint
                f_1446_71154_71191(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71154, 71191);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71266_71285(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71266, 71285);
                    return return_v;
                }


                uint
                f_1446_71266_71303(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71266, 71303);
                    return return_v;
                }


                bool
                f_1446_71343_71379(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 71343, 71379);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71434_71453(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71434, 71453);
                    return return_v;
                }


                string
                f_1446_71434_71458(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71434, 71458);
                    return return_v;
                }


                bool
                f_1446_71405_71459(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 71405, 71459);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71522_71541(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71522, 71541);
                    return return_v;
                }


                string
                f_1446_71522_71546(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71522, 71546);
                    return return_v;
                }


                int
                f_1446_71501_71558(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 71501, 71558);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71631_71650(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71631, 71650);
                    return return_v;
                }


                string
                f_1446_71631_71655(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71631, 71655);
                    return return_v;
                }


                bool
                f_1446_71603_71656(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 71603, 71656);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_71718_71737(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71718, 71737);
                    return return_v;
                }


                string
                f_1446_71718_71742(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 71718, 71742);
                    return return_v;
                }


                int
                f_1446_71698_71753(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 71698, 71753);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_69400_69410_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 69400, 69410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 69087, 71829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 69087, 71829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<AstParameterArgumentPair> BindPositionalParameter(
                    Collection<AstParameterArgumentPair> unboundArguments,
                    uint validParameterSetFlags,
                    uint defaultParameterSetFlag,
                    BindingType bindingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 71841, 79331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 72126, 72215);

                Collection<AstParameterArgumentPair>
                result = f_1446_72172_72214()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 72231, 79290) || true) && (_bindingEffective && (DynAbs.Tracing.TraceSender.Expression_True(1446, 72235, 72282) && f_1446_72256_72278(unboundArguments) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 72231, 79290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 72316, 72429);

                    List<AstParameterArgumentPair>
                    unboundArgumentsCollection = f_1446_72376_72428(unboundArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 72505, 72629);

                    SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>>
                    positionalParameterDictionary
                    = default(SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>>);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 72691, 72854);

                        positionalParameterDictionary =
                        f_1446_72748_72853(_unboundParameters, validParameterSetFlags);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1446, 72891, 73325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73244, 73270);

                        _bindingEffective = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73292, 73306);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1446, 72891, 73325);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73399, 73490) || true) && (f_1446_73403_73438(positionalParameterDictionary) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 73399, 73490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73466, 73490);

                        return unboundArguments;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 73399, 73490);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73510, 73540);

                    int
                    unboundArgumentsIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73558, 79059);
                        foreach (Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> nextPositionalParameters in f_1446_73666_73702_I(f_1446_73666_73702(positionalParameterDictionary)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 73558, 79059);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73744, 73865) || true) && (f_1446_73748_73778(nextPositionalParameters) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 73744, 73865);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73833, 73842);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 73744, 73865);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 73889, 74090);

                            AstParameterArgumentPair
                            argument = f_1446_73925_74089(unboundArgumentsCollection, result, ref unboundArgumentsIndex)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 74114, 74213) || true) && (argument == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 74114, 74213);
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 74184, 74190);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 74114, 74213);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 76854, 76886);

                            bool
                            aParameterGetBound = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 76908, 77434) || true) && ((bindingType != BindingType.ParameterCompletion) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 76912, 77021) && ((validParameterSetFlags & defaultParameterSetFlag) != 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 76908, 77434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 77125, 77411);

                                aParameterGetBound =
                                f_1446_77175_77410(this, defaultParameterSetFlag, nextPositionalParameters, argument, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 76908, 77434);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 77458, 77944) || true) && (!aParameterGetBound && (DynAbs.Tracing.TraceSender.Expression_True(1446, 77462, 77529) && (bindingType == BindingType.ArgumentBinding)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 77458, 77944);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 77636, 77921);

                                aParameterGetBound =
                                f_1446_77686_77920(this, validParameterSetFlags, nextPositionalParameters, argument, false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 77458, 77944);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 77968, 78407) || true) && (!aParameterGetBound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 77968, 78407);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78100, 78384);

                                aParameterGetBound =
                                f_1446_78150_78383(this, validParameterSetFlags, nextPositionalParameters, argument, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 77968, 78407);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78431, 79040) || true) && (!aParameterGetBound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 78431, 79040);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78504, 78525);

                                f_1446_78504_78524(result, argument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 78431, 79040);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 78431, 79040);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78690, 79017) || true) && (validParameterSetFlags != _currentParameterSetFlag)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 78690, 79017);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78802, 78852);

                                    validParameterSetFlags = _currentParameterSetFlag;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 78882, 78990);

                                    f_1446_78882_78989(positionalParameterDictionary, validParameterSetFlags);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 78690, 79017);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 78431, 79040);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 73558, 79059);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 5502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 5502);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79088, 79117);

                        for (int
        index = unboundArgumentsIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79079, 79275) || true) && (index < f_1446_79127_79159(unboundArgumentsCollection))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79161, 79168)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 79079, 79275))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 79079, 79275);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79210, 79256);

                            f_1446_79210_79255(result, f_1446_79221_79254(unboundArgumentsCollection, index));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 197);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 72231, 79290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79306, 79320);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 71841, 79331);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_72172_72214()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 72172, 72214);
                    return return_v;
                }


                int
                f_1446_72256_72278(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 72256, 72278);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_72376_72428(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>((System.Collections.Generic.IEnumerable<System.Management.Automation.Language.AstParameterArgumentPair>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 72376, 72428);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                f_1446_72748_72853(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters, uint
                validParameterSetFlag)
                {
                    var return_v = ParameterBinderController.EvaluateUnboundPositionalParameters((System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>)unboundParameters, validParameterSetFlag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 72748, 72853);
                    return return_v;
                }


                int
                f_1446_73403_73438(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 73403, 73438);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1446_73666_73702(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 73666, 73702);
                    return return_v;
                }


                int
                f_1446_73748_73778(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 73748, 73778);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_73925_74089(System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                unboundArgumentsCollection, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                nonPositionalArguments, ref int
                unboundArgumentsIndex)
                {
                    var return_v = GetNextPositionalArgument(unboundArgumentsCollection, nonPositionalArguments, ref unboundArgumentsIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 73925, 74089);
                    return return_v;
                }


                bool
                f_1446_77175_77410(System.Management.Automation.Language.PseudoParameterBinder
                this_param, uint
                validParameterSetFlag, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.Language.AstParameterArgumentPair
                argument, bool
                typeConversion)
                {
                    var return_v = this_param.BindPseudoPositionalParameterInSet(validParameterSetFlag, nextPositionalParameters, argument, typeConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 77175, 77410);
                    return return_v;
                }


                bool
                f_1446_77686_77920(System.Management.Automation.Language.PseudoParameterBinder
                this_param, uint
                validParameterSetFlag, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.Language.AstParameterArgumentPair
                argument, bool
                typeConversion)
                {
                    var return_v = this_param.BindPseudoPositionalParameterInSet(validParameterSetFlag, nextPositionalParameters, argument, typeConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 77686, 77920);
                    return return_v;
                }


                bool
                f_1446_78150_78383(System.Management.Automation.Language.PseudoParameterBinder
                this_param, uint
                validParameterSetFlag, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.Language.AstParameterArgumentPair
                argument, bool
                typeConversion)
                {
                    var return_v = this_param.BindPseudoPositionalParameterInSet(validParameterSetFlag, nextPositionalParameters, argument, typeConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 78150, 78383);
                    return return_v;
                }


                int
                f_1446_78504_78524(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 78504, 78524);
                    return 0;
                }


                int
                f_1446_78882_78989(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                positionalParameterDictionary, uint
                validParameterSets)
                {
                    ParameterBinderController.UpdatePositionalDictionary(positionalParameterDictionary, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 78882, 78989);
                    return 0;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1446_73666_73702_I(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 73666, 73702);
                    return return_v;
                }


                int
                f_1446_79127_79159(System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 79127, 79159);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_79221_79254(System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 79221, 79254);
                    return return_v;
                }


                int
                f_1446_79210_79255(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 79210, 79255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 71841, 79331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 71841, 79331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindPseudoPositionalParameterInSet(
                    uint validParameterSetFlag,
                    Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> nextPositionalParameters,
                    AstParameterArgumentPair argument,
                    bool typeConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 79343, 82386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79649, 79680);

                bool
                bindingSuccessful = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79694, 79725);

                uint
                localParameterSetFlag = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79739, 82154);
                    foreach (PositionalCommandParameter parameter in f_1446_79788_79819_I(f_1446_79788_79819(nextPositionalParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 79739, 82154);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 79853, 82139);
                            foreach (ParameterSetSpecificMetadata parameterSetData in f_1446_79911_79937_I(f_1446_79911_79937(parameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 79853, 82139);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80054, 80262) || true) && ((validParameterSetFlag & f_1446_80083_80116(parameterSetData)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1446, 80058, 80180) && f_1446_80151_80180_M(!parameterSetData.IsInAllSets)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 80054, 80262);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80230, 80239);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 80054, 80262);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80286, 80306);

                                bool
                                result = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80328, 80386);

                                string
                                parameterName = f_1446_80351_80385(f_1446_80351_80380(f_1446_80351_80370(parameter)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80408, 80464);

                                Type
                                parameterType = f_1446_80429_80463(f_1446_80429_80458(f_1446_80429_80448(parameter)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80486, 80528);

                                Type
                                argumentType = f_1446_80506_80527(argument)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 80997, 81335) || true) && (argumentType == typeof(object))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 80997, 81335);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81058, 81092);

                                    bindingSuccessful = result = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 80997, 81335);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 80997, 81335);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81119, 81335) || true) && (f_1446_81123_81168(argumentType, parameterType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81119, 81335);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81195, 81229);

                                        bindingSuccessful = result = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81119, 81335);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81119, 81335);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81256, 81335) || true) && (typeConversion)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81256, 81335);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81301, 81335);

                                            bindingSuccessful = result = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81256, 81335);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81119, 81335);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 80997, 81335);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81359, 82120) || true) && (result)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81359, 82120);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81419, 81492);

                                    localParameterSetFlag |= f_1446_81444_81491(f_1446_81444_81473(f_1446_81444_81463(parameter)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81518, 81565);

                                    f_1446_81518_81564(_unboundParameters, f_1446_81544_81563(parameter));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81593, 81858) || true) && (!f_1446_81598_81641(_boundParameters, parameterName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81593, 81858);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81699, 81756);

                                        f_1446_81699_81755(_boundParameters, parameterName, f_1446_81735_81754(parameter));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81786, 81831);

                                        f_1446_81786_81830(_boundPositionalParameter, parameterName);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81593, 81858);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81886, 82063) || true) && (!f_1446_81891_81933(_boundArguments, parameterName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 81886, 82063);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 81991, 82036);

                                        f_1446_81991_82035(_boundArguments, parameterName, argument);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81886, 82063);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1446, 82091, 82097);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 81359, 82120);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 79853, 82139);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 2287);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 2287);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 79739, 82154);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 2416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 2416);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82216, 82336) || true) && (bindingSuccessful && (DynAbs.Tracing.TraceSender.Expression_True(1446, 82220, 82267) && localParameterSetFlag != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82216, 82336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82286, 82336);

                    _currentParameterSetFlag &= localParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82216, 82336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82350, 82375);

                return bindingSuccessful;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 79343, 82386);

                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1446_79788_79819(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 79788, 79819);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_79911_79937(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 79911, 79937);
                    return return_v;
                }


                uint
                f_1446_80083_80116(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80083, 80116);
                    return return_v;
                }


                bool
                f_1446_80151_80180_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80151, 80180);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_80351_80370(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80351, 80370);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_80351_80380(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80351, 80380);
                    return return_v;
                }


                string
                f_1446_80351_80385(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80351, 80385);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_80429_80448(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80429, 80448);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_80429_80458(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80429, 80458);
                    return return_v;
                }


                System.Type
                f_1446_80429_80463(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80429, 80463);
                    return return_v;
                }


                System.Type
                f_1446_80506_80527(System.Management.Automation.Language.AstParameterArgumentPair
                this_param)
                {
                    var return_v = this_param.ArgumentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 80506, 80527);
                    return return_v;
                }


                bool
                f_1446_81123_81168(System.Type
                argType, System.Type
                paramType)
                {
                    var return_v = IsTypeEquivalent(argType, paramType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81123, 81168);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_81444_81463(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 81444, 81463);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_81444_81473(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 81444, 81473);
                    return return_v;
                }


                uint
                f_1446_81444_81491(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 81444, 81491);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_81544_81563(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 81544, 81563);
                    return return_v;
                }


                bool
                f_1446_81518_81564(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81518, 81564);
                    return return_v;
                }


                bool
                f_1446_81598_81641(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81598, 81641);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1446_81735_81754(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 81735, 81754);
                    return return_v;
                }


                int
                f_1446_81699_81755(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81699, 81755);
                    return 0;
                }


                int
                f_1446_81786_81830(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81786, 81830);
                    return 0;
                }


                bool
                f_1446_81891_81933(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81891, 81933);
                    return return_v;
                }


                int
                f_1446_81991_82035(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, System.Management.Automation.Language.AstParameterArgumentPair
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 81991, 82035);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_79911_79937_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 79911, 79937);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1446_79788_79819_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 79788, 79819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 79343, 82386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 79343, 82386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTypeEquivalent(Type argType, Type paramType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 82398, 83053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82489, 82509);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82523, 83012) || true) && (argType == paramType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82523, 83012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82581, 82595);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82523, 83012);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82523, 83012);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82629, 83012) || true) && (f_1446_82633_82664(argType, paramType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82629, 83012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82698, 82712);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82629, 83012);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82629, 83012);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82746, 83012) || true) && (argType == f_1446_82761_82787(paramType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82746, 83012);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82821, 82835);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82746, 83012);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82746, 83012);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82869, 83012) || true) && (f_1446_82873_82908(argType, typeof(Array)) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 82873, 82949) && f_1446_82912_82949(paramType, typeof(Array))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 82869, 83012);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 82983, 82997);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82869, 83012);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82746, 83012);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82629, 83012);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 82523, 83012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83028, 83042);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 82398, 83053);

                bool
                f_1446_82633_82664(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 82633, 82664);
                    return return_v;
                }


                System.Type?
                f_1446_82761_82787(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 82761, 82787);
                    return return_v;
                }


                bool
                f_1446_82873_82908(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 82873, 82908);
                    return return_v;
                }


                bool
                f_1446_82912_82949(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 82912, 82949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 82398, 83053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 82398, 83053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AstParameterArgumentPair GetNextPositionalArgument(
                    List<AstParameterArgumentPair> unboundArgumentsCollection,
                    Collection<AstParameterArgumentPair> nonPositionalArguments,
                    ref int unboundArgumentsIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1446, 83065, 84014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83506, 83545);

                AstParameterArgumentPair
                result = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83559, 83973) || true) && (unboundArgumentsIndex < f_1446_83590_83622(unboundArgumentsCollection))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 83559, 83973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83656, 83744);

                        AstParameterArgumentPair
                        argument = f_1446_83692_83743(unboundArgumentsCollection, unboundArgumentsIndex++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83762, 83901) || true) && (f_1446_83766_83794_M(!argument.ParameterSpecified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 83762, 83901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83836, 83854);

                            result = argument;
                            DynAbs.Tracing.TraceSender.TraceBreak(1446, 83876, 83882);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 83762, 83901);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83921, 83958);

                        f_1446_83921_83957(
                                        nonPositionalArguments, argument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 83559, 83973);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 83559, 83973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 83559, 83973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 83989, 84003);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1446, 83065, 84014);

                int
                f_1446_83590_83622(System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 83590, 83622);
                    return return_v;
                }


                System.Management.Automation.Language.AstParameterArgumentPair
                f_1446_83692_83743(System.Collections.Generic.List<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 83692, 83743);
                    return return_v;
                }


                bool
                f_1446_83766_83794_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 83766, 83794);
                    return return_v;
                }


                int
                f_1446_83921_83957(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, System.Management.Automation.Language.AstParameterArgumentPair
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 83921, 83957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 83065, 84014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 83065, 84014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<AstParameterArgumentPair> BindRemainingParameters(Collection<AstParameterArgumentPair> unboundArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 84026, 86760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84174, 84194);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84208, 84239);

                uint
                localParameterSetFlag = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84255, 84351) || true) && (!_bindingEffective || (DynAbs.Tracing.TraceSender.Expression_False(1446, 84259, 84308) || f_1446_84281_84303(unboundArguments) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 84255, 84351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84327, 84351);

                    return unboundArguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 84255, 84351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84367, 84435);

                Collection<ExpressionAst>
                argList = f_1446_84403_84434()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84449, 84868);
                    foreach (AstParameterArgumentPair arg in f_1446_84490_84506_I(unboundArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 84449, 84868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84540, 84573);

                        AstPair
                        realArg = arg as AstPair
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84591, 84790);

                        f_1446_84591_84789(realArg != null && (DynAbs.Tracing.TraceSender.Expression_True(1446, 84610, 84656) && f_1446_84629_84656_M(!realArg.ParameterSpecified)) && (DynAbs.Tracing.TraceSender.Expression_True(1446, 84610, 84698) && f_1446_84660_84698_M(!realArg.ArgumentIsCommandParameterAst)), "all unbound arguments left should be pure ExpressionAst arguments");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84808, 84853);

                        f_1446_84808_84852(argList, f_1446_84835_84851(realArg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 84449, 84868);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 420);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84884, 84973);

                var
                unboundParametersCopy = f_1446_84912_84972(_unboundParameters)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 84989, 86584);
                    foreach (MergedCompiledCommandParameter unboundParam in f_1446_85045_85066_I(unboundParametersCopy))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 84989, 86584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85100, 85278);

                        bool
                        isInParameterSet = (f_1446_85125_85165(f_1446_85125_85147(unboundParam)) & _currentParameterSetFlag) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1446, 85124, 85277) || f_1446_85243_85277(f_1446_85243_85265(unboundParam)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85296, 85387) || true) && (!isInParameterSet)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 85296, 85387);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85359, 85368);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 85296, 85387);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85407, 85517);

                        var
                        parameterSetDataCollection = f_1446_85440_85516(f_1446_85440_85462(unboundParam), _currentParameterSetFlag)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85535, 86569);
                            foreach (ParameterSetSpecificMetadata parameterSetData in f_1446_85593_85619_I(parameterSetDataCollection))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 85535, 86569);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85661, 85792) || true) && (f_1446_85665_85710_M(!parameterSetData.ValueFromRemainingArguments))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 85661, 85792);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85760, 85769);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 85661, 85792);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85816, 85882);

                                localParameterSetFlag |= f_1446_85841_85881(f_1446_85841_85863(unboundParam));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85904, 85955);

                                string
                                parameterName = f_1446_85927_85954(f_1446_85927_85949(unboundParam))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 85977, 86017);

                                f_1446_85977_86016(_unboundParameters, unboundParam);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86041, 86212) || true) && (!f_1446_86046_86089(_boundParameters, parameterName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 86041, 86212);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86139, 86189);

                                    f_1446_86139_86188(_boundParameters, parameterName, unboundParam);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 86041, 86212);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86236, 86484) || true) && (!f_1446_86241_86283(_boundArguments, parameterName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 86236, 86484);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86333, 86410);

                                    f_1446_86333_86409(_boundArguments, parameterName, f_1446_86368_86408(parameterName, argList));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86436, 86461);

                                    f_1446_86436_86460(unboundArguments);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 86236, 86484);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86508, 86522);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 86544, 86550);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 85535, 86569);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 1035);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 1035);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 84989, 86584);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 1596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 1596);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86600, 86709) || true) && (result && (DynAbs.Tracing.TraceSender.Expression_True(1446, 86604, 86640) && localParameterSetFlag != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 86600, 86709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86659, 86709);

                    _currentParameterSetFlag &= localParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 86600, 86709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86725, 86749);

                return unboundArguments;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 84026, 86760);

                int
                f_1446_84281_84303(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 84281, 84303);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.ExpressionAst>
                f_1446_84403_84434()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Language.ExpressionAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 84403, 84434);
                    return return_v;
                }


                bool
                f_1446_84629_84656_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 84629, 84656);
                    return return_v;
                }


                bool
                f_1446_84660_84698_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 84660, 84698);
                    return return_v;
                }


                int
                f_1446_84591_84789(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 84591, 84789);
                    return 0;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1446_84835_84851(System.Management.Automation.Language.AstPair
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 84835, 84851);
                    return return_v;
                }


                int
                f_1446_84808_84852(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.ExpressionAst>
                this_param, System.Management.Automation.Language.CommandElementAst
                item)
                {
                    this_param.Add((System.Management.Automation.Language.ExpressionAst)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 84808, 84852);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                f_1446_84490_84506_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 84490, 84506);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_84912_84972(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 84912, 84972);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_85125_85147(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85125, 85147);
                    return return_v;
                }


                uint
                f_1446_85125_85165(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85125, 85165);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_85243_85265(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85243, 85265);
                    return return_v;
                }


                bool
                f_1446_85243_85277(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85243, 85277);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_85440_85462(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85440, 85462);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_85440_85516(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 85440, 85516);
                    return return_v;
                }


                bool
                f_1446_85665_85710_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85665, 85710);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_85841_85863(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85841, 85863);
                    return return_v;
                }


                uint
                f_1446_85841_85881(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85841, 85881);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_85927_85949(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85927, 85949);
                    return return_v;
                }


                string
                f_1446_85927_85954(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 85927, 85954);
                    return return_v;
                }


                bool
                f_1446_85977_86016(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 85977, 86016);
                    return return_v;
                }


                bool
                f_1446_86046_86089(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86046, 86089);
                    return return_v;
                }


                int
                f_1446_86139_86188(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86139, 86188);
                    return 0;
                }


                bool
                f_1446_86241_86283(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86241, 86283);
                    return return_v;
                }


                System.Management.Automation.Language.AstArrayPair
                f_1446_86368_86408(string
                parameterName, System.Collections.ObjectModel.Collection<System.Management.Automation.Language.ExpressionAst>
                arguments)
                {
                    var return_v = new System.Management.Automation.Language.AstArrayPair(parameterName, (System.Collections.Generic.ICollection<System.Management.Automation.Language.ExpressionAst>)arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86368, 86408);
                    return return_v;
                }


                int
                f_1446_86333_86409(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, System.Management.Automation.Language.AstArrayPair
                value)
                {
                    this_param.Add(key, (System.Management.Automation.Language.AstParameterArgumentPair)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86333, 86409);
                    return 0;
                }


                int
                f_1446_86436_86460(System.Collections.ObjectModel.Collection<System.Management.Automation.Language.AstParameterArgumentPair>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 86436, 86460);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_85593_85619_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 85593, 85619);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_85045_85066_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 85045, 85066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 84026, 86760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 84026, 86760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BindPipelineParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1446, 86772, 89042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86834, 86854);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86868, 86899);

                uint
                localParameterSetFlag = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 86915, 87022) || true) && (!_bindingEffective || (DynAbs.Tracing.TraceSender.Expression_False(1446, 86919, 86966) || !_isPipelineInputExpected))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 86915, 87022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87000, 87007);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 86915, 87022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87038, 87127);

                var
                unboundParametersCopy = f_1446_87066_87126(_unboundParameters)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87143, 88906);
                    foreach (MergedCompiledCommandParameter unboundParam in f_1446_87199_87220_I(unboundParametersCopy))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 87143, 88906);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87254, 87351) || true) && (f_1446_87258_87319_M(!f_1446_87259_87281(unboundParam).IsPipelineParameterInSomeParameterSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 87254, 87351);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87342, 87351);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 87254, 87351);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87371, 87549);

                        bool
                        isInParameterSet = (f_1446_87396_87436(f_1446_87396_87418(unboundParam)) & _currentParameterSetFlag) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1446, 87395, 87548) || f_1446_87514_87548(f_1446_87514_87536(unboundParam)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87567, 87658) || true) && (!isInParameterSet)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 87567, 87658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87630, 87639);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 87567, 87658);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87678, 87788);

                        var
                        parameterSetDataCollection = f_1446_87711_87787(f_1446_87711_87733(unboundParam), _currentParameterSetFlag)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 87806, 88891);
                            foreach (ParameterSetSpecificMetadata parameterSetData in f_1446_87864_87890_I(parameterSetDataCollection))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 87806, 88891);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88031, 88152) || true) && (f_1446_88035_88070_M(!parameterSetData.ValueFromPipeline))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 88031, 88152);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88120, 88129);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 88031, 88152);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88176, 88242);

                                localParameterSetFlag |= f_1446_88201_88241(f_1446_88201_88223(unboundParam));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88264, 88315);

                                string
                                parameterName = f_1446_88287_88314(f_1446_88287_88309(unboundParam))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88337, 88377);

                                f_1446_88337_88376(_unboundParameters, unboundParam);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88401, 88572) || true) && (!f_1446_88406_88449(_boundParameters, parameterName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 88401, 88572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88499, 88549);

                                    f_1446_88499_88548(_boundParameters, parameterName, unboundParam);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 88401, 88572);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88596, 88806) || true) && (!f_1446_88601_88643(_boundArguments, parameterName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 88596, 88806);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88693, 88783);

                                    f_1446_88693_88782(_boundArguments, parameterName, f_1446_88728_88781(parameterName, _pipelineInputType));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 88596, 88806);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88830, 88844);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1446, 88866, 88872);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 87806, 88891);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 1086);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 1086);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 87143, 88906);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1446, 1, 1764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1446, 1, 1764);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88922, 89031) || true) && (result && (DynAbs.Tracing.TraceSender.Expression_True(1446, 88926, 88962) && localParameterSetFlag != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1446, 88922, 89031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 88981, 89031);

                    _currentParameterSetFlag &= localParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1446, 88922, 89031);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1446, 86772, 89042);

                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_87066_87126(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 87066, 87126);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_87259_87281(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87259, 87281);
                    return return_v;
                }


                bool
                f_1446_87258_87319_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87258, 87319);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_87396_87418(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87396, 87418);
                    return return_v;
                }


                uint
                f_1446_87396_87436(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87396, 87436);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_87514_87536(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87514, 87536);
                    return return_v;
                }


                bool
                f_1446_87514_87548(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87514, 87548);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_87711_87733(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 87711, 87733);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_87711_87787(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 87711, 87787);
                    return return_v;
                }


                bool
                f_1446_88035_88070_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 88035, 88070);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_88201_88223(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 88201, 88223);
                    return return_v;
                }


                uint
                f_1446_88201_88241(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 88201, 88241);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1446_88287_88309(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 88287, 88309);
                    return return_v;
                }


                string
                f_1446_88287_88314(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1446, 88287, 88314);
                    return return_v;
                }


                bool
                f_1446_88337_88376(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88337, 88376);
                    return return_v;
                }


                bool
                f_1446_88406_88449(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88406, 88449);
                    return return_v;
                }


                int
                f_1446_88499_88548(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88499, 88548);
                    return 0;
                }


                bool
                f_1446_88601_88643(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88601, 88643);
                    return return_v;
                }


                System.Management.Automation.Language.PipeObjectPair
                f_1446_88728_88781(string
                parameterName, System.Type
                pipeObjType)
                {
                    var return_v = new System.Management.Automation.Language.PipeObjectPair(parameterName, pipeObjType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88728, 88781);
                    return return_v;
                }


                int
                f_1446_88693_88782(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.AstParameterArgumentPair>
                this_param, string
                key, System.Management.Automation.Language.PipeObjectPair
                value)
                {
                    this_param.Add(key, (System.Management.Automation.Language.AstParameterArgumentPair)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 88693, 88782);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1446_87864_87890_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 87864, 87890);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1446_87199_87220_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1446, 87199, 87220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1446, 86772, 89042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 86772, 89042);
            }
        }

        public PseudoParameterBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1446, 37534, 89049);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46366, 46378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46449, 46460);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46517, 46533);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46594, 46611);
            this._function = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46637, 46656);
            this._commandName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46687, 46706);
            this._commandInfo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46730, 46770);
            this._currentParameterSetFlag = uint.MaxValue;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46794, 46822);
            this._defaultParameterSetFlag = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46872, 46898);
            this._bindableParameters = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 46968, 46984);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47048, 47063);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47119, 47129);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47167, 47192);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47248, 47266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47333, 47358);
            this._pipelineInputType = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47382, 47406);
            this._bindingEffective = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47430, 47462);
            this._isPipelineInputExpected = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47513, 47532);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47583, 47603);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47659, 47679);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1446, 47757, 47775);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1446, 37534, 89049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 37534, 89049);
        }


        static PseudoParameterBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1446, 37534, 89049);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1446, 37534, 89049);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1446, 37534, 89049);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1446, 37534, 89049);
    }
}
