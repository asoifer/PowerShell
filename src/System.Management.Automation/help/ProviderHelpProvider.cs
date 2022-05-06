// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;

namespace System.Management.Automation
{
internal class ProviderHelpProvider : HelpProviderWithCache
{
internal ProviderHelpProvider(HelpSystem helpSystem) :base(f_1171_860_870_C(helpSystem) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1171,800,964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,1006,1019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5106,5134);
this._helpFiles = f_1171_5119_5134();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,896,953);

_sessionState = f_1171_912_952(f_1171_912_939(helpSystem));
DynAbs.Tracing.TraceSender.TraceExitConstructor(1171,800,964);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,800,964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,800,964);
}
		}

private readonly SessionState _sessionState;

internal override string Name
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,1267,1350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,1303,1335);

return "Provider Help Provider";
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,1267,1350);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,1213,1361);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,1213,1361);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override HelpCategory HelpCategory
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,1592,1672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,1628,1657);

return HelpCategory.Provider;
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,1592,1672);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,1524,1683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,1524,1683);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override IEnumerable<HelpInfo> ExactMatchHelp(HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,1929,4349);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,2033,2083);

Collection<ProviderInfo> 
matchingProviders = null
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,2135,2202);

matchingProviders = f_1171_2155_2201(f_1171_2155_2177(_sessionState), f_1171_2182_2200(helpRequest));
            }
            catch (ProviderNotFoundException e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,2231,3140);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,2659,3125) || true) && (f_1171_2663_2695(f_1171_2663_2678(this))== HelpCategory.Provider)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,2659,3125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,2762,2869);

ErrorRecord 
errorRecord = f_1171_2788_2868(e, "ProviderLoadError", ErrorCategory.ResourceUnavailable, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,2891,3040);

errorRecord.ErrorDetails = f_1171_2918_3039(f_1171_2935_2972(typeof(ProviderHelpProvider)), "HelpErrors", "ProviderLoadError", f_1171_3009_3027(helpRequest), f_1171_3029_3038(e));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3062,3106);

f_1171_3062_3105(f_1171_3062_3088(f_1171_3062_3077(this)), errorRecord);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,2659,3125);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,2231,3140);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3156,4338) || true) && (matchingProviders != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,3156,4338);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3219,4323);
foreach(ProviderInfo providerInfo in f_1171_3257_3274_I(matchingProviders) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,3219,4323);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3368,3395);

f_1171_3368_3394(this, providerInfo);
                    }
                    catch (IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,3440,3619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3520,3596);

f_1171_3520_3595(this, ioException, f_1171_3553_3571(helpRequest), f_1171_3573_3594(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,3440,3619);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,3641,3854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3749,3831);

f_1171_3749_3830(this, securityException, f_1171_3788_3806(helpRequest), f_1171_3808_3829(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,3641,3854);
                    }
                    catch (XmlException xmlException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,3876,4058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,3958,4035);

f_1171_3958_4034(this, xmlException, f_1171_3992_4010(helpRequest), f_1171_4012_4033(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,3876,4058);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4082,4165);

HelpInfo 
helpInfo = f_1171_4102_4164(this, f_1171_4111_4136(providerInfo)+ "\\" + f_1171_4146_4163(providerInfo))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4189,4304) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,4189,4304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4259,4281);

listYield.Add(helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,4189,4304);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,3219,4323);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1171,1,1105);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1171,1,1105);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1171,3156,4338);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,1929,4349);

return listYield;

System.Management.Automation.CmdletProviderManagementIntrinsics
f_1171_2155_2177(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 2155, 2177);
return return_v;
}


string
f_1171_2182_2200(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 2182, 2200);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
f_1171_2155_2201(System.Management.Automation.CmdletProviderManagementIntrinsics
this_param,string
name)
{
var return_v = this_param.Get( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 2155, 2201);
return return_v;
}


System.Management.Automation.HelpSystem
f_1171_2663_2678(System.Management.Automation.ProviderHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 2663, 2678);
return return_v;
}


System.Management.Automation.HelpCategory
f_1171_2663_2695(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastHelpCategory ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 2663, 2695);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1171_2788_2868(System.Management.Automation.ProviderNotFoundException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 2788, 2868);
return return_v;
}


System.Reflection.Assembly
f_1171_2935_2972(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 2935, 2972);
return return_v;
}


