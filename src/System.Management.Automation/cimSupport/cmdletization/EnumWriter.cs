// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.Management.Automation;
using System.Reflection;
using System.Reflection.Emit;

using Microsoft.PowerShell.Cmdletization.Xml;

namespace Microsoft.PowerShell.Cmdletization
{
    internal static class EnumWriter
    {
        private const string
        namespacePrefix = "Microsoft.PowerShell.Cmdletization.GeneratedTypes"
        ;

        private static ModuleBuilder CreateModuleBuilder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1061, 494, 834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 569, 624);

                AssemblyName
                aName = f_1061_590_623(namespacePrefix)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 638, 731);

                AssemblyBuilder
                ab = f_1061_659_730(aName, AssemblyBuilderAccess.Run)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 745, 799);

                ModuleBuilder
                mb = f_1061_764_798(ab, f_1061_787_797(aName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 813, 823);

                return mb;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1061, 494, 834);

                System.Reflection.AssemblyName
                f_1061_590_623(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 590, 623);
                    return return_v;
                }


                System.Reflection.Emit.AssemblyBuilder
                f_1061_659_730(System.Reflection.AssemblyName
                name, System.Reflection.Emit.AssemblyBuilderAccess
                access)
                {
                    var return_v = AssemblyBuilder.DefineDynamicAssembly(name, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 659, 730);
                    return return_v;
                }


                string
                f_1061_787_797(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 787, 797);
                    return return_v;
                }


                System.Reflection.Emit.ModuleBuilder
                f_1061_764_798(System.Reflection.Emit.AssemblyBuilder
                this_param, string
                name)
                {
                    var return_v = this_param.DefineDynamicModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 764, 798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1061, 494, 834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1061, 494, 834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Lazy<ModuleBuilder> s_moduleBuilder;

        private static object s_moduleBuilderUsageLock;

        internal static string GetEnumFullName(EnumMetadataEnum enumMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1061, 1048, 1206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1142, 1195);

                return namespacePrefix + "." + f_1061_1173_1194(enumMetadata);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1061, 1048, 1206);

                string
                f_1061_1173_1194(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.EnumName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1173, 1194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1061, 1048, 1206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1061, 1048, 1206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void Compile(EnumMetadataEnum enumMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1061, 1218, 2616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1302, 1354);

                string
                fullEnumName = f_1061_1324_1353(enumMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1370, 1390);

                Type
                underlyingType
                = default(Type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1404, 1712) || true) && (f_1061_1408_1435(enumMetadata) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1061, 1404, 1712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1477, 1602);

                    underlyingType = (Type)f_1061_1500_1601(f_1061_1529_1556(enumMetadata), typeof(Type), f_1061_1572_1600());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1061, 1404, 1712);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1061, 1404, 1712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1668, 1697);

                    underlyingType = typeof(int);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1061, 1404, 1712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1728, 1769);

                ModuleBuilder
                mb = f_1061_1747_1768(s_moduleBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1783, 1798);

                EnumBuilder
                eb
                = default(EnumBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1818, 1842);
                lock (s_moduleBuilderUsageLock)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1876, 1948);

                    eb = f_1061_1881_1947(mb, fullEnumName, TypeAttributes.Public, underlyingType);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 1979, 2256) || true) && (f_1061_1983_2017(enumMetadata) && (DynAbs.Tracing.TraceSender.Expression_True(1061, 1983, 2046) && f_1061_2021_2046(enumMetadata)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1061, 1979, 2256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2080, 2196);

                    var
                    cab = f_1061_2090_2195(f_1061_2117_2171(typeof(FlagsAttribute), Type.EmptyTypes), f_1061_2173_2194())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2214, 2241);

                    f_1061_2214_2240(eb, cab);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1061, 1979, 2256);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2272, 2569);
                    foreach (var value in f_1061_2294_2312_I(f_1061_2294_2312(enumMetadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1061, 2272, 2569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2346, 2371);

                        string
                        name = f_1061_2360_2370(value)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2389, 2499);

                        object
                        integerValue = f_1061_2411_2498(f_1061_2440_2451(value), underlyingType, f_1061_2469_2497())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2517, 2554);

                        f_1061_2517_2553(eb, name, integerValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1061, 2272, 2569);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1061, 1, 298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1061, 1, 298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 2585, 2605);

                f_1061_2585_2604(
                            eb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1061, 1218, 2616);

                string
                f_1061_1324_1353(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                enumMetadata)
                {
                    var return_v = GetEnumFullName(enumMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 1324, 1353);
                    return return_v;
                }


                string
                f_1061_1408_1435(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.UnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1408, 1435);
                    return return_v;
                }


                string
                f_1061_1529_1556(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.UnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1529, 1556);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1061_1572_1600()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1572, 1600);
                    return return_v;
                }


                object
                f_1061_1500_1601(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 1500, 1601);
                    return return_v;
                }


                System.Reflection.Emit.ModuleBuilder
                f_1061_1747_1768(System.Lazy<System.Reflection.Emit.ModuleBuilder>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1747, 1768);
                    return return_v;
                }


                System.Reflection.Emit.EnumBuilder
                f_1061_1881_1947(System.Reflection.Emit.ModuleBuilder
                this_param, string
                name, System.Reflection.TypeAttributes
                visibility, System.Type
                underlyingType)
                {
                    var return_v = this_param.DefineEnum(name, visibility, underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 1881, 1947);
                    return return_v;
                }


                bool
                f_1061_1983_2017(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.BitwiseFlagsSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 1983, 2017);
                    return return_v;
                }


                bool
                f_1061_2021_2046(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.BitwiseFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 2021, 2046);
                    return return_v;
                }


                System.Reflection.ConstructorInfo?
                f_1061_2117_2171(System.Type
                this_param, System.Type[]
                types)
                {
                    var return_v = this_param.GetConstructor(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2117, 2171);
                    return return_v;
                }


                object[]
                f_1061_2173_2194()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2173, 2194);
                    return return_v;
                }


                System.Reflection.Emit.CustomAttributeBuilder
                f_1061_2090_2195(System.Reflection.ConstructorInfo
                con, object[]
                constructorArgs)
                {
                    var return_v = new System.Reflection.Emit.CustomAttributeBuilder(con, constructorArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2090, 2195);
                    return return_v;
                }


                int
                f_1061_2214_2240(System.Reflection.Emit.EnumBuilder
                this_param, System.Reflection.Emit.CustomAttributeBuilder
                customBuilder)
                {
                    this_param.SetCustomAttribute(customBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2214, 2240);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnumValue[]
                f_1061_2294_2312(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 2294, 2312);
                    return return_v;
                }


                string
                f_1061_2360_2370(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnumValue
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 2360, 2370);
                    return return_v;
                }


                string
                f_1061_2440_2451(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnumValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 2440, 2451);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1061_2469_2497()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1061, 2469, 2497);
                    return return_v;
                }


                object
                f_1061_2411_2498(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2411, 2498);
                    return return_v;
                }


                System.Reflection.Emit.FieldBuilder
                f_1061_2517_2553(System.Reflection.Emit.EnumBuilder
                this_param, string
                literalName, object
                literalValue)
                {
                    var return_v = this_param.DefineLiteral(literalName, literalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2517, 2553);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnumValue[]
                f_1061_2294_2312_I(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnumValue[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2294, 2312);
                    return return_v;
                }


                System.Reflection.TypeInfo?
                f_1061_2585_2604(System.Reflection.Emit.EnumBuilder
                this_param)
                {
                    var return_v = this_param.CreateTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 2585, 2604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1061, 1218, 2616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1061, 1218, 2616);
            }
        }

        static EnumWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1061, 342, 2623);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 412, 481);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 881, 963);
            s_moduleBuilder = f_1061_899_963(CreateModuleBuilder, isThreadSafe: true);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1061, 996, 1035);
            s_moduleBuilderUsageLock = f_1061_1023_1035();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1061, 342, 2623);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1061, 342, 2623);
        }


        static System.Lazy<System.Reflection.Emit.ModuleBuilder>
        f_1061_899_963(System.Func<System.Reflection.Emit.ModuleBuilder>
        valueFactory, bool
        isThreadSafe)
        {
            var return_v = new System.Lazy<System.Reflection.Emit.ModuleBuilder>(valueFactory, isThreadSafe: isThreadSafe);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 899, 963);
            return return_v;
        }


        static object
        f_1061_1023_1035()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1061, 1023, 1035);
            return return_v;
        }

    }
}
