// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Provider
{
public abstract class ContainerCmdletProvider : ItemCmdletProvider
{
internal void GetChildItems(
            string path,
            bool recurse,
            uint depth,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,2378,2672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,2553,2571);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,2625,2661);

f_1188_2625_2660(this, path, recurse, depth);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,2378,2672);

int
f_1188_2625_2660(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse,uint
depth)
{
this_param.GetChildItems( path, recurse, depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 2625, 2660);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,2378,2672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,2378,2672);
}
		}

internal object GetChildItemsDynamicParameters(
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,3853,4118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,4022,4040);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,4054,4107);

return f_1188_4061_4106(this, path, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,3853,4118);

object
f_1188_4061_4106(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse)
{
var return_v = this_param.GetChildItemsDynamicParameters( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 4061, 4106);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,3853,4118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,3853,4118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetChildNames(
            string path,
            ReturnContainers returnContainers,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,5420,5710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,5591,5609);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,5661,5699);

f_1188_5661_5698(this, path, returnContainers);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,5420,5710);

int
f_1188_5661_5698(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,System.Management.Automation.ReturnContainers
returnContainers)
{
this_param.GetChildNames( path, returnContainers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 5661, 5698);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,5420,5710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,5420,5710);
}
		}

[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#")]
        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#")]
        internal virtual bool ConvertPath(
            string path,
            string filter,
            ref string updatedPath,
            ref string updatedFilter,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,7560,8145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,7995,8013);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,8065,8134);

return f_1188_8072_8133(this, path, filter, ref updatedPath, ref updatedFilter);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,7560,8145);

bool
f_1188_8072_8133(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
filter,ref string
updatedPath,ref string
updatedFilter)
{
var return_v = this_param.ConvertPath( path, filter, ref updatedPath, ref updatedFilter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 8072, 8133);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,7560,8145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,7560,8145);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal object GetChildNamesDynamicParameters(
            string path,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,9035,9264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,9177,9195);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,9209,9253);

return f_1188_9216_9252(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,9035,9264);

object
f_1188_9216_9252(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path)
{
var return_v = this_param.GetChildNamesDynamicParameters( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 9216, 9252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,9035,9264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,9035,9264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RenameItem(
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,10133,10391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,10282,10300);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,10354,10380);

f_1188_10354_10379(this, path, newName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,10133,10391);

int
f_1188_10354_10379(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
newName)
{
this_param.RenameItem( path, newName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 10354, 10379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,10133,10391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,10133,10391);
}
		}

internal object RenameItemDynamicParameters(
            string path,
            string newName,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,11236,11497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,11404,11422);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,11436,11486);

return f_1188_11443_11485(this, path, newName);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,11236,11497);

object
f_1188_11443_11485(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
newName)
{
var return_v = this_param.RenameItemDynamicParameters( path, newName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 11443, 11485);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,11236,11497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,11236,11497);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void NewItem(
            string path,
            string type,
            object newItemValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,12488,12782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,12665,12683);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,12737,12771);

f_1188_12737_12770(this, path, type, newItemValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,12488,12782);

int
f_1188_12737_12770(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
itemTypeName,object
newItemValue)
{
this_param.NewItem( path, itemTypeName, newItemValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 12737, 12770);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,12488,12782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,12488,12782);
}
		}

internal object NewItemDynamicParameters(
            string path,
            string type,
            object newItemValue,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,13757,14054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,13953,13971);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,13985,14043);

return f_1188_13992_14042(this, path, type, newItemValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,13757,14054);

object
f_1188_13992_14042(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
itemTypeName,object
newItemValue)
{
var return_v = this_param.NewItemDynamicParameters( path, itemTypeName, newItemValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 13992, 14042);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,13757,14054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,13757,14054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void RemoveItem(
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,14855,15111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,15002,15020);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,15074,15100);

f_1188_15074_15099(this, path, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,14855,15111);

int
f_1188_15074_15099(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse)
{
this_param.RemoveItem( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 15074, 15099);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,14855,15111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,14855,15111);
}
		}

internal object RemoveItemDynamicParameters(
            string path,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,16064,16323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,16230,16248);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,16262,16312);

return f_1188_16269_16311(this, path, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,16064,16323);

object
f_1188_16269_16311(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse)
{
var return_v = this_param.RemoveItemDynamicParameters( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 16269, 16311);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,16064,16323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,16064,16323);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool HasChildItems(string path, CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,17258,17464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,17354,17372);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,17426,17453);

