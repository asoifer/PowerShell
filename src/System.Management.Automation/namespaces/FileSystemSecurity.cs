// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Security.AccessControl;

namespace Microsoft.PowerShell.Commands
{
public sealed partial class FileSystemProvider : NavigationCmdletProvider, IContentCmdletProvider, IPropertyCmdletProvider, ISecurityDescriptorCmdletProvider
{
public void GetSecurityDescriptor(string path,
                                          AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1194,1619,3065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,1765,1790);

ObjectSecurity 
sd = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,1804,1831);

path = f_1194_1811_1830(path);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,1847,1979) || true) && (f_1194_1851_1877(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,1847,1979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,1911,1964);

throw f_1194_1917_1963("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,1847,1979);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,1995,2145) || true) && ((sections & ~AccessControlSections.All) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,1995,2145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2077,2130);

throw f_1194_2083_2129("sections");
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,1995,2145);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2161,2227);

var 
currentPrivilegeState = f_1194_2189_2226()
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2277,2362);

f_1194_2277_2361("SeBackupPrivilege", ref currentPrivilegeState);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2382,2632) || true) && (f_1194_2386_2408(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,2382,2632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2450,2493);

sd = f_1194_2455_2492(path, sections);
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,2382,2632);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,2382,2632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2575,2613);

sd = f_1194_2580_2612(path, sections);
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,2382,2632);
}
            }
            catch (System.Security.SecurityException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1194,2661,2843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2737,2828);

f_1194_2737_2827(this, f_1194_2748_2826(e, f_1194_2767_2787(f_1194_2767_2778(e)), ErrorCategory.PermissionDenied, path));
DynAbs.Tracing.TraceSender.TraceExitCatch(1194,2661,2843);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1194,2857,2998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,2897,2983);

f_1194_2897_2982("SeBackupPrivilege", ref currentPrivilegeState);
DynAbs.Tracing.TraceSender.TraceExitFinally(1194,2857,2998);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,3014,3054);

f_1194_3014_3053(this, sd, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1194,1619,3065);

string
f_1194_1811_1830(string
path)
{
var return_v = NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 1811, 1830);
return return_v;
}


bool
f_1194_1851_1877(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 1851, 1877);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1194_1917_1963(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 1917, 1963);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1194_2083_2129(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2083, 2129);
return return_v;
}


System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
f_1194_2189_2226()
{
var return_v = new System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2189, 2226);
return return_v;
}


bool
f_1194_2277_2361(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
oldPrivilegeState)
{
var return_v = PlatformInvokes.EnableTokenPrivilege( privilegeName, ref oldPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2277, 2361);
return return_v;
}


bool
f_1194_2386_2408(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2386, 2408);
return return_v;
}


System.Security.AccessControl.DirectorySecurity
f_1194_2455_2492(string
name,System.Security.AccessControl.AccessControlSections
includeSections)
{
var return_v = new System.Security.AccessControl.DirectorySecurity( name, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2455, 2492);
return return_v;
}


System.Security.AccessControl.FileSecurity
f_1194_2580_2612(string
fileName,System.Security.AccessControl.AccessControlSections
includeSections)
{
var return_v = new System.Security.AccessControl.FileSecurity( fileName, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2580, 2612);
return return_v;
}


System.Type
f_1194_2767_2778(System.Security.SecurityException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2767, 2778);
return return_v;
}


string
f_1194_2767_2787(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1194, 2767, 2787);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1194_2748_2826(System.Security.SecurityException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,string
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, (object)targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2748, 2826);
return return_v;
}


int
f_1194_2737_2827(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2737, 2827);
return 0;
}


bool
f_1194_2897_2982(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
previousPrivilegeState)
{
var return_v = PlatformInvokes.RestoreTokenPrivilege( privilegeName, ref previousPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 2897, 2982);
return return_v;
}


int
f_1194_3014_3053(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,System.Security.AccessControl.ObjectSecurity
securityDescriptor,string
path)
{
this_param.WriteSecurityDescriptorObject( securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 3014, 3053);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,1619,3065);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,1619,3065);
}
		}

public void SetSecurityDescriptor(
            string path,
            ObjectSecurity securityDescriptor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1194,3796,9124);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,3929,4057) || true) && (f_1194_3933_3959(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,3929,4057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,3993,4042);

throw f_1194_3999_4041("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,3929,4057);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4073,4100);

path = f_1194_4080_4099(path);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4116,4262) || true) && (securityDescriptor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,4116,4262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4180,4247);

