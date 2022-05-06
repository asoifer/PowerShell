// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;

namespace Microsoft.PowerShell.Commands
{
[Cmdlet(VerbsCommon.New, "PSSessionOption", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096488", RemotingCapability = RemotingCapability.None)]
    [OutputType(typeof(PSSessionOption))]
    public sealed class NewPSSessionOptionCommand : PSCmdlet
{
[Parameter]
        public int MaximumRedirection
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,1102,1143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,1108,1141);

return f_1599_1115_1140(_maximumRedirection);
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,1102,1143);

int
f_1599_1115_1140(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 1115, 1140);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,1027,1206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,1027,1206);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,1159,1195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,1165,1193);

_maximumRedirection = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,1159,1195);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,1027,1206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,1027,1206);
}
		}}

private int? _maximumRedirection;

[Parameter]
        public SwitchParameter NoCompression {get; set; }

[Parameter]
        public SwitchParameter NoMachineProfile {get; set; }

[Parameter]
        [ValidateNotNull]
        public CultureInfo Culture {get; set; }

[Parameter]
        [ValidateNotNull]
        public CultureInfo UICulture {get; set; }

[Parameter]
        public int MaximumReceivedDataSizePerCommand
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,3068,3117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3074,3115);

return f_1599_3081_3114(_maxRecvdDataSizePerCommand);
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,3068,3117);

int
f_1599_3081_3114(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 3081, 3114);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,2978,3188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,2978,3188);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,3133,3177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3139,3175);

_maxRecvdDataSizePerCommand = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,3133,3177);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,2978,3188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,2978,3188);
}
		}}

private int? _maxRecvdDataSizePerCommand;

[Parameter]
        public int MaximumReceivedObjectSize
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,3560,3601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3566,3599);

return f_1599_3573_3598(_maxRecvdObjectSize);
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,3560,3601);

int
f_1599_3573_3598(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 3573, 3598);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,3478,3664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,3478,3664);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,3617,3653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3623,3651);

_maxRecvdObjectSize = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,3617,3653);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,3478,3664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,3478,3664);
}
		}}

private int? _maxRecvdObjectSize;

[Parameter]
        public OutputBufferingMode OutputBufferingMode {get; set; }

[Parameter]
        [ValidateRange(0, Int32.MaxValue)]
        public int MaxConnectionRetryCount {get; set; }

[Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public PSPrimitiveDictionary ApplicationArguments {get; set; }

[Parameter]
        [Alias("OpenTimeoutMSec")]
        [ValidateRange(0, Int32.MaxValue)]
        public int OpenTimeout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,5297,5463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,5333,5448);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1599, 5340, 5361)||((f_1599_5340_5361(_openTimeout)&&DynAbs.Tracing.TraceSender.Conditional_F2(1599, 5364, 5382))||DynAbs.Tracing.TraceSender.Conditional_F3(1599, 5406, 5447)))?f_1599_5364_5382(_openTimeout):                    RunspaceConnectionInfo.DefaultOpenTimeout;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,5297,5463);

bool
f_1599_5340_5361(int?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 5340, 5361);
return return_v;
}


int
f_1599_5364_5382(int?
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 5364, 5382);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,5149,5519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,5149,5519);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,5479,5508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,5485,5506);

_openTimeout = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,5479,5508);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,5149,5519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,5149,5519);
}
		}}

private int? _openTimeout;

[Parameter]
        [Alias("CancelTimeoutMSec")]
        [ValidateRange(0, Int32.MaxValue)]
        public int CancelTimeout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,6354,6524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,6390,6509);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1599, 6397, 6420)||((f_1599_6397_6420(_cancelTimeout)&&DynAbs.Tracing.TraceSender.Conditional_F2(1599, 6423, 6443))||DynAbs.Tracing.TraceSender.Conditional_F3(1599, 6467, 6508)))?f_1599_6423_6443(_cancelTimeout):                    BaseTransportManager.ClientCloseTimeoutMs;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,6354,6524);

