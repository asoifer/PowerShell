// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Runtime.Serialization;

// Stops compiler from warning about unknown warnings
#pragma warning disable 1634, 1691

namespace System.Management.Automation
{
[Serializable]
    public class JobDefinition : ISerializable
{
private string _name;

public string Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,936,957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,942,955);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,936,957);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,893,1006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,893,1006);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,973,995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,979,993);

_name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,973,995);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,893,1006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,893,1006);
}
		}}

public Type JobSourceAdapterType {get; }

private string _moduleName;

public string ModuleName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,1510,1537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1516,1535);

return _moduleName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,1510,1537);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,1461,1592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,1461,1592);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,1553,1581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1559,1579);

_moduleName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,1553,1581);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,1461,1592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,1461,1592);
}
		}}

private string _jobSourceAdapterTypeName;

public string JobSourceAdapterTypeName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,1810,1851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1816,1849);

return _jobSourceAdapterTypeName;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,1810,1851);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,1747,1920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,1747,1920);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,1867,1909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1873,1907);

_jobSourceAdapterTypeName = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,1867,1909);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,1747,1920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,1747,1920);
}
		}}

public string Command {get; }

private Guid _instanceId;

public Guid InstanceId
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,2295,2365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,2331,2350);

return _instanceId;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,2295,2365);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,2248,2463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,2248,2463);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,2381,2452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,2417,2437);

_instanceId = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,2381,2452);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,2248,2463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,2248,2463);
}
		}}

public virtual void Save(Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,2661,2772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,2725,2761);

throw f_1576_2731_2760();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,2661,2772);

System.NotImplementedException
f_1576_2731_2760()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 2731, 2760);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,2661,2772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,2661,2772);
}
		}

public virtual void Load(Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,2954,3065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3018,3054);

throw f_1576_3024_3053();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,2954,3065);

System.NotImplementedException
f_1576_3024_3053()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 3024, 3053);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,2954,3065);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,2954,3065);
}
		}

public CommandInfo CommandInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,3279,3342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3315,3327);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,3279,3342);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,3224,3353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,3224,3353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public JobDefinition(Type jobSourceAdapterType, string command, string name)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,3670,4079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,778,783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1223,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1291,1302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1619,1644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,2072,2102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3771,3815);

JobSourceAdapterType = jobSourceAdapterType;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3829,3964) || true) && (jobSourceAdapterType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,3829,3964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3895,3949);

_jobSourceAdapterTypeName = f_1576_3923_3948(jobSourceAdapterType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,3829,3964);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,3980,3998);

Command = command;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,4012,4025);

_name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,4039,4068);

_instanceId = Guid.NewGuid();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,3670,4079);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,3670,4079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,3670,4079);
}
		}

protected JobDefinition(SerializationInfo info, StreamingContext context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,4223,4368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,778,783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1223,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1291,1302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,1619,1644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,2072,2102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,4321,4357);

throw f_1576_4327_4356();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,4223,4368);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,4223,4368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,4223,4368);
}
		}

public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,4512,4667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,4620,4656);

throw f_1576_4626_4655();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,4512,4667);

System.NotImplementedException
f_1576_4626_4655()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 4626, 4655);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,4512,4667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,4512,4667);
}
		}

static JobDefinition()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1576,684,4674);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1576,684,4674);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,684,4674);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1576,684,4674);

string
f_1576_3923_3948(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 3923, 3948);
return return_v;
}


System.NotImplementedException
f_1576_4327_4356()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 4327, 4356);
return return_v;
}

}
[Serializable]
    public class JobInvocationInfo : ISerializable
{
public string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,5389,5453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5425,5438);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,5389,5453);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,5346,5646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,5346,5646);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,5469,5635);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5505,5588) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,5505,5588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5545,5588);

throw f_1576_5551_5587("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,5505,5588);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5606,5620);

_name = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,5469,5635);

System.Management.Automation.PSArgumentNullException
f_1576_5551_5587(string
paramName)
{
var return_v = new System.Management.Automation.PSArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 5551, 5587);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,5346,5646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,5346,5646);
}
		}}

private string _name ;

private string _command;

public string Command
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,5875,5965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5911,5950);

return _command ??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1576, 5918, 5949)??f_1576_5930_5949(_definition));
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,5875,5965);

string
f_1576_5930_5949(System.Management.Automation.JobDefinition
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 5930, 5949);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,5829,6060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,5829,6060);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,5981,6049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6017,6034);

