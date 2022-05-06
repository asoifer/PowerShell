// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace System.Management.Automation
{
public sealed class ProxyCommand
{
private ProxyCommand()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1320,524,568);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1320,524,568);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,524,568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,524,568);
}
		}

public static string Create(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,1278,1589);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,1363,1503) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,1363,1503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,1424,1488);

throw f_1320_1430_1487("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,1363,1503);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,1519,1578);

return f_1320_1526_1577(commandMetadata, string.Empty, true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,1278,1589);

System.Management.Automation.PSArgumentNullException
f_1320_1430_1487(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 1430, 1487);
return return_v;
}


string
f_1320_1526_1577(System.Management.Automation.CommandMetadata
this_param,string
helpComment,bool
generateDynamicParameters)
{
var return_v = this_param.GetProxyCommand( helpComment, generateDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 1526, 1577);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,1278,1589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,1278,1589);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string Create(CommandMetadata commandMetadata, string helpComment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,2354,2684);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,2459,2599) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,2459,2599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,2520,2584);

throw f_1320_2526_2583("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,2459,2599);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,2615,2673);

return f_1320_2622_2672(commandMetadata, helpComment, true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,2354,2684);

System.Management.Automation.PSArgumentNullException
f_1320_2526_2583(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 2526, 2583);
return return_v;
}


string
f_1320_2622_2672(System.Management.Automation.CommandMetadata
this_param,string
helpComment,bool
generateDynamicParameters)
{
var return_v = this_param.GetProxyCommand( helpComment, generateDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 2622, 2672);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,2354,2684);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,2354,2684);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string Create(CommandMetadata commandMetadata, string helpComment, bool generateDynamicParameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,3710,4093);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,3847,3987) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,3847,3987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,3908,3972);

throw f_1320_3914_3971("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,3847,3987);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,4003,4082);

return f_1320_4010_4081(commandMetadata, helpComment, generateDynamicParameters);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,3710,4093);

System.Management.Automation.PSArgumentNullException
f_1320_3914_3971(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 3914, 3971);
return return_v;
}


string
f_1320_4010_4081(System.Management.Automation.CommandMetadata
this_param,string
helpComment,bool
generateDynamicParameters)
{
var return_v = this_param.GetProxyCommand( helpComment, generateDynamicParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 4010, 4081);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,3710,4093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,3710,4093);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetCmdletBindingAttribute(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,4693,4997);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,4797,4937) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,4797,4937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,4858,4922);

throw f_1320_4864_4921("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,4797,4937);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,4953,4986);

return f_1320_4960_4985(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,4693,4997);

System.Management.Automation.PSArgumentNullException
f_1320_4864_4921(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 4864, 4921);
return return_v;
}


string
f_1320_4960_4985(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetDecl();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 4960, 4985);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,4693,4997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,4693,4997);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public static string GetParamBlock(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,5669,6060);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,5854,5994) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,5854,5994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,5915,5979);

throw f_1320_5921_5978("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,5854,5994);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,6010,6049);

return f_1320_6017_6048(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,5669,6060);

System.Management.Automation.PSArgumentNullException
f_1320_5921_5978(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 5921, 5978);
return return_v;
}


string
f_1320_6017_6048(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetParamBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 6017, 6048);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,5669,6060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,5669,6060);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetBegin(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,6731,7024);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,6818,6958) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,6818,6958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,6879,6943);

throw f_1320_6885_6942("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,6818,6958);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,6974,7013);

return f_1320_6981_7012(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,6731,7024);

System.Management.Automation.PSArgumentNullException
f_1320_6885_6942(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 6885, 6942);
return return_v;
}


string
f_1320_6981_7012(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetBeginBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 6981, 7012);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,6731,7024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,6731,7024);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetProcess(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,7701,7998);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,7790,7930) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,7790,7930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,7851,7915);

throw f_1320_7857_7914("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,7790,7930);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,7946,7987);

return f_1320_7953_7986(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,7701,7998);

System.Management.Automation.PSArgumentNullException
f_1320_7857_7914(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 7857, 7914);
return return_v;
}


string
f_1320_7953_7986(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetProcessBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 7953, 7986);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,7701,7998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,7701,7998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetDynamicParam(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,8700,9007);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,8794,8934) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,8794,8934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,8855,8919);