bool
f_1599_6397_6420(int?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 6397, 6420);
return return_v;
}


int
f_1599_6423_6443(int?
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 6423, 6443);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,6202,6582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,6202,6582);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,6540,6571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,6546,6569);

_cancelTimeout = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,6540,6571);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,6202,6582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,6202,6582);
}
		}}

private int? _cancelTimeout;

[Parameter]
        [ValidateRange(-1, Int32.MaxValue)]
        [Alias("IdleTimeoutMSec")]
        public int IdleTimeout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,7141,7307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,7177,7292);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1599, 7184, 7205)||((f_1599_7184_7205(_idleTimeout)&&DynAbs.Tracing.TraceSender.Conditional_F2(1599, 7208, 7226))||DynAbs.Tracing.TraceSender.Conditional_F3(1599, 7250, 7291)))?f_1599_7208_7226(_idleTimeout):RunspaceConnectionInfo.DefaultIdleTimeout;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,7141,7307);

bool
f_1599_7184_7205(int?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 7184, 7205);
return return_v;
}


int
f_1599_7208_7226(int?
this_param)
{
var return_v = this_param.Value
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 7208, 7226);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,6992,7363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,6992,7363);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,7323,7352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,7329,7350);

_idleTimeout = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,7323,7352);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,6992,7363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,6992,7363);
}
		}}

private int? _idleTimeout;

[Parameter]
        [ValidateNotNullOrEmpty]
        public ProxyAccessType ProxyAccessType {get; set; }

[Parameter]
        public AuthenticationMechanism ProxyAuthentication {get; set; }

[Parameter]
        [ValidateNotNullOrEmpty]
        [Credential]
        public PSCredential ProxyCredential {get; set; }

[Parameter]
        public SwitchParameter SkipCACheck
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,9575,9603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,9581,9601);

return _skipcacheck;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,9575,9603);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,9495,9659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,9495,9659);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,9619,9648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,9625,9646);

_skipcacheck = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,9619,9648);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,9495,9659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,9495,9659);
}
		}}

private bool _skipcacheck;

[Parameter]
        public SwitchParameter SkipCNCheck
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,10157,10185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10163,10183);

return _skipcncheck;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,10157,10185);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,10077,10241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,10077,10241);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,10201,10230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10207,10228);

_skipcncheck = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,10201,10230);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,10077,10241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,10077,10241);
}
		}}

private bool _skipcncheck;

[Parameter]
        public SwitchParameter SkipRevocationCheck
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,10763,10799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10769,10797);

return _skiprevocationcheck;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,10763,10799);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,10675,10863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,10675,10863);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,10815,10852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10821,10850);

_skiprevocationcheck = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,10815,10852);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,10675,10863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,10675,10863);
}
		}}

private bool _skiprevocationcheck;

[Parameter]
        [Alias("OperationTimeoutMSec")]
        [ValidateRange(0, Int32.MaxValue)]
        public int OperationTimeout
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,11279,11468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,11315,11453);

return ((DynAbs.Tracing.TraceSender.Conditional_F1(1599, 11323, 11349)||((f_1599_11323_11349(_operationtimeout)&&DynAbs.Tracing.TraceSender.Conditional_F2(1599, 11352, 11375))||DynAbs.Tracing.TraceSender.Conditional_F3(1599, 11399, 11451)))?f_1599_11352_11375(_operationtimeout):                    BaseTransportManager.ClientDefaultOperationTimeoutMs);
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,11279,11468);

bool
f_1599_11323_11349(int?
this_param)
{
var return_v = this_param.HasValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 11323, 11349);
return return_v;
}


int
f_1599_11352_11375(int?
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 11352, 11375);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,11121,11529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,11121,11529);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,11484,11518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,11490,11516);

_operationtimeout = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,11484,11518);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,11121,11529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,11121,11529);
}
		}}

private int? _operationtimeout;

[Parameter]
        public SwitchParameter NoEncryption
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,12010,12039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12016,12037);

return _noencryption;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,12010,12039);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,11929,12139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,11929,12139);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,12055,12128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12091,12113);

