// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation.Language
{
    internal enum ScopeType
    {
        Type,           // class or enum
        Method,         // class method
        Function,       // function
        ScriptBlock     // script or anonymous script block
    }
internal class TypeLookupResult
{
public TypeLookupResult(TypeDefinitionAst type = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,732,834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,846,889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,899,951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,811,823);

Type = type;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,732,834);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,732,834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,732,834);
}
		}

public TypeDefinitionAst Type {get; set; }

public List<string> ExternalNamespaces {get; set; }

public bool IsAmbiguous()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,963,1092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1013,1081);

return (f_1556_1021_1039()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 1021, 1079)&&f_1556_1051_1075(f_1556_1051_1069())> 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,963,1092);

System.Collections.Generic.List<string>
f_1556_1021_1039()
{
var return_v = ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 1021, 1039);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_1051_1069()
{
var return_v = ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 1051, 1069);
return return_v;
}


int
f_1556_1051_1075(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 1051, 1075);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,963,1092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,963,1092);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TypeLookupResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1556,684,1099);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1556,684,1099);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,684,1099);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1556,684,1099);
}
internal class Scope
{
internal Ast _ast;

internal ScopeType _scopeType;

private readonly Dictionary<string, TypeLookupResult> _typeTable;

private readonly Dictionary<string, Ast> _variableTable;

internal Scope(IParameterMetadataProvider ast, ScopeType scopeType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,1614,1965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1157,1161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1191,1201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1525,1535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1587,1601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1706,1722);

_ast = (Ast)ast;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1736,1759);

_scopeType = scopeType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1773,1861);

_typeTable = f_1556_1786_1860(f_1556_1827_1859());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1875,1954);

_variableTable = f_1556_1892_1953(f_1556_1920_1952());
DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,1614,1965);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,1614,1965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,1614,1965);
}
		}

internal Scope(TypeDefinitionAst typeDefinition)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,1977,3090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1157,1161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1191,1201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1525,1535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,1587,1601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2050,2072);

_ast = typeDefinition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2086,2114);

_scopeType = ScopeType.Type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2128,2216);

_typeTable = f_1556_2141_2215(f_1556_2182_2214());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2230,2309);

_variableTable = f_1556_2247_2308(f_1556_2275_2307());
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2323,3079);
foreach(var member in f_1556_2346_2368_I(f_1556_2346_2368(typeDefinition)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,2323,3079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2402,2451);

var 
propertyMember = member as PropertyMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2469,3064) || true) && (propertyMember != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,2469,3064);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2864,3045) || true) && (!f_1556_2869_2916(_variableTable, f_1556_2896_2915(propertyMember)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,2864,3045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,2966,3022);

f_1556_2966_3021(                        _variableTable, f_1556_2985_3004(propertyMember), propertyMember);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,2864,3045);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,2469,3064);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,2323,3079);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,757);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,757);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,1977,3090);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,1977,3090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,1977,3090);
}
		}

internal void AddType(Parser parser, TypeDefinitionAst typeDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,3102,4089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3200,3224);

TypeLookupResult 
result
=default(TypeLookupResult);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3238,4078) || true) && (f_1556_3242_3300(_typeTable, f_1556_3265_3287(typeDefinitionAst), out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,3238,4078);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3334,3917) || true) && (f_1556_3338_3363(result)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,3334,3917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3505,3538);

result.ExternalNamespaces = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3560,3592);

result.Type = typeDefinitionAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,3334,3917);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,3334,3917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3674,3898);

f_1556_3674_3897(                    parser, f_1556_3693_3717(typeDefinitionAst), nameof(ParserStrings.MemberAlreadyDefined), f_1556_3813_3847(), f_1556_3874_3896(typeDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,3334,3917);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,3238,4078);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,3238,4078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,3983,4063);

f_1556_3983_4062(                _typeTable, f_1556_3998_4020(typeDefinitionAst), f_1556_4022_4061(typeDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,3238,4078);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,3102,4089);

string
f_1556_3265_3287(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3265, 3287);
return return_v;
}


bool
f_1556_3242_3300(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,out System.Management.Automation.Language.TypeLookupResult
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 3242, 3300);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_3338_3363(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3338, 3363);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_3693_3717(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3693, 3717);
return return_v;
}


string
f_1556_3813_3847()
{
var return_v =                         ParserStrings.MemberAlreadyDefined;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3813, 3847);
return return_v;
}


string
f_1556_3874_3896(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3874, 3896);
return return_v;
}


int
f_1556_3674_3897(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 3674, 3897);
return 0;
}


string
f_1556_3998_4020(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 3998, 4020);
return return_v;
}


System.Management.Automation.Language.TypeLookupResult
f_1556_4022_4061(System.Management.Automation.Language.TypeDefinitionAst
type)
{
var return_v = new System.Management.Automation.Language.TypeLookupResult( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4022, 4061);
return return_v;
}


int
f_1556_3983_4062(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,System.Management.Automation.Language.TypeLookupResult
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 3983, 4062);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,3102,4089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,3102,4089);
}
		}

internal void AddTypeFromUsingModule(Parser parser, TypeDefinitionAst typeDefinitionAst, PSModuleInfo moduleInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,4101,5562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4239,4263);

TypeLookupResult 
result
=default(TypeLookupResult);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4277,4997) || true) && (f_1556_4281_4339(_typeTable, f_1556_4304_4326(typeDefinitionAst), out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,4277,4997);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4373,4610) || true) && (f_1556_4377_4402(result)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,4373,4610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4544,4591);

f_1556_4544_4590(f_1556_4544_4569(result), f_1556_4574_4589(moduleInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,4373,4610);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,4277,4997);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,4277,4997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4676,4836);

var 
newLookupEntry = new TypeLookupResult(typeDefinitionAst)
                {
                    ExternalNamespaces = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1556_4798_4816(),1556,4697,4835)                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4854,4909);

f_1556_4854_4908(f_1556_4854_4887(newLookupEntry), f_1556_4892_4907(moduleInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,4927,4982);

f_1556_4927_4981(                _typeTable, f_1556_4942_4964(typeDefinitionAst), newLookupEntry);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,4277,4997);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5013,5110);

string 
fullName = f_1556_5031_5109(f_1556_5069_5084(moduleInfo), f_1556_5086_5108(typeDefinitionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5124,5551) || true) && (f_1556_5128_5172(_typeTable, fullName, out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,5124,5551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5206,5404);

f_1556_5206_5403(                parser, f_1556_5225_5249(typeDefinitionAst), nameof(ParserStrings.MemberAlreadyDefined), f_1556_5337_5371(), fullName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,5124,5551);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,5124,5551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5470,5536);

f_1556_5470_5535(                _typeTable, fullName, f_1556_5495_5534(typeDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,5124,5551);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,4101,5562);

string
f_1556_4304_4326(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4304, 4326);
return return_v;
}


bool
f_1556_4281_4339(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,out System.Management.Automation.Language.TypeLookupResult
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4281, 4339);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_4377_4402(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4377, 4402);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_4544_4569(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4544, 4569);
return return_v;
}


string
f_1556_4574_4589(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4574, 4589);
return return_v;
}


int
f_1556_4544_4590(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4544, 4590);
return 0;
}


System.Collections.Generic.List<string>
f_1556_4798_4816()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4798, 4816);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_4854_4887(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4854, 4887);
return return_v;
}


string
f_1556_4892_4907(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4892, 4907);
return return_v;
}


int
f_1556_4854_4908(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4854, 4908);
return 0;
}


string
f_1556_4942_4964(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 4942, 4964);
return return_v;
}


int
f_1556_4927_4981(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,System.Management.Automation.Language.TypeLookupResult
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 4927, 4981);
return 0;
}


string
f_1556_5069_5084(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5069, 5084);
return return_v;
}


string
f_1556_5086_5108(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5086, 5108);
return return_v;
}


string
f_1556_5031_5109(string
namespaceName,string
typeName)
{
var return_v = SymbolResolver.GetModuleQualifiedName( namespaceName, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5031, 5109);
return return_v;
}


bool
f_1556_5128_5172(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,out System.Management.Automation.Language.TypeLookupResult
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5128, 5172);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_5225_5249(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5225, 5249);
return return_v;
}


string
f_1556_5337_5371()
{
var return_v =                     ParserStrings.MemberAlreadyDefined;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5337, 5371);
return return_v;
}


int
f_1556_5206_5403(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5206, 5403);
return 0;
}


