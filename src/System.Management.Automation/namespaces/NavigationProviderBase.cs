// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Text;

namespace System.Management.Automation.Provider
{
public abstract class NavigationCmdletProvider : ContainerCmdletProvider
{
internal string MakePath(
            string parent,
            string child,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,2813,3076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,2962,2980);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,3034,3065);

return f_1204_3041_3064(this, parent, child);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,2813,3076);

string
f_1204_3041_3064(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 3041, 3064);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,2813,3076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,2813,3076);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetParentPath(
            string path,
            string root,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,4462,4729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,4613,4631);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,4685,4718);

return f_1204_4692_4717(this, path, root);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,4462,4729);

string
f_1204_4692_4717(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 4692, 4717);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,4462,4729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,4462,4729);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string NormalizeRelativePath(
            string path,
            string basePath,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,6063,6354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,6226,6244);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,6298,6343);

return f_1204_6305_6342(this, path, basePath);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,6063,6354);

string
f_1204_6305_6342(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
basePath)
{
var return_v = this_param.NormalizeRelativePath( path, basePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 6305, 6342);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,6063,6354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,6063,6354);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string GetChildName(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,7347,7580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,7471,7489);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,7543,7569);

return f_1204_7550_7568(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,7347,7580);

string
f_1204_7550_7568(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 7550, 7568);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,7347,7580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,7347,7580);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsItemContainer(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,8243,8480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,8368,8386);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,8440,8469);

return f_1204_8447_8468(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,8243,8480);

bool
f_1204_8447_8468(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.IsItemContainer( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 8447, 8468);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,8243,8480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,8243,8480);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void MoveItem(
            string path,
            string destination,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,9241,9503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,9392,9410);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,9464,9492);

f_1204_9464_9491(this, path, destination);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,9241,9503);

int
f_1204_9464_9491(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
destination)
{
this_param.MoveItem( path, destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 9464, 9491);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,9241,9503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,9241,9503);
}
		}

internal object MoveItemDynamicParameters(
            string path,
            string destination,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,10269,10534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,10439,10457);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,10471,10523);

return f_1204_10478_10522(this, path, destination);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,10269,10534);

object
f_1204_10478_10522(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
destination)
{
var return_v = this_param.MoveItemDynamicParameters( path, destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 10478, 10522);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,10269,10534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,10269,10534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual string MakePath(string parent, string child)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,12194,12343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,12281,12332);

return f_1204_12288_12331(this, parent, child, childIsLeaf: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,12194,12343);

string
f_1204_12288_12331(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child,bool
childIsLeaf)
{
var return_v = this_param.MakePath( parent, child, childIsLeaf: childIsLeaf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 12288, 12331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,12194,12343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,12194,12343);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected string MakePath(string parent, string child, bool childIsLeaf)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,13191,15909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13288,15898);
using(f_1204_13295_13342())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13376,13397);

string 
result = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13417,13591) || true) && (parent == null &&(DynAbs.Tracing.TraceSender.Expression_True(1204, 13421, 13473)&&                    child == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,13417,13591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13515,13572);

throw f_1204_13521_13571(nameof(parent));
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,13417,13591);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13611,15849) || true) && (f_1204_13615_13643(parent)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 13615, 13695)&&f_1204_13668_13695(child)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,13611,15849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13737,13759);

result = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,13611,15849);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,13611,15849);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13801,15849) || true) && (f_1204_13805_13833(parent)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 13805, 13891)&&                         !f_1204_13864_13891(child)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,13801,15849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,13933,13963);

result = f_1204_13942_13962(this, child);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,13801,15849);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,13801,15849);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,14005,15849) || true) && (!f_1204_14010_14038(parent)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 14009, 14323)&&                         (f_1204_14069_14096(child)||(DynAbs.Tracing.TraceSender.Expression_False(1204, 14069, 14208)||f_1204_14127_14208(                          child, StringLiterals.DefaultPathSeparatorString, StringComparison.Ordinal))||(DynAbs.Tracing.TraceSender.Expression_False(1204, 14069, 14322)||f_1204_14239_14322(                          child, StringLiterals.AlternatePathSeparatorString, StringComparison.Ordinal)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,14005,15849);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,14365,14662) || true) && (f_1204_14369_14421(parent, StringLiterals.DefaultPathSeparator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,14365,14662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,14471,14487);

result = parent;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,14365,14662);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,14365,14662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,14585,14639);

result = parent + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1204,14603,14638);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,14365,14662);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,14005,15849);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,14005,15849);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15010,15495) || true) && (childIsLeaf)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,15010,15495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15075,15106);

parent = f_1204_15084_15105(this, parent);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,15010,15495);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,15010,15495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15386,15417);

parent = f_1204_15395_15416(this, parent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15443,15472);

