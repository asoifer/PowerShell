// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;

namespace System.Management.Automation
{
internal class MamlNode
{
internal MamlNode(XmlNode xmlNode)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1165,2877,2966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,2994,3002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,3304,3314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46672,46753);
this.Errors = f_1165_46723_46752();DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,2936,2955);

_xmlNode = xmlNode;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1165,2877,2966);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,2877,2966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,2877,2966);
}
		}

private XmlNode _xmlNode;

internal XmlNode XmlNode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,3197,3264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,3233,3249);

return _xmlNode;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,3197,3264);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,3148,3275);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,3148,3275);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSObject _mshObject;

internal PSObject PSObject
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,3510,4038);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,3546,3985) || true) && (_mshObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,3546,3985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,3876,3909);

f_1165_3876_3908(this, _xmlNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,3931,3966);

_mshObject = f_1165_3944_3965(this, _xmlNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,3546,3985);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,4005,4023);

return _mshObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,3510,4038);

int
f_1165_3876_3908(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
this_param.RemoveUnsupportedNodes( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 3876, 3908);
return 0;
}


System.Management.Automation.PSObject
f_1165_3944_3965(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetPSObject( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 3944, 3965);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,3459,4049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,3459,4049);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private PSObject GetPSObject(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,8263,9984);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8333,8393) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,8333,8393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8371,8393);

return f_1165_8378_8392();
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,8333,8393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8409,8435);

PSObject 
mshObject = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8451,9658) || true) && (f_1165_8455_8472(xmlNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,8451,9658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8506,8557);

mshObject = f_1165_8518_8556(f_1165_8531_8555(f_1165_8531_8548(xmlNode)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,8451,9658);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,8451,9658);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8591,9658) || true) && (f_1165_8595_8625(xmlNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,8591,9658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8659,8721);

mshObject = f_1165_8671_8720(f_1165_8684_8719(this, xmlNode));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,8591,9658);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,8591,9658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,8787,8840);

mshObject = f_1165_8799_8839(f_1165_8812_8838(this, xmlNode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9015,9043);

f_1165_9015_9042(f_1165_9015_9034(mshObject));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9063,9555) || true) && (f_1165_9067_9093(f_1165_9067_9085(xmlNode), "type")!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9063,9555);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9143,9536) || true) && (f_1165_9147_9240(f_1165_9162_9194(f_1165_9162_9188(f_1165_9162_9180(xmlNode), "type")), "field", StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9143,9536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9272,9325);

f_1165_9272_9324(f_1165_9272_9291(mshObject), "MamlPSClassHelpInfo#field");
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9143,9536);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9143,9536);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9352,9536) || true) && (f_1165_9356_9450(f_1165_9371_9403(f_1165_9371_9397(f_1165_9371_9389(xmlNode), "type")), "method", StringComparison.OrdinalIgnoreCase)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9352,9536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9482,9536);

f_1165_9482_9535(f_1165_9482_9501(mshObject), "MamlPSClassHelpInfo#method");
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9352,9536);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9143,9536);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9063,9555);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9575,9643);

f_1165_9575_9642(f_1165_9575_9594(mshObject), "MamlCommandHelpInfo#" + f_1165_9624_9641(xmlNode));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,8591,9658);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,8451,9658);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9674,9940) || true) && (f_1165_9678_9696(xmlNode)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9674,9940);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9738,9925);
foreach(XmlNode attribute in f_1165_9768_9786_I(f_1165_9768_9786(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,9738,9925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9828,9906);

f_1165_9828_9905(f_1165_9828_9848(mshObject), f_1165_9853_9904(f_1165_9872_9886(attribute), f_1165_9888_9903(attribute)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9738,9925);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,188);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,188);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1165,9674,9940);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,9956,9973);

return mshObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,8263,9984);

System.Management.Automation.PSObject
f_1165_8378_8392()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8378, 8392);
return return_v;
}


bool
f_1165_8455_8472(System.Xml.XmlNode
xmlNode)
{
var return_v = IsAtomic( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8455, 8472);
return return_v;
}


string
f_1165_8531_8548(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 8531, 8548);
return return_v;
}


string
f_1165_8531_8555(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8531, 8555);
return return_v;
}


System.Management.Automation.PSObject
f_1165_8518_8556(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8518, 8556);
return return_v;
}


bool
f_1165_8595_8625(System.Xml.XmlNode
xmlNode)
{
var return_v = IncludeMamlFormatting( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8595, 8625);
return return_v;
}


System.Management.Automation.PSObject[]
f_1165_8684_8719(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetMamlFormattingPSObjects( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8684, 8719);
return return_v;
}


System.Management.Automation.PSObject
f_1165_8671_8720(System.Management.Automation.PSObject[]
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8671, 8720);
return return_v;
}


System.Management.Automation.PSObject
f_1165_8812_8838(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetInsidePSObject( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8812, 8838);
return return_v;
}


System.Management.Automation.PSObject
f_1165_8799_8839(System.Management.Automation.PSObject
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 8799, 8839);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1165_9015_9034(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9015, 9034);
return return_v;
}


int
f_1165_9015_9042(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9015, 9042);
return 0;
}


System.Xml.XmlAttributeCollection
f_1165_9067_9085(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9067, 9085);
return return_v;
}


System.Xml.XmlAttribute
f_1165_9067_9093(System.Xml.XmlAttributeCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9067, 9093);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1165_9162_9180(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9162, 9180);
return return_v;
}


System.Xml.XmlAttribute
f_1165_9162_9188(System.Xml.XmlAttributeCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9162, 9188);
return return_v;
}


string
f_1165_9162_9194(System.Xml.XmlAttribute
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9162, 9194);
return return_v;
}


int
f_1165_9147_9240(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9147, 9240);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1165_9272_9291(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9272, 9291);
return return_v;
}


int
f_1165_9272_9324(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9272, 9324);
return 0;
}


System.Xml.XmlAttributeCollection
f_1165_9371_9389(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9371, 9389);
return return_v;
}


System.Xml.XmlAttribute
f_1165_9371_9397(System.Xml.XmlAttributeCollection
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9371, 9397);
return return_v;
}


string
f_1165_9371_9403(System.Xml.XmlAttribute
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9371, 9403);
return return_v;
}


int
f_1165_9356_9450(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9356, 9450);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1165_9482_9501(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9482, 9501);
return return_v;
}


int
f_1165_9482_9535(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9482, 9535);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_9575_9594(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9575, 9594);
return return_v;
}


string
f_1165_9624_9641(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9624, 9641);
return return_v;
}


int
f_1165_9575_9642(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9575, 9642);
return 0;
}


System.Xml.XmlAttributeCollection
f_1165_9678_9696(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9678, 9696);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1165_9768_9786(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9768, 9786);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_9828_9848(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9828, 9848);
return return_v;
}


string
f_1165_9872_9886(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9872, 9886);
return return_v;
}


string
f_1165_9888_9903(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 9888, 9903);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_9853_9904(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9853, 9904);
return return_v;
}


int
f_1165_9828_9905(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9828, 9905);
return 0;
}


System.Xml.XmlAttributeCollection
f_1165_9768_9786_I(System.Xml.XmlAttributeCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 9768, 9786);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,8263,9984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,8263,9984);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject GetInsidePSObject(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,10967,11449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11043,11095);

Hashtable 
properties = f_1165_11066_11094(this, xmlNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11111,11147);

PSObject 
mshObject = f_1165_11132_11146()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11163,11225);

IDictionaryEnumerator 
enumerator = f_1165_11198_11224(properties)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11241,11405) || true) && (f_1165_11248_11269(enumerator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,11241,11405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11303,11390);

f_1165_11303_11389(f_1165_11303_11323(mshObject), f_1165_11328_11388((string)f_1165_11355_11369(enumerator), f_1165_11371_11387(enumerator)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,11241,11405);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,11241,11405);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,11241,11405);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,11421,11438);

return mshObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,10967,11449);

System.Collections.Hashtable
f_1165_11066_11094(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetInsideProperties( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11066, 11094);
return return_v;
}


System.Management.Automation.PSObject
f_1165_11132_11146()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11132, 11146);
return return_v;
}


System.Collections.IDictionaryEnumerator
f_1165_11198_11224(System.Collections.Hashtable
this_param)
{
var return_v = this_param.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11198, 11224);
return return_v;
}


