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

using System.Collections.Concurrent;
using BigInt = System.Numerics.BigInteger;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Management.Automation.Interpreter
{
    internal abstract class InstructionFactory
    {
        private static ConditionalWeakTable<Type, InstructionFactory> s_factories;

        internal static InstructionFactory GetFactory(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1501, 1068, 2785);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1149, 2598) || true) && (s_factories == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1501, 1149, 2598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1206, 1275);

                    var
                    factories = f_1501_1222_1274()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1293, 1359);

                    f_1501_1293_1358(factories, typeof(object), InstructionFactory<object>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1377, 1439);

                    f_1501_1377_1438(factories, typeof(bool), InstructionFactory<bool>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1457, 1519);

                    f_1501_1457_1518(factories, typeof(byte), InstructionFactory<byte>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1537, 1601);

                    f_1501_1537_1600(factories, typeof(sbyte), InstructionFactory<sbyte>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1619, 1683);

                    f_1501_1619_1682(factories, typeof(short), InstructionFactory<short>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1701, 1767);

                    f_1501_1701_1766(factories, typeof(ushort), InstructionFactory<ushort>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1785, 1845);

                    f_1501_1785_1844(factories, typeof(int), InstructionFactory<int>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1863, 1925);

                    f_1501_1863_1924(factories, typeof(uint), InstructionFactory<uint>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1943, 2005);

                    f_1501_1943_2004(factories, typeof(long), InstructionFactory<long>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2023, 2087);

                    f_1501_2023_2086(factories, typeof(ulong), InstructionFactory<ulong>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2105, 2169);

                    f_1501_2105_2168(factories, typeof(float), InstructionFactory<float>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2187, 2253);

                    f_1501_2187_2252(factories, typeof(double), InstructionFactory<double>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2271, 2333);

                    f_1501_2271_2332(factories, typeof(char), InstructionFactory<char>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2351, 2417);

                    f_1501_2351_2416(factories, typeof(string), InstructionFactory<string>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2435, 2501);

                    f_1501_2435_2500(factories, typeof(BigInt), InstructionFactory<BigInt>.Factory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2521, 2583);

                    f_1501_2521_2582(ref s_factories, factories, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1501, 1149, 2598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 2614, 2774);

                return f_1501_2621_2773(s_factories, type, t => (InstructionFactory)typeof(InstructionFactory<>).MakeGenericType(t).GetField("Factory").GetValue(null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1501, 1068, 2785);

                System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                f_1501_1222_1274()
                {
                    var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1222, 1274);
                    return return_v;
                }


                int
                f_1501_1293_1358(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1293, 1358);
                    return 0;
                }


                int
                f_1501_1377_1438(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1377, 1438);
                    return 0;
                }


                int
                f_1501_1457_1518(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1457, 1518);
                    return 0;
                }


                int
                f_1501_1537_1600(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1537, 1600);
                    return 0;
                }


                int
                f_1501_1619_1682(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1619, 1682);
                    return 0;
                }


                int
                f_1501_1701_1766(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1701, 1766);
                    return 0;
                }


                int
                f_1501_1785_1844(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1785, 1844);
                    return 0;
                }


                int
                f_1501_1863_1924(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1863, 1924);
                    return 0;
                }


                int
                f_1501_1943_2004(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 1943, 2004);
                    return 0;
                }


                int
                f_1501_2023_2086(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2023, 2086);
                    return 0;
                }


                int
                f_1501_2105_2168(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2105, 2168);
                    return 0;
                }


                int
                f_1501_2187_2252(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2187, 2252);
                    return 0;
                }


                int
                f_1501_2271_2332(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2271, 2332);
                    return 0;
                }


                int
                f_1501_2351_2416(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2351, 2416);
                    return 0;
                }


                int
                f_1501_2435_2500(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Management.Automation.Interpreter.InstructionFactory
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2435, 2500);
                    return 0;
                }


                System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                f_1501_2521_2582(ref System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                location1, System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                value, System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2521, 2582);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InstructionFactory
                f_1501_2621_2773(System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>
                this_param, System.Type
                key, System.Runtime.CompilerServices.ConditionalWeakTable<System.Type, System.Management.Automation.Interpreter.InstructionFactory>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 2621, 2773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 1068, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 1068, 2785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal abstract Instruction GetArrayItem();

        protected internal abstract Instruction SetArrayItem();

        protected internal abstract Instruction TypeIs();

        protected internal abstract Instruction TypeAs();

        protected internal abstract Instruction DefaultValue();

        protected internal abstract Instruction NewArray();

        protected internal abstract Instruction NewArrayInit(int elementCount);

        public InstructionFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1501, 923, 3249);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1501, 923, 3249);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 923, 3249);
        }


        static InstructionFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1501, 923, 3249);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 1044, 1055);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1501, 923, 3249);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 923, 3249);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1501, 923, 3249);
    }
    internal sealed class InstructionFactory<T> : InstructionFactory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static InstructionFactory Factory;

        private Instruction _getArrayItem;

        private Instruction _setArrayItem;

        private Instruction _typeIs;

        private Instruction _defaultValue;

        private Instruction _newArray;

        private Instruction _typeAs;

        private Instruction[] _newArrayInit;

        private const int
        MaxArrayInitElementCountCache = 32
        ;

        private InstructionFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1501, 4081, 4113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3583, 3596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3627, 3640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3671, 3678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3709, 3722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3753, 3762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3793, 3800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3833, 3846);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1501, 4081, 4113);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4081, 4113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4081, 4113);
            }
        }

        static InstructionFactory() 
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1501, 3251, 5687);
            // TODO: No se que numeritos van
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 3515, 3550);
            Factory = new InstructionFactory<T>();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1501, 3251, 5687);
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 3251, 5687);
        }

        protected internal override Instruction GetArrayItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4125, 4290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 4204, 4279);

                return _getArrayItem ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 4211, 4278) ?? (_getArrayItem = f_1501_4245_4277()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4125, 4290);

                System.Management.Automation.Interpreter.GetArrayItemInstruction<T>
                f_1501_4245_4277()
                {
                    var return_v = new System.Management.Automation.Interpreter.GetArrayItemInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 4245, 4277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4125, 4290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4125, 4290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction SetArrayItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4302, 4467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 4381, 4456);

                return _setArrayItem ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 4388, 4455) ?? (_setArrayItem = f_1501_4422_4454()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4302, 4467);

                System.Management.Automation.Interpreter.SetArrayItemInstruction<T>
                f_1501_4422_4454()
                {
                    var return_v = new System.Management.Automation.Interpreter.SetArrayItemInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 4422, 4454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4302, 4467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4302, 4467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction TypeIs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4479, 4620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 4552, 4609);

                return _typeIs ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 4559, 4608) ?? (_typeIs = f_1501_4581_4607()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4479, 4620);

                System.Management.Automation.Interpreter.TypeIsInstruction<T>
                f_1501_4581_4607()
                {
                    var return_v = new System.Management.Automation.Interpreter.TypeIsInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 4581, 4607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4479, 4620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4479, 4620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction TypeAs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4632, 4773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 4705, 4762);

                return _typeAs ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 4712, 4761) ?? (_typeAs = f_1501_4734_4760()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4632, 4773);

                System.Management.Automation.Interpreter.TypeAsInstruction<T>
                f_1501_4734_4760()
                {
                    var return_v = new System.Management.Automation.Interpreter.TypeAsInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 4734, 4760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4632, 4773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4632, 4773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction DefaultValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4785, 4950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 4864, 4939);

                return _defaultValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 4871, 4938) ?? (_defaultValue = f_1501_4905_4937()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4785, 4950);

                System.Management.Automation.Interpreter.DefaultValueInstruction<T>
                f_1501_4905_4937()
                {
                    var return_v = new System.Management.Automation.Interpreter.DefaultValueInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 4905, 4937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4785, 4950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4785, 4950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction NewArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 4962, 5111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5037, 5100);

                return _newArray ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 5044, 5099) ?? (_newArray = f_1501_5070_5098()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 4962, 5111);

                System.Management.Automation.Interpreter.NewArrayInstruction<T>
                f_1501_5070_5098()
                {
                    var return_v = new System.Management.Automation.Interpreter.NewArrayInstruction<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 5070, 5098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 4962, 5111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 4962, 5111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override Instruction NewArrayInit(int elementCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1501, 5123, 5678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5218, 5599) || true) && (elementCount < MaxArrayInitElementCountCache)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1501, 5218, 5599);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5300, 5449) || true) && (_newArrayInit == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1501, 5300, 5449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5367, 5430);

                        _newArrayInit = new Instruction[MaxArrayInitElementCountCache];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1501, 5300, 5449);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5469, 5584);

                    return _newArrayInit[elementCount] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1501, 5476, 5583) ?? (_newArrayInit[elementCount] = f_1501_5538_5582(elementCount)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1501, 5218, 5599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1501, 5615, 5667);

                return f_1501_5622_5666(elementCount);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1501, 5123, 5678);

                System.Management.Automation.Interpreter.NewArrayInitInstruction<T>
                f_1501_5538_5582(int
                elementCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.NewArrayInitInstruction<T>(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 5538, 5582);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NewArrayInitInstruction<T>
                f_1501_5622_5666(int
                elementCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.NewArrayInitInstruction<T>(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1501, 5622, 5666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1501, 5123, 5678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1501, 5123, 5678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
