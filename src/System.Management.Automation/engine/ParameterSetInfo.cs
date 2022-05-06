// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

using Microsoft.PowerShell;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
public class CommandParameterSetInfo
{
internal CommandParameterSetInfo(
            string name,
            bool isDefaultParameterSet,
            uint parameterSetFlag,
            MergedCommandParameterMetadata parameterMetadata)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1307,1563,2301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2468,2508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2641,2684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2829,2909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,1787,1804);

IsDefault = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,1818,1838);

Name = string.Empty;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,1852,1980) || true) && (f_1307_1856_1882(name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,1852,1980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,1916,1965);

throw f_1307_1922_1964("name");
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,1852,1980);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,1996,2140) || true) && (parameterMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,1996,2140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2059,2125);

throw f_1307_2065_2124("parameterMetadata");
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,1996,2140);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2156,2173);

this.Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2187,2226);

this.IsDefault = isDefaultParameterSet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,2242,2290);

f_1307_2242_2289(this, parameterMetadata, parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1307,1563,2301);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,1563,2301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,1563,2301);
}
		}

public string Name {get; private set; }

public bool IsDefault {get; private set; }

public ReadOnlyCollection<CommandParameterInfo> Parameters {get; private set; }

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1307,3027,3884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,3085,3138);

Text.StringBuilder 
result = f_1307_3113_3137()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,3154,3832);

f_1307_3154_3831(this, parameter => AppendFormatCommandParameterInfo(parameter, result), delegate (string str)
                                     {
                                         if (result.Length > 0)
                                         {
                                             result.Append(" ");
                                         }

                                         result.Append("[");
                                         result.Append(str);
                                         result.Append("]");
                                     });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,3848,3873);

return f_1307_3855_3872(result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1307,3027,3884);

System.Text.StringBuilder
f_1307_3113_3137()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 3113, 3137);
return return_v;
}


int
f_1307_3154_3831(System.Management.Automation.CommandParameterSetInfo
this_param,System.Action<System.Management.Automation.CommandParameterInfo>
parameterAction,System.Action<string>
commonParameterAction)
{
this_param.GenerateParametersInDisplayOrder( parameterAction, commonParameterAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 3154, 3831);
return 0;
}


string
f_1307_3855_3872(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 3855, 3872);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,3027,3884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,3027,3884);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GenerateParametersInDisplayOrder(
            Action<CommandParameterInfo> parameterAction,
            Action<string> commonParameterAction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1307,4473,8361);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,4704,4793);

List<CommandParameterInfo> 
sortedPositionalParameters = f_1307_4760_4792()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,4807,4894);

List<CommandParameterInfo> 
namedMandatoryParameters = f_1307_4861_4893()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,4908,4986);

List<CommandParameterInfo> 
namedParameters = f_1307_4953_4985()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5002,6444);
foreach(CommandParameterInfo parameter in f_1307_5045_5055_I(f_1307_5045_5055()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5002,6444);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5089,6429) || true) && (f_1307_5093_5111(parameter)== int.MinValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5089,6429);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5228,5495) || true) && (f_1307_5232_5253(parameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5228,5495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5303,5343);

f_1307_5303_5342(                        namedMandatoryParameters, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5228,5495);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5228,5495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5441,5472);

f_1307_5441_5471(                        namedParameters, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5228,5495);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5089,6429);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5089,6429);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,5909,6327) || true) && (f_1307_5913_5931(parameter)>= f_1307_5935_5967(sortedPositionalParameters))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,5909,6327);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6026,6072);
                        for (int 
fillerIndex = f_1307_6040_6072(sortedPositionalParameters)
;
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6017,6304) || true) && (fillerIndex <= f_1307_6119_6137(parameter))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6169,6182)
,                             ++fillerIndex,DynAbs.Tracing.TraceSender.TraceExitCondition(1307,6017,6304))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,6017,6304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6240,6277);

f_1307_6240_6276(                            sortedPositionalParameters, null);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,288);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,288);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5909,6327);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6351,6410);

sortedPositionalParameters[f_1307_6378_6396(parameter)] = parameter;
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5089,6429);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,5002,6444);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,1443);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,1443);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6460,6716);
foreach(CommandParameterInfo parameter in f_1307_6503_6529_I(sortedPositionalParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,6460,6716);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6563,6654) || true) && (parameter == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,6563,6654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6626,6635);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,6563,6654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6674,6701);

