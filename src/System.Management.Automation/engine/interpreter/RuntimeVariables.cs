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
    internal sealed class RuntimeVariables : IRuntimeVariables
    {
        private readonly IStrongBox[] _boxes;

        private RuntimeVariables(IStrongBox[] boxes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1519, 940, 1035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 921, 927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 1009, 1024);

                _boxes = boxes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1519, 940, 1035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1519, 940, 1035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 940, 1035);
            }
        }

        int IRuntimeVariables.Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1519, 1099, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 1135, 1156);

                    return f_1519_1142_1155(_boxes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1519, 1099, 1171);

                    int
                    f_1519_1142_1155(System.Runtime.CompilerServices.IStrongBox[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1519, 1142, 1155);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1519, 1047, 1182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 1047, 1182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IRuntimeVariables.this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1519, 1259, 1337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 1295, 1322);

                    return f_1519_1302_1321(_boxes[index]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1519, 1259, 1337);

                    object
                    f_1519_1302_1321(System.Runtime.CompilerServices.IStrongBox
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1519, 1302, 1321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1519, 1259, 1337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 1259, 1337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1519, 1353, 1432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 1389, 1417);

                    _boxes[index].Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1519, 1353, 1432);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1519, 1353, 1432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 1353, 1432);
                }
            }
        }

        internal static IRuntimeVariables Create(IStrongBox[] boxes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1519, 1455, 1586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1519, 1540, 1575);

                return f_1519_1547_1574(boxes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1519, 1455, 1586);

                System.Management.Automation.Interpreter.RuntimeVariables
                f_1519_1547_1574(System.Runtime.CompilerServices.IStrongBox[]
                boxes)
                {
                    var return_v = new System.Management.Automation.Interpreter.RuntimeVariables(boxes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1519, 1547, 1574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1519, 1455, 1586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 1455, 1586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuntimeVariables()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1519, 816, 1593);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1519, 816, 1593);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1519, 816, 1593);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1519, 816, 1593);
    }
}
