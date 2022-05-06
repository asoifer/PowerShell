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

namespace System.Management.Automation.Interpreter
{
    internal interface IInstructionProvider
    {

        void AddInstructions(LightCompiler compiler);
    }
    internal abstract partial class Instruction
    {
        public const int
        UnknownInstrIndex = int.MaxValue
        ;

        public virtual int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1084, 1101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1090, 1099);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1084, 1101);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1049, 1103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1049, 1103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1150, 1167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1156, 1165);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1150, 1167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1115, 1169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1115, 1169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int ConsumedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1224, 1241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1230, 1239);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1224, 1241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1181, 1243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1181, 1243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int ProducedContinuations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1298, 1315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1304, 1313);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1298, 1315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1255, 1317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1255, 1317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StackBalance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1377, 1422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1383, 1420);

                    return f_1500_1390_1403() - f_1500_1406_1419();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1377, 1422);

                    int
                    f_1500_1390_1403()
                    {
                        var return_v = ProducedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1390, 1403);
                        return return_v;
                    }


                    int
                    f_1500_1406_1419()
                    {
                        var return_v = ConsumedStack;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1406, 1419);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1329, 1433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1329, 1433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int ContinuationsBalance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1501, 1562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1507, 1560);

                    return f_1500_1514_1535() - f_1500_1538_1559();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1501, 1562);

                    int
                    f_1500_1514_1535()
                    {
                        var return_v = ProducedContinuations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1514, 1535);
                        return return_v;
                    }


                    int
                    f_1500_1538_1559()
                    {
                        var return_v = ConsumedContinuations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1538, 1559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1445, 1573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1445, 1573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract int Run(InterpretedFrame frame);

        public virtual string InstructionName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1707, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1713, 1772);

                    return f_1500_1720_1771(f_1500_1720_1734(f_1500_1720_1729(this)), "Instruction", string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1707, 1774);

                    System.Type
                    f_1500_1720_1729(System.Management.Automation.Interpreter.Instruction
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 1720, 1729);
                        return return_v;
                    }


                    string
                    f_1500_1720_1734(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1720, 1734);
                        return return_v;
                    }


                    string
                    f_1500_1720_1771(string
                    this_param, string
                    oldValue, string
                    newValue)
                    {
                        var return_v = this_param.Replace(oldValue, newValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 1720, 1771);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1645, 1785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1645, 1785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1797, 1896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1855, 1885);

                return f_1500_1862_1877() + "()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1797, 1896);

                string
                f_1500_1862_1877()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1500, 1862, 1877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1797, 1896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1797, 1896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IList<object> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 1908, 2086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2057, 2075);

                return f_1500_2064_2074(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 1908, 2086);

                string
                f_1500_2064_2074(System.Management.Automation.Interpreter.Instruction
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 2064, 2074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 1908, 2086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 1908, 2086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object GetDebugCookie(LightCompiler compiler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 2098, 2206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2183, 2195);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 2098, 2206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 2098, 2206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2098, 2206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Instruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1500, 927, 2213);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1500, 927, 2213);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 927, 2213);
        }


        static Instruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1500, 927, 2213);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 1004, 1036);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1500, 927, 2213);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 927, 2213);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1500, 927, 2213);
    }
    internal sealed class NotInstruction : Instruction
    {
        public static readonly Instruction Instance;

        private NotInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1500, 2367, 2395);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1500, 2367, 2395);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 2367, 2395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2367, 2395);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 2443, 2460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2449, 2458);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 2443, 2460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 2407, 2462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2407, 2462);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 2510, 2527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2516, 2525);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 2510, 2527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 2474, 2529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2474, 2529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1500, 2541, 2741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2613, 2706);

                f_1500_2613_2705(frame, (DynAbs.Tracing.TraceSender.Conditional_F1(1500, 2624, 2641) || (((bool)f_1500_2630_2641(frame) && DynAbs.Tracing.TraceSender.Conditional_F2(1500, 2644, 2673)) || DynAbs.Tracing.TraceSender.Conditional_F3(1500, 2676, 2704))) ? ScriptingRuntimeHelpers.False : ScriptingRuntimeHelpers.True);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2720, 2730);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1500, 2541, 2741);

                object
                f_1500_2630_2641(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 2630, 2641);
                    return return_v;
                }


                int
                f_1500_2613_2705(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 2613, 2705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1500, 2541, 2741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2541, 2741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NotInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1500, 2221, 2748);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1500, 2323, 2354);
            Instance = f_1500_2334_2354();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1500, 2221, 2748);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1500, 2221, 2748);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1500, 2221, 2748);

        static System.Management.Automation.Interpreter.NotInstruction
        f_1500_2334_2354()
        {
            var return_v = new System.Management.Automation.Interpreter.NotInstruction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1500, 2334, 2354);
            return return_v;
        }

    }
}
