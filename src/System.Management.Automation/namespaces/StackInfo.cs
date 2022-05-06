// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
public sealed class PathInfoStack : Stack<PathInfo>
{
internal PathInfoStack(string stackName, Stack<PathInfo> locationStack) : base()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1215,938,1917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,2017,2052);
this.Name = null;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1043,1179) || true) && (locationStack == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1215,1043,1179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1102,1164);

throw f_1215_1108_1163("locationStack");
DynAbs.Tracing.TraceSender.TraceExitCondition(1215,1043,1179);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1195,1333) || true) && (f_1215_1199_1230(stackName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1215,1195,1333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1264,1318);

throw f_1215_1270_1317("stackName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1215,1195,1333);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1349,1366);

Name = stackName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1633,1694);

PathInfo[] 
stackContents = new PathInfo[f_1215_1673_1692(locationStack)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1708,1747);

f_1215_1708_1746(            locationStack, stackContents, 0);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1772,1804);

            for (int 
index = f_1215_1780_1800(stackContents)- 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1763,1906) || true) && (index >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1818,1825)
,--index,DynAbs.Tracing.TraceSender.TraceExitCondition(1215,1763,1906))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1215,1763,1906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1215,1859,1891);

f_1215_1859_1890(                this, stackContents[index]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1215,1,144);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1215,1,144);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(1215,938,1917);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1215,938,1917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1215,938,1917);
}
		}

public string Name {get; }

static PathInfoStack()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1215,276,2059);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1215,276,2059);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1215,276,2059);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1215,276,2059);

System.Management.Automation.PSArgumentNullException
f_1215_1108_1163(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1215, 1108, 1163);
return return_v;
}


bool
f_1215_1199_1230(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1215, 1199, 1230);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1215_1270_1317(string
paramName)
{
var return_v = PSTraceSource.NewArgumentException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1215, 1270, 1317);
return return_v;
}


int
f_1215_1673_1692(System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1215, 1673, 1692);
return return_v;
}


int
f_1215_1708_1746(System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
this_param,System.Management.Automation.PathInfo[]
array,int
arrayIndex)
{
this_param.CopyTo( array, arrayIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1215, 1708, 1746);
return 0;
}


int
f_1215_1780_1800(System.Management.Automation.PathInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1215, 1780, 1800);
return return_v;
}


int
f_1215_1859_1890(System.Management.Automation.PathInfoStack
this_param,System.Management.Automation.PathInfo
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1215, 1859, 1890);
return 0;
}

}
}
