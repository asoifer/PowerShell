// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation.Internal
{
    /// <summary>
    /// Corresponds to -OutputVariable, -ErrorVariable, -WarningVariable, and -InformationVariable.
    /// </summary>
    internal enum VariableStreamKind
    {
        Output,
        Error,
        Warning,
        Information
    };
internal class Pipe
{
private ExecutionContext _context;

internal PipelineProcessor PipelineProcessor {get; }

internal CommandProcessorBase DownstreamCmdlet
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,1384,1417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1390,1415);

return _downstreamCmdlet;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,1384,1417);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,1313,1639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,1313,1639);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,1433,1628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1469,1569);

f_1311_1469_1568(_resultList == null, "Tried to set downstream cmdlet when _resultList not null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1587,1613);

_downstreamCmdlet = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,1433,1628);

int
f_1311_1469_1568(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 1469, 1568);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,1313,1639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,1313,1639);
}
		}}

private CommandProcessorBase _downstreamCmdlet;

internal PipelineReader<object> ExternalReader {get; set; }

internal PipelineWriter ExternalWriter
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,2848,2879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2854,2877);

return _externalWriter;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,2848,2879);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,2785,3100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,2785,3100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,2895,3089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2931,3032);

f_1311_2931_3031(_resultList == null, "Tried to set Pipe ExternalWriter when resultList not null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3050,3074);

_externalWriter = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,2895,3089);

int
f_1311_2931_3031(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 2931, 3031);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,2785,3100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,2785,3100);
}
		}}

private PipelineWriter _externalWriter;

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,3281,3471);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3339,3423) || true) && (_downstreamCmdlet != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,3339,3423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3387,3423);

return f_1311_3394_3422(_downstreamCmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,3339,3423);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3437,3460);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(),1311,3444,3459);
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,3281,3471);

string
f_1311_3394_3422(System.Management.Automation.CommandProcessorBase
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 3394, 3422);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,3281,3471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,3281,3471);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal int OutBufferCount {get; set; }

internal bool NullPipe
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,3875,3900);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3881,3898);

return _nullPipe;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,3875,3900);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,3828,4035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,3828,4035);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,3916,4024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3952,3973);

_isRedirected = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3991,4009);

_nullPipe = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,3916,4024);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,3828,4035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,3828,4035);
}
		}}

private bool _nullPipe;

internal Queue<object> ObjectQueue {get; }

internal bool Empty
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,4704,4971);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4740,4830) || true) && (_enumeratorToProcess != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,4740,4830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4795,4830);

return _enumeratorToProcessIsEmpty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,4740,4830);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4850,4926) || true) && (f_1311_4854_4865()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,4850,4926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4896,4926);

return f_1311_4903_4920(f_1311_4903_4914())== 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,4850,4926);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4944,4956);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,4704,4971);

System.Collections.Generic.Queue<object>
f_1311_4854_4865()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 4854, 4865);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_4903_4914()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 4903, 4914);
return return_v;
}


int
f_1311_4903_4920(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 4903, 4920);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,4660,4982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,4660,4982);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal bool IsRedirected
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,5264,5322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5270,5320);

return _downstreamCmdlet != null ||(DynAbs.Tracing.TraceSender.Expression_False(1311, 5277, 5319)||_isRedirected);
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,5264,5322);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,5213,5333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,5213,5333);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private bool _isRedirected;

private List<IList> _outVariableList;

private List<IList> _errorVariableList;

private List<IList> _warningVariableList;

private List<IList> _informationVariableList;

private PSVariable _pipelineVariableObject;

private static void AddToVarList(List<IList> varList, object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1311,6339,6648);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6429,6637) || true) && (varList != null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 6433, 6469)&&f_1311_6452_6465(varList)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6429,6637);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6512,6517);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6503,6622) || true) && (i < f_1311_6523_6536(varList))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6538,6541)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6503,6622))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6503,6622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6583,6603);

f_1311_6583_6602(f_1311_6583_6593(varList, i), obj);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1311,1,120);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1311,1,120);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6429,6637);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1311,6339,6648);