string
f_1171_3009_3027(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3009, 3027);
return return_v;
}


string
f_1171_3029_3038(System.Management.Automation.ProviderNotFoundException
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3029, 3038);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1171_2918_3039(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 2918, 3039);
return return_v;
}


System.Management.Automation.HelpSystem
f_1171_3062_3077(System.Management.Automation.ProviderHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3062, 3077);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1171_3062_3088(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.LastErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3062, 3088);
return return_v;
}


int
f_1171_3062_3105(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3062, 3105);
return 0;
}


int
f_1171_3368_3394(System.Management.Automation.ProviderHelpProvider
this_param,System.Management.Automation.ProviderInfo
providerInfo)
{
this_param.LoadHelpFile( providerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3368, 3394);
return 0;
}


string
f_1171_3553_3571(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3553, 3571);
return return_v;
}


string
f_1171_3573_3594(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3573, 3594);
return return_v;
}


int
f_1171_3520_3595(System.Management.Automation.ProviderHelpProvider
this_param,System.IO.IOException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3520, 3595);
return 0;
}


string
f_1171_3788_3806(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3788, 3806);
return return_v;
}


string
f_1171_3808_3829(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3808, 3829);
return return_v;
}


int
f_1171_3749_3830(System.Management.Automation.ProviderHelpProvider
this_param,System.Security.SecurityException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3749, 3830);
return 0;
}


string
f_1171_3992_4010(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 3992, 4010);
return return_v;
}


string
f_1171_4012_4033(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4012, 4033);
return return_v;
}


int
f_1171_3958_4034(System.Management.Automation.ProviderHelpProvider
this_param,System.Xml.XmlException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3958, 4034);
return 0;
}


string
f_1171_4111_4136(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4111, 4136);
return return_v;
}


string
f_1171_4146_4163(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4146, 4163);
return return_v;
}


System.Management.Automation.HelpInfo
f_1171_4102_4164(System.Management.Automation.ProviderHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 4102, 4164);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
f_1171_3257_3274_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ProviderInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 3257, 3274);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,1929,4349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,1929,4349);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetProviderAssemblyPath(ProviderInfo providerInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1171,4361,4706);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4458,4513) || true) && (providerInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,4458,4513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4501,4513);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,4458,4513);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4529,4601) || true) && (f_1171_4533_4562(providerInfo)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,4529,4601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4589,4601);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,4529,4601);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,4617,4695);

return f_1171_4624_4694(f_1171_4646_4693(f_1171_4646_4684(f_1171_4646_4675(providerInfo))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1171,4361,4706);

System.Type
f_1171_4533_4562(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.ImplementingType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4533, 4562);
return return_v;
}


System.Type
f_1171_4646_4675(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.ImplementingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4646, 4675);
return return_v;
}


System.Reflection.Assembly
f_1171_4646_4684(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4646, 4684);
return return_v;
}


string
f_1171_4646_4693(System.Reflection.Assembly
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 4646, 4693);
return return_v;
}


string?
f_1171_4624_4694(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 4624, 4694);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,4361,4706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,4361,4706);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private readonly Hashtable _helpFiles ;

private void LoadHelpFile(ProviderInfo providerInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,5443,10374);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5520,5654) || true) && (providerInfo == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,5520,5654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5578,5639);

throw f_1171_5584_5638("providerInfo");
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,5520,5654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5670,5710);

string 
helpFile = f_1171_5688_5709(providerInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5726,5849) || true) && (f_1171_5730_5760(helpFile)||(DynAbs.Tracing.TraceSender.Expression_False(1171, 5730, 5793)||f_1171_5764_5793(_helpFiles, helpFile)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,5726,5849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5827,5834);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,5726,5849);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5865,5898);

string 
helpFileToLoad = helpFile
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,5974,6025);

PSSnapInInfo 
mshSnapInInfo = f_1171_6003_6024(providerInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,6296,6354);

Collection<string> 
searchPaths = f_1171_6329_6353()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,6368,7335) || true) && (mshSnapInInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,6368,7335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,6427,6559);