System.Management.Automation.Language.TypeLookupResult
f_1556_5495_5534(System.Management.Automation.Language.TypeDefinitionAst
type)
{
var return_v = new System.Management.Automation.Language.TypeLookupResult( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5495, 5534);
return return_v;
}


int
f_1556_5470_5535(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,System.Management.Automation.Language.TypeLookupResult
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5470, 5535);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,4101,5562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,4101,5562);
}
		}

internal TypeLookupResult LookupType(TypeName typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,5574,5921);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5654,5748) || true) && (f_1556_5658_5679(typeName)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,5654,5748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5721,5733);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,5654,5748);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5764,5798);

TypeLookupResult 
typeLookupResult
=default(TypeLookupResult);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5812,5872);

f_1556_5812_5871(            _typeTable, f_1556_5835_5848(typeName), out typeLookupResult);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,5886,5910);

return typeLookupResult;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,5574,5921);

string
f_1556_5658_5679(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.AssemblyName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5658, 5679);
return return_v;
}


string
f_1556_5835_5848(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 5835, 5848);
return return_v;
}


bool
f_1556_5812_5871(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
this_param,string
key,out System.Management.Automation.Language.TypeLookupResult
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 5812, 5871);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,5574,5921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,5574,5921);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Ast LookupVariable(VariablePath variablePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,5933,6172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6010,6033);

Ast 
variabledefinition
=default(Ast);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6047,6121);

f_1556_6047_6120(            _variableTable, f_1556_6074_6095(variablePath), out variabledefinition);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6135,6161);

return variabledefinition;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,5933,6172);

string
f_1556_6074_6095(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 6074, 6095);
return return_v;
}


bool
f_1556_6047_6120(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>
this_param,string
key,out System.Management.Automation.Language.Ast
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 6047, 6120);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,5933,6172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,5933,6172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static Scope()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1556,1107,6179);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1556,1107,6179);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,1107,6179);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1556,1107,6179);

System.StringComparer
f_1556_1827_1859()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 1827, 1859);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
f_1556_1786_1860(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 1786, 1860);
return return_v;
}


System.StringComparer
f_1556_1920_1952()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 1920, 1952);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>
f_1556_1892_1953(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 1892, 1953);
return return_v;
}


System.StringComparer
f_1556_2182_2214()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 2182, 2214);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>
f_1556_2141_2215(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.TypeLookupResult>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 2141, 2215);
return return_v;
}


System.StringComparer
f_1556_2275_2307()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 2275, 2307);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>
f_1556_2247_2308(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 2247, 2308);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1556_2346_2368(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Members;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 2346, 2368);
return return_v;
}


string
f_1556_2896_2915(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 2896, 2915);
return return_v;
}


bool
f_1556_2869_2916(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 2869, 2916);
return return_v;
}


string
f_1556_2985_3004(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 2985, 3004);
return return_v;
}


int
f_1556_2966_3021(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.Ast>
this_param,string
key,System.Management.Automation.Language.PropertyMemberAst
value)
{
this_param.Add( key, (System.Management.Automation.Language.Ast)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 2966, 3021);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1556_2346_2368_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 2346, 2368);
return return_v;
}

}
internal class SymbolTable
{
internal readonly List<Scope> _scopes;

internal readonly Parser _parser;

internal SymbolTable(Parser parser)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,6323,6453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6260,6267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6303,6310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6383,6411);

_scopes = f_1556_6393_6410();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6425,6442);

_parser = parser;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,6323,6453);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,6323,6453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,6323,6453);
}
		}

internal void AddTypesInScope(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,6465,7022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6803,6889);

var 
types = f_1556_6815_6888(ast, x => x is TypeDefinitionAst, searchNestedScriptBlocks: false)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6903,7011);
foreach(var type in f_1556_6924_6929_I(types) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,6903,7011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,6963,6996);

f_1556_6963_6995(this, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,6903,7011);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,109);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,109);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1556,6465,7022);

System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
f_1556_6815_6888(System.Management.Automation.Language.Ast
this_param,System.Func<System.Management.Automation.Language.Ast, bool>
predicate,bool
searchNestedScriptBlocks)
{
var return_v = this_param.FindAll( predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 6815, 6888);
return return_v;
}


int
f_1556_6963_6995(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.Ast
typeDefinitionAst)
{
this_param.AddType( (System.Management.Automation.Language.TypeDefinitionAst)typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 6963, 6995);
return 0;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
f_1556_6924_6929_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 6924, 6929);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,6465,7022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,6465,7022);
}
		}

internal void EnterScope(IParameterMetadataProvider ast, ScopeType scopeType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,7034,7258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7136,7174);

var 
scope = f_1556_7148_7173(ast, scopeType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7188,7207);

f_1556_7188_7206(            _scopes, scope);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7221,7247);

f_1556_7221_7246(this, ast);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,7034,7258);

System.Management.Automation.Language.Scope
f_1556_7148_7173(System.Management.Automation.Language.IParameterMetadataProvider
ast,System.Management.Automation.Language.ScopeType
scopeType)
{
var return_v = new System.Management.Automation.Language.Scope( ast, scopeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7148, 7173);
return return_v;
}


int
f_1556_7188_7206(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,System.Management.Automation.Language.Scope
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7188, 7206);
return 0;
}


int
f_1556_7221_7246(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.IParameterMetadataProvider
ast)
{
this_param.AddTypesInScope( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7221, 7246);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,7034,7258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,7034,7258);
}
		}

internal void EnterScope(TypeDefinitionAst typeDefinition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,7270,7481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7353,7391);

var 
scope = f_1556_7365_7390(typeDefinition)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7405,7424);

f_1556_7405_7423(            _scopes, scope);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7438,7470);

f_1556_7438_7469(this, typeDefinition);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,7270,7481);

System.Management.Automation.Language.Scope
f_1556_7365_7390(System.Management.Automation.Language.TypeDefinitionAst
typeDefinition)
{
var return_v = new System.Management.Automation.Language.Scope( typeDefinition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7365, 7390);
return return_v;
}


int
f_1556_7405_7423(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,System.Management.Automation.Language.Scope
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7405, 7423);
return 0;
}


int
f_1556_7438_7469(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.TypeDefinitionAst
ast)
{
this_param.AddTypesInScope( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7438, 7469);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,7270,7481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,7270,7481);
}
		}

internal void LeaveScope()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,7493,7694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7544,7633);

f_1556_7544_7632(f_1556_7563_7576(_scopes)> 0, "Scope stack can't be empty when leaving a scope");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7647,7683);

f_1556_7647_7682(            _scopes, f_1556_7664_7677(_scopes)- 1);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,7493,7694);

int
f_1556_7563_7576(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 7563, 7576);
return return_v;
}


int
f_1556_7544_7632(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7544, 7632);
return 0;
}


int
f_1556_7664_7677(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 7664, 7677);
return return_v;
}


int
f_1556_7647_7682(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7647, 7682);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,7493,7694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,7493,7694);
}
		}

public void AddType(TypeDefinitionAst typeDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,7850,8005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,7931,7994);

f_1556_7931_7993(f_1556_7931_7957(_scopes, f_1556_7939_7952(_scopes)- 1), _parser, typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,7850,8005);

int
f_1556_7939_7952(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 7939, 7952);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_7931_7957(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 7931, 7957);
return return_v;
}


int
f_1556_7931_7993(System.Management.Automation.Language.Scope
this_param,System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst)
{
this_param.AddType( parser, typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 7931, 7993);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,7850,8005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,7850,8005);
}
		}

public void AddTypeFromUsingModule(TypeDefinitionAst typeDefinitionAst, PSModuleInfo moduleInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,8234,8456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8355,8445);

f_1556_8355_8444(f_1556_8355_8381(_scopes, f_1556_8363_8376(_scopes)- 1), _parser, typeDefinitionAst, moduleInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,8234,8456);

int
f_1556_8363_8376(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 8363, 8376);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_8355_8381(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 8355, 8381);
return return_v;
}


int
f_1556_8355_8444(System.Management.Automation.Language.Scope
this_param,System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst,System.Management.Automation.PSModuleInfo
moduleInfo)
{
this_param.AddTypeFromUsingModule( parser, typeDefinitionAst, moduleInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 8355, 8444);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,8234,8456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,8234,8456);
}
		}

public TypeLookupResult LookupType(TypeName typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,8468,8830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8546,8577);

