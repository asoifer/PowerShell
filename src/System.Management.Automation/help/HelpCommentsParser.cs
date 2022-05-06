// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Help;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace System.Management.Automation
{
internal class HelpCommentsParser
{
private HelpCommentsParser()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1151,713,763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1719,1761);
this._sections = f_1151_1731_1761();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1816,1862);
this._parameters = f_1151_1830_1862();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1903,1933);
this._examples = f_1151_1915_1933();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1974,2002);
this._inputs = f_1151_1984_2002();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2043,2072);
this._outputs = f_1151_2054_2072();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2113,2140);
this._links = f_1151_2122_2140();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2165,2190);
this.isExternalHelpSet = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2223,2235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2270,2286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2312,2324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2356,2378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2409,2413);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1151,713,763);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,713,763);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,713,763);
}
		}

private HelpCommentsParser(List<string> parameterDescriptions)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1151,775,920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1719,1761);
this._sections = f_1151_1731_1761();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1816,1862);
this._parameters = f_1151_1830_1862();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1903,1933);
this._examples = f_1151_1915_1933();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1974,2002);
this._inputs = f_1151_1984_2002();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2043,2072);
this._outputs = f_1151_2054_2072();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2113,2140);
this._links = f_1151_2122_2140();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2165,2190);
this.isExternalHelpSet = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2223,2235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2270,2286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2312,2324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2356,2378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2409,2413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,862,909);

_parameterDescriptions = parameterDescriptions;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1151,775,920);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,775,920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,775,920);
}
		}

private HelpCommentsParser(CommandInfo commandInfo, List<string> parameterDescriptions)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1151,932,1665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1719,1761);
this._sections = f_1151_1731_1761();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1816,1862);
this._parameters = f_1151_1830_1862();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1903,1933);
this._examples = f_1151_1915_1933();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1974,2002);
this._inputs = f_1151_1984_2002();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2043,2072);
this._outputs = f_1151_2054_2072();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2113,2140);
this._links = f_1151_2122_2140();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2165,2190);
this.isExternalHelpSet = false;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2223,2235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2270,2286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2312,2324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2356,2378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2409,2413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1044,1090);

FunctionInfo 
fi = commandInfo as FunctionInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1104,1530) || true) && (fi != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,1104,1530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1152,1182);

_scriptBlock = f_1151_1167_1181(fi);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1200,1223);

_commandName = f_1151_1215_1222(fi);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,1104,1530);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,1104,1530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1289,1347);

ExternalScriptInfo 
si = commandInfo as ExternalScriptInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1365,1515) || true) && (si != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,1365,1515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1421,1451);

_scriptBlock = f_1151_1436_1450(si);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1473,1496);

_commandName = f_1151_1488_1495(si);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,1365,1515);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,1104,1530);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1546,1593);

_commandMetadata = f_1151_1565_1592(commandInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,1607,1654);

_parameterDescriptions = parameterDescriptions;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1151,932,1665);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,932,1665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,932,1665);
}
		}

private readonly Language.CommentHelpInfo _sections ;

private readonly Dictionary<string, string> _parameters ;

private readonly List<string> _examples ;

private readonly List<string> _inputs ;

private readonly List<string> _outputs ;

private readonly List<string> _links ;

internal bool isExternalHelpSet ;

private ScriptBlock _scriptBlock;

private CommandMetadata _commandMetadata;

private string _commandName;

private List<string> _parameterDescriptions;

private XmlDocument _doc;

internal static readonly string mshURI ;

internal static readonly string mamlURI ;

internal static readonly string commandURI ;

internal static readonly string devURI ;

private const string 
directive = @"^\s*\.(\w+)(\s+(\S.*))?\s*$"
;

private const string 
blankline = @"^\s*$"
;

internal static readonly string ProviderHelpCommandXPath ;

private void DetermineParameterDescriptions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,3488,4133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3558,3568);

int 
i = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3582,4122);
foreach(string parameterName in f_1151_3615_3686_I(f_1151_3615_3686(f_1151_3615_3681(f_1151_3615_3662(_commandMetadata)))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,3582,4122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3720,3739);

string 
description
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3757,4083) || true) && (!f_1151_3762_3836(_parameters, f_1151_3786_3818(parameterName), out description))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,3757,4083);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3878,4064) || true) && (i < f_1151_3886_3914(_parameterDescriptions))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,3878,4064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3964,4041);

f_1151_3964_4040(                        _parameters, f_1151_3980_4012(parameterName), f_1151_4014_4039(_parameterDescriptions, i));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,3878,4064);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,3757,4083);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4103,4107);

++i;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,3582,4122);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,541);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,541);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1151,3488,4133);

System.Management.Automation.MergedCommandParameterMetadata
f_1151_3615_3662(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.StaticCommandParameterMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 3615, 3662);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1151_3615_3681(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 3615, 3681);
return return_v;
}


System.Collections.Generic.ICollection<string>
f_1151_3615_3686(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 3615, 3686);
return return_v;
}


string
f_1151_3786_3818(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 3786, 3818);
return return_v;
}


bool
f_1151_3762_3836(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 3762, 3836);
return return_v;
}


int
f_1151_3886_3914(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 3886, 3914);
return return_v;
}


string
f_1151_3980_4012(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 3980, 4012);
return return_v;
}


string
f_1151_4014_4039(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 4014, 4039);
return return_v;
}


int
f_1151_3964_4040(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,string
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 3964, 4040);
return 0;
}


System.Collections.Generic.ICollection<string>
f_1151_3615_3686_I(System.Collections.Generic.ICollection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 3615, 3686);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,3488,4133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,3488,4133);
}
		}

private string GetParameterDescription(string parameterName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,4145,4491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4230,4323);

f_1151_4230_4322(!f_1151_4250_4285(parameterName), "Parameter name must not be empty");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4339,4358);

string 
description
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4372,4447);

f_1151_4372_4446(            _parameters, f_1151_4396_4428(parameterName), out description);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4461,4480);

return description;
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,4145,4491);

bool
f_1151_4250_4285(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 4250, 4285);
return return_v;
}


int
f_1151_4230_4322(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 4230, 4322);
return 0;
}


string
f_1151_4396_4428(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 4396, 4428);
return return_v;
}


bool
f_1151_4372_4446(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 4372, 4446);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,4145,4491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,4145,4491);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private XmlElement BuildXmlForParameter(
            string parameterName,
            bool isMandatory,
            bool valueFromPipeline,
            bool valueFromPipelineByPropertyName,
            string position,
            Type type,
            string description,
            bool supportsWildcards,
            string defaultValue,
            bool forSyntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,4503,8929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,4909,4992);

XmlElement 
command_parameter = f_1151_4940_4991(_doc, "command:parameter", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5006,5081);

f_1151_5006_5080(            command_parameter, "required", (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 5049, 5060)||((isMandatory &&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 5063, 5069))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 5072, 5079)))?"true" :"false");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5172,5253);

f_1151_5172_5252(            // command_parameter.SetAttribute("variableLength", "unknown");
            command_parameter, "globbing", (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 5215, 5232)||((supportsWildcards &&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 5235, 5241))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 5244, 5251)))?"true" :"false");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5267,5287);

string 
fromPipeline
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5301,5806) || true) && (valueFromPipeline &&(DynAbs.Tracing.TraceSender.Expression_True(1151, 5305, 5357)&&valueFromPipelineByPropertyName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5301,5806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5391,5439);

fromPipeline = "true (ByValue, ByPropertyName)";
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5301,5806);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5301,5806);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5473,5806) || true) && (valueFromPipeline)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5473,5806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5528,5560);

fromPipeline = "true (ByValue)";
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5473,5806);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5473,5806);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5594,5806) || true) && (valueFromPipelineByPropertyName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5594,5806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5663,5702);

fromPipeline = "true (ByPropertyName)";
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5594,5806);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,5594,5806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5768,5791);

fromPipeline = "false";
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5594,5806);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5473,5806);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,5301,5806);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5822,5884);

f_1151_5822_5883(
            command_parameter, "pipelineInput", fromPipeline);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5898,5951);

f_1151_5898_5950(            command_parameter, "position", position);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,5967,6026);

XmlElement 
name = f_1151_5985_6025(_doc, "maml:name", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6040,6095);

XmlText 
name_text = f_1151_6060_6094(_doc, parameterName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6109,6168);

f_1151_6109_6167(f_1151_6109_6144(            command_parameter, name), name_text);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6182,6622) || true) && (!f_1151_6187_6220(description))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,6182,6622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6254,6332);

XmlElement 
maml_description = f_1151_6284_6331(_doc, "maml:description", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6350,6414);

XmlElement 
maml_para = f_1151_6373_6413(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6432,6490);

XmlText 
maml_para_text = f_1151_6457_6489(_doc, description)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6508,6607);

f_1151_6508_6606(f_1151_6508_6578(f_1151_6508_6555(                command_parameter, maml_description), maml_para), maml_para_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,6182,6622);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6638,6695) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,6638,6695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6673,6695);

type = typeof(object);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,6638,6695);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6711,6773);

var 
elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 6729, 6741)||((f_1151_6729_6741(type)&&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 6744, 6765))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 6768, 6772)))?f_1151_6744_6765(type):type
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6789,8198) || true) && (f_1151_6793_6811(elementType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,6789,8198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6845,6940);

XmlElement 
parameterValueGroup = f_1151_6878_6939(_doc, "command:parameterValueGroup", commandURI)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,6958,7416);
foreach(string valueName in f_1151_6987_7013_I(f_1151_6987_7013(elementType)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,6958,7416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7055,7140);

XmlElement 
parameterValue = f_1151_7083_7139(_doc, "command:parameterValue", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7162,7211);

f_1151_7162_7210(                    parameterValue, "required", "false");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7233,7294);

XmlText 
parameterValue_text = f_1151_7263_7293(_doc, valueName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7316,7397);

f_1151_7316_7396(f_1151_7316_7363(                    parameterValueGroup, parameterValue), parameterValue_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,6958,7416);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,459);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,459);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7436,7487);

f_1151_7436_7486(
                command_parameter, parameterValueGroup);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,6789,8198);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,6789,8198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7553,7617);

bool 
isSwitchParameter = elementType == typeof(SwitchParameter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7635,8183) || true) && (!forSyntax ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 7639, 7671)||!isSwitchParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,7635,8183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7713,7798);

XmlElement 
parameterValue = f_1151_7741_7797(_doc, "command:parameterValue", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,7820,7898);

f_1151_7820_7897(                    parameterValue, "required", (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 7860, 7877)||((isSwitchParameter &&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 7880, 7887))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 7890, 7896)))?"false" :"true");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8002,8063);

XmlText 
parameterValue_text = f_1151_8032_8062(_doc, f_1151_8052_8061(type))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8085,8164);

f_1151_8085_8163(f_1151_8085_8130(                    command_parameter, parameterValue), parameterValue_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,7635,8183);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,6789,8198);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8214,8877) || true) && (!forSyntax)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,8214,8877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8262,8322);

XmlElement 
devType = f_1151_8283_8321(_doc, "dev:type", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8340,8403);

XmlElement 
typeName = f_1151_8362_8402(_doc, "maml:name", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8421,8476);

XmlText 
typeName_text = f_1151_8445_8475(_doc, f_1151_8465_8474(type))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8494,8582);

f_1151_8494_8581(f_1151_8494_8554(f_1151_8494_8532(                command_parameter, devType), typeName), typeName_text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8602,8682);

XmlElement 
defaultValueElement = f_1151_8635_8681(_doc, "dev:defaultValue", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8700,8762);

XmlText 
defaultValue_text = f_1151_8728_8761(_doc, defaultValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8780,8862);

f_1151_8780_8861(f_1151_8780_8830(                command_parameter, defaultValueElement), defaultValue_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,8214,8877);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,8893,8918);

return command_parameter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,4503,8929);

System.Xml.XmlElement
f_1151_4940_4991(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 4940, 4991);
return return_v;
}


int
f_1151_5006_5080(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 5006, 5080);
return 0;
}


int
f_1151_5172_5252(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 5172, 5252);
return 0;
}


int
f_1151_5822_5883(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 5822, 5883);
return 0;
}


int
f_1151_5898_5950(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 5898, 5950);
return 0;
}


System.Xml.XmlElement
f_1151_5985_6025(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 5985, 6025);
return return_v;
}


System.Xml.XmlText
f_1151_6060_6094(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6060, 6094);
return return_v;
}


System.Xml.XmlNode
f_1151_6109_6144(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6109, 6144);
return return_v;
}


System.Xml.XmlNode
f_1151_6109_6167(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6109, 6167);
return return_v;
}


bool
f_1151_6187_6220(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6187, 6220);
return return_v;
}


System.Xml.XmlElement
f_1151_6284_6331(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6284, 6331);
return return_v;
}


System.Xml.XmlElement
f_1151_6373_6413(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6373, 6413);
return return_v;
}


System.Xml.XmlText
f_1151_6457_6489(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6457, 6489);
return return_v;
}


System.Xml.XmlNode
f_1151_6508_6555(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6508, 6555);
return return_v;
}


System.Xml.XmlNode
f_1151_6508_6578(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6508, 6578);
return return_v;
}


System.Xml.XmlNode
f_1151_6508_6606(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6508, 6606);
return return_v;
}


bool
f_1151_6729_6741(System.Type
this_param)
{
var return_v = this_param.IsArray ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 6729, 6741);
return return_v;
}


System.Type?
f_1151_6744_6765(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6744, 6765);
return return_v;
}


bool
f_1151_6793_6811(System.Type
this_param)
{
var return_v = this_param.IsEnum;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 6793, 6811);
return return_v;
}


System.Xml.XmlElement
f_1151_6878_6939(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6878, 6939);
return return_v;
}


string[]
f_1151_6987_7013(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6987, 7013);
return return_v;
}


System.Xml.XmlElement
f_1151_7083_7139(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7083, 7139);
return return_v;
}


int
f_1151_7162_7210(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7162, 7210);
return 0;
}


System.Xml.XmlText
f_1151_7263_7293(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7263, 7293);
return return_v;
}


System.Xml.XmlNode
f_1151_7316_7363(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7316, 7363);
return return_v;
}


System.Xml.XmlNode
f_1151_7316_7396(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7316, 7396);
return return_v;
}


string[]
f_1151_6987_7013_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 6987, 7013);
return return_v;
}


System.Xml.XmlNode
f_1151_7436_7486(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7436, 7486);
return return_v;
}


System.Xml.XmlElement
f_1151_7741_7797(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7741, 7797);
return return_v;
}


int
f_1151_7820_7897(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 7820, 7897);
return 0;
}


string
f_1151_8052_8061(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 8052, 8061);
return return_v;
}


System.Xml.XmlText
f_1151_8032_8062(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8032, 8062);
return return_v;
}


System.Xml.XmlNode
f_1151_8085_8130(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8085, 8130);
return return_v;
}


System.Xml.XmlNode
f_1151_8085_8163(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8085, 8163);
return return_v;
}


System.Xml.XmlElement
f_1151_8283_8321(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8283, 8321);
return return_v;
}


System.Xml.XmlElement
f_1151_8362_8402(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8362, 8402);
return return_v;
}


string
f_1151_8465_8474(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 8465, 8474);
return return_v;
}


System.Xml.XmlText
f_1151_8445_8475(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8445, 8475);
return return_v;
}


System.Xml.XmlNode
f_1151_8494_8532(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8494, 8532);
return return_v;
}


