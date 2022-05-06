// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691
#pragma warning disable 56506

using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Internal;
using System.Management.Automation.Host;
using System.Reflection;
using System.Resources;
using System.Diagnostics.CodeAnalysis; // for fxcop
using System.Security.AccessControl;

namespace System.Management.Automation.Provider
{
    /// <summary>
    /// This interface needs to be implemented by providers that want users to see
    /// provider-specific help.
    /// </summary>
    public interface ICmdletProviderSupportsHelp
    {

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Maml", Justification = "Maml is an acronym.")]
        string GetHelpMaml(string helpItemName, string path);
    }
public abstract partial class CmdletProvider : IResourceSupplier
{
private CmdletProviderContext _contextBase ;

private ProviderInfo _providerInformation ;

[TraceSourceAttribute(
             "CmdletProviderClasses",
             "The namespace provider base classes tracer")]
        internal static PSTraceSource providerBaseTracer ;

internal void SetProviderInformation(ProviderInfo providerInfoToSet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,3893,4198);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,3986,4130) || true) && (providerInfoToSet == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,3986,4130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,4049,4115);

throw f_1206_4055_4114("providerInfoToSet");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,3986,4130);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,4146,4187);

_providerInformation = providerInfoToSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,3893,4198);

System.Management.Automation.PSArgumentNullException
f_1206_4055_4114(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 4055, 4114);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,3893,4198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,3893,4198);
}
		}

internal virtual bool IsFilterSet()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,4508,4657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,4568,4615);

bool 
filterSet = !f_1206_4586_4614(f_1206_4607_4613())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,4629,4646);

return filterSet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,4508,4657);

string
f_1206_4607_4613()
{
var return_v = Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 4607, 4613);
return return_v;
}


bool
f_1206_4586_4614(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 4586, 4614);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,4508,4657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,4508,4657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal CmdletProviderContext Context
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,5190,5261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,5226,5246);

return _contextBase;
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,5190,5261);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,5127,7710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,5127,7710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,5277,7699);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,5313,5445) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,5313,5445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,5372,5426);

throw f_1206_5378_5425("value");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,5313,5445);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,5541,5952) || true) && (f_1206_5545_5561(value)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1206, 5545, 5632)&&f_1206_5594_5610(value)!= f_1206_5614_5632())&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 5545, 5774)&&                    !f_1206_5658_5774(ProviderCapabilities.Credentials, _providerInformation)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,5541,5952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,5816,5933);

throw f_1206_5822_5932(f_1206_5887_5931());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,5541,5952);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,6084,6649) || true) && (_providerInformation != null &&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6088, 6168)&&!f_1206_6121_6168(f_1206_6142_6167(_providerInformation)))&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6088, 6218)&&f_1206_6172_6218(f_1206_6172_6197(_providerInformation), "FileSystem"))&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6088, 6267)&&f_1206_6243_6259(value)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6088, 6330)&&f_1206_6292_6308(value)!= f_1206_6312_6330())&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6088, 6453)&&                    !f_1206_6356_6453(f_1206_6356_6425(f_1206_6356_6420(f_1206_6356_6410(f_1206_6356_6402(f_1206_6356_6378(value))))), "NewPSDriveCommand")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,6084,6649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,6495,6630);

throw f_1206_6501_6629(f_1206_6566_6628());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,6084,6649);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,6741,7094) || true) && ((!f_1206_6747_6781(f_1206_6768_6780(value))) &&(DynAbs.Tracing.TraceSender.Expression_True(1206, 6745, 6921)&&                    (!f_1206_6809_6920(ProviderCapabilities.Filter, _providerInformation))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,6741,7094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,6963,7075);

throw f_1206_6969_7074(f_1206_7034_7073());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,6741,7094);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,7239,7588) || true) && ((f_1206_7244_7264(value)) &&(DynAbs.Tracing.TraceSender.Expression_True(1206, 7243, 7409)&&                   (!f_1206_7291_7408(ProviderCapabilities.Transactions, _providerInformation))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,7239,7588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,7451,7569);

throw f_1206_7457_7568(f_1206_7522_7567());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,7239,7588);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,7608,7629);

_contextBase = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,7647,7684);

_contextBase.ProviderInstance = this;
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,5277,7699);

System.Management.Automation.PSArgumentNullException
f_1206_5378_5425(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 5378, 5425);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_5545_5561(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 5545, 5561);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_5594_5610(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 5594, 5610);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_5614_5632()
{
var return_v = PSCredential.Empty ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 5614, 5632);
return return_v;
}


bool
f_1206_5658_5774(System.Management.Automation.Provider.ProviderCapabilities
capability,System.Management.Automation.ProviderInfo
provider)
{
var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities( capability, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 5658, 5774);
return return_v;
}


string
f_1206_5887_5931()
{
var return_v =                         SessionStateStrings.Credentials_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 5887, 5931);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_5822_5932(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 5822, 5932);
return return_v;
}


string
f_1206_6142_6167(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6142, 6167);
return return_v;
}


bool
f_1206_6121_6168(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6121, 6168);
return return_v;
}


string
f_1206_6172_6197(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6172, 6197);
return return_v;
}


bool
f_1206_6172_6218(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6172, 6218);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_6243_6259(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6243, 6259);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_6292_6308(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6292, 6308);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_6312_6330()
{
var return_v = PSCredential.Empty ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6312, 6330);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_6356_6378(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6356, 6378);
return return_v;
}


System.Management.Automation.CommandProcessorBase
f_1206_6356_6402(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.CurrentCommandProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6356, 6402);
return return_v;
}


System.Management.Automation.Internal.InternalCommand
f_1206_6356_6410(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.Command;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6356, 6410);
return return_v;
}


System.Type
f_1206_6356_6420(System.Management.Automation.Internal.InternalCommand
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6356, 6420);
return return_v;
}


string
f_1206_6356_6425(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6356, 6425);
return return_v;
}


bool
f_1206_6356_6453(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6356, 6453);
return return_v;
}


string
f_1206_6566_6628()
{
var return_v =                         SessionStateStrings.FileSystemProviderCredentials_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6566, 6628);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_6501_6629(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6501, 6629);
return return_v;
}


string
f_1206_6768_6780(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 6768, 6780);
return return_v;
}


bool
f_1206_6747_6781(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6747, 6781);
return return_v;
}


bool
f_1206_6809_6920(System.Management.Automation.Provider.ProviderCapabilities
capability,System.Management.Automation.ProviderInfo
provider)
{
var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities( capability, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6809, 6920);
return return_v;
}


string
f_1206_7034_7073()
{
var return_v =                         SessionStateStrings.Filter_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 7034, 7073);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_6969_7074(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 6969, 7074);
return return_v;
}


bool
f_1206_7244_7264(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.UseTransaction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 7244, 7264);
return return_v;
}


bool
f_1206_7291_7408(System.Management.Automation.Provider.ProviderCapabilities
capability,System.Management.Automation.ProviderInfo
provider)
{
var return_v = CmdletProviderManagementIntrinsics.CheckProviderCapabilities( capability, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 7291, 7408);
return return_v;
}


string
f_1206_7522_7567()
{
var return_v =                         SessionStateStrings.Transactions_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 7522, 7567);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_7457_7568(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 7457, 7568);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,5127,7710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,5127,7710);
}
		}}

internal ProviderInfo Start(ProviderInfo providerInfo, CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,8175,8383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,8299,8331);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,8345,8372);

return f_1206_8352_8371(this, providerInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,8175,8383);

System.Management.Automation.ProviderInfo
f_1206_8352_8371(System.Management.Automation.Provider.CmdletProvider
this_param,System.Management.Automation.ProviderInfo
providerInfo)
{
var return_v = this_param.Start( providerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 8352, 8371);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,8175,8383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,8175,8383);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object StartDynamicParameters(CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,8880,9079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,8988,9020);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,9036,9068);

return f_1206_9043_9067(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,8880,9079);

object
f_1206_9043_9067(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.StartDynamicParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 9043, 9067);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,8880,9079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,8880,9079);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Stop(CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,9426,9578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,9514,9546);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,9560,9567);

f_1206_9560_9566(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,9426,9578);

