// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Internal;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

using Microsoft.PowerShell;

namespace System.Management.Automation.Language
{
    internal class TypeDefiner
    {
        internal const string
        DynamicClassAssemblyName = "PowerShell Class Assembly"
        ;

        internal const string
        DynamicClassAssemblyFullNamePrefix = "PowerShell Class Assembly,"
        ;

        private static int s_globalCounter;

        private static readonly CustomAttributeBuilder s_hiddenCustomAttributeBuilder;

        private static readonly string s_sessionStateKeeperFieldName;

        internal static readonly string SessionStateFieldName;

        private static readonly MethodInfo s_sessionStateKeeper_GetSessionState;

        private static bool TryConvertArg(object arg, Type type, out object result, Parser parser, IScriptExtent errorExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 1310, 2054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1525, 1657) || true) && (arg != null && (DynAbs.Tracing.TraceSender.Expression_True(1553, 1529, 1565) && f_1553_1544_1557(arg) == type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 1525, 1657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1599, 1612);

                    result = arg;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1630, 1642);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 1525, 1657);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1673, 2015) || true) && (!f_1553_1678_1732(arg, type, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 1673, 2015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1766, 1969);

                    f_1553_1766_1968(parser, errorExtent, nameof(ParserStrings.CannotConvertValue), f_1553_1882_1914(), f_1553_1937_1967(type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1987, 2000);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 1673, 2015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2031, 2043);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 1310, 2054);

                System.Type
                f_1553_1544_1557(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 1544, 1557);
                    return return_v;
                }


                bool
                f_1553_1678_1732(object
                valueToConvert, System.Type
                resultType, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 1678, 1732);
                    return return_v;
                }


                string
                f_1553_1882_1914()
                {
                    var return_v = ParserStrings.CannotConvertValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 1882, 1914);
                    return return_v;
                }


                string
                f_1553_1937_1967(System.Type
                type)
                {
                    var return_v = ToStringCodeMethods.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 1937, 1967);
                    return return_v;
                }


                int
                f_1553_1766_1968(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 1766, 1968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 1310, 2054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 1310, 2054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CustomAttributeBuilder GetAttributeBuilder(Parser parser, AttributeAst attributeAst, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 2066, 8835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2225, 2296);

                var
                attributeType = f_1553_2245_2295(f_1553_2245_2266(attributeAst))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2310, 2414);

                f_1553_2310_2413(attributeType != null, "Semantic checks should have verified attribute type exists");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2430, 2714);

                f_1553_2430_2713(f_1553_2467_2530(attributeType, true) == null || (DynAbs.Tracing.TraceSender.Expression_False(1553, 2467, 2656) || (f_1553_2560_2631(f_1553_2560_2623(attributeType, true)) & attributeTargets) != 0), "Semantic checks should have verified attribute usage");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2730, 2802);

                var
                positionalArgs = new object[f_1553_2762_2800(f_1553_2762_2794(attributeAst))]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2816, 2881);

                var
                cvv = new ConstantValueVisitor { AttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1553, 2826, 2880) }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2904, 2909);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2895, 3113) || true) && (i < f_1553_2915_2953(f_1553_2915_2947(attributeAst)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2955, 2958)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 2895, 3113))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 2895, 3113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 2992, 3041);

                        var
                        posArg = f_1553_3005_3040(f_1553_3005_3037(attributeAst), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3059, 3098);

                        positionalArgs[i] = f_1553_3079_3097(posArg, cvv);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3129, 3177);

                var
                ctorInfos = f_1553_3145_3176(attributeType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3191, 3264);

                var
                newConstructors = f_1553_3213_3263(ctorInfos)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3280, 3302);

                string
                errorId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3316, 3339);

                string
                errorMsg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3353, 3377);

                bool
                expandParamsOnBest
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3391, 3413);

                bool
                callNonVirtually
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3427, 3474);

                var
                positionalArgCount = f_1553_3452_3473(positionalArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3490, 3838);

                var
                bestMethod = f_1553_3507_3837(newConstructors, invocationConstraints: null, allowCastingToByRefLikeType: false, positionalArgs, ref errorId, ref errorMsg, out expandParamsOnBest, out callNonVirtually)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3854, 4156) || true) && (bestMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 3854, 4156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 3910, 4111);

                    f_1553_3910_4110(parser, f_1553_3929_4109(f_1553_3944_3963(attributeAst), errorId, f_1553_3995_4108(f_1553_4009_4037(), errorMsg, f_1553_4049_4067(attributeType), f_1553_4069_4107(f_1553_4069_4101(attributeAst)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4129, 4141);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 3854, 4156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4172, 4229);

                var
                constructorInfo = (ConstructorInfo)bestMethod.method
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4245, 4297);

                var
                parameterInfo = f_1553_4265_4296(constructorInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4311, 4359);

                var
                ctorArgs = new object[f_1553_4337_4357(parameterInfo)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4373, 4384);

                object
                arg
                = default(object);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4407, 4419);
                    for (var
        argIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4398, 6523) || true) && (argIndex < f_1553_4432_4452(parameterInfo))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4454, 4464)
        , ++argIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 4398, 6523))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 4398, 6523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 4498, 4553);

                        var
                        resultType = f_1553_4515_4552(parameterInfo[argIndex])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5248, 5349);

                        var
                        paramArrayAttrs = f_1553_5270_5348(parameterInfo[argIndex], typeof(ParamArrayAttribute), true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5367, 6225) || true) && (paramArrayAttrs != null && (DynAbs.Tracing.TraceSender.Expression_True(1553, 5371, 5419) && f_1553_5398_5419(paramArrayAttrs)) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 5371, 5441) && expandParamsOnBest))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 5367, 6225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5483, 5556);

                            var
                            elementType = f_1553_5501_5555(f_1553_5501_5538(parameterInfo[argIndex]))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5578, 5661);

                            var
                            paramsArray = f_1553_5596_5660(elementType, positionalArgCount - argIndex)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5683, 5716);

                            ctorArgs[argIndex] = paramsArray;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5749, 5754);

                                for (var
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5740, 6176) || true) && (i < f_1553_5760_5778(paramsArray))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5780, 5783)
            , ++i, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5785, 5795)
            , ++argIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 5740, 6176))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 5740, 6176);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 5845, 6096) || true) && (!f_1553_5850_5999(positionalArgs[argIndex], elementType, out arg, parser, f_1553_5949_5998(f_1553_5949_5991(f_1553_5949_5981(attributeAst), argIndex))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 5845, 6096);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6057, 6069);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 5845, 6096);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6124, 6153);

                                    f_1553_6124_6152(
                                                            paramsArray, arg, i);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 437);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 437);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 6200, 6206);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 5367, 6225);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6245, 6463) || true) && (!f_1553_6250_6390(positionalArgs[argIndex], resultType, out arg, parser, f_1553_6340_6389(f_1553_6340_6382(f_1553_6340_6372(attributeAst), argIndex))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 6245, 6463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6432, 6444);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 6245, 6463);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6483, 6508);

                        ctorArgs[argIndex] = arg;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 2126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 2126);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6539, 6691) || true) && (f_1553_6543_6576(f_1553_6543_6570(attributeAst)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 6539, 6691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6615, 6676);

                    return f_1553_6622_6675(constructorInfo, ctorArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 6539, 6691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6707, 6755);

                var
                propertyInfoList = f_1553_6730_6754()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6769, 6807);

                var
                propertyArgs = f_1553_6788_6806()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6821, 6863);

                var
                fieldInfoList = f_1553_6841_6862()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6877, 6912);

                var
                fieldArgs = f_1553_6893_6911()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 6926, 8615);
                    foreach (var namedArg in f_1553_6951_6978_I(f_1553_6951_6978(attributeAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 6926, 8615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7012, 7045);

                        var
                        name = f_1553_7023_7044(namedArg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7063, 7273);

                        var
                        members = f_1553_7077_7272(attributeType, name, MemberTypes.Field | MemberTypes.Property, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7291, 7482);

                        f_1553_7291_7481(f_1553_7310_7324(members) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1553, 7310, 7388) && (members[0] is PropertyInfo || (DynAbs.Tracing.TraceSender.Expression_False(1553, 7334, 7387) || members[0] is FieldInfo))), "Semantic checks should have ensured names attribute argument exists");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7502, 7538);

                        arg = f_1553_7508_7537(f_1553_7508_7525(namedArg), cvv);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7558, 7604);

                        var
                        propertyInfo = members[0] as PropertyInfo
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7622, 8147) || true) && (propertyInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 7622, 8147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7688, 7792);

                            f_1553_7688_7791(f_1553_7707_7734(propertyInfo) != null, "Semantic checks ensures property is settable");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7816, 7994) || true) && (!f_1553_7821_7909(arg, f_1553_7840_7865(propertyInfo), out arg, parser, f_1553_7884_7908(f_1553_7884_7901(namedArg))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 7816, 7994);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 7959, 7971);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 7816, 7994);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8018, 8053);

                            f_1553_8018_8052(
                                                propertyInfoList, propertyInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8075, 8097);

                            f_1553_8075_8096(propertyArgs, arg);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8119, 8128);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 7622, 8147);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8167, 8205);

                        var
                        fieldInfo = (FieldInfo)members[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8223, 8334);

                        f_1553_8223_8333(f_1553_8242_8263_M(!fieldInfo.IsInitOnly) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 8242, 8287) && f_1553_8267_8287_M(!fieldInfo.IsLiteral)), "Semantic checks ensures field is settable");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8354, 8514) || true) && (!f_1553_8359_8441(arg, f_1553_8378_8397(fieldInfo), out arg, parser, f_1553_8416_8440(f_1553_8416_8433(namedArg))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 8354, 8514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8483, 8495);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 8354, 8514);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8534, 8563);

                        f_1553_8534_8562(
                                        fieldInfoList, fieldInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8581, 8600);

                        f_1553_8581_8599(fieldArgs, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 6926, 8615);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 8631, 8824);

                return f_1553_8638_8823(constructorInfo, ctorArgs, f_1553_8709_8735(propertyInfoList), f_1553_8737_8759(propertyArgs), f_1553_8778_8801(fieldInfoList), f_1553_8803_8822(fieldArgs));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 2066, 8835);

                System.Management.Automation.Language.ITypeName
                f_1553_2245_2266(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2245, 2266);
                    return return_v;
                }


                System.Type
                f_1553_2245_2295(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 2245, 2295);
                    return return_v;
                }


                int
                f_1553_2310_2413(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 2310, 2413);
                    return 0;
                }


                System.AttributeUsageAttribute?
                f_1553_2467_2530(System.Type
                element, bool
                inherit)
                {
                    var return_v = element.GetCustomAttribute<System.AttributeUsageAttribute>(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 2467, 2530);
                    return return_v;
                }


                System.AttributeUsageAttribute?
                f_1553_2560_2623(System.Type
                element, bool
                inherit)
                {
                    var return_v = element.GetCustomAttribute<System.AttributeUsageAttribute>(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 2560, 2623);
                    return return_v;
                }


                System.AttributeTargets
                f_1553_2560_2631(System.AttributeUsageAttribute
                this_param)
                {
                    var return_v = this_param.ValidOn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2560, 2631);
                    return return_v;
                }


                int
                f_1553_2430_2713(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 2430, 2713);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_2762_2794(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2762, 2794);
                    return return_v;
                }


                int
                f_1553_2762_2800(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2762, 2800);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_2915_2947(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2915, 2947);
                    return return_v;
                }


                int
                f_1553_2915_2953(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 2915, 2953);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_3005_3037(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 3005, 3037);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_3005_3040(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 3005, 3040);
                    return return_v;
                }


                object
                f_1553_3079_3097(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.ConstantValueVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3079, 3097);
                    return return_v;
                }


                System.Reflection.ConstructorInfo[]
                f_1553_3145_3176(System.Type
                this_param)
                {
                    var return_v = this_param.GetConstructors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3145, 3176);
                    return return_v;
                }


                System.Management.Automation.MethodInformation[]
                f_1553_3213_3263(System.Reflection.ConstructorInfo[]
                methods)
                {
                    var return_v = DotNetAdapter.GetMethodInformationArray((System.Reflection.MethodBase[])methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3213, 3263);
                    return return_v;
                }


                int
                f_1553_3452_3473(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 3452, 3473);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1553_3507_3837(System.Management.Automation.MethodInformation[]
                methods, System.Management.Automation.PSMethodInvocationConstraints
                invocationConstraints, bool
                allowCastingToByRefLikeType, object[]
                arguments, ref string
                errorId, ref string
                errorMsg, out bool
                expandParamsOnBest, out bool
                callNonVirtually)
                {
                    var return_v = Adapter.FindBestMethod(methods, invocationConstraints: invocationConstraints, allowCastingToByRefLikeType: allowCastingToByRefLikeType, arguments, ref errorId, ref errorMsg, out expandParamsOnBest, out callNonVirtually);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3507, 3837);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_3944_3963(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 3944, 3963);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1553_4009_4037()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4009, 4037);
                    return return_v;
                }


                string
                f_1553_4049_4067(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4049, 4067);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_4069_4101(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4069, 4101);
                    return return_v;
                }


                int
                f_1553_4069_4107(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4069, 4107);
                    return return_v;
                }


                string
                f_1553_3995_4108(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3995, 4108);
                    return return_v;
                }


                System.Management.Automation.Language.ParseError
                f_1553_3929_4109(System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                message)
                {
                    var return_v = new System.Management.Automation.Language.ParseError(extent, errorId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3929, 4109);
                    return return_v;
                }


                int
                f_1553_3910_4110(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.ParseError
                error)
                {
                    this_param.ReportError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 3910, 4110);
                    return 0;
                }


                System.Reflection.ParameterInfo[]
                f_1553_4265_4296(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 4265, 4296);
                    return return_v;
                }


                int
                f_1553_4337_4357(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4337, 4357);
                    return return_v;
                }


                int
                f_1553_4432_4452(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4432, 4452);
                    return return_v;
                }


                System.Type
                f_1553_4515_4552(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 4515, 4552);
                    return return_v;
                }


                object[]
                f_1553_5270_5348(System.Reflection.ParameterInfo
                this_param, System.Type
                attributeType, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(attributeType, inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 5270, 5348);
                    return return_v;
                }


                bool
                f_1553_5398_5419(object[]
                source)
                {
                    var return_v = source.Any<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 5398, 5419);
                    return return_v;
                }


                System.Type
                f_1553_5501_5538(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 5501, 5538);
                    return return_v;
                }


                System.Type?
                f_1553_5501_5555(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 5501, 5555);
                    return return_v;
                }


                System.Array
                f_1553_5596_5660(System.Type
                elementType, int
                length)
                {
                    var return_v = Array.CreateInstance(elementType, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 5596, 5660);
                    return return_v;
                }


                int
                f_1553_5760_5778(System.Array
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 5760, 5778);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_5949_5981(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 5949, 5981);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_5949_5991(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 5949, 5991);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_5949_5998(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 5949, 5998);
                    return return_v;
                }


                bool
                f_1553_5850_5999(object
                arg, System.Type
                type, out object
                result, System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.IScriptExtent
                errorExtent)
                {
                    var return_v = TryConvertArg(arg, type, out result, parser, errorExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 5850, 5999);
                    return return_v;
                }


                int
                f_1553_6124_6152(System.Array
                this_param, object
                value, int
                index)
                {
                    this_param.SetValue(value, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6124, 6152);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1553_6340_6372(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.PositionalArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6340, 6372);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_6340_6382(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6340, 6382);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_6340_6389(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6340, 6389);
                    return return_v;
                }


                bool
                f_1553_6250_6390(object
                arg, System.Type
                type, out object
                result, System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.IScriptExtent
                errorExtent)
                {
                    var return_v = TryConvertArg(arg, type, out result, parser, errorExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6250, 6390);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
                f_1553_6543_6570(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6543, 6570);
                    return return_v;
                }


                int
                f_1553_6543_6576(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6543, 6576);
                    return return_v;
                }


                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_6622_6675(System.Reflection.ConstructorInfo
                con, object[]
                constructorArgs)
                {
                    var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6622, 6675);
                    return return_v;
                }


                System.Collections.Generic.List<System.Reflection.PropertyInfo>
                f_1553_6730_6754()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.PropertyInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6730, 6754);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1553_6788_6806()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6788, 6806);
                    return return_v;
                }


                System.Collections.Generic.List<System.Reflection.FieldInfo>
                f_1553_6841_6862()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.FieldInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6841, 6862);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1553_6893_6911()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6893, 6911);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
                f_1553_6951_6978(System.Management.Automation.Language.AttributeAst
                this_param)
                {
                    var return_v = this_param.NamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 6951, 6978);
                    return return_v;
                }


                string
                f_1553_7023_7044(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.ArgumentName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7023, 7044);
                    return return_v;
                }


                System.Reflection.MemberInfo[]
                f_1553_7077_7272(System.Type
                this_param, string
                name, System.Reflection.MemberTypes
                type, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMember(name, type, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7077, 7272);
                    return return_v;
                }


                int
                f_1553_7310_7324(System.Reflection.MemberInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7310, 7324);
                    return return_v;
                }


                int
                f_1553_7291_7481(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7291, 7481);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_7508_7525(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7508, 7525);
                    return return_v;
                }


                object
                f_1553_7508_7537(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.ConstantValueVisitor
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7508, 7537);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1553_7707_7734(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.GetSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7707, 7734);
                    return return_v;
                }


                int
                f_1553_7688_7791(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7688, 7791);
                    return 0;
                }


                System.Type
                f_1553_7840_7865(System.Reflection.PropertyInfo
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7840, 7865);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_7884_7901(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7884, 7901);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_7884_7908(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 7884, 7908);
                    return return_v;
                }


                bool
                f_1553_7821_7909(object
                arg, System.Type
                type, out object
                result, System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.IScriptExtent
                errorExtent)
                {
                    var return_v = TryConvertArg(arg, type, out result, parser, errorExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 7821, 7909);
                    return return_v;
                }


                int
                f_1553_8018_8052(System.Collections.Generic.List<System.Reflection.PropertyInfo>
                this_param, System.Reflection.PropertyInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8018, 8052);
                    return 0;
                }


                int
                f_1553_8075_8096(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8075, 8096);
                    return 0;
                }


                bool
                f_1553_8242_8263_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 8242, 8263);
                    return return_v;
                }


                bool
                f_1553_8267_8287_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 8267, 8287);
                    return return_v;
                }


                int
                f_1553_8223_8333(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8223, 8333);
                    return 0;
                }


                System.Type
                f_1553_8378_8397(System.Reflection.FieldInfo
                this_param)
                {
                    var return_v = this_param.FieldType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 8378, 8397);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1553_8416_8433(System.Management.Automation.Language.NamedAttributeArgumentAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 8416, 8433);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_8416_8440(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 8416, 8440);
                    return return_v;
                }


                bool
                f_1553_8359_8441(object
                arg, System.Type
                type, out object
                result, System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.IScriptExtent
                errorExtent)
                {
                    var return_v = TryConvertArg(arg, type, out result, parser, errorExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8359, 8441);
                    return return_v;
                }


                int
                f_1553_8534_8562(System.Collections.Generic.List<System.Reflection.FieldInfo>
                this_param, System.Reflection.FieldInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8534, 8562);
                    return 0;
                }


                int
                f_1553_8581_8599(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8581, 8599);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
                f_1553_6951_6978_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 6951, 6978);
                    return return_v;
                }


                System.Reflection.PropertyInfo[]
                f_1553_8709_8735(System.Collections.Generic.List<System.Reflection.PropertyInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8709, 8735);
                    return return_v;
                }


                object[]
                f_1553_8737_8759(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8737, 8759);
                    return return_v;
                }


                System.Reflection.FieldInfo[]
                f_1553_8778_8801(System.Collections.Generic.List<System.Reflection.FieldInfo>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8778, 8801);
                    return return_v;
                }


                object[]
                f_1553_8803_8822(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8803, 8822);
                    return return_v;
                }


                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_8638_8823(System.Reflection.ConstructorInfo
                con, object[]
                constructorArgs, System.Reflection.PropertyInfo[]
                namedProperties, object[]
                propertyValues, System.Reflection.FieldInfo[]
                namedFields, object[]
                fieldValues)
                {
                    var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 8638, 8823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 2066, 8835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 2066, 8835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void DefineCustomAttributes(TypeBuilder member, ReadOnlyCollection<AttributeAst> attributes, Parser parser, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 8847, 9425);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9030, 9414) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9030, 9414);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9086, 9399);
                        foreach (var attr in f_1553_9107_9117_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9086, 9399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9159, 9227);

                            var
                            cabuilder = f_1553_9175_9226(parser, attr, attributeTargets)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9249, 9380) || true) && (cabuilder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9249, 9380);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9320, 9357);

                                f_1553_9320_9356(member, cabuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9249, 9380);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9086, 9399);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9030, 9414);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 8847, 9425);

                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_9175_9226(System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.AttributeAst
                attributeAst, System.AttributeTargets
                attributeTargets)
                {
                    var return_v = GetAttributeBuilder(parser, attributeAst, attributeTargets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9175, 9226);
                    return return_v;
                }


                int
                f_1553_9320_9356(System.Reflection.Emit.TypeBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9320, 9356);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1553_9107_9117_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9107, 9117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 8847, 9425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 8847, 9425);
            }
        }

        internal static void DefineCustomAttributes(PropertyBuilder member, ReadOnlyCollection<AttributeAst> attributes, Parser parser, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 9437, 10019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9624, 10008) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9624, 10008);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9680, 9993);
                        foreach (var attr in f_1553_9701_9711_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9680, 9993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9753, 9821);

                            var
                            cabuilder = f_1553_9769_9820(parser, attr, attributeTargets)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9843, 9974) || true) && (cabuilder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 9843, 9974);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 9914, 9951);

                                f_1553_9914_9950(member, cabuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9843, 9974);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9680, 9993);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 9624, 10008);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 9437, 10019);

                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_9769_9820(System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.AttributeAst
                attributeAst, System.AttributeTargets
                attributeTargets)
                {
                    var return_v = GetAttributeBuilder(parser, attributeAst, attributeTargets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9769, 9820);
                    return return_v;
                }


                int
                f_1553_9914_9950(System.Reflection.Emit.PropertyBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9914, 9950);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1553_9701_9711_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 9701, 9711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 9437, 10019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 9437, 10019);
            }
        }

        internal static void DefineCustomAttributes(ConstructorBuilder member, ReadOnlyCollection<AttributeAst> attributes, Parser parser, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 10031, 10616);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10221, 10605) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 10221, 10605);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10277, 10590);
                        foreach (var attr in f_1553_10298_10308_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 10277, 10590);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10350, 10418);

                            var
                            cabuilder = f_1553_10366_10417(parser, attr, attributeTargets)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10440, 10571) || true) && (cabuilder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 10440, 10571);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10511, 10548);

                                f_1553_10511_10547(member, cabuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 10440, 10571);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 10277, 10590);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 10221, 10605);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 10031, 10616);

                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_10366_10417(System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.AttributeAst
                attributeAst, System.AttributeTargets
                attributeTargets)
                {
                    var return_v = GetAttributeBuilder(parser, attributeAst, attributeTargets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 10366, 10417);
                    return return_v;
                }


                int
                f_1553_10511_10547(System.Reflection.Emit.ConstructorBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 10511, 10547);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1553_10298_10308_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 10298, 10308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 10031, 10616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 10031, 10616);
            }
        }

        internal static void DefineCustomAttributes(MethodBuilder member, ReadOnlyCollection<AttributeAst> attributes, Parser parser, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 10628, 11208);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10813, 11197) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 10813, 11197);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10869, 11182);
                        foreach (var attr in f_1553_10890_10900_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 10869, 11182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 10942, 11010);

                            var
                            cabuilder = f_1553_10958_11009(parser, attr, attributeTargets)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11032, 11163) || true) && (cabuilder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 11032, 11163);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11103, 11140);

                                f_1553_11103_11139(member, cabuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 11032, 11163);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 10869, 11182);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 10813, 11197);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 10628, 11208);

                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_10958_11009(System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.AttributeAst
                attributeAst, System.AttributeTargets
                attributeTargets)
                {
                    var return_v = GetAttributeBuilder(parser, attributeAst, attributeTargets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 10958, 11009);
                    return return_v;
                }


                int
                f_1553_11103_11139(System.Reflection.Emit.MethodBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 11103, 11139);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1553_10890_10900_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 10890, 10900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 10628, 11208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 10628, 11208);
            }
        }

        internal static void DefineCustomAttributes(EnumBuilder member, ReadOnlyCollection<AttributeAst> attributes, Parser parser, AttributeTargets attributeTargets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 11220, 11798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11403, 11787) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 11403, 11787);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11459, 11772);
                        foreach (var attr in f_1553_11480_11490_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 11459, 11772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11532, 11600);

                            var
                            cabuilder = f_1553_11548_11599(parser, attr, attributeTargets)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11622, 11753) || true) && (cabuilder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 11622, 11753);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11693, 11730);

                                f_1553_11693_11729(member, cabuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 11622, 11753);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 11459, 11772);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 11403, 11787);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 11220, 11798);

                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_11548_11599(System.Management.Automation.Language.Parser
                parser, System.Management.Automation.Language.AttributeAst
                attributeAst, System.AttributeTargets
                attributeTargets)
                {
                    var return_v = GetAttributeBuilder(parser, attributeAst, attributeTargets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 11548, 11599);
                    return return_v;
                }


                int
                f_1553_11693_11729(System.Reflection.Emit.EnumBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 11693, 11729);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                f_1553_11480_11490_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 11480, 11490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 11220, 11798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 11220, 11798);
            }
        }
        private class DefineTypeHelper
        {
            private readonly Parser _parser;

            internal readonly TypeDefinitionAst _typeDefinitionAst;

            internal readonly TypeBuilder _typeBuilder;

            internal readonly FieldBuilder _sessionStateField;

            internal readonly FieldBuilder _sessionStateKeeperField;

            internal readonly ModuleBuilder _moduleBuilder;

            internal readonly TypeBuilder _staticHelpersTypeBuilder;

            private readonly Dictionary<string, PropertyMemberAst> _definedProperties;

            private readonly Dictionary<string, List<Tuple<FunctionMemberAst, Type[]>>> _definedMethods;

            private HashSet<Tuple<string, Type>> _interfaceProperties;

            internal readonly List<(string fieldName, IParameterMetadataProvider bodyAst, bool isStatic)> _fieldsToInitForMemberFunctions;

            private bool _baseClassHasDefaultCtor;

            public bool HasFatalErrors { get; private set; }

            public DefineTypeHelper(Parser parser, ModuleBuilder module, TypeDefinitionAst typeDefinitionAst, string typeName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1553, 13031, 14654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11889, 11896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 11947, 11965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12010, 12022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12068, 12086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12132, 12156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12203, 12217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12262, 12287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12357, 12375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12466, 12481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12533, 12553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12662, 12693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12721, 12745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 12967, 13015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13178, 13202);

                    _moduleBuilder = module;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13220, 13237);

                    _parser = parser;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13255, 13294);

                    _typeDefinitionAst = typeDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13314, 13336);

                    List<Type>
                    interfaces
                    = default(List<Type>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13354, 13431);

                    var
                    baseClass = f_1553_13370_13430(this, parser, typeDefinitionAst, out interfaces)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13451, 13595);

                    _typeBuilder = f_1553_13466_13594(module, typeName, Reflection.TypeAttributes.Class | Reflection.TypeAttributes.Public, baseClass, f_1553_13573_13593(interfaces));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13613, 13770);

                    _staticHelpersTypeBuilder = f_1553_13641_13769(module, f_1553_13659_13735(f_1553_13673_13701(), "{0}_<staticHelpers>", typeName), Reflection.TypeAttributes.Class);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13788, 13888);

                    f_1553_13788_13887(_typeBuilder, f_1553_13825_13853(typeDefinitionAst), _parser, AttributeTargets.Class);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13906, 13945);

                    _typeDefinitionAst.Type = _typeBuilder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 13965, 14054);

                    _fieldsToInitForMemberFunctions = f_1553_13999_14053();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 14072, 14187);

                    _definedMethods = f_1553_14090_14186(f_1553_14153_14185());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 14205, 14302);

                    _definedProperties = f_1553_14226_14301(f_1553_14268_14300());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 14322, 14446);

                    _sessionStateField = f_1553_14343_14445(_typeBuilder, SessionStateFieldName, typeof(SessionStateInternal), FieldAttributes.Private);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 14464, 14639);

                    _sessionStateKeeperField = f_1553_14491_14638(_staticHelpersTypeBuilder, s_sessionStateKeeperFieldName, typeof(SessionStateKeeper), FieldAttributes.Assembly | FieldAttributes.Static);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1553, 13031, 14654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 13031, 14654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 13031, 14654);
                }
            }

            private Type GetBaseTypes(Parser parser, TypeDefinitionAst typeDefinitionAst, out List<Type> interfaces)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 15005, 21336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15199, 15221);

                    Type
                    baseClass = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15239, 15269);

                    interfaces = f_1553_15252_15268();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15372, 15404);

                    _baseClassHasDefaultCtor = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15422, 21266) || true) && (f_1553_15426_15459(f_1553_15426_15453(typeDefinitionAst)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 15422, 21266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15536, 15583);

                        var
                        baseTypeAsts = f_1553_15555_15582(typeDefinitionAst)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15605, 15644);

                        var
                        firstBaseTypeAst = f_1553_15628_15643(baseTypeAsts, 0)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15668, 18181) || true) && (f_1553_15672_15705(f_1553_15672_15697(firstBaseTypeAst)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 15668, 18181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 15755, 15986);

                            f_1553_15755_15985(parser, f_1553_15774_15797(firstBaseTypeAst), nameof(ParserStrings.SubtypeArray), f_1553_15893_15919(), f_1553_15950_15984(f_1553_15950_15975(firstBaseTypeAst)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 15668, 18181);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 15668, 18181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 16142, 16200);

                            baseClass = f_1553_16154_16199(f_1553_16154_16179(firstBaseTypeAst));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 16226, 18158) || true) && (baseClass == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 16226, 18158);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 16305, 16548);

                                f_1553_16305_16547(parser, f_1553_16324_16347(firstBaseTypeAst), nameof(ParserStrings.TypeNotFound), f_1553_16451_16477(), f_1553_16512_16546(f_1553_16512_16537(firstBaseTypeAst)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 16226, 18158);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 16226, 18158);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 16726, 18131) || true) && (f_1553_16730_16748(baseClass))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 16726, 18131);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 16814, 17055);

                                    f_1553_16814_17054(parser, f_1553_16833_16856(firstBaseTypeAst), nameof(ParserStrings.SealedBaseClass), f_1553_16971_17000(), f_1553_17039_17053(baseClass));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 17158, 17175);

                                    baseClass = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 16726, 18131);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 16726, 18131);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 17241, 18131) || true) && (f_1553_17245_17268(baseClass) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 17245, 17307) && f_1553_17272_17307_M(!baseClass.IsConstructedGenericType)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 17241, 18131);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 17373, 17628);

                                        f_1553_17373_17627(parser, f_1553_17392_17415(firstBaseTypeAst), nameof(ParserStrings.SubtypeUnclosedGeneric), f_1553_17537_17573(), f_1553_17612_17626(baseClass));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 17757, 17774);

                                        baseClass = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 17241, 18131);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 17241, 18131);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 17840, 18131) || true) && (f_1553_17844_17865(baseClass))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 17840, 18131);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18023, 18049);

                                            f_1553_18023_18048(                                // First Ast can represent interface as well as BaseClass.
                                                                            interfaces, baseClass);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18083, 18100);

                                            baseClass = null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 17840, 18131);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 17241, 18131);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 16726, 18131);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 16226, 18158);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 15668, 18181);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18205, 18889) || true) && (baseClass != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 18205, 18889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18449, 18506);

                            var
                            baseTypeName = f_1553_18468_18493(firstBaseTypeAst) as TypeName
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18532, 18866) || true) && (baseTypeName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 18532, 18866);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18614, 18671);

                                _baseClassHasDefaultCtor = f_1553_18641_18670(baseTypeName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 18532, 18866);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 18532, 18866);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18785, 18839);

                                _baseClassHasDefaultCtor = f_1553_18812_18838(baseClass);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 18532, 18866);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 18205, 18889);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18922, 18927);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18913, 19448) || true) && (i < f_1553_18933_18951(baseTypeAsts))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 18953, 18956)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 18913, 19448))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 18913, 19448);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19006, 19425) || true) && (f_1553_19010_19042(f_1553_19010_19034(f_1553_19010_19025(baseTypeAsts, i))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 19006, 19425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19100, 19341);

                                    f_1553_19100_19340(parser, f_1553_19119_19141(f_1553_19119_19134(baseTypeAsts, i)), nameof(ParserStrings.SubtypeArray), f_1553_19245_19271(), f_1553_19306_19339(f_1553_19306_19330(f_1553_19306_19321(baseTypeAsts, i))));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19371, 19398);

                                    this.HasFatalErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 19006, 19425);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 536);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 536);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19481, 19486);

                            for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19472, 21247) || true) && (i < f_1553_19492_19510(baseTypeAsts))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19512, 19515)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 19472, 21247))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 19472, 21247);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19565, 21224) || true) && (f_1553_19569_19601(f_1553_19569_19593(f_1553_19569_19584(baseTypeAsts, i))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 19565, 21224);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 19659, 19900);

                                    f_1553_19659_19899(parser, f_1553_19678_19700(f_1553_19678_19693(baseTypeAsts, i)), nameof(ParserStrings.SubtypeArray), f_1553_19804_19830(), f_1553_19865_19898(f_1553_19865_19889(f_1553_19865_19880(baseTypeAsts, i))));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 19565, 21224);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 19565, 21224);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20014, 20080);

                                    Type
                                    interfaceType = f_1553_20035_20079(f_1553_20035_20059(f_1553_20035_20050(baseTypeAsts, i)))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20110, 21197) || true) && (interfaceType == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 20110, 21197);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20201, 20454);

                                        f_1553_20201_20453(parser, f_1553_20220_20242(f_1553_20220_20235(baseTypeAsts, i)), nameof(ParserStrings.TypeNotFound), f_1553_20354_20380(), f_1553_20419_20452(f_1553_20419_20443(f_1553_20419_20434(baseTypeAsts, i))));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 20110, 21197);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 20110, 21197);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20584, 21166) || true) && (f_1553_20588_20613(interfaceType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 20584, 21166);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20687, 20717);

                                            f_1553_20687_20716(interfaces, interfaceType);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 20584, 21166);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 20584, 21166);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 20863, 21131);

                                            f_1553_20863_21130(parser, f_1553_20882_20904(f_1553_20882_20897(baseTypeAsts, i)), nameof(ParserStrings.InterfaceNameExpected), f_1553_21033_21068(), f_1553_21111_21129(interfaceType));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 20584, 21166);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 20110, 21197);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 19565, 21224);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1776);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1776);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 15422, 21266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 21286, 21321);

                    return baseClass ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1553, 21293, 21320) ?? typeof(object));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 15005, 21336);

                    System.Collections.Generic.List<System.Type>
                    f_1553_15252_15268()
                    {
                        var return_v = new System.Collections.Generic.List<System.Type>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 15252, 15268);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    f_1553_15426_15453(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.BaseTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15426, 15453);
                        return return_v;
                    }


                    bool
                    f_1553_15426_15459(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    source)
                    {
                        var return_v = source.Any<System.Management.Automation.Language.TypeConstraintAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 15426, 15459);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    f_1553_15555_15582(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.BaseTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15555, 15582);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_15628_15643(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15628, 15643);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_15672_15697(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15672, 15697);
                        return return_v;
                    }


                    bool
                    f_1553_15672_15705(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.IsArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15672, 15705);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_15774_15797(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15774, 15797);
                        return return_v;
                    }


                    string
                    f_1553_15893_15919()
                    {
                        var return_v = ParserStrings.SubtypeArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15893, 15919);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_15950_15975(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15950, 15975);
                        return return_v;
                    }


                    string
                    f_1553_15950_15984(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 15950, 15984);
                        return return_v;
                    }


                    int
                    f_1553_15755_15985(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 15755, 15985);
                        return 0;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_16154_16179(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16154, 16179);
                        return return_v;
                    }


                    System.Type
                    f_1553_16154_16199(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 16154, 16199);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_16324_16347(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16324, 16347);
                        return return_v;
                    }


                    string
                    f_1553_16451_16477()
                    {
                        var return_v = ParserStrings.TypeNotFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16451, 16477);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_16512_16537(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16512, 16537);
                        return return_v;
                    }


                    string
                    f_1553_16512_16546(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16512, 16546);
                        return return_v;
                    }


                    int
                    f_1553_16305_16547(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 16305, 16547);
                        return 0;
                    }


                    bool
                    f_1553_16730_16748(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16730, 16748);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_16833_16856(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16833, 16856);
                        return return_v;
                    }


                    string
                    f_1553_16971_17000()
                    {
                        var return_v = ParserStrings.SealedBaseClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 16971, 17000);
                        return return_v;
                    }


                    string
                    f_1553_17039_17053(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17039, 17053);
                        return return_v;
                    }


                    int
                    f_1553_16814_17054(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 16814, 17054);
                        return 0;
                    }


                    bool
                    f_1553_17245_17268(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsGenericType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17245, 17268);
                        return return_v;
                    }


                    bool
                    f_1553_17272_17307_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17272, 17307);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_17392_17415(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17392, 17415);
                        return return_v;
                    }


                    string
                    f_1553_17537_17573()
                    {
                        var return_v = ParserStrings.SubtypeUnclosedGeneric;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17537, 17573);
                        return return_v;
                    }


                    string
                    f_1553_17612_17626(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17612, 17626);
                        return return_v;
                    }


                    int
                    f_1553_17373_17627(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 17373, 17627);
                        return 0;
                    }


                    bool
                    f_1553_17844_17865(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 17844, 17865);
                        return return_v;
                    }


                    int
                    f_1553_18023_18048(System.Collections.Generic.List<System.Type>
                    this_param, System.Type
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 18023, 18048);
                        return 0;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_18468_18493(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 18468, 18493);
                        return return_v;
                    }


                    bool
                    f_1553_18641_18670(System.Management.Automation.Language.TypeName
                    this_param)
                    {
                        var return_v = this_param.HasDefaultCtor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 18641, 18670);
                        return return_v;
                    }


                    bool
                    f_1553_18812_18838(System.Type
                    type)
                    {
                        var return_v = type.HasDefaultCtor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 18812, 18838);
                        return return_v;
                    }


                    int
                    f_1553_18933_18951(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 18933, 18951);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19010_19025(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19010, 19025);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_19010_19034(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19010, 19034);
                        return return_v;
                    }


                    bool
                    f_1553_19010_19042(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.IsArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19010, 19042);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19119_19134(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19119, 19134);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_19119_19141(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19119, 19141);
                        return return_v;
                    }


                    string
                    f_1553_19245_19271()
                    {
                        var return_v = ParserStrings.SubtypeArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19245, 19271);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19306_19321(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19306, 19321);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_19306_19330(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19306, 19330);
                        return return_v;
                    }


                    string
                    f_1553_19306_19339(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19306, 19339);
                        return return_v;
                    }


                    int
                    f_1553_19100_19340(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 19100, 19340);
                        return 0;
                    }


                    int
                    f_1553_19492_19510(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19492, 19510);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19569_19584(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19569, 19584);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_19569_19593(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19569, 19593);
                        return return_v;
                    }


                    bool
                    f_1553_19569_19601(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.IsArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19569, 19601);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19678_19693(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19678, 19693);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_19678_19700(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19678, 19700);
                        return return_v;
                    }


                    string
                    f_1553_19804_19830()
                    {
                        var return_v = ParserStrings.SubtypeArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19804, 19830);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_19865_19880(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19865, 19880);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_19865_19889(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19865, 19889);
                        return return_v;
                    }


                    string
                    f_1553_19865_19898(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 19865, 19898);
                        return return_v;
                    }


                    int
                    f_1553_19659_19899(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 19659, 19899);
                        return 0;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_20035_20050(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20035, 20050);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_20035_20059(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20035, 20059);
                        return return_v;
                    }


                    System.Type
                    f_1553_20035_20079(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 20035, 20079);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_20220_20235(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20220, 20235);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_20220_20242(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20220, 20242);
                        return return_v;
                    }


                    string
                    f_1553_20354_20380()
                    {
                        var return_v = ParserStrings.TypeNotFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20354, 20380);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_20419_20434(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20419, 20434);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_20419_20443(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20419, 20443);
                        return return_v;
                    }


                    string
                    f_1553_20419_20452(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20419, 20452);
                        return return_v;
                    }


                    int
                    f_1553_20201_20453(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 20201, 20453);
                        return 0;
                    }


                    bool
                    f_1553_20588_20613(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20588, 20613);
                        return return_v;
                    }


                    int
                    f_1553_20687_20716(System.Collections.Generic.List<System.Type>
                    this_param, System.Type
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 20687, 20716);
                        return 0;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_20882_20897(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20882, 20897);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_20882_20904(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 20882, 20904);
                        return return_v;
                    }


                    string
                    f_1553_21033_21068()
                    {
                        var return_v = ParserStrings.InterfaceNameExpected;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 21033, 21068);
                        return return_v;
                    }


                    string
                    f_1553_21111_21129(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 21111, 21129);
                        return return_v;
                    }


                    int
                    f_1553_20863_21130(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 20863, 21130);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 15005, 21336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 15005, 21336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool ShouldImplementProperty(string name, Type type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 21352, 22779);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 21445, 22681) || true) && (_interfaceProperties == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 21445, 22681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 21519, 21577);

                        _interfaceProperties = f_1553_21542_21576();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 21599, 21639);

                        var
                        allInterfaces = f_1553_21619_21638()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 21933, 22306);
                            foreach (var interfaceType in f_1553_21963_21991_I(f_1553_21963_21991(_typeBuilder)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 21933, 22306);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22041, 22222);
                                    foreach (var parentInterface in f_1553_22073_22102_I(f_1553_22073_22102(interfaceType)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 22041, 22222);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22160, 22195);

                                        f_1553_22160_22194(allInterfaces, parentInterface);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 22041, 22222);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 182);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 182);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22250, 22283);

                                f_1553_22250_22282(
                                                        allInterfaces, interfaceType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 21933, 22306);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 374);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 374);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22330, 22662);
                            foreach (var interfaceType in f_1553_22360_22373_I(allInterfaces))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 22330, 22662);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22423, 22639);
                                    foreach (var property in f_1553_22448_22477_I(f_1553_22448_22477(interfaceType)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 22423, 22639);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22535, 22612);

                                        f_1553_22535_22611(_interfaceProperties, f_1553_22560_22610(f_1553_22573_22586(property), f_1553_22588_22609(property)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 22423, 22639);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 217);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 217);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 22330, 22662);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 333);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 333);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 21445, 22681);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 22701, 22764);

                    return f_1553_22708_22763(_interfaceProperties, f_1553_22738_22762(name, type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 21352, 22779);

                    System.Collections.Generic.HashSet<System.Tuple<string, System.Type>>
                    f_1553_21542_21576()
                    {
                        var return_v = new System.Collections.Generic.HashSet<System.Tuple<string, System.Type>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 21542, 21576);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<System.Type>
                    f_1553_21619_21638()
                    {
                        var return_v = new System.Collections.Generic.HashSet<System.Type>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 21619, 21638);
                        return return_v;
                    }


                    System.Type[]
                    f_1553_21963_21991(System.Reflection.Emit.TypeBuilder
                    this_param)
                    {
                        var return_v = this_param.GetInterfaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 21963, 21991);
                        return return_v;
                    }


                    System.Type[]
                    f_1553_22073_22102(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetInterfaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22073, 22102);
                        return return_v;
                    }


                    bool
                    f_1553_22160_22194(System.Collections.Generic.HashSet<System.Type>
                    this_param, System.Type
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22160, 22194);
                        return return_v;
                    }


                    System.Type[]
                    f_1553_22073_22102_I(System.Type[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22073, 22102);
                        return return_v;
                    }


                    bool
                    f_1553_22250_22282(System.Collections.Generic.HashSet<System.Type>
                    this_param, System.Type
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22250, 22282);
                        return return_v;
                    }


                    System.Type[]
                    f_1553_21963_21991_I(System.Type[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 21963, 21991);
                        return return_v;
                    }


                    System.Reflection.PropertyInfo[]
                    f_1553_22448_22477(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetProperties();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22448, 22477);
                        return return_v;
                    }


                    string
                    f_1553_22573_22586(System.Reflection.PropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 22573, 22586);
                        return return_v;
                    }


                    System.Type
                    f_1553_22588_22609(System.Reflection.PropertyInfo
                    this_param)
                    {
                        var return_v = this_param.PropertyType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 22588, 22609);
                        return return_v;
                    }


                    System.Tuple<string, System.Type>
                    f_1553_22560_22610(string
                    item1, System.Type
                    item2)
                    {
                        var return_v = Tuple.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22560, 22610);
                        return return_v;
                    }


                    bool
                    f_1553_22535_22611(System.Collections.Generic.HashSet<System.Tuple<string, System.Type>>
                    this_param, System.Tuple<string, System.Type>
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22535, 22611);
                        return return_v;
                    }


                    System.Reflection.PropertyInfo[]
                    f_1553_22448_22477_I(System.Reflection.PropertyInfo[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22448, 22477);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<System.Type>
                    f_1553_22360_22373_I(System.Collections.Generic.HashSet<System.Type>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22360, 22373);
                        return return_v;
                    }


                    System.Tuple<string, System.Type>
                    f_1553_22738_22762(string
                    item1, System.Type
                    item2)
                    {
                        var return_v = Tuple.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22738, 22762);
                        return return_v;
                    }


                    bool
                    f_1553_22708_22763(System.Collections.Generic.HashSet<System.Tuple<string, System.Type>>
                    this_param, System.Tuple<string, System.Type>
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 22708, 22763);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 21352, 22779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 21352, 22779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void DefineMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 22795, 27815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23110, 23138);

                    bool
                    needStaticCtor = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23156, 23185);

                    bool
                    needDefaultCtor = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23203, 23230);

                    bool
                    hasAnyMethods = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23248, 23316);

                    List<FunctionMemberAst>
                    staticCtors = f_1553_23286_23315()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23334, 23404);

                    List<FunctionMemberAst>
                    instanceCtors = f_1553_23374_23403()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23424, 25110);
                        foreach (var member in f_1553_23447_23473_I(f_1553_23447_23473(_typeDefinitionAst)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23424, 25110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23515, 23567);

                            var
                            propertyMemberAst = member as PropertyMemberAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23589, 25091) || true) && (propertyMemberAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23589, 25091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23668, 23702);

                                f_1553_23668_23701(this, propertyMemberAst);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23728, 24157) || true) && (f_1553_23732_23762(propertyMemberAst) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23728, 24157);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23828, 24130) || true) && (f_1553_23832_23858(propertyMemberAst))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23828, 24130);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 23924, 23946);

                                        needStaticCtor = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23828, 24130);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23828, 24130);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24076, 24099);

                                        needDefaultCtor = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23828, 24130);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23728, 24157);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23589, 25091);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 23589, 25091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24255, 24310);

                                FunctionMemberAst
                                method = member as FunctionMemberAst
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24336, 24539);

                                f_1553_24336_24538(method != null, f_1553_24371_24537("Unexpected subtype of MemberAst '{0}'. Expect `{1}`", f_1553_24473_24494(f_1553_24473_24489(member)), f_1553_24496_24536(f_1553_24496_24531(typeof(FunctionMemberAst)))));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24565, 24970) || true) && (f_1553_24569_24589(method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 24565, 24970);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24647, 24943) || true) && (f_1553_24651_24666(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 24647, 24943);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24732, 24756);

                                        f_1553_24732_24755(staticCtors, method);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 24647, 24943);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 24647, 24943);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24886, 24912);

                                        f_1553_24886_24911(instanceCtors, method);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 24647, 24943);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 24565, 24970);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 24998, 25019);

                                hasAnyMethods = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25047, 25068);

                                f_1553_25047_25067(this, method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23589, 25091);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 23424, 25110);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1687);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25477, 25578) || true) && (hasAnyMethods)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 25477, 25578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25536, 25559);

                        needDefaultCtor = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 25477, 25578);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25598, 26196) || true) && (needStaticCtor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 25598, 26196);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25658, 26177);
                            foreach (var ctor in f_1553_25679_25690_I(staticCtors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 25658, 26177);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25740, 25808);

                                var
                                parameters = f_1553_25757_25807(((IParameterMetadataProvider)f_1553_25786_25795(ctor)))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 25999, 26154) || true) && (parameters == null || (DynAbs.Tracing.TraceSender.Expression_False(1553, 26003, 26046) || f_1553_26025_26041(parameters) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 25999, 26154);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26104, 26127);

                                    needStaticCtor = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 25999, 26154);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 25658, 26177);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 520);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 520);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 25598, 26196);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26216, 26335) || true) && (needDefaultCtor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 26216, 26335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26277, 26316);

                        needDefaultCtor = !f_1553_26296_26315(instanceCtors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 26216, 26335);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26447, 26839) || true) && (needStaticCtor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 26447, 26839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26507, 26662);

                        var
                        staticCtorAst = f_1553_26527_26661(f_1553_26566_26595(), _typeDefinitionAst, SpecialMemberFunctionType.StaticConstructor)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26684, 26820);

                        f_1553_26684_26819(this, staticCtorAst, null, true, Reflection.MethodAttributes.Private | Reflection.MethodAttributes.Static, Type.EmptyTypes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 26447, 26839);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26859, 27800) || true) && (_baseClassHasDefaultCtor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 26859, 27800);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26929, 27303) || true) && (needDefaultCtor)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 26929, 27303);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 26998, 27155);

                            var
                            defaultCtorAst = f_1553_27019_27154(f_1553_27058_27087(), _typeDefinitionAst, SpecialMemberFunctionType.DefaultConstructor)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 27181, 27280);

                            f_1553_27181_27279(this, defaultCtorAst, null, true, Reflection.MethodAttributes.Public, Type.EmptyTypes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 26929, 27303);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 26859, 27800);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 26859, 27800);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 27385, 27781) || true) && (!f_1553_27390_27409(instanceCtors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 27385, 27781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 27459, 27705);

                            f_1553_27459_27704(_parser, f_1553_27479_27504(_typeDefinitionAst), nameof(ParserStrings.BaseClassNoDefaultCtor), f_1553_27610_27646(), f_1553_27677_27703(f_1553_27677_27698(_typeBuilder)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 27731, 27758);

                            this.HasFatalErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 27385, 27781);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 26859, 27800);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 22795, 27815);

                    System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    f_1553_23286_23315()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 23286, 23315);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    f_1553_23374_23403()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 23374, 23403);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_23447_23473(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Members;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 23447, 23473);
                        return return_v;
                    }


                    int
                    f_1553_23668_23701(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.PropertyMemberAst
                    propertyMemberAst)
                    {
                        this_param.DefineProperty(propertyMemberAst);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 23668, 23701);
                        return 0;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_23732_23762(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 23732, 23762);
                        return return_v;
                    }


                    bool
                    f_1553_23832_23858(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 23832, 23858);
                        return return_v;
                    }


                    System.Type
                    f_1553_24473_24489(System.Management.Automation.Language.MemberAst
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24473, 24489);
                        return return_v;
                    }


                    string
                    f_1553_24473_24494(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 24473, 24494);
                        return return_v;
                    }


                    System.Type
                    f_1553_24496_24531(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24496, 24531);
                        return return_v;
                    }


                    string
                    f_1553_24496_24536(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 24496, 24536);
                        return return_v;
                    }


                    string
                    f_1553_24371_24537(string
                    formatSpec, string
                    o1, string
                    o2)
                    {
                        var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24371, 24537);
                        return return_v;
                    }


                    int
                    f_1553_24336_24538(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24336, 24538);
                        return 0;
                    }


                    bool
                    f_1553_24569_24589(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 24569, 24589);
                        return return_v;
                    }


                    bool
                    f_1553_24651_24666(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 24651, 24666);
                        return return_v;
                    }


                    int
                    f_1553_24732_24755(System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24732, 24755);
                        return 0;
                    }


                    int
                    f_1553_24886_24911(System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 24886, 24911);
                        return 0;
                    }


                    int
                    f_1553_25047_25067(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    functionMemberAst)
                    {
                        this_param.DefineMethod(functionMemberAst);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 25047, 25067);
                        return 0;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_23447_23473_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 23447, 23473);
                        return return_v;
                    }


                    System.Management.Automation.Language.ScriptBlockAst
                    f_1553_25786_25795(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 25786, 25795);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    f_1553_25757_25807(System.Management.Automation.Language.IParameterMetadataProvider
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 25757, 25807);
                        return return_v;
                    }


                    int
                    f_1553_26025_26041(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 26025, 26041);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    f_1553_25679_25690_I(System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 25679, 25690);
                        return return_v;
                    }


                    bool
                    f_1553_26296_26315(System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    source)
                    {
                        var return_v = source.Any<System.Management.Automation.Language.FunctionMemberAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 26296, 26315);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_26566_26595()
                    {
                        var return_v = PositionUtilities.EmptyExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 26566, 26595);
                        return return_v;
                    }


                    System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                    f_1553_26527_26661(System.Management.Automation.Language.IScriptExtent
                    extent, System.Management.Automation.Language.TypeDefinitionAst
                    definingType, System.Management.Automation.Language.SpecialMemberFunctionType
                    type)
                    {
                        var return_v = new System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst(extent, definingType, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 26527, 26661);
                        return return_v;
                    }


                    int
                    f_1553_26684_26819(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                    ipmp, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributeAsts, bool
                    isHidden, System.Reflection.MethodAttributes
                    methodAttributes, System.Type[]
                    parameterTypes)
                    {
                        this_param.DefineConstructor((System.Management.Automation.Language.IParameterMetadataProvider)ipmp, attributeAsts, isHidden, methodAttributes, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 26684, 26819);
                        return 0;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_27058_27087()
                    {
                        var return_v = PositionUtilities.EmptyExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27058, 27087);
                        return return_v;
                    }


                    System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                    f_1553_27019_27154(System.Management.Automation.Language.IScriptExtent
                    extent, System.Management.Automation.Language.TypeDefinitionAst
                    definingType, System.Management.Automation.Language.SpecialMemberFunctionType
                    type)
                    {
                        var return_v = new System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst(extent, definingType, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 27019, 27154);
                        return return_v;
                    }


                    int
                    f_1553_27181_27279(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.CompilerGeneratedMemberFunctionAst
                    ipmp, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributeAsts, bool
                    isHidden, System.Reflection.MethodAttributes
                    methodAttributes, System.Type[]
                    parameterTypes)
                    {
                        this_param.DefineConstructor((System.Management.Automation.Language.IParameterMetadataProvider)ipmp, attributeAsts, isHidden, methodAttributes, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 27181, 27279);
                        return 0;
                    }


                    bool
                    f_1553_27390_27409(System.Collections.Generic.List<System.Management.Automation.Language.FunctionMemberAst>
                    source)
                    {
                        var return_v = source.Any<System.Management.Automation.Language.FunctionMemberAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 27390, 27409);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_27479_27504(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27479, 27504);
                        return return_v;
                    }


                    string
                    f_1553_27610_27646()
                    {
                        var return_v = ParserStrings.BaseClassNoDefaultCtor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27610, 27646);
                        return return_v;
                    }


                    System.Type
                    f_1553_27677_27698(System.Reflection.Emit.TypeBuilder
                    this_param)
                    {
                        var return_v = this_param.BaseType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27677, 27698);
                        return return_v;
                    }


                    string
                    f_1553_27677_27703(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27677, 27703);
                        return return_v;
                    }


                    int
                    f_1553_27459_27704(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 27459, 27704);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 22795, 27815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 22795, 27815);
                }
            }

            private void DefineProperty(PropertyMemberAst propertyMemberAst)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 27831, 29156);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 27928, 28301) || true) && (f_1553_27932_27986(_definedProperties, f_1553_27963_27985(propertyMemberAst)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 27928, 28301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28028, 28253);

                        f_1553_28028_28252(_parser, f_1553_28048_28072(propertyMemberAst), nameof(ParserStrings.MemberAlreadyDefined), f_1553_28168_28202(), f_1553_28229_28251(propertyMemberAst));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28275, 28282);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 27928, 28301);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28321, 28387);

                    f_1553_28321_28386(
                                    _definedProperties, f_1553_28344_28366(propertyMemberAst), propertyMemberAst);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28407, 28417);

                    Type
                    type
                    = default(Type);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28435, 28821) || true) && (f_1553_28439_28469(propertyMemberAst) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 28435, 28821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28519, 28541);

                        type = typeof(object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 28435, 28821);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 28435, 28821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28623, 28690);

                        type = f_1553_28630_28689(f_1553_28630_28669(f_1553_28630_28660(propertyMemberAst)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28712, 28802);

                        f_1553_28712_28801(type != null, "Semantic checks should have ensure type can't be null");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 28435, 28821);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 28841, 28913);

                    PropertyBuilder
                    property = f_1553_28868_28912(this, propertyMemberAst, type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29017, 29141);

                    f_1553_29017_29140(property, f_1553_29050_29078(propertyMemberAst), _parser, AttributeTargets.Field | AttributeTargets.Property);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 27831, 29156);

                    string
                    f_1553_27963_27985(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 27963, 27985);
                        return return_v;
                    }


                    bool
                    f_1553_27932_27986(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.PropertyMemberAst>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 27932, 27986);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_28048_28072(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28048, 28072);
                        return return_v;
                    }


                    string
                    f_1553_28168_28202()
                    {
                        var return_v = ParserStrings.MemberAlreadyDefined;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28168, 28202);
                        return return_v;
                    }


                    string
                    f_1553_28229_28251(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28229, 28251);
                        return return_v;
                    }


                    int
                    f_1553_28028_28252(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 28028, 28252);
                        return 0;
                    }


                    string
                    f_1553_28344_28366(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28344, 28366);
                        return return_v;
                    }


                    int
                    f_1553_28321_28386(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.PropertyMemberAst>
                    this_param, string
                    key, System.Management.Automation.Language.PropertyMemberAst
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 28321, 28386);
                        return 0;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_28439_28469(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.PropertyType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28439, 28469);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_28630_28660(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.PropertyType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28630, 28660);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_28630_28669(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 28630, 28669);
                        return return_v;
                    }


                    System.Type
                    f_1553_28630_28689(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 28630, 28689);
                        return return_v;
                    }


                    int
                    f_1553_28712_28801(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 28712, 28801);
                        return 0;
                    }


                    System.Reflection.Emit.PropertyBuilder
                    f_1553_28868_28912(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.PropertyMemberAst
                    propertyMemberAst, System.Type
                    type)
                    {
                        var return_v = this_param.EmitPropertyIl(propertyMemberAst, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 28868, 28912);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_29050_29078(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 29050, 29078);
                        return return_v;
                    }


                    int
                    f_1553_29017_29140(System.Reflection.Emit.PropertyBuilder
                    member, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributes, System.Management.Automation.Language.Parser
                    parser, System.AttributeTargets
                    attributeTargets)
                    {
                        DefineCustomAttributes(member, attributes, parser, attributeTargets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 29017, 29140);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 27831, 29156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 27831, 29156);
                }
            }

            private PropertyBuilder EmitPropertyIl(PropertyMemberAst propertyMemberAst, Type type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 29172, 34239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29344, 29397);

                    var
                    backingFieldAttributes = FieldAttributes.Private
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29514, 29617);

                    var
                    getSetAttributes = Reflection.MethodAttributes.SpecialName | Reflection.MethodAttributes.HideBySig
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29635, 29757);

                    getSetAttributes |= (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 29655, 29681) || ((f_1553_29655_29681(propertyMemberAst) && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 29684, 29718)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 29721, 29756))) ? Reflection.MethodAttributes.Public : Reflection.MethodAttributes.Private;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29775, 29949) || true) && (f_1553_29779_29832(this, f_1553_29803_29825(propertyMemberAst), type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 29775, 29949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29874, 29930);

                        getSetAttributes |= Reflection.MethodAttributes.Virtual;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 29775, 29949);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 29969, 30186) || true) && (f_1553_29973_29999(propertyMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 29969, 30186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30041, 30090);

                        backingFieldAttributes |= FieldAttributes.Static;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30112, 30167);

                        getSetAttributes |= Reflection.MethodAttributes.Static;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 29969, 30186);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30265, 30383);

                    string
                    backingFieldName = f_1553_30291_30382(f_1553_30305_30333(), "<{0}>k__BackingField", f_1553_30359_30381(propertyMemberAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30401, 30493);

                    var
                    backingField = f_1553_30420_30492(_typeBuilder, backingFieldName, type, backingFieldAttributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30513, 30548);

                    bool
                    hasValidateAttributes = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30566, 31157) || true) && (f_1553_30570_30598(propertyMemberAst) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 30566, 31157);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30657, 30662);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30648, 31138) || true) && (i < f_1553_30668_30702(f_1553_30668_30696(propertyMemberAst)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30704, 30707)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 30648, 31138))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 30648, 31138);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30757, 30848);

                                Type
                                attributeType = f_1553_30778_30847(f_1553_30778_30818(f_1553_30778_30809(f_1553_30778_30806(propertyMemberAst), i)))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 30874, 31115) || true) && (attributeType != null && (DynAbs.Tracing.TraceSender.Expression_True(1553, 30878, 30965) && f_1553_30903_30965(attributeType, typeof(ValidateArgumentsAttribute))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 30874, 31115);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31023, 31052);

                                    hasValidateAttributes = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1553, 31082, 31088);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 30874, 31115);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 491);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 491);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 30566, 31157);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31282, 31409);

                    PropertyBuilder
                    property = f_1553_31309_31408(_typeBuilder, f_1553_31337_31359(propertyMemberAst), Reflection.PropertyAttributes.None, type, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31483, 31623);

                    MethodBuilder
                    getMethod = f_1553_31509_31622(_typeBuilder, f_1553_31535_31580("get_", f_1553_31557_31579(propertyMemberAst)), getSetAttributes, type, Type.EmptyTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31641, 31691);

                    ILGenerator
                    getIlGen = f_1553_31664_31690(getMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31709, 32184) || true) && (f_1553_31713_31739(propertyMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 31709, 32184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31812, 31856);

                        f_1553_31812_31855(                    // static
                                            getIlGen, OpCodes.Ldsfld, backingField);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 31878, 31905);

                        f_1553_31878_31904(getIlGen, OpCodes.Ret);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 31709, 32184);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 31709, 32184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32020, 32051);

                        f_1553_32020_32050(                    // instance
                                            getIlGen, OpCodes.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32073, 32116);

                        f_1553_32073_32115(getIlGen, OpCodes.Ldfld, backingField);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32138, 32165);

                        f_1553_32138_32164(getIlGen, OpCodes.Ret);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 31709, 32184);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32258, 32402);

                    MethodBuilder
                    setMethod = f_1553_32284_32401(_typeBuilder, f_1553_32310_32355("set_", f_1553_32332_32354(propertyMemberAst)), getSetAttributes, null, new Type[] { type })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32420, 32470);

                    ILGenerator
                    setIlGen = f_1553_32443_32469(setMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32490, 33266) || true) && (hasValidateAttributes)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 32490, 33266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32557, 32588);

                        Type
                        typeToLoad = _typeBuilder
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32610, 32653);

                        f_1553_32610_32652(setIlGen, OpCodes.Ldtoken, typeToLoad);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32675, 32748);

                        f_1553_32675_32747(setIlGen, OpCodes.Call, f_1553_32703_32746(typeof(Type), "GetTypeFromHandle"));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32800, 32853);

                        f_1553_32800_32852(setIlGen, OpCodes.Ldstr, f_1553_32829_32851(propertyMemberAst));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 32900, 32978);

                        f_1553_32900_32977(setIlGen, (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 32914, 32940) || ((f_1553_32914_32940(propertyMemberAst) && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 32943, 32958)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 32961, 32976))) ? OpCodes.Ldarg_0 : OpCodes.Ldarg_1);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33018, 33144) || true) && (f_1553_33022_33038(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 33018, 33144);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33088, 33121);

                            f_1553_33088_33120(setIlGen, OpCodes.Box, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 33018, 33144);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33168, 33247);

                        f_1553_33168_33246(
                                            setIlGen, OpCodes.Call, CachedReflectionInfo.ClassOps_ValidateSetProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 32490, 33266);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33286, 33705) || true) && (f_1553_33290_33316(propertyMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 33286, 33705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33358, 33389);

                        f_1553_33358_33388(setIlGen, OpCodes.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33411, 33455);

                        f_1553_33411_33454(setIlGen, OpCodes.Stsfld, backingField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 33286, 33705);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 33286, 33705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33537, 33568);

                        f_1553_33537_33567(setIlGen, OpCodes.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33590, 33621);

                        f_1553_33590_33620(setIlGen, OpCodes.Ldarg_1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33643, 33686);

                        f_1553_33643_33685(setIlGen, OpCodes.Stfld, backingField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 33286, 33705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33725, 33752);

                    f_1553_33725_33751(
                                    setIlGen, OpCodes.Ret);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33933, 33966);

                    f_1553_33933_33965(
                                    // Map the two methods created above to our PropertyBuilder to
                                    // their corresponding behaviors, "get" and "set" respectively.
                                    property, getMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 33984, 34017);

                    f_1553_33984_34016(property, setMethod);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34037, 34188) || true) && (f_1553_34041_34067(propertyMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 34037, 34188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34109, 34169);

                        f_1553_34109_34168(property, s_hiddenCustomAttributeBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 34037, 34188);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34208, 34224);

                    return property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 29172, 34239);

                    bool
                    f_1553_29655_29681(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsPublic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 29655, 29681);
                        return return_v;
                    }


                    string
                    f_1553_29803_29825(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 29803, 29825);
                        return return_v;
                    }


                    bool
                    f_1553_29779_29832(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, string
                    name, System.Type
                    type)
                    {
                        var return_v = this_param.ShouldImplementProperty(name, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 29779, 29832);
                        return return_v;
                    }


                    bool
                    f_1553_29973_29999(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 29973, 29999);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1553_30305_30333()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30305, 30333);
                        return return_v;
                    }


                    string
                    f_1553_30359_30381(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30359, 30381);
                        return return_v;
                    }


                    string
                    f_1553_30291_30382(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 30291, 30382);
                        return return_v;
                    }


                    System.Reflection.Emit.FieldBuilder
                    f_1553_30420_30492(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    fieldName, System.Type
                    type, System.Reflection.FieldAttributes
                    attributes)
                    {
                        var return_v = this_param.DefineField(fieldName, type, attributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 30420, 30492);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_30570_30598(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30570, 30598);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_30668_30696(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30668, 30696);
                        return return_v;
                    }


                    int
                    f_1553_30668_30702(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30668, 30702);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_30778_30806(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30778, 30806);
                        return return_v;
                    }


                    System.Management.Automation.Language.AttributeAst
                    f_1553_30778_30809(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30778, 30809);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_30778_30818(System.Management.Automation.Language.AttributeAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 30778, 30818);
                        return return_v;
                    }


                    System.Type
                    f_1553_30778_30847(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionAttributeType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 30778, 30847);
                        return return_v;
                    }


                    bool
                    f_1553_30903_30965(System.Type
                    this_param, System.Type
                    c)
                    {
                        var return_v = this_param.IsSubclassOf(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 30903, 30965);
                        return return_v;
                    }


                    string
                    f_1553_31337_31359(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 31337, 31359);
                        return return_v;
                    }


                    System.Reflection.Emit.PropertyBuilder
                    f_1553_31309_31408(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    name, System.Reflection.PropertyAttributes
                    attributes, System.Type
                    returnType, System.Type[]?
                    parameterTypes)
                    {
                        var return_v = this_param.DefineProperty(name, attributes, returnType, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31309, 31408);
                        return return_v;
                    }


                    string
                    f_1553_31557_31579(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 31557, 31579);
                        return return_v;
                    }


                    string
                    f_1553_31535_31580(string
                    str0, string
                    str1)
                    {
                        var return_v = string.Concat(str0, str1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31535, 31580);
                        return return_v;
                    }


                    System.Reflection.Emit.MethodBuilder
                    f_1553_31509_31622(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    name, System.Reflection.MethodAttributes
                    attributes, System.Type
                    returnType, System.Type[]
                    parameterTypes)
                    {
                        var return_v = this_param.DefineMethod(name, attributes, returnType, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31509, 31622);
                        return return_v;
                    }


                    System.Reflection.Emit.ILGenerator
                    f_1553_31664_31690(System.Reflection.Emit.MethodBuilder
                    this_param)
                    {
                        var return_v = this_param.GetILGenerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31664, 31690);
                        return return_v;
                    }


                    bool
                    f_1553_31713_31739(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 31713, 31739);
                        return return_v;
                    }


                    int
                    f_1553_31812_31855(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31812, 31855);
                        return 0;
                    }


                    int
                    f_1553_31878_31904(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 31878, 31904);
                        return 0;
                    }


                    int
                    f_1553_32020_32050(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32020, 32050);
                        return 0;
                    }


                    int
                    f_1553_32073_32115(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32073, 32115);
                        return 0;
                    }


                    int
                    f_1553_32138_32164(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32138, 32164);
                        return 0;
                    }


                    string
                    f_1553_32332_32354(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 32332, 32354);
                        return return_v;
                    }


                    string
                    f_1553_32310_32355(string
                    str0, string
                    str1)
                    {
                        var return_v = string.Concat(str0, str1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32310, 32355);
                        return return_v;
                    }


                    System.Reflection.Emit.MethodBuilder
                    f_1553_32284_32401(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    name, System.Reflection.MethodAttributes
                    attributes, System.Type?
                    returnType, System.Type[]
                    parameterTypes)
                    {
                        var return_v = this_param.DefineMethod(name, attributes, returnType, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32284, 32401);
                        return return_v;
                    }


                    System.Reflection.Emit.ILGenerator
                    f_1553_32443_32469(System.Reflection.Emit.MethodBuilder
                    this_param)
                    {
                        var return_v = this_param.GetILGenerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32443, 32469);
                        return return_v;
                    }


                    int
                    f_1553_32610_32652(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Type
                    cls)
                    {
                        this_param.Emit(opcode, cls);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32610, 32652);
                        return 0;
                    }


                    System.Reflection.MethodInfo?
                    f_1553_32703_32746(System.Type
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMethod(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32703, 32746);
                        return return_v;
                    }


                    int
                    f_1553_32675_32747(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.MethodInfo
                    meth)
                    {
                        this_param.Emit(opcode, meth);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32675, 32747);
                        return 0;
                    }


                    string
                    f_1553_32829_32851(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 32829, 32851);
                        return return_v;
                    }


                    int
                    f_1553_32800_32852(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, string
                    str)
                    {
                        this_param.Emit(opcode, str);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32800, 32852);
                        return 0;
                    }


                    bool
                    f_1553_32914_32940(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 32914, 32940);
                        return return_v;
                    }


                    int
                    f_1553_32900_32977(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 32900, 32977);
                        return 0;
                    }


                    bool
                    f_1553_33022_33038(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 33022, 33038);
                        return return_v;
                    }


                    int
                    f_1553_33088_33120(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Type
                    cls)
                    {
                        this_param.Emit(opcode, cls);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33088, 33120);
                        return 0;
                    }


                    int
                    f_1553_33168_33246(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.MethodInfo
                    meth)
                    {
                        this_param.Emit(opcode, meth);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33168, 33246);
                        return 0;
                    }


                    bool
                    f_1553_33290_33316(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 33290, 33316);
                        return return_v;
                    }


                    int
                    f_1553_33358_33388(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33358, 33388);
                        return 0;
                    }


                    int
                    f_1553_33411_33454(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33411, 33454);
                        return 0;
                    }


                    int
                    f_1553_33537_33567(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33537, 33567);
                        return 0;
                    }


                    int
                    f_1553_33590_33620(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33590, 33620);
                        return 0;
                    }


                    int
                    f_1553_33643_33685(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33643, 33685);
                        return 0;
                    }


                    int
                    f_1553_33725_33751(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33725, 33751);
                        return 0;
                    }


                    int
                    f_1553_33933_33965(System.Reflection.Emit.PropertyBuilder
                    this_param, System.Reflection.Emit.MethodBuilder
                    mdBuilder)
                    {
                        this_param.SetGetMethod(mdBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33933, 33965);
                        return 0;
                    }


                    int
                    f_1553_33984_34016(System.Reflection.Emit.PropertyBuilder
                    this_param, System.Reflection.Emit.MethodBuilder
                    mdBuilder)
                    {
                        this_param.SetSetMethod(mdBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 33984, 34016);
                        return 0;
                    }


                    bool
                    f_1553_34041_34067(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsHidden;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 34041, 34067);
                        return return_v;
                    }


                    int
                    f_1553_34109_34168(System.Reflection.Emit.PropertyBuilder
                    this_param, System.Reflection.Emit.CustomAttributeBuilder
                    customBuilder)
                    {
                        this_param.SetCustomAttribute(customBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 34109, 34168);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 29172, 34239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 29172, 34239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool CheckForDuplicateOverload(FunctionMemberAst functionMemberAst, Type[] newParameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 34255, 36609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34385, 34434);

                    List<Tuple<FunctionMemberAst, Type[]>>
                    overloads
                    = default(List<Tuple<FunctionMemberAst, Type[]>>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34452, 36481) || true) && (!f_1553_34457_34523(_definedMethods, f_1553_34485_34507(functionMemberAst), out overloads))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 34452, 36481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34565, 34622);

                        overloads = f_1553_34577_34621();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34644, 34699);

                        f_1553_34644_34698(_definedMethods, f_1553_34664_34686(functionMemberAst), overloads);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 34452, 36481);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 34452, 36481);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34781, 36462);
                            foreach (var overload in f_1553_34806_34815_I(overloads))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 34781, 36462);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 34865, 34905);

                                var
                                overloadParameters = f_1553_34890_34904(overload)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35016, 35163) || true) && (f_1553_35020_35040(newParameters) != f_1553_35044_35069(overloadParameters))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 35016, 35163);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35127, 35136);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 35016, 35163);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35191, 35216);

                                var
                                sameSignature = true
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35251, 35256);
                                    for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35242, 35576) || true) && (i < f_1553_35262_35282(newParameters))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35284, 35287)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 35242, 35576))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 35242, 35576);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35345, 35549) || true) && (newParameters[i] != overloadParameters[i])
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 35345, 35549);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35456, 35478);

                                            sameSignature = false;
                                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 35512, 35518);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 35345, 35549);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 335);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 335);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35604, 36439) || true) && (sameSignature)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 35604, 36439);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 35850, 36412) || true) && (f_1553_35854_35877(f_1553_35854_35868(overload)) == f_1553_35881_35907(functionMemberAst) || (DynAbs.Tracing.TraceSender.Expression_False(1553, 35854, 35976) || f_1553_35944_35976_M(!functionMemberAst.IsConstructor)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 35850, 36412);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36042, 36335);

                                        f_1553_36042_36334(_parser, f_1553_36062_36090(functionMemberAst) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IScriptExtent>(1553, 36062, 36118) ?? f_1553_36094_36118(functionMemberAst)), nameof(ParserStrings.MemberAlreadyDefined), f_1553_36238_36272(), f_1553_36311_36333(functionMemberAst));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36369, 36381);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 35850, 36412);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 35604, 36439);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 34781, 36462);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1682);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1682);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 34452, 36481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36501, 36563);

                    f_1553_36501_36562(
                                    overloads, f_1553_36515_36561(functionMemberAst, newParameters));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36581, 36594);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 34255, 36609);

                    string
                    f_1553_34485_34507(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 34485, 34507);
                        return return_v;
                    }


                    bool
                    f_1553_34457_34523(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>>
                    this_param, string
                    key, out System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 34457, 34523);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    f_1553_34577_34621()
                    {
                        var return_v = new System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 34577, 34621);
                        return return_v;
                    }


                    string
                    f_1553_34664_34686(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 34664, 34686);
                        return return_v;
                    }


                    int
                    f_1553_34644_34698(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>>
                    this_param, string
                    key, System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 34644, 34698);
                        return 0;
                    }


                    System.Type[]
                    f_1553_34890_34904(System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 34890, 34904);
                        return return_v;
                    }


                    int
                    f_1553_35020_35040(System.Type[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35020, 35040);
                        return return_v;
                    }


                    int
                    f_1553_35044_35069(System.Type[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35044, 35069);
                        return return_v;
                    }


                    int
                    f_1553_35262_35282(System.Type[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35262, 35282);
                        return return_v;
                    }


                    System.Management.Automation.Language.FunctionMemberAst
                    f_1553_35854_35868(System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35854, 35868);
                        return return_v;
                    }


                    bool
                    f_1553_35854_35877(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35854, 35877);
                        return return_v;
                    }


                    bool
                    f_1553_35881_35907(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35881, 35907);
                        return return_v;
                    }


                    bool
                    f_1553_35944_35976_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 35944, 35976);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_36062_36090(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.NameExtent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 36062, 36090);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_36094_36118(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 36094, 36118);
                        return return_v;
                    }


                    string
                    f_1553_36238_36272()
                    {
                        var return_v = ParserStrings.MemberAlreadyDefined;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 36238, 36272);
                        return return_v;
                    }


                    string
                    f_1553_36311_36333(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 36311, 36333);
                        return return_v;
                    }


                    int
                    f_1553_36042_36334(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 36042, 36334);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    f_1553_34806_34815_I(System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 34806, 34815);
                        return return_v;
                    }


                    System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>
                    f_1553_36515_36561(System.Management.Automation.Language.FunctionMemberAst
                    item1, System.Type[]
                    item2)
                    {
                        var return_v = Tuple.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 36515, 36561);
                        return return_v;
                    }


                    int
                    f_1553_36501_36562(System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>
                    this_param, System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 36501, 36562);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 34255, 36609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 34255, 36609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Type[] GetParameterTypes(FunctionMemberAst functionMemberAst)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 36625, 38413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36727, 36803);

                    var
                    parameters = f_1553_36744_36802(((IParameterMetadataProvider)functionMemberAst))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36821, 36927) || true) && (parameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 36821, 36927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36885, 36908);

                        return Type.EmptyTypes;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 36821, 36927);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36947, 36970);

                    bool
                    anyErrors = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 36988, 37028);

                    var
                    result = new Type[f_1553_37010_37026(parameters)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37055, 37060);
                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37046, 38345) || true) && (i < f_1553_37066_37082(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37084, 37087)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 37046, 38345))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 37046, 38345);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37129, 37220);

                            var
                            typeConstraint = f_1553_37150_37219(f_1553_37150_37202(f_1553_37150_37174(f_1553_37150_37163(parameters, i))))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37242, 37428);

                            var
                            paramType = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 37258, 37282) || (((typeConstraint != null)
                            && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 37326, 37369)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 37413, 37427))) ? f_1553_37326_37369(f_1553_37326_37349(typeConstraint)) : typeof(object)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37450, 38280) || true) && (paramType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 37450, 38280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37521, 37749);

                                f_1553_37521_37748(_parser, f_1553_37541_37562(typeConstraint), nameof(ParserStrings.TypeNotFound), f_1553_37658_37684(), f_1553_37715_37747(f_1553_37715_37738(typeConstraint)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37775, 37792);

                                anyErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 37450, 38280);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 37450, 38280);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37842, 38280) || true) && (paramType == typeof(void) || (DynAbs.Tracing.TraceSender.Expression_False(1553, 37846, 37908) || f_1553_37875_37908(paramType)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 37842, 38280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 37958, 38214);

                                    f_1553_37958_38213(_parser, f_1553_37978_37999(typeConstraint), nameof(ParserStrings.TypeNotAllowedForParameter), f_1553_38109_38149(), f_1553_38180_38212(f_1553_38180_38203(typeConstraint)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38240, 38257);

                                    anyErrors = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 37842, 38280);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 37450, 38280);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38304, 38326);

                            result[i] = paramType;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1300);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38365, 38398);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 38372, 38381) || ((anyErrors && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 38384, 38388)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 38391, 38397))) ? null : result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 36625, 38413);

                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    f_1553_36744_36802(System.Management.Automation.Language.IParameterMetadataProvider
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 36744, 36802);
                        return return_v;
                    }


                    int
                    f_1553_37010_37026(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37010, 37026);
                        return return_v;
                    }


                    int
                    f_1553_37066_37082(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37066, 37082);
                        return return_v;
                    }


                    System.Management.Automation.Language.ParameterAst
                    f_1553_37150_37163(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37150, 37163);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                    f_1553_37150_37174(System.Management.Automation.Language.ParameterAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37150, 37174);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
                    f_1553_37150_37202(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                    source)
                    {
                        var return_v = source.OfType<System.Management.Automation.Language.TypeConstraintAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 37150, 37202);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_37150_37219(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
                    source)
                    {
                        var return_v = source.FirstOrDefault<System.Management.Automation.Language.TypeConstraintAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 37150, 37219);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_37326_37349(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37326, 37349);
                        return return_v;
                    }


                    System.Type
                    f_1553_37326_37369(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 37326, 37369);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_37541_37562(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37541, 37562);
                        return return_v;
                    }


                    string
                    f_1553_37658_37684()
                    {
                        var return_v = ParserStrings.TypeNotFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37658, 37684);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_37715_37738(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37715, 37738);
                        return return_v;
                    }


                    string
                    f_1553_37715_37747(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37715, 37747);
                        return return_v;
                    }


                    int
                    f_1553_37521_37748(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 37521, 37748);
                        return 0;
                    }


                    bool
                    f_1553_37875_37908(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsGenericTypeDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37875, 37908);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_37978_37999(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 37978, 37999);
                        return return_v;
                    }


                    string
                    f_1553_38109_38149()
                    {
                        var return_v = ParserStrings.TypeNotAllowedForParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 38109, 38149);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_38180_38203(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 38180, 38203);
                        return return_v;
                    }


                    string
                    f_1553_38180_38212(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 38180, 38212);
                        return return_v;
                    }


                    int
                    f_1553_37958_38213(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 37958, 38213);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 36625, 38413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 36625, 38413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool MethodExistsOnBaseClassAndFinal(string methodName, Type[] parameterTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 38429, 38941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38548, 38586);

                    Type
                    baseType = f_1553_38564_38585(_typeBuilder)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38699, 38800) || true) && (baseType is TypeBuilder)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 38699, 38800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38768, 38781);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 38699, 38800);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38820, 38876);

                    var
                    mi = f_1553_38829_38875(baseType, methodName, parameterTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 38894, 38926);

                    return mi != null && (DynAbs.Tracing.TraceSender.Expression_True(1553, 38901, 38925) && f_1553_38915_38925(mi));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 38429, 38941);

                    System.Type
                    f_1553_38564_38585(System.Reflection.Emit.TypeBuilder
                    this_param)
                    {
                        var return_v = this_param.BaseType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 38564, 38585);
                        return return_v;
                    }


                    System.Reflection.MethodInfo?
                    f_1553_38829_38875(System.Type
                    this_param, string
                    name, System.Type[]
                    types)
                    {
                        var return_v = this_param.GetMethod(name, types);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 38829, 38875);
                        return return_v;
                    }


                    bool
                    f_1553_38915_38925(System.Reflection.MethodInfo
                    this_param)
                    {
                        var return_v = this_param.IsFinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 38915, 38925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 38429, 38941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 38429, 38941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void DefineMethod(FunctionMemberAst functionMemberAst)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 38957, 42544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39052, 39110);

                    var
                    parameterTypes = f_1553_39073_39109(this, functionMemberAst)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39128, 39289) || true) && (parameterTypes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 39128, 39289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39263, 39270);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 39128, 39289);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39309, 39441) || true) && (f_1553_39313_39373(this, functionMemberAst, parameterTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 39309, 39441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39415, 39422);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 39309, 39441);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39461, 40545) || true) && (f_1553_39465_39496(functionMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 39461, 40545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39538, 39596);

                        var
                        methodAttributes = Reflection.MethodAttributes.Public
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39618, 40344) || true) && (f_1553_39622_39648(functionMemberAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 39618, 40344);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39698, 39744);

                            var
                            parameters = f_1553_39715_39743(functionMemberAst)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39770, 40238) || true) && (f_1553_39774_39790(parameters) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 39770, 40238);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39852, 39935);

                                IScriptExtent
                                errorExtent = f_1553_39880_39934(f_1553_39896_39914(parameters), f_1553_39916_39933(parameters))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 39965, 40174);

                                f_1553_39965_40173(_parser, errorExtent, nameof(ParserStrings.StaticConstructorCantHaveParameters), f_1553_40123_40172());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40204, 40211);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 39770, 40238);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40266, 40321);

                            methodAttributes |= Reflection.MethodAttributes.Static;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 39618, 40344);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40368, 40497);

                        f_1553_40368_40496(this, functionMemberAst, f_1553_40405_40433(functionMemberAst), f_1553_40435_40461(functionMemberAst), methodAttributes, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40519, 40526);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 39461, 40545);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40565, 40760);

                    var
                    attributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 40582, 40608) || ((f_1553_40582_40608(functionMemberAst) && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 40649, 40683)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 40724, 40759))) ? Reflection.MethodAttributes.Public
                    : Reflection.MethodAttributes.Private
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40778, 41355) || true) && (f_1553_40782_40808(functionMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 40778, 41355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40850, 40899);

                        attributes |= Reflection.MethodAttributes.Static;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 40778, 41355);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 40778, 41355);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 40981, 41262) || true) && (f_1553_40985_41061(this, f_1553_41022_41044(functionMemberAst), parameterTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 40981, 41262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41111, 41163);

                            attributes |= Reflection.MethodAttributes.HideBySig;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41189, 41239);

                            attributes |= Reflection.MethodAttributes.NewSlot;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 40981, 41262);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41286, 41336);

                        attributes |= Reflection.MethodAttributes.Virtual;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 40778, 41355);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41375, 41426);

                    var
                    returnType = f_1553_41392_41425(functionMemberAst)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41444, 41800) || true) && (returnType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 41444, 41800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41508, 41752);

                        f_1553_41508_41751(_parser, f_1553_41528_41563(f_1553_41528_41556(functionMemberAst)), nameof(ParserStrings.TypeNotFound), f_1553_41651_41677(), f_1553_41704_41750(f_1553_41704_41741(f_1553_41704_41732(functionMemberAst))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41774, 41781);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 41444, 41800);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41820, 41923);

                    var
                    method = f_1553_41833_41922(_typeBuilder, f_1553_41859_41881(functionMemberAst), attributes, returnType, parameterTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 41941, 42036);

                    f_1553_41941_42035(method, f_1553_41972_42000(functionMemberAst), _parser, AttributeTargets.Method);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42054, 42203) || true) && (f_1553_42058_42084(functionMemberAst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 42054, 42203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42126, 42184);

                        f_1553_42126_42183(method, s_hiddenCustomAttributeBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 42054, 42203);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42223, 42265);

                    var
                    ilGenerator = f_1553_42241_42264(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42283, 42529);

                    f_1553_42283_42528(this, functionMemberAst, ilGenerator, f_1553_42332_42384(this, f_1553_42348_42359(method), f_1553_42361_42383(parameterTypes)), f_1553_42386_42412(functionMemberAst), parameterTypes, returnType, (i, n) => method.DefineParameter(i, ParameterAttributes.None, n));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 38957, 42544);

                    System.Type[]
                    f_1553_39073_39109(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    functionMemberAst)
                    {
                        var return_v = this_param.GetParameterTypes(functionMemberAst);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39073, 39109);
                        return return_v;
                    }


                    bool
                    f_1553_39313_39373(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    functionMemberAst, System.Type[]
                    newParameters)
                    {
                        var return_v = this_param.CheckForDuplicateOverload(functionMemberAst, newParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39313, 39373);
                        return return_v;
                    }


                    bool
                    f_1553_39465_39496(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 39465, 39496);
                        return return_v;
                    }


                    bool
                    f_1553_39622_39648(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 39622, 39648);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    f_1553_39715_39743(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 39715, 39743);
                        return return_v;
                    }


                    int
                    f_1553_39774_39790(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 39774, 39790);
                        return return_v;
                    }


                    System.Management.Automation.Language.ParameterAst
                    f_1553_39896_39914(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    source)
                    {
                        var return_v = source.First<System.Management.Automation.Language.ParameterAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39896, 39914);
                        return return_v;
                    }


                    System.Management.Automation.Language.ParameterAst
                    f_1553_39916_39933(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    source)
                    {
                        var return_v = source.Last<System.Management.Automation.Language.ParameterAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39916, 39933);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_39880_39934(System.Management.Automation.Language.ParameterAst
                    first, System.Management.Automation.Language.ParameterAst
                    last)
                    {
                        var return_v = Parser.ExtentOf((System.Management.Automation.Language.Ast)first, (System.Management.Automation.Language.Ast)last);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39880, 39934);
                        return return_v;
                    }


                    string
                    f_1553_40123_40172()
                    {
                        var return_v = ParserStrings.StaticConstructorCantHaveParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 40123, 40172);
                        return return_v;
                    }


                    int
                    f_1553_39965_40173(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 39965, 40173);
                        return 0;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_40405_40433(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 40405, 40433);
                        return return_v;
                    }


                    bool
                    f_1553_40435_40461(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsHidden;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 40435, 40461);
                        return return_v;
                    }


                    int
                    f_1553_40368_40496(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    ipmp, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributeAsts, bool
                    isHidden, System.Reflection.MethodAttributes
                    methodAttributes, System.Type[]
                    parameterTypes)
                    {
                        this_param.DefineConstructor((System.Management.Automation.Language.IParameterMetadataProvider)ipmp, attributeAsts, isHidden, methodAttributes, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 40368, 40496);
                        return 0;
                    }


                    bool
                    f_1553_40582_40608(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsPublic
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 40582, 40608);
                        return return_v;
                    }


                    bool
                    f_1553_40782_40808(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 40782, 40808);
                        return return_v;
                    }


                    string
                    f_1553_41022_41044(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41022, 41044);
                        return return_v;
                    }


                    bool
                    f_1553_40985_41061(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, string
                    methodName, System.Type[]
                    parameterTypes)
                    {
                        var return_v = this_param.MethodExistsOnBaseClassAndFinal(methodName, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 40985, 41061);
                        return return_v;
                    }


                    System.Type
                    f_1553_41392_41425(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.GetReturnType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 41392, 41425);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_41528_41556(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41528, 41556);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_41528_41563(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41528, 41563);
                        return return_v;
                    }


                    string
                    f_1553_41651_41677()
                    {
                        var return_v = ParserStrings.TypeNotFound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41651, 41677);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_41704_41732(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41704, 41732);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_41704_41741(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41704, 41741);
                        return return_v;
                    }


                    string
                    f_1553_41704_41750(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41704, 41750);
                        return return_v;
                    }


                    int
                    f_1553_41508_41751(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 41508, 41751);
                        return 0;
                    }


                    string
                    f_1553_41859_41881(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41859, 41881);
                        return return_v;
                    }


                    System.Reflection.Emit.MethodBuilder
                    f_1553_41833_41922(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    name, System.Reflection.MethodAttributes
                    attributes, System.Type
                    returnType, System.Type[]
                    parameterTypes)
                    {
                        var return_v = this_param.DefineMethod(name, attributes, returnType, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 41833, 41922);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_41972_42000(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 41972, 42000);
                        return return_v;
                    }


                    int
                    f_1553_41941_42035(System.Reflection.Emit.MethodBuilder
                    member, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributes, System.Management.Automation.Language.Parser
                    parser, System.AttributeTargets
                    attributeTargets)
                    {
                        DefineCustomAttributes(member, attributes, parser, attributeTargets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 41941, 42035);
                        return 0;
                    }


                    bool
                    f_1553_42058_42084(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsHidden;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 42058, 42084);
                        return return_v;
                    }


                    int
                    f_1553_42126_42183(System.Reflection.Emit.MethodBuilder
                    this_param, System.Reflection.Emit.CustomAttributeBuilder
                    customBuilder)
                    {
                        this_param.SetCustomAttribute(customBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42126, 42183);
                        return 0;
                    }


                    System.Reflection.Emit.ILGenerator
                    f_1553_42241_42264(System.Reflection.Emit.MethodBuilder
                    this_param)
                    {
                        var return_v = this_param.GetILGenerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42241, 42264);
                        return return_v;
                    }


                    string
                    f_1553_42348_42359(System.Reflection.Emit.MethodBuilder
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 42348, 42359);
                        return return_v;
                    }


                    int
                    f_1553_42361_42383(System.Type[]
                    source)
                    {
                        var return_v = source.Count<System.Type>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42361, 42383);
                        return return_v;
                    }


                    string
                    f_1553_42332_42384(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, string
                    name, int
                    numberOfParameters)
                    {
                        var return_v = this_param.GetMetaDataName(name, numberOfParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42332, 42384);
                        return return_v;
                    }


                    bool
                    f_1553_42386_42412(System.Management.Automation.Language.FunctionMemberAst
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 42386, 42412);
                        return return_v;
                    }


                    int
                    f_1553_42283_42528(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.FunctionMemberAst
                    ipmp, System.Reflection.Emit.ILGenerator
                    ilGenerator, string
                    metadataToken, bool
                    isStatic, System.Type[]
                    parameterTypes, System.Type
                    returnType, System.Action<int, string>
                    parameterNameSetter)
                    {
                        this_param.DefineMethodBody((System.Management.Automation.Language.IParameterMetadataProvider)ipmp, ilGenerator, metadataToken, isStatic, parameterTypes, returnType, parameterNameSetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42283, 42528);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 38957, 42544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 38957, 42544);
                }
            }

            private void DefineConstructor(IParameterMetadataProvider ipmp, ReadOnlyCollection<AttributeAst> attributeAsts, bool isHidden, Reflection.MethodAttributes methodAttributes, Type[] parameterTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 42560, 44164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42788, 42865);

                    bool
                    isStatic = (methodAttributes & Reflection.MethodAttributes.Static) != 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 42883, 43080);

                    var
                    ctor = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 42894, 42902) || ((isStatic
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 42926, 42962)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 42986, 43079))) ? f_1553_42926_42962(_typeBuilder) : f_1553_42986_43079(_typeBuilder, methodAttributes, CallingConventions.Standard, parameterTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43098, 43181);

                    f_1553_43098_43180(ctor, attributeAsts, _parser, AttributeTargets.Constructor);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43199, 43328) || true) && (isHidden)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 43199, 43328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43253, 43309);

                        f_1553_43253_43308(ctor, s_hiddenCustomAttributeBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 43199, 43328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43348, 43388);

                    var
                    ilGenerator = f_1553_43366_43387(ctor)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43408, 43916) || true) && (!isStatic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 43408, 43916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43463, 43497);

                        f_1553_43463_43496(ilGenerator, OpCodes.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43560, 43593);

                        f_1553_43560_43592(
                                            ilGenerator, OpCodes.Ldnull);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43615, 43673);

                        f_1553_43615_43672(ilGenerator, OpCodes.Ldfld, _sessionStateKeeperField);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43695, 43774);

                        f_1553_43695_43773(ilGenerator, OpCodes.Call, s_sessionStateKeeper_GetSessionState, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43845, 43897);

                        f_1553_43845_43896(
                                            ilGenerator, OpCodes.Stfld, _sessionStateField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 43408, 43916);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 43936, 44149);

                    f_1553_43936_44148(this, ipmp, ilGenerator, f_1553_43972_44022(this, f_1553_43988_43997(ctor), f_1553_43999_44021(parameterTypes)), isStatic, parameterTypes, typeof(void), (i, n) => ctor.DefineParameter(i, ParameterAttributes.None, n));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 42560, 44164);

                    System.Reflection.Emit.ConstructorBuilder
                    f_1553_42926_42962(System.Reflection.Emit.TypeBuilder
                    this_param)
                    {
                        var return_v = this_param.DefineTypeInitializer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42926, 42962);
                        return return_v;
                    }


                    System.Reflection.Emit.ConstructorBuilder
                    f_1553_42986_43079(System.Reflection.Emit.TypeBuilder
                    this_param, System.Reflection.MethodAttributes
                    attributes, System.Reflection.CallingConventions
                    callingConvention, System.Type[]
                    parameterTypes)
                    {
                        var return_v = this_param.DefineConstructor(attributes, callingConvention, parameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 42986, 43079);
                        return return_v;
                    }


                    int
                    f_1553_43098_43180(System.Reflection.Emit.ConstructorBuilder
                    member, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributes, System.Management.Automation.Language.Parser
                    parser, System.AttributeTargets
                    attributeTargets)
                    {
                        DefineCustomAttributes(member, attributes, parser, attributeTargets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43098, 43180);
                        return 0;
                    }


                    int
                    f_1553_43253_43308(System.Reflection.Emit.ConstructorBuilder
                    this_param, System.Reflection.Emit.CustomAttributeBuilder
                    customBuilder)
                    {
                        this_param.SetCustomAttribute(customBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43253, 43308);
                        return 0;
                    }


                    System.Reflection.Emit.ILGenerator
                    f_1553_43366_43387(System.Reflection.Emit.ConstructorBuilder
                    this_param)
                    {
                        var return_v = this_param.GetILGenerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43366, 43387);
                        return return_v;
                    }


                    int
                    f_1553_43463_43496(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43463, 43496);
                        return 0;
                    }


                    int
                    f_1553_43560_43592(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43560, 43592);
                        return 0;
                    }


                    int
                    f_1553_43615_43672(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43615, 43672);
                        return 0;
                    }


                    int
                    f_1553_43695_43773(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.MethodInfo
                    methodInfo, System.Type[]?
                    optionalParameterTypes)
                    {
                        this_param.EmitCall(opcode, methodInfo, optionalParameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43695, 43773);
                        return 0;
                    }


                    int
                    f_1553_43845_43896(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43845, 43896);
                        return 0;
                    }


                    string
                    f_1553_43988_43997(System.Reflection.Emit.ConstructorBuilder
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 43988, 43997);
                        return return_v;
                    }


                    int
                    f_1553_43999_44021(System.Type[]
                    source)
                    {
                        var return_v = source.Count<System.Type>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43999, 44021);
                        return return_v;
                    }


                    string
                    f_1553_43972_44022(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, string
                    name, int
                    numberOfParameters)
                    {
                        var return_v = this_param.GetMetaDataName(name, numberOfParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43972, 44022);
                        return return_v;
                    }


                    int
                    f_1553_43936_44148(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                    this_param, System.Management.Automation.Language.IParameterMetadataProvider
                    ipmp, System.Reflection.Emit.ILGenerator
                    ilGenerator, string
                    metadataToken, bool
                    isStatic, System.Type[]
                    parameterTypes, System.Type
                    returnType, System.Action<int, string>
                    parameterNameSetter)
                    {
                        this_param.DefineMethodBody(ipmp, ilGenerator, metadataToken, isStatic, parameterTypes, returnType, parameterNameSetter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 43936, 44148);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 42560, 44164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 42560, 44164);
                }
            }

            private string GetMetaDataName(string name, int numberOfParameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 44180, 44482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 44280, 44339);

                    int
                    currentId = f_1553_44296_44338(ref s_globalCounter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 44357, 44429);

                    string
                    metaDataName = name + "_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (numberOfParameters).ToString(), 1553, 44392, 44410) + "_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (currentId).ToString(), 1553, 44419, 44428)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 44447, 44467);

                    return metaDataName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 44180, 44482);

                    int
                    f_1553_44296_44338(ref int
                    location)
                    {
                        var return_v = Interlocked.Increment(ref location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 44296, 44338);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 44180, 44482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 44180, 44482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void DefineMethodBody(
                            IParameterMetadataProvider ipmp,
                            ILGenerator ilGenerator,
                            string metadataToken,
                            bool isStatic,
                            Type[] parameterTypes,
                            Type returnType,
                            Action<int, string> parameterNameSetter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 44498, 48751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 44856, 44947);

                    var
                    wrapperFieldName = f_1553_44879_44946(f_1553_44893_44921(), "<{0}>", metadataToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 44965, 45286);

                    var
                    scriptBlockWrapperField = f_1553_44995_45285(_staticHelpersTypeBuilder, wrapperFieldName, typeof(ScriptBlockMemberMethodWrapper), FieldAttributes.Assembly | FieldAttributes.Static)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45306, 45364);

                    f_1553_45306_45363(
                                    ilGenerator, OpCodes.Ldsfld, scriptBlockWrapperField);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45382, 45998) || true) && (isStatic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 45382, 45998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45436, 45469);

                        f_1553_45436_45468(ilGenerator, OpCodes.Ldnull);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45532, 45565);

                        f_1553_45532_45564(ilGenerator, OpCodes.Ldnull);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 45382, 45998);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 45382, 45998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45704, 45730);

                        f_1553_45704_45729(ilGenerator, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45792, 45826);

                        f_1553_45792_45825(ilGenerator, OpCodes.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 45897, 45949);

                        f_1553_45897_45948(ilGenerator, OpCodes.Ldfld, _sessionStateField);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 45382, 45998);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46018, 46061);

                    int
                    parameterCount = f_1553_46039_46060(parameterTypes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46079, 47952) || true) && (parameterCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 46079, 47952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46143, 46176);

                        var
                        parameters = f_1553_46160_46175(ipmp)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46198, 46253);

                        var
                        local = f_1553_46210_46252(ilGenerator, typeof(object[]))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46277, 46314);

                        f_1553_46277_46313(ilGenerator, parameterCount);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46381, 46430);

                        f_1553_46381_46429(ilGenerator, OpCodes.Newarr, typeof(object));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46478, 46517);

                        f_1553_46478_46516(ilGenerator, OpCodes.Stloc, local);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46582, 46607);

                        int
                        j = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 46590, 46598) || ((isStatic && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 46601, 46602)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 46605, 46606))) ? 0 : 1
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46638, 46643);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46629, 47618) || true) && (i < parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46665, 46668)
        , i++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46670, 46673)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 46629, 47618))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 46629, 47618);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46723, 46762);

                                f_1553_46723_46761(ilGenerator, OpCodes.Ldloc, local);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46812, 46836);

                                f_1553_46812_46835(ilGenerator, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 46907, 46933);

                                f_1553_46907_46932(ilGenerator, j);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47015, 47212) || true) && (f_1553_47019_47048(parameterTypes[i]))
                                )  // value types must be boxed

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 47015, 47212);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47136, 47185);

                                    f_1553_47136_47184(ilGenerator, OpCodes.Box, parameterTypes[i]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 47015, 47212);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47240, 47277);

                                f_1553_47240_47276(
                                                        ilGenerator, OpCodes.Stelem_Ref);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47526, 47595);

                                f_1553_47526_47594(parameterNameSetter, i + 1, f_1553_47553_47593(f_1553_47553_47584(f_1553_47553_47571(f_1553_47553_47566(parameters, i)))));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 990);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 990);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47642, 47681);

                        f_1553_47642_47680(
                                            ilGenerator, OpCodes.Ldloc, local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 46079, 47952);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 46079, 47952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47785, 47933);

                        f_1553_47785_47932(ilGenerator, OpCodes.Ldsfld, f_1553_47818_47931(typeof(ScriptBlockMemberMethodWrapper), "_emptyArgumentArray", BindingFlags.Static | BindingFlags.Public));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 46079, 47952);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 47972, 47996);

                    MethodInfo
                    invokeHelper
                    = default(MethodInfo);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48014, 48468) || true) && (returnType == typeof(void))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 48014, 48468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48086, 48211);

                        invokeHelper = f_1553_48101_48210(typeof(ScriptBlockMemberMethodWrapper), "InvokeHelper", BindingFlags.Instance | BindingFlags.Public);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 48014, 48468);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 48014, 48468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48293, 48449);

                        invokeHelper = f_1553_48308_48448(f_1553_48308_48418(typeof(ScriptBlockMemberMethodWrapper), "InvokeHelperT", BindingFlags.Instance | BindingFlags.Public), returnType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 48014, 48468);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48488, 48523);

                    f_1553_48488_48522(
                                    ilGenerator, OpCodes.Tailcall);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48541, 48596);

                    f_1553_48541_48595(ilGenerator, OpCodes.Call, invokeHelper, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48614, 48644);

                    f_1553_48614_48643(ilGenerator, OpCodes.Ret);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48664, 48736);

                    f_1553_48664_48735(
                                    _fieldsToInitForMemberFunctions, (wrapperFieldName, ipmp, isStatic));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 44498, 48751);

                    System.Globalization.CultureInfo
                    f_1553_44893_44921()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 44893, 44921);
                        return return_v;
                    }


                    string
                    f_1553_44879_44946(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 44879, 44946);
                        return return_v;
                    }


                    System.Reflection.Emit.FieldBuilder
                    f_1553_44995_45285(System.Reflection.Emit.TypeBuilder
                    this_param, string
                    fieldName, System.Type
                    type, System.Reflection.FieldAttributes
                    attributes)
                    {
                        var return_v = this_param.DefineField(fieldName, type, attributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 44995, 45285);
                        return return_v;
                    }


                    int
                    f_1553_45306_45363(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45306, 45363);
                        return 0;
                    }


                    int
                    f_1553_45436_45468(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45436, 45468);
                        return 0;
                    }


                    int
                    f_1553_45532_45564(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45532, 45564);
                        return 0;
                    }


                    int
                    f_1553_45704_45729(System.Reflection.Emit.ILGenerator
                    emitter, int
                    c)
                    {
                        EmitLdarg(emitter, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45704, 45729);
                        return 0;
                    }


                    int
                    f_1553_45792_45825(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45792, 45825);
                        return 0;
                    }


                    int
                    f_1553_45897_45948(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.FieldBuilder
                    field)
                    {
                        this_param.Emit(opcode, (System.Reflection.FieldInfo)field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 45897, 45948);
                        return 0;
                    }


                    int
                    f_1553_46039_46060(System.Type[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 46039, 46060);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    f_1553_46160_46175(System.Management.Automation.Language.IParameterMetadataProvider
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 46160, 46175);
                        return return_v;
                    }


                    System.Reflection.Emit.LocalBuilder
                    f_1553_46210_46252(System.Reflection.Emit.ILGenerator
                    this_param, System.Type
                    localType)
                    {
                        var return_v = this_param.DeclareLocal(localType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46210, 46252);
                        return return_v;
                    }


                    int
                    f_1553_46277_46313(System.Reflection.Emit.ILGenerator
                    emitter, int
                    c)
                    {
                        EmitLdc(emitter, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46277, 46313);
                        return 0;
                    }


                    int
                    f_1553_46381_46429(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Type
                    cls)
                    {
                        this_param.Emit(opcode, cls);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46381, 46429);
                        return 0;
                    }


                    int
                    f_1553_46478_46516(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.LocalBuilder
                    local)
                    {
                        this_param.Emit(opcode, local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46478, 46516);
                        return 0;
                    }


                    int
                    f_1553_46723_46761(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.LocalBuilder
                    local)
                    {
                        this_param.Emit(opcode, local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46723, 46761);
                        return 0;
                    }


                    int
                    f_1553_46812_46835(System.Reflection.Emit.ILGenerator
                    emitter, int
                    c)
                    {
                        EmitLdc(emitter, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46812, 46835);
                        return 0;
                    }


                    int
                    f_1553_46907_46932(System.Reflection.Emit.ILGenerator
                    emitter, int
                    c)
                    {
                        EmitLdarg(emitter, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 46907, 46932);
                        return 0;
                    }


                    bool
                    f_1553_47019_47048(System.Type
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 47019, 47048);
                        return return_v;
                    }


                    int
                    f_1553_47136_47184(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Type
                    cls)
                    {
                        this_param.Emit(opcode, cls);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47136, 47184);
                        return 0;
                    }


                    int
                    f_1553_47240_47276(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47240, 47276);
                        return 0;
                    }


                    System.Management.Automation.Language.ParameterAst
                    f_1553_47553_47566(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 47553, 47566);
                        return return_v;
                    }


                    System.Management.Automation.Language.VariableExpressionAst
                    f_1553_47553_47571(System.Management.Automation.Language.ParameterAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 47553, 47571);
                        return return_v;
                    }


                    System.Management.Automation.VariablePath
                    f_1553_47553_47584(System.Management.Automation.Language.VariableExpressionAst
                    this_param)
                    {
                        var return_v = this_param.VariablePath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 47553, 47584);
                        return return_v;
                    }


                    string
                    f_1553_47553_47593(System.Management.Automation.VariablePath
                    this_param)
                    {
                        var return_v = this_param.UserPath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 47553, 47593);
                        return return_v;
                    }


                    int
                    f_1553_47526_47594(System.Action<int, string>
                    this_param, int
                    arg1, string
                    arg2)
                    {
                        this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47526, 47594);
                        return 0;
                    }


                    int
                    f_1553_47642_47680(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.Emit.LocalBuilder
                    local)
                    {
                        this_param.Emit(opcode, local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47642, 47680);
                        return 0;
                    }


                    System.Reflection.FieldInfo?
                    f_1553_47818_47931(System.Type
                    this_param, string
                    name, System.Reflection.BindingFlags
                    bindingAttr)
                    {
                        var return_v = this_param.GetField(name, bindingAttr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47818, 47931);
                        return return_v;
                    }


                    int
                    f_1553_47785_47932(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.FieldInfo
                    field)
                    {
                        this_param.Emit(opcode, field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 47785, 47932);
                        return 0;
                    }


                    System.Reflection.MethodInfo?
                    f_1553_48101_48210(System.Type
                    this_param, string
                    name, System.Reflection.BindingFlags
                    bindingAttr)
                    {
                        var return_v = this_param.GetMethod(name, bindingAttr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48101, 48210);
                        return return_v;
                    }


                    System.Reflection.MethodInfo?
                    f_1553_48308_48418(System.Type
                    this_param, string
                    name, System.Reflection.BindingFlags
                    bindingAttr)
                    {
                        var return_v = this_param.GetMethod(name, bindingAttr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48308, 48418);
                        return return_v;
                    }


                    System.Reflection.MethodInfo
                    f_1553_48308_48448(System.Reflection.MethodInfo
                    this_param, params System.Type[]
                    typeArguments)
                    {
                        var return_v = this_param.MakeGenericMethod(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48308, 48448);
                        return return_v;
                    }


                    int
                    f_1553_48488_48522(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48488, 48522);
                        return 0;
                    }


                    int
                    f_1553_48541_48595(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode, System.Reflection.MethodInfo
                    methodInfo, System.Type[]?
                    optionalParameterTypes)
                    {
                        this_param.EmitCall(opcode, methodInfo, optionalParameterTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48541, 48595);
                        return 0;
                    }


                    int
                    f_1553_48614_48643(System.Reflection.Emit.ILGenerator
                    this_param, System.Reflection.Emit.OpCode
                    opcode)
                    {
                        this_param.Emit(opcode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48614, 48643);
                        return 0;
                    }


                    int
                    f_1553_48664_48735(System.Collections.Generic.List<(string fieldName, System.Management.Automation.Language.IParameterMetadataProvider bodyAst, bool isStatic)>
                    this_param, (string wrapperFieldName, System.Management.Automation.Language.IParameterMetadataProvider ipmp, bool isStatic)
                    item)
                    {
                        this_param.Add(((string fieldName, System.Management.Automation.Language.IParameterMetadataProvider bodyAst, bool isStatic))item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 48664, 48735);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 44498, 48751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 44498, 48751);
                }
            }

            static DefineTypeHelper()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1553, 11810, 48762);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1553, 11810, 48762);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 11810, 48762);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1553, 11810, 48762);

            System.Type
            f_1553_13370_13430(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
            this_param, System.Management.Automation.Language.Parser
            parser, System.Management.Automation.Language.TypeDefinitionAst
            typeDefinitionAst, out System.Collections.Generic.List<System.Type>
            interfaces)
            {
                var return_v = this_param.GetBaseTypes(parser, typeDefinitionAst, out interfaces);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13370, 13430);
                return return_v;
            }


            System.Type[]
            f_1553_13573_13593(System.Collections.Generic.List<System.Type>
            this_param)
            {
                var return_v = this_param.ToArray();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13573, 13593);
                return return_v;
            }


            System.Reflection.Emit.TypeBuilder
            f_1553_13466_13594(System.Reflection.Emit.ModuleBuilder
            this_param, string
            name, System.Reflection.TypeAttributes
            attr, System.Type
            parent, System.Type[]
            interfaces)
            {
                var return_v = this_param.DefineType(name, attr, parent, interfaces);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13466, 13594);
                return return_v;
            }


            System.Globalization.CultureInfo
            f_1553_13673_13701()
            {
                var return_v = CultureInfo.InvariantCulture;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 13673, 13701);
                return return_v;
            }


            string
            f_1553_13659_13735(System.Globalization.CultureInfo
            provider, string
            format, string
            arg0)
            {
                var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13659, 13735);
                return return_v;
            }


            System.Reflection.Emit.TypeBuilder
            f_1553_13641_13769(System.Reflection.Emit.ModuleBuilder
            this_param, string
            name, System.Reflection.TypeAttributes
            attr)
            {
                var return_v = this_param.DefineType(name, attr);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13641, 13769);
                return return_v;
            }


            System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
            f_1553_13825_13853(System.Management.Automation.Language.TypeDefinitionAst
            this_param)
            {
                var return_v = this_param.Attributes;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 13825, 13853);
                return return_v;
            }


            int
            f_1553_13788_13887(System.Reflection.Emit.TypeBuilder
            member, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
            attributes, System.Management.Automation.Language.Parser
            parser, System.AttributeTargets
            attributeTargets)
            {
                DefineCustomAttributes(member, attributes, parser, attributeTargets);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13788, 13887);
                return 0;
            }


            System.Collections.Generic.List<(string, System.Management.Automation.Language.IParameterMetadataProvider, bool)>
            f_1553_13999_14053()
            {
                var return_v = new System.Collections.Generic.List<(string, System.Management.Automation.Language.IParameterMetadataProvider, bool)>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 13999, 14053);
                return return_v;
            }


            System.StringComparer
            f_1553_14153_14185()
            {
                var return_v = StringComparer.OrdinalIgnoreCase;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 14153, 14185);
                return return_v;
            }


            System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>>
            f_1553_14090_14186(System.StringComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Tuple<System.Management.Automation.Language.FunctionMemberAst, System.Type[]>>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 14090, 14186);
                return return_v;
            }


            System.StringComparer
            f_1553_14268_14300()
            {
                var return_v = StringComparer.OrdinalIgnoreCase;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 14268, 14300);
                return return_v;
            }


            System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.PropertyMemberAst>
            f_1553_14226_14301(System.StringComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.PropertyMemberAst>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 14226, 14301);
                return return_v;
            }


            System.Reflection.Emit.FieldBuilder
            f_1553_14343_14445(System.Reflection.Emit.TypeBuilder
            this_param, string
            fieldName, System.Type
            type, System.Reflection.FieldAttributes
            attributes)
            {
                var return_v = this_param.DefineField(fieldName, type, attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 14343, 14445);
                return return_v;
            }


            System.Reflection.Emit.FieldBuilder
            f_1553_14491_14638(System.Reflection.Emit.TypeBuilder
            this_param, string
            fieldName, System.Type
            type, System.Reflection.FieldAttributes
            attributes)
            {
                var return_v = this_param.DefineField(fieldName, type, attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 14491, 14638);
                return return_v;
            }

        }
        private class DefineEnumHelper
        {
            private readonly Parser _parser;

            private readonly TypeDefinitionAst _enumDefinitionAst;

            private readonly ModuleBuilder _moduleBuilder;

            private readonly string _typeName;

            internal DefineEnumHelper(Parser parser, ModuleBuilder module, TypeDefinitionAst enumDefinitionAst, string typeName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1553, 49053, 49372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48853, 48860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48910, 48928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 48974, 48988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 49027, 49036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 49202, 49219);

                    _parser = parser;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 49237, 49276);

                    _enumDefinitionAst = enumDefinitionAst;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 49294, 49318);

                    _moduleBuilder = module;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 49336, 49357);

                    _typeName = typeName;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1553, 49053, 49372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 49053, 49372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 49053, 49372);
                }
            }

            internal static List<DefineEnumHelper> Sort(List<DefineEnumHelper> defineEnumHelpers, Parser parser)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 49388, 56151);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 50957, 51075) || true) && (f_1553_50961_50984(defineEnumHelpers) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 50957, 51075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51031, 51056);

                        return defineEnumHelpers;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 50957, 51075);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51254, 51352);

                    var
                    graph = f_1553_51266_51351()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51426, 51617);
                        foreach (var helper in f_1553_51449_51466_I(defineEnumHelpers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 51426, 51617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51508, 51598);

                            f_1553_51508_51597(graph, helper._enumDefinitionAst, f_1553_51545_51596(helper, f_1553_51566_51595()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 51426, 51617);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 192);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 192);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51677, 53842);
                        foreach (var helper in f_1553_51700_51717_I(defineEnumHelpers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 51677, 53842);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51759, 53823);
                                foreach (var enumerator in f_1553_51786_51819_I(f_1553_51786_51819(helper._enumDefinitionAst)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 51759, 53823);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51869, 51929);

                                    var
                                    initExpr = f_1553_51884_51928(((PropertyMemberAst)enumerator))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 51955, 52238) || true) && (initExpr == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 51955, 52238);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52202, 52211);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 51955, 52238);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52370, 53800);
                                        foreach (var memberExpr in f_1553_52397_52455_I(f_1553_52397_52455(initExpr, ast => ast is MemberExpressionAst, false)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 52370, 53800);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52513, 52594);

                                            var
                                            typeExpr = f_1553_52528_52572(((MemberExpressionAst)memberExpr)) as TypeExpressionAst
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52624, 53773) || true) && (typeExpr != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 52624, 53773);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52914, 52959);

                                                var
                                                typeName = f_1553_52929_52946(typeExpr) as TypeName
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 52993, 53742) || true) && (typeName != null
                                                && (DynAbs.Tracing.TraceSender.Expression_True(1553, 52997, 53089) && typeName._typeDefinitionAst != null
                                                ) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 52997, 53186) && typeName._typeDefinitionAst != helper._enumDefinitionAst  // Don't add self edges
                                                ) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 52997, 53298) && f_1553_53252_53298(graph, typeName._typeDefinitionAst)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 52993, 53742);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 53372, 53426);

                                                    var
                                                    edgeList = f_1553_53387_53425(f_1553_53387_53419(graph, helper._enumDefinitionAst))
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 53464, 53707) || true) && (!f_1553_53469_53515(edgeList, typeName._typeDefinitionAst))
                                                    )  // Only add 1 edge per enum

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 53464, 53707);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 53626, 53668);

                                                        f_1553_53626_53667(edgeList, typeName._typeDefinitionAst);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 53464, 53707);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 52993, 53742);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 52624, 53773);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 52370, 53800);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 1431);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 1431);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 51759, 53823);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 2065);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 2065);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 51677, 53842);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 2166);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 2166);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54080, 54145);

                    var
                    result = f_1553_54093_54144(f_1553_54120_54143(defineEnumHelpers))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54163, 54231);

                    var
                    readyList = f_1553_54179_54230(f_1553_54206_54229(defineEnumHelpers))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54249, 54344);

                    f_1553_54249_54343(readyList, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from value in graph.Values where value.Item2.Count == 0 select value.Item1, 1553, 54268, 54342));
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54362, 55271) || true) && (f_1553_54369_54384(readyList) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 54362, 55271);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54430, 54472);

                            var
                            node = f_1553_54441_54471(readyList, f_1553_54451_54466(readyList) - 1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54494, 54534);

                            f_1553_54494_54533(readyList, f_1553_54513_54528(readyList) - 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54556, 54573);

                            f_1553_54556_54572(result, node);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54684, 55252);
                                foreach (var value in f_1553_54706_54718_I(f_1553_54706_54718(graph)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 54684, 55252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 54768, 54812);

                                    f_1553_54768_54811(f_1553_54768_54779(value), node._enumDefinitionAst);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55022, 55229) || true) && (f_1553_55026_55043(f_1553_55026_55037(value)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1553, 55026, 55081) && !f_1553_55053_55081(result, f_1553_55069_55080(value))) && (DynAbs.Tracing.TraceSender.Expression_True(1553, 55026, 55117) && !f_1553_55086_55117(readyList, f_1553_55105_55116(value))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 55022, 55229);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55175, 55202);

                                        f_1553_55175_55201(readyList, f_1553_55189_55200(value));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 55022, 55229);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 54684, 55252);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 569);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 569);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 54362, 55271);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 54362, 55271);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 54362, 55271);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55291, 56102) || true) && (f_1553_55295_55307(result) < f_1553_55310_55333(defineEnumHelpers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 55291, 56102);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55448, 55879);
                            foreach (var helper in f_1553_55471_55488_I(defineEnumHelpers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 55448, 55879);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55538, 55856) || true) && (!f_1553_55543_55566(result, helper))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 55538, 55856);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55624, 55829);

                                    f_1553_55624_55828(parser, f_1553_55643_55675(helper._enumDefinitionAst), nameof(ParserStrings.CycleInEnumInitializers), f_1553_55790_55827());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 55538, 55856);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 55448, 55879);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 432);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 432);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 55291, 56102);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 55291, 56102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 55961, 56083);

                        f_1553_55961_56082(f_1553_55980_55992(result) == f_1553_55996_56019(defineEnumHelpers), "Logic error if we have more outgoing results than incoming");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 55291, 56102);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56122, 56136);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 49388, 56151);

                    int
                    f_1553_50961_50984(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 50961, 50984);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>
                    f_1553_51266_51351()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51266, 51351);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    f_1553_51566_51595()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51566, 51595);
                        return return_v;
                    }


                    System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    f_1553_51545_51596(System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item1, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    item2)
                    {
                        var return_v = Tuple.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51545, 51596);
                        return return_v;
                    }


                    int
                    f_1553_51508_51597(System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    key, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51508, 51597);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    f_1553_51449_51466_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51449, 51466);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_51786_51819(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Members;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 51786, 51819);
                        return return_v;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_51884_51928(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 51884, 51928);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                    f_1553_52397_52455(System.Management.Automation.Language.ExpressionAst
                    this_param, System.Func<System.Management.Automation.Language.Ast, bool>
                    predicate, bool
                    searchNestedScriptBlocks)
                    {
                        var return_v = this_param.FindAll(predicate, searchNestedScriptBlocks);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 52397, 52455);
                        return return_v;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_52528_52572(System.Management.Automation.Language.MemberExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 52528, 52572);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_52929_52946(System.Management.Automation.Language.TypeExpressionAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 52929, 52946);
                        return return_v;
                    }


                    bool
                    f_1553_53252_53298(System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 53252, 53298);
                        return return_v;
                    }


                    System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    f_1553_53387_53419(System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 53387, 53419);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    f_1553_53387_53425(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 53387, 53425);
                        return return_v;
                    }


                    bool
                    f_1553_53469_53515(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 53469, 53515);
                        return return_v;
                    }


                    int
                    f_1553_53626_53667(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 53626, 53667);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                    f_1553_52397_52455_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 52397, 52455);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_51786_51819_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51786, 51819);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    f_1553_51700_51717_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 51700, 51717);
                        return return_v;
                    }


                    int
                    f_1553_54120_54143(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54120, 54143);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    f_1553_54093_54144(int
                    capacity)
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54093, 54144);
                        return return_v;
                    }


                    int
                    f_1553_54206_54229(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54206, 54229);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    f_1553_54179_54230(int
                    capacity)
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54179, 54230);
                        return return_v;
                    }


                    int
                    f_1553_54249_54343(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    collection)
                    {
                        this_param.AddRange(collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54249, 54343);
                        return 0;
                    }


                    int
                    f_1553_54369_54384(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54369, 54384);
                        return return_v;
                    }


                    int
                    f_1553_54451_54466(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54451, 54466);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    f_1553_54441_54471(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54441, 54471);
                        return return_v;
                    }


                    int
                    f_1553_54513_54528(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54513, 54528);
                        return return_v;
                    }


                    int
                    f_1553_54494_54533(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, int
                    index)
                    {
                        this_param.RemoveAt(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54494, 54533);
                        return 0;
                    }


                    int
                    f_1553_54556_54572(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54556, 54572);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>.ValueCollection
                    f_1553_54706_54718(System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54706, 54718);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    f_1553_54768_54779(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 54768, 54779);
                        return return_v;
                    }


                    bool
                    f_1553_54768_54811(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    this_param, System.Management.Automation.Language.TypeDefinitionAst
                    item)
                    {
                        var return_v = this_param.Remove(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54768, 54811);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    f_1553_55026_55037(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item2;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55026, 55037);
                        return return_v;
                    }


                    int
                    f_1553_55026_55043(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55026, 55043);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    f_1553_55069_55080(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55069, 55080);
                        return return_v;
                    }


                    bool
                    f_1553_55053_55081(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55053, 55081);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    f_1553_55105_55116(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55105, 55116);
                        return return_v;
                    }


                    bool
                    f_1553_55086_55117(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55086, 55117);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    f_1553_55189_55200(System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>
                    this_param)
                    {
                        var return_v = this_param.Item1;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55189, 55200);
                        return return_v;
                    }


                    int
                    f_1553_55175_55201(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55175, 55201);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>.ValueCollection
                    f_1553_54706_54718_I(System.Collections.Generic.Dictionary<System.Management.Automation.Language.TypeDefinitionAst, System.Tuple<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper, System.Collections.Generic.List<System.Management.Automation.Language.TypeDefinitionAst>>>.ValueCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 54706, 54718);
                        return return_v;
                    }


                    int
                    f_1553_55295_55307(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55295, 55307);
                        return return_v;
                    }


                    int
                    f_1553_55310_55333(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55310, 55333);
                        return return_v;
                    }


                    bool
                    f_1553_55543_55566(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55543, 55566);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_55643_55675(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55643, 55675);
                        return return_v;
                    }


                    string
                    f_1553_55790_55827()
                    {
                        var return_v = ParserStrings.CycleInEnumInitializers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55790, 55827);
                        return return_v;
                    }


                    int
                    f_1553_55624_55828(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55624, 55828);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    f_1553_55471_55488_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55471, 55488);
                        return return_v;
                    }


                    int
                    f_1553_55980_55992(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55980, 55992);
                        return return_v;
                    }


                    int
                    f_1553_55996_56019(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 55996, 56019);
                        return return_v;
                    }


                    int
                    f_1553_55961_56082(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 55961, 56082);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 49388, 56151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 49388, 56151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void DefineEnum()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1553, 56167, 62041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56226, 56296);

                    var
                    typeConstraintAst = f_1553_56250_56295(f_1553_56250_56278(_enumDefinitionAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56314, 56424);

                    var
                    underlyingType = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 56335, 56360) || ((typeConstraintAst == null && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 56363, 56374)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 56377, 56423))) ? typeof(int) : f_1553_56377_56423(f_1553_56377_56403(typeConstraintAst))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56444, 56523);

                    var
                    definedEnumerators = f_1553_56469_56522(f_1553_56489_56521())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56541, 56646);

                    var
                    enumBuilder = f_1553_56559_56645(_moduleBuilder, _typeName, Reflection.TypeAttributes.Public, underlyingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56664, 56763);

                    f_1553_56664_56762(enumBuilder, f_1553_56700_56729(_enumDefinitionAst), _parser, AttributeTargets.Enum);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56783, 56801);

                    dynamic
                    value = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56819, 56840);

                    dynamic
                    maxValue = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56858, 58292);

                    switch (f_1553_56866_56898(underlyingType))
                    {

                        case TypeCode.Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 56985, 57010);

                            maxValue = byte.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57036, 57042);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57110, 57136);

                            maxValue = short.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57162, 57168);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57236, 57260);

                            maxValue = int.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57286, 57292);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57360, 57385);

                            maxValue = long.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57411, 57417);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57485, 57511);

                            maxValue = sbyte.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57537, 57543);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57612, 57639);

                            maxValue = ushort.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57665, 57671);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57740, 57765);

                            maxValue = uint.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57791, 57797);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        case TypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57866, 57892);

                            maxValue = ulong.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 57918, 57924);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 56858, 58292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 57980, 58241);

                            f_1553_57980_58240(_parser, f_1553_58030_58054(typeConstraintAst), nameof(ParserStrings.InvalidUnderlyingType), f_1553_58159_58194(), underlyingType);
                            DynAbs.Tracing.TraceSender.TraceBreak(1553, 58267, 58273);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 56858, 58292);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58312, 58337);

                    bool
                    valueTooBig = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58357, 61942);
                        foreach (var member in f_1553_58380_58406_I(f_1553_58380_58406(_enumDefinitionAst)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58357, 61942);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58448, 58491);

                            var
                            enumerator = (PropertyMemberAst)member
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58513, 60523) || true) && (f_1553_58517_58540(enumerator) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58513, 60523);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58598, 58616);

                                object
                                constValue
                                = default(object);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58642, 60441) || true) && (f_1553_58646_58734(f_1553_58680_58703(enumerator), out constValue, false, false))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58642, 60441);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58792, 60050) || true) && (!f_1553_58797_58867(constValue, underlyingType, out value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58792, 60050);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 58933, 60019) || true) && (constValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1553, 58937, 59078) && f_1553_58996_59078(f_1553_59025_59077(f_1553_59056_59076(constValue)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58933, 60019);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 59152, 59503);

                                            f_1553_59152_59502(_parser, f_1553_59214_59244(f_1553_59214_59237(enumerator)), nameof(ParserStrings.EnumeratorValueOutOfBounds), f_1553_59378_59418(), f_1553_59461_59501(underlyingType));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58933, 60019);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58933, 60019);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 59649, 59984);

                                            f_1553_59649_59983(_parser, f_1553_59711_59741(f_1553_59711_59734(enumerator)), nameof(ParserStrings.CannotConvertValue), f_1553_59867_59899(), f_1553_59942_59982(underlyingType));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58933, 60019);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58792, 60050);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58642, 60441);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 58642, 60441);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 60164, 60414);

                                    f_1553_60164_60413(_parser, f_1553_60218_60248(f_1553_60218_60241(enumerator)), nameof(ParserStrings.EnumeratorValueMustBeConstant), f_1553_60369_60412());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58642, 60441);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 60469, 60500);

                                valueTooBig = value > maxValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58513, 60523);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 60547, 60925) || true) && (valueTooBig)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 60547, 60925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 60612, 60902);

                                f_1553_60612_60901(_parser, f_1553_60662_60679(enumerator), nameof(ParserStrings.EnumeratorValueOutOfBounds), f_1553_60789_60829(), f_1553_60860_60900(underlyingType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 60547, 60925);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 60949, 61632) || true) && (f_1553_60953_60997(definedEnumerators, f_1553_60981_60996(enumerator)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 60949, 61632);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61047, 61300);

                                f_1553_61047_61299(_parser, f_1553_61097_61114(enumerator), nameof(ParserStrings.MemberAlreadyDefined), f_1553_61218_61252(), f_1553_61283_61298(enumerator));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 60949, 61632);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 60949, 61632);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61350, 61632) || true) && (value != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 61350, 61632);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61417, 61467);

                                    value = f_1553_61425_61466(value, underlyingType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61493, 61533);

                                    f_1553_61493_61532(definedEnumerators, f_1553_61516_61531(enumerator));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61559, 61609);

                                    f_1553_61559_61608(enumBuilder, f_1553_61585_61600(enumerator), value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 61350, 61632);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 60949, 61632);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61656, 61923) || true) && (value < maxValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 61656, 61923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61726, 61737);

                                value += 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61763, 61783);

                                valueTooBig = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 61656, 61923);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 61656, 61923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61881, 61900);

                                valueTooBig = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 61656, 61923);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 58357, 61942);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 3586);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 3586);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 61962, 62026);

                    _enumDefinitionAst.Type = f_1553_61988_62025(f_1553_61988_62016(enumBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1553, 56167, 62041);

                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    f_1553_56250_56278(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.BaseTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 56250, 56278);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeConstraintAst
                    f_1553_56250_56295(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
                    source)
                    {
                        var return_v = source.FirstOrDefault<System.Management.Automation.Language.TypeConstraintAst>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56250, 56295);
                        return return_v;
                    }


                    System.Management.Automation.Language.ITypeName
                    f_1553_56377_56403(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.TypeName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 56377, 56403);
                        return return_v;
                    }


                    System.Type
                    f_1553_56377_56423(System.Management.Automation.Language.ITypeName
                    this_param)
                    {
                        var return_v = this_param.GetReflectionType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56377, 56423);
                        return return_v;
                    }


                    System.StringComparer
                    f_1553_56489_56521()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 56489, 56521);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<string>
                    f_1553_56469_56522(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56469, 56522);
                        return return_v;
                    }


                    System.Reflection.Emit.EnumBuilder
                    f_1553_56559_56645(System.Reflection.Emit.ModuleBuilder
                    this_param, string
                    name, System.Reflection.TypeAttributes
                    visibility, System.Type
                    underlyingType)
                    {
                        var return_v = this_param.DefineEnum(name, visibility, underlyingType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56559, 56645);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    f_1553_56700_56729(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 56700, 56729);
                        return return_v;
                    }


                    int
                    f_1553_56664_56762(System.Reflection.Emit.EnumBuilder
                    member, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
                    attributes, System.Management.Automation.Language.Parser
                    parser, System.AttributeTargets
                    attributeTargets)
                    {
                        DefineCustomAttributes(member, attributes, parser, attributeTargets);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56664, 56762);
                        return 0;
                    }


                    System.TypeCode
                    f_1553_56866_56898(System.Type
                    type)
                    {
                        var return_v = Type.GetTypeCode(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 56866, 56898);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_58030_58054(System.Management.Automation.Language.TypeConstraintAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 58030, 58054);
                        return return_v;
                    }


                    string
                    f_1553_58159_58194()
                    {
                        var return_v = ParserStrings.InvalidUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 58159, 58194);
                        return return_v;
                    }


                    int
                    f_1553_57980_58240(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, System.Type
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 57980, 58240);
                        return 0;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_58380_58406(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Members;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 58380, 58406);
                        return return_v;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_58517_58540(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 58517, 58540);
                        return return_v;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_58680_58703(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 58680, 58703);
                        return return_v;
                    }


                    bool
                    f_1553_58646_58734(System.Management.Automation.Language.ExpressionAst
                    ast, out object
                    constantValue, bool
                    forAttribute, bool
                    forRequires)
                    {
                        var return_v = IsConstantValueVisitor.IsConstant((System.Management.Automation.Language.Ast)ast, out constantValue, forAttribute, forRequires);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 58646, 58734);
                        return return_v;
                    }


                    bool
                    f_1553_58797_58867(object
                    valueToConvert, System.Type
                    resultType, out dynamic
                    result)
                    {
                        var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 58797, 58867);
                        return return_v;
                    }


                    System.Type
                    f_1553_59056_59076(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59056, 59076);
                        return return_v;
                    }


                    System.TypeCode
                    f_1553_59025_59077(System.Type
                    type)
                    {
                        var return_v = LanguagePrimitives.GetTypeCode(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59025, 59077);
                        return return_v;
                    }


                    bool
                    f_1553_58996_59078(System.TypeCode
                    typeCode)
                    {
                        var return_v = LanguagePrimitives.IsNumeric(typeCode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 58996, 59078);
                        return return_v;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_59214_59237(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59214, 59237);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_59214_59244(System.Management.Automation.Language.ExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59214, 59244);
                        return return_v;
                    }


                    string
                    f_1553_59378_59418()
                    {
                        var return_v = ParserStrings.EnumeratorValueOutOfBounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59378, 59418);
                        return return_v;
                    }


                    string
                    f_1553_59461_59501(System.Type
                    type)
                    {
                        var return_v = ToStringCodeMethods.Type(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59461, 59501);
                        return return_v;
                    }


                    int
                    f_1553_59152_59502(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59152, 59502);
                        return 0;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_59711_59734(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59711, 59734);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_59711_59741(System.Management.Automation.Language.ExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59711, 59741);
                        return return_v;
                    }


                    string
                    f_1553_59867_59899()
                    {
                        var return_v = ParserStrings.CannotConvertValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 59867, 59899);
                        return return_v;
                    }


                    string
                    f_1553_59942_59982(System.Type
                    type)
                    {
                        var return_v = ToStringCodeMethods.Type(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59942, 59982);
                        return return_v;
                    }


                    int
                    f_1553_59649_59983(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 59649, 59983);
                        return 0;
                    }


                    System.Management.Automation.Language.ExpressionAst
                    f_1553_60218_60241(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.InitialValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60218, 60241);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_60218_60248(System.Management.Automation.Language.ExpressionAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60218, 60248);
                        return return_v;
                    }


                    string
                    f_1553_60369_60412()
                    {
                        var return_v = ParserStrings.EnumeratorValueMustBeConstant;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60369, 60412);
                        return return_v;
                    }


                    int
                    f_1553_60164_60413(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 60164, 60413);
                        return 0;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_60662_60679(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60662, 60679);
                        return return_v;
                    }


                    string
                    f_1553_60789_60829()
                    {
                        var return_v = ParserStrings.EnumeratorValueOutOfBounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60789, 60829);
                        return return_v;
                    }


                    string
                    f_1553_60860_60900(System.Type
                    type)
                    {
                        var return_v = ToStringCodeMethods.Type(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 60860, 60900);
                        return return_v;
                    }


                    int
                    f_1553_60612_60901(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 60612, 60901);
                        return 0;
                    }


                    string
                    f_1553_60981_60996(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 60981, 60996);
                        return return_v;
                    }


                    bool
                    f_1553_60953_60997(System.Collections.Generic.HashSet<string>
                    this_param, string
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 60953, 60997);
                        return return_v;
                    }


                    System.Management.Automation.Language.IScriptExtent
                    f_1553_61097_61114(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Extent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 61097, 61114);
                        return return_v;
                    }


                    string
                    f_1553_61218_61252()
                    {
                        var return_v = ParserStrings.MemberAlreadyDefined;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 61218, 61252);
                        return return_v;
                    }


                    string
                    f_1553_61283_61298(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 61283, 61298);
                        return return_v;
                    }


                    int
                    f_1553_61047_61299(System.Management.Automation.Language.Parser
                    this_param, System.Management.Automation.Language.IScriptExtent
                    extent, string
                    errorId, string
                    errorMsg, string
                    arg)
                    {
                        this_param.ReportError(extent, errorId, errorMsg, (object)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61047, 61299);
                        return 0;
                    }


                    object?
                    f_1553_61425_61466(object?
                    value, System.Type
                    conversionType)
                    {
                        var return_v = System.Convert.ChangeType(value, conversionType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61425, 61466);
                        return return_v;
                    }


                    string
                    f_1553_61516_61531(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 61516, 61531);
                        return return_v;
                    }


                    bool
                    f_1553_61493_61532(System.Collections.Generic.HashSet<string>
                    this_param, string
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61493, 61532);
                        return return_v;
                    }


                    string
                    f_1553_61585_61600(System.Management.Automation.Language.PropertyMemberAst
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 61585, 61600);
                        return return_v;
                    }


                    System.Reflection.Emit.FieldBuilder
                    f_1553_61559_61608(System.Reflection.Emit.EnumBuilder
                    this_param, string
                    literalName, object?
                    literalValue)
                    {
                        var return_v = this_param.DefineLiteral(literalName, literalValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61559, 61608);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    f_1553_58380_58406_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 58380, 58406);
                        return return_v;
                    }


                    System.Reflection.TypeInfo?
                    f_1553_61988_62016(System.Reflection.Emit.EnumBuilder
                    this_param)
                    {
                        var return_v = this_param.CreateTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61988, 62016);
                        return return_v;
                    }


                    System.Type
                    f_1553_61988_62025(System.Reflection.TypeInfo
                    this_param)
                    {
                        var return_v = this_param.AsType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 61988, 62025);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 56167, 62041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 56167, 62041);
                }
            }

            static DefineEnumHelper()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1553, 48774, 62052);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1553, 48774, 62052);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 48774, 62052);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1553, 48774, 62052);
        }

        private static IEnumerable<CustomAttributeBuilder> GetAssemblyAttributeBuilders(string scriptFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 62064, 62952);

                var listYield = new List<CustomAttributeBuilder>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62187, 62282);

                var
                ctor = f_1553_62198_62281(typeof(DynamicClassImplementationAssemblyAttribute), Type.EmptyTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62296, 62334);

                var
                emptyArgs = f_1553_62312_62333()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62350, 62522) || true) && (f_1553_62354_62386(scriptFile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 62350, 62522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62420, 62477);

                    listYield.Add(f_1553_62433_62476(ctor, emptyArgs));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62495, 62507);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 62350, 62522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62538, 62725);

                var
                propertyInfo = new PropertyInfo[] {
f_1553_62595_62722(                typeof(DynamicClassImplementationAssemblyAttribute), nameof(DynamicClassImplementationAssemblyAttribute.ScriptFile))}
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62739, 62786);

                var
                propertyArgs = new object[] { scriptFile }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62802, 62941);

                listYield.Add(f_1553_62815_62940(ctor, emptyArgs, propertyInfo, propertyArgs, f_1553_62904_62928(), emptyArgs));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 62064, 62952);

                return listYield;

                System.Reflection.ConstructorInfo?
                f_1553_62198_62281(System.Type
                this_param, System.Type[]
                types)
                {
                    var return_v = this_param.GetConstructor(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62198, 62281);
                    return return_v;
                }


                object[]
                f_1553_62312_62333()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62312, 62333);
                    return return_v;
                }


                bool
                f_1553_62354_62386(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62354, 62386);
                    return return_v;
                }


                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_62433_62476(System.Reflection.ConstructorInfo
                con, object[]
                constructorArgs)
                {
                    var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62433, 62476);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_1553_62595_62722(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62595, 62722);
                    return return_v;
                }


                System.Reflection.FieldInfo[]
                f_1553_62904_62928()
                {
                    var return_v = Array.Empty<FieldInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62904, 62928);
                    return return_v;
                }


                System.Reflection.Emit.CustomAttributeBuilder
                f_1553_62815_62940(System.Reflection.ConstructorInfo
                con, object[]
                constructorArgs, System.Reflection.PropertyInfo[]
                namedProperties, object[]
                propertyValues, System.Reflection.FieldInfo[]
                namedFields, object[]
                fieldValues)
                {
                    var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 62815, 62940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 62064, 62952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 62064, 62952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int counter;

        internal static Assembly DefineTypes(Parser parser, Ast rootAst, TypeDefinitionAst[] typeDefinitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 63005, 68360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63131, 63227);

                f_1553_63131_63226(f_1553_63150_63164(rootAst) == null, "Caller should only define types from the root ast");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63243, 63316);

                var
                definedTypes = f_1553_63262_63315(f_1553_63282_63314())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63332, 63593);

                var
                assemblyName = new AssemblyName(DynamicClassAssemblyName)
                {
    // We could generate a unique name, but a unique version works too.
    Version = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1553_63521_63577(1, 0, 0, f_1553_63542_63576(ref counter)), 1553, 63351, 63592)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63607, 63779);

                var
                assembly = f_1553_63622_63778(assemblyName, AssemblyBuilderAccess.RunAndCollect, f_1553_63728_63777(f_1553_63757_63776(f_1553_63757_63771(rootAst))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63793, 63861);

                var
                module = f_1553_63806_63860(assembly, DynamicClassAssemblyName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63877, 63930);

                var
                defineTypeHelpers = f_1553_63901_63929()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 63944, 63997);

                var
                defineEnumHelpers = f_1553_63968_63996()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64013, 64851);
                    foreach (var typeDefinitionAst in f_1553_64047_64062_I(typeDefinitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 64013, 64851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64096, 64153);

                        var
                        typeName = f_1553_64111_64152(typeDefinitionAst)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64171, 64836) || true) && (!f_1553_64176_64207(definedTypes, typeName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 64171, 64836);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64249, 64276);

                            f_1553_64249_64275(definedTypes, typeName);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64298, 64817) || true) && ((f_1553_64303_64335(typeDefinitionAst) & TypeAttributes.Class) == TypeAttributes.Class)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 64298, 64817);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64433, 64522);

                                f_1553_64433_64521(defineTypeHelpers, f_1553_64455_64520(parser, module, typeDefinitionAst, typeName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 64298, 64817);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 64298, 64817);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64572, 64817) || true) && ((f_1553_64577_64609(typeDefinitionAst) & TypeAttributes.Enum) == TypeAttributes.Enum)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 64572, 64817);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64705, 64794);

                                    f_1553_64705_64793(defineEnumHelpers, f_1553_64727_64792(parser, module, typeDefinitionAst, typeName));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 64572, 64817);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 64298, 64817);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 64171, 64836);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 64013, 64851);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 64959, 65028);

                defineEnumHelpers = f_1553_64979_65027(defineEnumHelpers, parser);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65042, 65151);
                    foreach (var helper in f_1553_65065_65082_I(defineEnumHelpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 65042, 65151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65116, 65136);

                        f_1553_65116_65135(helper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 65042, 65151);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 110);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65167, 65279);
                    foreach (var helper in f_1553_65190_65207_I(defineTypeHelpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 65167, 65279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65241, 65264);

                        f_1553_65241_65263(helper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 65167, 65279);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 113);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65295, 68317);
                    foreach (var helper in f_1553_65318_65335_I(defineTypeHelpers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 65295, 68317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65369, 65469);

                        f_1553_65369_65468(f_1553_65388_65418(helper._typeDefinitionAst) is TypeBuilder, "Type should be the TypeBuilder");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65487, 65520);

                        bool
                        runtimeTypeAssigned = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65538, 68122) || true) && (f_1553_65542_65564_M(!helper.HasFatalErrors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 65538, 68122);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65658, 65702);

                                var
                                type = f_1553_65669_65701(helper._typeBuilder)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65728, 65766);

                                helper._typeDefinitionAst.Type = type;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65792, 65819);

                                runtimeTypeAssigned = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65845, 65908);

                                var
                                helperType = f_1553_65862_65907(helper._staticHelpersTypeBuilder)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 65936, 66001);

                                SessionStateKeeper
                                sessionStateKeeper = f_1553_65976_66000()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 66027, 66159);

                                f_1553_66027_66158(f_1553_66027_66123(helperType, s_sessionStateKeeperFieldName, BindingFlags.NonPublic | BindingFlags.Static), null, sessionStateKeeper);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 66187, 67220) || true) && (helper._fieldsToInitForMemberFunctions != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 66187, 67220);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 66295, 67193);
                                        foreach (var tuple in f_1553_66317_66355_I(helper._fieldsToInitForMemberFunctions))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 66295, 67193);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 66744, 66977);

                                            var
                                            methodWrapper = (DynAbs.Tracing.TraceSender.Conditional_F1(1553, 66764, 66778) || ((tuple.isStatic
                                            && DynAbs.Tracing.TraceSender.Conditional_F2(1553, 66818, 66887)) || DynAbs.Tracing.TraceSender.Conditional_F3(1553, 66927, 66976))) ? f_1553_66818_66887(tuple.bodyAst, sessionStateKeeper) : f_1553_66927_66976(tuple.bodyAst)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 67011, 67162);

                                            f_1553_67011_67161(f_1553_67011_67093(helperType, tuple.fieldName, BindingFlags.NonPublic | BindingFlags.Static), null, methodWrapper);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 66295, 67193);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 899);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 899);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 66187, 67220);
                                }
                            }
                            catch (TypeLoadException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1553, 67265, 68103);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 67800, 68080);

                                f_1553_67800_68079(                        // This is a cheap way to get error messages about non-implemented abstract/interface methods (and maybe some other errors).
                                                                           // We use .NET API to perform this check during type creation.
                                                                           //
                                                                           // Presumably this catch could go away when we will not create Type at parse time.
                                                                           // Error checking should be moved/added to semantic checks.
                                                        parser, f_1553_67819_67851(helper._typeDefinitionAst), nameof(ParserStrings.TypeCreationError), f_1553_67952_67983(), f_1553_68014_68038(helper._typeBuilder), f_1553_68069_68078(e));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1553, 67265, 68103);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 65538, 68122);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68142, 68302) || true) && (!runtimeTypeAssigned)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 68142, 68302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68245, 68283);

                            helper._typeDefinitionAst.Type = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 68142, 68302);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 65295, 68317);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 1, 3023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 1, 3023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68333, 68349);

                return assembly;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 63005, 68360);

                System.Management.Automation.Language.Ast
                f_1553_63150_63164(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 63150, 63164);
                    return return_v;
                }


                int
                f_1553_63131_63226(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63131, 63226);
                    return 0;
                }


                System.StringComparer
                f_1553_63282_63314()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 63282, 63314);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1553_63262_63315(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63262, 63315);
                    return return_v;
                }


                int
                f_1553_63542_63576(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63542, 63576);
                    return return_v;
                }


                System.Version
                f_1553_63521_63577(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63521, 63577);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_63757_63771(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 63757, 63771);
                    return return_v;
                }


                string
                f_1553_63757_63776(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 63757, 63776);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>
                f_1553_63728_63777(string
                scriptFile)
                {
                    var return_v = GetAssemblyAttributeBuilders(scriptFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63728, 63777);
                    return return_v;
                }


                System.Reflection.Emit.AssemblyBuilder
                f_1553_63622_63778(System.Reflection.AssemblyName
                name, System.Reflection.Emit.AssemblyBuilderAccess
                access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>
                assemblyAttributes)
                {
                    var return_v = AssemblyBuilder.DefineDynamicAssembly(name, access, assemblyAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63622, 63778);
                    return return_v;
                }


                System.Reflection.Emit.ModuleBuilder
                f_1553_63806_63860(System.Reflection.Emit.AssemblyBuilder
                this_param, string
                name)
                {
                    var return_v = this_param.DefineDynamicModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63806, 63860);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                f_1553_63901_63929()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63901, 63929);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                f_1553_63968_63996()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 63968, 63996);
                    return return_v;
                }


                string
                f_1553_64111_64152(System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst)
                {
                    var return_v = GetClassNameInAssembly(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64111, 64152);
                    return return_v;
                }


                bool
                f_1553_64176_64207(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64176, 64207);
                    return return_v;
                }


                bool
                f_1553_64249_64275(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64249, 64275);
                    return return_v;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1553_64303_64335(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.TypeAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 64303, 64335);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                f_1553_64455_64520(System.Management.Automation.Language.Parser
                parser, System.Reflection.Emit.ModuleBuilder
                module, System.Management.Automation.Language.TypeDefinitionAst
                typeDefinitionAst, string
                typeName)
                {
                    var return_v = new System.Management.Automation.Language.TypeDefiner.DefineTypeHelper(parser, module, typeDefinitionAst, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64455, 64520);
                    return return_v;
                }


                int
                f_1553_64433_64521(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                this_param, System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64433, 64521);
                    return 0;
                }


                System.Management.Automation.Language.TypeAttributes
                f_1553_64577_64609(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.TypeAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 64577, 64609);
                    return return_v;
                }


                System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                f_1553_64727_64792(System.Management.Automation.Language.Parser
                parser, System.Reflection.Emit.ModuleBuilder
                module, System.Management.Automation.Language.TypeDefinitionAst
                enumDefinitionAst, string
                typeName)
                {
                    var return_v = new System.Management.Automation.Language.TypeDefiner.DefineEnumHelper(parser, module, enumDefinitionAst, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64727, 64792);
                    return return_v;
                }


                int
                f_1553_64705_64793(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                this_param, System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64705, 64793);
                    return 0;
                }


                System.Management.Automation.Language.TypeDefinitionAst[]
                f_1553_64047_64062_I(System.Management.Automation.Language.TypeDefinitionAst[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64047, 64062);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                f_1553_64979_65027(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                defineEnumHelpers, System.Management.Automation.Language.Parser
                parser)
                {
                    var return_v = DefineEnumHelper.Sort(defineEnumHelpers, parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 64979, 65027);
                    return return_v;
                }


                int
                f_1553_65116_65135(System.Management.Automation.Language.TypeDefiner.DefineEnumHelper
                this_param)
                {
                    this_param.DefineEnum();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65116, 65135);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                f_1553_65065_65082_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineEnumHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65065, 65082);
                    return return_v;
                }


                int
                f_1553_65241_65263(System.Management.Automation.Language.TypeDefiner.DefineTypeHelper
                this_param)
                {
                    this_param.DefineMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65241, 65263);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                f_1553_65190_65207_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65190, 65207);
                    return return_v;
                }


                System.Type
                f_1553_65388_65418(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 65388, 65418);
                    return return_v;
                }


                int
                f_1553_65369_65468(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65369, 65468);
                    return 0;
                }


                bool
                f_1553_65542_65564_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 65542, 65564);
                    return return_v;
                }


                System.Type?
                f_1553_65669_65701(System.Reflection.Emit.TypeBuilder
                this_param)
                {
                    var return_v = this_param.CreateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65669, 65701);
                    return return_v;
                }


                System.Type?
                f_1553_65862_65907(System.Reflection.Emit.TypeBuilder
                this_param)
                {
                    var return_v = this_param.CreateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65862, 65907);
                    return return_v;
                }


                System.Management.Automation.Internal.SessionStateKeeper
                f_1553_65976_66000()
                {
                    var return_v = new System.Management.Automation.Internal.SessionStateKeeper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65976, 66000);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_1553_66027_66123(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 66027, 66123);
                    return return_v;
                }


                int
                f_1553_66027_66158(System.Reflection.FieldInfo
                this_param, object?
                obj, System.Management.Automation.Internal.SessionStateKeeper
                value)
                {
                    this_param.SetValue(obj, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 66027, 66158);
                    return 0;
                }


                System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                f_1553_66818_66887(System.Management.Automation.Language.IParameterMetadataProvider
                ast, System.Management.Automation.Internal.SessionStateKeeper
                sessionStateKeeper)
                {
                    var return_v = new System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper(ast, sessionStateKeeper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 66818, 66887);
                    return return_v;
                }


                System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                f_1553_66927_66976(System.Management.Automation.Language.IParameterMetadataProvider
                ast)
                {
                    var return_v = new System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 66927, 66976);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_1553_67011_67093(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetField(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 67011, 67093);
                    return return_v;
                }


                int
                f_1553_67011_67161(System.Reflection.FieldInfo
                this_param, object?
                obj, System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                value)
                {
                    this_param.SetValue(obj, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 67011, 67161);
                    return 0;
                }


                System.Collections.Generic.List<(string fieldName, System.Management.Automation.Language.IParameterMetadataProvider bodyAst, bool isStatic)>
                f_1553_66317_66355_I(System.Collections.Generic.List<(string fieldName, System.Management.Automation.Language.IParameterMetadataProvider bodyAst, bool isStatic)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 66317, 66355);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_67819_67851(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 67819, 67851);
                    return return_v;
                }


                string
                f_1553_67952_67983()
                {
                    var return_v = ParserStrings.TypeCreationError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 67952, 67983);
                    return return_v;
                }


                string
                f_1553_68014_68038(System.Reflection.Emit.TypeBuilder
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 68014, 68038);
                    return return_v;
                }


                string
                f_1553_68069_68078(System.TypeLoadException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 68069, 68078);
                    return return_v;
                }


                int
                f_1553_67800_68079(System.Management.Automation.Language.Parser
                this_param, System.Management.Automation.Language.IScriptExtent
                extent, string
                errorId, string
                errorMsg, string
                arg1, string
                arg2)
                {
                    this_param.ReportError(extent, errorId, errorMsg, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 67800, 68079);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                f_1553_65318_65335_I(System.Collections.Generic.List<System.Management.Automation.Language.TypeDefiner.DefineTypeHelper>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 65318, 65335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 63005, 68360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 63005, 68360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetClassNameInAssembly(TypeDefinitionAst typeDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 68372, 69656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68573, 68603);

                List<string>
                nameParts = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68617, 68655);

                var
                parent = f_1553_68630_68654(typeDefinitionAst)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68669, 69392) || true) && (f_1553_68676_68689(parent) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 68669, 69392);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68731, 69334) || true) && (parent is IParameterMetadataProvider)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 68731, 69334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68813, 68857);

                            nameParts = nameParts ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<string>>(1553, 68825, 68856) ?? f_1553_68838_68856());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68879, 68931);

                            var
                            fnDefn = f_1553_68892_68905(parent) as FunctionDefinitionAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 68953, 69315) || true) && (fnDefn != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 68953, 69315);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69021, 69037);

                                parent = fnDefn;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69063, 69090);

                                f_1553_69063_69089(nameParts, f_1553_69077_69088(fnDefn));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 68953, 69315);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 68953, 69315);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69188, 69292);

                                f_1553_69188_69291(nameParts, "<" + f_1553_69208_69284(f_1553_69208_69240(f_1553_69208_69226(f_1553_69208_69221(parent))), "x", f_1553_69255_69283()) + ">");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 68953, 69315);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 68731, 69334);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69354, 69377);

                        parent = f_1553_69363_69376(parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 68669, 69392);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1553, 68669, 69392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1553, 68669, 69392);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69408, 69508) || true) && (nameParts == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 69408, 69508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69463, 69493);

                    return f_1553_69470_69492(typeDefinitionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 69408, 69508);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69524, 69544);

                f_1553_69524_69543(
                            nameParts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69558, 69596);

                f_1553_69558_69595(nameParts, f_1553_69572_69594(typeDefinitionAst));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69610, 69645);

                return f_1553_69617_69644(".", nameParts);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 68372, 69656);

                System.Management.Automation.Language.Ast
                f_1553_68630_68654(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 68630, 68654);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1553_68676_68689(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 68676, 68689);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1553_68838_68856()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 68838, 68856);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1553_68892_68905(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 68892, 68905);
                    return return_v;
                }


                string
                f_1553_69077_69088(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69077, 69088);
                    return return_v;
                }


                int
                f_1553_69063_69089(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69063, 69089);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1553_69208_69221(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69208, 69221);
                    return return_v;
                }


                string
                f_1553_69208_69226(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69208, 69226);
                    return return_v;
                }


                int
                f_1553_69208_69240(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69208, 69240);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1553_69255_69283()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69255, 69283);
                    return return_v;
                }


                string
                f_1553_69208_69284(int
                this_param, string
                format, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString(format, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69208, 69284);
                    return return_v;
                }


                int
                f_1553_69188_69291(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69188, 69291);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1553_69363_69376(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69363, 69376);
                    return return_v;
                }


                string
                f_1553_69470_69492(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69470, 69492);
                    return return_v;
                }


                int
                f_1553_69524_69543(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Reverse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69524, 69543);
                    return 0;
                }


                string
                f_1553_69572_69594(System.Management.Automation.Language.TypeDefinitionAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 69572, 69594);
                    return return_v;
                }


                int
                f_1553_69558_69595(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69558, 69595);
                    return 0;
                }


                string
                f_1553_69617_69644(string
                separator, System.Collections.Generic.List<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 69617, 69644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 68372, 69656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 68372, 69656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static OpCode[] s_ldc;

        private static void EmitLdc(ILGenerator emitter, int c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 69921, 70202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70001, 70191) || true) && (c < f_1553_70009_70021(s_ldc))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 70001, 70191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70055, 70078);

                    f_1553_70055_70077(emitter, s_ldc[c]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 70001, 70191);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 70001, 70191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70144, 70176);

                    f_1553_70144_70175(emitter, OpCodes.Ldc_I4, c);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 70001, 70191);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 69921, 70202);

                int
                f_1553_70009_70021(System.Reflection.Emit.OpCode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 70009, 70021);
                    return return_v;
                }


                int
                f_1553_70055_70077(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 70055, 70077);
                    return 0;
                }


                int
                f_1553_70144_70175(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 70144, 70175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 69921, 70202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 69921, 70202);
            }
        }

        private static OpCode[] s_ldarg;

        private static void EmitLdarg(ILGenerator emitter, int c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1553, 70362, 70648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70444, 70637) || true) && (c < f_1553_70452_70466(s_ldarg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 70444, 70637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70500, 70525);

                    f_1553_70500_70524(emitter, s_ldarg[c]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 70444, 70637);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1553, 70444, 70637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70591, 70622);

                    f_1553_70591_70621(emitter, OpCodes.Ldarg, c);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1553, 70444, 70637);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1553, 70362, 70648);

                int
                f_1553_70452_70466(System.Reflection.Emit.OpCode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1553, 70452, 70466);
                    return return_v;
                }


                int
                f_1553_70500_70524(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 70500, 70524);
                    return 0;
                }


                int
                f_1553_70591_70621(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 70591, 70621);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1553, 70362, 70648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 70362, 70648);
            }
        }

        public TypeDefiner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1553, 440, 70655);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1553, 440, 70655);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 440, 70655);
        }


        static TypeDefiner()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1553, 440, 70655);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 505, 559);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 592, 657);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 689, 708);
            s_globalCounter = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 766, 918);
            s_hiddenCustomAttributeBuilder = f_1553_812_918(f_1553_839_894(typeof(HiddenAttribute), Type.EmptyTypes), f_1553_896_917());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 962, 1016);
            s_sessionStateKeeperFieldName = "__sessionStateKeeper";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1059, 1099);
            SessionStateFieldName = "__sessionState";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 1145, 1297);
            s_sessionStateKeeper_GetSessionState = f_1553_1197_1297(typeof(SessionStateKeeper), "GetSessionState", BindingFlags.Instance | BindingFlags.Public);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 62983, 62994);
            counter = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 69692, 69908);
            s_ldc = new OpCode[]{
            OpCodes.Ldc_I4_0, OpCodes.Ldc_I4_1, OpCodes.Ldc_I4_2, OpCodes.Ldc_I4_3, OpCodes.Ldc_I4_4,
            OpCodes.Ldc_I4_5, OpCodes.Ldc_I4_6, OpCodes.Ldc_I4_7, OpCodes.Ldc_I4_8
        };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1553, 70238, 70349);
            s_ldarg = new OpCode[]{
            OpCodes.Ldarg_0, OpCodes.Ldarg_1, OpCodes.Ldarg_2, OpCodes.Ldarg_3
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1553, 440, 70655);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1553, 440, 70655);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1553, 440, 70655);

        static System.Reflection.ConstructorInfo?
        f_1553_839_894(System.Type
        this_param, System.Type[]
        types)
        {
            var return_v = this_param.GetConstructor(types);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 839, 894);
            return return_v;
        }


        static object[]
        f_1553_896_917()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 896, 917);
            return return_v;
        }


        static System.Reflection.Emit.CustomAttributeBuilder
        f_1553_812_918(System.Reflection.ConstructorInfo
        con, object[]
        constructorArgs)
        {
            var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 812, 918);
            return return_v;
        }


        static System.Reflection.MethodInfo?
        f_1553_1197_1297(System.Type
        this_param, string
        name, System.Reflection.BindingFlags
        bindingAttr)
        {
            var return_v = this_param.GetMethod(name, bindingAttr);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1553, 1197, 1297);
            return return_v;
        }

    }
}