f_1171_6427_6558(!f_1171_6447_6498(f_1171_6468_6497(mshSnapInInfo)), "Application Base is null or empty.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,6839,6910);

helpFileToLoad = f_1171_6856_6909(f_1171_6869_6898(mshSnapInInfo), helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,6368,7335);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,6368,7335);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,6944,7335) || true) && ((f_1171_6949_6968(providerInfo)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1171, 6948, 7030)&&(!f_1171_6983_7029(f_1171_7004_7028(f_1171_7004_7023(providerInfo))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,6944,7335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7064,7136);

helpFileToLoad = f_1171_7081_7135(f_1171_7094_7124(f_1171_7094_7113(providerInfo)), helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,6944,7335);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,6944,7335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7202,7247);

f_1171_7202_7246(                searchPaths, f_1171_7218_7245(this));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7265,7320);

f_1171_7265_7319(                searchPaths, f_1171_7281_7318(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,6944,7335);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,6368,7335);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7351,7425);

string 
location = f_1171_7369_7424(helpFileToLoad, searchPaths)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7439,7534) || true) && (f_1171_7443_7473(location))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,7439,7534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7492,7534);

throw f_1171_7498_7533(helpFile);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,7439,7534);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7550,7740);

XmlDocument 
doc = f_1171_7568_7739(f_1171_7629_7651(location), false, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7884,7909);

_helpFiles[helpFile] = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7925,7954);

XmlNode 
helpItemsNode = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,7970,8450) || true) && (f_1171_7974_7991(doc))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,7970,8450);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8034,8039);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8025,8435) || true) && (i < f_1171_8045_8065(f_1171_8045_8059(doc)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8067,8070)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8025,8435))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8025,8435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8112,8145);

XmlNode 
node = f_1171_8127_8144(f_1171_8127_8141(doc), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8167,8416) || true) && (f_1171_8171_8184(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1171, 8171, 8290)&&f_1171_8211_8285(f_1171_8226_8235(node), "helpItems", StringComparison.OrdinalIgnoreCase)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8167,8416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8340,8361);

helpItemsNode = node;
DynAbs.Tracing.TraceSender.TraceBreak(1171,8387,8393);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8167,8416);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1171,1,411);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1171,1,411);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1171,7970,8450);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8466,8517) || true) && (helpItemsNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8466,8517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8510,8517);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8466,8517);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8533,10363);
using(f_1171_8540_8571(f_1171_8540_8555(this), location))            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8605,10348) || true) && (f_1171_8609_8636(helpItemsNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8605,10348);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8687,8692);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8678,10329) || true) && (i < f_1171_8698_8728(f_1171_8698_8722(helpItemsNode)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8730,8733)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8678,10329))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8678,10329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8783,8826);

XmlNode 
node = f_1171_8798_8825(f_1171_8798_8822(helpItemsNode), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,8852,10306) || true) && (f_1171_8856_8869(node)== XmlNodeType.Element &&(DynAbs.Tracing.TraceSender.Expression_True(1171, 8856, 8978)&&f_1171_8896_8973(f_1171_8911_8920(node), "providerHelp", StringComparison.OrdinalIgnoreCase)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,8852,10306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9036,9084);

HelpInfo 
helpInfo = f_1171_9056_9083(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9116,10279) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,9116,10279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9202,9247);

f_1171_9202_9246(f_1171_9202_9217(this), f_1171_9230_9245(helpInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9455,9645);

f_1171_9455_9644(f_1171_9455_9482(f_1171_9455_9472(helpInfo)), 0, f_1171_9493_9643(f_1171_9507_9535(), "ProviderHelpInfo#{0}#{1}", f_1171_9602_9627(providerInfo), f_1171_9629_9642(helpInfo)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9681,10143) || true) && (!f_1171_9686_9733(f_1171_9707_9732(providerInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,9681,10143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9807,9895);

f_1171_9807_9894(f_1171_9807_9835(f_1171_9807_9824(helpInfo)), f_1171_9840_9893("PSSnapIn", f_1171_9871_9892(providerInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,9933,10108);

f_1171_9933_10107(f_1171_9933_9960(f_1171_9933_9950(helpInfo)), 1, f_1171_9971_10106(f_1171_9985_10013(), "ProviderHelpInfo#{0}", f_1171_10080_10105(providerInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,9681,10143);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,10179,10248);

f_1171_10179_10247(this, f_1171_10188_10213(providerInfo)+ "\\" + f_1171_10223_10236(helpInfo), helpInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,9116,10279);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8852,10306);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1171,1,1652);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1171,1,1652);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1171,8605,10348);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1171,8533,10363);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,5443,10374);