return f_1188_17433_17452(this, path);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,17258,17464);

bool
f_1188_17433_17452(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path)
{
var return_v = this_param.HasChildItems( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 17433, 17452);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,17258,17464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,17258,17464);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void CopyItem(
            string path,
            string copyPath,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,18371,18663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,18546,18564);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,18618,18652);

f_1188_18618_18651(this, path, copyPath, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,18371,18663);

int
f_1188_18618_18651(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
copyPath,bool
recurse)
{
this_param.CopyItem( path, copyPath, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 18618, 18651);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,18371,18663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,18371,18663);
}
		}

internal object CopyItemDynamicParameters(
            string path,
            string destination,
            bool recurse,
            CmdletProviderContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,19553,19854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,19750,19768);

Context = context;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,19782,19843);

return f_1188_19789_19842(this, path, destination, recurse);
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,19553,19854);

object
f_1188_19789_19842(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,string
destination,bool
recurse)
{
var return_v = this_param.CopyItemDynamicParameters( path, destination, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 19789, 19842);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,19553,19854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,19553,19854);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void GetChildItems(
            string path,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,21887,22257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,22002,22246);
using(f_1188_22009_22056())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,22090,22231);

throw
f_1188_22117_22230(f_1188_22182_22229());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,22002,22246);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,21887,22257);

System.IDisposable
f_1188_22009_22056()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 22009, 22056);
return return_v;
}


string
f_1188_22182_22229()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 22182, 22229);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_22117_22230(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 22117, 22230);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,21887,22257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,21887,22257);
}
		}

protected virtual void GetChildItems(
            string path,
            bool recurse,
            uint depth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,24353,24973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,24493,24962);
using(f_1188_24500_24547())            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,24581,24947) || true) && (depth == uint.MaxValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1188,24581,24947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,24649,24683);

f_1188_24649_24682(                    this, path, recurse);
DynAbs.Tracing.TraceSender.TraceExitCondition(1188,24581,24947);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1188,24581,24947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,24765,24928);

throw
f_1188_24796_24927(f_1188_24865_24926());
DynAbs.Tracing.TraceSender.TraceExitCondition(1188,24581,24947);
}
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,24493,24962);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,24353,24973);

System.IDisposable
f_1188_24500_24547()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 24500, 24547);
return return_v;
}


int
f_1188_24649_24682(System.Management.Automation.Provider.ContainerCmdletProvider
this_param,string
path,bool
recurse)
{
this_param.GetChildItems( path, recurse);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 24649, 24682);
return 0;
}


string
f_1188_24865_24926()
{
var return_v =                             SessionStateStrings.CmdletProvider_NotSupportedRecursionDepth;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 24865, 24926);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_24796_24927(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 24796, 24927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,24353,24973);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,24353,24973);
}
		}

protected virtual object GetChildItemsDynamicParameters(string path, bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,26045,26278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,26152,26267);
using(f_1188_26159_26206())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,26240,26252);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,26152,26267);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,26045,26278);

System.IDisposable
f_1188_26159_26206()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 26159, 26206);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,26045,26278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,26045,26278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void GetChildNames(
            string path,
            ReturnContainers returnContainers)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,28334,28725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,28470,28714);
using(f_1188_28477_28524())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,28558,28699);

throw
f_1188_28585_28698(f_1188_28650_28697());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,28470,28714);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,28334,28725);

System.IDisposable
f_1188_28477_28524()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 28477, 28524);
return return_v;
}


string
f_1188_28650_28697()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 28650, 28697);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_28585_28698(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 28585, 28698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,28334,28725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,28334,28725);
}
		}

[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#")]
        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "3#")]
        protected virtual bool ConvertPath(
            string path,
            string filter,
            ref string updatedPath,
            ref string updatedFilter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,30594,31113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,30986,31102);
using(f_1188_30993_31040())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,31074,31087);

return false;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,30986,31102);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,30594,31113);

System.IDisposable
f_1188_30993_31040()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 30993, 31040);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,30594,31113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,30594,31113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual object GetChildNamesDynamicParameters(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,31894,32113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,31987,32102);
using(f_1188_31994_32041())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,32075,32087);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,31987,32102);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,31894,32113);