_command = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,5981,6049);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,5829,6060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,5829,6060);
}
		}}

private JobDefinition _definition;

public JobDefinition Definition
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,6270,6340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6306,6325);

return _definition;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,6270,6340);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,6214,6438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,6214,6438);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,6356,6427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6392,6412);

_definition = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,6356,6427);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,6214,6438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,6214,6438);
}
		}}

private List<CommandParameterCollection> _parameters;

public List<CommandParameterCollection> Parameters
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,6697,6782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6703,6780);

return _parameters ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>>(1576, 6710, 6779)??(_parameters = f_1576_6740_6778()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,6697,6782);

System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_6740_6778()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 6740, 6778);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,6622,6793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,6622,6793);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Guid InstanceId {get; }

public virtual void Save(Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,7124,7235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,7188,7224);

throw f_1576_7194_7223();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,7124,7235);

System.NotImplementedException
f_1576_7194_7223()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 7194, 7223);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,7124,7235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,7124,7235);
}
		}

public virtual void Load(Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,7407,7518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,7471,7507);

throw f_1576_7477_7506();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,7407,7518);

System.NotImplementedException
f_1576_7477_7506()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 7477, 7506);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,7407,7518);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,7407,7518);
}
		}

protected JobInvocationInfo()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,7603,7645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,7603,7645);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,7603,7645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,7603,7645);
}
		}

public JobInvocationInfo(JobDefinition definition, Dictionary<string, object> parameters)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,7923,8294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,8037,8062);

_definition = definition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,8076,8153);

var 
convertedCollection = f_1576_8102_8152(parameters)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,8167,8283) || true) && (convertedCollection != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,8167,8283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,8232,8268);

f_1576_8232_8267(f_1576_8232_8242(), convertedCollection);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,8167,8283);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,7923,8294);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,7923,8294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,7923,8294);
}
		}

[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "This is forced by the interaction of PowerShell and Workflow.")]
        public JobInvocationInfo(JobDefinition definition, IEnumerable<Dictionary<string, object>> parameterCollectionList)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,8685,9547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9016,9041);

_definition = definition;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9055,9099) || true) && (parameterCollectionList == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,9055,9099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9092,9099);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,9055,9099);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9113,9536);
foreach(var parameterCollection in f_1576_9149_9172_I(parameterCollectionList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,9113,9536);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9206,9248) || true) && (parameterCollection == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,9206,9248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9239,9248);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,9206,9248);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9266,9375);

CommandParameterCollection 
convertedCollection = f_1576_9315_9374(parameterCollection)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9393,9521) || true) && (convertedCollection != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,9393,9521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9466,9502);

f_1576_9466_9501(f_1576_9466_9476(), convertedCollection);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,9393,9521);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,9113,9536);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1576,1,424);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1576,1,424);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,8685,9547);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,8685,9547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,8685,9547);
}
		}

public JobInvocationInfo(JobDefinition definition, CommandParameterCollection parameters)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,9700,9927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9814,9839);

_definition = definition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,9853,9916);

f_1576_9853_9915(f_1576_9853_9863(), parameters ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Runspaces.CommandParameterCollection>(1576, 9868, 9914)??f_1576_9882_9914()));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,9700,9927);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,9700,9927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,9700,9927);
}
		}

public JobInvocationInfo(JobDefinition definition, IEnumerable<CommandParameterCollection> parameters)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,10080,10413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10207,10232);

_definition = definition;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10246,10277) || true) && (parameters == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,10246,10277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10270,10277);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,10246,10277);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10291,10402);
foreach(var parameter in f_1576_10317_10327_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,10291,10402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10361,10387);

f_1576_10361_10386(f_1576_10361_10371(), parameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,10291,10402);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1576,1,112);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1576,1,112);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,10080,10413);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,10080,10413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,10080,10413);
}
		}

protected JobInvocationInfo(SerializationInfo info, StreamingContext context)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,10557,10706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5673,5693);
this._name = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,5721,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6094,6105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6491,6502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,6907,6956);
this.InstanceId = Guid.NewGuid();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10659,10695);

throw f_1576_10665_10694();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,10557,10706);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,10557,10706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,10557,10706);
}
		}

public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,10850,11005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,10958,10994);

throw f_1576_10964_10993();
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,10850,11005);

System.NotImplementedException
f_1576_10964_10993()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 10964, 10993);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,10850,11005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,10850,11005);
}
		}