System.Xml.XmlNode
f_1151_8494_8554(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8494, 8554);
return return_v;
}


System.Xml.XmlNode
f_1151_8494_8581(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8494, 8581);
return return_v;
}


System.Xml.XmlElement
f_1151_8635_8681(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8635, 8681);
return return_v;
}


System.Xml.XmlText
f_1151_8728_8761(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8728, 8761);
return return_v;
}


System.Xml.XmlNode
f_1151_8780_8830(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8780, 8830);
return return_v;
}


System.Xml.XmlNode
f_1151_8780_8861(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 8780, 8861);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,4503,8929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,4503,8929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal XmlDocument BuildXmlFromComments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,9140,21866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9208,9290);

f_1151_9208_9289(!f_1151_9228_9262(_commandName), "Name can never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9306,9331);

_doc = f_1151_9313_9330();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9345,9416);

XmlElement 
command = f_1151_9366_9415(_doc, "command:command", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9430,9474);

f_1151_9430_9473(            command, "xmlns:maml", mamlURI);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9488,9538);

f_1151_9488_9537(            command, "xmlns:command", commandURI);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9552,9594);

f_1151_9552_9593(            command, "xmlns:dev", devURI);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9608,9634);

f_1151_9608_9633(            _doc, command);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9650,9721);

XmlElement 
details = f_1151_9671_9720(_doc, "command:details", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9735,9764);

f_1151_9735_9763(            command, details);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9780,9845);

XmlElement 
name = f_1151_9798_9844(_doc, "command:name", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9859,9913);

XmlText 
name_text = f_1151_9879_9912(_doc, _commandName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9927,9976);

f_1151_9927_9975(f_1151_9927_9952(            details, name), name_text);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,9992,10426) || true) && (!f_1151_9997_10037(f_1151_10018_10036(_sections)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,9992,10426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10071,10141);

XmlElement 
synopsis = f_1151_10093_10140(_doc, "maml:description", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10159,10227);

XmlElement 
synopsis_para = f_1151_10186_10226(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10245,10309);

XmlText 
synopsis_text = f_1151_10269_10308(_doc, f_1151_10289_10307(_sections))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10327,10411);

f_1151_10327_10410(f_1151_10327_10383(f_1151_10327_10356(                details, synopsis), synopsis_para), synopsis_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,9992,10426);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10550,10583);

f_1151_10550_10582(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10599,10668);

XmlElement 
syntax = f_1151_10619_10667(_doc, "command:syntax", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10682,10781);

MergedCommandParameterMetadata 
parameterMetadata = f_1151_10733_10780(_commandMetadata)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10795,11217) || true) && (f_1151_10799_10834(parameterMetadata)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,10795,11217);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10881,10886);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10872,11059) || true) && (i < f_1151_10892_10927(parameterMetadata))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10929,10932)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,10872,11059))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,10872,11059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,10974,11040);

f_1151_10974_11039(this, command, syntax, parameterMetadata, i);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,188);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,188);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1151,10795,11217);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,10795,11217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11125,11202);

f_1151_11125_11201(this, command, syntax, parameterMetadata, int.MaxValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,10795,11217);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11300,11384);

XmlElement 
commandParameters = f_1151_11331_11383(_doc, "command:parameters", commandURI)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11398,15055);
foreach(KeyValuePair<string, MergedCompiledCommandParameter> pair in f_1151_11468_11504_I(f_1151_11468_11504(parameterMetadata)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,11398,15055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11538,11598);

MergedCompiledCommandParameter 
mergedParameter = pair.Value
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11616,11770) || true) && (f_1151_11620_11653(mergedParameter)== ParameterBinderAssociation.CommonParameters)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,11616,11770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11742,11751);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,11616,11770);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11790,11822);

string 
parameterName = pair.Key
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11840,11900);

string 
description = f_1151_11861_11899(this, parameterName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11920,11966);

ParameterSetSpecificMetadata 
parameterSetData
=default(ParameterSetSpecificMetadata);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,11984,12009);

bool 
isMandatory = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12027,12058);

bool 
valueFromPipeline = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12076,12121);

bool 
valueFromPipelineByPropertyName = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12139,12165);

string 
position = "named"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12183,12193);

int 
i = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12213,12276);

CompiledCommandParameter 
parameter = f_1151_12250_12275(mergedParameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12294,12392);

f_1151_12294_12391(f_1151_12294_12320(parameter), ParameterAttribute.AllParameterSets, out parameterSetData);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12410,12572) || true) && (parameterSetData == null &&(DynAbs.Tracing.TraceSender.Expression_True(1151, 12417, 12451)&&i < 32))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,12410,12572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12493,12553);

parameterSetData = f_1151_12512_12552(parameter, 1u << i++);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,12410,12572);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,12410,12572);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,12410,12572);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12592,13052) || true) && (parameterSetData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,12592,13052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12662,12705);

isMandatory = f_1151_12676_12704(parameterSetData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12727,12782);

valueFromPipeline = f_1151_12747_12781(parameterSetData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12804,12887);

valueFromPipelineByPropertyName = f_1151_12838_12886(parameterSetData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,12909,13033);

position = (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 12920, 12949)||((f_1151_12920_12949(parameterSetData)&&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 12952, 13022))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 13025, 13032)))?f_1151_12952_13022((1 + f_1151_12957_12982(parameterSetData)), f_1151_12993_13021()):"named";
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,12592,13052);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13072,13126);

var 
compiledAttributes = f_1151_13097_13125(parameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13144,13231);

bool 
supportsWildcards = f_1151_13169_13230(f_1151_13169_13224(compiledAttributes))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13251,13289);

string 
defaultValueStr = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13307,13334);

object 
defaultValue = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13352,13450);

var 
defaultValueAttribute = f_1151_13380_13449(f_1151_13380_13432(compiledAttributes))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13468,13786) || true) && (defaultValueAttribute != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,13468,13786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13543,13588);

defaultValueStr = f_1151_13561_13587(defaultValueAttribute);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13610,13767) || true) && (f_1151_13614_13651(defaultValueStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,13610,13767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13701,13744);

defaultValue = f_1151_13716_13743(defaultValueAttribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,13610,13767);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,13468,13786);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13806,14688) || true) && (f_1151_13810_13847(defaultValueStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,13806,14688);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13889,14227) || true) && (defaultValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,13889,14227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,13963,13991);

RuntimeDefinedParameter 
rdp
=default(RuntimeDefinedParameter);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14017,14204) || true) && (f_1151_14021_14094(f_1151_14021_14058(_scriptBlock), parameterName, out rdp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,14017,14204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14152,14177);

defaultValue = f_1151_14167_14176(rdp);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,14017,14204);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,13889,14227);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14251,14320);

var 
wrapper = defaultValue as Compiler.DefaultValueExpressionWrapper
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14342,14669) || true) && (wrapper != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,14342,14669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14411,14460);

defaultValueStr = f_1151_14429_14459(f_1151_14429_14454(f_1151_14429_14447(wrapper)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,14342,14669);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,14342,14669);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14510,14669) || true) && (defaultValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,14510,14669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14584,14646);

defaultValueStr = f_1151_14602_14645(null, defaultValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,14510,14669);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,14342,14669);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,13806,14688);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14708,14974);

XmlElement 
parameterElement = f_1151_14738_14973(this, parameterName, isMandatory, valueFromPipeline, valueFromPipelineByPropertyName, position, f_1151_14891_14905(parameter), description, supportsWildcards, defaultValueStr, forSyntax: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,14992,15040);

f_1151_14992_15039(                commandParameters, parameterElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,11398,15055);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,3658);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,3658);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15071,15110);

f_1151_15071_15109(
            command, commandParameters);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15163,15621) || true) && (!f_1151_15168_15211(f_1151_15189_15210(_sections)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,15163,15621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15245,15318);

XmlElement 
description = f_1151_15270_15317(_doc, "maml:description", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15336,15407);

XmlElement 
description_para = f_1151_15366_15406(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15425,15495);

XmlText 
description_text = f_1151_15452_15494(_doc, f_1151_15472_15493(_sections))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15513,15606);

f_1151_15513_15605(f_1151_15513_15575(f_1151_15513_15545(                command, description), description_para), description_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,15163,15621);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15637,16158) || true) && (!f_1151_15642_15679(f_1151_15663_15678(_sections)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,15637,16158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15713,15780);

XmlElement 
alertSet = f_1151_15735_15779(_doc, "maml:alertSet", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15798,15859);

XmlElement 
alert = f_1151_15817_15858(_doc, "maml:alert", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15877,15942);

XmlElement 
alert_para = f_1151_15901_15941(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,15960,16023);

XmlText 
alert_para_text = f_1151_15986_16022(_doc, f_1151_16006_16021(_sections))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16041,16143);

f_1151_16041_16142(f_1151_16041_16113(f_1151_16041_16089(f_1151_16041_16070(                command, alertSet), alert), alert_para), alert_para_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,15637,16158);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16174,18860) || true) && (f_1151_16178_16193(_examples)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,16174,18860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16231,16304);

XmlElement 
examples = f_1151_16253_16303(_doc, "command:examples", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16322,16336);

int 
count = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16354,18795);
foreach(string example in f_1151_16381_16390_I(_examples) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,16354,18795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16432,16508);

XmlElement 
example_node = f_1151_16458_16507(_doc, "command:example", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16593,16654);

XmlElement 
title = f_1151_16612_16653(_doc, "maml:title", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16676,16907);

string 
titleStr = f_1151_16694_16906(f_1151_16708_16736(), "\t\t\t\t-------------------------- {0} {1} --------------------------", f_1151_16861_16896(), count++)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,16929,16980);

XmlText 
title_text = f_1151_16950_16979(_doc, titleStr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17002,17058);

f_1151_17002_17057(f_1151_17002_17033(                    example_node, title), title_text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17082,17100);

string 
prompt_str
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17122,17138);

string 
code_str
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17160,17179);

string 
remarks_str
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17201,17276);

f_1151_17201_17275(example, out prompt_str, out code_str, out remarks_str);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17358,17433);

XmlElement 
introduction = f_1151_17384_17432(_doc, "maml:introduction", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17455,17527);

XmlElement 
introduction_para = f_1151_17486_17526(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17549,17614);

XmlText 
introduction_para_text = f_1151_17582_17613(_doc, prompt_str)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17636,17742);

f_1151_17636_17741(f_1151_17636_17705(f_1151_17636_17674(                    example_node, introduction), introduction_para), introduction_para_text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17803,17860);

XmlElement 
code = f_1151_17821_17859(_doc, "dev:code", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17882,17932);

XmlText 
code_text = f_1151_17902_17931(_doc, code_str)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,17954,18008);

f_1151_17954_18007(f_1151_17954_17984(                    example_node, code), code_text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18092,18155);

XmlElement 
remarks = f_1151_18113_18154(_doc, "dev:remarks", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18177,18244);

XmlElement 
remarks_para = f_1151_18203_18243(_doc, "maml:para", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18266,18327);

XmlText 
remarks_para_text = f_1151_18294_18326(_doc, remarks_str)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18349,18440);

f_1151_18349_18439(f_1151_18349_18408(f_1151_18349_18382(                    example_node, remarks), remarks_para), remarks_para_text);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18565,18570);
                    // The convention is to have 4 blank paras after the example for spacing
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18556,18717) || true) && (i < 4)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18579,18582)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,18556,18717))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,18556,18717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18632,18694);

f_1151_18632_18693(                        remarks, f_1151_18652_18692(_doc, "maml:para", mamlURI));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,162);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,162);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18741,18776);

f_1151_18741_18775(
                    examples, example_node);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,16354,18795);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,2442);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,2442);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18815,18845);

f_1151_18815_18844(
                command, examples);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,16174,18860);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18876,19631) || true) && (f_1151_18880_18893(_inputs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,18876,19631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,18931,19008);

XmlElement 
inputTypes = f_1151_18955_19007(_doc, "command:inputTypes", commandURI)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19026,19564);
foreach(string inputStr in f_1151_19054_19061_I(_inputs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,19026,19564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19103,19178);

XmlElement 
inputType = f_1151_19126_19177(_doc, "command:inputType", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19200,19257);

XmlElement 
type = f_1151_19218_19256(_doc, "dev:type", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19279,19343);

XmlElement 
maml_name = f_1151_19302_19342(_doc, "maml:name", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19365,19420);

XmlText 
maml_name_text = f_1151_19390_19419(_doc, inputStr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19442,19545);

f_1151_19442_19544(f_1151_19442_19516(f_1151_19442_19493(f_1151_19442_19475(                    inputTypes, inputType), type), maml_name), maml_name_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,19026,19564);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,539);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,539);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19584,19616);

f_1151_19584_19615(
                command, inputTypes);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,18876,19631);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19834,19861);

IEnumerable 
outputs = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19875,20104) || true) && (f_1151_19879_19893(_outputs)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,19875,20104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19931,19950);

outputs = _outputs;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,19875,20104);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,19875,20104);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,19984,20104) || true) && (f_1151_19988_20017(f_1151_19988_20011(_scriptBlock))> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,19984,20104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20055,20089);

outputs = f_1151_20065_20088(_scriptBlock);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,19984,20104);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,19875,20104);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20120,20983) || true) && (outputs != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,20120,20983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20173,20254);

XmlElement 
returnValues = f_1151_20199_20253(_doc, "command:returnValues", commandURI)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20272,20914);
foreach(object output in f_1151_20298_20305_I(outputs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,20272,20914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20347,20426);

XmlElement 
returnValue = f_1151_20372_20425(_doc, "command:returnValue", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20448,20505);

XmlElement 
type = f_1151_20466_20504(_doc, "dev:type", devURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20527,20591);

XmlElement 
maml_name = f_1151_20550_20590(_doc, "maml:name", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20613,20683);

string 
returnValueStr = output as string ??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1151, 20637, 20682)??f_1151_20657_20682(((PSTypeName)output)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20705,20766);

XmlText 
maml_name_text = f_1151_20730_20765(_doc, returnValueStr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20788,20895);

f_1151_20788_20894(f_1151_20788_20866(f_1151_20788_20843(f_1151_20788_20825(                    returnValues, returnValue), type), maml_name), maml_name_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,20272,20914);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,643);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,643);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20934,20968);

f_1151_20934_20967(
                command, returnValues);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,20120,20983);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,20999,21827) || true) && (f_1151_21003_21015(_links)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,20999,21827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21053,21121);

XmlElement 
links = f_1151_21072_21120(_doc, "maml:relatedLinks", mamlURI)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21139,21765);
foreach(string link in f_1151_21163_21169_I(_links) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,21139,21765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21211,21290);

XmlElement 
navigationLink = f_1151_21239_21289(_doc, "maml:navigationLink", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21312,21403);

bool 
isOnlineHelp = f_1151_21332_21402(f_1151_21358_21383(link), UriKind.Absolute)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21425,21487);

string 
nodeName = (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 21443, 21455)||((isOnlineHelp &&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 21458, 21468))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 21471, 21486)))?"maml:uri" :"maml:linkText"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21509,21569);

XmlElement 
linkText = f_1151_21531_21568(_doc, nodeName, mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21591,21641);

XmlText 
linkText_text = f_1151_21615_21640(_doc, link)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21663,21746);

f_1151_21663_21745(f_1151_21663_21718(f_1151_21663_21696(                    links, navigationLink), linkText), linkText_text);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,21139,21765);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,627);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,627);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21785,21812);

f_1151_21785_21811(
                command, links);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,20999,21827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,21843,21855);

