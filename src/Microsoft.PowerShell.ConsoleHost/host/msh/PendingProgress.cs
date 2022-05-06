// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
internal
    class PendingProgress
{
internal
        void
        Update(Int64 sourceId, ProgressRecord record)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,2216,6562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2318,2374);

f_123_2318_2373(record != null, "record should not be null");
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,2390,6418);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2425,2590) || true) && (f_123_2429_2452(record)== f_123_2456_2473(record))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,2425,2590);
DynAbs.Tracing.TraceSender.TraceBreak(123,2565,2571);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,2425,2590);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2610,2642);

ArrayList 
listWhereFound = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2660,2685);

int 
indexWhereFound = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2703,2832);

ProgressNode 
foundNode =
f_123_2749_2831(this, sourceId, f_123_2772_2789(record), out listWhereFound, out indexWhereFound)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2852,4652) || true) && (foundNode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,2852,4652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2915,2989);

f_123_2915_2988(listWhereFound != null, "node found, but list not identified");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3011,3082);

f_123_3011_3081(indexWhereFound >= 0, "node found, but index not returned");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3106,3326) || true) && (f_123_3110_3127(record)== ProgressRecordType.Completed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,3106,3326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3209,3271);

f_123_3209_3270(this, listWhereFound, indexWhereFound);
DynAbs.Tracing.TraceSender.TraceBreak(123,3297,3303);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,3106,3326);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3350,4633) || true) && (f_123_3354_3377(record)== f_123_3381_3407(foundNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,3350,4633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3633,3670);

foundNode.Activity = f_123_3654_3669(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3696,3751);

foundNode.StatusDescription = f_123_3726_3750(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3777,3830);

foundNode.CurrentOperation = f_123_3806_3829(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3856,3922);

foundNode.PercentComplete = f_123_3884_3921(f_123_3893_3915(record), 100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,3948,4001);

foundNode.SecondsRemaining = f_123_3977_4000(record);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,4027,4045);

foundNode.Age = 0;
DynAbs.Tracing.TraceSender.TraceBreak(123,4071,4077);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,3350,4633);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,3350,4633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,4548,4610);

f_123_4548_4609(this, listWhereFound, indexWhereFound);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,3350,4633);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,2852,4652);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,4773,5041) || true) && (f_123_4777_4794(record)== ProgressRecordType.Completed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,4773,5041);
DynAbs.Tracing.TraceSender.TraceBreak(123,5016,5022);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,4773,5041);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5061,5119);

ProgressNode 
newNode = f_123_5084_5118(sourceId, record)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5250,5356) || true) && (_nodeCount >= maxNodeCount)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,5250,5356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5325,5337);

f_123_5325_5336(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,5250,5356);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,5250,5356);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,5250,5356);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5376,6335) || true) && (f_123_5380_5404(newNode)>= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,5376,6335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5451,5534);

ProgressNode 
parentNode = f_123_5477_5533(this, newNode.SourceId, f_123_5508_5532(newNode))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5556,5903) || true) && (parentNode != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,5556,5903);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5628,5782) || true) && (parentNode.Children == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,5628,5782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5717,5755);

parentNode.Children = f_123_5739_5754();
DynAbs.Tracing.TraceSender.TraceExitCondition(123,5628,5782);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,5810,5848);

f_123_5810_5847(this, parentNode.Children, newNode);
DynAbs.Tracing.TraceSender.TraceBreak(123,5874,5880);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,5556,5903);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6286,6316);

newNode.ParentActivityId = -1;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,5376,6335);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6355,6388);

f_123_6355_6387(this, _topLevelNodes, newNode);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,2390,6418);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,2390,6418) || true) && (false)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,2390,6418);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,2390,6418);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6527,6551);

f_123_6527_6550(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(123,2216,6562);

int
f_123_2318_2373(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2318, 2373);
return 0;
}


int
f_123_2429_2452(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ParentActivityId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 2429, 2452);
return return_v;
}


int
f_123_2456_2473(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 2456, 2473);
return return_v;
}


int
f_123_2772_2789(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 2772, 2789);
return return_v;
}


Microsoft.PowerShell.ProgressNode
f_123_2749_2831(Microsoft.PowerShell.PendingProgress
this_param,long
sourceId,int
activityId,out System.Collections.ArrayList
listWhereFound,out int
indexWhereFound)
{
var return_v = this_param.FindNodeById( sourceId, activityId, out listWhereFound, out indexWhereFound);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2749, 2831);
return return_v;
}


int
f_123_2915_2988(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2915, 2988);
return 0;
}


int
f_123_3011_3081(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 3011, 3081);
return 0;
}


System.Management.Automation.ProgressRecordType
f_123_3110_3127(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3110, 3127);
return return_v;
}


int
f_123_3209_3270(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
indexToRemove)
{
this_param.RemoveNodeAndPromoteChildren( nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 3209, 3270);
return 0;
}


int
f_123_3354_3377(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.ParentActivityId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3354, 3377);
return return_v;
}


int
f_123_3381_3407(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.ParentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3381, 3407);
return return_v;
}


string
f_123_3654_3669(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.Activity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3654, 3669);
return return_v;
}


string
f_123_3726_3750(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.StatusDescription;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3726, 3750);
return return_v;
}


string
f_123_3806_3829(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.CurrentOperation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3806, 3829);
return return_v;
}


int
f_123_3893_3915(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.PercentComplete;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3893, 3915);
return return_v;
}


int
f_123_3884_3921(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 3884, 3921);
return return_v;
}


int
f_123_3977_4000(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.SecondsRemaining;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 3977, 4000);
return return_v;
}


int
f_123_4548_4609(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
indexToRemove)
{
this_param.RemoveNodeAndPromoteChildren( nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 4548, 4609);
return 0;
}


System.Management.Automation.ProgressRecordType
f_123_4777_4794(System.Management.Automation.ProgressRecord
this_param)
{
var return_v = this_param.RecordType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 4777, 4794);
return return_v;
}