System.Management.Automation.PSArgumentNullException
f_1171_5584_5638(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 5584, 5638);
return return_v;
}


string
f_1171_5688_5709(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 5688, 5709);
return return_v;
}


bool
f_1171_5730_5760(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 5730, 5760);
return return_v;
}


bool
f_1171_5764_5793(System.Collections.Hashtable
this_param,string
key)
{
var return_v = this_param.Contains( (object)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 5764, 5793);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1171_6003_6024(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 6003, 6024);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1171_6329_6353()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 6329, 6353);
return return_v;
}


string
f_1171_6468_6497(System.Management.Automation.PSSnapInInfo
this_param)
{
var return_v = this_param.ApplicationBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 6468, 6497);
return return_v;
}


bool
f_1171_6447_6498(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 6447, 6498);
return return_v;
}


int
f_1171_6427_6558(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 6427, 6558);
return 0;
}


string
f_1171_6869_6898(System.Management.Automation.PSSnapInInfo
this_param)
{
var return_v = this_param.ApplicationBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 6869, 6898);
return return_v;
}


string
f_1171_6856_6909(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 6856, 6909);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1171_6949_6968(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Module ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 6949, 6968);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1171_7004_7023(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 7004, 7023);
return return_v;
}


string
f_1171_7004_7028(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 7004, 7028);
return return_v;
}


bool
f_1171_6983_7029(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 6983, 7029);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1171_7094_7113(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 7094, 7113);
return return_v;
}


string
f_1171_7094_7124(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.ModuleBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 7094, 7124);
return return_v;
}


string
f_1171_7081_7135(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7081, 7135);
return return_v;
}


string
f_1171_7218_7245(System.Management.Automation.ProviderHelpProvider
this_param)
{
var return_v = this_param.GetDefaultShellSearchPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7218, 7245);
return return_v;
}


int
f_1171_7202_7246(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7202, 7246);
return 0;
}


string
f_1171_7281_7318(System.Management.Automation.ProviderInfo
providerInfo)
{
var return_v = GetProviderAssemblyPath( providerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7281, 7318);
return return_v;
}


int
f_1171_7265_7319(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7265, 7319);
return 0;
}


string
f_1171_7369_7424(string
file,System.Collections.ObjectModel.Collection<string>
searchPaths)
{
var return_v = MUIFileSearcher.LocateFile( file, searchPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7369, 7424);
return return_v;
}


bool
f_1171_7443_7473(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7443, 7473);
return return_v;
}


System.IO.FileNotFoundException
f_1171_7498_7533(string
message)
{
var return_v = new System.IO.FileNotFoundException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7498, 7533);
return return_v;
}


System.IO.FileInfo
f_1171_7629_7651(string
fileName)
{
var return_v = new System.IO.FileInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7629, 7651);
return return_v;
}


System.Xml.XmlDocument
f_1171_7568_7739(System.IO.FileInfo
xmlPath,bool
preserveNonElements,int?
maxCharactersInDocument)
{
var return_v = InternalDeserializer.LoadUnsafeXmlDocument( xmlPath, preserveNonElements, maxCharactersInDocument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 7568, 7739);
return return_v;
}


bool
f_1171_7974_7991(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 7974, 7991);
return return_v;
}


System.Xml.XmlNodeList
f_1171_8045_8059(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8045, 8059);
return return_v;
}


int
f_1171_8045_8065(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8045, 8065);
return return_v;
}


System.Xml.XmlNodeList
f_1171_8127_8141(System.Xml.XmlDocument
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8127, 8141);
return return_v;
}


System.Xml.XmlNode
f_1171_8127_8144(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8127, 8144);
return return_v;
}


System.Xml.XmlNodeType
f_1171_8171_8184(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8171, 8184);
return return_v;
}


string
f_1171_8226_8235(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8226, 8235);
return return_v;
}


int
f_1171_8211_8285(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 8211, 8285);
return return_v;
}


System.Management.Automation.HelpSystem
f_1171_8540_8555(System.Management.Automation.ProviderHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8540, 8555);
return return_v;
}


System.IDisposable
f_1171_8540_8571(System.Management.Automation.HelpSystem
this_param,string
helpFile)
{
var return_v = this_param.Trace( helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 8540, 8571);
return return_v;
}


bool
f_1171_8609_8636(System.Xml.XmlNode
this_param)
{
var return_v = this_param.HasChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8609, 8636);
return return_v;
}