return _doc;
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,9140,21866);

bool
f_1151_9228_9262(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9228, 9262);
return return_v;
}


int
f_1151_9208_9289(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9208, 9289);
return 0;
}


System.Xml.XmlDocument
f_1151_9313_9330()
{
var return_v = new System.Xml.XmlDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9313, 9330);
return return_v;
}


System.Xml.XmlElement
f_1151_9366_9415(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9366, 9415);
return return_v;
}


int
f_1151_9430_9473(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9430, 9473);
return 0;
}


int
f_1151_9488_9537(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9488, 9537);
return 0;
}


int
f_1151_9552_9593(System.Xml.XmlElement
this_param,string
name,string
value)
{
this_param.SetAttribute( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9552, 9593);
return 0;
}


System.Xml.XmlNode
f_1151_9608_9633(System.Xml.XmlDocument
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9608, 9633);
return return_v;
}


System.Xml.XmlElement
f_1151_9671_9720(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9671, 9720);
return return_v;
}


System.Xml.XmlNode
f_1151_9735_9763(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9735, 9763);
return return_v;
}


System.Xml.XmlElement
f_1151_9798_9844(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9798, 9844);
return return_v;
}


System.Xml.XmlText
f_1151_9879_9912(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9879, 9912);
return return_v;
}


System.Xml.XmlNode
f_1151_9927_9952(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9927, 9952);
return return_v;
}


System.Xml.XmlNode
f_1151_9927_9975(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9927, 9975);
return return_v;
}


string
f_1151_10018_10036(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 10018, 10036);
return return_v;
}


bool
f_1151_9997_10037(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 9997, 10037);
return return_v;
}


System.Xml.XmlElement
f_1151_10093_10140(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10093, 10140);
return return_v;
}


System.Xml.XmlElement
f_1151_10186_10226(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10186, 10226);
return return_v;
}


string
f_1151_10289_10307(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 10289, 10307);
return return_v;
}


System.Xml.XmlText
f_1151_10269_10308(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10269, 10308);
return return_v;
}


System.Xml.XmlNode
f_1151_10327_10356(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10327, 10356);
return return_v;
}


System.Xml.XmlNode
f_1151_10327_10383(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10327, 10383);
return return_v;
}


System.Xml.XmlNode
f_1151_10327_10410(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10327, 10410);
return return_v;
}


int
f_1151_10550_10582(System.Management.Automation.HelpCommentsParser
this_param)
{
this_param.DetermineParameterDescriptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10550, 10582);
return 0;
}


System.Xml.XmlElement
f_1151_10619_10667(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10619, 10667);
return return_v;
}


System.Management.Automation.MergedCommandParameterMetadata
f_1151_10733_10780(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.StaticCommandParameterMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 10733, 10780);
return return_v;
}


int
f_1151_10799_10834(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.ParameterSetCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 10799, 10834);
return return_v;
}


int
f_1151_10892_10927(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.ParameterSetCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 10892, 10927);
return return_v;
}


int
f_1151_10974_11039(System.Management.Automation.HelpCommentsParser
this_param,System.Xml.XmlElement
command,System.Xml.XmlElement
syntax,System.Management.Automation.MergedCommandParameterMetadata
parameterMetadata,int
i)
{
this_param.BuildSyntaxForParameterSet( command, syntax, parameterMetadata, i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 10974, 11039);
return 0;
}


int
f_1151_11125_11201(System.Management.Automation.HelpCommentsParser
this_param,System.Xml.XmlElement
command,System.Xml.XmlElement
syntax,System.Management.Automation.MergedCommandParameterMetadata
parameterMetadata,int
i)
{
this_param.BuildSyntaxForParameterSet( command, syntax, parameterMetadata, i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 11125, 11201);
return 0;
}


System.Xml.XmlElement
f_1151_11331_11383(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 11331, 11383);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1151_11468_11504(System.Management.Automation.MergedCommandParameterMetadata
this_param)
{
var return_v = this_param.BindableParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 11468, 11504);
return return_v;
}


System.Management.Automation.ParameterBinderAssociation
f_1151_11620_11653(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.BinderAssociation ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 11620, 11653);
return return_v;
}


string
f_1151_11861_11899(System.Management.Automation.HelpCommentsParser
this_param,string
parameterName)
{
var return_v = this_param.GetParameterDescription( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 11861, 11899);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1151_12250_12275(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12250, 12275);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
f_1151_12294_12320(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.ParameterSetData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12294, 12320);
return return_v;
}


bool
f_1151_12294_12391(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
this_param,string
key,out System.Management.Automation.ParameterSetSpecificMetadata
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 12294, 12391);
return return_v;
}


System.Management.Automation.ParameterSetSpecificMetadata
f_1151_12512_12552(System.Management.Automation.CompiledCommandParameter
this_param,uint
parameterSetFlag)
{
var return_v = this_param.GetParameterSetData( parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 12512, 12552);
return return_v;
}


bool
f_1151_12676_12704(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12676, 12704);
return return_v;
}


bool
f_1151_12747_12781(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12747, 12781);
return return_v;
}


bool
f_1151_12838_12886(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12838, 12886);
return return_v;
}


bool
f_1151_12920_12949(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsPositional ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12920, 12949);
return return_v;
}


int
f_1151_12957_12982(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12957, 12982);
return return_v;
}


System.Globalization.CultureInfo
f_1151_12993_13021()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 12993, 13021);
return return_v;
}


string
f_1151_12952_13022(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 12952, 13022);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1151_13097_13125(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.CompiledAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 13097, 13125);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.SupportsWildcardsAttribute>
f_1151_13169_13224(System.Collections.ObjectModel.Collection<System.Attribute>
source)
{
var return_v = source.OfType<System.Management.Automation.SupportsWildcardsAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13169, 13224);
return return_v;
}


bool
f_1151_13169_13230(System.Collections.Generic.IEnumerable<System.Management.Automation.SupportsWildcardsAttribute>
source)
{
var return_v = source.Any<System.Management.Automation.SupportsWildcardsAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13169, 13230);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.PSDefaultValueAttribute>
f_1151_13380_13432(System.Collections.ObjectModel.Collection<System.Attribute>
source)
{
var return_v = source.OfType<System.Management.Automation.PSDefaultValueAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13380, 13432);
return return_v;
}


System.Management.Automation.PSDefaultValueAttribute
f_1151_13380_13449(System.Collections.Generic.IEnumerable<System.Management.Automation.PSDefaultValueAttribute>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.PSDefaultValueAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13380, 13449);
return return_v;
}


string
f_1151_13561_13587(System.Management.Automation.PSDefaultValueAttribute
this_param)
{
var return_v = this_param.Help;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 13561, 13587);
return return_v;
}


bool
f_1151_13614_13651(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13614, 13651);
return return_v;
}


object
f_1151_13716_13743(System.Management.Automation.PSDefaultValueAttribute
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 13716, 13743);
return return_v;
}


bool
f_1151_13810_13847(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 13810, 13847);
return return_v;
}


System.Management.Automation.RuntimeDefinedParameterDictionary
f_1151_14021_14058(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.RuntimeDefinedParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14021, 14058);
return return_v;
}


bool
f_1151_14021_14094(System.Management.Automation.RuntimeDefinedParameterDictionary
this_param,string
key,out System.Management.Automation.RuntimeDefinedParameter
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 14021, 14094);
return return_v;
}


object
f_1151_14167_14176(System.Management.Automation.RuntimeDefinedParameter
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14167, 14176);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1151_14429_14447(System.Management.Automation.Language.Compiler.DefaultValueExpressionWrapper
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14429, 14447);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_14429_14454(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14429, 14454);
return return_v;
}


string
f_1151_14429_14459(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14429, 14459);
return return_v;
}


string
f_1151_14602_14645(System.Management.Automation.ExecutionContext
context,object
obj)
{
var return_v = PSObject.ToStringParser( context, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 14602, 14645);
return return_v;
}


System.Type
f_1151_14891_14905(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 14891, 14905);
return return_v;
}


System.Xml.XmlElement
f_1151_14738_14973(System.Management.Automation.HelpCommentsParser
this_param,string
parameterName,bool
isMandatory,bool
valueFromPipeline,bool
valueFromPipelineByPropertyName,string
position,System.Type
type,string
description,bool
supportsWildcards,string
defaultValue,bool
forSyntax)
{
var return_v = this_param.BuildXmlForParameter( parameterName, isMandatory, valueFromPipeline, valueFromPipelineByPropertyName, position, type, description, supportsWildcards, defaultValue, forSyntax: forSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 14738, 14973);
return return_v;
}


System.Xml.XmlNode
f_1151_14992_15039(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 14992, 15039);
return return_v;
}


System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
f_1151_11468_11504_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 11468, 11504);
return return_v;
}


System.Xml.XmlNode
f_1151_15071_15109(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15071, 15109);
return return_v;
}


string
f_1151_15189_15210(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Description;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 15189, 15210);
return return_v;
}


bool
f_1151_15168_15211(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15168, 15211);
return return_v;
}


System.Xml.XmlElement
f_1151_15270_15317(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15270, 15317);
return return_v;
}


System.Xml.XmlElement
f_1151_15366_15406(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15366, 15406);
return return_v;
}


string
f_1151_15472_15493(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Description;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 15472, 15493);
return return_v;
}


System.Xml.XmlText
f_1151_15452_15494(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15452, 15494);
return return_v;
}


System.Xml.XmlNode
f_1151_15513_15545(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15513, 15545);
return return_v;
}


System.Xml.XmlNode
f_1151_15513_15575(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15513, 15575);
return return_v;
}


System.Xml.XmlNode
f_1151_15513_15605(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15513, 15605);
return return_v;
}


string
f_1151_15663_15678(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Notes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 15663, 15678);
return return_v;
}


bool
f_1151_15642_15679(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15642, 15679);
return return_v;
}


System.Xml.XmlElement
f_1151_15735_15779(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15735, 15779);
return return_v;
}


System.Xml.XmlElement
f_1151_15817_15858(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15817, 15858);
return return_v;
}


System.Xml.XmlElement
f_1151_15901_15941(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15901, 15941);
return return_v;
}


string
f_1151_16006_16021(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Notes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 16006, 16021);
return return_v;
}


System.Xml.XmlText
f_1151_15986_16022(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 15986, 16022);
return return_v;
}


System.Xml.XmlNode
f_1151_16041_16070(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16041, 16070);
return return_v;
}


System.Xml.XmlNode
f_1151_16041_16089(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16041, 16089);
return return_v;
}


System.Xml.XmlNode
f_1151_16041_16113(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16041, 16113);
return return_v;
}


System.Xml.XmlNode
f_1151_16041_16142(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16041, 16142);
return return_v;
}


int
f_1151_16178_16193(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 16178, 16193);
return return_v;
}


System.Xml.XmlElement
f_1151_16253_16303(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16253, 16303);
return return_v;
}


System.Xml.XmlElement
f_1151_16458_16507(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16458, 16507);
return return_v;
}


System.Xml.XmlElement
f_1151_16612_16653(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16612, 16653);
return return_v;
}


System.Globalization.CultureInfo
f_1151_16708_16736()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 16708, 16736);
return return_v;
}


string
f_1151_16861_16896()
{
var return_v =                         HelpDisplayStrings.ExampleUpperCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 16861, 16896);
return return_v;
}


string
f_1151_16694_16906(System.Globalization.CultureInfo
provider,string
format,string
arg0,int
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16694, 16906);
return return_v;
}


System.Xml.XmlText
f_1151_16950_16979(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16950, 16979);
return return_v;
}


System.Xml.XmlNode
f_1151_17002_17033(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17002, 17033);
return return_v;
}


System.Xml.XmlNode
f_1151_17002_17057(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17002, 17057);
return return_v;
}


int
f_1151_17201_17275(string
content,out string
prompt_str,out string
code_str,out string
remarks_str)
{
GetExampleSections( content, out prompt_str, out code_str, out remarks_str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17201, 17275);
return 0;
}


System.Xml.XmlElement
f_1151_17384_17432(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17384, 17432);
return return_v;
}


System.Xml.XmlElement
f_1151_17486_17526(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17486, 17526);
return return_v;
}


System.Xml.XmlText
f_1151_17582_17613(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17582, 17613);
return return_v;
}


System.Xml.XmlNode
f_1151_17636_17674(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17636, 17674);
return return_v;
}


System.Xml.XmlNode
f_1151_17636_17705(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17636, 17705);
return return_v;
}


System.Xml.XmlNode
f_1151_17636_17741(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17636, 17741);
return return_v;
}


System.Xml.XmlElement
f_1151_17821_17859(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17821, 17859);
return return_v;
}


System.Xml.XmlText
f_1151_17902_17931(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17902, 17931);
return return_v;
}


System.Xml.XmlNode
f_1151_17954_17984(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17954, 17984);
return return_v;
}


System.Xml.XmlNode
f_1151_17954_18007(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 17954, 18007);
return return_v;
}


System.Xml.XmlElement
f_1151_18113_18154(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18113, 18154);
return return_v;
}


System.Xml.XmlElement
f_1151_18203_18243(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18203, 18243);
return return_v;
}


System.Xml.XmlText
f_1151_18294_18326(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18294, 18326);
return return_v;
}


System.Xml.XmlNode
f_1151_18349_18382(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18349, 18382);
return return_v;
}


System.Xml.XmlNode
f_1151_18349_18408(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18349, 18408);
return return_v;
}


System.Xml.XmlNode
f_1151_18349_18439(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18349, 18439);
return return_v;
}


System.Xml.XmlElement
f_1151_18652_18692(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18652, 18692);
return return_v;
}


System.Xml.XmlNode
f_1151_18632_18693(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18632, 18693);
return return_v;
}


System.Xml.XmlNode
f_1151_18741_18775(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18741, 18775);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_16381_16390_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 16381, 16390);
return return_v;
}


System.Xml.XmlNode
f_1151_18815_18844(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18815, 18844);
return return_v;
}


int
f_1151_18880_18893(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 18880, 18893);
return return_v;
}


System.Xml.XmlElement
f_1151_18955_19007(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 18955, 19007);
return return_v;
}


System.Xml.XmlElement
f_1151_19126_19177(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19126, 19177);
return return_v;
}


System.Xml.XmlElement
f_1151_19218_19256(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19218, 19256);
return return_v;
}


System.Xml.XmlElement
f_1151_19302_19342(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19302, 19342);
return return_v;
}


System.Xml.XmlText
f_1151_19390_19419(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19390, 19419);
return return_v;
}


System.Xml.XmlNode
f_1151_19442_19475(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19442, 19475);
return return_v;
}


System.Xml.XmlNode
f_1151_19442_19493(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19442, 19493);
return return_v;
}


System.Xml.XmlNode
f_1151_19442_19516(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19442, 19516);
return return_v;
}


System.Xml.XmlNode
f_1151_19442_19544(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19442, 19544);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_19054_19061_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19054, 19061);
return return_v;
}


System.Xml.XmlNode
f_1151_19584_19615(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 19584, 19615);
return return_v;
}


int
f_1151_19879_19893(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 19879, 19893);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1151_19988_20011(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.OutputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 19988, 20011);
return return_v;
}


int
f_1151_19988_20017(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 19988, 20017);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1151_20065_20088(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.OutputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 20065, 20088);
return return_v;
}


System.Xml.XmlElement
f_1151_20199_20253(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20199, 20253);
return return_v;
}


System.Xml.XmlElement
f_1151_20372_20425(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20372, 20425);
return return_v;
}


