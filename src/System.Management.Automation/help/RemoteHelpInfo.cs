// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
internal class RemoteHelpInfo : BaseCommandHelpInfo
{
private PSObject _deserializedRemoteHelp;

internal RemoteHelpInfo(
            ExecutionContext context,
            RemoteRunspace remoteRunspace,
            string localCommandName,
            string remoteHelpTopic,
            string remoteHelpCategory,
            HelpCategory localHelpCategory) :base(f_1173_797_814_C(localHelpCategory) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1173,522,3129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,486,509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,840,909);

f_1173_840_908(remoteRunspace != null, "Caller should verify arguments");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,925,3118);
using(PowerShell 
powerShell = f_1173_956_975()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1009,1043);

f_1173_1009_1042(                powerShell, "Get-Help");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1061,1110);

f_1173_1061_1109(                powerShell, "Name", remoteHelpTopic);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1128,1290) || true) && (!f_1173_1133_1173(remoteHelpCategory))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,1128,1290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1215,1271);

f_1173_1215_1270(                    powerShell, "Category", remoteHelpCategory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,1128,1290);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1310,1347);

powerShell.Runspace = remoteRunspace;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1367,1400);

Collection<PSObject> 
helpResults
=default(Collection<PSObject>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1418,1562);
using(f_1173_1425_1467(context, powerShell))                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1509,1543);

helpResults = f_1173_1523_1542(powerShell);
DynAbs.Tracing.TraceSender.TraceExitUsing(1173,1418,1562);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1582,1775) || true) && ((helpResults == null) ||(DynAbs.Tracing.TraceSender.Expression_False(1173, 1586, 1635)||(f_1173_1612_1629(helpResults)== 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,1582,1775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1677,1756);

throw f_1173_1683_1755(remoteHelpTopic);
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,1582,1775);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1795,1878);

f_1173_1795_1877(f_1173_1806_1823(helpResults)== 1, "Remote help should return exactly one result");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1896,1937);

_deserializedRemoteHelp = f_1173_1922_1936(helpResults, 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,1955,2006);

f_1173_1955_2005(f_1173_1955_1986(_deserializedRemoteHelp), "ToString");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2364,2433);

PSPropertyInfo 
nameInfo = f_1173_2390_2432(f_1173_2390_2424(_deserializedRemoteHelp), "Name")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2451,2566) || true) && (nameInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,2451,2566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2513,2547);

nameInfo.Value = localCommandName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,2451,2566);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2586,2625);

PSObject 
commandDetails = f_1173_2612_2624(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2643,3103) || true) && (commandDetails != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,2643,3103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2711,2756);

nameInfo = f_1173_2722_2755(f_1173_2722_2747(commandDetails), "Name");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2778,3084) || true) && (nameInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,2778,3084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2848,2882);

nameInfo.Value = localCommandName;
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,2778,3084);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,2778,3084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,2980,3061);

f_1173_2980_3060(f_1173_2980_3010(commandDetails), f_1173_3015_3059("Name", localCommandName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,2778,3084);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,2643,3103);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1173,925,3118);
            }
DynAbs.Tracing.TraceSender.TraceExitConstructor(1173,522,3129);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,522,3129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,522,3129);
}
		}

internal override PSObject FullHelp
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1173,3201,3283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3237,3268);

return _deserializedRemoteHelp;
DynAbs.Tracing.TraceSender.TraceExitMethod(1173,3201,3283);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,3141,3294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,3141,3294);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private string GetHelpProperty(string propertyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1173,3306,3611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3382,3457);

PSPropertyInfo 
property = f_1173_3408_3456(f_1173_3408_3442(_deserializedRemoteHelp), propertyName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3471,3552) || true) && (property == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1173,3471,3552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3525,3537);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1173,3471,3552);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3568,3600);

return f_1173_3575_3589(property)as string;
DynAbs.Tracing.TraceSender.TraceExitMethod(1173,3306,3611);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1173_3408_3442(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 3408, 3442);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1173_3408_3456(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 3408, 3456);
return return_v;
}


object
f_1173_3575_3589(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 3575, 3589);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,3306,3611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,3306,3611);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override string Component
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1173,3682,3774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3718,3759);