int
f_1206_9560_9566(System.Management.Automation.Provider.CmdletProvider
this_param)
{
this_param.Stop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 9560, 9566);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,9426,9578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,9426,9578);
}
		}

protected internal virtual void StopProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,9679,9749);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,9679,9749);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,9679,9749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,9679,9749);
}
		}

internal void GetProperty(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,10575,11262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,10768,10800);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,10816,10891);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,10907,11134) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,10907,11134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,10969,11119);

throw
f_1206_10996_11118(f_1206_11061_11117());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,10907,11134);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,11190,11251);

f_1206_11190_11250(
            // Call interface method

            propertyProvider, path, providerSpecificPickList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,10575,11262);

string
f_1206_11061_11117()
{
var return_v =                         SessionStateStrings.IPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 11061, 11117);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_10996_11118(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 10996, 11118);
return return_v;
}


int
f_1206_11190_11250(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList)
{
this_param.GetProperty( path, providerSpecificPickList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 11190, 11250);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,10575,11262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,10575,11262);
}
		}

internal object GetPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,12164,12716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,12376,12408);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,12424,12499);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,12515,12604) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,12515,12604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,12577,12589);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,12515,12604);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,12620,12705);

return f_1206_12627_12704(propertyProvider, path, providerSpecificPickList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,12164,12716);

object
f_1206_12627_12704(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
providerSpecificPickList)
{
var return_v = this_param.GetPropertyDynamicParameters( path, providerSpecificPickList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 12627, 12704);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,12164,12716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,12164,12716);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetProperty(
            string path,
            PSObject propertyValue,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,13390,14045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,13562,13594);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,13610,13685);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,13701,13928) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,13701,13928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,13763,13913);

throw
f_1206_13790_13912(f_1206_13855_13911());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,13701,13928);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,13984,14034);

f_1206_13984_14033(
            // Call interface method

            propertyProvider, path, propertyValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,13390,14045);

string
f_1206_13855_13911()
{
var return_v =                         SessionStateStrings.IPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 13855, 13911);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_13790_13912(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 13790, 13912);
return return_v;
}


int
f_1206_13984_14033(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Management.Automation.PSObject
propertyValue)
{
this_param.SetProperty( path, propertyValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 13984, 14033);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,13390,14045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,13390,14045);
}
		}

internal object SetPropertyDynamicParameters(
            string path,
            PSObject propertyValue,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,14910,15430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,15101,15133);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,15149,15224);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,15240,15329) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,15240,15329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,15302,15314);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,15240,15329);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,15345,15419);

return f_1206_15352_15418(propertyProvider, path, propertyValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,14910,15430);

object
f_1206_15352_15418(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Management.Automation.PSObject
propertyValue)
{
var return_v = this_param.SetPropertyDynamicParameters( path, propertyValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 15352, 15418);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,14910,15430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,14910,15430);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearProperty(
            string path,
            Collection<string> propertyName,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,16250,16917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,16433,16465);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,16481,16556);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,16572,16799) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,16572,16799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,16634,16784);

throw
f_1206_16661_16783(f_1206_16726_16782());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,16572,16799);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,16855,16906);

f_1206_16855_16905(
            // Call interface method

            propertyProvider, path, propertyName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,16250,16917);

string
f_1206_16726_16782()
{
var return_v =                         SessionStateStrings.IPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 16726, 16782);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_16661_16783(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 16661, 16783);
return return_v;
}


int
f_1206_16855_16905(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyToClear)
{
this_param.ClearProperty( path, propertyToClear);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 16855, 16905);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,16250,16917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,16250,16917);
}
		}

internal object ClearPropertyDynamicParameters(
            string path,
            Collection<string> providerSpecificPickList,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,17817,18373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,18031,18063);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,18079,18154);

IPropertyCmdletProvider 
propertyProvider = this as IPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,18170,18259) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,18170,18259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,18232,18244);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,18170,18259);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,18275,18362);

return f_1206_18282_18361(propertyProvider, path, providerSpecificPickList);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,17817,18373);

object
f_1206_18282_18361(System.Management.Automation.Provider.IPropertyCmdletProvider
this_param,string
path,System.Collections.ObjectModel.Collection<string>
propertyToClear)
{
var return_v = this_param.ClearPropertyDynamicParameters( path, propertyToClear);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 18282, 18361);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,17817,18373);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,17817,18373);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void NewProperty(
            string path,
            string propertyName,
            string propertyTypeName,
            object value,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,19548,20310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,19782,19814);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,19830,19919);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,19935,20169) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,19935,20169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,19997,20154);

throw
f_1206_20024_20153(f_1206_20089_20152());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,19935,20169);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,20225,20299);

f_1206_20225_20298(
            // Call interface method

            propertyProvider, path, propertyName, propertyTypeName, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,19548,20310);

string
f_1206_20089_20152()
{
var return_v =                         SessionStateStrings.IDynamicPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 20089, 20152);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_20024_20153(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 20024, 20153);
return return_v;
}


int
f_1206_20225_20298(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
propertyName,string
propertyTypeName,object
value)
{
this_param.NewProperty( path, propertyName, propertyTypeName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 20225, 20298);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,19548,20310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,19548,20310);
}
		}

internal object NewPropertyDynamicParameters(
            string path,
            string propertyName,
            string propertyTypeName,
            object value,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,21369,21989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,21622,21654);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,21670,21759);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,21775,21864) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,21775,21864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,21837,21849);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,21775,21864);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,21880,21978);

return f_1206_21887_21977(propertyProvider, path, propertyName, propertyTypeName, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,21369,21989);

object
f_1206_21887_21977(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
propertyName,string
propertyTypeName,object
value)
{
var return_v = this_param.NewPropertyDynamicParameters( path, propertyName, propertyTypeName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 21887, 21977);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,21369,21989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,21369,21989);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveProperty(
            string path,
            string propertyName,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,22804,23482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,22976,23008);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,23024,23113);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,23129,23363) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,23129,23363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,23191,23348);

throw
f_1206_23218_23347(f_1206_23283_23346());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,23129,23363);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,23419,23471);

f_1206_23419_23470(
            // Call interface method

            propertyProvider, path, propertyName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,22804,23482);

string
f_1206_23283_23346()
{
var return_v =                         SessionStateStrings.IDynamicPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 23283, 23346);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_23218_23347(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 23218, 23347);
return return_v;
}


int
f_1206_23419_23470(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
propertyName)
{
this_param.RemoveProperty( path, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 23419, 23470);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,22804,23482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,22804,23482);
}
		}

internal object RemovePropertyDynamicParameters(
            string path,
            string propertyName,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,24292,24828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,24483,24515);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,24531,24620);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,24636,24725) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,24636,24725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,24698,24710);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,24636,24725);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,24741,24817);

return f_1206_24748_24816(propertyProvider, path, propertyName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,24292,24828);

object
f_1206_24748_24816(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
propertyName)
{
var return_v = this_param.RemovePropertyDynamicParameters( path, propertyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 24748, 24816);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,24292,24828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,24292,24828);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RenameProperty(
                    string path,
            string propertyName,
            string newPropertyName,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,25764,26504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,25981,26013);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,26029,26118);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,26134,26368) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,26134,26368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,26196,26353);

throw
f_1206_26223_26352(f_1206_26288_26351());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,26134,26368);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,26424,26493);

f_1206_26424_26492(
            // Call interface method

            propertyProvider, path, propertyName, newPropertyName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,25764,26504);

string
f_1206_26288_26351()
{
var return_v =                         SessionStateStrings.IDynamicPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 26288, 26351);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_26223_26352(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 26223, 26352);
return return_v;
}


int
f_1206_26424_26492(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
sourceProperty,string
destinationProperty)
{
this_param.RenameProperty( path, sourceProperty, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 26424, 26492);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,25764,26504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,25764,26504);
}
		}

internal object RenamePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationProperty,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,27441,28043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,27675,27707);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,27723,27812);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,27828,27917) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,27828,27917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,27890,27902);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,27828,27917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,27933,28032);

return f_1206_27940_28031(propertyProvider, path, sourceProperty, destinationProperty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,27441,28043);

object
f_1206_27940_28031(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
path,string
sourceProperty,string
destinationProperty)
{
var return_v = this_param.RenamePropertyDynamicParameters( path, sourceProperty, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 27940, 28031);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,27441,28043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,27441,28043);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void CopyProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,29148,29954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,29404,29436);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,29452,29541);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,29557,29791) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,29557,29791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,29619,29776);

