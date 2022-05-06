// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

namespace System.Management.Automation.Help
{
[Serializable]
    internal class UpdatableHelpSystemException : Exception
{
internal UpdatableHelpSystemException(string errorId, string message, ErrorCategory cat, object targetObject, Exception innerException)
:base(f_1180_1463_1470_C(message) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,1307,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2175,2221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2309,2354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2441,2478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,1512,1544);

FullyQualifiedErrorId = errorId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,1558,1578);

ErrorCategory = cat;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,1592,1620);

TargetObject = targetObject;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,1307,1631);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,1307,1631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,1307,1631);
}
		}

internal string FullyQualifiedErrorId {get; }

internal ErrorCategory ErrorCategory {get; }

internal object TargetObject {get; }

static UpdatableHelpSystemException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1180,829,2485);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1180,829,2485);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,829,2485);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1180,829,2485);

static string
f_1180_1463_1470_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1180, 1307, 1631);
return return_v;
}

}
internal class UpdatableHelpExceptionContext
{
internal UpdatableHelpExceptionContext(UpdatableHelpSystemException exception)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,2764,3057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,3148,3194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,3289,3336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,3440,3496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2867,2889);

Exception = exception;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2903,2967);

Modules = f_1180_2913_2966(f_1180_2933_2965());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,2981,3046);

Cultures = f_1180_2992_3045(f_1180_3012_3044());
DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,2764,3057);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,2764,3057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,2764,3057);
}
		}

internal HashSet<string> Modules {get; set; }

internal HashSet<string> Cultures {get; set; }

internal UpdatableHelpSystemException Exception {get; }

internal ErrorRecord CreateErrorRecord(UpdatableHelpCommandType commandType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,3718,4050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,3819,3852);

f_1180_3819_3851(f_1180_3832_3845(f_1180_3832_3839())!= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,3868,4039);

return f_1180_3875_4038(f_1180_3891_3938(f_1180_3905_3937(this, commandType)), f_1180_3940_3971(f_1180_3940_3949()), f_1180_3973_3996(f_1180_3973_3982()), f_1180_4015_4037(f_1180_4015_4024()));
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,3718,4050);

System.Collections.Generic.HashSet<string>
f_1180_3832_3839()
{
var return_v = Modules;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3832, 3839);
return return_v;
}


int
f_1180_3832_3845(System.Collections.Generic.HashSet<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3832, 3845);
return return_v;
}


int
f_1180_3819_3851(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 3819, 3851);
return 0;
}


string
f_1180_3905_3937(System.Management.Automation.Help.UpdatableHelpExceptionContext
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType)
{
var return_v = this_param.GetExceptionMessage( commandType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 3905, 3937);
return return_v;
}


System.Exception
f_1180_3891_3938(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 3891, 3938);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_3940_3949()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3940, 3949);
return return_v;
}


string
f_1180_3940_3971(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3940, 3971);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_3973_3982()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3973, 3982);
return return_v;
}


System.Management.Automation.ErrorCategory
f_1180_3973_3996(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.ErrorCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3973, 3996);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_4015_4024()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4015, 4024);
return return_v;
}


object
f_1180_4015_4037(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.TargetObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4015, 4037);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1180_3875_4038(System.Exception
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 3875, 4038);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,3718,4050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,3718,4050);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetExceptionMessage(UpdatableHelpCommandType commandType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,4231,5751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4329,4359);

string 
message = string.Empty
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4373,4479);

SortedSet<string> 
sortedModules = f_1180_4407_4478(f_1180_4429_4436(), f_1180_4438_4477())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4493,4601);

SortedSet<string> 
sortedCultures = f_1180_4528_4600(f_1180_4550_4558(), f_1180_4560_4599())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4615,4665);

string 
modules = f_1180_4632_4664(", ", sortedModules)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4679,4731);

string 
cultures = f_1180_4697_4730(", ", sortedCultures)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4747,5709) || true) && (commandType == UpdatableHelpCommandType.UpdateHelpCommand)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,4747,5709);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4842,5237) || true) && (f_1180_4846_4860(f_1180_4846_4854())== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,4842,5237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,4907,5011);

message = f_1180_4917_5010(f_1180_4935_4981(), modules, f_1180_4992_5009(f_1180_4992_5001()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,4842,5237);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,4842,5237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,5093,5218);

message = f_1180_5103_5217(f_1180_5121_5178(), modules, cultures, f_1180_5199_5216(f_1180_5199_5208()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,4842,5237);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,4747,5709);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,4747,5709);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,5303,5694) || true) && (f_1180_5307_5321(f_1180_5307_5315())== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,5303,5694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,5368,5470);

message = f_1180_5378_5469(f_1180_5396_5440(), modules, f_1180_5451_5468(f_1180_5451_5460()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,5303,5694);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,5303,5694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,5552,5675);

message = f_1180_5562_5674(f_1180_5580_5635(), modules, cultures, f_1180_5656_5673(f_1180_5656_5665()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,5303,5694);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,4747,5709);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,5725,5740);

return message;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,4231,5751);

System.Collections.Generic.HashSet<string>
f_1180_4429_4436()
{
var return_v = Modules;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4429, 4436);
return return_v;
}


System.StringComparer
f_1180_4438_4477()
{
var return_v = StringComparer.CurrentCultureIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4438, 4477);
return return_v;
}


System.Collections.Generic.SortedSet<string>
f_1180_4407_4478(System.Collections.Generic.HashSet<string>
collection,System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.SortedSet<string>( (System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 4407, 4478);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1180_4550_4558()
{
var return_v = Cultures;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4550, 4558);
return return_v;
}


System.StringComparer
f_1180_4560_4599()
{
var return_v = StringComparer.CurrentCultureIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4560, 4599);
return return_v;
}


System.Collections.Generic.SortedSet<string>
f_1180_4528_4600(System.Collections.Generic.HashSet<string>
collection,System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.SortedSet<string>( (System.Collections.Generic.IEnumerable<string>)collection, (System.Collections.Generic.IComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 4528, 4600);
return return_v;
}


string
f_1180_4632_4664(string
separator,System.Collections.Generic.SortedSet<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 4632, 4664);
return return_v;
}


string
f_1180_4697_4730(string
separator,System.Collections.Generic.SortedSet<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 4697, 4730);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1180_4846_4854()
{
var return_v = Cultures;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4846, 4854);
return return_v;
}


int
f_1180_4846_4860(System.Collections.Generic.HashSet<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4846, 4860);
return return_v;
}


string
f_1180_4935_4981()
{
var return_v = HelpDisplayStrings.FailedToUpdateHelpForModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4935, 4981);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_4992_5001()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4992, 5001);
return return_v;
}


string
f_1180_4992_5009(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 4992, 5009);
return return_v;
}


string
f_1180_4917_5010(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 4917, 5010);
return return_v;
}


string
f_1180_5121_5178()
{
var return_v = HelpDisplayStrings.FailedToUpdateHelpForModuleWithCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5121, 5178);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_5199_5208()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5199, 5208);
return return_v;
}


string
f_1180_5199_5216(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5199, 5216);
return return_v;
}


string
f_1180_5103_5217(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 5103, 5217);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1180_5307_5315()
{
var return_v = Cultures;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5307, 5315);
return return_v;
}


int
f_1180_5307_5321(System.Collections.Generic.HashSet<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5307, 5321);
return return_v;
}


string
f_1180_5396_5440()
{
var return_v = HelpDisplayStrings.FailedToSaveHelpForModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5396, 5440);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_5451_5460()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5451, 5460);
return return_v;
}


string
f_1180_5451_5468(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5451, 5468);
return return_v;
}


string
f_1180_5378_5469(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 5378, 5469);
return return_v;
}


string
f_1180_5580_5635()
{
var return_v = HelpDisplayStrings.FailedToSaveHelpForModuleWithCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5580, 5635);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_5656_5665()
{
var return_v = Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5656, 5665);
return return_v;
}


string
f_1180_5656_5673(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 5656, 5673);
return return_v;
}


string
f_1180_5562_5674(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 5562, 5674);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,4231,5751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,4231,5751);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static UpdatableHelpExceptionContext()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1180,2560,5758);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1180,2560,5758);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,2560,5758);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1180,2560,5758);

System.StringComparer
f_1180_2933_2965()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 2933, 2965);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1180_2913_2966(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 2913, 2966);
return return_v;
}


System.StringComparer
f_1180_3012_3044()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 3012, 3044);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1180_2992_3045(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 2992, 3045);
return return_v;
}

}

    /// <summary>
    /// Enumeration showing Update or Save help.
    /// </summary>
    internal enum UpdatableHelpCommandType
    {
        UnknownCommand = 0,
        UpdateHelpCommand = 1,
        SaveHelpCommand = 2
    }
internal class UpdatableHelpProgressEventArgs : EventArgs
{
internal UpdatableHelpProgressEventArgs(string moduleName, string status, int percent)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,6414,6766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7530,7569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7662,7699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7784,7819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7905,7964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,6525,6569);

f_1180_6525_6568(!f_1180_6539_6567(status));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,6585,6639);

CommandType = UpdatableHelpCommandType.UnknownCommand;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,6653,6677);

ProgressStatus = status;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,6691,6717);

ProgressPercent = percent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,6731,6755);

ModuleName = moduleName;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,6414,6766);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,6414,6766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,6414,6766);
}
		}

internal UpdatableHelpProgressEventArgs(string moduleName, UpdatableHelpCommandType type, string status, int percent)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,7093,7441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7530,7569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7662,7699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7784,7819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7905,7964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7235,7279);

f_1180_7235_7278(!f_1180_7249_7277(status));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7295,7314);

CommandType = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7328,7352);

ProgressStatus = status;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7366,7392);

ProgressPercent = percent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,7406,7430);

ModuleName = moduleName;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,7093,7441);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,7093,7441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,7093,7441);
}
		}

internal string ProgressStatus {get; }

internal int ProgressPercent {get; }

internal string ModuleName {get; }

internal UpdatableHelpCommandType CommandType {get; set; }

static UpdatableHelpProgressEventArgs()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1180,6079,7971);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1180,6079,7971);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,6079,7971);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1180,6079,7971);

bool
f_1180_6539_6567(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 6539, 6567);
return return_v;
}


int
f_1180_6525_6568(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 6525, 6568);
return 0;
}


bool
f_1180_7249_7277(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 7249, 7277);
return return_v;
}


int
f_1180_7235_7278(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 7235, 7278);
return 0;
}

}
internal class UpdatableHelpSystem : IDisposable
{
private TimeSpan _defaultTimeout;

private Collection<UpdatableHelpProgressEventArgs> _progressEvents;

private bool _stopping;

private object _syncObject;

private UpdatableHelpCommandBase _cmdlet;

private CancellationTokenSource _cancelTokenSource;

internal WebClient WebClient {get; }

internal string CurrentModule {get; set; }

internal UpdatableHelpSystem(UpdatableHelpCommandBase cmdlet, bool useDefaultCredentials)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,8646,9482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8253,8268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8292,8301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8327,8338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8382,8389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8432,8450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8463,8500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8512,8555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9895,9941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8760,8788);

WebClient = f_1180_8772_8787();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8802,8843);

_defaultTimeout = f_1180_8820_8842(0, 0, 30);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8857,8924);

_progressEvents = f_1180_8875_8923();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8938,8975);

Errors = f_1180_8947_8974();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,8989,9007);

_stopping = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9021,9048);

_syncObject = f_1180_9035_9047();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9062,9079);

_cmdlet = cmdlet;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9093,9144);

_cancelTokenSource = f_1180_9114_9143();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9160,9216);

f_1180_9160_9169().UseDefaultCredentials = useDefaultCredentials;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,8646,9482);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,8646,9482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,8646,9482);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,9580,9803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9689,9718);

f_1180_9689_9717(            _cancelTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9732,9752);

f_1180_9732_9751(f_1180_9732_9741());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,9766,9792);

f_1180_9766_9791(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,9580,9803);

int
f_1180_9689_9717(System.Threading.CancellationTokenSource
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 9689, 9717);
return 0;
}


System.Net.WebClient
f_1180_9732_9741()
{
var return_v = WebClient;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 9732, 9741);
return return_v;
}


int
f_1180_9732_9751(System.Net.WebClient
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 9732, 9751);
return 0;
}


int
f_1180_9766_9791(System.Management.Automation.Help.UpdatableHelpSystem
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 9766, 9791);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,9580,9803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,9580,9803);
}
		}

internal Collection<Exception> Errors {get; }

internal IEnumerable<string> GetCurrentUICulture()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,10122,10576);

var listYield= new List<String>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10197,10248);

CultureInfo 
culture = f_1180_10219_10247()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10264,10537) || true) && (culture != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,10264,10537);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10320,10431) || true) && (f_1180_10324_10358(f_1180_10345_10357(culture)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,10320,10431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10400,10412);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,10320,10431);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10451,10477);

listYield.Add(f_1180_10464_10476(culture));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10497,10522);

culture = f_1180_10507_10521(culture);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,10264,10537);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,10264,10537);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,10264,10537);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,10553,10565);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,10122,10576);

return listYield;

System.Globalization.CultureInfo
f_1180_10219_10247()
{
var return_v = CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 10219, 10247);
return return_v;
}


string
f_1180_10345_10357(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 10345, 10357);
return return_v;
}


bool
f_1180_10324_10358(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 10324, 10358);
return return_v;
}


string
f_1180_10464_10476(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 10464, 10476);
return return_v;
}


System.Globalization.CultureInfo
f_1180_10507_10521(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 10507, 10521);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,10122,10576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,10122,10576);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal UpdatableHelpUri GetHelpInfoUri(UpdatableHelpModuleInfo module, CultureInfo culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,10920,11163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,11038,11152);

return f_1180_11045_11151(f_1180_11066_11083(module), f_1180_11085_11102(module), culture, f_1180_11113_11150(this, f_1180_11124_11142(module), false));
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,10920,11163);

string
f_1180_11066_11083(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 11066, 11083);
return return_v;
}


System.Guid
f_1180_11085_11102(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.ModuleGuid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 11085, 11102);
return return_v;
}


string
f_1180_11124_11142(System.Management.Automation.Help.UpdatableHelpModuleInfo
this_param)
{
var return_v = this_param.HelpInfoUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 11124, 11142);
return return_v;
}


string
f_1180_11113_11150(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
baseUri,bool
verbose)
{
var return_v = this_param.ResolveUri( baseUri, verbose);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 11113, 11150);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpUri
f_1180_11045_11151(string
moduleName,System.Guid
moduleGuid,System.Globalization.CultureInfo
culture,string
resolvedUri)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpUri( moduleName, moduleGuid, culture, resolvedUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 11045, 11151);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,10920,11163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,10920,11163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal UpdatableHelpInfo GetHelpInfo(UpdatableHelpCommandType commandType, string uri, string moduleName, Guid moduleGuid, string culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,11621,13454);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,11822,11997);

f_1180_11822_11996(OnProgressChanged, this, f_1180_11846_11995(f_1180_11881_11894(), commandType, f_1180_11909_11991(f_1180_11949_11990()), 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12017,12028);

string 
xml
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12046,12697);
using(HttpClientHandler 
handler = f_1180_12081_12104()
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12146,12210);