throw f_1320_8861_8918("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,8794,8934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,8950,8996);

return f_1320_8957_8995(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,8700,9007);

System.Management.Automation.PSArgumentNullException
f_1320_8861_8918(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 8861, 8918);
return return_v;
}


string
f_1320_8957_8995(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetDynamicParamBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 8957, 8995);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,8700,9007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,8700,9007);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetEnd(CommandMetadata commandMetadata)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,9672,9961);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,9757,9897) || true) && (commandMetadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,9757,9897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,9818,9882);

throw f_1320_9824_9881("commandMetaData");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,9757,9897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,9913,9950);

return f_1320_9920_9949(commandMetadata);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,9672,9961);

System.Management.Automation.PSArgumentNullException
f_1320_9824_9881(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 9824, 9881);
return return_v;
}


string
f_1320_9920_9949(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.GetEndBlock();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 9920, 9949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,9672,9961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,9672,9961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static T GetProperty<T>(PSObject obj, string property) where T : class
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,9973,10292);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10076,10092);

T 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10106,10251) || true) && (obj != null &&(DynAbs.Tracing.TraceSender.Expression_True(1320, 10110, 10157)&&f_1320_10125_10149(f_1320_10125_10139(obj), property)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,10106,10251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10191,10236);

result = f_1320_10200_10230(f_1320_10200_10224(f_1320_10200_10214(obj), property))as T;
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,10106,10251);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10267,10281);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,9973,10292);

System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1320_10125_10139(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 10125, 10139);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1320_10125_10149(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 10125, 10149);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1320_10200_10214(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 10200, 10214);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1320_10200_10224(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 10200, 10224);
return return_v;
}


object
f_1320_10200_10230(System.Management.Automation.PSPropertyInfo
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 10200, 10230);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,9973,10292);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,9973,10292);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetObjText(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,10304,10620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10373,10392);

string 
text = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10408,10441);

PSObject 
psobj = obj as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10455,10563) || true) && (psobj != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,10455,10563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10506,10548);

text = f_1320_10513_10547(psobj, "Text");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,10455,10563);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10579,10609);

return text ??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1320, 10586, 10608)??f_1320_10594_10608(obj));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,10304,10620);

string
f_1320_10513_10547(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<string>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10513, 10547);
return return_v;
}


string?
f_1320_10594_10608(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10594, 10608);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,10304,10620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,10304,10620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void AppendContent(StringBuilder sb, string section, object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,10632,11124);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10736,11113) || true) && (obj != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,10736,11113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10785,10815);

string 
text = f_1320_10799_10814(obj)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10833,11098) || true) && (!f_1320_10838_10864(text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,10833,11098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10906,10922);

f_1320_10906_10921(                    sb, "\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10944,10963);

f_1320_10944_10962(                    sb, section);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,10985,11003);

f_1320_10985_11002(                    sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11025,11041);

f_1320_11025_11040(                    sb, text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11063,11079);

f_1320_11063_11078(                    sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,10833,11098);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,10736,11113);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,10632,11124);

string
f_1320_10799_10814(object
obj)
{
var return_v = GetObjText( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10799, 10814);
return return_v;
}


bool
f_1320_10838_10864(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10838, 10864);
return return_v;
}


System.Text.StringBuilder
f_1320_10906_10921(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10906, 10921);
return return_v;
}


System.Text.StringBuilder
f_1320_10944_10962(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10944, 10962);
return return_v;
}


System.Text.StringBuilder
f_1320_10985_11002(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 10985, 11002);
return return_v;
}


System.Text.StringBuilder
f_1320_11025_11040(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11025, 11040);
return return_v;
}


System.Text.StringBuilder
f_1320_11063_11078(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11063, 11078);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,10632,11124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,10632,11124);
}
		}

private static void AppendContent(StringBuilder sb, string section, PSObject[] array)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,11136,12052);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11246,12041) || true) && (array != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,11246,12041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11297,11315);

bool 
first = true
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11333,11919);
foreach(PSObject obj in f_1320_11358_11363_I(array) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,11333,11919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11405,11435);

string 
text = f_1320_11419_11434(obj)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11457,11900) || true) && (!f_1320_11462_11488(text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,11457,11900);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11538,11791) || true) && (first)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,11538,11791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11605,11619);

first = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11649,11667);

f_1320_11649_11666(                            sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11697,11716);

f_1320_11697_11715(                            sb, section);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11746,11764);

f_1320_11746_11763(                            sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,11538,11791);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11819,11835);