throw f_1194_4186_4246("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,4116,4262);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4278,4518) || true) && (!f_1194_4283_4300(path)&&(DynAbs.Tracing.TraceSender.Expression_True(1194, 4282, 4327)&&!f_1194_4305_4327(path)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,4278,4518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4361,4503);

f_1194_4361_4502(this, f_1194_4383_4501(path, "SetSecurityDescriptor_FileNotFound"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,4278,4518);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4534,4599);

FileSystemSecurity 
sd = securityDescriptor as FileSystemSecurity
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4615,9113) || true) && (sd == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,4615,9113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,4663,4726);

throw f_1194_4669_4725("securityDescriptor");
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,4615,9113);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,4615,9113);
                // This algorithm works around the following security descriptor complexities:
                //
                //     - In order to copy an ACL between files, you need to use the
                //       binary form, and transfer all sections. If you don't use the binary form,
                //       then the FileSystem only applies changes that have happened to that specific
                //       ACL object -- which will not be present if you are just stamping a specific
                //       ACL on a lot of files.
                //     - Copying a full ACL means copying its Audit section, which normal users
                //       don't have access to.
                //
                // In order to make this cmdlet support regular users modifying their own files,
                // the solution is to:
                //
                //     - First attempt to copy the entire security descriptor as we did in V1.
                //       This ensures backward compatability for administrator scripts that currently
                //       work.
                //     - If the attempt fails due to a PrivilegeNotHeld exception, try again with
                //       an estimate of the minimum required subset. This is an estimate, since the
                //       ACL object doesn't tell you exactly what's changed.
                //           - If their ACL doesn't include any audit rules, don't try to set the
                //             audit section. If it does contain Audit rules, continue to try and
                //             set the section, so they get an appropriate error message.
                //           - If their ACL has the same Owner / Group as the destination file,
                //             also don't try to set those sections.
                //       If they added audit rules, or made changes to the Owner / Group, they will
                //       still get an error message.
                //
                // We can't roll the two steps into one, as the second step can't handle the
                // situation where an admin wants to _clear_ the audit entries. It would be nice to
                // detect a difference in audit entries (like we do with Owner and Group,) but
                // retrieving the Audit entries requires SeSecurityPrivilege as well.

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,7300,7359);

f_1194_7300_7358(this, path, sd, AccessControlSections.All);
                }
                catch (PrivilegeNotHeldException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1194,7396,9098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,7546,7620);

ObjectSecurity 
existingDescriptor = f_1194_7582_7619(f_1194_7582_7600(path))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,7642,7707);

Type 
ntAccountType = typeof(System.Security.Principal.NTAccount)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,7731,7790);

AccessControlSections 
sections = AccessControlSections.All
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,7943,8014);

int 
auditRuleCount = f_1194_7964_8013(f_1194_7964_8007(sd, true, true, ntAccountType))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8036,8277) || true) && ((auditRuleCount == 0) &&(DynAbs.Tracing.TraceSender.Expression_True(1194, 8040, 8163)&&                        (f_1194_8091_8116(sd)== f_1194_8120_8162(existingDescriptor))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,8036,8277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8213,8254);

sections &= ~AccessControlSections.Audit;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,8036,8277);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8389,8579) || true) && (f_1194_8393_8419(sd, ntAccountType)== f_1194_8423_8465(existingDescriptor, ntAccountType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,8389,8579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8515,8556);

sections &= ~AccessControlSections.Owner;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,8389,8579);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8691,8881) || true) && (f_1194_8695_8721(sd, ntAccountType)== f_1194_8725_8767(existingDescriptor, ntAccountType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,8691,8881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,8817,8858);

sections &= ~AccessControlSections.Group;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,8691,8881);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9037,9079);

f_1194_9037_9078(this, path, sd, sections);
DynAbs.Tracing.TraceSender.TraceExitCatch(1194,7396,9098);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,4615,9113);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1194,3796,9124);

bool
f_1194_3933_3959(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 3933, 3959);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1194_3999_4041(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 3999, 4041);
return return_v;
}


string
f_1194_4080_4099(string
path)
{
var return_v = NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4080, 4099);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1194_4186_4246(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4186, 4246);
return return_v;
}