TypeLookupResult 
result = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8600,8621);
            for (int 
i = f_1556_8604_8617(_scopes)- 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8591,8789) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8631,8634)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1556,8591,8789))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,8591,8789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8668,8709);

result = f_1556_8677_8708(f_1556_8677_8687(_scopes, i), typeName);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8727,8774) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,8727,8774);
DynAbs.Tracing.TraceSender.TraceBreak(1556,8768,8774);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,8727,8774);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,199);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8805,8819);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,8468,8830);

int
f_1556_8604_8617(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 8604, 8617);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_8677_8687(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 8677, 8687);
return return_v;
}


System.Management.Automation.Language.TypeLookupResult
f_1556_8677_8708(System.Management.Automation.Language.Scope
this_param,System.Management.Automation.Language.TypeName
typeName)
{
var return_v = this_param.LookupType( typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 8677, 8708);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,8468,8830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,8468,8830);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Ast LookupVariable(VariablePath variablePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,8842,9198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8919,8937);

Ast 
result = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8960,8981);
            for (int 
i = f_1556_8964_8977(_scopes)- 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8951,9157) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,8991,8994)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1556,8951,9157))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,8951,9157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9028,9077);

result = f_1556_9037_9076(f_1556_9037_9047(_scopes, i), variablePath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9095,9142) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,9095,9142);
DynAbs.Tracing.TraceSender.TraceBreak(1556,9136,9142);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,9095,9142);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,207);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,207);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9173,9187);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,8842,9198);

int
f_1556_8964_8977(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 8964, 8977);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_9037_9047(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 9037, 9047);
return return_v;
}


System.Management.Automation.Language.Ast
f_1556_9037_9076(System.Management.Automation.Language.Scope
this_param,System.Management.Automation.VariablePath
variablePath)
{
var return_v = this_param.LookupVariable( variablePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 9037, 9076);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,8842,9198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,8842,9198);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public TypeDefinitionAst GetCurrentTypeDefinitionAst()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,9429,9805);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9517,9538);
            for (int 
i = f_1556_9521_9534(_scopes)- 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9508,9766) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9548,9551)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1556,9508,9766))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,9508,9766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9585,9646);

TypeDefinitionAst 
ast = f_1556_9609_9619(_scopes, i)._ast as TypeDefinitionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9664,9751) || true) && (ast != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,9664,9751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9721,9732);

return ast;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,9664,9751);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,259);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,259);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9782,9794);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,9429,9805);

int
f_1556_9521_9534(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 9521, 9534);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_9609_9619(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 9609, 9619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,9429,9805);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,9429,9805);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool IsInMethodScope()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,9817,9947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,9871,9936);

return f_1556_9878_9904(_scopes, f_1556_9886_9899(_scopes)- 1)._scopeType == ScopeType.Method;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,9817,9947);

int
f_1556_9886_9899(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 9886, 9899);
return return_v;
}


System.Management.Automation.Language.Scope
f_1556_9878_9904(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 9878, 9904);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,9817,9947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,9817,9947);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SymbolTable()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1556,6187,9954);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1556,6187,9954);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,6187,9954);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1556,6187,9954);

System.Collections.Generic.List<System.Management.Automation.Language.Scope>
f_1556_6393_6410()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Scope>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 6393, 6410);
return return_v;
}

}
internal class SymbolResolver : AstVisitor2, IAstPostVisitHandler
{
private readonly SymbolResolvePostActionVisitor _symbolResolvePostActionVisitor;

internal readonly SymbolTable _symbolTable;

internal readonly Parser _parser;

internal readonly TypeResolutionState _typeResolutionState;

[ThreadStatic]
        private static PowerShell t_usingStatementResolvePowerShell;

private static PowerShell UsingStatementResolvePowerShell
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1556,10479,12235);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10648,12159) || true) && (t_usingStatementResolvePowerShell == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,10648,12159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10735,11862) || true) && (f_1556_10739_10763()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,10735,11862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10821,10905);

t_usingStatementResolvePowerShell = f_1556_10857_10904(RunspaceMode.CurrentRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,10735,11862);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,10735,11862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11097,11152);

InitialSessionState 
iss = f_1556_11123_11151()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11178,11270);

f_1556_11178_11269(f_1556_11178_11190(iss), f_1556_11195_11268("Get-Module", typeof(GetModuleCommand), null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11296,11425);

var 
sessionStateProviderEntry = f_1556_11328_11424(FileSystemProvider.ProviderName, typeof(FileSystemProvider), null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11451,11611);

var 
snapin = f_1556_11464_11610(f_1556_11464_11500(), snapIn => snapIn.Name.Equals("Microsoft.PowerShell.Core", StringComparison.OrdinalIgnoreCase))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11637,11683);

f_1556_11637_11682(                        sessionStateProviderEntry, snapin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11709,11754);

f_1556_11709_11753(f_1556_11709_11722(iss), sessionStateProviderEntry);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11780,11839);

t_usingStatementResolvePowerShell = f_1556_11816_11838(iss);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,10735,11862);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,10648,12159);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,10648,12159);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,11904,12159) || true) && (f_1556_11908_11932()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 11908, 12014)&&f_1556_11944_11986(t_usingStatementResolvePowerShell)!= f_1556_11990_12014()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,11904,12159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12056,12140);

t_usingStatementResolvePowerShell = f_1556_12092_12139(RunspaceMode.CurrentRunspace);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,11904,12159);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,10648,12159);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12179,12220);

return t_usingStatementResolvePowerShell;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1556,10479,12235);

System.Management.Automation.Runspaces.Runspace
f_1556_10739_10763()
{
var return_v = Runspace.DefaultRunspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 10739, 10763);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_10857_10904(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 10857, 10904);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionState
f_1556_11123_11151()
{
var return_v = InitialSessionState.Create();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11123, 11151);
return return_v;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
f_1556_11178_11190(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 11178, 11190);
return return_v;
}


System.Management.Automation.Runspaces.SessionStateCmdletEntry
f_1556_11195_11268(string
name,System.Type
implementingType,string
helpFileName)
{
var return_v = new System.Management.Automation.Runspaces.SessionStateCmdletEntry( name, implementingType, helpFileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11195, 11268);
return return_v;
}


int
f_1556_11178_11269(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
this_param,System.Management.Automation.Runspaces.SessionStateCmdletEntry
item)
{
this_param.Add( (System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11178, 11269);
return 0;
}


System.Management.Automation.Runspaces.SessionStateProviderEntry
f_1556_11328_11424(string
name,System.Type
implementingType,string
helpFileName)
{
var return_v = new System.Management.Automation.Runspaces.SessionStateProviderEntry( name, implementingType, helpFileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11328, 11424);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
f_1556_11464_11500()
{
var return_v = PSSnapInReader.ReadEnginePSSnapIns();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11464, 11500);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1556_11464_11610(System.Collections.ObjectModel.Collection<System.Management.Automation.PSSnapInInfo>
source,System.Func<System.Management.Automation.PSSnapInInfo, bool>
predicate)
{
var return_v = source.FirstOrDefault<System.Management.Automation.PSSnapInInfo>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11464, 11610);
return return_v;
}


int
f_1556_11637_11682(System.Management.Automation.Runspaces.SessionStateProviderEntry
this_param,System.Management.Automation.PSSnapInInfo
psSnapIn)
{
this_param.SetPSSnapIn( psSnapIn);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11637, 11682);
return 0;
}


System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
f_1556_11709_11722(System.Management.Automation.Runspaces.InitialSessionState
this_param)
{
var return_v = this_param.Providers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 11709, 11722);
return return_v;
}


int
f_1556_11709_11753(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
this_param,System.Management.Automation.Runspaces.SessionStateProviderEntry
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11709, 11753);
return 0;
}


System.Management.Automation.PowerShell
f_1556_11816_11838(System.Management.Automation.Runspaces.InitialSessionState
initialSessionState)
{
var return_v = PowerShell.Create( initialSessionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 11816, 11838);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1556_11908_11932()
{
var return_v = Runspace.DefaultRunspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 11908, 11932);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1556_11944_11986(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Runspace ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 11944, 11986);
return return_v;
}


System.Management.Automation.Runspaces.Runspace
f_1556_11990_12014()
{
var return_v = Runspace.DefaultRunspace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 11990, 12014);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_12092_12139(System.Management.Automation.RunspaceMode
runspace)
{
var return_v = PowerShell.Create( runspace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 12092, 12139);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,10397,12246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,10397,12246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private SymbolResolver(Parser parser, TypeResolutionState typeResolutionState)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,12258,12609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10092,10123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10164,10176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10212,10219);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10268,10288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12361,12400);