bool
f_1165_11248_11269(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11248, 11269);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_11303_11323(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 11303, 11323);
return return_v;
}


object
f_1165_11355_11369(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.Key;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 11355, 11369);
return return_v;
}


object
f_1165_11371_11387(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 11371, 11387);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_11328_11388(object
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( (string)name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11328, 11388);
return return_v;
}


int
f_1165_11303_11389(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 11303, 11389);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,10967,11449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,10967,11449);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Hashtable GetInsideProperties(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,12840,13400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,12919,12990);

Hashtable 
properties = f_1165_12942_12989(f_1165_12956_12988())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13006,13062) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,13006,13062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13044,13062);

return properties;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,13006,13062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13078,13335) || true) && (f_1165_13082_13100(xmlNode)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,13078,13335);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13142,13320);
foreach(XmlNode childNode in f_1165_13172_13190_I(f_1165_13172_13190(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,13142,13320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13232,13301);

f_1165_13232_13300(properties, f_1165_13256_13275(childNode), f_1165_13277_13299(this, childNode));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,13142,13320);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,179);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,179);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1165,13078,13335);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13351,13389);

return f_1165_13358_13388(properties);
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,12840,13400);

System.StringComparer
f_1165_12956_12988()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 12956, 12988);
return return_v;
}


System.Collections.Hashtable
f_1165_12942_12989(System.StringComparer
equalityComparer)
{
var return_v = new System.Collections.Hashtable( (System.Collections.IEqualityComparer)equalityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 12942, 12989);
return return_v;
}


System.Xml.XmlNodeList
f_1165_13082_13100(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 13082, 13100);
return return_v;
}


System.Xml.XmlNodeList
f_1165_13172_13190(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 13172, 13190);
return return_v;
}


string
f_1165_13256_13275(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 13256, 13275);
return return_v;
}


System.Management.Automation.PSObject
f_1165_13277_13299(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetPSObject( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 13277, 13299);
return return_v;
}


int
f_1165_13232_13300(System.Collections.Hashtable
properties,string
name,System.Management.Automation.PSObject
mshObject)
{
AddProperty( properties, name, mshObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 13232, 13300);
return 0;
}


System.Xml.XmlNodeList
f_1165_13172_13190_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 13172, 13190);
return return_v;
}


System.Collections.Hashtable
f_1165_13358_13388(System.Collections.Hashtable
properties)
{
var return_v = SimplifyProperties( properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 13358, 13388);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,12840,13400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,12840,13400);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void RemoveUnsupportedNodes(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,13703,14663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13938,13977);

XmlNode 
childNode = f_1165_13958_13976(xmlNode)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,13991,14652) || true) && (childNode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,13991,14652);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14104,14637) || true) && (f_1165_14108_14126(childNode)== XmlNodeType.Comment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,14104,14637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14191,14224);

XmlNode 
nodeToRemove = childNode
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14246,14280);

childNode = f_1165_14258_14279(childNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14369,14403);

f_1165_14369_14402(                    // Remove this node and its children if any..
                    xmlNode, nodeToRemove);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,14104,14637);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,14104,14637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14528,14562);

f_1165_14528_14561(this, childNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,14584,14618);

childNode = f_1165_14596_14617(childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,14104,14637);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,13991,14652);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,13991,14652);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,13991,14652);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1165,13703,14663);

System.Xml.XmlNode
f_1165_13958_13976(System.Xml.XmlNode
this_param)
{
var return_v = this_param.FirstChild;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 13958, 13976);
return return_v;
}


System.Xml.XmlNodeType
f_1165_14108_14126(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NodeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 14108, 14126);
return return_v;
}


System.Xml.XmlNode
f_1165_14258_14279(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NextSibling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 14258, 14279);
return return_v;
}


System.Xml.XmlNode
f_1165_14369_14402(System.Xml.XmlNode
this_param,System.Xml.XmlNode
oldChild)
{
var return_v = this_param.RemoveChild( oldChild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 14369, 14402);
return return_v;
}


int
f_1165_14528_14561(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
this_param.RemoveUnsupportedNodes( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 14528, 14561);
return 0;
}


System.Xml.XmlNode
f_1165_14596_14617(System.Xml.XmlNode
this_param)
{
var return_v = this_param.NextSibling;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 14596, 14617);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,13703,14663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,13703,14663);
}
		}

private static void AddProperty(Hashtable properties, string name, PSObject mshObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,16264,17143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16375,16430);

ArrayList 
propertyValues = (ArrayList)f_1165_16413_16429(properties, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16446,16608) || true) && (propertyValues == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,16446,16608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16506,16539);

propertyValues = f_1165_16523_16538();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16559,16593);

properties[name] = propertyValues;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,16446,16608);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16624,16671) || true) && (mshObject == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,16624,16671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16664,16671);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,16624,16671);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16687,16895) || true) && (f_1165_16691_16711(mshObject)is PSCustomObject ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 16691, 16791)||!f_1165_16734_16791(f_1165_16734_16764(f_1165_16734_16754(mshObject)), typeof(PSObject[]))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,16687,16895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16825,16855);

f_1165_16825_16854(                propertyValues, mshObject);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16873,16880);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,16687,16895);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16911,16968);

PSObject[] 
mshObjects = (PSObject[])f_1165_16947_16967(mshObject)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16993,16998);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,16984,17109) || true) && (i < f_1165_17004_17021(mshObjects))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17023,17026)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,16984,17109))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,16984,17109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17060,17094);

f_1165_17060_17093(                propertyValues, mshObjects[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,126);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,126);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17125,17132);

return;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,16264,17143);

object
f_1165_16413_16429(System.Collections.Hashtable
this_param,object
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 16413, 16429);
return return_v;
}


System.Collections.ArrayList
f_1165_16523_16538()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 16523, 16538);
return return_v;
}


object
f_1165_16691_16711(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 16691, 16711);
return return_v;
}


object
f_1165_16734_16754(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 16734, 16754);
return return_v;
}


System.Type
f_1165_16734_16764(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 16734, 16764);
return return_v;
}


bool
f_1165_16734_16791(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 16734, 16791);
return return_v;
}


int
f_1165_16825_16854(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 16825, 16854);
return return_v;
}


object
f_1165_16947_16967(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.BaseObject;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 16947, 16967);
return return_v;
}


int
f_1165_17004_17021(System.Management.Automation.PSObject[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 17004, 17021);
return return_v;
}


int
f_1165_17060_17093(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 17060, 17093);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,16264,17143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,16264,17143);
}
		}

private static Hashtable SimplifyProperties(Hashtable properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,17660,18914);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17750,17803) || true) && (properties == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,17750,17803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17791,17803);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,17750,17803);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17819,17886);

Hashtable 
result = f_1165_17838_17885(f_1165_17852_17884())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17900,17962);

IDictionaryEnumerator 
enumerator = f_1165_17935_17961(properties)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,17978,18873) || true) && (f_1165_17985_18006(enumerator))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,17978,18873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18040,18095);

ArrayList 
propertyValues = (ArrayList)f_1165_18078_18094(enumerator)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18115,18202) || true) && (propertyValues == null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 18119, 18170)||f_1165_18145_18165(propertyValues)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,18115,18202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18193,18202);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,18115,18202);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18222,18772) || true) && (f_1165_18226_18246(propertyValues)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,18222,18772);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18293,18753) || true) && (!f_1165_18298_18351(f_1165_18333_18350(propertyValues, 0)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,18293,18753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18401,18450);

PSObject 
mshObject = (PSObject)f_1165_18432_18449(propertyValues, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18658,18693);

result[f_1165_18665_18679(enumerator)] = mshObject;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18721,18730);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,18293,18753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,18222,18772);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18792,18858);

result[f_1165_18799_18813(enumerator)] = f_1165_18817_18857(propertyValues, typeof(PSObject));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,17978,18873);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,17978,18873);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,17978,18873);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,18889,18903);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,17660,18914);

System.StringComparer
f_1165_17852_17884()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 17852, 17884);
return return_v;
}


System.Collections.Hashtable
f_1165_17838_17885(System.StringComparer
equalityComparer)
{
var return_v = new System.Collections.Hashtable( (System.Collections.IEqualityComparer)equalityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 17838, 17885);
return return_v;
}


