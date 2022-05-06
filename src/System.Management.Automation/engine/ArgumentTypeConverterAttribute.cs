// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal sealed class ArgumentTypeConverterAttribute : ArgumentTransformationAttribute
    {
        internal ArgumentTypeConverterAttribute(params Type[] types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1235, 741, 859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 886, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 826, 848);

                _convertTypes = types;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1235, 741, 859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 741, 859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 741, 859);
            }
        }

        private Type[] _convertTypes;

        internal Type TargetType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1235, 961, 1136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 997, 1121);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1235, 1004, 1025) || ((_convertTypes == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1235, 1056, 1060)) || DynAbs.Tracing.TraceSender.Conditional_F3(1235, 1091, 1120))) ? null
                    : f_1235_1091_1120(_convertTypes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1235, 961, 1136);

                    System.Type
                    f_1235_1091_1120(System.Type[]
                    source)
                    {
                        var return_v = source.LastOrDefault<System.Type>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 1091, 1120);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 912, 1147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 912, 1147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1235, 1159, 1340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1269, 1329);

                return f_1235_1276_1328(this, engineIntrinsics, inputData, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1235, 1159, 1340);

                object
                f_1235_1276_1328(System.Management.Automation.ArgumentTypeConverterAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData, bool
                bindingParameters, bool
                bindingScriptCmdlet)
                {
                    var return_v = this_param.Transform(engineIntrinsics, inputData, bindingParameters, bindingScriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 1276, 1328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 1159, 1340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 1159, 1340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object Transform(EngineIntrinsics engineIntrinsics, object inputData, bool bindingParameters, bool bindingScriptCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1235, 1352, 8369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1505, 1566) || true) && (_convertTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 1505, 1566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1549, 1566);

                    return inputData;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 1505, 1566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1582, 1608);

                object
                result = inputData
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1669, 1674);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1660, 7694) || true) && (i < f_1235_1680_1700(_convertTypes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1702, 1705)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 1660, 7694))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 1660, 7694);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 1747, 4517) || true) && (bindingParameters)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 1747, 4517);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2070, 4494) || true) && (f_1235_2074_2147(_convertTypes[i], typeof(System.Management.Automation.PSReference)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 2070, 4494);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2205, 2217);

                                    object
                                    temp
                                    = default(object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2247, 2287);

                                    PSObject
                                    mshObject = result as PSObject
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2317, 2483) || true) && (mshObject != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 2317, 2483);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2373, 2401);

                                        temp = f_1235_2380_2400(mshObject);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 2317, 2483);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 2317, 2483);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2469, 2483);

                                        temp = result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 2317, 2483);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2515, 2559);

                                    PSReference
                                    reference = temp as PSReference
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2591, 2903) || true) && (reference == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 2591, 2903);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 2678, 2872);

                                        throw f_1235_2684_2871("InvalidCastExceptionReferenceTypeExpected", null, f_1235_2830_2870());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 2591, 2903);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 2070, 4494);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 2070, 4494);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3017, 3029);

                                    object
                                    temp
                                    = default(object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3059, 3099);

                                    PSObject
                                    mshObject = result as PSObject
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3129, 3295) || true) && (mshObject != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 3129, 3295);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3185, 3213);

                                        temp = f_1235_3192_3212(mshObject);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 3129, 3295);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 3129, 3295);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3281, 3295);

                                        temp = result;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 3129, 3295);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3451, 3495);

                                    PSReference
                                    reference = temp as PSReference
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3527, 3670) || true) && (reference != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 3527, 3670);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3614, 3639);

                                        result = f_1235_3623_3638(reference);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 3527, 3670);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 3702, 4467) || true) && (bindingScriptCmdlet && (DynAbs.Tracing.TraceSender.Expression_True(1235, 3706, 3763) && _convertTypes[i] == typeof(string)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 3702, 4467);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 4056, 4085);

                                        temp = f_1235_4063_4084(result);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 4119, 4436) || true) && (temp != null && (DynAbs.Tracing.TraceSender.Expression_True(1235, 4123, 4161) && f_1235_4139_4161(f_1235_4139_4153(temp))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 4119, 4436);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 4235, 4401);

                                            throw f_1235_4241_4400("InvalidCastFromAnyTypeToString", null, f_1235_4349_4399());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 4119, 4436);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 3702, 4467);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 2070, 4494);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 1747, 4517);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 4948, 5130) || true) && (f_1235_4952_5016(_convertTypes[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 4948, 5130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5066, 5107);

                                f_1235_5066_5106(result, _convertTypes[i]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 4948, 5130);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5154, 6463) || true) && (bindingScriptCmdlet)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 5154, 6463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5407, 5520);

                                ParameterCollectionTypeInformation
                                collectionTypeInfo = f_1235_5463_5519(_convertTypes[i])
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5546, 6440) || true) && (f_1235_5550_5592(collectionTypeInfo) != ParameterCollectionType.NotCollection
                                && (DynAbs.Tracing.TraceSender.Expression_True(1235, 5550, 5744) && f_1235_5666_5744(f_1235_5713_5743(collectionTypeInfo))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 5546, 6440);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5802, 5867);

                                    IList
                                    currentValueAsIList = f_1235_5830_5866(result)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5897, 6413) || true) && (currentValueAsIList != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 5897, 6413);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 5994, 6197);
                                            foreach (object val in f_1235_6017_6036_I(currentValueAsIList))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 5994, 6197);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 6110, 6162);

                                                f_1235_6110_6161(val, f_1235_6130_6160(collectionTypeInfo));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 5994, 6197);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1235, 1, 204);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1235, 1, 204);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 5897, 6413);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 5897, 6413);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 6327, 6382);

                                        f_1235_6327_6381(result, f_1235_6350_6380(collectionTypeInfo));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 5897, 6413);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 5546, 6440);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 5154, 6463);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 6487, 6581);

                            result = f_1235_6496_6580(result, _convertTypes[i], f_1235_6551_6579());

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 6914, 7675) || true) && ((!bindingScriptCmdlet) && (DynAbs.Tracing.TraceSender.Expression_True(1235, 6918, 6964) && (!bindingParameters)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 6914, 7675);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 7141, 7652) || true) && (_convertTypes[i] == typeof(ActionPreference))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 7141, 7652);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 7247, 7308);

                                    ActionPreference
                                    resultPreference = (ActionPreference)result
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 7340, 7625) || true) && (resultPreference == ActionPreference.Suspend)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 7340, 7625);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 7454, 7594);

                                        throw f_1235_7460_7593("InvalidActionPreference", null, f_1235_7520_7574(), resultPreference);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 7340, 7625);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 7141, 7652);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 6914, 7675);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1235, 1, 6035);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1235, 1, 6035);
                    }
                }
                catch (PSInvalidCastException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1235, 7723, 7867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 7788, 7852);

                    throw f_1235_7794_7851(f_1235_7838_7847(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1235, 7723, 7867);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8125, 8328) || true) && (bindingParameters || (DynAbs.Tracing.TraceSender.Expression_False(1235, 8129, 8169) || bindingScriptCmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 8125, 8328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8203, 8313);

                    f_1235_8203_8312(inputData, result, f_1235_8260_8311(f_1235_8260_8298(f_1235_8260_8289(engineIntrinsics))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 8125, 8328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8344, 8358);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1235, 1352, 8369);

                int
                f_1235_1680_1700(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 1680, 1700);
                    return return_v;
                }


                bool
                f_1235_2074_2147(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 2074, 2147);
                    return return_v;
                }


                object
                f_1235_2380_2400(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 2380, 2400);
                    return return_v;
                }


                string
                f_1235_2830_2870()
                {
                    var return_v = ExtendedTypeSystem.ReferenceTypeExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 2830, 2870);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1235_2684_2871(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 2684, 2871);
                    return return_v;
                }


                object
                f_1235_3192_3212(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 3192, 3212);
                    return return_v;
                }


                object
                f_1235_3623_3638(System.Management.Automation.PSReference
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 3623, 3638);
                    return return_v;
                }


                object
                f_1235_4063_4084(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 4063, 4084);
                    return return_v;
                }


                System.Type
                f_1235_4139_4153(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 4139, 4153);
                    return return_v;
                }


                bool
                f_1235_4139_4161(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 4139, 4161);
                    return return_v;
                }


                string
                f_1235_4349_4399()
                {
                    var return_v = ExtendedTypeSystem.InvalidCastCannotRetrieveString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 4349, 4399);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1235_4241_4400(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 4241, 4400);
                    return return_v;
                }


                bool
                f_1235_4952_5016(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBoolOrSwitchParameterType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 4952, 5016);
                    return return_v;
                }


                int
                f_1235_5066_5106(object
                value, System.Type
                boolType)
                {
                    CheckBoolValue(value, boolType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 5066, 5106);
                    return 0;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1235_5463_5519(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.ParameterCollectionTypeInformation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 5463, 5519);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1235_5550_5592(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 5550, 5592);
                    return return_v;
                }


                System.Type
                f_1235_5713_5743(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 5713, 5743);
                    return return_v;
                }


                bool
                f_1235_5666_5744(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBoolOrSwitchParameterType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 5666, 5744);
                    return return_v;
                }


                System.Collections.IList
                f_1235_5830_5866(object
                value)
                {
                    var return_v = ParameterBinderBase.GetIList(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 5830, 5866);
                    return return_v;
                }


                System.Type
                f_1235_6130_6160(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 6130, 6160);
                    return return_v;
                }


                int
                f_1235_6110_6161(object
                value, System.Type
                boolType)
                {
                    CheckBoolValue(value, boolType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 6110, 6161);
                    return 0;
                }


                System.Collections.IList
                f_1235_6017_6036_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 6017, 6036);
                    return return_v;
                }


                System.Type
                f_1235_6350_6380(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 6350, 6380);
                    return return_v;
                }


                int
                f_1235_6327_6381(object
                value, System.Type
                boolType)
                {
                    CheckBoolValue(value, boolType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 6327, 6381);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1235_6551_6579()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 6551, 6579);
                    return return_v;
                }


                object
                f_1235_6496_6580(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 6496, 6580);
                    return return_v;
                }


                string
                f_1235_7520_7574()
                {
                    var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 7520, 7574);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1235_7460_7593(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 7460, 7593);
                    return return_v;
                }


                string
                f_1235_7838_7847(System.Management.Automation.PSInvalidCastException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 7838, 7847);
                    return return_v;
                }


                System.Management.Automation.ArgumentTransformationMetadataException
                f_1235_7794_7851(string
                message, System.Management.Automation.PSInvalidCastException
                innerException)
                {
                    var return_v = new System.Management.Automation.ArgumentTransformationMetadataException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 7794, 7851);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1235_8260_8289(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 8260, 8289);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1235_8260_8298(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 8260, 8298);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1235_8260_8311(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 8260, 8311);
                    return return_v;
                }


                int
                f_1235_8203_8312(object
                originalObject, object
                resultObject, System.Management.Automation.PSLanguageMode
                currentLanguageMode)
                {
                    ExecutionContext.PropagateInputSource(originalObject, resultObject, currentLanguageMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8203, 8312);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 1352, 8369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 1352, 8369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckBoolValue(object value, Type boolType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1235, 8381, 9391);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8469, 9380) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 8469, 9380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8520, 8554);

                    Type
                    resultType = f_1235_8538_8553(value)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8574, 8683) || true) && (resultType == typeof(PSObject))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 8574, 8683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8631, 8683);

                        resultType = f_1235_8644_8682(f_1235_8644_8672(((PSObject)value)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 8574, 8683);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8703, 8975) || true) && (!(f_1235_8709_8763(f_1235_8738_8762(resultType)) || (DynAbs.Tracing.TraceSender.Expression_False(1235, 8709, 8848) || f_1235_8790_8848(resultType))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 8703, 8975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 8891, 8956);

                        f_1235_8891_8955(resultType, boolType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 8703, 8975);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 8469, 9380);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 8469, 9380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 9041, 9164);

                    bool
                    isNullable = f_1235_9059_9081(boolType) && (DynAbs.Tracing.TraceSender.Expression_True(1235, 9059, 9163) && f_1235_9106_9141(boolType) == typeof(Nullable<>))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 9184, 9365) || true) && (!isNullable && (DynAbs.Tracing.TraceSender.Expression_True(1235, 9188, 9245) && f_1235_9203_9245(boolType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1235, 9184, 9365);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 9287, 9346);

                        f_1235_9287_9345(null, boolType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 9184, 9365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1235, 8469, 9380);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1235, 8381, 9391);

                System.Type
                f_1235_8538_8553(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8538, 8553);
                    return return_v;
                }


                object
                f_1235_8644_8672(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 8644, 8672);
                    return return_v;
                }


                System.Type
                f_1235_8644_8682(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8644, 8682);
                    return return_v;
                }


                System.TypeCode
                f_1235_8738_8762(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8738, 8762);
                    return return_v;
                }


                bool
                f_1235_8709_8763(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8709, 8763);
                    return return_v;
                }


                bool
                f_1235_8790_8848(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBoolOrSwitchParameterType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8790, 8848);
                    return return_v;
                }


                int
                f_1235_8891_8955(System.Type
                resultType, System.Type
                convertType)
                {
                    ThrowPSInvalidBooleanArgumentCastException(resultType, convertType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 8891, 8955);
                    return 0;
                }


                bool
                f_1235_9059_9081(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 9059, 9081);
                    return return_v;
                }


                System.Type
                f_1235_9106_9141(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 9106, 9141);
                    return return_v;
                }


                bool
                f_1235_9203_9245(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBooleanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 9203, 9245);
                    return return_v;
                }


                int
                f_1235_9287_9345(System.Type
                resultType, System.Type
                convertType)
                {
                    ThrowPSInvalidBooleanArgumentCastException(resultType, convertType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 9287, 9345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 8381, 9391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 8381, 9391);
            }
        }

        internal static void ThrowPSInvalidBooleanArgumentCastException(Type resultType, Type convertType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1235, 9403, 9783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1235, 9526, 9772);

                throw f_1235_9532_9771("InvalidCastExceptionUnsupportedParameterType", null, f_1235_9648_9710(), resultType, convertType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1235, 9403, 9783);

                string
                f_1235_9648_9710()
                {
                    var return_v = ExtendedTypeSystem.InvalidCastExceptionForBooleanArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1235, 9648, 9710);
                    return return_v;
                }


                System.Management.Automation.PSInvalidCastException
                f_1235_9532_9771(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.PSInvalidCastException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1235, 9532, 9771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1235, 9403, 9783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 9403, 9783);
            }
        }

        static ArgumentTypeConverterAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1235, 431, 9790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1235, 431, 9790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1235, 431, 9790);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1235, 431, 9790);
    }
}

