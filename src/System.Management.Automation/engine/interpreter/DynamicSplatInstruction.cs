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

using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed partial class DynamicSplatInstruction : Instruction
    {
        private readonly CallSite<Func<CallSite, ArgumentArray, object>> _site;

        private readonly int _argumentCount;

        internal DynamicSplatInstruction(int argumentCount, CallSite<Func<CallSite, ArgumentArray, object>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1495, 1181, 1380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1117, 1122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1154, 1168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1311, 1324);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1338, 1369);

                _argumentCount = argumentCount;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1495, 1181, 1380);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1495, 1181, 1380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 1181, 1380);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1495, 1428, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1434, 1443);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1495, 1428, 1445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1495, 1392, 1447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 1392, 1447);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1495, 1495, 1525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1501, 1523);

                    return _argumentCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1495, 1495, 1525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1495, 1459, 1527);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 1459, 1527);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1495, 1539, 1875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1611, 1657);

                int
                first = frame.StackIndex - _argumentCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1671, 1758);

                object
                ret = f_1495_1684_1757(_site, _site, f_1495_1704_1756(frame.Data, first, _argumentCount))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1772, 1796);

                frame.Data[first] = ret;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1810, 1839);

                frame.StackIndex = first + 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1855, 1864);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1495, 1539, 1875);

                System.Management.Automation.Interpreter.ArgumentArray
                f_1495_1704_1756(object[]
                arguments, int
                first, int
                count)
                {
                    var return_v = new System.Management.Automation.Interpreter.ArgumentArray(arguments, first, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1495, 1704, 1756);
                    return return_v;
                }


                object
                f_1495_1684_1757(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, System.Management.Automation.Interpreter.ArgumentArray, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, System.Management.Automation.Interpreter.ArgumentArray, object>>
                arg1, System.Management.Automation.Interpreter.ArgumentArray
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1495, 1684, 1757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1495, 1539, 1875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 1539, 1875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1495, 1887, 2004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1495, 1945, 1993);

                return "DynamicSplatInstruction(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_site).ToString(), 1495, 1981, 1986) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1495, 1887, 2004);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1495, 1887, 2004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 1887, 2004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicSplatInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1495, 968, 2011);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1495, 968, 2011);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1495, 968, 2011);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1495, 968, 2011);
    }
}