_noencryption = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,12055,12128);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,11929,12139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,11929,12139);
}
		}}

private bool _noencryption;

[Parameter]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UTF")]
        public SwitchParameter UseUTF16
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,12622,12647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12628,12645);

return _useutf16;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,12622,12647);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,12435,12743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,12435,12743);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,12663,12732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12699,12717);

_useutf16 = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,12663,12732);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,12435,12743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,12435,12743);
}
		}}

private bool _useutf16;

[Parameter]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SPN")]
        public SwitchParameter IncludePortInSPN
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,13129,13162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13135,13160);

return _includePortInSPN;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,13129,13162);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,12934,13223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,12934,13223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,13178,13212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13184,13210);

_includePortInSPN = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,13178,13212);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,12934,13223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,12934,13223);
}
		}}

private bool _includePortInSPN;

protected override void BeginProcessing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1599,13449,15911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13515,13562);

PSSessionOption 
result = f_1599_13540_13561()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13633,13679);

result.ProxyAccessType = f_1599_13658_13678(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13693,13747);

result.ProxyAuthentication = f_1599_13722_13746(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13761,13807);

result.ProxyCredential = f_1599_13786_13806(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13829,13867);

result.SkipCACheck = f_1599_13850_13866(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13881,13919);

result.SkipCNCheck = f_1599_13902_13918(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13944,13998);

result.SkipRevocationCheck = f_1599_13973_13997(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14012,14168) || true) && (f_1599_14016_14042(_operationtimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,14012,14168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14076,14153);

result.OperationTimeout = TimeSpan.FromMilliseconds(f_1599_14128_14151(_operationtimeout));
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,14012,14168);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14184,14224);

result.NoEncryption = f_1599_14206_14223(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14238,14270);

result.UseUTF16 = f_1599_14256_14269(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14284,14332);

result.IncludePortInSPN = f_1599_14310_14331(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14390,14538) || true) && (f_1599_14394_14422(_maximumRedirection))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,14390,14538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14456,14523);

result.MaximumConnectionRedirectionCount = f_1599_14499_14522(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,14390,14538);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14554,14606);

result.NoCompression = this.NoCompression.IsPresent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14620,14678);

result.NoMachineProfile = this.NoMachineProfile.IsPresent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14694,14765);

result.MaximumReceivedDataSizePerCommand = _maxRecvdDataSizePerCommand;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14779,14834);

result.MaximumReceivedObjectSize = _maxRecvdObjectSize;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14850,14953) || true) && (f_1599_14854_14866(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,14850,14953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14908,14938);

result.Culture = f_1599_14925_14937(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,14850,14953);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,14969,15078) || true) && (f_1599_14973_14987(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,14969,15078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15029,15063);

result.UICulture = f_1599_15048_15062(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,14969,15078);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15094,15235) || true) && (f_1599_15098_15119(_openTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,15094,15235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15153,15220);

result.OpenTimeout = TimeSpan.FromMilliseconds(f_1599_15200_15218(_openTimeout));
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,15094,15235);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15251,15398) || true) && (f_1599_15255_15278(_cancelTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,15251,15398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15312,15383);

result.CancelTimeout = TimeSpan.FromMilliseconds(f_1599_15361_15381(_cancelTimeout));
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,15251,15398);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15414,15555) || true) && (f_1599_15418_15439(_idleTimeout))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,15414,15555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15473,15540);

result.IdleTimeout = TimeSpan.FromMilliseconds(f_1599_15520_15538(_idleTimeout));
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,15414,15555);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15571,15620);

result.OutputBufferingMode = f_1599_15600_15619();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15636,15693);

result.MaxConnectionRetryCount = f_1599_15669_15692();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15709,15851) || true) && (f_1599_15713_15738(this)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1599,15709,15851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15780,15836);

result.ApplicationArguments = f_1599_15810_15835(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(1599,15709,15851);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,15875,15900);

f_1599_15875_15899(
            this, result);
