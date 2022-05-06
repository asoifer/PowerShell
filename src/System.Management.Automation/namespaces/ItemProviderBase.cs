// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;

namespace System.Management.Automation.Provider
{
public abstract class ItemCmdletProvider : DriveCmdletProvider
{
internal void GetItem(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,1660,1847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,1750,1768);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,1822,1836);

f_1202_1822_1835(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,1660,1847);

int
f_1202_1822_1835(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
this_param.GetItem( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 1822, 1835);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,1660,1847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,1660,1847);
}
		}

internal object GetItemDynamicParameters(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,2726,2916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,2835,2853);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,2867,2905);

return f_1202_2874_2904(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,2726,2916);

object
f_1202_2874_2904(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetItemDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 2874, 2904);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,2726,2916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,2726,2916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void SetItem(
            string path,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,3635,3958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,3779,3838);

f_1202_3779_3837(            providerBaseTracer, "ItemCmdletProvider.SetItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,3854,3872);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,3926,3947);

f_1202_3926_3946(this, path, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,3635,3958);

int
f_1202_3779_3837(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 3779, 3837);
return 0;
}


int
f_1202_3926_3946(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,object
value)
{
this_param.SetItem( path, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 3926, 3946);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,3635,3958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,3635,3958);
}
		}

internal object SetItemDynamicParameters(
            string path,
            object value,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,4951,5202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,5114,5132);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,5146,5191);

return f_1202_5153_5190(this, path, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,4951,5202);

object
f_1202_5153_5190(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path,object
value)
{
var return_v = this_param.SetItemDynamicParameters( path, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 5153, 5190);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,4951,5202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,4951,5202);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void ClearItem(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,5706,6001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,5825,5886);

f_1202_5825_5885(            providerBaseTracer, "ItemCmdletProvider.ClearItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,5902,5920);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,5974,5990);

f_1202_5974_5989(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,5706,6001);

int
f_1202_5825_5885(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 5825, 5885);
return 0;
}


int
f_1202_5974_5989(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
this_param.ClearItem( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 5974, 5989);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,5706,6001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,5706,6001);
}
		}

internal object ClearItemDynamicParameters(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,6882,7103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,7020,7038);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,7052,7092);

return f_1202_7059_7091(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,6882,7103);

object
f_1202_7059_7091(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.ClearItemDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 7059, 7091);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,6882,7103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,6882,7103);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void InvokeDefaultAction(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,7641,7966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,7770,7841);

f_1202_7770_7840(            providerBaseTracer, "ItemCmdletProvider.InvokeDefaultAction");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,7857,7875);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,7929,7955);

f_1202_7929_7954(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,7641,7966);

int
f_1202_7770_7840(System.Management.Automation.PSTraceSource
this_param,string
format)
{
this_param.WriteLine( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 7770, 7840);
return 0;
}


int
f_1202_7929_7954(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
this_param.InvokeDefaultAction( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 7929, 7954);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,7641,7966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,7641,7966);
}
		}

internal object InvokeDefaultActionDynamicParameters(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,8848,9089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,8996,9014);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,9028,9078);

return f_1202_9035_9077(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,8848,9089);

object
f_1202_9035_9077(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.InvokeDefaultActionDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 9035, 9077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,8848,9089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,8848,9089);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool ItemExists(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,9703,10223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,9796,9814);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,9868,9892);

bool 
itemExists = false
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,10072,10102);

itemExists = f_1202_10085_10101(this, path);
            }
            catch (Exception)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1202,10131,10178);
DynAbs.Tracing.TraceSender.TraceExitCatch(1202,10131,10178);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,10194,10212);

return itemExists;
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,9703,10223);

bool
f_1202_10085_10101(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.ItemExists( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 10085, 10101);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,9703,10223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,9703,10223);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object ItemExistsDynamicParameters(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,11103,11326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,11242,11260);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,11274,11315);

return f_1202_11281_11314(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,11103,11326);

object
f_1202_11281_11314(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.ItemExistsDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 11281, 11314);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,11103,11326);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,11103,11326);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsValidPath(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,12394,12596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,12488,12506);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,12560,12585);

return f_1202_12567_12584(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,12394,12596);

bool
f_1202_12567_12584(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.IsValidPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 12567, 12584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,12394,12596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,12394,12596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal string[] ExpandPath(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,13415,13617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,13512,13530);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,13582,13606);

return f_1202_13589_13605(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,13415,13617);

string[]
f_1202_13589_13605(System.Management.Automation.Provider.ItemCmdletProvider
this_param,string
path)
{
var return_v = this_param.ExpandPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 13589, 13605);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,13415,13617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,13415,13617);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void GetItem(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,15043,15366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,15111,15355);
using(f_1202_15118_15165())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,15199,15340);