System.Xml.XmlNodeList
f_1171_8698_8722(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8698, 8722);
return return_v;
}


int
f_1171_8698_8728(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8698, 8728);
return return_v;
}


System.Xml.XmlNodeList
f_1171_8798_8822(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8798, 8822);
return return_v;
}


System.Xml.XmlNode
f_1171_8798_8825(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8798, 8825);
return return_v;
}


System.Xml.XmlNodeType
f_1171_8856_8869(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8856, 8869);
return return_v;
}


string
f_1171_8911_8920(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 8911, 8920);
return return_v;
}


int
f_1171_8896_8973(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 8896, 8973);
return return_v;
}


System.Management.Automation.ProviderHelpInfo
f_1171_9056_9083(System.Xml.XmlNode
xmlNode)
{
var return_v = ProviderHelpInfo.Load( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9056, 9083);
return return_v;
}


System.Management.Automation.HelpSystem
f_1171_9202_9217(System.Management.Automation.ProviderHelpProvider
this_param)
{
var return_v = this_param.HelpSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9202, 9217);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1171_9230_9245(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9230, 9245);
return return_v;
}


int
f_1171_9202_9246(System.Management.Automation.HelpSystem
this_param,System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
errorRecords)
{
this_param.TraceErrors( errorRecords);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9202, 9246);
return 0;
}


System.Management.Automation.PSObject
f_1171_9455_9472(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9455, 9472);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1171_9455_9482(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9455, 9482);
return return_v;
}


System.Globalization.CultureInfo
f_1171_9507_9535()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9507, 9535);
return return_v;
}


string
f_1171_9602_9627(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9602, 9627);
return return_v;
}


string
f_1171_9629_9642(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9629, 9642);
return return_v;
}


string
f_1171_9493_9643(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9493, 9643);
return return_v;
}


int
f_1171_9455_9644(System.Collections.ObjectModel.Collection<string>
this_param,int
index,string
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9455, 9644);
return 0;
}


string
f_1171_9707_9732(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9707, 9732);
return return_v;
}


bool
f_1171_9686_9733(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9686, 9733);
return return_v;
}


System.Management.Automation.PSObject
f_1171_9807_9824(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9807, 9824);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1171_9807_9835(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9807, 9835);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1171_9871_9892(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9871, 9892);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1171_9840_9893(string
name,System.Management.Automation.PSSnapInInfo
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9840, 9893);
return return_v;
}


int
f_1171_9807_9894(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9807, 9894);
return 0;
}


System.Management.Automation.PSObject
f_1171_9933_9950(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9933, 9950);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1171_9933_9960(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9933, 9960);
return return_v;
}


System.Globalization.CultureInfo
f_1171_9985_10013()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 9985, 10013);
return return_v;
}


string
f_1171_10080_10105(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 10080, 10105);
return return_v;
}


string
f_1171_9971_10106(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9971, 10106);
return return_v;
}


int
f_1171_9933_10107(System.Collections.ObjectModel.Collection<string>
this_param,int
index,string
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 9933, 10107);
return 0;
}


string
f_1171_10188_10213(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 10188, 10213);
return return_v;
}


string
f_1171_10223_10236(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 10223, 10236);
return return_v;
}


int
f_1171_10179_10247(System.Management.Automation.ProviderHelpProvider
this_param,string
target,System.Management.Automation.HelpInfo
helpInfo)
{
this_param.AddCache( target, helpInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 10179, 10247);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,5443,10374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,5443,10374);
}
		}

internal override IEnumerable<HelpInfo> SearchHelp(HelpRequest helpRequest, bool searchOnlyContent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,10881,14401);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11005,11041);

int 
countOfHelpInfoObjectsFound = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11055,11090);

string 
target = f_1171_11071_11089(helpRequest)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11104,11128);

string 
pattern = target
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11212,11251);

WildcardPattern 
wildCardPattern = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11267,11342);

bool 
decoratedSearch = !f_1171_11291_11341(target)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11358,11978) || true) && (!searchOnlyContent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,11358,11978);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11414,11509) || true) && (decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,11414,11509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11475,11490);

pattern += "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,11414,11509);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,11358,11978);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,11358,11978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11575,11616);

string 
searchTarget = f_1171_11597_11615(helpRequest)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11634,11760) || true) && (decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,11634,11760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11695,11741);