System.Xml.XmlElement
f_1151_20466_20504(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20466, 20504);
return return_v;
}


System.Xml.XmlElement
f_1151_20550_20590(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20550, 20590);
return return_v;
}


string
f_1151_20657_20682(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 20657, 20682);
return return_v;
}


System.Xml.XmlText
f_1151_20730_20765(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20730, 20765);
return return_v;
}


System.Xml.XmlNode
f_1151_20788_20825(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20788, 20825);
return return_v;
}


System.Xml.XmlNode
f_1151_20788_20843(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20788, 20843);
return return_v;
}


System.Xml.XmlNode
f_1151_20788_20866(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20788, 20866);
return return_v;
}


System.Xml.XmlNode
f_1151_20788_20894(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20788, 20894);
return return_v;
}


System.Collections.IEnumerable
f_1151_20298_20305_I(System.Collections.IEnumerable
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20298, 20305);
return return_v;
}


System.Xml.XmlNode
f_1151_20934_20967(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 20934, 20967);
return return_v;
}


int
f_1151_21003_21015(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 21003, 21015);
return return_v;
}


System.Xml.XmlElement
f_1151_21072_21120(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21072, 21120);
return return_v;
}


System.Xml.XmlElement
f_1151_21239_21289(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21239, 21289);
return return_v;
}


string
f_1151_21358_21383(string
stringToEscape)
{
var return_v = Uri.EscapeUriString( stringToEscape);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21358, 21383);
return return_v;
}


bool
f_1151_21332_21402(string
uriString,System.UriKind
uriKind)
{
var return_v = Uri.IsWellFormedUriString( uriString, uriKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21332, 21402);
return return_v;
}


System.Xml.XmlElement
f_1151_21531_21568(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21531, 21568);
return return_v;
}


System.Xml.XmlText
f_1151_21615_21640(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21615, 21640);
return return_v;
}


System.Xml.XmlNode
f_1151_21663_21696(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21663, 21696);
return return_v;
}


System.Xml.XmlNode
f_1151_21663_21718(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21663, 21718);
return return_v;
}


System.Xml.XmlNode
f_1151_21663_21745(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21663, 21745);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_21163_21169_I(System.Collections.Generic.List<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21163, 21169);
return return_v;
}


System.Xml.XmlNode
f_1151_21785_21811(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 21785, 21811);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,9140,21866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,9140,21866);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void BuildSyntaxForParameterSet(XmlElement command, XmlElement syntax, MergedCommandParameterMetadata parameterMetadata, int i)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,21878,23839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22038,22115);

XmlElement 
syntaxItem = f_1151_22062_22114(_doc, "command:syntaxItem", commandURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22129,22198);

XmlElement 
syntaxItemName = f_1151_22157_22197(_doc, "maml:name", mamlURI)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22212,22276);

XmlText 
syntaxItemName_text = f_1151_22242_22275(_doc, _commandName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22292,22364);

f_1151_22292_22363(f_1151_22292_22330(
            syntaxItem, syntaxItemName), syntaxItemName_text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22380,22516);

Collection<MergedCompiledCommandParameter> 
compiledParameters =
f_1151_22461_22515(                parameterMetadata, 1u << i)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22532,23760);
foreach(MergedCompiledCommandParameter mergedParameter in f_1151_22591_22609_I(compiledParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,22532,23760);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22643,22797) || true) && (f_1151_22647_22680(mergedParameter)== ParameterBinderAssociation.CommonParameters)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,22643,22797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22769,22778);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,22643,22797);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22817,22880);

CompiledCommandParameter 
parameter = f_1151_22854_22879(mergedParameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,22898,22985);

ParameterSetSpecificMetadata 
parameterSetData = f_1151_22946_22984(parameter, 1u << i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23003,23064);

string 
description = f_1151_23024_23063(this, f_1151_23048_23062(parameter))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23082,23194);

bool 
supportsWildcards = f_1151_23107_23193(f_1151_23107_23135(parameter), attribute => attribute is SupportsWildcardsAttribute)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23212,23686);

XmlElement 
parameterElement = f_1151_23242_23685(this, f_1151_23263_23277(parameter), f_1151_23300_23328(parameterSetData), f_1151_23330_23364(parameterSetData), f_1151_23387_23435(parameterSetData), (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 23458, 23487)||((f_1151_23458_23487(parameterSetData)&&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 23490, 23560))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 23563, 23570)))?f_1151_23490_23560((1 + f_1151_23495_23520(parameterSetData)), f_1151_23531_23559()):"named", f_1151_23593_23607(parameter), description, supportsWildcards, defaultValue: string.Empty, forSyntax: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23704,23745);

f_1151_23704_23744(                syntaxItem, parameterElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,22532,23760);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,1229);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,1229);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23776,23828);

f_1151_23776_23827(f_1151_23776_23803(
            command, syntax), syntaxItem);
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,21878,23839);

System.Xml.XmlElement
f_1151_22062_22114(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22062, 22114);
return return_v;
}


System.Xml.XmlElement
f_1151_22157_22197(System.Xml.XmlDocument
this_param,string
qualifiedName,string
namespaceURI)
{
var return_v = this_param.CreateElement( qualifiedName, namespaceURI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22157, 22197);
return return_v;
}


System.Xml.XmlText
f_1151_22242_22275(System.Xml.XmlDocument
this_param,string
text)
{
var return_v = this_param.CreateTextNode( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22242, 22275);
return return_v;
}


System.Xml.XmlNode
f_1151_22292_22330(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22292, 22330);
return return_v;
}


System.Xml.XmlNode
f_1151_22292_22363(System.Xml.XmlNode
this_param,System.Xml.XmlText
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22292, 22363);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
f_1151_22461_22515(System.Management.Automation.MergedCommandParameterMetadata
this_param,uint
parameterSetFlag)
{
var return_v = this_param.GetParametersInParameterSet( parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22461, 22515);
return return_v;
}


System.Management.Automation.ParameterBinderAssociation
f_1151_22647_22680(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.BinderAssociation ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 22647, 22680);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1151_22854_22879(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 22854, 22879);
return return_v;
}


System.Management.Automation.ParameterSetSpecificMetadata
f_1151_22946_22984(System.Management.Automation.CompiledCommandParameter
this_param,uint
parameterSetFlag)
{
var return_v = this_param.GetParameterSetData( parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22946, 22984);
return return_v;
}


string
f_1151_23048_23062(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23048, 23062);
return return_v;
}


string
f_1151_23024_23063(System.Management.Automation.HelpCommentsParser
this_param,string
parameterName)
{
var return_v = this_param.GetParameterDescription( parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23024, 23063);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1151_23107_23135(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.CompiledAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23107, 23135);
return return_v;
}


bool
f_1151_23107_23193(System.Collections.ObjectModel.Collection<System.Attribute>
source,System.Func<System.Attribute, bool>
predicate)
{
var return_v = source.Any<System.Attribute>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23107, 23193);
return return_v;
}


string
f_1151_23263_23277(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23263, 23277);
return return_v;
}


bool
f_1151_23300_23328(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23300, 23328);
return return_v;
}


bool
f_1151_23330_23364(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23330, 23364);
return return_v;
}


bool
f_1151_23387_23435(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23387, 23435);
return return_v;
}


bool
f_1151_23458_23487(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsPositional ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23458, 23487);
return return_v;
}


int
f_1151_23495_23520(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23495, 23520);
return return_v;
}


System.Globalization.CultureInfo
f_1151_23531_23559()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23531, 23559);
return return_v;
}


string
f_1151_23490_23560(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23490, 23560);
return return_v;
}


System.Type
f_1151_23593_23607(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 23593, 23607);
return return_v;
}


System.Xml.XmlElement
f_1151_23242_23685(System.Management.Automation.HelpCommentsParser
this_param,string
parameterName,bool
isMandatory,bool
valueFromPipeline,bool
valueFromPipelineByPropertyName,string
position,System.Type
type,string
description,bool
supportsWildcards,string
defaultValue,bool
forSyntax)
{
var return_v = this_param.BuildXmlForParameter( parameterName, isMandatory, valueFromPipeline, valueFromPipelineByPropertyName, position, type, description, supportsWildcards, defaultValue: defaultValue, forSyntax: forSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23242, 23685);
return return_v;
}


System.Xml.XmlNode
f_1151_23704_23744(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23704, 23744);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
f_1151_22591_22609_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 22591, 22609);
return return_v;
}


System.Xml.XmlNode
f_1151_23776_23803(System.Xml.XmlElement
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23776, 23803);
return return_v;
}


System.Xml.XmlNode
f_1151_23776_23827(System.Xml.XmlNode
this_param,System.Xml.XmlElement
newChild)
{
var return_v = this_param.AppendChild( (System.Xml.XmlNode)newChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 23776, 23827);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,21878,23839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,21878,23839);
}
		}

private static void GetExampleSections(string content, out string prompt_str, out string code_str, out string remarks_str)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,23851,24826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,23998,24034);

string 
default_prompt_str = "PS > "
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24050,24098);

var 
promptMatch = f_1151_24068_24097(content, "^.*?>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24112,24186);

prompt_str = (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 24125, 24144)||((f_1151_24125_24144(promptMatch)&&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 24147, 24164))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 24167, 24185)))?f_1151_24147_24164(promptMatch):default_prompt_str;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24200,24319) || true) && (f_1151_24204_24223(promptMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,24200,24319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24257,24304);

content = f_1151_24267_24303(content, f_1151_24285_24302(prompt_str));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,24200,24319);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24335,24449);

var 
codeAndRemarksMatch = f_1151_24361_24448(content, "^(?<code>.*?)\r?\n\r?\n(?<remarks>.*)$", RegexOptions.Singleline)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24463,24815) || true) && (f_1151_24467_24494(codeAndRemarksMatch))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,24463,24815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24528,24587);

code_str = f_1151_24539_24586(f_1151_24539_24579(f_1151_24539_24573(f_1151_24539_24565(codeAndRemarksMatch), "code")));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24605,24663);

remarks_str = f_1151_24619_24662(f_1151_24619_24656(f_1151_24619_24645(codeAndRemarksMatch), "remarks"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,24463,24815);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,24463,24815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24729,24755);

code_str = f_1151_24740_24754(content);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,24773,24800);

remarks_str = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,24463,24815);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,23851,24826);

System.Text.RegularExpressions.Match
f_1151_24068_24097(string
input,string
pattern)
{
var return_v = Regex.Match( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 24068, 24097);
return return_v;
}


bool
f_1151_24125_24144(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24125, 24144);
return return_v;
}


string
f_1151_24147_24164(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24147, 24164);
return return_v;
}


bool
f_1151_24204_24223(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24204, 24223);
return return_v;
}


int
f_1151_24285_24302(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24285, 24302);
return return_v;
}


string
f_1151_24267_24303(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 24267, 24303);
return return_v;
}


System.Text.RegularExpressions.Match
f_1151_24361_24448(string
input,string
pattern,System.Text.RegularExpressions.RegexOptions
options)
{
var return_v = Regex.Match( input, pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 24361, 24448);
return return_v;
}


bool
f_1151_24467_24494(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24467, 24494);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_24539_24565(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24539, 24565);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_24539_24573(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24539, 24573);
return return_v;
}


string
f_1151_24539_24579(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24539, 24579);
return return_v;
}


string
f_1151_24539_24586(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 24539, 24586);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_24619_24645(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24619, 24645);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_24619_24656(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24619, 24656);
return return_v;
}


string
f_1151_24619_24662(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 24619, 24662);
return return_v;
}


string
f_1151_24740_24754(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 24740, 24754);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,23851,24826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,23851,24826);
}
		}

private static void CollectCommentText(Token comment, List<string> commentLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,25113,25309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25218,25245);

string 
text = f_1151_25232_25244(comment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25259,25298);

f_1151_25259_25297(text, commentLines);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,25113,25309);

string
f_1151_25232_25244(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 25232, 25244);
return return_v;
}


int
f_1151_25259_25297(string
text,System.Collections.Generic.List<string>
commentLines)
{
CollectCommentText( text, commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 25259, 25297);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,25113,25309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,25113,25309);
}
		}

private static void CollectCommentText(string text, List<string> commentLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,25321,27001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25424,25434);

int 
i = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25448,26990) || true) && (f_1151_25452_25459(text, 0)== '<')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,25448,26990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25500,25514);

int 
start = 2
;
try {                // The full text includes '<#', so start at index 2 to skip those characters,
                // and the full text also includes '#>' at the end, so skip those as well.
                for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25724,25729)
,i = 2; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25719,26452) || true) && (i < f_1151_25735_25746(text)- 2)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25752,25755)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,25719,26452))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,25719,26452);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25797,26433) || true) && (f_1151_25801_25808(text, i)== '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,25797,26433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25866,25917);

f_1151_25866_25916(                        commentLines, f_1151_25883_25915(text, start, i - start));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,25943,25957);

start = i + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,25797,26433);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,25797,26433);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26007,26433) || true) && (f_1151_26011_26018(text, i)== '\r')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,26007,26433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26076,26127);

f_1151_26076_26126(                        commentLines, f_1151_26093_26125(text, start, i - start));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26256,26368) || true) && (f_1151_26260_26271(text, i + 1)== '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,26256,26368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26337,26341);

i++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,26256,26368);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26396,26410);

start = i + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,26007,26433);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,25797,26433);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,734);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,734);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26472,26523);

f_1151_26472_26522(
                commentLines, f_1151_26489_26521(text, start, i - start));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,25448,26990);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,25448,26990);
try {                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26589,26919) || true) && (i < f_1151_26600_26611(text))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26613,26616)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,26589,26919))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,26589,26919);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26803,26900) || true) && (f_1151_26807_26814(text, i)!= '#')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,26803,26900);
DynAbs.Tracing.TraceSender.TraceBreak(1151,26871,26877);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,26803,26900);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,331);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,331);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,26939,26975);

f_1151_26939_26974(
                commentLines, f_1151_26956_26973(text, i));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,25448,26990);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,25321,27001);

char
f_1151_25452_25459(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 25452, 25459);
return return_v;
}


int
f_1151_25735_25746(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 25735, 25746);
return return_v;
}


char
f_1151_25801_25808(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 25801, 25808);
return return_v;
}


string
f_1151_25883_25915(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 25883, 25915);
return return_v;
}


int
f_1151_25866_25916(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 25866, 25916);
return 0;
}


char
f_1151_26011_26018(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 26011, 26018);
return return_v;
}


string
f_1151_26093_26125(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26093, 26125);
return return_v;
}


int
f_1151_26076_26126(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26076, 26126);
return 0;
}


char
f_1151_26260_26271(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 26260, 26271);
return return_v;
}


string
f_1151_26489_26521(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26489, 26521);
return return_v;
}


int
f_1151_26472_26522(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26472, 26522);
return 0;
}


int
f_1151_26600_26611(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 26600, 26611);
return return_v;
}


char
f_1151_26807_26814(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 26807, 26814);
return return_v;
}


string
f_1151_26956_26973(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26956, 26973);
return return_v;
}


int
f_1151_26939_26974(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 26939, 26974);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,25321,27001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,25321,27001);
}
		}

private static string GetSection(List<string> commentLines, ref int i)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,27443,29337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27538,27561);

bool 
capturing = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27575,27598);

int 
countLeadingWS = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27612,27651);

StringBuilder 
sb = f_1151_27631_27650()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27665,27694);

const char 
nbsp = (char)0xA0
;
try {
            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27715,27718)