throw
f_1202_15226_15339(f_1202_15291_15338());
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,15111,15355);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,15043,15366);

System.IDisposable
f_1202_15118_15165()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 15118, 15165);
return return_v;
}


string
f_1202_15291_15338()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1202, 15291, 15338);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1202_15226_15339(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 15226, 15339);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,15043,15366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,15043,15366);
}
		}

protected virtual object GetItemDynamicParameters(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,16136,16349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,16223,16338);
using(f_1202_16230_16277())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,16311,16323);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,16223,16338);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,16136,16349);

System.IDisposable
f_1202_16230_16277()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 16230, 16277);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,16136,16349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,16136,16349);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void SetItem(
            string path,
            object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,17795,18159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,17904,18148);
using(f_1202_17911_17958())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,17992,18133);

throw
f_1202_18019_18132(f_1202_18084_18131());
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,17904,18148);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,17795,18159);

System.IDisposable
f_1202_17911_17958()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 17911, 17958);
return return_v;
}


string
f_1202_18084_18131()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1202, 18084, 18131);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1202_18019_18132(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 18019, 18132);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,17795,18159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,17795,18159);
}
		}

protected virtual object SetItemDynamicParameters(string path, object value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,19043,19270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,19144,19259);
using(f_1202_19151_19198())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,19232,19244);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,19144,19259);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,19043,19270);

System.IDisposable
f_1202_19151_19198()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 19151, 19198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,19043,19270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,19043,19270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void ClearItem(
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,20613,20952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,20697,20941);
using(f_1202_20704_20751())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,20785,20926);

throw
f_1202_20812_20925(f_1202_20877_20924());
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,20697,20941);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,20613,20952);

System.IDisposable
f_1202_20704_20751()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 20704, 20751);
return return_v;
}


string
f_1202_20877_20924()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1202, 20877, 20924);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1202_20812_20925(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 20812, 20925);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,20613,20952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,20613,20952);
}
		}

protected virtual object ClearItemDynamicParameters(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,21724,21939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,21813,21928);
using(f_1202_21820_21867())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,21901,21913);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,21813,21928);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,21724,21939);

System.IDisposable
f_1202_21820_21867()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 21820, 21867);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,21724,21939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,21724,21939);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void InvokeDefaultAction(
            string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,23378,23727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,23472,23716);
using(f_1202_23479_23526())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,23560,23701);

throw
f_1202_23587_23700(f_1202_23652_23699());
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,23472,23716);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,23378,23727);

System.IDisposable
f_1202_23479_23526()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 23479, 23526);
return return_v;
}


string
f_1202_23652_23699()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1202, 23652, 23699);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1202_23587_23700(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 23587, 23700);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,23378,23727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,23378,23727);
}
		}

protected virtual object InvokeDefaultActionDynamicParameters(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,24500,24725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,24599,24714);
using(f_1202_24606_24653())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,24687,24699);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,24599,24714);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,24500,24725);

System.IDisposable
f_1202_24606_24653()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 24606, 24653);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,24500,24725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,24500,24725);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual bool ItemExists(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,26309,26635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,26380,26624);
using(f_1202_26387_26434())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,26468,26609);

throw
f_1202_26495_26608(f_1202_26560_26607());
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,26380,26624);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,26309,26635);

System.IDisposable
f_1202_26387_26434()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 26387, 26434);
return return_v;
}


string
f_1202_26560_26607()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1202, 26560, 26607);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1202_26495_26608(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 26495, 26608);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,26309,26635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,26309,26635);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual object ItemExistsDynamicParameters(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,27406,27622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,27496,27611);
using(f_1202_27503_27550())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,27584,27596);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,27496,27611);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,27406,27622);

System.IDisposable
f_1202_27503_27550()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 27503, 27550);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,27406,27622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,27406,27622);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract bool IsValidPath(string path);

protected virtual string[] ExpandPath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1202,29102,29320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,29177,29309);
using(f_1202_29184_29231())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1202,29265,29294);

return new string[] { path };
DynAbs.Tracing.TraceSender.TraceExitUsing(1202,29177,29309);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1202,29102,29320);

System.IDisposable
f_1202_29184_29231()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1202, 29184, 29231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1202,29102,29320);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,29102,29320);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ItemCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1202,910,29367);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1202,910,29367);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,910,29367);
}


static ItemCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1202,910,29367);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1202,910,29367);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1202,910,29367);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1202,910,29367);
}

    }