searchTarget = "*" + f_1171_11716_11734(helpRequest)+ "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,11634,11760);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11780,11887);

wildCardPattern = f_1171_11798_11886(searchTarget, WildcardOptions.Compiled | WildcardOptions.IgnoreCase);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11949,11963);

pattern = "*";
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,11358,11978);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,11994,12108);

PSSnapinQualifiedName 
snapinQualifiedNameForPattern =
f_1171_12065_12107(pattern)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12124,12226) || true) && (snapinQualifiedNameForPattern == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,12124,12226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12199,12211);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,12124,12226);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12242,14390);
foreach(ProviderInfo providerInfo in f_1171_12280_12311_I(f_1171_12280_12311(f_1171_12280_12302(_sessionState))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,12242,14390);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12345,14375) || true) && (f_1171_12349_12378(providerInfo, pattern))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,12345,14375);
                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12472,12499);

f_1171_12472_12498(this, providerInfo);
                    }
                    catch (IOException ioException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,12544,12827);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12624,12804) || true) && (!decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,12624,12804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12702,12777);

f_1171_12702_12776(this, ioException, f_1171_12735_12752(providerInfo), f_1171_12754_12775(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,12624,12804);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,12544,12827);
                    }
                    catch (System.Security.SecurityException securityException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,12849,13166);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,12957,13143) || true) && (!decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,12957,13143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13035,13116);

f_1171_13035_13115(this, securityException, f_1171_13074_13091(providerInfo), f_1171_13093_13114(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,12957,13143);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,12849,13166);
                    }
                    catch (XmlException xmlException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1171,13188,13474);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13270,13451) || true) && (!decoratedSearch)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,13270,13451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13348,13424);

f_1171_13348_13423(this, xmlException, f_1171_13382_13399(providerInfo), f_1171_13401_13422(providerInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,13270,13451);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(1171,13188,13474);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13498,13581);

HelpInfo 
helpInfo = f_1171_13518_13580(this, f_1171_13527_13552(providerInfo)+ "\\" + f_1171_13562_13579(providerInfo))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13605,14356) || true) && (helpInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,13605,14356);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13675,14069) || true) && (searchOnlyContent)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,13675,14069);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,13884,14042) || true) && (!f_1171_13889_13936(helpInfo, wildCardPattern))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,13884,14042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14002,14011);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,13884,14042);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,13675,14069);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14097,14127);

countOfHelpInfoObjectsFound++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14153,14175);

listYield.Add(helpInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14203,14333) || true) && (countOfHelpInfoObjectsFound >= f_1171_14238_14260(helpRequest)&&(DynAbs.Tracing.TraceSender.Expression_True(1171, 14207, 14290)&&f_1171_14264_14286(helpRequest)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1171,14203,14333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14321,14333);

return listYield;
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,14203,14333);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,13605,14356);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,12345,14375);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1171,12242,14390);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1171,1,2149);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1171,1,2149);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1171,10881,14401);

return listYield;

string
f_1171_11071_11089(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 11071, 11089);
return return_v;
}


bool
f_1171_11291_11341(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 11291, 11341);
return return_v;
}


string
f_1171_11597_11615(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 11597, 11615);
return return_v;
}


string
f_1171_11716_11734(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.Target ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 11716, 11734);
return return_v;
}


System.Management.Automation.WildcardPattern
f_1171_11798_11886(string
pattern,System.Management.Automation.WildcardOptions
options)
{
var return_v = WildcardPattern.Get( pattern, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 11798, 11886);
return return_v;
}


System.Management.Automation.PSSnapinQualifiedName
f_1171_12065_12107(string
name)
{
var return_v = PSSnapinQualifiedName.GetInstance( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12065, 12107);
return return_v;
}


System.Management.Automation.CmdletProviderManagementIntrinsics
f_1171_12280_12302(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Provider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 12280, 12302);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
f_1171_12280_12311(System.Management.Automation.CmdletProviderManagementIntrinsics
this_param)
{
var return_v = this_param.GetAll();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12280, 12311);
return return_v;
}


bool
f_1171_12349_12378(System.Management.Automation.ProviderInfo
this_param,string
providerName)
{
var return_v = this_param.IsMatch( providerName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12349, 12378);
return return_v;
}


