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
// Enables instruction counting and displaying stats at process exit.
// #define STATS

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
    [DebuggerTypeProxy(typeof(InstructionArray.DebugView))]
    internal struct InstructionArray
    {

        internal readonly int MaxStackDepth;

        internal readonly int MaxContinuationDepth;

        internal readonly Instruction[] Instructions;

        internal readonly object[] Objects;

        internal readonly RuntimeLabel[] Labels;

        internal readonly List<KeyValuePair<int, object>> DebugCookies;

        internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions,
                    object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1502, 1640, 2108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 1863, 1893);

                MaxStackDepth = maxStackDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 1907, 1951);

                MaxContinuationDepth = maxContinuationDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 1965, 1993);

                Instructions = instructions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2007, 2035);

                DebugCookies = debugCookies;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2049, 2067);

                Objects = objects;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2081, 2097);

                Labels = labels;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1502, 1640, 2108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 1640, 2108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 1640, 2108);
            }
        }

        internal int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 2164, 2199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2170, 2197);

                    return f_1502_2177_2196(Instructions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 2164, 2199);

                    int
                    f_1502_2177_2196(System.Management.Automation.Interpreter.Instruction[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 2177, 2196);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 2120, 2210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 2120, 2210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        internal sealed class DebugView
        {
            private readonly InstructionArray _array;

            public DebugView(InstructionArray array)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1502, 2365, 2468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2438, 2453);

                    _array = array;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1502, 2365, 2468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 2365, 2468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 2365, 2468);
                }
            }

            [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
            public InstructionList.DebugView.InstructionView[] A0
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 2638, 2974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 2682, 2955);

                        return f_1502_2689_2954(_array.Instructions, _array.Objects, (index) => _array.Labels[index].Index, _array.DebugCookies);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 2638, 2974);

                        System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView[]
                        f_1502_2689_2954(System.Management.Automation.Interpreter.Instruction[]
                        instructions, object[]
                        objects, System.Func<int, int>
                        labelIndexer, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>
                        debugCookies)
                        {
                            var return_v = InstructionList.DebugView.GetInstructionViews((System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>)instructions, (System.Collections.Generic.IList<object>)objects, labelIndexer, (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<int, object>>)debugCookies);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 2689, 2954);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 2484, 2989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 2484, 2989);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DebugView()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1502, 2252, 3000);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1502, 2252, 3000);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 2252, 3000);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1502, 2252, 3000);
        }
        static InstructionArray()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1502, 993, 3029);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1502, 993, 3029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 993, 3029);
        }

    }
    [DebuggerTypeProxy(typeof(InstructionList.DebugView))]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal sealed class InstructionList
    {
        private readonly List<Instruction> _instructions;

        private List<object> _objects;

        private int _currentStackDepth;

        private int _maxStackDepth;

        private int _currentContinuationsDepth;

        private int _maxContinuationDepth;

        private int _runtimeLabelCount;

        private List<BranchLabel> _labels;

        private List<KeyValuePair<int, object>> _debugCookies;
        internal sealed class DebugView
        {
            private readonly InstructionList _list;

            public DebugView(InstructionList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1502, 3949, 4048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3927, 3932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4020, 4033);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1502, 3949, 4048);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 3949, 4048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 3949, 4048);
                }
            }

            [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
            public InstructionView[] A0
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 4192, 4508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4236, 4489);

                        return f_1502_4243_4488(_list._instructions, _list._objects, (index) => _list._labels[index].TargetIndex, _list._debugCookies);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 4192, 4508);

                        System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView[]
                        f_1502_4243_4488(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                        instructions, System.Collections.Generic.List<object>
                        objects, System.Func<int, int>
                        labelIndexer, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>
                        debugCookies)
                        {
                            var return_v = GetInstructionViews((System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>)instructions, (System.Collections.Generic.IList<object>)objects, labelIndexer, (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<int, object>>)debugCookies);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 4243, 4488);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 4064, 4523);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 4064, 4523);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal static InstructionView[] GetInstructionViews(IList<Instruction> instructions, IList<object> objects,
                            Func<int, int> labelIndexer, IList<KeyValuePair<int, object>> debugCookies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 4539, 6053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4774, 4815);

                    var
                    result = f_1502_4787_4814()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4833, 4847);

                    int
                    index = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4865, 4884);

                    int
                    stackDepth = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4902, 4929);

                    int
                    continuationsDepth = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 4949, 5047);

                    var
                    cookieEnumerator = f_1502_4972_5046((debugCookies ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<int, object>>>(1502, 4973, 5029) ?? f_1502_4989_5029())))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5065, 5109);

                    var
                    hasCookie = f_1502_5081_5108(cookieEnumerator)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5138, 5143);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5129, 5994) || true) && (i < f_1502_5149_5167(instructions))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5169, 5172)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 5129, 5994))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 5129, 5994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5214, 5235);

                            object
                            cookie = null
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5257, 5489) || true) && (hasCookie && (DynAbs.Tracing.TraceSender.Expression_True(1502, 5264, 5310) && cookieEnumerator.Current.Key == i))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 5257, 5489);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5360, 5400);

                                    cookie = cookieEnumerator.Current.Value;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5426, 5466);

                                    hasCookie = f_1502_5438_5465(cookieEnumerator);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 5257, 5489);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1502, 5257, 5489);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1502, 5257, 5489);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5513, 5558);

                            int
                            stackDiff = f_1502_5529_5557(f_1502_5529_5544(instructions, i))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5580, 5632);

                            int
                            contDiff = f_1502_5595_5631(f_1502_5595_5610(instructions, i))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5654, 5732);

                            string
                            name = f_1502_5668_5731(f_1502_5668_5683(instructions, i), i, cookie, labelIndexer, objects)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5754, 5844);

                            f_1502_5754_5843(result, f_1502_5765_5842(f_1502_5785_5800(instructions, i), name, i, stackDepth, continuationsDepth));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5868, 5876);

                            index++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5898, 5922);

                            stackDepth += stackDiff;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 5944, 5975);

                            continuationsDepth += contDiff;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1502, 1, 866);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1502, 1, 866);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 6014, 6038);

                    return f_1502_6021_6037(result);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 4539, 6053);

                    System.Collections.Generic.List<System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView>
                    f_1502_4787_4814()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 4787, 4814);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<int, object>[]
                    f_1502_4989_5029()
                    {
                        var return_v = Array.Empty<KeyValuePair<int, object>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 4989, 5029);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int, object>>
                    f_1502_4972_5046(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<int, object>>
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 4972, 5046);
                        return return_v;
                    }


                    bool
                    f_1502_5081_5108(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int, object>>
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 5081, 5108);
                        return return_v;
                    }


                    int
                    f_1502_5149_5167(System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5149, 5167);
                        return return_v;
                    }


                    bool
                    f_1502_5438_5465(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int, object>>
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 5438, 5465);
                        return return_v;
                    }


                    System.Management.Automation.Interpreter.Instruction
                    f_1502_5529_5544(System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5529, 5544);
                        return return_v;
                    }


                    int
                    f_1502_5529_5557(System.Management.Automation.Interpreter.Instruction
                    this_param)
                    {
                        var return_v = this_param.StackBalance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5529, 5557);
                        return return_v;
                    }


                    System.Management.Automation.Interpreter.Instruction
                    f_1502_5595_5610(System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5595, 5610);
                        return return_v;
                    }


                    int
                    f_1502_5595_5631(System.Management.Automation.Interpreter.Instruction
                    this_param)
                    {
                        var return_v = this_param.ContinuationsBalance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5595, 5631);
                        return return_v;
                    }


                    System.Management.Automation.Interpreter.Instruction
                    f_1502_5668_5683(System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5668, 5683);
                        return return_v;
                    }


                    string
                    f_1502_5668_5731(System.Management.Automation.Interpreter.Instruction
                    this_param, int
                    instructionIndex, object
                    cookie, System.Func<int, int>
                    labelIndexer, System.Collections.Generic.IList<object>
                    objects)
                    {
                        var return_v = this_param.ToDebugString(instructionIndex, cookie, labelIndexer, objects);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 5668, 5731);
                        return return_v;
                    }


                    System.Management.Automation.Interpreter.Instruction
                    f_1502_5785_5800(System.Collections.Generic.IList<System.Management.Automation.Interpreter.Instruction>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 5785, 5800);
                        return return_v;
                    }


                    System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView
                    f_1502_5765_5842(System.Management.Automation.Interpreter.Instruction
                    instruction, string
                    name, int
                    index, int
                    stackDepth, int
                    continuationsDepth)
                    {
                        var return_v = new System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView(instruction, name, index, stackDepth, continuationsDepth);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 5765, 5842);
                        return return_v;
                    }


                    int
                    f_1502_5754_5843(System.Collections.Generic.List<System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView>
                    this_param, System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 5754, 5843);
                        return 0;
                    }


                    System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView[]
                    f_1502_6021_6037(System.Collections.Generic.List<System.Management.Automation.Interpreter.InstructionList.DebugView.InstructionView>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 6021, 6037);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 4539, 6053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 4539, 6053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
            internal struct InstructionView
            {

                private readonly int _index;

                private readonly int _stackDepth;

                private readonly int _continuationsDepth;

                private readonly string _name;

                private readonly Instruction _instruction;

                internal string GetName()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 6507, 6800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 6573, 6781);

                        // LAFHIS
                        var temp1 = _index.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 6580, 6586);
                        var temp2 = string.Empty;
                        if ((DynAbs.Tracing.TraceSender.Conditional_F1(1502, 6615, 6639) ||
                            ((_continuationsDepth == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1502, 6642, 6654)) ||
                            DynAbs.Tracing.TraceSender.Conditional_F3(1502, 6657, 6690)))) 
                        {
                            temp2 = string.Empty;
                        } 
                        else
                        {
                            temp2 = " C(" + _continuationsDepth.ToString() + ")";
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 6665, 6684);
                        }
                        var temp3 = string.Empty;
                        if ((DynAbs.Tracing.TraceSender.Conditional_F1(1502, 6720, 6736) ||
                            ((_stackDepth == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1502, 6739, 6751)) || DynAbs.Tracing.TraceSender.Conditional_F3(1502, 6754, 6779))))
                        {
                            temp3 = string.Empty;
                        }
                        else
                        {
                            temp3 = " S(" + _stackDepth.ToString() + ")";
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 6762, 6773);
                        }

                        return temp1 + temp2 + temp3;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 6507, 6800);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 6507, 6800);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 6507, 6800);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal string GetValue()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 6820, 6919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 6887, 6900);

                        return _name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 6820, 6919);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 6820, 6919);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 6820, 6919);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal string GetDisplayType()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 6939, 7106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7012, 7087);

                        // LAFHIS
                        var temp1 = (f_1502_7019_7052(_instruction)).ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 7019, 7052);
                        var temp2 = (f_1502_7061_7086(_instruction)).ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 7061, 7086);

                        return temp1 + "/" + temp2;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 6939, 7106);

                        int
                        f_1502_7019_7052(System.Management.Automation.Interpreter.Instruction
                        this_param)
                        {
                            var return_v = this_param.ContinuationsBalance;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7019, 7052);
                            return return_v;
                        }


                        int
                        f_1502_7061_7086(System.Management.Automation.Interpreter.Instruction
                        this_param)
                        {
                            var return_v = this_param.StackBalance;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7061, 7086);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 6939, 7106);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 6939, 7106);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1502, 7126, 7506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7278, 7305);

                        _instruction = instruction;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7327, 7340);

                        _name = name;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7362, 7377);

                        _index = index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7399, 7424);

                        _stackDepth = stackDepth;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7446, 7487);

                        _continuationsDepth = continuationsDepth;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1502, 7126, 7506);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 7126, 7506);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 7126, 7506);
                    }
                }
                static InstructionView()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1502, 6069, 7521);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1502, 6069, 7521);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 6069, 7521);
                }
            }
        }

        public void Emit(Instruction instruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 7599, 7751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7665, 7696);

                f_1502_7665_7695(_instructions, instruction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7710, 7740);

                f_1502_7710_7739(this, instruction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 7599, 7751);

                int
                f_1502_7665_7695(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                this_param, System.Management.Automation.Interpreter.Instruction
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 7665, 7695);
                    return 0;
                }


                int
                f_1502_7710_7739(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.UpdateStackDepth(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 7710, 7739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 7599, 7751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 7599, 7751);
            }
        }

        private void UpdateStackDepth(Instruction instruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 7763, 8735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 7842, 8022);

                f_1502_7842_8021(f_1502_7855_7880(instruction) >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1502, 7855, 7919) && f_1502_7889_7914(instruction) >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(1502, 7855, 7978) && f_1502_7940_7973(instruction) >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(1502, 7855, 8020) && f_1502_7982_8015(instruction) >= 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8038, 8086);

                _currentStackDepth -= f_1502_8060_8085(instruction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8100, 8138);

                f_1502_8100_8137(_currentStackDepth >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8152, 8200);

                _currentStackDepth += f_1502_8174_8199(instruction);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8214, 8338) || true) && (_currentStackDepth > _maxStackDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 8214, 8338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8287, 8323);

                    _maxStackDepth = _currentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 8214, 8338);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8354, 8418);

                _currentContinuationsDepth -= f_1502_8384_8417(instruction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8432, 8478);

                f_1502_8432_8477(_currentContinuationsDepth >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8492, 8556);

                _currentContinuationsDepth += f_1502_8522_8555(instruction);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8570, 8724) || true) && (_currentContinuationsDepth > _maxContinuationDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 8570, 8724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8658, 8709);

                    _maxContinuationDepth = _currentContinuationsDepth;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 8570, 8724);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 7763, 8735);

                int
                f_1502_7855_7880(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ConsumedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7855, 7880);
                    return return_v;
                }


                int
                f_1502_7889_7914(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ProducedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7889, 7914);
                    return return_v;
                }


                int
                f_1502_7940_7973(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ConsumedContinuations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7940, 7973);
                    return return_v;
                }


                int
                f_1502_7982_8015(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ProducedContinuations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 7982, 8015);
                    return return_v;
                }


                int
                f_1502_7842_8021(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 7842, 8021);
                    return 0;
                }


                int
                f_1502_8060_8085(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ConsumedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 8060, 8085);
                    return return_v;
                }


                int
                f_1502_8100_8137(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 8100, 8137);
                    return 0;
                }


                int
                f_1502_8174_8199(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ProducedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 8174, 8199);
                    return return_v;
                }


                int
                f_1502_8384_8417(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ConsumedContinuations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 8384, 8417);
                    return return_v;
                }


                int
                f_1502_8432_8477(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 8432, 8477);
                    return 0;
                }


                int
                f_1502_8522_8555(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ProducedContinuations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 8522, 8555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 7763, 8735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 7763, 8735);
            }
        }

        [Conditional("DEBUG")]
        public void SetDebugCookie(object cookie)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 8858, 9236);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 8967, 9095) || true) && (_debugCookies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 8967, 9095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9026, 9080);

                    _debugCookies = f_1502_9042_9079();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 8967, 9095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9111, 9135);

                f_1502_9111_9134(f_1502_9124_9129() > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9149, 9217);

                f_1502_9149_9216(_debugCookies, f_1502_9167_9215(f_1502_9197_9202() - 1, cookie));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 8858, 9236);

                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>
                f_1502_9042_9079()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 9042, 9079);
                    return return_v;
                }


                int
                f_1502_9124_9129()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 9124, 9129);
                    return return_v;
                }


                int
                f_1502_9111_9134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 9111, 9134);
                    return 0;
                }


                int
                f_1502_9197_9202()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 9197, 9202);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<int, object>
                f_1502_9167_9215(int
                key, object
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<int, object>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 9167, 9215);
                    return return_v;
                }


                int
                f_1502_9149_9216(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>
                this_param, System.Collections.Generic.KeyValuePair<int, object>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 9149, 9216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 8858, 9236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 8858, 9236);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 9289, 9324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9295, 9322);

                    return f_1502_9302_9321(_instructions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 9289, 9324);

                    int
                    f_1502_9302_9321(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 9302, 9321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 9248, 9335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 9248, 9335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int CurrentStackDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 9400, 9434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9406, 9432);

                    return _currentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 9400, 9434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 9347, 9445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 9347, 9445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int CurrentContinuationsDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 9518, 9560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9524, 9558);

                    return _currentContinuationsDepth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 9518, 9560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 9457, 9571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 9457, 9571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int MaxStackDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 9632, 9662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9638, 9660);

                    return _maxStackDepth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 9632, 9662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 9583, 9673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 9583, 9673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Instruction GetInstruction(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 9685, 9795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 9756, 9784);

                return f_1502_9763_9783(_instructions, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 9685, 9795);

                System.Management.Automation.Interpreter.Instruction
                f_1502_9763_9783(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 9763, 9783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 9685, 9795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 9685, 9795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public InstructionArray ToArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 10911, 11921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 11616, 11910);

                return f_1502_11623_11909(_maxStackDepth, _maxContinuationDepth, f_1502_11735_11758(_instructions), (DynAbs.Tracing.TraceSender.Conditional_F1(1502, 11777, 11795) || (((_objects != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1502, 11798, 11816)) || DynAbs.Tracing.TraceSender.Conditional_F3(1502, 11819, 11823))) ? f_1502_11798_11816(_objects) : null, f_1502_11842_11862(this), _debugCookies);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 10911, 11921);

                System.Management.Automation.Interpreter.Instruction[]
                f_1502_11735_11758(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 11735, 11758);
                    return return_v;
                }


                object[]
                f_1502_11798_11816(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 11798, 11816);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RuntimeLabel[]
                f_1502_11842_11862(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.BuildRuntimeLabels();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 11842, 11862);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InstructionArray
                f_1502_11623_11909(int
                maxStackDepth, int
                maxContinuationDepth, System.Management.Automation.Interpreter.Instruction[]
                instructions, object[]
                objects, System.Management.Automation.Interpreter.RuntimeLabel[]
                labels, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, object>>
                debugCookies)
                {
                    var return_v = new System.Management.Automation.Interpreter.InstructionArray(maxStackDepth, maxContinuationDepth, instructions, objects, labels, debugCookies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 11623, 11909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 10911, 11921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 10911, 11921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        PushIntMinCachedValue = -100
        ;

        private const int
        PushIntMaxCachedValue = 100
        ;

        private const int
        CachedObjectCount = 256
        ;

        private static Instruction s_null;

        private static Instruction s_true;

        private static Instruction s_false;

        private static Instruction[] s_ints;

        private static Instruction[] s_loadObjectCached;

        public void EmitLoad(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 12397, 12489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12456, 12478);

                f_1502_12456_12477(this, value, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 12397, 12489);

                int
                f_1502_12456_12477(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value, System.Type
                type)
                {
                    this_param.EmitLoad(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12456, 12477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 12397, 12489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 12397, 12489);
            }
        }

        public void EmitLoad(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 12501, 12821);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12558, 12810) || true) && ((bool)value)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 12558, 12810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12607, 12667);

                    f_1502_12607_12666(this, s_true ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 12612, 12665) ?? (s_true = f_1502_12632_12664(value))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 12558, 12810);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 12558, 12810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12733, 12795);

                    f_1502_12733_12794(this, s_false ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 12738, 12793) ?? (s_false = f_1502_12760_12792(value))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 12558, 12810);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 12501, 12821);

                System.Management.Automation.Interpreter.LoadObjectInstruction
                f_1502_12632_12664(bool
                value)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadObjectInstruction((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12632, 12664);
                    return return_v;
                }


                int
                f_1502_12607_12666(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12607, 12666);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadObjectInstruction
                f_1502_12760_12792(bool
                value)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadObjectInstruction((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12760, 12792);
                    return return_v;
                }


                int
                f_1502_12733_12794(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12733, 12794);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 12501, 12821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 12501, 12821);
            }
        }

        public void EmitLoad(object value, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 12833, 14614);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12903, 13053) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 12903, 13053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12954, 13013);

                    f_1502_12954_13012(this, s_null ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 12959, 13011) ?? (s_null = f_1502_12979_13010(null))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13031, 13038);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 12903, 13053);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13069, 13913) || true) && (type == null || (DynAbs.Tracing.TraceSender.Expression_False(1502, 13073, 13105) || f_1502_13089_13105(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13069, 13913);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13139, 13268) || true) && (value is bool)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13139, 13268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13198, 13220);

                        f_1502_13198_13219(this, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13242, 13249);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13139, 13268);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13288, 13898) || true) && (value is int)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13288, 13898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13346, 13365);

                        int
                        i = (int)value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13387, 13879) || true) && (i >= PushIntMinCachedValue && (DynAbs.Tracing.TraceSender.Expression_True(1502, 13391, 13447) && i <= PushIntMaxCachedValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13387, 13879);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13497, 13676) || true) && (s_ints == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13497, 13676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13573, 13649);

                                s_ints = new Instruction[PushIntMaxCachedValue - PushIntMinCachedValue + 1];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13497, 13676);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13704, 13731);

                            i -= PushIntMinCachedValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13757, 13823);

                            f_1502_13757_13822(this, s_ints[i] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 13762, 13821) ?? (s_ints[i] = f_1502_13788_13820(value))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13849, 13856);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13387, 13879);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13288, 13898);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13069, 13913);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13929, 14193) || true) && (_objects == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 13929, 14193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 13983, 14013);

                    _objects = f_1502_13994_14012();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14031, 14178) || true) && (s_loadObjectCached == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 14031, 14178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14103, 14159);

                        s_loadObjectCached = new Instruction[CachedObjectCount];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 14031, 14178);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 13929, 14193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14209, 14603) || true) && (f_1502_14213_14227(_objects) < f_1502_14230_14255(s_loadObjectCached))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 14209, 14603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14289, 14323);

                    uint
                    index = (uint)f_1502_14308_14322(_objects)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14341, 14361);

                    f_1502_14341_14360(_objects, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14379, 14483);

                    f_1502_14379_14482(this, s_loadObjectCached[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 14384, 14481) ?? (s_loadObjectCached[index] = f_1502_14442_14480(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 14209, 14603);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 14209, 14603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14549, 14588);

                    f_1502_14549_14587(this, f_1502_14554_14586(value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 14209, 14603);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 12833, 14614);

                System.Management.Automation.Interpreter.LoadObjectInstruction
                f_1502_12979_13010(object
                value)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadObjectInstruction(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12979, 13010);
                    return return_v;
                }


                int
                f_1502_12954_13012(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 12954, 13012);
                    return 0;
                }


                bool
                f_1502_13089_13105(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 13089, 13105);
                    return return_v;
                }


                int
                f_1502_13198_13219(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value)
                {
                    this_param.EmitLoad((bool)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 13198, 13219);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadObjectInstruction
                f_1502_13788_13820(object
                value)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadObjectInstruction(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 13788, 13820);
                    return return_v;
                }


                int
                f_1502_13757_13822(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 13757, 13822);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1502_13994_14012()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 13994, 14012);
                    return return_v;
                }


                int
                f_1502_14213_14227(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 14213, 14227);
                    return return_v;
                }


                int
                f_1502_14230_14255(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 14230, 14255);
                    return return_v;
                }


                int
                f_1502_14308_14322(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 14308, 14322);
                    return return_v;
                }


                int
                f_1502_14341_14360(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14341, 14360);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadCachedObjectInstruction
                f_1502_14442_14480(uint
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadCachedObjectInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14442, 14480);
                    return return_v;
                }


                int
                f_1502_14379_14482(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14379, 14482);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadObjectInstruction
                f_1502_14554_14586(object
                value)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadObjectInstruction(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14554, 14586);
                    return return_v;
                }


                int
                f_1502_14549_14587(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LoadObjectInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14549, 14587);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 12833, 14614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 12833, 14614);
            }
        }

        public void EmitDup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 14626, 14713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14672, 14702);

                f_1502_14672_14701(this, DupInstruction.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 14626, 14713);

                int
                f_1502_14672_14701(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.DupInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14672, 14701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 14626, 14713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 14626, 14713);
            }
        }

        public void EmitPop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 14725, 14812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14771, 14801);

                f_1502_14771_14800(this, PopInstruction.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 14725, 14812);

                int
                f_1502_14771_14800(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.PopInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 14771, 14800);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 14725, 14812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 14725, 14812);
            }
        }

        internal void SwitchToBoxed(int index, int instructionIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 14872, 15341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 14957, 15030);

                var
                instruction = f_1502_14975_15006(_instructions, instructionIndex) as IBoxableInstruction
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15046, 15330) || true) && (instruction != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 15046, 15330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15103, 15161);

                    var
                    newInstruction = f_1502_15124_15160(instruction, index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15179, 15315) || true) && (newInstruction != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 15179, 15315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15247, 15296);

                        _instructions[instructionIndex] = newInstruction;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 15179, 15315);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 15046, 15330);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 14872, 15341);

                System.Management.Automation.Interpreter.Instruction
                f_1502_14975_15006(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 14975, 15006);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_15124_15160(System.Management.Automation.Interpreter.IBoxableInstruction
                this_param, int
                index)
                {
                    var return_v = this_param.BoxIfIndexMatches(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 15124, 15160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 14872, 15341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 14872, 15341);
            }
        }

        private const int
        LocalInstrCacheSize = 64
        ;

        private static Instruction[] s_loadLocal;

        private static Instruction[] s_loadLocalBoxed;

        private static Instruction[] s_loadLocalFromClosure;

        private static Instruction[] s_loadLocalFromClosureBoxed;

        private static Instruction[] s_assignLocal;

        private static Instruction[] s_storeLocal;

        private static Instruction[] s_assignLocalBoxed;

        private static Instruction[] s_storeLocalBoxed;

        private static Instruction[] s_assignLocalToClosure;

        private static Instruction[] s_initReference;

        private static Instruction[] s_initImmutableRefBox;

        private static Instruction[] s_parameterBox;

        private static Instruction[] s_parameter;

        public void EmitLoadLocal(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 16149, 16626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16210, 16333) || true) && (s_loadLocal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16210, 16333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16267, 16318);

                    s_loadLocal = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16210, 16333);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16349, 16615) || true) && (index < f_1502_16361_16379(s_loadLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16349, 16615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16413, 16496);

                    f_1502_16413_16495(this, s_loadLocal[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 16418, 16494) ?? (s_loadLocal[index] = f_1502_16462_16493(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16349, 16615);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16349, 16615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16562, 16600);

                    f_1502_16562_16599(this, f_1502_16567_16598(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16349, 16615);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 16149, 16626);

                int
                f_1502_16361_16379(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 16361, 16379);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadLocalInstruction
                f_1502_16462_16493(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16462, 16493);
                    return return_v;
                }


                int
                f_1502_16413_16495(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16413, 16495);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadLocalInstruction
                f_1502_16567_16598(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16567, 16598);
                    return return_v;
                }


                int
                f_1502_16562_16599(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LoadLocalInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16562, 16599);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 16149, 16626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 16149, 16626);
            }
        }

        public void EmitLoadLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 16638, 16743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16704, 16732);

                f_1502_16704_16731(this, f_1502_16709_16730(index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 16638, 16743);

                System.Management.Automation.Interpreter.Instruction
                f_1502_16709_16730(int
                index)
                {
                    var return_v = LoadLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16709, 16730);
                    return return_v;
                }


                int
                f_1502_16704_16731(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 16704, 16731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 16638, 16743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 16638, 16743);
            }
        }

        internal static Instruction LoadLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 16755, 17286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16833, 16966) || true) && (s_loadLocalBoxed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16833, 16966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16895, 16951);

                    s_loadLocalBoxed = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16833, 16966);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16982, 17275) || true) && (index < f_1502_16994_17017(s_loadLocalBoxed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16982, 17275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17051, 17150);

                    return s_loadLocalBoxed[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 17058, 17149) ?? (s_loadLocalBoxed[index] = f_1502_17112_17148(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16982, 17275);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 16982, 17275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17216, 17260);

                    return f_1502_17223_17259(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 16982, 17275);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 16755, 17286);

                int
                f_1502_16994_17017(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 16994, 17017);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadLocalBoxedInstruction
                f_1502_17112_17148(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17112, 17148);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadLocalBoxedInstruction
                f_1502_17223_17259(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17223, 17259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 16755, 17286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 16755, 17286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EmitLoadLocalFromClosure(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 17298, 17863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17370, 17515) || true) && (s_loadLocalFromClosure == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 17370, 17515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17438, 17500);

                    s_loadLocalFromClosure = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 17370, 17515);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17531, 17852) || true) && (index < f_1502_17543_17572(s_loadLocalFromClosure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 17531, 17852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17606, 17722);

                    f_1502_17606_17721(this, s_loadLocalFromClosure[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 17611, 17720) ?? (s_loadLocalFromClosure[index] = f_1502_17677_17719(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 17531, 17852);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 17531, 17852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17788, 17837);

                    f_1502_17788_17836(this, f_1502_17793_17835(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 17531, 17852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 17298, 17863);

                int
                f_1502_17543_17572(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 17543, 17572);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadLocalFromClosureInstruction
                f_1502_17677_17719(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalFromClosureInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17677, 17719);
                    return return_v;
                }


                int
                f_1502_17606_17721(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17606, 17721);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadLocalFromClosureInstruction
                f_1502_17793_17835(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalFromClosureInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17793, 17835);
                    return return_v;
                }


                int
                f_1502_17788_17836(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LoadLocalFromClosureInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 17788, 17836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 17298, 17863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 17298, 17863);
            }
        }

        public void EmitLoadLocalFromClosureBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 17875, 18480);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 17952, 18107) || true) && (s_loadLocalFromClosureBoxed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 17952, 18107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18025, 18092);

                    s_loadLocalFromClosureBoxed = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 17952, 18107);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18123, 18469) || true) && (index < f_1502_18135_18169(s_loadLocalFromClosureBoxed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 18123, 18469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18203, 18334);

                    f_1502_18203_18333(this, s_loadLocalFromClosureBoxed[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 18208, 18332) ?? (s_loadLocalFromClosureBoxed[index] = f_1502_18284_18331(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 18123, 18469);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 18123, 18469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18400, 18454);

                    f_1502_18400_18453(this, f_1502_18405_18452(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 18123, 18469);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 17875, 18480);

                int
                f_1502_18135_18169(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 18135, 18169);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadLocalFromClosureBoxedInstruction
                f_1502_18284_18331(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalFromClosureBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18284, 18331);
                    return return_v;
                }


                int
                f_1502_18203_18333(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18203, 18333);
                    return 0;
                }


                System.Management.Automation.Interpreter.LoadLocalFromClosureBoxedInstruction
                f_1502_18405_18452(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadLocalFromClosureBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18405, 18452);
                    return return_v;
                }


                int
                f_1502_18400_18453(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LoadLocalFromClosureBoxedInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18400, 18453);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 17875, 18480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 17875, 18480);
            }
        }

        public void EmitAssignLocal(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 18492, 18985);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18555, 18682) || true) && (s_assignLocal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 18555, 18682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18614, 18667);

                    s_assignLocal = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 18555, 18682);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18698, 18974) || true) && (index < f_1502_18710_18730(s_assignLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 18698, 18974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18764, 18853);

                    f_1502_18764_18852(this, s_assignLocal[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 18769, 18851) ?? (s_assignLocal[index] = f_1502_18817_18850(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 18698, 18974);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 18698, 18974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 18919, 18959);

                    f_1502_18919_18958(this, f_1502_18924_18957(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 18698, 18974);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 18492, 18985);

                int
                f_1502_18710_18730(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 18710, 18730);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AssignLocalInstruction
                f_1502_18817_18850(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18817, 18850);
                    return return_v;
                }


                int
                f_1502_18764_18852(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18764, 18852);
                    return 0;
                }


                System.Management.Automation.Interpreter.AssignLocalInstruction
                f_1502_18924_18957(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18924, 18957);
                    return return_v;
                }


                int
                f_1502_18919_18958(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.AssignLocalInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 18919, 18958);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 18492, 18985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 18492, 18985);
            }
        }

        public void EmitStoreLocal(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 18997, 19482);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19059, 19184) || true) && (s_storeLocal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19059, 19184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19117, 19169);

                    s_storeLocal = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19059, 19184);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19200, 19471) || true) && (index < f_1502_19212_19231(s_storeLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19200, 19471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19265, 19351);

                    f_1502_19265_19350(this, s_storeLocal[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 19270, 19349) ?? (s_storeLocal[index] = f_1502_19316_19348(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19200, 19471);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19200, 19471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19417, 19456);

                    f_1502_19417_19455(this, f_1502_19422_19454(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19200, 19471);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 18997, 19482);

                int
                f_1502_19212_19231(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 19212, 19231);
                    return return_v;
                }


                System.Management.Automation.Interpreter.StoreLocalInstruction
                f_1502_19316_19348(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19316, 19348);
                    return return_v;
                }


                int
                f_1502_19265_19350(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19265, 19350);
                    return 0;
                }


                System.Management.Automation.Interpreter.StoreLocalInstruction
                f_1502_19422_19454(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreLocalInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19422, 19454);
                    return return_v;
                }


                int
                f_1502_19417_19455(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.StoreLocalInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19417, 19455);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 18997, 19482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 18997, 19482);
            }
        }

        public void EmitAssignLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 19494, 19603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19562, 19592);

                f_1502_19562_19591(this, f_1502_19567_19590(index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 19494, 19603);

                System.Management.Automation.Interpreter.Instruction
                f_1502_19567_19590(int
                index)
                {
                    var return_v = AssignLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19567, 19590);
                    return return_v;
                }


                int
                f_1502_19562_19591(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19562, 19591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 19494, 19603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 19494, 19603);
            }
        }

        internal static Instruction AssignLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 19615, 20162);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19695, 19832) || true) && (s_assignLocalBoxed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19695, 19832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19759, 19817);

                    s_assignLocalBoxed = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19695, 19832);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19848, 20151) || true) && (index < f_1502_19860_19885(s_assignLocalBoxed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19848, 20151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 19919, 20024);

                    return s_assignLocalBoxed[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 19926, 20023) ?? (s_assignLocalBoxed[index] = f_1502_19984_20022(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19848, 20151);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 19848, 20151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20090, 20136);

                    return f_1502_20097_20135(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 19848, 20151);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 19615, 20162);

                int
                f_1502_19860_19885(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 19860, 19885);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AssignLocalBoxedInstruction
                f_1502_19984_20022(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 19984, 20022);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AssignLocalBoxedInstruction
                f_1502_20097_20135(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 20097, 20135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 19615, 20162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 19615, 20162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EmitStoreLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 20174, 20281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20241, 20270);

                f_1502_20241_20269(this, f_1502_20246_20268(index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 20174, 20281);

                System.Management.Automation.Interpreter.Instruction
                f_1502_20246_20268(int
                index)
                {
                    var return_v = StoreLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 20246, 20268);
                    return return_v;
                }


                int
                f_1502_20241_20269(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 20241, 20269);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 20174, 20281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 20174, 20281);
            }
        }

        internal static Instruction StoreLocalBoxed(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 20293, 20832);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20372, 20507) || true) && (s_storeLocalBoxed == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 20372, 20507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20435, 20492);

                    s_storeLocalBoxed = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 20372, 20507);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20523, 20821) || true) && (index < f_1502_20535_20559(s_storeLocalBoxed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 20523, 20821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20593, 20695);

                    return s_storeLocalBoxed[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 20600, 20694) ?? (s_storeLocalBoxed[index] = f_1502_20656_20693(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 20523, 20821);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 20523, 20821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20761, 20806);

                    return f_1502_20768_20805(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 20523, 20821);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 20293, 20832);

                int
                f_1502_20535_20559(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 20535, 20559);
                    return return_v;
                }


                System.Management.Automation.Interpreter.StoreLocalBoxedInstruction
                f_1502_20656_20693(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 20656, 20693);
                    return return_v;
                }


                System.Management.Automation.Interpreter.StoreLocalBoxedInstruction
                f_1502_20768_20805(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreLocalBoxedInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 20768, 20805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 20293, 20832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 20293, 20832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EmitAssignLocalToClosure(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 20844, 21409);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20916, 21061) || true) && (s_assignLocalToClosure == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 20916, 21061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 20984, 21046);

                    s_assignLocalToClosure = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 20916, 21061);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21077, 21398) || true) && (index < f_1502_21089_21118(s_assignLocalToClosure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21077, 21398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21152, 21268);

                    f_1502_21152_21267(this, s_assignLocalToClosure[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 21157, 21266) ?? (s_assignLocalToClosure[index] = f_1502_21223_21265(index))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21077, 21398);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21077, 21398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21334, 21383);

                    f_1502_21334_21382(this, f_1502_21339_21381(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21077, 21398);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 20844, 21409);

                int
                f_1502_21089_21118(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 21089, 21118);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AssignLocalToClosureInstruction
                f_1502_21223_21265(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalToClosureInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21223, 21265);
                    return return_v;
                }


                int
                f_1502_21152_21267(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21152, 21267);
                    return 0;
                }


                System.Management.Automation.Interpreter.AssignLocalToClosureInstruction
                f_1502_21339_21381(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.AssignLocalToClosureInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21339, 21381);
                    return return_v;
                }


                int
                f_1502_21334_21382(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.AssignLocalToClosureInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21334, 21382);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 20844, 21409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 20844, 21409);
            }
        }

        public void EmitStoreLocalToClosure(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 21421, 21559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21492, 21524);

                f_1502_21492_21523(this, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21538, 21548);

                f_1502_21538_21547(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 21421, 21559);

                int
                f_1502_21492_21523(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocalToClosure(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21492, 21523);
                    return 0;
                }


                int
                f_1502_21538_21547(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitPop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21538, 21547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 21421, 21559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 21421, 21559);
            }
        }

        public void EmitInitializeLocal(int index, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 21571, 22120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21649, 21719);

                object
                value = f_1502_21664_21718(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21733, 22109) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21733, 22109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21784, 21850);

                    f_1502_21784_21849(this, f_1502_21789_21848(index, value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21733, 22109);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21733, 22109);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21884, 22109) || true) && (f_1502_21888_21904(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21884, 22109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 21938, 22001);

                        f_1502_21938_22000(this, f_1502_21943_21999(index, type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21884, 22109);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 21884, 22109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22067, 22094);

                        f_1502_22067_22093(this, f_1502_22072_22092(index));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21884, 22109);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 21733, 22109);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 21571, 22120);

                object
                f_1502_21664_21718(System.Type
                type)
                {
                    var return_v = ScriptingRuntimeHelpers.GetPrimitiveDefaultValue(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21664, 21718);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableValue
                f_1502_21789_21848(int
                index, object
                defaultValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableValue(index, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21789, 21848);
                    return return_v;
                }


                int
                f_1502_21784_21849(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableValue
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21784, 21849);
                    return 0;
                }


                bool
                f_1502_21888_21904(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 21888, 21904);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.MutableValue
                f_1502_21943_21999(int
                index, System.Type
                type)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.MutableValue(index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21943, 21999);
                    return return_v;
                }


                int
                f_1502_21938_22000(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.InitializeLocalInstruction.MutableValue
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 21938, 22000);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_22072_22092(int
                index)
                {
                    var return_v = InitReference(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22072, 22092);
                    return return_v;
                }


                int
                f_1502_22067_22093(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22067, 22093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 21571, 22120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 21571, 22120);
            }
        }

        internal void EmitInitializeParameter(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 22132, 22239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22205, 22228);

                f_1502_22205_22227(this, f_1502_22210_22226(index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 22132, 22239);

                System.Management.Automation.Interpreter.Instruction
                f_1502_22210_22226(int
                index)
                {
                    var return_v = Parameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22210, 22226);
                    return return_v;
                }


                int
                f_1502_22205_22227(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22205, 22227);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 22132, 22239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 22132, 22239);
            }
        }

        internal static Instruction Parameter(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 22251, 22724);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22324, 22447) || true) && (s_parameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 22324, 22447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22381, 22432);

                    s_parameter = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 22324, 22447);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22463, 22642) || true) && (index < f_1502_22475_22493(s_parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 22463, 22642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22527, 22627);

                    return s_parameter[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 22534, 22626) ?? (s_parameter[index] = f_1502_22578_22625(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 22463, 22642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22658, 22713);

                return f_1502_22665_22712(index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 22251, 22724);

                int
                f_1502_22475_22493(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 22475, 22493);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.Parameter
                f_1502_22578_22625(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.Parameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22578, 22625);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.Parameter
                f_1502_22665_22712(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.Parameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 22665, 22712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 22251, 22724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 22251, 22724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Instruction ParameterBox(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 22736, 23233);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22812, 22941) || true) && (s_parameterBox == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 22812, 22941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22872, 22926);

                    s_parameterBox = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 22812, 22941);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 22957, 23148) || true) && (index < f_1502_22969_22990(s_parameterBox))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 22957, 23148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23024, 23133);

                    return s_parameterBox[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 23031, 23132) ?? (s_parameterBox[index] = f_1502_23081_23131(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 22957, 23148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23164, 23222);

                return f_1502_23171_23221(index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 22736, 23233);

                int
                f_1502_22969_22990(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 22969, 22990);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.ParameterBox
                f_1502_23081_23131(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ParameterBox(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 23081, 23131);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.ParameterBox
                f_1502_23171_23221(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ParameterBox(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 23171, 23221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 22736, 23233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 22736, 23233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Instruction InitReference(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 23245, 23742);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23322, 23453) || true) && (s_initReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 23322, 23453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23383, 23438);

                    s_initReference = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 23322, 23453);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23469, 23660) || true) && (index < f_1502_23481_23503(s_initReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 23469, 23660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23537, 23645);

                    return s_initReference[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 23544, 23644) ?? (s_initReference[index] = f_1502_23596_23643(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 23469, 23660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23676, 23731);

                return f_1502_23683_23730(index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 23245, 23742);

                int
                f_1502_23481_23503(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 23481, 23503);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.Reference
                f_1502_23596_23643(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.Reference(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 23596, 23643);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.Reference
                f_1502_23683_23730(int
                index)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.Reference(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 23683, 23730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 23245, 23742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 23245, 23742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Instruction InitImmutableRefBox(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 23754, 24305);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23837, 23980) || true) && (s_initImmutableRefBox == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 23837, 23980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23904, 23965);

                    s_initImmutableRefBox = new Instruction[LocalInstrCacheSize];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 23837, 23980);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 23996, 24214) || true) && (index < f_1502_24008_24036(s_initImmutableRefBox))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 23996, 24214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24070, 24199);

                    return s_initImmutableRefBox[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1502, 24077, 24198) ?? (s_initImmutableRefBox[index] = f_1502_24141_24197(index, null)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 23996, 24214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24230, 24294);

                return f_1502_24237_24293(index, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 23754, 24305);

                int
                f_1502_24008_24036(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 24008, 24036);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox
                f_1502_24141_24197(int
                index, object
                defaultValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox(index, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24141, 24197);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox
                f_1502_24237_24293(int
                index, object
                defaultValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox(index, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24237, 24293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 23754, 24305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 23754, 24305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EmitNewRuntimeVariables(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 24317, 24444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24388, 24433);

                f_1502_24388_24432(this, f_1502_24393_24431(count));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 24317, 24444);

                System.Management.Automation.Interpreter.RuntimeVariablesInstruction
                f_1502_24393_24431(int
                count)
                {
                    var return_v = new System.Management.Automation.Interpreter.RuntimeVariablesInstruction(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24393, 24431);
                    return return_v;
                }


                int
                f_1502_24388_24432(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.RuntimeVariablesInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24388, 24432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 24317, 24444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 24317, 24444);
            }
        }

        public void EmitGetArrayItem(Type arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 24514, 24938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24583, 24628);

                var
                elementType = f_1502_24601_24627(arrayType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24642, 24927) || true) && (f_1502_24646_24665(elementType) || (DynAbs.Tracing.TraceSender.Expression_False(1502, 24646, 24692) || f_1502_24669_24692(elementType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 24642, 24927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24726, 24782);

                    f_1502_24726_24781(this, f_1502_24731_24780(InstructionFactory<object>.Factory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 24642, 24927);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 24642, 24927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 24848, 24912);

                    f_1502_24848_24911(this, f_1502_24853_24910(f_1502_24853_24895(elementType)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 24642, 24927);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 24514, 24938);

                System.Type?
                f_1502_24601_24627(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24601, 24627);
                    return return_v;
                }


                bool
                f_1502_24646_24665(System.Type
                this_param)
                {
                    var return_v = this_param.IsClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 24646, 24665);
                    return return_v;
                }


                bool
                f_1502_24669_24692(System.Type
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 24669, 24692);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_24731_24780(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.GetArrayItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24731, 24780);
                    return return_v;
                }


                int
                f_1502_24726_24781(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24726, 24781);
                    return 0;
                }


                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_24853_24895(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24853, 24895);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_24853_24910(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.GetArrayItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24853, 24910);
                    return return_v;
                }


                int
                f_1502_24848_24911(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 24848, 24911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 24514, 24938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 24514, 24938);
            }
        }

        public void EmitSetArrayItem(Type arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 24950, 25374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25019, 25064);

                var
                elementType = f_1502_25037_25063(arrayType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25078, 25363) || true) && (f_1502_25082_25101(elementType) || (DynAbs.Tracing.TraceSender.Expression_False(1502, 25082, 25128) || f_1502_25105_25128(elementType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 25078, 25363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25162, 25218);

                    f_1502_25162_25217(this, f_1502_25167_25216(InstructionFactory<object>.Factory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 25078, 25363);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 25078, 25363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25284, 25348);

                    f_1502_25284_25347(this, f_1502_25289_25346(f_1502_25289_25331(elementType)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 25078, 25363);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 24950, 25374);

                System.Type?
                f_1502_25037_25063(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25037, 25063);
                    return return_v;
                }


                bool
                f_1502_25082_25101(System.Type
                this_param)
                {
                    var return_v = this_param.IsClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 25082, 25101);
                    return return_v;
                }


                bool
                f_1502_25105_25128(System.Type
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 25105, 25128);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_25167_25216(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.SetArrayItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25167, 25216);
                    return return_v;
                }


                int
                f_1502_25162_25217(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25162, 25217);
                    return 0;
                }


                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_25289_25331(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25289, 25331);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_25289_25346(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.SetArrayItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25289, 25346);
                    return return_v;
                }


                int
                f_1502_25284_25347(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25284, 25347);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 24950, 25374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 24950, 25374);
            }
        }

        public void EmitNewArray(Type elementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 25386, 25524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25453, 25513);

                f_1502_25453_25512(this, f_1502_25458_25511(f_1502_25458_25500(elementType)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 25386, 25524);

                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_25458_25500(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25458, 25500);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_25458_25511(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.NewArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25458, 25511);
                    return return_v;
                }


                int
                f_1502_25453_25512(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25453, 25512);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 25386, 25524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 25386, 25524);
            }
        }

        public void EmitNewArrayBounds(Type elementType, int rank)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 25536, 25685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25619, 25674);

                f_1502_25619_25673(this, f_1502_25624_25672(elementType, rank));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 25536, 25685);

                System.Management.Automation.Interpreter.NewArrayBoundsInstruction
                f_1502_25624_25672(System.Type
                elementType, int
                rank)
                {
                    var return_v = new System.Management.Automation.Interpreter.NewArrayBoundsInstruction(elementType, rank);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25624, 25672);
                    return return_v;
                }


                int
                f_1502_25619_25673(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.NewArrayBoundsInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 25619, 25673);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 25536, 25685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 25536, 25685);
            }
        }

        public void EmitNewArrayInit(Type elementType, int elementCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 25697, 26838);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 25952, 26827) || true) && (elementType == typeof(CommandParameterInternal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 25952, 26827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26037, 26123);

                    f_1502_26037_26122(this, f_1502_26042_26121(InstructionFactory<CommandParameterInternal>.Factory, elementCount));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 25952, 26827);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 25952, 26827);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26157, 26827) || true) && (elementType == typeof(CommandParameterInternal[]))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26157, 26827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26244, 26332);

                        f_1502_26244_26331(this, f_1502_26249_26330(InstructionFactory<CommandParameterInternal[]>.Factory, elementCount));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26157, 26827);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26157, 26827);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26366, 26827) || true) && (elementType == typeof(object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26366, 26827);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26433, 26501);

                            f_1502_26433_26500(this, f_1502_26438_26499(InstructionFactory<object>.Factory, elementCount));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26366, 26827);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26366, 26827);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26535, 26827) || true) && (elementType == typeof(string))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26535, 26827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26602, 26670);

                                f_1502_26602_26669(this, f_1502_26607_26668(InstructionFactory<string>.Factory, elementCount));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26535, 26827);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26535, 26827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26736, 26812);

                                f_1502_26736_26811(this, f_1502_26741_26810(f_1502_26741_26783(elementType), elementCount));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26535, 26827);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26366, 26827);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26157, 26827);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 25952, 26827);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 25697, 26838);

                System.Management.Automation.Interpreter.Instruction
                f_1502_26042_26121(System.Management.Automation.Interpreter.InstructionFactory
                this_param, int
                elementCount)
                {
                    var return_v = this_param.NewArrayInit(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26042, 26121);
                    return return_v;
                }


                int
                f_1502_26037_26122(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26037, 26122);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_26249_26330(System.Management.Automation.Interpreter.InstructionFactory
                this_param, int
                elementCount)
                {
                    var return_v = this_param.NewArrayInit(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26249, 26330);
                    return return_v;
                }


                int
                f_1502_26244_26331(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26244, 26331);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_26438_26499(System.Management.Automation.Interpreter.InstructionFactory
                this_param, int
                elementCount)
                {
                    var return_v = this_param.NewArrayInit(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26438, 26499);
                    return return_v;
                }


                int
                f_1502_26433_26500(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26433, 26500);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_26607_26668(System.Management.Automation.Interpreter.InstructionFactory
                this_param, int
                elementCount)
                {
                    var return_v = this_param.NewArrayInit(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26607, 26668);
                    return return_v;
                }


                int
                f_1502_26602_26669(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26602, 26669);
                    return 0;
                }


                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_26741_26783(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26741, 26783);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_26741_26810(System.Management.Automation.Interpreter.InstructionFactory
                this_param, int
                elementCount)
                {
                    var return_v = this_param.NewArrayInit(elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26741, 26810);
                    return return_v;
                }


                int
                f_1502_26736_26811(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 26736, 26811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 25697, 26838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 25697, 26838);
            }
        }

        public void EmitAdd(Type type, bool @checked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 26913, 27192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 26983, 27181) || true) && (@checked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26983, 27181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27029, 27066);

                    f_1502_27029_27065(this, f_1502_27034_27064(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26983, 27181);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 26983, 27181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27132, 27166);

                    f_1502_27132_27165(this, f_1502_27137_27164(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 26983, 27181);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 26913, 27192);

                System.Management.Automation.Interpreter.Instruction
                f_1502_27034_27064(System.Type
                type)
                {
                    var return_v = AddOvfInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27034, 27064);
                    return return_v;
                }


                int
                f_1502_27029_27065(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27029, 27065);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_27137_27164(System.Type
                type)
                {
                    var return_v = AddInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27137, 27164);
                    return return_v;
                }


                int
                f_1502_27132_27165(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27132, 27165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 26913, 27192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 26913, 27192);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        public void EmitSub(Type type, bool @checked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 27204, 27594);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27385, 27583) || true) && (@checked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 27385, 27583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27431, 27468);

                    f_1502_27431_27467(this, f_1502_27436_27466(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 27385, 27583);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 27385, 27583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27534, 27568);

                    f_1502_27534_27567(this, f_1502_27539_27566(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 27385, 27583);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 27204, 27594);

                System.Management.Automation.Interpreter.Instruction
                f_1502_27436_27466(System.Type
                type)
                {
                    var return_v = SubOvfInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27436, 27466);
                    return return_v;
                }


                int
                f_1502_27431_27467(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27431, 27467);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_27539_27566(System.Type
                type)
                {
                    var return_v = SubInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27539, 27566);
                    return return_v;
                }


                int
                f_1502_27534_27567(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27534, 27567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 27204, 27594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 27204, 27594);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        public void EmitMul(Type type, bool @checked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 27606, 27996);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27787, 27985) || true) && (@checked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 27787, 27985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27833, 27870);

                    f_1502_27833_27869(this, f_1502_27838_27868(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 27787, 27985);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 27787, 27985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 27936, 27970);

                    f_1502_27936_27969(this, f_1502_27941_27968(type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 27787, 27985);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 27606, 27996);

                System.Management.Automation.Interpreter.Instruction
                f_1502_27838_27868(System.Type
                type)
                {
                    var return_v = MulOvfInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27838, 27868);
                    return return_v;
                }


                int
                f_1502_27833_27869(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27833, 27869);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_27941_27968(System.Type
                type)
                {
                    var return_v = MulInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27941, 27968);
                    return return_v;
                }


                int
                f_1502_27936_27969(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 27936, 27969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 27606, 27996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 27606, 27996);
            }
        }

        public void EmitDiv(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28008, 28108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28063, 28097);

                f_1502_28063_28096(this, f_1502_28068_28095(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28008, 28108);

                System.Management.Automation.Interpreter.Instruction
                f_1502_28068_28095(System.Type
                type)
                {
                    var return_v = DivInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28068, 28095);
                    return return_v;
                }


                int
                f_1502_28063_28096(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28063, 28096);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28008, 28108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28008, 28108);
            }
        }

        public void EmitEqual(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28173, 28277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28230, 28266);

                f_1502_28230_28265(this, f_1502_28235_28264(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28173, 28277);

                System.Management.Automation.Interpreter.Instruction
                f_1502_28235_28264(System.Type
                type)
                {
                    var return_v = EqualInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28235, 28264);
                    return return_v;
                }


                int
                f_1502_28230_28265(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28230, 28265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28173, 28277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28173, 28277);
            }
        }

        public void EmitNotEqual(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28289, 28399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28349, 28388);

                f_1502_28349_28387(this, f_1502_28354_28386(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28289, 28399);

                System.Management.Automation.Interpreter.Instruction
                f_1502_28354_28386(System.Type
                type)
                {
                    var return_v = NotEqualInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28354, 28386);
                    return return_v;
                }


                int
                f_1502_28349_28387(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28349, 28387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28289, 28399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28289, 28399);
            }
        }

        public void EmitLessThan(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28411, 28521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28471, 28510);

                f_1502_28471_28509(this, f_1502_28476_28508(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28411, 28521);

                System.Management.Automation.Interpreter.Instruction
                f_1502_28476_28508(System.Type
                type)
                {
                    var return_v = LessThanInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28476, 28508);
                    return return_v;
                }


                int
                f_1502_28471_28509(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28471, 28509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28411, 28521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28411, 28521);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        public void EmitLessThanOrEqual(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28533, 28756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28711, 28745);

                throw f_1502_28717_28744();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28533, 28756);

                System.NotSupportedException
                f_1502_28717_28744()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28717, 28744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28533, 28756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28533, 28756);
            }
        }

        public void EmitGreaterThan(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28768, 28884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 28831, 28873);

                f_1502_28831_28872(this, f_1502_28836_28871(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28768, 28884);

                System.Management.Automation.Interpreter.Instruction
                f_1502_28836_28871(System.Type
                type)
                {
                    var return_v = GreaterThanInstruction.Create(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28836, 28871);
                    return return_v;
                }


                int
                f_1502_28831_28872(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 28831, 28872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28768, 28884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28768, 28884);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        public void EmitGreaterThanOrEqual(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 28896, 29122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29077, 29111);

                throw f_1502_29083_29110();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 28896, 29122);

                System.NotSupportedException
                f_1502_29083_29110()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29083, 29110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 28896, 29122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 28896, 29122);
            }
        }

        public void EmitNumericConvertChecked(TypeCode from, TypeCode to)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 29187, 29342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29277, 29331);

                f_1502_29277_29330(this, f_1502_29282_29329(from, to));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 29187, 29342);

                System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                f_1502_29282_29329(System.TypeCode
                from, System.TypeCode
                to)
                {
                    var return_v = new System.Management.Automation.Interpreter.NumericConvertInstruction.Checked(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29282, 29329);
                    return return_v;
                }


                int
                f_1502_29277_29330(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29277, 29330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 29187, 29342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 29187, 29342);
            }
        }

        public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 29354, 29513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29446, 29502);

                f_1502_29446_29501(this, f_1502_29451_29500(from, to));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 29354, 29513);

                System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                f_1502_29451_29500(System.TypeCode
                from, System.TypeCode
                to)
                {
                    var return_v = new System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29451, 29500);
                    return return_v;
                }


                int
                f_1502_29446_29501(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29446, 29501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 29354, 29513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 29354, 29513);
            }
        }

        public void EmitNot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 29584, 29671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29630, 29660);

                f_1502_29630_29659(this, NotInstruction.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 29584, 29671);

                int
                f_1502_29630_29659(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29630, 29659);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 29584, 29671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 29584, 29671);
            }
        }

        public void EmitDefaultValue(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 29730, 29862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29794, 29851);

                f_1502_29794_29850(this, f_1502_29799_29849(f_1502_29799_29834(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 29730, 29862);

                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_29799_29834(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29799, 29834);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_29799_29849(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.DefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29799, 29849);
                    return return_v;
                }


                int
                f_1502_29794_29850(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29794, 29850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 29730, 29862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 29730, 29862);
            }
        }

        public void EmitNew(ConstructorInfo constructorInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 29874, 30004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 29951, 29993);

                f_1502_29951_29992(this, f_1502_29956_29991(constructorInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 29874, 30004);

                System.Management.Automation.Interpreter.NewInstruction
                f_1502_29956_29991(System.Reflection.ConstructorInfo
                constructor)
                {
                    var return_v = new System.Management.Automation.Interpreter.NewInstruction(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29956, 29991);
                    return return_v;
                }


                int
                f_1502_29951_29992(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.NewInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 29951, 29992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 29874, 30004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 29874, 30004);
            }
        }

        internal void EmitCreateDelegate(LightDelegateCreator creator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30016, 30159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30103, 30148);

                f_1502_30103_30147(this, f_1502_30108_30146(creator));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30016, 30159);

                System.Management.Automation.Interpreter.CreateDelegateInstruction
                f_1502_30108_30146(System.Management.Automation.Interpreter.LightDelegateCreator
                delegateCreator)
                {
                    var return_v = new System.Management.Automation.Interpreter.CreateDelegateInstruction(delegateCreator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30108, 30146);
                    return return_v;
                }


                int
                f_1502_30103_30147(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.CreateDelegateInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30103, 30147);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30016, 30159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30016, 30159);
            }
        }

        public void EmitTypeEquals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30171, 30272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30224, 30261);

                f_1502_30224_30260(this, TypeEqualsInstruction.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30171, 30272);

                int
                f_1502_30224_30260(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.TypeEqualsInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30224, 30260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30171, 30272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30171, 30272);
            }
        }

        public void EmitTypeIs(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30284, 30404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30342, 30393);

                f_1502_30342_30392(this, f_1502_30347_30391(f_1502_30347_30382(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30284, 30404);

                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_30347_30382(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30347, 30382);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_30347_30391(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.TypeIs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30347, 30391);
                    return return_v;
                }


                int
                f_1502_30342_30392(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30342, 30392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30284, 30404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30284, 30404);
            }
        }

        public void EmitTypeAs(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30416, 30536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30474, 30525);

                f_1502_30474_30524(this, f_1502_30479_30523(f_1502_30479_30514(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30416, 30536);

                System.Management.Automation.Interpreter.InstructionFactory
                f_1502_30479_30514(System.Type
                type)
                {
                    var return_v = InstructionFactory.GetFactory(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30479, 30514);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_30479_30523(System.Management.Automation.Interpreter.InstructionFactory
                this_param)
                {
                    var return_v = this_param.TypeAs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30479, 30523);
                    return return_v;
                }


                int
                f_1502_30474_30524(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30474, 30524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30416, 30536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30416, 30536);
            }
        }

        private static readonly Dictionary<FieldInfo, Instruction> s_loadFields;

        public void EmitLoadField(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30735, 30839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30802, 30828);

                f_1502_30802_30827(this, f_1502_30807_30826(this, field));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30735, 30839);

                System.Management.Automation.Interpreter.Instruction
                f_1502_30807_30826(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.FieldInfo
                field)
                {
                    var return_v = this_param.GetLoadField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30807, 30826);
                    return return_v;
                }


                int
                f_1502_30802_30827(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30802, 30827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30735, 30839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30735, 30839);
            }
        }

        private Instruction GetLoadField(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 30851, 31546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30931, 30943);
                lock (s_loadFields)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30977, 31001);

                    Instruction
                    instruction
                    = default(Instruction);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31019, 31481) || true) && (!f_1502_31024_31072(s_loadFields, field, out instruction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 31019, 31481);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31114, 31401) || true) && (f_1502_31118_31132(field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 31114, 31401);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31182, 31234);

                            instruction = f_1502_31196_31233(field);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 31114, 31401);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 31114, 31401);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31332, 31378);

                            instruction = f_1502_31346_31377(field);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 31114, 31401);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31425, 31462);

                        f_1502_31425_31461(
                                            s_loadFields, field, instruction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 31019, 31481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31501, 31520);

                    return instruction;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 30851, 31546);

                bool
                f_1502_31024_31072(System.Collections.Generic.Dictionary<System.Reflection.FieldInfo, System.Management.Automation.Interpreter.Instruction>
                this_param, System.Reflection.FieldInfo
                key, out System.Management.Automation.Interpreter.Instruction
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31024, 31072);
                    return return_v;
                }


                bool
                f_1502_31118_31132(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 31118, 31132);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadStaticFieldInstruction
                f_1502_31196_31233(System.Reflection.FieldInfo
                field)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadStaticFieldInstruction(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31196, 31233);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoadFieldInstruction
                f_1502_31346_31377(System.Reflection.FieldInfo
                field)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoadFieldInstruction(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31346, 31377);
                    return return_v;
                }


                int
                f_1502_31425_31461(System.Collections.Generic.Dictionary<System.Reflection.FieldInfo, System.Management.Automation.Interpreter.Instruction>
                this_param, System.Reflection.FieldInfo
                key, System.Management.Automation.Interpreter.Instruction
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31425, 31461);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 30851, 31546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 30851, 31546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void EmitStoreField(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 31558, 31854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31626, 31843) || true) && (f_1502_31630_31644(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 31626, 31843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31678, 31723);

                    f_1502_31678_31722(this, f_1502_31683_31721(field));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 31626, 31843);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 31626, 31843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31789, 31828);

                    f_1502_31789_31827(this, f_1502_31794_31826(field));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 31626, 31843);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 31558, 31854);

                bool
                f_1502_31630_31644(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 31630, 31644);
                    return return_v;
                }


                System.Management.Automation.Interpreter.StoreStaticFieldInstruction
                f_1502_31683_31721(System.Reflection.FieldInfo
                field)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreStaticFieldInstruction(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31683, 31721);
                    return return_v;
                }


                int
                f_1502_31678_31722(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.StoreStaticFieldInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31678, 31722);
                    return 0;
                }


                System.Management.Automation.Interpreter.StoreFieldInstruction
                f_1502_31794_31826(System.Reflection.FieldInfo
                field)
                {
                    var return_v = new System.Management.Automation.Interpreter.StoreFieldInstruction(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31794, 31826);
                    return return_v;
                }


                int
                f_1502_31789_31827(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.StoreFieldInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31789, 31827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 31558, 31854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 31558, 31854);
            }
        }

        public void EmitCall(MethodInfo method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 31866, 31982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 31930, 31971);

                f_1502_31930_31970(this, method, f_1502_31947_31969(method));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 31866, 31982);

                System.Reflection.ParameterInfo[]
                f_1502_31947_31969(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31947, 31969);
                    return return_v;
                }


                int
                f_1502_31930_31970(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method, System.Reflection.ParameterInfo[]
                parameters)
                {
                    this_param.EmitCall(method, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 31930, 31970);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 31866, 31982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 31866, 31982);
            }
        }

        public void EmitCall(MethodInfo method, ParameterInfo[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 31994, 32146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 32086, 32135);

                f_1502_32086_32134(this, f_1502_32091_32133(method, parameters));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 31994, 32146);

                System.Management.Automation.Interpreter.CallInstruction
                f_1502_32091_32133(System.Reflection.MethodInfo
                info, System.Reflection.ParameterInfo[]
                parameters)
                {
                    var return_v = CallInstruction.Create(info, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32091, 32133);
                    return return_v;
                }


                int
                f_1502_32086_32134(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.CallInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32086, 32134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 31994, 32146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 31994, 32146);
            }
        }

        public void EmitDynamic(Type type, CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 32207, 32345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 32289, 32334);

                f_1502_32289_32333(this, f_1502_32294_32332(type, binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 32207, 32345);

                System.Management.Automation.Interpreter.Instruction
                f_1502_32294_32332(System.Type
                delegateType, System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CreateDynamicInstruction(delegateType, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32294, 32332);
                    return return_v;
                }


                int
                f_1502_32289_32333(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32289, 32333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 32207, 32345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 32207, 32345);
            }
        }

        public void EmitDynamic<T0, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 32563, 32706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 32644, 32695);

                f_1502_32644_32694(this, f_1502_32649_32693(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 32563, 32706);

                System.Management.Automation.Interpreter.Instruction
                f_1502_32649_32693(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32649, 32693);
                    return return_v;
                }


                int
                f_1502_32644_32694(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32644, 32694);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 32563, 32706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 32563, 32706);
            }
        }

        public void EmitDynamic<T0, T1, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 32718, 32869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 32803, 32858);

                f_1502_32803_32857(this, f_1502_32808_32856(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 32718, 32869);

                System.Management.Automation.Interpreter.Instruction
                f_1502_32808_32856(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32808, 32856);
                    return return_v;
                }


                int
                f_1502_32803_32857(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32803, 32857);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 32718, 32869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 32718, 32869);
            }
        }

        public void EmitDynamic<T0, T1, T2, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 32881, 33040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 32970, 33029);

                f_1502_32970_33028(this, f_1502_32975_33027(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 32881, 33040);

                System.Management.Automation.Interpreter.Instruction
                f_1502_32975_33027(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32975, 33027);
                    return return_v;
                }


                int
                f_1502_32970_33028(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 32970, 33028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 32881, 33040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 32881, 33040);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 33052, 33219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 33145, 33208);

                f_1502_33145_33207(this, f_1502_33150_33206(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 33052, 33219);

                System.Management.Automation.Interpreter.Instruction
                f_1502_33150_33206(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33150, 33206);
                    return return_v;
                }


                int
                f_1502_33145_33207(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33145, 33207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 33052, 33219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 33052, 33219);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 33231, 33406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 33328, 33395);

                f_1502_33328_33394(this, f_1502_33333_33393(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 33231, 33406);

                System.Management.Automation.Interpreter.Instruction
                f_1502_33333_33393(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33333, 33393);
                    return return_v;
                }


                int
                f_1502_33328_33394(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33328, 33394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 33231, 33406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 33231, 33406);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 33418, 33601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 33519, 33590);

                f_1502_33519_33589(this, f_1502_33524_33588(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 33418, 33601);

                System.Management.Automation.Interpreter.Instruction
                f_1502_33524_33588(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33524, 33588);
                    return return_v;
                }


                int
                f_1502_33519_33589(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33519, 33589);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 33418, 33601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 33418, 33601);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 33613, 33804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 33718, 33793);

                f_1502_33718_33792(this, f_1502_33723_33791(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 33613, 33804);

                System.Management.Automation.Interpreter.Instruction
                f_1502_33723_33791(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33723, 33791);
                    return return_v;
                }


                int
                f_1502_33718_33792(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33718, 33792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 33613, 33804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 33613, 33804);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 33816, 34015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 33925, 34004);

                f_1502_33925_34003(this, f_1502_33930_34002(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 33816, 34015);

                System.Management.Automation.Interpreter.Instruction
                f_1502_33930_34002(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33930, 34002);
                    return return_v;
                }


                int
                f_1502_33925_34003(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 33925, 34003);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 33816, 34015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 33816, 34015);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 34027, 34234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 34140, 34223);

                f_1502_34140_34222(this, f_1502_34145_34221(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 34027, 34234);

                System.Management.Automation.Interpreter.Instruction
                f_1502_34145_34221(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34145, 34221);
                    return return_v;
                }


                int
                f_1502_34140_34222(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34140, 34222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 34027, 34234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 34027, 34234);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 34246, 34461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 34363, 34450);

                f_1502_34363_34449(this, f_1502_34368_34448(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 34246, 34461);

                System.Management.Automation.Interpreter.Instruction
                f_1502_34368_34448(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34368, 34448);
                    return return_v;
                }


                int
                f_1502_34363_34449(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34363, 34449);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 34246, 34461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 34246, 34461);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 34473, 34698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 34595, 34687);

                f_1502_34595_34686(this, f_1502_34600_34685(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 34473, 34698);

                System.Management.Automation.Interpreter.Instruction
                f_1502_34600_34685(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34600, 34685);
                    return return_v;
                }


                int
                f_1502_34595_34686(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34595, 34686);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 34473, 34698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 34473, 34698);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 34710, 34945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 34837, 34934);

                f_1502_34837_34933(this, f_1502_34842_34932(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 34710, 34945);

                System.Management.Automation.Interpreter.Instruction
                f_1502_34842_34932(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34842, 34932);
                    return return_v;
                }


                int
                f_1502_34837_34933(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 34837, 34933);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 34710, 34945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 34710, 34945);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 34957, 35202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 35089, 35191);

                f_1502_35089_35190(this, f_1502_35094_35189(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 34957, 35202);

                System.Management.Automation.Interpreter.Instruction
                f_1502_35094_35189(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35094, 35189);
                    return return_v;
                }


                int
                f_1502_35089_35190(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35089, 35190);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 34957, 35202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 34957, 35202);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 35214, 35469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 35351, 35458);

                f_1502_35351_35457(this, f_1502_35356_35456(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 35214, 35469);

                System.Management.Automation.Interpreter.Instruction
                f_1502_35356_35456(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35356, 35456);
                    return return_v;
                }


                int
                f_1502_35351_35457(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35351, 35457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 35214, 35469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 35214, 35469);
            }
        }

        public void EmitDynamic<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 35481, 35746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 35623, 35735);

                f_1502_35623_35734(this, f_1502_35628_35733(binder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 35481, 35746);

                System.Management.Automation.Interpreter.Instruction
                f_1502_35628_35733(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35628, 35733);
                    return return_v;
                }


                int
                f_1502_35623_35734(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35623, 35734);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 35481, 35746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 35481, 35746);
            }
        }

        private static Dictionary<Type, Func<CallSiteBinder, Instruction>> s_factories;

        internal static Instruction CreateDynamicInstruction(Type delegateType, CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1502, 35985, 37404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36104, 36146);

                Func<CallSiteBinder, Instruction>
                factory
                = default(Func<CallSiteBinder, Instruction>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36166, 36177);
                lock (s_factories)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36211, 37339) || true) && (!f_1502_36216_36266(s_factories, delegateType, out factory))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 36211, 37339);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36308, 36732) || true) && (f_1502_36312_36355(f_1502_36312_36344(delegateType, "Invoke")) == typeof(void))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 36308, 36732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36619, 36709);

                            return f_1502_36626_36708(delegateType, f_1502_36664_36701(delegateType, binder), true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 36308, 36732);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36756, 36839);

                        Type
                        instructionType = f_1502_36779_36838(delegateType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36861, 37045) || true) && (instructionType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 36861, 37045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 36938, 37022);

                            return f_1502_36945_37021(delegateType, f_1502_36983_37020(delegateType, binder));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 36861, 37045);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37069, 37260);

                        factory =
                                                (Func<CallSiteBinder, Instruction>)
                        f_1502_37165_37259(f_1502_37165_37201(instructionType, "Factory"), typeof(Func<CallSiteBinder, Instruction>));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37284, 37320);

                        s_factories[delegateType] = factory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 36211, 37339);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37370, 37393);

                return f_1502_37377_37392(factory, binder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1502, 35985, 37404);

                bool
                f_1502_36216_36266(System.Collections.Generic.Dictionary<System.Type, System.Func<System.Runtime.CompilerServices.CallSiteBinder, System.Management.Automation.Interpreter.Instruction>>
                this_param, System.Type
                key, out System.Func<System.Runtime.CompilerServices.CallSiteBinder, System.Management.Automation.Interpreter.Instruction>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36216, 36266);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1502_36312_36344(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36312, 36344);
                    return return_v;
                }


                System.Type
                f_1502_36312_36355(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 36312, 36355);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite
                f_1502_36664_36701(System.Type
                delegateType, System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite.Create(delegateType, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36664, 36701);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstructionN
                f_1502_36626_36708(System.Type
                delegateType, System.Runtime.CompilerServices.CallSite
                site, bool
                isVoid)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstructionN(delegateType, site, isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36626, 36708);
                    return return_v;
                }


                System.Type
                f_1502_36779_36838(System.Type
                delegateType)
                {
                    var return_v = DynamicInstructionN.GetDynamicInstructionType(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36779, 36838);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite
                f_1502_36983_37020(System.Type
                delegateType, System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite.Create(delegateType, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36983, 37020);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstructionN
                f_1502_36945_37021(System.Type
                delegateType, System.Runtime.CompilerServices.CallSite
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstructionN(delegateType, site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 36945, 37021);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1502_37165_37201(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 37165, 37201);
                    return return_v;
                }


                System.Delegate
                f_1502_37165_37259(System.Reflection.MethodInfo
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 37165, 37259);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_37377_37392(System.Func<System.Runtime.CompilerServices.CallSiteBinder, System.Management.Automation.Interpreter.Instruction>
                this_param, System.Runtime.CompilerServices.CallSiteBinder
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 37377, 37392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 35985, 37404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 35985, 37404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly RuntimeLabel[] s_emptyRuntimeLabels;

        private RuntimeLabel[] BuildRuntimeLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 37619, 38274);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37687, 37791) || true) && (_runtimeLabelCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 37687, 37791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37748, 37776);

                    return s_emptyRuntimeLabels;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 37687, 37791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37807, 37861);

                var
                result = new RuntimeLabel[_runtimeLabelCount + 1]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37875, 38097);
                    foreach (BranchLabel label in f_1502_37905_37912_I(_labels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 37875, 38097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37946, 38082) || true) && (f_1502_37950_37971(label))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 37946, 38082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38013, 38063);

                            result[f_1502_38020_38036(label)] = f_1502_38040_38062(label);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 37946, 38082);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 37875, 38097);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1502, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1502, 1, 223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38155, 38235);

                result[f_1502_38162_38175(result) - 1] = f_1502_38183_38234(Interpreter.RethrowOnReturn, 0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38249, 38263);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 37619, 38274);

                bool
                f_1502_37950_37971(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.HasRuntimeLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 37950, 37971);
                    return return_v;
                }


                int
                f_1502_38020_38036(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.LabelIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 38020, 38036);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RuntimeLabel
                f_1502_38040_38062(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.ToRuntimeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38040, 38062);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Interpreter.BranchLabel>
                f_1502_37905_37912_I(System.Collections.Generic.List<System.Management.Automation.Interpreter.BranchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 37905, 37912);
                    return return_v;
                }


                int
                f_1502_38162_38175(System.Management.Automation.Interpreter.RuntimeLabel[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 38162, 38175);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RuntimeLabel
                f_1502_38183_38234(int
                index, int
                continuationStackDepth, int
                stackDepth)
                {
                    var return_v = new System.Management.Automation.Interpreter.RuntimeLabel(index, continuationStackDepth, stackDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38183, 38234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 37619, 38274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 37619, 38274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BranchLabel MakeLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 38286, 38560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38341, 38443) || true) && (_labels == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 38341, 38443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38394, 38428);

                    _labels = f_1502_38404_38427();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 38341, 38443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38459, 38489);

                var
                label = f_1502_38471_38488()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38503, 38522);

                f_1502_38503_38521(_labels, label);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38536, 38549);

                return label;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 38286, 38560);

                System.Collections.Generic.List<System.Management.Automation.Interpreter.BranchLabel>
                f_1502_38404_38427()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.BranchLabel>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38404, 38427);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1502_38471_38488()
                {
                    var return_v = new System.Management.Automation.Interpreter.BranchLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38471, 38488);
                    return return_v;
                }


                int
                f_1502_38503_38521(System.Collections.Generic.List<System.Management.Automation.Interpreter.BranchLabel>
                this_param, System.Management.Automation.Interpreter.BranchLabel
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38503, 38521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 38286, 38560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 38286, 38560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FixupBranch(int branchIndex, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 38572, 38753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38651, 38742);

                _instructions[branchIndex] = f_1502_38680_38741(((OffsetInstruction)f_1502_38700_38726(_instructions, branchIndex)), offset);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 38572, 38753);

                System.Management.Automation.Interpreter.Instruction
                f_1502_38700_38726(System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 38700, 38726);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1502_38680_38741(System.Management.Automation.Interpreter.OffsetInstruction
                this_param, int
                offset)
                {
                    var return_v = this_param.Fixup(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 38680, 38741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 38572, 38753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 38572, 38753);
            }
        }

        private int EnsureLabelIndex(BranchLabel label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 38765, 39073);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38837, 38935) || true) && (f_1502_38841_38862(label))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1502, 38837, 38935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38896, 38920);

                    return f_1502_38903_38919(label);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1502, 38837, 38935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 38951, 38989);

                label.LabelIndex = _runtimeLabelCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39003, 39024);

                _runtimeLabelCount++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39038, 39062);

                return f_1502_39045_39061(label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 38765, 39073);

                bool
                f_1502_38841_38862(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.HasRuntimeLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 38841, 38862);
                    return return_v;
                }


                int
                f_1502_38903_38919(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.LabelIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 38903, 38919);
                    return return_v;
                }


                int
                f_1502_39045_39061(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.LabelIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 39045, 39061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 38765, 39073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 38765, 39073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int MarkRuntimeLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39085, 39279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39139, 39178);

                BranchLabel
                handlerLabel = f_1502_39166_39177(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39192, 39216);

                f_1502_39192_39215(this, handlerLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39230, 39268);

                return f_1502_39237_39267(this, handlerLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39085, 39279);

                System.Management.Automation.Interpreter.BranchLabel
                f_1502_39166_39177(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39166, 39177);
                    return return_v;
                }


                int
                f_1502_39192_39215(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39192, 39215);
                    return 0;
                }


                int
                f_1502_39237_39267(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    var return_v = this_param.EnsureLabelIndex(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39237, 39267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39085, 39279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39085, 39279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkLabel(BranchLabel label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39291, 39384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39356, 39373);

                f_1502_39356_39372(label, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39291, 39384);

                int
                f_1502_39356_39372(System.Management.Automation.Interpreter.BranchLabel
                this_param, System.Management.Automation.Interpreter.InstructionList
                instructions)
                {
                    this_param.Mark(instructions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39356, 39372);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39291, 39384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39291, 39384);
            }
        }

        public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39396, 39577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39491, 39566);

                f_1502_39491_39565(this, f_1502_39496_39564(f_1502_39519_39542(this, label), hasResult, hasValue));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39396, 39577);

                int
                f_1502_39519_39542(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    var return_v = this_param.EnsureLabelIndex(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39519, 39542);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GotoInstruction
                f_1502_39496_39564(int
                labelIndex, bool
                hasResult, bool
                hasValue)
                {
                    var return_v = GotoInstruction.Create(labelIndex, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39496, 39564);
                    return return_v;
                }


                int
                f_1502_39491_39565(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.GotoInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39491, 39565);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39396, 39577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39396, 39577);
            }
        }

        private void EmitBranch(OffsetInstruction instruction, BranchLabel label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39589, 39763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39687, 39705);

                f_1502_39687_39704(this, instruction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39719, 39752);

                f_1502_39719_39751(label, this, f_1502_39741_39746() - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39589, 39763);

                int
                f_1502_39687_39704(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.OffsetInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39687, 39704);
                    return 0;
                }


                int
                f_1502_39741_39746()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1502, 39741, 39746);
                    return return_v;
                }


                int
                f_1502_39719_39751(System.Management.Automation.Interpreter.BranchLabel
                this_param, System.Management.Automation.Interpreter.InstructionList
                instructions, int
                branchIndex)
                {
                    this_param.AddBranch(instructions, branchIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39719, 39751);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39589, 39763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39589, 39763);
            }
        }

        public void EmitBranch(BranchLabel label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39775, 39895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 39841, 39884);

                f_1502_39841_39883(this, f_1502_39852_39875(), label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39775, 39895);

                System.Management.Automation.Interpreter.BranchInstruction
                f_1502_39852_39875()
                {
                    var return_v = new System.Management.Automation.Interpreter.BranchInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39852, 39875);
                    return return_v;
                }


                int
                f_1502_39841_39883(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchInstruction
                instruction, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.EmitBranch((System.Management.Automation.Interpreter.OffsetInstruction)instruction, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 39841, 39883);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39775, 39895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39775, 39895);
            }
        }

        public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 39907, 40077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40004, 40066);

                f_1502_40004_40065(this, f_1502_40015_40057(hasResult, hasValue), label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 39907, 40077);

                System.Management.Automation.Interpreter.BranchInstruction
                f_1502_40015_40057(bool
                hasResult, bool
                hasValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.BranchInstruction(hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40015, 40057);
                    return return_v;
                }


                int
                f_1502_40004_40065(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchInstruction
                instruction, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.EmitBranch((System.Management.Automation.Interpreter.OffsetInstruction)instruction, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40004, 40065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 39907, 40077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 39907, 40077);
            }
        }

        public void EmitCoalescingBranch(BranchLabel leftNotNull)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40089, 40241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40171, 40230);

                f_1502_40171_40229(this, f_1502_40182_40215(), leftNotNull);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40089, 40241);

                System.Management.Automation.Interpreter.CoalescingBranchInstruction
                f_1502_40182_40215()
                {
                    var return_v = new System.Management.Automation.Interpreter.CoalescingBranchInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40182, 40215);
                    return return_v;
                }


                int
                f_1502_40171_40229(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.CoalescingBranchInstruction
                instruction, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.EmitBranch((System.Management.Automation.Interpreter.OffsetInstruction)instruction, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40171, 40229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40089, 40241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40089, 40241);
            }
        }

        public void EmitBranchTrue(BranchLabel elseLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40253, 40389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40327, 40378);

                f_1502_40327_40377(this, f_1502_40338_40365(), elseLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40253, 40389);

                System.Management.Automation.Interpreter.BranchTrueInstruction
                f_1502_40338_40365()
                {
                    var return_v = new System.Management.Automation.Interpreter.BranchTrueInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40338, 40365);
                    return return_v;
                }


                int
                f_1502_40327_40377(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchTrueInstruction
                instruction, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.EmitBranch((System.Management.Automation.Interpreter.OffsetInstruction)instruction, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40327, 40377);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40253, 40389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40253, 40389);
            }
        }

        public void EmitBranchFalse(BranchLabel elseLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40401, 40539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40476, 40528);

                f_1502_40476_40527(this, f_1502_40487_40515(), elseLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40401, 40539);

                System.Management.Automation.Interpreter.BranchFalseInstruction
                f_1502_40487_40515()
                {
                    var return_v = new System.Management.Automation.Interpreter.BranchFalseInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40487, 40515);
                    return return_v;
                }


                int
                f_1502_40476_40527(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchFalseInstruction
                instruction, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.EmitBranch((System.Management.Automation.Interpreter.OffsetInstruction)instruction, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40476, 40527);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40401, 40539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40401, 40539);
            }
        }

        public void EmitThrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40551, 40639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40599, 40628);

                f_1502_40599_40627(this, ThrowInstruction.Throw);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40551, 40639);

                int
                f_1502_40599_40627(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.ThrowInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40599, 40627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40551, 40639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40551, 40639);
            }
        }

        public void EmitThrowVoid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40651, 40747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40703, 40736);

                f_1502_40703_40735(this, ThrowInstruction.VoidThrow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40651, 40747);

                int
                f_1502_40703_40735(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.ThrowInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40703, 40735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40651, 40747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40651, 40747);
            }
        }

        public void EmitRethrow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40759, 40851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40809, 40840);

                f_1502_40809_40839(this, ThrowInstruction.Rethrow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40759, 40851);

                int
                f_1502_40809_40839(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.ThrowInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40809, 40839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40759, 40851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40759, 40851);
            }
        }

        public void EmitRethrowVoid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40863, 40963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 40917, 40952);

                f_1502_40917_40951(this, ThrowInstruction.VoidRethrow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40863, 40963);

                int
                f_1502_40917_40951(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.ThrowInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 40917, 40951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40863, 40963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40863, 40963);
            }
        }

        public void EmitEnterTryFinally(BranchLabel finallyStartLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 40975, 41165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41062, 41154);

                f_1502_41062_41153(this, f_1502_41067_41152(f_1502_41116_41151(this, finallyStartLabel)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 40975, 41165);

                int
                f_1502_41116_41151(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    var return_v = this_param.EnsureLabelIndex(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41116, 41151);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                f_1502_41067_41152(int
                labelIndex)
                {
                    var return_v = EnterTryCatchFinallyInstruction.CreateTryFinally(labelIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41067, 41152);
                    return return_v;
                }


                int
                f_1502_41062_41153(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41062, 41153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 40975, 41165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 40975, 41165);
            }
        }

        public void EmitEnterTryCatch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41177, 41299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41233, 41288);

                f_1502_41233_41287(this, f_1502_41238_41286());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41177, 41299);

                System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                f_1502_41238_41286()
                {
                    var return_v = EnterTryCatchFinallyInstruction.CreateTryCatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41238, 41286);
                    return return_v;
                }


                int
                f_1502_41233_41287(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41233, 41287);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41177, 41299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41177, 41299);
            }
        }

        public void EmitEnterFinally(BranchLabel finallyStartLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41311, 41480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41395, 41469);

                f_1502_41395_41468(this, f_1502_41400_41467(f_1502_41431_41466(this, finallyStartLabel)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41311, 41480);

                int
                f_1502_41431_41466(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    var return_v = this_param.EnsureLabelIndex(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41431, 41466);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EnterFinallyInstruction
                f_1502_41400_41467(int
                labelIndex)
                {
                    var return_v = EnterFinallyInstruction.Create(labelIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41400, 41467);
                    return return_v;
                }


                int
                f_1502_41395_41468(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.EnterFinallyInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41395, 41468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41311, 41480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41311, 41480);
            }
        }

        public void EmitLeaveFinally()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41492, 41597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41547, 41586);

                f_1502_41547_41585(this, LeaveFinallyInstruction.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41492, 41597);

                int
                f_1502_41547_41585(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41547, 41585);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41492, 41597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41492, 41597);
            }
        }

        public void EmitLeaveFault(bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41609, 41762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41675, 41751);

                f_1502_41675_41750(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1502, 41680, 41688) || ((hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1502, 41691, 41720)) || DynAbs.Tracing.TraceSender.Conditional_F3(1502, 41723, 41749))) ? LeaveFaultInstruction.NonVoid : LeaveFaultInstruction.Void);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41609, 41762);

                int
                f_1502_41675_41750(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.Instruction
                instruction)
                {
                    this_param.Emit(instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41675, 41750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41609, 41762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41609, 41762);
            }
        }

        public void EmitEnterExceptionHandlerNonVoid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41774, 41903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41845, 41892);

                f_1502_41845_41891(this, EnterExceptionHandlerInstruction.NonVoid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41774, 41903);

                int
                f_1502_41845_41891(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41845, 41891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41774, 41903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41774, 41903);
            }
        }

        public void EmitEnterExceptionHandlerVoid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 41915, 42038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 41983, 42027);

                f_1502_41983_42026(this, EnterExceptionHandlerInstruction.Void);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 41915, 42038);

                int
                f_1502_41983_42026(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 41983, 42026);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 41915, 42038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 41915, 42038);
            }
        }

        public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 42050, 42270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 42162, 42259);

                f_1502_42162_42258(this, f_1502_42167_42257(f_1502_42207_42246(this, tryExpressionEndLabel), hasValue));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 42050, 42270);

                int
                f_1502_42207_42246(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    var return_v = this_param.EnsureLabelIndex(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 42207, 42246);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction
                f_1502_42167_42257(int
                labelIndex, bool
                hasValue)
                {
                    var return_v = LeaveExceptionHandlerInstruction.Create(labelIndex, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 42167, 42257);
                    return return_v;
                }


                int
                f_1502_42162_42258(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 42162, 42258);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 42050, 42270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 42050, 42270);
            }
        }

        public void EmitSwitch(Dictionary<int, int> cases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1502, 42282, 42403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 42357, 42392);

                f_1502_42357_42391(this, f_1502_42362_42390(cases));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1502, 42282, 42403);

                System.Management.Automation.Interpreter.SwitchInstruction
                f_1502_42362_42390(System.Collections.Generic.Dictionary<int, int>
                cases)
                {
                    var return_v = new System.Management.Automation.Interpreter.SwitchInstruction(cases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 42362, 42390);
                    return return_v;
                }


                int
                f_1502_42357_42391(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.SwitchInstruction
                instruction)
                {
                    this_param.Emit((System.Management.Automation.Interpreter.Instruction)instruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 42357, 42391);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1502, 42282, 42403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 42282, 42403);
            }
        }

        public InstructionList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1502, 3037, 42432);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3308, 3347);
            this._instructions = f_1502_3324_3347();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3379, 3387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3412, 3430);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3453, 3467);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3490, 3516);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3539, 3560);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3583, 3601);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3638, 3645);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 3775, 3795);
            this._debugCookies = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1502, 3037, 42432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 3037, 42432);
        }


        static InstructionList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1502, 3037, 42432);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12009, 12037);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12066, 12093);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12122, 12145);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12185, 12191);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12229, 12235);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12273, 12280);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12320, 12326);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 12366, 12384);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15371, 15395);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15437, 15448);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15488, 15504);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15544, 15566);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15606, 15633);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15673, 15686);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15726, 15738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15778, 15796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15836, 15853);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15893, 15915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 15955, 15970);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16010, 16031);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16071, 16085);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 16125, 16136);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 30667, 30722);
            s_loadFields = f_1502_30682_30722();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 35888, 35972);
            s_factories = f_1502_35915_35972();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1502, 37509, 37606);
            s_emptyRuntimeLabels = new RuntimeLabel[] { f_1502_37553_37604(Interpreter.RethrowOnReturn, 0, 0) };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1502, 3037, 42432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1502, 3037, 42432);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1502, 3037, 42432);

        System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>
        f_1502_3324_3347()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.Instruction>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 3324, 3347);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Reflection.FieldInfo, System.Management.Automation.Interpreter.Instruction>
        f_1502_30682_30722()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Reflection.FieldInfo, System.Management.Automation.Interpreter.Instruction>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 30682, 30722);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Type, System.Func<System.Runtime.CompilerServices.CallSiteBinder, System.Management.Automation.Interpreter.Instruction>>
        f_1502_35915_35972()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Type, System.Func<System.Runtime.CompilerServices.CallSiteBinder, System.Management.Automation.Interpreter.Instruction>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 35915, 35972);
            return return_v;
        }


        static System.Management.Automation.Interpreter.RuntimeLabel
        f_1502_37553_37604(int
        index, int
        continuationStackDepth, int
        stackDepth)
        {
            var return_v = new System.Management.Automation.Interpreter.RuntimeLabel(index, continuationStackDepth, stackDepth);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1502, 37553, 37604);
            return return_v;
        }

    }
}
