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
using System.Globalization;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LoadObjectInstruction : Instruction
    {
        private readonly object _value;

        internal LoadObjectInstruction(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1520, 957, 1052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 938, 944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1026, 1041);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1520, 957, 1052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 957, 1052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 957, 1052);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1100, 1117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1106, 1115);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1100, 1117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1064, 1119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1064, 1119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1131, 1278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1203, 1243);

                frame.Data[frame.StackIndex++] = _value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1257, 1267);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1131, 1278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1131, 1278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1131, 1278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1290, 1407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1348, 1396);

                return "LoadObject(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((_value ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1520, 1372, 1388) ?? "null"))).ToString(), 1520, 1371, 1389) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1290, 1407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1290, 1407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1290, 1407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadObjectInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1520, 840, 1414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1520, 840, 1414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 840, 1414);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1520, 840, 1414);
    }
    internal sealed class LoadCachedObjectInstruction : Instruction
    {
        private readonly uint _index;

        internal LoadCachedObjectInstruction(uint index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1520, 1543, 1642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1524, 1530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1616, 1631);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1520, 1543, 1642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1543, 1642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1543, 1642);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1690, 1707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1696, 1705);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1690, 1707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1654, 1709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1654, 1709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1721, 1896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1793, 1861);

                frame.Data[frame.StackIndex++] = frame.Interpreter._objects[_index];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 1875, 1885);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1721, 1896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1721, 1896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1721, 1896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IList<object> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 1908, 2174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2058, 2163);

                return f_1520_2065_2162(f_1520_2079_2107(), "LoadCached({0}: {1})", _index, f_1520_2141_2161(objects, (int)_index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 1908, 2174);

                System.Globalization.CultureInfo
                f_1520_2079_2107()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1520, 2079, 2107);
                    return return_v;
                }


                object
                f_1520_2141_2161(System.Collections.Generic.IList<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1520, 2141, 2161);
                    return return_v;
                }


                string
                f_1520_2065_2162(System.Globalization.CultureInfo
                provider, string
                format, uint
                arg0, object
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1520, 2065, 2162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 1908, 2174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1908, 2174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 2186, 2291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2244, 2280);

                return "LoadCached(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_index).ToString(), 1520, 2267, 2273) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 2186, 2291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2186, 2291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2186, 2291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadCachedObjectInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1520, 1422, 2298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1520, 1422, 2298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 1422, 2298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1520, 1422, 2298);
    }
    internal sealed class PopInstruction : Instruction
    {
        internal static readonly PopInstruction Instance;

        private PopInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1520, 2457, 2485);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1520, 2457, 2485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2457, 2485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2457, 2485);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 2533, 2550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2539, 2548);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 2533, 2550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2497, 2552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2497, 2552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 2564, 2683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2636, 2648);

                f_1520_2636_2647(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2662, 2672);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 2564, 2683);

                object
                f_1520_2636_2647(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1520, 2636, 2647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2564, 2683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2564, 2683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 2695, 2779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2753, 2768);

                return "Pop()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 2695, 2779);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2695, 2779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2695, 2779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PopInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1520, 2306, 2786);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2413, 2444);
            Instance = f_1520_2424_2444();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1520, 2306, 2786);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2306, 2786);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1520, 2306, 2786);

        static System.Management.Automation.Interpreter.PopInstruction
        f_1520_2424_2444()
        {
            var return_v = new System.Management.Automation.Interpreter.PopInstruction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1520, 2424, 2444);
            return return_v;
        }

    }
    internal sealed class DupInstruction : Instruction
    {
        internal static readonly DupInstruction Instance;

        private DupInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1520, 2945, 2973);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1520, 2945, 2973);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2945, 2973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2945, 2973);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 3021, 3038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 3027, 3036);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 3021, 3038);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 2985, 3040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2985, 3040);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 3088, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 3094, 3103);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 3088, 3105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 3052, 3107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 3052, 3107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 3119, 3272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 3191, 3237);

                frame.Data[frame.StackIndex++] = f_1520_3224_3236(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 3251, 3261);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 3119, 3272);

                object
                f_1520_3224_3236(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1520, 3224, 3236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 3119, 3272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 3119, 3272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1520, 3284, 3368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 3342, 3357);

                return "Dup()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1520, 3284, 3368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1520, 3284, 3368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 3284, 3368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DupInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1520, 2794, 3375);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1520, 2901, 2932);
            Instance = f_1520_2912_2932();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1520, 2794, 3375);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1520, 2794, 3375);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1520, 2794, 3375);

        static System.Management.Automation.Interpreter.DupInstruction
        f_1520_2912_2932()
        {
            var return_v = new System.Management.Automation.Interpreter.DupInstruction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1520, 2912, 2932);
            return return_v;
        }

    }
}
