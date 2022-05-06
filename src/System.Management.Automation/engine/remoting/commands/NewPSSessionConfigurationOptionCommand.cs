// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;

namespace Microsoft.PowerShell.Commands
{
public class WSManConfigurationOption : PSTransportOption
{
private const string 
Token = " {0}='{1}'"
;

private const string 
QuotasToken = "<Quotas {0} />"
;

internal const string 
AttribOutputBufferingMode = "OutputBufferingMode"
;

internal static System.Management.Automation.Runspaces.OutputBufferingMode? DefaultOutputBufferingMode ;

private System.Management.Automation.Runspaces.OutputBufferingMode? _outputBufferingMode ;

private const string 
AttribProcessIdleTimeout = "ProcessIdleTimeoutSec"
;

internal static readonly int? DefaultProcessIdleTimeout_ForPSRemoting ;

private int? _processIdleTimeoutSec ;

internal const string 
AttribMaxIdleTimeout = "MaxIdleTimeoutms"
;

internal static readonly int? DefaultMaxIdleTimeout ;

private int? _maxIdleTimeoutSec ;

internal const string 
AttribIdleTimeout = "IdleTimeoutms"
;

internal static readonly int? DefaultIdleTimeout ;

private int? _idleTimeoutSec ;

private const string 
AttribMaxConcurrentUsers = "MaxConcurrentUsers"
;

internal static readonly int? DefaultMaxConcurrentUsers ;

private int? _maxConcurrentUsers ;

private const string 
AttribMaxProcessesPerSession = "MaxProcessesPerShell"
;

internal static readonly int? DefaultMaxProcessesPerSession ;

private int? _maxProcessesPerSession ;

private const string 
AttribMaxMemoryPerSessionMB = "MaxMemoryPerShellMB"
;

internal static readonly int? DefaultMaxMemoryPerSessionMB ;

private int? _maxMemoryPerSessionMB ;

private const string 
AttribMaxSessions = "MaxShells"
;

internal static readonly int? DefaultMaxSessions ;

private int? _maxSessions ;

private const string 
AttribMaxSessionsPerUser = "MaxShellsPerUser"
;

internal static readonly int? DefaultMaxSessionsPerUser ;

private int? _maxSessionsPerUser ;

private const string 
AttribMaxConcurrentCommandsPerSession = "MaxConcurrentCommandsPerShell"
;

internal static readonly int? DefaultMaxConcurrentCommandsPerSession ;

private int? _maxConcurrentCommandsPerSession ;

internal WSManConfigurationOption()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1598,3032,3089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,926,953);
this._outputBufferingMode = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1159,1188);
this._processIdleTimeoutSec = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1365,1390);
this._maxIdleTimeoutSec = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1572,1594);
this._idleTimeoutSec = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1780,1806);
this._maxConcurrentUsers = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2002,2032);
this._maxProcessesPerSession = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2225,2254);
this._maxMemoryPerSessionMB = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2417,2436);
this._maxSessions = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2620,2646);
this._maxSessionsPerUser = null;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2869,2908);
this._maxConcurrentCommandsPerSession = null;DynAbs.Tracing.TraceSender.TraceExitConstructor(1598,3032,3089);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,3032,3089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,3032,3089);
}
		}

protected internal override void LoadFromDefaults(bool keepAssigned)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,3260,5019);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3353,3503) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 3357, 3404)||f_1598_3374_3404_M(!_outputBufferingMode.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,3353,3503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3438,3488);

_outputBufferingMode = DefaultOutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,3353,3503);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3519,3686) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 3523, 3572)||f_1598_3540_3572_M(!_processIdleTimeoutSec.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,3519,3686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3606,3671);

_processIdleTimeoutSec = DefaultProcessIdleTimeout_ForPSRemoting;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,3519,3686);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3702,3843) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 3706, 3751)||f_1598_3723_3751_M(!_maxIdleTimeoutSec.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,3702,3843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3785,3828);

