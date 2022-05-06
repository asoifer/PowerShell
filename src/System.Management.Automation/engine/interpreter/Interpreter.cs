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

using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed class Interpreter
    {
        internal static readonly object NoValue;

        internal const int
        RethrowOnReturn = Int32.MaxValue
        ;

        internal readonly int _compilationThreshold;

        internal readonly object[] _objects;

        internal readonly RuntimeLabel[] _labels;

        internal readonly string _name;

        internal readonly DebugInfo[] _debugInfos;

        internal Interpreter(string name, LocalVariables locals, HybridReferenceDictionary<LabelTarget, BranchLabel> labelMapping,
                    InstructionArray instructions, DebugInfo[] debugInfos, int compilationThreshold)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1504, 1826, 2469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1598, 1619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1659, 1667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1711, 1718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1756, 1761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1802, 1813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2752, 2784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2979, 3060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 3072, 3154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2067, 2080);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2094, 2125);

                LocalCount = f_1504_2107_2124(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2139, 2182);

                ClosureVariables = f_1504_2158_2181(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2198, 2226);

                Instructions = instructions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2240, 2272);

                _objects = instructions.Objects;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2286, 2316);

                _labels = instructions.Labels;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2330, 2358);

                LabelMapping = labelMapping;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2374, 2399);

                _debugInfos = debugInfos;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2413, 2458);

                _compilationThreshold = compilationThreshold;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1504, 1826, 2469);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1504, 1826, 2469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1504, 1826, 2469);
            }
        }

        internal int ClosureSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1504, 2530, 2729);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2566, 2664) || true) && (f_1504_2570_2586() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1504, 2566, 2664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2636, 2645);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1504, 2566, 2664);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2684, 2714);

                    return f_1504_2691_2713(f_1504_2691_2707());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1504, 2530, 2729);

                    System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                    f_1504_2570_2586()
                    {
                        var return_v = ClosureVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 2570, 2586);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                    f_1504_2691_2707()
                    {
                        var return_v = ClosureVariables;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 2691, 2707);
                        return return_v;
                    }


                    int
                    f_1504_2691_2713(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 2691, 2713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1504, 2481, 2740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1504, 2481, 2740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int LocalCount { get; }

        internal bool CompileSynchronously
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1504, 2855, 2897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 2861, 2895);

                    return _compilationThreshold <= 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1504, 2855, 2897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1504, 2796, 2908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1504, 2796, 2908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal InstructionArray Instructions { get; }

        internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

        internal HybridReferenceDictionary<LabelTarget, BranchLabel> LabelMapping { get; }

        [SpecialName, MethodImpl(MethodImplOptions.NoInlining)]
        public void Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1504, 3751, 4171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 3880, 3925);

                var
                instructions = f_1504_3899_3911().Instructions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 3939, 3974);

                int
                index = frame.InstructionIndex
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 3988, 4160) || true) && (index < f_1504_4003_4022(instructions))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1504, 3988, 4160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 4056, 4096);

                        index += f_1504_4065_4095(instructions[index], frame);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 4114, 4145);

                        frame.InstructionIndex = index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1504, 3988, 4160);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1504, 3988, 4160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1504, 3988, 4160);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1504, 3751, 4171);

                System.Management.Automation.Interpreter.InstructionArray
                f_1504_3899_3911()
                {
                    var return_v = Instructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 3899, 3911);
                    return return_v;
                }


                int
                f_1504_4003_4022(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 4003, 4022);
                    return return_v;
                }


                int
                f_1504_4065_4095(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1504, 4065, 4095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1504, 3751, 4171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1504, 3751, 4171);
            }
        }

        static Interpreter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1504, 1332, 4178);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1414, 1436);
            NoValue = f_1504_1424_1436();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1504, 1466, 1498);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1504, 1332, 4178);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1504, 1332, 4178);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1504, 1332, 4178);

        static object
        f_1504_1424_1436()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1504, 1424, 1436);
            return return_v;
        }


        int
        f_1504_2107_2124(System.Management.Automation.Interpreter.LocalVariables
        this_param)
        {
            var return_v = this_param.LocalCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 2107, 2124);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
        f_1504_2158_2181(System.Management.Automation.Interpreter.LocalVariables
        this_param)
        {
            var return_v = this_param.ClosureVariables;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1504, 2158, 2181);
            return return_v;
        }

    }
}