int
f_1311_6452_6465(System.Collections.Generic.List<System.Collections.IList>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 6452, 6465);
return return_v;
}


int
f_1311_6523_6536(System.Collections.Generic.List<System.Collections.IList>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 6523, 6536);
return return_v;
}


System.Collections.IList
f_1311_6583_6593(System.Collections.Generic.List<System.Collections.IList>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 6583, 6593);
return return_v;
}


int
f_1311_6583_6602(System.Collections.IList
this_param,object
value)
{
var return_v = this_param.Add( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 6583, 6602);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,6339,6648);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,6339,6648);
}
		}

internal void AppendVariableList(VariableStreamKind kind, object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,6660,7367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6754,7356);

switch (kind)
            {

case VariableStreamKind.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6754,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6852,6890);

f_1311_6852_6889(_errorVariableList, obj);
DynAbs.Tracing.TraceSender.TraceBreak(1311,6912,6918);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6754,7356);

case VariableStreamKind.Warning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6754,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6990,7030);

f_1311_6990_7029(_warningVariableList, obj);
DynAbs.Tracing.TraceSender.TraceBreak(1311,7052,7058);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6754,7356);

case VariableStreamKind.Output:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6754,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7129,7165);

f_1311_7129_7164(_outVariableList, obj);
DynAbs.Tracing.TraceSender.TraceBreak(1311,7187,7193);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6754,7356);

case VariableStreamKind.Information:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,6754,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7269,7313);

f_1311_7269_7312(_informationVariableList, obj);
DynAbs.Tracing.TraceSender.TraceBreak(1311,7335,7341);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,6754,7356);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,6660,7367);

int
f_1311_6852_6889(System.Collections.Generic.List<System.Collections.IList>
varList,object
obj)
{
AddToVarList( varList, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 6852, 6889);
return 0;
}


int
f_1311_6990_7029(System.Collections.Generic.List<System.Collections.IList>
varList,object
obj)
{
AddToVarList( varList, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 6990, 7029);
return 0;
}


int
f_1311_7129_7164(System.Collections.Generic.List<System.Collections.IList>
varList,object
obj)
{
AddToVarList( varList, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 7129, 7164);
return 0;
}


int
f_1311_7269_7312(System.Collections.Generic.List<System.Collections.IList>
varList,object
obj)
{
AddToVarList( varList, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 7269, 7312);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,6660,7367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,6660,7367);
}
		}

internal void AddVariableList(VariableStreamKind kind, IList list)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,7379,8723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7470,8712);

switch (kind)
            {

case VariableStreamKind.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7470,8712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7568,7710) || true) && (_errorVariableList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7568,7710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7648,7687);

_errorVariableList = f_1311_7669_7686();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7568,7710);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7734,7763);

f_1311_7734_7762(
                    _errorVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,7785,7791);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7470,8712);

case VariableStreamKind.Warning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7470,8712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7863,8009) || true) && (_warningVariableList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7863,8009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,7945,7986);

_warningVariableList = f_1311_7968_7985();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7863,8009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8033,8064);

f_1311_8033_8063(
                    _warningVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,8086,8092);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7470,8712);

case VariableStreamKind.Output:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7470,8712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8163,8301) || true) && (_outVariableList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8163,8301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8241,8278);

_outVariableList = f_1311_8260_8277();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8163,8301);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8325,8352);

f_1311_8325_8351(
                    _outVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,8374,8380);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7470,8712);

case VariableStreamKind.Information:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,7470,8712);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8456,8610) || true) && (_informationVariableList == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8456,8610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8542,8587);

_informationVariableList = f_1311_8569_8586();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8456,8610);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8634,8669);

f_1311_8634_8668(
                    _informationVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,8691,8697);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,7470,8712);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,7379,8723);

System.Collections.Generic.List<System.Collections.IList>
f_1311_7669_7686()
{
var return_v = new System.Collections.Generic.List<System.Collections.IList>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 7669, 7686);
return return_v;
}


int
f_1311_7734_7762(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 7734, 7762);
return 0;
}