_maxIdleTimeoutSec = DefaultMaxIdleTimeout;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,3702,3843);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3859,3991) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 3863, 3905)||f_1598_3880_3905_M(!_idleTimeoutSec.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,3859,3991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,3939,3976);

_idleTimeoutSec = DefaultIdleTimeout;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,3859,3991);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4007,4154) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4011, 4057)||f_1598_4028_4057_M(!_maxConcurrentUsers.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4007,4154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4091,4139);

_maxConcurrentUsers = DefaultMaxConcurrentUsers;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4007,4154);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4170,4329) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4174, 4224)||f_1598_4191_4224_M(!_maxProcessesPerSession.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4170,4329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4258,4314);

_maxProcessesPerSession = DefaultMaxProcessesPerSession;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4170,4329);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4345,4501) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4349, 4398)||f_1598_4366_4398_M(!_maxMemoryPerSessionMB.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4345,4501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4432,4486);

_maxMemoryPerSessionMB = DefaultMaxMemoryPerSessionMB;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4345,4501);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4517,4643) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4521, 4560)||f_1598_4538_4560_M(!_maxSessions.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4517,4643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4594,4628);

_maxSessions = DefaultMaxSessions;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4517,4643);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4659,4806) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4663, 4709)||f_1598_4680_4709_M(!_maxSessionsPerUser.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4659,4806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4743,4791);

_maxSessionsPerUser = DefaultMaxSessionsPerUser;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4659,4806);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4822,5008) || true) && (!keepAssigned ||(DynAbs.Tracing.TraceSender.Expression_False(1598, 4826, 4885)||f_1598_4843_4885_M(!_maxConcurrentCommandsPerSession.HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,4822,5008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,4919,4993);

_maxConcurrentCommandsPerSession = DefaultMaxConcurrentCommandsPerSession;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,4822,5008);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,3260,5019);

bool
f_1598_3374_3404_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 3374, 3404);
return return_v;
}


bool
f_1598_3540_3572_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 3540, 3572);
return return_v;
}


bool
f_1598_3723_3751_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 3723, 3751);
return return_v;
}


bool
f_1598_3880_3905_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 3880, 3905);
return return_v;
}


bool
f_1598_4028_4057_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4028, 4057);
return return_v;
}


bool
f_1598_4191_4224_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4191, 4224);
return return_v;
}


bool
f_1598_4366_4398_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4366, 4398);
return return_v;
}


bool
f_1598_4538_4560_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4538, 4560);
return return_v;
}


bool
f_1598_4680_4709_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4680, 4709);
return return_v;
}


bool
f_1598_4843_4885_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 4843, 4885);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,3260,5019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,3260,5019);
}
		}

public int? ProcessIdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5180,5261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5216,5246);

return _processIdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5180,5261);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5122,5379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5122,5379);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5277,5368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5322,5353);

_processIdleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5277,5368);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5122,5379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5122,5379);
}
		}}

public int? MaxIdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5532,5609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5568,5594);

return _maxIdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5532,5609);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5478,5723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5478,5723);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5625,5712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5670,5697);

_maxIdleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5625,5712);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5478,5723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5478,5723);
}
		}}

public int? MaxSessions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5856,5927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5892,5912);

return _maxSessions;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5856,5927);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5808,6035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5808,6035);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,5943,6024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,5988,6009);

_maxSessions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,5943,6024);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,5808,6035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,5808,6035);
}
		}}

public int? MaxConcurrentCommandsPerSession
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,6208,6299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,6244,6284);

return _maxConcurrentCommandsPerSession;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,6208,6299);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6140,6427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6140,6427);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,6315,6416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,6360,6401);

_maxConcurrentCommandsPerSession = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,6315,6416);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6140,6427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6140,6427);
}
		}}

public int? MaxSessionsPerUser
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,6574,6652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,6610,6637);

return _maxSessionsPerUser;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,6574,6652);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6519,6767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6519,6767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,6668,6756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,6713,6741);

_maxSessionsPerUser = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,6668,6756);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6519,6767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6519,6767);
}
		}}

public int? MaxMemoryPerSessionMB
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,6920,7001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,6956,6986);