throw
f_1206_29646_29775(f_1206_29711_29774());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,29557,29791);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,29847,29943);

f_1206_29847_29942(
            // Call interface method

            propertyProvider, sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,29148,29954);

string
f_1206_29711_29774()
{
var return_v =                         SessionStateStrings.IDynamicPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 29711, 29774);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_29646_29775(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 29646, 29775);
return return_v;
}


int
f_1206_29847_29942(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty)
{
this_param.CopyProperty( sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 29847, 29942);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,29148,29954);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,29148,29954);
}
		}

internal object CopyPropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,31037,31689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,31306,31338);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,31354,31443);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,31459,31548) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,31459,31548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,31521,31533);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,31459,31548);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,31564,31678);

return f_1206_31571_31677(propertyProvider, path, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,31037,31689);

object
f_1206_31571_31677(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty)
{
var return_v = this_param.CopyPropertyDynamicParameters( sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 31571, 31677);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,31037,31689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,31037,31689);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void MoveProperty(
            string sourcePath,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,32789,33595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,33045,33077);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,33093,33182);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,33198,33432) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,33198,33432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,33260,33417);

throw
f_1206_33287_33416(f_1206_33352_33415());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,33198,33432);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,33488,33584);

f_1206_33488_33583(
            // Call interface method

            propertyProvider, sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,32789,33595);

string
f_1206_33352_33415()
{
var return_v =                         SessionStateStrings.IDynamicPropertyCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 33352, 33415);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_33287_33416(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 33287, 33416);
return return_v;
}


int
f_1206_33488_33583(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty)
{
this_param.MoveProperty( sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 33488, 33583);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,32789,33595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,32789,33595);
}
		}

internal object MovePropertyDynamicParameters(
            string path,
            string sourceProperty,
            string destinationPath,
            string destinationProperty,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,34678,35330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,34947,34979);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,34995,35084);

IDynamicPropertyCmdletProvider 
propertyProvider = this as IDynamicPropertyCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,35100,35189) || true) && (propertyProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,35100,35189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,35162,35174);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,35100,35189);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,35205,35319);

return f_1206_35212_35318(propertyProvider, path, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,34678,35330);

object
f_1206_35212_35318(System.Management.Automation.Provider.IDynamicPropertyCmdletProvider
this_param,string
sourcePath,string
sourceProperty,string
destinationPath,string
destinationProperty)
{
var return_v = this_param.MovePropertyDynamicParameters( sourcePath, sourceProperty, destinationPath, destinationProperty);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 35212, 35318);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,34678,35330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,34678,35330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IContentReader GetContentReader(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,36070,36694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,36220,36252);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,36268,36340);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,36356,36581) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,36356,36581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,36417,36566);

throw
f_1206_36444_36565(f_1206_36509_36564());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,36356,36581);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,36637,36683);

return f_1206_36644_36682(contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,36070,36694);

string
f_1206_36509_36564()
{
var return_v =                         SessionStateStrings.IContentCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 36509, 36564);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_36444_36565(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 36444, 36565);
return return_v;
}


System.Management.Automation.Provider.IContentReader
f_1206_36644_36682(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetContentReader( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 36644, 36682);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,36070,36694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,36070,36694);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetContentReaderDynamicParameters(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,37371,37844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,37530,37562);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,37578,37650);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,37666,37754) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,37666,37754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,37727,37739);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,37666,37754);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,37770,37833);

return f_1206_37777_37832(contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,37371,37844);

object
f_1206_37777_37832(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetContentReaderDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 37777, 37832);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,37371,37844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,37371,37844);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IContentWriter GetContentWriter(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,38450,39074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,38600,38632);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,38648,38720);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,38736,38961) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,38736,38961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,38797,38946);

throw
f_1206_38824_38945(f_1206_38889_38944());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,38736,38961);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,39017,39063);

return f_1206_39024_39062(contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,38450,39074);

string
f_1206_38889_38944()
{
var return_v =                         SessionStateStrings.IContentCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 38889, 38944);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_38824_38945(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 38824, 38945);
return return_v;
}


System.Management.Automation.Provider.IContentWriter
f_1206_39024_39062(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetContentWriter( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 39024, 39062);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,38450,39074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,38450,39074);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetContentWriterDynamicParameters(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,39767,40240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,39926,39958);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,39974,40046);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,40062,40150) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,40062,40150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,40123,40135);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,40062,40150);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,40166,40229);

return f_1206_40173_40228(contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,39767,40240);

object
f_1206_40173_40228(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetContentWriterDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 40173, 40228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,39767,40240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,39767,40240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearContent(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,40732,41331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,40868,40900);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,40916,40988);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,41004,41229) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,41004,41229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,41065,41214);

throw
f_1206_41092_41213(f_1206_41157_41212());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,41004,41229);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,41285,41320);

f_1206_41285_41319(
            // Call interface method

            contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,40732,41331);

string
f_1206_41157_41212()
{
var return_v =                         SessionStateStrings.IContentCmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 41157, 41212);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1206_41092_41213(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 41092, 41213);
return return_v;
}


int
f_1206_41285_41319(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
this_param.ClearContent( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 41285, 41319);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,40732,41331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,40732,41331);
}
		}

internal object ClearContentDynamicParameters(
            string path,
            CmdletProviderContext cmdletProviderContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,42010,42475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,42165,42197);

Context = cmdletProviderContext;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,42213,42285);

IContentCmdletProvider 
contentProvider = this as IContentCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,42301,42389) || true) && (contentProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,42301,42389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,42362,42374);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,42301,42389);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,42405,42464);

return f_1206_42412_42463(contentProvider, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,42010,42475);

object
f_1206_42412_42463(System.Management.Automation.Provider.IContentCmdletProvider
this_param,string
path)
{
var return_v = this_param.ClearContentDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 42412, 42463);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,42010,42475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,42010,42475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual ProviderInfo Start(ProviderInfo providerInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,43512,43734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,43600,43723);
using(f_1206_43607_43654())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,43688,43708);

return providerInfo;
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,43600,43723);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,43512,43734);

System.IDisposable
f_1206_43607_43654()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 43607, 43654);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,43512,43734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,43512,43734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual object StartDynamicParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,44321,44521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,44395,44510);
using(f_1206_44402_44449())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,44483,44495);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,44395,44510);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,44321,44521);

System.IDisposable
f_1206_44402_44449()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 44402, 44449);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,44321,44521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,44321,44521);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void Stop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,44886,45036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,44940,45025);
using(f_1206_44947_44994())            {
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,44940,45025);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,44886,45036);

System.IDisposable
f_1206_44947_44994()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 44947, 44994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,44886,45036);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,44886,45036);
}
		}

public bool Stopping
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,45213,45550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,45249,45535);
using(f_1206_45256_45303())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,45345,45468);

f_1206_45345_45467(f_1206_45390_45397()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,45492,45516);

return f_1206_45499_45515(f_1206_45499_45506());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,45249,45535);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,45213,45550);

System.IDisposable
f_1206_45256_45303()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 45256, 45303);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_45390_45397()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 45390, 45397);
return return_v;
}


int
f_1206_45345_45467(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 45345, 45467);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_45499_45506()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 45499, 45506);
return return_v;
}


bool
f_1206_45499_45515(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Stopping;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 45499, 45515);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,45168,45561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,45168,45561);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SessionState SessionState
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,45751,46133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,45787,46118);
using(f_1206_45794_45841())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,45883,46006);

f_1206_45883_46005(f_1206_45928_45935()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,46030,46099);

return f_1206_46037_46098(f_1206_46054_46097(f_1206_46054_46078(f_1206_46054_46061())));
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,45787,46118);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,45751,46133);

System.IDisposable
f_1206_45794_45841()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 45794, 45841);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_45928_45935()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 45928, 45935);
return return_v;
}


int
f_1206_45883_46005(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 45883, 46005);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_46054_46061()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46054, 46061);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_46054_46078(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46054, 46078);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1206_46054_46097(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46054, 46097);
return return_v;
}