return f_1173_3725_3758(this, "Component");
DynAbs.Tracing.TraceSender.TraceExitMethod(1173,3682,3774);

string
f_1173_3725_3758(System.Management.Automation.RemoteHelpInfo
this_param,string
propertyName)
{
var return_v = this_param.GetHelpProperty( propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 3725, 3758);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,3623,3785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,3623,3785);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Functionality
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1173,3860,3956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,3896,3941);

return f_1173_3903_3940(this, "Functionality");
DynAbs.Tracing.TraceSender.TraceExitMethod(1173,3860,3956);

string
f_1173_3903_3940(System.Management.Automation.RemoteHelpInfo
this_param,string
propertyName)
{
var return_v = this_param.GetHelpProperty( propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 3903, 3940);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,3797,3967);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,3797,3967);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override string Role
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1173,4033,4120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1173,4069,4105);

return f_1173_4076_4104(this, "Role");
DynAbs.Tracing.TraceSender.TraceExitMethod(1173,4033,4120);

string
f_1173_4076_4104(System.Management.Automation.RemoteHelpInfo
this_param,string
propertyName)
{
var return_v = this_param.GetHelpProperty( propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 4076, 4104);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1173,3979,4131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,3979,4131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static RemoteHelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1173,401,4138);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1173,401,4138);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1173,401,4138);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1173,401,4138);

int
f_1173_840_908(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 840, 908);
return 0;
}


System.Management.Automation.PowerShell
f_1173_956_975()
{
var return_v = PowerShell.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 956, 975);
return return_v;
}


System.Management.Automation.PowerShell
f_1173_1009_1042(System.Management.Automation.PowerShell
this_param,string
cmdlet)
{
var return_v = this_param.AddCommand( cmdlet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1009, 1042);
return return_v;
}


System.Management.Automation.PowerShell
f_1173_1061_1109(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1061, 1109);
return return_v;
}


bool
f_1173_1133_1173(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1133, 1173);
return return_v;
}


System.Management.Automation.PowerShell
f_1173_1215_1270(System.Management.Automation.PowerShell
this_param,string
parameterName,string
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1215, 1270);
return return_v;
}


System.Management.Automation.PowerShellStopper
f_1173_1425_1467(System.Management.Automation.ExecutionContext
context,System.Management.Automation.PowerShell
powerShell)
{
var return_v = new System.Management.Automation.PowerShellStopper( context, powerShell);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1425, 1467);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1173_1523_1542(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1523, 1542);
return return_v;
}


int
f_1173_1612_1629(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 1612, 1629);
return return_v;
}


Microsoft.PowerShell.Commands.HelpNotFoundException
f_1173_1683_1755(string
helpTopic)
{
var return_v = new Microsoft.PowerShell.Commands.HelpNotFoundException( helpTopic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1683, 1755);
return return_v;
}


int
f_1173_1806_1823(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 1806, 1823);
return return_v;
}


int
f_1173_1795_1877(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1795, 1877);
return 0;
}


System.Management.Automation.PSObject
f_1173_1922_1936(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 1922, 1936);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMethodInfo>
f_1173_1955_1986(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 1955, 1986);
return return_v;
}


int
f_1173_1955_2005(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMethodInfo>
this_param,string
name)
{
this_param.Remove( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 1955, 2005);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1173_2390_2424(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2390, 2424);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1173_2390_2432(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2390, 2432);
return return_v;
}


System.Management.Automation.PSObject
f_1173_2612_2624(System.Management.Automation.RemoteHelpInfo
this_param)
{
var return_v = this_param.Details;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2612, 2624);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1173_2722_2747(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2722, 2747);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1173_2722_2755(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2722, 2755);
return return_v;
}


System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
f_1173_2980_3010(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.InstanceMembers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1173, 2980, 3010);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1173_3015_3059(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 3015, 3059);
return return_v;
}


int
f_1173_2980_3060(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSMemberInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1173, 2980, 3060);
return 0;
}


static System.Management.Automation.HelpCategory
f_1173_797_814_C(System.Management.Automation.HelpCategory
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1173, 522, 3129);
return return_v;
}

}
}
