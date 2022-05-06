// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using COM = System.Runtime.InteropServices.ComTypes;

namespace System.Management.Automation
{
    internal class ComProperty
    {
        private bool _hasSetter;

        private bool _hasSetterByRef;

        private int _dispId;

        private int _setterIndex;

        private int _setterByRefIndex;

        private int _getterIndex;

        private COM.ITypeInfo _typeInfo;

        internal ComProperty(COM.ITypeInfo typeinfo, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1380, 1029, 1169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 500, 518);
                this._hasSetter = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 542, 565);
                this._hasSetterByRef = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 588, 595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 618, 630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 653, 670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 693, 705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 738, 747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1275, 1304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1329, 1340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3708, 3768);
                this.IsParameterized = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 4454, 4509);
                this.IsGettable = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1111, 1132);

                _typeInfo = typeinfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1146, 1158);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1380, 1029, 1169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 1029, 1169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 1029, 1169);
            }
        }

        internal string Name { get; }

        private Type _cachedType;

        internal Type Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 1490, 3011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1526, 1545);

                    _cachedType = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1565, 2957) || true) && (_cachedType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 1565, 2957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1630, 1661);

                        IntPtr
                        pFuncDesc = IntPtr.Zero
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1737, 1794);

                            f_1380_1737_1793(_typeInfo, f_1380_1759_1777(this), out pFuncDesc);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1820, 1892);

                            COM.FUNCDESC
                            funcdesc = f_1380_1844_1891(pFuncDesc)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 1920, 2664) || true) && (f_1380_1924_1934())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 1920, 2664);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2058, 2129);

                                _cachedType = f_1380_2072_2128(funcdesc.elemdescFunc.tdesc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 1920, 2664);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 1920, 2664);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2324, 2419);

                                ParameterInformation[]
                                parameterInformation = f_1380_2370_2418(funcdesc, false)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2449, 2555);

                                f_1380_2449_2554(f_1380_2468_2495(parameterInformation) == 1, "Invalid number of parameters in a property setter");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2585, 2637);

                                _cachedType = parameterInformation[0].parameterType;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 1920, 2664);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1380, 2709, 2938);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2765, 2915) || true) && (pFuncDesc != IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 2765, 2915);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2851, 2888);

                                f_1380_2851_2887(_typeInfo, pFuncDesc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 2765, 2915);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1380, 2709, 2938);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 1565, 2957);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 2977, 2996);

                    return _cachedType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 1490, 3011);

                    int
                    f_1380_1759_1777(System.Management.Automation.ComProperty
                    this_param)
                    {
                        var return_v = this_param.GetFuncDescIndex();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 1759, 1777);
                        return return_v;
                    }


                    int
                    f_1380_1737_1793(System.Runtime.InteropServices.ComTypes.ITypeInfo
                    this_param, int
                    index, out System.IntPtr
                    ppFuncDesc)
                    {
                        this_param.GetFuncDesc(index, out ppFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 1737, 1793);
                        return 0;
                    }


                    System.Runtime.InteropServices.ComTypes.FUNCDESC
                    f_1380_1844_1891(System.IntPtr
                    ptr)
                    {
                        var return_v = Marshal.PtrToStructure<COM.FUNCDESC>(ptr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 1844, 1891);
                        return return_v;
                    }


                    bool
                    f_1380_1924_1934()
                    {
                        var return_v = IsGettable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 1924, 1934);
                        return return_v;
                    }


                    System.Type
                    f_1380_2072_2128(System.Runtime.InteropServices.ComTypes.TYPEDESC
                    typedesc)
                    {
                        var return_v = ComUtil.GetTypeFromTypeDesc(typedesc);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 2072, 2128);
                        return return_v;
                    }


                    System.Management.Automation.ParameterInformation[]
                    f_1380_2370_2418(System.Runtime.InteropServices.ComTypes.FUNCDESC
                    funcdesc, bool
                    skipLastParameter)
                    {
                        var return_v = ComUtil.GetParameterInformation(funcdesc, skipLastParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 2370, 2418);
                        return return_v;
                    }


                    int
                    f_1380_2468_2495(System.Management.Automation.ParameterInformation[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 2468, 2495);
                        return return_v;
                    }


                    int
                    f_1380_2449_2554(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 2449, 2554);
                        return 0;
                    }


                    int
                    f_1380_2851_2887(System.Runtime.InteropServices.ComTypes.ITypeInfo
                    this_param, System.IntPtr
                    pFuncDesc)
                    {
                        this_param.ReleaseFuncDesc(pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 2851, 2887);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 1447, 3022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 1447, 3022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int GetFuncDescIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 3156, 3584);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3211, 3573) || true) && (f_1380_3215_3225())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 3211, 3573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3259, 3279);

                    return _getterIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 3211, 3573);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 3211, 3573);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3313, 3573) || true) && (_hasSetter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 3313, 3573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3361, 3381);

                        return _setterIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 3313, 3573);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 3313, 3573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3447, 3515);

                        f_1380_3447_3514(_hasSetterByRef, "Invalid property setter type");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 3533, 3558);

                        return _setterByRefIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 3313, 3573);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 3211, 3573);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 3156, 3584);

                bool
                f_1380_3215_3225()
                {
                    var return_v = IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 3215, 3225);
                    return return_v;
                }


                int
                f_1380_3447_3514(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 3447, 3514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 3156, 3584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 3156, 3584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsParameterized { get; private set; }

        internal int ParamCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 4006, 4066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 4042, 4051);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 4006, 4066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 3958, 4077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 3958, 4077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 4241, 4328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 4277, 4313);

                    return _hasSetter | _hasSetterByRef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 4241, 4328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 4192, 4339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 4192, 4339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsGettable { get; private set; }

        internal object GetValue(object target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 4767, 5524);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 4867, 4969);

                    return f_1380_4874_4968(target as IDispatch, _dispId, null, null, COM.INVOKEKIND.INVOKE_PROPERTYGET);
                }
                catch (TargetInvocationException te)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 4998, 5289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5067, 5116);

                    var
                    innerCom = f_1380_5082_5099(te) as COMException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5134, 5274) || true) && (innerCom == null || (DynAbs.Tracing.TraceSender.Expression_False(1380, 5138, 5207) || f_1380_5158_5174(innerCom) != ComUtil.DISP_E_MEMBERNOTFOUND))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 5134, 5274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5249, 5255);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 5134, 5274);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 4998, 5289);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 5303, 5485);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5359, 5470) || true) && (f_1380_5363_5373(ce) != ComUtil.DISP_E_UNKNOWNNAME)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 5359, 5470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5445, 5451);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 5359, 5470);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 5303, 5485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5501, 5513);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 4767, 5524);

                object
                f_1380_4874_4968(object
                target, int
                dispId, object[]
                args, bool[]
                byRef, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokeKind)
                {
                    var return_v = ComInvoker.Invoke((System.Management.Automation.IDispatch)target, dispId, args, byRef, invokeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 4874, 4968);
                    return return_v;
                }


                System.Exception
                f_1380_5082_5099(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 5082, 5099);
                    return return_v;
                }


                int
                f_1380_5158_5174(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 5158, 5174);
                    return return_v;
                }


                int
                f_1380_5363_5373(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 5363, 5373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 4767, 5524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 4767, 5524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetValue(object target, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 5864, 7604);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 5984, 6006);

                    object[]
                    newarguments
                    = default(object[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 6024, 6084);

                    var
                    getterCollection = new Collection<int> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _getterIndex, 1380, 6047, 6083) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 6102, 6186);

                    var
                    methods = f_1380_6116_6185(_typeInfo, getterCollection, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 6204, 6321);

                    var
                    bestMethod = (ComMethodInformation)f_1380_6243_6320(f_1380_6277_6281(), methods, arguments, out newarguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 6341, 6935);

                    object
                    returnValue = f_1380_6362_6934(target as IDispatch, bestMethod.DispId, newarguments, f_1380_6602_6854(bestMethod.parameters, f_1380_6731_6750(newarguments), isPropertySet: false), bestMethod.InvokeKind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 6953, 7012);

                    f_1380_6953_7011(newarguments, bestMethod, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7030, 7049);

                    return returnValue;
                }
                catch (TargetInvocationException te)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 7078, 7369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7147, 7196);

                    var
                    innerCom = f_1380_7162_7179(te) as COMException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7214, 7354) || true) && (innerCom == null || (DynAbs.Tracing.TraceSender.Expression_False(1380, 7218, 7287) || f_1380_7238_7254(innerCom) != ComUtil.DISP_E_MEMBERNOTFOUND))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 7214, 7354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7329, 7335);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 7214, 7354);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 7078, 7369);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 7383, 7565);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7439, 7550) || true) && (f_1380_7443_7453(ce) != ComUtil.DISP_E_UNKNOWNNAME)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 7439, 7550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7525, 7531);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 7439, 7550);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 7383, 7565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7581, 7593);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 5864, 7604);

                System.Management.Automation.ComMethodInformation[]
                f_1380_6116_6185(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeInfo, System.Collections.ObjectModel.Collection<int>
                methods, bool
                skipLastParameters)
                {
                    var return_v = ComUtil.GetMethodInformationArray(typeInfo, methods, skipLastParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 6116, 6185);
                    return return_v;
                }


                string
                f_1380_6277_6281()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 6277, 6281);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1380_6243_6320(string
                methodName, System.Management.Automation.ComMethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = Adapter.GetBestMethodAndArguments(methodName, (System.Management.Automation.MethodInformation[])methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 6243, 6320);
                    return return_v;
                }


                int
                f_1380_6731_6750(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 6731, 6750);
                    return return_v;
                }


                bool[]
                f_1380_6602_6854(System.Management.Automation.ParameterInformation[]
                parameters, int
                argumentCount, bool
                isPropertySet)
                {
                    var return_v = ComInvoker.GetByRefArray(parameters, argumentCount, isPropertySet: isPropertySet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 6602, 6854);
                    return return_v;
                }


                object
                f_1380_6362_6934(object
                target, int
                dispId, object[]
                args, bool[]
                byRef, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokeKind)
                {
                    var return_v = ComInvoker.Invoke((System.Management.Automation.IDispatch)target, dispId, args, byRef, invokeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 6362, 6934);
                    return return_v;
                }


                int
                f_1380_6953_7011(object[]
                arguments, System.Management.Automation.ComMethodInformation
                methodInformation, object[]
                originalArguments)
                {
                    Adapter.SetReferences(arguments, (System.Management.Automation.MethodInformation)methodInformation, originalArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 6953, 7011);
                    return 0;
                }


                System.Exception
                f_1380_7162_7179(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 7162, 7179);
                    return return_v;
                }


                int
                f_1380_7238_7254(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 7238, 7254);
                    return return_v;
                }


                int
                f_1380_7443_7453(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 7443, 7453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 5864, 7604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 5864, 7604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetValue(object target, object setValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 7878, 8831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 7957, 7992);

                object[]
                propValue = new object[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8006, 8114);

                setValue = f_1380_8017_8113(setValue, f_1380_8073_8082(this), f_1380_8084_8112());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8128, 8152);

                propValue[0] = setValue;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8204, 8304);

                    f_1380_8204_8303(target as IDispatch, _dispId, propValue, null, COM.INVOKEKIND.INVOKE_PROPERTYPUT);
                }
                catch (TargetInvocationException te)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 8333, 8624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8402, 8451);

                    var
                    innerCom = f_1380_8417_8434(te) as COMException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8469, 8609) || true) && (innerCom == null || (DynAbs.Tracing.TraceSender.Expression_False(1380, 8473, 8542) || f_1380_8493_8509(innerCom) != ComUtil.DISP_E_MEMBERNOTFOUND))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 8469, 8609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8584, 8590);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 8469, 8609);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 8333, 8624);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 8638, 8820);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8694, 8805) || true) && (f_1380_8698_8708(ce) != ComUtil.DISP_E_UNKNOWNNAME)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 8694, 8805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 8780, 8786);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 8694, 8805);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 8638, 8820);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 7878, 8831);

                System.Type
                f_1380_8073_8082(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 8073, 8082);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1380_8084_8112()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 8084, 8112);
                    return return_v;
                }


                object
                f_1380_8017_8113(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = Adapter.PropertySetAndMethodArgumentConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 8017, 8113);
                    return return_v;
                }


                object
                f_1380_8204_8303(object
                target, int
                dispId, object[]
                args, bool[]
                byRef, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokeKind)
                {
                    var return_v = ComInvoker.Invoke((System.Management.Automation.IDispatch)target, dispId, args, byRef, invokeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 8204, 8303);
                    return return_v;
                }


                System.Exception
                f_1380_8417_8434(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 8417, 8434);
                    return return_v;
                }


                int
                f_1380_8493_8509(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 8493, 8509);
                    return return_v;
                }


                int
                f_1380_8698_8708(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 8698, 8708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 7878, 8831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 7878, 8831);
            }
        }

        internal void SetValue(object target, object setValue, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 9186, 11117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9285, 9307);

                object[]
                newarguments
                = default(object[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9321, 9419);

                var
                setterCollection = new Collection<int> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(1380, 9366, 9381) || ((_hasSetterByRef && DynAbs.Tracing.TraceSender.Conditional_F2(1380, 9384, 9401)) || DynAbs.Tracing.TraceSender.Conditional_F3(1380, 9404, 9416))) ? _setterByRefIndex : _setterIndex, 1380, 9344, 9418) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9433, 9516);

                var
                methods = f_1380_9447_9515(_typeInfo, setterCollection, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9530, 9647);

                var
                bestMethod = (ComMethodInformation)f_1380_9569_9646(f_1380_9603_9607(), methods, arguments, out newarguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9663, 9720);

                var
                finalArguments = new object[f_1380_9695_9714(newarguments) + 1]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9743, 9748);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9734, 9863) || true) && (i < f_1380_9754_9773(newarguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9775, 9778)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 9734, 9863))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 9734, 9863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9812, 9848);

                        finalArguments[i] = newarguments[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1380, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1380, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 9879, 10009);

                finalArguments[f_1380_9894_9913(newarguments)] = f_1380_9917_10008(setValue, f_1380_9973_9977(), f_1380_9979_10007());

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10061, 10511);

                    f_1380_10061_10510(target as IDispatch, bestMethod.DispId, finalArguments, f_1380_10240_10451(bestMethod.parameters, f_1380_10348_10369(finalArguments), isPropertySet: true), bestMethod.InvokeKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10529, 10590);

                    f_1380_10529_10589(finalArguments, bestMethod, arguments);
                }
                catch (TargetInvocationException te)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 10619, 10910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10688, 10737);

                    var
                    innerCom = f_1380_10703_10720(te) as COMException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10755, 10895) || true) && (innerCom == null || (DynAbs.Tracing.TraceSender.Expression_False(1380, 10759, 10828) || f_1380_10779_10795(innerCom) != ComUtil.DISP_E_MEMBERNOTFOUND))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 10755, 10895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10870, 10876);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 10755, 10895);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 10619, 10910);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1380, 10924, 11106);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 10980, 11091) || true) && (f_1380_10984_10994(ce) != ComUtil.DISP_E_UNKNOWNNAME)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 10980, 11091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11066, 11072);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 10980, 11091);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1380, 10924, 11106);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 9186, 11117);

                System.Management.Automation.ComMethodInformation[]
                f_1380_9447_9515(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeInfo, System.Collections.ObjectModel.Collection<int>
                methods, bool
                skipLastParameters)
                {
                    var return_v = ComUtil.GetMethodInformationArray(typeInfo, methods, skipLastParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 9447, 9515);
                    return return_v;
                }


                string
                f_1380_9603_9607()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9603, 9607);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1380_9569_9646(string
                methodName, System.Management.Automation.ComMethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = Adapter.GetBestMethodAndArguments(methodName, (System.Management.Automation.MethodInformation[])methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 9569, 9646);
                    return return_v;
                }


                int
                f_1380_9695_9714(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9695, 9714);
                    return return_v;
                }


                int
                f_1380_9754_9773(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9754, 9773);
                    return return_v;
                }


                int
                f_1380_9894_9913(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9894, 9913);
                    return return_v;
                }


                System.Type
                f_1380_9973_9977()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9973, 9977);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1380_9979_10007()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 9979, 10007);
                    return return_v;
                }


                object
                f_1380_9917_10008(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = Adapter.PropertySetAndMethodArgumentConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 9917, 10008);
                    return return_v;
                }


                int
                f_1380_10348_10369(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 10348, 10369);
                    return return_v;
                }


                bool[]
                f_1380_10240_10451(System.Management.Automation.ParameterInformation[]
                parameters, int
                argumentCount, bool
                isPropertySet)
                {
                    var return_v = ComInvoker.GetByRefArray(parameters, argumentCount, isPropertySet: isPropertySet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 10240, 10451);
                    return return_v;
                }


                object
                f_1380_10061_10510(object
                target, int
                dispId, object[]
                args, bool[]
                byRef, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokeKind)
                {
                    var return_v = ComInvoker.Invoke((System.Management.Automation.IDispatch)target, dispId, args, byRef, invokeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 10061, 10510);
                    return return_v;
                }


                int
                f_1380_10529_10589(object[]
                arguments, System.Management.Automation.ComMethodInformation
                methodInformation, object[]
                originalArguments)
                {
                    Adapter.SetReferences(arguments, (System.Management.Automation.MethodInformation)methodInformation, originalArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 10529, 10589);
                    return 0;
                }


                System.Exception
                f_1380_10703_10720(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 10703, 10720);
                    return return_v;
                }


                int
                f_1380_10779_10795(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 10779, 10795);
                    return return_v;
                }


                int
                f_1380_10984_10994(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 10984, 10994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 9186, 11117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 9186, 11117);
            }
        }

        internal void UpdateFuncDesc(COM.FUNCDESC desc, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 11434, 12559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11517, 11538);

                _dispId = desc.memid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11552, 12548);

                switch (desc.invkind)
                {

                    case COM.INVOKEKIND.INVOKE_PROPERTYGET:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 11552, 12548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11667, 11685);

                        IsGettable = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11707, 11728);

                        _getterIndex = index;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11752, 11868) || true) && (desc.cParams > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 11752, 11868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11822, 11845);

                            IsParameterized = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 11752, 11868);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1380, 11892, 11898);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 11552, 12548);

                    case COM.INVOKEKIND.INVOKE_PROPERTYPUT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 11552, 12548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 11979, 11997);

                        _hasSetter = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12019, 12040);

                        _setterIndex = index;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12064, 12180) || true) && (desc.cParams > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 12064, 12180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12134, 12157);

                            IsParameterized = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 12064, 12180);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1380, 12204, 12210);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 11552, 12548);

                    case COM.INVOKEKIND.INVOKE_PROPERTYPUTREF:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 11552, 12548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12294, 12320);

                        _setterByRefIndex = index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12342, 12365);

                        _hasSetterByRef = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12387, 12503) || true) && (desc.cParams > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 12387, 12503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12457, 12480);

                            IsParameterized = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 12387, 12503);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1380, 12527, 12533);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 11552, 12548);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 11434, 12559);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 11434, 12559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 11434, 12559);
            }
        }

        internal string GetDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 12571, 13178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12627, 12658);

                IntPtr
                pFuncDesc = IntPtr.Zero
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12710, 12767);

                    f_1380_12710_12766(_typeInfo, f_1380_12732_12750(this), out pFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12785, 12857);

                    COM.FUNCDESC
                    funcdesc = f_1380_12809_12856(pFuncDesc)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 12877, 12957);

                    return f_1380_12884_12956(_typeInfo, funcdesc, f_1380_12944_12955_M(!IsGettable));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1380, 12986, 13167);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13026, 13152) || true) && (pFuncDesc != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 13026, 13152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13096, 13133);

                        f_1380_13096_13132(_typeInfo, pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 13026, 13152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1380, 12986, 13167);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 12571, 13178);

                int
                f_1380_12732_12750(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.GetFuncDescIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 12732, 12750);
                    return return_v;
                }


                int
                f_1380_12710_12766(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out System.IntPtr
                ppFuncDesc)
                {
                    this_param.GetFuncDesc(index, out ppFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 12710, 12766);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.FUNCDESC
                f_1380_12809_12856(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.FUNCDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 12809, 12856);
                    return return_v;
                }


                bool
                f_1380_12944_12955_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 12944, 12955);
                    return return_v;
                }


                string
                f_1380_12884_12956(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc, bool
                isPropertyPut)
                {
                    var return_v = ComUtil.GetMethodSignatureFromFuncDesc(typeinfo, funcdesc, isPropertyPut);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 12884, 12956);
                    return return_v;
                }


                int
                f_1380_13096_13132(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, System.IntPtr
                pFuncDesc)
                {
                    this_param.ReleaseFuncDesc(pFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13096, 13132);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 12571, 13178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 12571, 13178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1380, 13341, 13902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13399, 13443);

                StringBuilder
                builder = f_1380_13423_13442()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13457, 13494);

                f_1380_13457_13493(builder, f_1380_13472_13492(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13508, 13528);

                f_1380_13508_13527(builder, " ");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13542, 13630) || true) && (f_1380_13546_13556())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 13542, 13630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13590, 13615);

                    f_1380_13590_13614(builder, "{get} ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 13542, 13630);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13646, 13734) || true) && (_hasSetter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 13646, 13734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13694, 13719);

                    f_1380_13694_13718(builder, "{set} ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 13646, 13734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13750, 13849) || true) && (_hasSetterByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1380, 13750, 13849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13803, 13834);

                    f_1380_13803_13833(builder, "{set by ref}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1380, 13750, 13849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1380, 13865, 13891);

                return f_1380_13872_13890(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1380, 13341, 13902);

                System.Text.StringBuilder
                f_1380_13423_13442()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13423, 13442);
                    return return_v;
                }


                string
                f_1380_13472_13492(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.GetDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13472, 13492);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1380_13457_13493(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13457, 13493);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1380_13508_13527(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13508, 13527);
                    return return_v;
                }


                bool
                f_1380_13546_13556()
                {
                    var return_v = IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1380, 13546, 13556);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1380_13590_13614(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13590, 13614);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1380_13694_13718(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13694, 13718);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1380_13803_13833(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13803, 13833);
                    return return_v;
                }


                string
                f_1380_13872_13890(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1380, 13872, 13890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1380, 13341, 13902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 13341, 13902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1380, 444, 13909);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1380, 444, 13909);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1380, 444, 13909);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1380, 444, 13909);
    }
}