f_1320_11819_11834(
                        sb, text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11861,11877);

f_1320_11861_11876(                        sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,11457,11900);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,11333,11919);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,587);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,587);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11939,12026) || true) && (!first)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,11939,12026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,11991,12007);

f_1320_11991_12006(                    sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,11939,12026);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,11246,12041);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,11136,12052);

string
f_1320_11419_11434(System.Management.Automation.PSObject
obj)
{
var return_v = GetObjText( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11419, 11434);
return return_v;
}


bool
f_1320_11462_11488(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11462, 11488);
return return_v;
}


System.Text.StringBuilder
f_1320_11649_11666(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11649, 11666);
return return_v;
}


System.Text.StringBuilder
f_1320_11697_11715(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11697, 11715);
return return_v;
}


System.Text.StringBuilder
f_1320_11746_11763(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11746, 11763);
return return_v;
}


System.Text.StringBuilder
f_1320_11819_11834(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11819, 11834);
return return_v;
}


System.Text.StringBuilder
f_1320_11861_11876(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11861, 11876);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_11358_11363_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11358, 11363);
return return_v;
}


System.Text.StringBuilder
f_1320_11991_12006(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 11991, 12006);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,11136,12052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,11136,12052);
}
		}

private static void AppendType(StringBuilder sb, string section, PSObject parent)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,12064,12947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12170,12224);

PSObject 
type = f_1320_12186_12223(parent, "type")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12238,12290);

PSObject 
name = f_1320_12254_12289(type, "name")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12304,12936) || true) && (name != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,12304,12936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12354,12372);

f_1320_12354_12371(                sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12390,12409);

f_1320_12390_12408(                sb, section);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12427,12445);

f_1320_12427_12444(                sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12463,12491);

f_1320_12463_12490(                sb, f_1320_12473_12489(name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12509,12525);

f_1320_12509_12524(                sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,12304,12936);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,12304,12936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12591,12641);

PSObject 
uri = f_1320_12606_12640(type, "uri")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12659,12921) || true) && (uri != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,12659,12921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12716,12734);

f_1320_12716_12733(                    sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12756,12775);

f_1320_12756_12774(                    sb, section);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12797,12815);

f_1320_12797_12814(                    sb, "\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12837,12864);

f_1320_12837_12863(                    sb, f_1320_12847_12862(uri));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,12886,12902);

f_1320_12886_12901(                    sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,12659,12921);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,12304,12936);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,12064,12947);

System.Management.Automation.PSObject
f_1320_12186_12223(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12186, 12223);
return return_v;
}


System.Management.Automation.PSObject
f_1320_12254_12289(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12254, 12289);
return return_v;
}


System.Text.StringBuilder
f_1320_12354_12371(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12354, 12371);
return return_v;
}


System.Text.StringBuilder
f_1320_12390_12408(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12390, 12408);
return return_v;
}


System.Text.StringBuilder
f_1320_12427_12444(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12427, 12444);
return return_v;
}


string
f_1320_12473_12489(System.Management.Automation.PSObject
obj)
{
var return_v = GetObjText( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12473, 12489);
return return_v;
}


System.Text.StringBuilder
f_1320_12463_12490(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12463, 12490);
return return_v;
}


System.Text.StringBuilder
f_1320_12509_12524(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12509, 12524);
return return_v;
}


System.Management.Automation.PSObject
f_1320_12606_12640(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12606, 12640);
return return_v;
}


System.Text.StringBuilder
f_1320_12716_12733(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12716, 12733);
return return_v;
}


System.Text.StringBuilder
f_1320_12756_12774(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12756, 12774);
return return_v;
}


System.Text.StringBuilder
f_1320_12797_12814(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12797, 12814);
return return_v;
}


string
f_1320_12847_12862(System.Management.Automation.PSObject
obj)
{
var return_v = GetObjText( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12847, 12862);
return return_v;
}


System.Text.StringBuilder
f_1320_12837_12863(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12837, 12863);
return return_v;
}


System.Text.StringBuilder
f_1320_12886_12901(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 12886, 12901);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,12064,12947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,12064,12947);
}
		}

public static string GetHelpComments(PSObject help)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1320,13535,18796);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13611,13716) || true) && (help == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,13611,13716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13661,13701);

throw f_1320_13667_13700("help");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,13611,13716);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13732,13758);

