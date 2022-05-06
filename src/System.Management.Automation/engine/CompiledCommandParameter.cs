// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace System.Management.Automation
{
    internal class CompiledCommandParameter
    {
        internal CompiledCommandParameter(RuntimeDefinedParameter runtimeDefinedParameter, bool processingDynamicParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1255, 1362, 4870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8834, 8876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8991, 9039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9155, 9195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9311, 9360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9490, 9535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9655, 9746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9980, 10051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10192, 10289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10430, 10510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10644, 10710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10862, 10916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11116, 11164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11347, 11408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11605, 11670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11844, 11883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12112, 12185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12358, 12423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12811, 12856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12966, 13018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 13181, 13277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 13385, 13432);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1503, 1659) || true) && (runtimeDefinedParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 1503, 1659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1572, 1644);

                    throw f_1255_1578_1643("runtimeDefinedParameter");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 1503, 1659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1675, 1716);

                this.Name = f_1255_1687_1715(runtimeDefinedParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1730, 1780);

                this.Type = f_1255_1742_1779(runtimeDefinedParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1794, 1839);

                this.IsDynamic = processingDynamicParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1855, 1966);

                this.CollectionTypeInformation = f_1255_1888_1965(f_1255_1927_1964(runtimeDefinedParameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 1982, 2036);

                this.CompiledAttributes = f_1255_2008_2035();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2052, 2163);

                this.ParameterSetData = f_1255_2076_2162(f_1255_2129_2161());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2179, 2246);

                Collection<ValidateArgumentsAttribute>
                validationAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2260, 2339);

                Collection<ArgumentTransformationAttribute>
                argTransformationAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2353, 2377);

                string[]
                aliases = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2464, 3546);
                    foreach (Attribute attribute in f_1255_2496_2530_I(f_1255_2496_2530(runtimeDefinedParameter)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 2464, 3546);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 2564, 3270) || true) && (processingDynamicParameters)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 2564, 3270);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3074, 3251) || true) && (attribute is ExperimentalAttribute || (DynAbs.Tracing.TraceSender.Expression_False(1255, 3078, 3169) || attribute is ParameterAttribute param && (DynAbs.Tracing.TraceSender.Expression_True(1255, 3116, 3169) && f_1255_3157_3169(param))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 3074, 3251);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3219, 3228);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 3074, 3251);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 2564, 3270);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3290, 3531) || true) && (!(attribute is ArgumentTypeConverterAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 3290, 3531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3382, 3512);

                            f_1255_3382_3511(this, f_1255_3399_3427(runtimeDefinedParameter), attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 3290, 3531);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 2464, 3546);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 1083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 1083);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3726, 3999) || true) && ((f_1255_3731_3740(this) == typeof(PSCredential)) && (DynAbs.Tracing.TraceSender.Expression_True(1255, 3730, 3804) && argTransformationAttributes == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 3726, 3999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 3838, 3984);

                    f_1255_3838_3983(this, f_1255_3855_3883(runtimeDefinedParameter), f_1255_3885_3910(), ref validationAttributes, ref argTransformationAttributes, ref aliases);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 3726, 3999);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 4059, 4339);
                    foreach (var attribute in f_1255_4085_4160_I(f_1255_4085_4160(f_1255_4085_4119(runtimeDefinedParameter))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 4059, 4339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 4194, 4324);

                        f_1255_4194_4323(this, f_1255_4211_4239(runtimeDefinedParameter), attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 4059, 4339);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 4355, 4523);

                this.ValidationAttributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1255, 4383, 4411) || ((validationAttributes == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1255, 4431, 4472)) || DynAbs.Tracing.TraceSender.Conditional_F3(1255, 4492, 4522))) ? f_1255_4431_4472() : f_1255_4492_4522(validationAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 4537, 4736);

                this.ArgumentTransformationAttributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1255, 4577, 4612) || ((argTransformationAttributes == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1255, 4632, 4678)) || DynAbs.Tracing.TraceSender.Conditional_F3(1255, 4698, 4735))) ? f_1255_4632_4678() : f_1255_4698_4735(argTransformationAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 4750, 4859);

                this.Aliases = (DynAbs.Tracing.TraceSender.Conditional_F1(1255, 4765, 4780) || ((aliases == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1255, 4800, 4821)) || DynAbs.Tracing.TraceSender.Conditional_F3(1255, 4841, 4858))) ? f_1255_4800_4821() : f_1255_4841_4858(aliases);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1255, 1362, 4870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 1362, 4870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 1362, 4870);
            }
        }

        internal CompiledCommandParameter(MemberInfo member, bool processingDynamicParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1255, 5875, 8703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8834, 8876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8991, 9039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9155, 9195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9311, 9360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9490, 9535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9655, 9746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 9980, 10051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10192, 10289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10430, 10510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10644, 10710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 10862, 10916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11116, 11164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11347, 11408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11605, 11670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 11844, 11883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12112, 12185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12358, 12423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12811, 12856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 12966, 13018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 13181, 13277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 13385, 13432);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 5986, 6108) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 5986, 6108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6038, 6093);

                    throw f_1255_6044_6092("member");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 5986, 6108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6124, 6148);

                this.Name = f_1255_6136_6147(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6162, 6204);

                this.DeclaringType = f_1255_6183_6203(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6218, 6263);

                this.IsDynamic = processingDynamicParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6279, 6321);

                var
                propertyInfo = member as PropertyInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6335, 7006) || true) && (propertyInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 6335, 7006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6393, 6431);

                    this.Type = f_1255_6405_6430(propertyInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 6335, 7006);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 6335, 7006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6497, 6533);

                    var
                    fieldInfo = member as FieldInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6551, 6991) || true) && (fieldInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 6551, 6991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6614, 6646);

                        this.Type = f_1255_6626_6645(fieldInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 6551, 6991);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 6551, 6991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6728, 6940);

                        ArgumentException
                        e =
                        f_1255_6771_6939("member", f_1255_6867_6938())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 6964, 6972);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 6551, 6991);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 6335, 7006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7022, 7105);

                this.CollectionTypeInformation = f_1255_7055_7104(f_1255_7094_7103(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7119, 7173);

                this.CompiledAttributes = f_1255_7145_7172();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7187, 7298);

                this.ParameterSetData = f_1255_7211_7297(f_1255_7264_7296());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7454, 7511);

                var
                memberAttributes = f_1255_7477_7510(member, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7527, 7594);

                Collection<ValidateArgumentsAttribute>
                validationAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7608, 7687);

                Collection<ArgumentTransformationAttribute>
                argTransformationAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7701, 7725);

                string[]
                aliases = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7741, 8233);
                    foreach (Attribute attr in f_1255_7768_7784_I(memberAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 7741, 8233);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7818, 8218);

                        switch (attr)
                        {

                            case ExperimentalAttribute _:
                            case ParameterAttribute param when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 7953, 7970) || true) && (f_1255_7958_7970(param)) && (DynAbs.Tracing.TraceSender.Expression_True(1255, 7953, 7970) || true)
                        :
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 7818, 8218);
                                DynAbs.Tracing.TraceSender.TraceBreak(1255, 7997, 8003);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 7818, 8218);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 7818, 8218);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8059, 8167);

                                f_1255_8059_8166(this, f_1255_8076_8087(member), attr, ref validationAttributes, ref argTransformationAttributes, ref aliases);
                                DynAbs.Tracing.TraceSender.TraceBreak(1255, 8193, 8199);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 7818, 8218);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 7741, 8233);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8249, 8417);

                this.ValidationAttributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1255, 8277, 8305) || ((validationAttributes == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1255, 8325, 8366)) || DynAbs.Tracing.TraceSender.Conditional_F3(1255, 8386, 8416))) ? f_1255_8325_8366() : f_1255_8386_8416(validationAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8431, 8630);

                this.ArgumentTransformationAttributes = (DynAbs.Tracing.TraceSender.Conditional_F1(1255, 8471, 8506) || ((argTransformationAttributes == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1255, 8526, 8572)) || DynAbs.Tracing.TraceSender.Conditional_F3(1255, 8592, 8629))) ? f_1255_8526_8572() : f_1255_8592_8629(argTransformationAttributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 8644, 8692);

                this.Aliases = aliases ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1255, 8659, 8691) ?? f_1255_8670_8691());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1255, 5875, 8703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 5875, 8703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 5875, 8703);
            }
        }

        internal string Name { get; private set; }

        internal string PSTypeName { get; private set; }

        internal Type Type { get; private set; }

        internal Type DeclaringType { get; private set; }

        internal bool IsDynamic { get; private set; }

        internal ParameterCollectionTypeInformation CollectionTypeInformation { get; private set; }

        internal Collection<Attribute> CompiledAttributes { get; private set; }

        internal ArgumentTransformationAttribute[] ArgumentTransformationAttributes { get; private set; }

        internal ValidateArgumentsAttribute[] ValidationAttributes { get; private set; }

        internal ObsoleteAttribute ObsoleteAttribute { get; private set; }

        internal bool AllowsNullArgument { get; private set; }

        internal bool CannotBeNull { get; private set; }

        internal bool AllowsEmptyStringArgument { get; private set; }

        internal bool AllowsEmptyCollectionArgument { get; private set; }

        internal bool IsInAllSets { get; set; }

        internal bool IsPipelineParameterInSomeParameterSet { get; private set; }

        internal bool IsMandatoryInSomeParameterSet { get; private set; }

        internal uint ParameterSetFlags { get; set; }

        internal Action<object, object> Setter { get; set; }

        internal Dictionary<string, ParameterSetSpecificMetadata> ParameterSetData { get; private set; }

        internal string[] Aliases { get; private set; }

        internal bool DoesParameterSetTakePipelineInput(uint validParameterSetFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 13976, 14933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14077, 14181) || true) && (f_1255_14081_14119_M(!IsPipelineParameterInSomeParameterSet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 14077, 14181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14153, 14166);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 14077, 14181);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14431, 14893);
                    foreach (ParameterSetSpecificMetadata parameterSetData in f_1255_14489_14512_I(f_1255_14489_14512(f_1255_14489_14505())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 14431, 14893);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14546, 14878) || true) && ((f_1255_14551_14579(parameterSetData) || (DynAbs.Tracing.TraceSender.Expression_False(1255, 14551, 14669) || (f_1255_14605_14638(parameterSetData) & validParameterSetFlags) != 0)) && (DynAbs.Tracing.TraceSender.Expression_True(1255, 14550, 14805) && (f_1255_14696_14730(parameterSetData) || (DynAbs.Tracing.TraceSender.Expression_False(1255, 14696, 14804) || f_1255_14756_14804(parameterSetData)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 14546, 14878);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14847, 14859);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 14546, 14878);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 14431, 14893);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 14909, 14922);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 13976, 14933);

                bool
                f_1255_14081_14119_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14081, 14119);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1255_14489_14505()
                {
                    var return_v = ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14489, 14505);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_14489_14512(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14489, 14512);
                    return return_v;
                }


                bool
                f_1255_14551_14579(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14551, 14579);
                    return return_v;
                }


                uint
                f_1255_14605_14638(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14605, 14638);
                    return return_v;
                }


                bool
                f_1255_14696_14730(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14696, 14730);
                    return return_v;
                }


                bool
                f_1255_14756_14804(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 14756, 14804);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_14489_14512_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 14489, 14512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 13976, 14933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 13976, 14933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ParameterSetSpecificMetadata GetParameterSetData(uint parameterSetFlag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 15344, 16166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 15449, 15492);

                ParameterSetSpecificMetadata
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 15508, 16125);
                    foreach (ParameterSetSpecificMetadata setData in f_1255_15557_15580_I(f_1255_15557_15580(f_1255_15557_15573())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 15508, 16125);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 15751, 16110) || true) && (f_1255_15755_15774(setData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 15751, 16110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 15816, 15833);

                            result = setData;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 15751, 16110);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 15751, 16110);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 15915, 16091) || true) && ((f_1255_15920_15944(setData) & parameterSetFlag) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 15915, 16091);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 16019, 16036);

                                result = setData;
                                DynAbs.Tracing.TraceSender.TraceBreak(1255, 16062, 16068);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 15915, 16091);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 15751, 16110);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 15508, 16125);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 16141, 16155);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 15344, 16166);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1255_15557_15573()
                {
                    var return_v = ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 15557, 15573);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_15557_15580(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 15557, 15580);
                    return return_v;
                }


                bool
                f_1255_15755_15774(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 15755, 15774);
                    return return_v;
                }


                uint
                f_1255_15920_15944(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 15920, 15944);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_15557_15580_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 15557, 15580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 15344, 16166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 15344, 16166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<ParameterSetSpecificMetadata> GetMatchingParameterSetData(uint parameterSetFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 16655, 17387);

                var listYield = new List<ParameterSetSpecificMetadata>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 16782, 17376);
                    foreach (ParameterSetSpecificMetadata setData in f_1255_16831_16854_I(f_1255_16831_16854(f_1255_16831_16847())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 16782, 17376);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 17025, 17361) || true) && (f_1255_17029_17048(setData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 17025, 17361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 17090, 17111);

                            listYield.Add(setData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 17025, 17361);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 17025, 17361);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 17193, 17342) || true) && ((f_1255_17198_17222(setData) & parameterSetFlags) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 17193, 17342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 17298, 17319);

                                listYield.Add(setData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 17193, 17342);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 17025, 17361);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 16782, 17376);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1255, 1, 595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1255, 1, 595);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 16655, 17387);

                return listYield;

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1255_16831_16847()
                {
                    var return_v = ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 16831, 16847);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_16831_16854(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 16831, 16854);
                    return return_v;
                }


                bool
                f_1255_17029_17048(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 17029, 17048);
                    return return_v;
                }


                uint
                f_1255_17198_17222(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 17198, 17222);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                f_1255_16831_16854_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 16831, 16854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 16655, 17387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 16655, 17387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessAttribute(
                    string memberName,
                    Attribute attribute,
                    ref Collection<ValidateArgumentsAttribute> validationAttributes,
                    ref Collection<ArgumentTransformationAttribute> argTransformationAttributes,
                    ref string[] aliases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 17795, 21489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18119, 18166) || true) && (attribute == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 18119, 18166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18159, 18166);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 18119, 18166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18182, 18216);

                f_1255_18182_18215(f_1255_18182_18200(), attribute);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18293, 18461) || true) && (attribute is ParameterAttribute paramAttr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 18293, 18461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18372, 18421);

                    f_1255_18372_18420(this, memberName, paramAttr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18439, 18446);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 18293, 18461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18477, 18559);

                ValidateArgumentsAttribute
                validateAttr = attribute as ValidateArgumentsAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18573, 19050) || true) && (validateAttr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 18573, 19050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18631, 18754) || true) && (validationAttributes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 18631, 18754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18686, 18754);

                        validationAttributes = f_1255_18709_18753();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 18631, 18754);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18772, 18811);

                    f_1255_18772_18810(validationAttributes, validateAttr);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18829, 19008) || true) && ((attribute is ValidateNotNullAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(1255, 18833, 18922) || (attribute is ValidateNotNullOrEmptyAttribute)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 18829, 19008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 18964, 18989);

                        this.CannotBeNull = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 18829, 19008);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19028, 19035);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 18573, 19050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19066, 19121);

                AliasAttribute
                aliasAttr = attribute as AliasAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19135, 19792) || true) && (aliasAttr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 19135, 19792);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19190, 19750) || true) && (aliases == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 19190, 19750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19251, 19282);

                        aliases = aliasAttr.aliasNames;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 19190, 19750);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 19190, 19750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19364, 19393);

                        var
                        prevAliasNames = aliases
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19415, 19456);

                        var
                        newAliasNames = aliasAttr.aliasNames
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19478, 19545);

                        aliases = new string[f_1255_19499_19520(prevAliasNames) + f_1255_19523_19543(newAliasNames)];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19567, 19626);

                        f_1255_19567_19625(prevAliasNames, aliases, f_1255_19603_19624(prevAliasNames));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19648, 19731);

                        f_1255_19648_19730(newAliasNames, 0, aliases, f_1255_19686_19707(prevAliasNames), f_1255_19709_19729(newAliasNames));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 19190, 19750);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19770, 19777);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 19135, 19792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19808, 19900);

                ArgumentTransformationAttribute
                argumentAttr = attribute as ArgumentTransformationAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19914, 20218) || true) && (argumentAttr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 19914, 20218);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 19972, 20114) || true) && (argTransformationAttributes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 19972, 20114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20034, 20114);

                        argTransformationAttributes = f_1255_20064_20113();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 19972, 20114);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20132, 20178);

                    f_1255_20132_20177(argTransformationAttributes, argumentAttr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20196, 20203);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 19914, 20218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20234, 20306);

                AllowNullAttribute
                allowNullAttribute = attribute as AllowNullAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20320, 20455) || true) && (allowNullAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 20320, 20455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20384, 20415);

                    this.AllowsNullArgument = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20433, 20440);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 20320, 20455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20471, 20564);

                AllowEmptyStringAttribute
                allowEmptyStringAttribute = attribute as AllowEmptyStringAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20578, 20727) || true) && (allowEmptyStringAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 20578, 20727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20649, 20687);

                    this.AllowsEmptyStringArgument = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20705, 20712);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 20578, 20727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20743, 20848);

                AllowEmptyCollectionAttribute
                allowEmptyCollectionAttribute = attribute as AllowEmptyCollectionAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20862, 21019) || true) && (allowEmptyCollectionAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 20862, 21019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20937, 20979);

                    this.AllowsEmptyCollectionArgument = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 20997, 21004);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 20862, 21019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21035, 21099);

                ObsoleteAttribute
                obsoleteAttr = attribute as ObsoleteAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21113, 21244) || true) && (obsoleteAttr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 21113, 21244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21171, 21204);

                    ObsoleteAttribute = obsoleteAttr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21222, 21229);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 21113, 21244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21260, 21335);

                PSTypeNameAttribute
                psTypeNameAttribute = attribute as PSTypeNameAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21349, 21478) || true) && (psTypeNameAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 21349, 21478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 21414, 21463);

                    this.PSTypeName = f_1255_21432_21462(psTypeNameAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 21349, 21478);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 17795, 21489);

                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1255_18182_18200()
                {
                    var return_v = CompiledAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 18182, 18200);
                    return return_v;
                }


                int
                f_1255_18182_18215(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Attribute
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 18182, 18215);
                    return 0;
                }


                int
                f_1255_18372_18420(System.Management.Automation.CompiledCommandParameter
                this_param, string
                parameterName, System.Management.Automation.ParameterAttribute
                parameter)
                {
                    this_param.ProcessParameterAttribute(parameterName, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 18372, 18420);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
                f_1255_18709_18753()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 18709, 18753);
                    return return_v;
                }


                int
                f_1255_18772_18810(System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
                this_param, System.Management.Automation.ValidateArgumentsAttribute
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 18772, 18810);
                    return 0;
                }


                int
                f_1255_19499_19520(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 19499, 19520);
                    return return_v;
                }


                int
                f_1255_19523_19543(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 19523, 19543);
                    return return_v;
                }


                int
                f_1255_19603_19624(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 19603, 19624);
                    return return_v;
                }


                int
                f_1255_19567_19625(string[]
                sourceArray, string[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 19567, 19625);
                    return 0;
                }


                int
                f_1255_19686_19707(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 19686, 19707);
                    return return_v;
                }


                int
                f_1255_19709_19729(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 19709, 19729);
                    return return_v;
                }


                int
                f_1255_19648_19730(string[]
                sourceArray, int
                sourceIndex, string[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 19648, 19730);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
                f_1255_20064_20113()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 20064, 20113);
                    return return_v;
                }


                int
                f_1255_20132_20177(System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
                this_param, System.Management.Automation.ArgumentTransformationAttribute
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 20132, 20177);
                    return 0;
                }


                string
                f_1255_21432_21462(System.Management.Automation.PSTypeNameAttribute
                this_param)
                {
                    var return_v = this_param.PSTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 21432, 21462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 17795, 21489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 17795, 21489);
            }
        }

        private void ProcessParameterAttribute(
                    string parameterName,
                    ParameterAttribute parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 22049, 23443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 22352, 22843) || true) && (f_1255_22356_22412(f_1255_22356_22372(), f_1255_22385_22411(parameter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 22352, 22843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 22446, 22800);

                    MetadataException
                    e =
                    f_1255_22489_22799("ParameterDeclaredInParameterSetMultipleTimes", null, f_1255_22641_22705(), parameterName, f_1255_22772_22798(parameter))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 22820, 22828);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 22352, 22843);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 22859, 23029) || true) && (f_1255_22863_22890(parameter) || (DynAbs.Tracing.TraceSender.Expression_False(1255, 22863, 22935) || f_1255_22894_22935(parameter)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 22859, 23029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 22969, 23014);

                    IsPipelineParameterInSomeParameterSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 22859, 23029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 23045, 23154) || true) && (f_1255_23049_23068(parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 23045, 23154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 23102, 23139);

                    IsMandatoryInSomeParameterSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 23045, 23154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 23243, 23343);

                ParameterSetSpecificMetadata
                parameterSetSpecificData = f_1255_23299_23342(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 23357, 23432);

                f_1255_23357_23431(f_1255_23357_23373(), f_1255_23378_23404(parameter), parameterSetSpecificData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 22049, 23443);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1255_22356_22372()
                {
                    var return_v = ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22356, 22372);
                    return return_v;
                }


                string
                f_1255_22385_22411(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22385, 22411);
                    return return_v;
                }


                bool
                f_1255_22356_22412(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 22356, 22412);
                    return return_v;
                }


                string
                f_1255_22641_22705()
                {
                    var return_v = DiscoveryExceptions.ParameterDeclaredInParameterSetMultipleTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22641, 22705);
                    return return_v;
                }


                string
                f_1255_22772_22798(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22772, 22798);
                    return return_v;
                }


                System.Management.Automation.MetadataException
                f_1255_22489_22799(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 22489, 22799);
                    return return_v;
                }


                bool
                f_1255_22863_22890(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22863, 22890);
                    return return_v;
                }


                bool
                f_1255_22894_22935(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 22894, 22935);
                    return return_v;
                }


                bool
                f_1255_23049_23068(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.Mandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 23049, 23068);
                    return return_v;
                }


                System.Management.Automation.ParameterSetSpecificMetadata
                f_1255_23299_23342(System.Management.Automation.ParameterAttribute
                attribute)
                {
                    var return_v = new System.Management.Automation.ParameterSetSpecificMetadata(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 23299, 23342);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1255_23357_23373()
                {
                    var return_v = ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 23357, 23373);
                    return return_v;
                }


                string
                f_1255_23378_23404(System.Management.Automation.ParameterAttribute
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 23378, 23404);
                    return return_v;
                }


                int
                f_1255_23357_23431(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetSpecificMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 23357, 23431);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 22049, 23443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 22049, 23443);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1255, 23455, 23536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 23513, 23525);

                return f_1255_23520_23524();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1255, 23455, 23536);

                string
                f_1255_23520_23524()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 23520, 23524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 23455, 23536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 23455, 23536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompiledCommandParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1255, 386, 23580);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1255, 386, 23580);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 386, 23580);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1255, 386, 23580);

        System.Management.Automation.PSArgumentNullException
        f_1255_1578_1643(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 1578, 1643);
            return return_v;
        }


        string
        f_1255_1687_1715(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 1687, 1715);
            return return_v;
        }


        System.Type
        f_1255_1742_1779(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.ParameterType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 1742, 1779);
            return return_v;
        }


        System.Type
        f_1255_1927_1964(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.ParameterType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 1927, 1964);
            return return_v;
        }


        System.Management.Automation.ParameterCollectionTypeInformation
        f_1255_1888_1965(System.Type
        type)
        {
            var return_v = new System.Management.Automation.ParameterCollectionTypeInformation(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 1888, 1965);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1255_2008_2035()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 2008, 2035);
            return return_v;
        }


        System.StringComparer
        f_1255_2129_2161()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 2129, 2161);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1255_2076_2162(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 2076, 2162);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1255_2496_2530(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Attributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 2496, 2530);
            return return_v;
        }


        bool
        f_1255_3157_3169(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.ToHide;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 3157, 3169);
            return return_v;
        }


        string
        f_1255_3399_3427(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 3399, 3427);
            return return_v;
        }


        int
        f_1255_3382_3511(System.Management.Automation.CompiledCommandParameter
        this_param, string
        memberName, System.Attribute
        attribute, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        validationAttributes, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        argTransformationAttributes, ref string[]
        aliases)
        {
            this_param.ProcessAttribute(memberName, attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 3382, 3511);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1255_2496_2530_I(System.Collections.ObjectModel.Collection<System.Attribute>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 2496, 2530);
            return return_v;
        }


        System.Type
        f_1255_3731_3740(System.Management.Automation.CompiledCommandParameter
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 3731, 3740);
            return return_v;
        }


        string
        f_1255_3855_3883(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 3855, 3883);
            return return_v;
        }


        System.Management.Automation.CredentialAttribute
        f_1255_3885_3910()
        {
            var return_v = new System.Management.Automation.CredentialAttribute();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 3885, 3910);
            return return_v;
        }


        int
        f_1255_3838_3983(System.Management.Automation.CompiledCommandParameter
        this_param, string
        memberName, System.Management.Automation.CredentialAttribute
        attribute, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        validationAttributes, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        argTransformationAttributes, ref string[]
        aliases)
        {
            this_param.ProcessAttribute(memberName, (System.Attribute)attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 3838, 3983);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1255_4085_4119(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Attributes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 4085, 4119);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.ArgumentTypeConverterAttribute>
        f_1255_4085_4160(System.Collections.ObjectModel.Collection<System.Attribute>
        source)
        {
            var return_v = source.OfType<System.Management.Automation.ArgumentTypeConverterAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4085, 4160);
            return return_v;
        }


        string
        f_1255_4211_4239(System.Management.Automation.RuntimeDefinedParameter
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 4211, 4239);
            return return_v;
        }


        int
        f_1255_4194_4323(System.Management.Automation.CompiledCommandParameter
        this_param, string
        memberName, System.Management.Automation.ArgumentTypeConverterAttribute
        attribute, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        validationAttributes, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        argTransformationAttributes, ref string[]
        aliases)
        {
            this_param.ProcessAttribute(memberName, (System.Attribute)attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4194, 4323);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.ArgumentTypeConverterAttribute>
        f_1255_4085_4160_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ArgumentTypeConverterAttribute>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4085, 4160);
            return return_v;
        }


        System.Management.Automation.ValidateArgumentsAttribute[]
        f_1255_4431_4472()
        {
            var return_v = Array.Empty<ValidateArgumentsAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4431, 4472);
            return return_v;
        }


        System.Management.Automation.ValidateArgumentsAttribute[]
        f_1255_4492_4522(System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        source)
        {
            var return_v = source.ToArray<System.Management.Automation.ValidateArgumentsAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4492, 4522);
            return return_v;
        }


        System.Management.Automation.ArgumentTransformationAttribute[]
        f_1255_4632_4678()
        {
            var return_v = Array.Empty<ArgumentTransformationAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4632, 4678);
            return return_v;
        }


        System.Management.Automation.ArgumentTransformationAttribute[]
        f_1255_4698_4735(System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        source)
        {
            var return_v = source.ToArray<System.Management.Automation.ArgumentTransformationAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4698, 4735);
            return return_v;
        }


        string[]
        f_1255_4800_4821()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4800, 4821);
            return return_v;
        }


        string[]
        f_1255_4841_4858(string[]
        source)
        {
            var return_v = source.ToArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 4841, 4858);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1255_6044_6092(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 6044, 6092);
            return return_v;
        }


        string
        f_1255_6136_6147(System.Reflection.MemberInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 6136, 6147);
            return return_v;
        }


        System.Type
        f_1255_6183_6203(System.Reflection.MemberInfo
        this_param)
        {
            var return_v = this_param.DeclaringType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 6183, 6203);
            return return_v;
        }


        System.Type
        f_1255_6405_6430(System.Reflection.PropertyInfo
        this_param)
        {
            var return_v = this_param.PropertyType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 6405, 6430);
            return return_v;
        }


        System.Type
        f_1255_6626_6645(System.Reflection.FieldInfo
        this_param)
        {
            var return_v = this_param.FieldType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 6626, 6645);
            return return_v;
        }


        string
        f_1255_6867_6938()
        {
            var return_v = DiscoveryExceptions.CompiledCommandParameterMemberMustBeFieldOrProperty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 6867, 6938);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1255_6771_6939(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 6771, 6939);
            return return_v;
        }


        System.Type
        f_1255_7094_7103(System.Management.Automation.CompiledCommandParameter
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 7094, 7103);
            return return_v;
        }


        System.Management.Automation.ParameterCollectionTypeInformation
        f_1255_7055_7104(System.Type
        type)
        {
            var return_v = new System.Management.Automation.ParameterCollectionTypeInformation(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 7055, 7104);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1255_7145_7172()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 7145, 7172);
            return return_v;
        }


        System.StringComparer
        f_1255_7264_7296()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 7264, 7296);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1255_7211_7297(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 7211, 7297);
            return return_v;
        }


        object[]
        f_1255_7477_7510(System.Reflection.MemberInfo
        this_param, bool
        inherit)
        {
            var return_v = this_param.GetCustomAttributes(inherit);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 7477, 7510);
            return return_v;
        }


        bool
        f_1255_7958_7970(System.Management.Automation.ParameterAttribute
        this_param)
        {
            var return_v = this_param.ToHide;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 7958, 7970);
            return return_v;
        }


        string
        f_1255_8076_8087(System.Reflection.MemberInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 8076, 8087);
            return return_v;
        }


        int
        f_1255_8059_8166(System.Management.Automation.CompiledCommandParameter
        this_param, string
        memberName, System.Attribute
        attribute, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        validationAttributes, ref System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        argTransformationAttributes, ref string[]
        aliases)
        {
            this_param.ProcessAttribute(memberName, attribute, ref validationAttributes, ref argTransformationAttributes, ref aliases);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8059, 8166);
            return 0;
        }


        object[]
        f_1255_7768_7784_I(object[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 7768, 7784);
            return return_v;
        }


        System.Management.Automation.ValidateArgumentsAttribute[]
        f_1255_8325_8366()
        {
            var return_v = Array.Empty<ValidateArgumentsAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8325, 8366);
            return return_v;
        }


        System.Management.Automation.ValidateArgumentsAttribute[]
        f_1255_8386_8416(System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateArgumentsAttribute>
        source)
        {
            var return_v = source.ToArray<System.Management.Automation.ValidateArgumentsAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8386, 8416);
            return return_v;
        }


        System.Management.Automation.ArgumentTransformationAttribute[]
        f_1255_8526_8572()
        {
            var return_v = Array.Empty<ArgumentTransformationAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8526, 8572);
            return return_v;
        }


        System.Management.Automation.ArgumentTransformationAttribute[]
        f_1255_8592_8629(System.Collections.ObjectModel.Collection<System.Management.Automation.ArgumentTransformationAttribute>
        source)
        {
            var return_v = source.ToArray<System.Management.Automation.ArgumentTransformationAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8592, 8629);
            return return_v;
        }


        string[]
        f_1255_8670_8691()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 8670, 8691);
            return return_v;
        }

    }

    /// <summary>
    /// The types of collections that are supported as parameter types.
    /// </summary>
    internal enum ParameterCollectionType
    {
        NotCollection,
        IList,
        Array,
        ICollectionGeneric
    }
    internal class ParameterCollectionTypeInformation
    {
        internal ParameterCollectionTypeInformation(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1255, 24349, 28031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 28141, 28219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 28335, 28382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 24428, 24492);

                ParameterCollectionType = ParameterCollectionType.NotCollection;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 24506, 24573);

                f_1255_24506_24572(type != null, "Caller to verify type argument");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 24965, 25185) || true) && (f_1255_24969_25001(type, typeof(Array)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 24965, 25185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25035, 25091);

                    ParameterCollectionType = ParameterCollectionType.Array;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25109, 25145);

                    ElementType = f_1255_25123_25144(type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25163, 25170);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 24965, 25185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25201, 25303) || true) && (f_1255_25205_25247(typeof(IDictionary), type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 25201, 25303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25281, 25288);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 25201, 25303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25319, 25360);

                Type[]
                interfaces = f_1255_25339_25359(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25374, 25630) || true) && (f_1255_25378_25472(interfaces, i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDictionary<,>)) || (DynAbs.Tracing.TraceSender.Expression_False(1255, 25378, 25574) || (f_1255_25494_25512(type) && (DynAbs.Tracing.TraceSender.Expression_True(1255, 25494, 25573) && f_1255_25516_25547(type) == typeof(IDictionary<,>)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 25374, 25630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25608, 25615);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 25374, 25630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 25646, 25717);

                bool
                implementsIList = (f_1255_25670_25707(type, f_1255_25688_25706(typeof(IList))) != null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26051, 26606) || true) && (implementsIList && (DynAbs.Tracing.TraceSender.Expression_True(1255, 26055, 26092) && f_1255_26074_26092(type)) && (DynAbs.Tracing.TraceSender.Expression_True(1255, 26055, 26153) && (f_1255_26097_26128(type) == typeof(Collection<>))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 26051, 26606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26187, 26243);

                    ParameterCollectionType = ParameterCollectionType.IList;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26304, 26353);

                    Type[]
                    elementTypes = f_1255_26326_26352(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26371, 26518);

                    f_1255_26371_26517(f_1255_26412_26431(elementTypes) == 1, "Expected 1 generic argument, got " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1255_26497_26516(elementTypes)).ToString(), 1255, 26497, 26516));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26536, 26566);

                    ElementType = elementTypes[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 26584, 26591);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 26051, 26606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27008, 27158);

                Type
                interfaceICollection =
                f_1255_27053_27157(interfaces, i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27172, 27779) || true) && (interfaceICollection != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 27172, 27779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27331, 27400);

                    ParameterCollectionType = ParameterCollectionType.ICollectionGeneric;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27461, 27526);

                    Type[]
                    elementTypes = f_1255_27483_27525(interfaceICollection)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27544, 27691);

                    f_1255_27544_27690(f_1255_27585_27604(elementTypes) == 1, "Expected 1 generic argument, got " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1255_27670_27689(elementTypes)).ToString(), 1255, 27670, 27689));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27709, 27739);

                    ElementType = elementTypes[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27757, 27764);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 27172, 27779);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27826, 28020) || true) && (implementsIList)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1255, 27826, 28020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27879, 27935);

                    ParameterCollectionType = ParameterCollectionType.IList;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1255, 27998, 28005);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1255, 27826, 28020);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1255, 24349, 28031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1255, 24349, 28031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 24349, 28031);
            }
        }

        internal ParameterCollectionType ParameterCollectionType { get; private set; }

        internal Type ElementType { get; private set; }

        static ParameterCollectionTypeInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1255, 23949, 28389);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1255, 23949, 28389);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1255, 23949, 28389);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1255, 23949, 28389);

        int
        f_1255_24506_24572(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 24506, 24572);
            return 0;
        }


        bool
        f_1255_24969_25001(System.Type
        this_param, System.Type
        c)
        {
            var return_v = this_param.IsSubclassOf(c);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 24969, 25001);
            return return_v;
        }


        System.Type?
        f_1255_25123_25144(System.Type
        this_param)
        {
            var return_v = this_param.GetElementType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25123, 25144);
            return return_v;
        }


        bool
        f_1255_25205_25247(System.Type
        this_param, System.Type
        c)
        {
            var return_v = this_param.IsAssignableFrom(c);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25205, 25247);
            return return_v;
        }


        System.Type[]
        f_1255_25339_25359(System.Type
        this_param)
        {
            var return_v = this_param.GetInterfaces();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25339, 25359);
            return return_v;
        }


        bool
        f_1255_25378_25472(System.Type[]
        source, System.Func<System.Type, bool>
        predicate)
        {
            var return_v = source.Any<System.Type>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25378, 25472);
            return return_v;
        }


        bool
        f_1255_25494_25512(System.Type
        this_param)
        {
            var return_v = this_param.IsGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 25494, 25512);
            return return_v;
        }


        System.Type
        f_1255_25516_25547(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericTypeDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25516, 25547);
            return return_v;
        }


        string
        f_1255_25688_25706(System.Type
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 25688, 25706);
            return return_v;
        }


        System.Type?
        f_1255_25670_25707(System.Type
        this_param, string
        name)
        {
            var return_v = this_param.GetInterface(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 25670, 25707);
            return return_v;
        }


        bool
        f_1255_26074_26092(System.Type
        this_param)
        {
            var return_v = this_param.IsGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 26074, 26092);
            return return_v;
        }


        System.Type
        f_1255_26097_26128(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericTypeDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 26097, 26128);
            return return_v;
        }


        System.Type[]
        f_1255_26326_26352(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericArguments();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 26326, 26352);
            return return_v;
        }


        int
        f_1255_26412_26431(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 26412, 26431);
            return return_v;
        }


        int
        f_1255_26497_26516(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 26497, 26516);
            return return_v;
        }


        int
        f_1255_26371_26517(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 26371, 26517);
            return 0;
        }


        System.Type
        f_1255_27053_27157(System.Type[]
        source, System.Func<System.Type, bool>
        predicate)
        {
            var return_v = source.FirstOrDefault<System.Type>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 27053, 27157);
            return return_v;
        }


        System.Type[]
        f_1255_27483_27525(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericArguments();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 27483, 27525);
            return return_v;
        }


        int
        f_1255_27585_27604(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 27585, 27604);
            return return_v;
        }


        int
        f_1255_27670_27689(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1255, 27670, 27689);
            return return_v;
        }


        int
        f_1255_27544_27690(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1255, 27544, 27690);
            return 0;
        }

    }
}