handler.UseDefaultCredentials = f_1180_12178_12209(f_1180_12178_12187());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12232,12678);
using(HttpClient 
client = f_1180_12259_12282(handler)
)                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12332,12365);

client.Timeout = _defaultTimeout;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12391,12446);

Task<string> 
responseBody = f_1180_12419_12445(client, uri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12472,12498);

xml = f_1180_12478_12497(responseBody);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12524,12655) || true) && (f_1180_12528_12550(responseBody)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,12524,12655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12616,12628);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,12524,12655);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,12232,12678);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,12046,12697);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,12717,13030);

UpdatableHelpInfo 
helpInfo = f_1180_12746_13029(this, xml, moduleName, moduleGuid, currentCulture: culture, pathOverride: null, verbose: true, shouldResolveUri: true, ignoreValidationException: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,13050,13066);

return helpInfo;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1180,13211,13443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,13251,13428);

f_1180_13251_13427(OnProgressChanged, this, f_1180_13275_13426(f_1180_13310_13323(), commandType, f_1180_13338_13420(f_1180_13378_13419()), 100));
DynAbs.Tracing.TraceSender.TraceExitFinally(1180,13211,13443);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,11621,13454);

string
f_1180_11881_11894()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 11881, 11894);
return return_v;
}


string
f_1180_11949_11990()
{
var return_v =                     HelpDisplayStrings.UpdateProgressLocating;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 11949, 11990);
return return_v;
}


string
f_1180_11909_11991(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 11909, 11991);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_11846_11995(string
moduleName,System.Management.Automation.Help.UpdatableHelpCommandType
type,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, type, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 11846, 11995);
return return_v;
}


int
f_1180_11822_11996(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 11822, 11996);
return 0;
}


System.Net.Http.HttpClientHandler
f_1180_12081_12104()
{
var return_v = new System.Net.Http.HttpClientHandler();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 12081, 12104);
return return_v;
}


System.Net.WebClient
f_1180_12178_12187()
{
var return_v = WebClient;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 12178, 12187);
return return_v;
}


bool
f_1180_12178_12209(System.Net.WebClient
this_param)
{
var return_v = this_param.UseDefaultCredentials;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 12178, 12209);
return return_v;
}


System.Net.Http.HttpClient
f_1180_12259_12282(System.Net.Http.HttpClientHandler
handler)
{
var return_v = new System.Net.Http.HttpClient( (System.Net.Http.HttpMessageHandler)handler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 12259, 12282);
return return_v;
}


System.Threading.Tasks.Task<string>
f_1180_12419_12445(System.Net.Http.HttpClient
this_param,string
requestUri)
{
var return_v = this_param.GetStringAsync( requestUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 12419, 12445);
return return_v;
}


string
f_1180_12478_12497(System.Threading.Tasks.Task<string>
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 12478, 12497);
return return_v;
}


System.AggregateException
f_1180_12528_12550(System.Threading.Tasks.Task<string>
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 12528, 12550);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1180_12746_13029(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
xml,string
moduleName,System.Guid
moduleGuid,string
currentCulture,string
pathOverride,bool
verbose,bool
shouldResolveUri,bool
ignoreValidationException)
{
var return_v = this_param.CreateHelpInfo( xml, moduleName, moduleGuid, currentCulture: currentCulture, pathOverride: pathOverride, verbose: verbose, shouldResolveUri: shouldResolveUri, ignoreValidationException: ignoreValidationException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 12746, 13029);
return return_v;
}


string
f_1180_13310_13323()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 13310, 13323);
return return_v;
}


string
f_1180_13378_13419()
{
var return_v =                     HelpDisplayStrings.UpdateProgressLocating;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 13378, 13419);
return return_v;
}


string
f_1180_13338_13420(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 13338, 13420);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_13275_13426(string
moduleName,System.Management.Automation.Help.UpdatableHelpCommandType
type,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, type, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 13275, 13426);
return return_v;
}


int
f_1180_13251_13427(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 13251, 13427);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,11621,13454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,11621,13454);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string ResolveUri(string baseUri, bool verbose)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,13743,18684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,13823,13868);

f_1180_13823_13867(!f_1180_13837_13866(baseUri));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14448,14756) || true) && (f_1180_14452_14477(baseUri)||(DynAbs.Tracing.TraceSender.Expression_False(1180, 14452, 14502)||f_1180_14481_14502(baseUri, '/')))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,14448,14756);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14536,14706) || true) && (verbose)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,14536,14706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14589,14687);

f_1180_14589_14686(                    _cmdlet, f_1180_14610_14685(f_1180_14628_14675(), baseUri));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,14536,14706);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14726,14741);

return baseUri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,14448,14756);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14772,14929) || true) && (verbose)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,14772,14929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14817,14914);

f_1180_14817_14913(                _cmdlet, f_1180_14838_14912(f_1180_14856_14902(), baseUri));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,14772,14929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,14945,14966);

string 
uri = baseUri
;

            try
            {
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15077,15082);
                // We only allow 10 redirections
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15068,18264) || true) && (i < 10)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15092,15095)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1180,15068,18264))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,15068,18264);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15137,15234) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,15137,15234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15200,15211);

return uri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,15137,15234);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15258,18245);
using(HttpClientHandler 
handler = f_1180_15293_15316()
)                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15366,15400);

handler.AllowAutoRedirect = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15426,15490);

handler.UseDefaultCredentials = f_1180_15458_15489(f_1180_15458_15467());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15516,18222);
using(HttpClient 
client = f_1180_15543_15566(handler)
)                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15624,15664);

client.Timeout = f_1180_15641_15663(0, 0, 30);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15719,15784);

Task<HttpResponseMessage> 
responseMessage = f_1180_15763_15783(client, uri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15814,18195);
using(HttpResponseMessage 
response = f_1180_15852_15874(responseMessage)
)                            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,15940,18164) || true) && (f_1180_15944_15963(response)== HttpStatusCode.Found ||(DynAbs.Tracing.TraceSender.Expression_False(1180, 15944, 16074)||f_1180_16028_16047(response)== HttpStatusCode.Redirect )||(DynAbs.Tracing.TraceSender.Expression_False(1180, 15944, 16158)||f_1180_16115_16134(response)== HttpStatusCode.Moved )||(DynAbs.Tracing.TraceSender.Expression_False(1180, 15944, 16253)||f_1180_16199_16218(response)== HttpStatusCode.MovedPermanently))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,15940,18164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16327,16371);

Uri 
responseUri = f_1180_16345_16370(f_1180_16345_16361(response))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16411,16893) || true) && (f_1180_16415_16440(responseUri))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,16411,16893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16522,16551);

uri = f_1180_16528_16550(responseUri);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,16411,16893);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,16411,16893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16713,16744);

Uri 
originalAbs = f_1180_16731_16743(uri)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16786,16854);

uri = f_1180_16792_16853(uri, f_1180_16804_16828(originalAbs), f_1180_16830_16852(responseUri));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,16411,16893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16933,16950);

uri = f_1180_16939_16949(uri);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,16990,17216) || true) && (verbose)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,16990,17216);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17083,17177);

f_1180_17083_17176(                                        _cmdlet, f_1180_17104_17175(f_1180_17122_17169(), uri));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,16990,17216);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17256,17409) || true) && (f_1180_17260_17277(uri, '/'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,17256,17409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17359,17370);

return uri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,17256,17409);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,15940,18164);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,15940,18164);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17483,18164) || true) && (f_1180_17487_17506(response)== HttpStatusCode.OK)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,17483,18164);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17601,18129) || true) && (f_1180_17605_17622(uri, '/'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,17601,18129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17704,17715);

return uri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,17601,18129);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,17601,18129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,17877,18090);

throw f_1180_17883_18089("InvalidHelpInfoUri", f_1180_17938_17999(f_1180_17956_17993(), uri), ErrorCategory.InvalidOperation, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,17601,18129);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,17483,18164);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,15940,18164);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,15814,18195);
                            }
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,15516,18222);
                        }
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,15258,18245);
                    }
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,3197);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,3197);
}            }
            catch (UriFormatException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,18293,18475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,18354,18460);

throw f_1180_18360_18459("InvalidUriFormat", f_1180_18413_18422(e), ErrorCategory.InvalidData, null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,18293,18475);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,18491,18673);

throw f_1180_18497_18672("TooManyRedirections", f_1180_18553_18610(f_1180_18571_18609()), ErrorCategory.InvalidOperation, null, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,13743,18684);

bool
f_1180_13837_13866(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 13837, 13866);
return return_v;
}


int
f_1180_13823_13867(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 13823, 13867);
return 0;
}


bool
f_1180_14452_14477(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14452, 14477);
return return_v;
}


bool
f_1180_14481_14502(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14481, 14502);
return return_v;
}


string
f_1180_14628_14675()
{
var return_v = RemotingErrorIdStrings.URIRedirectWarningToHost;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 14628, 14675);
return return_v;
}


string
f_1180_14610_14685(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14610, 14685);
return return_v;
}


int
f_1180_14589_14686(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14589, 14686);
return 0;
}


string
f_1180_14856_14902()
{
var return_v = HelpDisplayStrings.UpdateHelpResolveUriVerbose;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 14856, 14902);
return return_v;
}


string
f_1180_14838_14912(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14838, 14912);
return return_v;
}


int
f_1180_14817_14913(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 14817, 14913);
return 0;
}


System.Net.Http.HttpClientHandler
f_1180_15293_15316()
{
var return_v = new System.Net.Http.HttpClientHandler();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 15293, 15316);
return return_v;
}


System.Net.WebClient
f_1180_15458_15467()
{
var return_v = WebClient;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 15458, 15467);
return return_v;
}


bool
f_1180_15458_15489(System.Net.WebClient
this_param)
{
var return_v = this_param.UseDefaultCredentials;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 15458, 15489);
return return_v;
}


System.Net.Http.HttpClient
f_1180_15543_15566(System.Net.Http.HttpClientHandler
handler)
{
var return_v = new System.Net.Http.HttpClient( (System.Net.Http.HttpMessageHandler)handler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 15543, 15566);
return return_v;
}


System.TimeSpan
f_1180_15641_15663(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 15641, 15663);
return return_v;
}


System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
f_1180_15763_15783(System.Net.Http.HttpClient
this_param,string
requestUri)
{
var return_v = this_param.GetAsync( requestUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 15763, 15783);
return return_v;
}


System.Net.Http.HttpResponseMessage
f_1180_15852_15874(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 15852, 15874);
return return_v;
}


System.Net.HttpStatusCode
f_1180_15944_15963(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.StatusCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 15944, 15963);
return return_v;
}


System.Net.HttpStatusCode
f_1180_16028_16047(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.StatusCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16028, 16047);
return return_v;
}


System.Net.HttpStatusCode
f_1180_16115_16134(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.StatusCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16115, 16134);
return return_v;
}


System.Net.HttpStatusCode
f_1180_16199_16218(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.StatusCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16199, 16218);
return return_v;
}


System.Net.Http.Headers.HttpResponseHeaders
f_1180_16345_16361(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.Headers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16345, 16361);
return return_v;
}


System.Uri
f_1180_16345_16370(System.Net.Http.Headers.HttpResponseHeaders
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16345, 16370);
return return_v;
}


bool
f_1180_16415_16440(System.Uri
this_param)
{
var return_v = this_param.IsAbsoluteUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16415, 16440);
return return_v;
}


string
f_1180_16528_16550(System.Uri
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 16528, 16550);
return return_v;
}


System.Uri
f_1180_16731_16743(string
uriString)
{
var return_v = new System.Uri( uriString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 16731, 16743);
return return_v;
}


string
f_1180_16804_16828(System.Uri
this_param)
{
var return_v = this_param.AbsolutePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 16804, 16828);
return return_v;
}


string
f_1180_16830_16852(System.Uri
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 16830, 16852);
return return_v;
}


string
f_1180_16792_16853(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 16792, 16853);
return return_v;
}


string
f_1180_16939_16949(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 16939, 16949);
return return_v;
}


string
f_1180_17122_17169()
{
var return_v = RemotingErrorIdStrings.URIRedirectWarningToHost;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 17122, 17169);
return return_v;
}


string
f_1180_17104_17175(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17104, 17175);
return return_v;
}


int
f_1180_17083_17176(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17083, 17176);
return 0;
}


bool
f_1180_17260_17277(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17260, 17277);
return return_v;
}


System.Net.HttpStatusCode
f_1180_17487_17506(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.StatusCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 17487, 17506);
return return_v;
}


bool
f_1180_17605_17622(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17605, 17622);
return return_v;
}


string
f_1180_17956_17993()
{
var return_v = HelpDisplayStrings.InvalidHelpInfoUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 17956, 17993);
return return_v;
}


string
f_1180_17938_17999(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17938, 17999);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_17883_18089(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 17883, 18089);
return return_v;
}


string
f_1180_18413_18422(System.UriFormatException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 18413, 18422);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_18360_18459(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.UriFormatException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 18360, 18459);
return return_v;
}


string
f_1180_18571_18609()
{
var return_v = HelpDisplayStrings.TooManyRedirections;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 18571, 18609);
return return_v;
}


string
f_1180_18553_18610(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 18553, 18610);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_18497_18672(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 18497, 18672);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,13743,18684);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,13743,18684);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private const string 
HelpInfoXmlSchema = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <xs:schema attributeFormDefault=""unqualified"" elementFormDefault=""qualified""
                targetNamespace=""http://schemas.microsoft.com/powershell/help/2010/05"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
                <xs:element name=""HelpInfo"">
                    <xs:complexType>
                        <xs:sequence>
                            <xs:element name=""HelpContentURI"" type=""xs:anyURI"" minOccurs=""1"" maxOccurs=""1"" />
                            <xs:element name=""SupportedUICultures"" minOccurs=""1"" maxOccurs=""1"">
                                <xs:complexType>
                                    <xs:sequence>
                                        <xs:element name=""UICulture"" minOccurs=""1"" maxOccurs=""unbounded"">
                                            <xs:complexType>
                                                <xs:sequence>
                                                    <xs:element name=""UICultureName"" type=""xs:language"" minOccurs=""1"" maxOccurs=""1"" />
                                                    <xs:element name=""UICultureVersion"" type=""xs:string"" minOccurs=""1"" maxOccurs=""1"" />
                                                </xs:sequence>
                                            </xs:complexType>
                                        </xs:element>
                                    </xs:sequence>
                                </xs:complexType>
                            </xs:element>
                        </xs:sequence>
                    </xs:complexType>
                </xs:element>
            </xs:schema>"
;

private const string 
HelpInfoXmlNamespace = "http://schemas.microsoft.com/powershell/help/2010/05"
;

private const string 
HelpInfoXmlValidationFailure = "HelpInfoXmlValidationFailure"
;

internal UpdatableHelpInfo CreateHelpInfo(string xml, string moduleName, Guid moduleGuid,
            string currentCulture, string pathOverride, bool verbose, bool shouldResolveUri, bool ignoreValidationException)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,21602,25097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,21842,21870);