_symbolTable = f_1556_12376_12399(parser);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12414,12431);

_parser = parser;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12445,12488);

_typeResolutionState = typeResolutionState;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12502,12598);

_symbolResolvePostActionVisitor = new SymbolResolvePostActionVisitor { _symbolResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => this,1556,12536,12597) };
DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,12258,12609);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,12258,12609);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,12258,12609);
}
		}

internal static void ResolveSymbols(Parser parser, ScriptBlockAst scriptBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1556,12621,13489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12727,12820);

f_1556_12727_12819(f_1556_12746_12767(scriptBlockAst)== null, "Can only resolve starting from the root");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,12836,13117);

var 
usingState = (DynAbs.Tracing.TraceSender.Conditional_F1(1556, 12853, 12893)||((f_1556_12853_12889(f_1556_12853_12883(scriptBlockAst))> 0
&&DynAbs.Tracing.TraceSender.Conditional_F2(1556, 12913, 13050))||DynAbs.Tracing.TraceSender.Conditional_F3(1556, 13070, 13116)))?f_1556_12913_13050(f_1556_12937_13012(f_1556_12981_13011(scriptBlockAst)), TypeResolutionState.emptyAssemblies):f_1556_13070_13116(null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13131,13185);

var 
resolver = f_1556_13146_13184(parser, usingState)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13199,13271);

f_1556_13199_13270(            resolver._symbolTable, scriptBlockAst, ScopeType.ScriptBlock);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13285,13316);

f_1556_13285_13315(            scriptBlockAst, resolver);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13330,13365);

f_1556_13330_13364(            resolver._symbolTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13381,13478);

f_1556_13381_13477(f_1556_13400_13435(resolver._symbolTable._scopes)== 0, "Somebody missed removing a scope");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1556,12621,13489);

System.Management.Automation.Language.Ast
f_1556_12746_12767(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 12746, 12767);
return return_v;
}


int
f_1556_12727_12819(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 12727, 12819);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
f_1556_12853_12883(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.UsingStatements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 12853, 12883);
return return_v;
}


int
f_1556_12853_12889(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 12853, 12889);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
f_1556_12981_13011(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.UsingStatements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 12981, 13011);
return return_v;
}


string[]
f_1556_12937_13012(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.UsingStatementAst>
usingAsts)
{
var return_v = TypeOps.GetNamespacesForTypeResolutionState( (System.Collections.Generic.IEnumerable<System.Management.Automation.Language.UsingStatementAst>)usingAsts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 12937, 13012);
return return_v;
}


System.Management.Automation.Language.TypeResolutionState
f_1556_12913_13050(string[]
namespaces,System.Reflection.Assembly[]
assemblies)
{
var return_v = new System.Management.Automation.Language.TypeResolutionState( namespaces, assemblies);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 12913, 13050);
return return_v;
}


System.Management.Automation.Language.TypeResolutionState
f_1556_13070_13116(System.Management.Automation.ExecutionContext
context)
{
var return_v = TypeResolutionState.GetDefaultUsingState( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13070, 13116);
return return_v;
}


System.Management.Automation.Language.SymbolResolver
f_1556_13146_13184(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeResolutionState
typeResolutionState)
{
var return_v = new System.Management.Automation.Language.SymbolResolver( parser, typeResolutionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13146, 13184);
return return_v;
}


int
f_1556_13199_13270(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.ScopeType
scopeType)
{
this_param.EnterScope( (System.Management.Automation.Language.IParameterMetadataProvider)ast, scopeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13199, 13270);
return 0;
}


int
f_1556_13285_13315(System.Management.Automation.Language.ScriptBlockAst
this_param,System.Management.Automation.Language.SymbolResolver
astVisitor)
{
this_param.Visit( (System.Management.Automation.Language.AstVisitor)astVisitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13285, 13315);
return 0;
}


int
f_1556_13330_13364(System.Management.Automation.Language.SymbolTable
this_param)
{
this_param.LeaveScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13330, 13364);
return 0;
}


int
f_1556_13400_13435(System.Collections.Generic.List<System.Management.Automation.Language.Scope>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 13400, 13435);
return return_v;
}


int
f_1556_13381_13477(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13381, 13477);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,12621,13489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,12621,13489);
}
		}

public override AstVisitAction VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,13501,13712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13613,13656);

f_1556_13613_13655(            _symbolTable, typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13670,13701);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,13501,13712);

int
f_1556_13613_13655(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.TypeDefinitionAst
typeDefinition)
{
this_param.EnterScope( typeDefinition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13613, 13655);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,13501,13712);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,13501,13712);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,13724,13998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13857,13942);

f_1556_13857_13941(            _symbolTable, f_1556_13881_13917(scriptBlockExpressionAst), ScopeType.ScriptBlock);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,13956,13987);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,13724,13998);

System.Management.Automation.Language.ScriptBlockAst
f_1556_13881_13917(System.Management.Automation.Language.ScriptBlockExpressionAst
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 13881, 13917);
return return_v;
}


int
f_1556_13857_13941(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.ScopeType
scopeType)
{
this_param.EnterScope( (System.Management.Automation.Language.IParameterMetadataProvider)ast, scopeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 13857, 13941);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,13724,13998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,13724,13998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,14010,14369);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14134,14311) || true) && (!(f_1556_14140_14168(functionDefinitionAst)is FunctionMemberAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,14134,14311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14224,14296);

f_1556_14224_14295(                _symbolTable, f_1556_14248_14274(functionDefinitionAst), ScopeType.Function);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,14134,14311);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14327,14358);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,14010,14369);

System.Management.Automation.Language.Ast
f_1556_14140_14168(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 14140, 14168);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1556_14248_14274(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 14248, 14274);
return return_v;
}


int
f_1556_14224_14295(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.ScopeType
scopeType)
{
this_param.EnterScope( (System.Management.Automation.Language.IParameterMetadataProvider)ast, scopeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 14224, 14295);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,14010,14369);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,14010,14369);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPropertyMember(PropertyMemberAst propertyMemberAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,14381,14535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14493,14524);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,14381,14535);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,14381,14535);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,14381,14535);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionMember(FunctionMemberAst functionMemberAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,14547,14781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14659,14725);

f_1556_14659_14724(            _symbolTable, f_1556_14683_14705(functionMemberAst), ScopeType.Method);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14739,14770);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,14547,14781);

System.Management.Automation.Language.ScriptBlockAst
f_1556_14683_14705(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 14683, 14705);
return return_v;
}


int
f_1556_14659_14724(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.ScriptBlockAst
ast,System.Management.Automation.Language.ScopeType
scopeType)
{
this_param.EnterScope( (System.Management.Automation.Language.IParameterMetadataProvider)ast, scopeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 14659, 14724);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,14547,14781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,14547,14781);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,14793,17745);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14920,17687) || true) && (f_1556_14924_14954(_symbolTable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,14920,17687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,14988,15058);

var 
targets = f_1556_15002_15057(f_1556_15002_15047(assignmentStatementAst))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15076,17610);
foreach(var expressionAst in f_1556_15106_15113_I(targets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,15076,17610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15155,15186);

var 
expression = expressionAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15208,15272);

var 
variableExpressionAst = expression as VariableExpressionAst
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15294,15896) || true) && (variableExpressionAst == null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 15301, 15352)&&expression != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,15294,15896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15402,15464);

var 
convertExpressionAst = expression as ConvertExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15490,15873) || true) && (convertExpressionAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,15490,15873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15580,15620);

expression = f_1556_15593_15619(convertExpressionAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15650,15726);

variableExpressionAst = f_1556_15674_15700(convertExpressionAst)as VariableExpressionAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,15490,15873);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,15490,15873);
DynAbs.Tracing.TraceSender.TraceBreak(1556,15840,15846);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,15490,15873);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,15294,15896);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,15294,15896);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,15294,15896);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,15920,17591) || true) && (variableExpressionAst != null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 15924, 16002)&&f_1556_15957_16002(f_1556_15957_15991(variableExpressionAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,15920,17591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16052,16126);

var 
ast = f_1556_16062_16125(_symbolTable, f_1556_16090_16124(variableExpressionAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16152,16198);

var 
propertyMember = ast as PropertyMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16224,17568) || true) && (propertyMember != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,16224,17568);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16308,17541) || true) && (f_1556_16312_16335(propertyMember))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,16308,17541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16401,16458);

