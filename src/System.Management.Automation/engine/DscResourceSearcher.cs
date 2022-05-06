// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class DscResourceSearcher : IEnumerable<DscResourceInfo>, IEnumerator<DscResourceInfo>
    {
        internal DscResourceSearcher(
                    string resourceName,
                    ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1267, 522, 925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 990, 1010);
                this._resourceName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1046, 1061);
                this._context = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1096, 1116);
                this._currentMatch = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1164, 1188);
                this._matchingResource = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1235, 1263);
                this._matchingResourceList = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 649, 725);

                f_1267_649_724(context != null, "caller to verify context is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 739, 836);

                f_1267_739_835(!f_1267_759_793(resourceName), "caller to verify commandName is valid");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 852, 881);

                _resourceName = resourceName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 895, 914);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1267, 522, 925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 522, 925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 522, 925);
            }
        }

        private string _resourceName;

        private ExecutionContext _context;

        private DscResourceInfo _currentMatch;

        private IEnumerator<DscResourceInfo> _matchingResource;

        private Collection<DscResourceInfo> _matchingResourceList;

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 1412, 1527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1456, 1477);

                _currentMatch = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1491, 1516);

                _matchingResource = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 1412, 1527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 1412, 1527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 1412, 1527);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 1631, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1677, 1685);

                f_1267_1677_1684(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1699, 1725);

                f_1267_1699_1724(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 1631, 1736);

                int
                f_1267_1677_1684(System.Management.Automation.DscResourceSearcher
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 1677, 1684);
                    return 0;
                }


                int
                f_1267_1699_1724(System.Management.Automation.DscResourceSearcher
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 1699, 1724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 1631, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 1631, 1736);
            }
        }

        IEnumerator<DscResourceInfo> IEnumerable<DscResourceInfo>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 1861, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 1959, 1971);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 1861, 1982);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 1861, 1982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 1861, 1982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 2107, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2171, 2183);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 2107, 2194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 2107, 2194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 2107, 2194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 2341, 2537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2388, 2425);

                _currentMatch = f_1267_2404_2424(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2441, 2497) || true) && (_currentMatch != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 2441, 2497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2485, 2497);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 2441, 2497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2513, 2526);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 2341, 2537);

                System.Management.Automation.DscResourceInfo
                f_1267_2404_2424(System.Management.Automation.DscResourceSearcher
                this_param)
                {
                    var return_v = this_param.GetNextDscResource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 2404, 2424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 2341, 2537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 2341, 2537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        DscResourceInfo IEnumerator<DscResourceInfo>.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 2718, 2790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 2754, 2775);

                    return _currentMatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 2718, 2790);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 2641, 2801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 2641, 2801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 2966, 3069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3002, 3054);

                    return f_1267_3009_3053(((IEnumerator<DscResourceInfo>)this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 2966, 3069);

                    System.Management.Automation.DscResourceInfo
                    f_1267_3009_3053(System.Collections.Generic.IEnumerator<System.Management.Automation.DscResourceInfo>
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 3009, 3053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 2915, 3080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 2915, 3080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private DscResourceInfo GetNextDscResource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1267, 3474, 7159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3543, 3630);

                var
                ps = f_1267_3552_3629(f_1267_3552_3599(RunspaceMode.CurrentRunspace), "Get-DscResource")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3646, 3743);

                WildcardPattern
                resourceMatcher = f_1267_3680_3742(_resourceName, WildcardOptions.IgnoreCase)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3759, 6898) || true) && (_matchingResourceList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 3759, 6898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3826, 3868);

                    Collection<PSObject>
                    psObjs = f_1267_3856_3867(ps)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3888, 3946);

                    _matchingResourceList = f_1267_3912_3945();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 3966, 3990);

                    bool
                    matchFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4010, 6712);
                        foreach (dynamic resource in f_1267_4039_4045_I(psObjs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 4010, 6712);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4087, 6693) || true) && (f_1267_4091_4104(resource) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 4087, 6693);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4162, 4198);

                                string
                                resourceName = f_1267_4184_4197(resource)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4226, 6670) || true) && (f_1267_4230_4267(resourceMatcher, resourceName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 4226, 6670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4325, 4860);

                                    DscResourceInfo
                                    resourceInfo = f_1267_4356_4859(resourceName, f_1267_4470_4491(resource), f_1267_4573_4586(resource), f_1267_4668_4687(resource), _context)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4892, 4942);

                                    resourceInfo.FriendlyName = f_1267_4920_4941(resource);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 4974, 5022);

                                    resourceInfo.CompanyName = f_1267_5001_5021(resource);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5054, 5107);

                                    PSModuleInfo
                                    psMod = f_1267_5075_5090(resource) as PSModuleInfo
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5139, 5219) || true) && (psMod != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 5139, 5219);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5191, 5219);

                                        resourceInfo.Module = psMod;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 5139, 5219);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5251, 5602) || true) && (f_1267_5255_5277(resource) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 5251, 5602);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5351, 5377);

                                        ImplementedAsType
                                        impType
                                        = default(ImplementedAsType);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5411, 5571) || true) && (f_1267_5415_5495(f_1267_5448_5481(f_1267_5448_5470(resource)), out impType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 5411, 5571);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5534, 5571);

                                            resourceInfo.ImplementedAs = impType;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 5411, 5571);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 5251, 5602);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5634, 5680);

                                    var
                                    properties = f_1267_5651_5670(resource) as IList
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5712, 6521) || true) && (properties != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 5712, 6521);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5800, 5881);

                                        List<DscResourcePropertyInfo>
                                        propertyList = f_1267_5845_5880()
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 5917, 6410);
                                            foreach (dynamic prop in f_1267_5942_5952_I(properties))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 5917, 6410);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6026, 6091);

                                                DscResourcePropertyInfo
                                                propInfo = f_1267_6061_6090()
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6129, 6155);

                                                propInfo.Name = f_1267_6145_6154(prop);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6193, 6235);

                                                propInfo.PropertyType = f_1267_6217_6234(prop);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6273, 6308);

                                                f_1267_6273_6307(propInfo, f_1267_6295_6306(prop));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6348, 6375);

                                                f_1267_6348_6374(
                                                                                    propertyList, propInfo);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 5917, 6410);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1267, 1, 494);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1267, 1, 494);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6446, 6490);

                                        f_1267_6446_6489(
                                                                        resourceInfo, propertyList);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 5712, 6521);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6553, 6593);

                                    f_1267_6553_6592(
                                                                _matchingResourceList, resourceInfo);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6625, 6643);

                                    matchFound = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 4226, 6670);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 4087, 6693);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 4010, 6712);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1267, 1, 2703);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1267, 1, 2703);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6732, 6883) || true) && (matchFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 6732, 6883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6769, 6827);

                        _matchingResource = f_1267_6789_6826(_matchingResourceList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 6732, 6883);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 6732, 6883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6871, 6883);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 6732, 6883);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 3759, 6898);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6914, 7120) || true) && (!f_1267_6919_6947(_matchingResource))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 6914, 7120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 6981, 7006);

                    _matchingResource = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 6914, 7120);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1267, 6914, 7120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 7072, 7105);

                    return f_1267_7079_7104(_matchingResource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1267, 6914, 7120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1267, 7136, 7148);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1267, 3474, 7159);

                System.Management.Automation.PowerShell
                f_1267_3552_3599(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 3552, 3599);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1267_3552_3629(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 3552, 3629);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1267_3680_3742(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 3680, 3742);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1267_3856_3867(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 3856, 3867);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.DscResourceInfo>
                f_1267_3912_3945()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.DscResourceInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 3912, 3945);
                    return return_v;
                }


                dynamic
                f_1267_4091_4104(dynamic
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4091, 4104);
                    return return_v;
                }


                dynamic
                f_1267_4184_4197(dynamic
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4184, 4197);
                    return return_v;
                }


                bool
                f_1267_4230_4267(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 4230, 4267);
                    return return_v;
                }


                dynamic
                f_1267_4470_4491(dynamic
                this_param)
                {
                    var return_v = this_param.ResourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4470, 4491);
                    return return_v;
                }


                dynamic
                f_1267_4573_4586(dynamic
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4573, 4586);
                    return return_v;
                }


                dynamic
                f_1267_4668_4687(dynamic
                this_param)
                {
                    var return_v = this_param.ParentPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4668, 4687);
                    return return_v;
                }


                System.Management.Automation.DscResourceInfo
                f_1267_4356_4859(string
                i0, dynamic
                i1, dynamic
                i2, dynamic
                i3, System.Management.Automation.ExecutionContext
                i4)
                {
                    var return_v = new System.Management.Automation.DscResourceInfo(i0, i1, i2, i3, i4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 4356, 4859);
                    return return_v;
                }


                dynamic
                f_1267_4920_4941(dynamic
                this_param)
                {
                    var return_v = this_param.FriendlyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 4920, 4941);
                    return return_v;
                }


                dynamic
                f_1267_5001_5021(dynamic
                this_param)
                {
                    var return_v = this_param.CompanyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 5001, 5021);
                    return return_v;
                }


                dynamic
                f_1267_5075_5090(dynamic
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 5075, 5090);
                    return return_v;
                }


                dynamic
                f_1267_5255_5277(dynamic
                this_param)
                {
                    var return_v = this_param.ImplementedAs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 5255, 5277);
                    return return_v;
                }


                dynamic
                f_1267_5448_5470(dynamic
                this_param)
                {
                    var return_v = this_param.ImplementedAs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 5448, 5470);
                    return return_v;
                }


                dynamic
                f_1267_5448_5481(dynamic
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 5448, 5481);
                    return return_v;
                }


                bool
                f_1267_5415_5495(string?
                value, out System.Management.Automation.ImplementedAsType
                result)
                {
                    var return_v = System.Enum.TryParse<System.Management.Automation.ImplementedAsType>(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 5415, 5495);
                    return return_v;
                }


                dynamic
                f_1267_5651_5670(dynamic
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 5651, 5670);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>
                f_1267_5845_5880()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 5845, 5880);
                    return return_v;
                }


                System.Management.Automation.DscResourcePropertyInfo
                f_1267_6061_6090()
                {
                    var return_v = new System.Management.Automation.DscResourcePropertyInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6061, 6090);
                    return return_v;
                }


                dynamic
                f_1267_6145_6154(dynamic
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 6145, 6154);
                    return return_v;
                }


                dynamic
                f_1267_6217_6234(dynamic
                this_param)
                {
                    var return_v = this_param.PropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 6217, 6234);
                    return return_v;
                }


                dynamic
                f_1267_6295_6306(dynamic
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 6295, 6306);
                    return return_v;
                }


                int
                f_1267_6273_6307(System.Management.Automation.DscResourcePropertyInfo
                this_param, System.Collections.Generic.IList<string>
                values)
                {
                    this_param.UpdateValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6273, 6307);
                    return 0;
                }


                int
                f_1267_6348_6374(System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>
                this_param, System.Management.Automation.DscResourcePropertyInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6348, 6374);
                    return 0;
                }


                System.Collections.IList
                f_1267_5942_5952_I(System.Collections.IList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 5942, 5952);
                    return return_v;
                }


                int
                f_1267_6446_6489(System.Management.Automation.DscResourceInfo
                this_param, System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>
                properties)
                {
                    this_param.UpdateProperties((System.Collections.Generic.IList<System.Management.Automation.DscResourcePropertyInfo>)properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6446, 6489);
                    return 0;
                }


                int
                f_1267_6553_6592(System.Collections.ObjectModel.Collection<System.Management.Automation.DscResourceInfo>
                this_param, System.Management.Automation.DscResourceInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6553, 6592);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1267_4039_4045_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 4039, 4045);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Management.Automation.DscResourceInfo>
                f_1267_6789_6826(System.Collections.ObjectModel.Collection<System.Management.Automation.DscResourceInfo>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6789, 6826);
                    return return_v;
                }


                bool
                f_1267_6919_6947(System.Collections.Generic.IEnumerator<System.Management.Automation.DscResourceInfo>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 6919, 6947);
                    return return_v;
                }


                System.Management.Automation.DscResourceInfo
                f_1267_7079_7104(System.Collections.Generic.IEnumerator<System.Management.Automation.DscResourceInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1267, 7079, 7104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1267, 3474, 7159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 3474, 7159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DscResourceSearcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1267, 410, 7188);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1267, 410, 7188);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1267, 410, 7188);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1267, 410, 7188);

        int
        f_1267_649_724(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 649, 724);
            return 0;
        }


        bool
        f_1267_759_793(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 759, 793);
            return return_v;
        }


        int
        f_1267_739_835(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1267, 739, 835);
            return 0;
        }

    }
}