System.Collections.Generic.List<System.Collections.IList>
f_1311_7968_7985()
{
var return_v = new System.Collections.Generic.List<System.Collections.IList>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 7968, 7985);
return return_v;
}


int
f_1311_8033_8063(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 8033, 8063);
return 0;
}


System.Collections.Generic.List<System.Collections.IList>
f_1311_8260_8277()
{
var return_v = new System.Collections.Generic.List<System.Collections.IList>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 8260, 8277);
return return_v;
}


int
f_1311_8325_8351(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 8325, 8351);
return 0;
}


System.Collections.Generic.List<System.Collections.IList>
f_1311_8569_8586()
{
var return_v = new System.Collections.Generic.List<System.Collections.IList>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 8569, 8586);
return return_v;
}


int
f_1311_8634_8668(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 8634, 8668);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,7379,8723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,7379,8723);
}
		}

internal void SetPipelineVariable(PSVariable pipelineVariable)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,8735,8876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8822,8865);

_pipelineVariableObject = pipelineVariable;
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,8735,8876);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,8735,8876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,8735,8876);
}
		}

internal void RemoveVariableList(VariableStreamKind kind, IList list)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,8888,9571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,8982,9560);

switch (kind)
            {

case VariableStreamKind.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8982,9560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9080,9112);

f_1311_9080_9111(                    _errorVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,9134,9140);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8982,9560);

case VariableStreamKind.Warning:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8982,9560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9212,9246);

f_1311_9212_9245(                    _warningVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,9268,9274);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8982,9560);

case VariableStreamKind.Output:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8982,9560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9345,9375);

f_1311_9345_9374(                    _outVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,9397,9403);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8982,9560);

case VariableStreamKind.Information:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,8982,9560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9479,9517);

f_1311_9479_9516(                    _informationVariableList, list);
DynAbs.Tracing.TraceSender.TraceBreak(1311,9539,9545);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,8982,9560);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,8888,9571);

bool
f_1311_9080_9111(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 9080, 9111);
return return_v;
}


bool
f_1311_9212_9245(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 9212, 9245);
return return_v;
}


bool
f_1311_9345_9374(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 9345, 9374);
return return_v;
}


bool
f_1311_9479_9516(System.Collections.Generic.List<System.Collections.IList>
this_param,System.Collections.IList
item)
{
var return_v = this_param.Remove( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 9479, 9516);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,8888,9571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,8888,9571);
}
		}

internal void RemovePipelineVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,9583,9827);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9646,9816) || true) && (_pipelineVariableObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,9646,9816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9715,9752);

_pipelineVariableObject.Value = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,9770,9801);

_pipelineVariableObject = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,9646,9816);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,9583,9827);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,9583,9827);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,9583,9827);
}
		}

internal void SetVariableListForTemporaryPipe(Pipe tempPipe)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,10300,10677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10385,10464);

f_1311_10385_10463(this, VariableStreamKind.Error, _errorVariableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10478,10561);

f_1311_10478_10560(this, VariableStreamKind.Warning, _warningVariableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10575,10666);

f_1311_10575_10665(this, VariableStreamKind.Information, _informationVariableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,10300,10677);

int
f_1311_10385_10463(System.Management.Automation.Internal.Pipe
this_param,System.Management.Automation.Internal.VariableStreamKind
streamKind,System.Collections.Generic.List<System.Collections.IList>
variableList,System.Management.Automation.Internal.Pipe
tempPipe)
{
this_param.CopyVariableToTempPipe( streamKind, variableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 10385, 10463);
return 0;
}


int
f_1311_10478_10560(System.Management.Automation.Internal.Pipe
this_param,System.Management.Automation.Internal.VariableStreamKind
streamKind,System.Collections.Generic.List<System.Collections.IList>
variableList,System.Management.Automation.Internal.Pipe
tempPipe)
{
this_param.CopyVariableToTempPipe( streamKind, variableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 10478, 10560);
return 0;
}