return _maxMemoryPerSessionMB;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,6920,7001);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6862,7119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6862,7119);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7017,7108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7062,7093);

_maxMemoryPerSessionMB = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7017,7108);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,6862,7119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,6862,7119);
}
		}}

public int? MaxProcessesPerSession
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7274,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7310,7341);

return _maxProcessesPerSession;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7274,7356);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7215,7475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7215,7475);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7372,7464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7417,7449);

_maxProcessesPerSession = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7372,7464);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7215,7475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7215,7475);
}
		}}

public int? MaxConcurrentUsers
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7622,7700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7658,7685);

return _maxConcurrentUsers;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7622,7700);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7567,7815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7567,7815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7716,7804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7761,7789);

_maxConcurrentUsers = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7716,7804);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7567,7815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7567,7815);
}
		}}

public int? IdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,7962,8036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,7998,8021);

return _idleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,7962,8036);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7911,8147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7911,8147);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,8052,8136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8097,8121);

_idleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,8052,8136);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,7911,8147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,7911,8147);
}
		}}

public System.Management.Automation.Runspaces.OutputBufferingMode? OutputBufferingMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,8351,8430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8387,8415);

return _outputBufferingMode;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,8351,8430);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,8240,8546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,8240,8546);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
internal set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,8446,8535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8491,8520);

_outputBufferingMode = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,8446,8535);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,8240,8546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,8240,8546);
}
		}}

internal override Hashtable ConstructQuotasAsHashtable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,8558,10327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8639,8674);

Hashtable 
quotas = f_1598_8658_8673()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8690,8865) || true) && (f_1598_8694_8718(_idleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,8690,8865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8752,8850);

quotas[AttribIdleTimeout] = f_1598_8780_8849((1000 * f_1598_8788_8809(_idleTimeoutSec)), f_1598_8820_8848());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,8690,8865);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8881,9062) || true) && (f_1598_8885_8913(_maxConcurrentUsers))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,8881,9062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,8947,9047);

quotas[AttribMaxConcurrentUsers] = f_1598_8982_9046(f_1598_8982_9007(_maxConcurrentUsers), f_1598_9017_9045());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,8881,9062);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9078,9271) || true) && (f_1598_9082_9114(_maxProcessesPerSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,9078,9271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9148,9256);

quotas[AttribMaxProcessesPerSession] = f_1598_9187_9255(f_1598_9187_9216(_maxProcessesPerSession), f_1598_9226_9254());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,9078,9271);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9287,9477) || true) && (f_1598_9291_9322(_maxMemoryPerSessionMB))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,9287,9477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9356,9462);

quotas[AttribMaxMemoryPerSessionMB] = f_1598_9394_9461(f_1598_9394_9422(_maxMemoryPerSessionMB), f_1598_9432_9460());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,9287,9477);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9493,9674) || true) && (f_1598_9497_9525(_maxSessionsPerUser))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,9493,9674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9559,9659);

quotas[AttribMaxSessionsPerUser] = f_1598_9594_9658(f_1598_9594_9619(_maxSessionsPerUser), f_1598_9629_9657());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,9493,9674);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9690,9910) || true) && (f_1598_9694_9735(_maxConcurrentCommandsPerSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,9690,9910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9769,9895);

quotas[AttribMaxConcurrentCommandsPerSession] = f_1598_9817_9894(f_1598_9817_9855(_maxConcurrentCommandsPerSession), f_1598_9865_9893());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,9690,9910);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9926,10086) || true) && (f_1598_9930_9951(_maxSessions))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,9926,10086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,9985,10071);

quotas[AttribMaxSessions] = f_1598_10013_10070(f_1598_10013_10031(_maxSessions), f_1598_10041_10069());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,9926,10086);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10102,10286) || true) && (f_1598_10106_10133(_maxIdleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,10102,10286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10167,10271);

quotas[AttribMaxIdleTimeout] = f_1598_10198_10270((1000 * f_1598_10206_10230(_maxIdleTimeoutSec)), f_1598_10241_10269());
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,10102,10286);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10302,10316);