private static CommandParameterCollection ConvertDictionaryToParameterCollection(IEnumerable<KeyValuePair<string, object>> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1576,11295,11871);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11454,11507) || true) && (parameters == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,11454,11507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11495,11507);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,11454,11507);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11521,11599);

CommandParameterCollection 
paramCollection = f_1576_11566_11598()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11613,11821);
foreach(CommandParameter paramItem in f_1576_11669_11741_I(f_1576_11669_11741(                parameters, param => new CommandParameter(param.Key, param.Value))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,11613,11821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11775,11806);

f_1576_11775_11805(                paramCollection, paramItem);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,11613,11821);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1576,1,209);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1576,1,209);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,11837,11860);

return paramCollection;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1576,11295,11871);

System.Management.Automation.Runspaces.CommandParameterCollection
f_1576_11566_11598()
{
var return_v = new System.Management.Automation.Runspaces.CommandParameterCollection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 11566, 11598);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.CommandParameter>
f_1576_11669_11741(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>
source,System.Func<System.Collections.Generic.KeyValuePair<string, object>, System.Management.Automation.Runspaces.CommandParameter>
selector)
{
var return_v = source.Select<System.Collections.Generic.KeyValuePair<string, object>,System.Management.Automation.Runspaces.CommandParameter>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 11669, 11741);
return return_v;
}


int
f_1576_11775_11805(System.Management.Automation.Runspaces.CommandParameterCollection
this_param,System.Management.Automation.Runspaces.CommandParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 11775, 11805);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.CommandParameter>
f_1576_11669_11741_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.CommandParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 11669, 11741);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,11295,11871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,11295,11871);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static JobInvocationInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1576,5153,11878);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1576,5153,11878);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,5153,11878);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1576,5153,11878);

System.Management.Automation.Runspaces.CommandParameterCollection
f_1576_8102_8152(System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = ConvertDictionaryToParameterCollection( (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>)parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 8102, 8152);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_8232_8242()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 8232, 8242);
return return_v;
}


int
f_1576_8232_8267(System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
this_param,System.Management.Automation.Runspaces.CommandParameterCollection
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 8232, 8267);
return 0;
}


System.Management.Automation.Runspaces.CommandParameterCollection
f_1576_9315_9374(System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = ConvertDictionaryToParameterCollection( (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>)parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 9315, 9374);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_9466_9476()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 9466, 9476);
return return_v;
}


int
f_1576_9466_9501(System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
this_param,System.Management.Automation.Runspaces.CommandParameterCollection
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 9466, 9501);
return 0;
}


System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, object>>
f_1576_9149_9172_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, object>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 9149, 9172);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_9853_9863()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 9853, 9863);
return return_v;
}


System.Management.Automation.Runspaces.CommandParameterCollection
f_1576_9882_9914()
{
var return_v = new System.Management.Automation.Runspaces.CommandParameterCollection();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 9882, 9914);
return return_v;
}


int
f_1576_9853_9915(System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
this_param,System.Management.Automation.Runspaces.CommandParameterCollection
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 9853, 9915);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_10361_10371()
{
var return_v = Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 10361, 10371);
return return_v;
}


int
f_1576_10361_10386(System.Collections.Generic.List<System.Management.Automation.Runspaces.CommandParameterCollection>
this_param,System.Management.Automation.Runspaces.CommandParameterCollection
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 10361, 10386);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.CommandParameterCollection>
f_1576_10317_10327_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Runspaces.CommandParameterCollection>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 10317, 10327);
return return_v;
}


System.NotImplementedException
f_1576_10665_10694()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 10665, 10694);
return return_v;
}

}
public abstract class JobSourceAdapter
{
public string Name {get; set; }

protected JobIdentifier RetrieveJobIdForReuse(Guid instanceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,12729,12895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,12816,12884);

return f_1576_12823_12883(instanceId, f_1576_12863_12882(f_1576_12863_12877(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,12729,12895);

System.Type
f_1576_12863_12877(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 12863, 12877);
return return_v;
}


string
f_1576_12863_12882(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 12863, 12882);
return return_v;
}


System.Management.Automation.JobIdentifier
f_1576_12823_12883(System.Guid
instanceId,string
typeName)
{
var return_v = JobManager.GetJobIdentifier( instanceId, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 12823, 12883);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,12729,12895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,12729,12895);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Only jobs that derive from Job2 should have reusable IDs.")]
        public void StoreJobIdForReuse(Job2 job, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,13285,14319);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13535,13703) || true) && (job == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,13535,13703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13584,13688);

