// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Management.Automation;
using System.Reflection;
using System.Resources;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class DisplayResourceManagerCache
    {
        internal enum LoadingResult { NoError, AssemblyNotFound, ResourceNotFound, StringNotFound }

        internal enum AssemblyBindingStatus { NotFound, FoundInGac, FoundInPath };

        internal string GetTextTokenString(TextToken tt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 551, 864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 624, 822) || true) && (tt.resource != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 624, 822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 681, 728);

                    string
                    resString = f_1125_700_727(this, tt.resource)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 746, 807) || true) && (resString != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 746, 807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 790, 807);

                        return resString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 746, 807);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 624, 822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 838, 853);

                return tt.text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 551, 864);

                string
                f_1125_700_727(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resourceReference)
                {
                    var return_v = this_param.GetString(resourceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 700, 727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 551, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 551, 864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void VerifyResource(StringResourceReference resourceReference, out LoadingResult result, out AssemblyBindingStatus bindingStatus)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 876, 1116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1039, 1105);

                f_1125_1039_1104(this, resourceReference, out result, out bindingStatus);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 876, 1116);

                string
                f_1125_1039_1104(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resourceReference, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.LoadingResult
                result, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyBindingStatus
                bindingStatus)
                {
                    var return_v = this_param.GetStringHelper(resourceReference, out result, out bindingStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 1039, 1104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 876, 1116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 876, 1116);
            }
        }

        private string GetString(StringResourceReference resourceReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 1128, 1389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1220, 1241);

                LoadingResult
                result
                = default(LoadingResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1255, 1291);

                AssemblyBindingStatus
                bindingStatus
                = default(AssemblyBindingStatus);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1305, 1378);

                return f_1125_1312_1377(this, resourceReference, out result, out bindingStatus);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 1128, 1389);

                string
                f_1125_1312_1377(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resourceReference, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.LoadingResult
                result, out Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyBindingStatus
                bindingStatus)
                {
                    var return_v = this_param.GetStringHelper(resourceReference, out result, out bindingStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 1312, 1377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 1128, 1389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 1128, 1389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetStringHelper(StringResourceReference resourceReference, out LoadingResult result, out AssemblyBindingStatus bindingStatus)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 1401, 4359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1566, 1606);

                result = LoadingResult.AssemblyNotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1620, 1667);

                bindingStatus = AssemblyBindingStatus.NotFound;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1683, 1720);

                AssemblyLoadResult
                loadResult = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1813, 2850) || true) && (f_1125_1817_1878(_resourceReferenceToAssemblyCache, resourceReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 1813, 2850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 1912, 2000);

                    loadResult = f_1125_1925_1977(_resourceReferenceToAssemblyCache, resourceReference) as AssemblyLoadResult;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2018, 2052);

                    bindingStatus = loadResult.status;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 1813, 2850);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 1813, 2850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2118, 2156);

                    loadResult = f_1125_2131_2155();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2240, 2256);

                    bool
                    foundInGac
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2274, 2358);

                    loadResult.a = f_1125_2289_2357(this, resourceReference, out foundInGac);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2376, 2696) || true) && (loadResult.a == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 2376, 2696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2442, 2493);

                        loadResult.status = AssemblyBindingStatus.NotFound;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 2376, 2696);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 2376, 2696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2575, 2677);

                        loadResult.status = (DynAbs.Tracing.TraceSender.Conditional_F1(1125, 2595, 2605) || ((foundInGac && DynAbs.Tracing.TraceSender.Conditional_F2(1125, 2608, 2640)) || DynAbs.Tracing.TraceSender.Conditional_F3(1125, 2643, 2676))) ? AssemblyBindingStatus.FoundInGac : AssemblyBindingStatus.FoundInPath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 2376, 2696);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2766, 2835);

                    f_1125_2766_2834(
                                    // add to the cache even if null
                                    _resourceReferenceToAssemblyCache, resourceReference, loadResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 1813, 2850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2866, 2900);

                bindingStatus = loadResult.status;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 2916, 3235) || true) && (loadResult.a == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 2916, 3235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3025, 3065);

                    result = LoadingResult.AssemblyNotFound;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3083, 3095);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 2916, 3235);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 2916, 3235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3161, 3220);

                    resourceReference.assemblyLocation = f_1125_3198_3219(loadResult.a);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 2916, 3235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3235, 3236);
                ;

                // load now the resource from the resource manager cache
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3358, 3482);

                    string
                    val = f_1125_3371_3481(loadResult.a, resourceReference.baseName, resourceReference.resourceId)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3500, 3794) || true) && (val == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 3500, 3794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3557, 3595);

                        result = LoadingResult.StringNotFound;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3617, 3629);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 3500, 3794);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 3500, 3794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3711, 3742);

                        result = LoadingResult.NoError;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3764, 3775);

                        return val;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 3500, 3794);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1125, 3823, 3944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 3889, 3929);

                    result = LoadingResult.ResourceNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1125, 3823, 3944);
                }
                catch (MissingManifestResourceException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1125, 3958, 4086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 4031, 4071);

                    result = LoadingResult.ResourceNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1125, 3958, 4086);
                }
                catch (Exception e) // will rethrow
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1125, 4100, 4320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 4168, 4281);

                    f_1125_4168_4280(false, "ResourceManagerCache.GetResourceString unexpected exception " + f_1125_4259_4279(f_1125_4259_4270(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 4299, 4305);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1125, 4100, 4320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 4336, 4348);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 1401, 4359);

                bool
                f_1125_1817_1878(System.Collections.Hashtable
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 1817, 1878);
                    return return_v;
                }


                object
                f_1125_1925_1977(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 1925, 1977);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyLoadResult
                f_1125_2131_2155()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyLoadResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 2131, 2155);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1125_2289_2357(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                resourceReference, out bool
                foundInGac)
                {
                    var return_v = this_param.LoadAssemblyFromResourceReference(resourceReference, out foundInGac);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 2289, 2357);
                    return return_v;
                }


                int
                f_1125_2766_2834(System.Collections.Hashtable
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringResourceReference
                key, Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyLoadResult
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 2766, 2834);
                    return 0;
                }


                string
                f_1125_3198_3219(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 3198, 3219);
                    return return_v;
                }


                string
                f_1125_3371_3481(System.Reflection.Assembly
                assembly, string
                baseName, string
                resourceId)
                {
                    var return_v = ResourceManagerCache.GetResourceString(assembly, baseName, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 3371, 3481);
                    return return_v;
                }


                System.Type
                f_1125_4259_4270(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 4259, 4270);
                    return return_v;
                }


                string
                f_1125_4259_4279(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 4259, 4279);
                    return return_v;
                }


                int
                f_1125_4168_4280(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 4168, 4280);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 1401, 4359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 1401, 4359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly LoadAssemblyFromResourceReference(StringResourceReference resourceReference, out bool foundInGac)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 4848, 5424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 5234, 5253);

                foundInGac = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 5332, 5413);

                return f_1125_5339_5412(_assemblyNameResolver, resourceReference.assemblyName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 4848, 5424);

                System.Reflection.Assembly
                f_1125_5339_5412(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyNameResolver
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.ResolveAssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 5339, 5412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 4848, 5424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 4848, 5424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class AssemblyLoadResult
        {
            internal Assembly a;

            internal AssemblyBindingStatus status;

            public AssemblyLoadResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1125, 5436, 5583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 5518, 5519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 5565, 5571);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1125, 5436, 5583);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 5436, 5583);
            }


            static AssemblyLoadResult()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1125, 5436, 5583);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1125, 5436, 5583);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 5436, 5583);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1125, 5436, 5583);
        }
        private class AssemblyNameResolver
        {
            internal Assembly ResolveAssemblyName(string assemblyName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 6072, 7215);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 6163, 6274) || true) && (f_1125_6167_6201(assemblyName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 6163, 6274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 6243, 6255);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 6163, 6274);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 6338, 6496) || true) && (f_1125_6342_6384(_assemblyReferences, assemblyName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 6338, 6496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 6426, 6477);

                        return (Assembly)f_1125_6443_6476(_assemblyReferences, assemblyName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 6338, 6496);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 6625, 6798);

                    Assembly
                    retVal = f_1125_6643_6700(this, assemblyName, true) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.Assembly>(1125, 6643, 6797) ?? f_1125_6739_6797(this, assemblyName, false))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 7000, 7102);

                    f_1125_7000_7101(retVal != null, "AssemblyName resolution failed, a resource file might be broken");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 7122, 7168);

                    f_1125_7122_7167(
                                    _assemblyReferences, assemblyName, retVal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 7186, 7200);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 6072, 7215);

                    bool
                    f_1125_6167_6201(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 6167, 6201);
                        return return_v;
                    }


                    bool
                    f_1125_6342_6384(System.Collections.Hashtable
                    this_param, string
                    key)
                    {
                        var return_v = this_param.Contains((object)key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 6342, 6384);
                        return return_v;
                    }


                    object
                    f_1125_6443_6476(System.Collections.Hashtable
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 6443, 6476);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_1125_6643_6700(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyNameResolver
                    this_param, string
                    assemblyName, bool
                    fullName)
                    {
                        var return_v = this_param.ResolveAssemblyNameInLoadedAssemblies(assemblyName, fullName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 6643, 6700);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_1125_6739_6797(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyNameResolver
                    this_param, string
                    assemblyName, bool
                    fullName)
                    {
                        var return_v = this_param.ResolveAssemblyNameInLoadedAssemblies(assemblyName, fullName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 6739, 6797);
                        return return_v;
                    }


                    int
                    f_1125_7000_7101(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 7000, 7101);
                        return 0;
                    }


                    int
                    f_1125_7122_7167(System.Collections.Hashtable
                    this_param, string
                    key, System.Reflection.Assembly
                    value)
                    {
                        this_param.Add((object)key, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 7122, 7167);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 6072, 7215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 6072, 7215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Assembly ResolveAssemblyNameInLoadedAssemblies(string assemblyName, bool fullName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1125, 7231, 8658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 7354, 7377);

                    Assembly
                    result = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 7943, 8603);
                        foreach (Assembly a in f_1125_7966_7991_I(f_1125_7966_7991()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 7943, 8603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8033, 8059);

                            AssemblyName
                            aName = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8133, 8153);

                                aName = f_1125_8141_8152(a);
                            }
                            catch (System.Security.SecurityException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1125, 8198, 8320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8288, 8297);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1125, 8198, 8320);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8344, 8406);

                            string
                            nameToCompare = (DynAbs.Tracing.TraceSender.Conditional_F1(1125, 8367, 8375) || ((fullName && DynAbs.Tracing.TraceSender.Conditional_F2(1125, 8378, 8392)) || DynAbs.Tracing.TraceSender.Conditional_F3(1125, 8395, 8405))) ? f_1125_8378_8392(aName) : f_1125_8395_8405(aName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8430, 8584) || true) && (f_1125_8434_8502(nameToCompare, assemblyName, StringComparison.Ordinal))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1125, 8430, 8584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8552, 8561);

                                return a;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 8430, 8584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1125, 7943, 8603);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1125, 1, 661);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1125, 1, 661);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8629, 8643);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1125, 7231, 8658);

                    System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                    f_1125_7966_7991()
                    {
                        var return_v = ClrFacade.GetAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 7966, 7991);
                        return return_v;
                    }


                    System.Reflection.AssemblyName
                    f_1125_8141_8152(System.Reflection.Assembly
                    this_param)
                    {
                        var return_v = this_param.GetName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 8141, 8152);
                        return return_v;
                    }


                    string
                    f_1125_8378_8392(System.Reflection.AssemblyName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 8378, 8392);
                        return return_v;
                    }


                    string
                    f_1125_8395_8405(System.Reflection.AssemblyName
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 8395, 8405);
                        return return_v;
                    }


                    bool
                    f_1125_8434_8502(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 8434, 8502);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                    f_1125_7966_7991_I(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 7966, 7991);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1125, 7231, 8658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 7231, 8658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Hashtable _assemblyReferences;

            public AssemblyNameResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1125, 5787, 8773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8692, 8761);
                this._assemblyReferences = f_1125_8714_8761(f_1125_8728_8760());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1125, 5787, 8773);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 5787, 8773);
            }


            static AssemblyNameResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1125, 5787, 8773);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1125, 5787, 8773);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 5787, 8773);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1125, 5787, 8773);

            System.StringComparer
            f_1125_8728_8760()
            {
                var return_v = StringComparer.OrdinalIgnoreCase;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1125, 8728, 8760);
                return return_v;
            }


            System.Collections.Hashtable
            f_1125_8714_8761(System.StringComparer
            equalityComparer)
            {
                var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 8714, 8761);
                return return_v;
            }

        }

        private AssemblyNameResolver _assemblyNameResolver;

        private Hashtable _resourceReferenceToAssemblyCache;

        public DisplayResourceManagerCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1125, 296, 8952);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8814, 8864);
            this._assemblyNameResolver = f_1125_8838_8864();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1125, 8893, 8944);
            this._resourceReferenceToAssemblyCache = f_1125_8929_8944();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1125, 296, 8952);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 296, 8952);
        }


        static DisplayResourceManagerCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1125, 296, 8952);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1125, 296, 8952);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1125, 296, 8952);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1125, 296, 8952);

        Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyNameResolver
        f_1125_8838_8864()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache.AssemblyNameResolver();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 8838, 8864);
            return return_v;
        }


        System.Collections.Hashtable
        f_1125_8929_8944()
        {
            var return_v = new System.Collections.Hashtable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1125, 8929, 8944);
            return return_v;
        }

    }
}