bool
f_1194_4283_4300(string
path)
{
var return_v = File.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4283, 4300);
return return_v;
}


bool
f_1194_4305_4327(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4305, 4327);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1194_4383_4501(string
path,string
errorId)
{
var return_v = CreateErrorRecord( path, errorId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4383, 4501);
return return_v;
}


int
f_1194_4361_4502(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.ThrowTerminatingError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4361, 4502);
return 0;
}


System.Management.Automation.PSArgumentException
f_1194_4669_4725(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 4669, 4725);
return return_v;
}


int
f_1194_7300_7358(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,string
path,System.Security.AccessControl.FileSystemSecurity
sd,System.Security.AccessControl.AccessControlSections
sections)
{
this_param.SetSecurityDescriptor( path, (System.Security.AccessControl.ObjectSecurity)sd, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 7300, 7358);
return 0;
}


System.IO.FileInfo
f_1194_7582_7600(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 7582, 7600);
return return_v;
}


System.Security.AccessControl.FileSecurity
f_1194_7582_7619(System.IO.FileInfo
fileInfo)
{
var return_v = fileInfo.GetAccessControl();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 7582, 7619);
return return_v;
}


System.Security.AccessControl.AuthorizationRuleCollection
f_1194_7964_8007(System.Security.AccessControl.FileSystemSecurity
this_param,bool
includeExplicit,bool
includeInherited,System.Type
targetType)
{
var return_v = this_param.GetAuditRules( includeExplicit, includeInherited, targetType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 7964, 8007);
return return_v;
}


int
f_1194_7964_8013(System.Security.AccessControl.AuthorizationRuleCollection
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1194, 7964, 8013);
return return_v;
}


bool
f_1194_8091_8116(System.Security.AccessControl.FileSystemSecurity
this_param)
{
var return_v = this_param.AreAuditRulesProtected ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1194, 8091, 8116);
return return_v;
}


bool
f_1194_8120_8162(System.Security.AccessControl.ObjectSecurity
this_param)
{
var return_v = this_param.AreAccessRulesProtected;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1194, 8120, 8162);
return return_v;
}


System.Security.Principal.IdentityReference
f_1194_8393_8419(System.Security.AccessControl.FileSystemSecurity
this_param,System.Type
targetType)
{
var return_v = this_param.GetOwner( targetType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 8393, 8419);
return return_v;
}


System.Security.Principal.IdentityReference
f_1194_8423_8465(System.Security.AccessControl.ObjectSecurity
this_param,System.Type
targetType)
{
var return_v = this_param.GetOwner( targetType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 8423, 8465);
return return_v;
}


System.Security.Principal.IdentityReference
f_1194_8695_8721(System.Security.AccessControl.FileSystemSecurity
this_param,System.Type
targetType)
{
var return_v = this_param.GetGroup( targetType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 8695, 8721);
return return_v;
}


System.Security.Principal.IdentityReference
f_1194_8725_8767(System.Security.AccessControl.ObjectSecurity
this_param,System.Type
targetType)
{
var return_v = this_param.GetGroup( targetType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 8725, 8767);
return return_v;
}


int
f_1194_9037_9078(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,string
path,System.Security.AccessControl.FileSystemSecurity
sd,System.Security.AccessControl.AccessControlSections
sections)
{
this_param.SetSecurityDescriptor( path, (System.Security.AccessControl.ObjectSecurity)sd, sections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9037, 9078);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,3796,9124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,3796,9124);
}
		}

private void SetSecurityDescriptor(string path, ObjectSecurity sd, AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1194,9136,11210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9259,9325);

var 
currentPrivilegeState = f_1194_9287_9324()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9339,9378);

byte[] 
securityDescriptorBinary = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9489,9574);

f_1194_9489_9573("SeBackupPrivilege", ref currentPrivilegeState);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9592,9656);

securityDescriptorBinary = f_1194_9619_9655(sd);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1194,9685,9826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9725,9811);

f_1194_9725_9810("SeBackupPrivilege", ref currentPrivilegeState);
DynAbs.Tracing.TraceSender.TraceExitFinally(1194,9685,9826);
            }

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,9878,9964);

f_1194_9878_9963("SeRestorePrivilege", ref currentPrivilegeState);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10248,11028) || true) && (f_1194_10252_10274(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,10248,11028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10316,10374);

DirectorySecurity 
newDescriptor = f_1194_10350_10373()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10396,10478);

