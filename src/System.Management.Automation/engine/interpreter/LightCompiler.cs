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
using System.Linq;
using System.Linq.Expressions;

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using AstUtils = System.Management.Automation.Interpreter.Utils;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed class ExceptionHandler
    {
        public readonly Type ExceptionType;

        public readonly int StartIndex;

        public readonly int EndIndex;

        public readonly int LabelIndex;

        public readonly int HandlerStartIndex;

        public readonly int HandlerEndIndex;

        internal TryCatchFinallyHandler Parent;

        public bool IsFault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 1469, 1506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1475, 1504);

                    return ExceptionType == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 1469, 1506);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 1447, 1508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 1447, 1508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ExceptionHandler(int start, int end, int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 1520, 1911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1148, 1161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1192, 1202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1233, 1241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1272, 1282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1313, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1361, 1376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1421, 1434);
                this.Parent = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1670, 1689);

                StartIndex = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1703, 1718);

                EndIndex = end;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1732, 1756);

                LabelIndex = labelIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1770, 1800);

                ExceptionType = exceptionType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1814, 1852);

                HandlerStartIndex = handlerStartIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 1866, 1900);

                HandlerEndIndex = handlerEndIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 1520, 1911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 1520, 1911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 1520, 1911);
            }
        }

        internal void SetParent(TryCatchFinallyHandler tryHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 1923, 2080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2006, 2035);

                f_1507_2006_2034(Parent == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2049, 2069);

                Parent = tryHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 1923, 2080);

                int
                f_1507_2006_2034(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 2006, 2034);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 1923, 2080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 1923, 2080);
            }
        }

        public bool Matches(Type exceptionType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 2092, 2331);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2156, 2291) || true) && (ExceptionType == null || (DynAbs.Tracing.TraceSender.Expression_False(1507, 2160, 2230) || f_1507_2185_2230(ExceptionType, exceptionType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 2156, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2264, 2276);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 2156, 2291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2307, 2320);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 2092, 2331);

                bool
                f_1507_2185_2230(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 2185, 2230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 2092, 2331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 2092, 2331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsBetterThan(ExceptionHandler other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 2343, 2673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2416, 2447) || true) && (other == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 2416, 2447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2435, 2447);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 2416, 2447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2463, 2597);

                f_1507_2463_2596(StartIndex == other.StartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1507, 2476, 2536) && EndIndex == other.EndIndex), "we only need to compare handlers for the same try block");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2611, 2662);

                return HandlerStartIndex < other.HandlerStartIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 2343, 2673);

                int
                f_1507_2463_2596(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 2463, 2596);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 2343, 2673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 2343, 2673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsInsideTryBlock(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 2685, 2809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2751, 2798);

                return index >= StartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1507, 2758, 2797) && index < EndIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 2685, 2809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 2685, 2809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 2685, 2809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsInsideCatchBlock(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 2821, 2961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 2889, 2950);

                return index >= HandlerStartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1507, 2896, 2949) && index < HandlerEndIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 2821, 2961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 2821, 2961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 2821, 2961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsInsideFinallyBlock(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 2973, 3202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3043, 3072);

                f_1507_3043_3071(Parent != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3086, 3191);

                return f_1507_3093_3119(Parent) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 3093, 3156) && index >= Parent.FinallyStartIndex) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 3093, 3190) && index < Parent.FinallyEndIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 2973, 3202);

                int
                f_1507_3043_3071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 3043, 3071);
                    return 0;
                }


                bool
                f_1507_3093_3119(System.Management.Automation.Interpreter.TryCatchFinallyHandler
                this_param)
                {
                    var return_v = this_param.IsFinallyBlockExist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 3093, 3119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 2973, 3202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 2973, 3202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 3214, 3544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3272, 3533);

                return f_1507_3279_3532(f_1507_3293_3321(), "{0} [{1}-{2}] [{3}->{4}]", ((DynAbs.Tracing.TraceSender.Conditional_F1(1507, 3369, 3376) || ((f_1507_3369_3376() && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 3379, 3386)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 3389, 3424))) ? "fault" : "catch(" + f_1507_3400_3418(ExceptionType) + ")"), StartIndex, EndIndex, HandlerStartIndex, HandlerEndIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 3214, 3544);

                System.Globalization.CultureInfo
                f_1507_3293_3321()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 3293, 3321);
                    return return_v;
                }


                bool
                f_1507_3369_3376()
                {
                    var return_v = IsFault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 3369, 3376);
                    return return_v;
                }


                string
                f_1507_3400_3418(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 3400, 3418);
                    return return_v;
                }


                string
                f_1507_3279_3532(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 3279, 3532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 3214, 3544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 3214, 3544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExceptionHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 1072, 3551);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 1072, 3551);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 1072, 3551);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 1072, 3551);
    }
    internal sealed class TryCatchFinallyHandler
    {
        internal readonly int TryStartIndex;

        internal readonly int TryEndIndex;

        internal readonly int FinallyStartIndex;

        internal readonly int FinallyEndIndex;

        internal readonly int GotoEndTargetIndex;

        private readonly ExceptionHandler[] _handlers;

        internal bool IsFinallyBlockExist
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 4137, 4257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 4143, 4255);

                    return (FinallyStartIndex != Instruction.UnknownInstrIndex && (DynAbs.Tracing.TraceSender.Expression_True(1507, 4151, 4253) && FinallyEndIndex != Instruction.UnknownInstrIndex));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 4137, 4257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 4079, 4268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 4079, 4268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsCatchBlockExist
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 4336, 4371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 4342, 4369);

                    return (_handlers != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 4336, 4371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 4280, 4382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 4280, 4382);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers)
        : this(f_1507_4603_4611_C(tryStart), tryEnd, gotoEndTargetIndex, Instruction.UnknownInstrIndex, Instruction.UnknownInstrIndex, handlers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 4472, 4808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 4737, 4797);

                f_1507_4737_4796(handlers != null, "catch blocks should exist");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 4472, 4808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 4472, 4808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 4472, 4808);
            }
        }

        internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, int finallyStart, int finallyEnd)
        : this(f_1507_5033_5041_C(tryStart), tryEnd, gotoEndTargetIndex, finallyStart, finallyEnd, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 4897, 5275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5127, 5264);

                f_1507_5127_5263(finallyStart != Instruction.UnknownInstrIndex && (DynAbs.Tracing.TraceSender.Expression_True(1507, 5140, 5232) && finallyEnd != Instruction.UnknownInstrIndex), "finally block should exist");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 4897, 5275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 4897, 5275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 4897, 5275);
            }
        }

        internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 5368, 6064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3642, 3687);
                this.TryStartIndex = Instruction.UnknownInstrIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3720, 3763);
                this.TryEndIndex = Instruction.UnknownInstrIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3796, 3845);
                this.FinallyStartIndex = Instruction.UnknownInstrIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3878, 3925);
                this.FinallyEndIndex = Instruction.UnknownInstrIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 3958, 4008);
                this.GotoEndTargetIndex = Instruction.UnknownInstrIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 4057, 4066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5536, 5561);

                TryStartIndex = tryStart;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5575, 5596);

                TryEndIndex = tryEnd;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5610, 5643);

                FinallyStartIndex = finallyStart;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5657, 5686);

                FinallyEndIndex = finallyEnd;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5700, 5739);

                GotoEndTargetIndex = gotoEndLabelIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5755, 5776);

                _handlers = handlers;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5792, 6053) || true) && (_handlers != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 5792, 6053);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5856, 5865);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5847, 6038) || true) && (index < f_1507_5875_5891(_handlers))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5893, 5900)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 5847, 6038))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 5847, 6038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5942, 5973);

                            var
                            handler = _handlers[index]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 5995, 6019);

                            f_1507_5995_6018(handler, this);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 192);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 192);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 5792, 6053);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 5368, 6064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 5368, 6064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 5368, 6064);
            }
        }

        internal int GotoHandler(InterpretedFrame frame, object exception, out ExceptionHandler handler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 6205, 6661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6326, 6423);

                f_1507_6326_6422(_handlers != null, "we should have at least one handler if the method gets called");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6437, 6509);

                handler = f_1507_6447_6508(_handlers, t => t.Matches(exception.GetType()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6523, 6557) || true) && (handler == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 6523, 6557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6546, 6555);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 6523, 6557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6573, 6650);

                return f_1507_6580_6649(frame, handler.LabelIndex, exception, gotoExceptionHandler: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 6205, 6661);

                int
                f_1507_6326_6422(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 6326, 6422);
                    return 0;
                }


                System.Management.Automation.Interpreter.ExceptionHandler
                f_1507_6447_6508(System.Management.Automation.Interpreter.ExceptionHandler[]
                source, System.Func<System.Management.Automation.Interpreter.ExceptionHandler, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.Interpreter.ExceptionHandler>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 6447, 6508);
                    return return_v;
                }


                int
                f_1507_6580_6649(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                labelIndex, object
                value, bool
                gotoExceptionHandler)
                {
                    var return_v = this_param.Goto(labelIndex, value, gotoExceptionHandler: gotoExceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 6580, 6649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 6205, 6661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 6205, 6661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TryCatchFinallyHandler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 3559, 6668);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 3559, 6668);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 3559, 6668);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 3559, 6668);

        int
        f_1507_4737_4796(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 4737, 4796);
            return 0;
        }


        static int
        f_1507_4603_4611_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1507, 4472, 4808);
            return return_v;
        }


        int
        f_1507_5127_5263(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 5127, 5263);
            return 0;
        }


        static int
        f_1507_5033_5041_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1507, 4897, 5275);
            return return_v;
        }


        int
        f_1507_5875_5891(System.Management.Automation.Interpreter.ExceptionHandler[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 5875, 5891);
            return return_v;
        }


        int
        f_1507_5995_6018(System.Management.Automation.Interpreter.ExceptionHandler
        this_param, System.Management.Automation.Interpreter.TryCatchFinallyHandler
        tryHandler)
        {
            this_param.SetParent(tryHandler);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 5995, 6018);
            return 0;
        }

    }
    internal sealed class RethrowException : SystemException
    {
        public RethrowException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 6776, 6846);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 6776, 6846);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 6776, 6846);
        }


        static RethrowException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 6776, 6846);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 6776, 6846);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 6776, 6846);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 6776, 6846);
    }
    [Serializable]
    internal class DebugInfo
    {
        public int StartLine, EndLine;

        public int Index;

        public string FileName;

        public bool IsClear;

        private static readonly DebugInfoComparer s_debugComparer;
        private class DebugInfoComparer : IComparer<DebugInfo>
        {
            int IComparer<DebugInfo>.Compare(DebugInfo d1, DebugInfo d2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 7316, 7549);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7409, 7534) || true) && (d1.Index > d2.Index)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 7409, 7534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7434, 7443);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 7409, 7534);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 7409, 7534);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7466, 7534) || true) && (d1.Index == d2.Index)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 7466, 7534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7492, 7501);

                            return 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 7466, 7534);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 7466, 7534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7524, 7534);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 7466, 7534);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 7409, 7534);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 7316, 7549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 7316, 7549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 7316, 7549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DebugInfoComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 7170, 7560);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 7170, 7560);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 7170, 7560);
            }


            static DebugInfoComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 7170, 7560);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 7170, 7560);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 7170, 7560);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 7170, 7560);
        }

        public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1507, 7572, 8398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7734, 7780);

                DebugInfo
                d = new DebugInfo { Index = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => index, 1507, 7748, 7779) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7870, 7940);

                int
                i = f_1507_7878_7939(debugInfos, d, s_debugComparer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7954, 8350) || true) && (i < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 7954, 8350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8143, 8150);

                    i = ~i;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8168, 8251) || true) && (i == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 8168, 8251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8220, 8232);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 8168, 8251);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8325, 8335);

                    i = i - 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 7954, 8350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8366, 8387);

                return debugInfos[i];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1507, 7572, 8398);

                int
                f_1507_7878_7939(System.Management.Automation.Interpreter.DebugInfo[]
                array, System.Management.Automation.Interpreter.DebugInfo
                value, System.Management.Automation.Interpreter.DebugInfo.DebugInfoComparer
                comparer)
                {
                    var return_v = Array.BinarySearch<DebugInfo>(array, value, (System.Collections.Generic.IComparer<System.Management.Automation.Interpreter.DebugInfo>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 7878, 7939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 7572, 8398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 7572, 8398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 8410, 8789);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8468, 8778) || true) && (IsClear)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 8468, 8778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8513, 8585);

                    return f_1507_8520_8584(f_1507_8534_8562(), "{0}: clear", Index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 8468, 8778);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 8468, 8778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 8651, 8763);

                    return f_1507_8658_8762(f_1507_8672_8700(), "{0}: [{1}-{2}] '{3}'", Index, StartLine, EndLine, FileName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 8468, 8778);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 8410, 8789);

                System.Globalization.CultureInfo
                f_1507_8534_8562()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 8534, 8562);
                    return return_v;
                }


                string
                f_1507_8520_8584(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 8520, 8584);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1507_8672_8700()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 8672, 8700);
                    return return_v;
                }


                string
                f_1507_8658_8762(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 8658, 8762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 8410, 8789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 8410, 8789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 6854, 8796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6955, 6964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6966, 6973);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 6995, 7000);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7025, 7033);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7056, 7063);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 6854, 8796);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 6854, 8796);
        }


        static DebugInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 6854, 8796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 7116, 7157);
            s_debugComparer = f_1507_7134_7157();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 6854, 8796);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 6854, 8796);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 6854, 8796);

        static System.Management.Automation.Interpreter.DebugInfo.DebugInfoComparer
        f_1507_7134_7157()
        {
            var return_v = new System.Management.Automation.Interpreter.DebugInfo.DebugInfoComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 7134, 7157);
            return return_v;
        }

    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
    [Serializable]
    internal struct InterpretedFrameInfo
    {

        public readonly string MethodName;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
        public readonly DebugInfo DebugInfo;

        public InterpretedFrameInfo(string methodName, DebugInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 9270, 9423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9357, 9381);

                MethodName = methodName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9395, 9412);

                DebugInfo = info;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 9270, 9423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 9270, 9423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 9270, 9423);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 9435, 9570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9493, 9559);

                // LAFHIS
                var temp2 = DynAbs.Tracing.TraceSender.Conditional_F1(1507, 9514, 9531) || ((DebugInfo != null && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 9534, 9550)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 9553, 9557));
                var temp = string.Empty;
                if (temp2)
                {
                    temp = ": " + (DebugInfo).ToString();
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 9541, 9550);
                }
                else
                {
                    temp = null;
                }

                return MethodName + temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 9435, 9570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 9435, 9570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 9435, 9570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static InterpretedFrameInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 8818, 9577);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 8818, 9577);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 8818, 9577);
        }
    }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
    internal sealed class LightCompiler
    {
        internal const int
        DefaultCompilationThreshold = 32
        ;

        private readonly int _compilationThreshold;

        private readonly InstructionList _instructions;

        private readonly LocalVariables _locals;

        private readonly List<DebugInfo> _debugInfos;

        private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels;

        private LabelScopeInfo _labelBlock;

        private readonly Stack<ParameterExpression> _exceptionForRethrowStack;

        private bool _forceCompile;

        private readonly LightCompiler _parent;

        private static LocalDefinition[] s_emptyLocals;

        public LightCompiler(int compilationThreshold)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 10938, 11174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9879, 9900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9946, 9959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10002, 10032);
                this._locals = f_1507_10012_10032();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10078, 10113);
                this._debugInfos = f_1507_10092_10113();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10191, 10260);
                this._treeLabels = f_1507_10205_10260();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10294, 10355);
                this._labelBlock = f_1507_10308_10355(null, LabelScopeKind.Lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10412, 10472);
                this._exceptionForRethrowStack = f_1507_10440_10472();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10769, 10782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10826, 10833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11009, 11047);

                _instructions = f_1507_11025_11046();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11061, 11163);

                _compilationThreshold = (DynAbs.Tracing.TraceSender.Conditional_F1(1507, 11085, 11109) || ((compilationThreshold < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 11112, 11139)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 11142, 11162))) ? DefaultCompilationThreshold : compilationThreshold;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 10938, 11174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 10938, 11174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 10938, 11174);
            }
        }

        private LightCompiler(LightCompiler parent)
        : this(f_1507_11250_11278_C(parent._compilationThreshold))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1507, 11186, 11332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11304, 11321);

                _parent = parent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1507, 11186, 11332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 11186, 11332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 11186, 11332);
            }
        }

        public InstructionList Instructions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 11404, 11433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11410, 11431);

                    return _instructions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 11404, 11433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 11344, 11444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 11344, 11444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalVariables Locals
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 11509, 11532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11515, 11530);

                    return _locals;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 11509, 11532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 11456, 11543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 11456, 11543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Expression Unbox(Expression strongBoxExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1507, 11555, 11745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11644, 11734);

                return f_1507_11651_11733(strongBoxExpression, f_1507_11689_11732(typeof(StrongBox<object>), "Value"));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1507, 11555, 11745);

                System.Reflection.FieldInfo?
                f_1507_11689_11732(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetField(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 11689, 11732);
                    return return_v;
                }


                System.Linq.Expressions.MemberExpression
                f_1507_11651_11733(System.Linq.Expressions.Expression
                expression, System.Reflection.FieldInfo
                field)
                {
                    var return_v = Expression.Field(expression, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 11651, 11733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 11555, 11745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 11555, 11745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public LightDelegateCreator CompileTop(LambdaExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 11757, 12554);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11852, 11861);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11843, 12106) || true) && (index < f_1507_11871_11892(f_1507_11871_11886(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11894, 11901)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 11843, 12106))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 11843, 12106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11935, 11966);

                        var
                        p = f_1507_11943_11965(f_1507_11943_11958(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 11984, 12022);

                        var
                        local = f_1507_11996_12021(_locals, p, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12040, 12091);

                        f_1507_12040_12090(_instructions, local.Index);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12122, 12141);

                f_1507_12122_12140(this, f_1507_12130_12139(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12212, 12354) || true) && (f_1507_12216_12230(f_1507_12216_12225(node)) != typeof(void) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 12216, 12281) && f_1507_12250_12265(node) == typeof(void)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 12212, 12354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12315, 12339);

                    f_1507_12315_12338(_instructions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 12212, 12354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12370, 12461);

                f_1507_12370_12460(f_1507_12383_12414(_instructions) == ((DynAbs.Tracing.TraceSender.Conditional_F1(1507, 12419, 12450) || ((f_1507_12419_12434(node) != typeof(void) && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 12453, 12454)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 12457, 12458))) ? 1 : 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 12477, 12543);

                return f_1507_12484_12542(f_1507_12509_12535(this, f_1507_12525_12534(node)), node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 11757, 12554);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_11871_11886(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 11871, 11886);
                    return return_v;
                }


                int
                f_1507_11871_11892(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 11871, 11892);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_11943_11958(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 11943, 11958);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_11943_11965(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 11943, 11965);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1507_11996_12021(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 11996, 12021);
                    return return_v;
                }


                int
                f_1507_12040_12090(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitInitializeParameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12040, 12090);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_12130_12139(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12130, 12139);
                    return return_v;
                }


                int
                f_1507_12122_12140(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12122, 12140);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_12216_12225(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12216, 12225);
                    return return_v;
                }


                System.Type
                f_1507_12216_12230(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12216, 12230);
                    return return_v;
                }


                System.Type
                f_1507_12250_12265(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12250, 12265);
                    return return_v;
                }


                int
                f_1507_12315_12338(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitPop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12315, 12338);
                    return 0;
                }


                int
                f_1507_12383_12414(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12383, 12414);
                    return return_v;
                }


                System.Type
                f_1507_12419_12434(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12419, 12434);
                    return return_v;
                }


                int
                f_1507_12370_12460(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12370, 12460);
                    return 0;
                }


                string
                f_1507_12525_12534(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 12525, 12534);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Interpreter
                f_1507_12509_12535(System.Management.Automation.Interpreter.LightCompiler
                this_param, string
                lambdaName)
                {
                    var return_v = this_param.MakeInterpreter(lambdaName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12509, 12535);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LightDelegateCreator
                f_1507_12484_12542(System.Management.Automation.Interpreter.Interpreter
                interpreter, System.Linq.Expressions.LambdaExpression
                lambda)
                {
                    var return_v = new System.Management.Automation.Interpreter.LightDelegateCreator(interpreter, lambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 12484, 12542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 11757, 12554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 11757, 12554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Interpreter MakeInterpreter(string lambdaName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 13341, 13702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13420, 13498) || true) && (_forceCompile)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 13420, 13498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13471, 13483);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 13420, 13498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13514, 13553);

                var
                debugInfos = f_1507_13531_13552(_debugInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13567, 13691);

                return f_1507_13574_13690(lambdaName, _locals, f_1507_13611_13629(this), f_1507_13631_13654(_instructions), debugInfos, _compilationThreshold);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 13341, 13702);

                System.Management.Automation.Interpreter.DebugInfo[]
                f_1507_13531_13552(System.Collections.Generic.List<System.Management.Automation.Interpreter.DebugInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13531, 13552);
                    return return_v;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                f_1507_13611_13629(System.Management.Automation.Interpreter.LightCompiler
                this_param)
                {
                    var return_v = this_param.GetBranchMapping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13611, 13629);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InstructionArray
                f_1507_13631_13654(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13631, 13654);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Interpreter
                f_1507_13574_13690(string
                name, System.Management.Automation.Interpreter.LocalVariables
                locals, System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                labelMapping, System.Management.Automation.Interpreter.InstructionArray
                instructions, System.Management.Automation.Interpreter.DebugInfo[]
                debugInfos, int
                compilationThreshold)
                {
                    var return_v = new System.Management.Automation.Interpreter.Interpreter(name, locals, labelMapping, instructions, debugInfos, compilationThreshold);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13574, 13690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 13341, 13702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 13341, 13702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileConstantExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 13714, 13901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13794, 13830);

                var
                node = (ConstantExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13844, 13890);

                f_1507_13844_13889(_instructions, f_1507_13867_13877(node), f_1507_13879_13888(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 13714, 13901);

                object
                f_1507_13867_13877(System.Linq.Expressions.ConstantExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 13867, 13877);
                    return return_v;
                }


                System.Type
                f_1507_13879_13888(System.Linq.Expressions.ConstantExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 13879, 13888);
                    return return_v;
                }


                int
                f_1507_13844_13889(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value, System.Type
                type)
                {
                    this_param.EmitLoad(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13844, 13889);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 13714, 13901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 13714, 13901);
            }
        }

        private void CompileDefaultExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 13913, 14039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 13992, 14028);

                f_1507_13992_14027(this, f_1507_14017_14026(expr));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 13913, 14039);

                System.Type
                f_1507_14017_14026(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 14017, 14026);
                    return return_v;
                }


                int
                f_1507_13992_14027(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Type
                type)
                {
                    this_param.CompileDefaultExpression(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 13992, 14027);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 13913, 14039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 13913, 14039);
            }
        }

        private void CompileDefaultExpression(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 14051, 14747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14124, 14736) || true) && (type != typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14124, 14736);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14182, 14721) || true) && (f_1507_14186_14202(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14182, 14721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14244, 14314);

                        object
                        value = f_1507_14259_14313(type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14336, 14591) || true) && (value != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14336, 14591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14403, 14433);

                            f_1507_14403_14432(_instructions, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14336, 14591);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14336, 14591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14531, 14568);

                            f_1507_14531_14567(_instructions, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14336, 14591);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14182, 14721);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14182, 14721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14673, 14702);

                        f_1507_14673_14701(_instructions, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14182, 14721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14124, 14736);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 14051, 14747);

                bool
                f_1507_14186_14202(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 14186, 14202);
                    return return_v;
                }


                object
                f_1507_14259_14313(System.Type
                type)
                {
                    var return_v = ScriptingRuntimeHelpers.GetPrimitiveDefaultValue(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 14259, 14313);
                    return return_v;
                }


                int
                f_1507_14403_14432(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value)
                {
                    this_param.EmitLoad(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 14403, 14432);
                    return 0;
                }


                int
                f_1507_14531_14567(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitDefaultValue(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 14531, 14567);
                    return 0;
                }


                int
                f_1507_14673_14701(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value)
                {
                    this_param.EmitLoad(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 14673, 14701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 14051, 14747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 14051, 14747);
            }
        }

        private LocalVariable EnsureAvailableForClosure(ParameterExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 14759, 15481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14857, 14877);

                LocalVariable
                local
                = default(LocalVariable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14891, 15470) || true) && (f_1507_14895_14940(_locals, expr, out local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14891, 15470);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 14974, 15106) || true) && (f_1507_14978_14994_M(!local.InClosure) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 14978, 15012) && f_1507_14998_15012_M(!local.IsBoxed)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14974, 15106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15054, 15087);

                        f_1507_15054_15086(_locals, expr, _instructions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14974, 15106);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15126, 15139);

                    return local;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14891, 15470);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 14891, 15470);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15173, 15470) || true) && (_parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 15173, 15470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15226, 15266);

                        f_1507_15226_15265(_parent, expr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15284, 15324);

                        return f_1507_15291_15323(_locals, expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 15173, 15470);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 15173, 15470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15390, 15455);

                        throw f_1507_15396_15454("unbound variable: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (expr).ToString(), 1507, 15449, 15453));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 15173, 15470);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 14891, 15470);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 14759, 15481);

                bool
                f_1507_14895_14940(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                var, out System.Management.Automation.Interpreter.LocalVariable
                local)
                {
                    var return_v = this_param.TryGetLocalOrClosure(var, out local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 14895, 14940);
                    return return_v;
                }


                bool
                f_1507_14978_14994_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 14978, 14994);
                    return return_v;
                }


                bool
                f_1507_14998_15012_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 14998, 15012);
                    return return_v;
                }


                int
                f_1507_15054_15086(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, System.Management.Automation.Interpreter.InstructionList
                instructions)
                {
                    this_param.Box(variable, instructions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15054, 15086);
                    return 0;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1507_15226_15265(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                expr)
                {
                    var return_v = this_param.EnsureAvailableForClosure(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15226, 15265);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1507_15291_15323(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.AddClosureVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15291, 15323);
                    return return_v;
                }


                System.InvalidOperationException
                f_1507_15396_15454(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15396, 15454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 14759, 15481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 14759, 15481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalVariable ResolveLocal(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 15712, 16022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15801, 15821);

                LocalVariable
                local
                = default(LocalVariable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15835, 15982) || true) && (!f_1507_15840_15889(_locals, variable, out local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 15835, 15982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15923, 15967);

                    local = f_1507_15931_15966(this, variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 15835, 15982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 15998, 16011);

                return local;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 15712, 16022);

                bool
                f_1507_15840_15889(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                var, out System.Management.Automation.Interpreter.LocalVariable
                local)
                {
                    var return_v = this_param.TryGetLocalOrClosure(var, out local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15840, 15889);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1507_15931_15966(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                expr)
                {
                    var return_v = this_param.EnsureAvailableForClosure(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 15931, 15966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 15712, 16022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 15712, 16022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CompileGetVariable(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 16034, 16609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16119, 16164);

                LocalVariable
                local = f_1507_16141_16163(this, variable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16180, 16538) || true) && (f_1507_16184_16199(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16180, 16538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16233, 16285);

                    f_1507_16233_16284(_instructions, local.Index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16180, 16538);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16180, 16538);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16319, 16538) || true) && (f_1507_16323_16336(local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16319, 16538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16370, 16416);

                        f_1507_16370_16415(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16319, 16538);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16319, 16538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16482, 16523);

                        f_1507_16482_16522(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16319, 16538);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16180, 16538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16554, 16598);

                f_1507_16554_16597(
                            _instructions, f_1507_16583_16596(variable));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 16034, 16609);

                System.Management.Automation.Interpreter.LocalVariable
                f_1507_16141_16163(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.ResolveLocal(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16141, 16163);
                    return return_v;
                }


                bool
                f_1507_16184_16199(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.InClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 16184, 16199);
                    return return_v;
                }


                int
                f_1507_16233_16284(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocalFromClosure(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16233, 16284);
                    return 0;
                }


                bool
                f_1507_16323_16336(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.IsBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 16323, 16336);
                    return return_v;
                }


                int
                f_1507_16370_16415(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16370, 16415);
                    return 0;
                }


                int
                f_1507_16482_16522(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16482, 16522);
                    return 0;
                }


                string
                f_1507_16583_16596(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 16583, 16596);
                    return return_v;
                }


                int
                f_1507_16554_16597(System.Management.Automation.Interpreter.InstructionList
                this_param, string
                cookie)
                {
                    this_param.SetDebugCookie((object)cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16554, 16597);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 16034, 16609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 16034, 16609);
            }
        }

        public void CompileGetBoxedVariable(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 16621, 17121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16711, 16756);

                LocalVariable
                local = f_1507_16733_16755(this, variable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16772, 17050) || true) && (f_1507_16776_16791(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16772, 17050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16825, 16882);

                    f_1507_16825_16881(_instructions, local.Index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16772, 17050);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 16772, 17050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16948, 16976);

                    f_1507_16948_16975(f_1507_16961_16974(local));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 16994, 17035);

                    f_1507_16994_17034(_instructions, local.Index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 16772, 17050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17066, 17110);

                f_1507_17066_17109(
                            _instructions, f_1507_17095_17108(variable));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 16621, 17121);

                System.Management.Automation.Interpreter.LocalVariable
                f_1507_16733_16755(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.ResolveLocal(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16733, 16755);
                    return return_v;
                }


                bool
                f_1507_16776_16791(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.InClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 16776, 16791);
                    return return_v;
                }


                int
                f_1507_16825_16881(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocalFromClosureBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16825, 16881);
                    return 0;
                }


                bool
                f_1507_16961_16974(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.IsBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 16961, 16974);
                    return return_v;
                }


                int
                f_1507_16948_16975(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16948, 16975);
                    return 0;
                }


                int
                f_1507_16994_17034(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 16994, 17034);
                    return 0;
                }


                string
                f_1507_17095_17108(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 17095, 17108);
                    return return_v;
                }


                int
                f_1507_17066_17109(System.Management.Automation.Interpreter.InstructionList
                this_param, string
                cookie)
                {
                    this_param.SetDebugCookie((object)cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17066, 17109);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 16621, 17121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 16621, 17121);
            }
        }

        public void CompileSetVariable(ParameterExpression variable, bool isVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 17133, 18324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17231, 17276);

                LocalVariable
                local = f_1507_17253_17275(this, variable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17292, 18253) || true) && (f_1507_17296_17311(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17292, 18253);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17345, 17601) || true) && (isVoid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17345, 17601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17397, 17448);

                        f_1507_17397_17447(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17345, 17601);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17345, 17601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17530, 17582);

                        f_1507_17530_17581(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17345, 17601);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17292, 18253);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17292, 18253);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17635, 18253) || true) && (f_1507_17639_17652(local))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17635, 18253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17686, 17934) || true) && (isVoid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17686, 17934);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17738, 17785);

                            f_1507_17738_17784(_instructions, local.Index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17686, 17934);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17686, 17934);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 17867, 17915);

                            f_1507_17867_17914(_instructions, local.Index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17686, 17934);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17635, 18253);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 17635, 18253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18000, 18238) || true) && (isVoid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 18000, 18238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18052, 18094);

                            f_1507_18052_18093(_instructions, local.Index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 18000, 18238);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 18000, 18238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18176, 18219);

                            f_1507_18176_18218(_instructions, local.Index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 18000, 18238);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17635, 18253);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 17292, 18253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18269, 18313);

                f_1507_18269_18312(
                            _instructions, f_1507_18298_18311(variable));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 17133, 18324);

                System.Management.Automation.Interpreter.LocalVariable
                f_1507_17253_17275(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.ResolveLocal(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17253, 17275);
                    return return_v;
                }


                bool
                f_1507_17296_17311(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.InClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 17296, 17311);
                    return return_v;
                }


                int
                f_1507_17397_17447(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitStoreLocalToClosure(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17397, 17447);
                    return 0;
                }


                int
                f_1507_17530_17581(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocalToClosure(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17530, 17581);
                    return 0;
                }


                bool
                f_1507_17639_17652(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.IsBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 17639, 17652);
                    return return_v;
                }


                int
                f_1507_17738_17784(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitStoreLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17738, 17784);
                    return 0;
                }


                int
                f_1507_17867_17914(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 17867, 17914);
                    return 0;
                }


                int
                f_1507_18052_18093(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitStoreLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18052, 18093);
                    return 0;
                }


                int
                f_1507_18176_18218(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18176, 18218);
                    return 0;
                }


                string
                f_1507_18298_18311(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18298, 18311);
                    return return_v;
                }


                int
                f_1507_18269_18312(System.Management.Automation.Interpreter.InstructionList
                this_param, string
                cookie)
                {
                    this_param.SetDebugCookie((object)cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18269, 18312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 17133, 18324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 17133, 18324);
            }
        }

        public void CompileParameterExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 18336, 18503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18416, 18453);

                var
                node = (ParameterExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18467, 18492);

                f_1507_18467_18491(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 18336, 18503);

                int
                f_1507_18467_18491(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    this_param.CompileGetVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18467, 18491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 18336, 18503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 18336, 18503);
            }
        }

        private void CompileBlockExpression(Expression expr, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 18515, 18860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18605, 18638);

                var
                node = (BlockExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18652, 18686);

                var
                end = f_1507_18662_18685(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18702, 18768);

                var
                lastExpression = f_1507_18723_18767(f_1507_18723_18739(node), f_1507_18740_18762(f_1507_18740_18756(node)) - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18782, 18814);

                f_1507_18782_18813(this, lastExpression, asVoid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18828, 18849);

                f_1507_18828_18848(this, end);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 18515, 18860);

                System.Management.Automation.Interpreter.LocalDefinition[]
                f_1507_18662_18685(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.BlockExpression
                node)
                {
                    var return_v = this_param.CompileBlockStart(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18662, 18685);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_18723_18739(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18723, 18739);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_18740_18756(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18740, 18756);
                    return return_v;
                }


                int
                f_1507_18740_18762(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18740, 18762);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_18723_18767(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18723, 18767);
                    return return_v;
                }


                int
                f_1507_18782_18813(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.Compile(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18782, 18813);
                    return 0;
                }


                int
                f_1507_18828_18848(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LocalDefinition[]
                locals)
                {
                    this_param.CompileBlockEnd(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 18828, 18848);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 18515, 18860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 18515, 18860);
            }
        }

        private LocalDefinition[] CompileBlockStart(BlockExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 18872, 20076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 18962, 18994);

                var
                start = f_1507_18974_18993(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19010, 19035);

                LocalDefinition[]
                locals
                = default(LocalDefinition[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19049, 19080);

                var
                variables = f_1507_19065_19079(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19094, 19884) || true) && (f_1507_19098_19113(variables) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 19094, 19884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19264, 19310);

                    locals = new LocalDefinition[f_1507_19293_19308(variables)];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19328, 19345);

                    int
                    localCnt = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19372, 19381);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19363, 19780) || true) && (index < f_1507_19391_19406(variables))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19408, 19415)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 19363, 19780))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 19363, 19780);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19457, 19489);

                            var
                            variable = f_1507_19472_19488(variables, index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19511, 19560);

                            var
                            local = f_1507_19523_19559(_locals, variable, start)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19582, 19609);

                            locals[localCnt++] = local;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19633, 19695);

                            f_1507_19633_19694(
                                                _instructions, local.Index, f_1507_19680_19693(variable));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19717, 19761);

                            f_1507_19717_19760(_instructions, f_1507_19746_19759(variable));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 418);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 418);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 19094, 19884);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 19094, 19884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19846, 19869);

                    locals = s_emptyLocals;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 19094, 19884);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19909, 19914);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19900, 20035) || true) && (i < f_1507_19920_19942(f_1507_19920_19936(node)) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19948, 19951)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 19900, 20035))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 19900, 20035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 19985, 20020);

                        f_1507_19985_20019(this, f_1507_19999_20018(f_1507_19999_20015(node), i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20051, 20065);

                return locals;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 18872, 20076);

                int
                f_1507_18974_18993(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 18974, 18993);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_19065_19079(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19065, 19079);
                    return return_v;
                }


                int
                f_1507_19098_19113(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19098, 19113);
                    return return_v;
                }


                int
                f_1507_19293_19308(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19293, 19308);
                    return return_v;
                }


                int
                f_1507_19391_19406(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19391, 19406);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_19472_19488(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19472, 19488);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1507_19523_19559(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 19523, 19559);
                    return return_v;
                }


                System.Type
                f_1507_19680_19693(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19680, 19693);
                    return return_v;
                }


                int
                f_1507_19633_19694(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index, System.Type
                type)
                {
                    this_param.EmitInitializeLocal(index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 19633, 19694);
                    return 0;
                }


                string
                f_1507_19746_19759(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19746, 19759);
                    return return_v;
                }


                int
                f_1507_19717_19760(System.Management.Automation.Interpreter.InstructionList
                this_param, string
                cookie)
                {
                    this_param.SetDebugCookie((object)cookie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 19717, 19760);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_19920_19936(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19920, 19936);
                    return return_v;
                }


                int
                f_1507_19920_19942(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19920, 19942);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_19999_20015(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19999, 20015);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_19999_20018(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 19999, 20018);
                    return return_v;
                }


                int
                f_1507_19985_20019(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoid(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 19985, 20019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 18872, 20076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 18872, 20076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileBlockEnd(LocalDefinition[] locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 20088, 20371);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20176, 20185);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20167, 20360) || true) && (index < f_1507_20195_20208(locals))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20210, 20217)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 20167, 20360))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 20167, 20360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20251, 20277);

                        var
                        local = locals[index]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20295, 20345);

                        f_1507_20295_20344(_locals, local, f_1507_20324_20343(_instructions));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 194);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 20088, 20371);

                int
                f_1507_20195_20208(System.Management.Automation.Interpreter.LocalDefinition[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20195, 20208);
                    return return_v;
                }


                int
                f_1507_20324_20343(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20324, 20343);
                    return return_v;
                }


                int
                f_1507_20295_20344(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Management.Automation.Interpreter.LocalDefinition
                definition, int
                end)
                {
                    this_param.UndefineLocal(definition, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 20295, 20344);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 20088, 20371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 20088, 20371);
            }
        }

        private void CompileIndexExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 20383, 21318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20460, 20494);

                var
                index = (IndexExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20536, 20631) || true) && (f_1507_20540_20552(index) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 20536, 20631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20594, 20616);

                    f_1507_20594_20615(this, f_1507_20602_20614(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 20536, 20631);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20705, 20710);

                    // indexes, byref args not allowed.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20696, 20851) || true) && (i < f_1507_20716_20737(f_1507_20716_20731(index)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20739, 20742)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 20696, 20851))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 20696, 20851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20776, 20805);

                        var
                        arg = f_1507_20786_20804(f_1507_20786_20801(index), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20823, 20836);

                        f_1507_20823_20835(this, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 156);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20867, 21307) || true) && (f_1507_20871_20884(index) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 20867, 21307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 20926, 20974);

                    f_1507_20926_20973(_instructions, f_1507_20949_20972(f_1507_20949_20962(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 20867, 21307);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 20867, 21307);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21008, 21307) || true) && (f_1507_21012_21033(f_1507_21012_21027(index)) != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 21008, 21307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21072, 21176);

                        f_1507_21072_21175(_instructions, f_1507_21095_21174(f_1507_21095_21112(f_1507_21095_21107(index)), "Get", BindingFlags.Public | BindingFlags.Instance));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 21008, 21307);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 21008, 21307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21242, 21292);

                        f_1507_21242_21291(_instructions, f_1507_21273_21290(f_1507_21273_21285(index)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 21008, 21307);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 20867, 21307);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 20383, 21318);

                System.Linq.Expressions.Expression
                f_1507_20540_20552(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20540, 20552);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_20602_20614(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20602, 20614);
                    return return_v;
                }


                int
                f_1507_20594_20615(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 20594, 20615);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_20716_20731(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20716, 20731);
                    return return_v;
                }


                int
                f_1507_20716_20737(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20716, 20737);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_20786_20801(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20786, 20801);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_20786_20804(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20786, 20804);
                    return return_v;
                }


                int
                f_1507_20823_20835(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 20823, 20835);
                    return 0;
                }


                System.Reflection.PropertyInfo
                f_1507_20871_20884(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20871, 20884);
                    return return_v;
                }


                System.Reflection.PropertyInfo
                f_1507_20949_20962(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20949, 20962);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_20949_20972(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 20949, 20972);
                    return return_v;
                }


                int
                f_1507_20926_20973(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 20926, 20973);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_21012_21027(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21012, 21027);
                    return return_v;
                }


                int
                f_1507_21012_21033(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21012, 21033);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_21095_21107(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21095, 21107);
                    return return_v;
                }


                System.Type
                f_1507_21095_21112(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21095, 21112);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1507_21095_21174(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21095, 21174);
                    return return_v;
                }


                int
                f_1507_21072_21175(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21072, 21175);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_21273_21285(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21273, 21285);
                    return return_v;
                }


                System.Type
                f_1507_21273_21290(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21273, 21290);
                    return return_v;
                }


                int
                f_1507_21242_21291(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                arrayType)
                {
                    this_param.EmitGetArrayItem(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21242, 21291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 20383, 21318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 20383, 21318);
            }
        }

        private void CompileIndexAssignment(BinaryExpression node, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 21330, 22460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21426, 21465);

                var
                index = (IndexExpression)f_1507_21455_21464(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21481, 21577) || true) && (!asVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 21481, 21577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21526, 21562);

                    throw f_1507_21532_21561();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 21481, 21577);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21619, 21714) || true) && (f_1507_21623_21635(index) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 21619, 21714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21677, 21699);

                    f_1507_21677_21698(this, f_1507_21685_21697(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 21619, 21714);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21788, 21793);

                    // indexes, byref args not allowed.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21779, 21934) || true) && (i < f_1507_21799_21820(f_1507_21799_21814(index)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21822, 21825)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 21779, 21934))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 21779, 21934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21859, 21888);

                        var
                        arg = f_1507_21869_21887(f_1507_21869_21884(index), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21906, 21919);

                        f_1507_21906_21918(this, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 21973, 21993);

                f_1507_21973_21992(this, f_1507_21981_21991(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22009, 22449) || true) && (f_1507_22013_22026(index) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22009, 22449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22068, 22116);

                    f_1507_22068_22115(_instructions, f_1507_22091_22114(f_1507_22091_22104(index)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22009, 22449);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22009, 22449);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22150, 22449) || true) && (f_1507_22154_22175(f_1507_22154_22169(index)) != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22150, 22449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22214, 22318);

                        f_1507_22214_22317(_instructions, f_1507_22237_22316(f_1507_22237_22254(f_1507_22237_22249(index)), "Set", BindingFlags.Public | BindingFlags.Instance));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22150, 22449);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22150, 22449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22384, 22434);

                        f_1507_22384_22433(_instructions, f_1507_22415_22432(f_1507_22415_22427(index)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22150, 22449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22009, 22449);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 21330, 22460);

                System.Linq.Expressions.Expression
                f_1507_21455_21464(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21455, 21464);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_21532_21561()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21532, 21561);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_21623_21635(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21623, 21635);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_21685_21697(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21685, 21697);
                    return return_v;
                }


                int
                f_1507_21677_21698(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21677, 21698);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_21799_21814(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21799, 21814);
                    return return_v;
                }


                int
                f_1507_21799_21820(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21799, 21820);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_21869_21884(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21869, 21884);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_21869_21887(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21869, 21887);
                    return return_v;
                }


                int
                f_1507_21906_21918(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21906, 21918);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_21981_21991(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 21981, 21991);
                    return return_v;
                }


                int
                f_1507_21973_21992(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 21973, 21992);
                    return 0;
                }


                System.Reflection.PropertyInfo
                f_1507_22013_22026(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22013, 22026);
                    return return_v;
                }


                System.Reflection.PropertyInfo
                f_1507_22091_22104(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22091, 22104);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_22091_22114(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22091, 22114);
                    return return_v;
                }


                int
                f_1507_22068_22115(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22068, 22115);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_22154_22169(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22154, 22169);
                    return return_v;
                }


                int
                f_1507_22154_22175(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22154, 22175);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_22237_22249(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22237, 22249);
                    return return_v;
                }


                System.Type
                f_1507_22237_22254(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22237, 22254);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1507_22237_22316(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22237, 22316);
                    return return_v;
                }


                int
                f_1507_22214_22317(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22214, 22317);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_22415_22427(System.Linq.Expressions.IndexExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22415, 22427);
                    return return_v;
                }


                System.Type
                f_1507_22415_22432(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22415, 22432);
                    return return_v;
                }


                int
                f_1507_22384_22433(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                arrayType)
                {
                    this_param.EmitSetArrayItem(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22384, 22433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 21330, 22460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 21330, 22460);
            }
        }

        private void CompileMemberAssignment(BinaryExpression node, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 22472, 24561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22569, 22610);

                var
                member = (MemberExpression)f_1507_22600_22609(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22626, 22674);

                PropertyInfo
                pi = f_1507_22644_22657(member) as PropertyInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22688, 23577) || true) && (pi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22688, 23577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22736, 22762);

                    var
                    method = f_1507_22749_22761(pi)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22780, 22897) || true) && (f_1507_22784_22801(member) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 22780, 22897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22851, 22878);

                        f_1507_22851_22877(this, f_1507_22859_22876(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22780, 22897);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22917, 22937);

                    f_1507_22917_22936(this, f_1507_22925_22935(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 22957, 22989);

                    int
                    start = f_1507_22969_22988(_instructions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23007, 23535) || true) && (!asVoid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23007, 23535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23060, 23150);

                        LocalDefinition
                        local = f_1507_23084_23149(_locals, f_1507_23104_23141(f_1507_23125_23140(f_1507_23125_23135(node))), start)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23172, 23215);

                        f_1507_23172_23214(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23237, 23268);

                        f_1507_23237_23267(_instructions, method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23290, 23331);

                        f_1507_23290_23330(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23353, 23403);

                        f_1507_23353_23402(_locals, local, f_1507_23382_23401(_instructions));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23007, 23535);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23007, 23535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23485, 23516);

                        f_1507_23485_23515(_instructions, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23007, 23535);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23555, 23562);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 22688, 23577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23593, 23635);

                FieldInfo
                fi = f_1507_23608_23621(member) as FieldInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23649, 24498) || true) && (fi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23649, 24498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23697, 23814) || true) && (f_1507_23701_23718(member) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23697, 23814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23768, 23795);

                        f_1507_23768_23794(this, f_1507_23776_23793(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23697, 23814);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23834, 23854);

                    f_1507_23834_23853(this, f_1507_23842_23852(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23874, 23906);

                    int
                    start = f_1507_23886_23905(_instructions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23924, 24456) || true) && (!asVoid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23924, 24456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 23977, 24067);

                        LocalDefinition
                        local = f_1507_24001_24066(_locals, f_1507_24021_24058(f_1507_24042_24057(f_1507_24042_24052(node))), start)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24089, 24132);

                        f_1507_24089_24131(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24154, 24187);

                        f_1507_24154_24186(_instructions, fi);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24209, 24250);

                        f_1507_24209_24249(_instructions, local.Index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24272, 24322);

                        f_1507_24272_24321(_locals, local, f_1507_24301_24320(_instructions));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23924, 24456);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 23924, 24456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24404, 24437);

                        f_1507_24404_24436(_instructions, fi);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23924, 24456);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24476, 24483);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 23649, 24498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24514, 24550);

                throw f_1507_24520_24549();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 22472, 24561);

                System.Linq.Expressions.Expression
                f_1507_22600_22609(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22600, 22609);
                    return return_v;
                }


                System.Reflection.MemberInfo
                f_1507_22644_22657(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22644, 22657);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_22749_22761(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22749, 22761);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_22784_22801(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22784, 22801);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_22859_22876(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22859, 22876);
                    return return_v;
                }


                int
                f_1507_22851_22877(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22851, 22877);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_22925_22935(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22925, 22935);
                    return return_v;
                }


                int
                f_1507_22917_22936(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 22917, 22936);
                    return 0;
                }


                int
                f_1507_22969_22988(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 22969, 22988);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_23125_23135(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23125, 23135);
                    return return_v;
                }


                System.Type
                f_1507_23125_23140(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23125, 23140);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_23104_23141(System.Type
                type)
                {
                    var return_v = Expression.Parameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23104, 23141);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1507_23084_23149(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23084, 23149);
                    return return_v;
                }


                int
                f_1507_23172_23214(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23172, 23214);
                    return 0;
                }


                int
                f_1507_23237_23267(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23237, 23267);
                    return 0;
                }


                int
                f_1507_23290_23330(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23290, 23330);
                    return 0;
                }


                int
                f_1507_23382_23401(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23382, 23401);
                    return return_v;
                }


                int
                f_1507_23353_23402(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Management.Automation.Interpreter.LocalDefinition
                definition, int
                end)
                {
                    this_param.UndefineLocal(definition, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23353, 23402);
                    return 0;
                }


                int
                f_1507_23485_23515(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23485, 23515);
                    return 0;
                }


                System.Reflection.MemberInfo
                f_1507_23608_23621(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23608, 23621);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_23701_23718(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23701, 23718);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_23776_23793(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23776, 23793);
                    return return_v;
                }


                int
                f_1507_23768_23794(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23768, 23794);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_23842_23852(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23842, 23852);
                    return return_v;
                }


                int
                f_1507_23834_23853(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 23834, 23853);
                    return 0;
                }


                int
                f_1507_23886_23905(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 23886, 23905);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_24042_24052(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24042, 24052);
                    return return_v;
                }


                System.Type
                f_1507_24042_24057(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24042, 24057);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_24021_24058(System.Type
                type)
                {
                    var return_v = Expression.Parameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24021, 24058);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1507_24001_24066(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24001, 24066);
                    return return_v;
                }


                int
                f_1507_24089_24131(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitAssignLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24089, 24131);
                    return 0;
                }


                int
                f_1507_24154_24186(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.FieldInfo
                field)
                {
                    this_param.EmitStoreField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24154, 24186);
                    return 0;
                }


                int
                f_1507_24209_24249(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    this_param.EmitLoadLocal(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24209, 24249);
                    return 0;
                }


                int
                f_1507_24301_24320(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24301, 24320);
                    return return_v;
                }


                int
                f_1507_24272_24321(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Management.Automation.Interpreter.LocalDefinition
                definition, int
                end)
                {
                    this_param.UndefineLocal(definition, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24272, 24321);
                    return 0;
                }


                int
                f_1507_24404_24436(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.FieldInfo
                field)
                {
                    this_param.EmitStoreField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24404, 24436);
                    return 0;
                }


                System.NotImplementedException
                f_1507_24520_24549()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24520, 24549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 22472, 24561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 22472, 24561);
            }
        }

        private void CompileVariableAssignment(BinaryExpression node, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 24573, 24817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24672, 24697);

                f_1507_24672_24696(this, f_1507_24685_24695(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24713, 24757);

                var
                target = (ParameterExpression)f_1507_24747_24756(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24771, 24806);

                f_1507_24771_24805(this, target, asVoid);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 24573, 24817);

                System.Linq.Expressions.Expression
                f_1507_24685_24695(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24685, 24695);
                    return return_v;
                }


                int
                f_1507_24672_24696(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24672, 24696);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_24747_24756(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24747, 24756);
                    return return_v;
                }


                int
                f_1507_24771_24805(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable, bool
                isVoid)
                {
                    this_param.CompileSetVariable(variable, isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 24771, 24805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 24573, 24817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 24573, 24817);
            }
        }

        private void CompileAssignBinaryExpression(Expression expr, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 24829, 25646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24926, 24960);

                var
                node = (BinaryExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 24976, 25635);

                switch (f_1507_24984_25002(f_1507_24984_24993(node)))
                {

                    case ExpressionType.Index:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 24976, 25635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25084, 25121);

                        f_1507_25084_25120(this, node, asVoid);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 25143, 25149);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 24976, 25635);

                    case ExpressionType.MemberAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 24976, 25635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25224, 25262);

                        f_1507_25224_25261(this, node, asVoid);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 25284, 25290);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 24976, 25635);

                    case ExpressionType.Parameter:
                    case ExpressionType.Extension:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 24976, 25635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25410, 25450);

                        f_1507_25410_25449(this, node, asVoid);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 25472, 25478);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 24976, 25635);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 24976, 25635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25528, 25620);

                        throw f_1507_25534_25619("Invalid lvalue for assignment: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1507_25600_25618(f_1507_25600_25609(node))).ToString(), 1507, 25600, 25618));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 24976, 25635);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 24829, 25646);

                System.Linq.Expressions.Expression
                f_1507_24984_24993(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24984, 24993);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_24984_25002(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 24984, 25002);
                    return return_v;
                }


                int
                f_1507_25084_25120(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.BinaryExpression
                node, bool
                asVoid)
                {
                    this_param.CompileIndexAssignment(node, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25084, 25120);
                    return 0;
                }


                int
                f_1507_25224_25261(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.BinaryExpression
                node, bool
                asVoid)
                {
                    this_param.CompileMemberAssignment(node, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25224, 25261);
                    return 0;
                }


                int
                f_1507_25410_25449(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.BinaryExpression
                node, bool
                asVoid)
                {
                    this_param.CompileVariableAssignment(node, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25410, 25449);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_25600_25609(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25600, 25609);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_25600_25618(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25600, 25618);
                    return return_v;
                }


                System.InvalidOperationException
                f_1507_25534_25619(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25534, 25619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 24829, 25646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 24829, 25646);
            }
        }

        private void CompileBinaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 25658, 27665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25736, 25770);

                var
                node = (BinaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25786, 27654) || true) && (f_1507_25790_25801(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 25786, 27654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25843, 25862);

                    f_1507_25843_25861(this, f_1507_25851_25860(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25880, 25900);

                    f_1507_25880_25899(this, f_1507_25888_25898(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 25918, 25954);

                    f_1507_25918_25953(_instructions, f_1507_25941_25952(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 25786, 27654);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 25786, 27654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26020, 27639);

                    switch (f_1507_26028_26041(node))
                    {

                        case ExpressionType.ArrayIndex:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26140, 26185);

                            f_1507_26140_26184(f_1507_26153_26168(f_1507_26153_26163(node)) == typeof(int));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26211, 26230);

                            f_1507_26211_26229(this, f_1507_26219_26228(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26256, 26276);

                            f_1507_26256_26275(this, f_1507_26264_26274(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26302, 26349);

                            f_1507_26302_26348(_instructions, f_1507_26333_26347(f_1507_26333_26342(node)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26375, 26382);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);

                        case ExpressionType.Add:
                        case ExpressionType.AddChecked:
                        case ExpressionType.Subtract:
                        case ExpressionType.SubtractChecked:
                        case ExpressionType.Multiply:
                        case ExpressionType.MultiplyChecked:
                        case ExpressionType.Divide:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26776, 26832);

                            f_1507_26776_26831(this, f_1507_26794_26807(node), f_1507_26809_26818(node), f_1507_26820_26830(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26858, 26865);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);

                        case ExpressionType.Equal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 26941, 26977);

                            f_1507_26941_26976(this, f_1507_26954_26963(node), f_1507_26965_26975(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27003, 27010);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);

                        case ExpressionType.NotEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27089, 27128);

                            f_1507_27089_27127(this, f_1507_27105_27114(node), f_1507_27116_27126(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27154, 27161);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);

                        case ExpressionType.LessThan:
                        case ExpressionType.LessThanOrEqual:
                        case ExpressionType.GreaterThan:
                        case ExpressionType.GreaterThanOrEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27413, 27469);

                            f_1507_27413_27468(this, f_1507_27431_27444(node), f_1507_27446_27455(node), f_1507_27457_27467(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27495, 27502);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 26020, 27639);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27560, 27620);

                            throw f_1507_27566_27619(f_1507_27594_27618(f_1507_27594_27607(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 26020, 27639);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 25786, 27654);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 25658, 27665);

                System.Reflection.MethodInfo
                f_1507_25790_25801(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25790, 25801);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_25851_25860(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25851, 25860);
                    return return_v;
                }


                int
                f_1507_25843_25861(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25843, 25861);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_25888_25898(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25888, 25898);
                    return return_v;
                }


                int
                f_1507_25880_25899(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25880, 25899);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1507_25941_25952(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 25941, 25952);
                    return return_v;
                }


                int
                f_1507_25918_25953(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 25918, 25953);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_26028_26041(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26028, 26041);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_26153_26163(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26153, 26163);
                    return return_v;
                }


                System.Type
                f_1507_26153_26168(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26153, 26168);
                    return return_v;
                }


                int
                f_1507_26140_26184(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26140, 26184);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_26219_26228(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26219, 26228);
                    return return_v;
                }


                int
                f_1507_26211_26229(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26211, 26229);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_26264_26274(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26264, 26274);
                    return return_v;
                }


                int
                f_1507_26256_26275(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26256, 26275);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_26333_26342(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26333, 26342);
                    return return_v;
                }


                System.Type
                f_1507_26333_26347(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26333, 26347);
                    return return_v;
                }


                int
                f_1507_26302_26348(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                arrayType)
                {
                    this_param.EmitGetArrayItem(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26302, 26348);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_26794_26807(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26794, 26807);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_26809_26818(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26809, 26818);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_26820_26830(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26820, 26830);
                    return return_v;
                }


                int
                f_1507_26776_26831(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ExpressionType
                nodeType, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    this_param.CompileArithmetic(nodeType, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26776, 26831);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_26954_26963(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26954, 26963);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_26965_26975(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 26965, 26975);
                    return return_v;
                }


                int
                f_1507_26941_26976(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    this_param.CompileEqual(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 26941, 26976);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_27105_27114(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27105, 27114);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_27116_27126(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27116, 27126);
                    return return_v;
                }


                int
                f_1507_27089_27127(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    this_param.CompileNotEqual(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27089, 27127);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_27431_27444(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27431, 27444);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_27446_27455(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27446, 27455);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_27457_27467(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27457, 27467);
                    return return_v;
                }


                int
                f_1507_27413_27468(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ExpressionType
                nodeType, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    this_param.CompileComparison(nodeType, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27413, 27468);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_27594_27607(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27594, 27607);
                    return return_v;
                }


                string
                f_1507_27594_27618(System.Linq.Expressions.ExpressionType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27594, 27618);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_27566_27619(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27566, 27619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 25658, 27665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 25658, 27665);
            }
        }

        private void CompileEqual(Expression left, Expression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 27677, 27996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27762, 27879);

                f_1507_27762_27878(f_1507_27775_27784(left) == f_1507_27788_27798(right) || (DynAbs.Tracing.TraceSender.Expression_False(1507, 27775, 27877) || f_1507_27828_27850_M(!f_1507_27829_27838(left).IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 27828, 27877) && f_1507_27854_27877_M(!f_1507_27855_27865(right).IsValueType))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27893, 27907);

                f_1507_27893_27906(this, left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27921, 27936);

                f_1507_27921_27935(this, right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 27950, 27985);

                f_1507_27950_27984(_instructions, f_1507_27974_27983(left));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 27677, 27996);

                System.Type
                f_1507_27775_27784(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27775, 27784);
                    return return_v;
                }


                System.Type
                f_1507_27788_27798(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27788, 27798);
                    return return_v;
                }


                System.Type
                f_1507_27829_27838(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27829, 27838);
                    return return_v;
                }


                bool
                f_1507_27828_27850_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27828, 27850);
                    return return_v;
                }


                System.Type
                f_1507_27855_27865(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27855, 27865);
                    return return_v;
                }


                bool
                f_1507_27854_27877_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27854, 27877);
                    return return_v;
                }


                int
                f_1507_27762_27878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27762, 27878);
                    return 0;
                }


                int
                f_1507_27893_27906(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27893, 27906);
                    return 0;
                }


                int
                f_1507_27921_27935(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27921, 27935);
                    return 0;
                }


                System.Type
                f_1507_27974_27983(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 27974, 27983);
                    return return_v;
                }


                int
                f_1507_27950_27984(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitEqual(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 27950, 27984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 27677, 27996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 27677, 27996);
            }
        }

        private void CompileNotEqual(Expression left, Expression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 28008, 28333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28096, 28213);

                f_1507_28096_28212(f_1507_28109_28118(left) == f_1507_28122_28132(right) || (DynAbs.Tracing.TraceSender.Expression_False(1507, 28109, 28211) || f_1507_28162_28184_M(!f_1507_28163_28172(left).IsValueType) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 28162, 28211) && f_1507_28188_28211_M(!f_1507_28189_28199(right).IsValueType))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28227, 28241);

                f_1507_28227_28240(this, left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28255, 28270);

                f_1507_28255_28269(this, right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28284, 28322);

                f_1507_28284_28321(_instructions, f_1507_28311_28320(left));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 28008, 28333);

                System.Type
                f_1507_28109_28118(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28109, 28118);
                    return return_v;
                }


                System.Type
                f_1507_28122_28132(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28122, 28132);
                    return return_v;
                }


                System.Type
                f_1507_28163_28172(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28163, 28172);
                    return return_v;
                }


                bool
                f_1507_28162_28184_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28162, 28184);
                    return return_v;
                }


                System.Type
                f_1507_28189_28199(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28189, 28199);
                    return return_v;
                }


                bool
                f_1507_28188_28211_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28188, 28211);
                    return return_v;
                }


                int
                f_1507_28096_28212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28096, 28212);
                    return 0;
                }


                int
                f_1507_28227_28240(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28227, 28240);
                    return 0;
                }


                int
                f_1507_28255_28269(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28255, 28269);
                    return 0;
                }


                System.Type
                f_1507_28311_28320(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28311, 28320);
                    return return_v;
                }


                int
                f_1507_28284_28321(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitNotEqual(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28284, 28321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 28008, 28333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 28008, 28333);
            }
        }

        private void CompileComparison(ExpressionType nodeType, Expression left, Expression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 28345, 29228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28460, 28532);

                f_1507_28460_28531(f_1507_28473_28482(left) == f_1507_28486_28496(right) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 28473, 28530) && f_1507_28500_28530(f_1507_28520_28529(left))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28647, 28661);

                f_1507_28647_28660(this, left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28675, 28690);

                f_1507_28675_28689(this, right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28706, 29217);

                switch (nodeType)
                {

                    case ExpressionType.LessThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 28706, 29217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28786, 28824);

                        f_1507_28786_28823(_instructions, f_1507_28813_28822(left));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 28825, 28831);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 28706, 29217);

                    case ExpressionType.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 28706, 29217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28886, 28931);

                        f_1507_28886_28930(_instructions, f_1507_28920_28929(left));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 28932, 28938);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 28706, 29217);

                    case ExpressionType.GreaterThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 28706, 29217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 28989, 29030);

                        f_1507_28989_29029(_instructions, f_1507_29019_29028(left));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29031, 29037);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 28706, 29217);

                    case ExpressionType.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 28706, 29217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29095, 29143);

                        f_1507_29095_29142(_instructions, f_1507_29132_29141(left));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29144, 29150);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 28706, 29217);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 28706, 29217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29177, 29202);

                        throw f_1507_29183_29201();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 28706, 29217);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 28345, 29228);

                System.Type
                f_1507_28473_28482(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28473, 28482);
                    return return_v;
                }


                System.Type
                f_1507_28486_28496(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28486, 28496);
                    return return_v;
                }


                System.Type
                f_1507_28520_28529(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28520, 28529);
                    return return_v;
                }


                bool
                f_1507_28500_28530(System.Type
                type)
                {
                    var return_v = TypeUtils.IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28500, 28530);
                    return return_v;
                }


                int
                f_1507_28460_28531(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28460, 28531);
                    return 0;
                }


                int
                f_1507_28647_28660(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28647, 28660);
                    return 0;
                }


                int
                f_1507_28675_28689(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28675, 28689);
                    return 0;
                }


                System.Type
                f_1507_28813_28822(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28813, 28822);
                    return return_v;
                }


                int
                f_1507_28786_28823(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitLessThan(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28786, 28823);
                    return 0;
                }


                System.Type
                f_1507_28920_28929(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 28920, 28929);
                    return return_v;
                }


                int
                f_1507_28886_28930(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitLessThanOrEqual(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28886, 28930);
                    return 0;
                }


                System.Type
                f_1507_29019_29028(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29019, 29028);
                    return return_v;
                }


                int
                f_1507_28989_29029(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitGreaterThan(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 28989, 29029);
                    return 0;
                }


                System.Type
                f_1507_29132_29141(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29132, 29141);
                    return return_v;
                }


                int
                f_1507_29095_29142(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitGreaterThanOrEqual(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29095, 29142);
                    return 0;
                }


                System.Exception
                f_1507_29183_29201()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29183, 29201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 28345, 29228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 28345, 29228);
            }
        }

        private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 29240, 30275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29355, 29430);

                f_1507_29355_29429(f_1507_29368_29377(left) == f_1507_29381_29391(right) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 29368, 29428) && f_1507_29395_29428(f_1507_29418_29427(left))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29444, 29458);

                f_1507_29444_29457(this, left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29472, 29487);

                f_1507_29472_29486(this, right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29501, 30264);

                switch (nodeType)
                {

                    case ExpressionType.Add:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29576, 29616);

                        f_1507_29576_29615(_instructions, f_1507_29598_29607(left), false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29617, 29623);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.AddChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29673, 29712);

                        f_1507_29673_29711(_instructions, f_1507_29695_29704(left), true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29713, 29719);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.Subtract:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29767, 29807);

                        f_1507_29767_29806(_instructions, f_1507_29789_29798(left), false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29808, 29814);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.SubtractChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29869, 29908);

                        f_1507_29869_29907(_instructions, f_1507_29891_29900(left), true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 29909, 29915);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.Multiply:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 29963, 30003);

                        f_1507_29963_30002(_instructions, f_1507_29985_29994(left), false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 30004, 30010);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.MultiplyChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30065, 30104);

                        f_1507_30065_30103(_instructions, f_1507_30087_30096(left), true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 30105, 30111);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    case ExpressionType.Divide:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30157, 30190);

                        f_1507_30157_30189(_instructions, f_1507_30179_30188(left));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 30191, 30197);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 29501, 30264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30224, 30249);

                        throw f_1507_30230_30248();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 29501, 30264);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 29240, 30275);

                System.Type
                f_1507_29368_29377(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29368, 29377);
                    return return_v;
                }


                System.Type
                f_1507_29381_29391(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29381, 29391);
                    return return_v;
                }


                System.Type
                f_1507_29418_29427(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29418, 29427);
                    return return_v;
                }


                bool
                f_1507_29395_29428(System.Type
                type)
                {
                    var return_v = TypeUtils.IsArithmetic(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29395, 29428);
                    return return_v;
                }


                int
                f_1507_29355_29429(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29355, 29429);
                    return 0;
                }


                int
                f_1507_29444_29457(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29444, 29457);
                    return 0;
                }


                int
                f_1507_29472_29486(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29472, 29486);
                    return 0;
                }


                System.Type
                f_1507_29598_29607(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29598, 29607);
                    return return_v;
                }


                int
                f_1507_29576_29615(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitAdd(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29576, 29615);
                    return 0;
                }


                System.Type
                f_1507_29695_29704(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29695, 29704);
                    return return_v;
                }


                int
                f_1507_29673_29711(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitAdd(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29673, 29711);
                    return 0;
                }


                System.Type
                f_1507_29789_29798(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29789, 29798);
                    return return_v;
                }


                int
                f_1507_29767_29806(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitSub(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29767, 29806);
                    return 0;
                }


                System.Type
                f_1507_29891_29900(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29891, 29900);
                    return return_v;
                }


                int
                f_1507_29869_29907(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitSub(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29869, 29907);
                    return 0;
                }


                System.Type
                f_1507_29985_29994(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 29985, 29994);
                    return return_v;
                }


                int
                f_1507_29963_30002(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitMul(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 29963, 30002);
                    return 0;
                }


                System.Type
                f_1507_30087_30096(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30087, 30096);
                    return return_v;
                }


                int
                f_1507_30065_30103(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, bool
                @checked)
                {
                    this_param.EmitMul(type, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30065, 30103);
                    return 0;
                }


                System.Type
                f_1507_30179_30188(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30179, 30188);
                    return return_v;
                }


                int
                f_1507_30157_30189(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitDiv(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30157, 30189);
                    return 0;
                }


                System.Exception
                f_1507_30230_30248()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30230, 30248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 29240, 30275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 29240, 30275);
            }
        }

        private void CompileConvertUnaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 30287, 31094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30371, 30404);

                var
                node = (UnaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30418, 31083) || true) && (f_1507_30422_30433(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 30418, 31083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30475, 30497);

                    f_1507_30475_30496(this, f_1507_30483_30495(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30579, 30738) || true) && (f_1507_30583_30594(node) != ScriptingRuntimeHelpers.Int32ToObjectMethod)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 30579, 30738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30683, 30719);

                        f_1507_30683_30718(_instructions, f_1507_30706_30717(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 30579, 30738);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 30418, 31083);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 30418, 31083);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30772, 31083) || true) && (f_1507_30776_30785(node) == typeof(void))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 30772, 31083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30835, 30863);

                        f_1507_30835_30862(this, f_1507_30849_30861(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 30772, 31083);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 30772, 31083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30929, 30951);

                        f_1507_30929_30950(this, f_1507_30937_30949(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 30969, 31068);

                        f_1507_30969_31067(this, f_1507_30990_31007(f_1507_30990_31002(node)), f_1507_31009_31018(node), f_1507_31020_31033(node) == ExpressionType.ConvertChecked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 30772, 31083);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 30418, 31083);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 30287, 31094);

                System.Reflection.MethodInfo
                f_1507_30422_30433(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30422, 30433);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_30483_30495(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30483, 30495);
                    return return_v;
                }


                int
                f_1507_30475_30496(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30475, 30496);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1507_30583_30594(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30583, 30594);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_30706_30717(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30706, 30717);
                    return return_v;
                }


                int
                f_1507_30683_30718(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30683, 30718);
                    return 0;
                }


                System.Type
                f_1507_30776_30785(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30776, 30785);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_30849_30861(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30849, 30861);
                    return return_v;
                }


                int
                f_1507_30835_30862(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoid(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30835, 30862);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_30937_30949(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30937, 30949);
                    return return_v;
                }


                int
                f_1507_30929_30950(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30929, 30950);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_30990_31002(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30990, 31002);
                    return return_v;
                }


                System.Type
                f_1507_30990_31007(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 30990, 31007);
                    return return_v;
                }


                System.Type
                f_1507_31009_31018(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 31009, 31018);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_31020_31033(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 31020, 31033);
                    return return_v;
                }


                int
                f_1507_30969_31067(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Type
                typeFrom, System.Type
                typeTo, bool
                isChecked)
                {
                    this_param.CompileConvertToType(typeFrom, typeTo, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 30969, 31067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 30287, 31094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 30287, 31094);
            }
        }

        private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 31106, 32098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31208, 31273);

                f_1507_31208_31272(typeFrom != typeof(void) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 31221, 31271) && typeTo != typeof(void)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31289, 31367) || true) && (typeTo == typeFrom)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 31289, 31367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31345, 31352);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 31289, 31367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31383, 31422);

                TypeCode
                from = f_1507_31399_31421(typeFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31436, 31471);

                TypeCode
                to = f_1507_31450_31470(typeTo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31485, 31875) || true) && (f_1507_31489_31514(from) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 31489, 31541) && f_1507_31518_31541(to)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 31485, 31875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31575, 31833) || true) && (isChecked)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 31575, 31833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31630, 31680);

                        f_1507_31630_31679(_instructions, from, to);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 31575, 31833);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 31575, 31833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31762, 31814);

                        f_1507_31762_31813(_instructions, from, to);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 31575, 31833);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 31853, 31860);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 31485, 31875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32080, 32087);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 31106, 32098);

                int
                f_1507_31208_31272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31208, 31272);
                    return 0;
                }


                System.TypeCode
                f_1507_31399_31421(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31399, 31421);
                    return return_v;
                }


                System.TypeCode
                f_1507_31450_31470(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31450, 31470);
                    return return_v;
                }


                bool
                f_1507_31489_31514(System.TypeCode
                typeCode)
                {
                    var return_v = TypeUtils.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31489, 31514);
                    return return_v;
                }


                bool
                f_1507_31518_31541(System.TypeCode
                typeCode)
                {
                    var return_v = TypeUtils.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31518, 31541);
                    return return_v;
                }


                int
                f_1507_31630_31679(System.Management.Automation.Interpreter.InstructionList
                this_param, System.TypeCode
                from, System.TypeCode
                to)
                {
                    this_param.EmitNumericConvertChecked(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31630, 31679);
                    return 0;
                }


                int
                f_1507_31762_31813(System.Management.Automation.Interpreter.InstructionList
                this_param, System.TypeCode
                from, System.TypeCode
                to)
                {
                    this_param.EmitNumericConvertUnchecked(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 31762, 31813);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 31106, 32098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 31106, 32098);
            }
        }

        private void CompileNotExpression(UnaryExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 32110, 32453);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32190, 32442) || true) && (f_1507_32194_32211(f_1507_32194_32206(node)) == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32190, 32442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32261, 32283);

                    f_1507_32261_32282(this, f_1507_32269_32281(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32301, 32325);

                    f_1507_32301_32324(_instructions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32190, 32442);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32190, 32442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32391, 32427);

                    throw f_1507_32397_32426();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32190, 32442);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 32110, 32453);

                System.Linq.Expressions.Expression
                f_1507_32194_32206(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32194, 32206);
                    return return_v;
                }


                System.Type
                f_1507_32194_32211(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32194, 32211);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_32269_32281(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32269, 32281);
                    return return_v;
                }


                int
                f_1507_32261_32282(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32261, 32282);
                    return 0;
                }


                int
                f_1507_32301_32324(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitNot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32301, 32324);
                    return 0;
                }


                System.NotImplementedException
                f_1507_32397_32426()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32397, 32426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 32110, 32453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 32110, 32453);
            }
        }

        private void CompileUnaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 32465, 33262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32542, 32575);

                var
                node = (UnaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32591, 33251) || true) && (f_1507_32595_32606(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32591, 33251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32648, 32670);

                    f_1507_32648_32669(this, f_1507_32656_32668(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32688, 32724);

                    f_1507_32688_32723(_instructions, f_1507_32711_32722(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32591, 33251);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32591, 33251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32790, 33236);

                    switch (f_1507_32798_32811(node))
                    {

                        case ExpressionType.Not:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32790, 33236);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32903, 32930);

                            f_1507_32903_32929(this, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 32956, 32963);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32790, 33236);

                        case ExpressionType.TypeAs:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32790, 33236);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33038, 33068);

                            f_1507_33038_33067(this, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33094, 33101);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32790, 33236);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 32790, 33236);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33157, 33217);

                            throw f_1507_33163_33216(f_1507_33191_33215(f_1507_33191_33204(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32790, 33236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 32591, 33251);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 32465, 33262);

                System.Reflection.MethodInfo
                f_1507_32595_32606(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32595, 32606);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_32656_32668(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32656, 32668);
                    return return_v;
                }


                int
                f_1507_32648_32669(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32648, 32669);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1507_32711_32722(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32711, 32722);
                    return return_v;
                }


                int
                f_1507_32688_32723(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32688, 32723);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_32798_32811(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 32798, 32811);
                    return return_v;
                }


                int
                f_1507_32903_32929(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.UnaryExpression
                node)
                {
                    this_param.CompileNotExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 32903, 32929);
                    return 0;
                }


                int
                f_1507_33038_33067(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.UnaryExpression
                node)
                {
                    this_param.CompileTypeAsExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33038, 33067);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_33191_33204(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33191, 33204);
                    return return_v;
                }


                string
                f_1507_33191_33215(System.Linq.Expressions.ExpressionType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33191, 33215);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_33163_33216(string
                message)
                {
                    var return_v = new System.NotImplementedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33163, 33216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 32465, 33262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 32465, 33262);
            }
        }

        private void CompileAndAlsoBinaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 33274, 33413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33359, 33402);

                f_1507_33359_33401(this, expr, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 33274, 33413);

                int
                f_1507_33359_33401(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                andAlso)
                {
                    this_param.CompileLogicalBinaryExpression(expr, andAlso);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33359, 33401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 33274, 33413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 33274, 33413);
            }
        }

        private void CompileOrElseBinaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 33425, 33564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33509, 33553);

                f_1507_33509_33552(this, expr, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 33425, 33564);

                int
                f_1507_33509_33552(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                andAlso)
                {
                    this_param.CompileLogicalBinaryExpression(expr, andAlso);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33509, 33552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 33425, 33564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 33425, 33564);
            }
        }

        private void CompileLogicalBinaryExpression(Expression expr, bool andAlso)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 33576, 34795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33675, 33709);

                var
                node = (BinaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33723, 33831) || true) && (f_1507_33727_33738(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 33723, 33831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33780, 33816);

                    throw f_1507_33786_33815();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 33723, 33831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33847, 33895);

                f_1507_33847_33894(f_1507_33860_33874(f_1507_33860_33869(node)) == f_1507_33878_33893(f_1507_33878_33888(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33911, 34672) || true) && (f_1507_33915_33929(f_1507_33915_33924(node)) == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 33911, 34672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 33979, 34021);

                    var
                    elseLabel = f_1507_33995_34020(_instructions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34039, 34080);

                    var
                    endLabel = f_1507_34054_34079(_instructions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34098, 34117);

                    f_1507_34098_34116(this, f_1507_34106_34115(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34135, 34370) || true) && (andAlso)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 34135, 34370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34188, 34229);

                        f_1507_34188_34228(_instructions, elseLabel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 34135, 34370);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 34135, 34370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34311, 34351);

                        f_1507_34311_34350(_instructions, elseLabel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 34135, 34370);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34390, 34410);

                    f_1507_34390_34409(this, f_1507_34398_34408(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34428, 34476);

                    f_1507_34428_34475(_instructions, endLabel, false, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34494, 34529);

                    f_1507_34494_34528(_instructions, elseLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34547, 34580);

                    f_1507_34547_34579(_instructions, !andAlso);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34598, 34632);

                    f_1507_34598_34631(_instructions, endLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34650, 34657);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 33911, 34672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34688, 34734);

                f_1507_34688_34733(f_1507_34701_34715(f_1507_34701_34710(node)) == typeof(bool?));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34748, 34784);

                throw f_1507_34754_34783();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 33576, 34795);

                System.Reflection.MethodInfo
                f_1507_33727_33738(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33727, 33738);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_33786_33815()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33786, 33815);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_33860_33869(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33860, 33869);
                    return return_v;
                }


                System.Type
                f_1507_33860_33874(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33860, 33874);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_33878_33888(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33878, 33888);
                    return return_v;
                }


                System.Type
                f_1507_33878_33893(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33878, 33893);
                    return return_v;
                }


                int
                f_1507_33847_33894(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33847, 33894);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_33915_33924(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33915, 33924);
                    return return_v;
                }


                System.Type
                f_1507_33915_33929(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 33915, 33929);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_33995_34020(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 33995, 34020);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_34054_34079(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34054, 34079);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_34106_34115(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34106, 34115);
                    return return_v;
                }


                int
                f_1507_34098_34116(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34098, 34116);
                    return 0;
                }


                int
                f_1507_34188_34228(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                elseLabel)
                {
                    this_param.EmitBranchFalse(elseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34188, 34228);
                    return 0;
                }


                int
                f_1507_34311_34350(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                elseLabel)
                {
                    this_param.EmitBranchTrue(elseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34311, 34350);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_34398_34408(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34398, 34408);
                    return return_v;
                }


                int
                f_1507_34390_34409(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34390, 34409);
                    return 0;
                }


                int
                f_1507_34428_34475(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitBranch(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34428, 34475);
                    return 0;
                }


                int
                f_1507_34494_34528(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34494, 34528);
                    return 0;
                }


                int
                f_1507_34547_34579(System.Management.Automation.Interpreter.InstructionList
                this_param, bool
                value)
                {
                    this_param.EmitLoad(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34547, 34579);
                    return 0;
                }


                int
                f_1507_34598_34631(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34598, 34631);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_34701_34710(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34701, 34710);
                    return return_v;
                }


                System.Type
                f_1507_34701_34715(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34701, 34715);
                    return return_v;
                }


                int
                f_1507_34688_34733(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34688, 34733);
                    return 0;
                }


                System.NotImplementedException
                f_1507_34754_34783()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34754, 34783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 33576, 34795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 33576, 34795);
            }
        }

        private void CompileConditionalExpression(Expression expr, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 34807, 36023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34903, 34942);

                var
                node = (ConditionalExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34956, 34975);

                f_1507_34956_34974(this, f_1507_34964_34973(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 34991, 36012) || true) && (f_1507_34995_35006(node) == f_1507_35010_35026())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 34991, 36012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35060, 35103);

                    var
                    endOfFalse = f_1507_35077_35102(_instructions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35121, 35162);

                    f_1507_35121_35161(_instructions, endOfFalse);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35180, 35210);

                    f_1507_35180_35209(this, f_1507_35188_35200(node), asVoid);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35228, 35264);

                    f_1507_35228_35263(_instructions, endOfFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 34991, 36012);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 34991, 36012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35330, 35372);

                    var
                    endOfTrue = f_1507_35346_35371(_instructions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35390, 35431);

                    f_1507_35390_35430(_instructions, endOfTrue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35449, 35478);

                    f_1507_35449_35477(this, f_1507_35457_35468(node), asVoid);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35498, 35997) || true) && (f_1507_35502_35514(node) != f_1507_35518_35534())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 35498, 35997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35576, 35619);

                        var
                        endOfFalse = f_1507_35593_35618(_instructions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35641, 35694);

                        f_1507_35641_35693(_instructions, endOfFalse, false, !asVoid);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35716, 35751);

                        f_1507_35716_35750(_instructions, endOfTrue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35773, 35803);

                        f_1507_35773_35802(this, f_1507_35781_35793(node), asVoid);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35825, 35861);

                        f_1507_35825_35860(_instructions, endOfFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 35498, 35997);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 35498, 35997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 35943, 35978);

                        f_1507_35943_35977(_instructions, endOfTrue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 35498, 35997);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 34991, 36012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 34807, 36023);

                System.Linq.Expressions.Expression
                f_1507_34964_34973(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34964, 34973);
                    return return_v;
                }


                int
                f_1507_34956_34974(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 34956, 34974);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_34995_35006(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.IfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 34995, 35006);
                    return return_v;
                }


                System.Linq.Expressions.DefaultExpression
                f_1507_35010_35026()
                {
                    var return_v = AstUtils.Empty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35010, 35026);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_35077_35102(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35077, 35102);
                    return return_v;
                }


                int
                f_1507_35121_35161(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                elseLabel)
                {
                    this_param.EmitBranchTrue(elseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35121, 35161);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_35188_35200(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.IfFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 35188, 35200);
                    return return_v;
                }


                int
                f_1507_35180_35209(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.Compile(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35180, 35209);
                    return 0;
                }


                int
                f_1507_35228_35263(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35228, 35263);
                    return 0;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_35346_35371(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35346, 35371);
                    return return_v;
                }


                int
                f_1507_35390_35430(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                elseLabel)
                {
                    this_param.EmitBranchFalse(elseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35390, 35430);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_35457_35468(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.IfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 35457, 35468);
                    return return_v;
                }


                int
                f_1507_35449_35477(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.Compile(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35449, 35477);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_35502_35514(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.IfFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 35502, 35514);
                    return return_v;
                }


                System.Linq.Expressions.DefaultExpression
                f_1507_35518_35534()
                {
                    var return_v = AstUtils.Empty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35518, 35534);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_35593_35618(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35593, 35618);
                    return return_v;
                }


                int
                f_1507_35641_35693(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitBranch(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35641, 35693);
                    return 0;
                }


                int
                f_1507_35716_35750(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35716, 35750);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_35781_35793(System.Linq.Expressions.ConditionalExpression
                this_param)
                {
                    var return_v = this_param.IfFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 35781, 35793);
                    return return_v;
                }


                int
                f_1507_35773_35802(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.Compile(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35773, 35802);
                    return 0;
                }


                int
                f_1507_35825_35860(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35825, 35860);
                    return 0;
                }


                int
                f_1507_35943_35977(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 35943, 35977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 34807, 36023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 34807, 36023);
            }
        }

        private void CompileLoopExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 36060, 37177);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 36060, 37177);
                //    var node = (LoopExpression)expr;
                //    var enterLoop = new EnterLoopInstruction(node, _locals, _compilationThreshold, _instructions.Count);
                //
                //    PushLabelBlock(LabelScopeKind.Statement);
                //    LabelInfo breakLabel = DefineLabel(node.BreakLabel);
                //    LabelInfo continueLabel = DefineLabel(node.ContinueLabel);
                //
                //    _instructions.MarkLabel(continueLabel.GetLabel(this));
                //
                //    // emit loop body:
                //    _instructions.Emit(enterLoop);
                //    CompileAsVoid(node.Body);
                //
                //    // emit loop branch:
                //    _instructions.EmitBranch(continueLabel.GetLabel(this), expr.Type != typeof(void), false);
                //
                //    _instructions.MarkLabel(breakLabel.GetLabel(this));
                //
                //    PopLabelBlock(LabelScopeKind.Statement);
                //
                //    enterLoop.FinishLoop(_instructions.Count);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 36060, 37177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 36060, 37177);
            }
        }

        private void CompileSwitchExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 37211, 39142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37289, 37323);

                var
                node = (SwitchExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37411, 37563) || true) && (f_1507_37415_37436(f_1507_37415_37431(node)) != typeof(int) || (DynAbs.Tracing.TraceSender.Expression_False(1507, 37415, 37478) || f_1507_37455_37470(node) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 37411, 37563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37512, 37548);

                    throw f_1507_37518_37547();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 37411, 37563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37624, 37781) || true) && (!f_1507_37629_37696(f_1507_37629_37639(node), c => c.TestValues.All(t => t is ConstantExpression)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 37624, 37781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37730, 37766);

                    throw f_1507_37736_37765();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 37624, 37781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37797, 37831);

                LabelInfo
                end = f_1507_37813_37830(this, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37845, 37887);

                bool
                hasValue = f_1507_37861_37870(node) != typeof(void)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37903, 37929);

                f_1507_37903_37928(this, f_1507_37911_37927(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37943, 37985);

                var
                caseDict = f_1507_37958_37984()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 37999, 38037);

                int
                switchIndex = f_1507_38017_38036(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38051, 38086);

                f_1507_38051_38085(_instructions, caseDict);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38102, 38295) || true) && (f_1507_38106_38122(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 38102, 38295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38164, 38190);

                    f_1507_38164_38189(this, f_1507_38172_38188(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 38102, 38295);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 38102, 38295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38256, 38280);

                    f_1507_38256_38279(!hasValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 38102, 38295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38311, 38373);

                f_1507_38311_38372(
                            _instructions, f_1507_38336_38354(end, this), false, hasValue);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38398, 38403);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38389, 39071) || true) && (i < f_1507_38409_38425(f_1507_38409_38419(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38427, 38430)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 38389, 39071))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 38389, 39071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38464, 38495);

                        var
                        switchCase = f_1507_38481_38494(f_1507_38481_38491(node), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38515, 38566);

                        int
                        caseOffset = f_1507_38532_38551(_instructions) - switchIndex
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38593, 38602);
                            for (int
            index = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38584, 38840) || true) && (index < f_1507_38612_38639(f_1507_38612_38633(switchCase)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38641, 38648)
            , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 38584, 38840))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 38584, 38840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38690, 38755);

                                var
                                testValue = (ConstantExpression)f_1507_38726_38754(f_1507_38726_38747(switchCase), index)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38777, 38821);

                                caseDict[(int)f_1507_38791_38806(testValue)] = caseOffset;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 257);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 257);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38860, 38885);

                        f_1507_38860_38884(this, f_1507_38868_38883(switchCase));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38905, 39056) || true) && (i < f_1507_38913_38929(f_1507_38913_38923(node)) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 38905, 39056);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 38975, 39037);

                            f_1507_38975_39036(_instructions, f_1507_39000_39018(end, this), false, hasValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 38905, 39056);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39087, 39131);

                f_1507_39087_39130(
                            _instructions, f_1507_39111_39129(end, this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 37211, 39142);

                System.Linq.Expressions.Expression
                f_1507_37415_37431(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37415, 37431);
                    return return_v;
                }


                System.Type
                f_1507_37415_37436(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37415, 37436);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_37455_37470(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Comparison;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37455, 37470);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_37518_37547()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37518, 37547);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                f_1507_37629_37639(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37629, 37639);
                    return return_v;
                }


                bool
                f_1507_37629_37696(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                source, System.Func<System.Linq.Expressions.SwitchCase, bool>
                predicate)
                {
                    var return_v = source.All<System.Linq.Expressions.SwitchCase>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37629, 37696);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_37736_37765()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37736, 37765);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_37813_37830(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.DefineLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37813, 37830);
                    return return_v;
                }


                System.Type
                f_1507_37861_37870(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37861, 37870);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_37911_37927(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 37911, 37927);
                    return return_v;
                }


                int
                f_1507_37903_37928(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37903, 37928);
                    return 0;
                }


                System.Collections.Generic.Dictionary<int, int>
                f_1507_37958_37984()
                {
                    var return_v = new System.Collections.Generic.Dictionary<int, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 37958, 37984);
                    return return_v;
                }


                int
                f_1507_38017_38036(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38017, 38036);
                    return return_v;
                }


                int
                f_1507_38051_38085(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Collections.Generic.Dictionary<int, int>
                cases)
                {
                    this_param.EmitSwitch(cases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38051, 38085);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_38106_38122(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.DefaultBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38106, 38122);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_38172_38188(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.DefaultBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38172, 38188);
                    return return_v;
                }


                int
                f_1507_38164_38189(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38164, 38189);
                    return 0;
                }


                int
                f_1507_38256_38279(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38256, 38279);
                    return 0;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_38336_38354(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38336, 38354);
                    return return_v;
                }


                int
                f_1507_38311_38372(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitBranch(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38311, 38372);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                f_1507_38409_38419(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38409, 38419);
                    return return_v;
                }


                int
                f_1507_38409_38425(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38409, 38425);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                f_1507_38481_38491(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38481, 38491);
                    return return_v;
                }


                System.Linq.Expressions.SwitchCase
                f_1507_38481_38494(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38481, 38494);
                    return return_v;
                }


                int
                f_1507_38532_38551(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38532, 38551);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_38612_38633(System.Linq.Expressions.SwitchCase
                this_param)
                {
                    var return_v = this_param.TestValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38612, 38633);
                    return return_v;
                }


                int
                f_1507_38612_38639(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38612, 38639);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_38726_38747(System.Linq.Expressions.SwitchCase
                this_param)
                {
                    var return_v = this_param.TestValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38726, 38747);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_38726_38754(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38726, 38754);
                    return return_v;
                }


                object
                f_1507_38791_38806(System.Linq.Expressions.ConstantExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38791, 38806);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_38868_38883(System.Linq.Expressions.SwitchCase
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38868, 38883);
                    return return_v;
                }


                int
                f_1507_38860_38884(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38860, 38884);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                f_1507_38913_38923(System.Linq.Expressions.SwitchExpression
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38913, 38923);
                    return return_v;
                }


                int
                f_1507_38913_38929(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 38913, 38929);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_39000_39018(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 39000, 39018);
                    return return_v;
                }


                int
                f_1507_38975_39036(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitBranch(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 38975, 39036);
                    return 0;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_39111_39129(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 39111, 39129);
                    return return_v;
                }


                int
                f_1507_39087_39130(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 39087, 39130);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 37211, 39142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 37211, 39142);
            }
        }

        private void CompileLabelExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 39154, 40624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39231, 39264);

                var
                node = (LabelExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39507, 39530);

                LabelInfo
                label = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39546, 40103) || true) && (_labelBlock.Kind == LabelScopeKind.Block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 39546, 40103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39624, 39676);

                    f_1507_39624_39675(_labelBlock, f_1507_39652_39663(node), out label);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39771, 39960) || true) && (label == null && (DynAbs.Tracing.TraceSender.Expression_True(1507, 39775, 39840) && _labelBlock.Parent.Kind == LabelScopeKind.Switch))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 39771, 39960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 39882, 39941);

                        f_1507_39882_39940(_labelBlock.Parent, f_1507_39917_39928(node), out label);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 39771, 39960);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40060, 40088);

                    f_1507_40060_40087(label != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 39546, 40103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40119, 40218) || true) && (label == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 40119, 40218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40170, 40203);

                    label = f_1507_40178_40202(this, f_1507_40190_40201(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 40119, 40218);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40234, 40551) || true) && (f_1507_40238_40255(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 40234, 40551);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40297, 40536) || true) && (f_1507_40301_40317(f_1507_40301_40312(node)) == typeof(void))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 40297, 40536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40375, 40408);

                        f_1507_40375_40407(this, f_1507_40389_40406(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 40297, 40536);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 40297, 40536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40490, 40517);

                        f_1507_40490_40516(this, f_1507_40498_40515(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 40297, 40536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 40234, 40551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40567, 40613);

                f_1507_40567_40612(
                            _instructions, f_1507_40591_40611(label, this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 39154, 40624);

                System.Linq.Expressions.LabelTarget
                f_1507_39652_39663(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 39652, 39663);
                    return return_v;
                }


                bool
                f_1507_39624_39675(System.Management.Automation.Interpreter.LabelScopeInfo
                this_param, System.Linq.Expressions.LabelTarget
                target, out System.Management.Automation.Interpreter.LabelInfo
                info)
                {
                    var return_v = this_param.TryGetLabelInfo(target, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 39624, 39675);
                    return return_v;
                }


                System.Linq.Expressions.LabelTarget
                f_1507_39917_39928(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 39917, 39928);
                    return return_v;
                }


                bool
                f_1507_39882_39940(System.Management.Automation.Interpreter.LabelScopeInfo
                this_param, System.Linq.Expressions.LabelTarget
                target, out System.Management.Automation.Interpreter.LabelInfo
                info)
                {
                    var return_v = this_param.TryGetLabelInfo(target, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 39882, 39940);
                    return return_v;
                }


                int
                f_1507_40060_40087(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40060, 40087);
                    return 0;
                }


                System.Linq.Expressions.LabelTarget
                f_1507_40190_40201(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40190, 40201);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_40178_40202(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.DefineLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40178, 40202);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_40238_40255(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40238, 40255);
                    return return_v;
                }


                System.Linq.Expressions.LabelTarget
                f_1507_40301_40312(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40301, 40312);
                    return return_v;
                }


                System.Type
                f_1507_40301_40317(System.Linq.Expressions.LabelTarget
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40301, 40317);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_40389_40406(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40389, 40406);
                    return return_v;
                }


                int
                f_1507_40375_40407(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoid(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40375, 40407);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_40498_40515(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40498, 40515);
                    return return_v;
                }


                int
                f_1507_40490_40516(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40490, 40516);
                    return 0;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_40591_40611(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40591, 40611);
                    return return_v;
                }


                int
                f_1507_40567_40612(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40567, 40612);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 39154, 40624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 39154, 40624);
            }
        }

        private void CompileGotoExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 40636, 41067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40712, 40744);

                var
                node = (GotoExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40758, 40802);

                var
                labelInfo = f_1507_40774_40801(this, f_1507_40789_40800(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40818, 40909) || true) && (f_1507_40822_40832(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 40818, 40909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40874, 40894);

                    f_1507_40874_40893(this, f_1507_40882_40892(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 40818, 40909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 40925, 41056);

                f_1507_40925_41055(
                            _instructions, f_1507_40948_40972(labelInfo, this), f_1507_40974_40983(node) != typeof(void), f_1507_41001_41011(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(1507, 41001, 41054) && f_1507_41023_41038(f_1507_41023_41033(node)) != typeof(void)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 40636, 41067);

                System.Linq.Expressions.LabelTarget
                f_1507_40789_40800(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40789, 40800);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_40774_40801(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.ReferenceLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40774, 40801);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_40822_40832(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40822, 40832);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_40882_40892(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40882, 40892);
                    return return_v;
                }


                int
                f_1507_40874_40893(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40874, 40893);
                    return 0;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_40948_40972(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40948, 40972);
                    return return_v;
                }


                System.Type
                f_1507_40974_40983(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 40974, 40983);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_41001_41011(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 41001, 41011);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_41023_41033(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 41023, 41033);
                    return return_v;
                }


                System.Type
                f_1507_41023_41038(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 41023, 41038);
                    return return_v;
                }


                int
                f_1507_40925_41055(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitGoto(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 40925, 41055);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 40636, 41067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 40636, 41067);
            }
        }

        public BranchLabel GetBranchLabel(LabelTarget target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 41079, 41213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41157, 41202);

                return f_1507_41164_41201(f_1507_41164_41186(this, target), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 41079, 41213);

                System.Management.Automation.Interpreter.LabelInfo
                f_1507_41164_41186(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.ReferenceLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41164, 41186);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_41164_41201(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41164, 41201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 41079, 41213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 41079, 41213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void PushLabelBlock(LabelScopeKind type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 41225, 41360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41297, 41349);

                _labelBlock = f_1507_41311_41348(_labelBlock, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 41225, 41360);

                System.Management.Automation.Interpreter.LabelScopeInfo
                f_1507_41311_41348(System.Management.Automation.Interpreter.LabelScopeInfo
                parent, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    var return_v = new System.Management.Automation.Interpreter.LabelScopeInfo(parent, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41311, 41348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 41225, 41360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 41225, 41360);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "kind")]
        public void PopLabelBlock(LabelScopeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 41372, 41694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41574, 41636);

                f_1507_41574_41635(_labelBlock != null && (DynAbs.Tracing.TraceSender.Expression_True(1507, 41587, 41634) && _labelBlock.Kind == kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41650, 41683);

                _labelBlock = _labelBlock.Parent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 41372, 41694);

                int
                f_1507_41574_41635(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41574, 41635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 41372, 41694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 41372, 41694);
            }
        }

        private LabelInfo EnsureLabel(LabelTarget node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 41706, 41994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41778, 41795);

                LabelInfo
                result
                = default(LabelInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41809, 41953) || true) && (!f_1507_41814_41855(_treeLabels, node, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 41809, 41953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41889, 41938);

                    _treeLabels[node] = result = f_1507_41918_41937(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 41809, 41953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 41969, 41983);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 41706, 41994);

                bool
                f_1507_41814_41855(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                this_param, System.Linq.Expressions.LabelTarget
                key, out System.Management.Automation.Interpreter.LabelInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41814, 41855);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_41918_41937(System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = new System.Management.Automation.Interpreter.LabelInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 41918, 41937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 41706, 41994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 41706, 41994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LabelInfo ReferenceLabel(LabelTarget node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 42006, 42201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42081, 42118);

                LabelInfo
                result = f_1507_42100_42117(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42132, 42162);

                f_1507_42132_42161(result, _labelBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42176, 42190);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 42006, 42201);

                System.Management.Automation.Interpreter.LabelInfo
                f_1507_42100_42117(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.EnsureLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 42100, 42117);
                    return return_v;
                }


                int
                f_1507_42132_42161(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                block)
                {
                    this_param.Reference(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 42132, 42161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 42006, 42201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 42006, 42201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LabelInfo DefineLabel(LabelTarget node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 42213, 42511);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42286, 42378) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 42286, 42378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42336, 42363);

                    return f_1507_42343_42362(null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 42286, 42378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42394, 42431);

                LabelInfo
                result = f_1507_42413_42430(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42445, 42472);

                f_1507_42445_42471(result, _labelBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 42486, 42500);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 42213, 42511);

                System.Management.Automation.Interpreter.LabelInfo
                f_1507_42343_42362(System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = new System.Management.Automation.Interpreter.LabelInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 42343, 42362);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_42413_42430(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.EnsureLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 42413, 42430);
                    return return_v;
                }


                int
                f_1507_42445_42471(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                block)
                {
                    this_param.Define(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 42445, 42471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 42213, 42511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 42213, 42511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryPushLabelBlock(Expression node)
        {
            // Anything that is "statement-like" -- e.g. has no associated
            // stack state can be jumped into, with the exception of try-blocks
            // We indicate this by a "Block"
            //
            // Otherwise, we push an "Expression" to indicate that it can't be
            // jumped into
            switch (node.NodeType)
            {
                default:
                    if (_labelBlock.Kind != LabelScopeKind.Expression)
                    {
                        PushLabelBlock(LabelScopeKind.Expression);
                        return true;
                    }

                    return false;
                case ExpressionType.Label:
                    // LabelExpression is a bit special, if it's directly in a
                    // block it becomes associate with the block's scope. Same
                    // thing if it's in a switch case body.
                    if (_labelBlock.Kind == LabelScopeKind.Block)
                    {
                        var label = ((LabelExpression)node).Target;
                        if (_labelBlock.ContainsTarget(label))
                        {
                            return false;
                        }

                        if (_labelBlock.Parent.Kind == LabelScopeKind.Switch &&
                            _labelBlock.Parent.ContainsTarget(label))
                        {
                            return false;
                        }
                    }

                    PushLabelBlock(LabelScopeKind.Statement);
                    return true;
                case ExpressionType.Block:
                    PushLabelBlock(LabelScopeKind.Block);
                    // Labels defined immediately in the block are valid for
                    // the whole block.
                    if (_labelBlock.Parent.Kind != LabelScopeKind.Switch)
                    {
                        DefineBlockLabels(node);
                    }

                    return true;
                case ExpressionType.Switch:
                    PushLabelBlock(LabelScopeKind.Switch);
                    // Define labels inside of the switch cases so they are in
                    // scope for the whole switch. This allows "goto case" and
                    // "goto default" to be considered as local jumps.
                    var @switch = (SwitchExpression)node;
                    for (int index = 0; index < @switch.Cases.Count; index++)
                    {
                        SwitchCase c = @switch.Cases[index];
                        DefineBlockLabels(c.Body);
                    }

                    DefineBlockLabels(@switch.DefaultBody);
                    return true;

                // Remove this when Convert(Void) goes away.
                case ExpressionType.Convert:
                    if (node.Type != typeof(void))
                    {
                        // treat it as an expression
                        goto default;
                    }

                    PushLabelBlock(LabelScopeKind.Statement);
                    return true;

                case ExpressionType.Conditional:
                case ExpressionType.Loop:
                case ExpressionType.Goto:
                    PushLabelBlock(LabelScopeKind.Statement);
                    return true;
            }
        }

        private void DefineBlockLabels(Expression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 46038, 46575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46110, 46146);

                var
                block = node as BlockExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46160, 46233) || true) && (block == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 46160, 46233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46211, 46218);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 46160, 46233);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46258, 46263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46265, 46292);

                    for (int
        i = 0
        ,
        n = f_1507_46269_46292(f_1507_46269_46286(block))
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46249, 46564) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46301, 46304)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 46249, 46564))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 46249, 46564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46338, 46374);

                        Expression
                        e = f_1507_46353_46373(f_1507_46353_46370(block), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46394, 46427);

                        var
                        label = e as LabelExpression
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46445, 46549) || true) && (label != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 46445, 46549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46504, 46530);

                            f_1507_46504_46529(this, f_1507_46516_46528(label));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 46445, 46549);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 316);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 46038, 46575);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_46269_46286(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46269, 46286);
                    return return_v;
                }


                int
                f_1507_46269_46292(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46269, 46292);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_46353_46370(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46353, 46370);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_46353_46373(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46353, 46373);
                    return return_v;
                }


                System.Linq.Expressions.LabelTarget
                f_1507_46516_46528(System.Linq.Expressions.LabelExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46516, 46528);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelInfo
                f_1507_46504_46529(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LabelTarget
                node)
                {
                    var return_v = this_param.DefineLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 46504, 46529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 46038, 46575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 46038, 46575);
            }
        }

        private HybridReferenceDictionary<LabelTarget, BranchLabel> GetBranchMapping()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 46587, 46983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46690, 46787);

                var
                newLabelMapping = f_1507_46712_46786(f_1507_46768_46785(_treeLabels))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46801, 46933);
                    foreach (var kvp in f_1507_46821_46832_I(_treeLabels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 46801, 46933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46866, 46918);

                        newLabelMapping[kvp.Key] = f_1507_46893_46917(kvp.Value, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 46801, 46933);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 46949, 46972);

                return newLabelMapping;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 46587, 46983);

                int
                f_1507_46768_46785(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 46768, 46785);
                    return return_v;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                f_1507_46712_46786(int
                initialCapacity)
                {
                    var return_v = new System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 46712, 46786);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_46893_46917(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    var return_v = this_param.GetLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 46893, 46917);
                    return return_v;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                f_1507_46821_46832_I(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 46821, 46832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 46587, 46983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 46587, 46983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileThrowUnaryExpression(Expression expr, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 46995, 47830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47090, 47123);

                var
                node = (UnaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47139, 47819) || true) && (f_1507_47143_47155(node) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47139, 47819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47197, 47258);

                    f_1507_47197_47257(this, f_1507_47224_47256(_exceptionForRethrowStack));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47276, 47489) || true) && (asVoid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47276, 47489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47328, 47360);

                        f_1507_47328_47359(_instructions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47276, 47489);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47276, 47489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47442, 47470);

                        f_1507_47442_47469(_instructions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47276, 47489);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47139, 47819);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47139, 47819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47555, 47577);

                    f_1507_47555_47576(this, f_1507_47563_47575(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47595, 47804) || true) && (asVoid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47595, 47804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47647, 47677);

                        f_1507_47647_47676(_instructions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47595, 47804);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47595, 47804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47759, 47785);

                        f_1507_47759_47784(_instructions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47595, 47804);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47139, 47819);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 46995, 47830);

                System.Linq.Expressions.Expression
                f_1507_47143_47155(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 47143, 47155);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_47224_47256(System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47224, 47256);
                    return return_v;
                }


                int
                f_1507_47197_47257(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                expr)
                {
                    this_param.CompileParameterExpression((System.Linq.Expressions.Expression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47197, 47257);
                    return 0;
                }


                int
                f_1507_47328_47359(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitRethrowVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47328, 47359);
                    return 0;
                }


                int
                f_1507_47442_47469(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitRethrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47442, 47469);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_47563_47575(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 47563, 47575);
                    return return_v;
                }


                int
                f_1507_47555_47576(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47555, 47576);
                    return 0;
                }


                int
                f_1507_47647_47676(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitThrowVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47647, 47676);
                    return 0;
                }


                int
                f_1507_47759_47784(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitThrow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 47759, 47784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 46995, 47830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 46995, 47830);
            }
        }

        private bool EndsWithRethrow(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 47899, 48393);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 47969, 48138) || true) && (f_1507_47973_47986(expr) == ExpressionType.Throw)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 47969, 48138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48044, 48077);

                    var
                    node = (UnaryExpression)expr
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48095, 48123);

                    return f_1507_48102_48114(node) == null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 47969, 48138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48154, 48202);

                BlockExpression
                block = expr as BlockExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48216, 48353) || true) && (block != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 48216, 48353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48267, 48338);

                    return f_1507_48274_48337(this, f_1507_48290_48336(f_1507_48290_48307(block), f_1507_48308_48331(f_1507_48308_48325(block)) - 1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 48216, 48353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48369, 48382);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 47899, 48393);

                System.Linq.Expressions.ExpressionType
                f_1507_47973_47986(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 47973, 47986);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_48102_48114(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48102, 48114);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_48290_48307(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48290, 48307);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_48308_48325(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48308, 48325);
                    return return_v;
                }


                int
                f_1507_48308_48331(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48308, 48331);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_48290_48336(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48290, 48336);
                    return return_v;
                }


                bool
                f_1507_48274_48337(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    var return_v = this_param.EndsWithRethrow(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 48274, 48337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 47899, 48393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 47899, 48393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileAsVoidRemoveRethrow(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 48462, 49087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48543, 48592);

                int
                stackDepth = f_1507_48560_48591(_instructions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48608, 48777) || true) && (f_1507_48612_48625(expr) == ExpressionType.Throw)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 48608, 48777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48683, 48737);

                    f_1507_48683_48736(f_1507_48696_48727(((UnaryExpression)expr)) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48755, 48762);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 48608, 48777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48793, 48826);

                var
                node = (BlockExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48840, 48874);

                var
                end = f_1507_48850_48873(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48890, 48963);

                f_1507_48890_48962(this, f_1507_48917_48961(f_1507_48917_48933(node), f_1507_48934_48956(f_1507_48934_48950(node)) - 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 48979, 49039);

                f_1507_48979_49038(stackDepth == f_1507_49006_49037(_instructions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49055, 49076);

                f_1507_49055_49075(this, end);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 48462, 49087);

                int
                f_1507_48560_48591(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48560, 48591);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_48612_48625(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48612, 48625);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_48696_48727(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48696, 48727);
                    return return_v;
                }


                int
                f_1507_48683_48736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 48683, 48736);
                    return 0;
                }


                System.Management.Automation.Interpreter.LocalDefinition[]
                f_1507_48850_48873(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.BlockExpression
                node)
                {
                    var return_v = this_param.CompileBlockStart(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 48850, 48873);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_48917_48933(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48917, 48933);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_48934_48950(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48934, 48950);
                    return return_v;
                }


                int
                f_1507_48934_48956(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48934, 48956);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_48917_48961(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 48917, 48961);
                    return return_v;
                }


                int
                f_1507_48890_48962(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoidRemoveRethrow(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 48890, 48962);
                    return 0;
                }


                int
                f_1507_49006_49037(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 49006, 49037);
                    return return_v;
                }


                int
                f_1507_48979_49038(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 48979, 49038);
                    return 0;
                }


                int
                f_1507_49055_49075(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LocalDefinition[]
                locals)
                {
                    this_param.CompileBlockEnd(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49055, 49075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 48462, 49087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 48462, 49087);
            }
        }

        private void CompileTryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 49099, 55587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49174, 49205);

                var
                node = (TryExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49221, 49265);

                BranchLabel
                end = f_1507_49239_49264(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49279, 49327);

                BranchLabel
                gotoEnd = f_1507_49301_49326(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49341, 49376);

                int
                tryStart = f_1507_49356_49375(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49392, 49426);

                BranchLabel
                startOfFinally = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49440, 49724) || true) && (f_1507_49444_49456(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 49440, 49724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49498, 49541);

                    startOfFinally = f_1507_49515_49540(_instructions);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49559, 49609);

                    f_1507_49559_49608(_instructions, startOfFinally);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 49440, 49724);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 49440, 49724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49675, 49709);

                    f_1507_49675_49708(_instructions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 49440, 49724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49740, 49781);

                List<ExceptionHandler>
                exHandlers = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49795, 49889);

                var
                enterTryInstr = f_1507_49815_49853(_instructions, tryStart) as EnterTryCatchFinallyInstruction
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49903, 49939);

                f_1507_49903_49938(enterTryInstr != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 49955, 49990);

                f_1507_49955_49989(this, LabelScopeKind.Try);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50004, 50023);

                f_1507_50004_50022(this, f_1507_50012_50021(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50039, 50086);

                bool
                hasValue = f_1507_50055_50069(f_1507_50055_50064(node)) != typeof(void)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50100, 50133);

                int
                tryEnd = f_1507_50113_50132(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50185, 50218);

                f_1507_50185_50217(
                            // handlers jump here:
                            _instructions, gotoEnd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50232, 50280);

                f_1507_50232_50279(_instructions, end, hasValue, hasValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50342, 54478) || true) && (f_1507_50346_50365(f_1507_50346_50359(node)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50342, 54478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50403, 50445);

                    exHandlers = f_1507_50416_50444();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50539, 52176) || true) && (f_1507_50543_50555(node) == null && (DynAbs.Tracing.TraceSender.Expression_True(1507, 50543, 50591) && f_1507_50567_50586(f_1507_50567_50580(node)) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50539, 52176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50633, 50664);

                        var
                        handler = f_1507_50647_50663(f_1507_50647_50660(node), 0)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50686, 52157) || true) && (f_1507_50690_50704(handler) == null && (DynAbs.Tracing.TraceSender.Expression_True(1507, 50690, 50749) && f_1507_50716_50728(handler) == typeof(Exception)) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 50690, 50777) && f_1507_50753_50769(handler) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50686, 52157);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50827, 52134) || true) && (f_1507_50831_50860(this, f_1507_50847_50859(handler)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50827, 52134);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50918, 51252) || true) && (hasValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50918, 51252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 50996, 51045);

                                    f_1507_50996_51044(_instructions);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50918, 51252);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 50918, 51252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51175, 51221);

                                    f_1507_51175_51220(_instructions);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50918, 51252);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51395, 51447);

                                int
                                handlerLabel = f_1507_51414_51446(_instructions)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51477, 51516);

                                int
                                handlerStart = f_1507_51496_51515(_instructions)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51548, 51589);

                                f_1507_51548_51588(this, f_1507_51575_51587(handler));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51619, 51658);

                                f_1507_51619_51657(_instructions, hasValue);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51688, 51717);

                                f_1507_51688_51716(_instructions, end);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51749, 51859);

                                f_1507_51749_51858(
                                                            exHandlers, f_1507_51764_51857(tryStart, tryEnd, handlerLabel, handlerStart, f_1507_51831_51850(_instructions), null));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 51889, 52006);

                                f_1507_51889_52005(enterTryInstr, f_1507_51917_52004(tryStart, tryEnd, f_1507_51962_51981(gotoEnd), f_1507_51983_52003(exHandlers)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52036, 52070);

                                f_1507_52036_52069(this, LabelScopeKind.Try);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52100, 52107);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50827, 52134);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50686, 52157);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50539, 52176);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52205, 52214);

                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52196, 54324) || true) && (index < f_1507_52224_52243(f_1507_52224_52237(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52245, 52252)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 52196, 54324))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 52196, 54324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52294, 52329);

                            var
                            handler = f_1507_52308_52328(f_1507_52308_52321(node), index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52351, 52388);

                            f_1507_52351_52387(this, LabelScopeKind.Catch);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52412, 52680) || true) && (f_1507_52416_52430(handler) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 52412, 52680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52555, 52591);

                                throw f_1507_52561_52590();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 52412, 52680);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52704, 52775);

                            var
                            parameter = f_1507_52720_52736(handler) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Linq.Expressions.ParameterExpression>(1507, 52720, 52774) ?? f_1507_52740_52774(f_1507_52761_52773(handler)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52799, 52863);

                            var
                            local = f_1507_52811_52862(_locals, parameter, f_1507_52842_52861(_instructions))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 52885, 52927);

                            f_1507_52885_52926(_exceptionForRethrowStack, parameter);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53064, 53342) || true) && (hasValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 53064, 53342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53126, 53175);

                                f_1507_53126_53174(_instructions);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 53064, 53342);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 53064, 53342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53273, 53319);

                                f_1507_53273_53318(_instructions);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 53064, 53342);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53469, 53521);

                            int
                            handlerLabel = f_1507_53488_53520(_instructions)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53543, 53582);

                            int
                            handlerStart = f_1507_53562_53581(_instructions)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53606, 53642);

                            f_1507_53606_53641(this, parameter, true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53664, 53686);

                            f_1507_53664_53685(this, f_1507_53672_53684(handler));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53710, 53742);

                            f_1507_53710_53741(
                                                _exceptionForRethrowStack);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53831, 53893);

                            f_1507_53831_53892(hasValue == (f_1507_53857_53874(f_1507_53857_53869(handler)) != typeof(void)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53915, 53974);

                            f_1507_53915_53973(_instructions, hasValue, gotoEnd);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 53998, 54173);

                            f_1507_53998_54172(
                                                exHandlers, f_1507_54013_54171(tryStart, tryEnd, handlerLabel, handlerStart, f_1507_54137_54156(_instructions), f_1507_54158_54170(handler)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54195, 54231);

                            f_1507_54195_54230(this, LabelScopeKind.Catch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54255, 54305);

                            f_1507_54255_54304(
                                                _locals, local, f_1507_54284_54303(_instructions));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 2129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 2129);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54344, 54463) || true) && (f_1507_54348_54358(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 54344, 54463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54408, 54444);

                        throw f_1507_54414_54443();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 54344, 54463);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 50342, 54478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54494, 55481) || true) && (f_1507_54498_54510(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 54494, 55481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54552, 54589);

                    f_1507_54552_54588(startOfFinally != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54607, 54646);

                    f_1507_54607_54645(this, LabelScopeKind.Finally);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54666, 54706);

                    f_1507_54666_54705(
                                    _instructions, startOfFinally);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54724, 54771);

                    f_1507_54724_54770(_instructions, startOfFinally);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54789, 54817);

                    f_1507_54789_54816(this, f_1507_54803_54815(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54835, 54868);

                    f_1507_54835_54867(_instructions);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 54888, 55154);

                    f_1507_54888_55153(
                                    enterTryInstr, f_1507_54938_55152(tryStart, tryEnd, f_1507_54983_55002(gotoEnd), f_1507_55029_55055(startOfFinally), f_1507_55057_55076(_instructions), (DynAbs.Tracing.TraceSender.Conditional_F1(1507, 55103, 55121) || ((exHandlers != null && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 55124, 55144)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 55147, 55151))) ? f_1507_55124_55144(exHandlers) : null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55172, 55210);

                    f_1507_55172_55209(this, LabelScopeKind.Finally);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 54494, 55481);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 54494, 55481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55276, 55309);

                    f_1507_55276_55308(exHandlers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55327, 55466);

                    f_1507_55327_55465(enterTryInstr, f_1507_55377_55464(tryStart, tryEnd, f_1507_55422_55441(gotoEnd), f_1507_55443_55463(exHandlers)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 54494, 55481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55497, 55526);

                f_1507_55497_55525(
                            _instructions, end);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55542, 55576);

                f_1507_55542_55575(this, LabelScopeKind.Try);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 49099, 55587);

                System.Management.Automation.Interpreter.BranchLabel
                f_1507_49239_49264(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49239, 49264);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_49301_49326(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49301, 49326);
                    return return_v;
                }


                int
                f_1507_49356_49375(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 49356, 49375);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_49444_49456(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 49444, 49456);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_49515_49540(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49515, 49540);
                    return return_v;
                }


                int
                f_1507_49559_49608(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                finallyStartLabel)
                {
                    this_param.EmitEnterTryFinally(finallyStartLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49559, 49608);
                    return 0;
                }


                int
                f_1507_49675_49708(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitEnterTryCatch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49675, 49708);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1507_49815_49853(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                index)
                {
                    var return_v = this_param.GetInstruction(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49815, 49853);
                    return return_v;
                }


                int
                f_1507_49903_49938(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49903, 49938);
                    return 0;
                }


                int
                f_1507_49955_49989(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                type)
                {
                    this_param.PushLabelBlock(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 49955, 49989);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_50012_50021(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50012, 50021);
                    return return_v;
                }


                int
                f_1507_50004_50022(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50004, 50022);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_50055_50064(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50055, 50064);
                    return return_v;
                }


                System.Type
                f_1507_50055_50069(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50055, 50069);
                    return return_v;
                }


                int
                f_1507_50113_50132(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50113, 50132);
                    return return_v;
                }


                int
                f_1507_50185_50217(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50185, 50217);
                    return 0;
                }


                int
                f_1507_50232_50279(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label, bool
                hasResult, bool
                hasValue)
                {
                    this_param.EmitGoto(label, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50232, 50279);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                f_1507_50346_50359(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Handlers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50346, 50359);
                    return return_v;
                }


                int
                f_1507_50346_50365(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50346, 50365);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                f_1507_50416_50444()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50416, 50444);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_50543_50555(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50543, 50555);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                f_1507_50567_50580(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Handlers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50567, 50580);
                    return return_v;
                }


                int
                f_1507_50567_50586(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50567, 50586);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                f_1507_50647_50660(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Handlers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50647, 50660);
                    return return_v;
                }


                System.Linq.Expressions.CatchBlock
                f_1507_50647_50663(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50647, 50663);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_50690_50704(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50690, 50704);
                    return return_v;
                }


                System.Type
                f_1507_50716_50728(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50716, 50728);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_50753_50769(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50753, 50769);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_50847_50859(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 50847, 50859);
                    return return_v;
                }


                bool
                f_1507_50831_50860(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    var return_v = this_param.EndsWithRethrow(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50831, 50860);
                    return return_v;
                }


                int
                f_1507_50996_51044(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitEnterExceptionHandlerNonVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 50996, 51044);
                    return 0;
                }


                int
                f_1507_51175_51220(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitEnterExceptionHandlerVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51175, 51220);
                    return 0;
                }


                int
                f_1507_51414_51446(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MarkRuntimeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51414, 51446);
                    return return_v;
                }


                int
                f_1507_51496_51515(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 51496, 51515);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_51575_51587(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 51575, 51587);
                    return return_v;
                }


                int
                f_1507_51548_51588(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoidRemoveRethrow(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51548, 51588);
                    return 0;
                }


                int
                f_1507_51619_51657(System.Management.Automation.Interpreter.InstructionList
                this_param, bool
                hasValue)
                {
                    this_param.EmitLeaveFault(hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51619, 51657);
                    return 0;
                }


                int
                f_1507_51688_51716(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51688, 51716);
                    return 0;
                }


                int
                f_1507_51831_51850(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 51831, 51850);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ExceptionHandler
                f_1507_51764_51857(int
                start, int
                end, int
                labelIndex, int
                handlerStartIndex, int
                handlerEndIndex, System.Type
                exceptionType)
                {
                    var return_v = new System.Management.Automation.Interpreter.ExceptionHandler(start, end, labelIndex, handlerStartIndex, handlerEndIndex, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51764, 51857);
                    return return_v;
                }


                int
                f_1507_51749_51858(System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                this_param, System.Management.Automation.Interpreter.ExceptionHandler
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51749, 51858);
                    return 0;
                }


                int
                f_1507_51962_51981(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 51962, 51981);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ExceptionHandler[]
                f_1507_51983_52003(System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51983, 52003);
                    return return_v;
                }


                System.Management.Automation.Interpreter.TryCatchFinallyHandler
                f_1507_51917_52004(int
                tryStart, int
                tryEnd, int
                gotoEndTargetIndex, System.Management.Automation.Interpreter.ExceptionHandler[]
                handlers)
                {
                    var return_v = new System.Management.Automation.Interpreter.TryCatchFinallyHandler(tryStart, tryEnd, gotoEndTargetIndex, handlers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51917, 52004);
                    return return_v;
                }


                int
                f_1507_51889_52005(System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                this_param, System.Management.Automation.Interpreter.TryCatchFinallyHandler
                tryHandler)
                {
                    this_param.SetTryHandler(tryHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 51889, 52005);
                    return 0;
                }


                int
                f_1507_52036_52069(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52036, 52069);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                f_1507_52224_52237(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Handlers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52224, 52237);
                    return return_v;
                }


                int
                f_1507_52224_52243(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52224, 52243);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                f_1507_52308_52321(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Handlers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52308, 52321);
                    return return_v;
                }


                System.Linq.Expressions.CatchBlock
                f_1507_52308_52328(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52308, 52328);
                    return return_v;
                }


                int
                f_1507_52351_52387(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                type)
                {
                    this_param.PushLabelBlock(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52351, 52387);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_52416_52430(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52416, 52430);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_52561_52590()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52561, 52590);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_52720_52736(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52720, 52736);
                    return return_v;
                }


                System.Type
                f_1507_52761_52773(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52761, 52773);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_52740_52774(System.Type
                type)
                {
                    var return_v = Expression.Parameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52740, 52774);
                    return return_v;
                }


                int
                f_1507_52842_52861(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 52842, 52861);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalDefinition
                f_1507_52811_52862(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Linq.Expressions.ParameterExpression
                variable, int
                start)
                {
                    var return_v = this_param.DefineLocal(variable, start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52811, 52862);
                    return return_v;
                }


                int
                f_1507_52885_52926(System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 52885, 52926);
                    return 0;
                }


                int
                f_1507_53126_53174(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitEnterExceptionHandlerNonVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53126, 53174);
                    return 0;
                }


                int
                f_1507_53273_53318(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitEnterExceptionHandlerVoid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53273, 53318);
                    return 0;
                }


                int
                f_1507_53488_53520(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MarkRuntimeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53488, 53520);
                    return return_v;
                }


                int
                f_1507_53562_53581(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 53562, 53581);
                    return return_v;
                }


                int
                f_1507_53606_53641(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable, bool
                isVoid)
                {
                    this_param.CompileSetVariable(variable, isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53606, 53641);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_53672_53684(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 53672, 53684);
                    return return_v;
                }


                int
                f_1507_53664_53685(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53664, 53685);
                    return 0;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_53710_53741(System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53710, 53741);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_53857_53869(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 53857, 53869);
                    return return_v;
                }


                System.Type
                f_1507_53857_53874(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 53857, 53874);
                    return return_v;
                }


                int
                f_1507_53831_53892(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53831, 53892);
                    return 0;
                }


                int
                f_1507_53915_53973(System.Management.Automation.Interpreter.InstructionList
                this_param, bool
                hasValue, System.Management.Automation.Interpreter.BranchLabel
                tryExpressionEndLabel)
                {
                    this_param.EmitLeaveExceptionHandler(hasValue, tryExpressionEndLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53915, 53973);
                    return 0;
                }


                int
                f_1507_54137_54156(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54137, 54156);
                    return return_v;
                }


                System.Type
                f_1507_54158_54170(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54158, 54170);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ExceptionHandler
                f_1507_54013_54171(int
                start, int
                end, int
                labelIndex, int
                handlerStartIndex, int
                handlerEndIndex, System.Type
                exceptionType)
                {
                    var return_v = new System.Management.Automation.Interpreter.ExceptionHandler(start, end, labelIndex, handlerStartIndex, handlerEndIndex, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54013, 54171);
                    return return_v;
                }


                int
                f_1507_53998_54172(System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                this_param, System.Management.Automation.Interpreter.ExceptionHandler
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 53998, 54172);
                    return 0;
                }


                int
                f_1507_54195_54230(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54195, 54230);
                    return 0;
                }


                int
                f_1507_54284_54303(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54284, 54303);
                    return return_v;
                }


                int
                f_1507_54255_54304(System.Management.Automation.Interpreter.LocalVariables
                this_param, System.Management.Automation.Interpreter.LocalDefinition
                definition, int
                end)
                {
                    this_param.UndefineLocal(definition, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54255, 54304);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_54348_54358(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Fault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54348, 54358);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_54414_54443()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54414, 54443);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_54498_54510(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54498, 54510);
                    return return_v;
                }


                int
                f_1507_54552_54588(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54552, 54588);
                    return 0;
                }


                int
                f_1507_54607_54645(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                type)
                {
                    this_param.PushLabelBlock(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54607, 54645);
                    return 0;
                }


                int
                f_1507_54666_54705(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54666, 54705);
                    return 0;
                }


                int
                f_1507_54724_54770(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                finallyStartLabel)
                {
                    this_param.EmitEnterFinally(finallyStartLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54724, 54770);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_54803_54815(System.Linq.Expressions.TryExpression
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54803, 54815);
                    return return_v;
                }


                int
                f_1507_54789_54816(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoid(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54789, 54816);
                    return 0;
                }


                int
                f_1507_54835_54867(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitLeaveFinally();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54835, 54867);
                    return 0;
                }


                int
                f_1507_54983_55002(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 54983, 55002);
                    return return_v;
                }


                int
                f_1507_55029_55055(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55029, 55055);
                    return return_v;
                }


                int
                f_1507_55057_55076(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55057, 55076);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ExceptionHandler[]
                f_1507_55124_55144(System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55124, 55144);
                    return return_v;
                }


                System.Management.Automation.Interpreter.TryCatchFinallyHandler
                f_1507_54938_55152(int
                tryStart, int
                tryEnd, int
                gotoEndLabelIndex, int
                finallyStart, int
                finallyEnd, System.Management.Automation.Interpreter.ExceptionHandler[]
                handlers)
                {
                    var return_v = new System.Management.Automation.Interpreter.TryCatchFinallyHandler(tryStart, tryEnd, gotoEndLabelIndex, finallyStart, finallyEnd, handlers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54938, 55152);
                    return return_v;
                }


                int
                f_1507_54888_55153(System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                this_param, System.Management.Automation.Interpreter.TryCatchFinallyHandler
                tryHandler)
                {
                    this_param.SetTryHandler(tryHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 54888, 55153);
                    return 0;
                }


                int
                f_1507_55172_55209(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55172, 55209);
                    return 0;
                }


                int
                f_1507_55276_55308(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55276, 55308);
                    return 0;
                }


                int
                f_1507_55422_55441(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55422, 55441);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ExceptionHandler[]
                f_1507_55443_55463(System.Collections.Generic.List<System.Management.Automation.Interpreter.ExceptionHandler>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55443, 55463);
                    return return_v;
                }


                System.Management.Automation.Interpreter.TryCatchFinallyHandler
                f_1507_55377_55464(int
                tryStart, int
                tryEnd, int
                gotoEndTargetIndex, System.Management.Automation.Interpreter.ExceptionHandler[]
                handlers)
                {
                    var return_v = new System.Management.Automation.Interpreter.TryCatchFinallyHandler(tryStart, tryEnd, gotoEndTargetIndex, handlers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55377, 55464);
                    return return_v;
                }


                int
                f_1507_55327_55465(System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                this_param, System.Management.Automation.Interpreter.TryCatchFinallyHandler
                tryHandler)
                {
                    this_param.SetTryHandler(tryHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55327, 55465);
                    return 0;
                }


                int
                f_1507_55497_55525(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55497, 55525);
                    return 0;
                }


                int
                f_1507_55542_55575(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55542, 55575);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 49099, 55587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 49099, 55587);
            }
        }

        private void CompileDynamicExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 55599, 55983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55678, 55713);

                var
                node = (DynamicExpression)expr
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55738, 55747);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55729, 55898) || true) && (index < f_1507_55757_55777(f_1507_55757_55771(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55779, 55786)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 55729, 55898))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 55729, 55898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55820, 55852);

                        var
                        arg = f_1507_55830_55851(f_1507_55830_55844(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55870, 55883);

                        f_1507_55870_55882(this, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 55914, 55972);

                f_1507_55914_55971(
                            _instructions, f_1507_55940_55957(node), f_1507_55959_55970(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 55599, 55983);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_55757_55771(System.Linq.Expressions.DynamicExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55757, 55771);
                    return return_v;
                }


                int
                f_1507_55757_55777(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55757, 55777);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_55830_55844(System.Linq.Expressions.DynamicExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55830, 55844);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_55830_55851(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55830, 55851);
                    return return_v;
                }


                int
                f_1507_55870_55882(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55870, 55882);
                    return 0;
                }


                System.Type
                f_1507_55940_55957(System.Linq.Expressions.DynamicExpression
                this_param)
                {
                    var return_v = this_param.DelegateType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55940, 55957);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSiteBinder
                f_1507_55959_55970(System.Linq.Expressions.DynamicExpression
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 55959, 55970);
                    return return_v;
                }


                int
                f_1507_55914_55971(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type, System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    this_param.EmitDynamic(type, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 55914, 55971);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 55599, 55983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 55599, 55983);
            }
        }

        private void CompileMethodCallExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 55995, 57204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56077, 56115);

                var
                node = (MethodCallExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56131, 56176);

                var
                parameters = f_1507_56148_56175(f_1507_56148_56159(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56543, 56589);

                var
                declaringType = f_1507_56563_56588(f_1507_56563_56574(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56603, 56833) || true) && (!f_1507_56608_56660(parameters, p => !p.ParameterType.IsByRef) || (DynAbs.Tracing.TraceSender.Expression_False(1507, 56607, 56763) || (f_1507_56682_56703_M(!f_1507_56683_56694(node).IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 56682, 56732) && f_1507_56707_56732(declaringType)) && (DynAbs.Tracing.TraceSender.Expression_True(1507, 56682, 56762) && f_1507_56736_56762_M(!declaringType.IsPrimitive)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 56603, 56833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56797, 56818);

                    _forceCompile = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 56603, 56833);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56849, 56944) || true) && (f_1507_56853_56874_M(!f_1507_56854_56865(node).IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 56849, 56944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56908, 56929);

                    f_1507_56908_56928(this, f_1507_56916_56927(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 56849, 56944);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56969, 56978);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 56960, 57129) || true) && (index < f_1507_56988_57008(f_1507_56988_57002(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57010, 57017)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 56960, 57129))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 56960, 57129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57051, 57083);

                        var
                        arg = f_1507_57061_57082(f_1507_57061_57075(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57101, 57114);

                        f_1507_57101_57113(this, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57145, 57193);

                f_1507_57145_57192(
                            _instructions, f_1507_57168_57179(node), parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 55995, 57204);

                System.Reflection.MethodInfo
                f_1507_56148_56159(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56148, 56159);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1507_56148_56175(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 56148, 56175);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_56563_56574(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56563, 56574);
                    return return_v;
                }


                System.Type
                f_1507_56563_56588(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56563, 56588);
                    return return_v;
                }


                bool
                f_1507_56608_56660(System.Reflection.ParameterInfo[]
                collection, System.Predicate<System.Reflection.ParameterInfo>
                predicate)
                {
                    var return_v = collection.TrueForAll<System.Reflection.ParameterInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 56608, 56660);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_56683_56694(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56683, 56694);
                    return return_v;
                }


                bool
                f_1507_56682_56703_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56682, 56703);
                    return return_v;
                }


                bool
                f_1507_56707_56732(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56707, 56732);
                    return return_v;
                }


                bool
                f_1507_56736_56762_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56736, 56762);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1507_56854_56865(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56854, 56865);
                    return return_v;
                }


                bool
                f_1507_56853_56874_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56853, 56874);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_56916_56927(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Object;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56916, 56927);
                    return return_v;
                }


                int
                f_1507_56908_56928(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 56908, 56928);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_56988_57002(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56988, 57002);
                    return return_v;
                }


                int
                f_1507_56988_57008(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 56988, 57008);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_57061_57075(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57061, 57075);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_57061_57082(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57061, 57082);
                    return return_v;
                }


                int
                f_1507_57101_57113(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57101, 57113);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1507_57168_57179(System.Linq.Expressions.MethodCallExpression
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57168, 57179);
                    return return_v;
                }


                int
                f_1507_57145_57192(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method, System.Reflection.ParameterInfo[]
                parameters)
                {
                    this_param.EmitCall(method, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57145, 57192);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 55995, 57204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 55995, 57204);
            }
        }

        private void CompileNewExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 57216, 58138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57291, 57322);

                var
                node = (NewExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57338, 57622) || true) && (f_1507_57342_57358(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 57338, 57622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57400, 57450);

                    var
                    parameters = f_1507_57417_57449(f_1507_57417_57433(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57468, 57607) || true) && (!f_1507_57473_57525(parameters, p => !p.ParameterType.IsByRef))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 57468, 57607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57567, 57588);

                        _forceCompile = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 57468, 57607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 57338, 57622);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57638, 58127) || true) && (f_1507_57642_57658(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 57638, 58127);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57709, 57718);
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57700, 57890) || true) && (index < f_1507_57728_57748(f_1507_57728_57742(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57750, 57757)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 57700, 57890))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 57700, 57890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57799, 57831);

                            var
                            arg = f_1507_57809_57830(f_1507_57809_57823(node), index)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57853, 57871);

                            f_1507_57853_57870(this, arg);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 57910, 57950);

                    f_1507_57910_57949(
                                    _instructions, f_1507_57932_57948(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 57638, 58127);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 57638, 58127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58016, 58052);

                    f_1507_58016_58051(f_1507_58029_58050(f_1507_58029_58038(expr)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58070, 58112);

                    f_1507_58070_58111(_instructions, f_1507_58101_58110(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 57638, 58127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 57216, 58138);

                System.Reflection.ConstructorInfo
                f_1507_57342_57358(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57342, 57358);
                    return return_v;
                }


                System.Reflection.ConstructorInfo
                f_1507_57417_57433(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57417, 57433);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1507_57417_57449(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57417, 57449);
                    return return_v;
                }


                bool
                f_1507_57473_57525(System.Reflection.ParameterInfo[]
                collection, System.Predicate<System.Reflection.ParameterInfo>
                predicate)
                {
                    var return_v = collection.TrueForAll<System.Reflection.ParameterInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57473, 57525);
                    return return_v;
                }


                System.Reflection.ConstructorInfo
                f_1507_57642_57658(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57642, 57658);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_57728_57742(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57728, 57742);
                    return return_v;
                }


                int
                f_1507_57728_57748(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57728, 57748);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_57809_57823(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57809, 57823);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_57809_57830(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57809, 57830);
                    return return_v;
                }


                int
                f_1507_57853_57870(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57853, 57870);
                    return 0;
                }


                System.Reflection.ConstructorInfo
                f_1507_57932_57948(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 57932, 57948);
                    return return_v;
                }


                int
                f_1507_57910_57949(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.ConstructorInfo
                constructorInfo)
                {
                    this_param.EmitNew(constructorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 57910, 57949);
                    return 0;
                }


                System.Type
                f_1507_58029_58038(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58029, 58038);
                    return return_v;
                }


                bool
                f_1507_58029_58050(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58029, 58050);
                    return return_v;
                }


                int
                f_1507_58016_58051(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58016, 58051);
                    return 0;
                }


                System.Type
                f_1507_58101_58110(System.Linq.Expressions.NewExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58101, 58110);
                    return return_v;
                }


                int
                f_1507_58070_58111(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitDefaultValue(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58070, 58111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 57216, 58138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 57216, 58138);
            }
        }

        private void CompileMemberExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 58150, 59562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58228, 58262);

                var
                node = (MemberExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58278, 58303);

                var
                member = f_1507_58291_58302(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58317, 58352);

                FieldInfo
                fi = member as FieldInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58366, 59125) || true) && (fi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58366, 59125);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58414, 59083) || true) && (f_1507_58418_58430(fi))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58414, 59083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58472, 58528);

                        f_1507_58472_58527(_instructions, f_1507_58495_58512(fi, null), f_1507_58514_58526(fi));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58414, 59083);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58414, 59083);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58570, 59083) || true) && (f_1507_58574_58585(fi))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58570, 59083);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58627, 58903) || true) && (f_1507_58631_58644(fi))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58627, 58903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58694, 58750);

                                f_1507_58694_58749(_instructions, f_1507_58717_58734(fi, null), f_1507_58736_58748(fi));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58627, 58903);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58627, 58903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58848, 58880);

                                f_1507_58848_58879(_instructions, fi);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58627, 58903);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58570, 59083);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 58570, 59083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 58985, 59010);

                            f_1507_58985_59009(this, f_1507_58993_59008(node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59032, 59064);

                            f_1507_59032_59063(_instructions, fi);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58570, 59083);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58414, 59083);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59103, 59110);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 58366, 59125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59141, 59182);

                PropertyInfo
                pi = member as PropertyInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59196, 59492) || true) && (pi != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 59196, 59492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59244, 59270);

                    var
                    method = f_1507_59257_59269(pi)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59288, 59401) || true) && (f_1507_59292_59307(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 59288, 59401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59357, 59382);

                        f_1507_59357_59381(this, f_1507_59365_59380(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 59288, 59401);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59421, 59452);

                    f_1507_59421_59451(
                                    _instructions, method);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59470, 59477);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 59196, 59492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59508, 59551);

                throw f_1507_59514_59550();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 58150, 59562);

                System.Reflection.MemberInfo
                f_1507_58291_58302(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58291, 58302);
                    return return_v;
                }


                bool
                f_1507_58418_58430(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.IsLiteral;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58418, 58430);
                    return return_v;
                }


                object?
                f_1507_58495_58512(System.Reflection.FieldInfo
                this_param, object?
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58495, 58512);
                    return return_v;
                }


                System.Type
                f_1507_58514_58526(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.FieldType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58514, 58526);
                    return return_v;
                }


                int
                f_1507_58472_58527(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value, System.Type
                type)
                {
                    this_param.EmitLoad(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58472, 58527);
                    return 0;
                }


                bool
                f_1507_58574_58585(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58574, 58585);
                    return return_v;
                }


                bool
                f_1507_58631_58644(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58631, 58644);
                    return return_v;
                }


                object?
                f_1507_58717_58734(System.Reflection.FieldInfo
                this_param, object?
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58717, 58734);
                    return return_v;
                }


                System.Type
                f_1507_58736_58748(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.FieldType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58736, 58748);
                    return return_v;
                }


                int
                f_1507_58694_58749(System.Management.Automation.Interpreter.InstructionList
                this_param, object
                value, System.Type
                type)
                {
                    this_param.EmitLoad(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58694, 58749);
                    return 0;
                }


                int
                f_1507_58848_58879(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.FieldInfo
                field)
                {
                    this_param.EmitLoadField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58848, 58879);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_58993_59008(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 58993, 59008);
                    return return_v;
                }


                int
                f_1507_58985_59009(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 58985, 59009);
                    return 0;
                }


                int
                f_1507_59032_59063(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.FieldInfo
                field)
                {
                    this_param.EmitLoadField(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59032, 59063);
                    return 0;
                }


                System.Reflection.MethodInfo
                f_1507_59257_59269(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59257, 59269);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_59292_59307(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59292, 59307);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_59365_59380(System.Linq.Expressions.MemberExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59365, 59380);
                    return return_v;
                }


                int
                f_1507_59357_59381(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59357, 59381);
                    return 0;
                }


                int
                f_1507_59421_59451(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Reflection.MethodInfo
                method)
                {
                    this_param.EmitCall(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59421, 59451);
                    return 0;
                }


                System.NotImplementedException
                f_1507_59514_59550()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59514, 59550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 58150, 59562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 58150, 59562);
            }
        }

        private void CompileNewArrayExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 59574, 60638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59654, 59690);

                var
                node = (NewArrayExpression)expr
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59715, 59724);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59706, 59879) || true) && (index < f_1507_59734_59756(f_1507_59734_59750(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59758, 59765)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 59706, 59879))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 59706, 59879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59799, 59833);

                        var
                        arg = f_1507_59809_59832(f_1507_59809_59825(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59851, 59864);

                        f_1507_59851_59863(this, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59895, 59941);

                Type
                elementType = f_1507_59914_59940(f_1507_59914_59923(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 59955, 59989);

                int
                rank = f_1507_59966_59988(f_1507_59966_59982(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60005, 60627) || true) && (f_1507_60009_60022(node) == ExpressionType.NewArrayInit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60005, 60627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60087, 60137);

                    f_1507_60087_60136(_instructions, elementType, rank);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60005, 60627);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60005, 60627);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60171, 60627) || true) && (f_1507_60175_60188(node) == ExpressionType.NewArrayBounds)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60171, 60627);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60255, 60503) || true) && (rank == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60255, 60503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60310, 60350);

                            f_1507_60310_60349(_instructions, elementType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60255, 60503);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60255, 60503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60432, 60484);

                            f_1507_60432_60483(_instructions, elementType, rank);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60255, 60503);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60171, 60627);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60171, 60627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60569, 60612);

                        throw f_1507_60575_60611();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60171, 60627);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60005, 60627);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 59574, 60638);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_59734_59750(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59734, 59750);
                    return return_v;
                }


                int
                f_1507_59734_59756(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59734, 59756);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_59809_59825(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59809, 59825);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_59809_59832(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59809, 59832);
                    return return_v;
                }


                int
                f_1507_59851_59863(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59851, 59863);
                    return 0;
                }


                System.Type
                f_1507_59914_59923(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59914, 59923);
                    return return_v;
                }


                System.Type?
                f_1507_59914_59940(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 59914, 59940);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_59966_59982(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59966, 59982);
                    return return_v;
                }


                int
                f_1507_59966_59988(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 59966, 59988);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_60009_60022(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 60009, 60022);
                    return return_v;
                }


                int
                f_1507_60087_60136(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                elementType, int
                elementCount)
                {
                    this_param.EmitNewArrayInit(elementType, elementCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 60087, 60136);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_60175_60188(System.Linq.Expressions.NewArrayExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 60175, 60188);
                    return return_v;
                }


                int
                f_1507_60310_60349(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                elementType)
                {
                    this_param.EmitNewArray(elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 60310, 60349);
                    return 0;
                }


                int
                f_1507_60432_60483(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                elementType, int
                rank)
                {
                    this_param.EmitNewArrayBounds(elementType, rank);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 60432, 60483);
                    return 0;
                }


                System.NotImplementedException
                f_1507_60575_60611()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 60575, 60611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 59574, 60638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 59574, 60638);
            }
        }

        private void CompileExtensionExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 60650, 61173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60731, 60786);

                var
                instructionProvider = expr as IInstructionProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60800, 60947) || true) && (instructionProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60800, 60947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60865, 60907);

                    f_1507_60865_60906(instructionProvider, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60925, 60932);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60800, 60947);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 60963, 61162) || true) && (f_1507_60967_60981(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60963, 61162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61015, 61038);

                    f_1507_61015_61037(this, f_1507_61023_61036(expr));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60963, 61162);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 60963, 61162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61104, 61147);

                    throw f_1507_61110_61146();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 60963, 61162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 60650, 61173);

                int
                f_1507_60865_60906(System.Management.Automation.Interpreter.IInstructionProvider
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    this_param.AddInstructions(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 60865, 60906);
                    return 0;
                }


                bool
                f_1507_60967_60981(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.CanReduce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 60967, 60981);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_61023_61036(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Reduce();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 61023, 61036);
                    return return_v;
                }


                int
                f_1507_61015_61037(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 61015, 61037);
                    return 0;
                }


                System.NotImplementedException
                f_1507_61110_61146()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 61110, 61146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 60650, 61173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 60650, 61173);
            }
        }

        private void CompileDebugInfoExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 61185, 61677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61266, 61303);

                var
                node = (DebugInfoExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61317, 61349);

                int
                start = f_1507_61329_61348(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61363, 61630);

                var
                info = new DebugInfo()
                {
                    Index = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => start, 1507, 61374, 61629),
                    FileName = f_1507_61465_61487(f_1507_61465_61478(node)),
                    StartLine = f_1507_61518_61532(node),
                    EndLine = f_1507_61561_61573(node),
                    IsClear = f_1507_61602_61614(node)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61644, 61666);

                f_1507_61644_61665(_debugInfos, info);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 61185, 61677);

                int
                f_1507_61329_61348(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61329, 61348);
                    return return_v;
                }


                System.Linq.Expressions.SymbolDocumentInfo
                f_1507_61465_61478(System.Linq.Expressions.DebugInfoExpression
                this_param)
                {
                    var return_v = this_param.Document;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61465, 61478);
                    return return_v;
                }


                string
                f_1507_61465_61487(System.Linq.Expressions.SymbolDocumentInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61465, 61487);
                    return return_v;
                }


                int
                f_1507_61518_61532(System.Linq.Expressions.DebugInfoExpression
                this_param)
                {
                    var return_v = this_param.StartLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61518, 61532);
                    return return_v;
                }


                int
                f_1507_61561_61573(System.Linq.Expressions.DebugInfoExpression
                this_param)
                {
                    var return_v = this_param.EndLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61561, 61573);
                    return return_v;
                }


                bool
                f_1507_61602_61614(System.Linq.Expressions.DebugInfoExpression
                this_param)
                {
                    var return_v = this_param.IsClear
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61602, 61614);
                    return return_v;
                }


                int
                f_1507_61644_61665(System.Collections.Generic.List<System.Management.Automation.Interpreter.DebugInfo>
                this_param, System.Management.Automation.Interpreter.DebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 61644, 61665);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 61185, 61677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 61185, 61677);
            }
        }

        private void CompileRuntimeVariablesExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 61689, 62243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61849, 61893);

                var
                node = (RuntimeVariablesExpression)expr
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61916, 61925);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61907, 62156) || true) && (index < f_1507_61935_61955(f_1507_61935_61949(node)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61957, 61964)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 61907, 62156))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 61907, 62156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 61998, 62035);

                        var
                        variable = f_1507_62013_62034(f_1507_62013_62027(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62053, 62089);

                        f_1507_62053_62088(this, variable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62107, 62141);

                        f_1507_62107_62140(this, variable);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62172, 62232);

                f_1507_62172_62231(
                            _instructions, f_1507_62210_62230(f_1507_62210_62224(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 61689, 62243);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_61935_61949(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61935, 61949);
                    return return_v;
                }


                int
                f_1507_61935_61955(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 61935, 61955);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_62013_62027(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62013, 62027);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1507_62013_62034(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62013, 62034);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1507_62053_62088(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                expr)
                {
                    var return_v = this_param.EnsureAvailableForClosure(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62053, 62088);
                    return return_v;
                }


                int
                f_1507_62107_62140(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    this_param.CompileGetBoxedVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62107, 62140);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1507_62210_62224(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62210, 62224);
                    return return_v;
                }


                int
                f_1507_62210_62230(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62210, 62230);
                    return return_v;
                }


                int
                f_1507_62172_62231(System.Management.Automation.Interpreter.InstructionList
                this_param, int
                count)
                {
                    this_param.EmitNewRuntimeVariables(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62172, 62231);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 61689, 62243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 61689, 62243);
            }
        }

        private void CompileLambdaExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 62255, 62827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62333, 62367);

                var
                node = (LambdaExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62381, 62420);

                var
                compiler = f_1507_62396_62419(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62434, 62474);

                var
                creator = f_1507_62448_62473(compiler, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62490, 62758) || true) && (f_1507_62494_62527(compiler._locals) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 62490, 62758);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62569, 62743);
                        foreach (ParameterExpression variable in f_1507_62610_62648_I(f_1507_62610_62648(f_1507_62610_62643(compiler._locals))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 62569, 62743);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62690, 62724);

                            f_1507_62690_62723(this, variable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 62569, 62743);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1507, 1, 175);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1507, 1, 175);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 62490, 62758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62774, 62816);

                f_1507_62774_62815(
                            _instructions, creator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 62255, 62827);

                System.Management.Automation.Interpreter.LightCompiler
                f_1507_62396_62419(System.Management.Automation.Interpreter.LightCompiler
                parent)
                {
                    var return_v = new System.Management.Automation.Interpreter.LightCompiler(parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62396, 62419);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LightDelegateCreator
                f_1507_62448_62473(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.LambdaExpression
                node)
                {
                    var return_v = this_param.CompileTop(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62448, 62473);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                f_1507_62494_62527(System.Management.Automation.Interpreter.LocalVariables
                this_param)
                {
                    var return_v = this_param.ClosureVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62494, 62527);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                f_1507_62610_62643(System.Management.Automation.Interpreter.LocalVariables
                this_param)
                {
                    var return_v = this_param.ClosureVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62610, 62643);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>.KeyCollection
                f_1507_62610_62648(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 62610, 62648);
                    return return_v;
                }


                int
                f_1507_62690_62723(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    this_param.CompileGetBoxedVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62690, 62723);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>.KeyCollection
                f_1507_62610_62648_I(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62610, 62648);
                    return return_v;
                }


                int
                f_1507_62774_62815(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.LightDelegateCreator
                creator)
                {
                    this_param.EmitCreateDelegate(creator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62774, 62815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 62255, 62827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 62255, 62827);
            }
        }

        private void CompileCoalesceBinaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 62839, 63594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62925, 62959);

                var
                node = (BinaryExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 62975, 63583) || true) && (f_1507_62979_63019(f_1507_63004_63018(f_1507_63004_63013(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 62975, 63583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63053, 63089);

                    throw f_1507_63059_63088();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 62975, 63583);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 62975, 63583);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63123, 63583) || true) && (f_1507_63127_63142(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 63123, 63583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63184, 63220);

                        throw f_1507_63190_63219();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 63123, 63583);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 63123, 63583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63286, 63330);

                        var
                        leftNotNull = f_1507_63304_63329(_instructions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63348, 63367);

                        f_1507_63348_63366(this, f_1507_63356_63365(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63385, 63433);

                        f_1507_63385_63432(_instructions, leftNotNull);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63451, 63475);

                        f_1507_63451_63474(_instructions);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63493, 63513);

                        f_1507_63493_63512(this, f_1507_63501_63511(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63531, 63568);

                        f_1507_63531_63567(_instructions, leftNotNull);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 63123, 63583);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 62975, 63583);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 62839, 63594);

                System.Linq.Expressions.Expression
                f_1507_63004_63013(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63004, 63013);
                    return return_v;
                }


                System.Type
                f_1507_63004_63018(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63004, 63018);
                    return return_v;
                }


                bool
                f_1507_62979_63019(System.Type
                type)
                {
                    var return_v = TypeUtils.IsNullableType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 62979, 63019);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_63059_63088()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63059, 63088);
                    return return_v;
                }


                System.Linq.Expressions.LambdaExpression
                f_1507_63127_63142(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63127, 63142);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_63190_63219()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63190, 63219);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1507_63304_63329(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63304, 63329);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_63356_63365(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63356, 63365);
                    return return_v;
                }


                int
                f_1507_63348_63366(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63348, 63366);
                    return 0;
                }


                int
                f_1507_63385_63432(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                leftNotNull)
                {
                    this_param.EmitCoalescingBranch(leftNotNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63385, 63432);
                    return 0;
                }


                int
                f_1507_63451_63474(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitPop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63451, 63474);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_63501_63511(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63501, 63511);
                    return return_v;
                }


                int
                f_1507_63493_63512(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63493, 63512);
                    return 0;
                }


                int
                f_1507_63531_63567(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Management.Automation.Interpreter.BranchLabel
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63531, 63567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 62839, 63594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 62839, 63594);
            }
        }

        private void CompileInvocationExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 63606, 64833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63688, 63726);

                var
                node = (InvocationExpression)expr
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63806, 63965) || true) && (f_1507_63810_63873(typeof(LambdaExpression), f_1507_63852_63872(f_1507_63852_63867(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 63806, 63965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 63907, 63950);

                    throw f_1507_63913_63949();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 63806, 63965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 64684, 64804);

                f_1507_64684_64803(this, f_1507_64712_64802(f_1507_64728_64743(node), f_1507_64745_64785(f_1507_64745_64765(f_1507_64745_64760(node)), "Invoke"), f_1507_64787_64801(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 63606, 64833);

                System.Linq.Expressions.Expression
                f_1507_63852_63867(System.Linq.Expressions.InvocationExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63852, 63867);
                    return return_v;
                }


                System.Type
                f_1507_63852_63872(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 63852, 63872);
                    return return_v;
                }


                bool
                f_1507_63810_63873(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63810, 63873);
                    return return_v;
                }


                System.NotImplementedException
                f_1507_63913_63949()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 63913, 63949);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_64728_64743(System.Linq.Expressions.InvocationExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 64728, 64743);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1507_64745_64760(System.Linq.Expressions.InvocationExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 64745, 64760);
                    return return_v;
                }


                System.Type
                f_1507_64745_64765(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 64745, 64765);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1507_64745_64785(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 64745, 64785);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1507_64787_64801(System.Linq.Expressions.InvocationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 64787, 64801);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1507_64712_64802(System.Linq.Expressions.Expression
                instance, System.Reflection.MethodInfo
                method, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                arguments)
                {
                    var return_v = Expression.Call(instance, method, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 64712, 64802);
                    return return_v;
                }


                int
                f_1507_64684_64803(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.MethodCallExpression
                expr)
                {
                    this_param.CompileMethodCallExpression((System.Linq.Expressions.Expression)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 64684, 64803);
                    return 0;
                }

                // }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 63606, 64833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 63606, 64833);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "expr")]
        private void CompileListInitExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 64845, 65110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65056, 65099);

                throw f_1507_65062_65098();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 64845, 65110);

                System.NotImplementedException
                f_1507_65062_65098()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 65062, 65098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 64845, 65110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 64845, 65110);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "expr")]
        private void CompileMemberInitExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 65122, 65389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65335, 65378);

                throw f_1507_65341_65377();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 65122, 65389);

                System.NotImplementedException
                f_1507_65341_65377()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 65341, 65377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 65122, 65389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 65122, 65389);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "expr")]
        private void CompileQuoteUnaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 65401, 65668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65614, 65657);

                throw f_1507_65620_65656();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 65401, 65668);

                System.NotImplementedException
                f_1507_65620_65656()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 65620, 65656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 65401, 65668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 65401, 65668);
            }
        }

        private void CompileUnboxUnaryExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 65680, 65877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65762, 65795);

                var
                node = (UnaryExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65844, 65866);

                f_1507_65844_65865(this, f_1507_65852_65864(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 65680, 65877);

                System.Linq.Expressions.Expression
                f_1507_65852_65864(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 65852, 65864);
                    return return_v;
                }


                int
                f_1507_65844_65865(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 65844, 65865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 65680, 65877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 65680, 65877);
            }
        }

        private void CompileTypeEqualExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 65889, 66230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 65970, 66026);

                f_1507_65970_66025(f_1507_65983_65996(expr) == ExpressionType.TypeEqual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66040, 66078);

                var
                node = (TypeBinaryExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66094, 66119);

                f_1507_66094_66118(this, f_1507_66102_66117(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66133, 66174);

                f_1507_66133_66173(_instructions, f_1507_66156_66172(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66188, 66219);

                f_1507_66188_66218(_instructions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 65889, 66230);

                System.Linq.Expressions.ExpressionType
                f_1507_65983_65996(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 65983, 65996);
                    return return_v;
                }


                int
                f_1507_65970_66025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 65970, 66025);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_66102_66117(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66102, 66117);
                    return return_v;
                }


                int
                f_1507_66094_66118(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66094, 66118);
                    return 0;
                }


                System.Type
                f_1507_66156_66172(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66156, 66172);
                    return return_v;
                }


                int
                f_1507_66133_66173(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                value)
                {
                    this_param.EmitLoad((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66133, 66173);
                    return 0;
                }


                int
                f_1507_66188_66218(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitTypeEquals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66188, 66218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 65889, 66230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 65889, 66230);
            }
        }

        private void CompileTypeAsExpression(UnaryExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 66242, 66408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66325, 66347);

                f_1507_66325_66346(this, f_1507_66333_66345(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66361, 66397);

                f_1507_66361_66396(_instructions, f_1507_66386_66395(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 66242, 66408);

                System.Linq.Expressions.Expression
                f_1507_66333_66345(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66333, 66345);
                    return return_v;
                }


                int
                f_1507_66325_66346(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66325, 66346);
                    return 0;
                }


                System.Type
                f_1507_66386_66395(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66386, 66395);
                    return return_v;
                }


                int
                f_1507_66361_66396(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitTypeAs(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66361, 66396);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 66242, 66408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 66242, 66408);
            }
        }

        private void CompileTypeIsExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 66420, 66996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66498, 66551);

                f_1507_66498_66550(f_1507_66511_66524(expr) == ExpressionType.TypeIs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66565, 66603);

                var
                node = (TypeBinaryExpression)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66619, 66644);

                f_1507_66619_66643(this, f_1507_66627_66642(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66708, 66985) || true) && (f_1507_66712_66737(f_1507_66712_66728(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 66708, 66985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66771, 66812);

                    f_1507_66771_66811(_instructions, f_1507_66794_66810(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66830, 66861);

                    f_1507_66830_66860(_instructions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 66708, 66985);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 66708, 66985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 66927, 66970);

                    f_1507_66927_66969(_instructions, f_1507_66952_66968(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 66708, 66985);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 66420, 66996);

                System.Linq.Expressions.ExpressionType
                f_1507_66511_66524(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66511, 66524);
                    return return_v;
                }


                int
                f_1507_66498_66550(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66498, 66550);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1507_66627_66642(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66627, 66642);
                    return return_v;
                }


                int
                f_1507_66619_66643(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66619, 66643);
                    return 0;
                }


                System.Type
                f_1507_66712_66728(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66712, 66728);
                    return return_v;
                }


                bool
                f_1507_66712_66737(System.Type
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66712, 66737);
                    return return_v;
                }


                System.Type
                f_1507_66794_66810(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66794, 66810);
                    return return_v;
                }


                int
                f_1507_66771_66811(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                value)
                {
                    this_param.EmitLoad((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66771, 66811);
                    return 0;
                }


                int
                f_1507_66830_66860(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitTypeEquals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66830, 66860);
                    return 0;
                }


                System.Type
                f_1507_66952_66968(System.Linq.Expressions.TypeBinaryExpression
                this_param)
                {
                    var return_v = this_param.TypeOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 66952, 66968);
                    return return_v;
                }


                int
                f_1507_66927_66969(System.Management.Automation.Interpreter.InstructionList
                this_param, System.Type
                type)
                {
                    this_param.EmitTypeIs(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 66927, 66969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 66420, 66996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 66420, 66996);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "expr")]
        private void CompileReducibleExpression(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 67008, 67274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67220, 67263);

                throw f_1507_67226_67262();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 67008, 67274);

                System.NotImplementedException
                f_1507_67226_67262()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67226, 67262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 67008, 67274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 67008, 67274);
            }
        }

        internal void Compile(Expression expr, bool asVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 67286, 67532);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67362, 67521) || true) && (asVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67362, 67521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67406, 67426);

                    f_1507_67406_67425(this, expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67362, 67521);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67362, 67521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67492, 67506);

                    f_1507_67492_67505(this, expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67362, 67521);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 67286, 67532);

                int
                f_1507_67406_67425(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAsVoid(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67406, 67425);
                    return 0;
                }


                int
                f_1507_67492_67505(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.Compile(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67492, 67505);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 67286, 67532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 67286, 67532);
            }
        }

        internal void CompileAsVoid(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 67544, 68862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67613, 67659);

                bool
                pushLabelBlock = f_1507_67635_67658(this, expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67673, 67730);

                int
                startingStackDepth = f_1507_67698_67729(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67744, 68654);

                switch (f_1507_67752_67765(expr))
                {

                    case ExpressionType.Assign:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67744, 68654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67848, 67890);

                        f_1507_67848_67889(this, expr, true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 67912, 67918);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67744, 68654);

                    case ExpressionType.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67744, 68654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 67986, 68021);

                        f_1507_67986_68020(this, expr, true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 68043, 68049);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67744, 68654);

                    case ExpressionType.Throw:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67744, 68654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68117, 68157);

                        f_1507_68117_68156(this, expr, true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 68179, 68185);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67744, 68654);

                    case ExpressionType.Constant:
                    case ExpressionType.Default:
                    case ExpressionType.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67744, 68654);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 68380, 68386);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67744, 68654);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 67744, 68654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68436, 68461);

                        f_1507_68436_68460(this, expr);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68483, 68609) || true) && (f_1507_68487_68496(expr) != typeof(void))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 68483, 68609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68562, 68586);

                            f_1507_68562_68585(_instructions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 68483, 68609);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 68633, 68639);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 67744, 68654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68670, 68738);

                f_1507_68670_68737(f_1507_68683_68714(_instructions) == startingStackDepth);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68752, 68851) || true) && (pushLabelBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 68752, 68851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 68804, 68836);

                    f_1507_68804_68835(this, _labelBlock.Kind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 68752, 68851);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 67544, 68862);

                bool
                f_1507_67635_67658(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.TryPushLabelBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67635, 67658);
                    return return_v;
                }


                int
                f_1507_67698_67729(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 67698, 67729);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_67752_67765(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 67752, 67765);
                    return return_v;
                }


                int
                f_1507_67848_67889(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileAssignBinaryExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67848, 67889);
                    return 0;
                }


                int
                f_1507_67986_68020(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileBlockExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 67986, 68020);
                    return 0;
                }


                int
                f_1507_68117_68156(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileThrowUnaryExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 68117, 68156);
                    return 0;
                }


                int
                f_1507_68436_68460(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileNoLabelPush(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 68436, 68460);
                    return 0;
                }


                System.Type
                f_1507_68487_68496(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 68487, 68496);
                    return return_v;
                }


                int
                f_1507_68562_68585(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    this_param.EmitPop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 68562, 68585);
                    return 0;
                }


                int
                f_1507_68683_68714(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 68683, 68714);
                    return return_v;
                }


                int
                f_1507_68670_68737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 68670, 68737);
                    return 0;
                }


                int
                f_1507_68804_68835(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 68804, 68835);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 67544, 68862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 67544, 68862);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private void CompileNoLabelPush(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 68874, 76293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69070, 69127);

                int
                startingStackDepth = f_1507_69095_69126(_instructions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69141, 76161);

                switch (f_1507_69149_69162(expr))
                {

                    case ExpressionType.Add:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69221, 69251);

                        f_1507_69221_69250(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69252, 69258);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.AddChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69308, 69338);

                        f_1507_69308_69337(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69339, 69345);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69388, 69418);

                        f_1507_69388_69417(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69419, 69425);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.AndAlso:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69472, 69509);

                        f_1507_69472_69508(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69510, 69516);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.ArrayLength:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69567, 69596);

                        f_1507_69567_69595(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69597, 69603);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.ArrayIndex:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69653, 69683);

                        f_1507_69653_69682(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69684, 69690);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69734, 69768);

                        f_1507_69734_69767(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69769, 69775);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Coalesce:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69823, 69861);

                        f_1507_69823_69860(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69862, 69868);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Conditional:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 69919, 69981);

                        f_1507_69919_69980(this, expr, f_1507_69954_69963(expr) == typeof(void));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 69982, 69988);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Constant:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70036, 70068);

                        f_1507_70036_70067(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70069, 70075);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Convert:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70122, 70158);

                        f_1507_70122_70157(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70159, 70165);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.ConvertChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70219, 70255);

                        f_1507_70219_70254(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70256, 70262);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Divide:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70308, 70338);

                        f_1507_70308_70337(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70339, 70345);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Equal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70390, 70420);

                        f_1507_70390_70419(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70421, 70427);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.ExclusiveOr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70478, 70508);

                        f_1507_70478_70507(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70509, 70515);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.GreaterThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70566, 70596);

                        f_1507_70566_70595(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70597, 70603);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70661, 70691);

                        f_1507_70661_70690(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70692, 70698);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Invoke:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70744, 70778);

                        f_1507_70744_70777(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70779, 70785);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Lambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70831, 70861);

                        f_1507_70831_70860(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70862, 70868);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.LeftShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 70917, 70947);

                        f_1507_70917_70946(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 70948, 70954);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.LessThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71002, 71032);

                        f_1507_71002_71031(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71033, 71039);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71094, 71124);

                        f_1507_71094_71123(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71125, 71131);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.ListInit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71179, 71211);

                        f_1507_71179_71210(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71212, 71218);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.MemberAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71270, 71300);

                        f_1507_71270_71299(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71301, 71307);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.MemberInit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71357, 71391);

                        f_1507_71357_71390(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71392, 71398);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Modulo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71444, 71474);

                        f_1507_71444_71473(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71475, 71481);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Multiply:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71529, 71559);

                        f_1507_71529_71558(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71560, 71566);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.MultiplyChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71621, 71651);

                        f_1507_71621_71650(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71652, 71658);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Negate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71704, 71733);

                        f_1507_71704_71732(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71734, 71740);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.UnaryPlus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71789, 71818);

                        f_1507_71789_71817(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71819, 71825);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.NegateChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71878, 71907);

                        f_1507_71878_71906(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71908, 71914);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.New:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 71957, 71984);

                        f_1507_71957_71983(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 71985, 71991);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.NewArrayInit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72043, 72075);

                        f_1507_72043_72074(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72076, 72082);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.NewArrayBounds:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72136, 72168);

                        f_1507_72136_72167(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72169, 72175);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Not:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72218, 72247);

                        f_1507_72218_72246(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72248, 72254);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72302, 72332);

                        f_1507_72302_72331(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72333, 72339);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Or:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72381, 72411);

                        f_1507_72381_72410(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72412, 72418);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.OrElse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72464, 72500);

                        f_1507_72464_72499(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72501, 72507);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72556, 72589);

                        f_1507_72556_72588(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72590, 72596);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Power:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72641, 72671);

                        f_1507_72641_72670(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72672, 72678);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Quote:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72723, 72757);

                        f_1507_72723_72756(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72758, 72764);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.RightShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72814, 72844);

                        f_1507_72814_72843(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72845, 72851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Subtract:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72899, 72929);

                        f_1507_72899_72928(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 72930, 72936);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.SubtractChecked:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 72991, 73021);

                        f_1507_72991_73020(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73022, 73028);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.TypeAs:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73074, 73103);

                        f_1507_73074_73102(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73104, 73110);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.TypeIs:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73156, 73186);

                        f_1507_73156_73185(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73187, 73193);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Assign:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73239, 73302);

                        f_1507_73239_73301(this, expr, f_1507_73275_73284(expr) == typeof(void));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73303, 73309);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73354, 73410);

                        f_1507_73354_73409(this, expr, f_1507_73383_73392(expr) == typeof(void));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73411, 73417);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.DebugInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73466, 73499);

                        f_1507_73466_73498(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73500, 73506);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Decrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73555, 73584);

                        f_1507_73555_73583(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73585, 73591);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73638, 73669);

                        f_1507_73638_73668(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73670, 73676);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73723, 73754);

                        f_1507_73723_73753(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73755, 73761);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Extension:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73810, 73843);

                        f_1507_73810_73842(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73844, 73850);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Goto:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73894, 73922);

                        f_1507_73894_73921(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 73923, 73929);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Increment:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 73978, 74007);

                        f_1507_73978_74006(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74008, 74014);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Index:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74059, 74088);

                        f_1507_74059_74087(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74089, 74095);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Label:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74140, 74169);

                        f_1507_74140_74168(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74170, 74176);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.RuntimeVariables:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74232, 74272);

                        f_1507_74232_74271(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74273, 74279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Loop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74323, 74351);

                        f_1507_74323_74350(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74352, 74358);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Switch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74404, 74434);

                        f_1507_74404_74433(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74435, 74441);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Throw:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74486, 74547);

                        f_1507_74486_74546(this, expr, f_1507_74520_74529(expr) == typeof(void));
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74548, 74554);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Try:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74597, 74624);

                        f_1507_74597_74623(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74625, 74631);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.Unbox:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74676, 74710);

                        f_1507_74676_74709(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74711, 74717);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.TypeEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74766, 74799);

                        f_1507_74766_74798(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74800, 74806);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.OnesComplement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74860, 74889);

                        f_1507_74860_74888(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74890, 74896);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.IsTrue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 74942, 74971);

                        f_1507_74942_74970(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 74972, 74978);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.IsFalse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 75025, 75054);

                        f_1507_75025_75053(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 75055, 75061);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    case ExpressionType.AddAssign:
                    case ExpressionType.AndAssign:
                    case ExpressionType.DivideAssign:
                    case ExpressionType.ExclusiveOrAssign:
                    case ExpressionType.LeftShiftAssign:
                    case ExpressionType.ModuloAssign:
                    case ExpressionType.MultiplyAssign:
                    case ExpressionType.OrAssign:
                    case ExpressionType.PowerAssign:
                    case ExpressionType.RightShiftAssign:
                    case ExpressionType.SubtractAssign:
                    case ExpressionType.AddAssignChecked:
                    case ExpressionType.MultiplyAssignChecked:
                    case ExpressionType.SubtractAssignChecked:
                    case ExpressionType.PreIncrementAssign:
                    case ExpressionType.PreDecrementAssign:
                    case ExpressionType.PostIncrementAssign:
                    case ExpressionType.PostDecrementAssign:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76054, 76087);

                        f_1507_76054_76086(this, expr);
                        DynAbs.Tracing.TraceSender.TraceBreak(1507, 76088, 76094);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 69141, 76161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76121, 76146);

                        throw f_1507_76127_76145();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 69141, 76161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76161, 76162);
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76176, 76282);

                f_1507_76176_76281(f_1507_76189_76220(_instructions) == startingStackDepth + ((DynAbs.Tracing.TraceSender.Conditional_F1(1507, 76246, 76271) || ((f_1507_76246_76255(expr) == typeof(void) && DynAbs.Tracing.TraceSender.Conditional_F2(1507, 76274, 76275)) || DynAbs.Tracing.TraceSender.Conditional_F3(1507, 76278, 76279))) ? 0 : 1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 68874, 76293);

                int
                f_1507_69095_69126(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 69095, 69126);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1507_69149_69162(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 69149, 69162);
                    return return_v;
                }


                int
                f_1507_69221_69250(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69221, 69250);
                    return 0;
                }


                int
                f_1507_69308_69337(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69308, 69337);
                    return 0;
                }


                int
                f_1507_69388_69417(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69388, 69417);
                    return 0;
                }


                int
                f_1507_69472_69508(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileAndAlsoBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69472, 69508);
                    return 0;
                }


                int
                f_1507_69567_69595(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69567, 69595);
                    return 0;
                }


                int
                f_1507_69653_69682(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69653, 69682);
                    return 0;
                }


                int
                f_1507_69734_69767(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileMethodCallExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69734, 69767);
                    return 0;
                }


                int
                f_1507_69823_69860(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileCoalesceBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69823, 69860);
                    return 0;
                }


                System.Type
                f_1507_69954_69963(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 69954, 69963);
                    return return_v;
                }


                int
                f_1507_69919_69980(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileConditionalExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 69919, 69980);
                    return 0;
                }


                int
                f_1507_70036_70067(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileConstantExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70036, 70067);
                    return 0;
                }


                int
                f_1507_70122_70157(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileConvertUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70122, 70157);
                    return 0;
                }


                int
                f_1507_70219_70254(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileConvertUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70219, 70254);
                    return 0;
                }


                int
                f_1507_70308_70337(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70308, 70337);
                    return 0;
                }


                int
                f_1507_70390_70419(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70390, 70419);
                    return 0;
                }


                int
                f_1507_70478_70507(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70478, 70507);
                    return 0;
                }


                int
                f_1507_70566_70595(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70566, 70595);
                    return 0;
                }


                int
                f_1507_70661_70690(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70661, 70690);
                    return 0;
                }


                int
                f_1507_70744_70777(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileInvocationExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70744, 70777);
                    return 0;
                }


                int
                f_1507_70831_70860(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileLambdaExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70831, 70860);
                    return 0;
                }


                int
                f_1507_70917_70946(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 70917, 70946);
                    return 0;
                }


                int
                f_1507_71002_71031(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71002, 71031);
                    return 0;
                }


                int
                f_1507_71094_71123(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71094, 71123);
                    return 0;
                }


                int
                f_1507_71179_71210(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileListInitExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71179, 71210);
                    return 0;
                }


                int
                f_1507_71270_71299(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileMemberExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71270, 71299);
                    return 0;
                }


                int
                f_1507_71357_71390(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileMemberInitExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71357, 71390);
                    return 0;
                }


                int
                f_1507_71444_71473(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71444, 71473);
                    return 0;
                }


                int
                f_1507_71529_71558(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71529, 71558);
                    return 0;
                }


                int
                f_1507_71621_71650(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71621, 71650);
                    return 0;
                }


                int
                f_1507_71704_71732(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71704, 71732);
                    return 0;
                }


                int
                f_1507_71789_71817(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71789, 71817);
                    return 0;
                }


                int
                f_1507_71878_71906(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71878, 71906);
                    return 0;
                }


                int
                f_1507_71957_71983(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileNewExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 71957, 71983);
                    return 0;
                }


                int
                f_1507_72043_72074(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileNewArrayExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72043, 72074);
                    return 0;
                }


                int
                f_1507_72136_72167(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileNewArrayExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72136, 72167);
                    return 0;
                }


                int
                f_1507_72218_72246(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72218, 72246);
                    return 0;
                }


                int
                f_1507_72302_72331(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72302, 72331);
                    return 0;
                }


                int
                f_1507_72381_72410(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72381, 72410);
                    return 0;
                }


                int
                f_1507_72464_72499(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileOrElseBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72464, 72499);
                    return 0;
                }


                int
                f_1507_72556_72588(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileParameterExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72556, 72588);
                    return 0;
                }


                int
                f_1507_72641_72670(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72641, 72670);
                    return 0;
                }


                int
                f_1507_72723_72756(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileQuoteUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72723, 72756);
                    return 0;
                }


                int
                f_1507_72814_72843(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72814, 72843);
                    return 0;
                }


                int
                f_1507_72899_72928(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72899, 72928);
                    return 0;
                }


                int
                f_1507_72991_73020(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileBinaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 72991, 73020);
                    return 0;
                }


                int
                f_1507_73074_73102(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73074, 73102);
                    return 0;
                }


                int
                f_1507_73156_73185(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileTypeIsExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73156, 73185);
                    return 0;
                }


                System.Type
                f_1507_73275_73284(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 73275, 73284);
                    return return_v;
                }


                int
                f_1507_73239_73301(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileAssignBinaryExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73239, 73301);
                    return 0;
                }


                System.Type
                f_1507_73383_73392(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 73383, 73392);
                    return return_v;
                }


                int
                f_1507_73354_73409(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileBlockExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73354, 73409);
                    return 0;
                }


                int
                f_1507_73466_73498(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileDebugInfoExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73466, 73498);
                    return 0;
                }


                int
                f_1507_73555_73583(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73555, 73583);
                    return 0;
                }


                int
                f_1507_73638_73668(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileDynamicExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73638, 73668);
                    return 0;
                }


                int
                f_1507_73723_73753(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileDefaultExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73723, 73753);
                    return 0;
                }


                int
                f_1507_73810_73842(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileExtensionExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73810, 73842);
                    return 0;
                }


                int
                f_1507_73894_73921(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileGotoExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73894, 73921);
                    return 0;
                }


                int
                f_1507_73978_74006(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 73978, 74006);
                    return 0;
                }


                int
                f_1507_74059_74087(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileIndexExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74059, 74087);
                    return 0;
                }


                int
                f_1507_74140_74168(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileLabelExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74140, 74168);
                    return 0;
                }


                int
                f_1507_74232_74271(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileRuntimeVariablesExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74232, 74271);
                    return 0;
                }


                int
                f_1507_74323_74350(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileLoopExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74323, 74350);
                    return 0;
                }


                int
                f_1507_74404_74433(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileSwitchExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74404, 74433);
                    return 0;
                }


                System.Type
                f_1507_74520_74529(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 74520, 74529);
                    return return_v;
                }


                int
                f_1507_74486_74546(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr, bool
                asVoid)
                {
                    this_param.CompileThrowUnaryExpression(expr, asVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74486, 74546);
                    return 0;
                }


                int
                f_1507_74597_74623(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileTryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74597, 74623);
                    return 0;
                }


                int
                f_1507_74676_74709(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnboxUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74676, 74709);
                    return 0;
                }


                int
                f_1507_74766_74798(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileTypeEqualExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74766, 74798);
                    return 0;
                }


                int
                f_1507_74860_74888(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74860, 74888);
                    return 0;
                }


                int
                f_1507_74942_74970(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 74942, 74970);
                    return 0;
                }


                int
                f_1507_75025_75053(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileUnaryExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 75025, 75053);
                    return 0;
                }


                int
                f_1507_76054_76086(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileReducibleExpression(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 76054, 76086);
                    return 0;
                }


                System.Exception
                f_1507_76127_76145()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 76127, 76145);
                    return return_v;
                }


                int
                f_1507_76189_76220(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.CurrentStackDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 76189, 76220);
                    return return_v;
                }


                System.Type
                f_1507_76246_76255(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1507, 76246, 76255);
                    return return_v;
                }


                int
                f_1507_76176_76281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 76176, 76281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 68874, 76293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 68874, 76293);
            }
        }

        public void Compile(Expression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1507, 76305, 76575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76366, 76412);

                bool
                pushLabelBlock = f_1507_76388_76411(this, expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76426, 76451);

                f_1507_76426_76450(this, expr);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76465, 76564) || true) && (pushLabelBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1507, 76465, 76564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 76517, 76549);

                    f_1507_76517_76548(this, _labelBlock.Kind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1507, 76465, 76564);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1507, 76305, 76575);

                bool
                f_1507_76388_76411(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.TryPushLabelBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 76388, 76411);
                    return return_v;
                }


                int
                f_1507_76426_76450(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Linq.Expressions.Expression
                expr)
                {
                    this_param.CompileNoLabelPush(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 76426, 76450);
                    return 0;
                }


                int
                f_1507_76517_76548(System.Management.Automation.Interpreter.LightCompiler
                this_param, System.Management.Automation.Interpreter.LabelScopeKind
                kind)
                {
                    this_param.PopLabelBlock(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 76517, 76548);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1507, 76305, 76575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 76305, 76575);
            }
        }

        static LightCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1507, 9585, 76582);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 9778, 9810);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1507, 10879, 10925);
            s_emptyLocals = f_1507_10895_10925();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1507, 9585, 76582);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1507, 9585, 76582);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1507, 9585, 76582);

        System.Management.Automation.Interpreter.LocalVariables
        f_1507_10012_10032()
        {
            var return_v = new System.Management.Automation.Interpreter.LocalVariables();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10012, 10032);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Interpreter.DebugInfo>
        f_1507_10092_10113()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.DebugInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10092, 10113);
            return return_v;
        }


        System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
        f_1507_10205_10260()
        {
            var return_v = new System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10205, 10260);
            return return_v;
        }


        System.Management.Automation.Interpreter.LabelScopeInfo
        f_1507_10308_10355(System.Management.Automation.Interpreter.LabelScopeInfo
        parent, System.Management.Automation.Interpreter.LabelScopeKind
        kind)
        {
            var return_v = new System.Management.Automation.Interpreter.LabelScopeInfo(parent, kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10308, 10355);
            return return_v;
        }


        System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>
        f_1507_10440_10472()
        {
            var return_v = new System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10440, 10472);
            return return_v;
        }


        static System.Management.Automation.Interpreter.LocalDefinition[]
        f_1507_10895_10925()
        {
            var return_v = Array.Empty<LocalDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 10895, 10925);
            return return_v;
        }


        System.Management.Automation.Interpreter.InstructionList
        f_1507_11025_11046()
        {
            var return_v = new System.Management.Automation.Interpreter.InstructionList();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1507, 11025, 11046);
            return return_v;
        }


        static int
        f_1507_11250_11278_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1507, 11186, 11332);
            return return_v;
        }

    }
}
