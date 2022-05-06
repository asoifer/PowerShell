// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

namespace System.Management.Automation
{
internal abstract class HelpInfo
{
internal HelpInfo()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1155,942,983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,2835,2911);
this.ForwardHelpCategory = HelpCategory.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,3518,3577);
this.ForwardTarget = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,9269,9322);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1155,942,983);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,942,983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,942,983);
}
		}

internal abstract string Name
{            get;
}

internal abstract string Synopsis
{            get;
}

internal virtual string Component
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,1618,1646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,1624,1644);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,1618,1646);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,1560,1657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,1560,1657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal virtual string Role
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,1848,1876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,1854,1874);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,1848,1876);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,1795,1887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,1795,1887);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal virtual string Functionality
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,2106,2134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,2112,2132);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,2106,2134);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,2044,2145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,2044,2145);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal abstract HelpCategory HelpCategory
{            get;
}

internal HelpCategory ForwardHelpCategory {get; set; }

internal string ForwardTarget {get; set; }

internal abstract PSObject FullHelp
{            get;
}

internal PSObject ShortHelp
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,4052,4400);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4088,4148) || true) && (f_1155_4092_4105(this)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,4088,4148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4136,4148);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,4088,4148);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4168,4223);

PSObject 
shortHelpObject = f_1155_4195_4222(f_1155_4208_4221(this))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4243,4277);

f_1155_4243_4276(f_1155_4243_4268(shortHelpObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4295,4342);

f_1155_4295_4341(f_1155_4295_4320(shortHelpObject), "HelpInfoShort");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4362,4385);

return shortHelpObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,4052,4400);

System.Management.Automation.PSObject
f_1155_4092_4105(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 4092, 4105);
return return_v;
}


System.Management.Automation.PSObject
f_1155_4208_4221(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 4208, 4221);
return return_v;
}


System.Management.Automation.PSObject
f_1155_4195_4222(System.Management.Automation.PSObject
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 4195, 4222);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1155_4243_4268(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 4243, 4268);
return return_v;
}


int
f_1155_4243_4276(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 4243, 4276);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1155_4295_4320(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 4295, 4320);
return return_v;
}


int
f_1155_4295_4341(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 4295, 4341);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,4000,4411);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,4000,4411);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal virtual PSObject[] GetParameter(string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,4805,4928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,4886,4917);

return f_1155_4893_4916();
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,4805,4928);

System.Management.Automation.PSObject[]
f_1155_4893_4916()
{
var return_v = Array.Empty<PSObject>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 4893, 4916);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,4805,4928);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,4805,4928);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual Uri GetUriForOnlineHelp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,5332,5422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,5399,5411);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,5332,5422);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,5332,5422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,5332,5422);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal virtual bool MatchPatternInContent(WildcardPattern pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,5799,6032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,6008,6021);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,5799,6032);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,5799,6032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,5799,6032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected void AddCommonHelpProperties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,6700,7992);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,6765,6816) || true) && (f_1155_6769_6782(this)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,6765,6816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,6809,6816);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,6765,6816);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,6832,7004) || true) && (f_1155_6836_6868(f_1155_6836_6860(f_1155_6836_6849(this)), "Name")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,6832,7004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,6910,6989);

f_1155_6910_6988(f_1155_6910_6934(f_1155_6910_6923(this)), f_1155_6939_6987("Name", f_1155_6966_6986(f_1155_6966_6975(this))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,6832,7004);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7020,7208) || true) && (f_1155_7024_7060(f_1155_7024_7048(f_1155_7024_7037(this)), "Category")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,7020,7208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7102,7193);

f_1155_7102_7192(f_1155_7102_7126(f_1155_7102_7115(this)), f_1155_7131_7191("Category", f_1155_7162_7190(f_1155_7162_7179(this))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,7020,7208);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7224,7408) || true) && (f_1155_7228_7264(f_1155_7228_7252(f_1155_7228_7241(this)), "Synopsis")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,7224,7408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7306,7393);