System.Collections.IDictionaryEnumerator
f_1165_17935_17961(System.Collections.Hashtable
this_param)
{
var return_v = this_param.GetEnumerator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 17935, 17961);
return return_v;
}


bool
f_1165_17985_18006(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.MoveNext();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 17985, 18006);
return return_v;
}


object
f_1165_18078_18094(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18078, 18094);
return return_v;
}


int
f_1165_18145_18165(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18145, 18165);
return return_v;
}


int
f_1165_18226_18246(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18226, 18246);
return return_v;
}


object
f_1165_18333_18350(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18333, 18350);
return return_v;
}


bool
f_1165_18298_18351(object
mshObject)
{
var return_v = IsMamlFormattingPSObject( (System.Management.Automation.PSObject)mshObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 18298, 18351);
return return_v;
}


object
f_1165_18432_18449(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18432, 18449);
return return_v;
}


object
f_1165_18665_18679(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.Key;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18665, 18679);
return return_v;
}


object
f_1165_18799_18813(System.Collections.IDictionaryEnumerator
this_param)
{
var return_v = this_param.Key;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 18799, 18813);
return return_v;
}


System.Array
f_1165_18817_18857(System.Collections.ArrayList
this_param,System.Type
type)
{
var return_v = this_param.ToArray( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 18817, 18857);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,17660,18914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,17660,18914);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsAtomic(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,19127,19631);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19197,19248) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,19197,19248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19235,19248);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,19197,19248);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19264,19325) || true) && (f_1165_19268_19286(xmlNode)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,19264,19325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19313,19325);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,19264,19325);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19341,19405) || true) && (f_1165_19345_19369(f_1165_19345_19363(xmlNode))> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,19341,19405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19392,19405);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,19341,19405);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19421,19485) || true) && (f_1165_19425_19449(f_1165_19425_19443(xmlNode))== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,19421,19485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19473,19485);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,19421,19485);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19501,19591) || true) && (f_1165_19505_19560(f_1165_19505_19536(f_1165_19505_19526(f_1165_19505_19523(xmlNode), 0)), typeof(XmlText)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,19501,19591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19579,19591);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,19501,19591);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,19607,19620);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,19127,19631);

System.Xml.XmlNodeList
f_1165_19268_19286(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19268, 19286);
return return_v;
}


System.Xml.XmlNodeList
f_1165_19345_19363(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19345, 19363);
return return_v;
}


int
f_1165_19345_19369(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19345, 19369);
return return_v;
}


System.Xml.XmlNodeList
f_1165_19425_19443(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19425, 19443);
return return_v;
}


int
f_1165_19425_19449(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19425, 19449);
return return_v;
}


System.Xml.XmlNodeList
f_1165_19505_19523(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19505, 19523);
return return_v;
}


System.Xml.XmlNode
f_1165_19505_19526(System.Xml.XmlNodeList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 19505, 19526);
return return_v;
}


System.Type
f_1165_19505_19536(System.Xml.XmlNode
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 19505, 19536);
return return_v;
}


bool
f_1165_19505_19560(System.Type
this_param,System.Type
o)
{
var return_v = this_param.Equals( o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 19505, 19560);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,19127,19631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,19127,19631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IncludeMamlFormatting(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,19925,20431);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20008,20059) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20008,20059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20046,20059);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20008,20059);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20075,20170) || true) && (f_1165_20079_20097(xmlNode)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 20079, 20138)||f_1165_20109_20133(f_1165_20109_20127(xmlNode))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20075,20170);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20157,20170);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20075,20170);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20186,20391);
foreach(XmlNode childNode in f_1165_20216_20234_I(f_1165_20216_20234(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20186,20391);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20268,20376) || true) && (f_1165_20272_20303(childNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20268,20376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20345,20357);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20268,20376);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20186,20391);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,206);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,206);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20407,20420);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,19925,20431);

System.Xml.XmlNodeList
f_1165_20079_20097(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20079, 20097);
return return_v;
}


System.Xml.XmlNodeList
f_1165_20109_20127(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20109, 20127);
return return_v;
}


int
f_1165_20109_20133(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20109, 20133);
return return_v;
}


System.Xml.XmlNodeList
f_1165_20216_20234(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20216, 20234);
return return_v;
}


bool
f_1165_20272_20303(System.Xml.XmlNode
xmlNode)
{
var return_v = IsMamlFormattingNode( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 20272, 20303);
return return_v;
}


System.Xml.XmlNodeList
f_1165_20216_20234_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 20216, 20234);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,19925,20431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,19925,20431);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsMamlFormattingNode(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,20741,21214);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20823,20926) || true) && (f_1165_20827_20895(f_1165_20827_20844(xmlNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20823,20926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20914,20926);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20823,20926);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,20942,21045) || true) && (f_1165_20946_21014(f_1165_20946_20963(xmlNode), "list", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,20942,21045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21033,21045);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,20942,21045);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21061,21174) || true) && (f_1165_21065_21143(f_1165_21065_21082(xmlNode), "definitionList", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,21061,21174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21162,21174);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,21061,21174);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21190,21203);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,20741,21214);

string
f_1165_20827_20844(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20827, 20844);
return return_v;
}


bool
f_1165_20827_20895(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 20827, 20895);
return return_v;
}


string
f_1165_20946_20963(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 20946, 20963);
return return_v;
}


bool
f_1165_20946_21014(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 20946, 21014);
return return_v;
}


string
f_1165_21065_21082(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 21065, 21082);
return return_v;
}


bool
f_1165_21065_21143(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 21065, 21143);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,20741,21214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,20741,21214);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsMamlFormattingPSObject(PSObject mshObject)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,21432,21789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21521,21572);

Collection<string> 
typeNames = f_1165_21552_21571(mshObject)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21588,21665) || true) && (typeNames == null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 21592, 21633)||f_1165_21613_21628(typeNames)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,21588,21665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21652,21665);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,21588,21665);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,21681,21778);

return f_1165_21688_21777(f_1165_21688_21718(typeNames, f_1165_21698_21713(typeNames)- 1), "MamlTextItem", StringComparison.OrdinalIgnoreCase);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,21432,21789);

System.Collections.ObjectModel.Collection<string>
f_1165_21552_21571(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 21552, 21571);
return return_v;
}


int
f_1165_21613_21628(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 21613, 21628);
return return_v;
}


int
f_1165_21698_21713(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 21698, 21713);
return return_v;
}


string
f_1165_21688_21718(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 21688, 21718);
return return_v;
}


bool
f_1165_21688_21777(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 21688, 21777);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,21432,21789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,21432,21789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject[] GetMamlFormattingPSObjects(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,23924,25951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24011,24050);

ArrayList 
mshObjects = f_1165_24034_24049()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24066,24123);

int 
paraNodes = f_1165_24082_24122(this, f_1165_24103_24121(xmlNode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24137,24151);

int 
count = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24239,24337);

bool 
trim = !f_1165_24252_24336(f_1165_24266_24278(xmlNode), "maml:introduction", StringComparison.OrdinalIgnoreCase)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24351,25868);
foreach(XmlNode childNode in f_1165_24381_24399_I(f_1165_24381_24399(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,24351,25868);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24433,24814) || true) && (f_1165_24437_24507(f_1165_24437_24456(childNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,24433,24814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24549,24557);

++count;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24579,24662);

PSObject 
paraPSObject = f_1165_24603_24661(childNode, count != paraNodes, trim: trim)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24684,24764) || true) && (paraPSObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,24684,24764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24735,24764);

f_1165_24735_24763(                        mshObjects, paraPSObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,24684,24764);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24786,24795);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,24433,24814);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24834,25230) || true) && (f_1165_24838_24908(f_1165_24838_24857(childNode), "list", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,24834,25230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,24950,25004);

ArrayList 
listPSObjects = f_1165_24976_25003(this, childNode)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25037,25042);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25028,25178) || true) && (i < f_1165_25048_25067(listPSObjects))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25069,25072)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,25028,25178))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,25028,25178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25122,25155);

