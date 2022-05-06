// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Management.Automation.Language;

namespace System.Management.Automation
{
    [DebuggerDisplay("{ParameterName}")]
    internal sealed class CommandParameterInternal
    {
        private class Parameter
        {
            internal Ast ast;

            internal string parameterName;

            internal string parameterText;

            public Parameter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1249, 414, 578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 475, 478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 509, 522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 553, 566);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1249, 414, 578);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 414, 578);
            }


            static Parameter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1249, 414, 578);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1249, 414, 578);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 414, 578);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1249, 414, 578);
        }
        private class Argument
        {
            internal Ast ast;

            internal object value;

            internal bool splatted;

            public Argument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1249, 590, 738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 650, 653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 684, 689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 718, 726);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1249, 590, 738);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 590, 738);
            }


            static Argument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1249, 590, 738);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1249, 590, 738);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 590, 738);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1249, 590, 738);
        }

        private Parameter _parameter;

        private Argument _argument;

        private bool _spaceAfterParameter;

        internal bool SpaceAfterParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 908, 944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 914, 942);

                    return _spaceAfterParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 908, 944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 872, 946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 872, 946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ParameterNameSpecified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 997, 1031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1003, 1029);

                    return _parameter != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 997, 1031);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 958, 1033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 958, 1033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ArgumentSpecified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 1079, 1112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1085, 1110);

                    return _argument != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 1079, 1112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 1045, 1114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 1045, 1114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ParameterAndArgumentSpecified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 1172, 1231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1178, 1229);

                    return f_1249_1185_1207() && (DynAbs.Tracing.TraceSender.Expression_True(1249, 1185, 1228) && f_1249_1211_1228());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 1172, 1231);

                    bool
                    f_1249_1185_1207()
                    {
                        var return_v = ParameterNameSpecified;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 1185, 1207);
                        return return_v;
                    }


                    bool
                    f_1249_1211_1228()
                    {
                        var return_v = ArgumentSpecified;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 1211, 1228);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 1126, 1233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 1126, 1233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string ParameterName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 1455, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1491, 1585);

                    f_1249_1491_1584(f_1249_1510_1532(), "Caller must verify parameter name was specified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1603, 1635);

                    return _parameter.parameterName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 1455, 1650);

                    bool
                    f_1249_1510_1532()
                    {
                        var return_v = ParameterNameSpecified;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 1510, 1532);
                        return return_v;
                    }


                    int
                    f_1249_1491_1584(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1249, 1491, 1584);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 1401, 1873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 1401, 1873);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 1666, 1862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1702, 1796);

                    f_1249_1702_1795(f_1249_1721_1743(), "Caller must verify parameter name was specified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 1814, 1847);

                    _parameter.parameterName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 1666, 1862);

                    bool
                    f_1249_1721_1743()
                    {
                        var return_v = ParameterNameSpecified;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 1721, 1743);
                        return return_v;
                    }


                    int
                    f_1249_1702_1795(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1249, 1702, 1795);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 1401, 1873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 1401, 1873);
                }
            }
        }

        internal string ParameterText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 2111, 2306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 2147, 2241);

                    f_1249_2147_2240(f_1249_2166_2188(), "Caller must verify parameter name was specified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 2259, 2291);

                    return _parameter.parameterText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 2111, 2306);

                    bool
                    f_1249_2166_2188()
                    {
                        var return_v = ParameterNameSpecified;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 2166, 2188);
                        return return_v;
                    }


                    int
                    f_1249_2147_2240(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1249, 2147, 2240);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 2057, 2317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 2057, 2317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Ast ParameterAst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 2491, 2509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 2494, 2509);
                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_parameter, 1249, 2494, 2509)?.ast;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 2491, 2509);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 2437, 2521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 2437, 2521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IScriptExtent ParameterExtent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 2711, 2767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 2714, 2767);
                    return f_1249_2714_2734_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1249_2714_2726(), 1249, 2714, 2734)?.Extent) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IScriptExtent>(1249, 2714, 2767) ?? f_1249_2738_2767());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 2711, 2767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 2644, 2779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 2644, 2779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Ast ArgumentAst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 2960, 2977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 2963, 2977);
                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_argument, 1249, 2963, 2977)?.ast;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 2960, 2977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 2907, 2989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 2907, 2989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IScriptExtent ArgumentExtent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 3186, 3241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 3189, 3241);
                    return f_1249_3189_3208_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1249_3189_3200(), 1249, 3189, 3208)?.Extent) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IScriptExtent>(1249, 3189, 3241) ?? f_1249_3212_3241());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 3186, 3241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 3120, 3253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 3120, 3253);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal object ArgumentValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 3471, 3547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 3477, 3545);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1249, 3484, 3501) || ((_argument != null && DynAbs.Tracing.TraceSender.Conditional_F2(1249, 3504, 3519)) || DynAbs.Tracing.TraceSender.Conditional_F3(1249, 3522, 3544))) ? _argument.value : f_1249_3522_3544();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 3471, 3547);

                    object
                    f_1249_3522_3544()
                    {
                        var return_v = UnboundParameter.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 3522, 3544);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 3417, 3558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 3417, 3558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ArgumentSplatted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 3768, 3830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 3774, 3828);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1249, 3781, 3798) || ((_argument != null && DynAbs.Tracing.TraceSender.Conditional_F2(1249, 3801, 3819)) || DynAbs.Tracing.TraceSender.Conditional_F3(1249, 3822, 3827))) ? _argument.splatted : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 3768, 3830);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 3713, 3841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 3713, 3841);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetArgumentValue(Ast ast, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 3945, 4205);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4023, 4120) || true) && (_argument == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1249, 4023, 4120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4078, 4105);

                    _argument = f_1249_4090_4104();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1249, 4023, 4120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4136, 4160);

                _argument.value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4174, 4194);

                _argument.ast = ast;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 3945, 4205);

                System.Management.Automation.CommandParameterInternal.Argument
                f_1249_4090_4104()
                {
                    var return_v = new System.Management.Automation.CommandParameterInternal.Argument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1249, 4090, 4104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 3945, 4205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 3945, 4205);
            }
        }

        internal IScriptExtent ErrorExtent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 4565, 4745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4601, 4632);

                    var
                    argExtent = f_1249_4617_4631()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 4650, 4730);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1249, 4657, 4699) || ((argExtent != f_1249_4670_4699() && DynAbs.Tracing.TraceSender.Conditional_F2(1249, 4702, 4711)) || DynAbs.Tracing.TraceSender.Conditional_F3(1249, 4714, 4729))) ? argExtent : f_1249_4714_4729();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 4565, 4745);

                    System.Management.Automation.Language.IScriptExtent
                    f_1249_4617_4631()
                    {
                        var return_v = ArgumentExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 4617, 4631);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1249_4670_4699()
                    {
                        var return_v = PositionUtilities.EmptyExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 4670, 4699);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1249_4714_4729()
                    {
                        var return_v = ParameterExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 4714, 4729);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 4506, 4756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 4506, 4756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static CommandParameterInternal CreateParameter(
                    string parameterName,
                    string parameterText,
                    Ast ast = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1249, 5190, 5596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 5371, 5585);

                return new CommandParameterInternal
                {
                    _parameter =
                                           DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new Parameter { ast = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => ast, 1249, 5480, 5569), parameterName = parameterName, parameterText = parameterText }, 1249, 5378, 5584)
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1249, 5190, 5596);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 5190, 5596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 5190, 5596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandParameterInternal CreateArgument(
                    object value,
                    Ast ast = null,
                    bool splatted = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1249, 5963, 6403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 6136, 6392);

                return new CommandParameterInternal
                {
                    _argument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new Argument
                    {
                        value = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => value, 1249, 6216, 6376),
                        ast = ast,
                        splatted = splatted
                    }, 1249, 6143, 6391)
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1249, 5963, 6403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 5963, 6403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 5963, 6403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandParameterInternal CreateParameterWithArgument(
                    Ast parameterAst,
                    string parameterName,
                    string parameterText,
                    Ast argumentAst,
                    object value,
                    bool spaceAfterParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1249, 7587, 8225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 7878, 8214);

                return new CommandParameterInternal
                {
                    _parameter = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new Parameter { ast = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => parameterAst, 1249, 7959, 8057), parameterName = parameterName, parameterText = parameterText }, 1249, 7885, 8213),
                    _argument = new Argument { ast = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => argumentAst, 1249, 8088, 8137), value = value },
                    _spaceAfterParameter = spaceAfterParameter
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1249, 7587, 8225);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 7587, 8225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 7587, 8225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDashQuestion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1249, 8264, 8427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 8319, 8416);

                return f_1249_8326_8348() && (DynAbs.Tracing.TraceSender.Expression_True(1249, 8326, 8415) && (f_1249_8353_8414(f_1249_8353_8366(), "?", StringComparison.OrdinalIgnoreCase)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1249, 8264, 8427);

                bool
                f_1249_8326_8348()
                {
                    var return_v = ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 8326, 8348);
                    return return_v;
                }


                string
                f_1249_8353_8366()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 8353, 8366);
                    return return_v;
                }


                bool
                f_1249_8353_8414(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1249, 8353, 8414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1249, 8264, 8427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 8264, 8427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CommandParameterInternal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1249, 309, 8434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 768, 778);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 806, 815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1249, 839, 859);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1249, 309, 8434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 309, 8434);
        }


        static CommandParameterInternal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1249, 309, 8434);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1249, 309, 8434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1249, 309, 8434);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1249, 309, 8434);

        System.Management.Automation.Language.Ast
        f_1249_2714_2726()
        {
            var return_v = ParameterAst;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 2714, 2726);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1249_2714_2734_M(System.Management.Automation.Language.IScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 2714, 2734);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1249_2738_2767()
        {
            var return_v = PositionUtilities.EmptyExtent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 2738, 2767);
            return return_v;
        }


        System.Management.Automation.Language.Ast
        f_1249_3189_3200()
        {
            var return_v = ArgumentAst;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 3189, 3200);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1249_3189_3208_M(System.Management.Automation.Language.IScriptExtent
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 3189, 3208);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1249_3212_3241()
        {
            var return_v = PositionUtilities.EmptyExtent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1249, 3212, 3241);
            return return_v;
        }

    }
}
