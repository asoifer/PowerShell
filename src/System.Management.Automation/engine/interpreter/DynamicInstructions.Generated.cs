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

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal partial class DynamicInstructionN
    {
        internal static Type GetDynamicInstructionType(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 930, 3043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1011, 1064);

                Type[]
                argTypes = f_1494_1029_1063(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1078, 1116) || true) && (f_1494_1082_1097(argTypes) == 0)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1078, 1116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1104, 1116);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1078, 1116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1130, 1147);

                Type
                genericType
                = default(Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1161, 1209);

                Type[]
                newArgTypes = f_1494_1182_1208(f_1494_1182_1198(argTypes, 1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1223, 2968);

                switch (f_1494_1231_1249(newArgTypes))
                {

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1484, 1527);

                        genericType = typeof(DynamicInstruction<>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1528, 1534);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1560, 1604);

                        genericType = typeof(DynamicInstruction<,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1605, 1611);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1637, 1682);

                        genericType = typeof(DynamicInstruction<,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1683, 1689);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1715, 1761);

                        genericType = typeof(DynamicInstruction<,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1762, 1768);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1794, 1841);

                        genericType = typeof(DynamicInstruction<,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1842, 1848);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1874, 1922);

                        genericType = typeof(DynamicInstruction<,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 1923, 1929);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 1955, 2004);

                        genericType = typeof(DynamicInstruction<,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2005, 2011);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2037, 2087);

                        genericType = typeof(DynamicInstruction<,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2088, 2094);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 9:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2120, 2171);

                        genericType = typeof(DynamicInstruction<,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2172, 2178);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 10:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2205, 2257);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2258, 2264);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 11:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2291, 2344);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2345, 2351);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 12:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2378, 2432);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2433, 2439);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 13:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2466, 2521);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2522, 2528);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 14:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2555, 2611);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2612, 2618);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 15:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2645, 2702);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2703, 2709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    case 16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2736, 2794);

                        genericType = typeof(DynamicInstruction<,,,,,,,,,,,,,,,>);
                        DynAbs.Tracing.TraceSender.TraceBreak(1494, 2795, 2801);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 1223, 2968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2928, 2953);

                        throw f_1494_2934_2952();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 1223, 2968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 2984, 3032);

                return f_1494_2991_3031(genericType, newArgTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 930, 3043);

                System.Type[]
                f_1494_1029_1063(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 1029, 1063);
                    return return_v;
                }


                int
                f_1494_1082_1097(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 1082, 1097);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1494_1182_1198(System.Type[]
                source, int
                count)
                {
                    var return_v = source.Skip<System.Type>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 1182, 1198);
                    return return_v;
                }


                System.Type[]
                f_1494_1182_1208(System.Collections.Generic.IEnumerable<System.Type>
                source)
                {
                    var return_v = source.ToArray<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 1182, 1208);
                    return return_v;
                }


                int
                f_1494_1231_1249(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 1231, 1249);
                    return return_v;
                }


                System.Exception
                f_1494_2934_2952()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 2934, 2952);
                    return return_v;
                }


                System.Type
                f_1494_2991_3031(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 2991, 3031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 930, 3043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 930, 3043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Instruction CreateUntypedInstruction(CallSiteBinder binder, int argCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 3055, 5718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3160, 5707);

                switch (argCount)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3416, 3466);

                        return f_1494_3423_3465(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3492, 3550);

                        return f_1494_3499_3549(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3576, 3642);

                        return f_1494_3583_3641(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3668, 3742);

                        return f_1494_3675_3741(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3768, 3850);

                        return f_1494_3775_3849(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3876, 3966);

                        return f_1494_3883_3965(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 3992, 4090);

                        return f_1494_3999_4089(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4116, 4222);

                        return f_1494_4123_4221(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4248, 4362);

                        return f_1494_4255_4361(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 9:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4388, 4510);

                        return f_1494_4395_4509(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 10:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4537, 4667);

                        return f_1494_4544_4666(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 11:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4694, 4832);

                        return f_1494_4701_4831(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 12:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 4859, 5005);

                        return f_1494_4866_5004(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 13:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 5032, 5186);

                        return f_1494_5039_5185(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 14:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 5213, 5375);

                        return f_1494_5220_5374(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    case 15:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 5402, 5572);

                        return f_1494_5409_5571(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1494, 3160, 5707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 5680, 5692);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1494, 3160, 5707);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 3055, 5718);

                System.Management.Automation.Interpreter.Instruction
                f_1494_3423_3465(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3423, 3465);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3499_3549(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3499, 3549);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3583_3641(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3583, 3641);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3675_3741(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3675, 3741);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3775_3849(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3775, 3849);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3883_3965(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3883, 3965);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_3999_4089(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 3999, 4089);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4123_4221(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4123, 4221);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4255_4361(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4255, 4361);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4395_4509(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4395, 4509);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4544_4666(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4544, 4666);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4701_4831(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4701, 4831);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_4866_5004(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 4866, 5004);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_5039_5185(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 5039, 5185);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_5220_5374(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 5220, 5374);
                    return return_v;
                }


                System.Management.Automation.Interpreter.Instruction
                f_1494_5409_5571(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = DynamicInstruction<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Factory(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 5409, 5571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 3055, 5718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 3055, 5718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<TRet> : Instruction
    {
        private CallSite<Func<CallSite, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 6026, 6191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6098, 6180);

                return f_1494_6105_6179(f_1494_6134_6178(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 6026, 6191);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, TRet>>
                f_1494_6134_6178(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 6134, 6178);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<TRet>
                f_1494_6105_6179(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 6105, 6179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6026, 6191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6026, 6191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 6203, 6305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6008, 6013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6281, 6294);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 6203, 6305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6203, 6305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6203, 6305);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 6353, 6370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6359, 6368);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 6353, 6370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6317, 6372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6317, 6372);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 6420, 6437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6426, 6435);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 6420, 6437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6384, 6439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6384, 6439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 6451, 6640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6514, 6569);

                frame.Data[frame.StackIndex - 0] = f_1494_6549_6568(_site, _site);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6583, 6606);

                frame.StackIndex -= -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6620, 6629);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 6451, 6640);

                TRet
                f_1494_6549_6568(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, TRet>>
                arg)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 6549, 6568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6451, 6640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6451, 6640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 6652, 6762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6701, 6751);

                return "Dynamic(" + f_1494_6721_6744(f_1494_6721_6733(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 6652, 6762);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_6721_6733(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 6721, 6733);
                    return return_v;
                }


                string?
                f_1494_6721_6744(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 6721, 6744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6652, 6762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6652, 6762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1494, 5905, 6769);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1494, 5905, 6769);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 5905, 6769);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1494, 5905, 6769);
    }
    internal class DynamicInstruction<T0, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 6904, 7075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6976, 7064);

                return f_1494_6983_7063(f_1494_7015_7062(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 6904, 7075);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, TRet>>
                f_1494_7015_7062(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 7015, 7062);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, TRet>
                f_1494_6983_7063(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 6983, 7063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 6904, 7075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 6904, 7075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 7087, 7192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 6886, 6891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7168, 7181);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 7087, 7192);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7087, 7192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7087, 7192);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 7240, 7257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7246, 7255);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 7240, 7257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7204, 7259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7204, 7259);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 7307, 7324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7313, 7322);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 7307, 7324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7271, 7326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7271, 7326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 7338, 7528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7401, 7494);

                frame.Data[frame.StackIndex - 1] = f_1494_7436_7493(_site, _site, frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7508, 7517);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 7338, 7528);

                TRet
                f_1494_7436_7493(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, TRet>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 7436, 7493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7338, 7528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7338, 7528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 7540, 7650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7589, 7639);

                return "Dynamic(" + f_1494_7609_7632(f_1494_7609_7621(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 7540, 7650);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_7609_7621(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 7609, 7621);
                    return return_v;
                }


                string?
                f_1494_7609_7632(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 7609, 7632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7540, 7650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7540, 7650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 7798, 7975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7870, 7964);

                return f_1494_7877_7963(f_1494_7912_7962(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 7798, 7975);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, TRet>>
                f_1494_7912_7962(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 7912, 7962);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, TRet>
                f_1494_7877_7963(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 7877, 7963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7798, 7975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7798, 7975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 7987, 8095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 7780, 7785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8071, 8084);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 7987, 8095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 7987, 8095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 7987, 8095);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 8143, 8160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8149, 8158);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 8143, 8160);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8107, 8162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8107, 8162);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 8210, 8227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8216, 8225);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 8210, 8227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8174, 8229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8174, 8229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 8241, 8505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8304, 8435);

                frame.Data[frame.StackIndex - 2] = f_1494_8339_8434(_site, _site, frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8449, 8471);

                frame.StackIndex -= 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8485, 8494);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 8241, 8505);

                TRet
                f_1494_8339_8434(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, TRet>>
                arg1, object
                arg2, object
                arg3)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 8339, 8434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8241, 8505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8241, 8505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 8517, 8627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8566, 8616);

                return "Dynamic(" + f_1494_8586_8609(f_1494_8586_8598(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 8517, 8627);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_8586_8598(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 8586, 8598);
                    return return_v;
                }


                string?
                f_1494_8586_8609(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 8586, 8609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8517, 8627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8517, 8627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 8781, 8964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8853, 8953);

                return f_1494_8860_8952(f_1494_8898_8951(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 8781, 8964);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, TRet>>
                f_1494_8898_8951(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 8898, 8951);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, TRet>
                f_1494_8860_8952(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 8860, 8952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8781, 8964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8781, 8964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 8976, 9087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 8763, 8768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9063, 9076);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 8976, 9087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 8976, 9087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 8976, 9087);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 9135, 9152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9141, 9150);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 9135, 9152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 9099, 9154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 9099, 9154);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 9202, 9219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9208, 9217);

                    return 3;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 9202, 9219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 9166, 9221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 9166, 9221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 9233, 9535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9296, 9465);

                frame.Data[frame.StackIndex - 3] = f_1494_9331_9464(_site, _site, frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9479, 9501);

                frame.StackIndex -= 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9515, 9524);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 9233, 9535);

                TRet
                f_1494_9331_9464(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 9331, 9464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 9233, 9535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 9233, 9535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 9547, 9657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9596, 9646);

                return "Dynamic(" + f_1494_9616_9639(f_1494_9616_9628(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 9547, 9657);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_9616_9628(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 9616, 9628);
                    return return_v;
                }


                string?
                f_1494_9616_9639(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 9616, 9639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 9547, 9657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 9547, 9657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 9817, 10006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9889, 9995);

                return f_1494_9896_9994(f_1494_9937_9993(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 9817, 10006);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, TRet>>
                f_1494_9937_9993(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 9937, 9993);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, TRet>
                f_1494_9896_9994(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 9896, 9994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 9817, 10006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 9817, 10006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 10018, 10132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 9799, 9804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10108, 10121);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 10018, 10132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10018, 10132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10018, 10132);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 10180, 10197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10186, 10195);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 10180, 10197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10144, 10199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10144, 10199);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 10247, 10264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10253, 10262);

                    return 4;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 10247, 10264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10211, 10266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10211, 10266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 10278, 10618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10341, 10548);

                frame.Data[frame.StackIndex - 4] = f_1494_10376_10547(_site, _site, frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10562, 10584);

                frame.StackIndex -= 3;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10598, 10607);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 10278, 10618);

                TRet
                f_1494_10376_10547(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 10376, 10547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10278, 10618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10278, 10618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 10630, 10740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10679, 10729);

                return "Dynamic(" + f_1494_10699_10722(f_1494_10699_10711(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 10630, 10740);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_10699_10711(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 10699, 10711);
                    return return_v;
                }


                string?
                f_1494_10699_10722(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 10699, 10722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10630, 10740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10630, 10740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 10906, 11101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10978, 11090);

                return f_1494_10985_11089(f_1494_11029_11088(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 10906, 11101);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, TRet>>
                f_1494_11029_11088(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 11029, 11088);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, TRet>
                f_1494_10985_11089(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 10985, 11089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 10906, 11101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 10906, 11101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 11113, 11230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 10888, 10893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11206, 11219);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 11113, 11230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 11113, 11230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 11113, 11230);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 11278, 11295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11284, 11293);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 11278, 11295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 11242, 11297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 11242, 11297);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 11345, 11362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11351, 11360);

                    return 5;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 11345, 11362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 11309, 11364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 11309, 11364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 11376, 11754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11439, 11684);

                frame.Data[frame.StackIndex - 5] = f_1494_11474_11683(_site, _site, frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11698, 11720);

                frame.StackIndex -= 4;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11734, 11743);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 11376, 11754);

                TRet
                f_1494_11474_11683(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 11474, 11683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 11376, 11754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 11376, 11754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 11766, 11876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 11815, 11865);

                return "Dynamic(" + f_1494_11835_11858(f_1494_11835_11847(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 11766, 11876);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_11835_11847(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 11835, 11847);
                    return return_v;
                }


                string?
                f_1494_11835_11858(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 11835, 11858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 11766, 11876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 11766, 11876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 12048, 12249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12120, 12238);

                return f_1494_12127_12237(f_1494_12174_12236(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 12048, 12249);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, TRet>>
                f_1494_12174_12236(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 12174, 12236);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, TRet>
                f_1494_12127_12237(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 12127, 12237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12048, 12249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12048, 12249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 12261, 12381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12030, 12035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12357, 12370);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 12261, 12381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12261, 12381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12261, 12381);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 12429, 12446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12435, 12444);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 12429, 12446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12393, 12448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12393, 12448);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 12496, 12513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12502, 12511);

                    return 6;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 12496, 12513);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12460, 12515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12460, 12515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 12527, 12943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12590, 12873);

                frame.Data[frame.StackIndex - 6] = f_1494_12625_12872(_site, _site, frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12887, 12909);

                frame.StackIndex -= 5;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 12923, 12932);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 12527, 12943);

                TRet
                f_1494_12625_12872(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 12625, 12872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12527, 12943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12527, 12943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 12955, 13065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13004, 13054);

                return "Dynamic(" + f_1494_13024_13047(f_1494_13024_13036(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 12955, 13065);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_13024_13036(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 13024, 13036);
                    return return_v;
                }


                string?
                f_1494_13024_13047(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 13024, 13047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 12955, 13065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 12955, 13065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 13243, 13450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13315, 13439);

                return f_1494_13322_13438(f_1494_13372_13437(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 13243, 13450);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>
                f_1494_13372_13437(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 13372, 13437);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>
                f_1494_13322_13438(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 13322, 13438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 13243, 13450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 13243, 13450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 13462, 13585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13225, 13230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13561, 13574);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 13462, 13585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 13462, 13585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 13462, 13585);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 13633, 13650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13639, 13648);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 13633, 13650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 13597, 13652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 13597, 13652);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 13700, 13717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13706, 13715);

                    return 7;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 13700, 13717);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 13664, 13719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 13664, 13719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 13731, 14185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 13794, 14115);

                frame.Data[frame.StackIndex - 7] = f_1494_13829_14114(_site, _site, frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14129, 14151);

                frame.StackIndex -= 6;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14165, 14174);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 13731, 14185);

                TRet
                f_1494_13829_14114(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 13829, 14114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 13731, 14185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 13731, 14185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 14197, 14307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14246, 14296);

                return "Dynamic(" + f_1494_14266_14289(f_1494_14266_14278(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 14197, 14307);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_14266_14278(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 14266, 14278);
                    return return_v;
                }


                string?
                f_1494_14266_14289(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 14266, 14289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14197, 14307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14197, 14307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 14491, 14704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14563, 14693);

                return f_1494_14570_14692(f_1494_14623_14691(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 14491, 14704);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>
                f_1494_14623_14691(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 14623, 14691);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
                f_1494_14570_14692(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 14570, 14692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14491, 14704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14491, 14704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 14716, 14842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14473, 14478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14818, 14831);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 14716, 14842);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14716, 14842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14716, 14842);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 14890, 14907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14896, 14905);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 14890, 14907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14854, 14909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14854, 14909);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 14957, 14974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 14963, 14972);

                    return 8;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 14957, 14974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14921, 14976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14921, 14976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 14988, 15480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15051, 15410);

                frame.Data[frame.StackIndex - 8] = f_1494_15086_15409(_site, _site, frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15424, 15446);

                frame.StackIndex -= 7;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15460, 15469);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 14988, 15480);

                TRet
                f_1494_15086_15409(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>
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
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 15086, 15409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 14988, 15480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 14988, 15480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 15492, 15602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15541, 15591);

                return "Dynamic(" + f_1494_15561_15584(f_1494_15561_15573(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 15492, 15602);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_15561_15573(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 15561, 15573);
                    return return_v;
                }


                string?
                f_1494_15561_15584(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 15561, 15584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 15492, 15602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 15492, 15602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 15792, 16011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15864, 16000);

                return f_1494_15871_15999(f_1494_15927_15998(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 15792, 16011);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>
                f_1494_15927_15998(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 15927, 15998);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
                f_1494_15871_15999(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 15871, 15999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 15792, 16011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 15792, 16011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 16023, 16152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 15774, 15779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16128, 16141);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 16023, 16152);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 16023, 16152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 16023, 16152);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 16200, 16217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16206, 16215);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 16200, 16217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 16164, 16219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 16164, 16219);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 16267, 16284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16273, 16282);

                    return 9;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 16267, 16284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 16231, 16286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 16231, 16286);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 16298, 16828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16361, 16758);

                frame.Data[frame.StackIndex - 9] = f_1494_16396_16757(_site, _site, frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16772, 16794);

                frame.StackIndex -= 8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16808, 16817);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 16298, 16828);

                TRet
                f_1494_16396_16757(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 16396, 16757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 16298, 16828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 16298, 16828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 16840, 16950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 16889, 16939);

                return "Dynamic(" + f_1494_16909_16932(f_1494_16909_16921(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 16840, 16950);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_16909_16921(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 16909, 16921);
                    return return_v;
                }


                string?
                f_1494_16909_16932(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 16909, 16932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 16840, 16950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 16840, 16950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 17146, 17371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17218, 17360);

                return f_1494_17225_17359(f_1494_17284_17358(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 17146, 17371);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>
                f_1494_17284_17358(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 17284, 17358);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>
                f_1494_17225_17359(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 17225, 17359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 17146, 17371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 17146, 17371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 17383, 17515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17128, 17133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17491, 17504);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 17383, 17515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 17383, 17515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 17383, 17515);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 17563, 17580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17569, 17578);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 17563, 17580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 17527, 17582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 17527, 17582);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 17630, 17648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17636, 17646);

                    return 10;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 17630, 17648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 17594, 17650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 17594, 17650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 17662, 18232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 17725, 18162);

                frame.Data[frame.StackIndex - 10] = f_1494_17761_18161(_site, _site, frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18176, 18198);

                frame.StackIndex -= 9;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18212, 18221);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 17662, 18232);

                TRet
                f_1494_17761_18161(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 17761, 18161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 17662, 18232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 17662, 18232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 18244, 18354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18293, 18343);

                return "Dynamic(" + f_1494_18313_18336(f_1494_18313_18325(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 18244, 18354);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_18313_18325(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 18313, 18325);
                    return return_v;
                }


                string?
                f_1494_18313_18336(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 18313, 18336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 18244, 18354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 18244, 18354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 18558, 18791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18630, 18780);

                return f_1494_18637_18779(f_1494_18700_18778(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 18558, 18791);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>
                f_1494_18700_18778(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 18700, 18778);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>
                f_1494_18637_18779(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 18637, 18779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 18558, 18791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 18558, 18791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 18803, 18939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18540, 18545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18915, 18928);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 18803, 18939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 18803, 18939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 18803, 18939);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 18987, 19004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 18993, 19002);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 18987, 19004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 18951, 19006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 18951, 19006);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 19054, 19072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 19060, 19070);

                    return 11;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 19054, 19072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 19018, 19074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 19018, 19074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 19086, 19697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 19149, 19626);

                frame.Data[frame.StackIndex - 11] = f_1494_19185_19625(_site, _site, frame.Data[frame.StackIndex - 11], frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 19640, 19663);

                frame.StackIndex -= 10;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 19677, 19686);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 19086, 19697);

                TRet
                f_1494_19185_19625(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11, object
                arg12)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11, (T10)arg12);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 19185, 19625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 19086, 19697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 19086, 19697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 19709, 19819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 19758, 19808);

                return "Dynamic(" + f_1494_19778_19801(f_1494_19778_19790(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 19709, 19819);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_19778_19790(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 19778, 19790);
                    return return_v;
                }


                string?
                f_1494_19778_19801(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 19778, 19801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 19709, 19819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 19709, 19819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 20031, 20272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20103, 20261);

                return f_1494_20110_20260(f_1494_20177_20259(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 20031, 20272);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>
                f_1494_20177_20259(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 20177, 20259);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>
                f_1494_20110_20260(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 20110, 20260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 20031, 20272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 20031, 20272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 20284, 20424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20013, 20018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20400, 20413);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 20284, 20424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 20284, 20424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 20284, 20424);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 20472, 20489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20478, 20487);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 20472, 20489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 20436, 20491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 20436, 20491);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 20539, 20557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20545, 20555);

                    return 12;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 20539, 20557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 20503, 20559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 20503, 20559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 20571, 21222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 20634, 21151);

                frame.Data[frame.StackIndex - 12] = f_1494_20670_21150(_site, _site, frame.Data[frame.StackIndex - 12], frame.Data[frame.StackIndex - 11], frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21165, 21188);

                frame.StackIndex -= 11;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21202, 21211);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 20571, 21222);

                TRet
                f_1494_20670_21150(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11, object
                arg12, object
                arg13)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11, (T10)arg12, (T11)arg13);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 20670, 21150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 20571, 21222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 20571, 21222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 21234, 21344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21283, 21333);

                return "Dynamic(" + f_1494_21303_21326(f_1494_21303_21315(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 21234, 21344);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_21303_21315(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 21303, 21315);
                    return return_v;
                }


                string?
                f_1494_21303_21326(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 21303, 21326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 21234, 21344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 21234, 21344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 21564, 21813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21636, 21802);

                return f_1494_21643_21801(f_1494_21714_21800(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 21564, 21813);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>
                f_1494_21714_21800(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 21714, 21800);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>
                f_1494_21643_21801(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 21643, 21801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 21564, 21813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 21564, 21813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 21825, 21969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21546, 21551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 21945, 21958);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 21825, 21969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 21825, 21969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 21825, 21969);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 22017, 22034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22023, 22032);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 22017, 22034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 21981, 22036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 21981, 22036);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 22084, 22102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22090, 22100);

                    return 13;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 22084, 22102);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 22048, 22104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 22048, 22104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 22116, 22807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22179, 22736);

                frame.Data[frame.StackIndex - 13] = f_1494_22215_22735(_site, _site, frame.Data[frame.StackIndex - 13], frame.Data[frame.StackIndex - 12], frame.Data[frame.StackIndex - 11], frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22750, 22773);

                frame.StackIndex -= 12;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22787, 22796);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 22116, 22807);

                TRet
                f_1494_22215_22735(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11, object
                arg12, object
                arg13, object
                arg14)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11, (T10)arg12, (T11)arg13, (T12)arg14);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 22215, 22735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 22116, 22807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 22116, 22807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 22819, 22929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 22868, 22918);

                return "Dynamic(" + f_1494_22888_22911(f_1494_22888_22900(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 22819, 22929);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_22888_22900(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 22888, 22900);
                    return return_v;
                }


                string?
                f_1494_22888_22911(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 22888, 22911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 22819, 22929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 22819, 22929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 23157, 23414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23229, 23403);

                return f_1494_23236_23402(f_1494_23311_23401(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 23157, 23414);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>
                f_1494_23311_23401(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 23311, 23401);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>
                f_1494_23236_23402(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 23236, 23402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 23157, 23414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 23157, 23414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 23426, 23574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23139, 23144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23550, 23563);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 23426, 23574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 23426, 23574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 23426, 23574);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 23622, 23639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23628, 23637);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 23622, 23639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 23586, 23641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 23586, 23641);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 23689, 23707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23695, 23705);

                    return 14;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 23689, 23707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 23653, 23709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 23653, 23709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 23721, 24452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 23784, 24381);

                frame.Data[frame.StackIndex - 14] = f_1494_23820_24380(_site, _site, frame.Data[frame.StackIndex - 14], frame.Data[frame.StackIndex - 13], frame.Data[frame.StackIndex - 12], frame.Data[frame.StackIndex - 11], frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 24395, 24418);

                frame.StackIndex -= 13;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 24432, 24441);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 23721, 24452);

                TRet
                f_1494_23820_24380(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11, object
                arg12, object
                arg13, object
                arg14, object
                arg15)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11, (T10)arg12, (T11)arg13, (T12)arg14, (T13)arg15);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 23820, 24380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 23721, 24452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 23721, 24452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 24464, 24574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 24513, 24563);

                return "Dynamic(" + f_1494_24533_24556(f_1494_24533_24545(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 24464, 24574);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_24533_24545(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 24533, 24545);
                    return return_v;
                }


                string?
                f_1494_24533_24556(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 24533, 24556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 24464, 24574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 24464, 24574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal class DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet> : Instruction
    {
        private CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>> _site;

        public static Instruction Factory(CallSiteBinder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1494, 24810, 25075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 24882, 25064);

                return f_1494_24889_25063(f_1494_24968_25062(binder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1494, 24810, 25075);

                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>
                f_1494_24968_25062(System.Runtime.CompilerServices.CallSiteBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>.Create(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 24968, 25062);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>
                f_1494_24889_25063(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>
                site)
                {
                    var return_v = new System.Management.Automation.Interpreter.DynamicInstruction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(site);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 24889, 25063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 24810, 25075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 24810, 25075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicInstruction(CallSite<Func<CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>> site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1494, 25087, 25239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 24792, 24797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 25215, 25228);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1494, 25087, 25239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 25087, 25239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 25087, 25239);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 25287, 25304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 25293, 25302);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 25287, 25304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 25251, 25306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 25251, 25306);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 25354, 25372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 25360, 25370);

                    return 15;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 25354, 25372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 25318, 25374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 25318, 25374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 25386, 26157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 25449, 26086);

                frame.Data[frame.StackIndex - 15] = f_1494_25485_26085(_site, _site, frame.Data[frame.StackIndex - 15], frame.Data[frame.StackIndex - 14], frame.Data[frame.StackIndex - 13], frame.Data[frame.StackIndex - 12], frame.Data[frame.StackIndex - 11], frame.Data[frame.StackIndex - 10], frame.Data[frame.StackIndex - 9], frame.Data[frame.StackIndex - 8], frame.Data[frame.StackIndex - 7], frame.Data[frame.StackIndex - 6], frame.Data[frame.StackIndex - 5], frame.Data[frame.StackIndex - 4], frame.Data[frame.StackIndex - 3], frame.Data[frame.StackIndex - 2], frame.Data[frame.StackIndex - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 26100, 26123);

                frame.StackIndex -= 14;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 26137, 26146);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 25386, 26157);

                TRet
                f_1494_25485_26085(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>
                arg1, object
                arg2, object
                arg3, object
                arg4, object
                arg5, object
                arg6, object
                arg7, object
                arg8, object
                arg9, object
                arg10, object
                arg11, object
                arg12, object
                arg13, object
                arg14, object
                arg15, object
                arg16)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (T0)arg2, (T1)arg3, (T2)arg4, (T3)arg5, (T4)arg6, (T5)arg7, (T6)arg8, (T7)arg9, (T8)arg10, (T9)arg11, (T10)arg12, (T11)arg13, (T12)arg14, (T13)arg15, (T14)arg16);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 25485, 26085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 25386, 26157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 25386, 26157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1494, 26169, 26279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1494, 26218, 26268);

                return "Dynamic(" + f_1494_26238_26261(f_1494_26238_26250(_site)) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1494, 26169, 26279);

                System.Runtime.CompilerServices.CallSiteBinder
                f_1494_26238_26250(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>>
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1494, 26238, 26250);
                    return return_v;
                }


                string?
                f_1494_26238_26261(System.Runtime.CompilerServices.CallSiteBinder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1494, 26238, 26261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1494, 26169, 26279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1494, 26169, 26279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }

    // *** END GENERATED CODE ***


}