f_1165_25122_25154(                        mshObjects, f_1165_25137_25153(listPSObjects, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,151);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25202,25211);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,24834,25230);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25250,25696) || true) && (f_1165_25254_25334(f_1165_25254_25273(childNode), "definitionList", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,25250,25696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25376,25450);

ArrayList 
definitionListPSObjects = f_1165_25412_25449(this, childNode)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25483,25488);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25474,25644) || true) && (i < f_1165_25494_25523(definitionListPSObjects))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25525,25528)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,25474,25644))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,25474,25644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25578,25621);

f_1165_25578_25620(                        mshObjects, f_1165_25593_25619(definitionListPSObjects, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,171);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,171);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25668,25677);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,25250,25696);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25802,25853);

f_1165_25802_25852(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,24351,25868);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,1518);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,1518);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,25884,25940);

return (PSObject[])f_1165_25903_25939(mshObjects, typeof(PSObject));
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,23924,25951);

System.Collections.ArrayList
f_1165_24034_24049()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24034, 24049);
return return_v;
}


System.Xml.XmlNodeList
f_1165_24103_24121(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 24103, 24121);
return return_v;
}


int
f_1165_24082_24122(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNodeList
nodes)
{
var return_v = this_param.GetParaMamlNodeCount( nodes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24082, 24122);
return return_v;
}


string
f_1165_24266_24278(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 24266, 24278);
return return_v;
}


bool
f_1165_24252_24336(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24252, 24336);
return return_v;
}


System.Xml.XmlNodeList
f_1165_24381_24399(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 24381, 24399);
return return_v;
}


string
f_1165_24437_24456(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 24437, 24456);
return return_v;
}


bool
f_1165_24437_24507(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24437, 24507);
return return_v;
}


System.Management.Automation.PSObject
f_1165_24603_24661(System.Xml.XmlNode
xmlNode,bool
newLine,bool
trim)
{
var return_v = GetParaPSObject( xmlNode, newLine, trim: trim);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24603, 24661);
return return_v;
}


int
f_1165_24735_24763(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24735, 24763);
return return_v;
}


string
f_1165_24838_24857(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 24838, 24857);
return return_v;
}


bool
f_1165_24838_24908(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24838, 24908);
return return_v;
}


System.Collections.ArrayList
f_1165_24976_25003(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetListPSObjects( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24976, 25003);
return return_v;
}


int
f_1165_25048_25067(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 25048, 25067);
return return_v;
}


object
f_1165_25137_25153(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 25137, 25153);
return return_v;
}


int
f_1165_25122_25154(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25122, 25154);
return return_v;
}


string
f_1165_25254_25273(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 25254, 25273);
return return_v;
}


bool
f_1165_25254_25334(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25254, 25334);
return return_v;
}


System.Collections.ArrayList
f_1165_25412_25449(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetDefinitionListPSObjects( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25412, 25449);
return return_v;
}


int
f_1165_25494_25523(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 25494, 25523);
return return_v;
}


object
f_1165_25593_25619(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 25593, 25619);
return return_v;
}


int
f_1165_25578_25620(System.Collections.ArrayList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25578, 25620);
return return_v;
}


int
f_1165_25802_25852(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25802, 25852);
return 0;
}


System.Xml.XmlNodeList
f_1165_24381_24399_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 24381, 24399);
return return_v;
}


System.Array
f_1165_25903_25939(System.Collections.ArrayList
this_param,System.Type
type)
{
var return_v = this_param.ToArray( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 25903, 25939);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,23924,25951);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,23924,25951);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int GetParaMamlNodeCount(XmlNodeList nodes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,26129,26647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26205,26215);

int 
i = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26231,26611);
foreach(XmlNode childNode in f_1165_26261_26266_I(nodes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,26231,26611);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26300,26596) || true) && (f_1165_26304_26374(f_1165_26304_26323(childNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,26300,26596);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26416,26549) || true) && (f_1165_26420_26467(f_1165_26420_26446(f_1165_26420_26439(childNode)), string.Empty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,26416,26549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26517,26526);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,26416,26549);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26573,26577);

++i;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,26300,26596);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,26231,26611);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,381);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,381);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26627,26636);

return i;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,26129,26647);

string
f_1165_26304_26323(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 26304, 26323);
return return_v;
}


bool
f_1165_26304_26374(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 26304, 26374);
return return_v;
}


string
f_1165_26420_26439(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 26420, 26439);
return return_v;
}


string
f_1165_26420_26446(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 26420, 26446);
return return_v;
}


bool
f_1165_26420_26467(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 26420, 26467);
return return_v;
}


System.Xml.XmlNodeList
f_1165_26261_26266_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 26261, 26266);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,26129,26647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,26129,26647);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void WriteMamlInvalidChildNodeError(XmlNode node, XmlNode childNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,26875,27387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,26976,27149);

ErrorRecord 
errorRecord = f_1165_27002_27148(f_1165_27018_27085("MamlInvalidChildNodeError"), "MamlInvalidChildNodeError", ErrorCategory.SyntaxError, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,27163,27333);

errorRecord.ErrorDetails = f_1165_27190_27332(f_1165_27207_27232(typeof(MamlNode)), "HelpErrors", "MamlInvalidChildNodeError", f_1165_27277_27291(node), f_1165_27293_27312(childNode), f_1165_27314_27331(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,27347,27376);

f_1165_27347_27375(f_1165_27347_27358(this), errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,26875,27387);

System.Management.Automation.ParentContainsErrorRecordException
f_1165_27018_27085(string
message)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27018, 27085);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1165_27002_27148(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27002, 27148);
return return_v;
}


System.Reflection.Assembly
f_1165_27207_27232(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 27207, 27232);
return return_v;
}


string
f_1165_27277_27291(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 27277, 27291);
return return_v;
}


string
f_1165_27293_27312(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 27293, 27312);
return return_v;
}


string
f_1165_27314_27331(System.Xml.XmlNode
xmlNode)
{
var return_v = GetNodePath( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27314, 27331);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1165_27190_27332(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27190, 27332);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1165_27347_27358(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 27347, 27358);
return return_v;
}


int
f_1165_27347_27375(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27347, 27375);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,26875,27387);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,26875,27387);
}
		}

private void WriteMamlInvalidChildNodeCountError(XmlNode node, string childNodeName, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,27663,28210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,27783,27966);

ErrorRecord 
errorRecord = f_1165_27809_27965(f_1165_27825_27897("MamlInvalidChildNodeCountError"), "MamlInvalidChildNodeCountError", ErrorCategory.SyntaxError, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,27980,28156);

errorRecord.ErrorDetails = f_1165_28007_28155(f_1165_28024_28049(typeof(MamlNode)), "HelpErrors", "MamlInvalidChildNodeCountError", f_1165_28099_28113(node), childNodeName, count, f_1165_28137_28154(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28170,28199);

f_1165_28170_28198(f_1165_28170_28181(this), errorRecord);
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,27663,28210);

System.Management.Automation.ParentContainsErrorRecordException
f_1165_27825_27897(string
message)
{
var return_v = new System.Management.Automation.ParentContainsErrorRecordException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27825, 27897);
return return_v;
}


System.Management.Automation.ErrorRecord
f_1165_27809_27965(System.Management.Automation.ParentContainsErrorRecordException
exception,string
errorId,System.Management.Automation.ErrorCategory
errorCategory,object
targetObject)
{
var return_v = new System.Management.Automation.ErrorRecord( (System.Exception)exception, errorId, errorCategory, targetObject);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 27809, 27965);
return return_v;
}


System.Reflection.Assembly
f_1165_28024_28049(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28024, 28049);
return return_v;
}


string
f_1165_28099_28113(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28099, 28113);
return return_v;
}


string
f_1165_28137_28154(System.Xml.XmlNode
xmlNode)
{
var return_v = GetNodePath( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28137, 28154);
return return_v;
}


System.Management.Automation.ErrorDetails
f_1165_28007_28155(System.Reflection.Assembly
assembly,string
baseName,string
resourceId,params object[]
args)
{
var return_v = new System.Management.Automation.ErrorDetails( assembly, baseName, resourceId, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28007, 28155);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1165_28170_28181(System.Management.Automation.MamlNode
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28170, 28181);
return return_v;
}


int
f_1165_28170_28198(System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
this_param,System.Management.Automation.ErrorRecord
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28170, 28198);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,27663,28210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,27663,28210);
}
		}

private static string GetNodePath(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,28222,28569);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28297,28355) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,28297,28355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28335,28355);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,28297,28355);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28371,28452) || true) && (f_1165_28375_28393(xmlNode)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,28371,28452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28420,28452);

