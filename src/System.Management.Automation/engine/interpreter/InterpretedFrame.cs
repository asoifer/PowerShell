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
using System.Diagnostics;
using System.Management.Automation.Language;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed class InterpretedFrame
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public static readonly ThreadLocal<InterpretedFrame> CurrentFrame;

        internal readonly Interpreter Interpreter;

        internal InterpretedFrame _parent;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly")]
        private int[] _continuations;

        private int _continuationIndex;

        private int _pendingContinuation;

        private object _pendingValue;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly")]
        public readonly object[] Data;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2105:ArrayFieldsShouldNotBeReadOnly")]
        public readonly StrongBox<object>[] Closure;

        public int StackIndex;

        public int InstructionIndex;

        internal InterpretedFrame(Interpreter interpreter, StrongBox<object>[] closure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1503, 2110, 2682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1342, 1353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1390, 1397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1546, 1560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1583, 1601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1624, 1644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1670, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1843, 1847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2018, 2025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2049, 2059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2081, 2097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2214, 2240);

                Interpreter = interpreter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2254, 2290);

                StackIndex = f_1503_2267_2289(interpreter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2304, 2375);

                Data = new object[StackIndex + interpreter.Instructions.MaxStackDepth];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2391, 2445);

                int
                c = interpreter.Instructions.MaxContinuationDepth
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2459, 2545) || true) && (c > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 2459, 2545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2502, 2530);

                    _continuations = new int[c];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 2459, 2545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2561, 2579);

                Closure = closure;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2595, 2621);

                _pendingContinuation = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2635, 2671);

                _pendingValue = Interpreter.NoValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1503, 2110, 2682);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 2110, 2682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 2110, 2682);
            }
        }

        public DebugInfo GetDebugInfo(int instructionIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 2694, 2862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2770, 2851);

                return f_1503_2777_2850(Interpreter._debugInfos, instructionIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 2694, 2862);

                System.Management.Automation.Interpreter.DebugInfo
                f_1503_2777_2850(System.Management.Automation.Interpreter.DebugInfo[]
                debugInfos, int
                index)
                {
                    var return_v = DebugInfo.GetMatchingDebugInfo(debugInfos, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 2777, 2850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 2694, 2862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 2694, 2862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 2917, 2950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 2923, 2948);

                    return Interpreter._name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 2917, 2950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 2874, 2961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 2874, 2961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Push(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3014, 3107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3069, 3096);

                Data[StackIndex++] = value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3014, 3107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3014, 3107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3014, 3107);
            }
        }

        public void Push(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3119, 3273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3172, 3262);

                Data[StackIndex++] = (DynAbs.Tracing.TraceSender.Conditional_F1(1503, 3193, 3198) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(1503, 3201, 3229)) || DynAbs.Tracing.TraceSender.Conditional_F3(1503, 3232, 3261))) ? ScriptingRuntimeHelpers.True : ScriptingRuntimeHelpers.False;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3119, 3273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3119, 3273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3119, 3273);
            }
        }

        public void Push(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3285, 3414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3337, 3403);

                Data[StackIndex++] = f_1503_3358_3402(value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3285, 3414);

                object
                f_1503_3358_3402(int
                i)
                {
                    var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 3358, 3402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3285, 3414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3285, 3414);
            }
        }

        public object Pop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3426, 3507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3470, 3496);

                return Data[--StackIndex];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3426, 3507);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3426, 3507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3426, 3507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetStackDepth(int depth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3519, 3637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3582, 3626);

                StackIndex = f_1503_3595_3617(Interpreter) + depth;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3519, 3637);

                int
                f_1503_3595_3617(System.Management.Automation.Interpreter.Interpreter
                this_param)
                {
                    var return_v = this_param.LocalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 3595, 3617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3519, 3637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3519, 3637);
            }
        }

        public object Peek()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3649, 3733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3694, 3722);

                return Data[StackIndex - 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3649, 3733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3649, 3733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3649, 3733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3745, 3886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3787, 3806);

                int
                i = StackIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3820, 3842);

                Data[i] = Data[i - 1];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3856, 3875);

                StackIndex = i + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3745, 3886);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3745, 3886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3745, 3886);
            }
        }

        public ExecutionContext ExecutionContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 3963, 4004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 3969, 4002);

                    return (ExecutionContext)Data[1];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 3963, 4004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 3898, 4015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 3898, 4015);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FunctionContext FunctionContext
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 4090, 4130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 4096, 4128);

                    return (FunctionContext)Data[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 4090, 4130);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 4027, 4141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 4027, 4141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public InterpretedFrame Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 4261, 4284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 4267, 4282);

                    return _parent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 4261, 4284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 4206, 4295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 4206, 4295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsInterpretedFrame(MethodBase method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1503, 4307, 4539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 4453, 4528);

                return f_1503_4460_4480(method) == typeof(Interpreter) && (DynAbs.Tracing.TraceSender.Expression_True(1503, 4460, 4527) && f_1503_4507_4518(method) == "Run");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1503, 4307, 4539);

                System.Type
                f_1503_4460_4480(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 4460, 4480);
                    return return_v;
                }


                string
                f_1503_4507_4518(System.Reflection.MethodBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 4507, 4518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 4307, 4539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 4307, 4539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<StackFrame> GroupStackFrames(IEnumerable<StackFrame> stackTrace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1503, 4773, 5454);

                var listYield = new List<StackFrame>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 4888, 4920);

                bool
                inInterpretedFrame = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 4934, 5443);
                    foreach (StackFrame frame in f_1503_4963_4973_I(stackTrace))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 4934, 5443);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5007, 5389) || true) && (f_1503_5011_5065(f_1503_5047_5064(frame)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 5007, 5389);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5107, 5211) || true) && (inInterpretedFrame)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 5107, 5211);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5179, 5188);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 5107, 5211);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5235, 5261);

                            inInterpretedFrame = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 5007, 5389);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 5007, 5389);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5343, 5370);

                            inInterpretedFrame = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 5007, 5389);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5409, 5428);

                        listYield.Add(frame);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 4934, 5443);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1503, 1, 510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1503, 1, 510);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1503, 4773, 5454);

                return listYield;

                System.Reflection.MethodBase?
                f_1503_5047_5064(System.Diagnostics.StackFrame
                this_param)
                {
                    var return_v = this_param.GetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 5047, 5064);
                    return return_v;
                }


                bool
                f_1503_5011_5065(System.Reflection.MethodBase
                method)
                {
                    var return_v = InterpretedFrame.IsInterpretedFrame(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 5011, 5065);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Diagnostics.StackFrame>
                f_1503_4963_4973_I(System.Collections.Generic.IEnumerable<System.Diagnostics.StackFrame>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 4963, 4973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 4773, 5454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 4773, 5454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 5466, 5804);

                var listYield = new List<InterpretedFrameInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5556, 5573);

                var
                frame = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 5587, 5793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5622, 5716);

                            listYield.Add(f_1503_5635_5715(f_1503_5660_5670(frame), f_1503_5672_5714(frame, frame.InstructionIndex)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5734, 5755);

                            frame = f_1503_5742_5754(frame);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 5587, 5793);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5587, 5793) || true) && (frame != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1503, 5587, 5793);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1503, 5587, 5793);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 5466, 5804);

                return listYield;

                string
                f_1503_5660_5670(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 5660, 5670);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DebugInfo
                f_1503_5672_5714(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                instructionIndex)
                {
                    var return_v = this_param.GetDebugInfo(instructionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 5672, 5714);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InterpretedFrameInfo
                f_1503_5635_5715(string
                methodName, System.Management.Automation.Interpreter.DebugInfo
                info)
                {
                    var return_v = new System.Management.Automation.Interpreter.InterpretedFrameInfo(methodName, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 5635, 5715);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InterpretedFrame
                f_1503_5742_5754(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 5742, 5754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 5466, 5804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 5466, 5804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SaveTraceToException(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 5816, 6126);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5896, 6115) || true) && (f_1503_5900_5944(f_1503_5900_5914(exception), typeof(InterpretedFrameInfo)) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 5896, 6115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 5986, 6100);

                    f_1503_5986_6000(exception)[typeof(InterpretedFrameInfo)] = f_1503_6033_6099(f_1503_6033_6089(f_1503_6064_6088(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 5896, 6115);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 5816, 6126);

                System.Collections.IDictionary
                f_1503_5900_5914(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 5900, 5914);
                    return return_v;
                }


                object
                f_1503_5900_5944(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 5900, 5944);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1503_5986_6000(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 5986, 6000);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Interpreter.InterpretedFrameInfo>
                f_1503_6064_6088(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.GetStackTraceDebugInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6064, 6088);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Interpreter.InterpretedFrameInfo>
                f_1503_6033_6089(System.Collections.Generic.IEnumerable<System.Management.Automation.Interpreter.InterpretedFrameInfo>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.InterpretedFrameInfo>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6033, 6089);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InterpretedFrameInfo[]
                f_1503_6033_6099(System.Collections.Generic.List<System.Management.Automation.Interpreter.InterpretedFrameInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6033, 6099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 5816, 6126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 5816, 6126);
            }
        }

        public static InterpretedFrameInfo[] GetExceptionStackTrace(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1503, 6138, 6332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6243, 6321);

                return f_1503_6250_6294(f_1503_6250_6264(exception), typeof(InterpretedFrameInfo)) as InterpretedFrameInfo[];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1503, 6138, 6332);

                System.Collections.IDictionary
                f_1503_6250_6264(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 6250, 6264);
                    return return_v;
                }


                object
                f_1503_6250_6294(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 6250, 6294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 6138, 6332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 6138, 6332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string[] Trace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 6403, 6729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6439, 6470);

                    var
                    trace = f_1503_6451_6469()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6488, 6505);

                    var
                    frame = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 6523, 6673);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6566, 6588);

                                f_1503_6566_6587(trace, f_1503_6576_6586(frame));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6610, 6631);

                                frame = f_1503_6618_6630(frame);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 6523, 6673);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6523, 6673) || true) && (frame != null)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1503, 6523, 6673);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1503, 6523, 6673);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6691, 6714);

                    return f_1503_6698_6713(trace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 6403, 6729);

                    System.Collections.Generic.List<string>
                    f_1503_6451_6469()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6451, 6469);
                        return return_v;
                    }


                    string
                    f_1503_6576_6586(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 6576, 6586);
                        return return_v;
                    }


                    int
                    f_1503_6566_6587(System.Collections.Generic.List<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6566, 6587);
                        return 0;
                    }


                    System.Management.Automation.Interpreter.InterpretedFrame
                    f_1503_6618_6630(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 6618, 6630);
                        return return_v;
                    }


                    string[]
                    f_1503_6698_6713(System.Collections.Generic.List<string>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6698, 6713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 6355, 6740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 6355, 6740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ThreadLocal<InterpretedFrame>.StorageInfo Enter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 6760, 7037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6843, 6909);

                var
                currentFrame = f_1503_6862_6908(InterpretedFrame.CurrentFrame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6923, 6952);

                _parent = currentFrame.Value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 6966, 6992);

                currentFrame.Value = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7006, 7026);

                return currentFrame;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 6760, 7037);

                System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>.StorageInfo
                f_1503_6862_6908(System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>
                this_param)
                {
                    var return_v = this_param.GetStorageInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 6862, 6908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 6760, 7037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 6760, 7037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Leave(ThreadLocal<InterpretedFrame>.StorageInfo currentFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7049, 7189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7149, 7178);

                currentFrame.Value = _parent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7049, 7189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7049, 7189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7049, 7189);
            }
        }

        internal bool IsJumpHappened()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7256, 7355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7311, 7344);

                return _pendingContinuation >= 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7256, 7355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7256, 7355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7256, 7355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void RemoveContinuation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7367, 7456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7424, 7445);

                _continuationIndex--;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7367, 7456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7367, 7456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7367, 7456);
            }
        }

        public void PushContinuation(int continuation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7468, 7602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7539, 7591);

                _continuations[_continuationIndex++] = continuation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7468, 7602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7468, 7602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7468, 7602);
            }
        }

        public int YieldToCurrentContinuation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7614, 7862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7678, 7751);

                var
                target = Interpreter._labels[_continuations[_continuationIndex - 1]]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7765, 7798);

                f_1503_7765_7797(this, target.StackDepth);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 7812, 7851);

                return target.Index - InstructionIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7614, 7862);

                int
                f_1503_7765_7797(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 7765, 7797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7614, 7862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7614, 7862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int YieldToPendingContinuation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 7979, 9117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8043, 8083);

                f_1503_8043_8082(_pendingContinuation >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8097, 8168);

                RuntimeLabel
                pendingTarget = Interpreter._labels[_pendingContinuation]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8314, 8635) || true) && (pendingTarget.ContinuationStackDepth < _continuationIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 8314, 8635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8409, 8498);

                    RuntimeLabel
                    currentTarget = Interpreter._labels[_continuations[_continuationIndex - 1]]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8516, 8556);

                    f_1503_8516_8555(this, currentTarget.StackDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8574, 8620);

                    return currentTarget.Index - InstructionIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 8314, 8635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8651, 8691);

                f_1503_8651_8690(this, pendingTarget.StackDepth);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8705, 8831) || true) && (_pendingValue != Interpreter.NoValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 8705, 8831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8779, 8816);

                    Data[StackIndex - 1] = _pendingValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 8705, 8831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 8970, 8996);

                _pendingContinuation = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9010, 9046);

                _pendingValue = Interpreter.NoValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9060, 9106);

                return pendingTarget.Index - InstructionIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 7979, 9117);

                int
                f_1503_8043_8082(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 8043, 8082);
                    return 0;
                }


                int
                f_1503_8516_8555(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 8516, 8555);
                    return 0;
                }


                int
                f_1503_8651_8690(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 8651, 8690);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 7979, 9117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 7979, 9117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void PushPendingContinuation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 9129, 9357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9193, 9220);

                f_1503_9193_9219(this, _pendingContinuation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9234, 9254);

                f_1503_9234_9253(this, _pendingValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9270, 9296);

                _pendingContinuation = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9310, 9346);

                _pendingValue = Interpreter.NoValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 9129, 9357);

                int
                f_1503_9193_9219(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9193, 9219);
                    return 0;
                }


                int
                f_1503_9234_9253(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9234, 9253);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 9129, 9357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 9129, 9357);
            }
        }

        internal void PopPendingContinuation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 9369, 9513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9432, 9454);

                _pendingValue = f_1503_9448_9453(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9468, 9502);

                _pendingContinuation = (int)f_1503_9496_9501(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 9369, 9513);

                object
                f_1503_9448_9453(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9448, 9453);
                    return return_v;
                }


                object
                f_1503_9496_9501(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9496, 9501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 9369, 9513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 9369, 9513);
            }
        }

        private static MethodInfo s_goto;

        private static MethodInfo s_voidGoto;

        internal static MethodInfo GotoMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1503, 9679, 9758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9685, 9756);

                    return s_goto ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.MethodInfo>(1503, 9692, 9755) ?? (s_goto = f_1503_9712_9754(typeof(InterpretedFrame), "Goto")));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1503, 9679, 9758);

                    System.Reflection.MethodInfo?
                    f_1503_9712_9754(System.Type
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMethod(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9712, 9754);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 9617, 9769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 9617, 9769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static MethodInfo VoidGotoMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1503, 9847, 9938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9853, 9936);

                    return s_voidGoto ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.MethodInfo>(1503, 9860, 9935) ?? (s_voidGoto = f_1503_9888_9934(typeof(InterpretedFrame), "VoidGoto")));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1503, 9847, 9938);

                    System.Reflection.MethodInfo?
                    f_1503_9888_9934(System.Type
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMethod(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 9888, 9934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 9781, 9949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 9781, 9949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int VoidGoto(int labelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 9961, 10106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10021, 10095);

                return f_1503_10028_10094(this, labelIndex, Interpreter.NoValue, gotoExceptionHandler: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 9961, 10106);

                int
                f_1503_10028_10094(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                labelIndex, object
                value, bool
                gotoExceptionHandler)
                {
                    var return_v = this_param.Goto(labelIndex, value, gotoExceptionHandler: gotoExceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 10028, 10094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 9961, 10106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 9961, 10106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Goto(int labelIndex, object value, bool gotoExceptionHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1503, 10118, 11194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10294, 10348);

                RuntimeLabel
                target = Interpreter._labels[labelIndex]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10362, 10578);

                f_1503_10362_10577(!gotoExceptionHandler || (DynAbs.Tracing.TraceSender.Expression_False(1503, 10375, 10451) || _continuationIndex == target.ContinuationStackDepth), "When it's time to jump to the exception handler, all previous finally blocks should already be processed");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10594, 10930) || true) && (_continuationIndex == target.ContinuationStackDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 10594, 10930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10683, 10716);

                    f_1503_10683_10715(this, target.StackDepth);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10734, 10856) || true) && (value != Interpreter.NoValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1503, 10734, 10856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10808, 10837);

                        Data[StackIndex - 1] = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 10734, 10856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 10876, 10915);

                    return target.Index - InstructionIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1503, 10594, 10930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 11063, 11097);

                _pendingContinuation = labelIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 11111, 11133);

                _pendingValue = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 11147, 11183);

                return f_1503_11154_11182(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1503, 10118, 11194);

                int
                f_1503_10362_10577(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 10362, 10577);
                    return 0;
                }


                int
                f_1503_10683_10715(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 10683, 10715);
                    return 0;
                }


                int
                f_1503_11154_11182(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.YieldToCurrentContinuation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 11154, 11182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1503, 10118, 11194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 10118, 11194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InterpretedFrame()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1503, 1008, 11223);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 1249, 1299);
            CurrentFrame = f_1503_1264_1299();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9551, 9557);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1503, 9594, 9604);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1503, 1008, 11223);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1503, 1008, 11223);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1503, 1008, 11223);

        static System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>
        f_1503_1264_1299()
        {
            var return_v = new System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1503, 1264, 1299);
            return return_v;
        }


        int
        f_1503_2267_2289(System.Management.Automation.Interpreter.Interpreter
        this_param)
        {
            var return_v = this_param.LocalCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1503, 2267, 2289);
            return return_v;
        }

    }
}