f_1576_13584_13687("job", f_1576_13630_13686());
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,13535,13703);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13719,13785);

f_1576_13719_13784(f_1576_13740_13754(job), f_1576_13756_13762(job), f_1576_13764_13783(f_1576_13764_13778(this)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13799,14308) || true) && (recurse &&(DynAbs.Tracing.TraceSender.Expression_True(1576, 13803, 13835)&&f_1576_13814_13827(job)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1576, 13803, 13862)&&f_1576_13839_13858(f_1576_13839_13852(job))> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,13799,14308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13896,13942);

Hashtable 
duplicateDetector = f_1576_13926_13941()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,13960,14014);

f_1576_13960_14013(                duplicateDetector, f_1576_13982_13996(job), f_1576_13998_14012(job));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14032,14293);
foreach(Job child in f_1576_14054_14067_I(f_1576_14054_14067(job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14032,14293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14109,14139);

Job2 
childJob = child as Job2
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14161,14192) || true) && (childJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14161,14192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14183,14192);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14161,14192);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14214,14274);

f_1576_14214_14273(this, duplicateDetector, childJob, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14032,14293);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1576,1,262);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1576,1,262);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1576,13799,14308);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,13285,14319);

string
f_1576_13630_13686()
{
var return_v = RemotingErrorIdStrings.JobSourceAdapterCannotSaveNullJob;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13630, 13686);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1576_13584_13687(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 13584, 13687);
return return_v;
}


System.Guid
f_1576_13740_13754(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13740, 13754);
return return_v;
}


int
f_1576_13756_13762(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13756, 13762);
return return_v;
}


System.Type
f_1576_13764_13778(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 13764, 13778);
return return_v;
}


string
f_1576_13764_13783(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13764, 13783);
return return_v;
}


int
f_1576_13719_13784(System.Guid
instanceId,int
id,string
typeName)
{
JobManager.SaveJobId( instanceId, id, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 13719, 13784);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_13814_13827(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13814, 13827);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_13839_13852(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13839, 13852);
return return_v;
}


int
f_1576_13839_13858(System.Collections.Generic.IList<System.Management.Automation.Job>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13839, 13858);
return return_v;
}


System.Collections.Hashtable
f_1576_13926_13941()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 13926, 13941);
return return_v;
}


System.Guid
f_1576_13982_13996(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13982, 13996);
return return_v;
}


System.Guid
f_1576_13998_14012(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 13998, 14012);
return return_v;
}


int
f_1576_13960_14013(System.Collections.Hashtable
this_param,System.Guid
key,System.Guid
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 13960, 14013);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_14054_14067(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14054, 14067);
return return_v;
}


int
f_1576_14214_14273(System.Management.Automation.JobSourceAdapter
this_param,System.Collections.Hashtable
duplicateDetector,System.Management.Automation.Job2
job,bool
recurse)
{
this_param.StoreJobIdForReuseHelper( duplicateDetector, job, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14214, 14273);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_14054_14067_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14054, 14067);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,13285,14319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,13285,14319);
}
		}

private void StoreJobIdForReuseHelper(Hashtable duplicateDetector, Job2 job, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,14331,14985);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14446,14504) || true) && (f_1576_14450_14495(duplicateDetector, f_1576_14480_14494(job)))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14446,14504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14497,14504);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14446,14504);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14518,14572);

f_1576_14518_14571(            duplicateDetector, f_1576_14540_14554(job), f_1576_14556_14570(job));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14588,14654);

f_1576_14588_14653(f_1576_14609_14623(job), f_1576_14625_14631(job), f_1576_14633_14652(f_1576_14633_14647(this)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14670,14716) || true) && (!recurse ||(DynAbs.Tracing.TraceSender.Expression_False(1576, 14674, 14707)||f_1576_14686_14699(job)== null))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14670,14716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14709,14716);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14670,14716);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14730,14974);
foreach(Job child in f_1576_14752_14765_I(f_1576_14752_14765(job)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14730,14974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14799,14829);

Job2 
childJob = child as Job2
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14847,14878) || true) && (childJob == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1576,14847,14878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14869,14878);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14847,14878);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,14896,14959);

f_1576_14896_14958(this, duplicateDetector, childJob, recurse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1576,14730,14974);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1576,1,245);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1576,1,245);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1576,14331,14985);

