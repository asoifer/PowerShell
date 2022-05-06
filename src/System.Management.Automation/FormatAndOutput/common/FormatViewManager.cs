// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Text;

using Microsoft.PowerShell.Commands;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal static class DefaultScalarTypes
    {
        internal static bool IsTypeInList(Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 455, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 710, 776);

                string
                typeName = f_1095_728_775(typeNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 792, 858) || true) && (f_1095_796_826(typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 792, 858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 845, 858);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 792, 858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 874, 949);

                string
                originalTypeName = f_1095_900_948(typeName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 965, 1039) || true) && (f_1095_969_1007(originalTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 965, 1039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1026, 1039);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 965, 1039);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1194, 1269) || true) && (f_1095_1198_1238(typeNames))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 1194, 1269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1257, 1269);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 1194, 1269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1285, 1344);

                return f_1095_1292_1343(s_defaultScalarTypesHash, originalTypeName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 455, 1355);

                string
                f_1095_728_775(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = PSObjectHelper.PSObjectIsOfExactType(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 728, 775);
                    return return_v;
                }


                bool
                f_1095_796_826(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 796, 826);
                    return return_v;
                }


                string
                f_1095_900_948(string
                typeName)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 900, 948);
                    return return_v;
                }


                bool
                f_1095_969_1007(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 969, 1007);
                    return return_v;
                }


                bool
                f_1095_1198_1238(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = PSObjectHelper.PSObjectIsEnum(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1198, 1238);
                    return return_v;
                }


                bool
                f_1095_1292_1343(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1292, 1343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 455, 1355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 455, 1355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DefaultScalarTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1095, 1367, 2458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2510, 2590);
                s_defaultScalarTypesHash = f_1095_2537_2590(f_1095_2557_2589());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1419, 1465);

                f_1095_1419_1464(s_defaultScalarTypesHash, "System.String");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1479, 1524);

                f_1095_1479_1523(s_defaultScalarTypesHash, "System.SByte");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1538, 1582);

                f_1095_1538_1581(s_defaultScalarTypesHash, "System.Byte");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1596, 1641);

                f_1095_1596_1640(s_defaultScalarTypesHash, "System.Int16");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1655, 1701);

                f_1095_1655_1700(s_defaultScalarTypesHash, "System.UInt16");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1715, 1760);

                f_1095_1715_1759(s_defaultScalarTypesHash, "System.Int32");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1774, 1820);

                f_1095_1774_1819(s_defaultScalarTypesHash, "System.UInt32");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1834, 1879);

                f_1095_1834_1878(s_defaultScalarTypesHash, "System.Int64");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1893, 1939);

                f_1095_1893_1938(s_defaultScalarTypesHash, "System.UInt64");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 1953, 1997);

                f_1095_1953_1996(s_defaultScalarTypesHash, "System.Char");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2011, 2057);

                f_1095_2011_2056(s_defaultScalarTypesHash, "System.Single");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2071, 2117);

                f_1095_2071_2116(s_defaultScalarTypesHash, "System.Double");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2131, 2178);

                f_1095_2131_2177(s_defaultScalarTypesHash, "System.Boolean");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2192, 2239);

                f_1095_2192_2238(s_defaultScalarTypesHash, "System.Decimal");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2253, 2299);

                f_1095_2253_2298(s_defaultScalarTypesHash, "System.IntPtr");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2313, 2374);

                f_1095_2313_2373(s_defaultScalarTypesHash, "System.Security.SecureString");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2388, 2447);

                f_1095_2388_2446(s_defaultScalarTypesHash, "System.Numerics.BigInteger");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1095, 1367, 2458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 1367, 2458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 1367, 2458);
            }
        }

        private static readonly HashSet<string> s_defaultScalarTypesHash;

        static bool
        f_1095_1419_1464(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1419, 1464);
            return return_v;
        }


        static bool
        f_1095_1479_1523(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1479, 1523);
            return return_v;
        }


        static bool
        f_1095_1538_1581(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1538, 1581);
            return return_v;
        }


        static bool
        f_1095_1596_1640(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1596, 1640);
            return return_v;
        }


        static bool
        f_1095_1655_1700(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1655, 1700);
            return return_v;
        }


        static bool
        f_1095_1715_1759(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1715, 1759);
            return return_v;
        }


        static bool
        f_1095_1774_1819(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1774, 1819);
            return return_v;
        }


        static bool
        f_1095_1834_1878(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1834, 1878);
            return return_v;
        }


        static bool
        f_1095_1893_1938(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1893, 1938);
            return return_v;
        }


        static bool
        f_1095_1953_1996(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 1953, 1996);
            return return_v;
        }


        static bool
        f_1095_2011_2056(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2011, 2056);
            return return_v;
        }


        static bool
        f_1095_2071_2116(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2071, 2116);
            return return_v;
        }


        static bool
        f_1095_2131_2177(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2131, 2177);
            return return_v;
        }


        static bool
        f_1095_2192_2238(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2192, 2238);
            return return_v;
        }


        static bool
        f_1095_2253_2298(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2253, 2298);
            return return_v;
        }


        static bool
        f_1095_2313_2373(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2313, 2373);
            return return_v;
        }


        static bool
        f_1095_2388_2446(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2388, 2446);
            return return_v;
        }


        static System.StringComparer
        f_1095_2557_2589()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 2557, 2589);
            return return_v;
        }


        static System.Collections.Generic.HashSet<string>
        f_1095_2537_2590(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2537, 2590);
            return return_v;
        }

    }
    internal sealed class FormatViewManager
    {
        [TraceSource("FormatViewBinding", "Format view binding")]
        private static PSTraceSource s_formatViewBindingTracer;

        private static string PSObjectTypeName(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 3084, 3495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3226, 3448) || true) && (so != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 3226, 3448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3274, 3311);

                    var
                    typeNames = f_1095_3290_3310(so)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3329, 3433) || true) && (f_1095_3333_3348(typeNames) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 3329, 3433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3394, 3414);

                        return f_1095_3401_3413(typeNames, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 3329, 3433);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 3226, 3448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3464, 3484);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 3084, 3495);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1095_3290_3310(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 3290, 3310);
                    return return_v;
                }


                int
                f_1095_3333_3348(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 3333, 3348);
                    return return_v;
                }


                string
                f_1095_3401_3413(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 3401, 3413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 3084, 3495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 3084, 3495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Initialize(TerminatingErrorContext errorContext,
                                            PSPropertyExpressionFactory expressionFactory,
                                            TypeInfoDataBase db,
                                            PSObject so,
                                            FormatShape shape,
                                            FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 3507, 9397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3923, 3950);

                ViewDefinition
                view = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 3964, 4017);

                const string
                findViewType = "FINDING VIEW TYPE: {0}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4031, 4093);

                const string
                findViewShapeType = "FINDING VIEW {0} TYPE: {1}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4107, 4174);

                const string
                findViewNameType = "FINDING VIEW NAME: {0} TYPE: {1}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4188, 4249);

                const string
                viewFound = "An applicable view has been found"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4263, 4327);

                const string
                viewNotFound = "No applicable view has been found"
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4377, 4431);

                    f_1095_4377_4430(s_formatViewBindingTracer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4514, 4551);

                    var
                    typeNames = f_1095_4530_4550(so)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4569, 6220) || true) && (shape == FormatShape.Undefined)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 4569, 6220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4645, 4890);
                        using (f_1095_4652_4724(s_formatViewBindingTracer, findViewType, f_1095_4703_4723(so)))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4774, 4867);

                            view = f_1095_4781_4866(expressionFactory, db, shape, typeNames, null);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1095, 4645, 4890);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 4914, 5660) || true) && (view != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 4914, 5660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5102, 5458);

                            _viewGenerator = f_1095_5119_5457(errorContext, expressionFactory, db, view, parameters);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5484, 5531);

                            f_1095_5484_5530(s_formatViewBindingTracer, viewFound);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5557, 5604);

                            f_1095_5557_5603(f_1095_5585_5598(), so);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5630, 5637);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 4914, 5660);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5684, 5734);

                        f_1095_5684_5733(
                                            s_formatViewBindingTracer, viewNotFound);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 5996, 6101);

                        _viewGenerator = f_1095_6013_6100(shape, so, errorContext, expressionFactory, db, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6123, 6170);

                        f_1095_6123_6169(f_1095_6151_6164(), so);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6194, 6201);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 4569, 6220);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6341, 6605) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1095, 6345, 6404) && f_1095_6367_6400(parameters.mshParameterList) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 6341, 6605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6446, 6557);

                        _viewGenerator = f_1095_6463_6556(shape, so, errorContext, expressionFactory, db, parameters);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6579, 6586);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 6341, 6605);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6704, 7967) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1095, 6708, 6772) && !f_1095_6731_6772(parameters.viewName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 6704, 7967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6814, 7124);
                        using (f_1095_6821_6943(s_formatViewBindingTracer, findViewNameType, parameters.viewName, f_1095_6922_6942(so)))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 6993, 7101);

                            view = f_1095_7000_7100(expressionFactory, db, shape, typeNames, parameters.viewName);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1095, 6814, 7124);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7148, 7719) || true) && (view != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 7148, 7719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7214, 7590);

                            _viewGenerator = f_1095_7231_7589(errorContext, expressionFactory, db, view, parameters);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7616, 7663);

                            f_1095_7616_7662(s_formatViewBindingTracer, viewFound);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7689, 7696);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 7148, 7719);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7743, 7793);

                        f_1095_7743_7792(
                                            s_formatViewBindingTracer, viewNotFound);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 7875, 7948);

                        f_1095_7875_7947(errorContext, parameters.viewName, so, db, shape);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 6704, 7967);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8069, 8314);
                    using (f_1095_8076_8160(s_formatViewBindingTracer, findViewShapeType, shape, f_1095_8139_8159(so)))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8202, 8295);

                        view = f_1095_8209_8294(expressionFactory, db, shape, typeNames, null);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1095, 8069, 8314);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8334, 8936) || true) && (view != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 8334, 8936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8392, 8748);

                        _viewGenerator = f_1095_8409_8747(errorContext, expressionFactory, db, view, parameters);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8770, 8817);

                        f_1095_8770_8816(s_formatViewBindingTracer, viewFound);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8839, 8886);

                        f_1095_8839_8885(f_1095_8867_8880(), so);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8910, 8917);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 8334, 8936);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 8956, 9006);

                    f_1095_8956_9005(
                                    s_formatViewBindingTracer, viewNotFound);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 9095, 9206);

                    _viewGenerator = f_1095_9112_9205(shape, so, errorContext, expressionFactory, db, parameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 9224, 9271);

                    f_1095_9224_9270(f_1095_9252_9265(), so);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1095, 9300, 9386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 9340, 9371);

                    f_1095_9340_9370();
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1095, 9300, 9386);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 3507, 9397);

                int
                f_1095_4377_4430(System.Management.Automation.PSTraceSource
                t)
                {
                    DisplayDataQuery.SetTracer(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 4377, 4430);
                    return 0;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1095_4530_4550(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 4530, 4550);
                    return return_v;
                }


                string
                f_1095_4703_4723(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectTypeName(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 4703, 4723);
                    return return_v;
                }


                System.IDisposable
                f_1095_4652_4724(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 4652, 4724);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1095_4781_4866(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames, string
                viewName)
                {
                    var return_v = DisplayDataQuery.GetViewByShapeAndType(expressionFactory, db, shape, (System.Collections.ObjectModel.Collection<string>)typeNames, viewName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 4781, 4866);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_5119_5457(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromViewDefinition(errorContext, expressionFactory, db, view, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 5119, 5457);
                    return return_v;
                }


                int
                f_1095_5484_5530(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 5484, 5530);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_5585_5598()
                {
                    var return_v = ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 5585, 5598);
                    return return_v;
                }


                int
                f_1095_5557_5603(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                viewGenerator, System.Management.Automation.PSObject
                so)
                {
                    PrepareViewForRemoteObjects(viewGenerator, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 5557, 5603);
                    return 0;
                }


                int
                f_1095_5684_5733(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 5684, 5733);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_6013_6100(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromProperties(shape, so, errorContext, expressionFactory, db, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6013, 6100);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_6151_6164()
                {
                    var return_v = ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 6151, 6164);
                    return return_v;
                }


                int
                f_1095_6123_6169(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                viewGenerator, System.Management.Automation.PSObject
                so)
                {
                    PrepareViewForRemoteObjects(viewGenerator, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6123, 6169);
                    return 0;
                }


                int
                f_1095_6367_6400(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 6367, 6400);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_6463_6556(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromProperties(shape, so, errorContext, expressionFactory, db, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6463, 6556);
                    return return_v;
                }


                bool
                f_1095_6731_6772(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6731, 6772);
                    return return_v;
                }


                string
                f_1095_6922_6942(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectTypeName(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6922, 6942);
                    return return_v;
                }


                System.IDisposable
                f_1095_6821_6943(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 6821, 6943);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1095_7000_7100(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames, string
                viewName)
                {
                    var return_v = DisplayDataQuery.GetViewByShapeAndType(expressionFactory, db, shape, (System.Collections.ObjectModel.Collection<string>)typeNames, viewName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 7000, 7100);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_7231_7589(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromViewDefinition(errorContext, expressionFactory, db, view, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 7231, 7589);
                    return return_v;
                }


                int
                f_1095_7616_7662(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 7616, 7662);
                    return 0;
                }


                int
                f_1095_7743_7792(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 7743, 7792);
                    return 0;
                }


                int
                f_1095_7875_7947(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, string
                viewName, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                formatShape)
                {
                    ProcessUnknownViewName(errorContext, viewName, so, db, formatShape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 7875, 7947);
                    return 0;
                }


                string
                f_1095_8139_8159(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectTypeName(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8139, 8159);
                    return return_v;
                }


                System.IDisposable
                f_1095_8076_8160(System.Management.Automation.PSTraceSource
                this_param, string
                format, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                arg1, string
                arg2)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8076, 8160);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1095_8209_8294(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames, string
                viewName)
                {
                    var return_v = DisplayDataQuery.GetViewByShapeAndType(expressionFactory, db, shape, (System.Collections.ObjectModel.Collection<string>)typeNames, viewName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8209, 8294);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_8409_8747(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromViewDefinition(errorContext, expressionFactory, db, view, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8409, 8747);
                    return return_v;
                }


                int
                f_1095_8770_8816(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8770, 8816);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_8867_8880()
                {
                    var return_v = ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 8867, 8880);
                    return return_v;
                }


                int
                f_1095_8839_8885(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                viewGenerator, System.Management.Automation.PSObject
                so)
                {
                    PrepareViewForRemoteObjects(viewGenerator, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8839, 8885);
                    return 0;
                }


                int
                f_1095_8956_9005(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 8956, 9005);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_9112_9205(Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    var return_v = SelectViewGeneratorFromProperties(shape, so, errorContext, expressionFactory, db, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 9112, 9205);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1095_9252_9265()
                {
                    var return_v = ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 9252, 9265);
                    return return_v;
                }


                int
                f_1095_9224_9270(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                viewGenerator, System.Management.Automation.PSObject
                so)
                {
                    PrepareViewForRemoteObjects(viewGenerator, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 9224, 9270);
                    return 0;
                }


                int
                f_1095_9340_9370()
                {
                    DisplayDataQuery.ResetTracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 9340, 9370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 3507, 9397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 3507, 9397);
            }
        }

        private static void PrepareViewForRemoteObjects(ViewGenerator viewGenerator, PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 9820, 10089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 9934, 10078) || true) && (f_1095_9938_9987(so))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 9934, 10078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10021, 10063);

                    f_1095_10021_10062(viewGenerator, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 9934, 10078);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 9820, 10089);

                bool
                f_1095_9938_9987(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.ShouldShowComputerNameProperty(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 9938, 9987);
                    return return_v;
                }


                int
                f_1095_10021_10062(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.PrepareForRemoteObjects(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 10021, 10062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 9820, 10089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 9820, 10089);
            }
        }

        private static void ProcessUnknownViewName(TerminatingErrorContext errorContext, string viewName, PSObject so, TypeInfoDataBase db, FormatShape formatShape)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 10626, 17500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10807, 10825);

                string
                msg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10839, 10868);

                bool
                foundValidViews = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10882, 10911);

                string
                formatTypeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10925, 10949);

                string
                separator = ", "
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 10963, 11016);

                StringBuilder
                validViewFormats = f_1095_10996_11015()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11032, 15977) || true) && (so != null && (DynAbs.Tracing.TraceSender.Expression_True(1095, 11036, 11071) && f_1095_11050_11063(so) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1095, 11036, 11102) && db != null) && (DynAbs.Tracing.TraceSender.Expression_True(1095, 11036, 11139) && db.viewDefinitionsSection != null) && (DynAbs.Tracing.TraceSender.Expression_True(1095, 11036, 11212) && db.viewDefinitionsSection.viewDefinitionList != null) && (DynAbs.Tracing.TraceSender.Expression_True(1095, 11036, 11287) && f_1095_11233_11283(db.viewDefinitionsSection.viewDefinitionList) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11032, 15977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11321, 11368);

                    StringBuilder
                    validViews = f_1095_11348_11367()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11386, 11452);

                    string
                    currentObjectTypeName = f_1095_11417_11451(f_1095_11417_11440(f_1095_11417_11430(so)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11472, 11495);

                    Type
                    formatType = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11513, 12309) || true) && (formatShape == FormatShape.Table)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11513, 12309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11591, 11629);

                        formatType = typeof(TableControlBody);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11651, 11676);

                        formatTypeName = "Table";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11513, 12309);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11513, 12309);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11718, 12309) || true) && (formatShape == FormatShape.List)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11718, 12309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11795, 11832);

                            formatType = typeof(ListControlBody);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11854, 11878);

                            formatTypeName = "List";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11718, 12309);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11718, 12309);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11920, 12309) || true) && (formatShape == FormatShape.Wide)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11920, 12309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 11997, 12034);

                                formatType = typeof(WideControlBody);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12056, 12080);

                                formatTypeName = "Wide";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11920, 12309);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 11920, 12309);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12122, 12309) || true) && (formatShape == FormatShape.Complex)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12122, 12309);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12202, 12242);

                                    formatType = typeof(ComplexControlBody);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12264, 12290);

                                    formatTypeName = "Custom";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12122, 12309);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11920, 12309);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11718, 12309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11513, 12309);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12329, 15596) || true) && (formatType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12329, 15596);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12393, 15577);
                            foreach (ViewDefinition currentViewDefinition in f_1095_12442_12486_I(db.viewDefinitionsSection.viewDefinitionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12393, 15577);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12536, 15554) || true) && (currentViewDefinition.mainControl != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12536, 15554);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12639, 15527);
                                        foreach (TypeOrGroupReference currentTypeOrGroupReference in f_1095_12700_12745_I(currentViewDefinition.appliesTo.referenceList))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12639, 15527);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 12811, 15496) || true) && (!f_1095_12816_12870(currentTypeOrGroupReference.name) && (DynAbs.Tracing.TraceSender.Expression_True(1095, 12815, 13017) && f_1095_12911_13017(currentObjectTypeName, currentTypeOrGroupReference.name, StringComparison.OrdinalIgnoreCase)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 12811, 15496);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13091, 15461) || true) && (f_1095_13095_13138(currentViewDefinition.mainControl) == formatType)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13091, 15461);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13234, 13280);

                                                    f_1095_13234_13279(validViews, currentViewDefinition.name);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13322, 13351);

                                                    f_1095_13322_13350(validViews, separator);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13091, 15461);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13091, 15461);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13433, 15461) || true) && (f_1095_13437_13524(viewName, currentViewDefinition.name, StringComparison.OrdinalIgnoreCase))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13433, 15461);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13606, 13637);

                                                        string
                                                        cmdletFormatName = null
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13679, 14715) || true) && (currentViewDefinition.mainControl is TableControlBody)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13679, 14715);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13826, 13860);

                                                            cmdletFormatName = "Format-Table";
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13679, 14715);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13679, 14715);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 13950, 14715) || true) && (currentViewDefinition.mainControl is ListControlBody)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13950, 14715);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14096, 14129);

                                                                cmdletFormatName = "Format-List";
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13950, 14715);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 13950, 14715);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14219, 14715) || true) && (currentViewDefinition.mainControl is WideControlBody)
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 14219, 14715);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14365, 14398);

                                                                    cmdletFormatName = "Format-Wide";
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 14219, 14715);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 14219, 14715);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14488, 14715) || true) && (currentViewDefinition.mainControl is ComplexControlBody)
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 14488, 14715);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14637, 14672);

                                                                        cmdletFormatName = "Format-Custom";
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 14488, 14715);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 14219, 14715);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13950, 14715);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13679, 14715);
                                                        }

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14759, 15336) || true) && (f_1095_14763_14786(validViewFormats) == 0)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 14759, 15336);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 14881, 14987);

                                                            string
                                                            suggestValidViewNamePrefix = f_1095_14917_14986(f_1095_14935_14985())
                                                            ;
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15033, 15085);

                                                            f_1095_15033_15084(validViewFormats, suggestValidViewNamePrefix);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 14759, 15336);
                                                        }

                                                        else

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 14759, 15336);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15263, 15293);

                                                            f_1095_15263_15292(validViewFormats, ", ");
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 14759, 15336);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15380, 15422);

                                                        f_1095_15380_15421(
                                                                                                validViewFormats, cmdletFormatName);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13433, 15461);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 13091, 15461);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12811, 15496);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12639, 15527);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1095, 1, 2889);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1095, 1, 2889);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12536, 15554);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12393, 15577);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1095, 1, 3185);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1095, 1, 3185);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 12329, 15596);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15616, 15962) || true) && (f_1095_15620_15637(validViews) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 15616, 15962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15683, 15757);

                        f_1095_15683_15756(validViews, f_1095_15701_15718(validViews) - f_1095_15721_15737(separator), f_1095_15739_15755(separator));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15779, 15898);

                        msg = f_1095_15785_15897(f_1095_15803_15847(), viewName, formatTypeName, f_1095_15875_15896(validViews));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15920, 15943);

                        foundValidViews = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 15616, 15962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 11032, 15977);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 15993, 17029) || true) && (!foundValidViews)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 15993, 17029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16047, 16113);

                    StringBuilder
                    unKnowViewFormatStringBuilder = f_1095_16093_16112()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16131, 16945) || true) && (f_1095_16135_16158(validViewFormats) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 16131, 16945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16341, 16475);

                        f_1095_16341_16474(                    // unKnowViewFormatStringBuilder.Append(StringUtil.Format(FormatAndOut_format_xxx.UnknownViewNameError, viewName));
                                            unKnowViewFormatStringBuilder, f_1095_16378_16473(f_1095_16396_16446(), viewName, formatTypeName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16497, 16563);

                        f_1095_16497_16562(unKnowViewFormatStringBuilder, f_1095_16534_16561(validViewFormats));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 16131, 16945);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 16131, 16945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16645, 16757);

                        f_1095_16645_16756(unKnowViewFormatStringBuilder, f_1095_16682_16755(f_1095_16700_16744(), viewName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16779, 16926);

                        f_1095_16779_16925(unKnowViewFormatStringBuilder, f_1095_16816_16924(f_1095_16834_16882(), formatTypeName, f_1095_16900_16923(f_1095_16900_16913(so))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 16131, 16945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 16965, 17012);

                    msg = f_1095_16971_17011(unKnowViewFormatStringBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17013, 17014);
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 15993, 17029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17045, 17362);

                ErrorRecord
                errorRecord = f_1095_17071_17361(f_1095_17133_17163(), "FormatViewNotFound", ErrorCategory.ObjectNotFound, viewName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17378, 17427);

                errorRecord.ErrorDetails = f_1095_17405_17426(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17441, 17489);

                f_1095_17441_17488(errorContext, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 10626, 17500);

                System.Text.StringBuilder
                f_1095_10996_11015()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 10996, 11015);
                    return return_v;
                }


                object
                f_1095_11050_11063(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 11050, 11063);
                    return return_v;
                }


                int
                f_1095_11233_11283(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 11233, 11283);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_11348_11367()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 11348, 11367);
                    return return_v;
                }


                object
                f_1095_11417_11430(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 11417, 11430);
                    return return_v;
                }


                System.Type
                f_1095_11417_11440(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 11417, 11440);
                    return return_v;
                }


                string
                f_1095_11417_11451(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 11417, 11451);
                    return return_v;
                }


                bool
                f_1095_12816_12870(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 12816, 12870);
                    return return_v;
                }


                bool
                f_1095_12911_13017(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 12911, 13017);
                    return return_v;
                }


                System.Type
                f_1095_13095_13138(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 13095, 13138);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_13234_13279(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 13234, 13279);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_13322_13350(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 13322, 13350);
                    return return_v;
                }


                bool
                f_1095_13437_13524(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 13437, 13524);
                    return return_v;
                }


                int
                f_1095_14763_14786(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 14763, 14786);
                    return return_v;
                }


                string
                f_1095_14935_14985()
                {
                    var return_v = FormatAndOut_format_xxx.SuggestValidViewNamePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 14935, 14985);
                    return return_v;
                }


                string
                f_1095_14917_14986(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 14917, 14986);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_15033_15084(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15033, 15084);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_15263_15292(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15263, 15292);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_15380_15421(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15380, 15421);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                f_1095_12700_12745_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 12700, 12745);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                f_1095_12442_12486_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 12442, 12486);
                    return return_v;
                }


                int
                f_1095_15620_15637(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 15620, 15637);
                    return return_v;
                }


                int
                f_1095_15701_15718(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 15701, 15718);
                    return return_v;
                }


                int
                f_1095_15721_15737(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 15721, 15737);
                    return return_v;
                }


                int
                f_1095_15739_15755(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 15739, 15755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_15683_15756(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15683, 15756);
                    return return_v;
                }


                string
                f_1095_15803_15847()
                {
                    var return_v = FormatAndOut_format_xxx.InvalidViewNameError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 15803, 15847);
                    return return_v;
                }


                string
                f_1095_15875_15896(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15875, 15896);
                    return return_v;
                }


                string
                f_1095_15785_15897(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 15785, 15897);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_16093_16112()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16093, 16112);
                    return return_v;
                }


                int
                f_1095_16135_16158(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 16135, 16158);
                    return return_v;
                }


                string
                f_1095_16396_16446()
                {
                    var return_v = FormatAndOut_format_xxx.UnknownViewNameErrorSuffix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 16396, 16446);
                    return return_v;
                }


                string
                f_1095_16378_16473(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16378, 16473);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_16341_16474(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16341, 16474);
                    return return_v;
                }


                string
                f_1095_16534_16561(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16534, 16561);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_16497_16562(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16497, 16562);
                    return return_v;
                }


                string
                f_1095_16700_16744()
                {
                    var return_v = FormatAndOut_format_xxx.UnknownViewNameError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 16700, 16744);
                    return return_v;
                }


                string
                f_1095_16682_16755(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16682, 16755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_16645_16756(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16645, 16756);
                    return return_v;
                }


                string
                f_1095_16834_16882()
                {
                    var return_v = FormatAndOut_format_xxx.NonExistingViewNameError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 16834, 16882);
                    return return_v;
                }


                object
                f_1095_16900_16913(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 16900, 16913);
                    return return_v;
                }


                System.Type
                f_1095_16900_16923(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16900, 16923);
                    return return_v;
                }


                string
                f_1095_16816_16924(string
                formatSpec, string
                o1, System.Type
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16816, 16924);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1095_16779_16925(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16779, 16925);
                    return return_v;
                }


                string
                f_1095_16971_17011(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 16971, 17011);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1095_17133_17163()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 17133, 17163);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1095_17071_17361(System.Management.Automation.PipelineStoppedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 17071, 17361);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1095_17405_17426(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 17405, 17426);
                    return return_v;
                }


                int
                f_1095_17441_17488(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 17441, 17488);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 10626, 17500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 10626, 17500);
            }
        }

        internal ViewGenerator ViewGenerator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 17573, 17744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17609, 17689);

                    f_1095_17609_17688(_viewGenerator != null, "this.viewGenerator cannot be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 17707, 17729);

                    return _viewGenerator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 17573, 17744);

                    int
                    f_1095_17609_17688(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 17609, 17688);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 17512, 17755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 17512, 17755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static ViewGenerator SelectViewGeneratorFromViewDefinition(
                                                TerminatingErrorContext errorContext,
                                                PSPropertyExpressionFactory expressionFactory,
                                                TypeInfoDataBase db,
                                                ViewDefinition view,
                                                FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 17767, 19084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18235, 18270);

                ViewGenerator
                viewGenerator = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18284, 18861) || true) && (view.mainControl is TableControlBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18284, 18861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18358, 18399);

                    viewGenerator = f_1095_18374_18398();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18284, 18861);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18284, 18861);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18433, 18861) || true) && (view.mainControl is ListControlBody)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18433, 18861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18506, 18546);

                        viewGenerator = f_1095_18522_18545();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18433, 18861);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18433, 18861);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18580, 18861) || true) && (view.mainControl is WideControlBody)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18580, 18861);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18653, 18693);

                            viewGenerator = f_1095_18669_18692();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18580, 18861);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18580, 18861);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18727, 18861) || true) && (view.mainControl is ComplexControlBody)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 18727, 18861);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18803, 18846);

                                viewGenerator = f_1095_18819_18845();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18727, 18861);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18580, 18861);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18433, 18861);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 18284, 18861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18877, 18944);

                f_1095_18877_18943(viewGenerator != null, "viewGenerator != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 18958, 19038);

                f_1095_18958_19037(viewGenerator, errorContext, expressionFactory, db, view, parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 19052, 19073);

                return viewGenerator;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 17767, 19084);

                Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                f_1095_18374_18398()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18374, 18398);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                f_1095_18522_18545()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18522, 18545);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                f_1095_18669_18692()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18669, 18692);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                f_1095_18819_18845()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18819, 18845);
                    return return_v;
                }


                int
                f_1095_18877_18943(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18877, 18943);
                    return 0;
                }


                int
                f_1095_18958_19037(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                terminatingErrorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                mshExpressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                formatParameters)
                {
                    this_param.Initialize(terminatingErrorContext, mshExpressionFactory, db, view, formatParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 18958, 19037);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 17767, 19084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 17767, 19084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ViewGenerator SelectViewGeneratorFromProperties(FormatShape shape, PSObject so,
                                            TerminatingErrorContext errorContext,
                                            PSPropertyExpressionFactory expressionFactory,
                                            TypeInfoDataBase db,
                                            FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 19096, 21750);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 19593, 20925) || true) && (shape == FormatShape.Undefined && (DynAbs.Tracing.TraceSender.Expression_True(1095, 19597, 19649) && parameters == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 19593, 20925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 19751, 19788);

                    var
                    typeNames = f_1095_19767_19787(so)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 19806, 19882);

                    shape = f_1095_19814_19881(expressionFactory, db, typeNames);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 19902, 20910) || true) && (shape == FormatShape.Undefined)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 19902, 20910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20115, 20200);

                        List<PSPropertyExpression>
                        expressionList = f_1095_20159_20199(so)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20222, 20705) || true) && (f_1095_20226_20246(expressionList) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 20222, 20705);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20460, 20682);
                                foreach (MshResolvedExpressionParameterAssociation mrepa in f_1095_20520_20552_I(f_1095_20520_20552(so)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 20460, 20682);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20610, 20655);

                                    f_1095_20610_20654(expressionList, f_1095_20629_20653(mrepa));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 20460, 20682);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1095, 1, 223);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1095, 1, 223);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 20222, 20705);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20814, 20891);

                        shape = f_1095_20822_20890(db, f_1095_20869_20889(expressionList));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 19902, 20910);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 19593, 20925);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20941, 20976);

                ViewGenerator
                viewGenerator = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 20990, 21527) || true) && (shape == FormatShape.Table)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 20990, 21527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21054, 21095);

                    viewGenerator = f_1095_21070_21094();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 20990, 21527);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 20990, 21527);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21129, 21527) || true) && (shape == FormatShape.List)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 21129, 21527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21192, 21232);

                        viewGenerator = f_1095_21208_21231();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 21129, 21527);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 21129, 21527);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21266, 21527) || true) && (shape == FormatShape.Wide)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 21266, 21527);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21329, 21369);

                            viewGenerator = f_1095_21345_21368();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 21266, 21527);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 21266, 21527);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21403, 21527) || true) && (shape == FormatShape.Complex)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 21403, 21527);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21469, 21512);

                                viewGenerator = f_1095_21485_21511();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 21403, 21527);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 21266, 21527);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 21129, 21527);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 20990, 21527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21543, 21610);

                f_1095_21543_21609(viewGenerator != null, "viewGenerator != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21626, 21704);

                f_1095_21626_21703(
                            viewGenerator, errorContext, expressionFactory, so, db, parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21718, 21739);

                return viewGenerator;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 19096, 21750);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1095_19767_19787(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 19767, 19787);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                f_1095_19814_19881(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = DisplayDataQuery.GetShapeFromType(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 19814, 19881);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1095_20159_20199(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.GetDefaultPropertySet(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 20159, 20199);
                    return return_v;
                }


                int
                f_1095_20226_20246(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 20226, 20246);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1095_20520_20552(System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandAll(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 20520, 20552);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1095_20629_20653(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 20629, 20653);
                    return return_v;
                }


                int
                f_1095_20610_20654(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 20610, 20654);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1095_20520_20552_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 20520, 20552);
                    return return_v;
                }


                int
                f_1095_20869_20889(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 20869, 20889);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                f_1095_20822_20890(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, int
                propertyCount)
                {
                    var return_v = DisplayDataQuery.GetShapeFromPropertyCount(db, propertyCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 20822, 20890);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                f_1095_21070_21094()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21070, 21094);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                f_1095_21208_21231()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21208, 21231);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                f_1095_21345_21368()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21345, 21368);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                f_1095_21485_21511()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21485, 21511);
                    return return_v;
                }


                int
                f_1095_21543_21609(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21543, 21609);
                    return 0;
                }


                int
                f_1095_21626_21703(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                terminatingErrorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                mshExpressionFactory, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                formatParameters)
                {
                    this_param.Initialize(terminatingErrorContext, mshExpressionFactory, so, db, formatParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 21626, 21703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 19096, 21750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 19096, 21750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ViewGenerator _viewGenerator;

        public FormatViewManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1095, 2766, 21933);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 21904, 21925);
            this._viewGenerator = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1095, 2766, 21933);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 2766, 21933);
        }


        static FormatViewManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1095, 2766, 21933);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 2942, 3044);
            s_formatViewBindingTracer = f_1095_2970_3044("FormatViewBinding", "Format view binding", false);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1095, 2766, 21933);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 2766, 21933);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1095, 2766, 21933);

        static System.Management.Automation.PSTraceSource
        f_1095_2970_3044(string
        name, string
        description, bool
        traceHeaders)
        {
            var return_v = PSTraceSource.GetTracer(name, description, traceHeaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 2970, 3044);
            return return_v;
        }

    }
    internal static class OutOfBandFormatViewManager
    {
        private static bool IsNotRemotingProperty(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 22141, 22739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 22220, 22683);

                var
                isRemotingPropertyName = f_1095_22249_22340(name, RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1095, 22249, 22459) || f_1095_22364_22459(name, RemotingConstants.ShowComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1095, 22249, 22572) || f_1095_22483_22572(name, RemotingConstants.RunspaceIdNoteProperty, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1095, 22249, 22682) || f_1095_22596_22682(name, RemotingConstants.SourceJobInstanceId, StringComparison.OrdinalIgnoreCase))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 22697, 22728);

                return !isRemotingPropertyName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 22141, 22739);

                bool
                f_1095_22249_22340(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 22249, 22340);
                    return return_v;
                }


                bool
                f_1095_22364_22459(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 22364, 22459);
                    return return_v;
                }


                bool
                f_1095_22483_22572(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 22483, 22572);
                    return return_v;
                }


                bool
                f_1095_22596_22682(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 22596, 22682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 22141, 22739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 22141, 22739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly MemberNamePredicate NameIsNotRemotingProperty;

        internal static bool HasNonRemotingProperties(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 22916, 22982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 22919, 22982);
                return f_1095_22919_22974(so, NameIsNotRemotingProperty) != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 22916, 22982);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 22916, 22982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 22916, 22982);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSPropertyInfo
            f_1095_22919_22974(System.Management.Automation.PSObject
            this_param, System.Management.Automation.MemberNamePredicate
            predicate)
            {
                var return_v = this_param.GetFirstPropertyOrDefault(predicate);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 22919, 22974);
                return return_v;
            }

        }

        internal static FormatEntryData GenerateOutOfBandData(TerminatingErrorContext errorContext, PSPropertyExpressionFactory expressionFactory,
                            TypeInfoDataBase db, PSObject so, int enumerationLimit, bool useToStringFallback, out List<ErrorRecord> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 22995, 25352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23291, 23305);

                errors = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23321, 23358);

                var
                typeNames = f_1095_23337_23357(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23372, 23462);

                ViewDefinition
                view = f_1095_23394_23461(expressionFactory, db, typeNames)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23478, 23515);

                ViewGenerator
                outOfBandViewGenerator
                = default(ViewGenerator);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23529, 25048) || true) && (view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 23529, 25048);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23663, 23949) || true) && (view.mainControl is ComplexControlBody)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 23663, 23949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23747, 23799);

                        outOfBandViewGenerator = f_1095_23772_23798();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 23663, 23949);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 23663, 23949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23881, 23930);

                        outOfBandViewGenerator = f_1095_23906_23929();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 23663, 23949);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 23969, 24052);

                    f_1095_23969_24051(
                                    outOfBandViewGenerator, errorContext, expressionFactory, db, view, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 23529, 25048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 23529, 25048);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24118, 24390) || true) && (f_1095_24122_24164(typeNames) || (DynAbs.Tracing.TraceSender.Expression_False(1095, 24122, 24218) || !f_1095_24190_24218(so)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 24118, 24390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24326, 24371);

                        return f_1095_24333_24370(so);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 24118, 24390);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24410, 24507) || true) && (!useToStringFallback)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 24410, 24507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24476, 24488);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 24410, 24507);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24603, 24737) || true) && (f_1095_24607_24659(f_1095_24607_24653(f_1095_24607_24636("*"), so)) <= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 24603, 24737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24706, 24718);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 24603, 24737);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24885, 24934);

                    outOfBandViewGenerator = f_1095_24910_24933();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 24952, 25033);

                    f_1095_24952_25032(outOfBandViewGenerator, errorContext, expressionFactory, so, db, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 23529, 25048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25064, 25147);

                FormatEntryData
                fed = f_1095_25086_25146(outOfBandViewGenerator, so, enumerationLimit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25161, 25182);

                fed.outOfBand = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25196, 25229);

                fed.writeStream = f_1095_25214_25228(so);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25245, 25314);

                errors = f_1095_25254_25313(f_1095_25254_25289(outOfBandViewGenerator));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25330, 25341);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 22995, 25352);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1095_23337_23357(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 23337, 23357);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1095_23394_23461(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = DisplayDataQuery.GetOutOfBandView(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 23394, 23461);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                f_1095_23772_23798()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 23772, 23798);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                f_1095_23906_23929()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 23906, 23929);
                    return return_v;
                }


                int
                f_1095_23969_24051(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                terminatingErrorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                mshExpressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                formatParameters)
                {
                    this_param.Initialize(terminatingErrorContext, mshExpressionFactory, db, view, formatParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 23969, 24051);
                    return 0;
                }


                bool
                f_1095_24122_24164(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = DefaultScalarTypes.IsTypeInList((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24122, 24164);
                    return return_v;
                }


                bool
                f_1095_24190_24218(System.Management.Automation.PSObject
                so)
                {
                    var return_v = HasNonRemotingProperties(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24190, 24218);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1095_24333_24370(System.Management.Automation.PSObject
                so)
                {
                    var return_v = GenerateOutOfBandObjectAsToString(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24333, 24370);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1095_24607_24636(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24607, 24636);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1095_24607_24653(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.ResolveNames(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24607, 24653);
                    return return_v;
                }


                int
                f_1095_24607_24659(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 24607, 24659);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                f_1095_24910_24933()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24910, 24933);
                    return return_v;
                }


                int
                f_1095_24952_25032(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                terminatingErrorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                mshExpressionFactory, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                formatParameters)
                {
                    this_param.Initialize(terminatingErrorContext, mshExpressionFactory, so, db, formatParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 24952, 25032);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1095_25086_25146(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GeneratePayload(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 25086, 25146);
                    return return_v;
                }


                System.Management.Automation.WriteStreamType
                f_1095_25214_25228(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 25214, 25228);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1095_25254_25289(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    var return_v = this_param.ErrorManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 25254, 25289);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                f_1095_25254_25313(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DrainFailedResultList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 25254, 25313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 22995, 25352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 22995, 25352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FormatEntryData GenerateOutOfBandObjectAsToString(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 25364, 25756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25467, 25511);

                FormatEntryData
                fed = f_1095_25489_25510()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25525, 25546);

                fed.outOfBand = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25562, 25621);

                RawTextFormatEntry
                rawTextEntry = f_1095_25596_25620()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25635, 25669);

                rawTextEntry.text = f_1095_25655_25668(so);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25683, 25718);

                fed.formatEntryInfo = rawTextEntry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 25734, 25745);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 25364, 25756);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1095_25489_25510()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 25489, 25510);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.RawTextFormatEntry
                f_1095_25596_25620()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.RawTextFormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 25596, 25620);
                    return return_v;
                }


                string
                f_1095_25655_25668(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 25655, 25668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 25364, 25756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 25364, 25756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OutOfBandFormatViewManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1095, 22076, 25763);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 22795, 22844);
            NameIsNotRemotingProperty = IsNotRemotingProperty;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1095, 22076, 25763);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 22076, 25763);
        }

    }
    internal sealed class FormatErrorManager
    {
        internal FormatErrorManager(FormatErrorPolicy formatErrorPolicy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1095, 26204, 26343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30875, 30893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 31053, 31103);
                this._formattingErrorList = f_1095_31076_31103();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 26293, 26332);

                _formatErrorPolicy = formatErrorPolicy;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1095, 26204, 26343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 26204, 26343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 26204, 26343);
            }
        }

        internal void LogPSPropertyExpressionFailedResult(PSPropertyExpressionResult result, object sourceObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 26673, 27094);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 26803, 26873) || true) && (f_1095_26807_26847_M(!_formatErrorPolicy.ShowErrorsAsMessages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 26803, 26873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 26866, 26873);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 26803, 26873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 26887, 26953);

                PSPropertyExpressionError
                error = f_1095_26921_26952()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 26967, 26989);

                error.result = result;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27003, 27037);

                error.sourceObject = sourceObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27051, 27083);

                f_1095_27051_27082(_formattingErrorList, error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 26673, 27094);

                bool
                f_1095_26807_26847_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 26807, 26847);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionError
                f_1095_26921_26952()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 26921, 26952);
                    return return_v;
                }


                int
                f_1095_27051_27082(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionError
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormattingError)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 27051, 27082);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 26673, 27094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 26673, 27094);
            }
        }

        internal void LogStringFormatError(StringFormatError error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 27270, 27481);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27354, 27424) || true) && (f_1095_27358_27398_M(!_formatErrorPolicy.ShowErrorsAsMessages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 27354, 27424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27417, 27424);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 27354, 27424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27438, 27470);

                f_1095_27438_27469(_formattingErrorList, error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 27270, 27481);

                bool
                f_1095_27358_27398_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 27358, 27398);
                    return return_v;
                }


                int
                f_1095_27438_27469(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormattingError)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 27438, 27469);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 27270, 27481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 27270, 27481);
            }
        }

        internal bool DisplayErrorStrings
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 27551, 27613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27557, 27611);

                    return f_1095_27564_27610(_formatErrorPolicy);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 27551, 27613);

                    bool
                    f_1095_27564_27610(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
                    this_param)
                    {
                        var return_v = this_param.ShowErrorsInFormattedOutput;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 27564, 27610);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 27493, 27624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 27493, 27624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool DisplayFormatErrorString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 27699, 27833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27786, 27818);

                    return f_1095_27793_27817(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 27699, 27833);

                    bool
                    f_1095_27793_27817(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                    this_param)
                    {
                        var return_v = this_param.DisplayErrorStrings;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 27793, 27817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 27636, 27844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 27636, 27844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string ErrorString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 27908, 27971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 27914, 27969);

                    return _formatErrorPolicy.errorStringInFormattedOutput;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 27908, 27971);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 27856, 27982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 27856, 27982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string FormatErrorString
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 28052, 28121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28058, 28119);

                    return _formatErrorPolicy.formatErrorStringInFormattedOutput;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 28052, 28121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 27994, 28132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 27994, 28132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal List<ErrorRecord> DrainFailedResultList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1095, 28403, 28962);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28478, 28553) || true) && (f_1095_28482_28522_M(!_formatErrorPolicy.ShowErrorsAsMessages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 28478, 28553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28541, 28553);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 28478, 28553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28569, 28620);

                List<ErrorRecord>
                retVal = f_1095_28596_28619()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28634, 28878);
                    foreach (FormattingError error in f_1095_28668_28688_I(_formattingErrorList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 28634, 28878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28722, 28775);

                        ErrorRecord
                        errorRecord = f_1095_28748_28774(error)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28793, 28863) || true) && (errorRecord != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 28793, 28863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28839, 28863);

                            f_1095_28839_28862(retVal, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 28793, 28863);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 28634, 28878);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1095, 1, 245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1095, 1, 245);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28894, 28923);

                f_1095_28894_28922(
                            _formattingErrorList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 28937, 28951);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1095, 28403, 28962);

                bool
                f_1095_28482_28522_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 28482, 28522);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                f_1095_28596_28619()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ErrorRecord>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 28596, 28619);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1095_28748_28774(Microsoft.PowerShell.Commands.Internal.Format.FormattingError
                error)
                {
                    var return_v = GenerateErrorRecord(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 28748, 28774);
                    return return_v;
                }


                int
                f_1095_28839_28862(System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                this_param, System.Management.Automation.ErrorRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 28839, 28862);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
                f_1095_28668_28688_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 28668, 28688);
                    return return_v;
                }


                int
                f_1095_28894_28922(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 28894, 28922);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 28403, 28962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 28403, 28962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorRecord GenerateErrorRecord(FormattingError error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1095, 29235, 30837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29329, 29360);

                ErrorRecord
                errorRecord = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29374, 29392);

                string
                msg = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29406, 29495);

                PSPropertyExpressionError
                psPropertyExpressionError = error as PSPropertyExpressionError
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29509, 30149) || true) && (psPropertyExpressionError != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 29509, 30149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29580, 29887);

                    errorRecord = f_1095_29594_29886(f_1095_29644_29686(psPropertyExpressionError.result), "PSPropertyExpressionError", ErrorCategory.InvalidArgument, psPropertyExpressionError.sourceObject);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 29907, 30067);

                    msg = f_1095_29913_30066(f_1095_29931_29980(), f_1095_30003_30065(f_1095_30003_30054(psPropertyExpressionError.result)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30085, 30134);

                    errorRecord.ErrorDetails = f_1095_30112_30133(msg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 29509, 30149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30165, 30228);

                StringFormatError
                formattingError = error as StringFormatError
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30242, 30791) || true) && (formattingError != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1095, 30242, 30791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30303, 30573);

                    errorRecord = f_1095_30317_30572(formattingError.exception, "formattingError", ErrorCategory.InvalidArgument, formattingError.sourceObject);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30593, 30709);

                    msg = f_1095_30599_30708(f_1095_30617_30656(), formattingError.formatString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30727, 30776);

                    errorRecord.ErrorDetails = f_1095_30754_30775(msg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1095, 30242, 30791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1095, 30807, 30826);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1095, 29235, 30837);

                System.Exception
                f_1095_29644_29686(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 29644, 29686);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1095_29594_29886(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 29594, 29886);
                    return return_v;
                }


                string
                f_1095_29931_29980()
                {
                    var return_v = FormatAndOut_format_xxx.PSPropertyExpressionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 29931, 29980);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1095_30003_30054(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 30003, 30054);
                    return return_v;
                }


                string
                f_1095_30003_30065(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 30003, 30065);
                    return return_v;
                }


                string
                f_1095_29913_30066(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 29913, 30066);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1095_30112_30133(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 30112, 30133);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1095_30317_30572(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 30317, 30572);
                    return return_v;
                }


                string
                f_1095_30617_30656()
                {
                    var return_v = FormatAndOut_format_xxx.FormattingError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1095, 30617, 30656);
                    return return_v;
                }


                string
                f_1095_30599_30708(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 30599, 30708);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1095_30754_30775(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 30754, 30775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1095, 29235, 30837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 29235, 30837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FormatErrorPolicy _formatErrorPolicy;

        private List<FormattingError> _formattingErrorList;

        static FormatErrorManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1095, 26147, 31111);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1095, 26147, 31111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1095, 26147, 31111);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1095, 26147, 31111);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>
        f_1095_31076_31103()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormattingError>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1095, 31076, 31103);
            return return_v;
        }

    }
}