DynAbs.Tracing.TraceSender.TraceExitMethod(1599,13449,15911);

System.Management.Automation.Remoting.PSSessionOption
f_1599_13540_13561()
{
var return_v = new System.Management.Automation.Remoting.PSSessionOption();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1599, 13540, 13561);
return return_v;
}


System.Management.Automation.Remoting.ProxyAccessType
f_1599_13658_13678(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.ProxyAccessType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13658, 13678);
return return_v;
}


System.Management.Automation.Runspaces.AuthenticationMechanism
f_1599_13722_13746(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.ProxyAuthentication;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13722, 13746);
return return_v;
}


System.Management.Automation.PSCredential
f_1599_13786_13806(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.ProxyCredential;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13786, 13806);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_13850_13866(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.SkipCACheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13850, 13866);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_13902_13918(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.SkipCNCheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13902, 13918);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_13973_13997(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.SkipRevocationCheck;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 13973, 13997);
return return_v;
}


bool
f_1599_14016_14042(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14016, 14042);
return return_v;
}


int
f_1599_14128_14151(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14128, 14151);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_14206_14223(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.NoEncryption;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14206, 14223);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_14256_14269(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.UseUTF16;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14256, 14269);
return return_v;
}


System.Management.Automation.SwitchParameter
f_1599_14310_14331(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.IncludePortInSPN;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14310, 14331);
return return_v;
}


bool
f_1599_14394_14422(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14394, 14422);
return return_v;
}


int
f_1599_14499_14522(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.MaximumRedirection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14499, 14522);
return return_v;
}


System.Globalization.CultureInfo
f_1599_14854_14866(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.Culture ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14854, 14866);
return return_v;
}


System.Globalization.CultureInfo
f_1599_14925_14937(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.Culture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14925, 14937);
return return_v;
}


System.Globalization.CultureInfo
f_1599_14973_14987(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.UICulture ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 14973, 14987);
return return_v;
}


System.Globalization.CultureInfo
f_1599_15048_15062(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.UICulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15048, 15062);
return return_v;
}


bool
f_1599_15098_15119(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15098, 15119);
return return_v;
}


int
f_1599_15200_15218(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15200, 15218);
return return_v;
}


bool
f_1599_15255_15278(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15255, 15278);
return return_v;
}


int
f_1599_15361_15381(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15361, 15381);
return return_v;
}


bool
f_1599_15418_15439(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15418, 15439);
return return_v;
}


int
f_1599_15520_15538(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15520, 15538);
return return_v;
}


System.Management.Automation.Runspaces.OutputBufferingMode
f_1599_15600_15619()
{
var return_v = OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15600, 15619);
return return_v;
}


int
f_1599_15669_15692()
{
var return_v = MaxConnectionRetryCount;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15669, 15692);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1599_15713_15738(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.ApplicationArguments ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15713, 15738);
return return_v;
}


System.Management.Automation.PSPrimitiveDictionary
f_1599_15810_15835(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param)
{
var return_v = this_param.ApplicationArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1599, 15810, 15835);
return return_v;
}


int
f_1599_15875_15899(Microsoft.PowerShell.Commands.NewPSSessionOptionCommand
this_param,System.Management.Automation.Remoting.PSSessionOption
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1599, 15875, 15899);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1599,13449,15911);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,13449,15911);
}
		}

public NewPSSessionOptionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1599,482,15948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,1231,1250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,2426,2514);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,2633,2723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3213,3240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3689,3708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,3906,3987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,4177,4290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,4492,4696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,5544,5556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,6607,6621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,7388,7400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,7767,7898);
this.ProxyAccessType = ProxyAccessType.None;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,8518,8640);
this.ProxyAuthentication = AuthenticationMechanism.Negotiate;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,8786,8912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,9684,9696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10266,10278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,10888,10908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,11554,11571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12164,12177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,12768,12777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1599,13248,13265);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1599,482,15948);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,482,15948);
}


static NewPSSessionOptionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1599,482,15948);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1599,482,15948);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1599,482,15948);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1599,482,15948);
}
}