System.IDisposable
f_1188_31994_32041()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 31994, 32041);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,31894,32113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,31894,32113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void RenameItem(
            string path,
            string newName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,34025,34394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,34139,34383);
using(f_1188_34146_34193())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,34227,34368);

throw
f_1188_34254_34367(f_1188_34319_34366());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,34139,34383);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,34025,34394);

System.IDisposable
f_1188_34146_34193()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 34146, 34193);
return return_v;
}


string
f_1188_34319_34366()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 34319, 34366);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_34254_34367(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 34254, 34367);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,34025,34394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,34025,34394);
}
		}

protected virtual object RenameItemDynamicParameters(string path, string newName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,35358,35590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,35464,35579);
using(f_1188_35471_35518())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,35552,35564);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,35464,35579);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,35358,35590);

System.IDisposable
f_1188_35471_35518()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 35471, 35518);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,35358,35590);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,35358,35590);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void NewItem(
            string path,
            string itemTypeName,
            object newItemValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,37903,38308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,38053,38297);
using(f_1188_38060_38107())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,38141,38282);

throw
f_1188_38168_38281(f_1188_38233_38280());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,38053,38297);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,37903,38308);

System.IDisposable
f_1188_38060_38107()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 38060, 38107);
return return_v;
}


string
f_1188_38233_38280()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 38233, 38280);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_38168_38281(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 38168, 38281);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,37903,38308);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,37903,38308);
}
		}

protected virtual object NewItemDynamicParameters(
            string path,
            string itemTypeName,
            object newItemValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,39410,39705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,39579,39694);
using(f_1188_39586_39633())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,39667,39679);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,39579,39694);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,39410,39705);

System.IDisposable
f_1188_39586_39633()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 39586, 39633);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,39410,39705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,39410,39705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void RemoveItem(
            string path,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,41565,41932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,41677,41921);
using(f_1188_41684_41731())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,41765,41906);

throw
f_1188_41792_41905(f_1188_41857_41904());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,41677,41921);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,41565,41932);

System.IDisposable
f_1188_41684_41731()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 41684, 41731);
return return_v;
}


string
f_1188_41857_41904()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 41857, 41904);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_41792_41905(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 41792, 41905);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,41565,41932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,41565,41932);
}
		}

protected virtual object RemoveItemDynamicParameters(
            string path,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,43004,43261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,43135,43250);
using(f_1188_43142_43189())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,43223,43235);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,43135,43250);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,43004,43261);

System.IDisposable
f_1188_43142_43189()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 43142, 43189);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,43004,43261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,43004,43261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual bool HasChildItems(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,44448,44777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,44522,44766);
using(f_1188_44529_44576())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,44610,44751);

throw
f_1188_44637_44750(f_1188_44702_44749());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,44522,44766);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,44448,44777);

System.IDisposable
f_1188_44529_44576()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 44529, 44576);
return return_v;
}


string
f_1188_44702_44749()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 44702, 44749);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_44637_44750(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 44637, 44750);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,44448,44777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,44448,44777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void CopyItem(
            string path,
            string copyPath,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,46940,47335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,47080,47324);
using(f_1188_47087_47134())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,47168,47309);

throw
f_1188_47195_47308(f_1188_47260_47307());
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,47080,47324);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,46940,47335);

System.IDisposable
f_1188_47087_47134()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 47087, 47134);
return return_v;
}


string
f_1188_47260_47307()
{
var return_v =                         SessionStateStrings.CmdletProvider_NotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1188, 47260, 47307);
return return_v;
}


System.Management.Automation.PSNotSupportedException
f_1188_47195_47308(string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewNotSupportedException( resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 47195, 47308);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,46940,47335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,46940,47335);
}
		}

protected virtual object CopyItemDynamicParameters(
            string path,
            string destination,
            bool recurse)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1188,48344,48632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,48506,48621);
using(f_1188_48513_48560())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1188,48594,48606);

return null;
DynAbs.Tracing.TraceSender.TraceExitUsing(1188,48506,48621);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(1188,48344,48632);

System.IDisposable
f_1188_48513_48560()
{
var return_v = PSTransactionManager.GetEngineProtectionScope();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1188, 48513, 48560);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1188,48344,48632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,48344,48632);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ContainerCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1188,1096,48679);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1188,1096,48679);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,1096,48679);
}


static ContainerCmdletProvider()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1188,1096,48679);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1188,1096,48679);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1188,1096,48679);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1188,1096,48679);
}

    }