bool 
isHelpObject = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13772,14013);
foreach(string typeName in f_1320_13800_13822_I(f_1320_13800_13822(help)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,13772,14013);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13856,13998) || true) && (f_1320_13860_13889(typeName, "HelpInfo"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,13856,13998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,13931,13951);

isHelpObject = true;
DynAbs.Tracing.TraceSender.TraceBreak(1320,13973,13979);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,13856,13998);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,13772,14013);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,242);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,242);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14029,14214) || true) && (!isHelpObject)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,14029,14214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14080,14138);

string 
error = f_1320_14095_14137()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14156,14199);

throw f_1320_14162_14198(error);
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,14029,14214);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14230,14269);

StringBuilder 
sb = f_1320_14249_14268()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14285,14355);

f_1320_14285_14354(sb, ".SYNOPSIS", f_1320_14316_14353(help, "Synopsis"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14369,14449);

f_1320_14369_14448(sb, ".DESCRIPTION", f_1320_14403_14447(help, "Description"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14465,14529);

PSObject 
parameters = f_1320_14487_14528(help, "Parameters")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14543,14615);

PSObject[] 
parameter = f_1320_14566_14614(parameters, "Parameter")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14629,15469) || true) && (parameter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,14629,15469);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14684,15454);
foreach(PSObject param in f_1320_14711_14720_I(parameter) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,14684,15454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14762,14815);

PSObject 
name = f_1320_14778_14814(param, "Name")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14837,14908);

PSObject[] 
description = f_1320_14862_14907(param, "Description")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14930,14957);

f_1320_14930_14956(                    sb, "\n.PARAMETER ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,14979,14995);

f_1320_14979_14994(                    sb, name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15017,15035);

f_1320_15017_15034(                    sb, "\n\n");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15057,15435);
foreach(PSObject obj in f_1320_15082_15093_I(description) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15057,15435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15143,15208);

string 
text = f_1320_15157_15189(obj, "Text")??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1320, 15157, 15207)??f_1320_15193_15207(obj))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15234,15412) || true) && (!f_1320_15239_15265(text))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15234,15412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15323,15339);

f_1320_15323_15338(                            sb, text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15369,15385);

f_1320_15369_15384(                            sb, "\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15234,15412);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15057,15435);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,379);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,379);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,14684,15454);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,771);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,771);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,14629,15469);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15485,15545);

PSObject 
examples = f_1320_15505_15544(help, "examples")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15559,15625);

PSObject[] 
example = f_1320_15580_15624(examples, "example")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15639,17218) || true) && (example != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15639,17218);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15692,17203);
foreach(PSObject ex in f_1320_15716_15723_I(example) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15692,17203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15765,15806);

StringBuilder 
exsb = f_1320_15786_15805()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15830,15900);

PSObject[] 
introduction = f_1320_15856_15899(ex, "introduction")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15922,16288) || true) && (introduction != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15922,16288);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,15996,16265);
foreach(PSObject intro in f_1320_16023_16035_I(introduction) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,15996,16265);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16093,16238) || true) && (intro != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,16093,16238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16176,16207);

f_1320_16176_16206(                                exsb, f_1320_16188_16205(intro));
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,16093,16238);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15996,16265);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,270);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,270);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15922,16288);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16312,16362);

PSObject 
code = f_1320_16328_16361(ex, "code")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16384,16502) || true) && (code != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,16384,16502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16450,16479);

f_1320_16450_16478(                        exsb, f_1320_16462_16477(code));
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,16384,16502);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16526,16586);

PSObject[] 
remarks = f_1320_16547_16585(ex, "remarks")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16608,16985) || true) && (remarks != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,16608,16985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16677,16695);

f_1320_16677_16694(                        exsb, "\n");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16721,16962);
foreach(PSObject remark in f_1320_16749_16756_I(remarks) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,16721,16962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16814,16870);

string 
remarkText = f_1320_16834_16869(remark, "text")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,16900,16935);

f_1320_16900_16934(                            exsb, f_1320_16912_16933(remarkText));
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,16721,16962);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,242);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,242);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,16608,16985);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17009,17184) || true) && (f_1320_17013_17024(exsb)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,17009,17184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17078,17108);

f_1320_17078_17107(                        sb, "\n\n.EXAMPLE\n\n");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17134,17161);

f_1320_17134_17160(                        sb, f_1320_17144_17159(exsb));
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,17009,17184);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15692,17203);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,1512);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,1512);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,15639,17218);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17234,17294);