f_1307_6674_6700(parameterAction, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,6460,6716);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,257);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,257);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6805,7059);
foreach(CommandParameterInfo parameter in f_1307_6848_6872_I(namedMandatoryParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,6805,7059);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6906,6997) || true) && (parameter == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,6906,6997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,6969,6978);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,6906,6997);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7017,7044);

f_1307_7017_7043(parameterAction, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,6805,7059);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,255);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,255);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7075,7154);

List<CommandParameterInfo> 
commonParameters = f_1307_7121_7153()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7233,7830);
foreach(CommandParameterInfo parameter in f_1307_7276_7291_I(namedParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7233,7830);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7325,7416) || true) && (parameter == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7325,7416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7388,7397);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7325,7416);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7483,7582);

bool 
isCommon = f_1307_7499_7581(f_1307_7499_7522(), f_1307_7532_7546(parameter), f_1307_7548_7580())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7600,7815) || true) && (!isCommon)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7600,7815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7655,7682);

f_1307_7655_7681(parameterAction, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7600,7815);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7600,7815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7764,7796);

f_1307_7764_7795(                    commonParameters, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7600,7815);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7233,7830);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,598);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,598);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,7920,8350) || true) && (f_1307_7924_7946(commonParameters)== f_1307_7950_7979(f_1307_7950_7973()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7920,8350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8013,8072);

f_1307_8013_8071(commonParameterAction, f_1307_8035_8070());
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7920,8350);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,7920,8350);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8188,8335);
foreach(CommandParameterInfo parameter in f_1307_8231_8247_I(commonParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,8188,8335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8289,8316);

f_1307_8289_8315(parameterAction, parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,8188,8335);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,148);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1307,7920,8350);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1307,4473,8361);

System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_4760_4792()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 4760, 4792);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_4861_4893()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 4861, 4893);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_4953_4985()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 4953, 4985);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
f_1307_5045_5055()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 5045, 5055);
return return_v;
}


int
f_1307_5093_5111(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 5093, 5111);
return return_v;
}


bool
f_1307_5232_5253(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 5232, 5253);
return return_v;
}


int
f_1307_5303_5342(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 5303, 5342);
return 0;
}


int
f_1307_5441_5471(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 5441, 5471);
return 0;
}


int
f_1307_5913_5931(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 5913, 5931);
return return_v;
}


int
f_1307_5935_5967(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 5935, 5967);
return return_v;
}


int
f_1307_6040_6072(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 6040, 6072);
return return_v;
}


int
f_1307_6119_6137(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 6119, 6137);
return return_v;
}


int
f_1307_6240_6276(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 6240, 6276);
return 0;
}


int
f_1307_6378_6396(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 6378, 6396);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
f_1307_5045_5055_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 5045, 5055);
return return_v;
}


int
f_1307_6674_6700(System.Action<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 6674, 6700);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_6503_6529_I(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 6503, 6529);
return return_v;
}


int
f_1307_7017_7043(System.Action<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7017, 7043);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_6848_6872_I(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 6848, 6872);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_7121_7153()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7121, 7153);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1307_7499_7522()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7499, 7522);
return return_v;
}


string
f_1307_7532_7546(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7532, 7546);
return return_v;
}


System.StringComparer
f_1307_7548_7580()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7548, 7580);
return return_v;
}


bool
f_1307_7499_7581(System.Collections.Generic.HashSet<string>
source,string
value,System.StringComparer
comparer)
{
var return_v = source.Contains<string>( value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7499, 7581);
return return_v;
}


int
f_1307_7655_7681(System.Action<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7655, 7681);
return 0;
}


int
f_1307_7764_7795(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7764, 7795);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_7276_7291_I(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 7276, 7291);
return return_v;
}


int
f_1307_7924_7946(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7924, 7946);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1307_7950_7973()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7950, 7973);
return return_v;
}


int
f_1307_7950_7979(System.Collections.Generic.HashSet<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 7950, 7979);
return return_v;
}


string
f_1307_8035_8070()
{
var return_v = HelpDisplayStrings.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8035, 8070);
return return_v;
}


int
f_1307_8013_8071(System.Action<string>
this_param,string
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 8013, 8071);
return 0;
}


