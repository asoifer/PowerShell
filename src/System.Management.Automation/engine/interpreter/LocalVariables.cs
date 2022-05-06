/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System.Globalization;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LocalVariable
    {
        private const int
        IsBoxedFlag = 1
        ;

        private const int
        InClosureFlag = 2
        ;

        public readonly int Index;

        private int _flags;

        public bool IsBoxed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 1252, 1295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1258, 1293);

                    return (_flags & IsBoxedFlag) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 1252, 1295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 1208, 1570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 1208, 1570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 1311, 1559);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1347, 1544) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 1347, 1544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1398, 1420);

                        _flags |= IsBoxedFlag;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 1347, 1544);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 1347, 1544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1502, 1525);

                        _flags &= ~IsBoxedFlag;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 1347, 1544);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 1311, 1559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 1208, 1570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 1208, 1570);
                }
            }
        }

        public bool InClosure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 1628, 1673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1634, 1671);

                    return (_flags & InClosureFlag) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 1628, 1673);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 1582, 1684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 1582, 1684);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool InClosureOrBoxed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 1749, 1784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1755, 1782);

                    return f_1513_1762_1771() | f_1513_1774_1781();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 1749, 1784);

                    bool
                    f_1513_1762_1771()
                    {
                        var return_v = InClosure;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 1762, 1771);
                        return return_v;
                    }


                    bool
                    f_1513_1774_1781()
                    {
                        var return_v = IsBoxed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 1774, 1781);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 1696, 1795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 1696, 1795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LocalVariable(int index, bool closure, bool boxed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1513, 1807, 1997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1161, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1189, 1195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1891, 1905);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1919, 1986);

                _flags = ((DynAbs.Tracing.TraceSender.Conditional_F1(1513, 1929, 1936) || ((closure && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 1939, 1952)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 1955, 1956))) ? InClosureFlag : 0) | ((DynAbs.Tracing.TraceSender.Conditional_F1(1513, 1961, 1966) || ((boxed && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 1969, 1980)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 1983, 1984))) ? IsBoxedFlag : 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1513, 1807, 1997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 1807, 1997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 1807, 1997);
            }
        }

        internal Expression LoadFromArray(Expression frameData, Expression closure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 2009, 2318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2109, 2213);

                Expression
                result = f_1513_2129_2212((DynAbs.Tracing.TraceSender.Conditional_F1(1513, 2152, 2161) || ((f_1513_2152_2161() && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 2164, 2171)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 2174, 2183))) ? closure : frameData, f_1513_2185_2211(Index))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2227, 2307);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1513, 2234, 2241) || ((f_1513_2234_2241() && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 2244, 2297)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 2300, 2306))) ? f_1513_2244_2297(result, typeof(StrongBox<object>)) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 2009, 2318);

                bool
                f_1513_2152_2161()
                {
                    var return_v = InClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 2152, 2161);
                    return return_v;
                }


                System.Linq.Expressions.ConstantExpression
                f_1513_2185_2211(int
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 2185, 2211);
                    return return_v;
                }


                System.Linq.Expressions.IndexExpression
                f_1513_2129_2212(System.Linq.Expressions.Expression
                array, params System.Linq.Expressions.Expression[]
                indexes)
                {
                    var return_v = Expression.ArrayAccess(array, indexes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 2129, 2212);
                    return return_v;
                }


                bool
                f_1513_2234_2241()
                {
                    var return_v = IsBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 2234, 2241);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1513_2244_2297(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 2244, 2297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 2009, 2318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2009, 2318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 2330, 2532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2388, 2521);

                return f_1513_2395_2520(f_1513_2409_2437(), "{0}: {1} {2}", Index, (DynAbs.Tracing.TraceSender.Conditional_F1(1513, 2462, 2469) || ((f_1513_2462_2469() && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 2472, 2479)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 2482, 2486))) ? "boxed" : null, (DynAbs.Tracing.TraceSender.Conditional_F1(1513, 2488, 2497) || ((f_1513_2488_2497() && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 2500, 2512)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 2515, 2519))) ? "in closure" : null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 2330, 2532);

                System.Globalization.CultureInfo
                f_1513_2409_2437()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 2409, 2437);
                    return return_v;
                }


                bool
                f_1513_2462_2469()
                {
                    var return_v = IsBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 2462, 2469);
                    return return_v;
                }


                bool
                f_1513_2488_2497()
                {
                    var return_v = InClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 2488, 2497);
                    return return_v;
                }


                string
                f_1513_2395_2520(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 2395, 2520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 2330, 2532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2330, 2532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1513, 997, 2539);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1067, 1082);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 1111, 1128);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1513, 997, 2539);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 997, 2539);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1513, 997, 2539);
    }

    internal struct LocalDefinition
    {

        private readonly int _index;

        private readonly ParameterExpression _parameter;

        internal LocalDefinition(int localIndex, ParameterExpression parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1513, 2693, 2857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2789, 2809);

                _index = localIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2823, 2846);

                _parameter = parameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1513, 2693, 2857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 2693, 2857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2693, 2857);
            }
        }

        public int Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 2910, 2975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 2946, 2960);

                    return _index;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 2910, 2975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 2869, 2986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2869, 2986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ParameterExpression Parameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 3059, 3128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3095, 3113);

                    return _parameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 3059, 3128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 2998, 3139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2998, 3139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 3151, 3453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3215, 3413) || true) && (obj is LocalDefinition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 3215, 3413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3275, 3320);

                    LocalDefinition
                    other = (LocalDefinition)obj
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3338, 3398);

                    return other.Index == Index && (DynAbs.Tracing.TraceSender.Expression_True(1513, 3345, 3397) && other.Parameter == Parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 3215, 3413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3429, 3442);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 3151, 3453);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 3151, 3453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 3151, 3453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 3465, 3685);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3523, 3603) || true) && (_parameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 3523, 3603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3579, 3588);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 3523, 3603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3619, 3674);

                return f_1513_3626_3650(_parameter) ^ f_1513_3653_3673(_index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 3465, 3685);

                int
                f_1513_3626_3650(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 3626, 3650);
                    return return_v;
                }


                int
                f_1513_3653_3673(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 3653, 3673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 3465, 3685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 3465, 3685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(LocalDefinition self, LocalDefinition other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1513, 3697, 3878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3797, 3867);

                return self.Index == other.Index && (DynAbs.Tracing.TraceSender.Expression_True(1513, 3804, 3866) && self.Parameter == other.Parameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1513, 3697, 3878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 3697, 3878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 3697, 3878);
            }
        }

        public static bool operator !=(LocalDefinition self, LocalDefinition other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1513, 3890, 4071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 3990, 4060);

                return self.Index != other.Index || (DynAbs.Tracing.TraceSender.Expression_False(1513, 3997, 4059) || self.Parameter != other.Parameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1513, 3890, 4071);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 3890, 4071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 3890, 4071);
            }
        }
        static LocalDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1513, 2547, 4078);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1513, 2547, 4078);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 2547, 4078);
        }
    }
    internal sealed class LocalVariables
    {
        private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables;

        private Dictionary<ParameterExpression, LocalVariable> _closureVariables;

        private int _localCount, _maxLocalCount;

        internal LocalVariables()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1513, 4446, 4493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4218, 4298);
                this._variables = f_1513_4231_4298();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4364, 4381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4406, 4417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4419, 4433);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1513, 4446, 4493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 4446, 4493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 4446, 4493);
            }
        }

        public LocalDefinition DefineLocal(ParameterExpression variable, int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 4505, 5580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4763, 4833);

                LocalVariable
                result = f_1513_4786_4832(_localCount++, false, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4847, 4909);

                _maxLocalCount = f_1513_4864_4908(_localCount, _maxLocalCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4925, 4958);

                VariableScope
                existing
                = default(VariableScope),
                newScope
                = default(VariableScope);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 4972, 5456) || true) && (f_1513_4976_5022(_variables, variable, out existing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 4972, 5456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5056, 5110);

                    newScope = f_1513_5067_5109(result, start, existing);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5128, 5270) || true) && (existing.ChildScopes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 5128, 5270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5202, 5251);

                        existing.ChildScopes = f_1513_5225_5250();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 5128, 5270);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5290, 5325);

                    f_1513_5290_5324(
                                    existing.ChildScopes, newScope);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 4972, 5456);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 4972, 5456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5391, 5441);

                    newScope = f_1513_5402_5440(result, start, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 4972, 5456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5472, 5504);

                _variables[variable] = newScope;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5518, 5569);

                return f_1513_5525_5568(result.Index, variable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 4505, 5580);

                System.Management.Automation.Interpreter.LocalVariable
                f_1513_4786_4832(int
                index, bool
                closure, bool
                boxed)
                {
                    var return_v = new System.Management.Automation.Interpreter.LocalVariable(index, closure, boxed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 4786, 4832);
                    return return_v;
                }


                int
                f_1513_4864_4908(int
                val1, int
                val2)
                {
                    var return_v = System.Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 4864, 4908);
                    return return_v;
                }


                bool
                f_1513_4976_5022(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariables.VariableScope
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 4976, 5022);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_5067_5109(System.Management.Automation.Interpreter.LocalVariable
                variable, int
                start, System.Management.Automation.Interpreter.LocalVariables.VariableScope
                parent)
                {
                    var return_v = new System.Management.Automation.Interpreter.LocalVariables.VariableScope(variable, start, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5067, 5109);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                f_1513_5225_5250()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.LocalVariables.VariableScope>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5225, 5250);
                    return return_v;
                }


                int
                f_1513_5290_5324(System.Collections.Generic.List<System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Management.Automation.Interpreter.LocalVariables.VariableScope
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5290, 5324);
                    return 0;
                }


                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_5402_5440(System.Management.Automation.Interpreter.LocalVariable
                variable, int
                start, System.Management.Automation.Interpreter.LocalVariables.VariableScope
                parent)
                {
                    var return_v = new System.Management.Automation.Interpreter.LocalVariables.VariableScope(variable, start, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5402, 5440);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1513_5525_5568(int
                localIndex, System.Linq.Expressions.ParameterExpression
                parameter)
                {
                    var return_v = new System.Management.Automation.Interpreter.LocalDefinition(localIndex, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5525, 5568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 4505, 5580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 4505, 5580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void UndefineLocal(LocalDefinition definition, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 5592, 6037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5679, 5724);

                var
                scope = f_1513_5691_5723(_variables, definition.Parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5738, 5755);

                scope.Stop = end;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5769, 5996) || true) && (scope.Parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 5769, 5996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5827, 5875);

                    _variables[definition.Parameter] = scope.Parent;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 5769, 5996);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 5769, 5996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 5941, 5981);

                    f_1513_5941_5980(_variables, definition.Parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 5769, 5996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6012, 6026);

                _localCount--;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 5592, 6037);

                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_5691_5723(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 5691, 5723);
                    return return_v;
                }


                bool
                f_1513_5941_5980(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 5941, 5980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 5592, 6037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 5592, 6037);
            }
        }

        internal void Box(ParameterExpression variable, InstructionList instructions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 6049, 6930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6151, 6184);

                var
                scope = f_1513_6163_6183(_variables, variable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6200, 6237);

                LocalVariable
                local = scope.Variable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6251, 6300);

                f_1513_6251_6299(f_1513_6264_6278_M(!local.IsBoxed) && (DynAbs.Tracing.TraceSender.Expression_True(1513, 6264, 6298) && f_1513_6282_6298_M(!local.InClosure)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6314, 6359);

                f_1513_6314_6334(_variables, variable).Variable.IsBoxed = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6375, 6392);

                int
                curChild = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6415, 6430);
                    for (int
        i = scope.Start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6406, 6919) || true) && (i < scope.Stop && (DynAbs.Tracing.TraceSender.Expression_True(1513, 6432, 6472) && i < f_1513_6454_6472(instructions)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6474, 6477)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 6406, 6919))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 6406, 6919);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6511, 6841) || true) && (scope.ChildScopes != null && (DynAbs.Tracing.TraceSender.Expression_True(1513, 6515, 6582) && f_1513_6544_6571(scope.ChildScopes, curChild).Start == i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 6511, 6841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6679, 6719);

                            var
                            child = f_1513_6691_6718(scope.ChildScopes, curChild)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6741, 6756);

                            i = child.Stop;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6780, 6791);

                            curChild++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6813, 6822);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 6511, 6841);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6861, 6904);

                        f_1513_6861_6903(
                                        instructions, local.Index, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1513, 1, 514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1513, 1, 514);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 6049, 6930);

                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_6163_6183(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6163, 6183);
                    return return_v;
                }


                bool
                f_1513_6264_6278_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6264, 6278);
                    return return_v;
                }


                bool
                f_1513_6282_6298_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6282, 6298);
                    return return_v;
                }


                int
                f_1513_6251_6299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 6251, 6299);
                    return 0;
                }


                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_6314_6334(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6314, 6334);
                    return return_v;
                }


                int
                f_1513_6454_6472(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6454, 6472);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_6544_6571(System.Collections.Generic.List<System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6544, 6571);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariables.VariableScope
                f_1513_6691_6718(System.Collections.Generic.List<System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 6691, 6718);
                    return return_v;
                }


                int
                f_1513_6861_6903(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index, int
                instructionIndex)
                {
                    this_param.SwitchToBoxed(index, instructionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 6861, 6903);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 6049, 6930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 6049, 6930);
            }
        }

        public int LocalCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 6988, 7018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 6994, 7016);

                    return _maxLocalCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 6988, 7018);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 6942, 7029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 6942, 7029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int GetOrDefineLocal(ParameterExpression var)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 7041, 7300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7118, 7149);

                int
                index = f_1513_7130_7148(this, var)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7163, 7260) || true) && (index == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 7163, 7260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7212, 7245);

                    return f_1513_7219_7238(this, var, 0).Index;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 7163, 7260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7276, 7289);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 7041, 7300);

                int
                f_1513_7130_7148(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                var)
                {
                    var return_v = this_param.GetLocalIndex(var);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 7130, 7148);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1513_7219_7238(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 7219, 7238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 7041, 7300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 7041, 7300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetLocalIndex(ParameterExpression var)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 7312, 7499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7386, 7404);

                VariableScope
                loc
                = default(VariableScope);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7418, 7488);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1513, 7425, 7461) || ((f_1513_7425_7461(_variables, var, out loc) && DynAbs.Tracing.TraceSender.Conditional_F2(1513, 7464, 7482)) || DynAbs.Tracing.TraceSender.Conditional_F3(1513, 7485, 7487))) ? loc.Variable.Index : -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 7312, 7499);

                bool
                f_1513_7425_7461(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariables.VariableScope
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 7425, 7461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 7312, 7499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 7312, 7499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 7511, 8018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7618, 7638);

                VariableScope
                scope
                = default(VariableScope);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7652, 7796) || true) && (f_1513_7656_7694(_variables, var, out scope))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 7652, 7796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7728, 7751);

                    local = scope.Variable;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7769, 7781);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 7652, 7796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7812, 7951) || true) && (_closureVariables != null && (DynAbs.Tracing.TraceSender.Expression_True(1513, 7816, 7890) && f_1513_7845_7890(_closureVariables, var, out local)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 7812, 7951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7924, 7936);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 7812, 7951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7967, 7980);

                local = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 7994, 8007);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 7511, 8018);

                bool
                f_1513_7656_7694(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariables.VariableScope
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 7656, 7694);
                    return return_v;
                }


                bool
                f_1513_7845_7890(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 7845, 7890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 7511, 8018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 7511, 8018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Dictionary<ParameterExpression, LocalVariable> CopyLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 8198, 8550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 8291, 8370);

                var
                res = f_1513_8301_8369(f_1513_8352_8368(_variables))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 8384, 8512);
                    foreach (var keyValue in f_1513_8409_8419_I(_variables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 8384, 8512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 8453, 8497);

                        res[keyValue.Key] = keyValue.Value.Variable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 8384, 8512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1513, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1513, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 8528, 8539);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 8198, 8550);

                int
                f_1513_8352_8368(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 8352, 8368);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                f_1513_8301_8369(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 8301, 8369);
                    return return_v;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                f_1513_8409_8419_I(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 8409, 8419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 8198, 8550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 8198, 8550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ContainsVariable(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 8701, 8837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 8786, 8826);

                return f_1513_8793_8825(_variables, variable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 8701, 8837);

                bool
                f_1513_8793_8825(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
                this_param, System.Linq.Expressions.ParameterExpression
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 8793, 8825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 8701, 8837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 8701, 8837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 9101, 9177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9137, 9162);

                    return _closureVariables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 9101, 9177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 9004, 9188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 9004, 9188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal LocalVariable AddClosureVariable(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1513, 9200, 9635);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9296, 9447) || true) && (_closureVariables == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1513, 9296, 9447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9359, 9432);

                    _closureVariables = f_1513_9379_9431();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1513, 9296, 9447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9463, 9542);

                LocalVariable
                result = f_1513_9486_9541(f_1513_9504_9527(_closureVariables), true, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9556, 9596);

                f_1513_9556_9595(_closureVariables, variable, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9610, 9624);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1513, 9200, 9635);

                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                f_1513_9379_9431()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 9379, 9431);
                    return return_v;
                }


                int
                f_1513_9504_9527(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1513, 9504, 9527);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1513_9486_9541(int
                index, bool
                closure, bool
                boxed)
                {
                    var return_v = new System.Management.Automation.Interpreter.LocalVariable(index, closure, boxed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 9486, 9541);
                    return return_v;
                }


                int
                f_1513_9556_9595(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 9556, 9595);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 9200, 9635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 9200, 9635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class VariableScope
        {
            public readonly int Start;

            public int Stop;

            public readonly LocalVariable Variable;

            public readonly VariableScope Parent;

            public List<VariableScope> ChildScopes;

            public VariableScope(LocalVariable variable, int start, VariableScope parent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1513, 10092, 10303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9866, 9871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9897, 9918);
                    this.Stop = Int32.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 9963, 9971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 10016, 10022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 10064, 10075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 10202, 10222);

                    Variable = variable;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 10240, 10254);

                    Start = start;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1513, 10272, 10288);

                    Parent = parent;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1513, 10092, 10303);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1513, 10092, 10303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 10092, 10303);
                }
            }

            static VariableScope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1513, 9787, 10314);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1513, 9787, 10314);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 9787, 10314);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1513, 9787, 10314);
        }

        static LocalVariables()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1513, 4086, 10321);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1513, 4086, 10321);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1513, 4086, 10321);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1513, 4086, 10321);

        System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>
        f_1513_4231_4298()
        {
            var return_v = new System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariables.VariableScope>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1513, 4231, 4298);
            return return_v;
        }

    }
}