System.Management.Automation.SessionState
f_1206_46037_46098(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.SessionState( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 46037, 46098);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,45694,46144);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,45694,46144);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ProviderIntrinsics InvokeProvider
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,46356,46744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,46392,46729);
using(f_1206_46399_46446())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,46488,46611);

f_1206_46488_46610(f_1206_46533_46540()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,46635,46710);

return f_1206_46642_46709(f_1206_46665_46708(f_1206_46665_46689(f_1206_46665_46672())));
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,46392,46729);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,46356,46744);

System.IDisposable
f_1206_46399_46446()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 46399, 46446);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_46533_46540()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46533, 46540);
return return_v;
}


int
f_1206_46488_46610(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 46488, 46610);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_46665_46672()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46665, 46672);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_46665_46689(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46665, 46689);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1206_46665_46708(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineSessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 46665, 46708);
return return_v;
}


System.Management.Automation.ProviderIntrinsics
f_1206_46642_46709(System.Management.Automation.SessionStateInternal
sessionState)
{
var return_v = new System.Management.Automation.ProviderIntrinsics( sessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 46642, 46709);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,46291,46755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,46291,46755);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CommandInvocationIntrinsics InvokeCommand
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,46975,47353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47011,47338);
using(f_1206_47018_47065())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47107,47230);

f_1206_47107_47229(f_1206_47152_47159()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47254,47319);

return f_1206_47261_47318(f_1206_47293_47317(f_1206_47293_47300()));
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,47011,47338);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,46975,47353);

System.IDisposable
f_1206_47018_47065()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 47018, 47065);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_47152_47159()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47152, 47159);
return return_v;
}


int
f_1206_47107_47229(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 47107, 47229);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_47293_47300()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47293, 47300);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_47293_47317(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47293, 47317);
return return_v;
}


System.Management.Automation.CommandInvocationIntrinsics
f_1206_47261_47318(System.Management.Automation.ExecutionContext
context)
{
var return_v = new System.Management.Automation.CommandInvocationIntrinsics( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 47261, 47318);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,46902,47364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,46902,47364);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSCredential Credential
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,47550,47889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47586,47874);
using(f_1206_47593_47640())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47682,47805);

f_1206_47682_47804(f_1206_47727_47734()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,47829,47855);

return f_1206_47836_47854(f_1206_47836_47843());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,47586,47874);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,47550,47889);

System.IDisposable
f_1206_47593_47640()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 47593, 47640);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_47727_47734()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47727, 47734);
return return_v;
}


int
f_1206_47682_47804(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 47682, 47804);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_47836_47843()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47836, 47843);
return return_v;
}


System.Management.Automation.PSCredential
f_1206_47836_47854(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Credential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 47836, 47854);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,47495,47900);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,47495,47900);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected internal ProviderInfo ProviderInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,48351,48545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,48387,48530);
using(f_1206_48394_48441())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,48483,48511);

return _providerInformation;
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,48387,48530);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,48351,48545);

System.IDisposable
f_1206_48394_48441()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 48394, 48441);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,48282,48556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,48282,48556);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected PSDriveInfo PSDriveInfo
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,48762,49096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,48798,49081);
using(f_1206_48805_48852())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,48894,49017);

f_1206_48894_49016(f_1206_48939_48946()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,49041,49062);

return f_1206_49048_49061(f_1206_49048_49055());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,48798,49081);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,48762,49096);

System.IDisposable
f_1206_48805_48852()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 48805, 48852);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_48939_48946()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 48939, 48946);
return return_v;
}


int
f_1206_48894_49016(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 48894, 49016);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_49048_49055()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 49048, 49055);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1206_49048_49061(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Drive;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 49048, 49061);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,48704,49107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,48704,49107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected object DynamicParameters
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,49333,49679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,49369,49664);
using(f_1206_49376_49423())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,49465,49588);

f_1206_49465_49587(f_1206_49510_49517()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,49612,49645);

return f_1206_49619_49644(f_1206_49619_49626());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,49369,49664);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,49333,49679);

System.IDisposable
f_1206_49376_49423()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 49376, 49423);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_49510_49517()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 49510, 49517);
return return_v;
}


int
f_1206_49465_49587(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 49465, 49587);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_49619_49626()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 49619, 49626);
return return_v;
}


object
f_1206_49619_49644(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.DynamicParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 49619, 49644);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,49274,49690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,49274,49690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SwitchParameter Force
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,50496,50830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,50532,50815);
using(f_1206_50539_50586())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,50628,50751);

f_1206_50628_50750(f_1206_50673_50680()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,50775,50796);

return f_1206_50782_50795(f_1206_50782_50789());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,50532,50815);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,50496,50830);

System.IDisposable
f_1206_50539_50586()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 50539, 50586);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_50673_50680()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 50673, 50680);
return return_v;
}


int
f_1206_50628_50750(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 50628, 50750);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_50782_50789()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 50782, 50789);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1206_50782_50795(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Force;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 50782, 50795);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,50443,50841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,50443,50841);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string Filter
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,51025,51360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51061,51345);
using(f_1206_51068_51115())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51157,51280);

f_1206_51157_51279(f_1206_51202_51209()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51304,51326);

return f_1206_51311_51325(f_1206_51311_51318());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,51061,51345);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,51025,51360);

System.IDisposable
f_1206_51068_51115()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 51068, 51115);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_51202_51209()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51202, 51209);
return return_v;
}


int
f_1206_51157_51279(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 51157, 51279);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_51311_51318()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51311, 51318);
return return_v;
}


string
f_1206_51311_51325(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Filter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51311, 51325);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,50980,51371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,50980,51371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Collection<string> Include
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,51628,51964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51664,51949);
using(f_1206_51671_51718())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51760,51883);

f_1206_51760_51882(f_1206_51805_51812()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,51907,51930);

return f_1206_51914_51929(f_1206_51914_51921());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,51664,51949);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,51628,51964);

System.IDisposable
f_1206_51671_51718()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 51671, 51718);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_51805_51812()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51805, 51812);
return return_v;
}


int
f_1206_51760_51882(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 51760, 51882);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_51914_51921()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51914, 51921);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1206_51914_51929(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Include;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 51914, 51929);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,51570,51975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,51570,51975);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Collection<string> Exclude
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,52232,52568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,52268,52553);
using(f_1206_52275_52322())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,52364,52487);

f_1206_52364_52486(f_1206_52409_52416()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,52511,52534);

return f_1206_52518_52533(f_1206_52518_52525());
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,52268,52553);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,52232,52568);

System.IDisposable
f_1206_52275_52322()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 52275, 52322);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_52409_52416()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 52409, 52416);
return return_v;
}


int
f_1206_52364_52486(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 52364, 52486);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_52518_52525()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 52518, 52525);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1206_52518_52533(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.Exclude;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 52518, 52533);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,52174,52579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,52174,52579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public PSHost Host
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,52726,53091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,52762,53076);
using(f_1206_52769_52816())                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,52858,52981);

f_1206_52858_52980(f_1206_52903_52910()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,53005,53057);

return f_1206_53012_53056(f_1206_53012_53036(f_1206_53012_53019()));
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,52762,53076);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,52726,53091);

System.IDisposable
f_1206_52769_52816()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 52769, 52816);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_52903_52910()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 52903, 52910);
return return_v;
}


int
f_1206_52858_52980(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 52858, 52980);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_53012_53019()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 53012, 53019);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_53012_53036(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 53012, 53036);
return return_v;
}


System.Management.Automation.Internal.Host.InternalHost
f_1206_53012_53056(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.EngineHostInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 53012, 53056);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,52683,53102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,52683,53102);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public virtual char ItemSeparator {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,53269,53299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,53272,53299);
return Path.DirectorySeparatorChar;DynAbs.Tracing.TraceSender.TraceExitMethod(1206,53269,53299);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,53269,53299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,53269,53299);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public virtual char AltItemSeparator {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,53472,53579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,53549,53579);
return Path.AltDirectorySeparatorChar;DynAbs.Tracing.TraceSender.TraceExitMethod(1206,53472,53579);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,53472,53579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,53472,53579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public virtual string GetResourceString(string baseName, string resourceId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,54387,55838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54487,55827);
using(f_1206_54494_54541())            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54575,54723) || true) && (f_1206_54579_54609(baseName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,54575,54723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54651,54704);

throw f_1206_54657_54703("baseName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,54575,54723);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54743,54895) || true) && (f_1206_54747_54779(resourceId))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,54743,54895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54821,54876);

throw f_1206_54827_54875("resourceId");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,54743,54895);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,54915,55088);

