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

using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;

namespace System.Management.Automation.Interpreter
{

    internal struct RuntimeLabel
    {

        public readonly int Index;

        public readonly int StackDepth;

        public readonly int ContinuationStackDepth;

        public RuntimeLabel(int index, int continuationStackDepth, int stackDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1488, 1044, 1268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1143, 1157);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1171, 1219);

                ContinuationStackDepth = continuationStackDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1233, 1257);

                StackDepth = stackDepth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1488, 1044, 1268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 1044, 1268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 1044, 1268);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 1280, 1466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1338, 1455);

                return f_1488_1345_1454(f_1488_1359_1387(), "->{0} C({1}) S({2})", Index, ContinuationStackDepth, StackDepth);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 1280, 1466);

                System.Globalization.CultureInfo
                f_1488_1359_1387()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1488, 1359, 1387);
                    return return_v;
                }


                string
                f_1488_1345_1454(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1, int
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 1345, 1454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 1280, 1466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 1280, 1466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static RuntimeLabel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1488, 867, 1473);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1488, 867, 1473);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 867, 1473);
        }
    }
    internal sealed class BranchLabel
    {
        internal const int
        UnknownIndex = Int32.MinValue
        ;

        internal const int
        UnknownDepth = Int32.MinValue
        ;

        internal int _labelIndex;

        internal int _targetIndex;

        internal int _stackDepth;

        internal int _continuationStackDepth;

        private List<int> _forwardBranchFixups;

        public BranchLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1488, 2053, 2095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1664, 1690);
                this._labelIndex = UnknownIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1714, 1741);
                this._targetIndex = UnknownIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1765, 1791);
                this._stackDepth = UnknownDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1815, 1853);
                this._continuationStackDepth = UnknownDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2020, 2040);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1488, 2053, 2095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2053, 2095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2053, 2095);
            }
        }

        internal int LabelIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2155, 2182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2161, 2180);

                    return _labelIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2155, 2182);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2107, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2107, 2237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2198, 2226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2204, 2224);

                    _labelIndex = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2198, 2226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2107, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2107, 2237);
                }
            }
        }

        internal bool HasRuntimeLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2303, 2346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2309, 2344);

                    return _labelIndex != UnknownIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2303, 2346);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2249, 2357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2249, 2357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int TargetIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2418, 2446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2424, 2444);

                    return _targetIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2418, 2446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2369, 2457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2369, 2457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int StackDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2517, 2544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2523, 2542);

                    return _stackDepth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2517, 2544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2469, 2555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2469, 2555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal RuntimeLabel ToRuntimeLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2567, 2848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2630, 2747);

                f_1488_2630_2746(_targetIndex != UnknownIndex && (DynAbs.Tracing.TraceSender.Expression_True(1488, 2643, 2702) && _stackDepth != UnknownDepth) && (DynAbs.Tracing.TraceSender.Expression_True(1488, 2643, 2745) && _continuationStackDepth != UnknownDepth));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 2761, 2837);

                return f_1488_2768_2836(_targetIndex, _continuationStackDepth, _stackDepth);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2567, 2848);

                int
                f_1488_2630_2746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 2630, 2746);
                    return 0;
                }


                System.Management.Automation.Interpreter.RuntimeLabel
                f_1488_2768_2836(int
                index, int
                continuationStackDepth, int
                stackDepth)
                {
                    var return_v = new System.Management.Automation.Interpreter.RuntimeLabel(index, continuationStackDepth, stackDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 2768, 2836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2567, 2848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2567, 2848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Mark(InstructionList instructions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 2860, 3555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3079, 3124);

                _stackDepth = f_1488_3093_3123(instructions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3138, 3203);

                _continuationStackDepth = f_1488_3164_3202(instructions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3217, 3251);

                _targetIndex = f_1488_3232_3250(instructions);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3267, 3544) || true) && (_forwardBranchFixups != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1488, 3267, 3544);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3333, 3481);
                        foreach (var branchIndex in f_1488_3361_3381_I(_forwardBranchFixups))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1488, 3333, 3481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3423, 3462);

                            f_1488_3423_3461(this, instructions, branchIndex);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1488, 3333, 3481);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1488, 1, 149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1488, 1, 149);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3501, 3529);

                    _forwardBranchFixups = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1488, 3267, 3544);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 2860, 3555);

                int
                f_1488_3093_3123(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1488, 3093, 3123);
                    return return_v;
                }


                int
                f_1488_3164_3202(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentContinuationsDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1488, 3164, 3202);
                    return return_v;
                }


                int
                f_1488_3232_3250(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1488, 3232, 3250);
                    return return_v;
                }


                int
                f_1488_3423_3461(System.Management.Automation.Interpreter.BranchLabel
                this_param, System.Management.Automation.Interpreter.InstructionList
                instructions, int
                branchIndex)
                {
                    this_param.FixupBranch(instructions, branchIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 3423, 3461);
                    return 0;
                }


                System.Collections.Generic.List<int>
                f_1488_3361_3381_I(System.Collections.Generic.List<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 3361, 3381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 2860, 3555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 2860, 3555);
            }
        }

        internal void AddBranch(InstructionList instructions, int branchIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 3567, 4251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3662, 3742);

                f_1488_3662_3741(((_targetIndex == UnknownIndex) == (_stackDepth == UnknownDepth)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3756, 3848);

                f_1488_3756_3847(((_targetIndex == UnknownIndex) == (_continuationStackDepth == UnknownDepth)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3864, 4240) || true) && (_targetIndex == UnknownIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1488, 3864, 4240);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 3930, 4062) || true) && (_forwardBranchFixups == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1488, 3930, 4062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 4004, 4043);

                        _forwardBranchFixups = f_1488_4027_4042();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1488, 3930, 4062);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 4082, 4120);

                    f_1488_4082_4119(
                                    _forwardBranchFixups, branchIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1488, 3864, 4240);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1488, 3864, 4240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 4186, 4225);

                    f_1488_4186_4224(this, instructions, branchIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1488, 3864, 4240);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 3567, 4251);

                int
                f_1488_3662_3741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 3662, 3741);
                    return 0;
                }


                int
                f_1488_3756_3847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 3756, 3847);
                    return 0;
                }


                System.Collections.Generic.List<int>
                f_1488_4027_4042()
                {
                    var return_v = new System.Collections.Generic.List<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 4027, 4042);
                    return return_v;
                }


                int
                f_1488_4082_4119(System.Collections.Generic.List<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 4082, 4119);
                    return 0;
                }


                int
                f_1488_4186_4224(System.Management.Automation.Interpreter.BranchLabel
                this_param, System.Management.Automation.Interpreter.InstructionList
                instructions, int
                branchIndex)
                {
                    this_param.FixupBranch(instructions, branchIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 4186, 4224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 3567, 4251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 3567, 4251);
            }
        }

        internal void FixupBranch(InstructionList instructions, int branchIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1488, 4263, 4494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 4360, 4403);

                f_1488_4360_4402(_targetIndex != UnknownIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 4417, 4483);

                f_1488_4417_4482(instructions, branchIndex, _targetIndex - branchIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1488, 4263, 4494);

                int
                f_1488_4360_4402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 4360, 4402);
                    return 0;
                }


                int
                f_1488_4417_4482(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                branchIndex, int
                offset)
                {
                    this_param.FixupBranch(branchIndex, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1488, 4417, 4482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1488, 4263, 4494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 4263, 4494);
            }
        }

        static BranchLabel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1488, 1481, 4501);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1550, 1579);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1488, 1609, 1638);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1488, 1481, 4501);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1488, 1481, 4501);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1488, 1481, 4501);
    }
}