Microsoft.PowerShell.ProgressNode
f_123_5084_5118(long
sourceId,System.Management.Automation.ProgressRecord
record)
{
var return_v = new Microsoft.PowerShell.ProgressNode( sourceId, record);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5084, 5118);
return return_v;
}


int
f_123_5325_5336(Microsoft.PowerShell.PendingProgress
this_param)
{
this_param.EvictNode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5325, 5336);
return 0;
}


int
f_123_5380_5404(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.ParentActivityId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 5380, 5404);
return return_v;
}


int
f_123_5508_5532(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.ParentActivityId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 5508, 5532);
return return_v;
}


Microsoft.PowerShell.ProgressNode
f_123_5477_5533(Microsoft.PowerShell.PendingProgress
this_param,long
sourceId,int
activityId)
{
var return_v = this_param.FindNodeById( sourceId, activityId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5477, 5533);
return return_v;
}


System.Collections.ArrayList
f_123_5739_5754()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5739, 5754);
return return_v;
}


int
f_123_5810_5847(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,Microsoft.PowerShell.ProgressNode
nodeToAdd)
{
this_param.AddNode( nodes, nodeToAdd);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5810, 5847);
return 0;
}


int
f_123_6355_6387(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,Microsoft.PowerShell.ProgressNode
nodeToAdd)
{
this_param.AddNode( nodes, nodeToAdd);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6355, 6387);
return 0;
}


int
f_123_6527_6550(Microsoft.PowerShell.PendingProgress
this_param)
{
this_param.AgeNodesAndResetStyle();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6527, 6550);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,2216,6562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,2216,6562);
}
		}

private
        void
        EvictNode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,6574,7306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6641,6673);

ArrayList 
listWhereFound = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6687,6712);

int 
indexWhereFound = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6728,6818);

ProgressNode 
oldestNode = f_123_6754_6817(this, out listWhereFound, out indexWhereFound)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6832,7295) || true) && (oldestNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,6832,7295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,6998,7061);

f_123_6998_7060(false, "Must be an old node in the tree somewhere");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,7140,7170);

f_123_7140_7169(this, _topLevelNodes, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,6832,7295);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,6832,7295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,7236,7280);

f_123_7236_7279(this, listWhereFound, indexWhereFound);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,6832,7295);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(123,6574,7306);

Microsoft.PowerShell.ProgressNode
f_123_6754_6817(Microsoft.PowerShell.PendingProgress
this_param,out System.Collections.ArrayList
listWhereFound,out int
indexWhereFound)
{
var return_v = this_param.FindOldestLeafmostNode( out listWhereFound, out indexWhereFound);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6754, 6817);
return return_v;
}


int
f_123_6998_7060(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6998, 7060);
return 0;
}


int
f_123_7140_7169(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
indexToRemove)
{
this_param.RemoveNode( nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7140, 7169);
return 0;
}


int
f_123_7236_7279(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
indexToRemove)
{
this_param.RemoveNode( nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7236, 7279);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,6574,7306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,6574,7306);
}
		}

private
        void
        RemoveNode(ArrayList nodes, int indexToRemove)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,7658,8470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,7791,7854);

ProgressNode 
nodeToRemove = (ProgressNode)f_123_7833_7853(nodes, indexToRemove)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,7870,7935);

f_123_7870_7934(nodes != null, "can't remove nodes from a null list");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,7949,8013);

f_123_7949_8012(indexToRemove < f_123_7976_7987(nodes), "index is not in list");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8027,8098);

f_123_8027_8097(f_123_8038_8058(nodes, indexToRemove)!= null, "no node at specified index");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8112,8227);

f_123_8112_8226(nodeToRemove.Children == null ||(DynAbs.Tracing.TraceSender.Expression_False(123, 8123, 8188)||f_123_8156_8183(nodeToRemove.Children)== 0), "can't remove a node with children");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8251,8281);

f_123_8251_8280(
            nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8295,8308);

--_nodeCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8352,8451);

f_123_8352_8450(_nodeCount == f_123_8377_8394(this), "We've lost track of the number of nodes in the tree");
DynAbs.Tracing.TraceSender.TraceExitMethod(123,7658,8470);

object
f_123_7833_7853(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 7833, 7853);
return return_v;
}


int
f_123_7870_7934(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7870, 7934);
return 0;
}


int
f_123_7976_7987(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 7976, 7987);
return return_v;
}


int
f_123_7949_8012(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7949, 8012);
return 0;
}


object
f_123_8038_8058(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 8038, 8058);
return return_v;
}


int
f_123_8027_8097(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8027, 8097);
return 0;
}


int
f_123_8156_8183(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 8156, 8183);
return return_v;
}


int
f_123_8112_8226(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8112, 8226);
return 0;
}


int
f_123_8251_8280(System.Collections.ArrayList
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8251, 8280);
return 0;
}


int
f_123_8377_8394(Microsoft.PowerShell.PendingProgress
this_param)
{
var return_v = this_param.CountNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8377, 8394);
return return_v;
}


int
f_123_8352_8450(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8352, 8450);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,7658,8470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,7658,8470);
}
		}

private
        void
        RemoveNodeAndPromoteChildren(ArrayList nodes, int indexToRemove)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,8482,9969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8602,8665);

ProgressNode 
nodeToRemove = (ProgressNode)f_123_8644_8664(nodes, indexToRemove)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8681,8746);

f_123_8681_8745(nodes != null, "can't remove nodes from a null list");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8760,8824);

f_123_8760_8823(indexToRemove < f_123_8787_8798(nodes), "index is not in list");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8838,8901);

f_123_8838_8900(nodeToRemove != null, "no node at specified index");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8917,8997) || true) && (nodeToRemove == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,8917,8997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,8975,8982);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,8917,8997);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9013,9958) || true) && (nodeToRemove.Children != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,9013,9958);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9133,9138);
                // promote the children.

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9124,9414) || true) && (i < f_123_9144_9171(nodeToRemove.Children))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9173,9176)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(123,9124,9414))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,9124,9414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9332,9395);