child = f_1204_15451_15471(this, child);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,15010,15495);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15519,15567);

ReadOnlySpan<char> 
appendChild = f_1204_15552_15566(child)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15589,15754) || true) && (f_1204_15593_15646(child, StringLiterals.DefaultPathSeparator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,15589,15754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15696,15731);

appendChild = appendChild.Slice(1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,15589,15754);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15778,15830);

result = f_1204_15787_15829(f_1204_15800_15815(parent), appendChild);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,14005,15849);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,13801,15849);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,13611,15849);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,15869,15883);

return result;
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,13288,15898);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,13191,15909);

System.IDisposable
f_1204_13295_13342()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13295, 13342);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1204_13521_13571(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13521, 13571);
return return_v;
}


bool
f_1204_13615_13643(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13615, 13643);
return return_v;
}


bool
f_1204_13668_13695(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13668, 13695);
return return_v;
}


bool
f_1204_13805_13833(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13805, 13833);
return return_v;
}


bool
f_1204_13864_13891(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13864, 13891);
return return_v;
}


string
f_1204_13942_13962(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 13942, 13962);
return return_v;
}


bool
f_1204_14010_14038(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 14010, 14038);
return return_v;
}


bool
f_1204_14069_14096(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 14069, 14096);
return return_v;
}


bool
f_1204_14127_14208(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 14127, 14208);
return return_v;
}


bool
f_1204_14239_14322(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 14239, 14322);
return return_v;
}


bool
f_1204_14369_14421(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 14369, 14421);
return return_v;
}


string
f_1204_15084_15105(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15084, 15105);
return return_v;
}


string
f_1204_15395_15416(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15395, 15416);
return return_v;
}


string
f_1204_15451_15471(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15451, 15471);
return return_v;
}


System.ReadOnlySpan<char>
f_1204_15552_15566(string
text)
{
var return_v = text.AsSpan();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15552, 15566);
return return_v;
}


bool
f_1204_15593_15646(string
this_param,char
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15593, 15646);
return return_v;
}


System.ReadOnlySpan<char>
f_1204_15800_15815(string
text)
{
var return_v = text.AsSpan();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15800, 15815);
return return_v;
}


string
f_1204_15787_15829(System.ReadOnlySpan<char>
path1,System.ReadOnlySpan<char>
path2)
{
var return_v = IO.Path.Join( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 15787, 15829);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,13191,15909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,13191,15909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual string GetParentPath(string path, string root)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,17049,19061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17138,19050);
using(f_1204_17145_17192())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17226,17251);

string 
parentPath = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17315,17455) || true) && (f_1204_17319_17345(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,17315,17455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17387,17436);

throw f_1204_17393_17435("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,17315,17455);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17475,17672) || true) && (root == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,17475,17672);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17533,17653) || true) && (f_1204_17537_17548()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,17533,17653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17606,17630);

root = f_1204_17613_17629(f_1204_17613_17624());
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,17533,17653);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,17475,17672);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17733,17760);

path = f_1204_17740_17759(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17778,17835);

path = f_1204_17785_17834(path, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17853,17884);

string 
rootPath = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17904,18012) || true) && (root != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,17904,18012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,17962,17993);

rootPath = f_1204_17973_17992(this, root);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,17904,18012);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18141,18997) || true) && (f_1204_18145_18275(path, rootPath, StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,18141,18997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18322,18348);

parentPath = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,18141,18997);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,18141,18997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18430,18500);

int 
lastIndex = f_1204_18446_18499(path, StringLiterals.DefaultPathSeparator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18524,18978) || true) && (lastIndex != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,18524,18978);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18593,18708) || true) && (lastIndex == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,18593,18708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18669,18681);

++lastIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,18593,18708);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18789,18831);

parentPath = f_1204_18802_18830(path, 0, lastIndex);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,18524,18978);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,18524,18978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,18929,18955);

parentPath = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,18524,18978);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,18141,18997);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,19017,19035);

return parentPath;
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,17138,19050);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,17049,19061);

System.IDisposable
f_1204_17145_17192()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17145, 17192);
return return_v;
}


bool
f_1204_17319_17345(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17319, 17345);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1204_17393_17435(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17393, 17435);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1204_17537_17548()
{
var return_v = PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 17537, 17548);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1204_17613_17624()
{
var return_v = PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 17613, 17624);
return return_v;
}


string
f_1204_17613_17629(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 17613, 17629);
return return_v;
}


string
f_1204_17740_17759(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17740, 17759);
return return_v;
}


string
f_1204_17785_17834(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17785, 17834);
return return_v;
}


string
f_1204_17973_17992(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 17973, 17992);
return return_v;
}


int
f_1204_18145_18275(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 18145, 18275);
return return_v;
}


int
f_1204_18446_18499(string
this_param,char
value)
{
var return_v = this_param.LastIndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 18446, 18499);
return return_v;
}