XmlDocument 
document = null
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,21920,22103);

document = f_1180_21931_22102(this, xml, HelpInfoXmlNamespace, HelpInfoXmlSchema, new ValidationEventHandler(HelpInfoValidationHandler), true);
            }
            catch (UpdatableHelpSystemException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,22132,22436);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22203,22395) || true) && (ignoreValidationException &&(DynAbs.Tracing.TraceSender.Expression_True(1180, 22207, 22322)&&f_1180_22236_22322(HelpInfoXmlValidationFailure, f_1180_22272_22295(e), StringComparison.Ordinal)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,22203,22395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22364,22376);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,22203,22395);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22415,22421);

throw;
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,22132,22436);
            }
            catch (XmlException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,22450,22724);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22505,22552) || true) && (ignoreValidationException)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,22505,22552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22538,22550);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,22505,22552);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22572,22709);

throw f_1180_22578_22708(HelpInfoXmlValidationFailure, f_1180_22662_22671(e), ErrorCategory.InvalidData, null, e);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,22450,22724);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22740,22766);

string 
uri = pathOverride
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22780,22852);

string 
unresolvedUri = f_1180_22803_22851(f_1180_22803_22841(f_1180_22803_22823(document, "HelpInfo"), "HelpContentURI"))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22868,23179) || true) && (f_1180_22872_22906(pathOverride))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,22868,23179);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,22940,23164) || true) && (shouldResolveUri)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,22940,23164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23002,23043);

uri = f_1180_23008_23042(this, unresolvedUri, verbose);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,22940,23164);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,22940,23164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23125,23145);

uri = unresolvedUri;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,22940,23164);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,22868,23179);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23195,23273);

XmlNodeList 
cultures = f_1180_23218_23272(f_1180_23218_23261(f_1180_23218_23238(document, "HelpInfo"), "SupportedUICultures"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23289,23389);

CultureSpecificUpdatableHelp[] 
updatableHelpItem = new CultureSpecificUpdatableHelp[f_1180_23373_23387(cultures)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23414,23419);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23405,23705) || true) && (i < f_1180_23425_23439(cultures))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23441,23444)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1180,23405,23705))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,23405,23705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23478,23690);

updatableHelpItem[i] = f_1180_23501_23689(f_1180_23556_23611(f_1180_23572_23610(f_1180_23572_23600(f_1180_23572_23583(cultures, i), "UICultureName"))), f_1180_23634_23688(f_1180_23646_23687(f_1180_23646_23677(f_1180_23646_23657(cultures, i), "UICultureVersion"))));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,301);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,301);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23721,23806);

UpdatableHelpInfo 
helpInfo = f_1180_23750_23805(unresolvedUri, updatableHelpItem)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23822,24596) || true) && (!f_1180_23827_23863(currentCulture))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,23822,24596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,23897,23993);

WildcardOptions 
wildcardOptions = WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24011,24154);

IEnumerable<WildcardPattern> 
patternList = f_1180_24054_24153(new string[1] { currentCulture }, wildcardOptions)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24183,24188);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24174,24581) || true) && (i < f_1180_24194_24218(updatableHelpItem))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24220,24223)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1180,24174,24581))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,24174,24581);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24265,24562) || true) && (f_1180_24269_24370(f_1180_24317_24350(f_1180_24317_24345(updatableHelpItem[i])), patternList, true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,24265,24562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24420,24539);

f_1180_24420_24538(f_1180_24420_24453(helpInfo), f_1180_24458_24537(moduleName, moduleGuid, f_1180_24503_24531(updatableHelpItem[i]), uri));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,24265,24562);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,408);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,408);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1180,23822,24596);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24612,25054) || true) && (!f_1180_24617_24653(currentCulture)&&(DynAbs.Tracing.TraceSender.Expression_True(1180, 24616, 24701)&&f_1180_24657_24696(f_1180_24657_24690(helpInfo))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,24612,25054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,24771,25039);

throw f_1180_24777_25038("HelpCultureNotSupported", f_1180_24858_24993(f_1180_24876_24918(), currentCulture, f_1180_24961_24992(helpInfo)), ErrorCategory.InvalidOperation, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,24612,25054);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25070,25086);

return helpInfo;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,21602,25097);

System.Xml.XmlDocument
f_1180_21931_22102(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
xml,string
ns,string
schema,System.Xml.Schema.ValidationEventHandler
handler,bool
helpInfo)
{
var return_v = this_param.CreateValidXmlDocument( xml, ns, schema, handler, helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 21931, 22102);
return return_v;
}


string
f_1180_22272_22295(System.Management.Automation.Help.UpdatableHelpSystemException
this_param)
{
var return_v = this_param.FullyQualifiedErrorId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 22272, 22295);
return return_v;
}


bool
f_1180_22236_22322(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 22236, 22322);
return return_v;
}


string
f_1180_22662_22671(System.Xml.XmlException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 22662, 22671);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_22578_22708(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Xml.XmlException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 22578, 22708);
return return_v;
}


System.Xml.XmlElement
f_1180_22803_22823(System.Xml.XmlDocument
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 22803, 22823);
return return_v;
}


System.Xml.XmlElement
f_1180_22803_22841(System.Xml.XmlElement
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 22803, 22841);
return return_v;
}


string
f_1180_22803_22851(System.Xml.XmlElement
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 22803, 22851);
return return_v;
}


bool
f_1180_22872_22906(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 22872, 22906);
return return_v;
}


string
f_1180_23008_23042(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
baseUri,bool
verbose)
{
var return_v = this_param.ResolveUri( baseUri, verbose);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23008, 23042);
return return_v;
}


System.Xml.XmlElement
f_1180_23218_23238(System.Xml.XmlDocument
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23218, 23238);
return return_v;
}


System.Xml.XmlElement
f_1180_23218_23261(System.Xml.XmlElement
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23218, 23261);
return return_v;
}


System.Xml.XmlNodeList
f_1180_23218_23272(System.Xml.XmlElement
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23218, 23272);
return return_v;
}


int
f_1180_23373_23387(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23373, 23387);
return return_v;
}


int
f_1180_23425_23439(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23425, 23439);
return return_v;
}


System.Xml.XmlNode
f_1180_23572_23583(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23572, 23583);
return return_v;
}


System.Xml.XmlElement
f_1180_23572_23600(System.Xml.XmlNode
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23572, 23600);
return return_v;
}


string
f_1180_23572_23610(System.Xml.XmlElement
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23572, 23610);
return return_v;
}


System.Globalization.CultureInfo
f_1180_23556_23611(string
name)
{
var return_v = new System.Globalization.CultureInfo( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23556, 23611);
return return_v;
}


System.Xml.XmlNode
f_1180_23646_23657(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23646, 23657);
return return_v;
}


System.Xml.XmlElement
f_1180_23646_23677(System.Xml.XmlNode
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23646, 23677);
return return_v;
}


string
f_1180_23646_23687(System.Xml.XmlElement
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 23646, 23687);
return return_v;
}


System.Version
f_1180_23634_23688(string
version)
{
var return_v = new System.Version( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23634, 23688);
return return_v;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp
f_1180_23501_23689(System.Globalization.CultureInfo
culture,System.Version
version)
{
var return_v = new System.Management.Automation.Help.CultureSpecificUpdatableHelp( culture, version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23501, 23689);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1180_23750_23805(string
unresolvedUri,System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
cultures)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpInfo( unresolvedUri, cultures);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23750, 23805);
return return_v;
}


bool
f_1180_23827_23863(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 23827, 23863);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
f_1180_24054_24153(string[]
globPatterns,System.Management.Automation.WildcardOptions
options)
{
var return_v = SessionStateUtilities.CreateWildcardsFromStrings( (System.Collections.Generic.IEnumerable<string>)globPatterns, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24054, 24153);
return return_v;
}


int
f_1180_24194_24218(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24194, 24218);
return return_v;
}


System.Globalization.CultureInfo
f_1180_24317_24345(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24317, 24345);
return return_v;
}


string
f_1180_24317_24350(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24317, 24350);
return return_v;
}


bool
f_1180_24269_24370(string
text,System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
patterns,bool
defaultValue)
{
var return_v = SessionStateUtilities.MatchesAnyWildcardPattern( text, patterns, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24269, 24370);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1180_24420_24453(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.HelpContentUriCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24420, 24453);
return return_v;
}


System.Globalization.CultureInfo
f_1180_24503_24531(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24503, 24531);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpUri
f_1180_24458_24537(string
moduleName,System.Guid
moduleGuid,System.Globalization.CultureInfo
culture,string
resolvedUri)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpUri( moduleName, moduleGuid, culture, resolvedUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24458, 24537);
return return_v;
}


int
f_1180_24420_24538(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
this_param,System.Management.Automation.Help.UpdatableHelpUri
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24420, 24538);
return 0;
}


bool
f_1180_24617_24653(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24617, 24653);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
f_1180_24657_24690(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.HelpContentUriCollection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24657, 24690);
return return_v;
}


int
f_1180_24657_24696(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpUri>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24657, 24696);
return return_v;
}


string
f_1180_24876_24918()
{
var return_v = HelpDisplayStrings.HelpCultureNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 24876, 24918);
return return_v;
}


string
f_1180_24961_24992(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.GetSupportedCultures();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24961, 24992);
return return_v;
}


string
f_1180_24858_24993(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24858, 24993);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_24777_25038(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 24777, 25038);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,21602,25097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,21602,25097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private XmlDocument CreateValidXmlDocument(string xml, string ns, string schema, ValidationEventHandler handler,
            bool helpInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,25497,26911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25662,25715);

XmlReaderSettings 
settings = f_1180_25691_25714()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25731,25801);

f_1180_25731_25800(f_1180_25731_25747(settings), ns, f_1180_25756_25799(f_1180_25774_25798(schema)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25815,25863);

settings.ValidationType = ValidationType.Schema;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25879,25948);

XmlReader 
reader = f_1180_25898_25947(f_1180_25915_25936(xml), settings)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,25962,26003);

XmlDocument 
document = f_1180_25985_26002()
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26055,26077);

f_1180_26055_26076(                document, reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26095,26122);

f_1180_26095_26121(                document, handler);
            }
            catch (XmlSchemaValidationException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,26151,26868);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26222,26853) || true) && (helpInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,26222,26853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26276,26510);

throw f_1180_26282_26509(HelpInfoXmlValidationFailure, f_1180_26370_26447(f_1180_26388_26435(), f_1180_26437_26446(e)), ErrorCategory.InvalidData, null, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,26222,26853);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,26222,26853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26592,26834);

throw f_1180_26598_26833("HelpContentXmlValidationFailure", f_1180_26691_26771(f_1180_26709_26759(), f_1180_26761_26770(e)), ErrorCategory.InvalidData, null, e);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,26222,26853);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,26151,26868);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,26884,26900);

return document;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,25497,26911);

System.Xml.XmlReaderSettings
f_1180_25691_25714()
{
var return_v = new System.Xml.XmlReaderSettings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25691, 25714);
return return_v;
}


System.Xml.Schema.XmlSchemaSet
f_1180_25731_25747(System.Xml.XmlReaderSettings
this_param)
{
var return_v = this_param.Schemas;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 25731, 25747);
return return_v;
}


System.IO.StringReader
f_1180_25774_25798(string
s)
{
var return_v = new System.IO.StringReader( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25774, 25798);
return return_v;
}


System.Xml.XmlTextReader
f_1180_25756_25799(System.IO.StringReader
input)
{
var return_v = new System.Xml.XmlTextReader( (System.IO.TextReader)input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25756, 25799);
return return_v;
}


System.Xml.Schema.XmlSchema
f_1180_25731_25800(System.Xml.Schema.XmlSchemaSet
this_param,string
targetNamespace,System.Xml.XmlTextReader
schemaDocument)
{
var return_v = this_param.Add( targetNamespace, (System.Xml.XmlReader)schemaDocument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25731, 25800);
return return_v;
}


System.IO.StringReader
f_1180_25915_25936(string
s)
{
var return_v = new System.IO.StringReader( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25915, 25936);
return return_v;
}


System.Xml.XmlReader
f_1180_25898_25947(System.IO.StringReader
input,System.Xml.XmlReaderSettings
settings)
{
var return_v = XmlReader.Create( (System.IO.TextReader)input, settings);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25898, 25947);
return return_v;
}


System.Xml.XmlDocument
f_1180_25985_26002()
{
var return_v = new System.Xml.XmlDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 25985, 26002);
return return_v;
}


int
f_1180_26055_26076(System.Xml.XmlDocument
this_param,System.Xml.XmlReader
reader)
{
this_param.Load( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26055, 26076);
return 0;
}


int
f_1180_26095_26121(System.Xml.XmlDocument
this_param,System.Xml.Schema.ValidationEventHandler
validationEventHandler)
{
this_param.Validate( validationEventHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26095, 26121);
return 0;
}


string
f_1180_26388_26435()
{
var return_v = HelpDisplayStrings.HelpInfoXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 26388, 26435);
return return_v;
}


string
f_1180_26437_26446(System.Xml.Schema.XmlSchemaValidationException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 26437, 26446);
return return_v;
}


string
f_1180_26370_26447(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26370, 26447);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_26282_26509(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Xml.Schema.XmlSchemaValidationException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26282, 26509);
return return_v;
}


string
f_1180_26709_26759()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 26709, 26759);
return return_v;
}


string
f_1180_26761_26770(System.Xml.Schema.XmlSchemaValidationException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 26761, 26770);
return return_v;
}


string
f_1180_26691_26771(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26691, 26771);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_26598_26833(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Xml.Schema.XmlSchemaValidationException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 26598, 26833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,25497,26911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,25497,26911);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void HelpInfoValidationHandler(object sender, ValidationEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,27135,27735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,27238,27724);

switch (f_1180_27246_27258(arg))
            {

case XmlSeverityType.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,27238,27724);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,27368,27611);

throw f_1180_27374_27610(HelpInfoXmlValidationFailure, f_1180_27466_27532(f_1180_27484_27531()), ErrorCategory.InvalidData, null, f_1180_27596_27609(arg));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,27238,27724);

case XmlSeverityType.Warning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,27238,27724);
DynAbs.Tracing.TraceSender.TraceBreak(1180,27703,27709);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,27238,27724);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,27135,27735);

System.Xml.Schema.XmlSeverityType
f_1180_27246_27258(System.Xml.Schema.ValidationEventArgs
this_param)
{
var return_v = this_param.Severity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 27246, 27258);
return return_v;
}


string
f_1180_27484_27531()
{
var return_v = HelpDisplayStrings.HelpInfoXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 27484, 27531);
return return_v;
}


string
f_1180_27466_27532(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 27466, 27532);
return return_v;
}


System.Xml.Schema.XmlSchemaException
f_1180_27596_27609(System.Xml.Schema.ValidationEventArgs
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 27596, 27609);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_27374_27610(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Xml.Schema.XmlSchemaException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 27374, 27610);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,27135,27735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,27135,27735);
}
		}

private void HelpContentValidationHandler(object sender, ValidationEventArgs arg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,27964,28575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,28070,28564);

switch (f_1180_28078_28090(arg))
            {

case XmlSeverityType.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,28070,28564);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,28200,28451);