((ProgressNode)f_123_9347_9371(nodeToRemove.Children, i)).ParentActivityId = -1;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,1,291);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,1,291);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9485,9515);

f_123_9485_9514(
                // add the children as siblings

                nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9533,9546);

--_nodeCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9564,9620);

f_123_9564_9619(                nodes, indexToRemove, nodeToRemove.Children);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9671,9770);

f_123_9671_9769(_nodeCount == f_123_9696_9713(this), "We've lost track of the number of nodes in the tree");
DynAbs.Tracing.TraceSender.TraceExitCondition(123,9013,9958);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,9013,9958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9885,9918);

f_123_9885_9917(this, nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,9936,9943);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,9013,9958);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(123,8482,9969);

object
f_123_8644_8664(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 8644, 8664);
return return_v;
}


int
f_123_8681_8745(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8681, 8745);
return 0;
}


int
f_123_8787_8798(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 8787, 8798);
return return_v;
}


int
f_123_8760_8823(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8760, 8823);
return 0;
}


int
f_123_8838_8900(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8838, 8900);
return 0;
}


int
f_123_9144_9171(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 9144, 9171);
return return_v;
}


object
f_123_9347_9371(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 9347, 9371);
return return_v;
}


int
f_123_9485_9514(System.Collections.ArrayList
this_param,int
index)
{
this_param.RemoveAt( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9485, 9514);
return 0;
}


int
f_123_9564_9619(System.Collections.ArrayList
this_param,int
index,System.Collections.ArrayList
c)
{
this_param.InsertRange( index, (System.Collections.ICollection)c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9564, 9619);
return 0;
}


int
f_123_9696_9713(Microsoft.PowerShell.PendingProgress
this_param)
{
var return_v = this_param.CountNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9696, 9713);
return return_v;
}


int
f_123_9671_9769(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9671, 9769);
return 0;
}


int
f_123_9885_9917(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
indexToRemove)
{
this_param.RemoveNode( nodes, indexToRemove);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9885, 9917);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,8482,9969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,8482,9969);
}
		}

private
        void
        AddNode(ArrayList nodes, ProgressNode nodeToAdd)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,10333,10730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,10437,10458);

f_123_10437_10457(            nodes, nodeToAdd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,10472,10485);

++_nodeCount;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,10532,10631);

f_123_10532_10630(_nodeCount == f_123_10557_10574(this), "We've lost track of the number of nodes in the tree");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,10645,10711);

f_123_10645_10710(_nodeCount <= maxNodeCount, "Too many nodes in tree!");
DynAbs.Tracing.TraceSender.TraceExitMethod(123,10333,10730);

int
f_123_10437_10457(System.Collections.ArrayList
this_param,Microsoft.PowerShell.ProgressNode
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10437, 10457);
return return_v;
}


int
f_123_10557_10574(Microsoft.PowerShell.PendingProgress
this_param)
{
var return_v = this_param.CountNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10557, 10574);
return return_v;
}


int
f_123_10532_10630(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10532, 10630);
return 0;
}


int
f_123_10645_10710(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10645, 10710);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,10333,10730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,10333,10730);
}
		}
private
        class FindOldestNodeVisitor : NodeVisitor
{
internal override
            bool
            Visit(ProgressNode node, ArrayList listWhereFound, int indexWhereFound)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,10825,11297);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,10978,11250) || true) && (node.Age >= _oldestSoFar)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,10978,11250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11048,11072);

_oldestSoFar = node.Age;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11094,11111);

FoundNode = node;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11133,11170);

this.ListWhereFound = listWhereFound;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11192,11231);

this.IndexWhereFound = indexWhereFound;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,10978,11250);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11270,11282);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,10825,11297);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,10825,11297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,10825,11297);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal
            ProgressNode
            FoundNode;

internal
            ArrayList
            ListWhereFound;

internal
            int
            IndexWhereFound ;

private int _oldestSoFar;

public FindOldestNodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,10742,11575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11361,11370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11432,11446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11502,11522);
this.IndexWhereFound = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11551,11563);
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,10742,11575);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,10742,11575);
}


static FindOldestNodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,10742,11575);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,10742,11575);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,10742,11575);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,10742,11575);
}

private
        ProgressNode
        FindOldestLeafmostNodeHelper(ArrayList treeToSearch, out ArrayList listWhereFound, out int indexWhereFound)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,11587,12598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11758,11780);

listWhereFound = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11794,11815);

indexWhereFound = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11831,11885);

FindOldestNodeVisitor 
v = f_123_11857_11884()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11899,11939);

f_123_11899_11938(treeToSearch, v);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,11955,11989);

listWhereFound = v.ListWhereFound;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12003,12039);

indexWhereFound = v.IndexWhereFound;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12086,12546) || true) && (v.FoundNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,12086,12546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12143,12220);

f_123_12143_12219(listWhereFound == null, "list should be null when no node found");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12238,12311);

f_123_12238_12310(indexWhereFound == -1, "index should indicate no node found");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12329,12426);

f_123_12329_12425(f_123_12340_12360(_topLevelNodes)== 0, "if there is no oldest node, then the tree must be empty");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12444,12531);

f_123_12444_12530(_nodeCount == 0, "if there is no oldest node, then the tree must be empty");
DynAbs.Tracing.TraceSender.TraceExitCondition(123,12086,12546);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12568,12587);

return v.FoundNode;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,11587,12598);

Microsoft.PowerShell.PendingProgress.FindOldestNodeVisitor
f_123_11857_11884()
{
var return_v = new Microsoft.PowerShell.PendingProgress.FindOldestNodeVisitor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11857, 11884);
return return_v;
}


int
f_123_11899_11938(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.FindOldestNodeVisitor
v)
{
NodeVisitor.VisitNodes( nodes, (Microsoft.PowerShell.PendingProgress.NodeVisitor)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11899, 11938);
return 0;
}


int
f_123_12143_12219(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12143, 12219);
return 0;
}


int
f_123_12238_12310(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12238, 12310);
return 0;
}


int
f_123_12340_12360(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12340, 12360);
return return_v;
}