string
f_1204_18802_18830(string
this_param,int
startIndex,int
length)
{
var return_v = this_param.Substring( startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 18802, 18830);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,17049,19061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,17049,19061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual string NormalizeRelativePath(
            string path,
            string basePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,20475,20777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,20603,20766);
using(f_1204_20610_20657())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,20691,20751);

return f_1204_20698_20750(this, path, basePath, false, f_1204_20742_20749());
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,20603,20766);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,20475,20777);

System.IDisposable
f_1204_20610_20657()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 20610, 20657);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1204_20742_20749()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 20742, 20749);
return return_v;
}


string
f_1204_20698_20750(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
basePath,bool
allowNonExistingPaths,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ContractRelativePath( path, basePath, allowNonExistingPaths, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 20698, 20750);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,20475,20777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,20475,20777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string ContractRelativePath(
            string path,
            string basePath,
            bool allowNonExistingPaths,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,20789,28071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,20992,21010);

Context = context;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21026,21144) || true) && (path == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,21026,21144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21076,21129);

throw f_1204_21082_21128("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,21026,21144);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21160,21249) || true) && (f_1204_21164_21175(path)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,21160,21249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21214,21234);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,21160,21249);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21265,21358) || true) && (basePath == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,21265,21358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21319,21343);

basePath = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,21265,21358);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21374,21431);

f_1204_21374_21430(
            providerBaseTracer, "basePath = {0}", basePath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21447,21468);

string 
result = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21482,21524);

bool 
originalPathHadTrailingSlash = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21540,21569);

string 
normalizedPath = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,21583,21620);

string 
normalizedBasePath = basePath
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,22726,23051) || true) && (!f_1204_22731_22902(f_1204_22745_22791(f_1204_22745_22782(f_1204_22745_22769(context))), @"Microsoft.ActiveDirectory.Management\ActiveDirectory", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,22726,23051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,22936,22973);

normalizedPath = f_1204_22953_22972(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,22991,23036);

normalizedBasePath = f_1204_23012_23035(this, basePath);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,22726,23051);
}
{try {
do // false loop

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,23067,27879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23204,23231);

string 
originalPath = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23249,23289);

Stack<string> 
tokenizedPathStack = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23309,23539) || true) && (f_1204_23313_23363(path, StringLiterals.DefaultPathSeparator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,23309,23539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23405,23462);

path = f_1204_23412_23461(path, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23484,23520);

originalPathHadTrailingSlash = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,23309,23539);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23559,23624);

basePath = f_1204_23570_23623(basePath, StringLiterals.DefaultPathSeparator);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23822,24181) || true) && (f_1204_23826_23911(normalizedPath, normalizedBasePath, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 23826, 23997)&&                    (!f_1204_23938_23996(originalPath, StringLiterals.DefaultPathSeparator))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,23822,24181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24039,24077);

string 
childName = f_1204_24058_24076(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24099,24134);

result = f_1204_24108_24133(this, "..", childName);
DynAbs.Tracing.TraceSender.TraceBreak(1204,24156,24162);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,23822,24181);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24332,27849) || true) && (!f_1204_24337_24418(normalizedPath, normalizedBasePath, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 24336, 24464)&&                    (f_1204_24444_24459(basePath)> 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,24332,27849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24506,24528);

result = string.Empty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24550,24620);

string 
commonBase = f_1204_24570_24619(this, normalizedPath, normalizedBasePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24644,24734);

Stack<string> 
parentNavigationStack = f_1204_24682_24733(this, normalizedBasePath, commonBase)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24756,24805);

int 
parentPopCount = f_1204_24777_24804(parentNavigationStack)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24829,24955) || true) && (f_1204_24833_24865(commonBase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,24829,24955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24915,24932);

parentPopCount--;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,24829,24955);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24988,25003);

                    for (int 
leafCounter = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,24979,25153) || true) && (leafCounter < parentPopCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,25035,25048)
,leafCounter++,DynAbs.Tracing.TraceSender.TraceExitCondition(1204,24979,25153))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,24979,25153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,25098,25130);

result = f_1204_25107_25129(this, "..", result);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,1,175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,1,175);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,25714,26729) || true) && (!f_1204_25719_25751(commonBase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,25714,26729);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,25801,26706) || true) && (f_1204_25805_25882(normalizedPath, commonBase, StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 25805, 25978)&&                            (!f_1204_25917_25977(normalizedPath, StringLiterals.DefaultPathSeparator))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,25801,26706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26036,26074);

string 
childName = f_1204_26055_26073(this, path)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26104,26136);

result = f_1204_26113_26135(this, "..", result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26166,26203);

result = f_1204_26175_26202(this, result, childName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,25801,26706);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,25801,26706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26317,26407);