var 
typeAst = f_1556_16415_16457(_symbolTable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16492,16585);

f_1556_16492_16584(typeAst != null, "Method scopes can exist only inside type definitions.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16621,16710);

string 
typeString = f_1556_16641_16709(f_1556_16655_16683(), "[{0}]::", f_1556_16696_16708(typeAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,16744,17089);

f_1556_16744_17088(                                _parser, f_1556_16764_16792(variableExpressionAst), nameof(ParserStrings.MissingTypeInStaticPropertyAssignment), f_1556_16929_16980(), typeString, f_1556_17068_17087(propertyMember));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,16308,17541);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,16308,17541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,17219,17510);

f_1556_17219_17509(                                _parser, f_1556_17239_17267(variableExpressionAst), nameof(ParserStrings.MissingThis), f_1556_17378_17403(), "$this.", f_1556_17489_17508(propertyMember));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,16308,17541);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,16224,17568);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,15920,17591);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,15076,17610);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,2535);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,2535);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1556,14920,17687);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,17703,17734);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,14793,17745);

bool
f_1556_14924_14954(System.Management.Automation.Language.SymbolTable
this_param)
{
var return_v = this_param.IsInMethodScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 14924, 14954);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
f_1556_15002_15047(System.Management.Automation.Language.AssignmentStatementAst
this_param)
{
var return_v = this_param.GetAssignmentTargets();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 15002, 15047);
return return_v;
}


System.Management.Automation.Language.ExpressionAst[]
f_1556_15002_15057(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
source)
{
var return_v = source.ToArray<System.Management.Automation.Language.ExpressionAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 15002, 15057);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1556_15593_15619(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 15593, 15619);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1556_15674_15700(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 15674, 15700);
return return_v;
}


System.Management.Automation.VariablePath
f_1556_15957_15991(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 15957, 15991);
return return_v;
}


bool
f_1556_15957_16002(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 15957, 16002);
return return_v;
}


System.Management.Automation.VariablePath
f_1556_16090_16124(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16090, 16124);
return return_v;
}


System.Management.Automation.Language.Ast
f_1556_16062_16125(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.VariablePath
variablePath)
{
var return_v = this_param.LookupVariable( variablePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 16062, 16125);
return return_v;
}


bool
f_1556_16312_16335(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16312, 16335);
return return_v;
}


System.Management.Automation.Language.TypeDefinitionAst
f_1556_16415_16457(System.Management.Automation.Language.SymbolTable
this_param)
{
var return_v = this_param.GetCurrentTypeDefinitionAst();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 16415, 16457);
return return_v;
}


int
f_1556_16492_16584(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 16492, 16584);
return 0;
}


System.Globalization.CultureInfo
f_1556_16655_16683()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16655, 16683);
return return_v;
}


string
f_1556_16696_16708(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16696, 16708);
return return_v;
}


string
f_1556_16641_16709(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 16641, 16709);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_16764_16792(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16764, 16792);
return return_v;
}


string
f_1556_16929_16980()
{
var return_v =                                     ParserStrings.MissingTypeInStaticPropertyAssignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 16929, 16980);
return return_v;
}


string
f_1556_17068_17087(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 17068, 17087);
return return_v;
}


int
f_1556_16744_17088(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 16744, 17088);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1556_17239_17267(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 17239, 17267);
return return_v;
}


string
f_1556_17378_17403()
{
var return_v =                                     ParserStrings.MissingThis;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 17378, 17403);
return return_v;
}


string
f_1556_17489_17508(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 17489, 17508);
return return_v;
}


int
f_1556_17219_17509(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 17219, 17509);
return 0;
}


System.Management.Automation.Language.ExpressionAst[]
f_1556_15106_15113_I(System.Management.Automation.Language.ExpressionAst[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 15106, 15113);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,14793,17745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,14793,17745);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,17757,18015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,17869,17959);

f_1556_17869_17958(this, f_1556_17886_17912(typeExpressionAst), genericArgumentCount: 0, isAttribute: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,17973,18004);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,17757,18015);

System.Management.Automation.Language.ITypeName
f_1556_17886_17912(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 17886, 17912);
return return_v;
}


bool
f_1556_17869_17958(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount: genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 17869, 17958);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,17757,18015);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,17757,18015);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,18027,18285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,18139,18229);

f_1556_18139_18228(this, f_1556_18156_18182(typeConstraintAst), genericArgumentCount: 0, isAttribute: false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,18243,18274);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,18027,18285);

System.Management.Automation.Language.ITypeName
f_1556_18156_18182(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 18156, 18182);
return return_v;
}


bool
f_1556_18139_18228(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount: genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 18139, 18228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,18027,18285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,18027,18285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Collection<PSModuleInfo> GetModulesFromUsingModule(UsingStatementAst usingStatementAst, out Exception exception, out bool wildcardCharactersUsed, out bool isConstant)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,19244,22464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19443,19460);

exception = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19474,19505);

wildcardCharactersUsed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19519,19537);

isConstant = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19615,19641);

object 
fullyQualifiedName
=default(object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19655,21779) || true) && (f_1556_19659_19696(usingStatementAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,19655,21779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19738,19758);

object 
resultObject
=default(object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19776,20025) || true) && (!f_1556_19781_19911(f_1556_19815_19852(usingStatementAst), out resultObject, forAttribute: false, forRequires: true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,19776,20025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19953,19972);

isConstant = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,19994,20006);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,19776,20025);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20045,20106);

var 
hashtable = resultObject as System.Collections.Hashtable
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20124,20159);

var 
ms = f_1556_20133_20158()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20177,20254);

exception = f_1556_20189_20253(ms, hashtable);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20272,20366) || true) && (exception != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,20272,20366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20335,20347);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,20272,20366);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20386,20566) || true) && (f_1556_20390_20441(f_1556_20433_20440(ms)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,20386,20566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20483,20513);

wildcardCharactersUsed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20535,20547);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,20386,20566);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20586,20610);

fullyQualifiedName = ms;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,19655,21779);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,19655,21779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20676,20736);

string 
fullyQualifiedNameStr = f_1556_20707_20735(f_1556_20707_20729(usingStatementAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20756,20950) || true) && (f_1556_20760_20825(fullyQualifiedNameStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,20756,20950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20867,20897);

wildcardCharactersUsed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,20919,20931);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,20756,20950);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21068,21119);

bool 
isPath = f_1556_21082_21118(fullyQualifiedNameStr, @"\")
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21137,21510) || true) && (isPath &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 21141, 21205)&&!f_1556_21152_21205(fullyQualifiedNameStr)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,21137,21510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21247,21306);

string 
rootPath = f_1556_21265_21305(_parser._fileName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21328,21491) || true) && (rootPath != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,21328,21491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21398,21468);

fullyQualifiedNameStr = f_1556_21422_21467(rootPath, fullyQualifiedNameStr);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,21328,21491);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,21137,21510);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21721,21764);

fullyQualifiedName = fullyQualifiedNameStr;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,19655,21779);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21795,21868);

var 
commandInfo = f_1556_21813_21867("Get-Module", typeof(GetModuleCommand))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,21971,22020);

f_1556_21971_22019(f_1556_21971_22011(f_1556_21971_22002()));
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22070,22313);

return f_1556_22077_22312(f_1556_22077_22267(f_1556_22077_22209(f_1556_22077_22132(f_1556_22077_22108(), commandInfo), "FullyQualifiedName", fullyQualifiedName), "ListAvailable", true));
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1556,22342,22453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22394,22408);

exception = e;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22426,22438);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(1556,22342,22453);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,19244,22464);

System.Management.Automation.Language.HashtableAst
f_1556_19659_19696(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.ModuleSpecification ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 19659, 19696);
return return_v;
}


System.Management.Automation.Language.HashtableAst
f_1556_19815_19852(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.ModuleSpecification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 19815, 19852);
return return_v;
}


bool
f_1556_19781_19911(System.Management.Automation.Language.HashtableAst
ast,out object
constantValue,bool
forAttribute,bool
forRequires)
{
var return_v = IsConstantValueVisitor.IsConstant( (System.Management.Automation.Language.Ast)ast, out constantValue, forAttribute: forAttribute, forRequires: forRequires);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 19781, 19911);
return return_v;
}


Microsoft.PowerShell.Commands.ModuleSpecification
f_1556_20133_20158()
{
var return_v = new Microsoft.PowerShell.Commands.ModuleSpecification();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 20133, 20158);
return return_v;
}