int
f_123_12329_12425(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12329, 12425);
return 0;
}


int
f_123_12444_12530(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12444, 12530);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,11587,12598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,11587,12598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        ProgressNode
        FindOldestLeafmostNode(out ArrayList listWhereFound, out int indexWhereFound)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,12610,13392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12751,12773);

listWhereFound = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12787,12808);

indexWhereFound = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12824,12851);

ProgressNode 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12865,12905);

ArrayList 
treeToSearch = _topLevelNodes
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,12921,13351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12956,13049);

result = f_123_12965_13048(this, treeToSearch, out listWhereFound, out indexWhereFound);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13067,13209) || true) && (result == null ||(DynAbs.Tracing.TraceSender.Expression_False(123, 13071, 13112)||result.Children == null )||(DynAbs.Tracing.TraceSender.Expression_False(123, 13071, 13142)||f_123_13116_13137(result.Children)== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,13067,13209);
DynAbs.Tracing.TraceSender.TraceBreak(123,13184,13190);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,13067,13209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13291,13322);

treeToSearch = result.Children;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,12921,13351);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,12921,13351) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,12921,13351);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,12921,13351);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13367,13381);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,12610,13392);

Microsoft.PowerShell.ProgressNode
f_123_12965_13048(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
treeToSearch,out System.Collections.ArrayList
listWhereFound,out int
indexWhereFound)
{
var return_v = this_param.FindOldestLeafmostNodeHelper( treeToSearch, out listWhereFound, out indexWhereFound);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12965, 13048);
return return_v;
}


int
f_123_13116_13137(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 13116, 13137);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,12610,13392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,12610,13392);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        ProgressNode
        FindNodeById(Int64 sourceId, int activityId)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,13488,13792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13596,13628);

ArrayList 
listWhereFound = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13642,13667);

int 
indexWhereFound = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,13681,13781);

return
f_123_13705_13780(this, sourceId, activityId, out listWhereFound, out indexWhereFound);
DynAbs.Tracing.TraceSender.TraceExitMethod(123,13488,13792);

Microsoft.PowerShell.ProgressNode
f_123_13705_13780(Microsoft.PowerShell.PendingProgress
this_param,long
sourceId,int
activityId,out System.Collections.ArrayList
listWhereFound,out int
indexWhereFound)
{
var return_v = this_param.FindNodeById( sourceId, activityId, out listWhereFound, out indexWhereFound);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13705, 13780);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,13488,13792);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,13488,13792);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private
        class FindByIdNodeVisitor : NodeVisitor
{
internal
            FindByIdNodeVisitor(Int64 sourceIdToFind, int activityIdToFind)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,13885,14098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14684,14693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14755,14769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14825,14845);
this.IndexWhereFound = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14874,14888);
this._idToFind = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14917,14932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14003,14036);

_sourceIdToFind = sourceIdToFind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14054,14083);

_idToFind = activityIdToFind;
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,13885,14098);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,13885,14098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,13885,14098);
}
		}

internal override
            bool
            Visit(ProgressNode node, ArrayList listWhereFound, int indexWhereFound)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,14114,14620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14267,14573) || true) && (f_123_14271_14286(node)== _idToFind &&(DynAbs.Tracing.TraceSender.Expression_True(123, 14271, 14335)&&node.SourceId == _sourceIdToFind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,14267,14573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14377,14399);

this.FoundNode = node;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14421,14458);

this.ListWhereFound = listWhereFound;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14480,14519);

this.IndexWhereFound = indexWhereFound;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14541,14554);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,14267,14573);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,14593,14605);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,14114,14620);

int
f_123_14271_14286(Microsoft.PowerShell.ProgressNode
this_param)
{
var return_v = this_param.ActivityId ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 14271, 14286);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,14114,14620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,14114,14620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal
            ProgressNode
            FoundNode;

internal
            ArrayList
            ListWhereFound;

internal
            int
            IndexWhereFound ;

private int _idToFind ;

private Int64 _sourceIdToFind;

static FindByIdNodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,13804,14944);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,13804,14944);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,13804,14944);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,13804,14944);
}

private
        ProgressNode
        FindNodeById(Int64 sourceId, int activityId, out ArrayList listWhereFound, out int indexWhereFound)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,15871,16672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16034,16056);

listWhereFound = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16070,16091);

indexWhereFound = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16107,16177);

FindByIdNodeVisitor 
v = f_123_16131_16176(sourceId, activityId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16191,16233);

f_123_16191_16232(_topLevelNodes, v);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16249,16283);

listWhereFound = v.ListWhereFound;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16297,16333);

indexWhereFound = v.IndexWhereFound;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16380,16620) || true) && (v.FoundNode == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,16380,16620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16437,16514);

f_123_16437_16513(listWhereFound == null, "list should be null when no node found");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16532,16605);

f_123_16532_16604(indexWhereFound == -1, "index should indicate no node found");
DynAbs.Tracing.TraceSender.TraceExitCondition(123,16380,16620);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,16642,16661);

return v.FoundNode;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,15871,16672);

Microsoft.PowerShell.PendingProgress.FindByIdNodeVisitor
f_123_16131_16176(long
sourceIdToFind,int
activityIdToFind)
{
var return_v = new Microsoft.PowerShell.PendingProgress.FindByIdNodeVisitor( sourceIdToFind, activityIdToFind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16131, 16176);
return return_v;
}


int
f_123_16191_16232(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.FindByIdNodeVisitor
v)
{
NodeVisitor.VisitNodes( nodes, (Microsoft.PowerShell.PendingProgress.NodeVisitor)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16191, 16232);
return 0;
}


int
f_123_16437_16513(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16437, 16513);
return 0;
}


int
f_123_16532_16604(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16532, 16604);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,15871,16672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,15871,16672);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        ProgressNode
        FindOldestNodeOfGivenStyle(ArrayList nodes, int oldestSoFar, ProgressNode.RenderStyle style)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,17363,18832);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17519,17597) || true) && (nodes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,17519,17597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17570,17582);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,17519,17597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17613,17639);