f_1194_10396_10477(                    newDescriptor, securityDescriptorBinary, sections);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10500,10556);

f_1194_10500_10555(f_1194_10500_10523(path), newDescriptor);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10578,10629);

f_1194_10578_10628(this, newDescriptor, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,10248,11028);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,10248,11028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10711,10759);

FileSecurity 
newDescriptor = f_1194_10740_10758()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10781,10863);

f_1194_10781_10862(                    newDescriptor, securityDescriptorBinary, sections);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10885,10936);

f_1194_10885_10935(f_1194_10885_10903(path), newDescriptor);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,10958,11009);

f_1194_10958_11008(this, newDescriptor, path);
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,10248,11028);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1194,11057,11199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,11097,11184);

f_1194_11097_11183("SeRestorePrivilege", ref currentPrivilegeState);
DynAbs.Tracing.TraceSender.TraceExitFinally(1194,11057,11199);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1194,9136,11210);

System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
f_1194_9287_9324()
{
var return_v = new System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9287, 9324);
return return_v;
}


bool
f_1194_9489_9573(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
oldPrivilegeState)
{
var return_v = PlatformInvokes.EnableTokenPrivilege( privilegeName, ref oldPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9489, 9573);
return return_v;
}


byte[]
f_1194_9619_9655(System.Security.AccessControl.ObjectSecurity
this_param)
{
var return_v = this_param.GetSecurityDescriptorBinaryForm();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9619, 9655);
return return_v;
}


bool
f_1194_9725_9810(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
previousPrivilegeState)
{
var return_v = PlatformInvokes.RestoreTokenPrivilege( privilegeName, ref previousPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9725, 9810);
return return_v;
}


bool
f_1194_9878_9963(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
oldPrivilegeState)
{
var return_v = PlatformInvokes.EnableTokenPrivilege( privilegeName, ref oldPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 9878, 9963);
return return_v;
}


bool
f_1194_10252_10274(string
path)
{
var return_v = Directory.Exists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10252, 10274);
return return_v;
}


System.Security.AccessControl.DirectorySecurity
f_1194_10350_10373()
{
var return_v = new System.Security.AccessControl.DirectorySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10350, 10373);
return return_v;
}


int
f_1194_10396_10477(System.Security.AccessControl.DirectorySecurity
this_param,byte[]
binaryForm,System.Security.AccessControl.AccessControlSections
includeSections)
{
this_param.SetSecurityDescriptorBinaryForm( binaryForm, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10396, 10477);
return 0;
}


System.IO.DirectoryInfo
f_1194_10500_10523(string
path)
{
var return_v = new System.IO.DirectoryInfo( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10500, 10523);
return return_v;
}


int
f_1194_10500_10555(System.IO.DirectoryInfo
directoryInfo,System.Security.AccessControl.DirectorySecurity
directorySecurity)
{
directoryInfo.SetAccessControl( directorySecurity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10500, 10555);
return 0;
}


int
f_1194_10578_10628(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,System.Security.AccessControl.DirectorySecurity
securityDescriptor,string
path)
{
this_param.WriteSecurityDescriptorObject( (System.Security.AccessControl.ObjectSecurity)securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10578, 10628);
return 0;
}


System.Security.AccessControl.FileSecurity
f_1194_10740_10758()
{
var return_v = new System.Security.AccessControl.FileSecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10740, 10758);
return return_v;
}


int
f_1194_10781_10862(System.Security.AccessControl.FileSecurity
this_param,byte[]
binaryForm,System.Security.AccessControl.AccessControlSections
includeSections)
{
this_param.SetSecurityDescriptorBinaryForm( binaryForm, includeSections);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10781, 10862);
return 0;
}


System.IO.FileInfo
f_1194_10885_10903(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10885, 10903);
return return_v;
}


int
f_1194_10885_10935(System.IO.FileInfo
fileInfo,System.Security.AccessControl.FileSecurity
fileSecurity)
{
fileInfo.SetAccessControl( fileSecurity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10885, 10935);
return 0;
}


int
f_1194_10958_11008(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,System.Security.AccessControl.FileSecurity
securityDescriptor,string
path)
{
this_param.WriteSecurityDescriptorObject( (System.Security.AccessControl.ObjectSecurity)securityDescriptor, path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 10958, 11008);
return 0;
}