string[] 
childNavigationItems = f_1204_26349_26406(f_1204_26349_26396(this, normalizedPath, commonBase))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26448,26463);

                            for (int 
leafCounter = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26439,26679) || true) && (leafCounter < f_1204_26479_26506(childNavigationItems))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26508,26521)
,leafCounter++,DynAbs.Tracing.TraceSender.TraceExitCondition(1204,26439,26679))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,26439,26679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26587,26648);

result = f_1204_26596_26647(this, result, childNavigationItems[leafCounter]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,1,241);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,1,241);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1204,25801,26706);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,25714,26729);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,24332,27849);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,24332,27849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,26887,26944);

tokenizedPathStack = f_1204_26908_26943(this, path, basePath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27088,27122);

Stack<string> 
normalizedPathStack
=default(Stack<string>);

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27198,27296);

normalizedPathStack = f_1204_27220_27295(tokenizedPathStack, path, basePath, allowNonExistingPaths);
                    }
                    catch (ArgumentException argumentException)
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1204,27341,27650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27433,27555);

f_1204_27433_27554(this, f_1204_27444_27553(argumentException, f_1204_27479_27515(f_1204_27479_27506(argumentException)), ErrorCategory.InvalidArgument, null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27581,27595);

result = null;
DynAbs.Tracing.TraceSender.TraceBreak(1204,27621,27627);

break;
DynAbs.Tracing.TraceSender.TraceExitCatch(1204,27341,27650);
                    }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27762,27830);

result = f_1204_27771_27829(this, normalizedPathStack);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,24332,27849);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,23067,27879);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,23067,27879) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,23067,27879);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,23067,27879);
}}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27895,28030) || true) && (originalPathHadTrailingSlash)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,27895,28030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,27961,28015);

result = result + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (StringLiterals.DefaultPathSeparator).ToString(),1204,27979,28014);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,27895,28030);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28046,28060);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,20789,28071);

System.Management.Automation.PSArgumentNullException
f_1204_21082_21128(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 21082, 21128);
return return_v;
}


int
f_1204_21164_21175(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 21164, 21175);
return return_v;
}


int
f_1204_21374_21430(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 21374, 21430);
return 0;
}


System.Management.Automation.Provider.CmdletProvider
f_1204_22745_22769(System.Management.Automation.CmdletProviderContext
this_param)
{
var return_v = this_param.ProviderInstance;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 22745, 22769);
return return_v;
}


System.Management.Automation.ProviderInfo
f_1204_22745_22782(System.Management.Automation.Provider.CmdletProvider
this_param)
{
var return_v = this_param.ProviderInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 22745, 22782);
return return_v;
}


string
f_1204_22745_22791(System.Management.Automation.ProviderInfo
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 22745, 22791);
return return_v;
}


bool
f_1204_22731_22902(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 22731, 22902);
return return_v;
}


string
f_1204_22953_22972(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 22953, 22972);
return return_v;
}


string
f_1204_23012_23035(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23012, 23035);
return return_v;
}


bool
f_1204_23313_23363(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23313, 23363);
return return_v;
}


string
f_1204_23412_23461(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23412, 23461);
return return_v;
}


string
f_1204_23570_23623(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23570, 23623);
return return_v;
}


bool
f_1204_23826_23911(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23826, 23911);
return return_v;
}


bool
f_1204_23938_23996(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 23938, 23996);
return return_v;
}


string
f_1204_24058_24076(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24058, 24076);
return return_v;
}


string
f_1204_24108_24133(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24108, 24133);
return return_v;
}


bool
f_1204_24337_24418(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24337, 24418);
return return_v;
}


int
f_1204_24444_24459(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 24444, 24459);
return return_v;
}


string
f_1204_24570_24619(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path1,string
path2)
{
var return_v = this_param.GetCommonBase( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24570, 24619);
return return_v;
}


System.Collections.Generic.Stack<string>
f_1204_24682_24733(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
basePath)
{
var return_v = this_param.TokenizePathToStack( path, basePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24682, 24733);
return return_v;
}


int
f_1204_24777_24804(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 24777, 24804);
return return_v;
}


bool
f_1204_24833_24865(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 24833, 24865);
return return_v;
}


string
f_1204_25107_25129(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 25107, 25129);
return return_v;
}


bool
f_1204_25719_25751(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 25719, 25751);
return return_v;
}


bool
f_1204_25805_25882(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 25805, 25882);
return return_v;
}


bool
f_1204_25917_25977(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 25917, 25977);
return return_v;
}


string
f_1204_26055_26073(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26055, 26073);
return return_v;
}


string
f_1204_26113_26135(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26113, 26135);
return return_v;
}


string
f_1204_26175_26202(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26175, 26202);
return return_v;
}