int
f_1311_10575_10665(System.Management.Automation.Internal.Pipe
this_param,System.Management.Automation.Internal.VariableStreamKind
streamKind,System.Collections.Generic.List<System.Collections.IList>
variableList,System.Management.Automation.Internal.Pipe
tempPipe)
{
this_param.CopyVariableToTempPipe( streamKind, variableList, tempPipe);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 10575, 10665);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,10300,10677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,10300,10677);
}
		}

private void CopyVariableToTempPipe(VariableStreamKind streamKind, List<IList> variableList, Pipe tempPipe)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,10689,11089);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10821,11078) || true) && (variableList != null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 10825, 10871)&&f_1311_10849_10867(variableList)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,10821,11078);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10914,10919);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10905,11063) || true) && (i < f_1311_10925_10943(variableList))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10945,10948)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1311,10905,11063))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,10905,11063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,10990,11044);

f_1311_10990_11043(                    tempPipe, streamKind, f_1311_11027_11042(variableList, i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1311,1,159);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1311,1,159);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1311,10821,11078);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,10689,11089);

int
f_1311_10849_10867(System.Collections.Generic.List<System.Collections.IList>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 10849, 10867);
return return_v;
}


int
f_1311_10925_10943(System.Collections.Generic.List<System.Collections.IList>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 10925, 10943);
return return_v;
}


System.Collections.IList
f_1311_11027_11042(System.Collections.Generic.List<System.Collections.IList>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 11027, 11042);
return return_v;
}


int
f_1311_10990_11043(System.Management.Automation.Internal.Pipe
this_param,System.Management.Automation.Internal.VariableStreamKind
kind,System.Collections.IList
list)
{
this_param.AddVariableList( kind, list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 10990, 11043);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,10689,11089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,10689,11089);
}
		}

internal Pipe()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1311,11358,11443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,935,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1069,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1680,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2200,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3135,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3639,3685);
this.OutBufferCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4060,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4230,4273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5358,5371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5533,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5711,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5893,5913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6088,6112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6303,6326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11875,11886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12554,12571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13950,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13994,14021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11398,11432);

ObjectQueue = f_1311_11412_11431();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1311,11358,11443);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,11358,11443);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,11358,11443);
}
		}

internal Pipe(List<object> resultList)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1311,11617,11833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,935,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1069,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1680,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2200,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3135,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3639,3685);
this.OutBufferCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4060,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4230,4273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5358,5371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5533,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5711,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5893,5913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6088,6112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6303,6326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11875,11886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12554,12571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13950,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13994,14021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11680,11748);

f_1311_11680_11747(resultList != null, "resultList cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11762,11783);

_isRedirected = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11797,11822);

_resultList = resultList;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1311,11617,11833);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,11617,11833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,11617,11833);
}
		}

private readonly List<object> _resultList;

internal Pipe(System.Collections.ObjectModel.Collection<PSObject> resultCollection)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1311,12197,12482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,935,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1069,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1680,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2200,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3135,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3639,3685);
this.OutBufferCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4060,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4230,4273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5358,5371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5533,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5711,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5893,5913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6088,6112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6303,6326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11875,11886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12554,12571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13950,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13994,14021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12305,12385);

f_1311_12305_12384(resultCollection != null, "resultCollection cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12399,12420);

_isRedirected = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12434,12471);

_resultCollection = resultCollection;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1311,12197,12482);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,12197,12482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,12197,12482);
}
		}

private System.Collections.ObjectModel.Collection<PSObject> _resultCollection;

internal Pipe(ExecutionContext context, PipelineProcessor outputPipeline)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1311,12929,13314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,935,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1069,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1680,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2200,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3135,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3639,3685);
this.OutBufferCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4060,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4230,4273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5358,5371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5533,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5711,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5893,5913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6088,6112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6303,6326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11875,11886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12554,12571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13950,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13994,14021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13027,13103);

f_1311_13027_13102(outputPipeline != null, "outputPipeline cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13117,13186);

f_1311_13117_13185(outputPipeline != null, "context cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13200,13221);

_isRedirected = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13235,13254);

_context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13268,13303);

PipelineProcessor = outputPipeline;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1311,12929,13314);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,12929,13314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,12929,13314);
}
		}