System.Exception
f_1556_20189_20253(Microsoft.PowerShell.Commands.ModuleSpecification
moduleSpecification,System.Collections.Hashtable
hashtable)
{
var return_v = ModuleSpecification.ModuleSpecificationInitHelper( moduleSpecification, hashtable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 20189, 20253);
return return_v;
}


string
f_1556_20433_20440(Microsoft.PowerShell.Commands.ModuleSpecification
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 20433, 20440);
return return_v;
}


bool
f_1556_20390_20441(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 20390, 20441);
return return_v;
}


System.Management.Automation.Language.StringConstantExpressionAst
f_1556_20707_20729(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 20707, 20729);
return return_v;
}


string
f_1556_20707_20735(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 20707, 20735);
return return_v;
}


bool
f_1556_20760_20825(string
pattern)
{
var return_v = WildcardPattern.ContainsWildcardCharacters( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 20760, 20825);
return return_v;
}


bool
f_1556_21082_21118(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21082, 21118);
return return_v;
}


bool
f_1556_21152_21205(string
path)
{
var return_v = LocationGlobber.IsAbsolutePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21152, 21205);
return return_v;
}


string?
f_1556_21265_21305(string
path)
{
var return_v = Path.GetDirectoryName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21265, 21305);
return return_v;
}


string
f_1556_21422_21467(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21422, 21467);
return return_v;
}


System.Management.Automation.CmdletInfo
f_1556_21813_21867(string
name,System.Type
implementingType)
{
var return_v = new System.Management.Automation.CmdletInfo( name, implementingType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21813, 21867);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_21971_22002()
{
var return_v =             // TODO(sevoroby): we should consider an async call with cancellation here.
            UsingStatementResolvePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 21971, 22002);
return return_v;
}


System.Management.Automation.PSCommand
f_1556_21971_22011(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Commands;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 21971, 22011);
return return_v;
}


int
f_1556_21971_22019(System.Management.Automation.PSCommand
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 21971, 22019);
return 0;
}


System.Management.Automation.PowerShell
f_1556_22077_22108()
{
var return_v = UsingStatementResolvePowerShell;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 22077, 22108);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_22077_22132(System.Management.Automation.PowerShell
this_param,System.Management.Automation.CmdletInfo
commandInfo)
{
var return_v = this_param.AddCommand( (System.Management.Automation.CommandInfo)commandInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 22077, 22132);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_22077_22209(System.Management.Automation.PowerShell
this_param,string
parameterName,object
value)
{
var return_v = this_param.AddParameter( parameterName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 22077, 22209);
return return_v;
}


System.Management.Automation.PowerShell
f_1556_22077_22267(System.Management.Automation.PowerShell
this_param,string
parameterName,bool
value)
{
var return_v = this_param.AddParameter( parameterName, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 22077, 22267);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1556_22077_22312(System.Management.Automation.PowerShell
this_param)
{
var return_v = this_param.Invoke<System.Management.Automation.PSModuleInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 22077, 22312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,19244,22464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,19244,22464);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingStatement(UsingStatementAst usingStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,22476,25446);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22588,25388) || true) && (f_1556_22592_22628(usingStatementAst)== UsingStatementKind.Module)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,22588,25388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22691,22711);

Exception 
exception
=default(Exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22729,22757);

bool 
wildcardCharactersUsed
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22775,22791);

bool 
isConstant
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22809,22930);

var 
moduleInfo = f_1556_22826_22929(this, usingStatementAst, out exception, out wildcardCharactersUsed, out isConstant)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,22948,25373) || true) && (!isConstant)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,22948,25373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23005,23201);

f_1556_23005_23200(                    _parser, f_1556_23025_23049(usingStatementAst), nameof(ParserStrings.RequiresArgumentMustBeConstant), f_1556_23155_23199());
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,22948,25373);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,22948,25373);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23243,25373) || true) && (exception != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23243,25373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23422,23644);

f_1556_23422_23643(                    // we re-using RequiresModuleInvalid string, semantic is very similar so it's fine to do that.
                    _parser, f_1556_23442_23466(usingStatementAst), nameof(ParserStrings.RequiresModuleInvalid), f_1556_23563_23598(), f_1556_23625_23642(exception));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23243,25373);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23243,25373);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23686,25373) || true) && (wildcardCharactersUsed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23686,25373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23754,23936);

f_1556_23754_23935(                    _parser, f_1556_23774_23798(usingStatementAst), nameof(ParserStrings.WildCardModuleNameError), f_1556_23897_23934());
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23686,25373);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23686,25373);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,23978,25373) || true) && (moduleInfo != null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 23982, 24024)&&f_1556_24004_24020(moduleInfo)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23978,25373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,24515,24589);

var 
exportedTypes = f_1556_24535_24588(usingStatementAst, f_1556_24574_24587(moduleInfo, 0))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,24611,24791);
foreach(var typePairs in f_1556_24637_24650_I(exportedTypes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,24611,24791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,24700,24768);

f_1556_24700_24767(                        _symbolTable, typePairs.Value, f_1556_24753_24766(moduleInfo, 0));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,24611,24791);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,181);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23978,25373);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,23978,25373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,24975,25109);

string 
moduleText = (DynAbs.Tracing.TraceSender.Conditional_F1(1556, 24995, 25025)||((f_1556_24995_25017(usingStatementAst)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(1556, 25028, 25056))||DynAbs.Tracing.TraceSender.Conditional_F3(1556, 25059, 25108)))?f_1556_25028_25056(f_1556_25028_25050(usingStatementAst)):f_1556_25059_25108(f_1556_25059_25103(f_1556_25059_25096(usingStatementAst)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25131,25354);

f_1556_25131_25353(                    _parser, f_1556_25151_25175(usingStatementAst), nameof(ParserStrings.ModuleNotFoundDuringParse), f_1556_25276_25315(), moduleText);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23978,25373);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23686,25373);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,23243,25373);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,22948,25373);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,22588,25388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25404,25435);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,22476,25446);

System.Management.Automation.Language.UsingStatementKind
f_1556_22592_22628(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.UsingStatementKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 22592, 22628);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
f_1556_22826_22929(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.UsingStatementAst
usingStatementAst,out System.Exception
exception,out bool
wildcardCharactersUsed,out bool
isConstant)
{
var return_v = this_param.GetModulesFromUsingModule( usingStatementAst, out exception, out wildcardCharactersUsed, out isConstant);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 22826, 22929);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_23025_23049(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23025, 23049);
return return_v;
}


string
f_1556_23155_23199()
{
var return_v =                         ParserStrings.RequiresArgumentMustBeConstant;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23155, 23199);
return return_v;
}


int
f_1556_23005_23200(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 23005, 23200);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1556_23442_23466(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23442, 23466);
return return_v;
}


string
f_1556_23563_23598()
{
var return_v =                         ParserStrings.RequiresModuleInvalid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23563, 23598);
return return_v;
}


string
f_1556_23625_23642(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23625, 23642);
return return_v;
}


int
f_1556_23422_23643(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 23422, 23643);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1556_23774_23798(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23774, 23798);
return return_v;
}


string
f_1556_23897_23934()
{
var return_v =                         ParserStrings.WildCardModuleNameError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 23897, 23934);
return return_v;
}


int
f_1556_23754_23935(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 23754, 23935);
return 0;
}


int
f_1556_24004_24020(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 24004, 24020);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1556_24574_24587(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 24574, 24587);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
f_1556_24535_24588(System.Management.Automation.Language.UsingStatementAst
this_param,System.Management.Automation.PSModuleInfo
moduleInfo)
{
var return_v = this_param.DefineImportedModule( moduleInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 24535, 24588);
return return_v;
}


System.Management.Automation.PSModuleInfo
f_1556_24753_24766(System.Collections.ObjectModel.Collection<System.Management.Automation.PSModuleInfo>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 24753, 24766);
return return_v;
}


int
f_1556_24700_24767(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst,System.Management.Automation.PSModuleInfo
moduleInfo)
{
this_param.AddTypeFromUsingModule( typeDefinitionAst, moduleInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 24700, 24767);
return 0;
}


System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
f_1556_24637_24650_I(System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.Language.TypeDefinitionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 24637, 24650);
return return_v;
}


System.Management.Automation.Language.StringConstantExpressionAst
f_1556_24995_25017(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 24995, 25017);
return return_v;
}


System.Management.Automation.Language.StringConstantExpressionAst
f_1556_25028_25050(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25028, 25050);
return return_v;
}