System.Collections.Generic.Stack<string>
f_1204_26349_26396(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
basePath)
{
var return_v = this_param.TokenizePathToStack( path, basePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26349, 26396);
return return_v;
}


string[]
f_1204_26349_26406(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26349, 26406);
return return_v;
}


int
f_1204_26479_26506(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 26479, 26506);
return return_v;
}


string
f_1204_26596_26647(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26596, 26647);
return return_v;
}


System.Collections.Generic.Stack<string>
f_1204_26908_26943(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
basePath)
{
var return_v = this_param.TokenizePathToStack( path, basePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 26908, 26943);
return return_v;
}


System.Collections.Generic.Stack<string>
f_1204_27220_27295(System.Collections.Generic.Stack<string>
tokenizedPathStack,string
path,string
basePath,bool
allowNonExistingPaths)
{
var return_v = NormalizeThePath( tokenizedPathStack, path, basePath, allowNonExistingPaths);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 27220, 27295);
return return_v;
}


System.Type
f_1204_27479_27506(System.ArgumentException
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 27479, 27506);
return return_v;
}


string
f_1204_27479_27515(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 27479, 27515);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1204_27444_27553(System.ArgumentException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 27444, 27553);
return return_v;
}


int
f_1204_27433_27554(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,System.Management.Automation.ErrorRecord
errorRecord)
{
this_param.WriteError( errorRecord);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 27433, 27554);
return 0;
}


string
f_1204_27771_27829(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,System.Collections.Generic.Stack<string>
normalizedPathStack)
{
var return_v = this_param.CreateNormalizedRelativePathFromStack( normalizedPathStack);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 27771, 27829);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,20789,28071);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,20789,28071);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetCommonBase(string path1, string path2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,28288,28960);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28556,28920) || true) && (!f_1204_28564_28627(path1, path2, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,28556,28920);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28661,28905) || true) && (f_1204_28665_28677(path2)> f_1204_28680_28692(path1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,28661,28905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28734,28769);

path2 = f_1204_28742_28768(this, path2, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,28661,28905);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,28661,28905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28851,28886);

path1 = f_1204_28859_28885(this, path1, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,28661,28905);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,28556,28920);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,28556,28920);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,28556,28920);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,28936,28949);

return path1;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,28288,28960);

bool
f_1204_28564_28627(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 28564, 28627);
return return_v;
}


int
f_1204_28665_28677(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 28665, 28677);
return return_v;
}


int
f_1204_28680_28692(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 28680, 28692);
return return_v;
}


string
f_1204_28742_28768(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 28742, 28768);
return return_v;
}


string
f_1204_28859_28885(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 28859, 28885);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,28288,28960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,28288,28960);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual string GetChildName(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,29674,31957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,29749,31946);
using(f_1204_29756_29803())            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,29881,30021) || true) && (f_1204_29885_29911(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,29881,30021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,29953,30002);

throw f_1204_29959_30001("path");
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,29881,30021);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30080,30107);

path = f_1204_30087_30106(this, path);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30172,30229);

path = f_1204_30179_30228(path, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30247,30268);

string 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30288,30363);

int 
separatorIndex = f_1204_30309_30362(path, StringLiterals.DefaultPathSeparator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30460,31897) || true) && (separatorIndex == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30460,31897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30526,30540);

result = path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30460,31897);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30460,31897);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30674,31897) || true) && (f_1204_30678_30703(this, path, f_1204_30695_30702()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30674,31897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30745,30791);

string 
parentPath = f_1204_30765_30790(this, path, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30873,31701) || true) && (f_1204_30877_30909(parentPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30873,31701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,30936,30950);

result = path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30873,31701);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30873,31701);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31112,31701) || true) && (f_1204_31116_31171(parentPath, StringLiterals.DefaultPathSeparator)== (f_1204_31176_31193(parentPath)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,31112,31701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31248,31346);

separatorIndex = f_1204_31265_31325(path, parentPath, StringComparison.OrdinalIgnoreCase)+ f_1204_31328_31345(parentPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31372,31412);

result = f_1204_31381_31411(path, separatorIndex);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,31112,31701);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,31112,31701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31510,31608);

separatorIndex = f_1204_31527_31587(path, parentPath, StringComparison.OrdinalIgnoreCase)+ f_1204_31590_31607(parentPath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31634,31678);

result = f_1204_31643_31677(path, separatorIndex + 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,31112,31701);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30873,31701);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30674,31897);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,30674,31897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31834,31878);

result = f_1204_31843_31877(path, separatorIndex + 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30674,31897);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,30460,31897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,31917,31931);

return result;
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,29749,31946);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,29674,31957);

System.IDisposable
f_1204_29756_29803()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 29756, 29803);
return return_v;
}


bool
f_1204_29885_29911(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 29885, 29911);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1204_29959_30001(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 29959, 30001);
return return_v;
}


