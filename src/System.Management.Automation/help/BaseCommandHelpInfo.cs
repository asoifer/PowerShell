// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal abstract class BaseCommandHelpInfo : HelpInfo
    {
        internal BaseCommandHelpInfo(HelpCategory helpCategory)
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1142, 592, 733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4032, 4084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 694, 722);

                HelpCategory = helpCategory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1142, 592, 733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 592, 733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 592, 733);
            }
        }

        internal PSObject Details
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 836, 1251);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 872, 932) || true) && (f_1142_876_889(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 872, 932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 920, 932);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 872, 932);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 952, 1146) || true) && (f_1142_956_991(f_1142_956_980(f_1142_956_969(this)), "Details") == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 956, 1073) || f_1142_1024_1065(f_1142_1024_1059(f_1142_1024_1048(f_1142_1024_1037(this)), "Details")) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 952, 1146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1115, 1127);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 952, 1146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1166, 1236);

                    return f_1142_1173_1235(f_1142_1193_1234(f_1142_1193_1228(f_1142_1193_1217(f_1142_1193_1206(this)), "Details")));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 836, 1251);

                    System.Management.Automation.PSObject
                    f_1142_876_889(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 876, 889);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_956_969(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 956, 969);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_956_980(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 956, 980);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_956_991(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 956, 991);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_1024_1037(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1024, 1037);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_1024_1048(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1024, 1048);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_1024_1059(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1024, 1059);
                        return return_v;
                    }


                    object
                    f_1142_1024_1065(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1024, 1065);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_1193_1206(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1193, 1206);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_1193_1217(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1193, 1217);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_1193_1228(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1193, 1228);
                        return return_v;
                    }


                    object
                    f_1142_1193_1234(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1193, 1234);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_1173_1235(object
                    obj)
                    {
                        var return_v = PSObject.AsPSObject(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 1173, 1235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 786, 1262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 786, 1262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 1449, 2083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1485, 1524);

                    PSObject
                    commandDetails = f_1142_1511_1523(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1542, 1649) || true) && (commandDetails == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 1542, 1649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1610, 1630);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 1542, 1649);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1669, 1867) || true) && (f_1142_1673_1706(f_1142_1673_1698(commandDetails), "Name") == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 1673, 1786) || f_1142_1739_1778(f_1142_1739_1772(f_1142_1739_1764(commandDetails), "Name")) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 1669, 1867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1828, 1848);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 1669, 1867);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1887, 1952);

                    string
                    name = f_1142_1901_1951(f_1142_1901_1940(f_1142_1901_1934(f_1142_1901_1926(commandDetails), "Name")))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 1970, 2029) || true) && (name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 1970, 2029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2009, 2029);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 1970, 2029);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2049, 2068);

                    return f_1142_2056_2067(name);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 1449, 2083);

                    System.Management.Automation.PSObject
                    f_1142_1511_1523(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.Details;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1511, 1523);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_1673_1698(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1673, 1698);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_1673_1706(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1673, 1706);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_1739_1764(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1739, 1764);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_1739_1772(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1739, 1772);
                        return return_v;
                    }


                    object
                    f_1142_1739_1778(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1739, 1778);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_1901_1926(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1901, 1926);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_1901_1934(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1901, 1934);
                        return return_v;
                    }


                    object
                    f_1142_1901_1940(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 1901, 1940);
                        return return_v;
                    }


                    string?
                    f_1142_1901_1951(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 1901, 1951);
                        return return_v;
                    }


                    string
                    f_1142_2056_2067(string
                    this_param)
                    {
                        var return_v = this_param.Trim();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 2056, 2067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 1395, 2094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 1395, 2094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string Synopsis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 2315, 3806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2351, 2390);

                    PSObject
                    commandDetails = f_1142_2377_2389(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2408, 2515) || true) && (commandDetails == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 2408, 2515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2476, 2496);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 2408, 2515);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2535, 2747) || true) && (f_1142_2539_2579(f_1142_2539_2564(commandDetails), "Description") == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 2539, 2666) || f_1142_2612_2658(f_1142_2612_2652(f_1142_2612_2637(commandDetails), "Description")) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 2535, 2747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2708, 2728);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 2535, 2747);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 2767, 2991);

                    object[]
                    synopsisItems = (object[])f_1142_2802_2990(f_1142_2853_2899(f_1142_2853_2893(f_1142_2853_2878(commandDetails), "Description")), typeof(object[]), f_1142_2961_2989())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3009, 3144) || true) && (synopsisItems == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 3013, 3063) || f_1142_3038_3058(synopsisItems) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 3009, 3144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3105, 3125);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 3009, 3144);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3164, 3265);

                    PSObject
                    firstSynopsisItem = (DynAbs.Tracing.TraceSender.Conditional_F1(1142, 3193, 3217) || ((synopsisItems[0] == null && DynAbs.Tracing.TraceSender.Conditional_F2(1142, 3220, 3224)) || DynAbs.Tracing.TraceSender.Conditional_F3(1142, 3227, 3264))) ? null : f_1142_3227_3264(synopsisItems[0])
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3283, 3537) || true) && (firstSynopsisItem == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 3287, 3381) || f_1142_3337_3373(f_1142_3337_3365(firstSynopsisItem), "Text") == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 3287, 3456) || f_1142_3406_3448(f_1142_3406_3442(f_1142_3406_3434(firstSynopsisItem), "Text")) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 3283, 3537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3498, 3518);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 3283, 3537);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3557, 3629);

                    string
                    synopsis = f_1142_3575_3628(f_1142_3575_3617(f_1142_3575_3611(f_1142_3575_3603(firstSynopsisItem), "Text")))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3647, 3748) || true) && (synopsis == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 3647, 3748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3709, 3729);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 3647, 3748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 3768, 3791);

                    return f_1142_3775_3790(synopsis);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 2315, 3806);

                    System.Management.Automation.PSObject
                    f_1142_2377_2389(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.Details;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2377, 2389);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_2539_2564(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2539, 2564);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_2539_2579(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2539, 2579);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_2612_2637(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2612, 2637);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_2612_2652(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2612, 2652);
                        return return_v;
                    }


                    object
                    f_1142_2612_2658(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2612, 2658);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_2853_2878(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2853, 2878);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_2853_2893(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2853, 2893);
                        return return_v;
                    }


                    object
                    f_1142_2853_2899(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2853, 2899);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1142_2961_2989()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 2961, 2989);
                        return return_v;
                    }


                    object
                    f_1142_2802_2990(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 2802, 2990);
                        return return_v;
                    }


                    int
                    f_1142_3038_3058(object[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3038, 3058);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_3227_3264(object
                    obj)
                    {
                        var return_v = PSObject.AsPSObject(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 3227, 3264);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_3337_3365(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3337, 3365);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_3337_3373(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3337, 3373);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_3406_3434(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3406, 3434);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_3406_3442(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3406, 3442);
                        return return_v;
                    }


                    object
                    f_1142_3406_3448(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3406, 3448);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_3575_3603(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3575, 3603);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_3575_3611(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3575, 3611);
                        return return_v;
                    }


                    object
                    f_1142_3575_3617(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 3575, 3617);
                        return return_v;
                    }


                    string?
                    f_1142_3575_3628(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 3575, 3628);
                        return return_v;
                    }


                    string
                    f_1142_3775_3790(string
                    this_param)
                    {
                        var return_v = this_param.Trim();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 3775, 3790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 2257, 3817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 2257, 3817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override HelpCategory HelpCategory { get; }

        internal override Uri GetUriForOnlineHelp()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 4554, 5444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4622, 4640);

                Uri
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4654, 4699);

                UriFormatException
                uriFormatException = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4751, 4801);

                    result = f_1142_4760_4800(f_1142_4786_4799(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4819, 4912) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 4819, 4912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 4879, 4893);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 4819, 4912);
                    }
                }
                catch (UriFormatException urie)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1142, 4941, 5046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5005, 5031);

                    uriFormatException = urie;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1142, 4941, 5046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5124, 5165);

                result = f_1142_5133_5164(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5179, 5383) || true) && (result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5179, 5383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5231, 5245);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5179, 5383);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5179, 5383);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5279, 5383) || true) && (uriFormatException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5279, 5383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5343, 5368);

                        throw uriFormatException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5279, 5383);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5179, 5383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5399, 5433);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUriForOnlineHelp(), 1142, 5406, 5432);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 4554, 5444);

                System.Management.Automation.PSObject
                f_1142_4786_4799(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 4786, 4799);
                    return return_v;
                }


                System.Uri
                f_1142_4760_4800(System.Management.Automation.PSObject
                commandFullHelp)
                {
                    var return_v = GetUriFromCommandPSObject(commandFullHelp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 4760, 4800);
                    return return_v;
                }


                System.Uri
                f_1142_5133_5164(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.LookupUriFromCommandInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 5133, 5164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 4554, 5444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 4554, 5444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Uri LookupUriFromCommandInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 5456, 9842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5520, 5573);

                CommandTypes
                cmdTypesToLookFor = CommandTypes.Cmdlet
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5587, 6620);

                switch (f_1142_5595_5612(this))
                {

                    case Automation.HelpCategory.Cmdlet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5704, 5744);

                        cmdTypesToLookFor = CommandTypes.Cmdlet;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 5766, 5772);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    case Automation.HelpCategory.Function:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 5852, 5894);

                        cmdTypesToLookFor = CommandTypes.Function;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 5916, 5922);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    case Automation.HelpCategory.ScriptCommand:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6007, 6047);

                        cmdTypesToLookFor = CommandTypes.Script;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 6069, 6075);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    case Automation.HelpCategory.ExternalScript:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6161, 6209);

                        cmdTypesToLookFor = CommandTypes.ExternalScript;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 6231, 6237);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    case Automation.HelpCategory.Filter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6315, 6355);

                        cmdTypesToLookFor = CommandTypes.Filter;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 6377, 6383);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    case Automation.HelpCategory.Configuration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6468, 6515);

                        cmdTypesToLookFor = CommandTypes.Configuration;
                        DynAbs.Tracing.TraceSender.TraceBreak(1142, 6537, 6543);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 5587, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6593, 6605);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 5587, 6620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6636, 6667);

                string
                commandName = f_1142_6657_6666(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6681, 6714);

                string
                moduleName = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6728, 7184) || true) && (f_1142_6732_6770(f_1142_6732_6756(f_1142_6732_6745(this)), "ModuleName") != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 6728, 7184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6812, 6899);

                    PSNoteProperty
                    moduleNameNP = f_1142_6842_6880(f_1142_6842_6866(f_1142_6842_6855(this)), "ModuleName") as PSNoteProperty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6917, 7169) || true) && (moduleNameNP != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 6917, 7169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 6983, 7150);

                        f_1142_6983_7149(f_1142_7023_7041(moduleNameNP), f_1142_7043_7071(), out moduleName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 6917, 7169);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 6728, 7184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7200, 7237);

                string
                commandToSearch = commandName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7251, 7457) || true) && (!f_1142_7256_7288(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 7251, 7457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7322, 7442);

                    commandToSearch = f_1142_7340_7441(f_1142_7354_7382(), "{0}\\{1}", moduleName, commandName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 7251, 7457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7473, 7543);

                ExecutionContext
                context = f_1142_7500_7542()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7557, 7637) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 7557, 7637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7610, 7622);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 7557, 7637);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7689, 7716);

                    CommandInfo
                    cmdInfo = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7736, 8112) || true) && (cmdTypesToLookFor == CommandTypes.Cmdlet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 7736, 8112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7822, 7894);

                        cmdInfo = f_1142_7832_7893(f_1142_7832_7866(f_1142_7832_7852(context)), commandToSearch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 7736, 8112);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 7736, 8112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 7976, 8093);

                        cmdInfo = f_1142_7986_8092(f_1142_7986_8075(f_1142_7986_8020(f_1142_7986_8006(context)), commandToSearch, cmdTypesToLookFor, false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 7736, 8112);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 8132, 8263) || true) && ((cmdInfo == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 8136, 8190) || (f_1142_8158_8181(cmdInfo) == null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 8132, 8263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 8232, 8244);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 8132, 8263);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 8283, 8334);

                    string
                    uriString = f_1142_8302_8333(f_1142_8302_8325(cmdInfo))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 8352, 9712) || true) && (!f_1142_8357_8388(uriString))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 8352, 9712);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 8430, 9188) || true) && (!f_1142_8435_8506(uriString, UriKind.RelativeOrAbsolute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 8430, 9188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 9037, 9106);

                            string[]
                            tempUriSplitArray = f_1142_9066_9105(uriString, Utils.Separators.Space)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 9132, 9165);

                            uriString = tempUriSplitArray[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 8430, 9188);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 9264, 9297);

                            return f_1142_9271_9296(uriString);
                            // return only the first Uri (ignore other uris)
                        }
                        catch (UriFormatException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1142, 9416, 9693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 9491, 9670);

                            throw f_1142_9497_9669(f_1142_9540_9561(), f_1142_9637_9668(f_1142_9637_9660(cmdInfo)));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1142, 9416, 9693);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 8352, 9712);
                    }
                }
                catch (CommandNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1142, 9741, 9803);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1142, 9741, 9803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 9819, 9831);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 5456, 9842);

                System.Management.Automation.HelpCategory
                f_1142_5595_5612(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.HelpCategory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 5595, 5612);
                    return return_v;
                }


                string
                f_1142_6657_6666(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6657, 6666);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_6732_6745(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6732, 6745);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_6732_6756(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6732, 6756);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_6732_6770(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6732, 6770);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_6842_6855(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6842, 6855);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_6842_6866(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6842, 6866);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_6842_6880(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 6842, 6880);
                    return return_v;
                }


                object
                f_1142_7023_7041(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7023, 7041);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1142_7043_7071()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7043, 7071);
                    return return_v;
                }


                bool
                f_1142_6983_7149(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<string>(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 6983, 7149);
                    return return_v;
                }


                bool
                f_1142_7256_7288(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7256, 7288);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1142_7354_7382()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7354, 7382);
                    return return_v;
                }


                string
                f_1142_7340_7441(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7340, 7441);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1142_7500_7542()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7500, 7542);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1142_7832_7852(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7832, 7852);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1142_7832_7866(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7832, 7866);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1142_7832_7893(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetCmdlet(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7832, 7893);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1142_7986_8006(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7986, 8006);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1142_7986_8020(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 7986, 8020);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1142_7986_8075(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                name, System.Management.Automation.CommandTypes
                commandTypes, bool
                nameIsPattern)
                {
                    var return_v = this_param.GetCommands(name, commandTypes, nameIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7986, 8075);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1142_7986_8092(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 7986, 8092);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1142_8158_8181(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 8158, 8181);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1142_8302_8325(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 8302, 8325);
                    return return_v;
                }


                string
                f_1142_8302_8333(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 8302, 8333);
                    return return_v;
                }


                bool
                f_1142_8357_8388(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 8357, 8388);
                    return return_v;
                }


                bool
                f_1142_8435_8506(string
                uriString, System.UriKind
                uriKind)
                {
                    var return_v = System.Uri.IsWellFormedUriString(uriString, uriKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 8435, 8506);
                    return return_v;
                }


                string[]
                f_1142_9066_9105(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 9066, 9105);
                    return return_v;
                }


                System.Uri
                f_1142_9271_9296(string
                uriString)
                {
                    var return_v = new System.Uri(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 9271, 9296);
                    return return_v;
                }


                string
                f_1142_9540_9561()
                {
                    var return_v = HelpErrors.InvalidURI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 9540, 9561);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1142_9637_9660(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 9637, 9660);
                    return return_v;
                }


                string
                f_1142_9637_9668(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 9637, 9668);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1142_9497_9669(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 9497, 9669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 5456, 9842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 5456, 9842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Uri GetUriFromCommandPSObject(PSObject commandFullHelp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1142, 9854, 12878);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10063, 10346) || true) && ((commandFullHelp == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 10067, 10165) || (f_1142_10114_10156(f_1142_10114_10140(commandFullHelp), "relatedLinks") == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 10067, 10244) || (f_1142_10187_10235(f_1142_10187_10229(f_1142_10187_10213(commandFullHelp), "relatedLinks")) == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 10063, 10346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10319, 10331);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 10063, 10346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10362, 10456);

                PSObject
                relatedLinks = f_1142_10386_10455(f_1142_10406_10454(f_1142_10406_10448(f_1142_10406_10432(commandFullHelp), "relatedLinks")))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10470, 10584) || true) && (f_1142_10474_10515(f_1142_10474_10497(relatedLinks), "navigationLink") == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 10470, 10584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10557, 10569);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 10470, 10584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10600, 10815);

                object[]
                navigationLinks = (object[])f_1142_10637_10814(f_1142_10684_10731(f_1142_10684_10725(f_1142_10684_10707(relatedLinks), "navigationLink")), typeof(object[]), f_1142_10785_10813())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10829, 12839);
                    foreach (object navigationLinkAsObject in f_1142_10871_10886_I(navigationLinks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 10829, 12839);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10920, 11024) || true) && (navigationLinkAsObject == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 10920, 11024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 10996, 11005);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 10920, 11024);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11044, 11114);

                        PSObject
                        navigationLink = f_1142_11070_11113(navigationLinkAsObject)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11132, 11206);

                        PSNoteProperty
                        uriNP = f_1142_11155_11187(f_1142_11155_11180(navigationLink), "uri") as PSNoteProperty
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11224, 12824) || true) && (uriNP != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 11224, 12824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11283, 11315);

                            string
                            uriString = string.Empty
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11337, 11435);

                            f_1142_11337_11434(f_1142_11377_11388(uriNP), f_1142_11390_11418(), out uriString);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11457, 12805) || true) && (!f_1142_11462_11493(uriString))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 11457, 12805);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 11543, 12337) || true) && (!f_1142_11548_11619(uriString, UriKind.RelativeOrAbsolute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 11543, 12337);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 12178, 12247);

                                    string[]
                                    tempUriSplitArray = f_1142_12207_12246(uriString, Utils.Separators.Space)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 12277, 12310);

                                    uriString = tempUriSplitArray[0];
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 11543, 12337);
                                }

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 12425, 12458);

                                    return f_1142_12432_12457(uriString);
                                    // return only the first Uri (ignore other uris)
                                }
                                catch (UriFormatException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1142, 12589, 12782);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 12672, 12755);

                                    throw f_1142_12678_12754(f_1142_12721_12742(), uriString);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1142, 12589, 12782);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 11457, 12805);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 11224, 12824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 10829, 12839);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1142, 1, 2011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1142, 1, 2011);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 12855, 12867);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1142, 9854, 12878);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_10114_10140(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10114, 10140);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_10114_10156(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10114, 10156);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_10187_10213(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10187, 10213);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_10187_10229(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10187, 10229);
                    return return_v;
                }


                object
                f_1142_10187_10235(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10187, 10235);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_10406_10432(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10406, 10432);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_10406_10448(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10406, 10448);
                    return return_v;
                }


                object
                f_1142_10406_10454(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10406, 10454);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_10386_10455(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 10386, 10455);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_10474_10497(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10474, 10497);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_10474_10515(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10474, 10515);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_10684_10707(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10684, 10707);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_10684_10725(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10684, 10725);
                    return return_v;
                }


                object
                f_1142_10684_10731(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10684, 10731);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1142_10785_10813()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 10785, 10813);
                    return return_v;
                }


                object
                f_1142_10637_10814(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 10637, 10814);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_11070_11113(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 11070, 11113);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_11155_11180(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 11155, 11180);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_11155_11187(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 11155, 11187);
                    return return_v;
                }


                object
                f_1142_11377_11388(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 11377, 11388);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1142_11390_11418()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 11390, 11418);
                    return return_v;
                }


                bool
                f_1142_11337_11434(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<string>(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 11337, 11434);
                    return return_v;
                }


                bool
                f_1142_11462_11493(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 11462, 11493);
                    return return_v;
                }


                bool
                f_1142_11548_11619(string
                uriString, System.UriKind
                uriKind)
                {
                    var return_v = System.Uri.IsWellFormedUriString(uriString, uriKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 11548, 11619);
                    return return_v;
                }


                string[]
                f_1142_12207_12246(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 12207, 12246);
                    return return_v;
                }


                System.Uri
                f_1142_12432_12457(string
                uriString)
                {
                    var return_v = new System.Uri(uriString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 12432, 12457);
                    return return_v;
                }


                string
                f_1142_12721_12742()
                {
                    var return_v = HelpErrors.InvalidURI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 12721, 12742);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1142_12678_12754(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 12678, 12754);
                    return return_v;
                }


                object[]
                f_1142_10871_10886_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 10871, 10886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 9854, 12878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 9854, 12878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool MatchPatternInContent(WildcardPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 13353, 13947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13447, 13501);

                f_1142_13447_13500(pattern != null, "pattern cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13517, 13544);

                string
                synopsis = f_1142_13535_13543()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13558, 13607);

                string
                detailedDescription = f_1142_13587_13606()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13623, 13716) || true) && (synopsis == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 13623, 13716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13677, 13701);

                    synopsis = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 13623, 13716);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13732, 13847) || true) && (detailedDescription == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 13732, 13847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13797, 13832);

                    detailedDescription = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 13732, 13847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 13863, 13936);

                return f_1142_13870_13895(pattern, synopsis) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 13870, 13935) || f_1142_13899_13935(pattern, detailedDescription));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 13353, 13947);

                int
                f_1142_13447_13500(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 13447, 13500);
                    return 0;
                }


                string
                f_1142_13535_13543()
                {
                    var return_v = Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 13535, 13543);
                    return return_v;
                }


                string
                f_1142_13587_13606()
                {
                    var return_v = DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 13587, 13606);
                    return return_v;
                }


                bool
                f_1142_13870_13895(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 13870, 13895);
                    return return_v;
                }


                bool
                f_1142_13899_13935(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 13899, 13935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 13353, 13947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 13353, 13947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override PSObject[] GetParameter(string pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 14242, 16515);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 14443, 14738) || true) && ((f_1142_14448_14461(this) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 14447, 14539) || (f_1142_14492_14530(f_1142_14492_14516(f_1142_14492_14505(this)), "parameters") == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 14447, 14614) || (f_1142_14561_14605(f_1142_14561_14599(f_1142_14561_14585(f_1142_14561_14574(this)), "parameters")) == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 14443, 14738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 14689, 14723);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetParameter(pattern), 1142, 14696, 14722);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 14443, 14738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 14754, 14837);

                PSObject
                prmts = f_1142_14771_14836(f_1142_14791_14835(f_1142_14791_14829(f_1142_14791_14815(f_1142_14791_14804(this)), "parameters")))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 14853, 14977) || true) && (f_1142_14857_14886(f_1142_14857_14873(prmts), "parameter") == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 14853, 14977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 14928, 14962);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetParameter(pattern), 1142, 14935, 14961);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 14853, 14977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15244, 15292);

                var
                param = f_1142_15256_15291(f_1142_15256_15285(f_1142_15256_15272(prmts), "parameter"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15306, 15353);

                PSObject[]
                paramAsPSObjArray = new PSObject[1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15369, 15484) || true) && (param is PSObject paramPSObj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 15369, 15484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15435, 15469);

                    paramAsPSObjArray[0] = paramPSObj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 15369, 15484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15500, 15724);

                PSObject[]
                prmtArray = (PSObject[])f_1142_15535_15723((DynAbs.Tracing.TraceSender.Conditional_F1(1142, 15582, 15610) || ((paramAsPSObjArray[0] != null && DynAbs.Tracing.TraceSender.Conditional_F2(1142, 15613, 15630)) || DynAbs.Tracing.TraceSender.Conditional_F3(1142, 15633, 15638))) ? paramAsPSObjArray : param, typeof(PSObject[]), f_1142_15694_15722())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15740, 15839) || true) && (f_1142_15744_15773(pattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 15740, 15839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15807, 15824);

                    return prmtArray;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 15740, 15839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15855, 15904);

                List<PSObject>
                returnList = f_1142_15883_15903()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 15918, 16001);

                WildcardPattern
                matcher = f_1142_15944_16000(pattern, WildcardOptions.IgnoreCase)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16015, 16460);
                    foreach (PSObject prmtr in f_1142_16042_16051_I(prmtArray))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 16015, 16460);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16085, 16237) || true) && ((f_1142_16090_16114(f_1142_16090_16106(prmtr), "name") == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 16089, 16167) || (f_1142_16128_16158(f_1142_16128_16152(f_1142_16128_16144(prmtr), "name")) == null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 16085, 16237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16209, 16218);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 16085, 16237);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16257, 16316);

                        string
                        prmName = f_1142_16274_16315(f_1142_16274_16304(f_1142_16274_16298(f_1142_16274_16290(prmtr), "name")))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16334, 16445) || true) && (f_1142_16338_16362(matcher, prmName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 16334, 16445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16404, 16426);

                            f_1142_16404_16425(returnList, prmtr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 16334, 16445);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 16015, 16460);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1142, 1, 446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1142, 1, 446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16476, 16504);

                return f_1142_16483_16503(returnList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 14242, 16515);

                System.Management.Automation.PSObject
                f_1142_14448_14461(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14448, 14461);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_14492_14505(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14492, 14505);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_14492_14516(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14492, 14516);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_14492_14530(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14492, 14530);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_14561_14574(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14561, 14574);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_14561_14585(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14561, 14585);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_14561_14599(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14561, 14599);
                    return return_v;
                }


                object
                f_1142_14561_14605(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14561, 14605);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_14791_14804(System.Management.Automation.BaseCommandHelpInfo
                this_param)
                {
                    var return_v = this_param.FullHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14791, 14804);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_14791_14815(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14791, 14815);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_14791_14829(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14791, 14829);
                    return return_v;
                }


                object
                f_1142_14791_14835(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14791, 14835);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1142_14771_14836(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 14771, 14836);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_14857_14873(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14857, 14873);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_14857_14886(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 14857, 14886);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_15256_15272(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 15256, 15272);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_15256_15285(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 15256, 15285);
                    return return_v;
                }


                object
                f_1142_15256_15291(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 15256, 15291);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1142_15694_15722()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 15694, 15722);
                    return return_v;
                }


                object
                f_1142_15535_15723(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 15535, 15723);
                    return return_v;
                }


                bool
                f_1142_15744_15773(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 15744, 15773);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1142_15883_15903()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 15883, 15903);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1142_15944_16000(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 15944, 16000);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_16090_16106(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16090, 16106);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_16090_16114(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16090, 16114);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_16128_16144(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16128, 16144);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_16128_16152(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16128, 16152);
                    return return_v;
                }


                object
                f_1142_16128_16158(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16128, 16158);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1142_16274_16290(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16274, 16290);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1142_16274_16298(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16274, 16298);
                    return return_v;
                }


                object
                f_1142_16274_16304(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16274, 16304);
                    return return_v;
                }


                string?
                f_1142_16274_16315(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 16274, 16315);
                    return return_v;
                }


                bool
                f_1142_16338_16362(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 16338, 16362);
                    return return_v;
                }


                int
                f_1142_16404_16425(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 16404, 16425);
                    return 0;
                }


                System.Management.Automation.PSObject[]
                f_1142_16042_16051_I(System.Management.Automation.PSObject[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 16042, 16051);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1142_16483_16503(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 16483, 16503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 14242, 16515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 14242, 16515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string DetailedDescription
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1142, 16774, 18763);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16810, 16878) || true) && (f_1142_16814_16827(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 16810, 16878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16858, 16878);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 16810, 16878);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 16898, 17108) || true) && (f_1142_16902_16941(f_1142_16902_16926(f_1142_16902_16915(this)), "Description") == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 16902, 17027) || f_1142_16974_17019(f_1142_16974_17013(f_1142_16974_16998(f_1142_16974_16987(this)), "Description")) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 16898, 17108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17069, 17089);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 16898, 17108);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17128, 17354);

                    object[]
                    descriptionItems = (object[])f_1142_17166_17353(f_1142_17217_17262(f_1142_17217_17256(f_1142_17217_17241(f_1142_17217_17230(this)), "Description")), typeof(object[]), f_1142_17324_17352())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17372, 17513) || true) && (descriptionItems == null || (DynAbs.Tracing.TraceSender.Expression_False(1142, 17376, 17432) || f_1142_17404_17427(descriptionItems) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 17372, 17513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17474, 17494);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 17372, 17513);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17839, 17885);

                    StringBuilder
                    result = f_1142_17862_17884(400)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17903, 18696);
                        foreach (object descriptionItem in f_1142_17938_17954_I(descriptionItems))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 17903, 18696);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 17996, 18105) || true) && (descriptionItem == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 17996, 18105);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18073, 18082);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 17996, 18105);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18129, 18195);

                            PSObject
                            descriptionObject = f_1142_18158_18194(descriptionItem)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18217, 18486) || true) && ((descriptionObject == null) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 18221, 18323) || (f_1142_18278_18314(f_1142_18278_18306(descriptionObject), "Text") == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1142, 18221, 18404) || (f_1142_18353_18395(f_1142_18353_18389(f_1142_18353_18381(descriptionObject), "Text")) == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1142, 18217, 18486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18454, 18463);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 18217, 18486);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18510, 18578);

                            string
                            text = f_1142_18524_18577(f_1142_18524_18566(f_1142_18524_18560(f_1142_18524_18552(descriptionObject), "Text")))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18600, 18620);

                            f_1142_18600_18619(result, text);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18642, 18677);

                            f_1142_18642_18676(result, f_1142_18656_18675());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1142, 17903, 18696);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1142, 1, 794);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1142, 1, 794);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1142, 18716, 18748);

                    return f_1142_18723_18747(f_1142_18723_18740(result));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1142, 16774, 18763);

                    System.Management.Automation.PSObject
                    f_1142_16814_16827(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16814, 16827);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_16902_16915(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16902, 16915);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_16902_16926(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16902, 16926);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_16902_16941(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16902, 16941);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_16974_16987(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16974, 16987);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_16974_16998(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16974, 16998);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_16974_17013(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16974, 17013);
                        return return_v;
                    }


                    object
                    f_1142_16974_17019(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 16974, 17019);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_17217_17230(System.Management.Automation.BaseCommandHelpInfo
                    this_param)
                    {
                        var return_v = this_param.FullHelp;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17217, 17230);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_17217_17241(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17217, 17241);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_17217_17256(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17217, 17256);
                        return return_v;
                    }


                    object
                    f_1142_17217_17262(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17217, 17262);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1142_17324_17352()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17324, 17352);
                        return return_v;
                    }


                    object
                    f_1142_17166_17353(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 17166, 17353);
                        return return_v;
                    }


                    int
                    f_1142_17404_17427(object[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 17404, 17427);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1142_17862_17884(int
                    capacity)
                    {
                        var return_v = new System.Text.StringBuilder(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 17862, 17884);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1142_18158_18194(object
                    obj)
                    {
                        var return_v = PSObject.AsPSObject(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18158, 18194);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_18278_18306(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18278, 18306);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_18278_18314(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18278, 18314);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_18353_18381(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18353, 18381);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_18353_18389(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18353, 18389);
                        return return_v;
                    }


                    object
                    f_1142_18353_18395(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18353, 18395);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1142_18524_18552(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18524, 18552);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1142_18524_18560(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18524, 18560);
                        return return_v;
                    }


                    object
                    f_1142_18524_18566(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18524, 18566);
                        return return_v;
                    }


                    string?
                    f_1142_18524_18577(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18524, 18577);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1142_18600_18619(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18600, 18619);
                        return return_v;
                    }


                    string
                    f_1142_18656_18675()
                    {
                        var return_v = Environment.NewLine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1142, 18656, 18675);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1142_18642_18676(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18642, 18676);
                        return return_v;
                    }


                    object[]
                    f_1142_17938_17954_I(object[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 17938, 17954);
                        return return_v;
                    }


                    string
                    f_1142_18723_18740(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18723, 18740);
                        return return_v;
                    }


                    string
                    f_1142_18723_18747(string
                    this_param)
                    {
                        var return_v = this_param.Trim();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1142, 18723, 18747);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1142, 16714, 18774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 16714, 18774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BaseCommandHelpInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1142, 521, 18803);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1142, 521, 18803);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1142, 521, 18803);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1142, 521, 18803);
    }
}
