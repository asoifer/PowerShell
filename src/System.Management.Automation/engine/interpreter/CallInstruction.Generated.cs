/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * ironpy@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/
using System.Linq.Expressions;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

using System.Dynamic;

namespace System.Management.Automation.Interpreter
{
    internal partial class CallInstruction
    {
        private const int
        MaxHelpers = 10
        ;

        private const int
        MaxArgs = 3
        ;

        public virtual object InvokeInstance(object instance, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 1311, 2288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1402, 2277);

                switch (f_1490_1409_1420(args))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1449, 1473);

                        return f_1490_1456_1472(this, instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1499, 1532);

                        return f_1490_1506_1531(this, instance, args[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1558, 1600);

                        return f_1490_1565_1599(this, instance, args[0], args[1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1626, 1677);

                        return f_1490_1633_1676(this, instance, args[0], args[1], args[2]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1703, 1763);

                        return f_1490_1710_1762(this, instance, args[0], args[1], args[2], args[3]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1789, 1858);

                        return f_1490_1796_1857(this, instance, args[0], args[1], args[2], args[3], args[4]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1884, 1962);

                        return f_1490_1891_1961(this, instance, args[0], args[1], args[2], args[3], args[4], args[5]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1988, 2075);

                        return f_1490_1995_2074(this, instance, args[0], args[1], args[2], args[3], args[4], args[5], args[6]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2101, 2197);

                        return f_1490_2108_2196(this, instance, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 1402, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2224, 2262);

                        throw f_1490_2230_2261();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 1402, 2277);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 1311, 2288);