,i++; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27710,29289) || true) && (i < f_1151_27724_27742(commentLines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27744,27747)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,27710,29289))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,27710,29289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27781,27811);

string 
line = f_1151_27795_27810(commentLines, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,27829,28030) || true) && (!capturing &&(DynAbs.Tracing.TraceSender.Expression_True(1151, 27833, 27877)&&f_1151_27847_27877(line, blankline)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,27829,28030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28002,28011);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,27829,28030);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28050,28262) || true) && (f_1151_28054_28084(line, directive))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,28050,28262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28211,28215);

i--;
DynAbs.Tracing.TraceSender.TraceBreak(1151,28237,28243);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,28050,28262);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28387,28694) || true) && (!capturing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,28387,28694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28443,28453);

int 
j = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28475,28675) || true) && (j < f_1151_28486_28497(line)&&(DynAbs.Tracing.TraceSender.Expression_True(1151, 28482, 28555)&&(f_1151_28502_28509(line, j)== ' ' ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 28502, 28535)||f_1151_28520_28527(line, j)== '\t' )||(DynAbs.Tracing.TraceSender.Expression_False(1151, 28502, 28554)||f_1151_28539_28546(line, j)== nbsp))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,28475,28675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28605,28622);

countLeadingWS++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28648,28652);

j++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,28475,28675);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,28475,28675);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,28475,28675);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1151,28387,28694);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28714,28731);

capturing = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28940,28954);

int 
start = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,28972,29187) || true) && (start < f_1151_28987_28998(line)&&(DynAbs.Tracing.TraceSender.Expression_True(1151, 28979, 29024)&&start < countLeadingWS )&&(DynAbs.Tracing.TraceSender.Expression_True(1151, 28979, 29118)&&                       (f_1151_29053_29064(line, start)== ' ' ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 29053, 29094)||f_1151_29075_29086(line, start)== '\t' )||(DynAbs.Tracing.TraceSender.Expression_False(1151, 29053, 29117)||f_1151_29098_29109(line, start)== nbsp))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,28972,29187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29160,29168);

start++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,28972,29187);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,28972,29187);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,28972,29187);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29207,29240);

f_1151_29207_29239(
                sb, f_1151_29217_29238(line, start));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29258,29274);

f_1151_29258_29273(                sb, '\n');
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,1580);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,1580);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29305,29326);

return f_1151_29312_29325(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,27443,29337);

System.Text.StringBuilder
f_1151_27631_27650()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 27631, 27650);
return return_v;
}


int
f_1151_27724_27742(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 27724, 27742);
return return_v;
}


string
f_1151_27795_27810(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 27795, 27810);
return return_v;
}


bool
f_1151_27847_27877(string
input,string
pattern)
{
var return_v = Regex.IsMatch( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 27847, 27877);
return return_v;
}


bool
f_1151_28054_28084(string
input,string
pattern)
{
var return_v = Regex.IsMatch( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 28054, 28084);
return return_v;
}


int
f_1151_28486_28497(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 28486, 28497);
return return_v;
}


char
f_1151_28502_28509(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 28502, 28509);
return return_v;
}


char
f_1151_28520_28527(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 28520, 28527);
return return_v;
}


char
f_1151_28539_28546(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 28539, 28546);
return return_v;
}


int
f_1151_28987_28998(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 28987, 28998);
return return_v;
}


char
f_1151_29053_29064(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29053, 29064);
return return_v;
}


char
f_1151_29075_29086(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29075, 29086);
return return_v;
}


char
f_1151_29098_29109(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29098, 29109);
return return_v;
}


string
f_1151_29217_29238(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29217, 29238);
return return_v;
}


System.Text.StringBuilder
f_1151_29207_29239(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29207, 29239);
return return_v;
}


System.Text.StringBuilder
f_1151_29258_29273(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29258, 29273);
return return_v;
}


string
f_1151_29312_29325(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29312, 29325);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,27443,29337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,27443,29337);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetHelpFile(CommandInfo commandInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,29349,30263);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29426,29521) || true) && (f_1151_29430_29452(_sections)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,29426,29521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29494,29506);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,29426,29521);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29537,29584);

string 
helpFileToLoad = f_1151_29561_29583(_sections)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29598,29656);

Collection<string> 
searchPaths = f_1151_29631_29655()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29670,29741);

string 
scriptFile = f_1151_29690_29740(f_1151_29690_29735(((IScriptCommandInfo)commandInfo)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29755,30130) || true) && (!f_1151_29760_29792(scriptFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,29755,30130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29826,29915);

helpFileToLoad = f_1151_29843_29914(f_1151_29856_29889(scriptFile), f_1151_29891_29913(_sections));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,29755,30130);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,29755,30130);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,29949,30130) || true) && (f_1151_29953_29971(commandInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,29949,30130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30013,30115);

helpFileToLoad = f_1151_30030_30114(f_1151_30043_30089(f_1151_30065_30088(f_1151_30065_30083(commandInfo))), f_1151_30091_30113(_sections));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,29949,30130);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,29755,30130);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30146,30220);

string 
location = f_1151_30164_30219(helpFileToLoad, searchPaths)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30236,30252);

return location;
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,29349,30263);

string
f_1151_29430_29452(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.MamlHelpFile ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29430, 29452);
return return_v;
}


string
f_1151_29561_29583(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.MamlHelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29561, 29583);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1151_29631_29655()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29631, 29655);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1151_29690_29735(System.Management.Automation.IScriptCommandInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29690, 29735);
return return_v;
}


string
f_1151_29690_29740(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.File;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29690, 29740);
return return_v;
}


bool
f_1151_29760_29792(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29760, 29792);
return return_v;
}


string?
f_1151_29856_29889(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29856, 29889);
return return_v;
}


string
f_1151_29891_29913(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.MamlHelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29891, 29913);
return return_v;
}


string
f_1151_29843_29914(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 29843, 29914);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1151_29953_29971(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Module ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 29953, 29971);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1151_30065_30083(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30065, 30083);
return return_v;
}


string
f_1151_30065_30088(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30065, 30088);
return return_v;
}


string?
f_1151_30043_30089(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30043, 30089);
return return_v;
}


string
f_1151_30091_30113(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.MamlHelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30091, 30113);
return return_v;
}


string
f_1151_30030_30114(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30030, 30114);
return return_v;
}


string
f_1151_30164_30219(string
file,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.LocateFile( file, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30164, 30219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,29349,30263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,29349,30263);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal RemoteHelpInfo GetRemoteHelpInfo(ExecutionContext context, CommandInfo commandInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,30275,31593);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30392,30564) || true) && (f_1151_30396_30449(f_1151_30417_30448(_sections))||(DynAbs.Tracing.TraceSender.Expression_False(1151, 30396, 30503)||f_1151_30453_30503(f_1151_30474_30502(_sections))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,30392,30564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30537,30549);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,30392,30564);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30665,30736);

IScriptCommandInfo 
scriptCommandInfo = (IScriptCommandInfo)commandInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30750,30821);

SessionState 
sessionState = f_1151_30778_30820(f_1151_30778_30807(scriptCommandInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30835,30928);

object 
runspaceInfoAsObject = f_1151_30865_30927(f_1151_30865_30888(sessionState), f_1151_30898_30926(_sections))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30942,30965);

PSSession 
runspaceInfo
=default(PSSession);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,30979,31281) || true) && (runspaceInfoAsObject == null ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 30983, 31104)||                !f_1151_31033_31104(runspaceInfoAsObject, out runspaceInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,30979,31281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,31138,31198);

string 
errorMessage = f_1151_31160_31197()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,31216,31266);

throw f_1151_31222_31265(errorMessage);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,30979,31281);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,31297,31582);

return f_1151_31304_31581(context, (RemoteRunspace)f_1151_31383_31404(runspaceInfo), f_1151_31423_31439(commandInfo), f_1151_31458_31489(_sections), f_1151_31508_31537(_sections), f_1151_31556_31580(commandInfo));
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,30275,31593);

string
f_1151_30417_30448(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpTargetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30417, 30448);
return return_v;
}


bool
f_1151_30396_30449(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30396, 30449);
return return_v;
}


string
f_1151_30474_30502(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.RemoteHelpRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30474, 30502);
return return_v;
}


bool
f_1151_30453_30503(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30453, 30503);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1151_30778_30807(System.Management.Automation.IScriptCommandInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30778, 30807);
return return_v;
}


System.Management.Automation.SessionState
f_1151_30778_30820(System.Management.Automation.ScriptBlock
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30778, 30820);
return return_v;
}


System.Management.Automation.PSVariableIntrinsics
f_1151_30865_30888(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.PSVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30865, 30888);
return return_v;
}


string
f_1151_30898_30926(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.RemoteHelpRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 30898, 30926);
return return_v;
}


object
f_1151_30865_30927(System.Management.Automation.PSVariableIntrinsics
this_param,string
name)
{
var return_v = this_param.GetValue( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 30865, 30927);
return return_v;
}


bool
f_1151_31033_31104(object
valueToConvert,out System.Management.Automation.Runspaces.PSSession
result)
{
var return_v = LanguagePrimitives.TryConvertTo( valueToConvert, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 31033, 31104);
return return_v;
}


string
f_1151_31160_31197()
{
var return_v = HelpErrors.RemoteRunspaceNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31160, 31197);
return return_v;
}


System.InvalidOperationException
f_1151_31222_31265(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 31222, 31265);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1151_31383_31404(System.Management.Automation.Runspaces.PSSession
this_param)
{
var return_v = this_param.Runspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31383, 31404);
return return_v;
}


string
f_1151_31423_31439(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31423, 31439);
return return_v;
}


string
f_1151_31458_31489(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpTargetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31458, 31489);
return return_v;
}


string
f_1151_31508_31537(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31508, 31537);
return return_v;
}


System.Management.Automation.HelpCategory
f_1151_31556_31580(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 31556, 31580);
return return_v;
}


System.Management.Automation.RemoteHelpInfo
f_1151_31304_31581(System.Management.Automation.ExecutionContext
context,System.Management.Automation.Runspaces.Runspace
remoteRunspace,string
localCommandName,string
remoteHelpTopic,string
remoteHelpCategory,System.Management.Automation.HelpCategory
localHelpCategory)
{
var return_v = new System.Management.Automation.RemoteHelpInfo( context, (System.Management.Automation.RemoteRunspace)remoteRunspace, localCommandName, remoteHelpTopic, remoteHelpCategory, localHelpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 31304, 31581);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,30275,31593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,30275,31593);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool AnalyzeCommentBlock(List<Token> comments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,31929,32384);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32009,32114) || true) && (comments == null ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 32013, 32052)||f_1151_32033_32047(comments)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32009,32114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32086,32099);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32009,32114);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32130,32177);

List<string> 
commentLines = f_1151_32158_32176()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32191,32316);
foreach(Token comment in f_1151_32217_32225_I(comments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32191,32316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32259,32301);

f_1151_32259_32300(comment, commentLines);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32191,32316);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,126);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,126);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32332,32373);

return f_1151_32339_32372(this, commentLines);
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,31929,32384);

int
f_1151_32033_32047(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32033, 32047);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_32158_32176()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32158, 32176);
return return_v;
}


int
f_1151_32259_32300(System.Management.Automation.Language.Token
comment,System.Collections.Generic.List<string>
commentLines)
{
CollectCommentText( comment, commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32259, 32300);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_32217_32225_I(System.Collections.Generic.List<System.Management.Automation.Language.Token>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32217, 32225);
return return_v;
}


bool
f_1151_32339_32372(System.Management.Automation.HelpCommentsParser
this_param,System.Collections.Generic.List<string>
commentLines)
{
var return_v = this_param.AnalyzeCommentBlock( commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32339, 32372);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,31929,32384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,31929,32384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool AnalyzeCommentBlock(List<string> commentLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,32396,37278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32480,32508);

bool 
directiveFound = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32531,32536);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32522,36643) || true) && (i < f_1151_32542_32560(commentLines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32562,32565)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32522,36643))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32522,36643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32599,32653);

Match 
match = f_1151_32613_32652(f_1151_32625_32640(commentLines, i), directive)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32671,36628) || true) && (f_1151_32675_32688(match))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32671,36628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32730,32752);

directiveFound = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32776,36466) || true) && (f_1151_32780_32803(f_1151_32780_32795(f_1151_32780_32792(match), 3)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32776,36466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,32853,34433);

switch (f_1151_32861_32901(f_1151_32861_32882(f_1151_32861_32876(f_1151_32861_32873(match), 1))))
                        {

case "PARAMETER":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
                                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33049,33112);

string 
param = f_1151_33064_33111(f_1151_33064_33104(f_1151_33064_33085(f_1151_33064_33079(f_1151_33064_33076(match), 3))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33150,33199);

string 
section = f_1151_33167_33198(commentLines, ref i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33237,33425) || true) && (!f_1151_33242_33272(_parameters, param))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,33237,33425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33354,33386);

f_1151_33354_33385(                                        _parameters, param, section);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,33237,33425);
}
DynAbs.Tracing.TraceSender.TraceBreak(1151,33465,33471);

break;
                                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);

case "FORWARDHELPTARGETNAME":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33599,33662);

_sections.ForwardHelpTargetName = f_1151_33633_33661(f_1151_33633_33654(f_1151_33633_33648(f_1151_33633_33645(match), 3)));
DynAbs.Tracing.TraceSender.TraceBreak(1151,33696,33702);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);

case "FORWARDHELPCATEGORY":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33793,33854);

_sections.ForwardHelpCategory = f_1151_33825_33853(f_1151_33825_33846(f_1151_33825_33840(f_1151_33825_33837(match), 3)));
DynAbs.Tracing.TraceSender.TraceBreak(1151,33888,33894);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);

case "REMOTEHELPRUNSPACE":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,33984,34044);

_sections.RemoteHelpRunspace = f_1151_34015_34043(f_1151_34015_34036(f_1151_34015_34030(f_1151_34015_34027(match), 3)));
DynAbs.Tracing.TraceSender.TraceBreak(1151,34078,34084);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);

case "EXTERNALHELP":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34168,34222);

_sections.MamlHelpFile = f_1151_34193_34221(f_1151_34193_34214(f_1151_34193_34208(f_1151_34193_34205(match), 3)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34256,34281);

isExternalHelpSet = true;
DynAbs.Tracing.TraceSender.TraceBreak(1151,34315,34321);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32853,34433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34393,34406);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32853,34433);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32776,36466);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32776,36466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34531,36443);

switch (f_1151_34539_34579(f_1151_34539_34560(f_1151_34539_34554(f_1151_34539_34551(match), 1))))
                        {

case "SYNOPSIS":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34687,34740);

_sections.Synopsis = f_1151_34708_34739(commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceBreak(1151,34774,34780);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "DESCRIPTION":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,34863,34919);

_sections.Description = f_1151_34887_34918(commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceBreak(1151,34953,34959);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "NOTES":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35036,35086);

_sections.Notes = f_1151_35054_35085(commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceBreak(1151,35120,35126);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "LINK":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35202,35253);

f_1151_35202_35252(                                _links, f_1151_35213_35251(f_1151_35213_35244(commentLines, ref i)));
DynAbs.Tracing.TraceSender.TraceBreak(1151,35287,35293);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "EXAMPLE":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35372,35419);

f_1151_35372_35418(                                _examples, f_1151_35386_35417(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,35453,35459);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "INPUTS":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35537,35582);

