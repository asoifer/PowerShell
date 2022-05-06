// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Provider;
using System.Security.AccessControl;
using Microsoft.PowerShell.Commands.Internal;

namespace Microsoft.PowerShell.Commands
{
public sealed partial class RegistryProvider :
        NavigationCmdletProvider,
        IPropertyCmdletProvider,
        IDynamicPropertyCmdletProvider,
        ISecurityDescriptorCmdletProvider
{
public void GetSecurityDescriptor(string path,
                                          AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1210,1714,2877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,1860,1885);

ObjectSecurity 
sd = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,1899,1927);

IRegistryWrapper 
key = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,1981,2113) || true) && (f_1210_1985_2011(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,1981,2113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2045,2098);

throw f_1210_2051_2097("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,1981,2113);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2129,2279) || true) && ((sections & ~AccessControlSections.All) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,2129,2279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2211,2264);

throw f_1210_2217_2263("sections");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,2129,2279);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2295,2322);

path = f_1210_2302_2321(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2338,2386);

key = f_1210_2344_2385(this, path, false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2402,2866) || true) && (key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,2402,2866);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2495,2531);

sd = f_1210_2500_2530(key, sections);
                }
                catch (System.Security.SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1210,2568,2791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2652,2743);

f_1210_2652_2742(this, f_1210_2663_2741(e, f_1210_2682_2702(f_1210_2682_2693(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2765,2772);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1210,2568,2791);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,2811,2851);

f_1210_2811_2850(this, sd, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,2402,2866);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1210,1714,2877);

bool
f_1210_1985_2011(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 1985, 2011);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1210_2051_2097(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2051, 2097);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1210_2217_2263(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2217, 2263);
return return_v;
}


string
f_1210_2302_2321(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2302, 2321);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1210_2344_2385(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2344, 2385);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1210_2500_2530(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,System.Security.AccessControl.AccessControlSections
includeSections)
{
var return_v = this_param.GetAccessControl( includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2500, 2530);
return return_v;
}


System.Type
f_1210_2682_2693(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2682, 2693);
return return_v;
}


string
f_1210_2682_2702(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1210, 2682, 2702);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1210_2663_2741(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2663, 2741);
return return_v;
}


int
f_1210_2652_2742(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2652, 2742);
return 0;
}


int
f_1210_2811_2850(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Security.AccessControl.ObjectSecurity
securityDescriptor,string
path)
{
this_param.WriteSecurityDescriptorObject( securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 2811, 2850);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1210,1714,2877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1210,1714,2877);
}
		}

public void SetSecurityDescriptor(
            string path,
            ObjectSecurity securityDescriptor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1210,3276,5474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3409,3437);

IRegistryWrapper 
key = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3453,3581) || true) && (f_1210_3457_3483(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,3453,3581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3517,3566);

throw f_1210_3523_3565("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,3453,3581);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3597,3743) || true) && (securityDescriptor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,3597,3743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3661,3728);

throw f_1210_3667_3727("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,3597,3743);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3759,3786);

path = f_1210_3766_3785(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3802,3820);

ObjectSecurity 
sd
=default(ObjectSecurity);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3834,4389) || true) && (f_1210_3838_3860(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,3834,4389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3894,3948);

sd = securityDescriptor as TransactedRegistrySecurity;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,3968,4106) || true) && (sd == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,3968,4106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4024,4087);

throw f_1210_4030_4086("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,3968,4106);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,3834,4389);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,3834,4389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4172,4216);

sd = securityDescriptor as RegistrySecurity;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4236,4374) || true) && (sd == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,4236,4374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4292,4355);

throw f_1210_4298_4354("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,4236,4374);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,3834,4389);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4405,4452);

key = f_1210_4411_4451(this, path, true);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4468,5463) || true) && (key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,4468,5463);
                //
                // the caller already checks for the following exceptions:
                // -- UnauthorizedAccessException
                // -- PrivilegeNotHeldException
                // -- NotSupportedException
                // -- SystemException
                //
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,4861,4886);

f_1210_4861_4885(                    key, sd);
                }
                catch (System.Security.SecurityException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1210,4923,5146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,5007,5098);