                int
                f_1490_1409_1420(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1490, 1409, 1420);
                    return return_v;
                }


                object
                f_1490_1456_1472(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0)
                {
                    var return_v = this_param.Invoke(arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1456, 1472);
                    return return_v;
                }


                object
                f_1490_1506_1531(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1)
                {
                    var return_v = this_param.Invoke(arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1506, 1531);
                    return return_v;
                }


                object
                f_1490_1565_1599(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1565, 1599);
                    return return_v;
                }


                object
                f_1490_1633_1676(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1633, 1676);
                    return return_v;
                }


                object
                f_1490_1710_1762(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1710, 1762);
                    return return_v;
                }


                object
                f_1490_1796_1857(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1796, 1857);
                    return return_v;
                }


                object
                f_1490_1891_1961(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1891, 1961);
                    return return_v;
                }


                object
                f_1490_1995_2074(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 1995, 2074);
                    return return_v;
                }


                object
                f_1490_2108_2196(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2108, 2196);
                    return return_v;
                }


                System.InvalidOperationException
                f_1490_2230_2261()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2230, 2261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 1311, 2288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 1311, 2288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 2300, 3285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2366, 3274);

                switch (f_1490_2373_2384(args))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2413, 2429);

                        return f_1490_2420_2428(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2455, 2478);

                        return f_1490_2462_2477(this, args[0]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2504, 2536);

                        return f_1490_2511_2535(this, args[0], args[1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2562, 2603);

                        return f_1490_2569_2602(this, args[0], args[1], args[2]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2629, 2679);

                        return f_1490_2636_2678(this, args[0], args[1], args[2], args[3]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2705, 2764);

                        return f_1490_2712_2763(this, args[0], args[1], args[2], args[3], args[4]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2790, 2858);

                        return f_1490_2797_2857(this, args[0], args[1], args[2], args[3], args[4], args[5]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2884, 2961);

                        return f_1490_2891_2960(this, args[0], args[1], args[2], args[3], args[4], args[5], args[6]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 2987, 3073);

                        return f_1490_2994_3072(this, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    case 9:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3099, 3194);

                        return f_1490_3106_3193(this, args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], args[8]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 2366, 3274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3221, 3259);

                        throw f_1490_3227_3258();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 2366, 3274);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 2300, 3285);

                int
                f_1490_2373_2384(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1490, 2373, 2384);
                    return return_v;
                }


                object
                f_1490_2420_2428(System.Management.Automation.Interpreter.CallInstruction
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2420, 2428);
                    return return_v;
                }


                object
                f_1490_2462_2477(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0)
                {
                    var return_v = this_param.Invoke(arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2462, 2477);
                    return return_v;
                }


                object
                f_1490_2511_2535(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1)
                {
                    var return_v = this_param.Invoke(arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2511, 2535);
                    return return_v;
                }


                object
                f_1490_2569_2602(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2569, 2602);
                    return return_v;
                }


                object
                f_1490_2636_2678(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2636, 2678);
                    return return_v;
                }


                object
                f_1490_2712_2763(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2712, 2763);
                    return return_v;
                }


                object
                f_1490_2797_2857(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2797, 2857);
                    return return_v;
                }


                object
                f_1490_2891_2960(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2891, 2960);
                    return return_v;
                }


                object
                f_1490_2994_3072(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 2994, 3072);
                    return return_v;
                }


                object
                f_1490_3106_3193(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                arg0, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8)
                {
                    var return_v = this_param.Invoke(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3106, 3193);
                    return return_v;
                }


                System.InvalidOperationException
                f_1490_3227_3258()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3227, 3258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 2300, 3285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 2300, 3285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3297, 3370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3330, 3368);

                throw f_1490_3336_3367();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3297, 3370);

                System.InvalidOperationException
                f_1490_3336_3367()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3336, 3367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3297, 3370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3297, 3370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3382, 3466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3426, 3464);

                throw f_1490_3432_3463();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3382, 3466);

                System.InvalidOperationException
                f_1490_3432_3463()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3432, 3463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3382, 3466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3382, 3466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3478, 3575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3535, 3573);

                throw f_1490_3541_3572();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3478, 3575);

                System.InvalidOperationException
                f_1490_3541_3572()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3541, 3572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3478, 3575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3478, 3575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3587, 3697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3657, 3695);

                throw f_1490_3663_3694();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3587, 3697);

                System.InvalidOperationException
                f_1490_3663_3694()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3663, 3694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3587, 3697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3587, 3697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3709, 3832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3792, 3830);

                throw f_1490_3798_3829();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3709, 3832);

                System.InvalidOperationException
                f_1490_3798_3829()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3798, 3829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3709, 3832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3709, 3832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3844, 3980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 3940, 3978);

                throw f_1490_3946_3977();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3844, 3980);

                System.InvalidOperationException
                f_1490_3946_3977()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 3946, 3977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3844, 3980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3844, 3980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 3992, 4141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 4101, 4139);

                throw f_1490_4107_4138();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 3992, 4141);

                System.InvalidOperationException
                f_1490_4107_4138()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 4107, 4138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 3992, 4141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 3992, 4141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 4153, 4315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 4275, 4313);

                throw f_1490_4281_4312();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 4153, 4315);

                System.InvalidOperationException
                f_1490_4281_4312()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 4281, 4312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 4153, 4315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 4153, 4315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 4327, 4502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 4462, 4500);

                throw f_1490_4468_4499();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 4327, 4502);

                System.InvalidOperationException
                f_1490_4468_4499()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 4468, 4499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 4327, 4502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 4327, 4502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 4514, 4702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 4662, 4700);

                throw f_1490_4668_4699();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 4514, 4702);

                System.InvalidOperationException
                f_1490_4668_4699()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 4668, 4699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 4514, 4702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 4514, 4702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Fast creation works if we have a known primitive types for the entire
        /// method signature.  If we have any non-primitive types then FastCreate
        /// falls back to SlowCreate which works for all types.
        ///
        /// Fast creation is fast because it avoids using reflection (MakeGenericType
        /// and Activator.CreateInstance) to create the types.  It does this through
        /// calling a series of generic methods picking up each strong type of the
        /// signature along the way.  When it runs out of types it news up the
        /// appropriate CallInstruction with the strong-types that have been built up.
        ///
        /// One relaxation is that for return types which are non-primitive types
        /// we can fallback to object due to relaxed delegates.
        /// </summary>
        private static CallInstruction FastCreate(MethodInfo target, ParameterInfo[] pi)
        {
            Type t = TryGetParameterOrReturnType(target, pi, 0);
            if (t == null)
            {
                return new ActionCallInstruction(target);
            }

            if (t.IsEnum)
                return SlowCreate(target, pi);
            switch (t.GetTypeCode())
            {
                case TypeCode.Object:
                    {
                        if (t != typeof(object) && (IndexIsNotReturnType(0, target, pi) || t.IsValueType))
                        {
                            // if we're on the return type relaxed delegates makes it ok to use object
                            goto default;
                        }

                        return FastCreate<object>(target, pi);
                    }
                case TypeCode.Int16:
                    return FastCreate<Int16>(target, pi);
                case TypeCode.Int32:
                    return FastCreate<Int32>(target, pi);
                case TypeCode.Int64:
                    return FastCreate<Int64>(target, pi);
                case TypeCode.Boolean:
                    return FastCreate<bool>(target, pi);
                case TypeCode.Char:
                    return FastCreate<char>(target, pi);
                case TypeCode.Byte:
                    return FastCreate<byte>(target, pi);
                case TypeCode.Decimal:
                    return FastCreate<Decimal>(target, pi);
                case TypeCode.DateTime:
                    return FastCreate<DateTime>(target, pi);
                case TypeCode.Double:
                    return FastCreate<double>(target, pi);
                case TypeCode.Single:
                    return FastCreate<Single>(target, pi);
                case TypeCode.UInt16:
                    return FastCreate<UInt16>(target, pi);
                case TypeCode.UInt32:
                    return FastCreate<UInt32>(target, pi);
                case TypeCode.UInt64:
                    return FastCreate<UInt64>(target, pi);
                case TypeCode.String:
                    return FastCreate<string>(target, pi);
                case TypeCode.SByte:
                    return FastCreate<sbyte>(target, pi);
                default:
                    return SlowCreate(target, pi);
            }
        }

        private static CallInstruction FastCreate<T0>(MethodInfo target, ParameterInfo[] pi)
        {
            Type t = TryGetParameterOrReturnType(target, pi, 1);
            if (t == null)
            {
                if (target.ReturnType == typeof(void))
                {
                    return new ActionCallInstruction<T0>(target);
                }

                return new FuncCallInstruction<T0>(target);
            }

            if (t.IsEnum)
                return SlowCreate(target, pi);
            switch (t.GetTypeCode())
            {
                case TypeCode.Object:
                    {
                        if (t != typeof(object) && (IndexIsNotReturnType(1, target, pi) || t.IsValueType))
                        {
                            // if we're on the return type relaxed delegates makes it ok to use object
                            goto default;
                        }

                        return FastCreate<T0, object>(target, pi);
                    }
                case TypeCode.Int16:
                    return FastCreate<T0, Int16>(target, pi);
                case TypeCode.Int32:
                    return FastCreate<T0, Int32>(target, pi);
                case TypeCode.Int64:
                    return FastCreate<T0, Int64>(target, pi);
                case TypeCode.Boolean:
                    return FastCreate<T0, bool>(target, pi);
                case TypeCode.Char:
                    return FastCreate<T0, char>(target, pi);
                case TypeCode.Byte:
                    return FastCreate<T0, byte>(target, pi);
                case TypeCode.Decimal:
                    return FastCreate<T0, Decimal>(target, pi);
                case TypeCode.DateTime:
                    return FastCreate<T0, DateTime>(target, pi);
                case TypeCode.Double:
                    return FastCreate<T0, Double>(target, pi);
                case TypeCode.Single:
                    return FastCreate<T0, Single>(target, pi);
                case TypeCode.UInt16:
                    return FastCreate<T0, UInt16>(target, pi);
                case TypeCode.UInt32:
                    return FastCreate<T0, UInt32>(target, pi);
                case TypeCode.UInt64:
                    return FastCreate<T0, UInt64>(target, pi);
                case TypeCode.String:
                    return FastCreate<T0, string>(target, pi);
                case TypeCode.SByte:
                    return FastCreate<T0, sbyte>(target, pi);
                default:
                    return SlowCreate(target, pi);
            }
        }

        private static CallInstruction FastCreate<T0, T1>(MethodInfo target, ParameterInfo[] pi)
        {
            Type t = TryGetParameterOrReturnType(target, pi, 2);
            if (t == null)
            {
                if (target.ReturnType == typeof(void))
                {
                    return new ActionCallInstruction<T0, T1>(target);
                }

                return new FuncCallInstruction<T0, T1>(target);
            }

            if (t.IsEnum)
                return SlowCreate(target, pi);
            switch (t.GetTypeCode())
            {
                case TypeCode.Object:
                    {
                        Debug.Assert(pi.Length == 2);
                        if (t.IsValueType)
                            goto default;

                        return new FuncCallInstruction<T0, T1, object>(target);
                    }
                case TypeCode.Int16:
                    return new FuncCallInstruction<T0, T1, Int16>(target);
                case TypeCode.Int32:
                    return new FuncCallInstruction<T0, T1, Int32>(target);
                case TypeCode.Int64:
                    return new FuncCallInstruction<T0, T1, Int64>(target);
                case TypeCode.Boolean:
                    return new FuncCallInstruction<T0, T1, bool>(target);
                case TypeCode.Char:
                    return new FuncCallInstruction<T0, T1, char>(target);
                case TypeCode.Byte:
                    return new FuncCallInstruction<T0, T1, byte>(target);
                case TypeCode.Decimal:
                    return new FuncCallInstruction<T0, T1, Decimal>(target);
                case TypeCode.DateTime:
                    return new FuncCallInstruction<T0, T1, DateTime>(target);
                case TypeCode.Double:
                    return new FuncCallInstruction<T0, T1, Double>(target);
                case TypeCode.Single:
                    return new FuncCallInstruction<T0, T1, Single>(target);
                case TypeCode.UInt16:
                    return new FuncCallInstruction<T0, T1, UInt16>(target);
                case TypeCode.UInt32:
                    return new FuncCallInstruction<T0, T1, UInt32>(target);
                case TypeCode.UInt64:
                    return new FuncCallInstruction<T0, T1, UInt64>(target);
                case TypeCode.String:
                    return new FuncCallInstruction<T0, T1, string>(target);
                case TypeCode.SByte:
                    return new FuncCallInstruction<T0, T1, sbyte>(target);
                default:
                    return SlowCreate(target, pi);
            }
        }

        private static Type GetHelperType(MethodInfo info, Type[] arrTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 12068, 14561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12151, 12158);

                Type
                t
                = default(Type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12172, 14525) || true) && (f_1490_12176_12191(info) == typeof(void))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12172, 14525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12228, 13340);

                    switch (f_1490_12236_12251(arrTypes))
                    {

                        case 0:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12284, 12318);

                            t = typeof(ActionCallInstruction);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12319, 12325);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12355, 12417);

                            t = f_1490_12359_12416(typeof(ActionCallInstruction<>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12418, 12424);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12454, 12517);

                            t = f_1490_12458_12516(typeof(ActionCallInstruction<,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12518, 12524);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12554, 12618);

                            t = f_1490_12558_12617(typeof(ActionCallInstruction<,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12619, 12625);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 4:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12655, 12720);

                            t = f_1490_12659_12719(typeof(ActionCallInstruction<,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12721, 12727);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 5:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12757, 12823);

                            t = f_1490_12761_12822(typeof(ActionCallInstruction<,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12824, 12830);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 6:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12860, 12927);

                            t = f_1490_12864_12926(typeof(ActionCallInstruction<,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 12928, 12934);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 7:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 12964, 13032);

                            t = f_1490_12968_13031(typeof(ActionCallInstruction<,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13033, 13039);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13069, 13138);

                            t = f_1490_13073_13137(typeof(ActionCallInstruction<,,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13139, 13145);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        case 9:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13175, 13245);

                            t = f_1490_13179_13244(typeof(ActionCallInstruction<,,,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13246, 13252);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12228, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13283, 13321);

                            throw f_1490_13289_13320();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12228, 13340);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12172, 14525);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 12172, 14525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13380, 14510);

                    switch (f_1490_13388_13403(arrTypes))
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13436, 13496);

                            t = f_1490_13440_13495(typeof(FuncCallInstruction<>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13497, 13503);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13533, 13594);

                            t = f_1490_13537_13593(typeof(FuncCallInstruction<,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13595, 13601);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13631, 13693);

                            t = f_1490_13635_13692(typeof(FuncCallInstruction<,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13694, 13700);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 4:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13730, 13793);

                            t = f_1490_13734_13792(typeof(FuncCallInstruction<,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13794, 13800);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 5:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13830, 13894);

                            t = f_1490_13834_13893(typeof(FuncCallInstruction<,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13895, 13901);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 6:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 13931, 13996);

                            t = f_1490_13935_13995(typeof(FuncCallInstruction<,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 13997, 14003);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 7:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14033, 14099);

                            t = f_1490_14037_14098(typeof(FuncCallInstruction<,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 14100, 14106);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14136, 14203);

                            t = f_1490_14140_14202(typeof(FuncCallInstruction<,,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 14204, 14210);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 9:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14240, 14308);

                            t = f_1490_14244_14307(typeof(FuncCallInstruction<,,,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 14309, 14315);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        case 10:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14346, 14415);

                            t = f_1490_14350_14414(typeof(FuncCallInstruction<,,,,,,,,,>), arrTypes);
                            DynAbs.Tracing.TraceSender.TraceBreak(1490, 14416, 14422);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1490, 13380, 14510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14453, 14491);

                            throw f_1490_14459_14490();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 13380, 14510);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1490, 12172, 14525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14541, 14550);

                return t;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 12068, 14561);

                System.Type
                f_1490_12176_12191(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1490, 12176, 12191);
                    return return_v;
                }


                int
                f_1490_12236_12251(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1490, 12236, 12251);
                    return return_v;
                }


                System.Type
                f_1490_12359_12416(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12359, 12416);
                    return return_v;
                }


                System.Type
                f_1490_12458_12516(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12458, 12516);
                    return return_v;
                }


                System.Type
                f_1490_12558_12617(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12558, 12617);
                    return return_v;
                }


                System.Type
                f_1490_12659_12719(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12659, 12719);
                    return return_v;
                }


                System.Type
                f_1490_12761_12822(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12761, 12822);
                    return return_v;
                }


                System.Type
                f_1490_12864_12926(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12864, 12926);
                    return return_v;
                }


                System.Type
                f_1490_12968_13031(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 12968, 13031);
                    return return_v;
                }


                System.Type
                f_1490_13073_13137(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13073, 13137);
                    return return_v;
                }


                System.Type
                f_1490_13179_13244(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13179, 13244);
                    return return_v;
                }


                System.InvalidOperationException
                f_1490_13289_13320()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13289, 13320);
                    return return_v;
                }


                int
                f_1490_13388_13403(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1490, 13388, 13403);
                    return return_v;
                }


                System.Type
                f_1490_13440_13495(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13440, 13495);
                    return return_v;
                }


                System.Type
                f_1490_13537_13593(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13537, 13593);
                    return return_v;
                }


                System.Type
                f_1490_13635_13692(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13635, 13692);
                    return return_v;
                }


                System.Type
                f_1490_13734_13792(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13734, 13792);
                    return return_v;
                }


                System.Type
                f_1490_13834_13893(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13834, 13893);
                    return return_v;
                }


                System.Type
                f_1490_13935_13995(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 13935, 13995);
                    return return_v;
                }


                System.Type
                f_1490_14037_14098(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14037, 14098);
                    return return_v;
                }


                System.Type
                f_1490_14140_14202(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14140, 14202);
                    return return_v;
                }


                System.Type
                f_1490_14244_14307(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14244, 14307);
                    return return_v;
                }


                System.Type
                f_1490_14350_14414(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14350, 14414);
                    return return_v;
                }


                System.InvalidOperationException
                f_1490_14459_14490()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14459, 14490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 12068, 14561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 12068, 14561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<TRet>(Func<TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 14573, 14838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14648, 14682);

                var
                info = f_1490_14659_14681(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14702, 14709);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14730, 14784);

                    s_cache[info] = f_1490_14746_14783(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14815, 14827);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 14573, 14838);

                System.Reflection.MethodInfo?
                f_1490_14659_14681(System.Func<TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14659, 14681);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<TRet>
                f_1490_14746_14783(System.Func<TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14746, 14783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 14573, 14838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 14573, 14838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, TRet>(Func<T0, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 14850, 15127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14933, 14967);

                var
                info = f_1490_14944_14966(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 14987, 14994);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15015, 15073);

                    s_cache[info] = f_1490_15031_15072(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15104, 15116);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 14850, 15127);

                System.Reflection.MethodInfo?
                f_1490_14944_14966(System.Func<T0, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 14944, 14966);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, TRet>
                f_1490_15031_15072(System.Func<T0, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15031, 15072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 14850, 15127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 14850, 15127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, TRet>(Func<T0, T1, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 15139, 15428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15230, 15264);

                var
                info = f_1490_15241_15263(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15284, 15291);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15312, 15374);

                    s_cache[info] = f_1490_15328_15373(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15405, 15417);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 15139, 15428);

                System.Reflection.MethodInfo?
                f_1490_15241_15263(System.Func<T0, T1, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15241, 15263);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, TRet>
                f_1490_15328_15373(System.Func<T0, T1, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15328, 15373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 15139, 15428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 15139, 15428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, TRet>(Func<T0, T1, T2, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 15440, 15741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15539, 15573);

                var
                info = f_1490_15550_15572(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15593, 15600);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15621, 15687);

                    s_cache[info] = f_1490_15637_15686(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15718, 15730);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 15440, 15741);

                System.Reflection.MethodInfo?
                f_1490_15550_15572(System.Func<T0, T1, T2, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15550, 15572);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, TRet>
                f_1490_15637_15686(System.Func<T0, T1, T2, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15637, 15686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 15440, 15741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 15440, 15741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, TRet>(Func<T0, T1, T2, T3, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 15753, 16066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15860, 15894);

                var
                info = f_1490_15871_15893(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15914, 15921);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 15942, 16012);

                    s_cache[info] = f_1490_15958_16011(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16043, 16055);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 15753, 16066);

                System.Reflection.MethodInfo?
                f_1490_15871_15893(System.Func<T0, T1, T2, T3, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15871, 15893);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, TRet>
                f_1490_15958_16011(System.Func<T0, T1, T2, T3, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 15958, 16011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 15753, 16066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 15753, 16066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, T4, TRet>(Func<T0, T1, T2, T3, T4, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 16078, 16403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16193, 16227);

                var
                info = f_1490_16204_16226(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16247, 16254);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16275, 16349);

                    s_cache[info] = f_1490_16291_16348(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16380, 16392);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 16078, 16403);

                System.Reflection.MethodInfo?
                f_1490_16204_16226(System.Func<T0, T1, T2, T3, T4, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16204, 16226);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, TRet>
                f_1490_16291_16348(System.Func<T0, T1, T2, T3, T4, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16291, 16348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 16078, 16403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 16078, 16403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, T4, T5, TRet>(Func<T0, T1, T2, T3, T4, T5, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 16415, 16752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16538, 16572);

                var
                info = f_1490_16549_16571(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16592, 16599);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16620, 16698);

                    s_cache[info] = f_1490_16636_16697(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16729, 16741);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 16415, 16752);

                System.Reflection.MethodInfo?
                f_1490_16549_16571(System.Func<T0, T1, T2, T3, T4, T5, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16549, 16571);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet>
                f_1490_16636_16697(System.Func<T0, T1, T2, T3, T4, T5, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16636, 16697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 16415, 16752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 16415, 16752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, T4, T5, T6, TRet>(Func<T0, T1, T2, T3, T4, T5, T6, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 16764, 17113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16895, 16929);

                var
                info = f_1490_16906_16928(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16949, 16956);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 16977, 17059);

                    s_cache[info] = f_1490_16993_17058(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17090, 17102);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 16764, 17113);

                System.Reflection.MethodInfo?
                f_1490_16906_16928(System.Func<T0, T1, T2, T3, T4, T5, T6, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16906, 16928);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>
                f_1490_16993_17058(System.Func<T0, T1, T2, T3, T4, T5, T6, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 16993, 17058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 16764, 17113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 16764, 17113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 17125, 17486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17264, 17298);

                var
                info = f_1490_17275_17297(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17318, 17325);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17346, 17432);

                    s_cache[info] = f_1490_17362_17431(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17463, 17475);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 17125, 17486);

                System.Reflection.MethodInfo?
                f_1490_17275_17297(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 17275, 17297);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                f_1490_17362_17431(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 17362, 17431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 17125, 17486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 17125, 17486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheFunc<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 17498, 17871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17645, 17679);

                var
                info = f_1490_17656_17678(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17699, 17706);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17727, 17817);

                    s_cache[info] = f_1490_17743_17816(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17848, 17860);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 17498, 17871);

                System.Reflection.MethodInfo?
                f_1490_17656_17678(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 17656, 17678);
                    return return_v;
                }


                System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                f_1490_17743_17816(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 17743, 17816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 17498, 17871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 17498, 17871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction(Action method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 17883, 18136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 17950, 17984);

                var
                info = f_1490_17961_17983(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18004, 18011);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18032, 18082);

                    s_cache[info] = f_1490_18048_18081(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18113, 18125);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 17883, 18136);

                System.Reflection.MethodInfo?
                f_1490_17961_17983(System.Action
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 17961, 17983);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction
                f_1490_18048_18081(System.Action
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18048, 18081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 17883, 18136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 17883, 18136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0>(Action<T0> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 18148, 18413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18223, 18257);

                var
                info = f_1490_18234_18256(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18277, 18284);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18305, 18359);

                    s_cache[info] = f_1490_18321_18358(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18390, 18402);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 18148, 18413);

                System.Reflection.MethodInfo?
                f_1490_18234_18256(System.Action<T0>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18234, 18256);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0>
                f_1490_18321_18358(System.Action<T0>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18321, 18358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 18148, 18413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 18148, 18413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1>(Action<T0, T1> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 18425, 18702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18508, 18542);

                var
                info = f_1490_18519_18541(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18562, 18569);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18590, 18648);

                    s_cache[info] = f_1490_18606_18647(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18679, 18691);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 18425, 18702);

                System.Reflection.MethodInfo?
                f_1490_18519_18541(System.Action<T0, T1>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18519, 18541);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1>
                f_1490_18606_18647(System.Action<T0, T1>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18606, 18647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 18425, 18702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 18425, 18702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2>(Action<T0, T1, T2> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 18714, 19003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18805, 18839);

                var
                info = f_1490_18816_18838(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18859, 18866);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18887, 18949);

                    s_cache[info] = f_1490_18903_18948(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 18980, 18992);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 18714, 19003);

                System.Reflection.MethodInfo?
                f_1490_18816_18838(System.Action<T0, T1, T2>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18816, 18838);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2>
                f_1490_18903_18948(System.Action<T0, T1, T2>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 18903, 18948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 18714, 19003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 18714, 19003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3>(Action<T0, T1, T2, T3> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 19015, 19316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19114, 19148);

                var
                info = f_1490_19125_19147(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19168, 19175);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19196, 19262);

                    s_cache[info] = f_1490_19212_19261(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19293, 19305);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 19015, 19316);

                System.Reflection.MethodInfo?
                f_1490_19125_19147(System.Action<T0, T1, T2, T3>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19125, 19147);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3>
                f_1490_19212_19261(System.Action<T0, T1, T2, T3>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19212, 19261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 19015, 19316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 19015, 19316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3, T4>(Action<T0, T1, T2, T3, T4> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 19328, 19641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19435, 19469);

                var
                info = f_1490_19446_19468(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19489, 19496);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19517, 19587);

                    s_cache[info] = f_1490_19533_19586(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19618, 19630);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 19328, 19641);

                System.Reflection.MethodInfo?
                f_1490_19446_19468(System.Action<T0, T1, T2, T3, T4>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19446, 19468);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4>
                f_1490_19533_19586(System.Action<T0, T1, T2, T3, T4>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19533, 19586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 19328, 19641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 19328, 19641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 19653, 19978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19768, 19802);

                var
                info = f_1490_19779_19801(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19822, 19829);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19850, 19924);

                    s_cache[info] = f_1490_19866_19923(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 19955, 19967);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 19653, 19978);

                System.Reflection.MethodInfo?
                f_1490_19779_19801(System.Action<T0, T1, T2, T3, T4, T5>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19779, 19801);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5>
                f_1490_19866_19923(System.Action<T0, T1, T2, T3, T4, T5>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 19866, 19923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 19653, 19978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 19653, 19978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3, T4, T5, T6>(Action<T0, T1, T2, T3, T4, T5, T6> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 19990, 20327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20113, 20147);

                var
                info = f_1490_20124_20146(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20167, 20174);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20195, 20273);

                    s_cache[info] = f_1490_20211_20272(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20304, 20316);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 19990, 20327);

                System.Reflection.MethodInfo?
                f_1490_20124_20146(System.Action<T0, T1, T2, T3, T4, T5, T6>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20124, 20146);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6>
                f_1490_20211_20272(System.Action<T0, T1, T2, T3, T4, T5, T6>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20211, 20272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 19990, 20327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 19990, 20327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 20339, 20688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20470, 20504);

                var
                info = f_1490_20481_20503(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20524, 20531);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20552, 20634);

                    s_cache[info] = f_1490_20568_20633(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20665, 20677);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 20339, 20688);

                System.Reflection.MethodInfo?
                f_1490_20481_20503(System.Action<T0, T1, T2, T3, T4, T5, T6, T7>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20481, 20503);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7>
                f_1490_20568_20633(System.Action<T0, T1, T2, T3, T4, T5, T6, T7>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20568, 20633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 20339, 20688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 20339, 20688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodInfo CacheAction<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1490, 20700, 21061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20839, 20873);

                var
                info = f_1490_20850_20872(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20893, 20900);
                lock (s_cache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 20921, 21007);

                    s_cache[info] = f_1490_20937_21006(method);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21038, 21050);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1490, 20700, 21061);

                System.Reflection.MethodInfo?
                f_1490_20850_20872(System.Action<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20850, 20872);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                f_1490_20937_21006(System.Action<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                target)
                {
                    var return_v = new System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 20937, 21006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 20700, 21061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 20700, 21061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal sealed class ActionCallInstruction : CallInstruction
    {
        private readonly Action _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 21227, 21266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21233, 21264);

                    return f_1490_21240_21263(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 21227, 21266);

                    System.Reflection.MethodInfo?
                    f_1490_21240_21263(System.Action
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 21240, 21263);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21193, 21268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21193, 21268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 21316, 21333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21322, 21331);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 21316, 21333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21280, 21335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21280, 21335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 21347, 21434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21175, 21182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21406, 21423);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 21347, 21434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21347, 21434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21347, 21434);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 21446, 21576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21175, 21182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21509, 21565);

                _target = (Action)f_1490_21527_21564(target, typeof(Action));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 21446, 21576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21446, 21576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21446, 21576);
            }
        }

        public override object Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 21588, 21682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21635, 21645);

                f_1490_21635_21644(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21659, 21671);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 21588, 21682);

                int
                f_1490_21635_21644(System.Management.Automation.Interpreter.ActionCallInstruction
                this_param)
                {
                    this_param._target();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 21635, 21644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21588, 21682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21588, 21682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 21694, 21837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21757, 21767);

                f_1490_21757_21766(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21781, 21803);

                frame.StackIndex -= 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21817, 21826);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 21694, 21837);

                int
                f_1490_21757_21766(System.Management.Automation.Interpreter.ActionCallInstruction
                this_param)
                {
                    this_param._target();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 21757, 21766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21694, 21837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21694, 21837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ActionCallInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1490, 21078, 21844);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1490, 21078, 21844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21078, 21844);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1490, 21078, 21844);

        System.Delegate
        f_1490_21527_21564(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 21527, 21564);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0> : CallInstruction
    {
        private readonly Action<T0> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22009, 22048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22015, 22046);

                    return f_1490_22022_22045(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22009, 22048);

                    System.Reflection.MethodInfo?
                    f_1490_22022_22045(System.Action<T0>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 22022, 22045);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 21975, 22050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 21975, 22050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22098, 22115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22104, 22113);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22098, 22115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22062, 22117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22062, 22117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 22129, 22220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21957, 21964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22192, 22209);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 22129, 22220);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22129, 22220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22129, 22220);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 22232, 22370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 21957, 21964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22295, 22359);

                _target = (Action<T0>)f_1490_22317_22358(target, typeof(Action<T0>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 22232, 22370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22232, 22370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22232, 22370);
            }
        }

        public override object Invoke(object arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22382, 22524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22440, 22487);

                f_1490_22440_22486(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 22448, 22460) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 22463, 22471)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 22474, 22485))) ? (T0)arg0 : default(T0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22501, 22513);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22382, 22524);

                int
                f_1490_22440_22486(System.Management.Automation.Interpreter.ActionCallInstruction<T0>
                this_param, T0
                obj)
                {
                    this_param._target(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 22440, 22486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22382, 22524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22382, 22524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22536, 22715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22599, 22645);

                f_1490_22599_22644(this, frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22659, 22681);

                frame.StackIndex -= 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22695, 22704);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22536, 22715);

                int
                f_1490_22599_22644(System.Management.Automation.Interpreter.ActionCallInstruction<T0>
                this_param, object
                obj)
                {
                    this_param._target((T0)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 22599, 22644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22536, 22715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22536, 22715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_22317_22358(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 22317, 22358);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1> : CallInstruction
    {
        private readonly Action<T0, T1> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22895, 22934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22901, 22932);

                    return f_1490_22908_22931(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22895, 22934);

                    System.Reflection.MethodInfo?
                    f_1490_22908_22931(System.Action<T0, T1>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 22908, 22931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22861, 22936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22861, 22936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 22984, 23001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22990, 22999);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 22984, 23001);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 22948, 23003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 22948, 23003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 23015, 23110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22843, 22850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23082, 23099);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 23015, 23110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23015, 23110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23015, 23110);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 23122, 23268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 22843, 22850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23185, 23257);

                _target = (Action<T0, T1>)f_1490_23211_23256(target, typeof(Action<T0, T1>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 23122, 23268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23122, 23268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23122, 23268);
            }
        }

        public override object Invoke(object arg0, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 23280, 23474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23351, 23437);

                f_1490_23351_23436(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 23359, 23371) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 23374, 23382)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 23385, 23396))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 23398, 23410) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 23413, 23421)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 23424, 23435))) ? (T1)arg1 : default(T1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23451, 23463);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 23280, 23474);

                int
                f_1490_23351_23436(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1>
                this_param, T0
                arg1, T1
                arg2)
                {
                    this_param._target(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 23351, 23436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23280, 23474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23280, 23474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 23486, 23703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23549, 23633);

                f_1490_23549_23632(this, frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23647, 23669);

                frame.StackIndex -= 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23683, 23692);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 23486, 23703);

                int
                f_1490_23549_23632(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1>
                this_param, object
                arg1, object
                arg2)
                {
                    this_param._target((T0)arg1, (T1)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 23549, 23632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23486, 23703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23486, 23703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_23211_23256(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 23211, 23256);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2> : CallInstruction
    {
        private readonly Action<T0, T1, T2> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 23891, 23930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23897, 23928);

                    return f_1490_23904_23927(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 23891, 23930);

                    System.Reflection.MethodInfo?
                    f_1490_23904_23927(System.Action<T0, T1, T2>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 23904, 23927);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23857, 23932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23857, 23932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 23980, 23997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23986, 23995);

                    return 3;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 23980, 23997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 23944, 23999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 23944, 23999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 24011, 24110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23839, 23846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24082, 24099);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 24011, 24110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 24011, 24110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 24011, 24110);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 24122, 24276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 23839, 23846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24185, 24265);

                _target = (Action<T0, T1, T2>)f_1490_24215_24264(target, typeof(Action<T0, T1, T2>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 24122, 24276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 24122, 24276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 24122, 24276);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 24288, 24534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24372, 24497);

                f_1490_24372_24496(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 24380, 24392) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 24395, 24403)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 24406, 24417))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 24419, 24431) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 24434, 24442)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 24445, 24456))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 24458, 24470) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 24473, 24481)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 24484, 24495))) ? (T2)arg2 : default(T2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24511, 24523);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 24288, 24534);

                int
                f_1490_24372_24496(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3)
                {
                    this_param._target(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 24372, 24496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 24288, 24534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 24288, 24534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 24546, 24801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24609, 24731);

                f_1490_24609_24730(this, frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24745, 24767);

                frame.StackIndex -= 3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24781, 24790);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 24546, 24801);

                int
                f_1490_24609_24730(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2>
                this_param, object
                arg1, object
                arg2, object
                arg3)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 24609, 24730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 24546, 24801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 24546, 24801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_24215_24264(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 24215, 24264);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 24997, 25036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25003, 25034);

                    return f_1490_25010_25033(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 24997, 25036);

                    System.Reflection.MethodInfo?
                    f_1490_25010_25033(System.Action<T0, T1, T2, T3>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 25010, 25033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 24963, 25038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 24963, 25038);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 25086, 25103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25092, 25101);

                    return 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 25086, 25103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 25050, 25105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 25050, 25105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 25117, 25220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24945, 24952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25192, 25209);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 25117, 25220);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 25117, 25220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 25117, 25220);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 25232, 25394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 24945, 24952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25295, 25383);

                _target = (Action<T0, T1, T2, T3>)f_1490_25329_25382(target, typeof(Action<T0, T1, T2, T3>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 25232, 25394);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 25232, 25394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 25232, 25394);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 25406, 25704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25503, 25667);

                f_1490_25503_25666(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 25511, 25523) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 25526, 25534)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 25537, 25548))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 25550, 25562) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 25565, 25573)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 25576, 25587))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 25589, 25601) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 25604, 25612)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 25615, 25626))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 25628, 25640) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 25643, 25651)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 25654, 25665))) ? (T3)arg3 : default(T3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25681, 25693);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 25406, 25704);

                int
                f_1490_25503_25666(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4)
                {
                    this_param._target(arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 25503, 25666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 25406, 25704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 25406, 25704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 25716, 26009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25779, 25939);

                f_1490_25779_25938(this, frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25953, 25975);

                frame.StackIndex -= 4;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 25989, 25998);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 25716, 26009);

                int
                f_1490_25779_25938(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 25779, 25938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 25716, 26009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 25716, 26009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_25329_25382(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 25329, 25382);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3, T4> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3, T4> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 26213, 26252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26219, 26250);

                    return f_1490_26226_26249(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 26213, 26252);

                    System.Reflection.MethodInfo?
                    f_1490_26226_26249(System.Action<T0, T1, T2, T3, T4>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 26226, 26249);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26179, 26254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26179, 26254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 26302, 26319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26308, 26317);

                    return 5;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 26302, 26319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26266, 26321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26266, 26321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3, T4> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 26333, 26440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26161, 26168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26412, 26429);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 26333, 26440);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26333, 26440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26333, 26440);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 26452, 26622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26161, 26168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26515, 26611);

                _target = (Action<T0, T1, T2, T3, T4>)f_1490_26553_26610(target, typeof(Action<T0, T1, T2, T3, T4>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 26452, 26622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26452, 26622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26452, 26622);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 26634, 26984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26744, 26947);

                f_1490_26744_26946(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 26752, 26764) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 26767, 26775)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 26778, 26789))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 26791, 26803) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 26806, 26814)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 26817, 26828))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 26830, 26842) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 26845, 26853)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 26856, 26867))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 26869, 26881) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 26884, 26892)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 26895, 26906))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 26908, 26920) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 26923, 26931)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 26934, 26945))) ? (T4)arg4 : default(T4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 26961, 26973);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 26634, 26984);

                int
                f_1490_26744_26946(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5)
                {
                    this_param._target(arg1, arg2, arg3, arg4, arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 26744, 26946);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26634, 26984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26634, 26984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 26996, 27327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27059, 27257);

                f_1490_27059_27256(this, frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27271, 27293);

                frame.StackIndex -= 5;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27307, 27316);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 26996, 27327);

                int
                f_1490_27059_27256(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 27059, 27256);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 26996, 27327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 26996, 27327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_26553_26610(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 26553, 26610);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3, T4, T5> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3, T4, T5> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 27539, 27578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27545, 27576);

                    return f_1490_27552_27575(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 27539, 27578);

                    System.Reflection.MethodInfo?
                    f_1490_27552_27575(System.Action<T0, T1, T2, T3, T4, T5>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 27552, 27575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 27505, 27580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 27505, 27580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 27628, 27645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27634, 27643);

                    return 6;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 27628, 27645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 27592, 27647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 27592, 27647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3, T4, T5> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 27659, 27770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27487, 27494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27742, 27759);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 27659, 27770);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 27659, 27770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 27659, 27770);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 27782, 27960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27487, 27494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 27845, 27949);

                _target = (Action<T0, T1, T2, T3, T4, T5>)f_1490_27887_27948(target, typeof(Action<T0, T1, T2, T3, T4, T5>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 27782, 27960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 27782, 27960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 27782, 27960);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 27972, 28374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28095, 28337);

                f_1490_28095_28336(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28103, 28115) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28118, 28126)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28129, 28140))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28142, 28154) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28157, 28165)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28168, 28179))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28181, 28193) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28196, 28204)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28207, 28218))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28220, 28232) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28235, 28243)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28246, 28257))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28259, 28271) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28274, 28282)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28285, 28296))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 28298, 28310) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 28313, 28321)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 28324, 28335))) ? (T5)arg5 : default(T5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28351, 28363);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 27972, 28374);

                int
                f_1490_28095_28336(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6)
                {
                    this_param._target(arg1, arg2, arg3, arg4, arg5, arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 28095, 28336);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 27972, 28374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 27972, 28374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 28386, 28755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28449, 28685);

                f_1490_28449_28684(this, frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28699, 28721);

                frame.StackIndex -= 6;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28735, 28744);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 28386, 28755);

                int
                f_1490_28449_28684(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 28449, 28684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 28386, 28755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 28386, 28755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_27887_27948(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 27887, 27948);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3, T4, T5, T6> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 28975, 29014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28981, 29012);

                    return f_1490_28988_29011(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 28975, 29014);

                    System.Reflection.MethodInfo?
                    f_1490_28988_29011(System.Action<T0, T1, T2, T3, T4, T5, T6>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 28988, 29011);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 28941, 29016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 28941, 29016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 29064, 29081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29070, 29079);

                    return 7;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 29064, 29081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 29028, 29083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 29028, 29083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3, T4, T5, T6> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 29095, 29210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28923, 28930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29182, 29199);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 29095, 29210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 29095, 29210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 29095, 29210);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 29222, 29408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 28923, 28930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29285, 29397);

                _target = (Action<T0, T1, T2, T3, T4, T5, T6>)f_1490_29331_29396(target, typeof(Action<T0, T1, T2, T3, T4, T5, T6>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 29222, 29408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 29222, 29408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 29222, 29408);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 29420, 29874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29556, 29837);

                f_1490_29556_29836(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29564, 29576) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29579, 29587)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29590, 29601))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29603, 29615) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29618, 29626)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29629, 29640))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29642, 29654) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29657, 29665)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29668, 29679))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29681, 29693) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29696, 29704)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29707, 29718))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29720, 29732) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29735, 29743)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29746, 29757))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29759, 29771) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29774, 29782)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29785, 29796))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 29798, 29810) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 29813, 29821)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 29824, 29835))) ? (T6)arg6 : default(T6));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29851, 29863);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 29420, 29874);

                int
                f_1490_29556_29836(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7)
                {
                    this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 29556, 29836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 29420, 29874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 29420, 29874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 29886, 30293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 29949, 30223);

                f_1490_29949_30222(this, frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30237, 30259);

                frame.StackIndex -= 7;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30273, 30282);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 29886, 30293);

                int
                f_1490_29949_30222(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 29949, 30222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 29886, 30293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 29886, 30293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_29331_29396(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 29331, 29396);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3, T4, T5, T6, T7> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 30521, 30560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30527, 30558);

                    return f_1490_30534_30557(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 30521, 30560);

                    System.Reflection.MethodInfo?
                    f_1490_30534_30557(System.Action<T0, T1, T2, T3, T4, T5, T6, T7>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 30534, 30557);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 30487, 30562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 30487, 30562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 30610, 30627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30616, 30625);

                    return 8;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 30610, 30627);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 30574, 30629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 30574, 30629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3, T4, T5, T6, T7> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 30641, 30760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30469, 30476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30732, 30749);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 30641, 30760);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 30641, 30760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 30641, 30760);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 30772, 30966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30469, 30476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 30835, 30955);

                _target = (Action<T0, T1, T2, T3, T4, T5, T6, T7>)f_1490_30885_30954(target, typeof(Action<T0, T1, T2, T3, T4, T5, T6, T7>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 30772, 30966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 30772, 30966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 30772, 30966);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 30978, 31484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 31127, 31447);

                f_1490_31127_31446(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31135, 31147) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31150, 31158)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31161, 31172))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31174, 31186) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31189, 31197)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31200, 31211))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31213, 31225) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31228, 31236)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31239, 31250))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31252, 31264) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31267, 31275)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31278, 31289))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31291, 31303) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31306, 31314)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31317, 31328))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31330, 31342) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31345, 31353)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31356, 31367))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31369, 31381) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31384, 31392)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31395, 31406))) ? (T6)arg6 : default(T6), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 31408, 31420) || ((arg7 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 31423, 31431)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 31434, 31445))) ? (T7)arg7 : default(T7));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 31461, 31473);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 30978, 31484);

                int
                f_1490_31127_31446(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7, T7
                arg8)
                {
                    this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 31127, 31446);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 30978, 31484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 30978, 31484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 31496, 31941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 31559, 31871);

                f_1490_31559_31870(this, frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 31885, 31907);

                frame.StackIndex -= 8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 31921, 31930);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 31496, 31941);

                int
                f_1490_31559_31870(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7, (T7)arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 31559, 31870);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 31496, 31941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 31496, 31941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_30885_30954(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 30885, 30954);
            return return_v;
        }

    }
    internal sealed class ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8> : CallInstruction
    {
        private readonly Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 32177, 32216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32183, 32214);

                    return f_1490_32190_32213(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 32177, 32216);

                    System.Reflection.MethodInfo?
                    f_1490_32190_32213(System.Action<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 32190, 32213);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 32143, 32218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 32143, 32218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 32266, 32283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32272, 32281);

                    return 9;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 32266, 32283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 32230, 32285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 32230, 32285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ActionCallInstruction(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 32297, 32420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32125, 32132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32392, 32409);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 32297, 32420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 32297, 32420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 32297, 32420);
            }
        }

        public ActionCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 32432, 32634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32125, 32132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32495, 32623);

                _target = (Action<T0, T1, T2, T3, T4, T5, T6, T7, T8>)f_1490_32549_32622(target, typeof(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 32432, 32634);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 32432, 32634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 32432, 32634);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 32646, 33204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 32808, 33167);

                f_1490_32808_33166(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 32816, 32828) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 32831, 32839)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 32842, 32853))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 32855, 32867) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 32870, 32878)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 32881, 32892))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 32894, 32906) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 32909, 32917)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 32920, 32931))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 32933, 32945) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 32948, 32956)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 32959, 32970))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 32972, 32984) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 32987, 32995)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 32998, 33009))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 33011, 33023) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 33026, 33034)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 33037, 33048))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 33050, 33062) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 33065, 33073)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 33076, 33087))) ? (T6)arg6 : default(T6), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 33089, 33101) || ((arg7 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 33104, 33112)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 33115, 33126))) ? (T7)arg7 : default(T7), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 33128, 33140) || ((arg8 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 33143, 33151)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 33154, 33165))) ? (T8)arg8 : default(T8));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33181, 33193);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 32646, 33204);

                int
                f_1490_32808_33166(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7, T7
                arg8, T8
                arg9)
                {
                    this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 32808, 33166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 32646, 33204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 32646, 33204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 33216, 33699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33279, 33629);

                f_1490_33279_33628(this, frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33643, 33665);

                frame.StackIndex -= 9;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33679, 33688);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 33216, 33699);

                int
                f_1490_33279_33628(System.Management.Automation.Interpreter.ActionCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9)
                {
                    this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7, (T7)arg8, (T8)arg9);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 33279, 33628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 33216, 33699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 33216, 33699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_32549_32622(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 32549, 32622);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<TRet> : CallInstruction
    {
        private readonly Func<TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 33871, 33910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33877, 33908);

                    return f_1490_33884_33907(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 33871, 33910);

                    System.Reflection.MethodInfo?
                    f_1490_33884_33907(System.Func<TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 33884, 33907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 33837, 33912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 33837, 33912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 33960, 33977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33966, 33975);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 33960, 33977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 33924, 33979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 33924, 33979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 33991, 34080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33819, 33826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34052, 34069);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 33991, 34080);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 33991, 34080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 33991, 34080);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 34092, 34228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 33819, 33826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34153, 34217);

                _target = (Func<TRet>)f_1490_34175_34216(target, typeof(Func<TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 34092, 34228);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34092, 34228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34092, 34228);
            }
        }

        public override object Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 34240, 34315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34287, 34304);

                return f_1490_34294_34303(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 34240, 34315);

                TRet
                f_1490_34294_34303(System.Management.Automation.Interpreter.FuncCallInstruction<TRet>
                this_param)
                {
                    var return_v = this_param._target();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 34294, 34303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34240, 34315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34240, 34315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 34327, 34506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34390, 34435);

                frame.Data[frame.StackIndex - 0] = f_1490_34425_34434(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34449, 34472);

                frame.StackIndex -= -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34486, 34495);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 34327, 34506);

                TRet
                f_1490_34425_34434(System.Management.Automation.Interpreter.FuncCallInstruction<TRet>
                this_param)
                {
                    var return_v = this_param._target();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 34425, 34434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34327, 34506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34327, 34506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FuncCallInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1490, 33714, 34513);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1490, 33714, 34513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 33714, 34513);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1490, 33714, 34513);

        System.Delegate
        f_1490_34175_34216(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 34175, 34216);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, TRet> : CallInstruction
    {
        private readonly Func<T0, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 34686, 34725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34692, 34723);

                    return f_1490_34699_34722(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 34686, 34725);

                    System.Reflection.MethodInfo?
                    f_1490_34699_34722(System.Func<T0, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 34699, 34722);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34652, 34727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34652, 34727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 34775, 34792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34781, 34790);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 34775, 34792);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34739, 34794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34739, 34794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 34806, 34899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34634, 34641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34871, 34888);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 34806, 34899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34806, 34899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34806, 34899);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 34911, 35055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34634, 34641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 34972, 35044);

                _target = (Func<T0, TRet>)f_1490_34998_35043(target, typeof(Func<T0, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 34911, 35055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 34911, 35055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 34911, 35055);
            }
        }

        public override object Invoke(object arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 35067, 35190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35125, 35179);

                return f_1490_35132_35178(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 35140, 35152) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 35155, 35163)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 35166, 35177))) ? (T0)arg0 : default(T0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 35067, 35190);

                TRet
                f_1490_35132_35178(System.Management.Automation.Interpreter.FuncCallInstruction<T0, TRet>
                this_param, T0
                arg)
                {
                    var return_v = this_param._target(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 35132, 35178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35067, 35190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35067, 35190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 35202, 35416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35265, 35346);

                frame.Data[frame.StackIndex - 1] = f_1490_35300_35345(this, frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35360, 35382);

                frame.StackIndex -= 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35396, 35405);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 35202, 35416);

                TRet
                f_1490_35300_35345(System.Management.Automation.Interpreter.FuncCallInstruction<T0, TRet>
                this_param, object
                arg)
                {
                    var return_v = this_param._target((T0)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 35300, 35345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35202, 35416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35202, 35416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_34998_35043(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 34998, 35043);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 35604, 35643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35610, 35641);

                    return f_1490_35617_35640(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 35604, 35643);

                    System.Reflection.MethodInfo?
                    f_1490_35617_35640(System.Func<T0, T1, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 35617, 35640);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35570, 35645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35570, 35645);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 35693, 35710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35699, 35708);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 35693, 35710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35657, 35712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35657, 35712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 35724, 35821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35552, 35559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35793, 35810);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 35724, 35821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35724, 35821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35724, 35821);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 35833, 35985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35552, 35559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 35894, 35974);

                _target = (Func<T0, T1, TRet>)f_1490_35924_35973(target, typeof(Func<T0, T1, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 35833, 35985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35833, 35985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35833, 35985);
            }
        }

        public override object Invoke(object arg0, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 35997, 36172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36068, 36161);

                return f_1490_36075_36160(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 36083, 36095) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 36098, 36106)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 36109, 36120))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 36122, 36134) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 36137, 36145)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 36148, 36159))) ? (T1)arg1 : default(T1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 35997, 36172);

                TRet
                f_1490_36075_36160(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, TRet>
                this_param, T0
                arg1, T1
                arg2)
                {
                    var return_v = this_param._target(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 36075, 36160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 35997, 36172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 35997, 36172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 36184, 36436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36247, 36366);

                frame.Data[frame.StackIndex - 2] = f_1490_36282_36365(this, frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36380, 36402);

                frame.StackIndex -= 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36416, 36425);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 36184, 36436);

                TRet
                f_1490_36282_36365(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, TRet>
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 36282, 36365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 36184, 36436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 36184, 36436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_35924_35973(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 35924, 35973);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 36632, 36671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36638, 36669);

                    return f_1490_36645_36668(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 36632, 36671);

                    System.Reflection.MethodInfo?
                    f_1490_36645_36668(System.Func<T0, T1, T2, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 36645, 36668);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 36598, 36673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 36598, 36673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 36721, 36738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36727, 36736);

                    return 3;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 36721, 36738);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 36685, 36740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 36685, 36740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 36752, 36853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36580, 36587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36825, 36842);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 36752, 36853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 36752, 36853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 36752, 36853);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 36865, 37025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36580, 36587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 36926, 37014);

                _target = (Func<T0, T1, T2, TRet>)f_1490_36960_37013(target, typeof(Func<T0, T1, T2, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 36865, 37025);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 36865, 37025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 36865, 37025);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 37037, 37264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37121, 37253);

                return f_1490_37128_37252(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 37136, 37148) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 37151, 37159)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 37162, 37173))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 37175, 37187) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 37190, 37198)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 37201, 37212))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 37214, 37226) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 37229, 37237)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 37240, 37251))) ? (T2)arg2 : default(T2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 37037, 37264);

                TRet
                f_1490_37128_37252(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3)
                {
                    var return_v = this_param._target(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 37128, 37252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 37037, 37264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 37037, 37264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 37276, 37566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37339, 37496);

                frame.Data[frame.StackIndex - 3] = f_1490_37374_37495(this, frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37510, 37532);

                frame.StackIndex -= 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37546, 37555);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 37276, 37566);

                TRet
                f_1490_37374_37495(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 37374, 37495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 37276, 37566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 37276, 37566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_36960_37013(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 36960, 37013);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 37770, 37809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37776, 37807);

                    return f_1490_37783_37806(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 37770, 37809);

                    System.Reflection.MethodInfo?
                    f_1490_37783_37806(System.Func<T0, T1, T2, T3, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 37783, 37806);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 37736, 37811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 37736, 37811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 37859, 37876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37865, 37874);

                    return 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 37859, 37876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 37823, 37878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 37823, 37878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 37890, 37995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37718, 37725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37967, 37984);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 37890, 37995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 37890, 37995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 37890, 37995);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 38007, 38175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 37718, 37725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38068, 38164);

                _target = (Func<T0, T1, T2, T3, TRet>)f_1490_38106_38163(target, typeof(Func<T0, T1, T2, T3, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 38007, 38175);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 38007, 38175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 38007, 38175);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 38187, 38466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38284, 38455);

                return f_1490_38291_38454(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 38299, 38311) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 38314, 38322)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 38325, 38336))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 38338, 38350) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 38353, 38361)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 38364, 38375))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 38377, 38389) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 38392, 38400)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 38403, 38414))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 38416, 38428) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 38431, 38439)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 38442, 38453))) ? (T3)arg3 : default(T3));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 38187, 38466);

                TRet
                f_1490_38291_38454(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 38291, 38454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 38187, 38466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 38187, 38466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 38478, 38806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38541, 38736);

                frame.Data[frame.StackIndex - 4] = f_1490_38576_38735(this, frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38750, 38772);

                frame.StackIndex -= 3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38786, 38795);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 38478, 38806);

                TRet
                f_1490_38576_38735(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 38576, 38735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 38478, 38806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 38478, 38806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_38106_38163(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 38106, 38163);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 39018, 39057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39024, 39055);

                    return f_1490_39031_39054(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 39018, 39057);

                    System.Reflection.MethodInfo?
                    f_1490_39031_39054(System.Func<T0, T1, T2, T3, T4, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 39031, 39054);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 38984, 39059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 38984, 39059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 39107, 39124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39113, 39122);

                    return 5;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 39107, 39124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 39071, 39126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 39071, 39126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 39138, 39247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38966, 38973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39219, 39236);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 39138, 39247);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 39138, 39247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 39138, 39247);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 39259, 39435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 38966, 38973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39320, 39424);

                _target = (Func<T0, T1, T2, T3, T4, TRet>)f_1490_39362_39423(target, typeof(Func<T0, T1, T2, T3, T4, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 39259, 39435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 39259, 39435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 39259, 39435);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 39447, 39778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39557, 39767);

                return f_1490_39564_39766(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 39572, 39584) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 39587, 39595)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 39598, 39609))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 39611, 39623) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 39626, 39634)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 39637, 39648))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 39650, 39662) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 39665, 39673)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 39676, 39687))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 39689, 39701) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 39704, 39712)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 39715, 39726))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 39728, 39740) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 39743, 39751)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 39754, 39765))) ? (T4)arg4 : default(T4));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 39447, 39778);

                TRet
                f_1490_39564_39766(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4, arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 39564, 39766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 39447, 39778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 39447, 39778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 39790, 40156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 39853, 40086);

                frame.Data[frame.StackIndex - 5] = f_1490_39888_40085(this, frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40100, 40122);

                frame.StackIndex -= 4;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40136, 40145);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 39790, 40156);

                TRet
                f_1490_39888_40085(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 39888, 40085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 39790, 40156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 39790, 40156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_39362_39423(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 39362, 39423);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, T5, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 40376, 40415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40382, 40413);

                    return f_1490_40389_40412(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 40376, 40415);

                    System.Reflection.MethodInfo?
                    f_1490_40389_40412(System.Func<T0, T1, T2, T3, T4, T5, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 40389, 40412);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 40342, 40417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 40342, 40417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 40465, 40482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40471, 40480);

                    return 6;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 40465, 40482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 40429, 40484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 40429, 40484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, T5, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 40496, 40609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40324, 40331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40581, 40598);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 40496, 40609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 40496, 40609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 40496, 40609);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 40621, 40805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40324, 40331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40682, 40794);

                _target = (Func<T0, T1, T2, T3, T4, T5, TRet>)f_1490_40728_40793(target, typeof(Func<T0, T1, T2, T3, T4, T5, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 40621, 40805);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 40621, 40805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 40621, 40805);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 40817, 41200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 40940, 41189);

                return f_1490_40947_41188(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 40955, 40967) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 40970, 40978)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 40981, 40992))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 40994, 41006) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 41009, 41017)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 41020, 41031))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 41033, 41045) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 41048, 41056)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 41059, 41070))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 41072, 41084) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 41087, 41095)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 41098, 41109))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 41111, 41123) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 41126, 41134)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 41137, 41148))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 41150, 41162) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 41165, 41173)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 41176, 41187))) ? (T5)arg5 : default(T5));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 40817, 41200);

                TRet
                f_1490_40947_41188(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4, arg5, arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 40947, 41188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 40817, 41200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 40817, 41200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 41212, 41616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41275, 41546);

                frame.Data[frame.StackIndex - 6] = f_1490_41310_41545(this, frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41560, 41582);

                frame.StackIndex -= 5;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41596, 41605);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 41212, 41616);

                TRet
                f_1490_41310_41545(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 41310, 41545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 41212, 41616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 41212, 41616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_40728_40793(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 40728, 40793);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, T5, T6, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 41844, 41883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41850, 41881);

                    return f_1490_41857_41880(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 41844, 41883);

                    System.Reflection.MethodInfo?
                    f_1490_41857_41880(System.Func<T0, T1, T2, T3, T4, T5, T6, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 41857, 41880);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 41810, 41885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 41810, 41885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 41933, 41950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41939, 41948);

                    return 7;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 41933, 41950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 41897, 41952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 41897, 41952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, T5, T6, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 41964, 42081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41792, 41799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 42053, 42070);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 41964, 42081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 41964, 42081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 41964, 42081);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 42093, 42285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 41792, 41799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 42154, 42274);

                _target = (Func<T0, T1, T2, T3, T4, T5, T6, TRet>)f_1490_42204_42273(target, typeof(Func<T0, T1, T2, T3, T4, T5, T6, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 42093, 42285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 42093, 42285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 42093, 42285);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 42297, 42732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 42433, 42721);

                return f_1490_42440_42720(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42448, 42460) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42463, 42471)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42474, 42485))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42487, 42499) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42502, 42510)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42513, 42524))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42526, 42538) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42541, 42549)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42552, 42563))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42565, 42577) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42580, 42588)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42591, 42602))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42604, 42616) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42619, 42627)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42630, 42641))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42643, 42655) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42658, 42666)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42669, 42680))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 42682, 42694) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 42697, 42705)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 42708, 42719))) ? (T6)arg6 : default(T6));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 42297, 42732);

                TRet
                f_1490_42440_42720(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 42440, 42720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 42297, 42732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 42297, 42732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 42744, 43186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 42807, 43116);

                frame.Data[frame.StackIndex - 7] = f_1490_42842_43115(this, frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43130, 43152);

                frame.StackIndex -= 6;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43166, 43175);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 42744, 43186);

                TRet
                f_1490_42842_43115(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 42842, 43115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 42744, 43186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 42744, 43186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_42204_42273(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 42204, 42273);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 43422, 43461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43428, 43459);

                    return f_1490_43435_43458(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 43422, 43461);

                    System.Reflection.MethodInfo?
                    f_1490_43435_43458(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 43435, 43458);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 43388, 43463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 43388, 43463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 43511, 43528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43517, 43526);

                    return 8;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 43511, 43528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 43475, 43530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 43475, 43530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 43542, 43663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43370, 43377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43635, 43652);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 43542, 43663);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 43542, 43663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 43542, 43663);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 43675, 43875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43370, 43377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 43736, 43864);

                _target = (Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet>)f_1490_43790_43863(target, typeof(Func<T0, T1, T2, T3, T4, T5, T6, T7, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 43675, 43875);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 43675, 43875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 43675, 43875);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 43887, 44374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 44036, 44363);

                return f_1490_44043_44362(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44051, 44063) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44066, 44074)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44077, 44088))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44090, 44102) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44105, 44113)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44116, 44127))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44129, 44141) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44144, 44152)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44155, 44166))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44168, 44180) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44183, 44191)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44194, 44205))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44207, 44219) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44222, 44230)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44233, 44244))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44246, 44258) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44261, 44269)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44272, 44283))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44285, 44297) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44300, 44308)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44311, 44322))) ? (T6)arg6 : default(T6), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 44324, 44336) || ((arg7 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 44339, 44347)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 44350, 44361))) ? (T7)arg7 : default(T7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 43887, 44374);

                TRet
                f_1490_44043_44362(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7, T7
                arg8)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 44043, 44362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 43887, 44374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 43887, 44374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 44386, 44866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 44449, 44796);

                frame.Data[frame.StackIndex - 8] = f_1490_44484_44795(this, frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 44810, 44832);

                frame.StackIndex -= 7;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 44846, 44855);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 44386, 44866);

                TRet
                f_1490_44484_44795(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7, (T7)arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 44484, 44795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 44386, 44866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 44386, 44866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_43790_43863(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 43790, 43863);
            return return_v;
        }

    }
    internal sealed class FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet> : CallInstruction
    {
        private readonly Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet> _target;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 45110, 45149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45116, 45147);

                    return f_1490_45123_45146(_target);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 45110, 45149);

                    System.Reflection.MethodInfo?
                    f_1490_45123_45146(System.Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                    del)
                    {
                        var return_v = del.GetMethodInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 45123, 45146);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 45076, 45151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 45076, 45151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 45199, 45216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45205, 45214);

                    return 9;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 45199, 45216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 45163, 45218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 45163, 45218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FuncCallInstruction(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet> target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 45230, 45355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45058, 45065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45327, 45344);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 45230, 45355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 45230, 45355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 45230, 45355);
            }
        }

        public FuncCallInstruction(MethodInfo target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1490, 45367, 45575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45058, 45065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45428, 45564);

                _target = (Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>)f_1490_45486_45563(target, typeof(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1490, 45367, 45575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 45367, 45575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 45367, 45575);
            }
        }

        public override object Invoke(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 45587, 46126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 45749, 46115);

                return f_1490_45756_46114(this, (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45764, 45776) || ((arg0 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45779, 45787)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45790, 45801))) ? (T0)arg0 : default(T0), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45803, 45815) || ((arg1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45818, 45826)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45829, 45840))) ? (T1)arg1 : default(T1), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45842, 45854) || ((arg2 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45857, 45865)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45868, 45879))) ? (T2)arg2 : default(T2), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45881, 45893) || ((arg3 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45896, 45904)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45907, 45918))) ? (T3)arg3 : default(T3), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45920, 45932) || ((arg4 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45935, 45943)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45946, 45957))) ? (T4)arg4 : default(T4), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45959, 45971) || ((arg5 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 45974, 45982)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 45985, 45996))) ? (T5)arg5 : default(T5), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 45998, 46010) || ((arg6 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 46013, 46021)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 46024, 46035))) ? (T6)arg6 : default(T6), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 46037, 46049) || ((arg7 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 46052, 46060)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 46063, 46074))) ? (T7)arg7 : default(T7), (DynAbs.Tracing.TraceSender.Conditional_F1(1490, 46076, 46088) || ((arg8 != null && DynAbs.Tracing.TraceSender.Conditional_F2(1490, 46091, 46099)) || DynAbs.Tracing.TraceSender.Conditional_F3(1490, 46102, 46113))) ? (T8)arg8 : default(T8));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 45587, 46126);

                TRet
                f_1490_45756_46114(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                this_param, T0
                arg1, T1
                arg2, T2
                arg3, T3
                arg4, T4
                arg5, T5
                arg6, T6
                arg7, T7
                arg8, T8
                arg9)
                {
                    var return_v = this_param._target(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 45756, 46114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 45587, 46126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 45587, 46126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 46138, 46656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 46201, 46586);

                frame.Data[frame.StackIndex - 9] = f_1490_46236_46585(this, frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 46600, 46622);

                frame.StackIndex -= 8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 46636, 46645);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 46138, 46656);

                TRet
                f_1490_46236_46585(System.Management.Automation.Interpreter.FuncCallInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                this_param, object
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9)
                {
                    var return_v = this_param._target((T0)arg1, (T1)arg2, (T2)arg3, (T3)arg4, (T4)arg5, (T5)arg6, (T6)arg7, (T7)arg8, (T8)arg9);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 46236, 46585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 46138, 46656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 46138, 46656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Delegate
        f_1490_45486_45563(System.Reflection.MethodInfo
        this_param, System.Type
        delegateType)
        {
            var return_v = this_param.CreateDelegate(delegateType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 45486, 45563);
            return return_v;
        }

    }
    internal sealed partial class MethodInfoCallInstruction : CallInstruction
    {
        public override object Invoke()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 46756, 46836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 46803, 46825);

                return f_1490_46810_46824(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 46756, 46836);

                object
                f_1490_46810_46824(System.Management.Automation.Interpreter.MethodInfoCallInstruction
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeWorker(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 46810, 46824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 46756, 46836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 46756, 46836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object Invoke(object arg0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 46848, 46943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 46906, 46932);

                return f_1490_46913_46931(this, arg0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 46848, 46943);

                object
                f_1490_46913_46931(System.Management.Automation.Interpreter.MethodInfoCallInstruction
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeWorker(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 46913, 46931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 46848, 46943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 46848, 46943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object Invoke(object arg0, object arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1490, 46955, 47069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 47026, 47058);

                return f_1490_47033_47057(this, arg0, arg1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1490, 46955, 47069);

                object
                f_1490_47033_47057(System.Management.Automation.Interpreter.MethodInfoCallInstruction
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeWorker(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1490, 47033, 47057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1490, 46955, 47069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1490, 46955, 47069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }

    // *** END GENERATED CODE ***

}
