// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using COM = System.Runtime.InteropServices.ComTypes;

// Disable obsolete warnings about VarEnum and COM-marshaling APIs in CoreCLR
#pragma warning disable 618

namespace System.Management.Automation
{
    internal static class ComInvoker
    {
        private const int
        DISP_E_EXCEPTION = unchecked((int)0x80020009)
        ;

        private const int
        LCID_DEFAULT = 0x0409
        ;

        private const int
        DISPID_PROPERTYPUT = -3
        ;

        private static readonly Guid s_IID_NULL;

        private static readonly int s_variantSize;

        private static unsafe void MakeByRefVariant(IntPtr srcVariantPtr, IntPtr destVariantPtr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1378, 1471, 3578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 1584, 1625);

                var
                srcVariant = (Variant*)srcVariantPtr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 1639, 1682);

                var
                destVariant = (Variant*)destVariantPtr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 1698, 3457);

                switch ((VarEnum)srcVariant->_typeUnion._vt)
                {

                    case VarEnum.VT_EMPTY:
                    case VarEnum.VT_NULL:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 1698, 3457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2051, 2119);

                        destVariant->_typeUnion._unionTypes._byref = f_1378_2096_2118(srcVariant);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2141, 2225);

                        destVariant->_typeUnion._vt = (ushort)VarEnum.VT_VARIANT | (ushort)VarEnum.VT_BYREF;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2247, 2254);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 1698, 3457);

                    case VarEnum.VT_RECORD:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 1698, 3457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2402, 2507);

                        destVariant->_typeUnion._unionTypes._record._record = srcVariant->_typeUnion._unionTypes._record._record;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2529, 2642);

                        destVariant->_typeUnion._unionTypes._record._recordInfo = srcVariant->_typeUnion._unionTypes._record._recordInfo;
                        DynAbs.Tracing.TraceSender.TraceBreak(1378, 2664, 2670);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 1698, 3457);

                    case VarEnum.VT_VARIANT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 1698, 3457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2736, 2804);

                        destVariant->_typeUnion._unionTypes._byref = f_1378_2781_2803(srcVariant);
                        DynAbs.Tracing.TraceSender.TraceBreak(1378, 2826, 2832);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 1698, 3457);

                    case VarEnum.VT_DECIMAL:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 1698, 3457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 2898, 2979);

                        destVariant->_typeUnion._unionTypes._byref = f_1378_2943_2978(&(srcVariant->_decimal));
                        DynAbs.Tracing.TraceSender.TraceBreak(1378, 3001, 3007);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 1698, 3457);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 1698, 3457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 3315, 3414);

                        destVariant->_typeUnion._unionTypes._byref = f_1378_3360_3413(&(srcVariant->_typeUnion._unionTypes._i4));
                        DynAbs.Tracing.TraceSender.TraceBreak(1378, 3436, 3442);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 1698, 3457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 3473, 3567);

                destVariant->_typeUnion._vt = (ushort)(srcVariant->_typeUnion._vt | (ushort)VarEnum.VT_BYREF);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1378, 1471, 3578);

                unsafe System.IntPtr
                f_1378_2096_2118(System.Management.Automation.ComInvoker.Variant*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 2096, 2118);
                    return return_v;
                }


                unsafe System.IntPtr
                f_1378_2781_2803(System.Management.Automation.ComInvoker.Variant*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 2781, 2803);
                    return return_v;
                }


                unsafe System.IntPtr
                f_1378_2943_2978(decimal*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 2943, 2978);
                    return return_v;
                }


                unsafe System.IntPtr
                f_1378_3360_3413(int*
                value)
                {
                    var return_v = new System.IntPtr((void*)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 3360, 3413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1378, 1471, 3578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 1471, 3578);
            }
        }

        private static unsafe IntPtr NewVariantArray(int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1378, 3897, 4377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 3978, 4047);

                IntPtr
                variantArray = f_1378_4000_4046(s_variantSize * length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4072, 4077);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4063, 4330) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4091, 4094)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 4063, 4330))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 4063, 4330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4128, 4184);

                        IntPtr
                        currentVarPtr = variantArray + s_variantSize * i
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4202, 4243);

                        var
                        currentVar = (Variant*)currentVarPtr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4261, 4315);

                        currentVar->_typeUnion._vt = (ushort)VarEnum.VT_EMPTY;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 4346, 4366);

                return variantArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1378, 3897, 4377);

                System.IntPtr
                f_1378_4000_4046(int
                cb)
                {
                    var return_v = Marshal.AllocCoTaskMem(cb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 4000, 4046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1378, 3897, 4377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 3897, 4377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool[] GetByRefArray(ParameterInformation[] parameters, int argumentCount, bool isPropertySet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1378, 4868, 5996);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5003, 5090) || true) && (f_1378_5007_5024(parameters) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 5003, 5090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5063, 5075);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 5003, 5090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5106, 5142);

                var
                byRef = new bool[argumentCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5156, 5190);

                int
                argsToProcess = argumentCount
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5204, 5629) || true) && (isPropertySet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 5204, 5629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5533, 5567);

                    argsToProcess = argumentCount - 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5585, 5614);

                    byRef[argsToProcess] = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 5204, 5629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5645, 5820);

                f_1378_5645_5819(f_1378_5664_5681(parameters) >= argsToProcess, "There might be more parameters than argsToProcess due unspecified optional arguments");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5845, 5850);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5836, 5956) || true) && (i < argsToProcess)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5871, 5874)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 5836, 5956))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 5836, 5956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5908, 5941);

                        byRef[i] = parameters[i].isByRef;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 5972, 5985);

                return byRef;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1378, 4868, 5996);

                int
                f_1378_5007_5024(System.Management.Automation.ParameterInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 5007, 5024);
                    return return_v;
                }


                int
                f_1378_5664_5681(System.Management.Automation.ParameterInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 5664, 5681);
                    return return_v;
                }


                int
                f_1378_5645_5819(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 5645, 5819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1378, 4868, 5996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 4868, 5996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Invoke(IDispatch target, int dispId, object[] args, bool[] byRef, COM.INVOKEKIND invokeKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1378, 6487, 14520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 6627, 6714);

                f_1378_6627_6713(target != null, "Caller makes sure an IDispatch object passed in.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 6728, 6905);

                f_1378_6728_6904(args == null || (DynAbs.Tracing.TraceSender.Expression_False(1378, 6747, 6776) || byRef == null) || (DynAbs.Tracing.TraceSender.Expression_False(1378, 6747, 6807) || f_1378_6780_6791(args) == f_1378_6795_6807(byRef)), "If 'args' and 'byRef' are not null, then they should be one-on-one mapping.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 6921, 6967);

                int
                argCount = (DynAbs.Tracing.TraceSender.Conditional_F1(1378, 6936, 6948) || ((args != null && DynAbs.Tracing.TraceSender.Conditional_F2(1378, 6951, 6962)) || DynAbs.Tracing.TraceSender.Conditional_F3(1378, 6965, 6966))) ? f_1378_6951_6962(args) : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 6981, 7036);

                int
                refCount = (DynAbs.Tracing.TraceSender.Conditional_F1(1378, 6996, 7009) || ((byRef != null && DynAbs.Tracing.TraceSender.Conditional_F2(1378, 7012, 7031)) || DynAbs.Tracing.TraceSender.Conditional_F3(1378, 7034, 7035))) ? f_1378_7012_7031(byRef, c => c) : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7050, 7141);

                IntPtr
                variantArgArray = IntPtr.Zero
                ,
                dispIdArray = IntPtr.Zero
                ,
                tmpVariants = IntPtr.Zero
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7231, 8800) || true) && (argCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 7231, 8800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7289, 7333);

                        variantArgArray = f_1378_7307_7332(argCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7357, 7374);

                        int
                        refIndex = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7405, 7410);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7396, 8781) || true) && (i < argCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7426, 7429)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 7396, 8781))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 7396, 8781);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7554, 7589);

                                int
                                actualIndex = argCount - i - 1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7615, 7680);

                                IntPtr
                                varArgPtr = variantArgArray + s_variantSize * actualIndex
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7784, 8758) || true) && (byRef != null && (DynAbs.Tracing.TraceSender.Expression_True(1378, 7788, 7813) && byRef[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 7784, 8758);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 7969, 8136) || true) && (tmpVariants == IntPtr.Zero)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 7969, 8136);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8065, 8105);

                                        tmpVariants = f_1378_8079_8104(refCount);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 7969, 8136);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8251, 8309);

                                    IntPtr
                                    tmpVarPtr = tmpVariants + s_variantSize * refIndex
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8339, 8393);

                                    f_1378_8339_8392(args[i], tmpVarPtr);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8483, 8522);

                                    f_1378_8483_8521(tmpVarPtr, varArgPtr);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8552, 8563);

                                    refIndex++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 7784, 8758);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 7784, 8758);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8677, 8731);

                                    f_1378_8677_8730(args[i], varArgPtr);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 7784, 8758);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 1386);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 1386);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 7231, 8800);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8820, 8859);

                    var
                    paramArray = new COM.DISPPARAMS[1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8877, 8916);

                    paramArray[0].rgvarg = variantArgArray;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8934, 8965);

                    paramArray[0].cArgs = argCount;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 8985, 9845) || true) && (invokeKind == COM.INVOKEKIND.INVOKE_PROPERTYPUT || (DynAbs.Tracing.TraceSender.Expression_False(1378, 8989, 9090) || invokeKind == COM.INVOKEKIND.INVOKE_PROPERTYPUTREF))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 8985, 9845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9235, 9275);

                        dispIdArray = f_1378_9249_9274(4);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9349, 9401);

                        f_1378_9349_9400(dispIdArray, DISPID_PROPERTYPUT);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9425, 9454);

                        paramArray[0].cNamedArgs = 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9476, 9522);

                        paramArray[0].rgdispidNamedArgs = dispIdArray;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 8985, 9845);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 8985, 9845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9729, 9758);

                        paramArray[0].cNamedArgs = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9780, 9826);

                        paramArray[0].rgdispidNamedArgs = IntPtr.Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 8985, 9845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9899, 9935);

                    EXCEPINFO
                    info = default(EXCEPINFO)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 9953, 9974);

                    object
                    result = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 10335, 10360);

                        uint
                        puArgErrNotUsed = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 10382, 10497);

                        f_1378_10382_10496(target, dispId, s_IID_NULL, LCID_DEFAULT, invokeKind, paramArray, out result, out info, out puArgErrNotUsed);
                    }
                    catch (Exception innerException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1378, 10534, 12755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11034, 11061);

                        string
                        exceptionMsg = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11083, 12423) || true) && (f_1378_11087_11109(innerException) == DISP_E_EXCEPTION)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 11083, 12423);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11470, 11523);

                            int
                            code = (DynAbs.Tracing.TraceSender.Conditional_F1(1378, 11481, 11496) || ((info.scode != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1378, 11499, 11509)) || DynAbs.Tracing.TraceSender.Conditional_F3(1378, 11512, 11522))) ? info.scode : info.wCode
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11549, 11629);

                            innerException = f_1378_11566_11610(code, IntPtr.Zero) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1378, 11566, 11628) ?? innerException);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11737, 11991) || true) && (info.bstrDescription != IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 11737, 11991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11834, 11895);

                                exceptionMsg = f_1378_11849_11894(info.bstrDescription);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 11925, 11964);

                                f_1378_11925_11963(info.bstrDescription);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 11737, 11991);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12062, 12215) || true) && (info.bstrSource != IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 12062, 12215);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12154, 12188);

                                f_1378_12154_12187(info.bstrSource);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 12062, 12215);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12243, 12400) || true) && (info.bstrHelpFile != IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 12243, 12400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12337, 12373);

                                f_1378_12337_12372(info.bstrHelpFile);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 12243, 12400);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 11083, 12423);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12447, 12693);

                        var
                        outerException = (DynAbs.Tracing.TraceSender.Conditional_F1(1378, 12468, 12488) || ((exceptionMsg == null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1378, 12538, 12583)) || DynAbs.Tracing.TraceSender.Conditional_F3(1378, 12633, 12692))) ? f_1378_12538_12583(innerException) : f_1378_12633_12692(exceptionMsg, innerException)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12715, 12736);

                        throw outerException;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1378, 10534, 12755);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12835, 13428) || true) && (refCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 12835, 13428);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12902, 12907);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12893, 13409) || true) && (i < argCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 12923, 12926)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 12893, 13409))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 12893, 13409);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13051, 13086);

                                int
                                actualIndex = argCount - i - 1
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13181, 13386) || true) && (byRef != null && (DynAbs.Tracing.TraceSender.Expression_True(1378, 13185, 13210) && byRef[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 13181, 13386);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13268, 13359);

                                    args[i] = f_1378_13278_13358(variantArgArray + s_variantSize * actualIndex);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 13181, 13386);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 517);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 12835, 13428);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13448, 13462);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1378, 13491, 14509);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13583, 13897) || true) && (variantArgArray != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 13583, 13897);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13668, 13673);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13659, 13815) || true) && (i < argCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13689, 13692)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 13659, 13815))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 13659, 13815);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13742, 13792);

                                f_1378_13742_13791(variantArgArray + s_variantSize * i);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 157);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 157);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13839, 13878);

                        f_1378_13839_13877(variantArgArray);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 13583, 13897);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 13959, 14085) || true) && (dispIdArray != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 13959, 14085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14031, 14066);

                        f_1378_14031_14065(dispIdArray);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 13959, 14085);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14192, 14494) || true) && (tmpVariants != IntPtr.Zero)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 14192, 14494);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14273, 14278);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14264, 14416) || true) && (i < refCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14294, 14297)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 14264, 14416))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1378, 14264, 14416);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14347, 14393);

                                f_1378_14347_14392(tmpVariants + s_variantSize * i);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1378, 1, 153);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1378, 1, 153);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 14440, 14475);

                        f_1378_14440_14474(tmpVariants);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1378, 14192, 14494);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1378, 13491, 14509);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1378, 6487, 14520);

                int
                f_1378_6627_6713(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 6627, 6713);
                    return 0;
                }


                int
                f_1378_6780_6791(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 6780, 6791);
                    return return_v;
                }


                int
                f_1378_6795_6807(bool[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 6795, 6807);
                    return return_v;
                }


                int
                f_1378_6728_6904(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 6728, 6904);
                    return 0;
                }


                int
                f_1378_6951_6962(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 6951, 6962);
                    return return_v;
                }


                int
                f_1378_7012_7031(bool[]
                source, System.Func<bool, bool>
                predicate)
                {
                    var return_v = source.Count<bool>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 7012, 7031);
                    return return_v;
                }


                System.IntPtr
                f_1378_7307_7332(int
                length)
                {
                    var return_v = NewVariantArray(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 7307, 7332);
                    return return_v;
                }


                System.IntPtr
                f_1378_8079_8104(int
                length)
                {
                    var return_v = NewVariantArray(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 8079, 8104);
                    return return_v;
                }


                int
                f_1378_8339_8392(object
                obj, System.IntPtr
                pDstNativeVariant)
                {
                    Marshal.GetNativeVariantForObject(obj, pDstNativeVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 8339, 8392);
                    return 0;
                }


                int
                f_1378_8483_8521(System.IntPtr
                srcVariantPtr, System.IntPtr
                destVariantPtr)
                {
                    MakeByRefVariant(srcVariantPtr, destVariantPtr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 8483, 8521);
                    return 0;
                }


                int
                f_1378_8677_8730(object
                obj, System.IntPtr
                pDstNativeVariant)
                {
                    Marshal.GetNativeVariantForObject(obj, pDstNativeVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 8677, 8730);
                    return 0;
                }


                System.IntPtr
                f_1378_9249_9274(int
                cb)
                {
                    var return_v = Marshal.AllocCoTaskMem(cb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 9249, 9274);
                    return return_v;
                }


                int
                f_1378_9349_9400(System.IntPtr
                ptr, int
                val)
                {
                    Marshal.WriteInt32(ptr, val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 9349, 9400);
                    return 0;
                }


                int
                f_1378_10382_10496(System.Management.Automation.IDispatch
                this_param, int
                dispIdMember, System.Guid
                iid, int
                lcid, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                wFlags, System.Runtime.InteropServices.ComTypes.DISPPARAMS[]
                paramArray, out object
                pVarResult, out System.Management.Automation.ComInvoker.EXCEPINFO
                pExcepInfo, out uint
                puArgErr)
                {
                    this_param.Invoke(dispIdMember, iid, lcid, wFlags, paramArray, out pVarResult, out pExcepInfo, out puArgErr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 10382, 10496);
                    return 0;
                }


                int
                f_1378_11087_11109(System.Exception
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1378, 11087, 11109);
                    return return_v;
                }


                System.Exception?
                f_1378_11566_11610(int
                errorCode, System.IntPtr
                errorInfo)
                {
                    var return_v = Marshal.GetExceptionForHR(errorCode, errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 11566, 11610);
                    return return_v;
                }


                string
                f_1378_11849_11894(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStringBSTR(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 11849, 11894);
                    return return_v;
                }


                int
                f_1378_11925_11963(System.IntPtr
                ptr)
                {
                    Marshal.FreeBSTR(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 11925, 11963);
                    return 0;
                }


                int
                f_1378_12154_12187(System.IntPtr
                ptr)
                {
                    Marshal.FreeBSTR(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 12154, 12187);
                    return 0;
                }


                int
                f_1378_12337_12372(System.IntPtr
                ptr)
                {
                    Marshal.FreeBSTR(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 12337, 12372);
                    return 0;
                }


                System.Reflection.TargetInvocationException
                f_1378_12538_12583(System.Exception
                inner)
                {
                    var return_v = new System.Reflection.TargetInvocationException(inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 12538, 12583);
                    return return_v;
                }


                System.Reflection.TargetInvocationException
                f_1378_12633_12692(string
                message, System.Exception
                inner)
                {
                    var return_v = new System.Reflection.TargetInvocationException(message, inner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 12633, 12692);
                    return return_v;
                }


                object?
                f_1378_13278_13358(System.IntPtr
                pSrcNativeVariant)
                {
                    var return_v = Marshal.GetObjectForNativeVariant(pSrcNativeVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 13278, 13358);
                    return return_v;
                }


                int
                f_1378_13742_13791(System.IntPtr
                pVariant)
                {
                    VariantClear(pVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 13742, 13791);
                    return 0;
                }


                int
                f_1378_13839_13877(System.IntPtr
                ptr)
                {
                    Marshal.FreeCoTaskMem(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 13839, 13877);
                    return 0;
                }


                int
                f_1378_14031_14065(System.IntPtr
                ptr)
                {
                    Marshal.FreeCoTaskMem(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 14031, 14065);
                    return 0;
                }


                int
                f_1378_14347_14392(System.IntPtr
                pVariant)
                {
                    VariantClear(pVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 14347, 14392);
                    return 0;
                }


                int
                f_1378_14440_14474(System.IntPtr
                ptr)
                {
                    Marshal.FreeCoTaskMem(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 14440, 14474);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1378, 6487, 14520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 6487, 14520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DllImport("oleaut32.dll")]
        internal static extern void VariantClear(IntPtr pVariant);

        [StructLayout(LayoutKind.Sequential)]
        internal struct EXCEPINFO
        {

            public short wCode;

            public short wReserved;

            public IntPtr bstrSource;

            public IntPtr bstrDescription;

            public IntPtr bstrHelpFile;

            public int dwHelpContext;

            public IntPtr pvReserved;

            public IntPtr pfnDeferredFillIn;

            public int scode;
            static EXCEPINFO()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 15188, 15631);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 15188, 15631);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 15188, 15631);
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct Variant
        {

            [FieldOffset(0)]
            internal TypeUnion _typeUnion;

            [FieldOffset(0)]
            internal Decimal _decimal;

            [StructLayout(LayoutKind.Explicit)]
            internal struct TypeUnion
            {

                [FieldOffset(0)]
                internal ushort _vt;

                [FieldOffset(2)]
                internal ushort _wReserved1;

                [FieldOffset(4)]
                internal ushort _wReserved2;

                [FieldOffset(6)]
                internal ushort _wReserved3;

                [FieldOffset(8)]
                internal UnionTypes _unionTypes;
                static TypeUnion()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 16409, 16909);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 16409, 16909);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 16409, 16909);
                }
            }

            [StructLayout(LayoutKind.Sequential)]
            internal struct Record
            {

                internal IntPtr _record;

                internal IntPtr _recordInfo;
                static Record()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 16925, 17116);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 16925, 17116);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 16925, 17116);
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            internal struct UnionTypes
            {

                [FieldOffset(0)]
                internal sbyte _i1;

                [FieldOffset(0)]
                internal Int16 _i2;

                [FieldOffset(0)]
                internal Int32 _i4;

                [FieldOffset(0)]
                internal Int64 _i8;

                [FieldOffset(0)]
                internal byte _ui1;

                [FieldOffset(0)]
                internal UInt16 _ui2;

                [FieldOffset(0)]
                internal UInt32 _ui4;

                [FieldOffset(0)]
                internal UInt64 _ui8;

                [FieldOffset(0)]
                internal Int32 _int;

                [FieldOffset(0)]
                internal UInt32 _uint;

                [FieldOffset(0)]
                internal Int16 _bool;

                [FieldOffset(0)]
                internal Int32 _error;

                [FieldOffset(0)]
                internal Single _r4;

                [FieldOffset(0)]
                internal double _r8;

                [FieldOffset(0)]
                internal Int64 _cy;

                [FieldOffset(0)]
                internal double _date;

                [FieldOffset(0)]
                internal IntPtr _bstr;

                [FieldOffset(0)]
                internal IntPtr _unknown;

                [FieldOffset(0)]
                internal IntPtr _dispatch;

                [FieldOffset(0)]
                internal IntPtr _pvarVal;

                [FieldOffset(0)]
                internal IntPtr _byref;

                [FieldOffset(0)]
                internal Record _record;
                static UnionTypes()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 17132, 18850);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 17132, 18850);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 17132, 18850);
                }
            }
            static Variant()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 15759, 18861);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 15759, 18861);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 15759, 18861);
            }
        }

        static ComInvoker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1378, 400, 18868);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 531, 576);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 640, 661);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 904, 927);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 1027, 1050);
            s_IID_NULL = f_1378_1040_1050();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1378, 1128, 1169);
            s_variantSize = f_1378_1144_1169();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1378, 400, 18868);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1378, 400, 18868);
        }


        static System.Guid
        f_1378_1040_1050()
        {
            var return_v = new System.Guid();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 1040, 1050);
            return return_v;
        }


        static int
        f_1378_1144_1169()
        {
            var return_v = Marshal.SizeOf<Variant>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1378, 1144, 1169);
            return return_v;
        }

    }
}
