// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Internal;
using System.Reflection;
using System.Runtime.InteropServices;

using COM = System.Runtime.InteropServices.ComTypes;

namespace System.Management.Automation
{
    internal class ComMethodInformation : MethodInformation
    {
        internal readonly Type ReturnType;

        internal readonly int DispId;

        internal readonly COM.INVOKEKIND InvokeKind;

        internal ComMethodInformation(bool hasvarargs, bool hasoptional, ParameterInformation[] arguments, Type returnType, int dispId, COM.INVOKEKIND invokekind)
        : base(f_1379_741_751_C(hasvarargs), hasoptional, arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1379, 566, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 450, 460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 493, 499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 543, 553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 801, 830);

                this.ReturnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 844, 865);

                this.DispId = dispId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 879, 908);

                this.InvokeKind = invokekind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1379, 566, 919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1379, 566, 919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 566, 919);
            }
        }

        static ComMethodInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1379, 355, 926);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1379, 355, 926);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 355, 926);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1379, 355, 926);

        static bool
        f_1379_741_751_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1379, 566, 919);
            return return_v;
        }

    }
    internal class ComMethod
    {
        private Collection<int> _methods;

        private COM.ITypeInfo _typeInfo;

        internal ComMethod(COM.ITypeInfo typeinfo, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1379, 1275, 1413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1083, 1115);
                this._methods = f_1379_1094_1115();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1148, 1157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1517, 1546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1355, 1376);

                _typeInfo = typeinfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1390, 1402);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1379, 1275, 1413);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1379, 1275, 1413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 1275, 1413);
            }
        }

        internal string Name { get; }

        internal void AddFuncDesc(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1379, 1750, 1842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 1811, 1831);

                f_1379_1811_1830(_methods, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1379, 1750, 1842);

                int
                f_1379_1811_1830(System.Collections.ObjectModel.Collection<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 1811, 1830);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1379, 1750, 1842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 1750, 1842);
            }
        }

        internal Collection<string> MethodDefinitions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1379, 1998, 2633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2070, 2123);

                Collection<string>
                result = f_1379_2098_2122()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2139, 2592);
                    foreach (int index in f_1379_2161_2169_I(_methods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1379, 2139, 2592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2203, 2220);

                        IntPtr
                        pFuncDesc
                        = default(IntPtr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2240, 2284);

                        f_1379_2240_2283(
                                        _typeInfo, index, out pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2302, 2374);

                        COM.FUNCDESC
                        funcdesc = f_1379_2326_2373(pFuncDesc)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2394, 2480);

                        string
                        signature = f_1379_2413_2479(_typeInfo, funcdesc, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2498, 2520);

                        f_1379_2498_2519(result, signature);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2540, 2577);

                        f_1379_2540_2576(
                                        _typeInfo, pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1379, 2139, 2592);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1379, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1379, 1, 454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 2608, 2622);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1379, 1998, 2633);

                System.Collections.ObjectModel.Collection<string>
                f_1379_2098_2122()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2098, 2122);
                    return return_v;
                }


                int
                f_1379_2240_2283(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out System.IntPtr
                ppFuncDesc)
                {
                    this_param.GetFuncDesc(index, out ppFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2240, 2283);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.FUNCDESC
                f_1379_2326_2373(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.FUNCDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2326, 2373);
                    return return_v;
                }


                string
                f_1379_2413_2479(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc, bool
                isPropertyPut)
                {
                    var return_v = ComUtil.GetMethodSignatureFromFuncDesc(typeinfo, funcdesc, isPropertyPut);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2413, 2479);
                    return return_v;
                }


                int
                f_1379_2498_2519(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2498, 2519);
                    return 0;
                }


                int
                f_1379_2540_2576(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, System.IntPtr
                pFuncDesc)
                {
                    this_param.ReleaseFuncDesc(pFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2540, 2576);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1379_2161_2169_I(System.Collections.ObjectModel.Collection<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 2161, 2169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1379, 1998, 2633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 1998, 2633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object InvokeMethod(PSMethod method, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1379, 2984, 5335);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 3110, 3132);

                    object[]
                    newarguments
                    = default(object[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 3150, 3226);

                    var
                    methods = f_1379_3164_3225(_typeInfo, _methods, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 3244, 3361);

                    var
                    bestMethod = (ComMethodInformation)f_1379_3283_3360(f_1379_3317_3321(), methods, arguments, out newarguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 3381, 3935);

                    object
                    returnValue = f_1379_3402_3934(method.baseObject as IDispatch, bestMethod.DispId, newarguments, f_1379_3597_3849(bestMethod.parameters, f_1379_3726_3745(newarguments), isPropertySet: false), COM.INVOKEKIND.INVOKE_FUNC)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 3953, 4012);

                    f_1379_3953_4011(newarguments, bestMethod, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4030, 4112);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1379, 4037, 4074) || ((bestMethod.ReturnType != typeof(void) && DynAbs.Tracing.TraceSender.Conditional_F2(1379, 4077, 4088)) || DynAbs.Tracing.TraceSender.Conditional_F3(1379, 4091, 4111))) ? returnValue : f_1379_4091_4111();
                }
                catch (TargetInvocationException te)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1379, 4141, 4851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4273, 4322);

                    var
                    innerCom = f_1379_4288_4305(te) as COMException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4340, 4836) || true) && (innerCom == null || (DynAbs.Tracing.TraceSender.Expression_False(1379, 4344, 4413) || f_1379_4364_4380(innerCom) != ComUtil.DISP_E_MEMBERNOTFOUND))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1379, 4340, 4836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4455, 4539);

                        string
                        message = (DynAbs.Tracing.TraceSender.Conditional_F1(1379, 4472, 4497) || ((f_1379_4472_4489(te) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1379, 4500, 4510)) || DynAbs.Tracing.TraceSender.Conditional_F3(1379, 4513, 4538))) ? f_1379_4500_4510(te) : f_1379_4513_4538(f_1379_4513_4530(te))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4561, 4817);

                        throw f_1379_4567_4816("ComMethodTargetInvocation", te, f_1379_4706_4750(), f_1379_4777_4788(method), f_1379_4790_4806(arguments), message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1379, 4340, 4836);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1379, 4141, 4851);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1379, 4865, 5296);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 4921, 5281) || true) && (f_1379_4925_4935(ce) != ComUtil.DISP_E_UNKNOWNNAME)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1379, 4921, 5281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 5007, 5262);

                        throw f_1379_5013_5261("ComMethodCOMException", ce, f_1379_5148_5192(), f_1379_5219_5230(method), f_1379_5232_5248(arguments), f_1379_5250_5260(ce));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1379, 4921, 5281);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1379, 4865, 5296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1379, 5312, 5324);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1379, 2984, 5335);

                System.Management.Automation.ComMethodInformation[]
                f_1379_3164_3225(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeInfo, System.Collections.ObjectModel.Collection<int>
                methods, bool
                skipLastParameters)
                {
                    var return_v = ComUtil.GetMethodInformationArray(typeInfo, methods, skipLastParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 3164, 3225);
                    return return_v;
                }


                string
                f_1379_3317_3321()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 3317, 3321);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1379_3283_3360(string
                methodName, System.Management.Automation.ComMethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = Adapter.GetBestMethodAndArguments(methodName, (System.Management.Automation.MethodInformation[])methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 3283, 3360);
                    return return_v;
                }


                int
                f_1379_3726_3745(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 3726, 3745);
                    return return_v;
                }


                bool[]
                f_1379_3597_3849(System.Management.Automation.ParameterInformation[]
                parameters, int
                argumentCount, bool
                isPropertySet)
                {
                    var return_v = ComInvoker.GetByRefArray(parameters, argumentCount, isPropertySet: isPropertySet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 3597, 3849);
                    return return_v;
                }


                object
                f_1379_3402_3934(object
                target, int
                dispId, object[]
                args, bool[]
                byRef, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokeKind)
                {
                    var return_v = ComInvoker.Invoke((System.Management.Automation.IDispatch)target, dispId, args, byRef, invokeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 3402, 3934);
                    return return_v;
                }


                int
                f_1379_3953_4011(object[]
                arguments, System.Management.Automation.ComMethodInformation
                methodInformation, object[]
                originalArguments)
                {
                    Adapter.SetReferences(arguments, (System.Management.Automation.MethodInformation)methodInformation, originalArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 3953, 4011);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1379_4091_4111()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4091, 4111);
                    return return_v;
                }


                System.Exception
                f_1379_4288_4305(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4288, 4305);
                    return return_v;
                }


                int
                f_1379_4364_4380(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4364, 4380);
                    return return_v;
                }


                System.Exception
                f_1379_4472_4489(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4472, 4489);
                    return return_v;
                }


                string
                f_1379_4500_4510(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4500, 4510);
                    return return_v;
                }


                System.Exception
                f_1379_4513_4530(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4513, 4530);
                    return return_v;
                }


                string
                f_1379_4513_4538(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4513, 4538);
                    return return_v;
                }


                string
                f_1379_4706_4750()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4706, 4750);
                    return return_v;
                }


                string
                f_1379_4777_4788(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4777, 4788);
                    return return_v;
                }


                int
                f_1379_4790_4806(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4790, 4806);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1379_4567_4816(string
                errorId, System.Reflection.TargetInvocationException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 4567, 4816);
                    return return_v;
                }


                int
                f_1379_4925_4935(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 4925, 4935);
                    return return_v;
                }


                string
                f_1379_5148_5192()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 5148, 5192);
                    return return_v;
                }


                string
                f_1379_5219_5230(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 5219, 5230);
                    return return_v;
                }


                int
                f_1379_5232_5248(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 5232, 5248);
                    return return_v;
                }


                string
                f_1379_5250_5260(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1379, 5250, 5260);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1379_5013_5261(string
                errorId, System.Runtime.InteropServices.COMException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 5013, 5261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1379, 2984, 5335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 2984, 5335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1379, 1018, 5342);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1379, 1018, 5342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1379, 1018, 5342);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1379, 1018, 5342);

        System.Collections.ObjectModel.Collection<int>
        f_1379_1094_1115()
        {
            var return_v = new System.Collections.ObjectModel.Collection<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1379, 1094, 1115);
            return return_v;
        }

    }
}