throw f_1180_28206_28450("HelpContentXmlValidationFailure", f_1180_28303_28372(f_1180_28321_28371()), ErrorCategory.InvalidData, null, f_1180_28436_28449(arg));
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,28070,28564);

case XmlSeverityType.Warning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,28070,28564);
DynAbs.Tracing.TraceSender.TraceBreak(1180,28543,28549);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,28070,28564);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,27964,28575);

System.Xml.Schema.XmlSeverityType
f_1180_28078_28090(System.Xml.Schema.ValidationEventArgs
this_param)
{
var return_v = this_param.Severity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 28078, 28090);
return return_v;
}


string
f_1180_28321_28371()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 28321, 28371);
return return_v;
}


string
f_1180_28303_28372(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 28303, 28372);
return return_v;
}


System.Xml.Schema.XmlSchemaException
f_1180_28436_28449(System.Xml.Schema.ValidationEventArgs
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 28436, 28449);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_28206_28450(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Xml.Schema.XmlSchemaException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 28206, 28450);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,27964,28575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,27964,28575);
}
		}

internal void CancelDownload()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,28757,28882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,28812,28840);

f_1180_28812_28839(            _cancelTokenSource);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,28854,28871);

_stopping = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,28757,28882);

int
f_1180_28812_28839(System.Threading.CancellationTokenSource
this_param)
{
this_param.Cancel();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 28812, 28839);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,28757,28882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,28757,28882);
}
		}

internal bool DownloadAndInstallHelpContent(UpdatableHelpCommandType commandType, ExecutionContext context, Collection<string> destPaths,
            string fileName, CultureInfo culture, string helpContentUri, string xsdPath, out Collection<string> installed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,29571,30492);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,29857,29987) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,29857,29987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,29904,29941);

installed = f_1180_29916_29940();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,29959,29972);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,29857,29987);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30003,30111);

string 
cache = f_1180_30018_30110(f_1180_30031_30049(), f_1180_30051_30109(f_1180_30084_30108()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30127,30328) || true) && (!f_1180_30132_30211(this, commandType, cache, helpContentUri, fileName, f_1180_30198_30210(culture)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,30127,30328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30245,30282);

installed = f_1180_30257_30281();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30300,30313);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,30127,30328);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30344,30453);

f_1180_30344_30452(this, commandType, context, cache, destPaths, fileName, cache, culture, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,30469,30481);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,29571,30492);

System.Collections.ObjectModel.Collection<string>
f_1180_29916_29940()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 29916, 29940);
return return_v;
}


string
f_1180_30031_30049()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30031, 30049);
return return_v;
}


string
f_1180_30084_30108()
{
var return_v = Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30084, 30108);
return return_v;
}


string?
f_1180_30051_30109(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30051, 30109);
return return_v;
}


string
f_1180_30018_30110(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30018, 30110);
return return_v;
}


string
f_1180_30198_30210(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 30198, 30210);
return return_v;
}


bool
f_1180_30132_30211(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,string
path,string
helpContentUri,string
fileName,string
culture)
{
var return_v = this_param.DownloadHelpContent( commandType, path, helpContentUri, fileName, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30132, 30211);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1180_30257_30281()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30257, 30281);
return return_v;
}


int
f_1180_30344_30452(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType,System.Management.Automation.ExecutionContext
context,string
sourcePath,System.Collections.ObjectModel.Collection<string>
destPaths,string
fileName,string
tempPath,System.Globalization.CultureInfo
culture,string
xsdPath,out System.Collections.ObjectModel.Collection<string>
installed)
{
this_param.InstallHelpContent( commandType, context, sourcePath, destPaths, fileName, tempPath, culture, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 30344, 30452);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,29571,30492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,29571,30492);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool DownloadHelpContent(UpdatableHelpCommandType commandType, string path, string helpContentUri, string fileName, string culture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,30979,31699);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31144,31219) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,31144,31219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31191,31204);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,31144,31219);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31235,31343) || true) && (!f_1180_31240_31262(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,31235,31343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31296,31328);

f_1180_31296_31327(path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,31235,31343);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31359,31532);

f_1180_31359_31531(OnProgressChanged, this, f_1180_31383_31530(f_1180_31418_31431(), commandType, f_1180_31446_31526(f_1180_31482_31525()), 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31548,31587);

string 
uri = helpContentUri + fileName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,31603,31688);

return f_1180_31610_31687(this, uri, f_1180_31645_31673(path, fileName), commandType);
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,30979,31699);

bool
f_1180_31240_31262(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31240, 31262);
return return_v;
}


System.IO.DirectoryInfo
f_1180_31296_31327(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31296, 31327);
return return_v;
}


string
f_1180_31418_31431()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 31418, 31431);
return return_v;
}


string
f_1180_31482_31525()
{
var return_v =                 HelpDisplayStrings.UpdateProgressConnecting;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 31482, 31525);
return return_v;
}


string
f_1180_31446_31526(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31446, 31526);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_31383_31530(string
moduleName,System.Management.Automation.Help.UpdatableHelpCommandType
type,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, type, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31383, 31530);
return return_v;
}


int
f_1180_31359_31531(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31359, 31531);
return 0;
}


string
f_1180_31645_31673(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31645, 31673);
return return_v;
}


bool
f_1180_31610_31687(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
uri,string
fileName,System.Management.Automation.Help.UpdatableHelpCommandType
commandType)
{
var return_v = this_param.DownloadHelpContentHttpClient( uri, fileName, commandType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 31610, 31687);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,30979,31699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,30979,31699);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool DownloadHelpContentHttpClient(string uri, string fileName, UpdatableHelpCommandType commandType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,31993,34795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32210,34741);
using(HttpClientHandler 
handler = f_1180_32245_32268()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32302,32336);

handler.AllowAutoRedirect = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32354,32418);

handler.UseDefaultCredentials = f_1180_32386_32417(f_1180_32386_32395());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32436,34726);
using(HttpClient 
client = f_1180_32463_32486(handler)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32528,32561);

client.Timeout = _defaultTimeout;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32583,32679);

Task<HttpResponseMessage> 
responseMsg = f_1180_32623_32678(client, f_1180_32639_32651(uri), f_1180_32653_32677(_cancelTokenSource))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32792,32811);

f_1180_32792_32810(
                    // TODO: Should I use a continuation to write the stream to a file?
                    responseMsg);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32835,32933) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,32835,32933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32898,32910);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,32835,32933);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,32957,34651) || true) && (f_1180_32961_32984_M(!responseMsg.IsCanceled))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,32957,34651);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,33034,34628) || true) && (f_1180_33038_33059(responseMsg)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,33034,34628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,33125,33382);

f_1180_33125_33381(f_1180_33125_33131(), f_1180_33136_33380("HelpContentNotFound", f_1180_33225_33282(f_1180_33243_33281()), ErrorCategory.ResourceUnavailable, null, f_1180_33358_33379(responseMsg)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,33034,34628);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,33034,34628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,33502,33513);
                            lock (_syncObject)
                            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,33579,33758);

f_1180_33579_33757(                                _progressEvents, f_1180_33599_33756(f_1180_33634_33647(), f_1180_33649_33750(f_1180_33705_33749()), 100));
                            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,33957,34007);

HttpResponseMessage 
response = f_1180_33988_34006(responseMsg)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,34037,34601) || true) && (f_1180_34041_34069(response))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,34037,34601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,34135,34175);

f_1180_34135_34174(this, response, fileName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,34037,34601);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,34037,34601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,34305,34570);

f_1180_34305_34569(f_1180_34305_34311(), f_1180_34316_34568("HelpContentNotFound", f_1180_34409_34466(f_1180_34427_34465()), ErrorCategory.ResourceUnavailable, null, f_1180_34546_34567(responseMsg)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,34037,34601);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,33034,34628);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,32957,34651);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,34675,34707);

f_1180_34675_34706(this, commandType);
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,32436,34726);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,32210,34741);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,34757,34784);

return (f_1180_34765_34777(f_1180_34765_34771())== 0);
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,31993,34795);

System.Net.Http.HttpClientHandler
f_1180_32245_32268()
{
var return_v = new System.Net.Http.HttpClientHandler();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 32245, 32268);
return return_v;
}


System.Net.WebClient
f_1180_32386_32395()
{
var return_v = WebClient;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 32386, 32395);
return return_v;
}


bool
f_1180_32386_32417(System.Net.WebClient
this_param)
{
var return_v = this_param.UseDefaultCredentials;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 32386, 32417);
return return_v;
}


System.Net.Http.HttpClient
f_1180_32463_32486(System.Net.Http.HttpClientHandler
handler)
{
var return_v = new System.Net.Http.HttpClient( (System.Net.Http.HttpMessageHandler)handler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 32463, 32486);
return return_v;
}


System.Uri
f_1180_32639_32651(string
uriString)
{
var return_v = new System.Uri( uriString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 32639, 32651);
return return_v;
}


System.Threading.CancellationToken
f_1180_32653_32677(System.Threading.CancellationTokenSource
this_param)
{
var return_v = this_param.Token;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 32653, 32677);
return return_v;
}


System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
f_1180_32623_32678(System.Net.Http.HttpClient
this_param,System.Uri
requestUri,System.Threading.CancellationToken
cancellationToken)
{
var return_v = this_param.GetAsync( requestUri, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 32623, 32678);
return return_v;
}


int
f_1180_32792_32810(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 32792, 32810);
return 0;
}


bool
f_1180_32961_32984_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 32961, 32984);
return return_v;
}


System.AggregateException
f_1180_33038_33059(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33038, 33059);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Exception>
f_1180_33125_33131()
{
var return_v = Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33125, 33131);
return return_v;
}


string
f_1180_33243_33281()
{
var return_v = HelpDisplayStrings.HelpContentNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33243, 33281);
return return_v;
}


string
f_1180_33225_33282(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33225, 33282);
return return_v;
}


System.AggregateException
f_1180_33358_33379(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33358, 33379);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_33136_33380(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.AggregateException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33136, 33380);
return return_v;
}


int
f_1180_33125_33381(System.Collections.ObjectModel.Collection<System.Exception>
this_param,System.Management.Automation.Help.UpdatableHelpSystemException
item)
{
this_param.Add( (System.Exception)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33125, 33381);
return 0;
}


string
f_1180_33634_33647()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33634, 33647);
return return_v;
}


string
f_1180_33705_33749()
{
var return_v =                                     HelpDisplayStrings.UpdateProgressDownloading;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33705, 33749);
return return_v;
}


string
f_1180_33649_33750(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33649, 33750);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_33599_33756(string
moduleName,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33599, 33756);
return return_v;
}


int
f_1180_33579_33757(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 33579, 33757);
return 0;
}


System.Net.Http.HttpResponseMessage
f_1180_33988_34006(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
var return_v = this_param.Result;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 33988, 34006);
return return_v;
}


bool
f_1180_34041_34069(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.IsSuccessStatusCode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34041, 34069);
return return_v;
}


int
f_1180_34135_34174(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Net.Http.HttpResponseMessage
response,string
fileName)
{
this_param.WriteResponseToFile( response, fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 34135, 34174);
return 0;
}


System.Collections.ObjectModel.Collection<System.Exception>
f_1180_34305_34311()
{
var return_v = Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34305, 34311);
return return_v;
}


string
f_1180_34427_34465()
{
var return_v = HelpDisplayStrings.HelpContentNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34427, 34465);
return return_v;
}


string
f_1180_34409_34466(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 34409, 34466);
return return_v;
}


System.AggregateException
f_1180_34546_34567(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34546, 34567);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_34316_34568(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.AggregateException
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, (System.Exception)innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 34316, 34568);
return return_v;
}


int
f_1180_34305_34569(System.Collections.ObjectModel.Collection<System.Exception>
this_param,System.Management.Automation.Help.UpdatableHelpSystemException
item)
{
this_param.Add( (System.Exception)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 34305, 34569);
return 0;
}


int
f_1180_34675_34706(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.Help.UpdatableHelpCommandType
commandType)
{
this_param.SendProgressEvents( commandType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 34675, 34706);
return 0;
}


System.Collections.ObjectModel.Collection<System.Exception>
f_1180_34765_34771()
{
var return_v = Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34765, 34771);
return return_v;
}


int
f_1180_34765_34777(System.Collections.ObjectModel.Collection<System.Exception>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 34765, 34777);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,31993,34795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,31993,34795);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteResponseToFile(HttpResponseMessage response, string fileName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,35019,35644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35227,35633);
using(FileStream 
downloadedFileStream = f_1180_35268_35327(fileName, FileMode.Create, FileAccess.Write)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35361,35432);

Task 
copyStreamOp = f_1180_35381_35431(f_1180_35381_35397(response), downloadedFileStream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35450,35470);

f_1180_35450_35469(                copyStreamOp);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35488,35618) || true) && (f_1180_35492_35514(copyStreamOp)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,35488,35618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35564,35599);

f_1180_35564_35598(f_1180_35564_35570(), f_1180_35575_35597(copyStreamOp));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,35488,35618);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,35227,35633);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,35019,35644);

System.IO.FileStream
f_1180_35268_35327(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access)
{
var return_v = new System.IO.FileStream( path, mode, access);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 35268, 35327);
return return_v;
}


System.Net.Http.HttpContent
f_1180_35381_35397(System.Net.Http.HttpResponseMessage
this_param)
{
var return_v = this_param.Content;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 35381, 35397);
return return_v;
}


System.Threading.Tasks.Task
f_1180_35381_35431(System.Net.Http.HttpContent
this_param,System.IO.FileStream
stream)
{
var return_v = this_param.CopyToAsync( (System.IO.Stream)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 35381, 35431);
return return_v;
}


int
f_1180_35450_35469(System.Threading.Tasks.Task
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 35450, 35469);
return 0;
}


System.AggregateException
f_1180_35492_35514(System.Threading.Tasks.Task
this_param)
{
var return_v = this_param.Exception ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 35492, 35514);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Exception>
f_1180_35564_35570()
{
var return_v = Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 35564, 35570);
return return_v;
}


System.AggregateException
f_1180_35575_35597(System.Threading.Tasks.Task
this_param)
{
var return_v = this_param.Exception;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 35575, 35597);
return return_v;
}


int
f_1180_35564_35598(System.Collections.ObjectModel.Collection<System.Exception>
this_param,System.AggregateException
item)
{
this_param.Add( (System.Exception)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 35564, 35598);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,35019,35644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,35019,35644);
}
		}

private void SendProgressEvents(UpdatableHelpCommandType commandType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,35656,36224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35793,35804);
            // Send progress events
            lock (_syncObject)
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35838,36198) || true) && (f_1180_35842_35863(_progressEvents)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,35838,36198);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,35909,36131);
foreach(UpdatableHelpProgressEventArgs evt in f_1180_35956_35971_I(_progressEvents) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,35909,36131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,36021,36051);

evt.CommandType = commandType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,36079,36108);

f_1180_36079_36107(OnProgressChanged, this, evt);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,35909,36131);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,223);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,223);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,36155,36179);

f_1180_36155_36178(
                    _progressEvents);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,35838,36198);
}
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,35656,36224);