ProgressNode 
found = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17662,17667);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17653,18547) || true) && (i < f_123_17673_17684(nodes))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17686,17689)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(123,17653,18547))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,17653,18547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17723,17766);

ProgressNode 
node = (ProgressNode)f_123_17757_17765(nodes, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17784,17851);

f_123_17784_17850(node != null, "nodes should not contain null elements");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17871,18041) || true) && (node.Age >= oldestSoFar &&(DynAbs.Tracing.TraceSender.Expression_True(123, 17875, 17921)&&node.Style == style))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,17871,18041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17963,17976);

found = node;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,17998,18022);

oldestSoFar = found.Age;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,17871,18041);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18061,18532) || true) && (node.Children != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,18061,18532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18128,18211);

ProgressNode 
child = f_123_18149_18210(this, node.Children, oldestSoFar, style)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18235,18513) || true) && (child != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,18235,18513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18426,18440);

found = child;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18466,18490);

oldestSoFar = found.Age;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,18235,18513);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,18061,18532);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,1,895);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,1,895);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18594,18786) || true) && (found != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,18594,18786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18645,18698);

f_123_18645_18697(found.Style == style, "unexpected style");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18716,18771);

f_123_18716_18770(found.Age >= oldestSoFar, "unexpected age");
DynAbs.Tracing.TraceSender.TraceExitCondition(123,18594,18786);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,18808,18821);

return found;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,17363,18832);

int
f_123_17673_17684(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 17673, 17684);
return return_v;
}


object
f_123_17757_17765(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 17757, 17765);
return return_v;
}


int
f_123_17784_17850(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 17784, 17850);
return 0;
}


Microsoft.PowerShell.ProgressNode
f_123_18149_18210(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
oldestSoFar,Microsoft.PowerShell.ProgressNode.RenderStyle
style)
{
var return_v = this_param.FindOldestNodeOfGivenStyle( nodes, oldestSoFar, style);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18149, 18210);
return return_v;
}


int
f_123_18645_18697(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18645, 18697);
return 0;
}


int
f_123_18716_18770(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18716, 18770);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,17363,18832);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,17363,18832);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private
        class AgeAndResetStyleVisitor : NodeVisitor
{
internal override
            bool
            Visit(ProgressNode node, ArrayList unused, int unusedToo)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,18929,19232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,19068,19122);

node.Age = f_123_19079_19121(node.Age + 1, Int32.MaxValue - 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,19140,19187);

node.Style = ProgressNode.RenderStyle.FullPlus;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,19205,19217);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,18929,19232);

int
f_123_19079_19121(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19079, 19121);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,18929,19232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,18929,19232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public AgeAndResetStyleVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,18844,19243);
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,18844,19243);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,18844,19243);
}


static AgeAndResetStyleVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,18844,19243);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,18844,19243);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,18844,19243);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,18844,19243);
}

private
        void
        AgeNodesAndResetStyle()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,19558,19768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,19637,19698);

AgeAndResetStyleVisitor 
arsv = f_123_19668_19697()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,19712,19757);

f_123_19712_19756(_topLevelNodes, arsv);
DynAbs.Tracing.TraceSender.TraceExitMethod(123,19558,19768);

Microsoft.PowerShell.PendingProgress.AgeAndResetStyleVisitor
f_123_19668_19697()
{
var return_v = new Microsoft.PowerShell.PendingProgress.AgeAndResetStyleVisitor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19668, 19697);
return return_v;
}


int
f_123_19712_19756(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.AgeAndResetStyleVisitor
v)
{
NodeVisitor.VisitNodes( nodes, (Microsoft.PowerShell.PendingProgress.NodeVisitor)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19712, 19756);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,19558,19768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,19558,19768);
}
		}

internal
        string[]
        Render(int maxWidth, int maxHeight, PSHostRawUserInterface rawUI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,20929,22760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21055,21145);

f_123_21055_21144(_topLevelNodes != null, "Shouldn't need to render progress if no data exists");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21159,21209);

f_123_21159_21208(maxWidth > 0, "maxWidth is too small");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21223,21276);

f_123_21223_21275(maxHeight >= 3, "maxHeight is too small");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21292,21457) || true) && (_topLevelNodes == null ||(DynAbs.Tracing.TraceSender.Expression_False(123, 21296, 21347)||f_123_21322_21342(_topLevelNodes)<= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,21292,21457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21430,21442);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,21292,21457);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21473,21491);

int 
invisible = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21505,21886) || true) && (f_123_21509_21548(this, rawUI, maxHeight, maxWidth)> maxHeight)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,21505,21886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21817,21871);

invisible = f_123_21829_21870(this, rawUI, maxHeight, maxWidth);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,21505,21886);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21902,21937);

ArrayList 
result = f_123_21921_21936()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,21951,21996);

string 
border = f_123_21967_21995(maxWidth)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22012,22031);

f_123_22012_22030(
            result, border);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22045,22102);

f_123_22045_22101(this, result, _topLevelNodes, 0, maxWidth, rawUI);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22116,22650) || true) && (invisible == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,22116,22650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22168,22360);

f_123_22168_22359(                result, " "
                    + f_123_22228_22358(f_123_22272_22321(), invisible));
DynAbs.Tracing.TraceSender.TraceExitCondition(123,22116,22650);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,22116,22650);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22394,22650) || true) && (invisible > 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,22394,22650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22445,22635);

f_123_22445_22634(                result, " "
                    + f_123_22505_22633(f_123_22549_22596(), invisible));
DynAbs.Tracing.TraceSender.TraceExitCondition(123,22394,22650);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,22116,22650);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22666,22685);

f_123_22666_22684(
            result, border);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,22701,22749);

return (string[])f_123_22718_22748(result, typeof(string));
DynAbs.Tracing.TraceSender.TraceExitMethod(123,20929,22760);

int
f_123_21055_21144(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21055, 21144);
return 0;
}


int
f_123_21159_21208(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21159, 21208);
return 0;
}