bool
f_1194_11097_11183(string
privilegeName,ref System.Management.Automation.PlatformInvokes.TOKEN_PRIVILEGE
previousPrivilegeState)
{
var return_v = PlatformInvokes.RestoreTokenPrivilege( privilegeName, ref previousPrivilegeState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 11097, 11183);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,9136,11210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,9136,11210);
}
		}

public ObjectSecurity NewSecurityDescriptorFromPath(
            string path,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1194,11946,12408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,12094,12131);

ItemType 
itemType = ItemType.Unknown
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,12147,12342) || true) && (f_1194_12151_12172(this, path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,12147,12342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,12206,12236);

itemType = ItemType.Directory;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,12147,12342);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,12147,12342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,12302,12327);

itemType = ItemType.File;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,12147,12342);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,12358,12397);

return f_1194_12365_12396(itemType);
DynAbs.Tracing.TraceSender.TraceExitMethod(1194,11946,12408);

bool
f_1194_12151_12172(Microsoft.PowerShell.Commands.FileSystemProvider
this_param,string
path)
{
var return_v = this_param.IsItemContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 12151, 12172);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1194_12365_12396(Microsoft.PowerShell.Commands.FileSystemProvider.ItemType
itemType)
{
var return_v = NewSecurityDescriptor( itemType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 12365, 12396);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,11946,12408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,11946,12408);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ObjectSecurity NewSecurityDescriptorOfType(
            string type,
            AccessControlSections sections)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1194,12955,13247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13101,13138);

ItemType 
itemType = ItemType.Unknown
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13154,13183);

itemType = f_1194_13165_13182(type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13197,13236);

return f_1194_13204_13235(itemType);
DynAbs.Tracing.TraceSender.TraceExitMethod(1194,12955,13247);

Microsoft.PowerShell.Commands.FileSystemProvider.ItemType
f_1194_13165_13182(string
input)
{
var return_v = GetItemType( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 13165, 13182);
return return_v;
}


System.Security.AccessControl.ObjectSecurity
f_1194_13204_13235(Microsoft.PowerShell.Commands.FileSystemProvider.ItemType
itemType)
{
var return_v = NewSecurityDescriptor( itemType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 13204, 13235);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,12955,13247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,12955,13247);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ObjectSecurity NewSecurityDescriptor(
            ItemType itemType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1194,13259,13727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13368,13393);

ObjectSecurity 
sd = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13409,13690);

switch (itemType)
            {

case ItemType.File:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,13409,13690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13500,13524);

sd = f_1194_13505_13523();
DynAbs.Tracing.TraceSender.TraceBreak(1194,13546,13552);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,13409,13690);

case ItemType.Directory:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1194,13409,13690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13618,13647);

sd = f_1194_13623_13646();
DynAbs.Tracing.TraceSender.TraceBreak(1194,13669,13675);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1194,13409,13690);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13706,13716);

return sd;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1194,13259,13727);

System.Security.AccessControl.FileSecurity
f_1194_13505_13523()
{
var return_v = new System.Security.AccessControl.FileSecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 13505, 13523);
return return_v;
}


System.Security.AccessControl.DirectorySecurity
f_1194_13623_13646()
{
var return_v = new System.Security.AccessControl.DirectorySecurity();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 13623, 13646);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,13259,13727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,13259,13727);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ErrorRecord CreateErrorRecord(string path,
                                                     string errorId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1194,13739,14286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13891,13913);

string 
message = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,13929,14003);

message = f_1194_13939_14002(f_1194_13957_13995(), path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,14019,14249);

ErrorRecord 
er =
f_1194_14053_14248(f_1194_14069_14103(message), errorId, ErrorCategory.ObjectNotFound, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1194,14265,14275);

return er;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1194,13739,14286);

string
f_1194_13957_13995()
{
var return_v = FileSystemProviderStrings.FileNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1194, 13957, 13995);
return return_v;
}


string
f_1194_13939_14002(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 13939, 14002);
return return_v;
}


System.IO.FileNotFoundException
f_1194_14069_14103(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 14069, 14103);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1194_14053_14248(System.IO.FileNotFoundException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1194, 14053, 14248);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1194,13739,14286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1194,13739,14286);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}