int
f_1180_35842_35863(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 35842, 35863);
return return_v;
}


int
f_1180_36079_36107(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 36079, 36107);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
f_1180_35956_35971_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 35956, 35971);
return return_v;
}


int
f_1180_36155_36178(System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 36155, 36178);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,35656,36224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,35656,36224);
}
		}

internal void GenerateHelpInfo(string moduleName, Guid moduleGuid, string contentUri, string culture, Version version, string destPath, string fileName, bool force)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,36789,41971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,36978,37019);

f_1180_36978_37018(f_1180_36991_37017(destPath));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37035,37104) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,37035,37104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37082,37089);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,37035,37104);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37120,37175);

string 
destHelpInfo = f_1180_37142_37174(destPath, fileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37191,37278) || true) && (force)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,37191,37278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37234,37263);

f_1180_37234_37262(this, destHelpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,37191,37278);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37294,37331);

UpdatableHelpInfo 
oldHelpInfo = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37345,37426);

string 
xml = f_1180_37358_37425(_cmdlet, destHelpInfo, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37442,37879) || true) && (xml != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,37442,37879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37643,37864);

oldHelpInfo = f_1180_37657_37863(this, xml, moduleName, moduleGuid, currentCulture: null, pathOverride: null, verbose: false, shouldResolveUri: false, ignoreValidationException: force);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,37442,37879);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,37895,41960);
using(FileStream 
file = f_1180_37920_37983(destHelpInfo, FileMode.Create, FileAccess.Write)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38017,38070);

XmlWriterSettings 
settings = f_1180_38046_38069()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38088,38122);

settings.Encoding = f_1180_38108_38121();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38140,38163);

settings.Indent = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38218,41945);
using(XmlWriter 
writer = f_1180_38244_38276(file, settings)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38318,38346);

f_1180_38318_38345(                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38368,38461);

f_1180_38368_38460(                    writer, "HelpInfo", "http://schemas.microsoft.com/powershell/help/2010/05");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38485,38528);

f_1180_38485_38527(
                    writer, "HelpContentURI");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38550,38580);

f_1180_38550_38579(                    writer, contentUri);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38602,38627);

f_1180_38602_38626(                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38651,38699);

f_1180_38651_38698(
                    writer, "SupportedUICultures");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38723,38742);

bool 
found = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38766,41275) || true) && (oldHelpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,38766,41275);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38839,41252);
foreach(CultureSpecificUpdatableHelp oldInfo in f_1180_38888_38918_I(f_1180_38888_38918(oldHelpInfo)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,38839,41252);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,38976,41225) || true) && (f_1180_38980_39052(f_1180_38980_39000(f_1180_38980_38995(oldInfo)), culture, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,38976,41225);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39118,40491) || true) && (f_1180_39122_39153(f_1180_39122_39137(oldInfo), version))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,39118,40491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39227,39265);

f_1180_39227_39264(                                    writer, "UICulture");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39303,39345);

f_1180_39303_39344(                                    writer, "UICultureName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39383,39423);

f_1180_39383_39422(                                    writer, f_1180_39401_39421(f_1180_39401_39416(oldInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39461,39486);

f_1180_39461_39485(                                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39524,39569);

f_1180_39524_39568(                                    writer, "UICultureVersion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39607,39653);

f_1180_39607_39652(                                    writer, f_1180_39625_39651(f_1180_39625_39640(oldInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39691,39716);

f_1180_39691_39715(                                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39754,39779);

f_1180_39754_39778(                                    writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,39118,40491);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,39118,40491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,39925,39963);

f_1180_39925_39962(                                    writer, "UICulture");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40001,40043);

f_1180_40001_40042(                                    writer, "UICultureName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40081,40108);

f_1180_40081_40107(                                    writer, culture);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40146,40171);

f_1180_40146_40170(                                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40209,40254);

f_1180_40209_40253(                                    writer, "UICultureVersion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40292,40330);

f_1180_40292_40329(                                    writer, f_1180_40310_40328(version));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40368,40393);

f_1180_40368_40392(                                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40431,40456);

f_1180_40431_40455(                                    writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,39118,40491);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40527,40540);

found = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,38976,41225);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,38976,41225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40670,40708);

f_1180_40670_40707(                                writer, "UICulture");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40742,40784);

f_1180_40742_40783(                                writer, "UICultureName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40818,40858);

f_1180_40818_40857(                                writer, f_1180_40836_40856(f_1180_40836_40851(oldInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40892,40917);

f_1180_40892_40916(                                writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,40951,40996);

f_1180_40951_40995(                                writer, "UICultureVersion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41030,41076);

f_1180_41030_41075(                                writer, f_1180_41048_41074(f_1180_41048_41063(oldInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41110,41135);

f_1180_41110_41134(                                writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41169,41194);

f_1180_41169_41193(                                writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,38976,41225);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,38839,41252);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,2414);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,2414);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1180,38766,41275);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41299,41829) || true) && (!found)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,41299,41829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41359,41397);

f_1180_41359_41396(                        writer, "UICulture");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41423,41465);

f_1180_41423_41464(                        writer, "UICultureName");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41491,41518);

f_1180_41491_41517(                        writer, culture);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41544,41569);

f_1180_41544_41568(                        writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41595,41640);

f_1180_41595_41639(                        writer, "UICultureVersion");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41666,41704);

f_1180_41666_41703(                        writer, f_1180_41684_41702(version));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41730,41755);

f_1180_41730_41754(                        writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41781,41806);

f_1180_41781_41805(                        writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,41299,41829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41853,41878);

f_1180_41853_41877(
                    writer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,41900,41926);

f_1180_41900_41925(                    writer);
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,38218,41945);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,37895,41960);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,36789,41971);

bool
f_1180_36991_37017(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 36991, 37017);
return return_v;
}


int
f_1180_36978_37018(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 36978, 37018);
return 0;
}


string
f_1180_37142_37174(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 37142, 37174);
return return_v;
}


int
f_1180_37234_37262(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
path)
{
this_param.RemoveReadOnly( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 37234, 37262);
return 0;
}


string
f_1180_37358_37425(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = UpdatableHelpSystem.LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 37358, 37425);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpInfo
f_1180_37657_37863(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
xml,string
moduleName,System.Guid
moduleGuid,string
currentCulture,string
pathOverride,bool
verbose,bool
shouldResolveUri,bool
ignoreValidationException)
{
var return_v = this_param.CreateHelpInfo( xml, moduleName, moduleGuid, currentCulture: currentCulture, pathOverride: pathOverride, verbose: verbose, shouldResolveUri: shouldResolveUri, ignoreValidationException: ignoreValidationException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 37657, 37863);
return return_v;
}


System.IO.FileStream
f_1180_37920_37983(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access)
{
var return_v = new System.IO.FileStream( path, mode, access);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 37920, 37983);
return return_v;
}


System.Xml.XmlWriterSettings
f_1180_38046_38069()
{
var return_v = new System.Xml.XmlWriterSettings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38046, 38069);
return return_v;
}


System.Text.Encoding
f_1180_38108_38121()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 38108, 38121);
return return_v;
}


System.Xml.XmlWriter
f_1180_38244_38276(System.IO.FileStream
output,System.Xml.XmlWriterSettings
settings)
{
var return_v = XmlWriter.Create( (System.IO.Stream)output, settings);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38244, 38276);
return return_v;
}


int
f_1180_38318_38345(System.Xml.XmlWriter
this_param)
{
this_param.WriteStartDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38318, 38345);
return 0;
}


int
f_1180_38368_38460(System.Xml.XmlWriter
this_param,string
localName,string
ns)
{
this_param.WriteStartElement( localName, ns);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38368, 38460);
return 0;
}


int
f_1180_38485_38527(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38485, 38527);
return 0;
}


int
f_1180_38550_38579(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38550, 38579);
return 0;
}


int
f_1180_38602_38626(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38602, 38626);
return 0;
}


int
f_1180_38651_38698(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38651, 38698);
return 0;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1180_38888_38918(System.Management.Automation.Help.UpdatableHelpInfo
this_param)
{
var return_v = this_param.UpdatableHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 38888, 38918);
return return_v;
}


System.Globalization.CultureInfo
f_1180_38980_38995(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 38980, 38995);
return return_v;
}


string
f_1180_38980_39000(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 38980, 39000);
return return_v;
}


bool
f_1180_38980_39052(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38980, 39052);
return return_v;
}


System.Version
f_1180_39122_39137(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 39122, 39137);
return return_v;
}


bool
f_1180_39122_39153(System.Version
this_param,System.Version
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39122, 39153);
return return_v;
}


int
f_1180_39227_39264(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39227, 39264);
return 0;
}


int
f_1180_39303_39344(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39303, 39344);
return 0;
}


System.Globalization.CultureInfo
f_1180_39401_39416(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 39401, 39416);
return return_v;
}


string
f_1180_39401_39421(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 39401, 39421);
return return_v;
}


int
f_1180_39383_39422(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39383, 39422);
return 0;
}


int
f_1180_39461_39485(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39461, 39485);
return 0;
}


int
f_1180_39524_39568(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39524, 39568);
return 0;
}


System.Version
f_1180_39625_39640(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 39625, 39640);
return return_v;
}


string
f_1180_39625_39651(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39625, 39651);
return return_v;
}


int
f_1180_39607_39652(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39607, 39652);
return 0;
}


int
f_1180_39691_39715(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39691, 39715);
return 0;
}


int
f_1180_39754_39778(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39754, 39778);
return 0;
}


int
f_1180_39925_39962(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 39925, 39962);
return 0;
}


int
f_1180_40001_40042(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40001, 40042);
return 0;
}


int
f_1180_40081_40107(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40081, 40107);
return 0;
}


int
f_1180_40146_40170(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40146, 40170);
return 0;
}


int
f_1180_40209_40253(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40209, 40253);
return 0;
}


string
f_1180_40310_40328(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40310, 40328);
return return_v;
}


int
f_1180_40292_40329(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40292, 40329);
return 0;
}


int
f_1180_40368_40392(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40368, 40392);
return 0;
}


int
f_1180_40431_40455(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40431, 40455);
return 0;
}


int
f_1180_40670_40707(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40670, 40707);
return 0;
}


int
f_1180_40742_40783(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40742, 40783);
return 0;
}


System.Globalization.CultureInfo
f_1180_40836_40851(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 40836, 40851);
return return_v;
}


string
f_1180_40836_40856(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 40836, 40856);
return return_v;
}


int
f_1180_40818_40857(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40818, 40857);
return 0;
}


int
f_1180_40892_40916(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40892, 40916);
return 0;
}


int
f_1180_40951_40995(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 40951, 40995);
return 0;
}


System.Version
f_1180_41048_41063(System.Management.Automation.Help.CultureSpecificUpdatableHelp
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 41048, 41063);
return return_v;
}


string
f_1180_41048_41074(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41048, 41074);
return return_v;
}


int
f_1180_41030_41075(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41030, 41075);
return 0;
}


int
f_1180_41110_41134(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41110, 41134);
return 0;
}


int
f_1180_41169_41193(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41169, 41193);
return 0;
}


System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
f_1180_38888_38918_I(System.Management.Automation.Help.CultureSpecificUpdatableHelp[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 38888, 38918);
return return_v;
}


int
f_1180_41359_41396(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41359, 41396);
return 0;
}


int
f_1180_41423_41464(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41423, 41464);
return 0;
}


int
f_1180_41491_41517(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41491, 41517);
return 0;
}


int
f_1180_41544_41568(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41544, 41568);
return 0;
}


int
f_1180_41595_41639(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41595, 41639);
return 0;
}


string
f_1180_41684_41702(System.Version
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41684, 41702);
return return_v;
}


int
f_1180_41666_41703(System.Xml.XmlWriter
this_param,string
value)
{
this_param.WriteValue( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41666, 41703);
return 0;
}


int
f_1180_41730_41754(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41730, 41754);
return 0;
}


int
f_1180_41781_41805(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41781, 41805);
return 0;
}


int
f_1180_41853_41877(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41853, 41877);
return 0;
}


int
f_1180_41900_41925(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 41900, 41925);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,36789,41971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,36789,41971);
}
		}

private void RemoveReadOnly(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,42117,42578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,42182,42567) || true) && (f_1180_42186_42203(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,42182,42567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,42237,42290);

FileAttributes 
attributes = f_1180_42265_42289(path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,42310,42552) || true) && ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,42310,42552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,42421,42474);

attributes = (attributes & ~FileAttributes.ReadOnly);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,42496,42533);

f_1180_42496_42532(path, attributes);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,42310,42552);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,42182,42567);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,42117,42578);

bool
f_1180_42186_42203(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 42186, 42203);
return return_v;
}


System.IO.FileAttributes
f_1180_42265_42289(string
path)
{
var return_v = File.GetAttributes( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 42265, 42289);
return return_v;
}


int
f_1180_42496_42532(string
path,System.IO.FileAttributes
fileAttributes)
{
File.SetAttributes( path, fileAttributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 42496, 42532);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,42117,42578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,42117,42578);
}
		}

internal void InstallHelpContent(UpdatableHelpCommandType commandType, ExecutionContext context, string sourcePath,
            Collection<string> destPaths, string fileName, string tempPath, CultureInfo culture, string xsdPath,
            out Collection<string> installed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,43388,45963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43689,43726);

installed = f_1180_43701_43725();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43742,43866) || true) && (_stopping)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,43742,43866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43789,43826);

installed = f_1180_43801_43825();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43844,43851);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,43742,43866);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43921,44037) || true) && (!f_1180_43926_43952(tempPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,43921,44037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,43986,44022);

f_1180_43986_44021(tempPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,43921,44037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44053,44087);

f_1180_44053_44086(f_1180_44066_44081(destPaths)> 0);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44139,44316);

f_1180_44139_44315(OnProgressChanged, this, f_1180_44163_44314(f_1180_44198_44211(), commandType, f_1180_44226_44310(f_1180_44266_44309()), 0));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44336,44412);

string 
combinedSourcePath = f_1180_44364_44411(f_1180_44376_44410(sourcePath, fileName))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44432,44730) || true) && (f_1180_44436_44476(combinedSourcePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,44432,44730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44518,44711);

throw f_1180_44524_44710("HelpContentNotFound", f_1180_44580_44637(f_1180_44598_44636()), ErrorCategory.ResourceUnavailable, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,44432,44730);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44750,44843);

string 
combinedTempPath = f_1180_44776_44842(tempPath, f_1180_44799_44841(fileName))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44863,45003) || true) && (f_1180_44867_44901(combinedTempPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,44863,45003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,44943,44984);

f_1180_44943_44983(combinedTempPath, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,44863,45003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45023,45046);

bool 
needToCopy = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45064,45144);

f_1180_45064_45143(this, context, combinedSourcePath, combinedTempPath, out needToCopy);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45162,45331) || true) && (needToCopy)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,45162,45331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45218,45312);

f_1180_45218_45311(this, combinedTempPath, destPaths, f_1180_45274_45286(culture), xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,45162,45331);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1180,45360,45952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45400,45579);