int
f_1307_8289_8315(System.Action<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 8289, 8315);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
f_1307_8231_8247_I(System.Collections.Generic.List<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 8231, 8247);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,4473,8361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,4473,8361);
}
		}

private static void AppendFormatCommandParameterInfo(CommandParameterInfo parameter, Text.StringBuilder result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1307,8445,9791);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8581,8721) || true) && (f_1307_8585_8598(result)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,8581,8721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8687,8706);

f_1307_8687_8705(                // Add a space between parameters
                result, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,8581,8721);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8737,9780) || true) && (f_1307_8741_8764(parameter)== typeof(SwitchParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,8737,9780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,8825,8934);

f_1307_8825_8933(                result, f_1307_8845_8873(), (DynAbs.Tracing.TraceSender.Conditional_F1(1307, 8875, 8896)||((f_1307_8875_8896(parameter)&&DynAbs.Tracing.TraceSender.Conditional_F2(1307, 8899, 8905))||DynAbs.Tracing.TraceSender.Conditional_F3(1307, 8908, 8916)))?"-{0}" :"[-{0}]", f_1307_8918_8932(parameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,8737,9780);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,8737,9780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9000,9099);

string 
parameterTypeString = f_1307_9029_9098(f_1307_9052_9075(parameter), f_1307_9077_9097(parameter))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9119,9765) || true) && (f_1307_9123_9144(parameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,9119,9765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9186,9423);

f_1307_9186_9422(                    result, f_1307_9206_9234(), (DynAbs.Tracing.TraceSender.Conditional_F1(1307, 9277, 9311)||((f_1307_9277_9295(parameter)!= int.MinValue &&DynAbs.Tracing.TraceSender.Conditional_F2(1307, 9314, 9328))||DynAbs.Tracing.TraceSender.Conditional_F3(1307, 9331, 9343)))?"[-{0}] <{1}>" :"-{0} <{1}>", f_1307_9386_9400(parameter), parameterTypeString);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,9119,9765);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,9119,9765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9505,9746);

f_1307_9505_9745(                    result, f_1307_9525_9553(), (DynAbs.Tracing.TraceSender.Conditional_F1(1307, 9596, 9630)||((f_1307_9596_9614(parameter)!= int.MinValue &&DynAbs.Tracing.TraceSender.Conditional_F2(1307, 9633, 9649))||DynAbs.Tracing.TraceSender.Conditional_F3(1307, 9652, 9666)))?"[[-{0}] <{1}>]" :"[-{0} <{1}>]", f_1307_9709_9723(parameter), parameterTypeString);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,9119,9765);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,8737,9780);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1307,8445,9791);

int
f_1307_8585_8598(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8585, 8598);
return return_v;
}


System.Text.StringBuilder
f_1307_8687_8705(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 8687, 8705);
return return_v;
}


System.Type
f_1307_8741_8764(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8741, 8764);
return return_v;
}


System.Globalization.CultureInfo
f_1307_8845_8873()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8845, 8873);
return return_v;
}


bool
f_1307_8875_8896(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.IsMandatory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8875, 8896);
return return_v;
}


string
f_1307_8918_8932(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 8918, 8932);
return return_v;
}


System.Text.StringBuilder
f_1307_8825_8933(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 8825, 8933);
return return_v;
}


System.Type
f_1307_9052_9075(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9052, 9075);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
f_1307_9077_9097(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9077, 9097);
return return_v;
}


string
f_1307_9029_9098(System.Type
type,System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
attributes)
{
var return_v = GetParameterTypeString( type, (System.Collections.Generic.IEnumerable<System.Attribute>)attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 9029, 9098);
return return_v;
}


bool
f_1307_9123_9144(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9123, 9144);
return return_v;
}


System.Globalization.CultureInfo
f_1307_9206_9234()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9206, 9234);
return return_v;
}


int
f_1307_9277_9295(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9277, 9295);
return return_v;
}


string
f_1307_9386_9400(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9386, 9400);
return return_v;
}


System.Text.StringBuilder
f_1307_9186_9422(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 9186, 9422);
return return_v;
}


System.Globalization.CultureInfo
f_1307_9525_9553()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9525, 9553);
return return_v;
}


int
f_1307_9596_9614(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9596, 9614);
return return_v;
}


string
f_1307_9709_9723(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 9709, 9723);
return return_v;
}


