// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal PathInfo CurrentLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 1039, 1682);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 1075, 1369) || true) && (f_1349_1079_1091() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 1075, 1369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 1299, 1350);

                        throw f_1349_1305_1349();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 1075, 1369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 1389, 1633);

                    PathInfo
                    result =
                    f_1349_1428_1632(f_1349_1467_1479(), f_1349_1506_1527(f_1349_1506_1518()), f_1349_1554_1582(f_1349_1554_1566()), f_1349_1609_1631(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 1653, 1667);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 1039, 1682);

                    System.Management.Automation.PSDriveInfo
                    f_1349_1079_1091()
                    {
                        var return_v = CurrentDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1079, 1091);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1349_1305_1349()
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 1305, 1349);
                        return return_v;
                    }


                    System.Management.Automation.PSDriveInfo
                    f_1349_1467_1479()
                    {
                        var return_v = CurrentDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1467, 1479);
                        return return_v;
                    }


                    System.Management.Automation.PSDriveInfo
                    f_1349_1506_1518()
                    {
                        var return_v = CurrentDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1506, 1518);
                        return return_v;
                    }


                    System.Management.Automation.ProviderInfo
                    f_1349_1506_1527(System.Management.Automation.PSDriveInfo
                    this_param)
                    {
                        var return_v = this_param.Provider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1506, 1527);
                        return return_v;
                    }


                    System.Management.Automation.PSDriveInfo
                    f_1349_1554_1566()
                    {
                        var return_v = CurrentDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1554, 1566);
                        return return_v;
                    }


                    string
                    f_1349_1554_1582(System.Management.Automation.PSDriveInfo
                    this_param)
                    {
                        var return_v = this_param.CurrentLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 1554, 1582);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1349_1609_1631(System.Management.Automation.SessionStateInternal
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.SessionState(sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 1609, 1631);
                        return return_v;
                    }


                    System.Management.Automation.PathInfo
                    f_1349_1428_1632(System.Management.Automation.PSDriveInfo
                    drive, System.Management.Automation.ProviderInfo
                    provider, string
                    path, System.Management.Automation.SessionState
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.PathInfo(drive, provider, path, sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 1428, 1632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 981, 1693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 981, 1693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PathInfo GetNamespaceCurrentLocation(string namespaceID)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 2706, 4617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 2796, 2928) || true) && (namespaceID == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 2796, 2928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 2853, 2913);

                    throw f_1349_2859_2912("namespaceID");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 2796, 2928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3024, 3049);

                PSDriveInfo
                drive = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3065, 3428) || true) && (f_1349_3069_3087(namespaceID) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 3065, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3126, 3201);

                    f_1349_3126_3200(f_1349_3126_3154(), f_1349_3167_3188(f_1349_3167_3179()), out drive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 3065, 3428);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 3065, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3329, 3413);

                    f_1349_3329_3412(f_1349_3329_3357(), f_1349_3370_3400(this, namespaceID), out drive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 3065, 3428);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3444, 3752) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 3444, 3752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3495, 3711);

                    DriveNotFoundException
                    e =
                    f_1349_3543_3710(namespaceID, "DriveNotFound", f_1349_3676_3709())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3729, 3737);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 3444, 3752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3768, 3849);

                CmdletProviderContext
                context = f_1349_3800_3848(f_1349_3826_3847(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3863, 3885);

                context.Drive = drive;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3954, 3973);

                string
                path = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 3989, 4517) || true) && (f_1349_3993_4005(drive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 3989, 4517);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 4039, 4361) || true) && (f_1349_4043_4102(f_1349_4080_4101(drive)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 4039, 4361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 4144, 4173);

                        path = f_1349_4151_4172(drive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 4039, 4361);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 4039, 4361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 4255, 4342);

                        path = f_1349_4262_4341(f_1349_4303_4324(drive), f_1349_4326_4340(drive));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 4039, 4361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 3989, 4517);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 3989, 4517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 4427, 4502);

                    path = f_1349_4434_4501(f_1349_4472_4493(drive), drive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 3989, 4517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 4533, 4606);

                return f_1349_4540_4605(drive, f_1349_4560_4574(drive), path, f_1349_4582_4604(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 2706, 4617);

                System.Management.Automation.PSArgumentNullException
                f_1349_2859_2912(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 2859, 2912);
                    return return_v;
                }


                int
                f_1349_3069_3087(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3069, 3087);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1349_3126_3154()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3126, 3154);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_3167_3179()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3167, 3179);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_3167_3188(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3167, 3188);
                    return return_v;
                }


                bool
                f_1349_3126_3200(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.ProviderInfo
                key, out System.Management.Automation.PSDriveInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 3126, 3200);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1349_3329_3357()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3329, 3357);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_3370_3400(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 3370, 3400);
                    return return_v;
                }


                bool
                f_1349_3329_3412(System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                this_param, System.Management.Automation.ProviderInfo
                key, out System.Management.Automation.PSDriveInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 3329, 3412);
                    return return_v;
                }


                string
                f_1349_3676_3709()
                {
                    var return_v = SessionStateStrings.DriveNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3676, 3709);
                    return return_v;
                }


                System.Management.Automation.DriveNotFoundException
                f_1349_3543_3710(string
                itemName, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.DriveNotFoundException(itemName, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 3543, 3710);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1349_3826_3847(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3826, 3847);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1349_3800_3848(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 3800, 3848);
                    return return_v;
                }


                bool
                f_1349_3993_4005(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Hidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 3993, 4005);
                    return return_v;
                }


                string
                f_1349_4080_4101(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4080, 4101);
                    return return_v;
                }


                bool
                f_1349_4043_4102(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 4043, 4102);
                    return return_v;
                }


                string
                f_1349_4151_4172(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4151, 4172);
                    return return_v;
                }


                string
                f_1349_4303_4324(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4303, 4324);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_4326_4340(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4326, 4340);
                    return return_v;
                }


                string
                f_1349_4262_4341(string
                path, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = LocationGlobber.GetProviderQualifiedPath(path, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 4262, 4341);
                    return return_v;
                }


                string
                f_1349_4472_4493(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4472, 4493);
                    return return_v;
                }


                string
                f_1349_4434_4501(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = LocationGlobber.GetDriveQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 4434, 4501);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_4560_4574(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 4560, 4574);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1349_4582_4604(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 4582, 4604);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_4540_4605(System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PathInfo(drive, provider, path, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 4540, 4605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 2706, 4617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 2706, 4617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo SetLocation(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 5854, 5963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 5921, 5952);

                return f_1349_5928_5951(this, path, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 5854, 5963);

                System.Management.Automation.PathInfo
                f_1349_5928_5951(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.SetLocation(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 5928, 5951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 5854, 5963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 5854, 5963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo SetLocation(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 7478, 7641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 7576, 7630);

                return f_1349_7583_7629(this, path, context, literalPath: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 7478, 7641);

                System.Management.Automation.PathInfo
                f_1349_7583_7629(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                literalPath)
                {
                    var return_v = this_param.SetLocation(path, context, literalPath: literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 7583, 7629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 7478, 7641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 7478, 7641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo SetLocation(string path, CmdletProviderContext context, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 9272, 23865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9388, 9506) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 9388, 9506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9438, 9491);

                    throw f_1349_9444_9490("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 9388, 9506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9522, 9557);

                PathInfo
                current = f_1349_9541_9556()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9571, 9598);

                string
                originalPath = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9612, 9636);

                string
                driveName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9650, 9679);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9693, 9718);

                string
                providerId = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9734, 10868);

                switch (originalPath)
                {

                    case string originalPathSwitch when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9819, 9896) || true) && (!literalPath && (DynAbs.Tracing.TraceSender.Expression_True(1349, 9824, 9896) && f_1349_9840_9896(originalPathSwitch, "-", StringComparison.Ordinal))) && (DynAbs.Tracing.TraceSender.Expression_True(1349, 9819, 9896) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 9734, 10868);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 9919, 10112) || true) && (f_1349_9923_9952(_setLocationHistory) <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 9919, 10112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10007, 10089);

                            throw f_1349_10013_10088(f_1349_10043_10087());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 9919, 10112);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10136, 10195);

                        path = f_1349_10143_10194(f_1349_10143_10189(_setLocationHistory, f_1349_10168_10188(this)));
                        DynAbs.Tracing.TraceSender.TraceBreak(1349, 10217, 10223);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 9734, 10868);

                    case string originalPathSwitch when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10272, 10349) || true) && (!literalPath && (DynAbs.Tracing.TraceSender.Expression_True(1349, 10277, 10349) && f_1349_10293_10349(originalPathSwitch, "+", StringComparison.Ordinal))) && (DynAbs.Tracing.TraceSender.Expression_True(1349, 10272, 10349) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 9734, 10868);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10372, 10565) || true) && (f_1349_10376_10405(_setLocationHistory) <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 10372, 10565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10460, 10542);

                            throw f_1349_10466_10541(f_1349_10496_10540());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 10372, 10565);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10589, 10648);

                        path = f_1349_10596_10647(f_1349_10596_10642(_setLocationHistory, f_1349_10621_10641(this)));
                        DynAbs.Tracing.TraceSender.TraceBreak(1349, 10670, 10676);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 9734, 10868);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 9734, 10868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10724, 10764);

                        var
                        pushPathInfo = f_1349_10743_10763(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10786, 10825);

                        f_1349_10786_10824(_setLocationHistory, pushPathInfo);
                        DynAbs.Tracing.TraceSender.TraceBreak(1349, 10847, 10853);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 9734, 10868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 10884, 10932);

                PSDriveInfo
                previousWorkingDrive = f_1349_10919_10931()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11010, 11136) || true) && (f_1349_11014_11046(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11010, 11136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11080, 11121);

                    path = f_1349_11087_11120(f_1349_11087_11094(), path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11010, 11136);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11152, 12999) || true) && (f_1349_11156_11198(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11152, 12999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11410, 11446);

                    provider = f_1349_11421_11445(f_1349_11421_11436());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11464, 11500);

                    CurrentDrive = f_1349_11479_11499(provider);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11152, 12999);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11152, 12999);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11534, 12999) || true) && (f_1349_11538_11599(path, out providerId))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11534, 12999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11633, 11674);

                        provider = f_1349_11644_11673(this, providerId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11692, 11728);

                        CurrentDrive = f_1349_11707_11727(provider);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11534, 12999);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11534, 12999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 11882, 12984) || true) && (f_1349_11886_11929(f_1349_11886_11893(), path, out driveName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 11882, 12984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 12122, 12172);

                            PSDriveInfo
                            newWorkingDrive = f_1349_12152_12171(this, driveName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 12194, 12225);

                            CurrentDrive = newWorkingDrive;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 12482, 12537);

                            string
                            colonTerminatedVolume = f_1349_12513_12530(f_1349_12513_12525()) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (':').ToString(), 1349, 12533, 12536)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 12559, 12823) || true) && (f_1349_12563_12598(f_1349_12563_12575()) && (DynAbs.Tracing.TraceSender.Expression_True(1349, 12563, 12647) && (f_1349_12603_12614(path) == f_1349_12618_12646(colonTerminatedVolume))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 12559, 12823);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 12697, 12800);

                                path = f_1349_12704_12799(colonTerminatedVolume + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Path.DirectorySeparatorChar).ToString(), 1349, 12741, 12768), f_1349_12770_12798(f_1349_12770_12782()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 12559, 12823);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11882, 12984);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11534, 12999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 11152, 12999);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13015, 13142) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 13015, 13142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13068, 13127);

                    context = f_1349_13078_13126(f_1349_13104_13125(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 13015, 13142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13158, 13260) || true) && (f_1349_13162_13174() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 13158, 13260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13216, 13245);

                    context.Drive = f_1349_13232_13244();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 13158, 13260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13276, 13315);

                CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13331, 13371);

                Collection<PathInfo>
                workingPath = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13423, 13645);

                    workingPath =
                    f_1349_13458_13644(f_1349_13458_13465(), path, false, context, out providerInstance);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 13674, 13753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13732, 13738);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 13674, 13753);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 13767, 13853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13832, 13838);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 13767, 13853);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 13867, 13958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 13937, 13943);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 13867, 13958);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 13972, 14202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14127, 14163);

                    CurrentDrive = previousWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14181, 14187);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 13972, 14202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14218, 14653) || true) && (f_1349_14222_14239(workingPath) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 14218, 14653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14397, 14433);

                    CurrentDrive = previousWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14453, 14638);

                    throw
                    f_1349_14480_14637(path, "PathNotFound", f_1349_14604_14636());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 14218, 14653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14764, 14792);

                bool
                foundContainer = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14806, 14835);

                bool
                pathIsContainer = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14849, 14890);

                bool
                pathIsProviderQualifiedPath = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14904, 14952);

                bool
                currentPathisProviderQualifiedPath = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14977, 14986);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 14968, 21817) || true) && (index < f_1349_14996_15013(workingPath))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15015, 15022)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 14968, 21817))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 14968, 21817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15056, 15157);

                        CmdletProviderContext
                        normalizePathContext =
                        f_1349_15122_15156(context)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15177, 15220);

                        PathInfo
                        resolvedPath = f_1349_15201_15219(workingPath, index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15238, 15264);

                        string
                        currentPath = path
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15326, 15353);

                            string
                            providerName = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15375, 15489);

                            currentPathisProviderQualifiedPath = f_1349_15412_15488(f_1349_15452_15469(resolvedPath), out providerName);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15511, 18443) || true) && (currentPathisProviderQualifiedPath)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 15511, 18443);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15732, 15821);

                                string
                                providerInternalPath = f_1349_15762_15820(f_1349_15802_15819(resolvedPath))
                                ;

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 15909, 16036);

                                    currentPath = f_1349_15923_16035(this, f_1349_15945_15976(this, providerName), providerInternalPath, string.Empty, normalizePathContext);
                                }
                                catch (NotSupportedException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 16089, 16331);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 16089, 16331);
                                    // Since the provider does not support normalizing the path, just
                                    // use the path we currently have.
                                }
                                catch (LoopFlowException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 16357, 16472);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 16439, 16445);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 16357, 16472);
                                }
                                catch (PipelineStoppedException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 16498, 16620);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 16587, 16593);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 16498, 16620);
                                }
                                catch (ActionPreferenceStopException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 16646, 16773);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 16740, 16746);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 16646, 16773);
                                }
                                catch (Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 16799, 17101);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 17002, 17038);

                                    CurrentDrive = previousWorkingDrive;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 17068, 17074);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 16799, 17101);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 15511, 18443);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 15511, 18443);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 17259, 17355);

                                    currentPath = f_1349_17273_17354(this, f_1349_17295_17312(resolvedPath), f_1349_17314_17331(f_1349_17314_17326()), normalizePathContext);
                                }
                                catch (NotSupportedException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 17408, 17650);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 17408, 17650);
                                    // Since the provider does not support normalizing the path, just
                                    // use the path we currently have.
                                }
                                catch (LoopFlowException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 17676, 17791);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 17758, 17764);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 17676, 17791);
                                }
                                catch (PipelineStoppedException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 17817, 17939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 17906, 17912);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 17817, 17939);
                                }
                                catch (ActionPreferenceStopException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 17965, 18092);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18059, 18065);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 17965, 18092);
                                }
                                catch (Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 18118, 18420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18321, 18357);

                                    CurrentDrive = previousWorkingDrive;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18387, 18393);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 18118, 18420);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 15511, 18443);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18546, 18904) || true) && (f_1349_18550_18582(normalizePathContext))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 18546, 18904);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18767, 18803);

                                CurrentDrive = previousWorkingDrive;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18831, 18881);

                                f_1349_18831_18880(
                                                        normalizePathContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 18546, 18904);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1349, 18941, 19050);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 18989, 19031);

                            f_1349_18989_19030(normalizePathContext);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1349, 18941, 19050);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19070, 19095);

                        bool
                        isContainer = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19115, 19216);

                        CmdletProviderContext
                        itemContainerContext =
                        f_1349_19181_19215(context)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19234, 19288);

                        itemContainerContext.SuppressWildcardExpansion = true;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19352, 19507);

                            isContainer =
                            f_1349_19391_19506(this, f_1349_19437_19454(resolvedPath), itemContainerContext);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19531, 19889) || true) && (f_1349_19535_19567(itemContainerContext))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 19531, 19889);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19752, 19788);

                                CurrentDrive = previousWorkingDrive;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19816, 19866);

                                f_1349_19816_19865(
                                                        itemContainerContext);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 19531, 19889);
                            }
                        }
                        catch (NotSupportedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 19926, 20355);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 19996, 20336) || true) && (f_1349_20000_20018(currentPath) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 19996, 20336);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20294, 20313);

                                isContainer = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 19996, 20336);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 19926, 20355);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1349, 20373, 20482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20421, 20463);

                            f_1349_20421_20462(itemContainerContext);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1349, 20373, 20482);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20502, 21802) || true) && (isContainer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 20502, 21802);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20559, 21783) || true) && (foundContainer)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 20559, 21783);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20835, 20871);

                                CurrentDrive = previousWorkingDrive;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 20899, 21135);

                                throw
                                f_1349_20934_21134("path", f_1349_21044_21086(), originalPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 20559, 21783);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 20559, 21783);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 21281, 21300);

                                path = currentPath;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 21379, 21402);

                                pathIsContainer = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 21504, 21569);

                                pathIsProviderQualifiedPath = currentPathisProviderQualifiedPath;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 21738, 21760);

                                foundContainer = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 20559, 21783);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 20502, 21802);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1349, 1, 6850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1349, 1, 6850);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 21833, 22910) || true) && (pathIsContainer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 21833, 22910);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22028, 22291) || true) && (!f_1349_22033_22075(path) && (DynAbs.Tracing.TraceSender.Expression_True(1349, 22032, 22152) && f_1349_22100_22152(path, StringLiterals.DefaultPathSeparator)) && (DynAbs.Tracing.TraceSender.Expression_True(1349, 22032, 22205) && !pathIsProviderQualifiedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 22028, 22291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22247, 22272);

                        path = f_1349_22254_22271(path, 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 22028, 22291);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22311, 22405);

                    f_1349_22311_22404(
                                    s_tracer, "New working path = {0}", path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22425, 22461);

                    f_1349_22425_22437().CurrentLocation = path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 21833, 22910);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 21833, 22910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22646, 22682);

                    CurrentDrive = previousWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 22702, 22895);

                    throw
                    f_1349_22729_22894(originalPath, "PathNotFound", f_1349_22861_22893());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 21833, 22910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23047, 23131);

                f_1349_23047_23075()[f_1349_23076_23097(f_1349_23076_23088())] =
                f_1349_23118_23130();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23205, 23310);

                f_1349_23205_23309(
                            // Set the $PWD variable to the new location
                            this, SpecialVariables.PWDVarPath, f_1349_23251_23271(this), false, true, CommandOrigin.Internal);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23409, 23810) || true) && (f_1349_23413_23467(f_1349_23413_23445(f_1349_23413_23431())) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 23409, 23810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23509, 23600);

                    var
                    eventArgs = f_1349_23525_23599(f_1349_23554_23572(), current, f_1349_23583_23598())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23618, 23725);

                    // LAFHIS ;
                    //f_1349_23618_23724(f_1349_23618_23672(f_1349_23618_23650(f_1349_23618_23636())), f_1349_23680_23712(f_1349_23680_23696()), eventArgs);
                    f_1349_23618_23672(f_1349_23618_23650(f_1349_23618_23636())).Invoke(f_1349_23680_23712(f_1349_23680_23696()), eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 23618, 23724);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23743, 23795);

                    f_1349_23743_23794(s_tracer, "Invoked LocationChangedAction");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 23409, 23810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 23826, 23854);

                return f_1349_23833_23853(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 9272, 23865);

                System.Management.Automation.PSArgumentNullException
                f_1349_9444_9490(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 9444, 9490);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_9541_9556()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 9541, 9556);
                    return return_v;
                }


                bool
                f_1349_9840_9896(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 9840, 9896);
                    return return_v;
                }


                int
                f_1349_9923_9952(System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 9923, 9952);
                    return return_v;
                }


                string
                f_1349_10043_10087()
                {
                    var return_v = SessionStateStrings.LocationUndoStackIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10043, 10087);
                    return return_v;
                }


                System.InvalidOperationException
                f_1349_10013_10088(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10013, 10088);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_10168_10188(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10168, 10188);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_10143_10189(System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                currentItem)
                {
                    var return_v = this_param.Undo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10143, 10189);
                    return return_v;
                }


                string
                f_1349_10143_10194(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10143, 10194);
                    return return_v;
                }


                bool
                f_1349_10293_10349(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10293, 10349);
                    return return_v;
                }


                int
                f_1349_10376_10405(System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10376, 10405);
                    return return_v;
                }


                string
                f_1349_10496_10540()
                {
                    var return_v = SessionStateStrings.LocationRedoStackIsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10496, 10540);
                    return return_v;
                }


                System.InvalidOperationException
                f_1349_10466_10541(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10466, 10541);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_10621_10641(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10621, 10641);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_10596_10642(System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                currentItem)
                {
                    var return_v = this_param.Redo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10596, 10642);
                    return return_v;
                }


                string
                f_1349_10596_10647(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10596, 10647);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_10743_10763(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetNewPushPathInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10743, 10763);
                    return return_v;
                }


                int
                f_1349_10786_10824(System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 10786, 10824);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_10919_10931()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 10919, 10931);
                    return return_v;
                }


                bool
                f_1349_11014_11046(string
                path)
                {
                    var return_v = LocationGlobber.IsHomePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11014, 11046);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1349_11087_11094()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11087, 11094);
                    return return_v;
                }


                string
                f_1349_11087_11120(System.Management.Automation.LocationGlobber
                this_param, string
                path)
                {
                    var return_v = this_param.GetHomeRelativePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11087, 11120);
                    return return_v;
                }


                bool
                f_1349_11156_11198(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11156, 11198);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_11421_11436()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11421, 11436);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_11421_11445(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11421, 11445);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_11479_11499(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.HiddenDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11479, 11499);
                    return return_v;
                }


                bool
                f_1349_11538_11599(string
                path, out string
                providerId)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11538, 11599);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_11644_11673(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11644, 11673);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_11707_11727(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.HiddenDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11707, 11727);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1349_11886_11893()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 11886, 11893);
                    return return_v;
                }


                bool
                f_1349_11886_11929(System.Management.Automation.LocationGlobber
                this_param, string
                path, out string
                driveName)
                {
                    var return_v = this_param.IsAbsolutePath(path, out driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 11886, 11929);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_12152_12171(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetDrive(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 12152, 12171);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_12513_12525()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12513, 12525);
                    return return_v;
                }


                string
                f_1349_12513_12530(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12513, 12530);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_12563_12575()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12563, 12575);
                    return return_v;
                }


                bool
                f_1349_12563_12598(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12563, 12598);
                    return return_v;
                }


                int
                f_1349_12603_12614(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12603, 12614);
                    return return_v;
                }


                int
                f_1349_12618_12646(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12618, 12646);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_12770_12782()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12770, 12782);
                    return return_v;
                }


                string
                f_1349_12770_12798(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 12770, 12798);
                    return return_v;
                }


                string
                f_1349_12704_12799(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 12704, 12799);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1349_13104_13125(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 13104, 13125);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1349_13078_13126(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 13078, 13126);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_13162_13174()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 13162, 13174);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_13232_13244()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 13232, 13244);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1349_13458_13465()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 13458, 13465);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1349_13458_13644(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 13458, 13644);
                    return return_v;
                }


                int
                f_1349_14222_14239(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 14222, 14239);
                    return return_v;
                }


                string
                f_1349_14604_14636()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 14604, 14636);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1349_14480_14637(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 14480, 14637);
                    return return_v;
                }


                int
                f_1349_14996_15013(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 14996, 15013);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1349_15122_15156(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 15122, 15156);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_15201_15219(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 15201, 15219);
                    return return_v;
                }


                string
                f_1349_15452_15469(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 15452, 15469);
                    return return_v;
                }


                bool
                f_1349_15412_15488(string
                path, out string
                providerId)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 15412, 15488);
                    return return_v;
                }


                string
                f_1349_15802_15819(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 15802, 15819);
                    return return_v;
                }


                string
                f_1349_15762_15820(string
                path)
                {
                    var return_v = LocationGlobber.RemoveProviderQualifier(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 15762, 15820);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_15945_15976(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 15945, 15976);
                    return return_v;
                }


                string
                f_1349_15923_16035(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(provider, path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 15923, 16035);
                    return return_v;
                }


                string
                f_1349_17295_17312(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 17295, 17312);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_17314_17326()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 17314, 17326);
                    return return_v;
                }


                string
                f_1349_17314_17331(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 17314, 17331);
                    return return_v;
                }


                string
                f_1349_17273_17354(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 17273, 17354);
                    return return_v;
                }


                bool
                f_1349_18550_18582(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 18550, 18582);
                    return return_v;
                }


                int
                f_1349_18831_18880(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 18831, 18880);
                    return 0;
                }


                int
                f_1349_18989_19030(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 18989, 19030);
                    return 0;
                }


                System.Management.Automation.CmdletProviderContext
                f_1349_19181_19215(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 19181, 19215);
                    return return_v;
                }


                string
                f_1349_19437_19454(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 19437, 19454);
                    return return_v;
                }


                bool
                f_1349_19391_19506(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsItemContainer(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 19391, 19506);
                    return return_v;
                }


                bool
                f_1349_19535_19567(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 19535, 19567);
                    return return_v;
                }


                int
                f_1349_19816_19865(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 19816, 19865);
                    return 0;
                }


                int
                f_1349_20000_20018(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 20000, 20018);
                    return return_v;
                }


                int
                f_1349_20421_20462(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 20421, 20462);
                    return 0;
                }


                string
                f_1349_21044_21086()
                {
                    var return_v = SessionStateStrings.PathResolvedToMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 21044, 21086);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1349_20934_21134(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 20934, 21134);
                    return return_v;
                }


                bool
                f_1349_22033_22075(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderDirectPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 22033, 22075);
                    return return_v;
                }


                bool
                f_1349_22100_22152(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 22100, 22152);
                    return return_v;
                }


                string
                f_1349_22254_22271(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 22254, 22271);
                    return return_v;
                }


                int
                f_1349_22311_22404(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 22311, 22404);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_22425_22437()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 22425, 22437);
                    return return_v;
                }


                string
                f_1349_22861_22893()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 22861, 22893);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1349_22729_22894(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 22729, 22894);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.ProviderInfo, System.Management.Automation.PSDriveInfo>
                f_1349_23047_23075()
                {
                    var return_v = ProvidersCurrentWorkingDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23047, 23075);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_23076_23088()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23076, 23088);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_23076_23097(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23076, 23097);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_23118_23130()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23118, 23130);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_23251_23271(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23251, 23271);
                    return return_v;
                }


                object
                f_1349_23205_23309(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, System.Management.Automation.PathInfo
                newValue, bool
                asValue, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, (object)newValue, asValue, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 23205, 23309);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1349_23413_23431()
                {
                    var return_v = PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23413, 23431);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1349_23413_23445(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23413, 23445);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.LocationChangedEventArgs>
                f_1349_23413_23467(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.LocationChangedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23413, 23467);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1349_23554_23572()
                {
                    var return_v = PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23554, 23572);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_23583_23598()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23583, 23598);
                    return return_v;
                }


                System.Management.Automation.LocationChangedEventArgs
                f_1349_23525_23599(System.Management.Automation.SessionState
                sessionState, System.Management.Automation.PathInfo
                oldPath, System.Management.Automation.PathInfo
                newPath)
                {
                    var return_v = new System.Management.Automation.LocationChangedEventArgs(sessionState, oldPath, newPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 23525, 23599);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1349_23618_23636()
                {
                    var return_v = PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23618, 23636);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1349_23618_23650(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23618, 23650);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.LocationChangedEventArgs>
                f_1349_23618_23672(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.LocationChangedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23618, 23672);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1349_23680_23696()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23680, 23696);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1349_23680_23712(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23680, 23712);
                    return return_v;
                }


                int
                f_1349_23618_23724(System.Management.Automation.CommandInvocationIntrinsics
                this_param, System.Management.Automation.Runspaces.Runspace
                sender, System.Management.Automation.LocationChangedEventArgs
                e)
                {
                    this_param.LocationChangedAction((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 23618, 23724);
                    return 0;
                }


                int
                f_1349_23743_23794(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 23743, 23794);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1349_23833_23853(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 23833, 23853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 9272, 23865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 9272, 23865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsCurrentLocationOrAncestor(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 25883, 31834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 25993, 26013);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26029, 26147) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 26029, 26147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26079, 26132);

                    throw f_1349_26085_26131("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 26029, 26147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26163, 26188);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26202, 26231);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26247, 26443);

                string
                providerSpecificPath =
                f_1349_26294_26442(f_1349_26294_26301(), path, context, out provider, out drive)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26459, 26593) || true) && (drive != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 26459, 26593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26510, 26546);

                    f_1349_26510_26545(s_tracer, "Tracing drive");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26564, 26578);

                    f_1349_26564_26577(drive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 26459, 26593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26609, 26796);

                f_1349_26609_26795(providerSpecificPath != null, "There should always be a way to generate a provider path for a " +
                                "given path");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26812, 26900) || true) && (drive != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 26812, 26900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 26863, 26885);

                    context.Drive = drive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 26812, 26900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 27028, 31793) || true) && (drive == f_1349_27041_27053())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 27028, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 27250, 27351);

                    CmdletProviderContext
                    normalizePathContext
                                        = f_1349_27316_27350(context)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 27415, 27494);

                        providerSpecificPath = f_1349_27438_27493(this, path, null, normalizePathContext);
                    }
                    catch (NotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 27531, 27741);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 27531, 27741);
                        // Since the provider does not support normalizing the path, just
                        // use the path we currently have.
                    }
                    catch (LoopFlowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 27759, 27850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 27825, 27831);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 27759, 27850);
                    }
                    catch (PipelineStoppedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 27868, 27966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 27941, 27947);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 27868, 27966);
                    }
                    catch (ActionPreferenceStopException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 27984, 28087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28062, 28068);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 27984, 28087);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1349, 28105, 28214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28153, 28195);

                        f_1349_28153_28194(normalizePathContext);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1349, 28105, 28214);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28234, 28381) || true) && (f_1349_28238_28270(normalizePathContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 28234, 28381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28312, 28362);

                        f_1349_28312_28361(normalizePathContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 28234, 28381);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28401, 28465);

                    f_1349_28401_28464(
                                    s_tracer, "Provider path = {0}", providerSpecificPath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28562, 28601);

                    PSDriveInfo
                    currentWorkingDrive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28619, 28660);

                    ProviderInfo
                    currentDriveProvider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28680, 28919);

                    string
                    currentWorkingPath =
                    f_1349_28729_28918(f_1349_28729_28736(), ".", context, out currentDriveProvider, out currentWorkingDrive)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 28939, 29099);

                    f_1349_28939_29098(currentWorkingDrive == f_1349_29007_29019(), "The current working drive should be the CurrentDrive.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 29119, 29231);

                    f_1349_29119_29230(
                                    s_tracer, "Current working path = {0}", currentWorkingPath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 29385, 29534);

                    f_1349_29385_29533(
                                    // See if the path is the current working directory or a parent
                                    // of the current working directory
                                    s_tracer, "Comparing {0} to {1}", providerSpecificPath, currentWorkingPath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 29554, 31666) || true) && (f_1349_29558_29657(providerSpecificPath, currentWorkingPath, StringComparison.CurrentCultureIgnoreCase) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 29554, 31666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 29809, 29873);

                        f_1349_29809_29872(                    // The path is the current working directory so
                                                               // return true
                                            s_tracer, "The path is the current working directory");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 29897, 29911);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 29554, 31666);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 29554, 31666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 30121, 30165);

                        string
                        lockedDirectory = currentWorkingPath
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 30189, 31647) || true) && (f_1349_30196_30218(lockedDirectory) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 30189, 31647);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 30593, 30843);

                                lockedDirectory =
                                f_1349_30640_30842(this, f_1349_30688_30702(drive), lockedDirectory, string.Empty, context);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 30871, 31041);

                                f_1349_30871_31040(
                                                        s_tracer, "Comparing {0} to {1}", lockedDirectory, providerSpecificPath);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 31069, 31624) || true) && (f_1349_31073_31169(lockedDirectory, providerSpecificPath, StringComparison.CurrentCultureIgnoreCase) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 31069, 31624);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 31350, 31515);

                                    f_1349_31350_31514(                            // The path is a parent of the current working
                                                                                   // directory
                                                                s_tracer, "The path is a parent of the current working directory: {0}", lockedDirectory);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 31547, 31561);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1349, 31591, 31597);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 31069, 31624);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 30189, 31647);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1349, 30189, 31647);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1349, 30189, 31647);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 29554, 31666);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 27028, 31793);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 27028, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 31732, 31778);

                    f_1349_31732_31777(s_tracer, "Drives are not the same");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 27028, 31793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 31809, 31823);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 25883, 31834);

                System.Management.Automation.PSArgumentNullException
                f_1349_26085_26131(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 26085, 26131);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1349_26294_26301()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 26294, 26301);
                    return return_v;
                }


                string
                f_1349_26294_26442(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 26294, 26442);
                    return return_v;
                }


                int
                f_1349_26510_26545(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 26510, 26545);
                    return 0;
                }


                int
                f_1349_26564_26577(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    this_param.Trace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 26564, 26577);
                    return 0;
                }


                int
                f_1349_26609_26795(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 26609, 26795);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_27041_27053()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 27041, 27053);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1349_27316_27350(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 27316, 27350);
                    return return_v;
                }


                string
                f_1349_27438_27493(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 27438, 27493);
                    return return_v;
                }


                int
                f_1349_28153_28194(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28153, 28194);
                    return 0;
                }


                bool
                f_1349_28238_28270(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28238, 28270);
                    return return_v;
                }


                int
                f_1349_28312_28361(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28312, 28361);
                    return 0;
                }


                int
                f_1349_28401_28464(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28401, 28464);
                    return 0;
                }


                System.Management.Automation.LocationGlobber
                f_1349_28729_28736()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 28729, 28736);
                    return return_v;
                }


                string
                f_1349_28729_28918(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28729, 28918);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_29007_29019()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 29007, 29019);
                    return return_v;
                }


                int
                f_1349_28939_29098(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 28939, 29098);
                    return 0;
                }


                int
                f_1349_29119_29230(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 29119, 29230);
                    return 0;
                }


                int
                f_1349_29385_29533(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 29385, 29533);
                    return 0;
                }


                int
                f_1349_29558_29657(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 29558, 29657);
                    return return_v;
                }


                int
                f_1349_29809_29872(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 29809, 29872);
                    return 0;
                }


                int
                f_1349_30196_30218(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 30196, 30218);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_30688_30702(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 30688, 30702);
                    return return_v;
                }


                string
                f_1349_30640_30842(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(provider, path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 30640, 30842);
                    return return_v;
                }


                int
                f_1349_30871_31040(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 30871, 31040);
                    return 0;
                }


                int
                f_1349_31073_31169(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 31073, 31169);
                    return return_v;
                }


                int
                f_1349_31350_31514(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 31350, 31514);
                    return 0;
                }


                int
                f_1349_31732_31777(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 31732, 31777);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 25883, 31834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 25883, 31834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HistoryStack<PathInfo> _setLocationHistory;

        private Dictionary<string, Stack<PathInfo>> _workingLocationStack;

        private const string
        startingDefaultStackName = "default"
        ;

        private string _defaultStackName;

        internal void PushCurrentLocation(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 32940, 33654);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33016, 33130) || true) && (f_1349_33020_33051(stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 33016, 33130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33085, 33115);

                    stackName = _defaultStackName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 33016, 33130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33204, 33241);

                Stack<PathInfo>
                locationStack = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33257, 33479) || true) && (!f_1349_33262_33325(_workingLocationStack, stackName, out locationStack))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 33257, 33479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33359, 33397);

                    locationStack = f_1349_33375_33396();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33415, 33464);

                    _workingLocationStack[stackName] = locationStack;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 33257, 33479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33556, 33596);

                var
                pushPathInfo = f_1349_33575_33595(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33610, 33643);

                f_1349_33610_33642(locationStack, pushPathInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 32940, 33654);

                bool
                f_1349_33020_33051(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33020, 33051);
                    return return_v;
                }


                bool
                f_1349_33262_33325(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                key, out System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33262, 33325);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                f_1349_33375_33396()
                {
                    var return_v = new System.Collections.Generic.Stack<System.Management.Automation.PathInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33375, 33396);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_33575_33595(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetNewPushPathInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33575, 33595);
                    return return_v;
                }


                int
                f_1349_33610_33642(System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                this_param, System.Management.Automation.PathInfo
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33610, 33642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 32940, 33654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 32940, 33654);
            }
        }

        private PathInfo GetNewPushPathInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 33666, 34412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33794, 33840);

                ProviderInfo
                provider = f_1349_33818_33839(f_1349_33818_33830())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33854, 33977);

                string
                mshQualifiedPath =
                f_1349_33897_33976(f_1349_33933_33961(f_1349_33933_33945()), f_1349_33963_33975())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 33993, 34201);

                PathInfo
                newPushLocation =
                f_1349_34037_34200(f_1349_34072_34084(), provider, mshQualifiedPath, f_1349_34177_34199(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 34217, 34362);

                f_1349_34217_34361(
                            s_tracer, "Pushing drive: {0} directory: {1}", f_1349_34308_34325(f_1349_34308_34320()), mshQualifiedPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 34378, 34401);

                return newPushLocation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 33666, 34412);

                System.Management.Automation.PSDriveInfo
                f_1349_33818_33830()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 33818, 33830);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1349_33818_33839(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 33818, 33839);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_33933_33945()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 33933, 33945);
                    return return_v;
                }


                string
                f_1349_33933_33961(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 33933, 33961);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_33963_33975()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 33963, 33975);
                    return return_v;
                }


                string
                f_1349_33897_33976(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = LocationGlobber.GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 33897, 33976);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_34072_34084()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 34072, 34084);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1349_34177_34199(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 34177, 34199);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_34037_34200(System.Management.Automation.PSDriveInfo
                drive, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PathInfo(drive, provider, path, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 34037, 34200);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_34308_34320()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 34308, 34320);
                    return return_v;
                }


                string
                f_1349_34308_34325(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 34308, 34325);
                    return return_v;
                }


                int
                f_1349_34217_34361(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 34217, 34361);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 33666, 34412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 33666, 34412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo PopLocation(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 35942, 39071);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36014, 36128) || true) && (f_1349_36018_36049(stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 36014, 36128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36083, 36113);

                    stackName = _defaultStackName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 36014, 36128);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36144, 37171) || true) && (f_1349_36148_36201(stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 36144, 37171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36318, 36341);

                    bool
                    haveMatch = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36361, 36476);

                    WildcardPattern
                    stackNamePattern =
                    f_1349_36417_36475(stackName, WildcardOptions.IgnoreCase)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36496, 37156);
                        foreach (string key in f_1349_36519_36545_I(f_1349_36519_36545(_workingLocationStack)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 36496, 37156);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36587, 37137) || true) && (f_1349_36591_36620(stackNamePattern, key))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 36587, 37137);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36670, 37027) || true) && (haveMatch)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 36670, 37027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 36741, 37000);

                                    throw
                                    f_1349_36780_36999("stackName", f_1349_36903_36950(), stackName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 36670, 37027);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37055, 37072);

                                haveMatch = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37098, 37114);

                                stackName = key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 36587, 37137);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 36496, 37156);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1349, 1, 661);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1349, 1, 661);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 36144, 37171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37187, 37221);

                PathInfo
                result = f_1349_37205_37220()
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37273, 37310);

                    Stack<PathInfo>
                    locationStack = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37328, 37886) || true) && (!f_1349_37333_37396(_workingLocationStack, stackName, out locationStack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 37328, 37886);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37438, 37831) || true) && (!f_1349_37443_37529(stackName, startingDefaultStackName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 37438, 37831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37579, 37808);

                            throw
                            f_1349_37614_37807("stackName", f_1349_37729_37762(), stackName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 37438, 37831);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37855, 37867);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 37328, 37886);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37906, 37960);

                    PathInfo
                    poppedWorkingDirectory = f_1349_37940_37959(locationStack)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 37980, 38172);

                    f_1349_37980_38171(poppedWorkingDirectory != null, "All items in the workingLocationStack should be " +
                                        "of type PathInfo");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 38192, 38405);

                    string
                    newPath =
                    f_1349_38230_38404(f_1349_38292_38343(f_1349_38315_38342(poppedWorkingDirectory)), f_1349_38370_38403(poppedWorkingDirectory))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 38425, 38455);

                    result = f_1349_38434_38454(this, newPath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 38475, 38837) || true) && (f_1349_38479_38498(locationStack) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1349, 38479, 38615) && !f_1349_38529_38615(stackName, startingDefaultStackName, StringComparison.OrdinalIgnoreCase)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 38475, 38837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 38778, 38818);

                        f_1349_38778_38817(                    // Remove the stack from the stack list if it
                                                               // no longer contains any paths.
                                            _workingLocationStack, stackName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 38475, 38837);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1349, 38866, 39030);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1349, 38866, 39030);
                    // This is a no-op. We stay with the current working
                    // directory.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 39046, 39060);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 35942, 39071);

                bool
                f_1349_36018_36049(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36018, 36049);
                    return return_v;
                }


                bool
                f_1349_36148_36201(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36148, 36201);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1349_36417_36475(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36417, 36475);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>.KeyCollection
                f_1349_36519_36545(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 36519, 36545);
                    return return_v;
                }


                bool
                f_1349_36591_36620(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36591, 36620);
                    return return_v;
                }


                string
                f_1349_36903_36950()
                {
                    var return_v = SessionStateStrings.StackNameResolvedToMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 36903, 36950);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1349_36780_36999(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36780, 36999);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>.KeyCollection
                f_1349_36519_36545_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 36519, 36545);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_37205_37220()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 37205, 37220);
                    return return_v;
                }


                bool
                f_1349_37333_37396(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                key, out System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 37333, 37396);
                    return return_v;
                }


                bool
                f_1349_37443_37529(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 37443, 37529);
                    return return_v;
                }


                string
                f_1349_37729_37762()
                {
                    var return_v = SessionStateStrings.StackNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 37729, 37762);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1349_37614_37807(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 37614, 37807);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_37940_37959(System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 37940, 37959);
                    return return_v;
                }


                int
                f_1349_37980_38171(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 37980, 38171);
                    return 0;
                }


                string
                f_1349_38315_38342(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 38315, 38342);
                    return return_v;
                }


                string
                f_1349_38292_38343(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38292, 38343);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1349_38370_38403(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.GetDrive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38370, 38403);
                    return return_v;
                }


                string
                f_1349_38230_38404(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = LocationGlobber.GetMshQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38230, 38404);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1349_38434_38454(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.SetLocation(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38434, 38454);
                    return return_v;
                }


                int
                f_1349_38479_38498(System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 38479, 38498);
                    return return_v;
                }


                bool
                f_1349_38529_38615(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38529, 38615);
                    return return_v;
                }


                bool
                f_1349_38778_38817(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 38778, 38817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 35942, 39071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 35942, 39071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfoStack LocationStack(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 39802, 40850);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 39881, 39995) || true) && (f_1349_39885_39916(stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 39881, 39995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 39950, 39980);

                    stackName = _defaultStackName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 39881, 39995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40011, 40048);

                Stack<PathInfo>
                locationStack = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40064, 40726) || true) && (!f_1349_40069_40132(_workingLocationStack, stackName, out locationStack))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 40064, 40726);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40310, 40711) || true) && (f_1349_40314_40476(stackName, startingDefaultStackName, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 40310, 40711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40518, 40556);

                        locationStack = f_1349_40534_40555();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 40310, 40711);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 40310, 40711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40638, 40692);

                        throw f_1349_40644_40691("stackName");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 40310, 40711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 40064, 40726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40742, 40809);

                PathInfoStack
                result = f_1349_40765_40808(stackName, locationStack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 40825, 40839);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 39802, 40850);

                bool
                f_1349_39885_39916(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 39885, 39916);
                    return return_v;
                }


                bool
                f_1349_40069_40132(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                key, out System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 40069, 40132);
                    return return_v;
                }


                bool
                f_1349_40314_40476(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 40314, 40476);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                f_1349_40534_40555()
                {
                    var return_v = new System.Collections.Generic.Stack<System.Management.Automation.PathInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 40534, 40555);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1349_40644_40691(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 40644, 40691);
                    return return_v;
                }


                System.Management.Automation.PathInfoStack
                f_1349_40765_40808(string
                stackName, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                locationStack)
                {
                    var return_v = new System.Management.Automation.PathInfoStack(stackName, locationStack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 40765, 40808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 39802, 40850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 39802, 40850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfoStack SetDefaultLocationStack(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1349, 41407, 42644);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 41496, 41617) || true) && (f_1349_41500_41531(stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 41496, 41617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 41565, 41602);

                    stackName = startingDefaultStackName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 41496, 41617);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 41633, 42321) || true) && (!f_1349_41638_41682(_workingLocationStack, stackName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 41633, 42321);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 41716, 42025) || true) && (f_1349_41720_41806(stackName, startingDefaultStackName, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 41716, 42025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 41932, 42006);

                        return f_1349_41939_42005(startingDefaultStackName, f_1349_41983_42004());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 41716, 42025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42045, 42267);

                    ItemNotFoundException
                    itemNotFound =
                    f_1349_42103_42266(stackName, "StackNotFound", f_1349_42233_42265())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42287, 42306);

                    throw itemNotFound;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 41633, 42321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42337, 42367);

                _defaultStackName = stackName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42383, 42456);

                Stack<PathInfo>
                locationStack = f_1349_42415_42455(_workingLocationStack, _defaultStackName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42472, 42605) || true) && (locationStack != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1349, 42472, 42605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42531, 42590);

                    return f_1349_42538_42589(_defaultStackName, locationStack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1349, 42472, 42605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 42621, 42633);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1349, 41407, 42644);

                bool
                f_1349_41500_41531(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 41500, 41531);
                    return return_v;
                }


                bool
                f_1349_41638_41682(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 41638, 41682);
                    return return_v;
                }


                bool
                f_1349_41720_41806(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 41720, 41806);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                f_1349_41983_42004()
                {
                    var return_v = new System.Collections.Generic.Stack<System.Management.Automation.PathInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 41983, 42004);
                    return return_v;
                }


                System.Management.Automation.PathInfoStack
                f_1349_41939_42005(string
                stackName, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                locationStack)
                {
                    var return_v = new System.Management.Automation.PathInfoStack(stackName, locationStack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 41939, 42005);
                    return return_v;
                }


                string
                f_1349_42233_42265()
                {
                    var return_v = SessionStateStrings.PathNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 42233, 42265);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1349_42103_42266(string
                path, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(path, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 42103, 42266);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                f_1349_42415_42455(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1349, 42415, 42455);
                    return return_v;
                }


                System.Management.Automation.PathInfoStack
                f_1349_42538_42589(string
                stackName, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>
                locationStack)
                {
                    var return_v = new System.Management.Automation.PathInfoStack(stackName, locationStack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1349, 42538, 42589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 41407, 42644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 41407, 42644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    public class LocationChangedEventArgs : EventArgs
    {
        internal LocationChangedEventArgs(SessionState sessionState, PathInfo oldPath, PathInfo newPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1349, 43464, 43688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 43800, 43846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 43956, 44002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 44132, 44187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 43585, 43613);

                SessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 43627, 43645);

                OldPath = oldPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 43659, 43677);

                NewPath = newPath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1349, 43464, 43688);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1349, 43464, 43688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 43464, 43688);
            }
        }

        public PathInfo OldPath { get; internal set; }

        public PathInfo NewPath { get; internal set; }

        public SessionState SessionState { get; internal set; }

        static LocationChangedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1349, 42920, 44194);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1349, 42920, 44194);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1349, 42920, 44194);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1349, 42920, 44194);
    }
}