PSObject 
alertSet = f_1320_17254_17293(help, "alertSet")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17308,17380);

f_1320_17308_17379(sb, ".NOTES", f_1320_17336_17378(alertSet, "alert"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17396,17460);

PSObject 
inputtypes = f_1320_17418_17459(help, "inputTypes")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17474,17542);

PSObject 
inputtype = f_1320_17495_17541(inputtypes, "inputType")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17556,17593);

f_1320_17556_17592(sb, ".INPUTS", inputtype);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17609,17677);

PSObject 
returnValues = f_1320_17633_17676(help, "returnValues")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17691,17765);

PSObject 
returnValue = f_1320_17714_17764(returnValues, "returnValue")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17779,17819);

f_1320_17779_17818(sb, ".OUTPUTS", returnValue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17835,17903);

PSObject 
relatedLinks = f_1320_17859_17902(help, "relatedLinks")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,17917,18001);

PSObject[] 
navigationLink = f_1320_17945_18000(relatedLinks, "navigationLink")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18015,18484) || true) && (navigationLink != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,18015,18484);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18075,18469);
foreach(PSObject link in f_1320_18101_18115_I(navigationLink) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1320,18075,18469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18297,18360);

f_1320_18297_18359(sb, ".LINK", f_1320_18324_18358(link, "uri"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18382,18450);

f_1320_18382_18449(sb, ".LINK", f_1320_18409_18448(link, "linkText"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1320,18075,18469);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1320,1,395);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1320,1,395);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1320,18015,18484);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18500,18574);

f_1320_18500_18573(sb, ".COMPONENT", f_1320_18532_18572(help, "Component"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18588,18652);

f_1320_18588_18651(sb, ".ROLE", f_1320_18615_18650(help, "Role"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18666,18748);

f_1320_18666_18747(sb, ".FUNCTIONALITY", f_1320_18702_18746(help, "Functionality"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1320,18764,18785);

return f_1320_18771_18784(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1320,13535,18796);

System.ArgumentNullException
f_1320_13667_13700(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 13667, 13700);
return return_v;
}


System.Management.Automation.Runspaces.ConsolidatedString
f_1320_13800_13822(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.InternalTypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 13800, 13822);
return return_v;
}


bool
f_1320_13860_13889(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 13860, 13889);
return return_v;
}


System.Management.Automation.Runspaces.ConsolidatedString
f_1320_13800_13822_I(System.Management.Automation.Runspaces.ConsolidatedString
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 13800, 13822);
return return_v;
}


string
f_1320_14095_14137()
{
var return_v = ProxyCommandStrings.HelpInfoObjectRequired;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 14095, 14137);
return return_v;
}


System.InvalidOperationException
f_1320_14162_14198(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14162, 14198);
return return_v;
}


System.Text.StringBuilder
f_1320_14249_14268()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14249, 14268);
return return_v;
}


string
f_1320_14316_14353(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<string>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14316, 14353);
return return_v;
}


int
f_1320_14285_14354(System.Text.StringBuilder
sb,string
section,string
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14285, 14354);
return 0;
}


System.Management.Automation.PSObject[]
f_1320_14403_14447(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14403, 14447);
return return_v;
}


int
f_1320_14369_14448(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject[]
array)
{
AppendContent( sb, section, array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14369, 14448);
return 0;
}


System.Management.Automation.PSObject
f_1320_14487_14528(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14487, 14528);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_14566_14614(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14566, 14614);
return return_v;
}


System.Management.Automation.PSObject
f_1320_14778_14814(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14778, 14814);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_14862_14907(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14862, 14907);
return return_v;
}


System.Text.StringBuilder
f_1320_14930_14956(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14930, 14956);
return return_v;
}


System.Text.StringBuilder
f_1320_14979_14994(System.Text.StringBuilder
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Append( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14979, 14994);
return return_v;
}


System.Text.StringBuilder
f_1320_15017_15034(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15017, 15034);
return return_v;
}


string
f_1320_15157_15189(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<string>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15157, 15189);
return return_v;
}


string
f_1320_15193_15207(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15193, 15207);
return return_v;
}


bool
f_1320_15239_15265(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15239, 15265);
return return_v;
}


System.Text.StringBuilder
f_1320_15323_15338(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15323, 15338);
return return_v;
}


System.Text.StringBuilder
f_1320_15369_15384(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15369, 15384);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_15082_15093_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15082, 15093);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_14711_14720_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 14711, 14720);
return return_v;
}


