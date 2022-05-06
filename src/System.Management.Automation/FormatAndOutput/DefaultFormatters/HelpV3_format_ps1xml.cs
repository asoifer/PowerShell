// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Runspaces
{
    internal sealed class HelpV3_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 299, 11299);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 391, 626);

                var
                MamlTypeControl = f_1107_413_625(f_1107_413_594(f_1107_413_561(f_1107_413_470(f_1107_413_435()), @"name", enumerateCollection: true)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 642, 1146);

                var
                MamlParameterValueControl = f_1107_674_1145(f_1107_674_1114(f_1107_674_1081(f_1107_674_966(f_1107_674_885(f_1107_674_770(f_1107_674_731(f_1107_674_696()), " "), @"""[""", selectedByScript: @"$_.required -ne ""true"""), @"""<"" + $_ + "">"""), @"""]""", selectedByScript: @"$_.required -ne ""true""")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 1162, 1403);

                var
                control1 = f_1107_1177_1402(f_1107_1177_1371(f_1107_1177_1338(f_1107_1177_1299(f_1107_1177_1234(f_1107_1177_1199()), @"Value"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 1419, 1697);

                var
                MamlPossibleValueControl = f_1107_1450_1696(f_1107_1450_1665(f_1107_1450_1632(f_1107_1450_1507(f_1107_1450_1472()), @"possibleValue", enumerateCollection: true, customControl: control1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 1713, 2128);

                var
                MamlShortDescriptionControl = f_1107_1747_2127(f_1107_1747_2096(f_1107_1747_2063(f_1107_1747_2024(f_1107_1747_1989(f_1107_1747_1956(f_1107_1747_1917(f_1107_1747_1853(f_1107_1747_1769(), entrySelectedByType: new[] { "MamlParaTextItem" }), @"Text")))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 2144, 3782);

                var
                MamlDescriptionControl = f_1107_2173_3781(f_1107_2173_3750(f_1107_2173_3717(f_1107_2173_3678(f_1107_2173_3643(f_1107_2173_3610(f_1107_2173_3573(f_1107_2173_3530(f_1107_2173_3456(f_1107_2173_3404(f_1107_2173_3365(f_1107_2173_3301(f_1107_2173_3211(f_1107_2173_3178(f_1107_2173_3141(f_1107_2173_3098(f_1107_2173_3030(f_1107_2173_2963(f_1107_2173_2905(f_1107_2173_2812(f_1107_2173_2779(f_1107_2173_2742(f_1107_2173_2699(f_1107_2173_2631(f_1107_2173_2564(f_1107_2173_2506(f_1107_2173_2415(f_1107_2173_2382(f_1107_2173_2343(f_1107_2173_2279(f_1107_2173_2195(), entrySelectedByType: new[] { "MamlParaTextItem" }), @"Text"))), entrySelectedByType: new[] { "MamlOrderedListTextItem" }), firstLineHanging: 4), @"Tag"), @"Text")))), entrySelectedByType: new[] { "MamlUnorderedListTextItem" }), firstLineHanging: 2), @"Tag"), @"Text")))), entrySelectedByType: new[] { "MamlDefinitionTextItem" }), @"Term")), leftIndent: 4), @"Definition"))))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 3798, 4437);

                var
                MamlFieldCustomControl = f_1107_3827_4436(f_1107_3827_4405(f_1107_3827_4372(f_1107_3827_4333(f_1107_3827_4298(f_1107_3827_4265(f_1107_3827_4226(f_1107_3827_4187(f_1107_3827_4104(f_1107_3827_4065(f_1107_3827_3942(f_1107_3827_3849(), entrySelectedByType: new[] { "MamlPSClassHelpInfo#field" }), @"""["" + $_.fieldData.type.name + ""] $"" + $_.fieldData.name")), @"$_.introduction.text"))))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 4453, 5597);

                var
                MamlMethodCustomControl = f_1107_4483_5596(f_1107_4483_5565(f_1107_4483_5532(f_1107_4483_5493(f_1107_4483_5458(f_1107_4483_5425(f_1107_4483_5388(f_1107_4483_5345(f_1107_4483_5258(f_1107_4483_5215(f_1107_4483_4681(f_1107_4483_4638(f_1107_4483_4599(f_1107_4483_4505(), entrySelectedByType: new[] { "MamlPSClassHelpInfo#method" }))), @"function GetParam
{
    if(-not $_.Parameters) { return $null }

    $_.Parameters.Parameter | ForEach-Object {
        if($_.type) { $param = ""[$($_.type.name)] `$$($_.name), "" }
        else { $param = ""[object] `$$($_.name), "" }

        $params += $param
    }

    $params = $params.Remove($params.Length - 2)
    return $params
}

$paramOutput = GetParam
""["" + $_.returnValue.type.name + ""] "" + $_.title + ""("" + $($paramOutput) + "")""")), @"$_.introduction.text"))))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 5613, 6199);

                var
                RelatedLinksHelpInfoControl = f_1107_5647_6198(f_1107_5647_6167(f_1107_5647_6134(f_1107_5647_6097(f_1107_5647_5756(f_1107_5647_5704(f_1107_5647_5669()), leftIndent: 4), f_1107_5819_6096(@"Set-StrictMode -Off
if (($_.relatedLinks -ne $()) -and ($_.relatedLinks.navigationLink -ne $()) -and ($_.relatedLinks.navigationLink.Length -ne 0))
{{
    ""    {0}`""Get-Help $($_.Details.Name) -Online`""""
}}", f_1107_6056_6095())))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 6215, 7076);

                var
                MamlParameterControl = f_1107_6242_7075(f_1107_6242_7044(f_1107_6242_7011(f_1107_6242_6299(f_1107_6242_6264()), @"Set-StrictMode -Off
$optional = $_.required -ne 'true'
$positional = (($_.position -ne $()) -and ($_.position -ne '') -and ($_.position -notmatch 'named') -and ([int]$_.position -ne $()))
$parameterValue = if ($null -ne $_.psobject.Members['ParameterValueGroup']) {
    "" {$($_.ParameterValueGroup.ParameterValue -join ' | ')}""
} elseif ($null -ne $_.psobject.Members['ParameterValue']) {
    "" <$($_.ParameterValue)>""
} else {
    ''
}
$(if ($optional -and $positional) { '[[-{0}]{1}] ' }
elseif ($optional)   { '[-{0}{1}] ' }
elseif ($positional) { '[-{0}]{1} ' }
else                 { '-{0}{1} ' }) -f $_.Name, $parameterValue")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 7092, 7293);

                var
                control2 = f_1107_7107_7292(f_1107_7107_7261(f_1107_7107_7228(f_1107_7107_7164(f_1107_7107_7129()), @"Text")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 7309, 8019);

                var
                MamlExampleControl = f_1107_7334_8018(f_1107_7334_7987(f_1107_7334_7954(f_1107_7334_7816(f_1107_7334_7777(f_1107_7334_7710(f_1107_7334_7671(f_1107_7334_7580(f_1107_7334_7456(f_1107_7334_7391(f_1107_7334_7356()), @"Title"), @"Introduction", enumerateCollection: true, customControl: control2), @"Code", enumerateCollection: true)), @"results")), @"remarks", enumerateCollection: true, customControl: MamlShortDescriptionControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 8035, 8561);

                var
                sharedControls = new CustomControl[] {
                null,//MamlParameterValueGroupControl,
                MamlParameterControl,
                MamlTypeControl,
                MamlParameterValueControl,
                MamlPossibleValueControl,
                MamlShortDescriptionControl,
                MamlDescriptionControl,
                MamlExampleControl,
                MamlFieldCustomControl,
                MamlMethodCustomControl,
                RelatedLinksHelpInfoControl
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 8577, 8726);

                listYield.Add(f_1107_8590_8725("ExtendedCmdletHelpInfo", f_1107_8678_8724(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 8742, 8917);

                listYield.Add(f_1107_8755_8916("ExtendedCmdletHelpInfo#DetailedView", f_1107_8856_8915(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 8933, 9100);

                listYield.Add(f_1107_8946_9099("ExtendedCmdletHelpInfo#FullView", f_1107_9043_9098(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 9116, 9277);

                listYield.Add(f_1107_9129_9276("ExtendedCmdletHelpInfo#ExamplesView", f_1107_9230_9275()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 9293, 9462);

                listYield.Add(f_1107_9306_9461("ExtendedCmdletHelpInfo#parameter", f_1107_9404_9460(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 9478, 9653);

                listYield.Add(f_1107_9491_9652("System.Management.Automation.VerboseRecord", f_1107_9599_9651()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 9669, 9870);

                listYield.Add(f_1107_9682_9869("Deserialized.System.Management.Automation.VerboseRecord", f_1107_9803_9868()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 9886, 10057);

                listYield.Add(f_1107_9899_10056("System.Management.Automation.DebugRecord", f_1107_10005_10055()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10073, 10270);

                listYield.Add(f_1107_10086_10269("Deserialized.System.Management.Automation.DebugRecord", f_1107_10205_10268()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10286, 10447);

                listYield.Add(f_1107_10299_10446("DscResourceHelpInfo#FullView", f_1107_10393_10445(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10463, 10632);

                listYield.Add(f_1107_10476_10631("DscResourceHelpInfo#DetailedView", f_1107_10574_10630(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10648, 10791);

                listYield.Add(f_1107_10661_10790("DscResourceHelpInfo", f_1107_10746_10789(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10807, 10960);

                listYield.Add(f_1107_10820_10959("PSClassHelpInfo#FullView", f_1107_10910_10958(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 10976, 11137);

                listYield.Add(f_1107_10989_11136("PSClassHelpInfo#DetailedView", f_1107_11083_11135(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 11153, 11288);

                listYield.Add(f_1107_11166_11287("PSClassHelpInfo", f_1107_11247_11286(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 299, 11299);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_413_435()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 413, 435);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_413_470(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 413, 470);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_413_561(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 413, 561);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_413_594(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 413, 594);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_413_625(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 413, 625);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_674_696()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 696);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_674_731(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 731);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_674_770(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 770);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_674_885(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 885);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_674_966(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 966);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_674_1081(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 1081);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_674_1114(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 1114);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_674_1145(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 674, 1145);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1177_1199()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1199);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1177_1234(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1234);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1177_1299(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1299);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1177_1338(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1338);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1177_1371(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1371);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_1177_1402(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1177, 1402);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1450_1472()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1450, 1472);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1450_1507(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1450, 1507);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1450_1632(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1450, 1632);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1450_1665(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1450, 1665);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_1450_1696(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1450, 1696);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1747_1769()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 1769);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1747_1853(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 1853);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1747_1917(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 1917);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1747_1956(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 1956);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1747_1989(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 1989);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1747_2024(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 2024);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_1747_2063(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 2063);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_1747_2096(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 2096);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_1747_2127(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 1747, 2127);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_2195()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2195);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2279(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2279);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2343(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2343);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2382(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2382);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_2415(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2415);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2506(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2506);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2564(System.Management.Automation.CustomEntryBuilder
                this_param, int
                firstLineHanging)
                {
                    var return_v = this_param.StartFrame(firstLineHanging: (uint)firstLineHanging);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2564);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2631(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2631);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2699(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2699);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2742(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2742);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2779(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2779);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_2812(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2812);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2905(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2905);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_2963(System.Management.Automation.CustomEntryBuilder
                this_param, int
                firstLineHanging)
                {
                    var return_v = this_param.StartFrame(firstLineHanging: (uint)firstLineHanging);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 2963);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3030(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3030);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3098(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3098);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3141(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3141);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3178(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3178);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_3211(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3211);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3301(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3301);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3365(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3365);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3404(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3404);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3456(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3456);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3530(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3530);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3573(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3573);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3610(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3610);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_3643(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3643);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3678(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3678);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_2173_3717(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3717);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_2173_3750(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3750);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_2173_3781(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 2173, 3781);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_3827_3849()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 3849);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_3942(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 3942);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4065(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4065);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4104(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4104);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4187(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4187);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4226(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4226);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4265(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4265);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_3827_4298(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4298);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4333(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4333);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_3827_4372(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4372);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_3827_4405(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4405);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_3827_4436(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 3827, 4436);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_4483_4505()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 4505);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_4599(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 4599);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_4638(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 4638);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_4681(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 4681);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5215(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5215);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5258(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5258);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5345(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5345);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5388(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5388);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5425(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5425);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_4483_5458(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5458);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5493(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5493);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_4483_5532(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5532);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_4483_5565(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5565);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_4483_5596(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 4483, 5596);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_5647_5669()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 5669);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_5647_5704(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 5704);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_5647_5756(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 5756);
                    return return_v;
                }


                string
                f_1107_6056_6095()
                {
                    var return_v = HelpDisplayStrings.RelatedLinksHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 6056, 6095);
                    return return_v;
                }


                string
                f_1107_5819_6096(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5819, 6096);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_5647_6097(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 6097);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_5647_6134(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 6134);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_5647_6167(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 6167);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_5647_6198(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 5647, 6198);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_6242_6264()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 6242, 6264);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_6242_6299(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 6242, 6299);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_6242_7011(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 6242, 7011);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_6242_7044(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 6242, 7044);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_6242_7075(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 6242, 7075);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_7107_7129()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7107, 7129);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7107_7164(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7107, 7164);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7107_7228(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7107, 7228);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_7107_7261(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7107, 7261);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_7107_7292(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7107, 7292);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_7334_7356()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7356);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7391(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7391);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7456(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7456);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7580(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7580);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7671(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7671);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7710(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7710);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7777(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7777);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7816(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7816);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_7334_7954(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7954);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_7334_7987(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 7987);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_7334_8018(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 7334, 8018);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_8678_8724(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ExtendedCmdletHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 8678, 8724);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_8590_8725(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 8590, 8725);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_8856_8915(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ExtendedCmdletHelpInfo_DetailedView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 8856, 8915);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_8755_8916(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 8755, 8916);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_9043_9098(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ExtendedCmdletHelpInfo_FullView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9043, 9098);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_8946_9099(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 8946, 9099);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_9230_9275()
                {
                    var return_v = ViewsOf_ExtendedCmdletHelpInfo_ExamplesView();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9230, 9275);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_9129_9276(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9129, 9276);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_9404_9460(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ExtendedCmdletHelpInfo_parameter(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9404, 9460);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_9306_9461(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9306, 9461);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_9599_9651()
                {
                    var return_v = ViewsOf_System_Management_Automation_VerboseRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9599, 9651);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_9491_9652(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9491, 9652);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_9803_9868()
                {
                    var return_v = ViewsOf_Deserialized_System_Management_Automation_VerboseRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9803, 9868);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_9682_9869(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9682, 9869);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10005_10055()
                {
                    var return_v = ViewsOf_System_Management_Automation_DebugRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10005, 10055);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_9899_10056(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 9899, 10056);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10205_10268()
                {
                    var return_v = ViewsOf_Deserialized_System_Management_Automation_DebugRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10205, 10268);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10086_10269(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10086, 10269);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10393_10445(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_DscResourceHelpInfo_FullView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10393, 10445);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10299_10446(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10299, 10446);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10574_10630(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_DscResourceHelpInfo_DetailedView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10574, 10630);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10476_10631(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10476, 10631);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10746_10789(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_DscResourceHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10746, 10789);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10661_10790(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10661, 10790);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_10910_10958(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_PSClassHelpInfo_FullView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10910, 10958);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10820_10959(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10820, 10959);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_11083_11135(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_PSClassHelpInfo_DetailedView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11083, 11135);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_10989_11136(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 10989, 11136);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1107_11247_11286(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_PSClassHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11247, 11286);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1107_11166_11287(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11166, 11287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 299, 11299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 299, 11299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ExtendedCmdletHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 11311, 14366);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 11447, 11683);

                var
                control7 = f_1107_11462_11682(f_1107_11462_11651(f_1107_11462_11618(f_1107_11462_11519(f_1107_11462_11484()), f_1107_11554_11617("[{0}]", f_1107_11581_11616()))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 11699, 12287);

                var
                control5 = f_1107_11714_12286(f_1107_11714_12255(f_1107_11714_12222(f_1107_11714_12183(f_1107_11714_12144(f_1107_11714_12004(f_1107_11714_11874(f_1107_11714_11835(f_1107_11714_11771(f_1107_11714_11736()), @"name"), " "), @"Parameter", enumerateCollection: true, customControl: sharedControls[1]), @" ", selectedByScript: "$_.CommonParameters -eq $true", customControl: control7)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 12303, 12562);

                var
                control4 = f_1107_12318_12561(f_1107_12318_12530(f_1107_12318_12497(f_1107_12318_12375(f_1107_12318_12340()), @"SyntaxItem", enumerateCollection: true, customControl: control5)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 12578, 13056);

                var
                control3 = f_1107_12593_13055(f_1107_12593_13024(f_1107_12593_12991(f_1107_12593_12954(f_1107_12593_12911(f_1107_12593_12868(f_1107_12593_12800(f_1107_12593_12748(f_1107_12593_12709(f_1107_12593_12650(f_1107_12593_12615()), f_1107_12685_12708())), leftIndent: 4), @"Name"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 13072, 14355);

                listYield.Add(f_1107_13085_14354("ReducedDefaultCommandHelp", f_1107_13156_14353(f_1107_13156_14322(f_1107_13156_14289(f_1107_13156_14252(f_1107_13156_14209(f_1107_13156_14138(f_1107_13156_14086(f_1107_13156_14047(f_1107_13156_13978(f_1107_13156_13939(f_1107_13156_13902(f_1107_13156_13859(f_1107_13156_13788(f_1107_13156_13736(f_1107_13156_13697(f_1107_13156_13628(f_1107_13156_13589(f_1107_13156_13552(f_1107_13156_13457(f_1107_13156_13405(f_1107_13156_13366(f_1107_13156_13305(f_1107_13156_13213(f_1107_13156_13178()), @"Details", customControl: control3), f_1107_13340_13365())), leftIndent: 4), @"Syntax", customControl: control4))), f_1107_13663_13696())), leftIndent: 4), @"Aliases")))), f_1107_14013_14046())), leftIndent: 4), @"Remarks")))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 11311, 14366);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_11462_11484()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11462, 11484);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11462_11519(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11462, 11519);
                    return return_v;
                }


                string
                f_1107_11581_11616()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 11581, 11616);
                    return return_v;
                }


                string
                f_1107_11554_11617(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11554, 11617);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11462_11618(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11462, 11618);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_11462_11651(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11462, 11651);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_11462_11682(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11462, 11682);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_11714_11736()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 11736);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_11771(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 11771);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_11835(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 11835);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_11874(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 11874);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_12004(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12004);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_12144(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12144);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_12183(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12183);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_11714_12222(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12222);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_11714_12255(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12255);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_11714_12286(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 11714, 12286);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_12318_12340()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12318, 12340);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12318_12375(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12318, 12375);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12318_12497(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12318, 12497);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_12318_12530(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12318, 12530);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_12318_12561(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12318, 12561);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_12593_12615()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12615);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12650(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12650);
                    return return_v;
                }


                string
                f_1107_12685_12708()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 12685, 12708);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12709(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12709);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12748(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12748);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12800(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12800);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12868(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12868);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12911(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12911);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12954(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12954);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_12593_12991(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 12991);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_12593_13024(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 13024);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_12593_13055(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 12593, 13055);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_13156_13178()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13178);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13213(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13213);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13305(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13305);
                    return return_v;
                }


                string
                f_1107_13340_13365()
                {
                    var return_v = HelpDisplayStrings.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 13340, 13365);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13366(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13366);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13405(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13405);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13457(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13457);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13552(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13552);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13589(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13589);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13628(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13628);
                    return return_v;
                }


                string
                f_1107_13663_13696()
                {
                    var return_v = HelpDisplayStrings.AliasesSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 13663, 13696);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13697(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13697);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13736(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13736);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13788(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13788);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13859(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13859);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13902(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13902);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13939(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13939);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_13978(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 13978);
                    return return_v;
                }


                string
                f_1107_14013_14046()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 14013, 14046);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14047(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14047);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14086(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14086);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14138(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14138);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14209(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14209);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14252(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14252);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_13156_14289(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14289);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_13156_14322(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14322);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_13156_14353(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13156, 14353);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_13085_14354(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 13085, 14354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 11311, 14366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 11311, 14366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ExtendedCmdletHelpInfo_DetailedView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 14378, 19693);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 14527, 14802);

                var
                control17 = f_1107_14543_14801(f_1107_14543_14770(f_1107_14543_14737(f_1107_14543_14698(f_1107_14543_14659(f_1107_14543_14600(f_1107_14543_14565()), f_1107_14635_14658())))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 14818, 15313);

                var
                control16 = f_1107_14834_15312(f_1107_14834_15281(f_1107_14834_15248(f_1107_14834_15209(f_1107_14834_15170(f_1107_14834_15133(f_1107_14834_15053(f_1107_14834_15001(f_1107_14834_14962(f_1107_14834_14891(f_1107_14834_14856()), f_1107_14926_14961())), leftIndent: 4), f_1107_15092_15132()))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 15329, 15756);

                var
                control14 = f_1107_15345_15755(f_1107_15345_15724(f_1107_15345_15691(f_1107_15345_15652(f_1107_15345_15613(f_1107_15345_15505(f_1107_15345_15441(f_1107_15345_15402(f_1107_15345_15367()), "-"), @"name"), @"ParameterValue", customControl: sharedControls[3])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 15772, 16032);

                var
                control13 = f_1107_15788_16031(f_1107_15788_16000(f_1107_15788_15967(f_1107_15788_15845(f_1107_15788_15810()), @"Parameter", enumerateCollection: true, customControl: control14)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 16048, 16335);

                var
                control12 = f_1107_16064_16334(f_1107_16064_16303(f_1107_16064_16270(f_1107_16064_16231(f_1107_16064_16160(f_1107_16064_16121(f_1107_16064_16086()), "["), f_1107_16195_16230()), "]")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 16351, 16941);

                var
                control10 = f_1107_16367_16940(f_1107_16367_16909(f_1107_16367_16876(f_1107_16367_16837(f_1107_16367_16798(f_1107_16367_16657(f_1107_16367_16527(f_1107_16367_16488(f_1107_16367_16424(f_1107_16367_16389()), @"name"), " "), @"Parameter", enumerateCollection: true, customControl: sharedControls[1]), @" ", selectedByScript: "$_.CommonParameters -eq $true", customControl: control12)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 16957, 17217);

                var
                control9 = f_1107_16972_17216(f_1107_16972_17185(f_1107_16972_17152(f_1107_16972_17029(f_1107_16972_16994()), @"SyntaxItem", enumerateCollection: true, customControl: control10)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 17233, 17711);

                var
                control8 = f_1107_17248_17710(f_1107_17248_17679(f_1107_17248_17646(f_1107_17248_17609(f_1107_17248_17566(f_1107_17248_17523(f_1107_17248_17455(f_1107_17248_17403(f_1107_17248_17364(f_1107_17248_17305(f_1107_17248_17270()), f_1107_17340_17363())), leftIndent: 4), @"Name"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 17727, 19682);

                listYield.Add(f_1107_17740_19681("ReducedVerboseCommandHelp", f_1107_17811_19680(f_1107_17811_19649(f_1107_17811_19616(f_1107_17811_19579(f_1107_17811_19536(f_1107_17811_19465(f_1107_17811_19413(f_1107_17811_19374(f_1107_17811_19305(f_1107_17811_19266(f_1107_17811_19229(f_1107_17811_19186(f_1107_17811_19115(f_1107_17811_19063(f_1107_17811_19024(f_1107_17811_18955(f_1107_17811_18916(f_1107_17811_18879(f_1107_17811_18688(f_1107_17811_18543(f_1107_17811_18443(f_1107_17811_18391(f_1107_17811_18352(f_1107_17811_18287(f_1107_17811_18250(f_1107_17811_18207(f_1107_17811_18112(f_1107_17811_18060(f_1107_17811_18021(f_1107_17811_17960(f_1107_17811_17868(f_1107_17811_17833()), @"Details", customControl: control8), f_1107_17995_18020())), leftIndent: 4), @"Syntax", customControl: control9))), f_1107_18322_18351())), leftIndent: 4), @"Parameters", customControl: control13), @" ", selectedByScript: "$_.CommonParameters -eq $true", customControl: control16), @" ", selectedByScript: "($_.CommonParameters -eq $false) -and ($_.parameters.parameter.count -eq 0)", customControl: control17))), f_1107_18990_19023())), leftIndent: 4), @"Aliases")))), f_1107_19340_19373())), leftIndent: 4), @"Remarks")))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 14378, 19693);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_14543_14565()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14565);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14543_14600(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14600);
                    return return_v;
                }


                string
                f_1107_14635_14658()
                {
                    var return_v = HelpDisplayStrings.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 14635, 14658);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14543_14659(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14659);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14543_14698(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14698);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14543_14737(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14737);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_14543_14770(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14770);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_14543_14801(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14543, 14801);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_14834_14856()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 14856);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_14891(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 14891);
                    return return_v;
                }


                string
                f_1107_14926_14961()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 14926, 14961);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_14962(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 14962);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15001(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15001);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15053(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15053);
                    return return_v;
                }


                string
                f_1107_15092_15132()
                {
                    var return_v = HelpDisplayStrings.BaseCmdletInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 15092, 15132);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15133(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15133);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15170(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15170);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15209(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15209);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_14834_15248(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15248);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_14834_15281(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15281);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_14834_15312(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 14834, 15312);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_15345_15367()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15367);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15402(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15402);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15441(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15441);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15505(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15505);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15613(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15613);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15652(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15652);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15345_15691(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15691);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_15345_15724(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15724);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_15345_15755(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15345, 15755);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_15788_15810()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15788, 15810);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15788_15845(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15788, 15845);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_15788_15967(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15788, 15967);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_15788_16000(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15788, 16000);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_15788_16031(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 15788, 16031);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16064_16086()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16086);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16064_16121(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16121);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16064_16160(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16160);
                    return return_v;
                }


                string
                f_1107_16195_16230()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 16195, 16230);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16064_16231(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16231);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16064_16270(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16270);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16064_16303(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16303);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_16064_16334(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16064, 16334);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16367_16389()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16389);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16424(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16424);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16488(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16488);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16527(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16527);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16657(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16657);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16798(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16798);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16837(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16837);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16367_16876(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16876);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16367_16909(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16909);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_16367_16940(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16367, 16940);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16972_16994()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16972, 16994);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16972_17029(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16972, 17029);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_16972_17152(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16972, 17152);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_16972_17185(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16972, 17185);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_16972_17216(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 16972, 17216);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_17248_17270()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17270);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17305(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17305);
                    return return_v;
                }


                string
                f_1107_17340_17363()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 17340, 17363);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17364(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17364);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17403(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17403);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17455(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17455);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17523(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17523);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17566(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17566);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17609(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17609);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17248_17646(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17646);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_17248_17679(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17679);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_17248_17710(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17248, 17710);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_17811_17833()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 17833);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_17868(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 17868);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_17960(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 17960);
                    return return_v;
                }


                string
                f_1107_17995_18020()
                {
                    var return_v = HelpDisplayStrings.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 17995, 18020);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18021(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18021);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18060(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18060);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18112(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18112);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18207(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18207);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18250(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18250);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18287(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18287);
                    return return_v;
                }


                string
                f_1107_18322_18351()
                {
                    var return_v = HelpDisplayStrings.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 18322, 18351);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18352(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18352);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18391(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18391);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18443(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18443);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18543(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18543);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18688(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18688);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18879(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18879);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18916(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18916);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_18955(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 18955);
                    return return_v;
                }


                string
                f_1107_18990_19023()
                {
                    var return_v = HelpDisplayStrings.AliasesSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 18990, 19023);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19024(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19024);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19063(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19063);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19115(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19115);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19186(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19186);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19229(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19229);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19266(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19266);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19305(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19305);
                    return return_v;
                }


                string
                f_1107_19340_19373()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 19340, 19373);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19374(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19374);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19413(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19413);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19465(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19465);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19536(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19536);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19579(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19579);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_17811_19616(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19616);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_17811_19649(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19649);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_17811_19680(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17811, 19680);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_17740_19681(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 17740, 19681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 14378, 19693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 14378, 19693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ExtendedCmdletHelpInfo_FullView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 19705, 29744);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 19850, 20125);

                var
                control35 = f_1107_19866_20124(f_1107_19866_20093(f_1107_19866_20060(f_1107_19866_20021(f_1107_19866_19923(f_1107_19866_19888()), @"type", customControl: sharedControls[2]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 20141, 20403);

                var
                control34 = f_1107_20157_20402(f_1107_20157_20371(f_1107_20157_20338(f_1107_20157_20214(f_1107_20157_20179()), @"ReturnValue", enumerateCollection: true, customControl: control35)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 20419, 20694);

                var
                control33 = f_1107_20435_20693(f_1107_20435_20662(f_1107_20435_20629(f_1107_20435_20590(f_1107_20435_20492(f_1107_20435_20457()), @"type", customControl: sharedControls[2]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 20710, 20970);

                var
                control32 = f_1107_20726_20969(f_1107_20726_20938(f_1107_20726_20905(f_1107_20726_20783(f_1107_20726_20748()), @"InputType", enumerateCollection: true, customControl: control33)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 20986, 21261);

                var
                control31 = f_1107_21002_21260(f_1107_21002_21229(f_1107_21002_21196(f_1107_21002_21157(f_1107_21002_21118(f_1107_21002_21059(f_1107_21002_21024()), f_1107_21094_21117())))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 21277, 21772);

                var
                control30 = f_1107_21293_21771(f_1107_21293_21740(f_1107_21293_21707(f_1107_21293_21668(f_1107_21293_21629(f_1107_21293_21592(f_1107_21293_21512(f_1107_21293_21460(f_1107_21293_21421(f_1107_21293_21350(f_1107_21293_21315()), f_1107_21385_21420())), leftIndent: 4), f_1107_21551_21591()))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 21788, 21995);

                var
                control28 = f_1107_21804_21994(f_1107_21804_21963(f_1107_21804_21930(f_1107_21804_21861(f_1107_21804_21826()), f_1107_21896_21929())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 22011, 22214);

                var
                control27 = f_1107_22027_22213(f_1107_22027_22182(f_1107_22027_22149(f_1107_22027_22084(f_1107_22027_22049()), f_1107_22119_22148())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 22230, 22432);

                var
                control26 = f_1107_22246_22431(f_1107_22246_22400(f_1107_22246_22367(f_1107_22246_22303(f_1107_22246_22268()), f_1107_22338_22366())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 22448, 22694);

                var
                control25 = f_1107_22464_22693(f_1107_22464_22662(f_1107_22464_22629(f_1107_22464_22521(f_1107_22464_22486()), @"possibleValues", customControl: sharedControls[4])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 22710, 25129);

                var
                control24 = f_1107_22726_25128(f_1107_22726_25097(f_1107_22726_25064(f_1107_22726_25027(f_1107_22726_24984(f_1107_22726_24941(f_1107_22726_24868(f_1107_22726_24791(f_1107_22726_24748(f_1107_22726_24677(f_1107_22726_24602(f_1107_22726_24559(f_1107_22726_24479(f_1107_22726_24404(f_1107_22726_24361(f_1107_22726_24284(f_1107_22726_24205(f_1107_22726_24162(f_1107_22726_24041(f_1107_22726_23875(f_1107_22726_23799(f_1107_22726_23756(f_1107_22726_23600(f_1107_22726_23445(f_1107_22726_23369(f_1107_22726_23326(f_1107_22726_23204(f_1107_22726_23085(f_1107_22726_23033(f_1107_22726_22994(f_1107_22726_22886(f_1107_22726_22822(f_1107_22726_22783(f_1107_22726_22748()), "-"), @"name"), @"ParameterValue", customControl: sharedControls[3])), leftIndent: 4), @"description", selectedByScript: "$_.description -ne $()"), control25, selectedByScript: "$_.possibleValues -ne $()")), f_1107_23408_23444()), @" ", selectedByScript: @"$_.required.ToLower().Equals(""true"")", customControl: control26), @" ", selectedByScript: @"$_.required.ToLower().Equals(""false"")", customControl: control27)), f_1107_23838_23874()), @" ", selectedByScript: @"($_.position -eq  $()) -or ($_.position -eq """")", customControl: control28), @"$_.position", selectedByScript: "$_.position  -ne  $()")), f_1107_24244_24283()), @"pipelineInput")), f_1107_24443_24478()), @"parameterSetName")), f_1107_24641_24676()), @"aliases")), f_1107_24830_24867()), @"isDynamic"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 25145, 25405);

                var
                control23 = f_1107_25161_25404(f_1107_25161_25373(f_1107_25161_25340(f_1107_25161_25218(f_1107_25161_25183()), @"Parameter", enumerateCollection: true, customControl: control24)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 25421, 25708);

                var
                control22 = f_1107_25437_25707(f_1107_25437_25676(f_1107_25437_25643(f_1107_25437_25604(f_1107_25437_25533(f_1107_25437_25494(f_1107_25437_25459()), "["), f_1107_25568_25603()), "]")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 25724, 26314);

                var
                control20 = f_1107_25740_26313(f_1107_25740_26282(f_1107_25740_26249(f_1107_25740_26210(f_1107_25740_26171(f_1107_25740_26030(f_1107_25740_25900(f_1107_25740_25861(f_1107_25740_25797(f_1107_25740_25762()), @"name"), " "), @"Parameter", enumerateCollection: true, customControl: sharedControls[1]), @" ", selectedByScript: "$_.CommonParameters -eq $true", customControl: control22)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 26330, 26591);

                var
                control19 = f_1107_26346_26590(f_1107_26346_26559(f_1107_26346_26526(f_1107_26346_26403(f_1107_26346_26368()), @"SyntaxItem", enumerateCollection: true, customControl: control20)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 26607, 27086);

                var
                control18 = f_1107_26623_27085(f_1107_26623_27054(f_1107_26623_27021(f_1107_26623_26984(f_1107_26623_26941(f_1107_26623_26898(f_1107_26623_26830(f_1107_26623_26778(f_1107_26623_26739(f_1107_26623_26680(f_1107_26623_26645()), f_1107_26715_26738())), leftIndent: 4), @"Name"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 27102, 29733);

                listYield.Add(f_1107_27183_27624_custom("ReducedFullCommandHelp", f_1107_27183_29731(f_1107_27183_29700(f_1107_27183_29667(f_1107_27183_29630(f_1107_27183_29587(f_1107_27183_29516(f_1107_27183_29464(f_1107_27183_29425(f_1107_27183_29356(f_1107_27183_29317(f_1107_27183_29280(f_1107_27183_29237(f_1107_27183_29166(f_1107_27183_29114(f_1107_27183_29075(f_1107_27183_29006(f_1107_27183_28969(f_1107_27183_28926(f_1107_27183_28824(f_1107_27183_28772(f_1107_27183_28733(f_1107_27183_28668(f_1107_27183_28631(f_1107_27183_28588(f_1107_27183_28488(f_1107_27183_28436(f_1107_27183_28397(f_1107_27183_28333(f_1107_27183_28296(f_1107_27183_28253(f_1107_27183_28062(f_1107_27183_27917(f_1107_27183_27817(f_1107_27183_27765(f_1107_27183_27726(f_1107_27183_27661(f_1107_27183_27624(f_1107_27183_27581(f_1107_27183_27485(f_1107_27183_27433(f_1107_27183_27394(f_1107_27183_27333(f_1107_27183_27240(f_1107_27183_27205()), @"Details", customControl: control18), f_1107_27368_27393())), leftIndent: 4), @"Syntax", customControl: control19))), f_1107_27696_27725())), leftIndent: 4), @"Parameters", customControl: control23), @" ", selectedByScript: "$_.CommonParameters -eq $true", customControl: control30), @" ", selectedByScript: "($_.CommonParameters -eq $false) -and ($_.parameters.parameter.count -eq 0)", customControl: control31))), f_1107_28368_28396())), leftIndent: 4), @"InputTypes", customControl: control32))), f_1107_28703_28732())), leftIndent: 4), @"ReturnValues", customControl: control34))), f_1107_29041_29074())), leftIndent: 4), @"Aliases")))), f_1107_29391_29424())), leftIndent: 4), @"Remarks")))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 19705, 29744);

                return listYield;

                FormatViewDefinition f_1107_27183_27624_custom(string s, CustomControl c)
                {
                    var ret = new FormatViewDefinition(s, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27624);
                    return ret;
                }

                System.Management.Automation.CustomControlBuilder
                f_1107_19866_19888()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 19888);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_19866_19923(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 19923);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_19866_20021(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 20021);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_19866_20060(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 20060);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_19866_20093(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 20093);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_19866_20124(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 19866, 20124);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20157_20179()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20157, 20179);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20157_20214(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20157, 20214);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20157_20338(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20157, 20338);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20157_20371(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20157, 20371);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_20157_20402(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20157, 20402);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20435_20457()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20457);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20435_20492(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20492);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20435_20590(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20590);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20435_20629(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20629);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20435_20662(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20662);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_20435_20693(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20435, 20693);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20726_20748()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20726, 20748);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20726_20783(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20726, 20783);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_20726_20905(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20726, 20905);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_20726_20938(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20726, 20938);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_20726_20969(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 20726, 20969);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21002_21024()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21024);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21002_21059(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21059);
                    return return_v;
                }


                string
                f_1107_21094_21117()
                {
                    var return_v = HelpDisplayStrings.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 21094, 21117);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21002_21118(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21118);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21002_21157(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21157);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21002_21196(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21196);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21002_21229(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21229);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_21002_21260(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21002, 21260);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21293_21315()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21315);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21350(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21350);
                    return return_v;
                }


                string
                f_1107_21385_21420()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 21385, 21420);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21421(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21421);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21460(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21460);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21512(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21512);
                    return return_v;
                }


                string
                f_1107_21551_21591()
                {
                    var return_v = HelpDisplayStrings.BaseCmdletInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 21551, 21591);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21592(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21592);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21629(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21629);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21668(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21668);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21293_21707(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21707);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21293_21740(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21740);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_21293_21771(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21293, 21771);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21804_21826()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21804, 21826);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21804_21861(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21804, 21861);
                    return return_v;
                }


                string
                f_1107_21896_21929()
                {
                    var return_v = HelpDisplayStrings.NamedParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 21896, 21929);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_21804_21930(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21804, 21930);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_21804_21963(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21804, 21963);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_21804_21994(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 21804, 21994);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22027_22049()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22027, 22049);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22027_22084(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22027, 22084);
                    return return_v;
                }


                string
                f_1107_22119_22148()
                {
                    var return_v = HelpDisplayStrings.FalseShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 22119, 22148);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22027_22149(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22027, 22149);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22027_22182(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22027, 22182);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_22027_22213(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22027, 22213);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22246_22268()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22246, 22268);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22246_22303(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22246, 22303);
                    return return_v;
                }


                string
                f_1107_22338_22366()
                {
                    var return_v = HelpDisplayStrings.TrueShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 22338, 22366);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22246_22367(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22246, 22367);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22246_22400(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22246, 22400);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_22246_22431(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22246, 22431);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22464_22486()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22464, 22486);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22464_22521(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22464, 22521);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22464_22629(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22464, 22629);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22464_22662(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22464, 22662);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_22464_22693(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22464, 22693);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22726_22748()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 22748);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_22783(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 22783);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_22822(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 22822);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_22886(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 22886);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_22994(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 22994);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23033(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23033);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23085(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23085);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23204(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, string
                selectedByScript)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23204);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23326(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23326);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23369(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23369);
                    return return_v;
                }


                string
                f_1107_23408_23444()
                {
                    var return_v = HelpDisplayStrings.ParameterRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 23408, 23444);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23445(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23445);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23600(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23600);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23756(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23756);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23799(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23799);
                    return return_v;
                }


                string
                f_1107_23838_23874()
                {
                    var return_v = HelpDisplayStrings.ParameterPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 23838, 23874);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_23875(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 23875);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24041(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24041);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24162(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24162);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24205(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24205);
                    return return_v;
                }


                string
                f_1107_24244_24283()
                {
                    var return_v = HelpDisplayStrings.AcceptsPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 24244, 24283);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24284(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24284);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24361(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24361);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24404(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24404);
                    return return_v;
                }


                string
                f_1107_24443_24478()
                {
                    var return_v = HelpDisplayStrings.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 24443, 24478);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24479(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24479);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24559(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24559);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24602(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24602);
                    return return_v;
                }


                string
                f_1107_24641_24676()
                {
                    var return_v = HelpDisplayStrings.ParameterAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 24641, 24676);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24677(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24677);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24748(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24748);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24791(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24791);
                    return return_v;
                }


                string
                f_1107_24830_24867()
                {
                    var return_v = HelpDisplayStrings.ParameterIsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 24830, 24867);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24868(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24868);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24941(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24941);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_24984(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 24984);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_25027(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 25027);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_22726_25064(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 25064);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_22726_25097(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 25097);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_22726_25128(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 22726, 25128);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25161_25183()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25161, 25183);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25161_25218(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25161, 25218);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25161_25340(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25161, 25340);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25161_25373(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25161, 25373);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_25161_25404(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25161, 25404);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25437_25459()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25459);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25437_25494(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25494);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25437_25533(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25533);
                    return return_v;
                }


                string
                f_1107_25568_25603()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 25568, 25603);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25437_25604(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25604);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25437_25643(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25643);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25437_25676(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25676);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_25437_25707(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25437, 25707);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25740_25762()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 25762);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_25797(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 25797);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_25861(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 25861);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_25900(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 25900);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_26030(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26030);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_26171(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26171);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_26210(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26210);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_25740_26249(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26249);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_25740_26282(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26282);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_25740_26313(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 25740, 26313);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_26346_26368()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26346, 26368);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26346_26403(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26346, 26403);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26346_26526(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26346, 26526);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_26346_26559(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26346, 26559);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_26346_26590(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26346, 26590);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_26623_26645()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26645);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26680(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26680);
                    return return_v;
                }


                string
                f_1107_26715_26738()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 26715, 26738);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26739(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26739);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26778(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26778);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26830(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26830);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26898(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26898);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26941(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26941);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_26984(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 26984);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_26623_27021(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 27021);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_26623_27054(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 27054);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_26623_27085(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 26623, 27085);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_27183_27205()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27205);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27240(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27240);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27333(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27333);
                    return return_v;
                }


                string
                f_1107_27368_27393()
                {
                    var return_v = HelpDisplayStrings.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 27368, 27393);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27394(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27394);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27433(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27433);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27485(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27485);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27581(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27581);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27624(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27624);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27661(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27661);
                    return return_v;
                }


                string
                f_1107_27696_27725()
                {
                    var return_v = HelpDisplayStrings.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 27696, 27725);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27726(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27726);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27765(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27765);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27817(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27817);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_27917(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 27917);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28062(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28062);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28253(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28253);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28296(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28296);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28333(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28333);
                    return return_v;
                }


                string
                f_1107_28368_28396()
                {
                    var return_v = HelpDisplayStrings.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 28368, 28396);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28397(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28397);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28436(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28436);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28488(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28488);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28588(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28588);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28631(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28631);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28668(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28668);
                    return return_v;
                }


                string
                f_1107_28703_28732()
                {
                    var return_v = HelpDisplayStrings.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 28703, 28732);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28733(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28733);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28772(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28772);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28824(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28824);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28926(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28926);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_28969(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 28969);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29006(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29006);
                    return return_v;
                }


                string
                f_1107_29041_29074()
                {
                    var return_v = HelpDisplayStrings.AliasesSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 29041, 29074);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29075(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29075);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29114(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29114);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29166(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29166);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29237(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29237);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29280(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29280);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29317(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29317);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29356(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29356);
                    return return_v;
                }


                string
                f_1107_29391_29424()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 29391, 29424);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29425(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29425);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29464(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29464);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29516(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29516);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29587(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29587);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29630(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29630);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_27183_29667(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29667);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_27183_29700(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29700);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_27183_29731(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 27183, 29731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 19705, 29744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 19705, 29744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ExtendedCmdletHelpInfo_ExamplesView()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 29756, 31339);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 29875, 30311);

                var
                control36 = f_1107_29891_30310(f_1107_29891_30279(f_1107_29891_30246(f_1107_29891_30209(f_1107_29891_30166(f_1107_29891_30098(f_1107_29891_30046(f_1107_29891_30007(f_1107_29891_29948(f_1107_29891_29913()), f_1107_29983_30006())), leftIndent: 4), @"Name")))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 30327, 31328);

                listYield.Add(f_1107_30340_31327("ReducedExamplesCommandHelp", f_1107_30412_31326(f_1107_30412_31295(f_1107_30412_31262(f_1107_30412_31225(f_1107_30412_31182(f_1107_30412_31111(f_1107_30412_31059(f_1107_30412_31020(f_1107_30412_30951(f_1107_30412_30912(f_1107_30412_30875(f_1107_30412_30832(f_1107_30412_30761(f_1107_30412_30709(f_1107_30412_30670(f_1107_30412_30601(f_1107_30412_30562(f_1107_30412_30469(f_1107_30412_30434()), @"Details", customControl: control36)), f_1107_30636_30669())), leftIndent: 4), @"Aliases")))), f_1107_30986_31019())), leftIndent: 4), @"Remarks")))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 29756, 31339);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_29891_29913()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 29913);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_29948(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 29948);
                    return return_v;
                }


                string
                f_1107_29983_30006()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 29983, 30006);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30007(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30007);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30046(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30046);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30098(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30098);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30166(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30166);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30209(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30209);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_29891_30246(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30246);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_29891_30279(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30279);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_29891_30310(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 29891, 30310);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_30412_30434()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30434);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30469(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30469);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30562(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30562);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30601(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30601);
                    return return_v;
                }


                string
                f_1107_30636_30669()
                {
                    var return_v = HelpDisplayStrings.AliasesSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 30636, 30669);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30670(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30670);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30709(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30709);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30761(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30761);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30832(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30832);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30875(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30875);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30912(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30912);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_30951(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 30951);
                    return return_v;
                }


                string
                f_1107_30986_31019()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 30986, 31019);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31020(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31020);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31059(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31059);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31111(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31111);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31182(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31182);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31225(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31225);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_30412_31262(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31262);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_30412_31295(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31295);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_30412_31326(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30412, 31326);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_30340_31327(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 30340, 31327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 29756, 31339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 29756, 31339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ExtendedCmdletHelpInfo_parameter(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 31351, 35176);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 31497, 31704);

                var
                control41 = f_1107_31513_31703(f_1107_31513_31672(f_1107_31513_31639(f_1107_31513_31570(f_1107_31513_31535()), f_1107_31605_31638())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 31720, 31923);

                var
                control40 = f_1107_31736_31922(f_1107_31736_31891(f_1107_31736_31858(f_1107_31736_31793(f_1107_31736_31758()), f_1107_31828_31857())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 31939, 32141);

                var
                control39 = f_1107_31955_32140(f_1107_31955_32109(f_1107_31955_32076(f_1107_31955_32012(f_1107_31955_31977()), f_1107_32047_32075())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 32157, 32403);

                var
                control38 = f_1107_32173_32402(f_1107_32173_32371(f_1107_32173_32338(f_1107_32173_32230(f_1107_32173_32195()), @"possibleValues", customControl: sharedControls[4])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 32419, 34838);

                var
                control37 = f_1107_32435_34837(f_1107_32435_34806(f_1107_32435_34773(f_1107_32435_34736(f_1107_32435_34693(f_1107_32435_34650(f_1107_32435_34577(f_1107_32435_34500(f_1107_32435_34457(f_1107_32435_34386(f_1107_32435_34311(f_1107_32435_34268(f_1107_32435_34188(f_1107_32435_34113(f_1107_32435_34070(f_1107_32435_33993(f_1107_32435_33914(f_1107_32435_33871(f_1107_32435_33750(f_1107_32435_33584(f_1107_32435_33508(f_1107_32435_33465(f_1107_32435_33309(f_1107_32435_33154(f_1107_32435_33078(f_1107_32435_33035(f_1107_32435_32913(f_1107_32435_32794(f_1107_32435_32742(f_1107_32435_32703(f_1107_32435_32595(f_1107_32435_32531(f_1107_32435_32492(f_1107_32435_32457()), "-"), @"name"), @"ParameterValue", customControl: sharedControls[3])), leftIndent: 4), @"description", selectedByScript: "$_.description -ne $()"), control38, selectedByScript: "$_.possibleValues -ne $()")), f_1107_33117_33153()), @" ", selectedByScript: @"$_.required.ToLower().Equals(""true"")", customControl: control39), @" ", selectedByScript: @"$_.required.ToLower().Equals(""false"")", customControl: control40)), f_1107_33547_33583()), @" ", selectedByScript: @"($_.position -eq  $()) -or ($_.position -eq """")", customControl: control41), @"$_.position", selectedByScript: "$_.position  -ne  $()")), f_1107_33953_33992()), @"pipelineInput")), f_1107_34152_34187()), @"parameterSetName")), f_1107_34350_34385()), @"aliases")), f_1107_34539_34576()), @"isDynamic"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 34854, 35165);

                listYield.Add(f_1107_34867_35164("ReducedCommandHelpParameterView", f_1107_34944_35163(f_1107_34944_35132(f_1107_34944_35099(f_1107_34944_35001(f_1107_34944_34966()), control37, enumerateCollection: true)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 31351, 35176);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_31513_31535()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31513, 31535);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31513_31570(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31513, 31570);
                    return return_v;
                }


                string
                f_1107_31605_31638()
                {
                    var return_v = HelpDisplayStrings.NamedParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 31605, 31638);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31513_31639(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31513, 31639);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_31513_31672(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31513, 31672);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_31513_31703(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31513, 31703);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_31736_31758()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31736, 31758);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31736_31793(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31736, 31793);
                    return return_v;
                }


                string
                f_1107_31828_31857()
                {
                    var return_v = HelpDisplayStrings.FalseShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 31828, 31857);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31736_31858(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31736, 31858);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_31736_31891(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31736, 31891);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_31736_31922(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31736, 31922);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_31955_31977()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31955, 31977);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31955_32012(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31955, 32012);
                    return return_v;
                }


                string
                f_1107_32047_32075()
                {
                    var return_v = HelpDisplayStrings.TrueShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 32047, 32075);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_31955_32076(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31955, 32076);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_31955_32109(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31955, 32109);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_31955_32140(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 31955, 32140);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_32173_32195()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32173, 32195);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32173_32230(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32173, 32230);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32173_32338(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32173, 32338);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_32173_32371(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32173, 32371);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_32173_32402(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32173, 32402);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_32435_32457()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32457);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32492(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32492);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32531(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32531);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32595(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32595);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32703(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32703);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32742(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32742);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32794(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32794);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_32913(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, string
                selectedByScript)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 32913);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33035(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33035);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33078(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33078);
                    return return_v;
                }


                string
                f_1107_33117_33153()
                {
                    var return_v = HelpDisplayStrings.ParameterRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 33117, 33153);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33154(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33154);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33309(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33309);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33465(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33465);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33508(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33508);
                    return return_v;
                }


                string
                f_1107_33547_33583()
                {
                    var return_v = HelpDisplayStrings.ParameterPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 33547, 33583);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33584(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33584);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33750(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33750);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33871(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33871);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33914(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33914);
                    return return_v;
                }


                string
                f_1107_33953_33992()
                {
                    var return_v = HelpDisplayStrings.AcceptsPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 33953, 33992);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_33993(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 33993);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34070(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34070);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34113(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34113);
                    return return_v;
                }


                string
                f_1107_34152_34187()
                {
                    var return_v = HelpDisplayStrings.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 34152, 34187);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34188(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34188);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34268(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34268);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34311(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34311);
                    return return_v;
                }


                string
                f_1107_34350_34385()
                {
                    var return_v = HelpDisplayStrings.ParameterAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 34350, 34385);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34386(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34386);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34457(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34457);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34500(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34500);
                    return return_v;
                }


                string
                f_1107_34539_34576()
                {
                    var return_v = HelpDisplayStrings.ParameterIsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 34539, 34576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34577(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34577);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34650(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34650);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34693(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34693);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34736(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34736);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_32435_34773(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34773);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_32435_34806(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34806);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_32435_34837(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 32435, 34837);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_34944_34966()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34944, 34966);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_34944_35001(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34944, 35001);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_34944_35099(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34944, 35099);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_34944_35132(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34944, 35132);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_34944_35163(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34944, 35163);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_34867_35164(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 34867, 35164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 31351, 35176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 31351, 35176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_VerboseRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 35188, 35602);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 35314, 35591);

                listYield.Add(f_1107_35327_35590("VerboseRecord", f_1107_35386_35589(f_1107_35386_35558(f_1107_35386_35525(f_1107_35386_35458(f_1107_35386_35423(outOfBand: true)), @"Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 35188, 35602);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_35386_35423(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35386, 35423);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_35386_35458(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35386, 35458);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_35386_35525(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35386, 35525);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_35386_35558(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35386, 35558);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_35386_35589(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35386, 35589);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_35327_35590(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35327, 35590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 35188, 35602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 35188, 35602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_System_Management_Automation_VerboseRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 35614, 36073);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 35753, 36062);

                listYield.Add(f_1107_35766_36061("DeserializedVerboseRecord", f_1107_35837_36060(f_1107_35837_36029(f_1107_35837_35996(f_1107_35837_35909(f_1107_35837_35874(outOfBand: true)), @"InformationalRecord_Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 35614, 36073);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_35837_35874(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35837, 35874);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_35837_35909(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35837, 35909);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_35837_35996(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35837, 35996);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_35837_36029(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35837, 36029);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_35837_36060(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35837, 36060);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_35766_36061(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 35766, 36061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 35614, 36073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 35614, 36073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_DebugRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 36085, 36495);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 36209, 36484);

                listYield.Add(f_1107_36222_36483("DebugRecord", f_1107_36279_36482(f_1107_36279_36451(f_1107_36279_36418(f_1107_36279_36351(f_1107_36279_36316(outOfBand: true)), @"Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 36085, 36495);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_36279_36316(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36279, 36316);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_36279_36351(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36279, 36351);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_36279_36418(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36279, 36418);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_36279_36451(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36279, 36451);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_36279_36482(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36279, 36482);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_36222_36483(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36222, 36483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 36085, 36495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 36085, 36495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_System_Management_Automation_DebugRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 36507, 36962);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 36644, 36951);

                listYield.Add(f_1107_36657_36950("DeserializedDebugRecord", f_1107_36726_36949(f_1107_36726_36918(f_1107_36726_36885(f_1107_36726_36798(f_1107_36726_36763(outOfBand: true)), @"InformationalRecord_Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 36507, 36962);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_36726_36763(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36726, 36763);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_36726_36798(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36726, 36798);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_36726_36885(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36726, 36885);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_36726_36918(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36726, 36918);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_36726_36949(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36726, 36949);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_36657_36950(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 36657, 36950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 36507, 36962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 36507, 36962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_DscResourceHelpInfo_FullView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 36974, 44017);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 37116, 37538);

                var
                control50 = f_1107_37132_37537(f_1107_37132_37506(f_1107_37132_37473(f_1107_37132_37434(f_1107_37132_37371(f_1107_37132_37257(f_1107_37132_37189(f_1107_37132_37154()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 37554, 37819);

                var
                control49 = f_1107_37570_37818(f_1107_37570_37787(f_1107_37570_37754(f_1107_37570_37627(f_1107_37570_37592()), @"navigationLink", enumerateCollection: true, customControl: control50)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 37835, 38101);

                var
                control48 = f_1107_37851_38100(f_1107_37851_38069(f_1107_37851_38036(f_1107_37851_37908(f_1107_37851_37873()), @"Example", enumerateCollection: true, customControl: sharedControls[7])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 38117, 38320);

                var
                control47 = f_1107_38133_38319(f_1107_38133_38288(f_1107_38133_38255(f_1107_38133_38190(f_1107_38133_38155()), f_1107_38225_38254())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 38336, 38538);

                var
                control46 = f_1107_38352_38537(f_1107_38352_38506(f_1107_38352_38473(f_1107_38352_38409(f_1107_38352_38374()), f_1107_38444_38472())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 38554, 38800);

                var
                control45 = f_1107_38570_38799(f_1107_38570_38768(f_1107_38570_38735(f_1107_38570_38627(f_1107_38570_38592()), @"possibleValues", customControl: sharedControls[4])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 38816, 40024);

                var
                control44 = f_1107_38832_40023(f_1107_38832_39992(f_1107_38832_39959(f_1107_38832_39920(f_1107_38832_39883(f_1107_38832_39840(f_1107_38832_39684(f_1107_38832_39529(f_1107_38832_39453(f_1107_38832_39410(f_1107_38832_39288(f_1107_38832_39152(f_1107_38832_39100(f_1107_38832_39061(f_1107_38832_38953(f_1107_38832_38889(f_1107_38832_38854()), @"name"), @"ParameterValue", customControl: sharedControls[3])), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[6]), control45, selectedByScript: "$_.possibleValues -ne $()")), f_1107_39492_39528()), @" ", selectedByScript: @"$_.required.ToLower().Equals(""true"")", customControl: control46), @" ", selectedByScript: @"$_.required.ToLower().Equals(""false"")", customControl: control47))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 40040, 40300);

                var
                control43 = f_1107_40056_40299(f_1107_40056_40268(f_1107_40056_40235(f_1107_40056_40113(f_1107_40056_40078()), @"Parameter", enumerateCollection: true, customControl: control44)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 40316, 41165);

                var
                control42 = f_1107_40332_41164(f_1107_40332_41133(f_1107_40332_41100(f_1107_40332_41063(f_1107_40332_41020(f_1107_40332_40884(f_1107_40332_40832(f_1107_40332_40793(f_1107_40332_40730(f_1107_40332_40693(f_1107_40332_40650(f_1107_40332_40607(f_1107_40332_40539(f_1107_40332_40487(f_1107_40332_40448(f_1107_40332_40389(f_1107_40332_40354()), f_1107_40424_40447())), leftIndent: 4), @"Name")))), f_1107_40765_40792())), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[5])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 41181, 44006);

                listYield.Add(f_1107_41194_44005("DscResourceHelp", f_1107_41255_44004(f_1107_41255_43973(f_1107_41255_43940(f_1107_41255_43903(f_1107_41255_43819(f_1107_41255_43776(f_1107_41255_43731(f_1107_41255_43620(f_1107_41255_43575(f_1107_41255_43504(f_1107_41255_43461(f_1107_41255_43416(f_1107_41255_43301(f_1107_41255_43256(f_1107_41255_43182(f_1107_41255_43139(f_1107_41255_43094(f_1107_41255_42979(f_1107_41255_42934(f_1107_41255_42860(f_1107_41255_42808(f_1107_41255_42769(f_1107_41255_42700(f_1107_41255_42661(f_1107_41255_42624(f_1107_41255_42522(f_1107_41255_42470(f_1107_41255_42431(f_1107_41255_42364(f_1107_41255_42327(f_1107_41255_42229(f_1107_41255_42177(f_1107_41255_42138(f_1107_41255_42075(f_1107_41255_42038(f_1107_41255_41938(f_1107_41255_41886(f_1107_41255_41847(f_1107_41255_41782(f_1107_41255_41743(f_1107_41255_41706(f_1107_41255_41570(f_1107_41255_41518(f_1107_41255_41479(f_1107_41255_41405(f_1107_41255_41312(f_1107_41255_41277()), @"Details", customControl: control42), f_1107_41440_41478())), leftIndent: 4), @"description", enumerateCollection: true, customControl: sharedControls[6]))), f_1107_41817_41846())), leftIndent: 4), @"Properties", customControl: control43)), f_1107_42110_42137())), leftIndent: 4), @"Examples", customControl: control48)), f_1107_42399_42430())), leftIndent: 4), @"relatedLinks", customControl: control49))), f_1107_42735_42768())), leftIndent: 4), f_1107_42899_42933()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1107_43221_43255()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1107_43543_43574()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[10]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 36974, 44017);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_37132_37154()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37154);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37132_37189(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37189);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37132_37257(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37257);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37132_37371(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37371);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37132_37434(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37434);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37132_37473(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37473);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_37132_37506(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37506);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_37132_37537(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37132, 37537);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_37570_37592()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37570, 37592);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37570_37627(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37570, 37627);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37570_37754(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37570, 37754);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_37570_37787(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37570, 37787);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_37570_37818(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37570, 37818);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_37851_37873()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37851, 37873);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37851_37908(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37851, 37908);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_37851_38036(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37851, 38036);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_37851_38069(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37851, 38069);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_37851_38100(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 37851, 38100);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38133_38155()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38133, 38155);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38133_38190(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38133, 38190);
                    return return_v;
                }


                string
                f_1107_38225_38254()
                {
                    var return_v = HelpDisplayStrings.FalseShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 38225, 38254);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38133_38255(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38133, 38255);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38133_38288(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38133, 38288);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_38133_38319(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38133, 38319);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38352_38374()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38352, 38374);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38352_38409(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38352, 38409);
                    return return_v;
                }


                string
                f_1107_38444_38472()
                {
                    var return_v = HelpDisplayStrings.TrueShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 38444, 38472);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38352_38473(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38352, 38473);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38352_38506(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38352, 38506);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_38352_38537(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38352, 38537);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38570_38592()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38570, 38592);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38570_38627(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38570, 38627);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38570_38735(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38570, 38735);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38570_38768(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38570, 38768);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_38570_38799(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38570, 38799);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38832_38854()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 38854);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_38889(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 38889);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_38953(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 38953);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39061(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39061);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39100(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39100);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39152(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39152);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39288(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39288);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39410(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39410);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39453(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39453);
                    return return_v;
                }


                string
                f_1107_39492_39528()
                {
                    var return_v = HelpDisplayStrings.ParameterRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 39492, 39528);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39529(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39529);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39684(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39684);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39840(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39840);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39883(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39883);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39920(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39920);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_38832_39959(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39959);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_38832_39992(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 39992);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_38832_40023(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 38832, 40023);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_40056_40078()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40056, 40078);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40056_40113(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40056, 40113);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40056_40235(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40056, 40235);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_40056_40268(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40056, 40268);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_40056_40299(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40056, 40299);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_40332_40354()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40354);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40389(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40389);
                    return return_v;
                }


                string
                f_1107_40424_40447()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 40424, 40447);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40448(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40448);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40487(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40487);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40539(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40539);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40607(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40607);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40650(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40650);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40693(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40693);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40730(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40730);
                    return return_v;
                }


                string
                f_1107_40765_40792()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 40765, 40792);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40793(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40793);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40832(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40832);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_40884(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 40884);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_41020(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 41020);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_41063(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 41063);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_40332_41100(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 41100);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_40332_41133(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 41133);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_40332_41164(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 40332, 41164);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_41255_41277()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41277);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41312(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41312);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41405(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41405);
                    return return_v;
                }


                string
                f_1107_41440_41478()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 41440, 41478);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41479(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41479);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41518(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41518);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41570(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41570);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41706(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41706);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41743(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41743);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41782(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41782);
                    return return_v;
                }


                string
                f_1107_41817_41846()
                {
                    var return_v = HelpDisplayStrings.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 41817, 41846);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41847(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41847);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41886(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41886);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_41938(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 41938);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42038(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42038);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42075(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42075);
                    return return_v;
                }


                string
                f_1107_42110_42137()
                {
                    var return_v = HelpDisplayStrings.Examples;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 42110, 42137);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42138(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42138);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42177(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42177);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42229(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42229);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42327(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42327);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42364(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42364);
                    return return_v;
                }


                string
                f_1107_42399_42430()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 42399, 42430);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42431(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42431);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42470(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42470);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42522(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42522);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42624(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42624);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42661(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42661);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42700(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42700);
                    return return_v;
                }


                string
                f_1107_42735_42768()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 42735, 42768);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42769(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42769);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42808(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42808);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42860(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42860);
                    return return_v;
                }


                string
                f_1107_42899_42933()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 42899, 42933);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42934(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42934);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_42979(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 42979);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43094(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43094);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43139(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43139);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43182(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43182);
                    return return_v;
                }


                string
                f_1107_43221_43255()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 43221, 43255);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43256(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43256);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43301(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43301);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43416(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43416);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43461(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43461);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43504(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43504);
                    return return_v;
                }


                string
                f_1107_43543_43574()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 43543, 43574);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43575(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43575);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43620(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43620);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43731(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43731);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43776(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43776);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43819(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43819);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43903(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43903);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_41255_43940(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43940);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_41255_43973(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 43973);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_41255_44004(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41255, 44004);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_41194_44005(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 41194, 44005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 36974, 44017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 36974, 44017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_DscResourceHelpInfo_DetailedView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 44029, 49825);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 44175, 44597);

                var
                control56 = f_1107_44191_44596(f_1107_44191_44565(f_1107_44191_44532(f_1107_44191_44493(f_1107_44191_44430(f_1107_44191_44316(f_1107_44191_44248(f_1107_44191_44213()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 44613, 44878);

                var
                control55 = f_1107_44629_44877(f_1107_44629_44846(f_1107_44629_44813(f_1107_44629_44686(f_1107_44629_44651()), @"navigationLink", enumerateCollection: true, customControl: control56)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 44894, 45160);

                var
                control54 = f_1107_44910_45159(f_1107_44910_45128(f_1107_44910_45095(f_1107_44910_44967(f_1107_44910_44932()), @"Example", enumerateCollection: true, customControl: sharedControls[7])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 45176, 45832);

                var
                control53 = f_1107_45192_45831(f_1107_45192_45800(f_1107_45192_45767(f_1107_45192_45728(f_1107_45192_45691(f_1107_45192_45648(f_1107_45192_45512(f_1107_45192_45460(f_1107_45192_45421(f_1107_45192_45313(f_1107_45192_45249(f_1107_45192_45214()), @"name"), @"ParameterValue", customControl: sharedControls[3])), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[6]))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 45848, 46108);

                var
                control52 = f_1107_45864_46107(f_1107_45864_46076(f_1107_45864_46043(f_1107_45864_45921(f_1107_45864_45886()), @"Parameter", enumerateCollection: true, customControl: control53)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 46124, 46973);

                var
                control51 = f_1107_46140_46972(f_1107_46140_46941(f_1107_46140_46908(f_1107_46140_46871(f_1107_46140_46828(f_1107_46140_46692(f_1107_46140_46640(f_1107_46140_46601(f_1107_46140_46538(f_1107_46140_46501(f_1107_46140_46458(f_1107_46140_46415(f_1107_46140_46347(f_1107_46140_46295(f_1107_46140_46256(f_1107_46140_46197(f_1107_46140_46162()), f_1107_46232_46255())), leftIndent: 4), @"Name")))), f_1107_46573_46600())), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[5])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 46989, 49814);

                listYield.Add(f_1107_47002_49813("DscResourceHelp", f_1107_47063_49812(f_1107_47063_49781(f_1107_47063_49748(f_1107_47063_49711(f_1107_47063_49627(f_1107_47063_49584(f_1107_47063_49539(f_1107_47063_49428(f_1107_47063_49383(f_1107_47063_49312(f_1107_47063_49269(f_1107_47063_49224(f_1107_47063_49109(f_1107_47063_49064(f_1107_47063_48990(f_1107_47063_48947(f_1107_47063_48902(f_1107_47063_48787(f_1107_47063_48742(f_1107_47063_48668(f_1107_47063_48616(f_1107_47063_48577(f_1107_47063_48508(f_1107_47063_48469(f_1107_47063_48432(f_1107_47063_48330(f_1107_47063_48278(f_1107_47063_48239(f_1107_47063_48172(f_1107_47063_48135(f_1107_47063_48037(f_1107_47063_47985(f_1107_47063_47946(f_1107_47063_47883(f_1107_47063_47846(f_1107_47063_47746(f_1107_47063_47694(f_1107_47063_47655(f_1107_47063_47590(f_1107_47063_47551(f_1107_47063_47514(f_1107_47063_47378(f_1107_47063_47326(f_1107_47063_47287(f_1107_47063_47213(f_1107_47063_47120(f_1107_47063_47085()), @"Details", customControl: control51), f_1107_47248_47286())), leftIndent: 4), @"description", enumerateCollection: true, customControl: sharedControls[6]))), f_1107_47625_47654())), leftIndent: 4), @"Properties", customControl: control52)), f_1107_47918_47945())), leftIndent: 4), @"Examples", customControl: control54)), f_1107_48207_48238())), leftIndent: 4), @"relatedLinks", customControl: control55))), f_1107_48543_48576())), leftIndent: 4), f_1107_48707_48741()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1107_49029_49063()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1107_49351_49382()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[10]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 44029, 49825);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_44191_44213()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44213);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44191_44248(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44248);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44191_44316(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44316);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44191_44430(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44430);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44191_44493(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44493);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44191_44532(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44532);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_44191_44565(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44565);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_44191_44596(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44191, 44596);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_44629_44651()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44629, 44651);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44629_44686(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44629, 44686);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44629_44813(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44629, 44813);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_44629_44846(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44629, 44846);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_44629_44877(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44629, 44877);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_44910_44932()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44910, 44932);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44910_44967(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44910, 44967);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_44910_45095(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44910, 45095);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_44910_45128(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44910, 45128);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_44910_45159(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 44910, 45159);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_45192_45214()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45214);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45249(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45249);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45313(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45313);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45421(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45421);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45460(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45460);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45512(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45512);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45648(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45648);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45691(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45691);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45728(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45728);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45192_45767(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45767);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_45192_45800(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45800);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_45192_45831(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45192, 45831);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_45864_45886()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45864, 45886);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45864_45921(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45864, 45921);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_45864_46043(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45864, 46043);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_45864_46076(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45864, 46076);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_45864_46107(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 45864, 46107);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_46140_46162()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46162);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46197(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46197);
                    return return_v;
                }


                string
                f_1107_46232_46255()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 46232, 46255);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46256(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46256);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46295(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46295);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46347(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46347);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46415(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46415);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46458(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46458);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46501(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46501);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46538(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46538);
                    return return_v;
                }


                string
                f_1107_46573_46600()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 46573, 46600);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46601(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46601);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46640(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46640);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46692(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46692);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46828(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46828);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46871(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46871);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_46140_46908(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46908);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_46140_46941(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46941);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_46140_46972(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 46140, 46972);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_47063_47085()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47085);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47120(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47120);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47213(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47213);
                    return return_v;
                }


                string
                f_1107_47248_47286()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 47248, 47286);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47287(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47287);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47326(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47326);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47378(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47378);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47514(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47514);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47551(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47551);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47590(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47590);
                    return return_v;
                }


                string
                f_1107_47625_47654()
                {
                    var return_v = HelpDisplayStrings.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 47625, 47654);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47655(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47655);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47694(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47694);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47746(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47746);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47846(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47846);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47883(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47883);
                    return return_v;
                }


                string
                f_1107_47918_47945()
                {
                    var return_v = HelpDisplayStrings.Examples;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 47918, 47945);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47946(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47946);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_47985(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 47985);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48037(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48037);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48135(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48135);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48172(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48172);
                    return return_v;
                }


                string
                f_1107_48207_48238()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 48207, 48238);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48239(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48239);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48278(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48278);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48330(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48330);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48432(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48432);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48469(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48469);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48508(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48508);
                    return return_v;
                }


                string
                f_1107_48543_48576()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 48543, 48576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48577(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48577);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48616(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48616);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48668(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48668);
                    return return_v;
                }


                string
                f_1107_48707_48741()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 48707, 48741);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48742(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48742);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48787(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48787);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48902(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48902);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48947(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48947);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_48990(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 48990);
                    return return_v;
                }


                string
                f_1107_49029_49063()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 49029, 49063);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49064(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49064);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49109(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49109);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49224(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49224);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49269(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49269);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49312(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49312);
                    return return_v;
                }


                string
                f_1107_49351_49382()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 49351, 49382);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49383(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49383);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49428(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49428);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49539(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49539);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49584(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49584);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49627(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49627);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49711(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49711);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_47063_49748(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49748);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_47063_49781(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49781);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_47063_49812(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47063, 49812);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_47002_49813(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 47002, 49813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 44029, 49825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 44029, 49825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_DscResourceHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 49837, 53808);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 49970, 50392);

                var
                control59 = f_1107_49986_50391(f_1107_49986_50360(f_1107_49986_50327(f_1107_49986_50288(f_1107_49986_50225(f_1107_49986_50111(f_1107_49986_50043(f_1107_49986_50008()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 50408, 50673);

                var
                control58 = f_1107_50424_50672(f_1107_50424_50641(f_1107_50424_50608(f_1107_50424_50481(f_1107_50424_50446()), @"navigationLink", enumerateCollection: true, customControl: control59)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 50689, 51538);

                var
                control57 = f_1107_50705_51537(f_1107_50705_51506(f_1107_50705_51473(f_1107_50705_51436(f_1107_50705_51393(f_1107_50705_51257(f_1107_50705_51205(f_1107_50705_51166(f_1107_50705_51103(f_1107_50705_51066(f_1107_50705_51023(f_1107_50705_50980(f_1107_50705_50912(f_1107_50705_50860(f_1107_50705_50821(f_1107_50705_50762(f_1107_50705_50727()), f_1107_50797_50820())), leftIndent: 4), @"Name")))), f_1107_51138_51165())), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[5])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 51554, 53797);

                listYield.Add(f_1107_51567_53796("DscResourceHelp", f_1107_51628_53795(f_1107_51628_53764(f_1107_51628_53731(f_1107_51628_53694(f_1107_51628_53610(f_1107_51628_53567(f_1107_51628_53522(f_1107_51628_53411(f_1107_51628_53366(f_1107_51628_53295(f_1107_51628_53252(f_1107_51628_53207(f_1107_51628_53092(f_1107_51628_53047(f_1107_51628_52973(f_1107_51628_52930(f_1107_51628_52885(f_1107_51628_52770(f_1107_51628_52725(f_1107_51628_52651(f_1107_51628_52599(f_1107_51628_52560(f_1107_51628_52491(f_1107_51628_52452(f_1107_51628_52415(f_1107_51628_52313(f_1107_51628_52261(f_1107_51628_52222(f_1107_51628_52155(f_1107_51628_52116(f_1107_51628_52079(f_1107_51628_51943(f_1107_51628_51891(f_1107_51628_51852(f_1107_51628_51778(f_1107_51628_51685(f_1107_51628_51650()), @"Details", customControl: control57), f_1107_51813_51851())), leftIndent: 4), @"description", enumerateCollection: true, customControl: sharedControls[6]))), f_1107_52190_52221())), leftIndent: 4), @"relatedLinks", customControl: control58))), f_1107_52526_52559())), leftIndent: 4), f_1107_52690_52724()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1107_53012_53046()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1107_53334_53365()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[10]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 49837, 53808);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_49986_50008()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50008);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_49986_50043(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50043);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_49986_50111(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50111);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_49986_50225(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50225);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_49986_50288(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50288);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_49986_50327(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50327);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_49986_50360(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50360);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_49986_50391(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 49986, 50391);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_50424_50446()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50424, 50446);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50424_50481(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50424, 50481);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50424_50608(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50424, 50608);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_50424_50641(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50424, 50641);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_50424_50672(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50424, 50672);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_50705_50727()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50727);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_50762(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50762);
                    return return_v;
                }


                string
                f_1107_50797_50820()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 50797, 50820);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_50821(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50821);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_50860(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50860);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_50912(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50912);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_50980(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 50980);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51023(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51023);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51066(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51066);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51103(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51103);
                    return return_v;
                }


                string
                f_1107_51138_51165()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 51138, 51165);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51166(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51166);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51205(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51205);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51257(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51257);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51393(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51393);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51436(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51436);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_50705_51473(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51473);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_50705_51506(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51506);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_50705_51537(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 50705, 51537);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_51628_51650()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51650);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_51685(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51685);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_51778(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51778);
                    return return_v;
                }


                string
                f_1107_51813_51851()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 51813, 51851);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_51852(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51852);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_51891(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51891);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_51943(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 51943);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52079(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52079);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52116(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52116);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52155(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52155);
                    return return_v;
                }


                string
                f_1107_52190_52221()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 52190, 52221);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52222(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52222);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52261(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52261);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52313(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52313);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52415(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52415);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52452(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52452);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52491(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52491);
                    return return_v;
                }


                string
                f_1107_52526_52559()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 52526, 52559);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52560(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52560);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52599(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52599);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52651(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52651);
                    return return_v;
                }


                string
                f_1107_52690_52724()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 52690, 52724);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52725(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52725);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52770(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52770);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52885(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52885);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52930(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52930);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_52973(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 52973);
                    return return_v;
                }


                string
                f_1107_53012_53046()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 53012, 53046);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53047(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53047);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53092(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53092);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53207(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53207);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53252(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53252);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53295(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53295);
                    return return_v;
                }


                string
                f_1107_53334_53365()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 53334, 53365);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53366(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53366);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53411(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53411);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53522(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53522);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53567(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53567);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53610(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53610);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53694(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53694);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_51628_53731(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53731);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_51628_53764(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53764);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_51628_53795(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51628, 53795);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_51567_53796(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 51567, 53796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 49837, 53808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 49837, 53808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_PSClassHelpInfo_FullView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 53820, 59632);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 53958, 54380);

                var
                control68 = f_1107_53974_54379(f_1107_53974_54348(f_1107_53974_54315(f_1107_53974_54276(f_1107_53974_54213(f_1107_53974_54099(f_1107_53974_54031(f_1107_53974_53996()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 54396, 54661);

                var
                control67 = f_1107_54412_54660(f_1107_54412_54629(f_1107_54412_54596(f_1107_54412_54469(f_1107_54412_54434()), @"navigationLink", enumerateCollection: true, customControl: control68)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 54677, 54943);

                var
                control66 = f_1107_54693_54942(f_1107_54693_54911(f_1107_54693_54878(f_1107_54693_54750(f_1107_54693_54715()), @"Example", enumerateCollection: true, customControl: sharedControls[7])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 54959, 55176);

                var
                control65 = f_1107_54975_55175(f_1107_54975_55144(f_1107_54975_55111(f_1107_54975_55032(f_1107_54975_54997()), sharedControls[9])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 55192, 55449);

                var
                control64 = f_1107_55208_55448(f_1107_55208_55417(f_1107_55208_55384(f_1107_55208_55265(f_1107_55208_55230()), @"member", enumerateCollection: true, customControl: control65)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 55465, 55682);

                var
                control63 = f_1107_55481_55681(f_1107_55481_55650(f_1107_55481_55617(f_1107_55481_55538(f_1107_55481_55503()), sharedControls[8])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 55698, 55955);

                var
                control62 = f_1107_55714_55954(f_1107_55714_55923(f_1107_55714_55890(f_1107_55714_55771(f_1107_55714_55736()), @"member", enumerateCollection: true, customControl: control63)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 55971, 59341);

                var
                control61 = f_1107_55987_59340(f_1107_55987_59309(f_1107_55987_59276(f_1107_55987_59239(f_1107_55987_59155(f_1107_55987_59112(f_1107_55987_59067(f_1107_55987_58956(f_1107_55987_58911(f_1107_55987_58840(f_1107_55987_58797(f_1107_55987_58752(f_1107_55987_58637(f_1107_55987_58592(f_1107_55987_58518(f_1107_55987_58475(f_1107_55987_58430(f_1107_55987_58315(f_1107_55987_58270(f_1107_55987_58196(f_1107_55987_58144(f_1107_55987_58105(f_1107_55987_58036(f_1107_55987_57997(f_1107_55987_57960(f_1107_55987_57858(f_1107_55987_57806(f_1107_55987_57767(f_1107_55987_57700(f_1107_55987_57663(f_1107_55987_57565(f_1107_55987_57513(f_1107_55987_57474(f_1107_55987_57411(f_1107_55987_57372(f_1107_55987_57335(f_1107_55987_57238(f_1107_55987_57186(f_1107_55987_57147(f_1107_55987_57085(f_1107_55987_57046(f_1107_55987_57009(f_1107_55987_56912(f_1107_55987_56860(f_1107_55987_56821(f_1107_55987_56756(f_1107_55987_56719(f_1107_55987_56676(f_1107_55987_56539(f_1107_55987_56487(f_1107_55987_56448(f_1107_55987_56385(f_1107_55987_56348(f_1107_55987_56305(f_1107_55987_56262(f_1107_55987_56194(f_1107_55987_56142(f_1107_55987_56103(f_1107_55987_56044(f_1107_55987_56009()), f_1107_56079_56102())), leftIndent: 4), @"Name")))), f_1107_56420_56447())), leftIndent: 4), @"Introduction", enumerateCollection: true, customControl: sharedControls[5]))), f_1107_56791_56820())), leftIndent: 4), @"members", customControl: control62))), f_1107_57120_57146())), leftIndent: 4), @"members", customControl: control64))), f_1107_57446_57473())), leftIndent: 4), @"Examples", customControl: control66)), f_1107_57735_57766())), leftIndent: 4), @"relatedLinks", customControl: control67))), f_1107_58071_58104())), leftIndent: 4), f_1107_58235_58269()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1107_58557_58591()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1107_58879_58910()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[10]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 59357, 59621);

                listYield.Add(f_1107_59370_59620("PSClassHelp", f_1107_59427_59619(f_1107_59427_59588(f_1107_59427_59555(f_1107_59427_59484(f_1107_59427_59449()), control61)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 53820, 59632);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_53974_53996()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 53996);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_53974_54031(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54031);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_53974_54099(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54099);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_53974_54213(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54213);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_53974_54276(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54276);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_53974_54315(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54315);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_53974_54348(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54348);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_53974_54379(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 53974, 54379);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54412_54434()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54412, 54434);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54412_54469(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54412, 54469);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54412_54596(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54412, 54596);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54412_54629(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54412, 54629);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_54412_54660(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54412, 54660);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54693_54715()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54693, 54715);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54693_54750(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54693, 54750);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54693_54878(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54693, 54878);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54693_54911(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54693, 54911);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_54693_54942(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54693, 54942);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54975_54997()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54975, 54997);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54975_55032(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54975, 55032);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_54975_55111(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54975, 55111);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_54975_55144(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54975, 55144);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_54975_55175(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 54975, 55175);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55208_55230()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55208, 55230);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55208_55265(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55208, 55265);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55208_55384(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55208, 55384);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55208_55417(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55208, 55417);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_55208_55448(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55208, 55448);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55481_55503()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55481, 55503);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55481_55538(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55481, 55538);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55481_55617(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55481, 55617);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55481_55650(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55481, 55650);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_55481_55681(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55481, 55681);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55714_55736()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55714, 55736);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55714_55771(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55714, 55771);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55714_55890(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55714, 55890);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55714_55923(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55714, 55923);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_55714_55954(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55714, 55954);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55987_56009()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56009);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56044(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56044);
                    return return_v;
                }


                string
                f_1107_56079_56102()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 56079, 56102);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56103(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56103);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56142(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56142);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56194(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56194);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56262(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56262);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56305(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56305);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56348(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56348);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56385(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56385);
                    return return_v;
                }


                string
                f_1107_56420_56447()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 56420, 56447);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56448(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56448);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56487(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56487);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56539(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56539);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56676(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56676);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56719(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56719);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56756(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56756);
                    return return_v;
                }


                string
                f_1107_56791_56820()
                {
                    var return_v = HelpDisplayStrings.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 56791, 56820);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56821(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56821);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56860(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56860);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_56912(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 56912);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57009(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57009);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57046(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57046);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57085(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57085);
                    return return_v;
                }


                string
                f_1107_57120_57146()
                {
                    var return_v = HelpDisplayStrings.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 57120, 57146);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57147(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57147);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57186(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57186);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57238(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57238);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57335(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57335);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57372(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57372);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57411(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57411);
                    return return_v;
                }


                string
                f_1107_57446_57473()
                {
                    var return_v = HelpDisplayStrings.Examples;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 57446, 57473);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57474(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57474);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57513(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57513);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57565(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57565);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57663(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57663);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57700(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57700);
                    return return_v;
                }


                string
                f_1107_57735_57766()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 57735, 57766);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57767(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57767);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57806(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57806);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57858(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57858);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57960(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57960);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_57997(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 57997);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58036(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58036);
                    return return_v;
                }


                string
                f_1107_58071_58104()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 58071, 58104);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58105(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58105);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58144(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58144);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58196(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58196);
                    return return_v;
                }


                string
                f_1107_58235_58269()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 58235, 58269);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58270(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58270);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58315(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58315);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58430(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58430);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58475(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58475);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58518(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58518);
                    return return_v;
                }


                string
                f_1107_58557_58591()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 58557, 58591);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58592(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58592);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58637(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58637);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58752(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58752);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58797(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58797);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58840(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58840);
                    return return_v;
                }


                string
                f_1107_58879_58910()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 58879, 58910);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58911(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58911);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_58956(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 58956);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_59067(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59067);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_59112(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59112);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_59155(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59155);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_59239(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59239);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_55987_59276(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59276);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_55987_59309(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59309);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_55987_59340(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 55987, 59340);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_59427_59449()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59427, 59449);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59427_59484(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59427, 59484);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59427_59555(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59427, 59555);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_59427_59588(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59427, 59588);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_59427_59619(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59427, 59619);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_59370_59620(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59370, 59620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 53820, 59632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 53820, 59632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_PSClassHelpInfo_DetailedView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 59644, 65460);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 59786, 60208);

                var
                control77 = f_1107_59802_60207(f_1107_59802_60176(f_1107_59802_60143(f_1107_59802_60104(f_1107_59802_60041(f_1107_59802_59927(f_1107_59802_59859(f_1107_59802_59824()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 60224, 60489);

                var
                control76 = f_1107_60240_60488(f_1107_60240_60457(f_1107_60240_60424(f_1107_60240_60297(f_1107_60240_60262()), @"navigationLink", enumerateCollection: true, customControl: control77)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 60505, 60771);

                var
                control75 = f_1107_60521_60770(f_1107_60521_60739(f_1107_60521_60706(f_1107_60521_60578(f_1107_60521_60543()), @"Example", enumerateCollection: true, customControl: sharedControls[7])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 60787, 61004);

                var
                control74 = f_1107_60803_61003(f_1107_60803_60972(f_1107_60803_60939(f_1107_60803_60860(f_1107_60803_60825()), sharedControls[9])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 61020, 61277);

                var
                control73 = f_1107_61036_61276(f_1107_61036_61245(f_1107_61036_61212(f_1107_61036_61093(f_1107_61036_61058()), @"member", enumerateCollection: true, customControl: control74)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 61293, 61510);

                var
                control72 = f_1107_61309_61509(f_1107_61309_61478(f_1107_61309_61445(f_1107_61309_61366(f_1107_61309_61331()), sharedControls[8])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 61526, 61783);

                var
                control71 = f_1107_61542_61782(f_1107_61542_61751(f_1107_61542_61718(f_1107_61542_61599(f_1107_61542_61564()), @"member", enumerateCollection: true, customControl: control72)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 61799, 65169);

                var
                control70 = f_1107_61815_65168(f_1107_61815_65137(f_1107_61815_65104(f_1107_61815_65067(f_1107_61815_64983(f_1107_61815_64940(f_1107_61815_64895(f_1107_61815_64784(f_1107_61815_64739(f_1107_61815_64668(f_1107_61815_64625(f_1107_61815_64580(f_1107_61815_64465(f_1107_61815_64420(f_1107_61815_64346(f_1107_61815_64303(f_1107_61815_64258(f_1107_61815_64143(f_1107_61815_64098(f_1107_61815_64024(f_1107_61815_63972(f_1107_61815_63933(f_1107_61815_63864(f_1107_61815_63825(f_1107_61815_63788(f_1107_61815_63686(f_1107_61815_63634(f_1107_61815_63595(f_1107_61815_63528(f_1107_61815_63491(f_1107_61815_63393(f_1107_61815_63341(f_1107_61815_63302(f_1107_61815_63239(f_1107_61815_63200(f_1107_61815_63163(f_1107_61815_63066(f_1107_61815_63014(f_1107_61815_62975(f_1107_61815_62913(f_1107_61815_62874(f_1107_61815_62837(f_1107_61815_62740(f_1107_61815_62688(f_1107_61815_62649(f_1107_61815_62584(f_1107_61815_62547(f_1107_61815_62504(f_1107_61815_62367(f_1107_61815_62315(f_1107_61815_62276(f_1107_61815_62213(f_1107_61815_62176(f_1107_61815_62133(f_1107_61815_62090(f_1107_61815_62022(f_1107_61815_61970(f_1107_61815_61931(f_1107_61815_61872(f_1107_61815_61837()), f_1107_61907_61930())), leftIndent: 4), @"Name")))), f_1107_62248_62275())), leftIndent: 4), @"Introduction", enumerateCollection: true, customControl: sharedControls[5]))), f_1107_62619_62648())), leftIndent: 4), @"members", customControl: control71))), f_1107_62948_62974())), leftIndent: 4), @"members", customControl: control73))), f_1107_63274_63301())), leftIndent: 4), @"Examples", customControl: control75)), f_1107_63563_63594())), leftIndent: 4), @"relatedLinks", customControl: control76))), f_1107_63899_63932())), leftIndent: 4), f_1107_64063_64097()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1107_64385_64419()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1107_64707_64738()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[10]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 65185, 65449);

                listYield.Add(f_1107_65198_65448("PSClassHelp", f_1107_65255_65447(f_1107_65255_65416(f_1107_65255_65383(f_1107_65255_65312(f_1107_65255_65277()), control70)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 59644, 65460);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_59802_59824()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 59824);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59802_59859(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 59859);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59802_59927(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 59927);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59802_60041(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 60041);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59802_60104(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 60104);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_59802_60143(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 60143);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_59802_60176(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 60176);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_59802_60207(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 59802, 60207);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60240_60262()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60240, 60262);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60240_60297(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60240, 60297);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60240_60424(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60240, 60424);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60240_60457(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60240, 60457);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_60240_60488(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60240, 60488);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60521_60543()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60521, 60543);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60521_60578(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60521, 60578);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60521_60706(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60521, 60706);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60521_60739(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60521, 60739);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_60521_60770(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60521, 60770);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60803_60825()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60803, 60825);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60803_60860(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60803, 60860);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_60803_60939(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60803, 60939);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_60803_60972(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60803, 60972);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_60803_61003(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 60803, 61003);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61036_61058()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61036, 61058);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61036_61093(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61036, 61093);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61036_61212(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61036, 61212);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61036_61245(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61036, 61245);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_61036_61276(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61036, 61276);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61309_61331()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61309, 61331);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61309_61366(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61309, 61366);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61309_61445(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61309, 61445);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61309_61478(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61309, 61478);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_61309_61509(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61309, 61509);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61542_61564()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61542, 61564);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61542_61599(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61542, 61599);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61542_61718(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61542, 61718);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61542_61751(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61542, 61751);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_61542_61782(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61542, 61782);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61815_61837()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 61837);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_61872(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 61872);
                    return return_v;
                }


                string
                f_1107_61907_61930()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 61907, 61930);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_61931(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 61931);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_61970(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 61970);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62022(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62022);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62090(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62090);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62133(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62133);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62176(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62176);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62213(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62213);
                    return return_v;
                }


                string
                f_1107_62248_62275()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 62248, 62275);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62276(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62276);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62315(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62315);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62367(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62367);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62504(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62504);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62547(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62547);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62584(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62584);
                    return return_v;
                }


                string
                f_1107_62619_62648()
                {
                    var return_v = HelpDisplayStrings.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 62619, 62648);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62649(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62649);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62688(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62688);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62740(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62740);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62837(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62837);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62874(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62874);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62913(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62913);
                    return return_v;
                }


                string
                f_1107_62948_62974()
                {
                    var return_v = HelpDisplayStrings.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 62948, 62974);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_62975(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 62975);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63014(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63014);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63066(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63066);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63163(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63163);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63200(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63200);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63239(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63239);
                    return return_v;
                }


                string
                f_1107_63274_63301()
                {
                    var return_v = HelpDisplayStrings.Examples;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 63274, 63301);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63302(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63302);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63341(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63341);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63393(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63393);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63491(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63491);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63528(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63528);
                    return return_v;
                }


                string
                f_1107_63563_63594()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 63563, 63594);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63595(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63595);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63634(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63634);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63686(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63686);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63788(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63788);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63825(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63825);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63864(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63864);
                    return return_v;
                }


                string
                f_1107_63899_63932()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 63899, 63932);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63933(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63933);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_63972(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 63972);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64024(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64024);
                    return return_v;
                }


                string
                f_1107_64063_64097()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 64063, 64097);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64098(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64098);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64143(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64143);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64258(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64258);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64303(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64303);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64346(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64346);
                    return return_v;
                }


                string
                f_1107_64385_64419()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 64385, 64419);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64420(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64420);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64465(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64465);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64580(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64580);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64625(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64625);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64668(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64668);
                    return return_v;
                }


                string
                f_1107_64707_64738()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 64707, 64738);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64739(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64739);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64784(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64784);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64895(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64895);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64940(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64940);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_64983(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 64983);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_65067(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 65067);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_61815_65104(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 65104);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_61815_65137(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 65137);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_61815_65168(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 61815, 65168);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_65255_65277()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65255, 65277);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65255_65312(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65255, 65312);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65255_65383(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65255, 65383);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_65255_65416(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65255, 65416);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_65255_65447(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65255, 65447);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_65198_65448(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65198, 65448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 59644, 65460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 59644, 65460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_PSClassHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1107, 65472, 69052);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 65601, 66023);

                var
                control81 = f_1107_65617_66022(f_1107_65617_65991(f_1107_65617_65958(f_1107_65617_65919(f_1107_65617_65856(f_1107_65617_65742(f_1107_65617_65674(f_1107_65617_65639()), @"linkText"), @""" """, selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 66039, 66304);

                var
                control80 = f_1107_66055_66303(f_1107_66055_66272(f_1107_66055_66239(f_1107_66055_66112(f_1107_66055_66077()), @"navigationLink", enumerateCollection: true, customControl: control81)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 66320, 67170);

                var
                control79 = f_1107_66336_67169(f_1107_66336_67138(f_1107_66336_67105(f_1107_66336_67068(f_1107_66336_67025(f_1107_66336_66888(f_1107_66336_66836(f_1107_66336_66797(f_1107_66336_66734(f_1107_66336_66697(f_1107_66336_66654(f_1107_66336_66611(f_1107_66336_66543(f_1107_66336_66491(f_1107_66336_66452(f_1107_66336_66393(f_1107_66336_66358()), f_1107_66428_66451())), leftIndent: 4), @"Name")))), f_1107_66769_66796())), leftIndent: 4), @"Introduction", enumerateCollection: true, customControl: sharedControls[5])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1107, 67186, 69041);

                listYield.Add(f_1107_67199_69040("PSClassHelp", f_1107_67256_69039(f_1107_67256_69008(f_1107_67256_68975(f_1107_67256_68938(f_1107_67256_68854(f_1107_67256_68811(f_1107_67256_68766(f_1107_67256_68663(f_1107_67256_68618(f_1107_67256_68547(f_1107_67256_68504(f_1107_67256_68459(f_1107_67256_68352(f_1107_67256_68307(f_1107_67256_68233(f_1107_67256_68190(f_1107_67256_68145(f_1107_67256_68038(f_1107_67256_67993(f_1107_67256_67919(f_1107_67256_67867(f_1107_67256_67828(f_1107_67256_67759(f_1107_67256_67720(f_1107_67256_67683(f_1107_67256_67581(f_1107_67256_67529(f_1107_67256_67490(f_1107_67256_67423(f_1107_67256_67384(f_1107_67256_67313(f_1107_67256_67278()), control79)), f_1107_67458_67489())), leftIndent: 4), @"relatedLinks", customControl: control80))), f_1107_67794_67827())), leftIndent: 4), f_1107_67958_67992()), @""""), @"""Get-Help "" + $_.Name + "" -Examples"""), @"""")), f_1107_68272_68306()), @""""), @"""Get-Help "" + $_.Name + "" -Detailed"""), @"""")), f_1107_68586_68617()), @""""), @"""Get-Help "" + $_.Name + "" -Full"""), @"""")), sharedControls[10]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1107, 65472, 69052);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1107_65617_65639()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65639);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65617_65674(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65674);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65617_65742(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65742);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65617_65856(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65856);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65617_65919(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65919);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_65617_65958(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65958);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_65617_65991(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 65991);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_65617_66022(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 65617, 66022);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_66055_66077()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66055, 66077);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66055_66112(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66055, 66112);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66055_66239(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66055, 66239);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_66055_66272(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66055, 66272);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_66055_66303(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66055, 66303);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_66336_66358()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66358);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66393(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66393);
                    return return_v;
                }


                string
                f_1107_66428_66451()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 66428, 66451);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66452(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66452);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66491(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66491);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66543(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66543);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66611(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66611);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66654(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66654);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66697(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66697);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66734(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66734);
                    return return_v;
                }


                string
                f_1107_66769_66796()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 66769, 66796);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66797(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66797);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66836(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66836);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_66888(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 66888);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_67025(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 67025);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_67068(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 67068);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_66336_67105(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 67105);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_66336_67138(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 67138);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_66336_67169(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 66336, 67169);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_67256_67278()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67278);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67313(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67313);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67384(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67384);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67423(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67423);
                    return return_v;
                }


                string
                f_1107_67458_67489()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 67458, 67489);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67490(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67490);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67529(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67529);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67581(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67581);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67683(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67683);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67720(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67720);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67759(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67759);
                    return return_v;
                }


                string
                f_1107_67794_67827()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 67794, 67827);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67828(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67828);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67867(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67867);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67919(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67919);
                    return return_v;
                }


                string
                f_1107_67958_67992()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 67958, 67992);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_67993(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 67993);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68038(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68038);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68145(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68145);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68190(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68190);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68233(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68233);
                    return return_v;
                }


                string
                f_1107_68272_68306()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 68272, 68306);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68307(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68307);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68352(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68352);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68459(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68459);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68504(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68504);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68547(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68547);
                    return return_v;
                }


                string
                f_1107_68586_68617()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1107, 68586, 68617);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68618(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68618);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68663(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68663);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68766(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68766);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68811(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68811);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68854(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68854);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68938(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68938);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1107_67256_68975(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 68975);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1107_67256_69008(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 69008);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1107_67256_69039(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67256, 69039);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1107_67199_69040(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1107, 67199, 69040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1107, 65472, 69052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 65472, 69052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public HelpV3_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1107, 240, 69059);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1107, 240, 69059);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 240, 69059);
        }


        static HelpV3_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1107, 240, 69059);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1107, 240, 69059);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1107, 240, 69059);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1107, 240, 69059);
    }
}
