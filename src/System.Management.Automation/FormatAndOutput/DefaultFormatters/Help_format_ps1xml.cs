// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Runspaces
{
    internal sealed class Help_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 297, 25062);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 389, 601);

                var
                TextPropertyControl = f_1108_415_600(f_1108_415_569(f_1108_415_536(f_1108_415_472(f_1108_415_437()), @"Text")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 617, 1032);

                var
                MamlShortDescriptionControl = f_1108_651_1031(f_1108_651_1000(f_1108_651_967(f_1108_651_928(f_1108_651_893(f_1108_651_860(f_1108_651_821(f_1108_651_757(f_1108_651_673(), entrySelectedByType: new[] { "MamlParaTextItem" }), @"Text")))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 1048, 2686);

                var
                MamlDescriptionControl = f_1108_1077_2685(f_1108_1077_2654(f_1108_1077_2621(f_1108_1077_2582(f_1108_1077_2547(f_1108_1077_2514(f_1108_1077_2477(f_1108_1077_2434(f_1108_1077_2360(f_1108_1077_2308(f_1108_1077_2269(f_1108_1077_2205(f_1108_1077_2115(f_1108_1077_2082(f_1108_1077_2045(f_1108_1077_2002(f_1108_1077_1934(f_1108_1077_1867(f_1108_1077_1809(f_1108_1077_1716(f_1108_1077_1683(f_1108_1077_1646(f_1108_1077_1603(f_1108_1077_1535(f_1108_1077_1468(f_1108_1077_1410(f_1108_1077_1319(f_1108_1077_1286(f_1108_1077_1247(f_1108_1077_1183(f_1108_1077_1099(), entrySelectedByType: new[] { "MamlParaTextItem" }), @"Text"))), entrySelectedByType: new[] { "MamlOrderedListTextItem" }), firstLineHanging: 4), @"Tag"), @"Text")))), entrySelectedByType: new[] { "MamlUnorderedListTextItem" }), firstLineHanging: 2), @"Tag"), @"Text")))), entrySelectedByType: new[] { "MamlDefinitionTextItem" }), @"Term")), leftIndent: 4), @"Definition"))))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 2702, 3542);

                var
                MamlParameterControl = f_1108_2729_3541(f_1108_2729_3510(f_1108_2729_3477(f_1108_2729_2786(f_1108_2729_2751()), @"$optional = $_.required -ne 'true'
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 3558, 3837);

                var
                MamlParameterValueControl = f_1108_3590_3836(f_1108_3590_3805(f_1108_3590_3772(f_1108_3590_3647(f_1108_3590_3612()), @"if ($_.required -ne 'true') { "" [<$_>]"" } else { "" <$_>"" }")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 3853, 5452);

                var
                MamlTextItem = f_1108_3872_5451(f_1108_3872_5420(f_1108_3872_5387(f_1108_3872_5348(f_1108_3872_5313(f_1108_3872_5280(f_1108_3872_5216(f_1108_3872_5124(f_1108_3872_5091(f_1108_3872_5052(f_1108_3872_5015(f_1108_3872_4941(f_1108_3872_4889(f_1108_3872_4850(f_1108_3872_4786(f_1108_3872_4696(f_1108_3872_4663(f_1108_3872_4624(f_1108_3872_4560(f_1108_3872_4497(f_1108_3872_4404(f_1108_3872_4371(f_1108_3872_4332(f_1108_3872_4268(f_1108_3872_4205(f_1108_3872_4114(f_1108_3872_4081(f_1108_3872_4042(f_1108_3872_3978(f_1108_3872_3894(), entrySelectedByType: new[] { "MamlParaTextItem" }), @"Text"))), entrySelectedByType: new[] { "MamlOrderedListTextItem" }), @"Tag"), @"Text"))), entrySelectedByType: new[] { "MamlUnorderedListTextItem" }), @"Tag"), @"Text"))), entrySelectedByType: new[] { "MamlDefinitionTextItem" }), @"Term")), leftIndent: 4), @"Definition")))), entrySelectedByType: new[] { "MamlPreformattedTextItem" }), @"Text"))), " ")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 5468, 5716);

                var
                MamlAlertControl = f_1108_5491_5715(f_1108_5491_5684(f_1108_5491_5651(f_1108_5491_5612(f_1108_5491_5548(f_1108_5491_5513()), @"Text"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 5732, 5934);

                var
                control4 = f_1108_5747_5933(f_1108_5747_5902(f_1108_5747_5869(f_1108_5747_5804(f_1108_5747_5769()), f_1108_5839_5868())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 5950, 6151);

                var
                control3 = f_1108_5965_6150(f_1108_5965_6119(f_1108_5965_6086(f_1108_5965_6022(f_1108_5965_5987()), f_1108_6057_6085())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 6167, 6672);

                var
                MamlTrueFalseShortControl = f_1108_6199_6671(f_1108_6199_6640(f_1108_6199_6607(f_1108_6199_6431(f_1108_6199_6256(f_1108_6199_6221()), @";", selectedByScript: @"$_.Equals('true', [System.StringComparison]::OrdinalIgnoreCase)", customControl: control3), @";", selectedByScript: @"$_.Equals('false', [System.StringComparison]::OrdinalIgnoreCase)", customControl: control4)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 6688, 7274);

                var
                RelatedLinksHelpInfoControl = f_1108_6722_7273(f_1108_6722_7242(f_1108_6722_7209(f_1108_6722_7172(f_1108_6722_6831(f_1108_6722_6779(f_1108_6722_6744()), leftIndent: 4), f_1108_6894_7171(@"Set-StrictMode -Off
if (($_.relatedLinks -ne $()) -and ($_.relatedLinks.navigationLink -ne $()) -and ($_.relatedLinks.navigationLink.Length -ne 0))
{{
    ""    {0}`""Get-Help $($_.Details.Name) -Online`""""
}}", f_1108_7131_7170())))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 7290, 7708);

                var
                control6 = f_1108_7305_7707(f_1108_7305_7676(f_1108_7305_7643(f_1108_7305_7604(f_1108_7305_7541(f_1108_7305_7430(f_1108_7305_7362(f_1108_7305_7327()), @"linkText"), "' '", selectedByScript: "$_.linkText.Length -ne 0"), @"uri"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 7724, 8002);

                var
                MamlRelatedLinksControl = f_1108_7754_8001(f_1108_7754_7970(f_1108_7754_7937(f_1108_7754_7811(f_1108_7754_7776()), @"navigationLink", enumerateCollection: true, customControl: control6)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 8018, 8929);

                var
                MamlDetailsControl = f_1108_8043_8928(f_1108_8043_8897(f_1108_8043_8864(f_1108_8043_8827(f_1108_8043_8784(f_1108_8043_8741(f_1108_8043_8595(f_1108_8043_8543(f_1108_8043_8504(f_1108_8043_8441(f_1108_8043_8404(f_1108_8043_8361(f_1108_8043_8318(f_1108_8043_8250(f_1108_8043_8198(f_1108_8043_8159(f_1108_8043_8100(f_1108_8043_8065()), f_1108_8135_8158())), leftIndent: 4), @"Name")))), f_1108_8476_8503())), leftIndent: 4), @"Description", enumerateCollection: true, customControl: MamlShortDescriptionControl))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 8945, 9744);

                var
                MamlExampleControl = f_1108_8970_9743(f_1108_8970_9712(f_1108_8970_9679(f_1108_8970_9541(f_1108_8970_9502(f_1108_8970_9435(f_1108_8970_9396(f_1108_8970_9305(f_1108_8970_9170(f_1108_8970_9131(f_1108_8970_9092(f_1108_8970_9027(f_1108_8970_8992()), @"Title"))), @"Introduction", enumerateCollection: true, customControl: TextPropertyControl), @"Code", enumerateCollection: true)), @"results")), @"remarks", enumerateCollection: true, customControl: MamlShortDescriptionControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 9760, 10132);

                var
                control1 = f_1108_9775_10131(f_1108_9775_10100(f_1108_9775_10067(f_1108_9775_10030(f_1108_9775_9884(f_1108_9775_9832(f_1108_9775_9797()), leftIndent: 4), @"description", enumerateCollection: true, customControl: MamlShortDescriptionControl))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 10148, 10523);

                var
                control0 = f_1108_10163_10522(f_1108_10163_10491(f_1108_10163_10458(f_1108_10163_10421(f_1108_10163_10378(f_1108_10163_10311(f_1108_10163_10259(f_1108_10163_10220(f_1108_10163_10185())), leftIndent: 4), @"uri")))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 10539, 10978);

                var
                MamlTypeControl = f_1108_10561_10977(f_1108_10561_10946(f_1108_10561_10913(f_1108_10561_10807(f_1108_10561_10709(f_1108_10561_10618(f_1108_10561_10583()), @"name", enumerateCollection: true), control0, selectedByScript: "$_.uri"), control1, selectedByScript: "$_.description")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 10994, 11509);

                var
                control2 = f_1108_11009_11508(f_1108_11009_11477(f_1108_11009_11444(f_1108_11009_11405(f_1108_11009_11368(f_1108_11009_11222(f_1108_11009_11170(f_1108_11009_11131(f_1108_11009_11066(f_1108_11009_11031()), @"Value")), leftIndent: 4), @"Description", enumerateCollection: true, customControl: MamlShortDescriptionControl)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 11525, 11803);

                var
                MamlPossibleValueControl = f_1108_11556_11802(f_1108_11556_11771(f_1108_11556_11738(f_1108_11556_11613(f_1108_11556_11578()), @"possibleValue", enumerateCollection: true, customControl: control2)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 11819, 12403);

                var
                MamlIndentedDescriptionControl = f_1108_11856_12402(f_1108_11856_12371(f_1108_11856_12338(f_1108_11856_12299(f_1108_11856_12262(f_1108_11856_12219(f_1108_11856_12078(f_1108_11856_12026(f_1108_11856_11987(f_1108_11856_11913(f_1108_11856_11878()), f_1108_11948_11986())), leftIndent: 4), @"description", enumerateCollection: true, customControl: MamlDescriptionControl))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 12419, 12915);

                var
                control5 = f_1108_12434_12914(f_1108_12434_12883(f_1108_12434_12850(f_1108_12434_12810(f_1108_12434_12727(f_1108_12434_12594(f_1108_12434_12555(f_1108_12434_12491(f_1108_12434_12456()), @"name"), " "), @"Parameter", enumerateCollection: true, customControl: MamlParameterControl), "[" + f_1108_12768_12803() + "]"), 2)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 12931, 13199);

                var
                MamlSyntaxControl = f_1108_12955_13198(f_1108_12955_13167(f_1108_12955_13134(f_1108_12955_13012(f_1108_12955_12977()), @"SyntaxItem", enumerateCollection: true, customControl: control5)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 13215, 13488);

                var
                ExamplesControl = f_1108_13237_13487(f_1108_13237_13456(f_1108_13237_13423(f_1108_13237_13294(f_1108_13237_13259()), @"Example", enumerateCollection: true, customControl: MamlExampleControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 13504, 14072);

                var
                MamlTypeWithDescriptionControl = f_1108_13541_14071(f_1108_13541_14040(f_1108_13541_14007(f_1108_13541_13968(f_1108_13541_13931(f_1108_13541_13785(f_1108_13541_13733(f_1108_13541_13694(f_1108_13541_13598(f_1108_13541_13563()), @"type", customControl: MamlTypeControl)), leftIndent: 4), @"description", enumerateCollection: true, customControl: MamlShortDescriptionControl)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 14088, 15502);

                var
                ErrorControl = f_1108_14107_15501(f_1108_14107_15470(f_1108_14107_15437(f_1108_14107_15398(f_1108_14107_15359(f_1108_14107_15211(f_1108_14107_15136(f_1108_14107_15097(f_1108_14107_14989(f_1108_14107_14913(f_1108_14107_14874(f_1108_14107_14778(f_1108_14107_14714(f_1108_14107_14675(f_1108_14107_14638(f_1108_14107_14492(f_1108_14107_14440(f_1108_14107_14401(f_1108_14107_14362(f_1108_14107_14294(f_1108_14107_14231(f_1108_14107_14164(f_1108_14107_14129()), @"errorId"), f_1108_14266_14293()), @"category"), ")")), leftIndent: 4), @"description", enumerateCollection: true, customControl: MamlShortDescriptionControl))), f_1108_14749_14777()), @"type", customControl: MamlTypeControl)), f_1108_14948_14988()), @"targetObjectType", customControl: MamlTypeControl)), f_1108_15171_15210()), @"recommendedAction", enumerateCollection: true, customControl: MamlShortDescriptionControl)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 15518, 15787);

                var
                MamlPossibleValuesControl = f_1108_15550_15786(f_1108_15550_15755(f_1108_15550_15722(f_1108_15550_15607(f_1108_15550_15572()), @"possibleValues", customControl: MamlPossibleValueControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 15803, 16293);

                var
                MamlIndentedSyntaxControl = f_1108_15835_16292(f_1108_15835_16261(f_1108_15835_16228(f_1108_15835_16191(f_1108_15835_16148(f_1108_15835_16044(f_1108_15835_15992(f_1108_15835_15953(f_1108_15835_15892(f_1108_15835_15857()), f_1108_15927_15952())), leftIndent: 4), @"Syntax", customControl: MamlSyntaxControl)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 16309, 16515);

                var
                control7 = f_1108_16324_16514(f_1108_16324_16483(f_1108_16324_16450(f_1108_16324_16381(f_1108_16324_16346()), f_1108_16416_16449())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 16531, 18671);

                var
                MamlFullParameterControl = f_1108_16562_18670(f_1108_16562_18639(f_1108_16562_18606(f_1108_16562_18569(f_1108_16562_18526(f_1108_16562_18483(f_1108_16562_18369(f_1108_16562_18285(f_1108_16562_18242(f_1108_16562_18165(f_1108_16562_18086(f_1108_16562_18043(f_1108_16562_17967(f_1108_16562_17887(f_1108_16562_17844(f_1108_16562_17723(f_1108_16562_17560(f_1108_16562_17484(f_1108_16562_17441(f_1108_16562_17327(f_1108_16562_17251(f_1108_16562_17113(f_1108_16562_17070(f_1108_16562_16929(f_1108_16562_16877(f_1108_16562_16838(f_1108_16562_16722(f_1108_16562_16658(f_1108_16562_16619(f_1108_16562_16584()), "-"), @"name"), @"ParameterValue", customControl: MamlParameterValueControl)), leftIndent: 4), @"Description", enumerateCollection: true, customControl: MamlDescriptionControl)), MamlPossibleValuesControl, selectedByScript: "$_.possibleValues -ne $()"), f_1108_17290_17326()), @"required", customControl: MamlTrueFalseShortControl)), f_1108_17523_17559()), @" ", selectedByScript: @"($_.position -eq  $()) -or ($_.position -eq '')", customControl: control7), @"$_.position", selectedByScript: "$_.position  -ne  $()")), f_1108_17926_17966()), @"defaultValue")), f_1108_18125_18164()), @"pipelineInput")), f_1108_18324_18368()), @"globbing", customControl: MamlTrueFalseShortControl))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 18687, 18961);

                var
                control8 = f_1108_18702_18960(f_1108_18702_18929(f_1108_18702_18896(f_1108_18702_18759(f_1108_18702_18724()), @"Parameter", enumerateCollection: true, customControl: MamlFullParameterControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 18977, 19536);

                var
                zzz = f_1108_18987_19535(f_1108_18987_19504(f_1108_18987_19471(f_1108_18987_19432(f_1108_18987_19393(f_1108_18987_19356(f_1108_18987_19276(f_1108_18987_19224(f_1108_18987_19185(f_1108_18987_19114(f_1108_18987_19044(f_1108_18987_19009()), control8), f_1108_19149_19184())), leftIndent: 4), f_1108_19315_19355()))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 19552, 20518);

                var
                sharedControls = new CustomControl[] {
                TextPropertyControl,
                MamlShortDescriptionControl,
                MamlDetailsControl,
                MamlIndentedDescriptionControl,
                MamlDescriptionControl,
                MamlParameterControl,
                MamlParameterValueControl,
                ExamplesControl,
                MamlExampleControl,
                MamlTypeControl,
                MamlTextItem,
                MamlAlertControl,
                MamlPossibleValuesControl,
                MamlPossibleValueControl,
                MamlTrueFalseShortControl,
                MamlIndentedSyntaxControl,
                MamlSyntaxControl,
                MamlTypeWithDescriptionControl,
                RelatedLinksHelpInfoControl,
                MamlRelatedLinksControl,
                ErrorControl,
                MamlFullParameterControl,
                zzz
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 20534, 20651);

                listYield.Add(f_1108_20547_20650("HelpInfoShort", f_1108_20626_20649()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 20667, 20786);

                listYield.Add(f_1108_20680_20785("CmdletHelpInfo", f_1108_20760_20784()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 20802, 20945);

                listYield.Add(f_1108_20815_20944("MamlCommandHelpInfo", f_1108_20900_20943(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 20961, 21130);

                listYield.Add(f_1108_20974_21129("MamlCommandHelpInfo#DetailedView", f_1108_21072_21128(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21146, 21315);

                listYield.Add(f_1108_21159_21314("MamlCommandHelpInfo#ExamplesView", f_1108_21257_21313(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21331, 21492);

                listYield.Add(f_1108_21344_21491("MamlCommandHelpInfo#FullView", f_1108_21438_21490(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21508, 21645);

                listYield.Add(f_1108_21521_21644("ProviderHelpInfo", f_1108_21603_21643(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21661, 21788);

                listYield.Add(f_1108_21674_21787("FaqHelpInfo", f_1108_21751_21786(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21804, 21939);

                listYield.Add(f_1108_21817_21938("GeneralHelpInfo", f_1108_21898_21937(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 21955, 22092);

                listYield.Add(f_1108_21968_22091("GlossaryHelpInfo", f_1108_22050_22090(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22108, 22241);

                listYield.Add(f_1108_22121_22240("ScriptHelpInfo", f_1108_22201_22239(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22257, 22418);

                listYield.Add(f_1108_22270_22417("MamlCommandHelpInfo#Examples", f_1108_22364_22416(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22434, 22593);

                listYield.Add(f_1108_22447_22592("MamlCommandHelpInfo#Example", f_1108_22540_22591(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22609, 22782);

                listYield.Add(f_1108_22622_22781("MamlCommandHelpInfo#commandDetails", f_1108_22722_22780(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22798, 22963);

                listYield.Add(f_1108_22811_22962("MamlCommandHelpInfo#Parameters", f_1108_22907_22961(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 22979, 23142);

                listYield.Add(f_1108_22992_23141("MamlCommandHelpInfo#Parameter", f_1108_23087_23140(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23158, 23315);

                listYield.Add(f_1108_23171_23314("MamlCommandHelpInfo#Syntax", f_1108_23263_23313(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23331, 23545);

                var
                td18 = f_1108_23342_23544("MamlDefinitionTextItem", f_1108_23430_23543(sharedControls))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23559, 23605);

                f_1108_23559_23604(f_1108_23559_23573(td18), "MamlOrderedListTextItem");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23619, 23658);

                f_1108_23619_23657(f_1108_23619_23633(td18), "MamlParaTextItem");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23672, 23720);

                f_1108_23672_23719(f_1108_23672_23686(td18), "MamlUnorderedListTextItem");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23734, 23752);

                listYield.Add(td18);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23768, 23933);

                listYield.Add(f_1108_23781_23932("MamlCommandHelpInfo#inputTypes", f_1108_23877_23931(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 23949, 24134);

                listYield.Add(f_1108_23962_24133("MamlCommandHelpInfo#nonTerminatingErrors", f_1108_24068_24132(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 24150, 24329);

                listYield.Add(f_1108_24163_24328("MamlCommandHelpInfo#terminatingErrors", f_1108_24266_24327(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 24345, 24514);

                listYield.Add(f_1108_24358_24513("MamlCommandHelpInfo#relatedLinks", f_1108_24456_24512(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 24530, 24699);

                listYield.Add(f_1108_24543_24698("MamlCommandHelpInfo#returnValues", f_1108_24641_24697(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 24715, 24876);

                listYield.Add(f_1108_24728_24875("MamlCommandHelpInfo#alertSet", f_1108_24822_24874(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 24892, 25051);

                listYield.Add(f_1108_24905_25050("MamlCommandHelpInfo#details", f_1108_24998_25049(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 297, 25062);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_415_437()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 415, 437);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_415_472(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 415, 472);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_415_536(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 415, 536);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_415_569(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 415, 569);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_415_600(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 415, 600);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_651_673()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 673);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_651_757(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 757);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_651_821(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 821);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_651_860(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 860);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_651_893(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 893);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_651_928(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 928);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_651_967(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 967);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_651_1000(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 1000);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_651_1031(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 651, 1031);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_1099()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1099);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1183(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1183);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1247(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1247);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1286(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1286);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_1319(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1319);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1410(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1410);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1468(System.Management.Automation.CustomEntryBuilder
                this_param, int
                firstLineHanging)
                {
                    var return_v = this_param.StartFrame(firstLineHanging: (uint)firstLineHanging);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1468);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1535(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1535);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1603(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1603);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1646(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1646);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1683(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1683);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_1716(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1716);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1809(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1809);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1867(System.Management.Automation.CustomEntryBuilder
                this_param, int
                firstLineHanging)
                {
                    var return_v = this_param.StartFrame(firstLineHanging: (uint)firstLineHanging);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1867);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_1934(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 1934);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2002(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2002);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2045(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2045);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2082(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2082);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_2115(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2115);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2205(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2205);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2269(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2269);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2308(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2308);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2360(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2360);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2434(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2434);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2477(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2477);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2514(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2514);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_2547(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2547);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2582(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2582);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_1077_2621(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2621);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_1077_2654(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2654);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_1077_2685(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 1077, 2685);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_2729_2751()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 2729, 2751);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_2729_2786(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 2729, 2786);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_2729_3477(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 2729, 3477);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_2729_3510(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 2729, 3510);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_2729_3541(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 2729, 3541);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3590_3612()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3590, 3612);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3590_3647(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3590, 3647);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3590_3772(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3590, 3772);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3590_3805(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3590, 3805);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_3590_3836(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3590, 3836);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_3894()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 3894);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_3978(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 3978);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4042(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4042);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4081(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4081);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_4114(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4114);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4205(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4205);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4268(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4268);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4332(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4332);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4371(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4371);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_4404(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4404);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4497(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4497);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4560(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4560);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4624(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4624);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4663(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4663);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_4696(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4696);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4786(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4786);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4850(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4850);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4889(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4889);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_4941(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 4941);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5015(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5015);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5052(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5052);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5091(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5091);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_5124(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5124);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5216(System.Management.Automation.CustomControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5216);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5280(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5280);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_5313(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5313);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5348(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5348);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_3872_5387(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5387);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_3872_5420(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5420);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_3872_5451(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 3872, 5451);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5491_5513()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5513);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5491_5548(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5548);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5491_5612(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5612);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5491_5651(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5651);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5491_5684(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5684);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_5491_5715(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5491, 5715);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5747_5769()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5747, 5769);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5747_5804(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5747, 5804);
                    return return_v;
                }


                string
                f_1108_5839_5868()
                {
                    var return_v = HelpDisplayStrings.FalseShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 5839, 5868);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5747_5869(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5747, 5869);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5747_5902(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5747, 5902);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_5747_5933(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5747, 5933);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5965_5987()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5965, 5987);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5965_6022(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5965, 6022);
                    return return_v;
                }


                string
                f_1108_6057_6085()
                {
                    var return_v = HelpDisplayStrings.TrueShort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 6057, 6085);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_5965_6086(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5965, 6086);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_5965_6119(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5965, 6119);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_5965_6150(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 5965, 6150);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_6199_6221()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6221);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6199_6256(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6256);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6199_6431(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6431);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6199_6607(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6607);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_6199_6640(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6640);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_6199_6671(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6199, 6671);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_6722_6744()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 6744);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6722_6779(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 6779);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6722_6831(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 6831);
                    return return_v;
                }


                string
                f_1108_7131_7170()
                {
                    var return_v = HelpDisplayStrings.RelatedLinksHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 7131, 7170);
                    return return_v;
                }


                string
                f_1108_6894_7171(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6894, 7171);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6722_7172(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 7172);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_6722_7209(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 7209);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_6722_7242(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 7242);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_6722_7273(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 6722, 7273);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_7305_7327()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7327);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7305_7362(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7362);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7305_7430(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7430);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7305_7541(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7541);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7305_7604(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7604);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7305_7643(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7643);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_7305_7676(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7676);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_7305_7707(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7305, 7707);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_7754_7776()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7754, 7776);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7754_7811(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7754, 7811);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_7754_7937(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7754, 7937);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_7754_7970(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7754, 7970);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_7754_8001(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 7754, 8001);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_8043_8065()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8065);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8100(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8100);
                    return return_v;
                }


                string
                f_1108_8135_8158()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 8135, 8158);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8159(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8159);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8198(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8198);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8250(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8250);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8318(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8318);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8361(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8361);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8404(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8404);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8441(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8441);
                    return return_v;
                }


                string
                f_1108_8476_8503()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 8476, 8503);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8504(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8504);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8543(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8543);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8595(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8595);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8741(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8741);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8784(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8784);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8827(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8827);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8043_8864(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8864);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_8043_8897(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8897);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_8043_8928(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8043, 8928);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_8970_8992()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 8992);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9027(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9027);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9092(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9092);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9131(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9131);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9170(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9170);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9305(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9305);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9396(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9396);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9435(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9435);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9502(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9502);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9541(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9541);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_8970_9679(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9679);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_8970_9712(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9712);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_8970_9743(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 8970, 9743);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_9775_9797()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 9797);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_9775_9832(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 9832);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_9775_9884(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 9884);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_9775_10030(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 10030);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_9775_10067(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 10067);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_9775_10100(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 10100);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_9775_10131(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 9775, 10131);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_10163_10185()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10185);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10220(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10220);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10259(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10259);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10311(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10311);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10378(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10378);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10421(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10421);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10163_10458(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10458);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_10163_10491(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10491);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_10163_10522(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10163, 10522);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_10561_10583()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10583);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10561_10618(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10618);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10561_10709(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10709);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10561_10807(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10807);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_10561_10913(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10913);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_10561_10946(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10946);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_10561_10977(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 10561, 10977);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11009_11031()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11031);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11066(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11066);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11131(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11131);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11170(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11170);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11222(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11222);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11368(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11368);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11405(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11405);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11009_11444(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11444);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11009_11477(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11477);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_11009_11508(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11009, 11508);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11556_11578()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11556, 11578);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11556_11613(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11556, 11613);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11556_11738(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11556, 11738);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11556_11771(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11556, 11771);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_11556_11802(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11556, 11802);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11856_11878()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 11878);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_11913(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 11913);
                    return return_v;
                }


                string
                f_1108_11948_11986()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 11948, 11986);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_11987(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 11987);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12026(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12026);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12078(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12078);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12219(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12219);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12262(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12262);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12299(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12299);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_11856_12338(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12338);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_11856_12371(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12371);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_11856_12402(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 11856, 12402);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_12434_12456()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12456);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12491(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12491);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12555(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12555);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12594(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12594);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12727(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12727);
                    return return_v;
                }


                string
                f_1108_12768_12803()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 12768, 12803);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12810(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12810);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12434_12850(System.Management.Automation.CustomEntryBuilder
                this_param, int
                count)
                {
                    var return_v = this_param.AddNewline(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12850);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_12434_12883(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12883);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_12434_12914(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12434, 12914);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_12955_12977()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12955, 12977);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12955_13012(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12955, 13012);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_12955_13134(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12955, 13134);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_12955_13167(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12955, 13167);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_12955_13198(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 12955, 13198);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_13237_13259()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13237, 13259);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13237_13294(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13237, 13294);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13237_13423(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13237, 13423);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_13237_13456(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13237, 13456);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_13237_13487(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13237, 13487);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_13541_13563()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13563);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13598(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13598);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13694(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13694);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13733(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13733);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13785(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13785);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13931(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13931);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_13968(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 13968);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_13541_14007(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 14007);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_13541_14040(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 14040);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_13541_14071(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 13541, 14071);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_14107_14129()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14129);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14164(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14164);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14231(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14231);
                    return return_v;
                }


                string
                f_1108_14266_14293()
                {
                    var return_v = HelpDisplayStrings.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 14266, 14293);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14294(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14294);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14362(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14362);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14401(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14401);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14440(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14440);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14492(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14492);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14638(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14638);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14675(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14675);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14714(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14714);
                    return return_v;
                }


                string
                f_1108_14749_14777()
                {
                    var return_v = HelpDisplayStrings.TypeColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 14749, 14777);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14778(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14778);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14874(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14874);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14913(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14913);
                    return return_v;
                }


                string
                f_1108_14948_14988()
                {
                    var return_v = HelpDisplayStrings.TargetObjectTypeColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 14948, 14988);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_14989(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 14989);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15097(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15097);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15136(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15136);
                    return return_v;
                }


                string
                f_1108_15171_15210()
                {
                    var return_v = HelpDisplayStrings.SuggestedActionColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 15171, 15210);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15211(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15211);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15359(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15359);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15398(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15398);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_14107_15437(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15437);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_14107_15470(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15470);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_14107_15501(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 14107, 15501);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_15550_15572()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15550, 15572);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15550_15607(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15550, 15607);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15550_15722(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15550, 15722);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_15550_15755(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15550, 15755);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_15550_15786(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15550, 15786);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_15835_15857()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 15857);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_15892(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 15892);
                    return return_v;
                }


                string
                f_1108_15927_15952()
                {
                    var return_v = HelpDisplayStrings.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 15927, 15952);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_15953(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 15953);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_15992(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 15992);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_16044(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16044);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_16148(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16148);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_16191(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16191);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_15835_16228(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16228);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_15835_16261(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16261);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_15835_16292(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 15835, 16292);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_16324_16346()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16324, 16346);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16324_16381(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16324, 16381);
                    return return_v;
                }


                string
                f_1108_16416_16449()
                {
                    var return_v = HelpDisplayStrings.NamedParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 16416, 16449);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16324_16450(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16324, 16450);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_16324_16483(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16324, 16483);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_16324_16514(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16324, 16514);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_16562_16584()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16584);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16619(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16619);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16658(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16658);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16722(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16722);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16838(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16838);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16877(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16877);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_16929(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 16929);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17070(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17070);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17113(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17113);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17251(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl, string
                selectedByScript)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17251);
                    return return_v;
                }


                string
                f_1108_17290_17326()
                {
                    var return_v = HelpDisplayStrings.ParameterRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 17290, 17326);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17327(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17327);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17441(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17441);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17484(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17484);
                    return return_v;
                }


                string
                f_1108_17523_17559()
                {
                    var return_v = HelpDisplayStrings.ParameterPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 17523, 17559);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17560(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17560);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17723(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17723);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17844(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, string
                selectedByScript)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, selectedByScript: selectedByScript);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17844);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17887(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17887);
                    return return_v;
                }


                string
                f_1108_17926_17966()
                {
                    var return_v = HelpDisplayStrings.ParameterDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 17926, 17966);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_17967(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 17967);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18043(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18043);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18086(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18086);
                    return return_v;
                }


                string
                f_1108_18125_18164()
                {
                    var return_v = HelpDisplayStrings.AcceptsPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 18125, 18164);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18165(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18165);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18242(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18242);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18285(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18285);
                    return return_v;
                }


                string
                f_1108_18324_18368()
                {
                    var return_v = HelpDisplayStrings.AcceptsWildCardCharacters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 18324, 18368);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18369(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18369);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18483(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18483);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18526(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18526);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18569(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18569);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_16562_18606(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18606);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_16562_18639(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18639);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_16562_18670(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 16562, 18670);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_18702_18724()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18702, 18724);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18702_18759(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18702, 18759);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18702_18896(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18702, 18896);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_18702_18929(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18702, 18929);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_18702_18960(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18702, 18960);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_18987_19009()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19009);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19044(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19044);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19114(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19114);
                    return return_v;
                }


                string
                f_1108_19149_19184()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 19149, 19184);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19185(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19185);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19224(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19224);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19276(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19276);
                    return return_v;
                }


                string
                f_1108_19315_19355()
                {
                    var return_v = HelpDisplayStrings.BaseCmdletInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 19315, 19355);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19356(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19356);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19393(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19393);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19432(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19432);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_18987_19471(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19471);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_18987_19504(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19504);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_18987_19535(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 18987, 19535);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_20626_20649()
                {
                    var return_v = ViewsOf_HelpInfoShort();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20626, 20649);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_20547_20650(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20547, 20650);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_20760_20784()
                {
                    var return_v = ViewsOf_CmdletHelpInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20760, 20784);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_20680_20785(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20680, 20785);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_20900_20943(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20900, 20943);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_20815_20944(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20815, 20944);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21072_21128(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_DetailedView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21072, 21128);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_20974_21129(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 20974, 21129);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21257_21313(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_ExamplesView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21257, 21313);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21159_21314(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21159, 21314);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21438_21490(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_FullView(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21438, 21490);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21344_21491(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21344, 21491);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21603_21643(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ProviderHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21603, 21643);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21521_21644(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21521, 21644);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21751_21786(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_FaqHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21751, 21786);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21674_21787(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21674, 21787);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_21898_21937(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_GeneralHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21898, 21937);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21817_21938(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21817, 21938);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22050_22090(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_GlossaryHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22050, 22090);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_21968_22091(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 21968, 22091);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22201_22239(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ScriptHelpInfo(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22201, 22239);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22121_22240(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22121, 22240);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22364_22416(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_Examples(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22364, 22416);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22270_22417(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22270, 22417);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22540_22591(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_Example(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22540, 22591);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22447_22592(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22447, 22592);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22722_22780(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_commandDetails(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22722, 22780);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22622_22781(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22622, 22781);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_22907_22961(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_Parameters(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22907, 22961);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22811_22962(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22811, 22962);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_23087_23140(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_Parameter(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23087, 23140);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_22992_23141(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 22992, 23141);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_23263_23313(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_Syntax(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23263, 23313);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_23171_23314(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23171, 23314);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_23430_23543(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlDefinitionTextItem_MamlOrderedListTextItem_MamlParaTextItem_MamlUnorderedListTextItem(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23430, 23543);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_23342_23544(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23342, 23544);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1108_23559_23573(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 23559, 23573);
                    return return_v;
                }


                int
                f_1108_23559_23604(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23559, 23604);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1108_23619_23633(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 23619, 23633);
                    return return_v;
                }


                int
                f_1108_23619_23657(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23619, 23657);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1108_23672_23686(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 23672, 23686);
                    return return_v;
                }


                int
                f_1108_23672_23719(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23672, 23719);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_23877_23931(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_inputTypes(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23877, 23931);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_23781_23932(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23781, 23932);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24068_24132(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_nonTerminatingErrors(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24068, 24132);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_23962_24133(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 23962, 24133);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24266_24327(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_terminatingErrors(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24266, 24327);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_24163_24328(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24163, 24328);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24456_24512(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_relatedLinks(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24456, 24512);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_24358_24513(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24358, 24513);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24641_24697(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_returnValues(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24641, 24697);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_24543_24698(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24543, 24698);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24822_24874(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_alertSet(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24822, 24874);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_24728_24875(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24728, 24875);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1108_24998_25049(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_MamlCommandHelpInfo_details(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24998, 25049);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1108_24905_25050(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 24905, 25050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 297, 25062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 297, 25062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_HelpInfoShort()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 25074, 25922);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 25171, 25911);

                listYield.Add(f_1108_25184_25910("help", f_1108_25234_25909(f_1108_25234_25880(f_1108_25234_25839(f_1108_25234_25783(f_1108_25234_25667(f_1108_25234_25611(f_1108_25234_25559(f_1108_25234_25516(f_1108_25234_25482(f_1108_25234_25406(f_1108_25234_25329(f_1108_25234_25255(), Alignment.Left, label: "Name", width: 33), Alignment.Left, label: "Category", width: 9), Alignment.Left, label: "Module", width: 25))), "Name"), "Category"), "if ($null -ne $_.ModuleName) { $_.ModuleName } else {$_.PSSnapIn}"), "Synopsis")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 25074, 25922);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1108_25234_25255()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25255);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1108_25234_25329(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25329);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1108_25234_25406(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25406);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1108_25234_25482(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25482);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1108_25234_25516(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25516);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1108_25234_25559(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25559);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1108_25234_25611(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25611);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1108_25234_25667(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25667);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1108_25234_25783(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25783);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1108_25234_25839(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25839);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1108_25234_25880(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25880);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1108_25234_25909(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25234, 25909);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_25184_25910(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 25184, 25910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 25074, 25922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 25074, 25922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_CmdletHelpInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 25934, 26878);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 26032, 26867);

                listYield.Add(f_1108_26045_26866("CmdletHelp", f_1108_26101_26865(f_1108_26101_26834(f_1108_26101_26801(f_1108_26101_26764(f_1108_26101_26721(f_1108_26101_26651(f_1108_26101_26599(f_1108_26101_26560(f_1108_26101_26499(f_1108_26101_26462(f_1108_26101_26419(f_1108_26101_26376(f_1108_26101_26308(f_1108_26101_26256(f_1108_26101_26217(f_1108_26101_26158(f_1108_26101_26123()), f_1108_26193_26216())), leftIndent: 4), @"Name")))), f_1108_26534_26559())), leftIndent: 4), @"Syntax")))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 25934, 26878);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_26101_26123()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26123);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26158(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26158);
                    return return_v;
                }


                string
                f_1108_26193_26216()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 26193, 26216);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26217(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26217);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26256(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26256);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26308(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26308);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26376(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26376);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26419(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26419);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26462(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26462);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26499(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26499);
                    return return_v;
                }


                string
                f_1108_26534_26559()
                {
                    var return_v = HelpDisplayStrings.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 26534, 26559);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26560(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26560);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26599(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26599);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26651(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26651);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26721(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26721);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26764(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26764);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_26101_26801(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26801);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_26101_26834(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26834);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_26101_26865(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26101, 26865);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_26045_26866(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 26045, 26866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 25934, 26878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 25934, 26878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 26890, 29043);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 27023, 29032);

                listYield.Add(f_1108_27036_29031("DefaultCommandHelp", f_1108_27100_29030(f_1108_27100_28999(f_1108_27100_28966(f_1108_27100_28929(f_1108_27100_28845(f_1108_27100_28802(f_1108_27100_28757(f_1108_27100_28646(f_1108_27100_28601(f_1108_27100_28530(f_1108_27100_28487(f_1108_27100_28442(f_1108_27100_28327(f_1108_27100_28246(f_1108_27100_28203(f_1108_27100_28158(f_1108_27100_28043(f_1108_27100_27962(f_1108_27100_27910(f_1108_27100_27871(f_1108_27100_27802(f_1108_27100_27763(f_1108_27100_27726(f_1108_27100_27615(f_1108_27100_27563(f_1108_27100_27524(f_1108_27100_27457(f_1108_27100_27358(f_1108_27100_27258(f_1108_27100_27157(f_1108_27100_27122()), @"Details", customControl: sharedControls[2]), @"$_", customControl: sharedControls[15]), @"$_", customControl: sharedControls[3]), f_1108_27492_27523())), leftIndent: 4), @"relatedLinks", customControl: sharedControls[19]))), f_1108_27837_27870())), leftIndent: 4), f_1108_28001_28035() + "\""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1108_28285_28319() + "\""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1108_28569_28600()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[18]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 26890, 29043);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_27100_27122()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27122);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27157(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27157);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27258(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27258);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27358(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27358);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27457(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27457);
                    return return_v;
                }


                string
                f_1108_27492_27523()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 27492, 27523);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27524(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27524);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27563(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27563);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27615(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27615);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27726(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27726);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27763(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27763);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27802(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27802);
                    return return_v;
                }


                string
                f_1108_27837_27870()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 27837, 27870);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27871(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27871);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27910(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27910);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_27962(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 27962);
                    return return_v;
                }


                string
                f_1108_28001_28035()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 28001, 28035);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28043(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28043);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28158(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28158);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28203(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28203);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28246(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28246);
                    return return_v;
                }


                string
                f_1108_28285_28319()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 28285, 28319);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28327(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28327);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28442(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28442);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28487(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28487);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28530(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28530);
                    return return_v;
                }


                string
                f_1108_28569_28600()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 28569, 28600);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28601(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28601);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28646(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28646);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28757(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28757);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28802(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28802);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28845(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28845);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28929(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28929);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_27100_28966(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28966);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_27100_28999(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 28999);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_27100_29030(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27100, 29030);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_27036_29031(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 27036, 29031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 26890, 29043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 26890, 29043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_DetailedView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 29055, 32771);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 29201, 29857);

                var
                control10 = f_1108_29217_29856(f_1108_29217_29825(f_1108_29217_29792(f_1108_29217_29755(f_1108_29217_29712(f_1108_29217_29576(f_1108_29217_29524(f_1108_29217_29485(f_1108_29217_29377(f_1108_29217_29313(f_1108_29217_29274(f_1108_29217_29239()), "-"), @"name"), @"ParameterValue", customControl: sharedControls[6])), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[4])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 29873, 30132);

                var
                control9 = f_1108_29888_30131(f_1108_29888_30100(f_1108_29888_30067(f_1108_29888_29945(f_1108_29888_29910()), @"Parameter", enumerateCollection: true, customControl: control10)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 30148, 32760);

                listYield.Add(f_1108_30161_32759("VerboseCommandHelp", f_1108_30225_32758(f_1108_30225_32727(f_1108_30225_32694(f_1108_30225_32657(f_1108_30225_32573(f_1108_30225_32530(f_1108_30225_32485(f_1108_30225_32374(f_1108_30225_32329(f_1108_30225_32258(f_1108_30225_32215(f_1108_30225_32170(f_1108_30225_32055(f_1108_30225_32010(f_1108_30225_31936(f_1108_30225_31893(f_1108_30225_31848(f_1108_30225_31733(f_1108_30225_31688(f_1108_30225_31614(f_1108_30225_31562(f_1108_30225_31523(f_1108_30225_31454(f_1108_30225_31417(f_1108_30225_31311(f_1108_30225_31259(f_1108_30225_31222(f_1108_30225_31179(f_1108_30225_31136(f_1108_30225_31095(f_1108_30225_31011(f_1108_30225_30955(f_1108_30225_30912(f_1108_30225_30837(f_1108_30225_30738(f_1108_30225_30686(f_1108_30225_30647(f_1108_30225_30582(f_1108_30225_30483(f_1108_30225_30383(f_1108_30225_30282(f_1108_30225_30247()), @"Details", customControl: sharedControls[2]), @"$_", customControl: sharedControls[15]), @"$_", customControl: sharedControls[3]), f_1108_30617_30646())), leftIndent: 4), @"Parameters", customControl: control9), f_1108_30876_30911())), leftIndent: 4), f_1108_31054_31094()))))), leftIndent: 4), @"Examples", customControl: sharedControls[7])), f_1108_31489_31522())), leftIndent: 4), f_1108_31653_31687()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Examples"""), @"""")), f_1108_31975_32009()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Detailed"""), @"""")), f_1108_32297_32328()), @""""), @"""Get-Help "" + $_.Details.Name + "" -Full"""), @"""")), sharedControls[18]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 29055, 32771);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_29217_29239()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29239);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29274(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29274);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29313(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29313);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29377(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29377);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29485(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29485);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29524(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29524);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29576(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29712(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29712);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29755(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29755);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29217_29792(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29792);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_29217_29825(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29825);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_29217_29856(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29217, 29856);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_29888_29910()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29888, 29910);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29888_29945(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29888, 29945);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_29888_30067(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29888, 30067);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_29888_30100(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29888, 30100);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_29888_30131(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 29888, 30131);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_30225_30247()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30247);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30282(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30282);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30383(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30383);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30483(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30483);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30582(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30582);
                    return return_v;
                }


                string
                f_1108_30617_30646()
                {
                    var return_v = HelpDisplayStrings.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 30617, 30646);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30647(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30647);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30686(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30686);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30738(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30738);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30837(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30837);
                    return return_v;
                }


                string
                f_1108_30876_30911()
                {
                    var return_v = HelpDisplayStrings.CommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 30876, 30911);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30912(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30912);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_30955(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 30955);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31011(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31011);
                    return return_v;
                }


                string
                f_1108_31054_31094()
                {
                    var return_v = HelpDisplayStrings.BaseCmdletInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 31054, 31094);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31095(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31095);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31136(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31136);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31179(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31179);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31222(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31222);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31259(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31259);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31311(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31311);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31417(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31417);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31454(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31454);
                    return return_v;
                }


                string
                f_1108_31489_31522()
                {
                    var return_v = HelpDisplayStrings.RemarksSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 31489, 31522);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31523(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31523);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31562(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31562);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31614(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31614);
                    return return_v;
                }


                string
                f_1108_31653_31687()
                {
                    var return_v = HelpDisplayStrings.ExampleHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 31653, 31687);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31688(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31688);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31733(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31733);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31848(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31848);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31893(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31893);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_31936(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 31936);
                    return return_v;
                }


                string
                f_1108_31975_32009()
                {
                    var return_v = HelpDisplayStrings.VerboseHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 31975, 32009);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32010(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32010);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32055(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32055);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32170(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32170);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32215(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32215);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32258(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32258);
                    return return_v;
                }


                string
                f_1108_32297_32328()
                {
                    var return_v = HelpDisplayStrings.FullHelpInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 32297, 32328);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32329(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32329);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32374(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32374);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32485(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32485);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32530(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32530);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32573(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32573);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32657(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32657);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_30225_32694(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32694);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_30225_32727(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32727);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_30225_32758(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30225, 32758);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_30161_32759(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 30161, 32759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 29055, 32771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 29055, 32771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_ExamplesView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 32783, 33436);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 32929, 33425);

                listYield.Add(f_1108_32942_33424("ExampleCommandHelp", f_1108_33006_33423(f_1108_33006_33392(f_1108_33006_33359(f_1108_33006_33322(f_1108_33006_33216(f_1108_33006_33164(f_1108_33006_33063(f_1108_33006_33028()), @"Details", customControl: sharedControls[2]), leftIndent: 4), @"Examples", customControl: sharedControls[7]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 32783, 33436);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_33006_33028()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33028);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33006_33063(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33063);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33006_33164(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33164);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33006_33216(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33216);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33006_33322(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33322);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33006_33359(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33359);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_33006_33392(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33392);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_33006_33423(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33006, 33423);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_32942_33424(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 32942, 33424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 32783, 33436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 32783, 33436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_FullView(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 33448, 39000);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 33590, 34247);

                var
                control16 = f_1108_33606_34246(f_1108_33606_34215(f_1108_33606_34182(f_1108_33606_34145(f_1108_33606_34102(f_1108_33606_34061(f_1108_33606_33926(f_1108_33606_33870(f_1108_33606_33827(f_1108_33606_33784(f_1108_33606_33715(f_1108_33606_33663(f_1108_33606_33628()), leftIndent: 4), @"title"))), leftIndent: 4), @"alert", enumerateCollection: true, customControl: sharedControls[11]))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 34263, 34500);

                var
                control15 = f_1108_34279_34499(f_1108_34279_34468(f_1108_34279_34435(f_1108_34279_34396(f_1108_34279_34336(f_1108_34279_34301()), f_1108_34371_34395()))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 34516, 35008);

                var
                control14 = f_1108_34532_35007(f_1108_34532_34976(f_1108_34532_34943(f_1108_34532_34906(f_1108_34532_34761(f_1108_34532_34709(f_1108_34532_34670(f_1108_34532_34589(f_1108_34532_34554()), f_1108_34624_34669())), leftIndent: 4), @"nonTerminatingError", enumerateCollection: true, customControl: sharedControls[20]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 35024, 35504);

                var
                control13 = f_1108_35040_35503(f_1108_35040_35472(f_1108_35040_35439(f_1108_35040_35402(f_1108_35040_35260(f_1108_35040_35208(f_1108_35040_35169(f_1108_35040_35097(f_1108_35040_35062()), f_1108_35132_35168())), leftIndent: 4), @"terminatingError", enumerateCollection: true, customControl: sharedControls[20]))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 35520, 35791);

                var
                control12 = f_1108_35536_35790(f_1108_35536_35759(f_1108_35536_35726(f_1108_35536_35593(f_1108_35536_35558()), @"ReturnValue", enumerateCollection: true, customControl: sharedControls[17])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 35807, 36076);

                var
                control11 = f_1108_35823_36075(f_1108_35823_36044(f_1108_35823_36011(f_1108_35823_35880(f_1108_35823_35845()), @"InputType", enumerateCollection: true, customControl: sharedControls[17])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 36092, 38989);

                listYield.Add(f_1108_36105_38988("FullCommandHelp", f_1108_36166_38987(f_1108_36166_38956(f_1108_36166_38923(f_1108_36166_38886(f_1108_36166_38775(f_1108_36166_38723(f_1108_36166_38684(f_1108_36166_38617(f_1108_36166_38580(f_1108_36166_38537(f_1108_36166_38431(f_1108_36166_38379(f_1108_36166_38215(f_1108_36166_38078(f_1108_36166_37782(f_1108_36166_37498(f_1108_36166_37461(f_1108_36166_37418(f_1108_36166_37316(f_1108_36166_37264(f_1108_36166_37225(f_1108_36166_37160(f_1108_36166_37123(f_1108_36166_37080(f_1108_36166_36980(f_1108_36166_36928(f_1108_36166_36889(f_1108_36166_36825(f_1108_36166_36788(f_1108_36166_36679(f_1108_36166_36627(f_1108_36166_36588(f_1108_36166_36523(f_1108_36166_36424(f_1108_36166_36324(f_1108_36166_36223(f_1108_36166_36188()), @"Details", customControl: sharedControls[2]), @"$_", customControl: sharedControls[15]), @"$_", customControl: sharedControls[3]), f_1108_36558_36587())), leftIndent: 4), @"Parameters", customControl: sharedControls[22])), f_1108_36860_36888())), leftIndent: 4), @"InputTypes", customControl: control11))), f_1108_37195_37224())), leftIndent: 4), @"ReturnValues", customControl: control12))), @"terminatingErrors", selectedByScript: @"
                      (($null -ne $_.terminatingErrors) -and
                      ($null -ne $_.terminatingErrors.terminatingError))
                    ", customControl: control13), @"nonTerminatingErrors", selectedByScript: @"
                      (($null -ne $_.nonTerminatingErrors) -and
                      ($null -ne $_.nonTerminatingErrors.nonTerminatingError))
                    ", customControl: control14), @"alertSet", selectedByScript: "$null -ne $_.alertSet", customControl: control15), @"alertSet", enumerateCollection: true, selectedByScript: "$null -ne $_.alertSet", customControl: control16), leftIndent: 4), @"Examples", customControl: sharedControls[7]))), f_1108_38652_38683())), leftIndent: 4), @"relatedLinks", customControl: sharedControls[19]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 33448, 39000);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_33606_33628()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33628);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33663(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33663);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33715(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33715);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33784(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33784);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33827(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33827);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33870(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33870);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_33926(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 33926);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_34061(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34061);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_34102(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34102);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_34145(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34145);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_33606_34182(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34182);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_33606_34215(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34215);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_33606_34246(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 33606, 34246);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_34279_34301()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34301);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34279_34336(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34336);
                    return return_v;
                }


                string
                f_1108_34371_34395()
                {
                    var return_v = HelpDisplayStrings.Notes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 34371, 34395);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34279_34396(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34396);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34279_34435(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34435);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_34279_34468(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34468);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_34279_34499(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34279, 34499);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_34532_34554()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34554);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34589(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34589);
                    return return_v;
                }


                string
                f_1108_34624_34669()
                {
                    var return_v = HelpDisplayStrings.NonHyphenTerminatingErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 34624, 34669);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34670(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34670);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34709(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34709);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34761(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34761);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34906(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34906);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_34532_34943(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34943);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_34532_34976(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 34976);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_34532_35007(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 34532, 35007);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35040_35062()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35062);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35097(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35097);
                    return return_v;
                }


                string
                f_1108_35132_35168()
                {
                    var return_v = HelpDisplayStrings.TerminatingErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 35132, 35168);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35169(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35169);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35208(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35208);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35260(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35260);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35402(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35402);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35040_35439(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35439);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35040_35472(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35472);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_35040_35503(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35040, 35503);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35536_35558()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35536, 35558);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35536_35593(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35536, 35593);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35536_35726(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35536, 35726);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35536_35759(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35536, 35759);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_35536_35790(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35536, 35790);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35823_35845()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35823, 35845);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35823_35880(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35823, 35880);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_35823_36011(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35823, 36011);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_35823_36044(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35823, 36044);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_35823_36075(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 35823, 36075);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_36166_36188()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36188);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36223(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36223);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36324(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36324);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36424(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36424);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36523(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36523);
                    return return_v;
                }


                string
                f_1108_36558_36587()
                {
                    var return_v = HelpDisplayStrings.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 36558, 36587);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36588(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36588);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36627(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36627);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36679(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36679);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36788(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36788);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36825(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36825);
                    return return_v;
                }


                string
                f_1108_36860_36888()
                {
                    var return_v = HelpDisplayStrings.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 36860, 36888);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36889(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36889);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36928(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36928);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_36980(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 36980);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37080(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37080);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37123(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37123);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37160(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37160);
                    return return_v;
                }


                string
                f_1108_37195_37224()
                {
                    var return_v = HelpDisplayStrings.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 37195, 37224);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37225(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37225);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37264(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37264);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37316(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37316);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37418(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37418);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37461(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37461);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37498(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37498);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_37782(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 37782);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38078(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38078);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38215(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38215);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38379(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, string
                selectedByScript, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, selectedByScript: selectedByScript, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38379);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38431(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38431);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38537(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38537);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38580(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38580);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38617(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38617);
                    return return_v;
                }


                string
                f_1108_38652_38683()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 38652, 38683);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38684(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38684);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38723(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38723);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38775(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38775);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38886(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38886);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_36166_38923(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38923);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_36166_38956(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38956);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_36166_38987(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36166, 38987);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_36105_38988(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 36105, 38988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 33448, 39000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 33448, 39000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ProviderHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 39012, 47694);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 39142, 40047);

                var
                TaskExampleControl = f_1108_39167_40046(f_1108_39167_40015(f_1108_39167_39982(f_1108_39167_39853(f_1108_39167_39814(f_1108_39167_39775(f_1108_39167_39708(f_1108_39167_39669(f_1108_39167_39578(f_1108_39167_39539(f_1108_39167_39500(f_1108_39167_39367(f_1108_39167_39328(f_1108_39167_39289(f_1108_39167_39224(f_1108_39167_39189()), @"Title"))), @"Introduction", enumerateCollection: true, customControl: sharedControls[0]))), @"Code", enumerateCollection: true)), @"results"))), @"remarks", enumerateCollection: true, customControl: sharedControls[10])))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 40063, 40683);

                var
                DynamicPossibleValues = f_1108_40091_40682(f_1108_40091_40651(f_1108_40091_40618(f_1108_40091_40581(f_1108_40091_40538(f_1108_40091_40401(f_1108_40091_40349(f_1108_40091_40312(f_1108_40091_40269(f_1108_40091_40200(f_1108_40091_40148(f_1108_40091_40113()), leftIndent: 4), @"Value"))), leftIndent: 8), @"Description", enumerateCollection: true, customControl: sharedControls[10])))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 40699, 40976);

                var
                TaskExamplesControl = f_1108_40725_40975(f_1108_40725_40944(f_1108_40725_40911(f_1108_40725_40782(f_1108_40725_40747()), @"Example", enumerateCollection: true, customControl: TaskExampleControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 40992, 41268);

                var
                control18 = f_1108_41008_41267(f_1108_41008_41236(f_1108_41008_41203(f_1108_41008_41065(f_1108_41008_41030()), @"PossibleValue", enumerateCollection: true, customControl: DynamicPossibleValues)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 41284, 41508);

                var
                control17 = f_1108_41300_41507(f_1108_41300_41476(f_1108_41300_41443(f_1108_41300_41357(f_1108_41300_41322()), @"""<"" + $_.Name + "">""")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 41524, 42680);

                var
                DynamicParameterControl = f_1108_41554_42679(f_1108_41554_42648(f_1108_41554_42615(f_1108_41554_42578(f_1108_41554_42535(f_1108_41554_42492(f_1108_41554_42413(f_1108_41554_42338(f_1108_41554_42295(f_1108_41554_42191(f_1108_41554_42148(f_1108_41554_42105(f_1108_41554_42030(f_1108_41554_41978(f_1108_41554_41941(f_1108_41554_41898(f_1108_41554_41804(f_1108_41554_41761(f_1108_41554_41693(f_1108_41554_41650(f_1108_41554_41611(f_1108_41554_41576())), "-"), @"Name"), " "), @"Type", customControl: control17))), leftIndent: 4), @"Description"))), @"PossibleValues", customControl: control18)), f_1108_42377_42412()), @"CmdletSupported"))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 42696, 43656);

                var
                Task = f_1108_42707_43655(f_1108_42707_43624(f_1108_42707_43591(f_1108_42707_43554(f_1108_42707_43511(f_1108_42707_43468(f_1108_42707_43333(f_1108_42707_43290(f_1108_42707_43247(f_1108_42707_43110(f_1108_42707_43058(f_1108_42707_43021(f_1108_42707_42978(f_1108_42707_42935(f_1108_42707_42866(f_1108_42707_42803(f_1108_42707_42764(f_1108_42707_42729())), f_1108_42842_42865()), @"Title")))), leftIndent: 4), @"Description", enumerateCollection: true, customControl: sharedControls[10]))), @"Examples", enumerateCollection: true, customControl: TaskExamplesControl))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 43672, 43965);

                var
                ProviderTasks = f_1108_43692_43964(f_1108_43692_43933(f_1108_43692_43900(f_1108_43692_43861(f_1108_43692_43749(f_1108_43692_43714()), @"Task", enumerateCollection: true, customControl: Task))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 43981, 44262);

                var
                control19 = f_1108_43997_44261(f_1108_43997_44230(f_1108_43997_44197(f_1108_43997_44054(f_1108_43997_44019()), @"DynamicParameter", enumerateCollection: true, customControl: DynamicParameterControl)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 44278, 47683);

                listYield.Add(f_1108_44291_47682("ProviderHelpInfo", f_1108_44353_47681(f_1108_44353_47650(f_1108_44353_47617(f_1108_44353_47580(f_1108_44353_47469(f_1108_44353_47417(f_1108_44353_47378(f_1108_44353_47311(f_1108_44353_47272(f_1108_44353_47235(f_1108_44353_47192(f_1108_44353_47123(f_1108_44353_47071(f_1108_44353_47032(f_1108_44353_46972(f_1108_44353_46935(f_1108_44353_46892(f_1108_44353_46785(f_1108_44353_46733(f_1108_44353_46694(f_1108_44353_46622(f_1108_44353_46585(f_1108_44353_46542(f_1108_44353_46416(f_1108_44353_46364(f_1108_44353_46325(f_1108_44353_46265(f_1108_44353_46228(f_1108_44353_46185(f_1108_44353_46047(f_1108_44353_45995(f_1108_44353_45956(f_1108_44353_45889(f_1108_44353_45852(f_1108_44353_45809(f_1108_44353_45664(f_1108_44353_45612(f_1108_44353_45573(f_1108_44353_45499(f_1108_44353_45462(f_1108_44353_45419(f_1108_44353_45376(f_1108_44353_45277(f_1108_44353_45225(f_1108_44353_45186(f_1108_44353_45123(f_1108_44353_45086(f_1108_44353_45043(f_1108_44353_44911(f_1108_44353_44859(f_1108_44353_44820(f_1108_44353_44759(f_1108_44353_44722(f_1108_44353_44679(f_1108_44353_44636(f_1108_44353_44568(f_1108_44353_44516(f_1108_44353_44477(f_1108_44353_44410(f_1108_44353_44375()), f_1108_44445_44476())), leftIndent: 4), @"Name")))), f_1108_44794_44819())), leftIndent: 4), @"Drives", enumerateCollection: true, customControl: sharedControls[10]))), f_1108_45158_45185())), leftIndent: 4), @"Synopsis", enumerateCollection: true)))), f_1108_45534_45572())), leftIndent: 4), @"DetailedDescription", enumerateCollection: true, customControl: sharedControls[10]))), f_1108_45924_45955())), leftIndent: 4), @"Capabilities", enumerateCollection: true, customControl: sharedControls[10]))), f_1108_46300_46324())), leftIndent: 4), @"Tasks", enumerateCollection: true, customControl: ProviderTasks))), f_1108_46657_46693())), leftIndent: 4), @"DynamicParameters", customControl: control19))), f_1108_47007_47031())), leftIndent: 4), @"Notes")))), f_1108_47346_47377())), leftIndent: 4), @"relatedLinks", customControl: sharedControls[19]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 39012, 47694);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_39167_39189()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39189);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39224(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39224);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39289(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39289);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39328(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39328);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39367(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39367);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39500(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39500);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39539(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39539);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39578(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39578);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39669(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39669);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39708(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39708);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39775(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39775);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39814(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39814);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39853(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39853);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_39167_39982(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 39982);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_39167_40015(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 40015);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_39167_40046(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 39167, 40046);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_40091_40113()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40113);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40148(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40148);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40200(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40200);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40269(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40269);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40312(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40312);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40349(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40349);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40401(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40401);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40538(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40538);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40581(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40581);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40091_40618(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40618);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_40091_40651(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40651);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_40091_40682(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40091, 40682);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_40725_40747()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40725, 40747);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40725_40782(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40725, 40782);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_40725_40911(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40725, 40911);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_40725_40944(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40725, 40944);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_40725_40975(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 40725, 40975);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41008_41030()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41008, 41030);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41008_41065(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41008, 41065);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41008_41203(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41008, 41203);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41008_41236(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41008, 41236);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_41008_41267(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41008, 41267);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41300_41322()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41300, 41322);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41300_41357(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41300, 41357);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41300_41443(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41300, 41443);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41300_41476(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41300, 41476);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_41300_41507(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41300, 41507);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41554_41576()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41611(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41611);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41650(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41650);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41693(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41693);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41761(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41761);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41804(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41804);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41898(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41898);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41941(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41941);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_41978(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 41978);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42030(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42030);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42105(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42105);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42148(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42148);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42191(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42191);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42295(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42295);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42338(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42338);
                    return return_v;
                }


                string
                f_1108_42377_42412()
                {
                    var return_v = HelpDisplayStrings.CmdletsSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 42377, 42412);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42413(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42413);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42492(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42492);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42535(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42535);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42578(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42578);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_41554_42615(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42615);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_41554_42648(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42648);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_41554_42679(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 41554, 42679);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_42707_42729()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42729);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_42764(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42764);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_42803(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42803);
                    return return_v;
                }


                string
                f_1108_42842_42865()
                {
                    var return_v = HelpDisplayStrings.Task;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 42842, 42865);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_42866(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42866);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_42935(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42935);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_42978(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 42978);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43021(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43021);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43058(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43058);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43110(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43110);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43247(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43247);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43290(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43290);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43333(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43333);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43468(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43468);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43511(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43511);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43554(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43554);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_42707_43591(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43591);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_42707_43624(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43624);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_42707_43655(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 42707, 43655);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_43692_43714()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43714);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_43692_43749(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43749);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_43692_43861(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43861);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_43692_43900(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43900);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_43692_43933(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43933);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_43692_43964(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43692, 43964);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_43997_44019()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43997, 44019);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_43997_44054(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43997, 44054);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_43997_44197(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43997, 44197);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_43997_44230(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43997, 44230);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_43997_44261(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 43997, 44261);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_44353_44375()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44375);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44410(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44410);
                    return return_v;
                }


                string
                f_1108_44445_44476()
                {
                    var return_v = HelpDisplayStrings.ProviderName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 44445, 44476);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44477(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44477);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44516(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44516);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44568(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44568);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44636(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44636);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44679(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44679);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44722(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44722);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44759(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44759);
                    return return_v;
                }


                string
                f_1108_44794_44819()
                {
                    var return_v = HelpDisplayStrings.Drives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 44794, 44819);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44820(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44820);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44859(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44859);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_44911(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 44911);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45043(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45043);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45086(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45086);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45123(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45123);
                    return return_v;
                }


                string
                f_1108_45158_45185()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 45158, 45185);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45186(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45186);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45225(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45225);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45277(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45277);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45376(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45376);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45419(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45419);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45462(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45462);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45499(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45499);
                    return return_v;
                }


                string
                f_1108_45534_45572()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 45534, 45572);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45573(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45573);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45612(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45612);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45664(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45664);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45809(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45809);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45852(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45852);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45889(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45889);
                    return return_v;
                }


                string
                f_1108_45924_45955()
                {
                    var return_v = HelpDisplayStrings.Capabilities;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 45924, 45955);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45956(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45956);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_45995(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 45995);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46047(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46047);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46185(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46185);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46228(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46228);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46265(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46265);
                    return return_v;
                }


                string
                f_1108_46300_46324()
                {
                    var return_v = HelpDisplayStrings.Tasks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 46300, 46324);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46325(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46325);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46364(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46364);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46416(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46416);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46542(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46542);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46585(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46585);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46622(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46622);
                    return return_v;
                }


                string
                f_1108_46657_46693()
                {
                    var return_v = HelpDisplayStrings.DynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 46657, 46693);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46694(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46694);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46733(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46733);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46785(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46785);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46892(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46892);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46935(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46935);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_46972(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 46972);
                    return return_v;
                }


                string
                f_1108_47007_47031()
                {
                    var return_v = HelpDisplayStrings.Notes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 47007, 47031);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47032(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47032);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47071(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47071);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47123(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47123);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47192(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47192);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47235(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47235);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47272(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47272);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47311(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47311);
                    return return_v;
                }


                string
                f_1108_47346_47377()
                {
                    var return_v = HelpDisplayStrings.RelatedLinks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 47346, 47377);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47378(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47378);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47417(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47417);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47469(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47469);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47580(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47580);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_44353_47617(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47617);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_44353_47650(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47650);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_44353_47681(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44353, 47681);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_44291_47682(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 44291, 47682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 39012, 47694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 39012, 47694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_FaqHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 47706, 48743);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 47831, 48732);

                listYield.Add(f_1108_47844_48731("FaqHelpInfo", f_1108_47901_48730(f_1108_47901_48699(f_1108_47901_48666(f_1108_47901_48629(f_1108_47901_48586(f_1108_47901_48454(f_1108_47901_48402(f_1108_47901_48363(f_1108_47901_48302(f_1108_47901_48263(f_1108_47901_48195(f_1108_47901_48127(f_1108_47901_48088(f_1108_47901_48023(f_1108_47901_47958(f_1108_47901_47923()), f_1108_47993_48022()), @"Title")), f_1108_48162_48194()), @"Question")), f_1108_48337_48362())), leftIndent: 4), @"Answer", enumerateCollection: true, customControl: sharedControls[10])))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 47706, 48743);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_47901_47923()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 47923);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_47958(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 47958);
                    return return_v;
                }


                string
                f_1108_47993_48022()
                {
                    var return_v = HelpDisplayStrings.TitleColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 47993, 48022);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48023(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48023);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48088(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48088);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48127(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48127);
                    return return_v;
                }


                string
                f_1108_48162_48194()
                {
                    var return_v = HelpDisplayStrings.QuestionColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 48162, 48194);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48195(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48195);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48263(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48263);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48302(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48302);
                    return return_v;
                }


                string
                f_1108_48337_48362()
                {
                    var return_v = HelpDisplayStrings.Answer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 48337, 48362);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48363(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48363);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48402(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48402);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48454(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48454);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48586(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48586);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48629(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48629);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_47901_48666(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48666);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_47901_48699(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48699);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_47901_48730(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47901, 48730);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_47844_48731(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 47844, 48731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 47706, 48743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 47706, 48743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_GeneralHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 48755, 49678);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 48884, 49667);

                listYield.Add(f_1108_48897_49666("GeneralHelpInfo", f_1108_48958_49665(f_1108_48958_49634(f_1108_48958_49601(f_1108_48958_49564(f_1108_48958_49521(f_1108_48958_49388(f_1108_48958_49336(f_1108_48958_49297(f_1108_48958_49223(f_1108_48958_49184(f_1108_48958_49145(f_1108_48958_49080(f_1108_48958_49015(f_1108_48958_48980()), f_1108_49050_49079()), @"Title"))), f_1108_49258_49296())), leftIndent: 4), @"Content", enumerateCollection: true, customControl: sharedControls[10])))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 48755, 49678);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_48958_48980()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 48980);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49015(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49015);
                    return return_v;
                }


                string
                f_1108_49050_49079()
                {
                    var return_v = HelpDisplayStrings.TitleColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 49050, 49079);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49080(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49080);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49145(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49145);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49184(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49184);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49223(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49223);
                    return return_v;
                }


                string
                f_1108_49258_49296()
                {
                    var return_v = HelpDisplayStrings.DetailedDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 49258, 49296);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49297(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49297);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49336(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49336);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49388(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49388);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49521(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49521);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49564(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49564);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_48958_49601(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49601);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_48958_49634(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49634);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_48958_49665(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48958, 49665);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_48897_49666(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 48897, 49666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 48755, 49678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 48755, 49678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_GlossaryHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 49690, 50573);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 49820, 50562);

                listYield.Add(f_1108_49833_50561("GlossaryHelpInfo", f_1108_49895_50560(f_1108_49895_50529(f_1108_49895_50496(f_1108_49895_50459(f_1108_49895_50416(f_1108_49895_50280(f_1108_49895_50228(f_1108_49895_50189(f_1108_49895_50119(f_1108_49895_50080(f_1108_49895_50016(f_1108_49895_49952(f_1108_49895_49917()), f_1108_49987_50015()), @"Name")), f_1108_50154_50188())), leftIndent: 4), @"Definition", enumerateCollection: true, customControl: sharedControls[10])))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 49690, 50573);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_49895_49917()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 49917);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_49952(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 49952);
                    return return_v;
                }


                string
                f_1108_49987_50015()
                {
                    var return_v = HelpDisplayStrings.TermColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 49987, 50015);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50016(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50016);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50080(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50080);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50119(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50119);
                    return return_v;
                }


                string
                f_1108_50154_50188()
                {
                    var return_v = HelpDisplayStrings.DefinitionColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 50154, 50188);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50189(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50189);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50228(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50228);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50280(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50280);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50416(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50416);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50459(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50459);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_49895_50496(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50496);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_49895_50529(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50529);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_49895_50560(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49895, 50560);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_49833_50561(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 49833, 50561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 49690, 50573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 49690, 50573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ScriptHelpInfo(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 50585, 51460);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 50713, 51449);

                listYield.Add(f_1108_50726_51448("ScriptHelpInfo", f_1108_50786_51447(f_1108_50786_51416(f_1108_50786_51383(f_1108_50786_51346(f_1108_50786_51303(f_1108_50786_51170(f_1108_50786_51118(f_1108_50786_51079(f_1108_50786_51012(f_1108_50786_50973(f_1108_50786_50908(f_1108_50786_50843(f_1108_50786_50808()), f_1108_50878_50907()), @"Title")), f_1108_51047_51078())), leftIndent: 4), @"Content", enumerateCollection: true, customControl: sharedControls[10])))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 50585, 51460);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_50786_50808()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 50808);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_50843(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 50843);
                    return return_v;
                }


                string
                f_1108_50878_50907()
                {
                    var return_v = HelpDisplayStrings.TitleColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 50878, 50907);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_50908(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 50908);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_50973(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 50973);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51012(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51012);
                    return return_v;
                }


                string
                f_1108_51047_51078()
                {
                    var return_v = HelpDisplayStrings.ContentColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 51047, 51078);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51079(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51079);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51118(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51118);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51170(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51170);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51303(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51303);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51346(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51346);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_50786_51383(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51383);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_50786_51416(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51416);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_50786_51447(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50786, 51447);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_50726_51448(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 50726, 51448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 50585, 51460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 50585, 51460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_Examples(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 51472, 51925);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 51614, 51914);

                listYield.Add(f_1108_51627_51913("MamlCommandExamples", f_1108_51692_51912(f_1108_51692_51881(f_1108_51692_51848(f_1108_51692_51749(f_1108_51692_51714()), @"$_", customControl: sharedControls[7])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 51472, 51925);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_51692_51714()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51692, 51714);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_51692_51749(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51692, 51749);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_51692_51848(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51692, 51848);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_51692_51881(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51692, 51881);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_51692_51912(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51692, 51912);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_51627_51913(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 51627, 51913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 51472, 51925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 51472, 51925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_Example(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 51937, 53007);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 52078, 52996);

                listYield.Add(f_1108_52091_52995("MamlCommandExample", f_1108_52155_52994(f_1108_52155_52963(f_1108_52155_52930(f_1108_52155_52802(f_1108_52155_52763(f_1108_52155_52724(f_1108_52155_52657(f_1108_52155_52618(f_1108_52155_52579(f_1108_52155_52488(f_1108_52155_52355(f_1108_52155_52316(f_1108_52155_52277(f_1108_52155_52212(f_1108_52155_52177()), @"Title"))), @"Introduction", enumerateCollection: true, customControl: sharedControls[0]), @"Code", enumerateCollection: true))), @"results"))), @"remarks", enumerateCollection: true, customControl: sharedControls[1])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 51937, 53007);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_52155_52177()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52177);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52212(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52212);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52277(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52277);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52316(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52316);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52355(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52355);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52488(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52488);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52579(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52579);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52618(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52618);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52657(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52657);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52724(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52724);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52763(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52763);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52802(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52802);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_52155_52930(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52930);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_52155_52963(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52963);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_52155_52994(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52155, 52994);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_52091_52995(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 52091, 52995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 51937, 53007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 51937, 53007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_commandDetails(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 53019, 54053);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 53167, 54042);

                listYield.Add(f_1108_53180_54041("MamlCommandDetails", f_1108_53244_54040(f_1108_53244_54009(f_1108_53244_53976(f_1108_53244_53939(f_1108_53244_53796(f_1108_53244_53744(f_1108_53244_53705(f_1108_53244_53642(f_1108_53244_53605(f_1108_53244_53562(f_1108_53244_53519(f_1108_53244_53451(f_1108_53244_53399(f_1108_53244_53360(f_1108_53244_53301(f_1108_53244_53266()), f_1108_53336_53359())), leftIndent: 4), @"Name")))), f_1108_53677_53704())), leftIndent: 4), @"commandDescription", enumerateCollection: true, customControl: sharedControls[1]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 53019, 54053);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_53244_53266()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53266);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53301(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53301);
                    return return_v;
                }


                string
                f_1108_53336_53359()
                {
                    var return_v = HelpDisplayStrings.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 53336, 53359);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53360(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53360);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53399(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53399);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53451(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53451);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53519(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53519);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53562(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53562);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53605(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53605);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53642(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53642);
                    return return_v;
                }


                string
                f_1108_53677_53704()
                {
                    var return_v = HelpDisplayStrings.Synopsis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1108, 53677, 53704);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53705(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53705);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53744(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53744);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53796(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53796);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53939(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53939);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_53244_53976(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 53976);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_53244_54009(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 54009);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_53244_54040(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53244, 54040);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_53180_54041(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 53180, 54041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 53019, 54053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 53019, 54053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_Parameters(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 54065, 54596);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 54209, 54585);

                listYield.Add(f_1108_54222_54584("MamlCommandParameters", f_1108_54289_54583(f_1108_54289_54552(f_1108_54289_54519(f_1108_54289_54482(f_1108_54289_54398(f_1108_54289_54346(f_1108_54289_54311()), leftIndent: 4), sharedControls[22]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 54065, 54596);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_54289_54311()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54311);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54289_54346(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54346);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54289_54398(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54398);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54289_54482(System.Management.Automation.CustomEntryBuilder
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddCustomControlExpressionBinding(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54482);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54289_54519(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54519);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_54289_54552(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54552);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_54289_54583(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54289, 54583);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_54222_54584(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54222, 54584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 54065, 54596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 54065, 54596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_Parameter(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 54608, 55068);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 54751, 55057);

                listYield.Add(f_1108_54764_55056("MamlCommandParameterView", f_1108_54834_55055(f_1108_54834_55024(f_1108_54834_54991(f_1108_54834_54891(f_1108_54834_54856()), @"$_", customControl: sharedControls[21])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 54608, 55068);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_54834_54856()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54834, 54856);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54834_54891(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54834, 54891);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_54834_54991(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54834, 54991);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_54834_55024(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54834, 55024);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_54834_55055(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54834, 55055);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_54764_55056(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 54764, 55056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 54608, 55068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 54608, 55068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_Syntax(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 55080, 55530);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 55220, 55519);

                listYield.Add(f_1108_55233_55518("MamlCommandSyntax", f_1108_55296_55517(f_1108_55296_55486(f_1108_55296_55453(f_1108_55296_55353(f_1108_55296_55318()), @"$_", customControl: sharedControls[16])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 55080, 55530);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_55296_55318()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55296, 55318);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_55296_55353(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55296, 55353);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_55296_55453(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55296, 55453);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_55296_55486(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55296, 55486);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_55296_55517(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55296, 55517);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_55233_55518(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55233, 55518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 55080, 55530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 55080, 55530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlDefinitionTextItem_MamlOrderedListTextItem_MamlParaTextItem_MamlUnorderedListTextItem(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 55542, 56045);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 55745, 56034);

                listYield.Add(f_1108_55758_56033("MamlText", f_1108_55812_56032(f_1108_55812_56001(f_1108_55812_55968(f_1108_55812_55869(f_1108_55812_55834()), @"$_", customControl: sharedControls[4])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 55542, 56045);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_55812_55834()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55812, 55834);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_55812_55869(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55812, 55869);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_55812_55968(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55812, 55968);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_55812_56001(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55812, 56001);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_55812_56032(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55812, 56032);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_55758_56033(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 55758, 56033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 55542, 56045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 55542, 56045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_inputTypes(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 56057, 56539);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 56201, 56528);

                listYield.Add(f_1108_56214_56527("MamlInputTypes", f_1108_56274_56526(f_1108_56274_56495(f_1108_56274_56462(f_1108_56274_56331(f_1108_56274_56296()), @"InputType", enumerateCollection: true, customControl: sharedControls[17])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 56057, 56539);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_56274_56296()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56274, 56296);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_56274_56331(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56274, 56331);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_56274_56462(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56274, 56462);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_56274_56495(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56274, 56495);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_56274_56526(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56274, 56526);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_56214_56527(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56214, 56527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 56057, 56539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 56057, 56539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_nonTerminatingErrors(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 56551, 57063);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 56705, 57052);

                listYield.Add(f_1108_56718_57051("MamlNonTerminatingErrors", f_1108_56788_57050(f_1108_56788_57019(f_1108_56788_56986(f_1108_56788_56845(f_1108_56788_56810()), @"nonTerminatingError", enumerateCollection: true, customControl: sharedControls[20])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 56551, 57063);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_56788_56810()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56788, 56810);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_56788_56845(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56788, 56845);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_56788_56986(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56788, 56986);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_56788_57019(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56788, 57019);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_56788_57050(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56788, 57050);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_56718_57051(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 56718, 57051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 56551, 57063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 56551, 57063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_terminatingErrors(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 57075, 57578);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 57226, 57567);

                listYield.Add(f_1108_57239_57566("MamlTerminatingErrors", f_1108_57306_57565(f_1108_57306_57534(f_1108_57306_57501(f_1108_57306_57363(f_1108_57306_57328()), @"terminatingError", enumerateCollection: true, customControl: sharedControls[20])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 57075, 57578);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_57306_57328()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57306, 57328);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_57306_57363(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57306, 57363);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_57306_57501(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57306, 57501);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_57306_57534(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57306, 57534);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_57306_57565(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57306, 57565);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_57239_57566(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57239, 57566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 57075, 57578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 57075, 57578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_relatedLinks(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 57590, 58045);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 57736, 58034);

                listYield.Add(f_1108_57749_58033("MamlRelatedLinks", f_1108_57811_58032(f_1108_57811_58001(f_1108_57811_57968(f_1108_57811_57868(f_1108_57811_57833()), @"$_", customControl: sharedControls[19])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 57590, 58045);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_57811_57833()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57811, 57833);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_57811_57868(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57811, 57868);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_57811_57968(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57811, 57968);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_57811_58001(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57811, 58001);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_57811_58032(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57811, 58032);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_57749_58033(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 57749, 58033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 57590, 58045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 57590, 58045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_returnValues(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 58057, 58544);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 58203, 58533);

                listYield.Add(f_1108_58216_58532("MamlReturnTypes", f_1108_58277_58531(f_1108_58277_58500(f_1108_58277_58467(f_1108_58277_58334(f_1108_58277_58299()), @"ReturnValue", enumerateCollection: true, customControl: sharedControls[17])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 58057, 58544);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_58277_58299()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58277, 58299);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58277_58334(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58277, 58334);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58277_58467(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58277, 58467);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_58277_58500(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58277, 58500);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_58277_58531(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58277, 58531);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_58216_58532(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58216, 58532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 58057, 58544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 58057, 58544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_alertSet(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 58556, 59266);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 58698, 59255);

                listYield.Add(f_1108_58711_59254("MamlAlertSet", f_1108_58769_59253(f_1108_58769_59222(f_1108_58769_59189(f_1108_58769_59152(f_1108_58769_59021(f_1108_58769_58969(f_1108_58769_58930(f_1108_58769_58891(f_1108_58769_58826(f_1108_58769_58791()), @"title"))), leftIndent: 4), @"alert", enumerateCollection: true, customControl: sharedControls[11]))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 58556, 59266);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_58769_58791()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 58791);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_58826(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 58826);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_58891(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 58891);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_58930(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 58930);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_58969(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 58969);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_59021(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 59021);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_59152(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 59152);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_58769_59189(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 59189);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_58769_59222(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 59222);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_58769_59253(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58769, 59253);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_58711_59254(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 58711, 59254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 58556, 59266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 58556, 59266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_MamlCommandHelpInfo_details(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1108, 59278, 59722);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1108, 59419, 59711);

                listYield.Add(f_1108_59432_59710("MamlDetails", f_1108_59489_59709(f_1108_59489_59678(f_1108_59489_59645(f_1108_59489_59546(f_1108_59489_59511()), @"$_", customControl: sharedControls[2])))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1108, 59278, 59722);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1108_59489_59511()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59489, 59511);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_59489_59546(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59489, 59546);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1108_59489_59645(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59489, 59645);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1108_59489_59678(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59489, 59678);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1108_59489_59709(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59489, 59709);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1108_59432_59710(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1108, 59432, 59710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1108, 59278, 59722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 59278, 59722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Help_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1108, 240, 59729);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1108, 240, 59729);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 240, 59729);
        }


        static Help_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1108, 240, 59729);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1108, 240, 59729);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1108, 240, 59729);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1108, 240, 59729);
    }
}