int
f_1171_12472_12498(System.Management.Automation.ProviderHelpProvider
this_param,System.Management.Automation.ProviderInfo
providerInfo)
{
this_param.LoadHelpFile( providerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12472, 12498);
return 0;
}


string
f_1171_12735_12752(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 12735, 12752);
return return_v;
}


string
f_1171_12754_12775(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 12754, 12775);
return return_v;
}


int
f_1171_12702_12776(System.Management.Automation.ProviderHelpProvider
this_param,System.IO.IOException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12702, 12776);
return 0;
}


string
f_1171_13074_13091(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13074, 13091);
return return_v;
}


string
f_1171_13093_13114(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13093, 13114);
return return_v;
}


int
f_1171_13035_13115(System.Management.Automation.ProviderHelpProvider
this_param,System.Security.SecurityException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 13035, 13115);
return 0;
}


string
f_1171_13382_13399(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13382, 13399);
return return_v;
}


string
f_1171_13401_13422(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.HelpFile;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13401, 13422);
return return_v;
}


int
f_1171_13348_13423(System.Management.Automation.ProviderHelpProvider
this_param,System.Xml.XmlException
exception,string
target,string
helpFile)
{
this_param.ReportHelpFileError( (System.Exception)exception, target, helpFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 13348, 13423);
return 0;
}


string
f_1171_13527_13552(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.PSSnapInName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13527, 13552);
return return_v;
}


string
f_1171_13562_13579(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 13562, 13579);
return return_v;
}


System.Management.Automation.HelpInfo
f_1171_13518_13580(System.Management.Automation.ProviderHelpProvider
this_param,string
target)
{
var return_v = this_param.GetCache( target);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 13518, 13580);
return return_v;
}


bool
f_1171_13889_13936(System.Management.Automation.HelpInfo
this_param,System.Management.Automation.WildcardPattern
pattern)
{
var return_v = this_param.MatchPatternInContent( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 13889, 13936);
return return_v;
}


int
f_1171_14238_14260(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 14238, 14260);
return return_v;
}


int
f_1171_14264_14286(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.MaxResults ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 14264, 14286);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
f_1171_12280_12311_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ProviderInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 12280, 12311);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,10881,14401);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,10881,14401);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override IEnumerable<HelpInfo> ProcessForwardedHelp(HelpInfo helpInfo, HelpRequest helpRequest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,14413,14739);

var listYield= new List<HelpInfo>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14542,14677);

ProviderCommandHelpInfo 
providerCommandHelpInfo = f_1171_14592_14676(helpInfo, f_1171_14648_14675(helpRequest))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,14691,14728);

listYield.Add(providerCommandHelpInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,14413,14739);

return listYield;

System.Management.Automation.ProviderContext
f_1171_14648_14675(System.Management.Automation.HelpRequest
this_param)
{
var return_v = this_param.ProviderContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 14648, 14675);
return return_v;
}


System.Management.Automation.ProviderCommandHelpInfo
f_1171_14592_14676(System.Management.Automation.HelpInfo
genericHelpInfo,System.Management.Automation.ProviderContext
providerContext)
{
var return_v = new System.Management.Automation.ProviderCommandHelpInfo( genericHelpInfo, providerContext);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 14592, 14676);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,14413,14739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,14413,14739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override void Reset()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1171,16883,16997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,16938,16951);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Reset(),1171,16938,16950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1171,16967,16986);

f_1171_16967_16985(
            _helpFiles);
DynAbs.Tracing.TraceSender.TraceExitMethod(1171,16883,16997);

int
f_1171_16967_16985(System.Collections.Hashtable
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 16967, 16985);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1171,16883,16997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,16883,16997);
}
		}

static ProviderHelpProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1171,634,17026);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1171,634,17026);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1171,634,17026);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1171,634,17026);

System.Management.Automation.ExecutionContext
f_1171_912_939(System.Management.Automation.HelpSystem
this_param)
{
var return_v = this_param.ExecutionContext;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 912, 939);
return return_v;
}


System.Management.Automation.SessionState
f_1171_912_952(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1171, 912, 952);
return return_v;
}


static System.Management.Automation.HelpSystem
f_1171_860_870_C(System.Management.Automation.HelpSystem
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(1171, 800, 964);
return return_v;
}


System.Collections.Hashtable
f_1171_5119_5134()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1171, 5119, 5134);
return return_v;
}

}
}
