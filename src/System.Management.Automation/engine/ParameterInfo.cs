// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
public class CommandParameterInfo
{
internal CommandParameterInfo(
            CompiledCommandParameter parameter,
            uint parameterSetFlag)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1306,1011,1636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1801,1844);
this.Name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1948,1982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,2226,2271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,2507,2537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,2786,2843);
this.Position = int.MinValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,2993,3044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,3258,3323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,3484,3545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,3659,3722);
this.HelpMessage = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,3854,3904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4033,4102);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1151,1279) || true) && (parameter == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1306,1151,1279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1206,1264);

throw f_1306_1212_1263("parameter");
DynAbs.Tracing.TraceSender.TraceExitCondition(1306,1151,1279);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1295,1317);

Name = f_1306_1302_1316(parameter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1331,1362);

ParameterType = f_1306_1347_1361(parameter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1376,1408);

IsDynamic = f_1306_1388_1407(parameter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1422,1482);

Aliases = f_1306_1432_1481(f_1306_1463_1480(parameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1498,1542);

f_1306_1498_1541(this, f_1306_1512_1540(parameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,1556,1625);

f_1306_1556_1624(this, f_1306_1576_1623(parameter, parameterSetFlag));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1306,1011,1636);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1306,1011,1636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1306,1011,1636);
}
		}

public string Name {get; }

public Type ParameterType {get; }

public bool IsMandatory {get; private set; }

public bool IsDynamic {get; }

public int Position {get; private set; }

public bool ValueFromPipeline {get; private set; }

public bool ValueFromPipelineByPropertyName {get; private set; }

public bool ValueFromRemainingArguments {get; private set; }

public string HelpMessage {get; private set; }

public ReadOnlyCollection<string> Aliases {get; }

public ReadOnlyCollection<Attribute> Attributes {get; private set; }

private void SetAttributes(IList<Attribute> attributeMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1306,4186,4738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4273,4412);

f_1306_4273_4411(attributeMetadata != null, "The compiled attribute collection should never be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4428,4500);

Collection<Attribute> 
processedAttributes = f_1306_4472_4499()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4516,4643);
foreach(var attribute in f_1306_4542_4559_I(attributeMetadata) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1306,4516,4643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4593,4628);

f_1306_4593_4627(                processedAttributes, attribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1306,4516,4643);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1306,1,128);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1306,1,128);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4659,4727);

Attributes = f_1306_4672_4726(processedAttributes);
DynAbs.Tracing.TraceSender.TraceExitMethod(1306,4186,4738);

int
f_1306_4273_4411(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 4273, 4411);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1306_4472_4499()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 4472, 4499);
return return_v;
}


int
f_1306_4593_4627(System.Collections.ObjectModel.Collection<System.Attribute>
this_param,System.Attribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 4593, 4627);
return 0;
}


System.Collections.Generic.IList<System.Attribute>
f_1306_4542_4559_I(System.Collections.Generic.IList<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 4542, 4559);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
f_1306_4672_4726(System.Collections.ObjectModel.Collection<System.Attribute>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>( (System.Collections.Generic.IList<System.Attribute>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 4672, 4726);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1306,4186,4738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1306,4186,4738);
}
		}

private void SetParameterSetData(ParameterSetSpecificMetadata parameterMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1306,4750,5278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4855,4899);

IsMandatory = f_1306_4869_4898(parameterMetadata);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4913,4951);

Position = f_1306_4924_4950(parameterMetadata);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,4965,5021);

ValueFromPipeline = parameterMetadata.valueFromPipeline;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,5035,5119);

ValueFromPipelineByPropertyName = parameterMetadata.valueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,5133,5209);

ValueFromRemainingArguments = f_1306_5163_5208(parameterMetadata);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1306,5223,5267);

HelpMessage = f_1306_5237_5266(parameterMetadata);
DynAbs.Tracing.TraceSender.TraceExitMethod(1306,4750,5278);

bool
f_1306_4869_4898(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.IsMandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 4869, 4898);
return return_v;
}


int
f_1306_4924_4950(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 4924, 4950);
return return_v;
}


bool
f_1306_5163_5208(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 5163, 5208);
return return_v;
}


string
f_1306_5237_5266(System.Management.Automation.ParameterSetSpecificMetadata
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 5237, 5266);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1306,4750,5278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1306,4750,5278);
}
		}

static CommandParameterInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1306,349,5323);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1306,349,5323);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1306,349,5323);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1306,349,5323);

System.Management.Automation.PSArgumentNullException
f_1306_1212_1263(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 1212, 1263);
return return_v;
}


string
f_1306_1302_1316(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 1302, 1316);
return return_v;
}


System.Type
f_1306_1347_1361(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 1347, 1361);
return return_v;
}


bool
f_1306_1388_1407(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.IsDynamic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 1388, 1407);
return return_v;
}


string[]
f_1306_1463_1480(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 1463, 1480);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1306_1432_1481(string[]
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 1432, 1481);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1306_1512_1540(System.Management.Automation.CompiledCommandParameter
this_param)
{
var return_v = this_param.CompiledAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1306, 1512, 1540);
return return_v;
}


int
f_1306_1498_1541(System.Management.Automation.CommandParameterInfo
this_param,System.Collections.ObjectModel.Collection<System.Attribute>
attributeMetadata)
{
this_param.SetAttributes( (System.Collections.Generic.IList<System.Attribute>)attributeMetadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 1498, 1541);
return 0;
}


System.Management.Automation.ParameterSetSpecificMetadata
f_1306_1576_1623(System.Management.Automation.CompiledCommandParameter
this_param,uint
parameterSetFlag)
{
var return_v = this_param.GetParameterSetData( parameterSetFlag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 1576, 1623);
return return_v;
}


int
f_1306_1556_1624(System.Management.Automation.CommandParameterInfo
this_param,System.Management.Automation.ParameterSetSpecificMetadata
parameterMetadata)
{
this_param.SetParameterSetData( parameterMetadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1306, 1556, 1624);
return 0;
}

}
}