return "\\" + f_1165_28434_28451(xmlNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,28371,28452);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28468,28558);

return f_1165_28475_28506(f_1165_28487_28505(xmlNode))+ "\\" + f_1165_28516_28533(xmlNode)+ f_1165_28536_28557(xmlNode);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,28222,28569);

System.Xml.XmlNode
f_1165_28375_28393(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ParentNode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28375, 28393);
return return_v;
}


string
f_1165_28434_28451(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28434, 28451);
return return_v;
}


System.Xml.XmlNode
f_1165_28487_28505(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ParentNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28487, 28505);
return return_v;
}


string
f_1165_28475_28506(System.Xml.XmlNode
xmlNode)
{
var return_v = GetNodePath( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28475, 28506);
return return_v;
}


string
f_1165_28516_28533(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28516, 28533);
return return_v;
}


string
f_1165_28536_28557(System.Xml.XmlNode
xmlNode)
{
var return_v = GetNodeIndex( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28536, 28557);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,28222,28569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,28222,28569);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetNodeIndex(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,28581,29431);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28657,28745) || true) && (xmlNode == null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 28661, 28706)||f_1165_28680_28698(xmlNode)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,28657,28745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28725,28745);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,28657,28745);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28761,28775);

int 
index = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28789,28803);

int 
total = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28819,29239);
foreach(XmlNode siblingNode in f_1165_28851_28880_I(f_1165_28851_28880(f_1165_28851_28869(xmlNode))) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,28819,29239);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28914,29048) || true) && (siblingNode == xmlNode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,28914,29048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,28982,28998);

index = total++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29020,29029);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,28914,29048);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29068,29224) || true) && (f_1165_29072_29155(f_1165_29072_29093(siblingNode), f_1165_29101_29118(xmlNode), StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,29068,29224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29197,29205);

total++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,29068,29224);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,28819,29239);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,421);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,421);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29255,29384) || true) && (total > 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,29255,29384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29302,29369);

return "[" + f_1165_29315_29362(index, "d", f_1165_29335_29361())+ "]";
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,29255,29384);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,29400,29420);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,28581,29431);

System.Xml.XmlNode
f_1165_28680_28698(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ParentNode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28680, 28698);
return return_v;
}


System.Xml.XmlNode
f_1165_28851_28869(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ParentNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28851, 28869);
return return_v;
}


System.Xml.XmlNodeList
f_1165_28851_28880(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 28851, 28880);
return return_v;
}


string
f_1165_29072_29093(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 29072, 29093);
return return_v;
}


string
f_1165_29101_29118(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 29101, 29118);
return return_v;
}


bool
f_1165_29072_29155(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 29072, 29155);
return return_v;
}


System.Xml.XmlNodeList
f_1165_28851_28880_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 28851, 28880);
return return_v;
}


System.Globalization.CultureInfo
f_1165_29335_29361()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 29335, 29361);
return return_v;
}


string
f_1165_29315_29362(int
this_param,string
format,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( format, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 29315, 29362);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,28581,29431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,28581,29431);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static PSObject GetParaPSObject(XmlNode xmlNode, bool newLine, bool trim = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,29969,31066);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30082,30132) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,30082,30132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30120,30132);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,30082,30132);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30148,30252) || true) && (!f_1165_30153_30221(f_1165_30153_30170(xmlNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,30148,30252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30240,30252);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,30148,30252);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30268,30304);

PSObject 
mshObject = f_1165_30289_30303()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30320,30359);

StringBuilder 
sb = f_1165_30339_30358()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30375,30782) || true) && (newLine &&(DynAbs.Tracing.TraceSender.Expression_True(1165, 30379, 30436)&&!f_1165_30391_30436(f_1165_30391_30415(f_1165_30391_30408(xmlNode)), string.Empty)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,30375,30782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30470,30510);

f_1165_30470_30509(                sb, f_1165_30484_30508(f_1165_30484_30501(xmlNode)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,30375,30782);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,30375,30782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30576,30610);

var 
innerText = f_1165_30592_30609(xmlNode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30628,30726) || true) && (trim)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,30628,30726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30678,30707);

innerText = f_1165_30690_30706(innerText);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,30628,30726);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30746,30767);

f_1165_30746_30766(
                sb, innerText);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,30375,30782);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30798,30866);

f_1165_30798_30865(f_1165_30798_30818(mshObject), f_1165_30823_30864("Text", f_1165_30850_30863(sb)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30882,30910);

f_1165_30882_30909(f_1165_30882_30901(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30924,30968);

f_1165_30924_30967(f_1165_30924_30943(mshObject), "MamlParaTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,30982,31022);

f_1165_30982_31021(f_1165_30982_31001(mshObject), "MamlTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,31038,31055);

return mshObject;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,29969,31066);

string
f_1165_30153_30170(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30153, 30170);
return return_v;
}


bool
f_1165_30153_30221(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30153, 30221);
return return_v;
}


System.Management.Automation.PSObject
f_1165_30289_30303()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30289, 30303);
return return_v;
}


System.Text.StringBuilder
f_1165_30339_30358()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30339, 30358);
return return_v;
}


string
f_1165_30391_30408(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30391, 30408);
return return_v;
}


string
f_1165_30391_30415(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30391, 30415);
return return_v;
}


bool
f_1165_30391_30436(string
this_param,string
value)
{
var return_v = this_param.Equals( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30391, 30436);
return return_v;
}


string
f_1165_30484_30501(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30484, 30501);
return return_v;
}


string
f_1165_30484_30508(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30484, 30508);
return return_v;
}


System.Text.StringBuilder
f_1165_30470_30509(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30470, 30509);
return return_v;
}


string
f_1165_30592_30609(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30592, 30609);
return return_v;
}


string
f_1165_30690_30706(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30690, 30706);
return return_v;
}


System.Text.StringBuilder
f_1165_30746_30766(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30746, 30766);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_30798_30818(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30798, 30818);
return return_v;
}


string
f_1165_30850_30863(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30850, 30863);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_30823_30864(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30823, 30864);
return return_v;
}


int
f_1165_30798_30865(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30798, 30865);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_30882_30901(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30882, 30901);
return return_v;
}


int
f_1165_30882_30909(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30882, 30909);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_30924_30943(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30924, 30943);
return return_v;
}


int
f_1165_30924_30967(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30924, 30967);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_30982_31001(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 30982, 31001);
return return_v;
}


int
f_1165_30982_31021(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 30982, 31021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,29969,31066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,29969,31066);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ArrayList GetListPSObjects(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,32102,33291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32178,32217);

ArrayList 
mshObjects = f_1165_32201_32216()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32233,32289) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32233,32289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32271,32289);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32233,32289);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32305,32415) || true) && (!f_1165_32310_32378(f_1165_32310_32327(xmlNode), "list", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32305,32415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32397,32415);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32305,32415);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32431,32531) || true) && (f_1165_32435_32453(xmlNode)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 32435, 32494)||f_1165_32465_32489(f_1165_32465_32483(xmlNode))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32431,32531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32513,32531);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32431,32531);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32547,32585);

bool 
ordered = f_1165_32562_32584(xmlNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32599,32613);

int 
index = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32629,33246);
foreach(XmlNode childNode in f_1165_32659_32677_I(f_1165_32659_32677(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32629,33246);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32711,33074) || true) && (f_1165_32715_32789(f_1165_32715_32734(childNode), "listItem", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32711,33074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32831,32910);

PSObject 
listItemPSObject = f_1165_32859_32909(this, childNode, ordered, ref index)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32934,33022) || true) && (listItemPSObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,32934,33022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,32989,33022);

f_1165_32989_33021(                        mshObjects, listItemPSObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32934,33022);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33046,33055);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32711,33074);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33180,33231);

f_1165_33180_33230(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,32629,33246);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,618);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,618);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33262,33280);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,32102,33291);

System.Collections.ArrayList
f_1165_32201_32216()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32201, 32216);
return return_v;
}


string
f_1165_32310_32327(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32310, 32327);
return return_v;
}


bool
f_1165_32310_32378(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32310, 32378);
return return_v;
}


System.Xml.XmlNodeList
f_1165_32435_32453(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32435, 32453);
return return_v;
}