internal Pipe(IEnumerator enumeratorToProcess)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1311,13526,13918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,935,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1069,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,1680,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,2200,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3135,3150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,3639,3685);
this.OutBufferCount = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4060,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,4230,4273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5358,5371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5533,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5711,5729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,5893,5913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6088,6112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,6303,6326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,11875,11886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,12554,12571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13950,13970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13994,14021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13597,13683);

f_1311_13597_13682(enumeratorToProcess != null, "enumeratorToProcess cannot be null");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13697,13740);

_enumeratorToProcess = enumeratorToProcess;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,13871,13907);

_enumeratorToProcessIsEmpty = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1311,13526,13918);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,13526,13918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,13526,13918);
}
		}

private IEnumerator _enumeratorToProcess;

private bool _enumeratorToProcessIsEmpty;

internal void Add(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,14720,15301);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,14774,14831) || true) && (obj == f_1311_14785_14805())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,14774,14831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,14824,14831);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,14774,14831);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,14980,15016);

f_1311_14980_15015(_outVariableList, obj);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15032,15071) || true) && (_nullPipe)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15032,15071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15064,15071);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15032,15071);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15139,15259) || true) && (_pipelineVariableObject != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15139,15259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15208,15244);

_pipelineVariableObject.Value = obj;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15139,15259);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15275,15290);

f_1311_15275_15289(this, obj);
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,14720,15301);

System.Management.Automation.PSObject
f_1311_14785_14805()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 14785, 14805);
return return_v;
}


int
f_1311_14980_15015(System.Collections.Generic.List<System.Collections.IList>
varList,object
obj)
{
AddToVarList( varList, obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 14980, 15015);
return 0;
}


int
f_1311_15275_15289(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.AddToPipe( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15275, 15289);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,14720,15301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,14720,15301);
}
		}

internal void AddWithoutAppendingOutVarList(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,15313,15505);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15393,15463) || true) && (obj == f_1311_15404_15424()||(DynAbs.Tracing.TraceSender.Expression_False(1311, 15397, 15437)||_nullPipe))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15393,15463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15456,15463);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15393,15463);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15479,15494);

f_1311_15479_15493(this, obj);
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,15313,15505);

System.Management.Automation.PSObject
f_1311_15404_15424()
{
var return_v = AutomationNull.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 15404, 15424);
return return_v;
}


int
f_1311_15479_15493(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.AddToPipe( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15479, 15493);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,15313,15505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,15313,15505);
}
		}

private void AddToPipe(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,15517,16642);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15576,16631) || true) && (f_1311_15580_15597()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15576,16631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15712,15762);

f_1311_15712_15761(                // Put the pipeline on the notification stack for stop.
                _context, f_1311_15743_15760());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15780,15808);

f_1311_15780_15807(f_1311_15780_15797(), obj);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15826,15863);

f_1311_15826_15862(                _context, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15576,16631);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15576,16631);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15897,16631) || true) && (_resultCollection != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15897,16631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,15960,16029);

f_1311_15960_16028(                _resultCollection, (DynAbs.Tracing.TraceSender.Conditional_F1(1311, 15982, 15993)||((obj != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1311, 15996, 16020))||DynAbs.Tracing.TraceSender.Conditional_F3(1311, 16023, 16027)))?f_1311_15996_16020(obj):null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15897,16631);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,15897,16631);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16063,16631) || true) && (_resultList != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16063,16631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16120,16141);

f_1311_16120_16140(                _resultList, obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16063,16631);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16063,16631);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16175,16631) || true) && (_externalWriter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16175,16631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16236,16263);

f_1311_16236_16262(                _externalWriter, obj);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16175,16631);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16175,16631);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16297,16631) || true) && (f_1311_16301_16312()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16297,16631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16354,16379);

f_1311_16354_16378(f_1311_16354_16365(), obj);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16458,16616) || true) && (_downstreamCmdlet != null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 16462, 16525)&&f_1311_16491_16508(f_1311_16491_16502())> f_1311_16511_16525()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,16458,16616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,16567,16597);