return quotas;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,8558,10327);

System.Collections.Hashtable
f_1598_8658_8673()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 8658, 8673);
return return_v;
}


bool
f_1598_8694_8718(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 8694, 8718);
return return_v;
}


int
f_1598_8788_8809(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 8788, 8809);
return return_v;
}


System.Globalization.CultureInfo
f_1598_8820_8848()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 8820, 8848);
return return_v;
}


string
f_1598_8780_8849(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 8780, 8849);
return return_v;
}


bool
f_1598_8885_8913(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 8885, 8913);
return return_v;
}


int
f_1598_8982_9007(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 8982, 9007);
return return_v;
}


System.Globalization.CultureInfo
f_1598_9017_9045()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9017, 9045);
return return_v;
}


string
f_1598_8982_9046(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 8982, 9046);
return return_v;
}


bool
f_1598_9082_9114(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9082, 9114);
return return_v;
}


int
f_1598_9187_9216(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9187, 9216);
return return_v;
}


System.Globalization.CultureInfo
f_1598_9226_9254()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9226, 9254);
return return_v;
}


string
f_1598_9187_9255(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 9187, 9255);
return return_v;
}


bool
f_1598_9291_9322(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9291, 9322);
return return_v;
}


int
f_1598_9394_9422(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9394, 9422);
return return_v;
}


System.Globalization.CultureInfo
f_1598_9432_9460()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9432, 9460);
return return_v;
}


string
f_1598_9394_9461(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 9394, 9461);
return return_v;
}


bool
f_1598_9497_9525(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9497, 9525);
return return_v;
}


int
f_1598_9594_9619(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9594, 9619);
return return_v;
}


System.Globalization.CultureInfo
f_1598_9629_9657()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9629, 9657);
return return_v;
}


string
f_1598_9594_9658(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 9594, 9658);
return return_v;
}


bool
f_1598_9694_9735(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9694, 9735);
return return_v;
}


int
f_1598_9817_9855(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9817, 9855);
return return_v;
}


System.Globalization.CultureInfo
f_1598_9865_9893()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9865, 9893);
return return_v;
}


string
f_1598_9817_9894(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 9817, 9894);
return return_v;
}


bool
f_1598_9930_9951(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 9930, 9951);
return return_v;
}


int
f_1598_10013_10031(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10013, 10031);
return return_v;
}


System.Globalization.CultureInfo
f_1598_10041_10069()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10041, 10069);
return return_v;
}


string
f_1598_10013_10070(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10013, 10070);
return return_v;
}


bool
f_1598_10106_10133(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10106, 10133);
return return_v;
}


int
f_1598_10206_10230(int?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10206, 10230);
return return_v;
}


System.Globalization.CultureInfo
f_1598_10241_10269()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10241, 10269);
return return_v;
}


string
f_1598_10198_10270(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10198, 10270);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,8558,10327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,8558,10327);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override string ConstructQuotas()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,10449,12559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10516,10555);

StringBuilder 
sb = f_1598_10535_10554()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10571,10753) || true) && (f_1598_10575_10599(_idleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,10571,10753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10633,10738);

f_1598_10633_10737(                sb, f_1598_10643_10736(f_1598_10657_10685(), Token, AttribIdleTimeout, 1000 * _idleTimeoutSec));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,10571,10753);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10769,10959) || true) && (f_1598_10773_10801(_maxConcurrentUsers))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,10769,10959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10835,10944);

f_1598_10835_10943(                sb, f_1598_10845_10942(f_1598_10859_10887(), Token, AttribMaxConcurrentUsers, _maxConcurrentUsers));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,10769,10959);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,10975,11177) || true) && (f_1598_10979_11011(_maxProcessesPerSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,10975,11177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11045,11162);

f_1598_11045_11161(                sb, f_1598_11055_11160(f_1598_11069_11097(), Token, AttribMaxProcessesPerSession, _maxProcessesPerSession));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,10975,11177);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11193,11392) || true) && (f_1598_11197_11228(_maxMemoryPerSessionMB))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,11193,11392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11262,11377);