string
f_1556_25028_25056(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25028, 25056);
return return_v;
}


System.Management.Automation.Language.HashtableAst
f_1556_25059_25096(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.ModuleSpecification;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25059, 25096);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_25059_25103(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25059, 25103);
return return_v;
}


string
f_1556_25059_25108(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25059, 25108);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_25151_25175(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25151, 25175);
return return_v;
}


string
f_1556_25276_25315()
{
var return_v =                         ParserStrings.ModuleNotFoundDuringParse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25276, 25315);
return return_v;
}


int
f_1556_25131_25353(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 25131, 25353);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,22476,25446);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,22476,25446);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttribute(AttributeAst attributeAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,25458,25695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25555,25639);

f_1556_25555_25638(this, f_1556_25572_25593(attributeAst), genericArgumentCount: 0, isAttribute: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25653,25684);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,25458,25695);

System.Management.Automation.Language.ITypeName
f_1556_25572_25593(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 25572, 25593);
return return_v;
}


bool
f_1556_25555_25638(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount: genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 25555, 25638);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,25458,25695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,25458,25695);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool DispatchTypeName(ITypeName type, int genericArgumentCount, bool isAttribute)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,25707,26652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25821,25869);

f_1556_25821_25868();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25883,25915);

var 
typeName = type as TypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25929,26612) || true) && (typeName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,25929,26612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,25983,26049);

return f_1556_25990_26048(this, typeName, genericArgumentCount, isAttribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,25929,26612);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,25929,26612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26115,26157);

var 
arrayTypeName = type as ArrayTypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26175,26597) || true) && (arrayTypeName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,26175,26597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26242,26283);

return f_1556_26249_26282(this, arrayTypeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,26175,26597);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,26175,26597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26365,26411);

var 
genericTypeName = type as GenericTypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26433,26578) || true) && (genericTypeName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,26433,26578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26510,26555);

return f_1556_26517_26554(this, genericTypeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,26433,26578);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,26175,26597);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,25929,26612);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26628,26641);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,25707,26652);

int
f_1556_25821_25868()
{
RuntimeHelpers.EnsureSufficientExecutionStack();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 25821, 25868);
return 0;
}


bool
f_1556_25990_26048(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.TypeName
typeName,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.VisitTypeName( typeName, genericArgumentCount, isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 25990, 26048);
return return_v;
}


bool
f_1556_26249_26282(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ArrayTypeName
arrayTypeName)
{
var return_v = this_param.VisitArrayTypeName( arrayTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 26249, 26282);
return return_v;
}


bool
f_1556_26517_26554(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.GenericTypeName
genericTypeName)
{
var return_v = this_param.VisitGenericTypeName( genericTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 26517, 26554);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,25707,26652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,25707,26652);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool VisitArrayTypeName(ArrayTypeName arrayTypeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,26664,27108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26749,26854);

bool 
resolved = f_1556_26765_26853(this, f_1556_26782_26807(arrayTypeName), genericArgumentCount: 0, isAttribute: false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26868,27065) || true) && (resolved)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,26868,27065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26914,26967);

var 
resolvedType = f_1556_26933_26966(arrayTypeName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,26985,27050);

f_1556_26985_27049(arrayTypeName, _typeResolutionState, resolvedType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,26868,27065);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27081,27097);

return resolved;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,26664,27108);

System.Management.Automation.Language.ITypeName
f_1556_26782_26807(System.Management.Automation.Language.ArrayTypeName
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 26782, 26807);
return return_v;
}


bool
f_1556_26765_26853(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount: genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 26765, 26853);
return return_v;
}


System.Type
f_1556_26933_26966(System.Management.Automation.Language.ArrayTypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 26933, 26966);
return return_v;
}


int
f_1556_26985_27049(System.Management.Automation.Language.ArrayTypeName
typeName,System.Management.Automation.Language.TypeResolutionState
typeResolutionState,System.Type
type)
{
TypeCache.Add( (System.Management.Automation.Language.ITypeName)typeName, typeResolutionState, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 26985, 27049);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,26664,27108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,26664,27108);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool VisitTypeName(TypeName typeName, int genericArgumentCount, bool isAttribute)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,27120,29762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27234,27284);

var 
classDefn = f_1556_27250_27283(_symbolTable, typeName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27300,29722) || true) && (classDefn != null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 27304, 27348)&&f_1556_27325_27348(classDefn)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,27300,29722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27382,27767);

f_1556_27382_27766(                _parser, f_1556_27402_27417(typeName), nameof(ParserStrings.AmbiguousTypeReference), f_1556_27507_27543(), f_1556_27566_27579(typeName), f_1556_27602_27672(f_1556_27625_27656(f_1556_27625_27653(classDefn), 0), f_1556_27658_27671(typeName)), f_1556_27695_27765(f_1556_27718_27749(f_1556_27718_27746(classDefn), 1), f_1556_27751_27764(typeName)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,27300,29722);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,27300,29722);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27801,29722) || true) && (classDefn != null &&(DynAbs.Tracing.TraceSender.Expression_True(1556, 27805, 27851)&&genericArgumentCount == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,27801,29722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27885,27928);

f_1556_27885_27927(                typeName, f_1556_27912_27926(classDefn));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,27801,29722);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,27801,29722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,27994,28006);

Exception 
e
=default(Exception);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28024,28238);

TypeResolutionState 
trs = (DynAbs.Tracing.TraceSender.Conditional_F1(1556, 28050, 28089)||((genericArgumentCount > 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1556, 28050, 28089)||isAttribute
)&&DynAbs.Tracing.TraceSender.Conditional_F2(1556, 28113, 28193))||DynAbs.Tracing.TraceSender.Conditional_F3(1556, 28217, 28237)))?f_1556_28113_28193(_typeResolutionState, genericArgumentCount, isAttribute):_typeResolutionState
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28258,28337);

var 
type = f_1556_28269_28336(typeName, out e, null, trs)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28355,29707) || true) && (type == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28355,29707);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28413,29521) || true) && (f_1556_28417_28459(_symbolTable)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28413,29521);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28611,29498) || true) && (!f_1556_28616_28713(f_1556_28616_28633(typeName), LanguagePrimitives.OrderedAttribute, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28611,29498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28771,28786);

string 
errorId
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28816,28832);

string 
errorMsg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28862,29368) || true) && (isAttribute)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28862,29368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,28943,29003);

errorId = nameof(ParserStrings.CustomAttributeTypeNotFound);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29037,29090);

errorMsg = f_1556_29048_29089();
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28862,29368);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28862,29368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29220,29265);

errorId = nameof(ParserStrings.TypeNotFound);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29299,29337);

errorMsg = f_1556_29310_29336();
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28862,29368);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29400,29471);

f_1556_29400_29470(
                            _parser, f_1556_29420_29435(typeName), errorId, errorMsg, f_1556_29456_29469(typeName));
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28611,29498);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28413,29521);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28355,29707);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,28355,29707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29603,29654);

((ISupportsTypeCaching)typeName).CachedType = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29676,29688);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,28355,29707);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,27801,29722);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,27300,29722);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29738,29751);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,27120,29762);

System.Management.Automation.Language.TypeLookupResult
f_1556_27250_27283(System.Management.Automation.Language.SymbolTable
this_param,System.Management.Automation.Language.TypeName
typeName)
{
var return_v = this_param.LookupType( typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27250, 27283);
return return_v;
}


bool
f_1556_27325_27348(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.IsAmbiguous();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27325, 27348);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_27402_27417(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27402, 27417);
return return_v;
}


string
f_1556_27507_27543()
{
var return_v =                     ParserStrings.AmbiguousTypeReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27507, 27543);
return return_v;
}


string
f_1556_27566_27579(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27566, 27579);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_27625_27653(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27625, 27653);
return return_v;
}


string
f_1556_27625_27656(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27625, 27656);
return return_v;
}


string
f_1556_27658_27671(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27658, 27671);
return return_v;
}


string
f_1556_27602_27672(string
namespaceName,string
typeName)
{
var return_v = GetModuleQualifiedName( namespaceName, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27602, 27672);
return return_v;
}


System.Collections.Generic.List<string>
f_1556_27718_27746(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.ExternalNamespaces;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27718, 27746);
return return_v;
}


string
f_1556_27718_27749(System.Collections.Generic.List<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27718, 27749);
return return_v;
}


string
f_1556_27751_27764(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27751, 27764);
return return_v;
}