System.Text.StringBuilder
f_1307_9505_9745(System.Text.StringBuilder
this_param,System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = this_param.AppendFormat( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 9505, 9745);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,8445,9791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,8445,9791);
}
		}

internal static string GetParameterTypeString(Type type, IEnumerable<Attribute> attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1307,9803,12458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9919,9946);

string 
parameterTypeString
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,9960,9989);

PSTypeNameAttribute 
typeName
=default(PSTypeNameAttribute);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,10003,12404) || true) && (attributes != null &&(DynAbs.Tracing.TraceSender.Expression_True(1307, 10007, 10107)&&(typeName = f_1307_10041_10098(f_1307_10041_10081(attributes))) != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,10003,12404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,10873,10980);

var 
match = f_1307_10885_10979(f_1307_10897_10916(typeName), "(.*\\.)?(?<NetTypeName>.*)#(.*[/\\\\])?(?<CimClassName>.*)")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,10998,11705) || true) && (f_1307_11002_11015(match))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,10998,11705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11057,11156);

parameterTypeString = f_1307_11079_11112(f_1307_11079_11106(f_1307_11079_11091(match), "NetTypeName"))+ "#" + f_1307_11121_11155(f_1307_11121_11149(f_1307_11121_11133(match), "CimClassName"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,10998,11705);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,10998,11705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11238,11280);

parameterTypeString = f_1307_11260_11279(typeName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11374,11450);

var 
lastDotIndex = f_1307_11393_11449(parameterTypeString, Utils.Separators.Dot)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11472,11686) || true) && (lastDotIndex != -1 &&(DynAbs.Tracing.TraceSender.Expression_True(1307, 11476, 11543)&&lastDotIndex + 1 < f_1307_11517_11543(parameterTypeString)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,11472,11686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11593,11663);

parameterTypeString = f_1307_11615_11662(parameterTypeString, lastDotIndex + 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,11472,11686);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,10998,11705);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11826,12175) || true) && (f_1307_11830_11842(type)&&(DynAbs.Tracing.TraceSender.Expression_True(1307, 11830, 11913)&&(f_1307_11847_11906(parameterTypeString, "[]", StringComparison.Ordinal)== -1)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,11826,12175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11955,11968);

var 
t = type
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,11990,12156) || true) && (f_1307_11997_12006(t))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,11990,12156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12056,12084);

parameterTypeString += "[]";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12110,12133);

t = f_1307_12114_12132(t);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,11990,12156);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,11990,12156);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,11990,12156);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1307,11826,12175);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,10003,12404);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,10003,12404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12241,12303);

Type 
parameterType = f_1307_12262_12294(type)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1307, 12262, 12302)??type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12321,12389);

parameterTypeString = f_1307_12343_12388(parameterType, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,10003,12404);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12420,12447);

return parameterTypeString;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1307,9803,12458);

System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeNameAttribute>
f_1307_10041_10081(System.Collections.Generic.IEnumerable<System.Attribute>
source)
{
var return_v = source.OfType<System.Management.Automation.PSTypeNameAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 10041, 10081);
return return_v;
}


System.Management.Automation.PSTypeNameAttribute
f_1307_10041_10098(System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeNameAttribute>
source)
{
var return_v = source.FirstOrDefault<System.Management.Automation.PSTypeNameAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 10041, 10098);
return return_v;
}


string
f_1307_10897_10916(System.Management.Automation.PSTypeNameAttribute
this_param)
{
var return_v = this_param.PSTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 10897, 10916);
return return_v;
}


System.Text.RegularExpressions.Match
f_1307_10885_10979(string
input,string
pattern)
{
var return_v = Regex.Match( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 10885, 10979);
return return_v;
}


bool
f_1307_11002_11015(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11002, 11015);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1307_11079_11091(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11079, 11091);
return return_v;
}


System.Text.RegularExpressions.Group
f_1307_11079_11106(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11079, 11106);
return return_v;
}


string
f_1307_11079_11112(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11079, 11112);
return return_v;
}


System.Text.RegularExpressions.GroupCollection
f_1307_11121_11133(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Groups;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11121, 11133);
return return_v;
}


System.Text.RegularExpressions.Group
f_1307_11121_11149(System.Text.RegularExpressions.GroupCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11121, 11149);
return return_v;
}