f_1151_35537_35581(                                _inputs, f_1151_35549_35580(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,35616,35622);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "OUTPUTS":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35701,35747);

f_1151_35701_35746(                                _outputs, f_1151_35714_35745(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,35781,35787);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "COMPONENT":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,35868,35929);

_sections.Component = f_1151_35890_35928(f_1151_35890_35921(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,35963,35969);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "ROLE":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36045,36101);

_sections.Role = f_1151_36062_36100(f_1151_36062_36093(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,36135,36141);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

case "FUNCTIONALITY":
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36226,36291);

_sections.Functionality = f_1151_36252_36290(f_1151_36252_36283(commentLines, ref i));
DynAbs.Tracing.TraceSender.TraceBreak(1151,36325,36331);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,34531,36443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36403,36416);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,34531,36443);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32776,36466);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32671,36628);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,32671,36628);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36508,36628) || true) && (!f_1151_36513_36554(f_1151_36527_36542(commentLines, i), blankline))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,36508,36628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36596,36609);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,36508,36628);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,32671,36628);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,4122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,4122);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36659,36722);

_sections.Examples = f_1151_36680_36721(_examples);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36736,36795);

_sections.Inputs = f_1151_36755_36794(_inputs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36809,36870);

_sections.Outputs = f_1151_36829_36869(_outputs);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,36884,36941);

_sections.Links = f_1151_36902_36940(_links);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,37162,37229);

_sections.Parameters = f_1151_37185_37228(_parameters);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,37245,37267);

return directiveFound;
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,32396,37278);

int
f_1151_32542_32560(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32542, 32560);
return return_v;
}


string
f_1151_32625_32640(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32625, 32640);
return return_v;
}


System.Text.RegularExpressions.Match
f_1151_32613_32652(string
input,string
pattern)
{
var return_v = Regex.Match( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32613, 32652);
return return_v;
}


bool
f_1151_32675_32688(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32675, 32688);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_32780_32792(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32780, 32792);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_32780_32795(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32780, 32795);
return return_v;
}


bool
f_1151_32780_32803(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32780, 32803);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_32861_32873(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32861, 32873);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_32861_32876(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32861, 32876);
return return_v;
}


string
f_1151_32861_32882(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 32861, 32882);
return return_v;
}


string
f_1151_32861_32901(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 32861, 32901);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_33064_33076(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33064, 33076);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_33064_33079(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33064, 33079);
return return_v;
}


string
f_1151_33064_33085(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33064, 33085);
return return_v;
}


string
f_1151_33064_33104(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33064, 33104);
return return_v;
}


string
f_1151_33064_33111(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33064, 33111);
return return_v;
}


string
f_1151_33167_33198(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33167, 33198);
return return_v;
}


bool
f_1151_33242_33272(System.Collections.Generic.Dictionary<string, string>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33242, 33272);
return return_v;
}


int
f_1151_33354_33385(System.Collections.Generic.Dictionary<string, string>
this_param,string
key,string
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33354, 33385);
return 0;
}


System.Text.RegularExpressions.GroupCollection
f_1151_33633_33645(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33633, 33645);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_33633_33648(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33633, 33648);
return return_v;
}


string
f_1151_33633_33654(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33633, 33654);
return return_v;
}


string
f_1151_33633_33661(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33633, 33661);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_33825_33837(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33825, 33837);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_33825_33840(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33825, 33840);
return return_v;
}


string
f_1151_33825_33846(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 33825, 33846);
return return_v;
}


string
f_1151_33825_33853(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 33825, 33853);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_34015_34027(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34015, 34027);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_34015_34030(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34015, 34030);
return return_v;
}


string
f_1151_34015_34036(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34015, 34036);
return return_v;
}


string
f_1151_34015_34043(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 34015, 34043);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_34193_34205(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34193, 34205);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_34193_34208(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34193, 34208);
return return_v;
}


string
f_1151_34193_34214(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34193, 34214);
return return_v;
}


string
f_1151_34193_34221(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 34193, 34221);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1151_34539_34551(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34539, 34551);
return return_v;
}


System.Text.RegularExpressions.Group
f_1151_34539_34554(System.Text.RegularExpressions.GroupCollection
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34539, 34554);
return return_v;
}


string
f_1151_34539_34560(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 34539, 34560);
return return_v;
}


string
f_1151_34539_34579(string
this_param)
{
var return_v = this_param.ToUpperInvariant();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 34539, 34579);
return return_v;
}


string
f_1151_34708_34739(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 34708, 34739);
return return_v;
}


string
f_1151_34887_34918(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 34887, 34918);
return return_v;
}


string
f_1151_35054_35085(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35054, 35085);
return return_v;
}


string
f_1151_35213_35244(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35213, 35244);
return return_v;
}


string
f_1151_35213_35251(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35213, 35251);
return return_v;
}


int
f_1151_35202_35252(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35202, 35252);
return 0;
}


string
f_1151_35386_35417(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35386, 35417);
return return_v;
}


int
f_1151_35372_35418(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35372, 35418);
return 0;
}


string
f_1151_35549_35580(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35549, 35580);
return return_v;
}


int
f_1151_35537_35581(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35537, 35581);
return 0;
}


string
f_1151_35714_35745(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35714, 35745);
return return_v;
}


int
f_1151_35701_35746(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35701, 35746);
return 0;
}


string
f_1151_35890_35921(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35890, 35921);
return return_v;
}


string
f_1151_35890_35928(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 35890, 35928);
return return_v;
}


string
f_1151_36062_36093(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36062, 36093);
return return_v;
}


string
f_1151_36062_36100(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36062, 36100);
return return_v;
}


string
f_1151_36252_36283(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36252, 36283);
return return_v;
}


string
f_1151_36252_36290(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36252, 36290);
return return_v;
}


string
f_1151_36527_36542(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 36527, 36542);
return return_v;
}


bool
f_1151_36513_36554(string
input,string
pattern)
{
var return_v = Regex.IsMatch( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36513, 36554);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_36680_36721(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36680, 36721);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_36755_36794(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36755, 36794);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_36829_36869(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36829, 36869);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_36902_36940(System.Collections.Generic.List<string>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 36902, 36940);
return return_v;
}


System.Collections.Generic.Dictionary<string, string>
f_1151_37185_37228(System.Collections.Generic.Dictionary<string, string>
dictionary)
{
var return_v = new System.Collections.Generic.Dictionary<string, string>( (System.Collections.Generic.IDictionary<string, string>)dictionary);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 37185, 37228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,32396,37278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,32396,37278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetAdditionalData(MamlCommandHelpInfo helpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1151,37748,38001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,37834,37990);

f_1151_37834_37989(            helpInfo, f_1151_37894_37913(_sections), f_1151_37932_37955(_sections), f_1151_37974_37988(_sections));
DynAbs.Tracing.TraceSender.TraceExitMethod(1151,37748,38001);

string
f_1151_37894_37913(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 37894, 37913);
return return_v;
}


string
f_1151_37932_37955(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 37932, 37955);
return return_v;
}


string
f_1151_37974_37988(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 37974, 37988);
return return_v;
}


int
f_1151_37834_37989(System.Management.Automation.MamlCommandHelpInfo
this_param,string
component,string
functionality,string
role)
{
this_param.SetAdditionalDataFromHelpComment( component, functionality, role);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 37834, 37989);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,37748,38001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,37748,38001);
}
		}

internal static CommentHelpInfo GetHelpContents(List<Language.Token> comments, List<string> parameterDescriptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,38013,38362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,38152,38238);

HelpCommentsParser 
helpCommentsParser = f_1151_38192_38237(parameterDescriptions)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,38252,38301);

f_1151_38252_38300(            helpCommentsParser, comments);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,38315,38351);

return helpCommentsParser._sections;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,38013,38362);

System.Management.Automation.HelpCommentsParser
f_1151_38192_38237(System.Collections.Generic.List<string>
parameterDescriptions)
{
var return_v = new System.Management.Automation.HelpCommentsParser( parameterDescriptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 38192, 38237);
return return_v;
}


bool
f_1151_38252_38300(System.Management.Automation.HelpCommentsParser
this_param,System.Collections.Generic.List<System.Management.Automation.Language.Token>
comments)
{
var return_v = this_param.AnalyzeCommentBlock( comments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 38252, 38300);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,38013,38362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,38013,38362);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static HelpInfo CreateFromComments(ExecutionContext context,
                                                    CommandInfo commandInfo,
                                                    List<Language.Token> comments,
                                                    List<string> parameterDescriptions,
                                                    bool dontSearchOnRemoteComputer,
                                                    out string helpFile, out string helpUriFromDotLink)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,38374,39871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,38910,39009);

HelpCommentsParser 
helpCommentsParser = f_1151_38950_39008(commandInfo, parameterDescriptions)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39023,39072);

f_1151_39023_39071(            helpCommentsParser, comments);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39088,39383) || true) && (f_1151_39092_39126(helpCommentsParser._sections)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1151, 39092, 39183)&&f_1151_39138_39178(f_1151_39138_39172(helpCommentsParser._sections))!= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,39088,39383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39217,39276);

helpUriFromDotLink = f_1151_39238_39275(f_1151_39238_39272(helpCommentsParser._sections), 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,39088,39383);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,39088,39383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39342,39368);

helpUriFromDotLink = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,39088,39383);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39399,39454);

helpFile = f_1151_39410_39453(helpCommentsParser, commandInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39604,39748) || true) && (f_1151_39608_39622(comments)== 1 &&(DynAbs.Tracing.TraceSender.Expression_True(1151, 39608, 39667)&&helpCommentsParser.isExternalHelpSet )&&(DynAbs.Tracing.TraceSender.Expression_True(1151, 39608, 39687)&&helpFile == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,39604,39748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39721,39733);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,39604,39748);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,39764,39860);

return f_1151_39771_39859(context, commandInfo, helpCommentsParser, dontSearchOnRemoteComputer);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,38374,39871);

System.Management.Automation.HelpCommentsParser
f_1151_38950_39008(System.Management.Automation.CommandInfo
commandInfo,System.Collections.Generic.List<string>
parameterDescriptions)
{
var return_v = new System.Management.Automation.HelpCommentsParser( commandInfo, parameterDescriptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 38950, 39008);
return return_v;
}


bool
f_1151_39023_39071(System.Management.Automation.HelpCommentsParser
this_param,System.Collections.Generic.List<System.Management.Automation.Language.Token>
comments)
{
var return_v = this_param.AnalyzeCommentBlock( comments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 39023, 39071);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_39092_39126(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Links ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39092, 39126);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_39138_39172(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Links;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39138, 39172);
return return_v;
}


int
f_1151_39138_39178(System.Collections.ObjectModel.ReadOnlyCollection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39138, 39178);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1151_39238_39272(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.Links;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39238, 39272);
return return_v;
}


string
f_1151_39238_39275(System.Collections.ObjectModel.ReadOnlyCollection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39238, 39275);
return return_v;
}


string
f_1151_39410_39453(System.Management.Automation.HelpCommentsParser
this_param,System.Management.Automation.CommandInfo
commandInfo)
{
var return_v = this_param.GetHelpFile( commandInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 39410, 39453);
return return_v;
}


int
f_1151_39608_39622(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 39608, 39622);
return return_v;
}


System.Management.Automation.HelpInfo
f_1151_39771_39859(System.Management.Automation.ExecutionContext
context,System.Management.Automation.CommandInfo
commandInfo,System.Management.Automation.HelpCommentsParser
helpCommentsParser,bool
dontSearchOnRemoteComputer)
{
var return_v = CreateFromComments( context, commandInfo, helpCommentsParser, dontSearchOnRemoteComputer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 39771, 39859);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,38374,39871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,38374,39871);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static HelpInfo CreateFromComments(ExecutionContext context, CommandInfo commandInfo, HelpCommentsParser helpCommentsParser,
            bool dontSearchOnRemoteComputer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,39883,43306);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40087,40782) || true) && (!dontSearchOnRemoteComputer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,40087,40782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40152,40243);

RemoteHelpInfo 
remoteHelpInfo = f_1151_40184_40242(helpCommentsParser, context, commandInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40261,40767) || true) && (remoteHelpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,40261,40767);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40378,40702) || true) && (f_1151_40382_40418(remoteHelpInfo)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,40378,40702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40476,40679);

f_1151_40476_40678(f_1151_40534_40557(remoteHelpInfo), f_1151_40642_40677(f_1151_40642_40669(commandInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,40378,40702);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40726,40748);

return remoteHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,40261,40767);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,40087,40782);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40798,40858);

XmlDocument 
doc = f_1151_40816_40857(helpCommentsParser)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40872,40925);

HelpCategory 
helpCategory = f_1151_40900_40924(commandInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,40939,41035);

MamlCommandHelpInfo 
localHelpInfo = f_1151_40975_41034(f_1151_41000_41019(doc), helpCategory)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41049,43258) || true) && (localHelpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41049,43258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41108,41160);

f_1151_41108_41159(                helpCommentsParser, localHelpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41180,42951) || true) && (!f_1151_41185_41257(f_1151_41206_41256(helpCommentsParser._sections))||(DynAbs.Tracing.TraceSender.Expression_False(1151, 41184, 41353)||!f_1151_41283_41353(f_1151_41304_41352(helpCommentsParser._sections))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41180,42951);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41395,41772) || true) && (f_1151_41399_41471(f_1151_41420_41470(helpCommentsParser._sections)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41395,41772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41521,41570);

localHelpInfo.ForwardTarget = f_1151_41551_41569(localHelpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41395,41772);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41395,41772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41668,41749);

localHelpInfo.ForwardTarget = f_1151_41698_41748(helpCommentsParser._sections);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41395,41772);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41796,42932) || true) && (!f_1151_41801_41871(f_1151_41822_41870(helpCommentsParser._sections)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41796,42932);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,41981,42120);

localHelpInfo.ForwardHelpCategory = (HelpCategory)f_1151_42031_42119(typeof(HelpCategory), f_1151_42064_42112(helpCommentsParser._sections), true);
                        }
                        catch (System.ArgumentException)
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1151,42173,42317);
DynAbs.Tracing.TraceSender.TraceExitCatch(1151,42173,42317);
                            // Ignore conversion errors.
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41796,42932);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,41796,42932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,42415,42909);

localHelpInfo.ForwardHelpCategory = (HelpCategory.Alias |
                                                             HelpCategory.Cmdlet |
                                                             HelpCategory.ExternalScript |
                                                             HelpCategory.Filter |
                                                             HelpCategory.Function |
                                                             HelpCategory.ScriptCommand);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41796,42932);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41180,42951);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43016,43243) || true) && (f_1151_43020_43055(localHelpInfo)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,43016,43243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43105,43224);

f_1151_43105_43223(f_1151_43163_43185(localHelpInfo), f_1151_43187_43222(f_1151_43187_43214(commandInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,43016,43243);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,41049,43258);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43274,43295);

return localHelpInfo;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,39883,43306);

System.Management.Automation.RemoteHelpInfo
f_1151_40184_40242(System.Management.Automation.HelpCommentsParser
this_param,System.Management.Automation.ExecutionContext
context,System.Management.Automation.CommandInfo
commandInfo)
{
var return_v = this_param.GetRemoteHelpInfo( context, commandInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 40184, 40242);
return return_v;
}


System.Uri
f_1151_40382_40418(System.Management.Automation.RemoteHelpInfo
this_param)
{
var return_v = this_param.GetUriForOnlineHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 40382, 40418);
return return_v;
}