int
f_123_21223_21275(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21223, 21275);
return 0;
}


int
f_123_21322_21342(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 21322, 21342);
return return_v;
}


int
f_123_21509_21548(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth)
{
var return_v = this_param.TallyHeight( rawUi, maxHeight, maxWidth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21509, 21548);
return return_v;
}


int
f_123_21829_21870(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth)
{
var return_v = this_param.CompressToFit( rawUi, maxHeight, maxWidth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21829, 21870);
return return_v;
}


System.Collections.ArrayList
f_123_21921_21936()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21921, 21936);
return return_v;
}


string
f_123_21967_21995(int
countOfSpaces)
{
var return_v = StringUtil.Padding( countOfSpaces);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 21967, 21995);
return return_v;
}


int
f_123_22012_22030(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22012, 22030);
return return_v;
}


int
f_123_22045_22101(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
strings,System.Collections.ArrayList
nodes,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
this_param.RenderHelper( strings, nodes, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22045, 22101);
return 0;
}


string
f_123_22272_22321()
{
var return_v =                         ProgressNodeStrings.InvisibleNodesMessageSingular;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 22272, 22321);
return return_v;
}


string
f_123_22228_22358(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22228, 22358);
return return_v;
}


int
f_123_22168_22359(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22168, 22359);
return return_v;
}


string
f_123_22549_22596()
{
var return_v =                         ProgressNodeStrings.InvisibleNodesMessagePlural;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 22549, 22596);
return return_v;
}


string
f_123_22505_22633(string
formatSpec,int
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22505, 22633);
return return_v;
}


int
f_123_22445_22634(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22445, 22634);
return return_v;
}


int
f_123_22666_22684(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22666, 22684);
return return_v;
}


System.Array
f_123_22718_22748(System.Collections.ArrayList
this_param,System.Type
type)
{
var return_v = this_param.ToArray( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22718, 22748);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,20929,22760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,20929,22760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        void
        RenderHelper(ArrayList strings, ArrayList nodes, int indentation, int maxWidth, PSHostRawUserInterface rawUI)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,23584,24551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,23749,23807);

f_123_23749_23806(strings != null, "strings should not be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,23821,23875);

f_123_23821_23874(nodes != null, "nodes should not be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,23891,23964) || true) && (nodes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,23891,23964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,23942,23949);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,23891,23964);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,23980,24540);
foreach(ProgressNode node in f_123_24010_24015_I(nodes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,23980,24540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24049,24075);

int 
lines = f_123_24061_24074(strings)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24095,24146);

f_123_24095_24145(
                node, strings, indentation, maxWidth, rawUI);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24166,24525) || true) && (node.Children != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,24166,24525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24333,24392);

int 
indentationIncrement = (DynAbs.Tracing.TraceSender.Conditional_F1(123, 24360, 24383)||(((f_123_24361_24374(strings)> lines) &&DynAbs.Tracing.TraceSender.Conditional_F2(123, 24386, 24387))||DynAbs.Tracing.TraceSender.Conditional_F3(123, 24390, 24391)))?2 :0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24416,24506);

f_123_24416_24505(this, strings, node.Children, indentation + indentationIncrement, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,24166,24525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,23980,24540);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,1,561);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,1,561);
}DynAbs.Tracing.TraceSender.TraceExitMethod(123,23584,24551);

int
f_123_23749_23806(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 23749, 23806);
return 0;
}


int
f_123_23821_23874(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 23821, 23874);
return 0;
}


int
f_123_24061_24074(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24061, 24074);
return return_v;
}


int
f_123_24095_24145(Microsoft.PowerShell.ProgressNode
this_param,System.Collections.ArrayList
strCollection,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
this_param.Render( strCollection, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 24095, 24145);
return 0;
}


int
f_123_24361_24374(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24361, 24374);
return return_v;
}


int
f_123_24416_24505(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
strings,System.Collections.ArrayList
nodes,int
indentation,int
maxWidth,System.Management.Automation.Host.PSHostRawUserInterface
rawUI)
{
this_param.RenderHelper( strings, nodes, indentation, maxWidth, rawUI);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 24416, 24505);
return 0;
}


System.Collections.ArrayList
f_123_24010_24015_I(System.Collections.ArrayList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 24010, 24015);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,23584,24551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,23584,24551);
}
		}
private
        class HeightTallyer : NodeVisitor
{
internal HeightTallyer(PSHostRawUserInterface rawUi, int maxHeight, int maxWidth)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,24638,24862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25390,25396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25423,25433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25460,25469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25499,25504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24752,24767);

_rawUi = rawUi;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24785,24808);

_maxHeight = maxHeight;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,24826,24847);

_maxWidth = maxWidth;
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,24638,24862);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,24638,24862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,24638,24862);
}
		}

internal override
            bool
            Visit(ProgressNode node, ArrayList unused, int unusedToo)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,24878,25343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25017,25070);

Tally += f_123_25026_25069(node, _rawUi, _maxWidth);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25200,25296) || true) && (Tally > _maxHeight)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,25200,25296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25264,25277);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,25200,25296);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,25316,25328);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,24878,25343);

int
f_123_25026_25069(Microsoft.PowerShell.ProgressNode
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxWidth)
{
var return_v = this_param.LinesRequiredMethod( rawUi, maxWidth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25026, 25069);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,24878,25343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,24878,25343);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private PSHostRawUserInterface _rawUi;

private int _maxHeight;

private int _maxWidth;

internal int Tally;

static HeightTallyer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,24563,25516);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,24563,25516);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,24563,25516);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,24563,25516);
}

private int TallyHeight(PSHostRawUserInterface rawUi, int maxHeight, int maxWidth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,26254,26524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,26361,26426);

HeightTallyer 
ht = f_123_26380_26425(rawUi, maxHeight, maxWidth)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,26440,26483);

f_123_26440_26482(_topLevelNodes, ht);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,26497,26513);

return ht.Tally;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,26254,26524);

