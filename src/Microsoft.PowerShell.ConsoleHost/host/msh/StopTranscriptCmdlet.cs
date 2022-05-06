// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsLifecycle.Stop, "Transcript", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096798")]
    [OutputType(typeof(string))]
    public sealed class StopTranscriptCommand : PSCmdlet
{
protected override
        void
        BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(128,638,1421);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,758,806);

string 
outFilename = f_128_779_805(f_128_779_786(f_128_779_783()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,824,1182) || true) && (outFilename != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(128,824,1182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,889,1024);

PSObject 
outputObject = f_128_913_1023(f_128_952_1022(f_128_970_1008(), outFilename))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,1046,1115);

f_128_1046_1114(f_128_1046_1069(outputObject), f_128_1074_1113("Path", outFilename));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,1137,1163);

f_128_1137_1162(this, outputObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(128,824,1182);
}
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(128,1211,1410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(128,1263,1395);

throw f_128_1269_1394(e, f_128_1341_1382(), f_128_1384_1393(e));
DynAbs.Tracing.TraceSender.TraceExitCatch(128,1211,1410);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(128,638,1421);

System.Management.Automation.Host.PSHost
f_128_779_783()
{
var return_v = Host;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 779, 783);
return return_v;
}


System.Management.Automation.Host.PSHostUserInterface
f_128_779_786(System.Management.Automation.Host.PSHost
this_param)
{
var return_v = this_param.UI;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 779, 786);
return return_v;
}


string
f_128_779_805(System.Management.Automation.Host.PSHostUserInterface
this_param)
{
var return_v = this_param.StopTranscribing();
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 779, 805);
return return_v;
}


string
f_128_970_1008()
{
var return_v = TranscriptStrings.TranscriptionStopped;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 970, 1008);
return return_v;
}


string
f_128_952_1022(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 952, 1022);
return return_v;
}


System.Management.Automation.PSObject
f_128_913_1023(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 913, 1023);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_128_1046_1069(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 1046, 1069);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_128_1074_1113(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1074, 1113);
return return_v;
}


int
f_128_1046_1114(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1046, 1114);
return 0;
}


int
f_128_1137_1162(Microsoft.PowerShell.Commands.StopTranscriptCommand
this_param,System.Management.Automation.PSObject
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1137, 1162);
return 0;
}


string
f_128_1341_1382()
{
var return_v = TranscriptStrings.ErrorStoppingTranscript;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 1341, 1382);
return return_v;
}


string
f_128_1384_1393(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(128, 1384, 1393);
return return_v;
}


System.Management.Automation.PSInvalidOperationException
f_128_1269_1394(System.Exception
innerException,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewInvalidOperationException( innerException, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(128, 1269, 1394);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(128,638,1421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128,638,1421);
}
		}

public StopTranscriptCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(128,337,1428);
DynAbs.Tracing.TraceSender.TraceExitConstructor(128,337,1428);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128,337,1428);
}


static StopTranscriptCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(128,337,1428);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(128,337,1428);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(128,337,1428);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(128,337,1428);
}
}