f_1180_45400_45578(OnProgressChanged, this, f_1180_45424_45577(f_1180_45459_45472(), commandType, f_1180_45487_45571(f_1180_45527_45570()), 100));

                try
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45643,45773) || true) && (f_1180_45647_45673(tempPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,45643,45773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,45723,45750);

f_1180_45723_45749(tempPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,45643,45773);
}
                }
                catch (IOException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,45810,45833);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,45810,45833);
}
                catch (UnauthorizedAccessException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,45851,45890);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,45851,45890);
}
                catch (ArgumentException) { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,45908,45937);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,45908,45937);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1180,45360,45952);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,43388,45963);

System.Collections.ObjectModel.Collection<string>
f_1180_43701_43725()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 43701, 43725);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1180_43801_43825()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 43801, 43825);
return return_v;
}


bool
f_1180_43926_43952(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 43926, 43952);
return return_v;
}


System.IO.DirectoryInfo
f_1180_43986_44021(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 43986, 44021);
return return_v;
}


int
f_1180_44066_44081(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 44066, 44081);
return return_v;
}


int
f_1180_44053_44086(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44053, 44086);
return 0;
}


string
f_1180_44198_44211()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 44198, 44211);
return return_v;
}


string
f_1180_44266_44309()
{
var return_v =                     HelpDisplayStrings.UpdateProgressInstalling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 44266, 44309);
return return_v;
}


string
f_1180_44226_44310(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44226, 44310);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_44163_44314(string
moduleName,System.Management.Automation.Help.UpdatableHelpCommandType
type,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, type, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44163, 44314);
return return_v;
}


int
f_1180_44139_44315(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44139, 44315);
return 0;
}


string
f_1180_44376_44410(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44376, 44410);
return return_v;
}


string
f_1180_44364_44411(string
path)
{
var return_v = GetFilePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44364, 44411);
return return_v;
}


bool
f_1180_44436_44476(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44436, 44476);
return return_v;
}


string
f_1180_44598_44636()
{
var return_v = HelpDisplayStrings.HelpContentNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 44598, 44636);
return return_v;
}


string
f_1180_44580_44637(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44580, 44637);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_44524_44710(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44524, 44710);
return return_v;
}


string?
f_1180_44799_44841(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44799, 44841);
return return_v;
}


string
f_1180_44776_44842(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44776, 44842);
return return_v;
}


bool
f_1180_44867_44901(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44867, 44901);
return return_v;
}


int
f_1180_44943_44983(string
path,bool
recursive)
{
Directory.Delete( path, recursive);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 44943, 44983);
return 0;
}


int
f_1180_45064_45143(System.Management.Automation.Help.UpdatableHelpSystem
this_param,System.Management.Automation.ExecutionContext
context,string
srcPath,string
destPath,out bool
needToCopy)
{
this_param.UnzipHelpContent( context, srcPath, destPath, out needToCopy);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45064, 45143);
return 0;
}


string
f_1180_45274_45286(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 45274, 45286);
return return_v;
}


int
f_1180_45218_45311(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
sourcePath,System.Collections.ObjectModel.Collection<string>
destPaths,string
culture,string
xsdPath,out System.Collections.ObjectModel.Collection<string>
installed)
{
this_param.ValidateAndCopyHelpContent( sourcePath, destPaths, culture, xsdPath, out installed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45218, 45311);
return 0;
}


string
f_1180_45459_45472()
{
var return_v = CurrentModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 45459, 45472);
return return_v;
}


string
f_1180_45527_45570()
{
var return_v =                     HelpDisplayStrings.UpdateProgressInstalling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 45527, 45570);
return return_v;
}


string
f_1180_45487_45571(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45487, 45571);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpProgressEventArgs
f_1180_45424_45577(string
moduleName,System.Management.Automation.Help.UpdatableHelpCommandType
type,string
status,int
percent)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpProgressEventArgs( moduleName, type, status, percent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45424, 45577);
return return_v;
}


int
f_1180_45400_45578(System.EventHandler<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
this_param,System.Management.Automation.Help.UpdatableHelpSystem
sender,System.Management.Automation.Help.UpdatableHelpProgressEventArgs
e)
{
this_param.Invoke( (object)sender, e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45400, 45578);
return 0;
}


bool
f_1180_45647_45673(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45647, 45673);
return return_v;
}


int
f_1180_45723_45749(string
path)
{
Directory.Delete( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 45723, 45749);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,43388,45963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,43388,45963);
}
		}

private void UnzipHelpContent(ExecutionContext context, string srcPath, string destPath, out bool needToCopy)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,47291,51098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47425,47443);

needToCopy = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47459,47575) || true) && (!f_1180_47464_47490(destPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,47459,47575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47524,47560);

f_1180_47524_47559(destPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,47459,47575);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47591,47647);

string 
sourceDirectory = f_1180_47616_47646(srcPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47661,47697);

bool 
sucessfulDecompression = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47916,48024) || true) && (!f_1180_47921_47951(sourceDirectory, '\\'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,47916,48024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,47985,48009);

sourceDirectory += "\\";
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,47916,48024);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48040,48134) || true) && (!f_1180_48045_48068(destPath, '\\'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,48040,48134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48102,48119);

destPath += "\\";
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,48040,48134);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48150,48283);

sucessfulDecompression = f_1180_48175_48282(f_1180_48175_48220(), f_1180_48229_48254(srcPath), sourceDirectory, destPath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48305,48556) || true) && (!sucessfulDecompression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,48305,48556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48366,48541);

throw f_1180_48372_48540("UnableToExtract", f_1180_48424_48474(f_1180_48442_48473()), ErrorCategory.InvalidOperation, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,48305,48556);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48572,48618);

string[] 
files = f_1180_48589_48617(destPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48632,51087) || true) && (f_1180_48636_48648(files)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,48632,51087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48733,48774);

string 
file = f_1180_48747_48773(files[0])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,48792,50491) || true) && (!f_1180_48797_48823(file)&&(DynAbs.Tracing.TraceSender.Expression_True(1180, 48796, 48893)&&f_1180_48827_48893(file, "placeholder.txt", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,48792,50491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49007,49045);

var 
fileInfo = f_1180_49022_49044(files[0])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49067,50472) || true) && (f_1180_49071_49086(fileInfo)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,49067,50472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49259,49278);

needToCopy = false;
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49364,49386);

f_1180_49364_49385(files[0]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49416,49467);

string 
directory = f_1180_49435_49466(files[0])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49497,49658) || true) && (!f_1180_49502_49533(directory))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,49497,49658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,49599,49627);

f_1180_49599_49626(directory);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,49497,49658);
}
                        }
                        catch (FileNotFoundException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,49711,49769);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,49711,49769);
}
                        catch (DirectoryNotFoundException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,49795,49858);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,49795,49858);
}
                        catch (UnauthorizedAccessException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,49884,49948);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,49884,49948);
}
                        catch (System.Security.SecurityException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,49974,50044);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,49974,50044);
}
                        catch (ArgumentNullException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,50070,50128);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,50070,50128);
}
                        catch (ArgumentException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,50154,50208);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,50154,50208);
}
                        catch (PathTooLongException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,50234,50291);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,50234,50291);
}
                        catch (NotSupportedException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,50317,50375);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,50317,50375);
}
                        catch (IOException)
                        { DynAbs.Tracing.TraceSender.TraceEnterCatch(1180,50401,50449);
DynAbs.Tracing.TraceSender.TraceExitCatch(1180,50401,50449);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,49067,50472);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,48792,50491);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,48632,51087);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,48632,51087);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,50557,51072);
foreach(string file in f_1180_50581_50586_I(files) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,50557,51072);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,50628,51053) || true) && (f_1180_50632_50649(file))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,50628,51053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,50699,50735);

FileInfo 
fInfo = f_1180_50716_50734(file)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,50761,51030) || true) && ((f_1180_50766_50782(fInfo)& FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,50761,51030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,50956,51003);

fInfo.Attributes &= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ~(FileAttributes.ReadOnly),1180,50956,50972);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,50761,51030);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,50628,51053);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,50557,51072);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,516);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,516);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1180,48632,51087);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,47291,51098);

bool
f_1180_47464_47490(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 47464, 47490);
return return_v;
}


System.IO.DirectoryInfo
f_1180_47524_47559(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 47524, 47559);
return return_v;
}


string?
f_1180_47616_47646(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 47616, 47646);
return return_v;
}


bool
f_1180_47921_47951(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 47921, 47951);
return return_v;
}


bool
f_1180_48045_48068(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48045, 48068);
return return_v;
}


System.Management.Automation.Internal.ICabinetExtractor
f_1180_48175_48220()
{
var return_v = CabinetExtractorFactory.GetCabinetExtractor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48175, 48220);
return return_v;
}


string?
f_1180_48229_48254(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48229, 48254);
return return_v;
}


bool
f_1180_48175_48282(System.Management.Automation.Internal.ICabinetExtractor
this_param,string
cabinetName,string
srcPath,string
destPath)
{
var return_v = this_param.Extract( cabinetName, srcPath, destPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48175, 48282);
return return_v;
}


string
f_1180_48442_48473()
{
var return_v = HelpDisplayStrings.UnzipFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 48442, 48473);
return return_v;
}


string
f_1180_48424_48474(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48424, 48474);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_48372_48540(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48372, 48540);
return return_v;
}


string[]
f_1180_48589_48617(string
path)
{
var return_v = Directory.GetFiles( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48589, 48617);
return return_v;
}


int
f_1180_48636_48648(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 48636, 48648);
return return_v;
}


string?
f_1180_48747_48773(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48747, 48773);
return return_v;
}


bool
f_1180_48797_48823(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48797, 48823);
return return_v;
}


bool
f_1180_48827_48893(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 48827, 48893);
return return_v;
}


System.IO.FileInfo
f_1180_49022_49044(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 49022, 49044);
return return_v;
}


long
f_1180_49071_49086(System.IO.FileInfo
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 49071, 49086);
return return_v;
}


int
f_1180_49364_49385(string
path)
{
File.Delete( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 49364, 49385);
return 0;
}


string?
f_1180_49435_49466(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 49435, 49466);
return return_v;
}


bool
f_1180_49502_49533(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 49502, 49533);
return return_v;
}


int
f_1180_49599_49626(string
path)
{
Directory.Delete( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 49599, 49626);
return 0;
}


bool
f_1180_50632_50649(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 50632, 50649);
return return_v;
}


System.IO.FileInfo
f_1180_50716_50734(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 50716, 50734);
return return_v;
}


System.IO.FileAttributes
f_1180_50766_50782(System.IO.FileInfo
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 50766, 50782);
return return_v;
}


string[]
f_1180_50581_50586_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 50581, 50586);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,47291,51098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,47291,51098);
}
		}

private void ValidateAndCopyHelpContent(string sourcePath, Collection<string> destPaths, string culture, string xsdPath,
            out Collection<string> installed)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,51545,61555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,51737,51774);

installed = f_1180_51749_51773();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,51790,51846);

string 
xsd = f_1180_51803_51845(_cmdlet, xsdPath, null)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,51917,52510);
foreach(string file in f_1180_51941_51971_I(f_1180_51941_51971(sourcePath)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,51917,52510);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52005,52495) || true) && (!f_1180_52010_52092(f_1180_52024_52047(file), ".xml", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1180, 52009, 52200)&&!f_1180_52118_52200(f_1180_52132_52155(file), ".txt", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52005,52495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52242,52476);

throw f_1180_52248_52475("HelpContentContainsInvalidFiles", f_1180_52341_52410(f_1180_52359_52409()), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52005,52495);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,51917,52510);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,594);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,594);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52557,61544);
foreach(string file in f_1180_52581_52611_I(f_1180_52581_52611(sourcePath)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52557,61544);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52645,59771) || true) && (f_1180_52649_52731(f_1180_52663_52686(file), ".xml", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52645,59771);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52773,58796) || true) && (xsd == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52773,58796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,52838,52941);

throw f_1180_52844_52940(f_1180_52870_52939(f_1180_52888_52929(), xsdPath));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52773,58796);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52773,58796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53039,53092);

string 
xml = f_1180_53052_53091(_cmdlet, file, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53120,53187);

XmlReader 
documentReader = f_1180_53147_53186(f_1180_53164_53185(xml))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53213,53261);

XmlDocument 
contentDocument = f_1180_53243_53260()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53289,53326);

f_1180_53289_53325(
                        contentDocument, documentReader);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53354,53818) || true) && (f_1180_53358_53390(f_1180_53358_53384(contentDocument))!= 1 &&(DynAbs.Tracing.TraceSender.Expression_True(1180, 53358, 53436)&&f_1180_53399_53431(f_1180_53399_53425(contentDocument))!= 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,53354,53818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53494,53791);

throw f_1180_53500_53790("HelpContentXmlValidationFailure", f_1180_53601_53717(f_1180_53619_53669(), f_1180_53671_53716()), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,53354,53818);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53846,53875);

XmlNode 
helpItemsNode = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,53903,56049) || true) && (f_1180_53907_53938(contentDocument)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1180, 53907, 54079)&&f_1180_53979_54079(f_1180_53979_54020(f_1180_53979_54010(contentDocument)), "providerHelp", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,53903,56049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,54137,54169);

helpItemsNode = contentDocument;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,53903,56049);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,53903,56049);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,54283,56022) || true) && (f_1180_54287_54319(f_1180_54287_54313(contentDocument))== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,54283,56022);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,54390,55104) || true) && (!f_1180_54395_54490(f_1180_54395_54434(f_1180_54395_54424(f_1180_54395_54421(contentDocument), 0)), "helpItems", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,54390,55104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,54564,54877);

throw f_1180_54570_54876("HelpContentXmlValidationFailure", f_1180_54679_54795(f_1180_54697_54747(), f_1180_54749_54794()), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,54390,55104);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,54390,55104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,55023,55069);

helpItemsNode = f_1180_55039_55068(f_1180_55039_55065(contentDocument), 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,54390,55104);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,54283,56022);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,54283,56022);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,55170,56022) || true) && (f_1180_55174_55206(f_1180_55174_55200(contentDocument))== 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,55170,56022);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,55277,55991) || true) && (!f_1180_55282_55377(f_1180_55282_55321(f_1180_55282_55311(f_1180_55282_55308(contentDocument), 1)), "helpItems", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,55277,55991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,55451,55764);

throw f_1180_55457_55763("HelpContentXmlValidationFailure", f_1180_55566_55682(f_1180_55584_55634(), f_1180_55636_55681()), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,55277,55991);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,55277,55991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,55910,55956);

helpItemsNode = f_1180_55926_55955(f_1180_55926_55952(contentDocument), 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,55277,55991);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,55170,56022);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,54283,56022);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,53903,56049);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56077,56147);