System.Management.Automation.PSObject
f_1151_40534_40557(System.Management.Automation.RemoteHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 40534, 40557);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1151_40642_40669(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 40642, 40669);
return return_v;
}


string
f_1151_40642_40677(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 40642, 40677);
return return_v;
}


int
f_1151_40476_40678(System.Management.Automation.PSObject
obj,string
relatedLink)
{
DefaultCommandHelpObjectBuilder.AddRelatedLinksProperties( obj, relatedLink);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 40476, 40678);
return 0;
}


System.Xml.XmlDocument
f_1151_40816_40857(System.Management.Automation.HelpCommentsParser
this_param)
{
var return_v = this_param.BuildXmlFromComments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 40816, 40857);
return return_v;
}


System.Management.Automation.HelpCategory
f_1151_40900_40924(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 40900, 40924);
return return_v;
}


System.Xml.XmlElement
f_1151_41000_41019(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.DocumentElement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41000, 41019);
return return_v;
}


System.Management.Automation.MamlCommandHelpInfo
f_1151_40975_41034(System.Xml.XmlElement
xmlNode,System.Management.Automation.HelpCategory
helpCategory)
{
var return_v = MamlCommandHelpInfo.Load( (System.Xml.XmlNode)xmlNode, helpCategory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 40975, 41034);
return return_v;
}


int
f_1151_41108_41159(System.Management.Automation.HelpCommentsParser
this_param,System.Management.Automation.MamlCommandHelpInfo
helpInfo)
{
this_param.SetAdditionalData( helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 41108, 41159);
return 0;
}


string
f_1151_41206_41256(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpTargetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41206, 41256);
return return_v;
}


bool
f_1151_41185_41257(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 41185, 41257);
return return_v;
}


string
f_1151_41304_41352(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41304, 41352);
return return_v;
}


bool
f_1151_41283_41353(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 41283, 41353);
return return_v;
}


string
f_1151_41420_41470(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpTargetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41420, 41470);
return return_v;
}


bool
f_1151_41399_41471(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 41399, 41471);
return return_v;
}


string
f_1151_41551_41569(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41551, 41569);
return return_v;
}


string
f_1151_41698_41748(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpTargetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41698, 41748);
return return_v;
}


string
f_1151_41822_41870(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 41822, 41870);
return return_v;
}


bool
f_1151_41801_41871(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 41801, 41871);
return return_v;
}


string
f_1151_42064_42112(System.Management.Automation.Language.CommentHelpInfo
this_param)
{
var return_v = this_param.ForwardHelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 42064, 42112);
return return_v;
}


object
f_1151_42031_42119(System.Type
enumType,string
value,bool
ignoreCase)
{
var return_v = Enum.Parse( enumType, value, ignoreCase);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 42031, 42119);
return return_v;
}


System.Uri
f_1151_43020_43055(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.GetUriForOnlineHelp();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 43020, 43055);
return return_v;
}


System.Management.Automation.PSObject
f_1151_43163_43185(System.Management.Automation.MamlCommandHelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 43163, 43185);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1151_43187_43214(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 43187, 43214);
return return_v;
}


string
f_1151_43187_43222(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 43187, 43222);
return return_v;
}


int
f_1151_43105_43223(System.Management.Automation.PSObject
obj,string
relatedLink)
{
DefaultCommandHelpObjectBuilder.AddRelatedLinksProperties( obj, relatedLink);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 43105, 43223);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,39883,43306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,39883,43306);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsCommentHelpText(List<Token> commentBlock)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,43638,43962);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43727,43814) || true) && ((commentBlock == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 43731, 43782)||(f_1151_43758_43776(commentBlock)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,43727,43814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43801,43814);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,43727,43814);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43830,43886);

HelpCommentsParser 
generator = f_1151_43861_43885()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,43900,43951);

return f_1151_43907_43950(generator, commentBlock);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,43638,43962);

int
f_1151_43758_43776(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 43758, 43776);
return return_v;
}


System.Management.Automation.HelpCommentsParser
f_1151_43861_43885()
{
var return_v = new System.Management.Automation.HelpCommentsParser();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 43861, 43885);
return return_v;
}


bool
f_1151_43907_43950(System.Management.Automation.HelpCommentsParser
this_param,System.Collections.Generic.List<System.Management.Automation.Language.Token>
comments)
{
var return_v = this_param.AnalyzeCommentBlock( comments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 43907, 43950);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,43638,43962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,43638,43962);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static List<Language.Token> GetCommentBlock(Language.Token[] tokens, ref int startIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,44019,45488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44140,44180);

var 
result = f_1151_44153_44179()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44279,44317);

int 
nextMaxStartLine = Int32.MaxValue
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44342,44356);

            for (int 
i = startIndex
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44333,45447) || true) && (i < f_1151_44362_44375(tokens))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44377,44380)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,44333,45447))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,44333,45447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44414,44449);

Language.Token 
current = tokens[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44601,44758) || true) && (f_1151_44605_44635(f_1151_44605_44619(current))> nextMaxStartLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,44601,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44696,44711);

startIndex = i;
DynAbs.Tracing.TraceSender.TraceBreak(1151,44733,44739);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,44601,44758);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44778,45432) || true) && (f_1151_44782_44794(current)== TokenKind.Comment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,44778,45432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,44857,44877);

f_1151_44857_44876(                    result, current);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45096,45148);

nextMaxStartLine = f_1151_45115_45143(f_1151_45115_45129(current))+ 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,44778,45432);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,44778,45432);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45190,45432) || true) && (f_1151_45194_45206(current)!= TokenKind.NewLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,45190,45432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45370,45385);

startIndex = i;
DynAbs.Tracing.TraceSender.TraceBreak(1151,45407,45413);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,45190,45432);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,44778,45432);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,1115);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,1115);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45463,45477);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,44019,45488);

System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_44153_44179()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 44153, 44179);
return return_v;
}


int
f_1151_44362_44375(System.Management.Automation.Language.Token[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 44362, 44375);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_44605_44619(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 44605, 44619);
return return_v;
}


int
f_1151_44605_44635(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.StartLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 44605, 44635);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_44782_44794(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 44782, 44794);
return return_v;
}


int
f_1151_44857_44876(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param,System.Management.Automation.Language.Token
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 44857, 44876);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1151_45115_45129(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45115, 45129);
return return_v;
}


int
f_1151_45115_45143(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.EndLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45115, 45143);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_45194_45206(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45194, 45206);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,44019,45488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,44019,45488);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static List<Language.Token> GetPrecedingCommentBlock(Language.Token[] tokens, int tokenIndex, int proximity)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,45500,46407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45641,45681);

var 
result = f_1151_45654_45680()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45695,45766);

int 
minEndLine = f_1151_45712_45753(f_1151_45712_45737(tokens[tokenIndex]))- proximity
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45791,45809);

            for (int 
i = tokenIndex - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45782,46335) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45819,45822)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,45782,46335))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,45782,46335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45856,45891);

Language.Token 
current = tokens[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,45911,45985) || true) && (f_1151_45915_45943(f_1151_45915_45929(current))< minEndLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,45911,45985);
DynAbs.Tracing.TraceSender.TraceBreak(1151,45979,45985);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,45911,45985);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46005,46320) || true) && (f_1151_46009_46021(current)== TokenKind.Comment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46005,46320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46084,46104);

f_1151_46084_46103(                    result, current);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46126,46174);

minEndLine = f_1151_46139_46169(f_1151_46139_46153(current))- 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46005,46320);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46005,46320);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46216,46320) || true) && (f_1151_46220_46232(current)!= TokenKind.NewLine)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46216,46320);
DynAbs.Tracing.TraceSender.TraceBreak(1151,46295,46301);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46216,46320);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46005,46320);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,554);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,554);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46351,46368);

f_1151_46351_46367(
            result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46382,46396);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,45500,46407);

System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_45654_45680()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Token>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 45654, 45680);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_45712_45737(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45712, 45737);
return return_v;
}


int
f_1151_45712_45753(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.StartLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45712, 45753);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_45915_45929(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45915, 45929);
return return_v;
}


int
f_1151_45915_45943(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.EndLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 45915, 45943);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_46009_46021(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46009, 46021);
return return_v;
}


int
f_1151_46084_46103(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param,System.Management.Automation.Language.Token
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 46084, 46103);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1151_46139_46153(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46139, 46153);
return return_v;
}


int
f_1151_46139_46169(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.StartLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46139, 46169);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_46220_46232(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46220, 46232);
return return_v;
}


int
f_1151_46351_46367(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param)
{
this_param.Reverse();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 46351, 46367);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,45500,46407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,45500,46407);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int FirstTokenInExtent(Language.Token[] tokens, IScriptExtent extent, int startIndex = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,46419,46825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46548,46558);

int 
index
=default(int);
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46577,46595)
,index = startIndex; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46572,46785) || true) && (index < f_1151_46605_46618(tokens))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46620,46627)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46572,46785))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46572,46785);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46661,46770) || true) && (!f_1151_46666_46703(f_1151_46666_46686(tokens[index]), extent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46661,46770);
DynAbs.Tracing.TraceSender.TraceBreak(1151,46745,46751);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46661,46770);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,214);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,214);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46801,46814);

return index;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,46419,46825);

int
f_1151_46605_46618(System.Management.Automation.Language.Token[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46605, 46618);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_46666_46686(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 46666, 46686);
return return_v;
}


bool
f_1151_46666_46703(System.Management.Automation.Language.IScriptExtent
extentToTest,System.Management.Automation.Language.IScriptExtent
startExtent)
{
var return_v = extentToTest.IsBefore( startExtent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 46666, 46703);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,46419,46825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,46419,46825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int LastTokenInExtent(Language.Token[] tokens, IScriptExtent extent, int startIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,46837,47240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46961,46971);

int 
index
=default(int);
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46990,47008)
,index = startIndex; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,46985,47196) || true) && (index < f_1151_47018_47031(tokens))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47033,47040)
,++index,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,46985,47196))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,46985,47196);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47074,47181) || true) && (f_1151_47078_47114(f_1151_47078_47098(tokens[index]), extent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,47074,47181);
DynAbs.Tracing.TraceSender.TraceBreak(1151,47156,47162);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,47074,47181);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,212);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,212);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47212,47229);

return index - 1;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,46837,47240);

int
f_1151_47018_47031(System.Management.Automation.Language.Token[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 47018, 47031);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_47078_47098(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 47078, 47098);
return return_v;
}


bool
f_1151_47078_47114(System.Management.Automation.Language.IScriptExtent
extentToTest,System.Management.Automation.Language.IScriptExtent
endExtent)
{
var return_v = extentToTest.IsAfter( endExtent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47078, 47114);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,46837,47240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,46837,47240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal const int 
CommentBlockProximity = 2
;

private static List<string> GetParameterComments(Language.Token[] tokens, IParameterMetadataProvider ipmp, int startIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,47309,49092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47456,47488);

var 
result = f_1151_47469_47487()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47502,47535);

var 
parameters = f_1151_47519_47534(ipmp)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47549,47659) || true) && (parameters == null ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 47553, 47596)||f_1151_47575_47591(parameters)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,47549,47659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47630,47644);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,47549,47659);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47675,49051);
foreach(var parameter in f_1151_47701_47711_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,47675,49051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47745,47783);

var 
commentLines = f_1151_47764_47782()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47803,47877);

var 
firstToken = f_1151_47820_47876(tokens, f_1151_47847_47863(parameter), startIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47895,47978);

var 
comments = f_1151_47910_47977(tokens, firstToken, CommentBlockProximity)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47996,48224) || true) && (comments != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,47996,48224);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48058,48205);
foreach(var comment in f_1151_48082_48090_I(comments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,48058,48205);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48140,48182);

f_1151_48140_48181(comment, commentLines);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,48058,48205);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1151,47996,48224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48244,48316);

var 
lastToken = f_1151_48260_48315(tokens, f_1151_48286_48302(parameter), firstToken)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48343,48357);
                for (int 
i = firstToken
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48334,48594) || true) && (i < lastToken)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48374,48377)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(1151,48334,48594))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,48334,48594);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48419,48575) || true) && (f_1151_48423_48437(tokens[i])== TokenKind.Comment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,48419,48575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48508,48552);

f_1151_48508_48551(tokens[i], commentLines);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,48419,48575);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,261);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,261);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48614,48629);

lastToken += 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48647,48697);

comments = f_1151_48658_48696(tokens, ref lastToken);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48715,48943) || true) && (comments != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,48715,48943);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48777,48924);
foreach(var comment in f_1151_48801_48809_I(comments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,48777,48924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48859,48901);

f_1151_48859_48900(comment, commentLines);
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,48777,48924);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1151,48715,48943);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48963,48974);

int 
n = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,48992,49036);

f_1151_48992_49035(                result, f_1151_49003_49034(commentLines, ref n));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,47675,49051);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,1,1377);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,1,1377);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49067,49081);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,47309,49092);

System.Collections.Generic.List<string>
f_1151_47469_47487()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47469, 47487);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1151_47519_47534(System.Management.Automation.Language.IParameterMetadataProvider
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 47519, 47534);
return return_v;
}


int
f_1151_47575_47591(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 47575, 47591);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_47764_47782()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47764, 47782);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_47847_47863(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 47847, 47863);
return return_v;
}


int
f_1151_47820_47876(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent,int
startIndex)
{
var return_v = FirstTokenInExtent( tokens, extent, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47820, 47876);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_47910_47977(System.Management.Automation.Language.Token[]
tokens,int
tokenIndex,int
proximity)
{
var return_v = GetPrecedingCommentBlock( tokens, tokenIndex, proximity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47910, 47977);
return return_v;
}


int
f_1151_48140_48181(System.Management.Automation.Language.Token
comment,System.Collections.Generic.List<string>
commentLines)
{
CollectCommentText( comment, commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48140, 48181);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_48082_48090_I(System.Collections.Generic.List<System.Management.Automation.Language.Token>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48082, 48090);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_48286_48302(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 48286, 48302);
return return_v;
}


int
f_1151_48260_48315(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent,int
startIndex)
{
var return_v = LastTokenInExtent( tokens, extent, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48260, 48315);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_48423_48437(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 48423, 48437);
return return_v;
}


int
f_1151_48508_48551(System.Management.Automation.Language.Token
comment,System.Collections.Generic.List<string>
commentLines)
{
CollectCommentText( comment, commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48508, 48551);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_48658_48696(System.Management.Automation.Language.Token[]
tokens,ref int
startIndex)
{
var return_v = GetCommentBlock( tokens, ref startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48658, 48696);
return return_v;
}


int
f_1151_48859_48900(System.Management.Automation.Language.Token
comment,System.Collections.Generic.List<string>
commentLines)
{
CollectCommentText( comment, commentLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48859, 48900);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_48801_48809_I(System.Collections.Generic.List<System.Management.Automation.Language.Token>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48801, 48809);
return return_v;
}


string
f_1151_49003_49034(System.Collections.Generic.List<string>
commentLines,ref int
i)
{
var return_v = GetSection( commentLines, ref i);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 49003, 49034);
return return_v;
}


int
f_1151_48992_49035(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 48992, 49035);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1151_47701_47711_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 47701, 47711);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,47309,49092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,47309,49092);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Tuple<List<Language.Token>, List<string>> GetHelpCommentTokens(IParameterMetadataProvider ipmp,
            Dictionary<Ast, Token[]> scriptBlockTokenCache)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1151,49104,54941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49301,49391);