System.Xml.XmlNodeList
f_1165_32465_32483(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32465, 32483);
return return_v;
}


int
f_1165_32465_32489(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32465, 32489);
return return_v;
}


bool
f_1165_32562_32584(System.Xml.XmlNode
xmlNode)
{
var return_v = IsOrderedList( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32562, 32584);
return return_v;
}


System.Xml.XmlNodeList
f_1165_32659_32677(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32659, 32677);
return return_v;
}


string
f_1165_32715_32734(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 32715, 32734);
return return_v;
}


bool
f_1165_32715_32789(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32715, 32789);
return return_v;
}


System.Management.Automation.PSObject
f_1165_32859_32909(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode,bool
ordered,ref int
index)
{
var return_v = this_param.GetListItemPSObject( xmlNode, ordered, ref index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32859, 32909);
return return_v;
}


int
f_1165_32989_33021(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32989, 33021);
return return_v;
}


int
f_1165_33180_33230(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 33180, 33230);
return 0;
}


System.Xml.XmlNodeList
f_1165_32659_32677_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 32659, 32677);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,32102,33291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,32102,33291);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsOrderedList(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,33480,34107);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33555,33606) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,33555,33606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33593,33606);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,33555,33606);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33622,33717) || true) && (f_1165_33626_33644(xmlNode)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 33626, 33685)||f_1165_33656_33680(f_1165_33656_33674(xmlNode))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,33622,33717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33704,33717);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,33622,33717);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33733,34067);
foreach(XmlNode attribute in f_1165_33763_33781_I(f_1165_33763_33781(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,33733,34067);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,33815,34052) || true) && (f_1165_33819_33885(f_1165_33819_33833(attribute), "class", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1165, 33819, 33979)&&f_1165_33910_33979(f_1165_33910_33925(attribute), "ordered", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,33815,34052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34021,34033);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,33815,34052);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,33733,34067);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,335);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,335);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34083,34096);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,33480,34107);

System.Xml.XmlAttributeCollection
f_1165_33626_33644(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33626, 33644);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1165_33656_33674(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33656, 33674);
return return_v;
}


int
f_1165_33656_33680(System.Xml.XmlAttributeCollection
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33656, 33680);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1165_33763_33781(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33763, 33781);
return return_v;
}


string
f_1165_33819_33833(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33819, 33833);
return return_v;
}


bool
f_1165_33819_33885(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 33819, 33885);
return return_v;
}


string
f_1165_33910_33925(System.Xml.XmlNode
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 33910, 33925);
return return_v;
}


bool
f_1165_33910_33979(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 33910, 33979);
return return_v;
}


System.Xml.XmlAttributeCollection
f_1165_33763_33781_I(System.Xml.XmlAttributeCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 33763, 33781);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,33480,34107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,33480,34107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject GetListItemPSObject(XmlNode xmlNode, bool ordered, ref int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,34415,36166);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34522,34572) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,34522,34572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34560,34572);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,34522,34572);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34588,34696) || true) && (!f_1165_34593_34665(f_1165_34593_34610(xmlNode), "listItem", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,34588,34696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34684,34696);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,34588,34696);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34712,34739);

string 
text = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34755,34892) || true) && (f_1165_34759_34783(f_1165_34759_34777(xmlNode))> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,34755,34892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34821,34877);

f_1165_34821_34876(this, xmlNode, "para", 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,34755,34892);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34908,35276);
foreach(XmlNode childNode in f_1165_34938_34956_I(f_1165_34938_34956(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,34908,35276);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,34990,35190) || true) && (f_1165_34994_35064(f_1165_34994_35013(childNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,34990,35190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35106,35140);

text = f_1165_35113_35139(f_1165_35113_35132(childNode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35162,35171);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,34990,35190);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35210,35261);

f_1165_35210_35260(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,34908,35276);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,369);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,369);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35292,35318);

string 
tag = string.Empty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35332,35580) || true) && (ordered)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,35332,35580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35377,35432);

tag = f_1165_35383_35431(index, "d2", f_1165_35404_35430());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35450,35462);

tag += ". ";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35480,35488);

index++;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,35332,35580);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,35332,35580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35554,35565);

tag = "* ";
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,35332,35580);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35596,35632);

PSObject 
mshObject = f_1165_35617_35631()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35648,35707);

f_1165_35648_35706(f_1165_35648_35668(mshObject), f_1165_35673_35705("Text", text));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35721,35778);

f_1165_35721_35777(f_1165_35721_35741(mshObject), f_1165_35746_35776("Tag", tag));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35794,35822);

f_1165_35794_35821(f_1165_35794_35813(mshObject));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35836,36066) || true) && (ordered)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,35836,36066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35881,35932);

f_1165_35881_35931(f_1165_35881_35900(mshObject), "MamlOrderedListTextItem");
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,35836,36066);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,35836,36066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,35998,36051);

f_1165_35998_36050(f_1165_35998_36017(mshObject), "MamlUnorderedListTextItem");
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,35836,36066);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36082,36122);

f_1165_36082_36121(f_1165_36082_36101(mshObject), "MamlTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36138,36155);

return mshObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,34415,36166);

string
f_1165_34593_34610(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 34593, 34610);
return return_v;
}


bool
f_1165_34593_34665(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 34593, 34665);
return return_v;
}


System.Xml.XmlNodeList
f_1165_34759_34777(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 34759, 34777);
return return_v;
}


int
f_1165_34759_34783(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 34759, 34783);
return return_v;
}


int
f_1165_34821_34876(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,string
childNodeName,int
count)
{
this_param.WriteMamlInvalidChildNodeCountError( node, childNodeName, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 34821, 34876);
return 0;
}


System.Xml.XmlNodeList
f_1165_34938_34956(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 34938, 34956);
return return_v;
}


string
f_1165_34994_35013(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 34994, 35013);
return return_v;
}


bool
f_1165_34994_35064(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 34994, 35064);
return return_v;
}


string
f_1165_35113_35132(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35113, 35132);
return return_v;
}


string
f_1165_35113_35139(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35113, 35139);
return return_v;
}


int
f_1165_35210_35260(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35210, 35260);
return 0;
}


System.Xml.XmlNodeList
f_1165_34938_34956_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 34938, 34956);
return return_v;
}


System.Globalization.CultureInfo
f_1165_35404_35430()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35404, 35430);
return return_v;
}


string
f_1165_35383_35431(int
this_param,string
format,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( format, (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35383, 35431);
return return_v;
}


System.Management.Automation.PSObject
f_1165_35617_35631()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35617, 35631);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_35648_35668(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35648, 35668);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_35673_35705(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35673, 35705);
return return_v;
}


int
f_1165_35648_35706(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35648, 35706);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_35721_35741(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35721, 35741);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_35746_35776(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35746, 35776);
return return_v;
}


int
f_1165_35721_35777(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35721, 35777);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_35794_35813(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35794, 35813);
return return_v;
}


int
f_1165_35794_35821(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35794, 35821);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_35881_35900(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35881, 35900);
return return_v;
}


int
f_1165_35881_35931(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35881, 35931);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_35998_36017(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 35998, 36017);
return return_v;
}


int
f_1165_35998_36050(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 35998, 36050);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_36082_36101(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36082, 36101);
return return_v;
}


int
f_1165_36082_36121(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 36082, 36121);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,34415,36166);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,34415,36166);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ArrayList GetDefinitionListPSObjects(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,36437,37586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36523,36562);

ArrayList 
mshObjects = f_1165_36546_36561()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36578,36634) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,36578,36634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36616,36634);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,36578,36634);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36650,36770) || true) && (!f_1165_36655_36733(f_1165_36655_36672(xmlNode), "definitionList", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,36650,36770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36752,36770);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,36650,36770);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36786,36886) || true) && (f_1165_36790_36808(xmlNode)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 36790, 36849)||f_1165_36820_36844(f_1165_36820_36838(xmlNode))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,36786,36886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36868,36886);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,36786,36886);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36902,37541);
foreach(XmlNode childNode in f_1165_36932_36950_I(f_1165_36932_36950(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,36902,37541);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,36984,37377) || true) && (f_1165_36988_37072(f_1165_36988_37007(childNode), "definitionListItem", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,36984,37377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37114,37193);

PSObject 
definitionListItemPSObject = f_1165_37152_37192(this, childNode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37217,37325) || true) && (definitionListItemPSObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,37217,37325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37282,37325);