ResourceManager 
manager =
f_1206_54962_55087(f_1206_55028_55051(f_1206_55028_55042(                        this)), baseName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55108,55131);

string 
retValue = null
;

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55195,55338);

retValue = f_1206_55206_55337(manager, resourceId, f_1206_55287_55336());
                }
                catch (MissingManifestResourceException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1206,55375,55576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55456,55557);

throw f_1206_55462_55556("baseName", f_1206_55509_55545(), baseName);
DynAbs.Tracing.TraceSender.TraceExitCatch(1206,55375,55576);
                }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55596,55776) || true) && (retValue == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,55596,55776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55658,55757);

throw f_1206_55664_55756("resourceId", f_1206_55713_55743(), resourceId);
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,55596,55776);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,55796,55812);

return retValue;
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,54487,55827);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,54387,55838);

System.IDisposable
f_1206_54494_54541()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54494, 54541);
return return_v;
}


bool
f_1206_54579_54609(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54579, 54609);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1206_54657_54703(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54657, 54703);
return return_v;
}


bool
f_1206_54747_54779(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54747, 54779);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1206_54827_54875(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54827, 54875);
return return_v;
}


System.Type
f_1206_55028_55042(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 55028, 55042);
return return_v;
}


System.Reflection.Assembly
f_1206_55028_55051(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 55028, 55051);
return return_v;
}


System.Resources.ResourceManager
f_1206_54962_55087(System.Reflection.Assembly
assembly,string
baseName)
{
var return_v = ResourceManagerCache.GetResourceManager( assembly, baseName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 54962, 55087);
return return_v;
}


System.Globalization.CultureInfo
f_1206_55287_55336()
{
var return_v =                                                   System.Globalization.CultureInfo.CurrentUICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 55287, 55336);
return return_v;
}


string?
f_1206_55206_55337(System.Resources.ResourceManager
this_param,string
name,System.Globalization.CultureInfo
culture)
{
var return_v = this_param.GetString( name, culture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 55206, 55337);
return return_v;
}


string
f_1206_55509_55545()
{
var return_v = GetErrorText.ResourceBaseNameFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 55509, 55545);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1206_55462_55556(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 55462, 55556);
return return_v;
}


string
f_1206_55713_55743()
{
var return_v = GetErrorText.ResourceIdFailure;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 55713, 55743);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1206_55664_55756(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 55664, 55756);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,54387,55838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,54387,55838);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void ThrowTerminatingError(ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,56023,57721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56106,57710);
using(f_1206_56113_56160())            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56194,56338) || true) && (errorRecord == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,56194,56338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56259,56319);

throw f_1206_56265_56318("errorRecord");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,56194,56338);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56358,56905) || true) && (f_1206_56362_56386(errorRecord)!= null
&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 56362, 56467)&&f_1206_56419_56459(f_1206_56419_56443(errorRecord))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,56358,56905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56509,56578);

Exception 
textLookupError = f_1206_56537_56577(f_1206_56537_56561(errorRecord))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56600,56648);

f_1206_56600_56624(errorRecord).TextLookupError = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,56670,56886);

f_1206_56670_56885(f_1206_56726_56755(f_1206_56726_56738(this)), f_1206_56782_56799(f_1206_56782_56794()), textLookupError, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,56358,56905);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,57221,57359);

ProviderInvocationException 
providerInvocationException =
f_1206_57300_57358(f_1206_57332_57344(), errorRecord)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,57429,57641);

f_1206_57429_57640(f_1206_57481_57510(f_1206_57481_57493(this)), f_1206_57533_57550(f_1206_57533_57545()), providerInvocationException, Severity.Warning);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,57661,57695);

throw providerInvocationException;
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,56106,57710);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,56023,57721);

System.IDisposable
f_1206_56113_56160()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 56113, 56160);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1206_56265_56318(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 56265, 56318);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_56362_56386(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56362, 56386);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_56419_56443(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56419, 56443);
return return_v;
}


System.Exception
f_1206_56419_56459(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56419, 56459);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_56537_56561(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56537, 56561);
return return_v;
}


System.Exception
f_1206_56537_56577(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56537, 56577);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_56600_56624(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56600, 56624);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_56726_56738(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56726, 56738);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_56726_56755(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56726, 56755);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_56782_56794()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56782, 56794);
return return_v;
}


string
f_1206_56782_56799(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 56782, 56799);
return return_v;
}


int
f_1206_56670_56885(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Exception
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 56670, 56885);
return 0;
}


System.Management.Automation.ProviderInfo
f_1206_57332_57344()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 57332, 57344);
return return_v;
}


System.Management.Automation.ProviderInvocationException
f_1206_57300_57358(System.Management.Automation.ProviderInfo
provider,System.Management.Automation.ErrorRecord
errorRecord)
{
var return_v = new System.Management.Automation.ProviderInvocationException( provider, errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 57300, 57358);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_57481_57493(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 57481, 57493);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_57481_57510(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 57481, 57510);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_57533_57545()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 57533, 57545);
return return_v;
}


string
f_1206_57533_57550(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 57533, 57550);
return return_v;
}


int
f_1206_57429_57640(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Management.Automation.ProviderInvocationException
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, (System.Exception)exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 57429, 57640);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,56023,57721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,56023,57721);
}
		}

public bool ShouldProcess(
            string target)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,57907,58272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,57986,58261);
using(f_1206_57993_58040())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,58074,58189);

f_1206_58074_58188(f_1206_58115_58122()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,58209,58246);

return f_1206_58216_58245(f_1206_58216_58223(), target);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,57986,58261);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,57907,58272);

System.IDisposable
f_1206_57993_58040()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 57993, 58040);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_58115_58122()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 58115, 58122);
return return_v;
}


int
f_1206_58074_58188(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 58074, 58188);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_58216_58223()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 58216, 58223);
return return_v;
}


bool
f_1206_58216_58245(System.Management.Automation.CmdletProviderContext
this_param,string
target)
{
var return_v = this_param.ShouldProcess( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 58216, 58245);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,57907,58272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,57907,58272);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ShouldProcess(
            string target,
            string action)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,58372,58773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,58479,58762);
using(f_1206_58486_58533())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,58567,58682);

f_1206_58567_58681(f_1206_58608_58615()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,58702,58747);

return f_1206_58709_58746(f_1206_58709_58716(), target, action);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,58479,58762);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,58372,58773);

System.IDisposable
f_1206_58486_58533()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 58486, 58533);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_58608_58615()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 58608, 58615);
return return_v;
}


int
f_1206_58567_58681(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 58567, 58681);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_58709_58716()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 58709, 58716);
return return_v;
}


bool
f_1206_58709_58746(System.Management.Automation.CmdletProviderContext
this_param,string
target,string
action)
{
var return_v = this_param.ShouldProcess( target, action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 58709, 58746);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,58372,58773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,58372,58773);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ShouldProcess(
            string verboseDescription,
            string verboseWarning,
            string caption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,58873,59416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59029,59405);
using(f_1206_59036_59083())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59117,59232);

f_1206_59117_59231(f_1206_59158_59165()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59252,59390);

return f_1206_59259_59389(f_1206_59259_59266(), verboseDescription, verboseWarning, caption);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,59029,59405);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,58873,59416);

System.IDisposable
f_1206_59036_59083()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59036, 59083);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_59158_59165()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 59158, 59165);
return return_v;
}


int
f_1206_59117_59231(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59117, 59231);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_59259_59266()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 59259, 59266);
return return_v;
}


bool
f_1206_59259_59389(System.Management.Automation.CmdletProviderContext
this_param,string
verboseDescription,string
verboseWarning,string
caption)
{
var return_v = this_param.ShouldProcess( verboseDescription, verboseWarning, caption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59259, 59389);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,58873,59416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,58873,59416);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ShouldProcess(
            string verboseDescription,
            string verboseWarning,
            string caption,
            out ShouldProcessReason shouldProcessReason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,59516,60163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59730,60152);
using(f_1206_59737_59784())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59818,59933);