f_1180_56077_56146(helpItemsNode != null, "helpItemsNode must not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56175,56244);

string 
targetNamespace = "http://schemas.microsoft.com/maml/2004/10"
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56272,58773);
foreach(XmlNode node in f_1180_56297_56321_I(f_1180_56297_56321(helpItemsNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56272,58773);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56379,58746) || true) && (f_1180_56383_56396(node)== XmlNodeType.Element)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56379,58746);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56485,58480) || true) && (!f_1180_56490_56563(f_1180_56490_56504(node), "providerHelp", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56485,58480);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56637,57630) || true) && (f_1180_56641_56706(f_1180_56641_56655(node), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56637,57630);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56788,57591) || true) && (!f_1180_56793_56898(f_1180_56793_56810(node), "http://schemas.microsoft.com/maml/2004/10", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56788,57591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,56988,57361);

throw f_1180_56994_57360("HelpContentXmlValidationFailure", f_1180_57111_57320(f_1180_57129_57179(), f_1180_57230_57319(f_1180_57248_57301(), targetNamespace)), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56788,57591);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,56788,57591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,57539,57548);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56788,57591);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56637,57630);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,57670,58445) || true) && (!f_1180_57675_57792(f_1180_57675_57692(node), "http://schemas.microsoft.com/maml/dev/command/2004/10", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1180, 57674, 57959)&&                                        !f_1180_57838_57959(f_1180_57838_57855(node), "http://schemas.microsoft.com/maml/dev/dscResource/2004/10", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,57670,58445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,58041,58406);

throw f_1180_58047_58405("HelpContentXmlValidationFailure", f_1180_58160_58365(f_1180_58178_58228(), f_1180_58275_58364(f_1180_58293_58346(), targetNamespace)), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,57670,58445);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56485,58480);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,58516,58715);

f_1180_58516_58714(this, f_1180_58539_58552(node), targetNamespace, xsd, new ValidationEventHandler(HelpContentValidationHandler), false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56379,58746);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,56272,58773);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,2502);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,2502);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52773,58796);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52645,59771);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,52645,59771);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,58838,59771) || true) && (f_1180_58842_58924(f_1180_58856_58879(file), ".txt", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,58838,59771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,58966,59043);

FileStream 
fileStream = f_1180_58990_59042(file, FileMode.Open, FileAccess.Read)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59067,59752) || true) && (f_1180_59071_59088(fileStream)> 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,59067,59752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59142,59177);

byte[] 
firstTwoBytes = new byte[2]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59205,59242);

f_1180_59205_59241(
                        fileStream, firstTwoBytes, 0, 2);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59340,59729) || true) && (firstTwoBytes[0] == 'M' &&(DynAbs.Tracing.TraceSender.Expression_True(1180, 59344, 59394)&&firstTwoBytes[1] == 'Z'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,59340,59729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59452,59702);

throw f_1180_59458_59701("HelpContentContainsInvalidFiles", f_1180_59559_59628(f_1180_59577_59627()), ErrorCategory.InvalidData, null, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,59340,59729);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,59067,59752);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,58838,59771);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52645,59771);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59791,61529);
foreach(string path in f_1180_59815_59824_I(destPaths) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,59791,61529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59866,59903);

f_1180_59866_59902(f_1180_59879_59901(path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,59927,59977);

string 
combinedPath = f_1180_59949_59976(path, culture)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60001,60149) || true) && (!f_1180_60006_60036(combinedPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,60001,60149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60086,60126);

f_1180_60086_60125(combinedPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,60001,60149);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60173,60242);

string 
destPath = f_1180_60191_60241(combinedPath, f_1180_60218_60240(file))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60335,60381);

FileAttributes? 
originalFileAttributes = null
;
                    try
                    {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60455,61099) || true) && (f_1180_60459_60480(destPath)&&(DynAbs.Tracing.TraceSender.Expression_True(1180, 60459, 60499)&&(f_1180_60485_60498(_cmdlet))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,60455,61099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60557,60597);

FileInfo 
fInfo = f_1180_60574_60596(destPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60627,61072) || true) && ((f_1180_60632_60648(fInfo)& FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,60627,61072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60852,60894);

originalFileAttributes = f_1180_60877_60893(fInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,60994,61041);

fInfo.Attributes &= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ~(FileAttributes.ReadOnly),1180,60994,61010);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,60627,61072);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,60455,61099);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,61127,61159);

f_1180_61127_61158(file, destPath, true);
                    }
                    finally
                    {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1180,61204,61462);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,61260,61439) || true) && (f_1180_61264_61295(originalFileAttributes))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,61260,61439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,61353,61412);

f_1180_61353_61411(destPath, f_1180_61382_61410(originalFileAttributes));
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,61260,61439);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1180,61204,61462);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,61486,61510);

f_1180_61486_61509(
                    installed, destPath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,59791,61529);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,1739);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,1739);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1180,52557,61544);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,8988);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,8988);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1180,51545,61555);

System.Collections.ObjectModel.Collection<string>
f_1180_51749_51773()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 51749, 51773);
return return_v;
}


string
f_1180_51803_51845(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 51803, 51845);
return return_v;
}


string[]
f_1180_51941_51971(string
path)
{
var return_v = Directory.GetFiles( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 51941, 51971);
return return_v;
}


string?
f_1180_52024_52047(string
path)
{
var return_v = Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52024, 52047);
return return_v;
}


bool
f_1180_52010_52092(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52010, 52092);
return return_v;
}


string?
f_1180_52132_52155(string
path)
{
var return_v = Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52132, 52155);
return return_v;
}


bool
f_1180_52118_52200(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52118, 52200);
return return_v;
}


string
f_1180_52359_52409()
{
var return_v = HelpDisplayStrings.HelpContentContainsInvalidFiles;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 52359, 52409);
return return_v;
}


string
f_1180_52341_52410(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52341, 52410);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_52248_52475(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52248, 52475);
return return_v;
}


string[]
f_1180_51941_51971_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 51941, 51971);
return return_v;
}


string[]
f_1180_52581_52611(string
path)
{
var return_v = Directory.GetFiles( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52581, 52611);
return return_v;
}


string?
f_1180_52663_52686(string
path)
{
var return_v = Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52663, 52686);
return return_v;
}


bool
f_1180_52649_52731(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52649, 52731);
return return_v;
}


string
f_1180_52888_52929()
{
var return_v = HelpDisplayStrings.HelpContentXsdNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 52888, 52929);
return return_v;
}


string
f_1180_52870_52939(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52870, 52939);
return return_v;
}


System.Management.Automation.ItemNotFoundException
f_1180_52844_52940(string
message)
{
var return_v = new System.Management.Automation.ItemNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52844, 52940);
return return_v;
}


string
f_1180_53052_53091(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = LoadStringFromPath( (System.Management.Automation.PSCmdlet)cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53052, 53091);
return return_v;
}


System.IO.StringReader
f_1180_53164_53185(string
s)
{
var return_v = new System.IO.StringReader( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53164, 53185);
return return_v;
}


System.Xml.XmlReader
f_1180_53147_53186(System.IO.StringReader
input)
{
var return_v = XmlReader.Create( (System.IO.TextReader)input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53147, 53186);
return return_v;
}


System.Xml.XmlDocument
f_1180_53243_53260()
{
var return_v = new System.Xml.XmlDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53243, 53260);
return return_v;
}


int
f_1180_53289_53325(System.Xml.XmlDocument
this_param,System.Xml.XmlReader
reader)
{
this_param.Load( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53289, 53325);
return 0;
}


System.Xml.XmlNodeList
f_1180_53358_53384(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53358, 53384);
return return_v;
}


int
f_1180_53358_53390(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53358, 53390);
return return_v;
}


System.Xml.XmlNodeList
f_1180_53399_53425(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53399, 53425);
return return_v;
}


int
f_1180_53399_53431(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53399, 53431);
return return_v;
}


string
f_1180_53619_53669()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53619, 53669);
return return_v;
}


string
f_1180_53671_53716()
{
var return_v = HelpDisplayStrings.RootElementMustBeHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53671, 53716);
return return_v;
}


string
f_1180_53601_53717(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53601, 53717);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_53500_53790(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53500, 53790);
return return_v;
}


System.Xml.XmlElement
f_1180_53907_53938(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.DocumentElement ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53907, 53938);
return return_v;
}


System.Xml.XmlElement
f_1180_53979_54010(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.DocumentElement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53979, 54010);
return return_v;
}


string
f_1180_53979_54020(System.Xml.XmlElement
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 53979, 54020);
return return_v;
}


bool
f_1180_53979_54079(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 53979, 54079);
return return_v;
}


System.Xml.XmlNodeList
f_1180_54287_54313(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54287, 54313);
return return_v;
}


int
f_1180_54287_54319(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54287, 54319);
return return_v;
}


System.Xml.XmlNodeList
f_1180_54395_54421(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54395, 54421);
return return_v;
}


System.Xml.XmlNode
f_1180_54395_54424(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54395, 54424);
return return_v;
}


string
f_1180_54395_54434(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54395, 54434);
return return_v;
}


bool
f_1180_54395_54490(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 54395, 54490);
return return_v;
}


string
f_1180_54697_54747()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54697, 54747);
return return_v;
}


string
f_1180_54749_54794()
{
var return_v = HelpDisplayStrings.RootElementMustBeHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 54749, 54794);
return return_v;
}


string
f_1180_54679_54795(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 54679, 54795);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_54570_54876(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 54570, 54876);
return return_v;
}


System.Xml.XmlNodeList
f_1180_55039_55065(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55039, 55065);
return return_v;
}


System.Xml.XmlNode
f_1180_55039_55068(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55039, 55068);
return return_v;
}


System.Xml.XmlNodeList
f_1180_55174_55200(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55174, 55200);
return return_v;
}


int
f_1180_55174_55206(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55174, 55206);
return return_v;
}


System.Xml.XmlNodeList
f_1180_55282_55308(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55282, 55308);
return return_v;
}


System.Xml.XmlNode
f_1180_55282_55311(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55282, 55311);
return return_v;
}


string
f_1180_55282_55321(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55282, 55321);
return return_v;
}


bool
f_1180_55282_55377(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 55282, 55377);
return return_v;
}


string
f_1180_55584_55634()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55584, 55634);
return return_v;
}


string
f_1180_55636_55681()
{
var return_v = HelpDisplayStrings.RootElementMustBeHelpItems;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55636, 55681);
return return_v;
}


string
f_1180_55566_55682(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 55566, 55682);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_55457_55763(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 55457, 55763);
return return_v;
}


System.Xml.XmlNodeList
f_1180_55926_55952(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55926, 55952);
return return_v;
}


System.Xml.XmlNode
f_1180_55926_55955(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 55926, 55955);
return return_v;
}


int
f_1180_56077_56146(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56077, 56146);
return 0;
}


System.Xml.XmlNodeList
f_1180_56297_56321(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 56297, 56321);
return return_v;
}


System.Xml.XmlNodeType
f_1180_56383_56396(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 56383, 56396);
return return_v;
}


string
f_1180_56490_56504(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 56490, 56504);
return return_v;
}


bool
f_1180_56490_56563(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56490, 56563);
return return_v;
}


string
f_1180_56641_56655(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 56641, 56655);
return return_v;
}


bool
f_1180_56641_56706(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56641, 56706);
return return_v;
}


string
f_1180_56793_56810(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NamespaceURI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 56793, 56810);
return return_v;
}


bool
f_1180_56793_56898(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56793, 56898);
return return_v;
}


string
f_1180_57129_57179()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 57129, 57179);
return return_v;
}


string
f_1180_57248_57301()
{
var return_v = HelpDisplayStrings.HelpContentMustBeInTargetNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 57248, 57301);
return return_v;
}


string
f_1180_57230_57319(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 57230, 57319);
return return_v;
}


string
f_1180_57111_57320(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 57111, 57320);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_56994_57360(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56994, 57360);
return return_v;
}


string
f_1180_57675_57692(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NamespaceURI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 57675, 57692);
return return_v;
}


bool
f_1180_57675_57792(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 57675, 57792);
return return_v;
}


string
f_1180_57838_57855(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NamespaceURI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 57838, 57855);
return return_v;
}


bool
f_1180_57838_57959(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 57838, 57959);
return return_v;
}


string
f_1180_58178_58228()
{
var return_v = HelpDisplayStrings.HelpContentXmlValidationFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 58178, 58228);
return return_v;
}


string
f_1180_58293_58346()
{
var return_v = HelpDisplayStrings.HelpContentMustBeInTargetNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 58293, 58346);
return return_v;
}


string
f_1180_58275_58364(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58275, 58364);
return return_v;
}


string
f_1180_58160_58365(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58160, 58365);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_58047_58405(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58047, 58405);
return return_v;
}


string
f_1180_58539_58552(System.Xml.XmlNode
this_param)
{
var return_v = this_param.OuterXml;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 58539, 58552);
return return_v;
}


System.Xml.XmlDocument
f_1180_58516_58714(System.Management.Automation.Help.UpdatableHelpSystem
this_param,string
xml,string
ns,string
schema,System.Xml.Schema.ValidationEventHandler
handler,bool
helpInfo)
{
var return_v = this_param.CreateValidXmlDocument( xml, ns, schema, handler, helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58516, 58714);
return return_v;
}


System.Xml.XmlNodeList
f_1180_56297_56321_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 56297, 56321);
return return_v;
}


string?
f_1180_58856_58879(string
path)
{
var return_v = Path.GetExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58856, 58879);
return return_v;
}


bool
f_1180_58842_58924(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58842, 58924);
return return_v;
}


System.IO.FileStream
f_1180_58990_59042(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access)
{
var return_v = new System.IO.FileStream( path, mode, access);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 58990, 59042);
return return_v;
}


long
f_1180_59071_59088(System.IO.FileStream
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 59071, 59088);
return return_v;
}


int
f_1180_59205_59241(System.IO.FileStream
this_param,byte[]
array,int
offset,int
count)
{
var return_v = this_param.Read( array, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59205, 59241);
return return_v;
}


string
f_1180_59577_59627()
{
var return_v = HelpDisplayStrings.HelpContentContainsInvalidFiles;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 59577, 59627);
return return_v;
}


string
f_1180_59559_59628(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59559, 59628);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemException
f_1180_59458_59701(string
errorId,string
message,System.Management.Automation.ErrorCategory
cat,object
targetObject,System.Exception
innerException)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemException( errorId, message, cat, targetObject, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59458, 59701);
return return_v;
}


bool
f_1180_59879_59901(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59879, 59901);
return return_v;
}


int
f_1180_59866_59902(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59866, 59902);
return 0;
}


string
f_1180_59949_59976(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59949, 59976);
return return_v;
}


bool
f_1180_60006_60036(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60006, 60036);
return return_v;
}


System.IO.DirectoryInfo
f_1180_60086_60125(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60086, 60125);
return return_v;
}


string?
f_1180_60218_60240(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60218, 60240);
return return_v;
}


string
f_1180_60191_60241(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60191, 60241);
return return_v;
}


bool
f_1180_60459_60480(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60459, 60480);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1180_60485_60498(Microsoft.PowerShell.Commands.UpdatableHelpCommandBase
this_param)
{
var return_v = this_param.Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 60485, 60498);
return return_v;
}


System.IO.FileInfo
f_1180_60574_60596(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 60574, 60596);
return return_v;
}


System.IO.FileAttributes
f_1180_60632_60648(System.IO.FileInfo
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 60632, 60648);
return return_v;
}


System.IO.FileAttributes
f_1180_60877_60893(System.IO.FileInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 60877, 60893);
return return_v;
}