f_1598_11262_11376(                sb, f_1598_11272_11375(f_1598_11286_11314(), Token, AttribMaxMemoryPerSessionMB, _maxMemoryPerSessionMB));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,11193,11392);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11408,11598) || true) && (f_1598_11412_11440(_maxSessionsPerUser))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,11408,11598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11474,11583);

f_1598_11474_11582(                sb, f_1598_11484_11581(f_1598_11498_11526(), Token, AttribMaxSessionsPerUser, _maxSessionsPerUser));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,11408,11598);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11614,11843) || true) && (f_1598_11618_11659(_maxConcurrentCommandsPerSession))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,11614,11843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11693,11828);

f_1598_11693_11827(                sb, f_1598_11703_11826(f_1598_11717_11745(), Token, AttribMaxConcurrentCommandsPerSession, _maxConcurrentCommandsPerSession));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,11614,11843);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11859,12028) || true) && (f_1598_11863_11884(_maxSessions))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,11859,12028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,11918,12013);

f_1598_11918_12012(                sb, f_1598_11928_12011(f_1598_11942_11970(), Token, AttribMaxSessions, _maxSessions));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,11859,12028);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12044,12388) || true) && (f_1598_12048_12075(_maxIdleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,12044,12388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12179,12373);

f_1598_12179_12372(                // Special case max int value for unbounded default.
                sb, f_1598_12189_12371(f_1598_12203_12231(), Token, AttribMaxIdleTimeout, (DynAbs.Tracing.TraceSender.Conditional_F1(1598, 12283, 12319)||((                    (_maxIdleTimeoutSec == int.MaxValue) &&DynAbs.Tracing.TraceSender.Conditional_F2(1598, 12322, 12340))||DynAbs.Tracing.TraceSender.Conditional_F3(1598, 12343, 12370)))?_maxIdleTimeoutSec :(1000 * _maxIdleTimeoutSec)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,12044,12388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12404,12548);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1598, 12411, 12424)||((f_1598_12411_12420(sb)> 0
&&DynAbs.Tracing.TraceSender.Conditional_F2(1598, 12444, 12515))||DynAbs.Tracing.TraceSender.Conditional_F3(1598, 12535, 12547)))?f_1598_12444_12515(f_1598_12458_12486(), QuotasToken, f_1598_12501_12514(sb)):string.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,10449,12559);

System.Text.StringBuilder
f_1598_10535_10554()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10535, 10554);
return return_v;
}


bool
f_1598_10575_10599(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10575, 10599);
return return_v;
}


System.Globalization.CultureInfo
f_1598_10657_10685()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10657, 10685);
return return_v;
}


string
f_1598_10643_10736(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10643, 10736);
return return_v;
}


System.Text.StringBuilder
f_1598_10633_10737(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10633, 10737);
return return_v;
}


bool
f_1598_10773_10801(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10773, 10801);
return return_v;
}


System.Globalization.CultureInfo
f_1598_10859_10887()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10859, 10887);
return return_v;
}


string
f_1598_10845_10942(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10845, 10942);
return return_v;
}


System.Text.StringBuilder
f_1598_10835_10943(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 10835, 10943);
return return_v;
}


bool
f_1598_10979_11011(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 10979, 11011);
return return_v;
}


System.Globalization.CultureInfo
f_1598_11069_11097()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11069, 11097);
return return_v;
}


string
f_1598_11055_11160(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11055, 11160);
return return_v;
}


System.Text.StringBuilder
f_1598_11045_11161(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11045, 11161);
return return_v;
}


bool
f_1598_11197_11228(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11197, 11228);
return return_v;
}


System.Globalization.CultureInfo
f_1598_11286_11314()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11286, 11314);
return return_v;
}


string
f_1598_11272_11375(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11272, 11375);
return return_v;
}


System.Text.StringBuilder
f_1598_11262_11376(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11262, 11376);
return return_v;
}