Microsoft.PowerShell.PendingProgress.HeightTallyer
f_123_26380_26425(System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth)
{
var return_v = new Microsoft.PowerShell.PendingProgress.HeightTallyer( rawUi, maxHeight, maxWidth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26380, 26425);
return return_v;
}


int
f_123_26440_26482(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.HeightTallyer
v)
{
NodeVisitor.VisitNodes( nodes, (Microsoft.PowerShell.PendingProgress.NodeVisitor)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26440, 26482);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,26254,26524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,26254,26524);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        bool
        AllNodesHaveGivenStyle(ArrayList nodes, ProgressNode.RenderStyle style)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,26836,27668);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,26963,27042) || true) && (nodes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,26963,27042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27014,27027);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,26963,27042);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27067,27072);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27058,27629) || true) && (i < f_123_27078_27089(nodes))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27091,27094)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(123,27058,27629))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,27058,27629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27128,27171);

ProgressNode 
node = (ProgressNode)f_123_27162_27170(nodes, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27189,27256);

f_123_27189_27255(node != null, "nodes should not contain null elements");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27276,27373) || true) && (node.Style != style)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,27276,27373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27341,27354);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,27276,27373);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27393,27614) || true) && (node.Children != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,27393,27614);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27460,27595) || true) && (!f_123_27465_27509(this, node.Children, style))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,27460,27595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27559,27572);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,27460,27595);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,27393,27614);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,1,572);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,1,572);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,27645,27657);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,26836,27668);

int
f_123_27078_27089(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 27078, 27089);
return return_v;
}


object
f_123_27162_27170(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 27162, 27170);
return return_v;
}


int
f_123_27189_27255(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 27189, 27255);
return 0;
}


bool
f_123_27465_27509(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,Microsoft.PowerShell.ProgressNode.RenderStyle
style)
{
var return_v = this_param.AllNodesHaveGivenStyle( nodes, style);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 27465, 27509);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,26836,27668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,26836,27668);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private
        class
        CountingNodeVisitor : NodeVisitor
{
internal override
            bool
            Visit(ProgressNode unused, ArrayList unusedToo, int unusedThree)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,27908,28107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28054,28062);

++Count;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28080,28092);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,27908,28107);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,27908,28107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,27908,28107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal
            int
            Count;

public CountingNodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,27818,28179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28162,28167);
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,27818,28179);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,27818,28179);
}


static CountingNodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,27818,28179);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,27818,28179);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,27818,28179);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,27818,28179);
}

private
        int
        CountNodes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,28412,28631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28479,28531);

CountingNodeVisitor 
cnv = f_123_28505_28530()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28545,28589);

f_123_28545_28588(_topLevelNodes, cnv);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,28603,28620);

return cnv.Count;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,28412,28631);

Microsoft.PowerShell.PendingProgress.CountingNodeVisitor
f_123_28505_28530()
{
var return_v = new Microsoft.PowerShell.PendingProgress.CountingNodeVisitor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28505, 28530);
return return_v;
}


int
f_123_28545_28588(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.CountingNodeVisitor
v)
{
NodeVisitor.VisitNodes( nodes, (Microsoft.PowerShell.PendingProgress.NodeVisitor)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28545, 28588);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,28412,28631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,28412,28631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        bool
        CompressToFitHelper(
            PSHostRawUserInterface rawUi,
            int maxHeight,
            int maxWidth,
            out int nodesCompressed,
            ProgressNode.RenderStyle priorStyle,
            ProgressNode.RenderStyle newStyle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,30256,31685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30566,30586);

nodesCompressed = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30602,30614);

int 
age = 0
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,30630,31182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30665,30745);

ProgressNode 
node = f_123_30685_30744(this, _topLevelNodes, age, priorStyle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30763,30928) || true) && (node == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,30763,30928);
DynAbs.Tracing.TraceSender.TraceBreak(123,30903,30909);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,30763,30928);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30948,30970);

node.Style = newStyle;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30988,31006);

++nodesCompressed;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,31024,31153) || true) && (f_123_31028_31067(this, rawUi, maxHeight, maxWidth)<= maxHeight)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,31024,31153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,31122,31134);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,31024,31153);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(123,30630,31182);
}
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,30630,31182) || true) && (true)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,30630,31182);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,30630,31182);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,31340,31472);

f_123_31340_31471(nodesCompressed == f_123_31388_31400(this), "We should have compressed every node in the tree.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,31486,31635);

f_123_31486_31634(f_123_31515_31563(this, _topLevelNodes, newStyle), "We should have compressed every node in the tree.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,31661,31674);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,30256,31685);

Microsoft.PowerShell.ProgressNode
f_123_30685_30744(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,int
oldestSoFar,Microsoft.PowerShell.ProgressNode.RenderStyle
style)
{
var return_v = this_param.FindOldestNodeOfGivenStyle( nodes, oldestSoFar, style);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 30685, 30744);
return return_v;
}


int
f_123_31028_31067(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth)
{
var return_v = this_param.TallyHeight( rawUi, maxHeight, maxWidth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31028, 31067);
return return_v;
}


int
f_123_31388_31400(Microsoft.PowerShell.PendingProgress
this_param)
{
var return_v = this_param.CountNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31388, 31400);
return return_v;
}


int
f_123_31340_31471(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31340, 31471);
return 0;
}


bool
f_123_31515_31563(Microsoft.PowerShell.PendingProgress
this_param,System.Collections.ArrayList
nodes,Microsoft.PowerShell.ProgressNode.RenderStyle
style)
{
var return_v = this_param.AllNodesHaveGivenStyle( nodes, style);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31515, 31563);
return return_v;
}


int
f_123_31486_31634(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31486, 31634);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,30256,31685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,30256,31685);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private
        int
        CompressToFit(PSHostRawUserInterface rawUi, int maxHeight, int maxWidth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(123,33077,35173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,33204,33287);

f_123_33204_33286(_topLevelNodes != null, "Shouldn't need to compress if no data exists");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,33303,33327);

