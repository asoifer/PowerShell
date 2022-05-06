// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands
{
    internal static class EnumerableExpansionConversion
    {
        internal const string
        CoreOnlyString = "CoreOnly"
        ;

        internal const string
        EnumOnlyString = "EnumOnly"
        ;

        internal const string
        BothString = "Both"
        ;

        internal static bool Convert(string expansionString, out EnumerableExpansion expansion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1117, 463, 1312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 575, 616);

                expansion = EnumerableExpansion.EnumOnly;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 630, 836) || true) && (f_1117_634_716(expansionString, CoreOnlyString, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1117, 630, 836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 750, 791);

                    expansion = EnumerableExpansion.CoreOnly;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 809, 821);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1117, 630, 836);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 852, 1058) || true) && (f_1117_856_938(expansionString, EnumOnlyString, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1117, 852, 1058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 972, 1013);

                    expansion = EnumerableExpansion.EnumOnly;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 1031, 1043);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1117, 852, 1058);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 1074, 1272) || true) && (f_1117_1078_1156(expansionString, BothString, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1117, 1074, 1272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 1190, 1227);

                    expansion = EnumerableExpansion.Both;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 1245, 1257);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1117, 1074, 1272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 1288, 1301);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1117, 463, 1312);

                bool
                f_1117_634_716(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1117, 634, 716);
                    return return_v;
                }


                bool
                f_1117_856_938(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1117, 856, 938);
                    return return_v;
                }


                bool
                f_1117_1078_1156(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1117, 1078, 1156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1117, 463, 1312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1117, 463, 1312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumerableExpansionConversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1117, 221, 1319);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 311, 338);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 371, 398);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1117, 431, 450);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1117, 221, 1319);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1117, 221, 1319);
        }

    }
}