f_1206_59818_59932(f_1206_59859_59866()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,59953,60137);

return f_1206_59960_60136(f_1206_59960_59967(), verboseDescription, verboseWarning, caption, out shouldProcessReason);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,59730,60152);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,59516,60163);

System.IDisposable
f_1206_59737_59784()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59737, 59784);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_59859_59866()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 59859, 59866);
return return_v;
}


int
f_1206_59818_59932(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59818, 59932);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_59960_59967()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 59960, 59967);
return return_v;
}


bool
f_1206_59960_60136(System.Management.Automation.CmdletProviderContext
this_param,string
verboseDescription,string
verboseWarning,string
caption,out System.Management.Automation.ShouldProcessReason
shouldProcessReason)
{
var return_v = this_param.ShouldProcess( verboseDescription, verboseWarning, caption, out shouldProcessReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 59960, 60136);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,59516,60163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,59516,60163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ShouldContinue(
            string query,
            string caption)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,60264,60667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,60372,60656);
using(f_1206_60379_60426())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,60460,60575);

f_1206_60460_60574(f_1206_60501_60508()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,60595,60641);

return f_1206_60602_60640(f_1206_60602_60609(), query, caption);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,60372,60656);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,60264,60667);

System.IDisposable
f_1206_60379_60426()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 60379, 60426);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_60501_60508()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 60501, 60508);
return return_v;
}


int
f_1206_60460_60574(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 60460, 60574);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_60602_60609()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 60602, 60609);
return return_v;
}


bool
f_1206_60602_60640(System.Management.Automation.CmdletProviderContext
this_param,string
query,string
caption)
{
var return_v = this_param.ShouldContinue( query, caption);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 60602, 60640);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,60264,60667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,60264,60667);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ShouldContinue(
            string query,
            string caption,
            ref bool yesToAll,
            ref bool noToAll)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,60768,61283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,60939,61272);
using(f_1206_60946_60993())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61027,61142);

f_1206_61027_61141(f_1206_61068_61075()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61162,61257);

return f_1206_61169_61256(f_1206_61169_61176(), query, caption, ref yesToAll, ref noToAll);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,60939,61272);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,60768,61283);

System.IDisposable
f_1206_60946_60993()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 60946, 60993);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_61068_61075()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 61068, 61075);
return return_v;
}


int
f_1206_61027_61141(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 61027, 61141);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_61169_61176()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 61169, 61176);
return return_v;
}


bool
f_1206_61169_61256(System.Management.Automation.CmdletProviderContext
this_param,string
query,string
caption,ref bool
yesToAll,ref bool
noToAll)
{
var return_v = this_param.ShouldContinue( query, caption, ref yesToAll, ref noToAll);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 61169, 61256);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,60768,61283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,60768,61283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool TransactionAvailable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,61449,61759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61508,61748);
using(f_1206_61515_61562())            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61596,61733) || true) && (f_1206_61600_61607()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,61596,61733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61638,61651);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,61596,61733);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,61596,61733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,61695,61733);

return f_1206_61702_61732(f_1206_61702_61709());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,61596,61733);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,61508,61748);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,61449,61759);

System.IDisposable
f_1206_61515_61562()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 61515, 61562);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_61600_61607()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 61600, 61607);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_61702_61709()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 61702, 61709);
return return_v;
}


bool
f_1206_61702_61732(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 61702, 61732);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,61449,61759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,61449,61759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PSTransactionContext CurrentPSTransaction
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,62054,62239);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62090,62224) || true) && (f_1206_62094_62101()== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,62090,62224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62132,62144);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,62090,62224);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,62090,62224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62188,62224);

return f_1206_62195_62223(f_1206_62195_62202());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,62090,62224);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,62054,62239);

System.Management.Automation.CmdletProviderContext
f_1206_62094_62101()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 62094, 62101);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_62195_62202()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 62195, 62202);
return return_v;
}


System.Management.Automation.PSTransactionContext
f_1206_62195_62223(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.CurrentPSTransaction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 62195, 62223);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,61981,62250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,61981,62250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public void WriteVerbose(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,62389,62727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62451,62716);
using(f_1206_62458_62505())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62539,62654);

f_1206_62539_62653(f_1206_62580_62587()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62674,62701);

f_1206_62674_62700(f_1206_62674_62681(), text);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,62451,62716);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,62389,62727);

System.IDisposable
f_1206_62458_62505()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 62458, 62505);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_62580_62587()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 62580, 62587);
return return_v;
}


int
f_1206_62539_62653(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 62539, 62653);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_62674_62681()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 62674, 62681);
return return_v;
}


int
f_1206_62674_62700(System.Management.Automation.CmdletProviderContext
this_param,string
text)
{
this_param.WriteVerbose( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 62674, 62700);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,62389,62727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,62389,62727);
}
		}

public void WriteWarning(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,62826,63164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62888,63153);
using(f_1206_62895_62942())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,62976,63091);

f_1206_62976_63090(f_1206_63017_63024()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63111,63138);

f_1206_63111_63137(f_1206_63111_63118(), text);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,62888,63153);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,62826,63164);

System.IDisposable
f_1206_62895_62942()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 62895, 62942);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_63017_63024()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 63017, 63024);
return return_v;
}


int
f_1206_62976_63090(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 62976, 63090);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_63111_63118()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 63111, 63118);
return return_v;
}


int
f_1206_63111_63137(System.Management.Automation.CmdletProviderContext
this_param,string
text)
{
this_param.WriteWarning( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63111, 63137);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,62826,63164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,62826,63164);
}
		}

public void WriteProgress(ProgressRecord progressRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,63264,63802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63345,63791);
using(f_1206_63352_63399())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63433,63548);

f_1206_63433_63547(f_1206_63474_63481()!= null, "The context should always be set");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63568,63718) || true) && (progressRecord == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,63568,63718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63636,63699);

throw f_1206_63642_63698("progressRecord");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,63568,63718);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63738,63776);

f_1206_63738_63775(f_1206_63738_63745(), progressRecord);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,63345,63791);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,63264,63802);

System.IDisposable
f_1206_63352_63399()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63352, 63399);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_63474_63481()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 63474, 63481);
return return_v;
}


int
f_1206_63433_63547(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63433, 63547);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1206_63642_63698(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63642, 63698);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_63738_63745()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 63738, 63745);
return return_v;
}


int
f_1206_63738_63775(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ProgressRecord
record)
{
this_param.WriteProgress( record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63738, 63775);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,63264,63802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,63264,63802);
}
		}

public void WriteDebug(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,63899,64233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,63959,64222);
using(f_1206_63966_64013())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64047,64162);

f_1206_64047_64161(f_1206_64088_64095()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64182,64207);

f_1206_64182_64206(f_1206_64182_64189(), text);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,63959,64222);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,63899,64233);

System.IDisposable
f_1206_63966_64013()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 63966, 64013);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_64088_64095()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 64088, 64095);
return return_v;
}


int
f_1206_64047_64161(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64047, 64161);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_64182_64189()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 64182, 64189);
return return_v;
}


int
f_1206_64182_64206(System.Management.Automation.CmdletProviderContext
this_param,string
text)
{
this_param.WriteDebug( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64182, 64206);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,63899,64233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,63899,64233);
}
		}

public void WriteInformation(InformationRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,64336,64697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64415,64686);
using(f_1206_64422_64469())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64503,64618);

f_1206_64503_64617(f_1206_64544_64551()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64638,64671);

f_1206_64638_64670(f_1206_64638_64645(), record);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,64415,64686);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,64336,64697);

System.IDisposable
f_1206_64422_64469()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64422, 64469);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_64544_64551()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 64544, 64551);
return return_v;
}


int
f_1206_64503_64617(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64503, 64617);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_64638_64645()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 64638, 64645);
return return_v;
}


int
f_1206_64638_64670(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.InformationRecord
record)
{
this_param.WriteInformation( record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64638, 64670);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,64336,64697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,64336,64697);
}
		}

public void WriteInformation(object messageData, string[] tags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,64800,65181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64888,65170);
using(f_1206_64895_64942())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,64976,65091);

f_1206_64976_65090(f_1206_65017_65024()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,65111,65155);

f_1206_65111_65154(f_1206_65111_65118(), messageData, tags);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,64888,65170);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,64800,65181);