f_1165_37282_37324(                        mshObjects, definitionListItemPSObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,37217,37325);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37349,37358);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,36984,37377);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37475,37526);

f_1165_37475_37525(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,36902,37541);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,640);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,640);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,37557,37575);

return mshObjects;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,36437,37586);

System.Collections.ArrayList
f_1165_36546_36561()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 36546, 36561);
return return_v;
}


string
f_1165_36655_36672(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36655, 36672);
return return_v;
}


bool
f_1165_36655_36733(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 36655, 36733);
return return_v;
}


System.Xml.XmlNodeList
f_1165_36790_36808(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36790, 36808);
return return_v;
}


System.Xml.XmlNodeList
f_1165_36820_36838(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36820, 36838);
return return_v;
}


int
f_1165_36820_36844(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36820, 36844);
return return_v;
}


System.Xml.XmlNodeList
f_1165_36932_36950(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36932, 36950);
return return_v;
}


string
f_1165_36988_37007(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 36988, 37007);
return return_v;
}


bool
f_1165_36988_37072(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 36988, 37072);
return return_v;
}


System.Management.Automation.PSObject
f_1165_37152_37192(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetDefinitionListItemPSObject( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 37152, 37192);
return return_v;
}


int
f_1165_37282_37324(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 37282, 37324);
return return_v;
}


int
f_1165_37475_37525(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 37475, 37525);
return 0;
}


System.Xml.XmlNodeList
f_1165_36932_36950_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 36932, 36950);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,36437,37586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,36437,37586);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSObject GetDefinitionListItemPSObject(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,38418,39955);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38506,38556) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,38506,38556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38544,38556);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,38506,38556);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38572,38690) || true) && (!f_1165_38577_38659(f_1165_38577_38594(xmlNode), "definitionListItem", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,38572,38690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38678,38690);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,38572,38690);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38706,38725);

string 
term = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38739,38764);

string 
definition = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38780,39460);
foreach(XmlNode childNode in f_1165_38810_38828_I(f_1165_38810_38828(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,38780,39460);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38862,39062) || true) && (f_1165_38866_38936(f_1165_38866_38885(childNode), "term", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,38862,39062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,38978,39012);

term = f_1165_38985_39011(f_1165_38985_39004(childNode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39034,39043);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,38862,39062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39082,39296) || true) && (f_1165_39086_39162(f_1165_39086_39105(childNode), "definition", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,39082,39296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39204,39246);

definition = f_1165_39217_39245(this, childNode);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39268,39277);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,39082,39296);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39394,39445);

f_1165_39394_39444(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,38780,39460);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,681);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,681);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39476,39537) || true) && (f_1165_39480_39506(term))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,39476,39537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39525,39537);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,39476,39537);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39553,39589);

PSObject 
mshObject = f_1165_39574_39588()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39605,39664);

f_1165_39605_39663(f_1165_39605_39625(mshObject), f_1165_39630_39662("Term", term));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39678,39749);

f_1165_39678_39748(f_1165_39678_39698(mshObject), f_1165_39703_39747("Definition", definition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39765,39793);

f_1165_39765_39792(f_1165_39765_39784(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39807,39857);

f_1165_39807_39856(f_1165_39807_39826(mshObject), "MamlDefinitionTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39871,39911);

f_1165_39871_39910(f_1165_39871_39890(mshObject), "MamlTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,39927,39944);

return mshObject;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,38418,39955);

string
f_1165_38577_38594(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 38577, 38594);
return return_v;
}


bool
f_1165_38577_38659(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 38577, 38659);
return return_v;
}


System.Xml.XmlNodeList
f_1165_38810_38828(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 38810, 38828);
return return_v;
}


string
f_1165_38866_38885(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 38866, 38885);
return return_v;
}


bool
f_1165_38866_38936(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 38866, 38936);
return return_v;
}


string
f_1165_38985_39004(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 38985, 39004);
return return_v;
}


string
f_1165_38985_39011(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 38985, 39011);
return return_v;
}


string
f_1165_39086_39105(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39086, 39105);
return return_v;
}


bool
f_1165_39086_39162(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39086, 39162);
return return_v;
}


string
f_1165_39217_39245(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
xmlNode)
{
var return_v = this_param.GetDefinitionText( xmlNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39217, 39245);
return return_v;
}


int
f_1165_39394_39444(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39394, 39444);
return 0;
}


System.Xml.XmlNodeList
f_1165_38810_38828_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 38810, 38828);
return return_v;
}


bool
f_1165_39480_39506(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39480, 39506);
return return_v;
}


System.Management.Automation.PSObject
f_1165_39574_39588()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39574, 39588);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_39605_39625(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39605, 39625);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_39630_39662(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39630, 39662);
return return_v;
}


int
f_1165_39605_39663(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39605, 39663);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1165_39678_39698(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39678, 39698);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1165_39703_39747(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39703, 39747);
return return_v;
}


int
f_1165_39678_39748(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39678, 39748);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_39765_39784(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39765, 39784);
return return_v;
}


int
f_1165_39765_39792(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39765, 39792);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_39807_39826(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39807, 39826);
return return_v;
}


int
f_1165_39807_39856(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39807, 39856);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1165_39871_39890(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 39871, 39890);
return return_v;
}


int
f_1165_39871_39910(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 39871, 39910);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,38418,39955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,38418,39955);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDefinitionText(XmlNode xmlNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1165,40201,41188);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40275,40325) || true) && (xmlNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40275,40325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40313,40325);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40275,40325);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40341,40451) || true) && (!f_1165_40346_40420(f_1165_40346_40363(xmlNode), "definition", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40341,40451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40439,40451);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40341,40451);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40467,40569) || true) && (f_1165_40471_40489(xmlNode)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 40471, 40530)||f_1165_40501_40525(f_1165_40501_40519(xmlNode))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40467,40569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40549,40569);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40467,40569);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40585,40722) || true) && (f_1165_40589_40613(f_1165_40589_40607(xmlNode))> 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40585,40722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40651,40707);

f_1165_40651_40706(this, xmlNode, "para", 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40585,40722);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40738,40765);

string 
text = string.Empty
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40781,41149);
foreach(XmlNode childNode in f_1165_40811_40829_I(f_1165_40811_40829(xmlNode)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40781,41149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40863,41063) || true) && (f_1165_40867_40937(f_1165_40867_40886(childNode), "para", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,40863,41063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,40979,41013);

text = f_1165_40986_41012(f_1165_40986_41005(childNode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,41035,41044);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40863,41063);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,41083,41134);

f_1165_41083_41133(this, xmlNode, childNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,40781,41149);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,369);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,369);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,41165,41177);

return text;
DynAbs.Tracing.TraceSender.TraceExitMethod(1165,40201,41188);

string
f_1165_40346_40363(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40346, 40363);
return return_v;
}


bool
f_1165_40346_40420(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 40346, 40420);
return return_v;
}


System.Xml.XmlNodeList
f_1165_40471_40489(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40471, 40489);
return return_v;
}


System.Xml.XmlNodeList
f_1165_40501_40519(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40501, 40519);
return return_v;
}


int
f_1165_40501_40525(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40501, 40525);
return return_v;
}


System.Xml.XmlNodeList
f_1165_40589_40607(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40589, 40607);
return return_v;
}


int
f_1165_40589_40613(System.Xml.XmlNodeList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40589, 40613);
return return_v;
}


int
f_1165_40651_40706(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,string
childNodeName,int
count)
{
this_param.WriteMamlInvalidChildNodeCountError( node, childNodeName, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 40651, 40706);
return 0;
}


System.Xml.XmlNodeList
f_1165_40811_40829(System.Xml.XmlNode
this_param)
{
var return_v = this_param.ChildNodes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40811, 40829);
return return_v;
}


string
f_1165_40867_40886(System.Xml.XmlNode
this_param)
{
var return_v = this_param.LocalName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40867, 40886);
return return_v;
}


bool
f_1165_40867_40937(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 40867, 40937);
return return_v;
}


string
f_1165_40986_41005(System.Xml.XmlNode
this_param)
{
var return_v = this_param.InnerText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 40986, 41005);
return return_v;
}


string
f_1165_40986_41012(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 40986, 41012);
return return_v;
}