string
f_1204_30087_30106(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.NormalizePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30087, 30106);
return return_v;
}


string
f_1204_30179_30228(string
this_param,char
trimChar)
{
var return_v = this_param.TrimEnd( trimChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30179, 30228);
return return_v;
}


int
f_1204_30309_30362(string
this_param,char
value)
{
var return_v = this_param.LastIndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30309, 30362);
return return_v;
}


System.Management.Automation.CmdletProviderContext
f_1204_30695_30702()
{
var return_v = Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 30695, 30702);
return return_v;
}


bool
f_1204_30678_30703(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,System.Management.Automation.CmdletProviderContext
context)
{
var return_v = this_param.ItemExists( path, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30678, 30703);
return return_v;
}


string
f_1204_30765_30790(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30765, 30790);
return return_v;
}


bool
f_1204_30877_30909(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 30877, 30909);
return return_v;
}


int
f_1204_31116_31171(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31116, 31171);
return return_v;
}


int
f_1204_31176_31193(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 31176, 31193);
return return_v;
}


int
f_1204_31265_31325(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31265, 31325);
return return_v;
}


int
f_1204_31328_31345(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 31328, 31345);
return return_v;
}


string
f_1204_31381_31411(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31381, 31411);
return return_v;
}


int
f_1204_31527_31587(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31527, 31587);
return return_v;
}


int
f_1204_31590_31607(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 31590, 31607);
return return_v;
}


string
f_1204_31643_31677(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31643, 31677);
return return_v;
}


string
f_1204_31843_31877(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 31843, 31877);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,29674,31957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,29674,31957);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual bool IsItemContainer(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,33027,33358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,33103,33347);
using(f_1204_33110_33157())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,33191,33332);

throw
f_1204_33218_33331(f_1204_33283_33330());
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,33103,33347);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,33027,33358);

System.IDisposable
f_1204_33110_33157()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 33110, 33157);
return return_v;
}


string
f_1204_33283_33330()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 33283, 33330);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1204_33218_33331(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 33218, 33331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,33027,33358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,33027,33358);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void MoveItem(
            string path,
            string destination)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,35093,35464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,35209,35453);
using(f_1204_35216_35263())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,35297,35438);

throw
f_1204_35324_35437(f_1204_35389_35436());
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,35209,35453);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,35093,35464);

System.IDisposable
f_1204_35216_35263()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 35216, 35263);
return return_v;
}


string
f_1204_35389_35436()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 35389, 35436);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1204_35324_35437(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 35324, 35437);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,35093,35464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,35093,35464);
}
		}

protected virtual object MoveItemDynamicParameters(
            string path,
            string destination)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,36349,36610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,36484,36599);
using(f_1204_36491_36538())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,36572,36584);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1204,36484,36599);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,36349,36610);

System.IDisposable
f_1204_36491_36538()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 36491, 36538);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,36349,36610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,36349,36610);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string NormalizePath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,37162,39100);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,37557,37679) || true) && (f_1204_37561_37612(path, StringLiterals.AlternatePathSeparator)== -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,37557,37679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,37652,37664);

return path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,37557,37679);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,37695,37775);

bool 
pathHasBackSlash = f_1204_37719_37768(path, StringLiterals.DefaultPathSeparator)!= -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,37789,37811);

string 
normalizedPath
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38014,38929) || true) && (pathHasBackSlash &&(DynAbs.Tracing.TraceSender.Expression_True(1204, 38018, 38058)&&f_1204_38038_38058(this, path))&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 38018, 38078)&&f_1204_38062_38078(this, path)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,38014,38929);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38431,38560) || true) && (f_1204_38435_38487(path, StringLiterals.AlternatePathSeparator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,38431,38560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38529,38541);

return path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,38431,38560);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38580,38686);

normalizedPath = f_1204_38597_38685(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38706,38914) || true) && (!f_1204_38711_38737(this, normalizedPath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,38706,38914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38779,38791);

return path;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,38706,38914);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,38706,38914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38873,38895);

return normalizedPath;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,38706,38914);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,38014,38929);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,38945,39051);

normalizedPath = f_1204_38962_39050(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39067,39089);

return normalizedPath;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,37162,39100);

int
f_1204_37561_37612(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 37561, 37612);
return return_v;
}


int
f_1204_37719_37768(string
this_param,char
value)
{
var return_v = this_param.IndexOf( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 37719, 37768);
return return_v;
}


bool
f_1204_38038_38058(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.IsAbsolutePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38038, 38058);
return return_v;
}


bool
f_1204_38062_38078(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38062, 38078);
return return_v;
}


bool
f_1204_38435_38487(string
this_param,char
value)
{
var return_v = this_param.EndsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38435, 38487);
return return_v;
}


string
f_1204_38597_38685(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38597, 38685);
return return_v;
}