System.IDisposable
f_1206_64895_64942()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64895, 64942);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_65017_65024()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 65017, 65024);
return return_v;
}


int
f_1206_64976_65090(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 64976, 65090);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_65111_65118()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 65111, 65118);
return return_v;
}


int
f_1206_65111_65154(System.Management.Automation.CmdletProviderContext
this_param,object
messageData,string[]
tags)
{
this_param.WriteInformation( messageData, tags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 65111, 65154);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,64800,65181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,64800,65181);
}
		}

private void WriteObject(
            object item,
            string path,
            bool isContainer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,65721,66318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,65854,65905);

PSObject 
result = f_1206_65872_65904(this, item, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,65963,66044);

f_1206_65963_66043(
            // Now add the IsContainer

            result, "PSIsContainer", (DynAbs.Tracing.TraceSender.Conditional_F1(1206, 66004, 66015)||((isContainer &&DynAbs.Tracing.TraceSender.Conditional_F2(1206, 66018, 66028))||DynAbs.Tracing.TraceSender.Conditional_F3(1206, 66031, 66042)))?Boxed.True :Boxed.False);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,66058,66140);

f_1206_66058_66139(            providerBaseTracer, "Attaching {0} = {1}", "PSIsContainer", isContainer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,66156,66263);

f_1206_66156_66262(f_1206_66193_66200()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,66279,66307);

f_1206_66279_66306(f_1206_66279_66286(), result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,65721,66318);

System.Management.Automation.PSObject
f_1206_65872_65904(System.Management.Automation.Provider.CmdletProvider
this_param,object
item,string
path)
{
var return_v = this_param.WrapOutputInPSObject( item, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 65872, 65904);
return return_v;
}


int
f_1206_65963_66043(System.Management.Automation.PSObject
this_param,string
memberName,object
value)
{
this_param.AddOrSetProperty( memberName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 65963, 66043);
return 0;
}


int
f_1206_66058_66139(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,bool
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 66058, 66139);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_66193_66200()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 66193, 66200);
return return_v;
}


int
f_1206_66156_66262(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 66156, 66262);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_66279_66286()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 66279, 66286);
return return_v;
}


int
f_1206_66279_66306(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.PSObject
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 66279, 66306);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,65721,66318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,65721,66318);
}
		}

private void WriteObject(
            object item,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,66733,67064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,66835,66886);

PSObject 
result = f_1206_66853_66885(this, item, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,66902,67009);

f_1206_66902_67008(f_1206_66939_66946()!= null, "The context should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,67025,67053);

f_1206_67025_67052(f_1206_67025_67032(), result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,66733,67064);

System.Management.Automation.PSObject
f_1206_66853_66885(System.Management.Automation.Provider.CmdletProvider
this_param,object
item,string
path)
{
var return_v = this_param.WrapOutputInPSObject( item, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 66853, 66885);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_66939_66946()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 66939, 66946);
return return_v;
}


int
f_1206_66902_67008(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 66902, 67008);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_67025_67032()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 67025, 67032);
return return_v;
}


int
f_1206_67025_67052(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.PSObject
obj)
{
this_param.WriteObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 67025, 67052);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,66733,67064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,66733,67064);
}
		}

private PSObject WrapOutputInPSObject(
            object item,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,67708,71888);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,67823,67941) || true) && (item == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,67823,67941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,67873,67926);

throw f_1206_67879_67925("item");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,67823,67941);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,67957,67994);

PSObject 
result = f_1206_67975_67993(item)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68010,68127);

f_1206_68010_68126(f_1206_68047_68059()!= null, "The ProviderInfo should always be set");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68257,68292);

PSObject 
mshObj = item as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68306,68449) || true) && (mshObj != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,68306,68449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68358,68434);

result.InternalTypeNames = f_1206_68385_68433(f_1206_68408_68432(mshObj));
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,68306,68449);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68536,68645);

string 
providerQualifiedPath =
f_1206_68584_68644(path, f_1206_68631_68643())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68661,68718);

f_1206_68661_68717(
            result, "PSPath", providerQualifiedPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68732,68817);

f_1206_68732_68816(            providerBaseTracer, "Attaching {0} = {1}", "PSPath", providerQualifiedPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68890,68962);

NavigationCmdletProvider 
navProvider = this as NavigationCmdletProvider
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,68976,71306) || true) && (navProvider != null &&(DynAbs.Tracing.TraceSender.Expression_True(1206, 68980, 69015)&&path != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,68976,71306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69091,69116);

string 
parentPath = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69136,69442) || true) && (f_1206_69140_69151()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,69136,69442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69201,69273);

parentPath = f_1206_69214_69272(navProvider, path, f_1206_69246_69262(f_1206_69246_69257()), f_1206_69264_69271());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,69136,69442);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,69136,69442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69355,69423);

parentPath = f_1206_69368_69422(navProvider, path, string.Empty, f_1206_69414_69421());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,69136,69442);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69462,69512);

string 
providerQualifiedParentPath = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69532,69752) || true) && (!f_1206_69537_69569(parentPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,69532,69752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69611,69733);

providerQualifiedParentPath =
f_1206_69666_69732(parentPath, f_1206_69719_69731());
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,69532,69752);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69772,69841);

f_1206_69772_69840(
                result, "PSParentPath", providerQualifiedParentPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,69859,69956);

f_1206_69859_69955(                providerBaseTracer, "Attaching {0} = {1}", "PSParentPath", providerQualifiedParentPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,70017,70076);

string 
childName = f_1206_70036_70075(navProvider, path, f_1206_70067_70074())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,70096,70146);

f_1206_70096_70145(
                result, "PSChildName", childName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,70164,70242);

f_1206_70164_70241(                providerBaseTracer, "Attaching {0} = {1}", "PSChildName", childName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,68976,71306);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71352,71610) || true) && (f_1206_71356_71367()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,71352,71610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71409,71496);

f_1206_71409_71495(                result, f_1206_71433_71494(f_1206_71433_71449(this), "PSDrive"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71514,71595);

f_1206_71514_71594(                providerBaseTracer, "Attaching {0} = {1}", "PSDrive", f_1206_71577_71593(this));
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,71352,71610);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71657,71748);

f_1206_71657_71747(
            // ProviderInfo

            result, f_1206_71681_71746(f_1206_71681_71698(this), "PSProvider"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71762,71847);

f_1206_71762_71846(            providerBaseTracer, "Attaching {0} = {1}", "PSProvider", f_1206_71828_71845(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,71863,71877);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,67708,71888);

System.Management.Automation.PSArgumentNullException
f_1206_67879_67925(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 67879, 67925);
return return_v;
}


System.Management.Automation.PSObject
f_1206_67975_67993(object
obj)
{
var return_v = new System.Management.Automation.PSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 67975, 67993);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_68047_68059()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 68047, 68059);
return return_v;
}


int
f_1206_68010_68126(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 68010, 68126);
return 0;
}


System.Management.Automation.Runspaces.ConsolidatedString
f_1206_68408_68432(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.InternalTypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 68408, 68432);
return return_v;
}


System.Management.Automation.Runspaces.ConsolidatedString
f_1206_68385_68433(System.Management.Automation.Runspaces.ConsolidatedString
other)
{
var return_v = new System.Management.Automation.Runspaces.ConsolidatedString( other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 68385, 68433);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_68631_68643()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 68631, 68643);
return return_v;
}


string
f_1206_68584_68644(string
path,System.Management.Automation.ProviderInfo
provider)
{
var return_v = LocationGlobber.GetProviderQualifiedPath( path, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 68584, 68644);
return return_v;
}


int
f_1206_68661_68717(System.Management.Automation.PSObject
this_param,string
memberName,string
value)
{
this_param.AddOrSetProperty( memberName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 68661, 68717);
return 0;
}


int
f_1206_68732_68816(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,string
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 68732, 68816);
return 0;
}


System.Management.Automation.PSDriveInfo
f_1206_69140_69151()
{
var return_v = PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69140, 69151);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1206_69246_69257()
{
var return_v = PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69246, 69257);
return return_v;
}


string
f_1206_69246_69262(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69246, 69262);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_69264_69271()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69264, 69271);
return return_v;
}