f_1155_7306_7392(f_1155_7306_7330(f_1155_7306_7319(this)), f_1155_7335_7391("Synopsis", f_1155_7366_7390(f_1155_7366_7379(this))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,7224,7408);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7424,7600) || true) && (f_1155_7428_7465(f_1155_7428_7452(f_1155_7428_7441(this)), "Component")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,7424,7600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7507,7585);

f_1155_7507_7584(f_1155_7507_7531(f_1155_7507_7520(this)), f_1155_7536_7583("Component", f_1155_7568_7582(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,7424,7600);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7616,7777) || true) && (f_1155_7620_7652(f_1155_7620_7644(f_1155_7620_7633(this)), "Role")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,7616,7777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7694,7762);

f_1155_7694_7761(f_1155_7694_7718(f_1155_7694_7707(this)), f_1155_7723_7760("Role", f_1155_7750_7759(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,7616,7777);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7793,7981) || true) && (f_1155_7797_7838(f_1155_7797_7821(f_1155_7797_7810(this)), "Functionality")== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,7793,7981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,7880,7966);

f_1155_7880_7965(f_1155_7880_7904(f_1155_7880_7893(this)), f_1155_7909_7964("Functionality", f_1155_7945_7963(this)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,7793,7981);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,6700,7992);

System.Management.Automation.PSObject
f_1155_6769_6782(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6769, 6782);
return return_v;
}


System.Management.Automation.PSObject
f_1155_6836_6849(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6836, 6849);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_6836_6860(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6836, 6860);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_6836_6868(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6836, 6868);
return return_v;
}


System.Management.Automation.PSObject
f_1155_6910_6923(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6910, 6923);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_6910_6934(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6910, 6934);
return return_v;
}


string
f_1155_6966_6975(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 6966, 6975);
return return_v;
}


string
f_1155_6966_6986(string
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 6966, 6986);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_6939_6987(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 6939, 6987);
return return_v;
}


int
f_1155_6910_6988(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 6910, 6988);
return 0;
}


System.Management.Automation.PSObject
f_1155_7024_7037(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7024, 7037);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7024_7048(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7024, 7048);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_7024_7060(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7024, 7060);
return return_v;
}


System.Management.Automation.PSObject
f_1155_7102_7115(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7102, 7115);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7102_7126(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7102, 7126);
return return_v;
}


System.Management.Automation.HelpCategory
f_1155_7162_7179(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.HelpCategory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7162, 7179);
return return_v;
}


string
f_1155_7162_7190(System.Management.Automation.HelpCategory
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7162, 7190);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_7131_7191(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7131, 7191);
return return_v;
}


int
f_1155_7102_7192(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7102, 7192);
return 0;
}


System.Management.Automation.PSObject
f_1155_7228_7241(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7228, 7241);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7228_7252(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7228, 7252);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_7228_7264(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7228, 7264);
return return_v;
}


System.Management.Automation.PSObject
f_1155_7306_7319(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7306, 7319);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7306_7330(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7306, 7330);
return return_v;
}


string
f_1155_7366_7379(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Synopsis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7366, 7379);
return return_v;
}


string
f_1155_7366_7390(string
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7366, 7390);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_7335_7391(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7335, 7391);
return return_v;
}


int
f_1155_7306_7392(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7306, 7392);
return 0;
}


System.Management.Automation.PSObject
f_1155_7428_7441(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7428, 7441);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7428_7452(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7428, 7452);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_7428_7465(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7428, 7465);
return return_v;
}


System.Management.Automation.PSObject
f_1155_7507_7520(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7507, 7520);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7507_7531(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7507, 7531);
return return_v;
}


string
f_1155_7568_7582(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7568, 7582);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_7536_7583(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7536, 7583);
return return_v;
}


int
f_1155_7507_7584(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7507, 7584);
return 0;
}


System.Management.Automation.PSObject
f_1155_7620_7633(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7620, 7633);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7620_7644(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7620, 7644);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_7620_7652(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7620, 7652);
return return_v;
}


System.Management.Automation.PSObject
f_1155_7694_7707(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7694, 7707);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7694_7718(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7694, 7718);
return return_v;
}