f_1311_16567_16596(                    _downstreamCmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16458,16616);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16297,16631);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16175,16631);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,16063,16631);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15897,16631);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,15576,16631);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,15517,16642);

System.Management.Automation.Internal.PipelineProcessor
f_1311_15580_15597()
{
var return_v = PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 15580, 15597);
return return_v;
}


System.Management.Automation.Internal.PipelineProcessor
f_1311_15743_15760()
{
var return_v = PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 15743, 15760);
return return_v;
}


int
f_1311_15712_15761(System.Management.Automation.ExecutionContext
this_param,System.Management.Automation.Internal.PipelineProcessor
pp)
{
this_param.PushPipelineProcessor( pp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15712, 15761);
return 0;
}


System.Management.Automation.Internal.PipelineProcessor
f_1311_15780_15797()
{
var return_v = PipelineProcessor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 15780, 15797);
return return_v;
}


System.Array
f_1311_15780_15807(System.Management.Automation.Internal.PipelineProcessor
this_param,object
input)
{
var return_v = this_param.Step( input);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15780, 15807);
return return_v;
}


int
f_1311_15826_15862(System.Management.Automation.ExecutionContext
this_param,bool
fromSteppablePipeline)
{
this_param.PopPipelineProcessor( fromSteppablePipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15826, 15862);
return 0;
}


System.Management.Automation.PSObject
f_1311_15996_16020(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15996, 16020);
return return_v;
}


int
f_1311_15960_16028(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 15960, 16028);
return 0;
}


int
f_1311_16120_16140(System.Collections.Generic.List<object>
this_param,object
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 16120, 16140);
return 0;
}


int
f_1311_16236_16262(System.Management.Automation.Runspaces.PipelineWriter
this_param,object
obj)
{
var return_v = this_param.Write( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 16236, 16262);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_16301_16312()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 16301, 16312);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_16354_16365()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 16354, 16365);
return return_v;
}


int
f_1311_16354_16378(System.Collections.Generic.Queue<object>
this_param,object
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 16354, 16378);
return 0;
}


System.Collections.Generic.Queue<object>
f_1311_16491_16502()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 16491, 16502);
return return_v;
}


int
f_1311_16491_16508(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 16491, 16508);
return return_v;
}


int
f_1311_16511_16525()
{
var return_v = OutBufferCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 16511, 16525);
return return_v;
}


int
f_1311_16567_16596(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.DoExecute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 16567, 16596);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,15517,16642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,15517,16642);
}
		}

internal void AddItems(object objects)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,17325,19250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,17711,17770);

IEnumerator 
ie = f_1311_17728_17769(objects)
;
            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,17820,18427) || true) && (ie == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,17820,18427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,17876,17889);

f_1311_17876_17888(this, objects);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,17820,18427);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,17820,18427);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,17971,18408) || true) && (f_1311_17978_18016(_context, null, ie))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,17971,18408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18066,18105);

object 
o = f_1311_18077_18104(null, ie)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18227,18350) || true) && (o == f_1311_18236_18256())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,18227,18350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18314,18323);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,18227,18350);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18378,18385);

f_1311_18378_18384(this, o);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,17971,18408);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1311,17971,18408);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1311,17971,18408);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1311,17820,18427);
}
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(1311,18456,18885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18684,18719);

var 
disposable = ie as IDisposable
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18737,18870) || true) && (disposable != null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 18741, 18788)&&!(objects is IEnumerator)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,18737,18870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18830,18851);

f_1311_18830_18850(                    disposable);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,18737,18870);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(1311,18456,18885);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18901,18954) || true) && (_externalWriter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,18901,18954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,18947,18954);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,18901,18954);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19070,19239) || true) && (_downstreamCmdlet != null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 19074, 19122)&&f_1311_19103_19114()!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1311, 19074, 19160)&&f_1311_19126_19143(f_1311_19126_19137())> f_1311_19146_19160()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19070,19239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19194,19224);

f_1311_19194_19223(                _downstreamCmdlet);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19070,19239);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,17325,19250);