bool
f_1598_11412_11440(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11412, 11440);
return return_v;
}


System.Globalization.CultureInfo
f_1598_11498_11526()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11498, 11526);
return return_v;
}


string
f_1598_11484_11581(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11484, 11581);
return return_v;
}


System.Text.StringBuilder
f_1598_11474_11582(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11474, 11582);
return return_v;
}


bool
f_1598_11618_11659(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11618, 11659);
return return_v;
}


System.Globalization.CultureInfo
f_1598_11717_11745()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11717, 11745);
return return_v;
}


string
f_1598_11703_11826(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11703, 11826);
return return_v;
}


System.Text.StringBuilder
f_1598_11693_11827(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11693, 11827);
return return_v;
}


bool
f_1598_11863_11884(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11863, 11884);
return return_v;
}


System.Globalization.CultureInfo
f_1598_11942_11970()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 11942, 11970);
return return_v;
}


string
f_1598_11928_12011(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11928, 12011);
return return_v;
}


System.Text.StringBuilder
f_1598_11918_12012(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 11918, 12012);
return return_v;
}


bool
f_1598_12048_12075(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12048, 12075);
return return_v;
}


System.Globalization.CultureInfo
f_1598_12203_12231()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12203, 12231);
return return_v;
}


string
f_1598_12189_12371(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12189, 12371);
return return_v;
}


System.Text.StringBuilder
f_1598_12179_12372(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12179, 12372);
return return_v;
}


int
f_1598_12411_12420(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12411, 12420);
return return_v;
}


System.Globalization.CultureInfo
f_1598_12458_12486()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12458, 12486);
return return_v;
}


string
f_1598_12501_12514(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12501, 12514);
return return_v;
}


string
f_1598_12444_12515(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12444, 12515);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,10449,12559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,10449,12559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override string ConstructOptionsAsXmlAttributes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,12695,13295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12778,12817);

StringBuilder 
sb = f_1598_12797_12816()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12831,13035) || true) && (f_1598_12835_12864(_outputBufferingMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,12831,13035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,12898,13020);

f_1598_12898_13019(                sb, f_1598_12908_13018(f_1598_12922_12950(), Token, AttribOutputBufferingMode, f_1598_12986_13017(_outputBufferingMode)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,12831,13035);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13051,13247) || true) && (f_1598_13055_13086(_processIdleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,13051,13247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13120,13232);

f_1598_13120_13231(                sb, f_1598_13130_13230(f_1598_13144_13172(), Token, AttribProcessIdleTimeout, _processIdleTimeoutSec));
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,13051,13247);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13263,13284);

return f_1598_13270_13283(sb);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,12695,13295);

System.Text.StringBuilder
f_1598_12797_12816()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12797, 12816);
return return_v;
}


bool
f_1598_12835_12864(System.Management.Automation.Runspaces.OutputBufferingMode?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12835, 12864);
return return_v;
}


System.Globalization.CultureInfo
f_1598_12922_12950()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 12922, 12950);
return return_v;
}


string?
f_1598_12986_13017(System.Management.Automation.Runspaces.OutputBufferingMode?
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12986, 13017);
return return_v;
}


string
f_1598_12908_13018(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12908, 13018);
return return_v;
}


System.Text.StringBuilder
f_1598_12898_13019(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 12898, 13019);
return return_v;
}


bool
f_1598_13055_13086(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 13055, 13086);
return return_v;
}


System.Globalization.CultureInfo
f_1598_13144_13172()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 13144, 13172);
return return_v;
}


string
f_1598_13130_13230(System.Globalization.CultureInfo
provider,string
format,string
arg0,int?
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 13130, 13230);
return return_v;
}


System.Text.StringBuilder
f_1598_13120_13231(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 13120, 13231);
return return_v;
}


string
f_1598_13270_13283(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 13270, 13283);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,12695,13295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,12695,13295);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override Hashtable ConstructOptionsAsHashtable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,13431,13907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13513,13547);