string
f_1155_7750_7759(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7750, 7759);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_7723_7760(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7723, 7760);
return return_v;
}


int
f_1155_7694_7761(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7694, 7761);
return 0;
}


System.Management.Automation.PSObject
f_1155_7797_7810(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7797, 7810);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7797_7821(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7797, 7821);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1155_7797_7838(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7797, 7838);
return return_v;
}


System.Management.Automation.PSObject
f_1155_7880_7893(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7880, 7893);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_7880_7904(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7880, 7904);
return return_v;
}


string
f_1155_7945_7963(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 7945, 7963);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_7909_7964(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7909, 7964);
return return_v;
}


int
f_1155_7880_7965(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 7880, 7965);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,6700,7992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,6700,7992);
}
		}

protected void UpdateUserDefinedDataProperties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1155,8442,9033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8515,8566) || true) && (f_1155_8519_8532(this)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1155,8515,8566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8559,8566);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1155,8515,8566);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8582,8627);

f_1155_8582_8626(f_1155_8582_8606(f_1155_8582_8595(this)), "Component");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8641,8719);

f_1155_8641_8718(f_1155_8641_8665(f_1155_8641_8654(this)), f_1155_8670_8717("Component", f_1155_8702_8716(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8735,8775);

f_1155_8735_8774(f_1155_8735_8759(f_1155_8735_8748(this)), "Role");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8789,8857);

f_1155_8789_8856(f_1155_8789_8813(f_1155_8789_8802(this)), f_1155_8818_8855("Role", f_1155_8845_8854(this)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8873,8922);

f_1155_8873_8921(f_1155_8873_8897(f_1155_8873_8886(this)), "Functionality");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1155,8936,9022);

f_1155_8936_9021(f_1155_8936_8960(f_1155_8936_8949(this)), f_1155_8965_9020("Functionality", f_1155_9001_9019(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(1155,8442,9033);

System.Management.Automation.PSObject
f_1155_8519_8532(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8519, 8532);
return return_v;
}


System.Management.Automation.PSObject
f_1155_8582_8595(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8582, 8595);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8582_8606(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8582, 8606);
return return_v;
}


int
f_1155_8582_8626(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
name)
{
this_param.Remove( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8582, 8626);
return 0;
}


System.Management.Automation.PSObject
f_1155_8641_8654(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8641, 8654);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8641_8665(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8641, 8665);
return return_v;
}


string
f_1155_8702_8716(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Component;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8702, 8716);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_8670_8717(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8670, 8717);
return return_v;
}


int
f_1155_8641_8718(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8641, 8718);
return 0;
}


System.Management.Automation.PSObject
f_1155_8735_8748(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8735, 8748);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8735_8759(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8735, 8759);
return return_v;
}


int
f_1155_8735_8774(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
name)
{
this_param.Remove( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8735, 8774);
return 0;
}


System.Management.Automation.PSObject
f_1155_8789_8802(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8789, 8802);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8789_8813(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8789, 8813);
return return_v;
}


string
f_1155_8845_8854(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Role;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8845, 8854);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_8818_8855(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8818, 8855);
return return_v;
}


int
f_1155_8789_8856(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8789, 8856);
return 0;
}


System.Management.Automation.PSObject
f_1155_8873_8886(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8873, 8886);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8873_8897(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8873, 8897);
return return_v;
}


int
f_1155_8873_8921(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
name)
{
this_param.Remove( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8873, 8921);
return 0;
}


System.Management.Automation.PSObject
f_1155_8936_8949(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.FullHelp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8936, 8949);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1155_8936_8960(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 8936, 8960);
return return_v;
}


string
f_1155_9001_9019(System.Management.Automation.HelpInfo
this_param)
{
var return_v = this_param.Functionality;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1155, 9001, 9019);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1155_8965_9020(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8965, 9020);
return return_v;
}


int
f_1155_8936_9021(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1155, 8936, 9021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1155,8442,9033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,8442,9033);
}
		}

internal Collection<ErrorRecord> Errors {get; set; }

static HelpInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1155,807,9351);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1155,807,9351);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1155,807,9351);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1155,807,9351);
}
}