int
f_1165_41083_41133(System.Management.Automation.MamlNode
this_param,System.Xml.XmlNode
node,System.Xml.XmlNode
childNode)
{
this_param.WriteMamlInvalidChildNodeError( node, childNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 41083, 41133);
return 0;
}


System.Xml.XmlNodeList
f_1165_40811_40829_I(System.Xml.XmlNodeList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 40811, 40829);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,40201,41188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,40201,41188);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetPreformattedText(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,42331,43569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42527,42573);

string 
noTabText = f_1165_42546_42572(text, "\t", "    ")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42587,42646);

string[] 
lines = f_1165_42604_42645(noTabText, Utils.Separators.Newline)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42660,42700);

string[] 
trimedLines = f_1165_42683_42699(lines)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42716,42805) || true) && (trimedLines == null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 42720, 42766)||f_1165_42743_42761(trimedLines)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,42716,42805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42785,42805);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,42716,42805);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42821,42873);

int 
minIndentation = f_1165_42842_42872(trimedLines)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42889,42944);

string[] 
shortedLines = new string[f_1165_42924_42942(trimedLines)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42967,42972);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42958,43316) || true) && (i < f_1165_42978_42996(trimedLines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,42998,43001)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,42958,43316))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,42958,43316);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43035,43301) || true) && (f_1165_43039_43066(trimedLines[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,43035,43301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43108,43141);

shortedLines[i] = trimedLines[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,43035,43301);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,43035,43301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43223,43282);

shortedLines[i] = f_1165_43241_43281(trimedLines[i], 0, minIndentation);
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,43035,43301);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,359);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,359);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43332,43375);

StringBuilder 
result = f_1165_43355_43374()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43398,43403);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43389,43517) || true) && (i < f_1165_43409_43428(shortedLines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43430,43433)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,43389,43517))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,43389,43517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43467,43502);

f_1165_43467_43501(                result, shortedLines[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,129);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,129);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43533,43558);

return f_1165_43540_43557(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,42331,43569);

string
f_1165_42546_42572(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 42546, 42572);
return return_v;
}


string[]
f_1165_42604_42645(string
this_param,params char[]
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 42604, 42645);
return return_v;
}


string[]
f_1165_42683_42699(string[]
lines)
{
var return_v = TrimLines( lines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 42683, 42699);
return return_v;
}


int
f_1165_42743_42761(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 42743, 42761);
return return_v;
}


int
f_1165_42842_42872(string[]
lines)
{
var return_v = GetMinIndentation( lines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 42842, 42872);
return return_v;
}


int
f_1165_42924_42942(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 42924, 42942);
return return_v;
}


int
f_1165_42978_42996(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 42978, 42996);
return return_v;
}


bool
f_1165_43039_43066(string
line)
{
var return_v = IsEmptyLine( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 43039, 43066);
return return_v;
}


string
f_1165_43241_43281(string
this_param,int
startIndex,int
count)
{
var return_v = this_param.Remove( startIndex, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 43241, 43281);
return return_v;
}


System.Text.StringBuilder
f_1165_43355_43374()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 43355, 43374);
return return_v;
}


int
f_1165_43409_43428(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 43409, 43428);
return return_v;
}


System.Text.StringBuilder
f_1165_43467_43501(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 43467, 43501);
return return_v;
}


string
f_1165_43540_43557(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 43540, 43557);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,42331,43569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,42331,43569);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string[] TrimLines(string[] lines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,43841,44677);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43915,43984) || true) && (lines == null ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 43919, 43953)||f_1165_43936_43948(lines)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,43915,43984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,43972,43984);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,43915,43984);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44000,44010);

int 
i = 0
;
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44029,44034)
,i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44024,44161) || true) && (i < f_1165_44040_44052(lines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44054,44057)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44024,44161))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44024,44161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44091,44146) || true) && (!f_1165_44096_44117(lines[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44091,44146);
DynAbs.Tracing.TraceSender.TraceBreak(1165,44140,44146);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44091,44146);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,138);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44177,44191);

int 
start = i
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44207,44263) || true) && (start == f_1165_44220_44232(lines))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44207,44263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44251,44263);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44207,44263);
}
try {
            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44284,44304)
,i = f_1165_44288_44300(lines)- 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44279,44425) || true) && (i >= start)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44318,44321)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44279,44425))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44279,44425);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44355,44410) || true) && (!f_1165_44360_44381(lines[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44355,44410);
DynAbs.Tracing.TraceSender.TraceBreak(1165,44404,44410);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44355,44410);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,147);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,147);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44441,44453);

int 
end = i
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44469,44515);

string[] 
result = new string[end - start + 1]
;
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44534,44543)
,i = start; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44529,44636) || true) && (i <= end)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44555,44558)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44529,44636))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44529,44636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44592,44621);

result[i - start] = lines[i];
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,108);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,108);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44652,44666);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,43841,44677);

int
f_1165_43936_43948(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 43936, 43948);
return return_v;
}


int
f_1165_44040_44052(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 44040, 44052);
return return_v;
}


bool
f_1165_44096_44117(string
line)
{
var return_v = IsEmptyLine( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 44096, 44117);
return return_v;
}


int
f_1165_44220_44232(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 44220, 44232);
return return_v;
}


int
f_1165_44288_44300(string[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 44288, 44300);
return return_v;
}


bool
f_1165_44360_44381(string
line)
{
var return_v = IsEmptyLine( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 44360, 44381);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,43841,44677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,43841,44677);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetMinIndentation(string[] lines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,44864,45362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44941,44965);

int 
minIndentation = -1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44990,44995);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,44981,45313) || true) && (i < f_1165_45001_45013(lines))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45015,45018)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1165,44981,45313))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,44981,45313);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45052,45109) || true) && (f_1165_45056_45077(lines[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,45052,45109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45100,45109);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,45052,45109);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45129,45172);

int 
indentation = f_1165_45147_45171(lines[i])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45192,45298) || true) && (minIndentation < 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1165, 45196, 45246)||indentation < minIndentation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,45192,45298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45269,45298);

minIndentation = indentation;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,45192,45298);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1165,1,333);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1165,1,333);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45329,45351);

return minIndentation;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,44864,45362);

int
f_1165_45001_45013(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 45001, 45013);
return return_v;
}


bool
f_1165_45056_45077(string
line)
{
var return_v = IsEmptyLine( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 45056, 45077);
return return_v;
}


int
f_1165_45147_45171(string
line)
{
var return_v = GetIndentation( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 45147, 45171);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,44864,45362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,44864,45362);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetIndentation(string line)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,45601,45870);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45672,45721) || true) && (f_1165_45676_45693(line))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,45672,45721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45712,45721);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,45672,45721);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45737,45800);

string 
leftTrimedLine = f_1165_45761_45799(line, Utils.Separators.Space)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,45816,45859);

return f_1165_45823_45834(line)- f_1165_45837_45858(leftTrimedLine);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,45601,45870);

bool
f_1165_45676_45693(string
line)
{
var return_v = IsEmptyLine( line);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 45676, 45693);
return return_v;
}


string
f_1165_45761_45799(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimStart( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 45761, 45799);
return return_v;
}


int
f_1165_45823_45834(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 45823, 45834);
return return_v;
}


int
f_1165_45837_45858(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1165, 45837, 45858);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,45601,45870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,45601,45870);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsEmptyLine(string line)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1165,46122,46421);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46191,46252) || true) && (f_1165_46195_46221(line))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,46191,46252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46240,46252);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,46191,46252);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46268,46300);

string 
trimedLine = f_1165_46288_46299(line)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46314,46381) || true) && (f_1165_46318_46350(trimedLine))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1165,46314,46381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46369,46381);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1165,46314,46381);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1165,46397,46410);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1165,46122,46421);

bool
f_1165_46195_46221(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 46195, 46221);
return return_v;
}


string
f_1165_46288_46299(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 46288, 46299);
return return_v;
}


bool
f_1165_46318_46350(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 46318, 46350);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1165,46122,46421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,46122,46421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Collection<ErrorRecord> Errors {get; }

static MamlNode()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1165,2751,46782);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1165,2751,46782);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1165,2751,46782);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1165,2751,46782);

System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>
f_1165_46723_46752()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ErrorRecord>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1165, 46723, 46752);
return return_v;
}

}
}