Hashtable 
table = f_1598_13531_13546()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13561,13710) || true) && (f_1598_13565_13594(_outputBufferingMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,13561,13710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13628,13695);

table[AttribOutputBufferingMode] = f_1598_13663_13694(_outputBufferingMode);
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,13561,13710);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13726,13867) || true) && (f_1598_13730_13761(_processIdleTimeoutSec))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1598,13726,13867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13795,13852);

table[AttribProcessIdleTimeout] = _processIdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceExitCondition(1598,13726,13867);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,13883,13896);

return table;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,13431,13907);

System.Collections.Hashtable
f_1598_13531_13546()
{
var return_v = new System.Collections.Hashtable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 13531, 13546);
return return_v;
}


bool
f_1598_13565_13594(System.Management.Automation.Runspaces.OutputBufferingMode?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 13565, 13594);
return return_v;
}


string?
f_1598_13663_13694(System.Management.Automation.Runspaces.OutputBufferingMode?
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 13663, 13694);
return return_v;
}


bool
f_1598_13730_13761(int?
this_param)
{
var return_v = this_param.HasValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 13730, 13761);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,13431,13907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,13431,13907);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static WSManConfigurationOption()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1598,406,13914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,501,521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,553,583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,618,667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,754,847);
DefaultOutputBufferingMode = System.Management.Automation.Runspaces.OutputBufferingMode.Block;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,987,1037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1078,1121);
DefaultProcessIdleTimeout_ForPSRemoting = 0;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1223,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1305,1341);
DefaultMaxIdleTimeout = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1425,1460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1501,1526);
DefaultIdleTimeout = 7200;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1628,1675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1716,1756);
DefaultMaxConcurrentUsers = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1840,1893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,1934,1978);
DefaultMaxProcessesPerSession = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2066,2117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2158,2201);
DefaultMaxMemoryPerSessionMB = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2288,2319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2360,2393);
DefaultMaxSessions = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2470,2515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2556,2596);
DefaultMaxSessionsPerUser = int.MaxValue;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2680,2751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,2792,2845);
DefaultMaxConcurrentCommandsPerSession = int.MaxValue;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1598,406,13914);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,406,13914);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1598,406,13914);
}
[Cmdlet(VerbsCommon.New, "PSTransportOption", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=210608", RemotingCapability = RemotingCapability.None)]
    [OutputType(typeof(WSManConfigurationOption))]
    public sealed class NewPSTransportOptionCommand : PSCmdlet
{
private WSManConfigurationOption _option ;

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(60, 2147483)]
        public int? MaxIdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,14621,14705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,14657,14690);

return f_1598_14664_14689(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,14621,14705);

int?
f_1598_14664_14689(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxIdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 14664, 14689);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,14478,14817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14478,14817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,14721,14806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,14757,14791);

_option.MaxIdleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,14721,14806);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,14478,14817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14478,14817);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(0, 1209600)]
        public int? ProcessIdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,15058,15146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,15094,15131);

return f_1598_15101_15130(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,15058,15146);

int?
f_1598_15101_15130(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.ProcessIdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 15101, 15130);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,14912,15262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14912,15262);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,15162,15251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,15198,15236);

_option.ProcessIdleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,15162,15251);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,14912,15262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14912,15262);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(1, int.MaxValue)]
        public int? MaxSessions
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,15488,15566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,15524,15551);

return f_1598_15531_15550(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,15488,15566);

int?
f_1598_15531_15550(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxSessions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 15531, 15550);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,15347,15672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,15347,15672);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,15582,15661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,15618,15646);

_option.MaxSessions = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,15582,15661);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,15347,15672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,15347,15672);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(1, int.MaxValue)]
        public int? MaxConcurrentCommandsPerSession
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,15938,16036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,15974,16021);

return f_1598_15981_16020(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,15938,16036);

int?
f_1598_15981_16020(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxConcurrentCommandsPerSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 15981, 16020);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,15777,16162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,15777,16162);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,16052,16151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,16088,16136);