System.Collections.IEnumerator
f_1311_17728_17769(object
obj)
{
var return_v = LanguagePrimitives.GetEnumerator( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 17728, 17769);
return return_v;
}


int
f_1311_17876_17888(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.Add( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 17876, 17888);
return 0;
}


bool
f_1311_17978_18016(System.Management.Automation.ExecutionContext
context,System.Management.Automation.Language.IScriptExtent
errorPosition,System.Collections.IEnumerator
enumerator)
{
var return_v = ParserOps.MoveNext( context, errorPosition, enumerator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 17978, 18016);
return return_v;
}


object
f_1311_18077_18104(System.Management.Automation.Language.IScriptExtent
errorPosition,System.Collections.IEnumerator
enumerator)
{
var return_v = ParserOps.Current( errorPosition, enumerator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 18077, 18104);
return return_v;
}


System.Management.Automation.PSObject
f_1311_18236_18256()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 18236, 18256);
return return_v;
}


int
f_1311_18378_18384(System.Management.Automation.Internal.Pipe
this_param,object
obj)
{
this_param.Add( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 18378, 18384);
return 0;
}


int
f_1311_18830_18850(System.IDisposable
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 18830, 18850);
return 0;
}


System.Collections.Generic.Queue<object>
f_1311_19103_19114()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19103, 19114);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_19126_19137()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19126, 19137);
return return_v;
}


int
f_1311_19126_19143(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19126, 19143);
return return_v;
}


int
f_1311_19146_19160()
{
var return_v = OutBufferCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19146, 19160);
return return_v;
}


int
f_1311_19194_19223(System.Management.Automation.CommandProcessorBase
this_param)
{
this_param.DoExecute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 19194, 19223);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,17325,19250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,17325,19250);
}
		}

internal object Retrieve()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,19582,21313);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19633,21302) || true) && (f_1311_19637_19648()!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1311, 19637, 19682)&&f_1311_19660_19677(f_1311_19660_19671())!= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19633,21302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19716,19745);

return f_1311_19723_19744(f_1311_19723_19734());
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19633,21302);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19633,21302);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19779,21302) || true) && (_enumeratorToProcess != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19779,21302);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19845,19927) || true) && (_enumeratorToProcessIsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19845,19927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19899,19927);

return f_1311_19906_19926();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19845,19927);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,19947,20154) || true) && (!f_1311_19952_20008(_context, null, _enumeratorToProcess))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19947,20154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20050,20085);

_enumeratorToProcessIsEmpty = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20107,20135);

return f_1311_20114_20134();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19947,20154);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20174,20227);

return f_1311_20181_20226(null, _enumeratorToProcess);
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19779,21302);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,19779,21302);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20261,21302) || true) && (f_1311_20265_20279()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,20261,21302);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20365,20398);

object 
o = f_1311_20376_20397(f_1311_20376_20390())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20420,20897) || true) && (f_1311_20424_20444()== o)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,20420,20897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20852,20874);

ExternalReader = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,20420,20897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,20921,20930);

return o;
                }
                catch (PipelineClosedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1311,20967,21086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21039,21067);

return f_1311_21046_21066();
DynAbs.Tracing.TraceSender.TraceExitCatch(1311,20967,21086);
                }
                catch (ObjectDisposedException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1311,21104,21223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21176,21204);

return f_1311_21183_21203();
DynAbs.Tracing.TraceSender.TraceExitCatch(1311,21104,21223);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,20261,21302);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,20261,21302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21274,21302);

return f_1311_21281_21301();
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,20261,21302);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19779,21302);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,19633,21302);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,19582,21313);

System.Collections.Generic.Queue<object>
f_1311_19637_19648()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19637, 19648);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_19660_19671()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19660, 19671);
return return_v;
}


int
f_1311_19660_19677(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19660, 19677);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_19723_19734()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19723, 19734);
return return_v;
}


object
f_1311_19723_19744(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Dequeue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 19723, 19744);
return return_v;
}


System.Management.Automation.PSObject
f_1311_19906_19926()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 19906, 19926);
return return_v;
}