f_1210_5007_5097(this, f_1210_5018_5096(e, f_1210_5037_5057(f_1210_5037_5048(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,5120,5127);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1210,4923,5146);
                }
                catch (System.UnauthorizedAccessException e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1210,5164,5388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,5249,5340);

f_1210_5249_5339(this, f_1210_5260_5338(e, f_1210_5279_5299(f_1210_5279_5290(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,5362,5369);

return;
DynAbs.Tracing.TraceSender.TraceExitCatch(1210,5164,5388);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,5408,5448);

f_1210_5408_5447(this, sd, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,4468,5463);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1210,3276,5474);

bool
f_1210_3457_3483(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 3457, 3483);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1210_3523_3565(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 3523, 3565);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1210_3667_3727(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 3667, 3727);
return return_v;
}


string
f_1210_3766_3785(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 3766, 3785);
return return_v;
}


bool
f_1210_3838_3860(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 3838, 3860);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1210_4030_4086(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 4030, 4086);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1210_4298_4354(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 4298, 4354);
return return_v;
}


Microsoft.PowerShell.Commands.IRegistryWrapper
f_1210_4411_4451(Microsoft.PowerShell.Commands.RegistryProvider
this_param,string
path,bool
writeAccess)
{
var return_v = this_param.GetRegkeyForPathWriteIfError( path, writeAccess);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 4411, 4451);
return return_v;
}


int
f_1210_4861_4885(Microsoft.PowerShell.Commands.IRegistryWrapper
this_param,System.Security.AccessControl.ObjectSecurity
securityDescriptor)
{
this_param.SetAccessControl( securityDescriptor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 4861, 4885);
return 0;
}


System.Type
f_1210_5037_5048(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5037, 5048);
return return_v;
}


string
f_1210_5037_5057(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1210, 5037, 5057);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1210_5018_5096(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5018, 5096);
return return_v;
}


int
f_1210_5007_5097(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5007, 5097);
return 0;
}


System.Type
f_1210_5279_5290(System.UnauthorizedAccessException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5279, 5290);
return return_v;
}


string
f_1210_5279_5299(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1210, 5279, 5299);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1210_5260_5338(System.UnauthorizedAccessException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5260, 5338);
return return_v;
}


int
f_1210_5249_5339(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5249, 5339);
return 0;
}


int
f_1210_5408_5447(Microsoft.PowerShell.Commands.RegistryProvider
this_param,System.Security.AccessControl.ObjectSecurity
securityDescriptor,string
path)
{
this_param.WriteSecurityDescriptorObject( securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 5408, 5447);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1210,3276,5474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1210,3276,5474);
}
		}

public ObjectSecurity NewSecurityDescriptorFromPath(
            string path,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1210,6134,6518);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,6282,6507) || true) && (f_1210_6286_6308(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,6282,6507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,6342,6382);

return f_1210_6349_6381();
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,6282,6507);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,6282,6507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,6448,6478);

return f_1210_6455_6477();
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,6282,6507);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1210,6134,6518);

bool
f_1210_6286_6308(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 6286, 6308);
return return_v;
}


Microsoft.PowerShell.Commands.Internal.TransactedRegistrySecurity
f_1210_6349_6381()
{
var return_v = new Microsoft.PowerShell.Commands.Internal.TransactedRegistrySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 6349, 6381);
return return_v;
}


System.Security.AccessControl.RegistrySecurity
f_1210_6455_6477()
{
var return_v = new System.Security.AccessControl.RegistrySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 6455, 6477);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1210,6134,6518);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1210,6134,6518);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ObjectSecurity NewSecurityDescriptorOfType(
            string type,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1210,7028,7410);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,7174,7399) || true) && (f_1210_7178_7200(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,7174,7399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,7234,7274);

return f_1210_7241_7273();
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,7174,7399);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1210,7174,7399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1210,7340,7370);

return f_1210_7347_7369();
DynAbs.Tracing.TraceSender.TraceExitCondition(1210,7174,7399);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1210,7028,7410);

bool
f_1210_7178_7200(Microsoft.PowerShell.Commands.RegistryProvider
this_param)
{
var return_v = this_param.TransactionAvailable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 7178, 7200);
return return_v;
}


Microsoft.PowerShell.Commands.Internal.TransactedRegistrySecurity
f_1210_7241_7273()
{
var return_v = new Microsoft.PowerShell.Commands.Internal.TransactedRegistrySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 7241, 7273);
return return_v;
}


System.Security.AccessControl.RegistrySecurity
f_1210_7347_7369()
{
var return_v = new System.Security.AccessControl.RegistrySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1210, 7347, 7369);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1210,7028,7410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1210,7028,7410);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