_option.MaxConcurrentCommandsPerSession = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,16052,16151);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,15777,16162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,15777,16162);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(1, int.MaxValue)]
        public int? MaxSessionsPerUser
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,16402,16487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,16438,16472);

return f_1598_16445_16471(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,16402,16487);

int?
f_1598_16445_16471(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxSessionsPerUser;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 16445, 16471);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,16254,16600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,16254,16600);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,16503,16589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,16539,16574);

_option.MaxSessionsPerUser = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,16503,16589);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,16254,16600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,16254,16600);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(5, int.MaxValue)]
        public int? MaxMemoryPerSessionMB
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,16846,16934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,16882,16919);

return f_1598_16889_16918(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,16846,16934);

int?
f_1598_16889_16918(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxMemoryPerSessionMB;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 16889, 16918);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,16695,17050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,16695,17050);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,16950,17039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,16986,17024);

_option.MaxMemoryPerSessionMB = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,16950,17039);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,16695,17050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,16695,17050);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(1, int.MaxValue)]
        public int? MaxProcessesPerSession
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,17298,17387);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,17334,17372);

return f_1598_17341_17371(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,17298,17387);

int?
f_1598_17341_17371(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxProcessesPerSession;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 17341, 17371);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,17146,17504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,17146,17504);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,17403,17493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,17439,17478);

_option.MaxProcessesPerSession = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,17403,17493);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,17146,17504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,17146,17504);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(1, 100)]
        public int? MaxConcurrentUsers
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,17735,17820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,17771,17805);

return f_1598_17778_17804(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,17735,17820);

int?
f_1598_17778_17804(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.MaxConcurrentUsers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 17778, 17804);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,17596,17933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,17596,17933);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,17836,17922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,17872,17907);

_option.MaxConcurrentUsers = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,17836,17922);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,17596,17933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,17596,17933);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true), ValidateRange(60, 2147483)]
        public int? IdleTimeoutSec
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,18160,18241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,18196,18226);

return f_1598_18203_18225(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,18160,18241);

int?
f_1598_18203_18225(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.IdleTimeoutSec;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 18203, 18225);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,18020,18350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,18020,18350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,18257,18339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,18293,18324);

_option.IdleTimeoutSec = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,18257,18339);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,18020,18350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,18020,18350);
}
		}}

[Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Management.Automation.Runspaces.OutputBufferingMode? OutputBufferingMode
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,18615,18701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,18651,18686);

return f_1598_18658_18685(_option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,18615,18701);

System.Management.Automation.Runspaces.OutputBufferingMode?
f_1598_18658_18685(Microsoft.PowerShell.Commands.WSManConfigurationOption
this_param)
{
var return_v = this_param.OutputBufferingMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1598, 18658, 18685);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,18443,18815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,18443,18815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,18717,18804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,18753,18789);

_option.OutputBufferingMode = value;
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,18717,18804);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,18443,18815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,18443,18815);
}
		}}

protected override void ProcessRecord()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1598,18915,19016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,18979,19005);

f_1598_18979_19004(            this, _option);
DynAbs.Tracing.TraceSender.TraceExitMethod(1598,18915,19016);

int
f_1598_18979_19004(Microsoft.PowerShell.Commands.NewPSTransportOptionCommand
this_param,Microsoft.PowerShell.Commands.WSManConfigurationOption
sendToPipeline)
{
this_param.WriteObject( (object)sendToPipeline);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 18979, 19004);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1598,18915,19016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,18915,19016);
}
		}

public NewPSTransportOptionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1598,14028,19023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1598,14346,14386);
this._option = f_1598_14356_14386();DynAbs.Tracing.TraceSender.TraceExitConstructor(1598,14028,19023);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14028,19023);
}


static NewPSTransportOptionCommand()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1598,14028,19023);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1598,14028,19023);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1598,14028,19023);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1598,14028,19023);

Microsoft.PowerShell.Commands.WSManConfigurationOption
f_1598_14356_14386()
{
var return_v = new Microsoft.PowerShell.Commands.WSManConfigurationOption();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1598, 14356, 14386);
return return_v;
}

}
}