System.Guid
f_1576_14480_14494(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14480, 14494);
return return_v;
}


bool
f_1576_14450_14495(System.Collections.Hashtable
this_param,System.Guid
key)
{
var return_v = this_param.ContainsKey( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14450, 14495);
return return_v;
}


System.Guid
f_1576_14540_14554(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14540, 14554);
return return_v;
}


System.Guid
f_1576_14556_14570(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14556, 14570);
return return_v;
}


int
f_1576_14518_14571(System.Collections.Hashtable
this_param,System.Guid
key,System.Guid
value)
{
this_param.Add( (object)key, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14518, 14571);
return 0;
}


System.Guid
f_1576_14609_14623(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.InstanceId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14609, 14623);
return return_v;
}


int
f_1576_14625_14631(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14625, 14631);
return return_v;
}


System.Type
f_1576_14633_14647(System.Management.Automation.JobSourceAdapter
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14633, 14647);
return return_v;
}


string
f_1576_14633_14652(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14633, 14652);
return return_v;
}


int
f_1576_14588_14653(System.Guid
instanceId,int
id,string
typeName)
{
JobManager.SaveJobId( instanceId, id, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14588, 14653);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_14686_14699(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.ChildJobs ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14686, 14699);
return return_v;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_14752_14765(System.Management.Automation.Job2
this_param)
{
var return_v = this_param.ChildJobs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1576, 14752, 14765);
return return_v;
}


int
f_1576_14896_14958(System.Management.Automation.JobSourceAdapter
this_param,System.Collections.Hashtable
duplicateDetector,System.Management.Automation.Job2
job,bool
recurse)
{
this_param.StoreJobIdForReuseHelper( duplicateDetector, job, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14896, 14958);
return 0;
}


System.Collections.Generic.IList<System.Management.Automation.Job>
f_1576_14752_14765_I(System.Collections.Generic.IList<System.Management.Automation.Job>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 14752, 14765);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,14331,14985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,14331,14985);
}
		}

public Job2 NewJob(JobDefinition definition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,15218,15381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,15287,15370);

return f_1576_15294_15369(this, f_1576_15301_15368(definition, f_1576_15335_15367()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,15218,15381);

System.Collections.Generic.Dictionary<string, object>
f_1576_15335_15367()
{
var return_v = new System.Collections.Generic.Dictionary<string, object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 15335, 15367);
return return_v;
}


System.Management.Automation.JobInvocationInfo
f_1576_15301_15368(System.Management.Automation.JobDefinition
definition,System.Collections.Generic.Dictionary<string, object>
parameters)
{
var return_v = new System.Management.Automation.JobInvocationInfo( definition, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 15301, 15368);
return return_v;
}


System.Management.Automation.Job2
f_1576_15294_15369(System.Management.Automation.JobSourceAdapter
this_param,System.Management.Automation.JobInvocationInfo
specification)
{
var return_v = this_param.NewJob( specification);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1576, 15294, 15369);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,15218,15381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,15218,15381);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public virtual Job2 NewJob(string definitionName, string definitionPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,15867,15987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,15964,15976);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,15867,15987);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,15867,15987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,15867,15987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public abstract Job2 NewJob(JobInvocationInfo specification);

public abstract IList<Job2> GetJobs();

public abstract IList<Job2> GetJobsByName(string name, bool recurse);

public abstract IList<Job2> GetJobsByCommand(string command, bool recurse);

public abstract Job2 GetJobByInstanceId(Guid instanceId, bool recurse);

public abstract Job2 GetJobBySessionId(int id, bool recurse);

public abstract IList<Job2> GetJobsByState(JobState state, bool recurse);

public abstract IList<Job2> GetJobsByFilter(Dictionary<string, object> filter, bool recurse);

public abstract void RemoveJob(Job2 job);

public virtual void PersistJob(Job2 job)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1576,19330,19466);
DynAbs.Tracing.TraceSender.TraceExitMethod(1576,19330,19466);
            // Implemented only if job needs to be told when to persist.
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1576,19330,19466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,19330,19466);
}
		}

public JobSourceAdapter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1576,12022,19473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1576,12158,12206);
this.Name = string.Empty;DynAbs.Tracing.TraceSender.TraceExitConstructor(1576,12022,19473);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,12022,19473);
}


static JobSourceAdapter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1576,12022,19473);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1576,12022,19473);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1576,12022,19473);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1576,12022,19473);
}
}