bool
f_1311_19952_20008(System.Management.Automation.ExecutionContext
context,System.Management.Automation.Language.IScriptExtent
errorPosition,System.Collections.IEnumerator
enumerator)
{
var return_v = ParserOps.MoveNext( context, errorPosition, enumerator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 19952, 20008);
return return_v;
}


System.Management.Automation.PSObject
f_1311_20114_20134()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 20114, 20134);
return return_v;
}


object
f_1311_20181_20226(System.Management.Automation.Language.IScriptExtent
errorPosition,System.Collections.IEnumerator
enumerator)
{
var return_v = ParserOps.Current( errorPosition, enumerator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 20181, 20226);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1311_20265_20279()
{
var return_v = ExternalReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 20265, 20279);
return return_v;
}


System.Management.Automation.Runspaces.PipelineReader<object>
f_1311_20376_20390()
{
var return_v = ExternalReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 20376, 20390);
return return_v;
}


object
f_1311_20376_20397(System.Management.Automation.Runspaces.PipelineReader<object>
this_param)
{
var return_v = this_param.Read();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 20376, 20397);
return return_v;
}


System.Management.Automation.PSObject
f_1311_20424_20444()
{
var return_v = AutomationNull.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 20424, 20444);
return return_v;
}


System.Management.Automation.PSObject
f_1311_21046_21066()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21046, 21066);
return return_v;
}


System.Management.Automation.PSObject
f_1311_21183_21203()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21183, 21203);
return return_v;
}


System.Management.Automation.PSObject
f_1311_21281_21301()
{
var return_v = AutomationNull.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21281, 21301);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,19582,21313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,19582,21313);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void Clear()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,21424,21543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21470,21532) || true) && (f_1311_21474_21485()!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,21470,21532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21512,21532);

f_1311_21512_21531(f_1311_21512_21523());
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,21470,21532);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,21424,21543);

System.Collections.Generic.Queue<object>
f_1311_21474_21485()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21474, 21485);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_21512_21523()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21512, 21523);
return return_v;
}


int
f_1311_21512_21531(System.Collections.Generic.Queue<object>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 21512, 21531);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,21424,21543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,21424,21543);
}
		}

internal object[] ToArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1311,21866,22084);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21918,22028) || true) && (f_1311_21922_21933()== null ||(DynAbs.Tracing.TraceSender.Expression_False(1311, 21922, 21967)||f_1311_21945_21962(f_1311_21945_21956())== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1311,21918,22028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,21986,22028);

return MshCommandRuntime.StaticEmptyArray;
DynAbs.Tracing.TraceSender.TraceExitCondition(1311,21918,22028);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1311,22044,22073);

return f_1311_22051_22072(f_1311_22051_22062());
DynAbs.Tracing.TraceSender.TraceExitMethod(1311,21866,22084);

System.Collections.Generic.Queue<object>
f_1311_21922_21933()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21922, 21933);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_21945_21956()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21945, 21956);
return return_v;
}


int
f_1311_21945_21962(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 21945, 21962);
return return_v;
}


System.Collections.Generic.Queue<object>
f_1311_22051_22062()
{
var return_v = ObjectQueue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1311, 22051, 22062);
return return_v;
}


object[]
f_1311_22051_22072(System.Collections.Generic.Queue<object>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 22051, 22072);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1311,21866,22084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,21866,22084);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static Pipe()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1311,874,22091);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1311,874,22091);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1311,874,22091);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1311,874,22091);

System.Collections.Generic.Queue<object>
f_1311_11412_11431()
{
var return_v = new System.Collections.Generic.Queue<object>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 11412, 11431);
return return_v;
}


int
f_1311_11680_11747(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 11680, 11747);
return 0;
}


int
f_1311_12305_12384(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 12305, 12384);
return 0;
}


int
f_1311_13027_13102(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 13027, 13102);
return 0;
}


int
f_1311_13117_13185(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 13117, 13185);
return 0;
}


int
f_1311_13597_13682(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1311, 13597, 13682);
return 0;
}

}
}