string
f_1206_69214_69272(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetParentPath( path, root, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69214, 69272);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_69414_69421()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69414, 69421);
return return_v;
}


string
f_1206_69368_69422(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetParentPath( path, root, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69368, 69422);
return return_v;
}


bool
f_1206_69537_69569(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69537, 69569);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_69719_69731()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 69719, 69731);
return return_v;
}


string
f_1206_69666_69732(string
path,System.Management.Automation.ProviderInfo
provider)
{
var return_v = LocationGlobber.GetProviderQualifiedPath( path, provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69666, 69732);
return return_v;
}


int
f_1206_69772_69840(System.Management.Automation.PSObject
this_param,string
memberName,string
value)
{
this_param.AddOrSetProperty( memberName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69772, 69840);
return 0;
}


int
f_1206_69859_69955(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,string
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 69859, 69955);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_70067_70074()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 70067, 70074);
return return_v;
}


string
f_1206_70036_70075(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.GetChildName( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 70036, 70075);
return return_v;
}


int
f_1206_70096_70145(System.Management.Automation.PSObject
this_param,string
memberName,string
value)
{
this_param.AddOrSetProperty( memberName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 70096, 70145);
return 0;
}


int
f_1206_70164_70241(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,string
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 70164, 70241);
return 0;
}


System.Management.Automation.PSDriveInfo
f_1206_71356_71367()
{
var return_v = PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 71356, 71367);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1206_71433_71449(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 71433, 71449);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1206_71433_71494(System.Management.Automation.PSDriveInfo
this_param,string
name)
{
var return_v = this_param.GetNotePropertyForProviderCmdlets( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71433, 71494);
return return_v;
}


int
f_1206_71409_71495(System.Management.Automation.PSObject
this_param,System.Management.Automation.PSNoteProperty
property)
{
this_param.AddOrSetProperty( property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71409, 71495);
return 0;
}


System.Management.Automation.PSDriveInfo
f_1206_71577_71593(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 71577, 71593);
return return_v;
}


int
f_1206_71514_71594(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,System.Management.Automation.PSDriveInfo
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71514, 71594);
return 0;
}


System.Management.Automation.ProviderInfo
f_1206_71681_71698(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 71681, 71698);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1206_71681_71746(System.Management.Automation.ProviderInfo
this_param,string
name)
{
var return_v = this_param.GetNotePropertyForProviderCmdlets( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71681, 71746);
return return_v;
}


int
f_1206_71657_71747(System.Management.Automation.PSObject
this_param,System.Management.Automation.PSNoteProperty
property)
{
this_param.AddOrSetProperty( property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71657, 71747);
return 0;
}


System.Management.Automation.ProviderInfo
f_1206_71828_71845(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 71828, 71845);
return return_v;
}


int
f_1206_71762_71846(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1,System.Management.Automation.ProviderInfo
arg2)
{
this_param.WriteLine( format, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 71762, 71846);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,67708,71888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,67708,71888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void WriteItemObject(
            object item,
            string path,
            bool isContainer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,72937,73224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,73073,73213);
using(f_1206_73080_73127())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,73161,73198);

f_1206_73161_73197(this, item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,73073,73213);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,72937,73224);

System.IDisposable
f_1206_73080_73127()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 73080, 73127);
return return_v;
}


int
f_1206_73161_73197(System.Management.Automation.Provider.CmdletProvider
this_param,object
item,string
path,bool
isContainer)
{
this_param.WriteObject( item, path, isContainer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 73161, 73197);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,72937,73224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,72937,73224);
}
		}

public void WritePropertyObject(
            object propertyValue,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,74173,74438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,74291,74427);
using(f_1206_74298_74345())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,74379,74412);

f_1206_74379_74411(this, propertyValue, path);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,74291,74427);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,74173,74438);

System.IDisposable
f_1206_74298_74345()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 74298, 74345);
return return_v;
}


int
f_1206_74379_74411(System.Management.Automation.Provider.CmdletProvider
this_param,object
item,string
path)
{
this_param.WriteObject( item, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 74379, 74411);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,74173,74438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,74173,74438);
}
		}

public void WriteSecurityDescriptorObject(
            ObjectSecurity securityDescriptor,
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,75447,75740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,75588,75729);
using(f_1206_75595_75642())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,75676,75714);

f_1206_75676_75713(this, securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,75588,75729);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,75447,75740);

System.IDisposable
f_1206_75595_75642()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 75595, 75642);
return return_v;
}


int
f_1206_75676_75713(System.Management.Automation.Provider.CmdletProvider
this_param,System.Security.AccessControl.ObjectSecurity
item,string
path)
{
this_param.WriteObject( (object)item, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 75676, 75713);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,75447,75740);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,75447,75740);
}
		}

public void WriteError(ErrorRecord errorRecord)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1206,75837,76785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,75909,76774);
using(f_1206_75916_75963())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,75997,76112);

f_1206_75997_76111(f_1206_76038_76045()!= null, "The context should always be set");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,76132,76276) || true) && (errorRecord == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,76132,76276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,76197,76257);

throw f_1206_76203_76256("errorRecord");
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,76132,76276);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,76296,76707) || true) && (f_1206_76300_76324(errorRecord)!= null
&&(DynAbs.Tracing.TraceSender.Expression_True(1206, 76300, 76405)&&f_1206_76357_76397(f_1206_76357_76381(errorRecord))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1206,76296,76707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,76447,76688);

f_1206_76447_76687(f_1206_76503_76532(f_1206_76503_76515(this)), f_1206_76559_76576(f_1206_76559_76571()), f_1206_76603_76643(f_1206_76603_76627(errorRecord)), Severity.Warning);
DynAbs.Tracing.TraceSender.TraceExitCondition(1206,76296,76707);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,76727,76759);

f_1206_76727_76758(f_1206_76727_76734(), errorRecord);
DynAbs.Tracing.TraceSender.TraceExitUsing(1206,75909,76774);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1206,75837,76785);

System.IDisposable
f_1206_75916_75963()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 75916, 75963);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_76038_76045()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76038, 76045);
return return_v;
}


int
f_1206_75997_76111(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 75997, 76111);
return 0;
}


System.Management.Automation.PSArgumentNullException
f_1206_76203_76256(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 76203, 76256);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_76300_76324(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76300, 76324);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_76357_76381(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76357, 76381);
return return_v;
}


System.Exception
f_1206_76357_76397(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76357, 76397);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1206_76503_76515(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76503, 76515);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1206_76503_76532(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76503, 76532);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1206_76559_76571()
{
var return_v = ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76559, 76571);
return return_v;
}


string
f_1206_76559_76576(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76559, 76576);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1206_76603_76627(System.Management.Automation.ErrorRecord
this_param)
{
var return_v = this_param.ErrorDetails;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76603, 76627);
return return_v;
}


System.Exception
f_1206_76603_76643(System.Management.Automation.ErrorDetails
this_param)
{
var return_v = this_param.TextLookupError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76603, 76643);
return return_v;
}


int
f_1206_76447_76687(System.Management.Automation.ExecutionContext
executionContext,string
providerName,System.Exception
exception,System.Management.Automation.Severity
severity)
{
MshLog.LogProviderHealthEvent( executionContext, providerName, exception, severity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 76447, 76687);
return 0;
}


System.Management.Automation.CmdletProviderContext
f_1206_76727_76734()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1206, 76727, 76734);
return return_v;
}


int
f_1206_76727_76758(System.Management.Automation.CmdletProviderContext
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 76727, 76758);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1206,75837,76785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,75837,76785);
}
		}

public CmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1206,2124,76879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,2476,2495);
this._contextBase = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,2661,2688);
this._providerInformation = null;DynAbs.Tracing.TraceSender.TraceExitConstructor(1206,2124,76879);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,2124,76879);
}


static CmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1206,2124,76879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1206,3147,3391);
providerBaseTracer = f_1206_3168_3391("CmdletProviderClasses", "The namespace provider base classes tracer");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1206,2124,76879);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1206,2124,76879);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1206,2124,76879);

static System.Management.Automation.PSTraceSource
f_1206_3168_3391(string
name,string
description)
{
var return_v = PSTraceSource.GetTracer( name, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1206, 3168, 3391);
return return_v;
}

}

    }

#pragma warning restore 56506