int 
nodesCompressed = 0
;

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,33534,33875) || true) && (f_123_33556_33817(this, rawUi, maxHeight, maxWidth, out nodesCompressed, ProgressNode.RenderStyle.FullPlus, ProgressNode.RenderStyle.Full))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,33534,33875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,33851,33860);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,33534,33875);
}

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,33891,34231) || true) && (f_123_33913_34173(this, rawUi, maxHeight, maxWidth, out nodesCompressed, ProgressNode.RenderStyle.Full, ProgressNode.RenderStyle.Compact))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,33891,34231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,34207,34216);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,33891,34231);
}

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,34247,34590) || true) && (f_123_34269_34532(this, rawUi, maxHeight, maxWidth, out nodesCompressed, ProgressNode.RenderStyle.Compact, ProgressNode.RenderStyle.Minimal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,34247,34590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,34566,34575);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,34247,34590);
}

if (
(DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,34606,35040) || true) && (f_123_34628_34893(this, rawUi, maxHeight, maxWidth, out nodesCompressed, ProgressNode.RenderStyle.Minimal, ProgressNode.RenderStyle.Invisible))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,34606,35040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,35002,35025);

return nodesCompressed;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,34606,35040);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,35056,35137);

f_123_35056_35136(false, "with all nodes invisible, we should never reach this point.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,35153,35162);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(123,33077,35173);

int
f_123_33204_33286(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33204, 33286);
return 0;
}


bool
f_123_33556_33817(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth,out int
nodesCompressed,Microsoft.PowerShell.ProgressNode.RenderStyle
priorStyle,Microsoft.PowerShell.ProgressNode.RenderStyle
newStyle)
{
var return_v = this_param.CompressToFitHelper( rawUi, maxHeight, maxWidth, out nodesCompressed, priorStyle, newStyle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33556, 33817);
return return_v;
}


bool
f_123_33913_34173(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth,out int
nodesCompressed,Microsoft.PowerShell.ProgressNode.RenderStyle
priorStyle,Microsoft.PowerShell.ProgressNode.RenderStyle
newStyle)
{
var return_v = this_param.CompressToFitHelper( rawUi, maxHeight, maxWidth, out nodesCompressed, priorStyle, newStyle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33913, 34173);
return return_v;
}


bool
f_123_34269_34532(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth,out int
nodesCompressed,Microsoft.PowerShell.ProgressNode.RenderStyle
priorStyle,Microsoft.PowerShell.ProgressNode.RenderStyle
newStyle)
{
var return_v = this_param.CompressToFitHelper( rawUi, maxHeight, maxWidth, out nodesCompressed, priorStyle, newStyle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34269, 34532);
return return_v;
}


bool
f_123_34628_34893(Microsoft.PowerShell.PendingProgress
this_param,System.Management.Automation.Host.PSHostRawUserInterface
rawUi,int
maxHeight,int
maxWidth,out int
nodesCompressed,Microsoft.PowerShell.ProgressNode.RenderStyle
priorStyle,Microsoft.PowerShell.ProgressNode.RenderStyle
newStyle)
{
var return_v = this_param.CompressToFitHelper( rawUi, maxHeight, maxWidth, out nodesCompressed, priorStyle, newStyle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34628, 34893);
return return_v;
}


int
f_123_35056_35136(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 35056, 35136);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,33077,35173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,33077,35173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private abstract
        class NodeVisitor
{
internal abstract
            bool
            Visit(ProgressNode node, ArrayList listWhereFound, int indexWhereFound);

internal static
            void
            VisitNodes(ArrayList nodes, NodeVisitor v)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123,36053,36807);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36175,36260) || true) && (nodes == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,36175,36260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36234,36241);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,36175,36260);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36289,36294);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36280,36792) || true) && (i < f_123_36300_36311(nodes))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36313,36316)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(123,36280,36792))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,36280,36792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36358,36401);

ProgressNode 
node = (ProgressNode)f_123_36392_36400(nodes, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36423,36490);

f_123_36423_36489(node != null, "nodes should not contain null elements");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36514,36622) || true) && (!f_123_36519_36542(v, node, nodes, i))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,36514,36622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36592,36599);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(123,36514,36622);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36646,36773) || true) && (node.Children != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(123,36646,36773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36721,36750);

f_123_36721_36749(node.Children, v);
DynAbs.Tracing.TraceSender.TraceExitCondition(123,36646,36773);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(123,1,513);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(123,1,513);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123,36053,36807);

int
f_123_36300_36311(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 36300, 36311);
return return_v;
}


object
f_123_36392_36400(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 36392, 36400);
return return_v;
}


int
f_123_36423_36489(bool
condition,string
whyThisShouldNeverHappen)
{
Dbg.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36423, 36489);
return 0;
}


bool
f_123_36519_36542(Microsoft.PowerShell.PendingProgress.NodeVisitor
this_param,Microsoft.PowerShell.ProgressNode
node,System.Collections.ArrayList
listWhereFound,int
indexWhereFound)
{
var return_v = this_param.Visit( node, listWhereFound, indexWhereFound);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36519, 36542);
return return_v;
}


int
f_123_36721_36749(System.Collections.ArrayList
nodes,Microsoft.PowerShell.PendingProgress.NodeVisitor
v)
{
VisitNodes( nodes, v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36721, 36749);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123,36053,36807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,36053,36807);
}
		}

public NodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,35257,36818);
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,35257,36818);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,35257,36818);
}


static NodeVisitor()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,35257,36818);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,35257,36818);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,35257,36818);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,35257,36818);
}

private ArrayList _topLevelNodes ;

private int _nodeCount;

private const int 
maxNodeCount = 128
;

public PendingProgress()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(123,1354,36990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36870,36902);
this._topLevelNodes = f_123_36887_36902();DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36925,36935);
DynAbs.Tracing.TraceSender.TraceExitConstructor(123,1354,36990);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,1354,36990);
}


static PendingProgress()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123,1354,36990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(123,36964,36982);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123,1354,36990);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123,1354,36990);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123,1354,36990);

System.Collections.ArrayList
f_123_36887_36902()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36887, 36902);
return return_v;
}

}
}   // namespace