int
f_1180_61127_61158(string
sourceFileName,string
destFileName,bool
overwrite)
{
File.Copy( sourceFileName, destFileName, overwrite);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 61127, 61158);
return 0;
}


bool
f_1180_61264_61295(System.IO.FileAttributes?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 61264, 61295);
return return_v;
}


System.IO.FileAttributes
f_1180_61382_61410(System.IO.FileAttributes?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 61382, 61410);
return return_v;
}


int
f_1180_61353_61411(string
path,System.IO.FileAttributes
fileAttributes)
{
File.SetAttributes( path, fileAttributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 61353, 61411);
return 0;
}


int
f_1180_61486_61509(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 61486, 61509);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1180_59815_59824_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 59815, 59824);
return return_v;
}


string[]
f_1180_52581_52611_I(string[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 52581, 52611);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,51545,61555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,51545,61555);
}
		}

internal static string LoadStringFromPath(PSCmdlet cmdlet, string path, PSCredential credential)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1180,61879,63352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62000,62027);

f_1180_62000_62026(path != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62043,62896) || true) && (credential != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,62043,62896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62133,62881);
using(UpdatableHelpSystemDrive 
drive = f_1180_62173_62250(cmdlet, f_1180_62210_62237(path), credential)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62292,62401);

string 
tempPath = f_1180_62310_62400(f_1180_62323_62341(), f_1180_62343_62399(f_1180_62376_62398()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62425,62603) || true) && (!f_1180_62430_62518(f_1180_62430_62456(f_1180_62430_62451(cmdlet)), f_1180_62464_62517(f_1180_62477_62492(drive), f_1180_62494_62516(path))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,62425,62603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62568,62580);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,62425,62603);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62627,62822);

f_1180_62627_62821(f_1180_62627_62653(f_1180_62627_62648(cmdlet)), new string[1] { f_1180_62675_62728(f_1180_62688_62703(drive), f_1180_62705_62727(path))}, tempPath, false, CopyContainers.CopyTargetContainer, true, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62846,62862);

path = tempPath;
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,62133,62881);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,62043,62896);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62912,62948);

string 
filePath = f_1180_62930_62947(path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,62962,63313) || true) && (!f_1180_62967_62997(filePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,62962,63313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63031,63298);
using(FileStream 
currentHelpInfoFile = f_1180_63071_63127(filePath, FileMode.Open, FileAccess.Read)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63169,63229);

StreamReader 
reader = f_1180_63191_63228(currentHelpInfoFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63253,63279);

return f_1180_63260_63278(reader);
DynAbs.Tracing.TraceSender.TraceExitUsing(1180,63031,63298);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,62962,63313);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63329,63341);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1180,61879,63352);

int
f_1180_62000_62026(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62000, 62026);
return 0;
}


string?
f_1180_62210_62237(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62210, 62237);
return return_v;
}


System.Management.Automation.Help.UpdatableHelpSystemDrive
f_1180_62173_62250(System.Management.Automation.PSCmdlet
cmdlet,string
path,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.Help.UpdatableHelpSystemDrive( cmdlet, path, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62173, 62250);
return return_v;
}


string
f_1180_62323_62341()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62323, 62341);
return return_v;
}


string
f_1180_62376_62398()
{
var return_v = Path.GetTempFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62376, 62398);
return return_v;
}


string?
f_1180_62343_62399(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62343, 62399);
return return_v;
}


string
f_1180_62310_62400(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62310, 62400);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1180_62430_62451(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62430, 62451);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1180_62430_62456(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62430, 62456);
return return_v;
}


string
f_1180_62477_62492(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62477, 62492);
return return_v;
}


string?
f_1180_62494_62516(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62494, 62516);
return return_v;
}


string
f_1180_62464_62517(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62464, 62517);
return return_v;
}


bool
f_1180_62430_62518(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string
path)
{
var return_v = this_param.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62430, 62518);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1180_62627_62648(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.InvokeProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62627, 62648);
return return_v;
}


System.Management.Automation.ItemCmdletProviderIntrinsics
f_1180_62627_62653(System.Management.Automation.ProviderIntrinsics
this_param)
{
var return_v = this_param.Item;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62627, 62653);
return return_v;
}


string
f_1180_62688_62703(System.Management.Automation.Help.UpdatableHelpSystemDrive
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 62688, 62703);
return return_v;
}


string?
f_1180_62705_62727(string
path)
{
var return_v = Path.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62705, 62727);
return return_v;
}


string
f_1180_62675_62728(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62675, 62728);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
f_1180_62627_62821(System.Management.Automation.ItemCmdletProviderIntrinsics
this_param,string[]
path,string
destinationPath,bool
recurse,System.Management.Automation.CopyContainers
copyContainers,bool
force,bool
literalPath)
{
var return_v = this_param.Copy( path, destinationPath, recurse, copyContainers, force, literalPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62627, 62821);
return return_v;
}


string
f_1180_62930_62947(string
path)
{
var return_v = GetFilePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62930, 62947);
return return_v;
}


bool
f_1180_62967_62997(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 62967, 62997);
return return_v;
}


System.IO.FileStream
f_1180_63071_63127(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access)
{
var return_v = new System.IO.FileStream( path, mode, access);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 63071, 63127);
return return_v;
}


System.IO.StreamReader
f_1180_63191_63228(System.IO.FileStream
stream)
{
var return_v = new System.IO.StreamReader( (System.IO.Stream)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 63191, 63228);
return return_v;
}


string
f_1180_63260_63278(System.IO.StreamReader
this_param)
{
var return_v = this_param.ReadToEnd();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 63260, 63278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,61879,63352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,61879,63352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetFilePath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1180,63571,64939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63643,63678);

FileInfo 
item = f_1180_63659_63677(path)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63877,63968) || true) && ((int)f_1180_63886_63901(item)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,63877,63968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,63941,63953);

return path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,63877,63968);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,64916,64928);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1180,63571,64939);

System.IO.FileInfo
f_1180_63659_63677(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 63659, 63677);
return return_v;
}


System.IO.FileAttributes
f_1180_63886_63901(System.IO.FileInfo
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 63886, 63901);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,63571,64939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,63571,64939);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetDefaultSourcePath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,65082,65418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,65145,65238);

var 
updatableHelpSetting = f_1180_65172_65237(Utils.SystemWideOnlyConfig)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,65252,65319);

string 
defaultSourcePath = f_1180_65279_65318_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(updatableHelpSetting, 1180, 65279, 65318)?.DefaultSourcePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,65333,65407);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1180, 65340, 65379)||((f_1180_65340_65379(defaultSourcePath)&&DynAbs.Tracing.TraceSender.Conditional_F2(1180, 65382, 65386))||DynAbs.Tracing.TraceSender.Conditional_F3(1180, 65389, 65406)))?null :defaultSourcePath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,65082,65418);

System.Management.Automation.Configuration.UpdatableHelp
f_1180_65172_65237(System.Management.Automation.Configuration.ConfigScope[]
preferenceOrder)
{
var return_v = Utils.GetPolicySetting<UpdatableHelp>( preferenceOrder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 65172, 65237);
return return_v;
}


string
f_1180_65279_65318_M(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 65279, 65318);
return return_v;
}


bool
f_1180_65340_65379(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 65340, 65379);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,65082,65418);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,65082,65418);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        
        
        internal event EventHandler<UpdatableHelpProgressEventArgs> 
OnProgressChanged
;

static UpdatableHelpSystem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1180,8094,67775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,18798,20533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,20565,20642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,20674,20735);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1180,8094,67775);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,8094,67775);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1180,8094,67775);

System.Net.WebClient
f_1180_8772_8787()
{
var return_v = new System.Net.WebClient();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 8772, 8787);
return return_v;
}


System.TimeSpan
f_1180_8820_8842(int
hours,int
minutes,int
seconds)
{
var return_v = new System.TimeSpan( hours, minutes, seconds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 8820, 8842);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>
f_1180_8875_8923()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Help.UpdatableHelpProgressEventArgs>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 8875, 8923);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Exception>
f_1180_8947_8974()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Exception>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 8947, 8974);
return return_v;
}


object
f_1180_9035_9047()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 9035, 9047);
return return_v;
}


System.Threading.CancellationTokenSource
f_1180_9114_9143()
{
var return_v = new System.Threading.CancellationTokenSource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 9114, 9143);
return return_v;
}


System.Net.WebClient
f_1180_9160_9169()
{
var return_v = WebClient;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 9160, 9169);
return return_v;
}

}
internal class UpdatableHelpSystemDrive : IDisposable
{
private string _driveName;

private PSCmdlet _cmdlet;

internal string DriveName
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,68147,68224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68183,68209);

return _driveName + ":\\";
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,68147,68224);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,68097,68235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,68097,68235);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal UpdatableHelpSystemDrive(PSCmdlet cmdlet, string path, PSCredential credential)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1180,68425,69837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,67958,67968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,67996,68003);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68547,68552);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68538,69826) || true) && (i < 6)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68561,68564)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1180,68538,69826))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,68538,69826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68598,68670);

_driveName = f_1180_68611_68669(f_1180_68644_68668());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68688,68705);

_cmdlet = cmdlet;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68819,68961) || true) && (f_1180_68823_68842(path, '\\')||(DynAbs.Tracing.TraceSender.Expression_False(1180, 68823, 68864)||f_1180_68846_68864(path, '/')))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,68819,68961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68906,68942);

path = f_1180_68913_68941(path, f_1180_68925_68936(path)- 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,68819,68961);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,68981,69065);

PSDriveInfo 
mappedDrive = f_1180_69007_69064(f_1180_69007_69032(f_1180_69007_69026(cmdlet)), _driveName, "local")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69085,69536) || true) && (mappedDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,69085,69536);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69150,69263) || true) && (f_1180_69154_69183(f_1180_69154_69170(mappedDrive), path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,69150,69263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69233,69240);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,69150,69263);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69342,69433) || true) && (i < 5)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,69342,69433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69401,69410);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,69342,69433);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69457,69517);

f_1180_69457_69516(f_1180_69457_69482(f_1180_69457_69476(cmdlet)), _driveName, true, "local");
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,69085,69536);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69556,69713);

mappedDrive = f_1180_69570_69712(_driveName, f_1180_69598_69658(f_1180_69598_69626(f_1180_69598_69617(cmdlet)), "FileSystem"), path, string.Empty, credential);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69733,69785);

f_1180_69733_69784(f_1180_69733_69758(f_1180_69733_69752(cmdlet)), mappedDrive, "local");
DynAbs.Tracing.TraceSender.TraceBreak(1180,69805,69811);

break;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1180,1,1289);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1180,1,1289);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1180,68425,69837);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,68425,69837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,68425,69837);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1180,69929,70262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,69975,70060);

PSDriveInfo 
mappedDrive = f_1180_70001_70059(f_1180_70001_70027(f_1180_70001_70021(_cmdlet)), _driveName, "local")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,70076,70209) || true) && (mappedDrive != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1180,70076,70209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,70133,70194);

f_1180_70133_70193(f_1180_70133_70159(f_1180_70133_70153(_cmdlet)), _driveName, true, "local");
DynAbs.Tracing.TraceSender.TraceExitCondition(1180,70076,70209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1180,70225,70251);

f_1180_70225_70250(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1180,69929,70262);

System.Management.Automation.SessionState
f_1180_70001_70021(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 70001, 70021);
return return_v;
}


System.Management.Automation.DriveManagementIntrinsics
f_1180_70001_70027(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 70001, 70027);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1180_70001_70059(System.Management.Automation.DriveManagementIntrinsics
this_param,string
driveName,string
scope)
{
var return_v = this_param.GetAtScope( driveName, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 70001, 70059);
return return_v;
}


System.Management.Automation.SessionState
f_1180_70133_70153(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 70133, 70153);
return return_v;
}


System.Management.Automation.DriveManagementIntrinsics
f_1180_70133_70159(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 70133, 70159);
return return_v;
}


int
f_1180_70133_70193(System.Management.Automation.DriveManagementIntrinsics
this_param,string
driveName,bool
force,string
scope)
{
this_param.Remove( driveName, force, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 70133, 70193);
return 0;
}


int
f_1180_70225_70250(System.Management.Automation.Help.UpdatableHelpSystemDrive
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 70225, 70250);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1180,69929,70262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,69929,70262);
}
		}

static UpdatableHelpSystemDrive()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1180,67873,70269);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1180,67873,70269);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1180,67873,70269);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1180,67873,70269);

string
f_1180_68644_68668()
{
var return_v = Path.GetRandomFileName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 68644, 68668);
return return_v;
}


string?
f_1180_68611_68669(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 68611, 68669);
return return_v;
}


bool
f_1180_68823_68842(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 68823, 68842);
return return_v;
}


bool
f_1180_68846_68864(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 68846, 68864);
return return_v;
}


int
f_1180_68925_68936(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 68925, 68936);
return return_v;
}


string
f_1180_68913_68941(string
this_param,int
startIndex)
{
var return_v = this_param.Remove( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 68913, 68941);
return return_v;
}


System.Management.Automation.SessionState
f_1180_69007_69026(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69007, 69026);
return return_v;
}


System.Management.Automation.DriveManagementIntrinsics
f_1180_69007_69032(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69007, 69032);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1180_69007_69064(System.Management.Automation.DriveManagementIntrinsics
this_param,string
driveName,string
scope)
{
var return_v = this_param.GetAtScope( driveName, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69007, 69064);
return return_v;
}


string
f_1180_69154_69170(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69154, 69170);
return return_v;
}


bool
f_1180_69154_69183(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69154, 69183);
return return_v;
}


System.Management.Automation.SessionState
f_1180_69457_69476(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69457, 69476);
return return_v;
}


System.Management.Automation.DriveManagementIntrinsics
f_1180_69457_69482(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69457, 69482);
return return_v;
}


int
f_1180_69457_69516(System.Management.Automation.DriveManagementIntrinsics
this_param,string
driveName,bool
force,string
scope)
{
this_param.Remove( driveName, force, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69457, 69516);
return 0;
}


System.Management.Automation.SessionState
f_1180_69598_69617(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69598, 69617);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1180_69598_69626(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69598, 69626);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1180_69598_69658(System.Management.Automation.SessionStateInternal
this_param,string
name)
{
var return_v = this_param.GetSingleProvider( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69598, 69658);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1180_69570_69712(string
name,System.Management.Automation.ProviderInfo
provider,string
root,string
description,System.Management.Automation.PSCredential
credential)
{
var return_v = new System.Management.Automation.PSDriveInfo( name, provider, root, description, credential);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69570, 69712);
return return_v;
}


System.Management.Automation.SessionState
f_1180_69733_69752(System.Management.Automation.PSCmdlet
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69733, 69752);
return return_v;
}


System.Management.Automation.DriveManagementIntrinsics
f_1180_69733_69758(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1180, 69733, 69758);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1180_69733_69784(System.Management.Automation.DriveManagementIntrinsics
this_param,System.Management.Automation.PSDriveInfo
drive,string
scope)
{
var return_v = this_param.New( drive, scope);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1180, 69733, 69784);
return return_v;
}

}
}