string
f_1307_11121_11155(System.Text.RegularExpressions.Group
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11121, 11155);
return return_v;
}


string
f_1307_11260_11279(System.Management.Automation.PSTypeNameAttribute
this_param)
{
var return_v = this_param.PSTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11260, 11279);
return return_v;
}


int
f_1307_11393_11449(string
this_param,char[]
anyOf)
{
var return_v = this_param.LastIndexOfAny( anyOf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 11393, 11449);
return return_v;
}


int
f_1307_11517_11543(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11517, 11543);
return return_v;
}


string
f_1307_11615_11662(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 11615, 11662);
return return_v;
}


bool
f_1307_11830_11842(System.Type
this_param)
{
var return_v = this_param.IsArray ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11830, 11842);
return return_v;
}


int
f_1307_11847_11906(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 11847, 11906);
return return_v;
}


bool
f_1307_11997_12006(System.Type
this_param)
{
var return_v = this_param.IsArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 11997, 12006);
return return_v;
}


System.Type?
f_1307_12114_12132(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12114, 12132);
return return_v;
}


System.Type?
f_1307_12262_12294(System.Type
nullableType)
{
var return_v = Nullable.GetUnderlyingType( nullableType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12262, 12294);
return return_v;
}


string
f_1307_12343_12388(System.Type
type,bool
dropNamespaces)
{
var return_v = ToStringCodeMethods.Type( type, dropNamespaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12343, 12388);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,9803,12458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,9803,12458);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void Initialize(MergedCommandParameterMetadata parameterMetadata, uint parameterSetFlag)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1307,12470,13501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12591,12718);

f_1307_12591_12717(parameterMetadata != null, "The parameterMetadata should never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12734,12845);

Collection<CommandParameterInfo> 
processedParameters =
f_1307_12806_12844()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,12917,13062);

Collection<MergedCompiledCommandParameter> 
compiledParameters =
f_1307_12998_13061(                parameterMetadata, parameterSetFlag)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,13078,13395);
foreach(MergedCompiledCommandParameter parameter in f_1307_13131_13149_I(compiledParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,13078,13395);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,13183,13380) || true) && (parameter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1307,13183,13380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,13246,13361);

f_1307_13246_13360(                    processedParameters, f_1307_13296_13359(f_1307_13321_13340(parameter), parameterSetFlag));
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,13183,13380);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1307,13078,13395);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1307,1,318);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1307,1,318);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1307,13411,13490);

Parameters = f_1307_13424_13489(processedParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(1307,12470,13501);

int
f_1307_12591_12717(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12591, 12717);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>
f_1307_12806_12844()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12806, 12844);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
f_1307_12998_13061(System.Management.Automation.MergedCommandParameterMetadata
this_param,uint
parameterSetFlag)
{
var return_v = this_param.GetParametersInParameterSet( parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 12998, 13061);
return return_v;
}


System.Management.Automation.CompiledCommandParameter
f_1307_13321_13340(System.Management.Automation.MergedCompiledCommandParameter
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1307, 13321, 13340);
return return_v;
}


System.Management.Automation.CommandParameterInfo
f_1307_13296_13359(System.Management.Automation.CompiledCommandParameter
parameter,uint
parameterSetFlag)
{
var return_v = new System.Management.Automation.CommandParameterInfo( parameter, parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 13296, 13359);
return return_v;
}


int
f_1307_13246_13360(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>
this_param,System.Management.Automation.CommandParameterInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 13246, 13360);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
f_1307_13131_13149_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 13131, 13149);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
f_1307_13424_13489(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>( (System.Collections.Generic.IList<System.Management.Automation.CommandParameterInfo>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 13424, 13489);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1307,12470,13501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,12470,13501);
}
		}

static CommandParameterSetInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1307,518,13546);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1307,518,13546);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1307,518,13546);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1307,518,13546);

bool
f_1307_1856_1882(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 1856, 1882);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1307_1922_1964(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 1922, 1964);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1307_2065_2124(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 2065, 2124);
return return_v;
}


int
f_1307_2242_2289(System.Management.Automation.CommandParameterSetInfo
this_param,System.Management.Automation.MergedCommandParameterMetadata
parameterMetadata,uint
parameterSetFlag)
{
this_param.Initialize( parameterMetadata, parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1307, 2242, 2289);
return 0;
}

}
}