bool
f_1204_38711_38737(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38711, 38737);
return return_v;
}


string
f_1204_38962_39050(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 38962, 39050);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,37162,39100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,37162,39100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsAbsolutePath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,39284,39787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39349,39369);

bool 
result = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39385,39746) || true) && (f_1204_39389_39425(path))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,39385,39746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39459,39473);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,39385,39746);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,39385,39746);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39507,39746) || true) && (f_1204_39511_39527(this)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1204, 39511, 39583)&&!f_1204_39540_39583(f_1204_39561_39582(f_1204_39561_39577(this))))&&(DynAbs.Tracing.TraceSender.Expression_True(1204, 39511, 39683)&&f_1204_39609_39683(                     path, f_1204_39625_39646(f_1204_39625_39641(this)), StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,39507,39746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39717,39731);

result = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,39507,39746);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,39385,39746);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,39762,39776);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,39284,39787);

bool
f_1204_39389_39425(string
path)
{
var return_v = LocationGlobber.IsAbsolutePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 39389, 39425);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1204_39511_39527(System.Management.Automation.Provider.NavigationCmdletProvider
this_param)
{
var return_v = this_param.PSDriveInfo ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 39511, 39527);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1204_39561_39577(System.Management.Automation.Provider.NavigationCmdletProvider
this_param)
{
var return_v = this_param.PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 39561, 39577);
return return_v;
}


string
f_1204_39561_39582(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 39561, 39582);
return return_v;
}


bool
f_1204_39540_39583(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 39540, 39583);
return return_v;
}


System.Management.Automation.PSDriveInfo
f_1204_39625_39641(System.Management.Automation.Provider.NavigationCmdletProvider
this_param)
{
var return_v = this_param.PSDriveInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 39625, 39641);
return return_v;
}


string
f_1204_39625_39646(System.Management.Automation.PSDriveInfo
this_param)
{
var return_v = this_param.Root;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 39625, 39646);
return return_v;
}


bool
f_1204_39609_39683(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.StartsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 39609, 39683);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,39284,39787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,39284,39787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Stack<string> TokenizePathToStack(string path, string basePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,40319,41576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40415,40470);

Stack<string> 
tokenizedPathStack = f_1204_40450_40469()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40484,40507);

string 
tempPath = path
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40521,40550);

string 
previousParent = path
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40566,41523) || true) && (f_1204_40573_40588(tempPath)> f_1204_40591_40606(basePath))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,40566,41523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40741,40783);

string 
childName = f_1204_40760_40782(this, tempPath)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40801,41016) || true) && (f_1204_40805_40836(childName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,40801,41016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,40935,40969);

f_1204_40935_40968(                    // Push the parent on and then stop
                    tokenizedPathStack, tempPath);
DynAbs.Tracing.TraceSender.TraceBreak(1204,40991,40997);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,40801,41016);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41036,41108);

f_1204_41036_41107(
                providerBaseTracer, "tokenizedPathStack.Push({0})", childName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41126,41161);

f_1204_41126_41160(                tokenizedPathStack, childName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41288,41333);

tempPath = f_1204_41299_41332(this, tempPath, basePath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41351,41462) || true) && (f_1204_41355_41370(tempPath)>= f_1204_41374_41395(previousParent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,41351,41462);
DynAbs.Tracing.TraceSender.TraceBreak(1204,41437,41443);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,41351,41462);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41482,41508);

previousParent = tempPath;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,40566,41523);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,40566,41523);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,40566,41523);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,41539,41565);

return tokenizedPathStack;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,40319,41576);

System.Collections.Generic.Stack<string>
f_1204_40450_40469()
{
var return_v = new System.Collections.Generic.Stack<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 40450, 40469);
return return_v;
}


int
f_1204_40573_40588(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 40573, 40588);
return return_v;
}


int
f_1204_40591_40606(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 40591, 40606);
return return_v;
}


string
f_1204_40760_40782(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetChildName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 40760, 40782);
return return_v;
}


bool
f_1204_40805_40836(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 40805, 40836);
return return_v;
}


int
f_1204_40935_40968(System.Collections.Generic.Stack<string>
this_param,string
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 40935, 40968);
return 0;
}


int
f_1204_41036_41107(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 41036, 41107);
return 0;
}


int
f_1204_41126_41160(System.Collections.Generic.Stack<string>
this_param,string
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 41126, 41160);
return 0;
}


string
f_1204_41299_41332(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
path,string
root)
{
var return_v = this_param.GetParentPath( path, root);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 41299, 41332);
return return_v;
}


int
f_1204_41355_41370(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 41355, 41370);
return return_v;
}


int
f_1204_41374_41395(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 41374, 41395);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,40319,41576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,40319,41576);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Stack<string> NormalizeThePath(
            Stack<string> tokenizedPathStack, string path,
            string basePath, bool allowNonExistingPaths)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1204,42605,44696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,42794,42850);

