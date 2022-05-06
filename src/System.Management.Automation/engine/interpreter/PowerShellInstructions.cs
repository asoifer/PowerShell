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

namespace System.Management.Automation.Interpreter
{
    internal class UpdatePositionInstruction : Instruction
    {
        private readonly int _sequencePoint;

        private readonly bool _checkBreakpoints;

        private UpdatePositionInstruction(bool checkBreakpoints, int sequencePoint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1518, 943, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 866, 880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 913, 930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1043, 1080);

                _checkBreakpoints = checkBreakpoints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1094, 1125);

                _sequencePoint = sequencePoint;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1518, 943, 1136);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1518, 943, 1136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1518, 943, 1136);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1518, 1148, 1656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1220, 1264);

                var
                functionContext = f_1518_1242_1263(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1278, 1315);

                var
                context = f_1518_1292_1314(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1331, 1391);

                functionContext._currentSequencePointIndex = _sequencePoint;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1405, 1619) || true) && (_checkBreakpoints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1518, 1405, 1619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1460, 1604) || true) && (context._debuggingMode > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1518, 1460, 1604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1532, 1585);

                        f_1518_1532_1584(f_1518_1532_1548(context), functionContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1518, 1460, 1604);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1518, 1405, 1619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1635, 1645);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1518, 1148, 1656);

                System.Management.Automation.Language.FunctionContext
                f_1518_1242_1263(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.FunctionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1518, 1242, 1263);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1518_1292_1314(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1518, 1292, 1314);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1518_1532_1548(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1518, 1532, 1548);
                    return return_v;
                }


                int
                f_1518_1532_1584(System.Management.Automation.ScriptDebugger
                this_param, System.Management.Automation.Language.FunctionContext
                functionContext)
                {
                    this_param.OnSequencePointHit(functionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1518, 1532, 1584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1518, 1148, 1656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1518, 1148, 1656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Instruction Create(int sequencePoint, bool checkBreakpoints)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1518, 1668, 1848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1518, 1767, 1837);

                return f_1518_1774_1836(checkBreakpoints, sequencePoint);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1518, 1668, 1848);

                System.Management.Automation.Interpreter.UpdatePositionInstruction
                f_1518_1774_1836(bool
                checkBreakpoints, int
                sequencePoint)
                {
                    var return_v = new System.Management.Automation.Interpreter.UpdatePositionInstruction(checkBreakpoints, sequencePoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1518, 1774, 1836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1518, 1668, 1848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1518, 1668, 1848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UpdatePositionInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1518, 774, 1855);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1518, 774, 1855);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1518, 774, 1855);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1518, 774, 1855);
    }
}