System.Management.Automation.PSObject
f_1320_15505_15544(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15505, 15544);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_15580_15624(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15580, 15624);
return return_v;
}


System.Text.StringBuilder
f_1320_15786_15805()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15786, 15805);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_15856_15899(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15856, 15899);
return return_v;
}


string
f_1320_16188_16205(System.Management.Automation.PSObject
obj)
{
var return_v = GetObjText( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16188, 16205);
return return_v;
}


System.Text.StringBuilder
f_1320_16176_16206(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16176, 16206);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_16023_16035_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16023, 16035);
return return_v;
}


System.Management.Automation.PSObject
f_1320_16328_16361(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16328, 16361);
return return_v;
}


string
f_1320_16462_16477(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16462, 16477);
return return_v;
}


System.Text.StringBuilder
f_1320_16450_16478(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16450, 16478);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_16547_16585(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16547, 16585);
return return_v;
}


System.Text.StringBuilder
f_1320_16677_16694(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16677, 16694);
return return_v;
}


string
f_1320_16834_16869(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<string>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16834, 16869);
return return_v;
}


string
f_1320_16912_16933(string
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16912, 16933);
return return_v;
}


System.Text.StringBuilder
f_1320_16900_16934(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16900, 16934);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_16749_16756_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 16749, 16756);
return return_v;
}


int
f_1320_17013_17024(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1320, 17013, 17024);
return return_v;
}


System.Text.StringBuilder
f_1320_17078_17107(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17078, 17107);
return return_v;
}


string
f_1320_17144_17159(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17144, 17159);
return return_v;
}


System.Text.StringBuilder
f_1320_17134_17160(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17134, 17160);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_15716_15723_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 15716, 15723);
return return_v;
}


System.Management.Automation.PSObject
f_1320_17254_17293(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17254, 17293);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_17336_17378(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17336, 17378);
return return_v;
}


int
f_1320_17308_17379(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject[]
array)
{
AppendContent( sb, section, array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17308, 17379);
return 0;
}


System.Management.Automation.PSObject
f_1320_17418_17459(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17418, 17459);
return return_v;
}


System.Management.Automation.PSObject
f_1320_17495_17541(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17495, 17541);
return return_v;
}


int
f_1320_17556_17592(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
parent)
{
AppendType( sb, section, parent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17556, 17592);
return 0;
}


System.Management.Automation.PSObject
f_1320_17633_17676(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17633, 17676);
return return_v;
}


System.Management.Automation.PSObject
f_1320_17714_17764(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17714, 17764);
return return_v;
}


int
f_1320_17779_17818(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
parent)
{
AppendType( sb, section, parent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17779, 17818);
return 0;
}


System.Management.Automation.PSObject
f_1320_17859_17902(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17859, 17902);
return return_v;
}


System.Management.Automation.PSObject[]
f_1320_17945_18000(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject[]>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 17945, 18000);
return return_v;
}


System.Management.Automation.PSObject
f_1320_18324_18358(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18324, 18358);
return return_v;
}


int
f_1320_18297_18359(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18297, 18359);
return 0;
}


System.Management.Automation.PSObject
f_1320_18409_18448(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18409, 18448);
return return_v;
}


int
f_1320_18382_18449(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18382, 18449);
return 0;
}


System.Management.Automation.PSObject[]
f_1320_18101_18115_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18101, 18115);
return return_v;
}


System.Management.Automation.PSObject
f_1320_18532_18572(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18532, 18572);
return return_v;
}


int
f_1320_18500_18573(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18500, 18573);
return 0;
}


System.Management.Automation.PSObject
f_1320_18615_18650(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18615, 18650);
return return_v;
}


int
f_1320_18588_18651(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18588, 18651);
return 0;
}


System.Management.Automation.PSObject
f_1320_18702_18746(System.Management.Automation.PSObject
obj,string
property)
{
var return_v = GetProperty<PSObject>( obj, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18702, 18746);
return return_v;
}


int
f_1320_18666_18747(System.Text.StringBuilder
sb,string
section,System.Management.Automation.PSObject
obj)
{
AppendContent( sb, section, (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18666, 18747);
return 0;
}


string
f_1320_18771_18784(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1320, 18771, 18784);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1320,13535,18796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,13535,18796);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ProxyCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1320,331,18825);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1320,331,18825);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1320,331,18825);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1320,331,18825);
}
}