string
f_1556_27695_27765(string
namespaceName,string
typeName)
{
var return_v = GetModuleQualifiedName( namespaceName, typeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27695, 27765);
return return_v;
}


int
f_1556_27382_27766(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27382, 27766);
return 0;
}


System.Management.Automation.Language.TypeDefinitionAst
f_1556_27912_27926(System.Management.Automation.Language.TypeLookupResult
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 27912, 27926);
return return_v;
}


int
f_1556_27885_27927(System.Management.Automation.Language.TypeName
this_param,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst)
{
this_param.SetTypeDefinition( typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 27885, 27927);
return 0;
}


System.Management.Automation.Language.TypeResolutionState
f_1556_28113_28193(System.Management.Automation.Language.TypeResolutionState
other,int
genericArgumentCount,bool
attribute)
{
var return_v = new System.Management.Automation.Language.TypeResolutionState( other, genericArgumentCount, attribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 28113, 28193);
return return_v;
}


System.Type
f_1556_28269_28336(System.Management.Automation.Language.TypeName
typeName,out System.Exception
exception,System.Reflection.Assembly[]
assemblies,System.Management.Automation.Language.TypeResolutionState
typeResolutionState)
{
var return_v = TypeResolver.ResolveTypeNameWithContext( typeName, out exception, assemblies, typeResolutionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 28269, 28336);
return return_v;
}


System.Management.Automation.Language.TypeDefinitionAst
f_1556_28417_28459(System.Management.Automation.Language.SymbolTable
this_param)
{
var return_v = this_param.GetCurrentTypeDefinitionAst();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 28417, 28459);
return return_v;
}


string
f_1556_28616_28633(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 28616, 28633);
return return_v;
}


bool
f_1556_28616_28713(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 28616, 28713);
return return_v;
}


string
f_1556_29048_29089()
{
var return_v = ParserStrings.CustomAttributeTypeNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 29048, 29089);
return return_v;
}


string
f_1556_29310_29336()
{
var return_v = ParserStrings.TypeNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 29310, 29336);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1556_29420_29435(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 29420, 29435);
return return_v;
}


string
f_1556_29456_29469(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 29456, 29469);
return return_v;
}


int
f_1556_29400_29470(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 29400, 29470);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,27120,29762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,27120,29762);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool VisitGenericTypeName(GenericTypeName genericTypeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,29774,30742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29865,29937);

var 
foundType = f_1556_29881_29936(genericTypeName, _typeResolutionState)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,29951,30114) || true) && (foundType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,29951,30114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30006,30069);

((ISupportsTypeCaching)genericTypeName).CachedType = foundType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30087,30099);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,29951,30114);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30130,30151);

bool 
resolved = true
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30165,30280);

resolved &= f_1556_30177_30279(this, f_1556_30194_30218(genericTypeName), f_1556_30220_30258(f_1556_30220_30252(genericTypeName)), isAttribute: false);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30294,30482);
foreach(var typeArg in f_1556_30318_30350_I(f_1556_30318_30350(genericTypeName)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,30294,30482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30384,30467);

resolved &= f_1556_30396_30466(this, typeArg, genericArgumentCount: 0, isAttribute: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,30294,30482);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1556,1,189);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1556,1,189);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30498,30699) || true) && (resolved)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,30498,30699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30544,30599);

var 
resolvedType = f_1556_30563_30598(genericTypeName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30617,30684);

f_1556_30617_30683(genericTypeName, _typeResolutionState, resolvedType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,30498,30699);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30715,30731);

return resolved;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,29774,30742);

System.Type
f_1556_29881_29936(System.Management.Automation.Language.GenericTypeName
typeName,System.Management.Automation.Language.TypeResolutionState
typeResolutionState)
{
var return_v = TypeCache.Lookup( (System.Management.Automation.Language.ITypeName)typeName, typeResolutionState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 29881, 29936);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1556_30194_30218(System.Management.Automation.Language.GenericTypeName
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 30194, 30218);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
f_1556_30220_30252(System.Management.Automation.Language.GenericTypeName
this_param)
{
var return_v = this_param.GenericArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 30220, 30252);
return return_v;
}


int
f_1556_30220_30258(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 30220, 30258);
return return_v;
}


bool
f_1556_30177_30279(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30177, 30279);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
f_1556_30318_30350(System.Management.Automation.Language.GenericTypeName
this_param)
{
var return_v = this_param.GenericArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 30318, 30350);
return return_v;
}


bool
f_1556_30396_30466(System.Management.Automation.Language.SymbolResolver
this_param,System.Management.Automation.Language.ITypeName
type,int
genericArgumentCount,bool
isAttribute)
{
var return_v = this_param.DispatchTypeName( type, genericArgumentCount: genericArgumentCount, isAttribute: isAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30396, 30466);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
f_1556_30318_30350_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ITypeName>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30318, 30350);
return return_v;
}


System.Type
f_1556_30563_30598(System.Management.Automation.Language.GenericTypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30563, 30598);
return return_v;
}


int
f_1556_30617_30683(System.Management.Automation.Language.GenericTypeName
typeName,System.Management.Automation.Language.TypeResolutionState
typeResolutionState,System.Type
type)
{
TypeCache.Add( (System.Management.Automation.Language.ITypeName)typeName, typeResolutionState, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30617, 30683);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,29774,30742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,29774,30742);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void PostVisit(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,30754,30864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30809,30853);

f_1556_30809_30852(            ast, _symbolResolvePostActionVisitor);
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,30754,30864);

object
f_1556_30809_30852(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.SymbolResolvePostActionVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 30809, 30852);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,30754,30864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,30754,30864);
}
		}

internal static string GetModuleQualifiedName(string namespaceName, string typeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1556,30876,31101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,30985,31022);

const char 
NAMESPACE_SEPARATOR = '.'
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31036,31090);

return namespaceName + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (NAMESPACE_SEPARATOR).ToString(),1556,31059,31078)+ typeName;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1556,30876,31101);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,30876,31101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,30876,31101);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SymbolResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1556,9962,31108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,10351,10384);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1556,9962,31108);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,9962,31108);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1556,9962,31108);

System.Management.Automation.Language.SymbolTable
f_1556_12376_12399(System.Management.Automation.Language.Parser
parser)
{
var return_v = new System.Management.Automation.Language.SymbolTable( parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 12376, 12399);
return return_v;
}

}
internal class SymbolResolvePostActionVisitor : DefaultCustomAstVisitor2
{
internal SymbolResolver _symbolResolver;

public override object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,31257,31559);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31373,31520) || true) && (!(f_1556_31379_31407(functionDefinitionAst)is FunctionMemberAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1556,31373,31520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31463,31505);

f_1556_31463_31504(                _symbolResolver._symbolTable);
DynAbs.Tracing.TraceSender.TraceExitCondition(1556,31373,31520);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31536,31548);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,31257,31559);

System.Management.Automation.Language.Ast
f_1556_31379_31407(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1556, 31379, 31407);
return return_v;
}


int
f_1556_31463_31504(System.Management.Automation.Language.SymbolTable
this_param)
{
this_param.LeaveScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 31463, 31504);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,31257,31559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31257,31559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,31571,31775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31696,31738);

f_1556_31696_31737(            _symbolResolver._symbolTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31752,31764);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,31571,31775);

int
f_1556_31696_31737(System.Management.Automation.Language.SymbolTable
this_param)
{
this_param.LeaveScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 31696, 31737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,31571,31775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31571,31775);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,31787,31970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31891,31933);

f_1556_31891_31932(            _symbolResolver._symbolTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31947,31959);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,31787,31970);

int
f_1556_31891_31932(System.Management.Automation.Language.SymbolTable
this_param)
{
this_param.LeaveScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 31891, 31932);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,31787,31970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31787,31970);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override object VisitFunctionMember(FunctionMemberAst functionMemberAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1556,31982,32165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,32086,32128);

f_1556_32086_32127(            _symbolResolver._symbolTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,32142,32154);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(1556,31982,32165);

int
f_1556_32086_32127(System.Management.Automation.Language.SymbolTable
this_param)
{
this_param.LeaveScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1556, 32086, 32127);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1556,31982,32165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31982,32165);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SymbolResolvePostActionVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1556,31116,32172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1556,31229,31244);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1556,31116,32172);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31116,32172);
}


static SymbolResolvePostActionVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1556,31116,32172);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1556,31116,32172);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1556,31116,32172);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1556,31116,32172);
}
}