Stack<string> 
normalizedPathStack = f_1204_42830_42849()
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,42866,44642) || true) && (f_1204_42873_42897(tokenizedPathStack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,42866,44642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,42935,42979);

string 
childName = f_1204_42954_42978(tokenizedPathStack)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,42999,43058);

f_1204_42999_43057(
                providerBaseTracer, "childName = {0}", childName);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43133,43316) || true) && (f_1204_43137_43194(childName, ".", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,43133,43316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43288,43297);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,43133,43316);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43380,44480) || true) && (f_1204_43384_43442(childName, "..", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,43380,44480);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43484,44461) || true) && (f_1204_43488_43513(normalizedPathStack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,43484,44461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43634,43680);

string 
poppedName = f_1204_43654_43679(normalizedPathStack)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43706,43782);

f_1204_43706_43781(                        providerBaseTracer, "normalizedPathStack.Pop() : {0}", poppedName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43808,43817);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,43484,44461);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,43484,44461);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43915,44438) || true) && (!allowNonExistingPaths)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,43915,44438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,43999,44373);

PSArgumentException 
e =
                                (PSArgumentException)
f_1204_44111_44372("path", f_1204_44229_44281(), path, basePath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,44403,44411);

throw e;
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,43915,44438);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,43484,44461);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,43380,44480);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,44500,44573);

f_1204_44500_44572(
                providerBaseTracer, "normalizedPathStack.Push({0})", childName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,44591,44627);

f_1204_44591_44626(                normalizedPathStack, childName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,42866,44642);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,42866,44642);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,42866,44642);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,44658,44685);

return normalizedPathStack;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1204,42605,44696);

System.Collections.Generic.Stack<string>
f_1204_42830_42849()
{
var return_v = new System.Collections.Generic.Stack<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 42830, 42849);
return return_v;
}


int
f_1204_42873_42897(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 42873, 42897);
return return_v;
}


string
f_1204_42954_42978(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 42954, 42978);
return return_v;
}


int
f_1204_42999_43057(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 42999, 43057);
return 0;
}


bool
f_1204_43137_43194(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 43137, 43194);
return return_v;
}


bool
f_1204_43384_43442(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 43384, 43442);
return return_v;
}


int
f_1204_43488_43513(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 43488, 43513);
return return_v;
}


string
f_1204_43654_43679(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 43654, 43679);
return return_v;
}


int
f_1204_43706_43781(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 43706, 43781);
return 0;
}


string
f_1204_44229_44281()
{
var return_v =                                     SessionStateStrings.NormalizeRelativePathOutsideBase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 44229, 44281);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1204_44111_44372(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 44111, 44372);
return return_v;
}


int
f_1204_44500_44572(System.Management.Automation.PSTraceSource
this_param,string
format,string
arg1)
{
this_param.WriteLine( format, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 44500, 44572);
return 0;
}


int
f_1204_44591_44626(System.Collections.Generic.Stack<string>
this_param,string
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 44591, 44626);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,42605,44696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,42605,44696);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string CreateNormalizedRelativePathFromStack(Stack<string> normalizedPathStack)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1204,45376,46011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45488,45522);

string 
leafElement = string.Empty
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45538,45965) || true) && (f_1204_45545_45570(normalizedPathStack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,45538,45965);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45608,45950) || true) && (f_1204_45612_45645(leafElement))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,45608,45950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45687,45727);

leafElement = f_1204_45701_45726(normalizedPathStack);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,45608,45950);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1204,45608,45950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45809,45858);

string 
parentElement = f_1204_45832_45857(normalizedPathStack)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45880,45931);

leafElement = f_1204_45894_45930(this, parentElement, leafElement);
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,45608,45950);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1204,45538,45965);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1204,45538,45965);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1204,45538,45965);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1204,45981,46000);

return leafElement;
DynAbs.Tracing.TraceSender.TraceExitMethod(1204,45376,46011);

int
f_1204_45545_45570(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1204, 45545, 45570);
return return_v;
}


bool
f_1204_45612_45645(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 45612, 45645);
return return_v;
}


string
f_1204_45701_45726(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 45701, 45726);
return return_v;
}


string
f_1204_45832_45857(System.Collections.Generic.Stack<string>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 45832, 45857);
return return_v;
}


string
f_1204_45894_45930(System.Management.Automation.Provider.NavigationCmdletProvider
this_param,string
parent,string
child)
{
var return_v = this_param.MakePath( parent, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1204, 45894, 45930);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1204,45376,46011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,45376,46011);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public NavigationCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1204,850,46056);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1204,850,46056);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,850,46056);
}


static NavigationCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1204,850,46056);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1204,850,46056);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1204,850,46056);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1204,850,46056);
}

    }