f_1151_49301_49390(scriptBlockTokenCache != null, "scriptBlockTokenCache cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49405,49425);

var 
ast = (Ast)ipmp
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49441,49459);

var 
rootAst = ast
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49473,49494);

Ast 
configAst = null
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49508,49751) || true) && (f_1151_49515_49529(rootAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,49508,49751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49571,49596);

rootAst = f_1151_49581_49595(rootAst);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49614,49736) || true) && (rootAst is ConfigurationDefinitionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,49614,49736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49697,49717);

configAst = rootAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,49614,49736);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,49508,49751);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,49508,49751);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,49508,49751);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49824,49855);

Language.Token[] 
tokens = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49869,49924);

f_1151_49869_49923(            scriptBlockTokenCache, rootAst, out tokens);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49940,50222) || true) && (tokens == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,49940,50222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,49992,50012);

ParseError[] 
errors
=default(ParseError[]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50077,50149);

f_1151_50077_50148(f_1151_50104_50123(f_1151_50104_50118(rootAst)), out tokens, out errors);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50167,50207);

scriptBlockTokenCache[rootAst] = tokens;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,49940,50222);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50238,50258);

int 
savedStartIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50272,50292);

int 
startTokenIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50306,50325);

int 
lastTokenIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50341,50388);

var 
funcDefnAst = ast as FunctionDefinitionAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50402,50436);

List<Language.Token> 
commentBlock
=default(List<Language.Token>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50450,53027) || true) && (funcDefnAst != null ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 50454, 50494)||configAst != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,50450,53027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50655,50801);

var 
funcOrConfigTokenIndex =
                    savedStartIndex = f_1151_50723_50800(tokens, (DynAbs.Tracing.TraceSender.Conditional_F1(1151, 50750, 50767)||((configAst == null &&DynAbs.Tracing.TraceSender.Conditional_F2(1151, 50770, 50780))||DynAbs.Tracing.TraceSender.Conditional_F3(1151, 50783, 50799)))?f_1151_50770_50780(ast):f_1151_50783_50799(configAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50821,50916);

commentBlock = f_1151_50836_50915(tokens, funcOrConfigTokenIndex, CommentBlockProximity);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,50936,51138) || true) && (f_1151_50940_50990(commentBlock))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,50936,51138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51032,51119);

return f_1151_51039_51118(commentBlock, f_1151_51066_51117(tokens, ipmp, savedStartIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,50936,51138);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51321,52011) || true) && (funcDefnAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,51321,52011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51386,51485);

startTokenIndex =
f_1151_51429_51480(tokens, f_1151_51456_51479(f_1151_51456_51472(funcDefnAst)))+ 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51507,51586);

lastTokenIndex = f_1151_51524_51585(tokens, f_1151_51550_51560(ast), funcOrConfigTokenIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51610,51746);

f_1151_51610_51745(f_1151_51629_51661(tokens[startTokenIndex - 1])== TokenKind.LCurly, "Unexpected first token in function");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51768,51898);

f_1151_51768_51897(f_1151_51787_51814(tokens[lastTokenIndex])== TokenKind.RCurly, "Unexpected last token in function");
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,51321,52011);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,51321,52011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,51980,51992);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,51321,52011);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,50450,53027);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,50450,53027);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52045,53027) || true) && (ast == rootAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,52045,53027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52097,52135);

startTokenIndex = savedStartIndex = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52153,52188);

lastTokenIndex = f_1151_52170_52183(tokens)- 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,52045,53027);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,52045,53027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52539,52618);

startTokenIndex = savedStartIndex = f_1151_52575_52613(tokens, f_1151_52602_52612(ast))+ 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52636,52708);

lastTokenIndex = f_1151_52653_52707(tokens, f_1151_52679_52689(ast), startTokenIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52728,52864);

f_1151_52728_52863(f_1151_52747_52779(tokens[startTokenIndex - 1])== TokenKind.LCurly, "Unexpected first token in script block");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,52882,53012);

f_1151_52882_53011(f_1151_52901_52928(tokens[lastTokenIndex])== TokenKind.RCurly, "Unexpected last token in script block");
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,52045,53027);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,50450,53027);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53043,54571) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53043,54571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53088,53148);

commentBlock = f_1151_53103_53147(tokens, ref startTokenIndex);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53166,53222) || true) && (f_1151_53170_53188(commentBlock)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53166,53222);
DynAbs.Tracing.TraceSender.TraceBreak(1151,53216,53222);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53166,53222);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53242,53329) || true) && (!f_1151_53247_53297(commentBlock))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53242,53329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53320,53329);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53242,53329);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53349,54449) || true) && (ast == rootAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53349,54449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53524,53570);

var 
endBlock = f_1151_53539_53569(((ScriptBlockAst)ast))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53592,53793) || true) && (endBlock == null ||(DynAbs.Tracing.TraceSender.Expression_False(1151, 53596, 53633)||f_1151_53616_53633_M(!endBlock.Unnamed)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53592,53793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53683,53770);

return f_1151_53690_53769(commentBlock, f_1151_53717_53768(tokens, ipmp, savedStartIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53592,53793);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53817,53875);

var 
firstStatement = f_1151_53838_53874(f_1151_53838_53857(endBlock))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53897,54430) || true) && (firstStatement is FunctionDefinitionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,53897,54430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,53990,54135);

int 
linesBetween = f_1151_54009_54046(f_1151_54009_54030(firstStatement))-
f_1151_54094_54134(f_1151_54094_54120(f_1151_54094_54113(                                            commentBlock)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54161,54373) || true) && (linesBetween > CommentBlockProximity)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,54161,54373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54259,54346);

return f_1151_54266_54345(commentBlock, f_1151_54293_54344(tokens, ipmp, savedStartIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,54161,54373);
}
DynAbs.Tracing.TraceSender.TraceBreak(1151,54401,54407);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53897,54430);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53349,54449);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54469,54556);

return f_1151_54476_54555(commentBlock, f_1151_54503_54554(tokens, ipmp, savedStartIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,53043,54571);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1151,53043,54571);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1151,53043,54571);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54587,54698);

commentBlock = f_1151_54602_54697(tokens, lastTokenIndex, f_1151_54651_54696(f_1151_54651_54680(tokens[lastTokenIndex])));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54712,54902) || true) && (f_1151_54716_54766(commentBlock))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1151,54712,54902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54800,54887);

return f_1151_54807_54886(commentBlock, f_1151_54834_54885(tokens, ipmp, savedStartIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(1151,54712,54902);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,54918,54930);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1151,49104,54941);

int
f_1151_49301_49390(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 49301, 49390);
return 0;
}


System.Management.Automation.Language.Ast
f_1151_49515_49529(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 49515, 49529);
return return_v;
}


System.Management.Automation.Language.Ast
f_1151_49581_49595(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 49581, 49595);
return return_v;
}


bool
f_1151_49869_49923(System.Collections.Generic.Dictionary<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[]>
this_param,System.Management.Automation.Language.Ast
key,out System.Management.Automation.Language.Token[]
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 49869, 49923);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_50104_50118(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 50104, 50118);
return return_v;
}


string
f_1151_50104_50123(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 50104, 50123);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1151_50077_50148(string
input,out System.Management.Automation.Language.Token[]
tokens,out System.Management.Automation.Language.ParseError[]
errors)
{
var return_v = Language.Parser.ParseInput( input, out tokens, out errors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 50077, 50148);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_50770_50780(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 50770, 50780);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_50783_50799(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 50783, 50799);
return return_v;
}


int
f_1151_50723_50800(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent)
{
var return_v = FirstTokenInExtent( tokens, extent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 50723, 50800);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_50836_50915(System.Management.Automation.Language.Token[]
tokens,int
tokenIndex,int
proximity)
{
var return_v = GetPrecedingCommentBlock( tokens, tokenIndex, proximity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 50836, 50915);
return return_v;
}


bool
f_1151_50940_50990(System.Collections.Generic.List<System.Management.Automation.Language.Token>
commentBlock)
{
var return_v = HelpCommentsParser.IsCommentHelpText( commentBlock);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 50940, 50990);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_51066_51117(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IParameterMetadataProvider
ipmp,int
startIndex)
{
var return_v = GetParameterComments( tokens, ipmp, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51066, 51117);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
f_1151_51039_51118(System.Collections.Generic.List<System.Management.Automation.Language.Token>
item1,System.Collections.Generic.List<string>
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51039, 51118);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1151_51456_51472(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 51456, 51472);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_51456_51479(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 51456, 51479);
return return_v;
}


int
f_1151_51429_51480(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent)
{
var return_v = FirstTokenInExtent( tokens, extent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51429, 51480);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_51550_51560(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 51550, 51560);
return return_v;
}


int
f_1151_51524_51585(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent,int
startIndex)
{
var return_v = LastTokenInExtent( tokens, extent, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51524, 51585);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_51629_51661(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 51629, 51661);
return return_v;
}


int
f_1151_51610_51745(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51610, 51745);
return 0;
}


System.Management.Automation.Language.TokenKind
f_1151_51787_51814(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 51787, 51814);
return return_v;
}


int
f_1151_51768_51897(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 51768, 51897);
return 0;
}


int
f_1151_52170_52183(System.Management.Automation.Language.Token[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 52170, 52183);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_52602_52612(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 52602, 52612);
return return_v;
}


int
f_1151_52575_52613(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent)
{
var return_v = FirstTokenInExtent( tokens, extent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 52575, 52613);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_52679_52689(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 52679, 52689);
return return_v;
}


int
f_1151_52653_52707(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IScriptExtent
extent,int
startIndex)
{
var return_v = LastTokenInExtent( tokens, extent, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 52653, 52707);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1151_52747_52779(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 52747, 52779);
return return_v;
}


int
f_1151_52728_52863(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 52728, 52863);
return 0;
}


System.Management.Automation.Language.TokenKind
f_1151_52901_52928(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 52901, 52928);
return return_v;
}


int
f_1151_52882_53011(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 52882, 53011);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_53103_53147(System.Management.Automation.Language.Token[]
tokens,ref int
startIndex)
{
var return_v = GetCommentBlock( tokens, ref startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 53103, 53147);
return return_v;
}


int
f_1151_53170_53188(System.Collections.Generic.List<System.Management.Automation.Language.Token>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 53170, 53188);
return return_v;
}


bool
f_1151_53247_53297(System.Collections.Generic.List<System.Management.Automation.Language.Token>
commentBlock)
{
var return_v = HelpCommentsParser.IsCommentHelpText( commentBlock);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 53247, 53297);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1151_53539_53569(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.EndBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 53539, 53569);
return return_v;
}


bool
f_1151_53616_53633_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 53616, 53633);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_53717_53768(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IParameterMetadataProvider
ipmp,int
startIndex)
{
var return_v = GetParameterComments( tokens, ipmp, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 53717, 53768);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
f_1151_53690_53769(System.Collections.Generic.List<System.Management.Automation.Language.Token>
item1,System.Collections.Generic.List<string>
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 53690, 53769);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1151_53838_53857(System.Management.Automation.Language.NamedBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 53838, 53857);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1151_53838_53874(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Language.StatementAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 53838, 53874);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_54009_54030(System.Management.Automation.Language.StatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54009, 54030);
return return_v;
}


int
f_1151_54009_54046(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.StartLineNumber ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54009, 54046);
return return_v;
}


System.Management.Automation.Language.Token
f_1151_54094_54113(System.Collections.Generic.List<System.Management.Automation.Language.Token>
source)
{
var return_v = source.Last<System.Management.Automation.Language.Token>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54094, 54113);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_54094_54120(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54094, 54120);
return return_v;
}


int
f_1151_54094_54134(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.EndLineNumber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54094, 54134);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_54293_54344(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IParameterMetadataProvider
ipmp,int
startIndex)
{
var return_v = GetParameterComments( tokens, ipmp, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54293, 54344);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
f_1151_54266_54345(System.Collections.Generic.List<System.Management.Automation.Language.Token>
item1,System.Collections.Generic.List<string>
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54266, 54345);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_54503_54554(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IParameterMetadataProvider
ipmp,int
startIndex)
{
var return_v = GetParameterComments( tokens, ipmp, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54503, 54554);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
f_1151_54476_54555(System.Collections.Generic.List<System.Management.Automation.Language.Token>
item1,System.Collections.Generic.List<string>
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54476, 54555);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1151_54651_54680(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54651, 54680);
return return_v;
}


int
f_1151_54651_54696(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.StartLineNumber;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 54651, 54696);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.Token>
f_1151_54602_54697(System.Management.Automation.Language.Token[]
tokens,int
tokenIndex,int
proximity)
{
var return_v = GetPrecedingCommentBlock( tokens, tokenIndex, proximity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54602, 54697);
return return_v;
}


bool
f_1151_54716_54766(System.Collections.Generic.List<System.Management.Automation.Language.Token>
commentBlock)
{
var return_v = HelpCommentsParser.IsCommentHelpText( commentBlock);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54716, 54766);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_54834_54885(System.Management.Automation.Language.Token[]
tokens,System.Management.Automation.Language.IParameterMetadataProvider
ipmp,int
startIndex)
{
var return_v = GetParameterComments( tokens, ipmp, startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54834, 54885);
return return_v;
}


System.Tuple<System.Collections.Generic.List<System.Management.Automation.Language.Token>, System.Collections.Generic.List<string>>
f_1151_54807_54886(System.Collections.Generic.List<System.Management.Automation.Language.Token>
item1,System.Collections.Generic.List<string>
item2)
{
var return_v = Tuple.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 54807, 54886);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1151,49104,54941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,49104,54941);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static HelpCommentsParser()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1151,663,54996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2456,2477);
mshURI = "http://msh";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2520,2573);
mamlURI = "http://schemas.microsoft.com/maml/2004/10";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2616,2684);
commandURI = "http://schemas.microsoft.com/maml/dev/command/2004/10";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2727,2783);
devURI = "http://schemas.microsoft.com/maml/dev/2004/10";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2815,2857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,2889,2909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,3269,3475);
ProviderHelpCommandXPath = "/msh:helpItems/msh:providerHelp/msh:CmdletHelpPaths/msh:CmdletHelpPath{0}/command:command[command:details/command:verb='{1}' and command:details/command:noun='{2}']";DynAbs.Tracing.TraceSender.TraceSimpleStatement(1151,47271,47296);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1151,663,54996);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1151,663,54996);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1151,663,54996);

System.Management.Automation.ScriptBlock
f_1151_1167_1181(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 1167, 1181);
return return_v;
}


string
f_1151_1215_1222(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 1215, 1222);
return return_v;
}


System.Management.Automation.ScriptBlock
f_1151_1436_1450(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 1436, 1450);
return return_v;
}


string
f_1151_1488_1495(System.Management.Automation.ExternalScriptInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 1488, 1495);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1151_1565_1592(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1151, 1565, 1592);
return return_v;
}


System.Management.Automation.Language.CommentHelpInfo
f_1151_1731_1761()
{
var return_v = new System.Management.Automation.Language.CommentHelpInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 1731, 1761);
return return_v;
}


System.Collections.Generic.Dictionary<string, string>
f_1151_1830_1862()
{
var return_v = new System.Collections.Generic.Dictionary<string, string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 1830, 1862);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_1915_1933()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 1915, 1933);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_1984_2002()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 1984, 2002);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_2054_2072()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 2054, 2072);
return return_v;
}


System.Collections.Generic.List<string>
f_1151_2122_2140()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1151, 2122, 2140);
return return_v;
}

}
}
