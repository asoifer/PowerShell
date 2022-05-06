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

using System.Linq.Expressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Management.Automation.Interpreter
{
    using LoopFunc = Func<object[], StrongBox<object>[], InterpretedFrame, int>;
    internal abstract class OffsetInstruction : Instruction
    {
        internal const int
        Unknown = Int32.MinValue
        ;

        internal const int
        CacheSize = 32
        ;

        protected int _offset;

        public int Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 1386, 1409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1392, 1407);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 1386, 1409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 1366, 1411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 1366, 1411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract Instruction[] Cache { get; }

        public Instruction Fixup(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 1479, 1865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1540, 1594);

                f_1491_1540_1593(_offset == Unknown && (DynAbs.Tracing.TraceSender.Expression_True(1491, 1553, 1592) && offset != Unknown));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1608, 1625);

                _offset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1641, 1659);

                var
                cache = f_1491_1653_1658()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1673, 1826) || true) && (cache != null && (DynAbs.Tracing.TraceSender.Expression_True(1491, 1677, 1705) && offset >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(1491, 1677, 1730) && offset < f_1491_1718_1730(cache)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 1673, 1826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1764, 1811);

                    return cache[offset] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1491, 1771, 1810) ?? (cache[offset] = this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 1673, 1826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1842, 1854);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 1479, 1865);

                int
                f_1491_1540_1593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 1540, 1593);
                    return 0;
                }


                System.Management.Automation.Interpreter.Instruction[]
                f_1491_1653_1658()
                {
                    var return_v = Cache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 1653, 1658);
                    return return_v;
                }


                int
                f_1491_1718_1730(System.Management.Automation.Interpreter.Instruction[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 1718, 1730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 1479, 1865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 1479, 1865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IList<object> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 1877, 2134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2027, 2123);

                return f_1491_2034_2044(this) + ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 2048, 2066) || ((_offset != Unknown && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 2069, 2106)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 2109, 2121))) ? " -> " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((instructionIndex + _offset)).ToString(), 1491, 2078, 2106) : string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 1877, 2134);

                string
                f_1491_2034_2044(System.Management.Automation.Interpreter.OffsetInstruction
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 2034, 2044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 1877, 2134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 1877, 2134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 2146, 2291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2204, 2280);

                return f_1491_2211_2226() + ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 2230, 2248) || ((_offset == Unknown && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 2251, 2256)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 2259, 2278))) ? "(?)" : "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_offset).ToString(), 1491, 2265, 2272) + ")");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 2146, 2291);

                string
                f_1491_2211_2226()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 2211, 2226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 2146, 2291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2146, 2291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public OffsetInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 1084, 2298);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1336, 1353);
            this._offset = Unknown;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 1084, 2298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 1084, 2298);
        }


        static OffsetInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 1084, 2298);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1175, 1199);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 1229, 1243);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 1084, 2298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 1084, 2298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 1084, 2298);
    }
    internal sealed class BranchFalseInstruction : OffsetInstruction
    {
        private static Instruction[] s_cache;

        public override Instruction[] Cache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 2496, 2561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2502, 2559);

                    return s_cache ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction[]>(1491, 2509, 2558) ?? (s_cache = new Instruction[CacheSize]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 2496, 2561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 2436, 2572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2436, 2572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal BranchFalseInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 2584, 2639);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 2584, 2639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 2584, 2639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2584, 2639);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 2687, 2704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2693, 2702);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 2687, 2704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 2651, 2706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2651, 2706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 2718, 2962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2790, 2823);

                f_1491_2790_2822(_offset != Unknown);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2839, 2925) || true) && (!(bool)f_1491_2850_2861(frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 2839, 2925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2895, 2910);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 2839, 2925);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2941, 2951);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 2718, 2962);

                int
                f_1491_2790_2822(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 2790, 2822);
                    return 0;
                }


                object
                f_1491_2850_2861(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 2850, 2861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 2718, 2962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2718, 2962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BranchFalseInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 2306, 2969);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 2416, 2423);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 2306, 2969);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2306, 2969);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 2306, 2969);
    }
    internal sealed class BranchTrueInstruction : OffsetInstruction
    {
        private static Instruction[] s_cache;

        public override Instruction[] Cache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 3166, 3231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3172, 3229);

                    return s_cache ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction[]>(1491, 3179, 3228) ?? (s_cache = new Instruction[CacheSize]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 3166, 3231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3106, 3242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3106, 3242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal BranchTrueInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 3254, 3308);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 3254, 3308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3254, 3308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3254, 3308);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 3356, 3373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3362, 3371);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 3356, 3373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3320, 3375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3320, 3375);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 3387, 3630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3459, 3492);

                f_1491_3459_3491(_offset != Unknown);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3508, 3593) || true) && ((bool)f_1491_3518_3529(frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 3508, 3593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3563, 3578);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 3508, 3593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3609, 3619);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 3387, 3630);

                int
                f_1491_3459_3491(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 3459, 3491);
                    return 0;
                }


                object
                f_1491_3518_3529(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 3518, 3529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3387, 3630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3387, 3630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BranchTrueInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 2977, 3637);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3086, 3093);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 2977, 3637);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 2977, 3637);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 2977, 3637);
    }
    internal sealed class CoalescingBranchInstruction : OffsetInstruction
    {
        private static Instruction[] s_cache;

        public override Instruction[] Cache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 3840, 3905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3846, 3903);

                    return s_cache ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction[]>(1491, 3853, 3902) ?? (s_cache = new Instruction[CacheSize]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 3840, 3905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3780, 3916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3780, 3916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CoalescingBranchInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 3928, 3988);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 3928, 3988);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 3928, 3988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3928, 3988);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 4036, 4053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4042, 4051);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 4036, 4053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 4000, 4055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 4000, 4055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 4103, 4120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4109, 4118);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 4103, 4120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 4067, 4122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 4067, 4122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 4134, 4380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4206, 4239);

                f_1491_4206_4238(_offset != Unknown);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4255, 4343) || true) && (f_1491_4259_4271(frame) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 4255, 4343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4313, 4328);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 4255, 4343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4359, 4369);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 4134, 4380);

                int
                f_1491_4206_4238(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 4206, 4238);
                    return 0;
                }


                object
                f_1491_4259_4271(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 4259, 4271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 4134, 4380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 4134, 4380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CoalescingBranchInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 3645, 4387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 3760, 3767);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 3645, 4387);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 3645, 4387);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 3645, 4387);
    }
    internal class BranchInstruction : OffsetInstruction
    {
        private static Instruction[][][] s_caches;

        public override Instruction[] Cache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 4578, 4930);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4614, 4776) || true) && (s_caches == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 4614, 4776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4676, 4757);

                        s_caches = new Instruction[2][][] { new Instruction[2][], new Instruction[2][] };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 4614, 4776);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4796, 4915);

                    return s_caches[f_1491_4812_4825()][f_1491_4827_4840()] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction[]>(1491, 4803, 4914) ?? (s_caches[f_1491_4855_4868()][f_1491_4870_4883()] = new Instruction[CacheSize]));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 4578, 4930);

                    int
                    f_1491_4812_4825()
                    {
                        var return_v = ConsumedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 4812, 4825);
                        return return_v;
                    }


                    int
                    f_1491_4827_4840()
                    {
                        var return_v = ProducedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 4827, 4840);
                        return return_v;
                    }


                    int
                    f_1491_4855_4868()
                    {
                        var return_v = ConsumedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 4855, 4868);
                        return return_v;
                    }


                    int
                    f_1491_4870_4883()
                    {
                        var return_v = ProducedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 4870, 4883);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 4518, 4941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 4518, 4941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal readonly bool _hasResult;

        internal readonly bool _hasValue;

        internal BranchInstruction()
        : this(f_1491_5091_5096_C(false), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 5042, 5126);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 5042, 5126);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5042, 5126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5042, 5126);
            }
        }

        public BranchInstruction(bool hasResult, bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 5138, 5287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4976, 4986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5020, 5029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5218, 5241);

                _hasResult = hasResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5255, 5276);

                _hasValue = hasValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 5138, 5287);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5138, 5287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5138, 5287);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 5357, 5390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5363, 5388);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 5370, 5379) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 5382, 5383)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 5386, 5387))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 5357, 5390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5299, 5401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5299, 5401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 5471, 5505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5477, 5503);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 5484, 5494) || ((_hasResult && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 5497, 5498)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 5501, 5502))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 5471, 5505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5413, 5516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5413, 5516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 5528, 5675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5600, 5633);

                f_1491_5600_5632(_offset != Unknown);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5649, 5664);

                return _offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 5528, 5675);

                int
                f_1491_5600_5632(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 5600, 5632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5528, 5675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5528, 5675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BranchInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 4395, 5682);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 4497, 4505);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 4395, 5682);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 4395, 5682);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 4395, 5682);

        static bool
        f_1491_5091_5096_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1491, 5042, 5126);
            return return_v;
        }

    }
    internal abstract class IndexedBranchInstruction : Instruction
    {
        protected const int
        CacheSize = 32
        ;

        internal readonly int _labelIndex;

        public IndexedBranchInstruction(int labelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 5862, 5970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5838, 5849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5934, 5959);

                _labelIndex = labelIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 5862, 5970);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5862, 5970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5862, 5970);
            }
        }

        public RuntimeLabel GetLabel(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 5982, 6177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6059, 6106);

                f_1491_6059_6105(_labelIndex != UnknownInstrIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6120, 6166);

                return frame.Interpreter._labels[_labelIndex];
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 5982, 6177);

                int
                f_1491_6059_6105(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 6059, 6105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 5982, 6177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5982, 6177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IList<object> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 6189, 6569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6339, 6386);

                f_1491_6339_6385(_labelIndex != UnknownInstrIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6400, 6444);

                int
                targetIndex = f_1491_6418_6443(labelIndexer, _labelIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6458, 6558);

                return f_1491_6465_6475(this) + ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 6479, 6518) || ((targetIndex != BranchLabel.UnknownIndex && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 6521, 6541)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 6544, 6556))) ? " -> " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (targetIndex).ToString(), 1491, 6530, 6541) : string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 6189, 6569);

                int
                f_1491_6339_6385(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 6339, 6385);
                    return 0;
                }


                int
                f_1491_6418_6443(System.Func<int, int>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 6418, 6443);
                    return return_v;
                }


                string
                f_1491_6465_6475(System.Management.Automation.Interpreter.IndexedBranchInstruction
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 6465, 6475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 6189, 6569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 6189, 6569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 6581, 6760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6639, 6686);

                f_1491_6639_6685(_labelIndex != UnknownInstrIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 6700, 6749);

                return f_1491_6707_6722() + "[" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_labelIndex).ToString(), 1491, 6731, 6742) + "]";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 6581, 6760);

                int
                f_1491_6639_6685(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 6639, 6685);
                    return 0;
                }


                string
                f_1491_6707_6722()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 6707, 6722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 6581, 6760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 6581, 6760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IndexedBranchInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 5690, 6767);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 5789, 5803);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 5690, 6767);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 5690, 6767);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 5690, 6767);
    }
    internal sealed class GotoInstruction : IndexedBranchInstruction
    {
        private const int
        Variants = 4
        ;

        private static readonly GotoInstruction[] s_cache;

        private readonly bool _hasResult;

        private readonly bool _hasValue;

        public override int ConsumedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 9234, 9251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9240, 9249);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 9234, 9251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9190, 9253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9190, 9253);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 9309, 9326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9315, 9324);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 9309, 9326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9265, 9328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9265, 9328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 9398, 9431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9404, 9429);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 9411, 9420) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 9423, 9424)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 9427, 9428))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 9398, 9431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9340, 9442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9340, 9442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 9512, 9546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9518, 9544);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 9525, 9535) || ((_hasResult && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 9538, 9539)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 9542, 9543))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 9512, 9546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9454, 9557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9454, 9557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private GotoInstruction(int targetIndex, bool hasResult, bool hasValue)
        : base(f_1491_9661_9672_C(targetIndex))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 9569, 9767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 8427, 8437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 8599, 8608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9698, 9721);

                _hasResult = hasResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9735, 9756);

                _hasValue = hasValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 9569, 9767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9569, 9767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9569, 9767);
            }
        }

        internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1491, 9779, 10243);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9889, 10156) || true) && (labelIndex < CacheSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 9889, 10156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 9949, 10026);

                    var
                    index = Variants * labelIndex | ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 9986, 9995) || ((hasResult && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 9998, 9999)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 10002, 10003))) ? 2 : 0) | ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 10008, 10016) || ((hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 10019, 10020)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 10023, 10024))) ? 1 : 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10044, 10141);

                    return s_cache[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.GotoInstruction>(1491, 10051, 10140) ?? (s_cache[index] = f_1491_10087_10139(labelIndex, hasResult, hasValue)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 9889, 10156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10172, 10232);

                return f_1491_10179_10231(labelIndex, hasResult, hasValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1491, 9779, 10243);

                System.Management.Automation.Interpreter.GotoInstruction
                f_1491_10087_10139(int
                targetIndex, bool
                hasResult, bool
                hasValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.GotoInstruction(targetIndex, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 10087, 10139);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GotoInstruction
                f_1491_10179_10231(int
                targetIndex, bool
                hasResult, bool
                hasValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.GotoInstruction(targetIndex, hasResult, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 10179, 10231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 9779, 10243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 9779, 10243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 10255, 10520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10402, 10509);

                return f_1491_10409_10508(frame, _labelIndex, (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 10433, 10442) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 10445, 10456)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 10459, 10478))) ? f_1491_10445_10456(frame) : Interpreter.NoValue, gotoExceptionHandler: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 10255, 10520);

                object
                f_1491_10445_10456(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 10445, 10456);
                    return return_v;
                }


                int
                f_1491_10409_10508(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                labelIndex, object
                value, bool
                gotoExceptionHandler)
                {
                    var return_v = this_param.Goto(labelIndex, value, gotoExceptionHandler: gotoExceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 10409, 10508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 10255, 10520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 10255, 10520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GotoInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 8177, 10527);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 8276, 8288);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 8341, 8392);
            s_cache = new GotoInstruction[Variants * CacheSize];
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 8177, 10527);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 8177, 10527);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 8177, 10527);

        static int
        f_1491_9661_9672_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1491, 9569, 9767);
            return return_v;
        }

    }
    internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        private readonly bool _hasFinally;

        private TryCatchFinallyHandler _tryHandler;

        internal void SetTryHandler(TryCatchFinallyHandler tryHandler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 10739, 10971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10826, 10921);

                f_1491_10826_10920(_tryHandler == null && (DynAbs.Tracing.TraceSender.Expression_True(1491, 10839, 10880) && tryHandler != null), "the tryHandler can be set only once");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10935, 10960);

                _tryHandler = tryHandler;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 10739, 10971);

                int
                f_1491_10826_10920(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 10826, 10920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 10739, 10971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 10739, 10971);
            }
        }

        public override int ProducedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 11027, 11062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11033, 11060);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 11040, 11051) || ((_hasFinally && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 11054, 11055)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 11058, 11059))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 11027, 11062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 10983, 11064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 10983, 11064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally)
        : base(f_1491_11170_11181_C(targetIndex))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 11076, 11243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10654, 10673);
                this._hasFinally = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 10715, 10726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11207, 11232);

                _hasFinally = hasFinally;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 11076, 11243);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 11076, 11243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 11076, 11243);
            }
        }

        internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1491, 11255, 11432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11360, 11421);

                return f_1491_11367_11420(labelIndex, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1491, 11255, 11432);

                System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                f_1491_11367_11420(int
                targetIndex, bool
                hasFinally)
                {
                    var return_v = new System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction(targetIndex, hasFinally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 11367, 11420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 11255, 11432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 11255, 11432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EnterTryCatchFinallyInstruction CreateTryCatch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1491, 11444, 11613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11533, 11602);

                return f_1491_11540_11601(UnknownInstrIndex, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1491, 11444, 11613);

                System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction
                f_1491_11540_11601(int
                targetIndex, bool
                hasFinally)
                {
                    var return_v = new System.Management.Automation.Interpreter.EnterTryCatchFinallyInstruction(targetIndex, hasFinally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 11540, 11601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 11444, 11613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 11444, 11613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 11625, 16799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11697, 11769);

                f_1491_11697_11768(_tryHandler != null, "the tryHandler must be set already");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11785, 11919) || true) && (_hasFinally)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 11785, 11919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11868, 11904);

                    f_1491_11868_11903(                // Push finally.
                                    frame, _labelIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 11785, 11919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11935, 11979);

                int
                prevInstrIndex = frame.InstructionIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 11993, 12018);

                frame.InstructionIndex++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12092, 12155);

                var
                instructions = frame.Interpreter.Instructions.Instructions
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12243, 12278);

                    int
                    index = frame.InstructionIndex
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12296, 12526) || true) && (index >= _tryHandler.TryStartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1491, 12303, 12372) && index < _tryHandler.TryEndIndex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 12296, 12526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12414, 12454);

                            index += f_1491_12423_12453(instructions[index], frame);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12476, 12507);

                            frame.InstructionIndex = index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 12296, 12526);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1491, 12296, 12526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1491, 12296, 12526);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12639, 13034) || true) && (index == _tryHandler.GotoEndTargetIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 12639, 13034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12810, 12936);

                        f_1491_12810_12935(instructions[index] is GotoInstruction, "should be the 'Goto' instruction that jumps out the try/catch/finally");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 12958, 13015);

                        frame.InstructionIndex += f_1491_12984_13014(instructions[index], frame);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 12639, 13034);
                    }
                }
                catch (RethrowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1491, 13063, 13214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13193, 13199);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1491, 13063, 13214);
                }
                catch (Exception exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1491, 13228, 15050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13288, 13326);

                    f_1491_13288_13325(frame, exception);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13427, 13473) || true) && (f_1491_13431_13461_M(!_tryHandler.IsCatchBlockExist))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 13427, 13473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13465, 13471);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 13427, 13473);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13612, 13639);

                    ExceptionHandler
                    exHandler
                    = default(ExceptionHandler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13657, 13740);

                    frame.InstructionIndex += f_1491_13683_13739(_tryHandler, frame, exception, out exHandler);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13758, 13791) || true) && (exHandler == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 13758, 13791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13783, 13789);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 13758, 13791);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13809, 13830);

                    bool
                    rethrow = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13936, 13971);

                        int
                        index = frame.InstructionIndex
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 13993, 14243) || true) && (index >= exHandler.HandlerStartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1491, 14000, 14073) && index < exHandler.HandlerEndIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 13993, 14243);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14123, 14163);

                                index += f_1491_14132_14162(instructions[index], frame);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14189, 14220);

                                frame.InstructionIndex = index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 13993, 14243);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1491, 13993, 14243);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1491, 13993, 14243);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14366, 14781) || true) && (index == _tryHandler.GotoEndTargetIndex)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 14366, 14781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14549, 14675);

                            f_1491_14549_14674(instructions[index] is GotoInstruction, "should be the 'Goto' instruction that jumps out the try/catch/finally");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14701, 14758);

                            frame.InstructionIndex += f_1491_14727_14757(instructions[index], frame);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 14366, 14781);
                        }
                    }
                    catch (RethrowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1491, 14818, 14992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 14958, 14973);

                        rethrow = true;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1491, 14818, 14992);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 15012, 15035) || true) && (rethrow)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 15012, 15035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 15027, 15033);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 15012, 15035);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1491, 13228, 15050);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1491, 15064, 16725);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 15104, 16710) || true) && (f_1491_15108_15139(_tryHandler))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 15104, 16710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 15947, 15988);

                        bool
                        isFromJump = f_1491_15965_15987(frame)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16010, 16161);

                        f_1491_16010_16160(!isFromJump || (DynAbs.Tracing.TraceSender.Expression_False(1491, 16023, 16093) || _tryHandler.FinallyStartIndex == frame.InstructionIndex), "we should already jump to the first instruction of the finally");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16348, 16415);

                        int
                        index = frame.InstructionIndex = _tryHandler.FinallyStartIndex
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16437, 16691) || true) && (index >= _tryHandler.FinallyStartIndex && (DynAbs.Tracing.TraceSender.Expression_True(1491, 16444, 16521) && index < _tryHandler.FinallyEndIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 16437, 16691);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16571, 16611);

                                index += f_1491_16580_16610(instructions[index], frame);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16637, 16668);

                                frame.InstructionIndex = index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 16437, 16691);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1491, 16437, 16691);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1491, 16437, 16691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 15104, 16710);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1491, 15064, 16725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16741, 16788);

                return frame.InstructionIndex - prevInstrIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 11625, 16799);

                int
                f_1491_11697_11768(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 11697, 11768);
                    return 0;
                }


                int
                f_1491_11868_11903(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                continuation)
                {
                    this_param.PushContinuation(continuation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 11868, 11903);
                    return 0;
                }


                int
                f_1491_12423_12453(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 12423, 12453);
                    return return_v;
                }


                int
                f_1491_12810_12935(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 12810, 12935);
                    return 0;
                }


                int
                f_1491_12984_13014(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 12984, 13014);
                    return return_v;
                }


                int
                f_1491_13288_13325(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, System.Exception
                exception)
                {
                    this_param.SaveTraceToException(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 13288, 13325);
                    return 0;
                }


                bool
                f_1491_13431_13461_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 13431, 13461);
                    return return_v;
                }


                int
                f_1491_13683_13739(System.Management.Automation.Interpreter.TryCatchFinallyHandler
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame, System.Exception
                exception, out System.Management.Automation.Interpreter.ExceptionHandler
                handler)
                {
                    var return_v = this_param.GotoHandler(frame, (object)exception, out handler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 13683, 13739);
                    return return_v;
                }


                int
                f_1491_14132_14162(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 14132, 14162);
                    return return_v;
                }


                int
                f_1491_14549_14674(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 14549, 14674);
                    return 0;
                }


                int
                f_1491_14727_14757(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 14727, 14757);
                    return return_v;
                }


                bool
                f_1491_15108_15139(System.Management.Automation.Interpreter.TryCatchFinallyHandler
                this_param)
                {
                    var return_v = this_param.IsFinallyBlockExist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 15108, 15139);
                    return return_v;
                }


                bool
                f_1491_15965_15987(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.IsJumpHappened();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 15965, 15987);
                    return return_v;
                }


                int
                f_1491_16010_16160(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 16010, 16160);
                    return 0;
                }


                int
                f_1491_16580_16610(System.Management.Automation.Interpreter.Instruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 16580, 16610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 11625, 16799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 11625, 16799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string InstructionName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 16874, 16939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 16880, 16937);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 16887, 16898) || ((_hasFinally && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 16901, 16918)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 16921, 16936))) ? "EnterTryFinally" : "EnterTryCatch";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 16874, 16939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 16811, 16950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 16811, 16950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 16962, 17109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17020, 17098);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 17027, 17038) || ((_hasFinally && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 17041, 17079)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 17082, 17097))) ? "EnterTryFinally[" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_labelIndex).ToString(), 1491, 17062, 17073) + "]" : "EnterTryCatch";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 16962, 17109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 16962, 17109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 16962, 17109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnterTryCatchFinallyInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 10535, 17116);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 10535, 17116);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 10535, 17116);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 10535, 17116);

        static int
        f_1491_11170_11181_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1491, 11076, 11243);
            return return_v;
        }

    }
    internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
    {
        private static readonly EnterFinallyInstruction[] s_cache;

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 17448, 17465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17454, 17463);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 17448, 17465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 17412, 17467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 17412, 17467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ConsumedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 17523, 17540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17529, 17538);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 17523, 17540);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 17479, 17542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 17479, 17542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EnterFinallyInstruction(int labelIndex)
        : base(f_1491_17622_17632_C(labelIndex))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 17554, 17655);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 17554, 17655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 17554, 17655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 17554, 17655);
            }
        }

        internal static EnterFinallyInstruction Create(int labelIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1491, 17667, 17997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17754, 17923) || true) && (labelIndex < CacheSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 17754, 17923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17814, 17908);

                    return s_cache[labelIndex] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.EnterFinallyInstruction>(1491, 17821, 17907) ?? (s_cache[labelIndex] = f_1491_17867_17906(labelIndex)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 17754, 17923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17939, 17986);

                return f_1491_17946_17985(labelIndex);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1491, 17667, 17997);

                System.Management.Automation.Interpreter.EnterFinallyInstruction
                f_1491_17867_17906(int
                labelIndex)
                {
                    var return_v = new System.Management.Automation.Interpreter.EnterFinallyInstruction(labelIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 17867, 17906);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EnterFinallyInstruction
                f_1491_17946_17985(int
                labelIndex)
                {
                    var return_v = new System.Management.Automation.Interpreter.EnterFinallyInstruction(labelIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 17946, 17985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 17667, 17997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 17667, 17997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 18009, 18640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18393, 18517) || true) && (!f_1491_18398_18420(frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 18393, 18517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18454, 18502);

                    f_1491_18454_18501(frame, f_1491_18474_18489(this, frame).StackDepth);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 18393, 18517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18533, 18565);

                f_1491_18533_18564(
                            frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18579, 18606);

                f_1491_18579_18605(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18620, 18629);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 18009, 18640);

                bool
                f_1491_18398_18420(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.IsJumpHappened();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18398, 18420);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RuntimeLabel
                f_1491_18474_18489(System.Management.Automation.Interpreter.EnterFinallyInstruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.GetLabel(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18474, 18489);
                    return return_v;
                }


                int
                f_1491_18454_18501(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, int
                depth)
                {
                    this_param.SetStackDepth(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18454, 18501);
                    return 0;
                }


                int
                f_1491_18533_18564(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    this_param.PushPendingContinuation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18533, 18564);
                    return 0;
                }


                int
                f_1491_18579_18605(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    this_param.RemoveContinuation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18579, 18605);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 18009, 18640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 18009, 18640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnterFinallyInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 17212, 18647);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 17351, 17399);
            s_cache = new EnterFinallyInstruction[CacheSize];
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 17212, 18647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 17212, 18647);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 17212, 18647);

        static int
        f_1491_17622_17632_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1491, 17554, 17655);
            return return_v;
        }

    }
    internal sealed class LeaveFinallyInstruction : Instruction
    {
        internal static readonly Instruction Instance;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 18944, 18961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18950, 18959);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 18944, 18961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 18908, 18963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 18908, 18963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LeaveFinallyInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 18975, 19030);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 18975, 19030);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 18975, 19030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 18975, 19030);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 19042, 19574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19114, 19145);

                f_1491_19114_19144(frame);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19405, 19447) || true) && (!f_1491_19410_19432(frame))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 19405, 19447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19436, 19445);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 19405, 19447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19521, 19563);

                return f_1491_19528_19562(frame);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 19042, 19574);

                int
                f_1491_19114_19144(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    this_param.PopPendingContinuation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 19114, 19144);
                    return 0;
                }


                bool
                f_1491_19410_19432(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.IsJumpHappened();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 19410, 19432);
                    return return_v;
                }


                int
                f_1491_19528_19562(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.YieldToPendingContinuation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 19528, 19562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 19042, 19574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 19042, 19574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LeaveFinallyInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 18742, 19581);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 18855, 18895);
            Instance = f_1491_18866_18895();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 18742, 19581);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 18742, 19581);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 18742, 19581);

        static System.Management.Automation.Interpreter.LeaveFinallyInstruction
        f_1491_18866_18895()
        {
            var return_v = new System.Management.Automation.Interpreter.LeaveFinallyInstruction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 18866, 18895);
            return return_v;
        }

    }
    internal sealed class EnterExceptionHandlerInstruction : Instruction
    {
        internal static readonly EnterExceptionHandlerInstruction Void;

        internal static readonly EnterExceptionHandlerInstruction NonVoid;

        private readonly bool _hasValue;

        private EnterExceptionHandlerInstruction(bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 20069, 20181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 20047, 20056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 20149, 20170);

                _hasValue = hasValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 20069, 20181);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 20069, 20181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 20069, 20181);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 20744, 20777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 20750, 20775);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 20757, 20766) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 20769, 20770)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 20773, 20774))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 20744, 20777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 20708, 20779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 20708, 20779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 21099, 21116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21105, 21114);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 21099, 21116);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 21063, 21118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 21063, 21118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 21130, 21308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21288, 21297);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 21130, 21308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 21130, 21308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 21130, 21308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnterExceptionHandlerInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 19650, 21315);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19793, 19843);
            Void = f_1491_19800_19843(false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 19912, 19964);
            NonVoid = f_1491_19922_19964(true);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 19650, 21315);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 19650, 21315);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 19650, 21315);

        static System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction
        f_1491_19800_19843(bool
        hasValue)
        {
            var return_v = new System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction(hasValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 19800, 19843);
            return return_v;
        }


        static System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction
        f_1491_19922_19964(bool
        hasValue)
        {
            var return_v = new System.Management.Automation.Interpreter.EnterExceptionHandlerInstruction(hasValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 19922, 19964);
            return return_v;
        }

    }
    internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        private static LeaveExceptionHandlerInstruction[] s_cache;

        private readonly bool _hasValue;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 21847, 21880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21853, 21878);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 21860, 21869) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 21872, 21873)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 21876, 21877))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 21847, 21880);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 21789, 21891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 21789, 21891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 21961, 21994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21967, 21992);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 21974, 21983) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 21986, 21987)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 21990, 21991))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 21961, 21994);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 21903, 22005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 21903, 22005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue)
        : base(f_1491_22109_22119_C(labelIndex))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 22017, 22177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21666, 21675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22145, 22166);

                _hasValue = hasValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 22017, 22177);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 22017, 22177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 22017, 22177);
            }
        }

        internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1491, 22189, 22639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22300, 22546) || true) && (labelIndex < CacheSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 22300, 22546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22360, 22410);

                    int
                    index = (2 * labelIndex) | ((DynAbs.Tracing.TraceSender.Conditional_F1(1491, 22392, 22400) || ((hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 22403, 22404)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 22407, 22408))) ? 1 : 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22428, 22531);

                    return s_cache[index] ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction>(1491, 22435, 22530) ?? (s_cache[index] = f_1491_22471_22529(labelIndex, hasValue)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 22300, 22546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22562, 22628);

                return f_1491_22569_22627(labelIndex, hasValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1491, 22189, 22639);

                System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction
                f_1491_22471_22529(int
                labelIndex, bool
                hasValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction(labelIndex, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 22471, 22529);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction
                f_1491_22569_22627(int
                labelIndex, bool
                hasValue)
                {
                    var return_v = new System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction(labelIndex, hasValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 22569, 22627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 22189, 22639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 22189, 22639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 22651, 22788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 22723, 22777);

                return f_1491_22730_22745(this, frame).Index - frame.InstructionIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 22651, 22788);

                System.Management.Automation.Interpreter.RuntimeLabel
                f_1491_22730_22745(System.Management.Automation.Interpreter.LeaveExceptionHandlerInstruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    var return_v = this_param.GetLabel(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 22730, 22745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 22651, 22788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 22651, 22788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LeaveExceptionHandlerInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 21422, 22795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 21570, 21631);
            s_cache = new LeaveExceptionHandlerInstruction[2 * CacheSize];
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 21422, 22795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 21422, 22795);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 21422, 22795);

        static int
        f_1491_22109_22119_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1491, 22017, 22177);
            return return_v;
        }

    }
    internal sealed class LeaveFaultInstruction : Instruction
    {
        internal static readonly Instruction NonVoid;

        internal static readonly Instruction Void;

        private readonly bool _hasValue;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 23582, 23599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23588, 23597);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 23582, 23599);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 23524, 23610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 23524, 23610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 23784, 23817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23790, 23815);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 23797, 23806) || ((_hasValue && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 23809, 23810)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 23813, 23814))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 23784, 23817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 23726, 23828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 23726, 23828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LeaveFaultInstruction(bool hasValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 23840, 23941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23176, 23185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23909, 23930);

                _hasValue = hasValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 23840, 23941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 23840, 23941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 23840, 23941);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 23953, 24110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24025, 24056);

                object
                exception = f_1491_24044_24055(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24070, 24099);

                throw f_1491_24076_24098();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 23953, 24110);

                object
                f_1491_24044_24055(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24044, 24055);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RethrowException
                f_1491_24076_24098()
                {
                    var return_v = new System.Management.Automation.Interpreter.RethrowException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24076, 24098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 23953, 24110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 23953, 24110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LeaveFaultInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 22902, 24117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23013, 23054);
            NonVoid = f_1491_23023_23054(true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 23102, 23141);
            Void = f_1491_23109_23141(false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 22902, 24117);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 22902, 24117);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 22902, 24117);

        static System.Management.Automation.Interpreter.LeaveFaultInstruction
        f_1491_23023_23054(bool
        hasValue)
        {
            var return_v = new System.Management.Automation.Interpreter.LeaveFaultInstruction(hasValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 23023, 23054);
            return return_v;
        }


        static System.Management.Automation.Interpreter.LeaveFaultInstruction
        f_1491_23109_23141(bool
        hasValue)
        {
            var return_v = new System.Management.Automation.Interpreter.LeaveFaultInstruction(hasValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 23109, 23141);
            return return_v;
        }

    }
    internal sealed class ThrowInstruction : Instruction
    {
        internal static readonly ThrowInstruction Throw;

        internal static readonly ThrowInstruction VoidThrow;

        internal static readonly ThrowInstruction Rethrow;

        internal static readonly ThrowInstruction VoidRethrow;

        private readonly bool _hasResult, _rethrow;

        private ThrowInstruction(bool hasResult, bool isRethrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 24639, 24789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24606, 24616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24618, 24626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24720, 24743);

                _hasResult = hasResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24757, 24778);

                _rethrow = isRethrow;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 24639, 24789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 24639, 24789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 24639, 24789);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 24859, 24893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24865, 24891);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 24872, 24882) || ((_hasResult && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 24885, 24886)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 24889, 24890))) ? 1 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 24859, 24893);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 24801, 24904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 24801, 24904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 24974, 25034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25010, 25019);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 24974, 25034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 24916, 25045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 24916, 25045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 25057, 25429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25129, 25161);

                var
                ex = (Exception)f_1491_25149_25160(frame)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25175, 25393) || true) && (_rethrow)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 25175, 25393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25349, 25378);

                    throw f_1491_25355_25377();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 25175, 25393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25409, 25418);

                throw ex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 25057, 25429);

                object
                f_1491_25149_25160(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 25149, 25160);
                    return return_v;
                }


                System.Management.Automation.Interpreter.RethrowException
                f_1491_25355_25377()
                {
                    var return_v = new System.Management.Automation.Interpreter.RethrowException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 25355, 25377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 25057, 25429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25057, 25429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ThrowInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 24125, 25436);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24236, 24277);
            Throw = f_1491_24244_24277(true, false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24330, 24376);
            VoidThrow = f_1491_24342_24376(false, false);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24429, 24471);
            Rethrow = f_1491_24439_24471(true, true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 24524, 24571);
            VoidRethrow = f_1491_24538_24571(false, true);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 24125, 25436);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 24125, 25436);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 24125, 25436);

        static System.Management.Automation.Interpreter.ThrowInstruction
        f_1491_24244_24277(bool
        hasResult, bool
        isRethrow)
        {
            var return_v = new System.Management.Automation.Interpreter.ThrowInstruction(hasResult, isRethrow);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24244, 24277);
            return return_v;
        }


        static System.Management.Automation.Interpreter.ThrowInstruction
        f_1491_24342_24376(bool
        hasResult, bool
        isRethrow)
        {
            var return_v = new System.Management.Automation.Interpreter.ThrowInstruction(hasResult, isRethrow);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24342, 24376);
            return return_v;
        }


        static System.Management.Automation.Interpreter.ThrowInstruction
        f_1491_24439_24471(bool
        hasResult, bool
        isRethrow)
        {
            var return_v = new System.Management.Automation.Interpreter.ThrowInstruction(hasResult, isRethrow);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24439, 24471);
            return return_v;
        }


        static System.Management.Automation.Interpreter.ThrowInstruction
        f_1491_24538_24571(bool
        hasResult, bool
        isRethrow)
        {
            var return_v = new System.Management.Automation.Interpreter.ThrowInstruction(hasResult, isRethrow);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 24538, 24571);
            return return_v;
        }

    }
    internal sealed class SwitchInstruction : Instruction
    {
        private readonly Dictionary<int, int> _cases;

        internal SwitchInstruction(Dictionary<int, int> cases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 25571, 25712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25552, 25558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25650, 25672);

                f_1491_25650_25671(cases);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25686, 25701);

                _cases = cases;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 25571, 25712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 25571, 25712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25571, 25712);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 25760, 25777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25766, 25775);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 25760, 25777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 25724, 25779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25724, 25779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 25827, 25844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25833, 25842);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 25827, 25844);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 25791, 25846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25791, 25846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 25858, 26035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25930, 25941);

                int
                target
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 25955, 26024);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1491, 25962, 26010) || ((f_1491_25962_26010(_cases, f_1491_25986_25997(frame), out target) && DynAbs.Tracing.TraceSender.Conditional_F2(1491, 26013, 26019)) || DynAbs.Tracing.TraceSender.Conditional_F3(1491, 26022, 26023))) ? target : 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 25858, 26035);

                object
                f_1491_25986_25997(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 25986, 25997);
                    return return_v;
                }


                bool
                f_1491_25962_26010(System.Collections.Generic.Dictionary<int, int>
                this_param, object
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue((int)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 25962, 26010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 25858, 26035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25858, 26035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SwitchInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 25444, 26042);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 25444, 26042);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 25444, 26042);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 25444, 26042);

        int
        f_1491_25650_25671(System.Collections.Generic.Dictionary<int, int>
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 25650, 25671);
            return 0;
        }

    }
    internal sealed class EnterLoopInstruction : Instruction
    {
        private readonly int _instructionIndex;

        private Dictionary<ParameterExpression, LocalVariable> _variables;

        private Dictionary<ParameterExpression, LocalVariable> _closureVariables;

        private PowerShellLoopExpression _loop;

        private int _loopEnd;

        private int _compilationThreshold;

        internal EnterLoopInstruction(PowerShellLoopExpression loop, LocalVariables locals, int compilationThreshold, int instructionIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 26457, 26852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26144, 26161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26227, 26237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26303, 26320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26364, 26369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26392, 26400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26423, 26444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26613, 26626);

                _loop = loop;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26640, 26673);

                _variables = f_1491_26653_26672(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26687, 26731);

                _closureVariables = f_1491_26707_26730(locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26745, 26790);

                _compilationThreshold = compilationThreshold;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26804, 26841);

                _instructionIndex = instructionIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 26457, 26852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 26457, 26852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 26457, 26852);
            }
        }

        internal void FinishLoop(int loopEnd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 26864, 26956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 26926, 26945);

                _loopEnd = loopEnd;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 26864, 26956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 26864, 26956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 26864, 26956);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 26968, 28137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 27674, 28101) || true) && (unchecked(_compilationThreshold--) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 27674, 28101);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 27751, 28086) || true) && (f_1491_27755_27793(frame.Interpreter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 27751, 28086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 27835, 27850);

                        f_1491_27835_27849(this, frame);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 27751, 28086);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 27751, 28086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28022, 28067);

                        f_1491_28022_28066(Compile, frame);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 27751, 28086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 27674, 28101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28117, 28126);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 26968, 28137);

                bool
                f_1491_27755_27793(System.Management.Automation.Interpreter.Interpreter
                this_param)
                {
                    var return_v = this_param.CompileSynchronously;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 27755, 27793);
                    return return_v;
                }


                int
                f_1491_27835_27849(System.Management.Automation.Interpreter.EnterLoopInstruction
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frameObj)
                {
                    this_param.Compile((object)frameObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 27835, 27849);
                    return 0;
                }


                bool
                f_1491_28022_28066(System.Threading.WaitCallback
                callBack, System.Management.Automation.Interpreter.InterpretedFrame
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, (object)state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 28022, 28066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 26968, 28137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 26968, 28137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Compiled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 28195, 28224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28201, 28222);

                    return _loop == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 28195, 28224);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 28149, 28235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 28149, 28235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void Compile(object frameObj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 28247, 29321);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28309, 28377) || true) && (f_1491_28313_28321())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 28309, 28377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28355, 28362);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 28309, 28377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28399, 28403);

                lock (this)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28437, 28517) || true) && (f_1491_28441_28449())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1491, 28437, 28517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28491, 28498);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1491, 28437, 28517);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28640, 28692);

                    InterpretedFrame
                    frame = (InterpretedFrame)frameObj
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28710, 28841);

                    var
                    compiler = f_1491_28725_28840(_loop, f_1491_28749_28779(frame.Interpreter), _variables, _closureVariables, _instructionIndex, _loopEnd)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 28859, 28922);

                    var
                    instructions = frame.Interpreter.Instructions.Instructions
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29010, 29099);

                    instructions[_instructionIndex] = f_1491_29044_29098(f_1491_29072_29097(compiler));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29203, 29216);

                    _loop = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29234, 29252);

                    _variables = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29270, 29295);

                    _closureVariables = null;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 28247, 29321);

                bool
                f_1491_28313_28321()
                {
                    var return_v = Compiled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 28313, 28321);
                    return return_v;
                }


                bool
                f_1491_28441_28449()
                {
                    var return_v = Compiled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 28441, 28449);
                    return return_v;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                f_1491_28749_28779(System.Management.Automation.Interpreter.Interpreter
                this_param)
                {
                    var return_v = this_param.LabelMapping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 28749, 28779);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoopCompiler
                f_1491_28725_28840(System.Management.Automation.Language.PowerShellLoopExpression
                loop, System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                labelMapping, System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                locals, System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                closureVariables, int
                loopStartInstructionIndex, int
                loopEndInstructionIndex)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoopCompiler(loop, labelMapping, locals, closureVariables, loopStartInstructionIndex, loopEndInstructionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 28725, 28840);
                    return return_v;
                }


                System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>
                f_1491_29072_29097(System.Management.Automation.Interpreter.LoopCompiler
                this_param)
                {
                    var return_v = this_param.CreateDelegate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 29072, 29097);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CompiledLoopInstruction
                f_1491_29044_29098(System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>
                compiledLoop)
                {
                    var return_v = new System.Management.Automation.Interpreter.CompiledLoopInstruction(compiledLoop);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 29044, 29098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 28247, 29321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 28247, 29321);
            }
        }

        static EnterLoopInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 26050, 29328);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 26050, 29328);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 26050, 29328);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 26050, 29328);

        System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
        f_1491_26653_26672(System.Management.Automation.Interpreter.LocalVariables
        this_param)
        {
            var return_v = this_param.CopyLocals();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 26653, 26672);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
        f_1491_26707_26730(System.Management.Automation.Interpreter.LocalVariables
        this_param)
        {
            var return_v = this_param.ClosureVariables;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1491, 26707, 26730);
            return return_v;
        }

    }
    internal sealed class CompiledLoopInstruction : Instruction
    {
        private readonly LoopFunc _compiledLoop;

        public CompiledLoopInstruction(LoopFunc compiledLoop)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1491, 29464, 29625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29438, 29451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29542, 29571);

                f_1491_29542_29570(compiledLoop);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29585, 29614);

                _compiledLoop = compiledLoop;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1491, 29464, 29625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 29464, 29625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 29464, 29625);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1491, 29637, 29775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1491, 29709, 29764);

                return f_1491_29716_29763(this, frame.Data, frame.Closure, frame);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1491, 29637, 29775);

                int
                f_1491_29716_29763(System.Management.Automation.Interpreter.CompiledLoopInstruction
                this_param, object[]
                arg1, System.Runtime.CompilerServices.StrongBox<object>[]
                arg2, System.Management.Automation.Interpreter.InterpretedFrame
                arg3)
                {
                    var return_v = this_param._compiledLoop(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 29716, 29763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1491, 29637, 29775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 29637, 29775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompiledLoopInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1491, 29336, 29782);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1491, 29336, 29782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1491, 29336, 29782);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1491, 29336, 29782);

        int
        f_1491_29542_29570(System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1491, 29542, 29570);
            return 0;
        }

    }
}
