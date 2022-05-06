// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class PathIntrinsics
    {
        private PathIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1310, 580, 827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61512, 61525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61565, 61578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 629, 816);

                f_1310_629_815(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1310, 580, 827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 580, 827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 580, 827);
            }
        }

        internal PathIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1310, 1306, 1579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61512, 61525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61565, 61578);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 1389, 1523) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1310, 1389, 1523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 1447, 1508);

                    throw f_1310_1453_1507("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1310, 1389, 1523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 1539, 1568);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1310, 1306, 1579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 1306, 1579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 1306, 1579);
            }
        }

        public PathInfo CurrentLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 1936, 2213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 1972, 2141);

                    f_1310_1972_2140(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 2161, 2198);

                    return f_1310_2168_2197(_sessionState);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 1936, 2213);

                    int
                    f_1310_1972_2140(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 1972, 2140);
                        return 0;
                    }


                    System.Management.Automation.PathInfo
                    f_1310_2168_2197(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.CurrentLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 2168, 2197);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 1880, 2224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 1880, 2224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PathInfo CurrentProviderLocation(string providerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 2970, 3381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 3055, 3216);

                f_1310_3055_3215(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 3307, 3370);

                return f_1310_3314_3369(_sessionState, providerName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 2970, 3381);

                int
                f_1310_3055_3215(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 3055, 3215);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1310_3314_3369(System.Management.Automation.SessionStateInternal
                this_param, string
                namespaceID)
                {
                    var return_v = this_param.GetNamespaceCurrentLocation(namespaceID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 3314, 3369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 2970, 3381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 2970, 3381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PathInfo CurrentFileSystemLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 3732, 4060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 3768, 3937);

                    f_1310_3768_3936(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 3957, 4045);

                    return f_1310_3964_4044(this, f_1310_3988_4043(f_1310_3988_4032(f_1310_3988_4018(_sessionState))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 3732, 4060);

                    int
                    f_1310_3768_3936(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 3768, 3936);
                        return 0;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1310_3988_4018(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 3988, 4018);
                        return return_v;
                    }


                    System.Management.Automation.ProviderNames
                    f_1310_3988_4032(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.ProviderNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 3988, 4032);
                        return return_v;
                    }


                    string
                    f_1310_3988_4043(System.Management.Automation.ProviderNames
                    this_param)
                    {
                        var return_v = this_param.FileSystem;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 3988, 4043);
                        return return_v;
                    }


                    System.Management.Automation.PathInfo
                    f_1310_3964_4044(System.Management.Automation.PathIntrinsics
                    this_param, string
                    providerName)
                    {
                        var return_v = this_param.CurrentProviderLocation(providerName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 3964, 4044);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 3666, 4071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 3666, 4071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PathInfo SetLocation(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 5356, 5723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 5421, 5582);

                f_1310_5421_5581(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 5673, 5712);

                return f_1310_5680_5711(_sessionState, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 5356, 5723);

                int
                f_1310_5421_5581(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 5421, 5581);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1310_5680_5711(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.SetLocation(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 5680, 5711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 5356, 5723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 5356, 5723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo SetLocation(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 7127, 7536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 7225, 7386);

                f_1310_7225_7385(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 7477, 7525);

                return f_1310_7484_7524(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 7127, 7536);

                int
                f_1310_7225_7385(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 7225, 7385);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1310_7484_7524(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.SetLocation(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 7484, 7524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 7127, 7536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 7127, 7536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PathInfo SetLocation(string path, CmdletProviderContext context, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 9056, 9496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 9172, 9333);

                f_1310_9172_9332(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 9424, 9485);

                return f_1310_9431_9484(_sessionState, path, context, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 9056, 9496);

                int
                f_1310_9172_9332(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 9172, 9332);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1310_9431_9484(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                literalPath)
                {
                    var return_v = this_param.SetLocation(path, context, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 9431, 9484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 9056, 9496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 9056, 9496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsCurrentLocationOrAncestor(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 11472, 11909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 11582, 11743);

                f_1310_11582_11742(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 11834, 11898);

                return f_1310_11841_11897(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 11472, 11909);

                int
                f_1310_11582_11742(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 11582, 11742);
                    return 0;
                }


                bool
                f_1310_11841_11897(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsCurrentLocationOrAncestor(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 11841, 11897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 11472, 11909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 11472, 11909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void PushCurrentLocation(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 12188, 12495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 12262, 12423);

                f_1310_12262_12422(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 12439, 12484);

                f_1310_12439_12483(
                            _sessionState, stackName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 12188, 12495);

                int
                f_1310_12262_12422(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 12262, 12422);
                    return 0;
                }


                int
                f_1310_12439_12483(System.Management.Automation.SessionStateInternal
                this_param, string
                stackName)
                {
                    this_param.PushCurrentLocation(stackName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 12439, 12483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 12188, 12495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 12188, 12495);
            }
        }

        public PathInfo PopLocation(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 13878, 14180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 13948, 14109);

                f_1310_13948_14108(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 14125, 14169);

                return f_1310_14132_14168(_sessionState, stackName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 13878, 14180);

                int
                f_1310_13948_14108(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 13948, 14108);
                    return 0;
                }


                System.Management.Automation.PathInfo
                f_1310_14132_14168(System.Management.Automation.SessionStateInternal
                this_param, string
                stackName)
                {
                    var return_v = this_param.PopLocation(stackName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 14132, 14168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 13878, 14180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 13878, 14180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PathInfoStack LocationStack(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 14431, 14742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 14508, 14669);

                f_1310_14508_14668(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 14685, 14731);

                return f_1310_14692_14730(_sessionState, stackName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 14431, 14742);

                int
                f_1310_14508_14668(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 14508, 14668);
                    return 0;
                }


                System.Management.Automation.PathInfoStack
                f_1310_14692_14730(System.Management.Automation.SessionStateInternal
                this_param, string
                stackName)
                {
                    var return_v = this_param.LocationStack(stackName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 14692, 14730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 14431, 14742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 14431, 14742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PathInfoStack SetDefaultLocationStack(string stackName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 15179, 15510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 15266, 15427);

                f_1310_15266_15426(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 15443, 15499);

                return f_1310_15450_15498(_sessionState, stackName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 15179, 15510);

                int
                f_1310_15266_15426(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 15266, 15426);
                    return 0;
                }


                System.Management.Automation.PathInfoStack
                f_1310_15450_15498(System.Management.Automation.SessionStateInternal
                this_param, string
                stackName)
                {
                    var return_v = this_param.SetDefaultLocationStack(stackName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 15450, 15498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 15179, 15510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 15179, 15510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PathInfo> GetResolvedPSPathFromPSPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 17335, 17659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 17497, 17545);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 17559, 17648);

                return f_1310_17566_17647(f_1310_17566_17578(), path, false, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 17335, 17659);

                System.Management.Automation.LocationGlobber
                f_1310_17566_17578()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 17566, 17578);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1310_17566_17647(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 17566, 17647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 17335, 17659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 17335, 17659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PathInfo> GetResolvedPSPathFromPSPath(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 19433, 19826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 19655, 19703);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 19717, 19815);

                return f_1310_19724_19814(f_1310_19724_19736(), path, false, context, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 19433, 19826);

                System.Management.Automation.LocationGlobber
                f_1310_19724_19736()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 19724, 19736);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1310_19724_19814(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 19724, 19814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 19433, 19826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 19433, 19826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetResolvedProviderPathFromPSPath(
                    string path,
                    out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 22019, 22418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 22239, 22287);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 22301, 22407);

                return f_1310_22308_22406(f_1310_22308_22320(), path, false, out provider, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 22019, 22418);

                System.Management.Automation.LocationGlobber
                f_1310_22308_22320()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 22308, 22320);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1310_22308_22406(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 22308, 22406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 22019, 22418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 22019, 22418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetResolvedProviderPathFromPSPath(
                    string path,
                    bool allowNonexistingPaths,
                    out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 22430, 22888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 22693, 22741);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 22755, 22877);

                return f_1310_22762_22876(f_1310_22762_22774(), path, allowNonexistingPaths, out provider, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 22430, 22888);

                System.Management.Automation.LocationGlobber
                f_1310_22762_22774()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 22762, 22774);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1310_22762_22876(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 22762, 22876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 22430, 22888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 22430, 22888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetResolvedProviderPathFromPSPath(
                    string path,
                    CmdletProviderContext context,
                    out ProviderInfo provider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 25311, 25767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 25579, 25627);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 25641, 25756);

                return f_1310_25648_25755(f_1310_25648_25660(), path, false, context, out provider, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 25311, 25767);

                System.Management.Automation.LocationGlobber
                f_1310_25648_25660()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 25648, 25660);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1310_25648_25755(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, context, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 25648, 25755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 25311, 25767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 25311, 25767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetResolvedProviderPathFromProviderPath(
                    string path,
                    string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 27526, 27924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 27744, 27792);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 27806, 27913);

                return f_1310_27813_27912(f_1310_27813_27825(), path, false, providerId, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 27526, 27924);

                System.Management.Automation.LocationGlobber
                f_1310_27813_27825()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 27813, 27825);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1310_27813_27912(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, string
                providerId, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromProviderPath(path, allowNonexistingPaths, providerId, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 27813, 27912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 27526, 27924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 27526, 27924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<string> GetResolvedProviderPathFromProviderPath(
                    string path,
                    string providerId,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 29878, 30333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 30144, 30192);

                Provider.CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 30206, 30322);

                return f_1310_30213_30321(f_1310_30213_30225(), path, false, providerId, context, out providerInstance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 29878, 30333);

                System.Management.Automation.LocationGlobber
                f_1310_30213_30225()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 30213, 30225);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1310_30213_30321(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, string
                providerId, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromProviderPath(path, allowNonexistingPaths, providerId, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 30213, 30321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 29878, 30333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 29878, 30333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetUnresolvedProviderPathFromPSPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 32218, 32429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 32376, 32418);

                return f_1310_32383_32417(f_1310_32383_32395(), path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 32218, 32429);

                System.Management.Automation.LocationGlobber
                f_1310_32383_32395()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 32383, 32395);
                    return return_v;
                }


                string
                f_1310_32383_32417(System.Management.Automation.LocationGlobber
                this_param, string
                path)
                {
                    var return_v = this_param.GetProviderPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 32383, 32417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 32218, 32429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 32218, 32429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetUnresolvedProviderPathFromPSPath(
                    string path,
                    out ProviderInfo provider,
                    out PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 34829, 35362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 35006, 35096);

                CmdletProviderContext
                context = f_1310_35038_35095(f_1310_35064_35094(_sessionState))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 35183, 35268);

                string
                result = f_1310_35199_35267(f_1310_35199_35211(), path, context, out provider, out drive)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 35284, 35321);

                f_1310_35284_35320(
                            context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 35337, 35351);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 34829, 35362);

                System.Management.Automation.ExecutionContext
                f_1310_35064_35094(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 35064, 35094);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1310_35038_35095(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 35038, 35095);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1310_35199_35211()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 35199, 35211);
                    return return_v;
                }


                string
                f_1310_35199_35267(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 35199, 35267);
                    return return_v;
                }


                int
                f_1310_35284_35320(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 35284, 35320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 34829, 35362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 34829, 35362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetUnresolvedProviderPathFromPSPath(
                    string path,
                    CmdletProviderContext context,
                    out ProviderInfo provider,
                    out PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 37784, 38165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 38078, 38154);

                return f_1310_38085_38153(f_1310_38085_38097(), path, context, out provider, out drive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 37784, 38165);

                System.Management.Automation.LocationGlobber
                f_1310_38085_38097()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 38085, 38097);
                    return return_v;
                }


                string
                f_1310_38085_38153(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 38085, 38153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 37784, 38165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 37784, 38165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsProviderQualified(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 38810, 39014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 38950, 39003);

                return f_1310_38957_39002(path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 38810, 39014);

                bool
                f_1310_38957_39002(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 38957, 39002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 38810, 39014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 38810, 39014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsPSAbsolute(string path, out string driveName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 39916, 40138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 40071, 40127);

                return f_1310_40078_40126(f_1310_40078_40090(), path, out driveName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 39916, 40138);

                System.Management.Automation.LocationGlobber
                f_1310_40078_40090()
                {
                    var return_v = PathResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 40078, 40090);
                    return return_v;
                }


                bool
                f_1310_40078_40126(System.Management.Automation.LocationGlobber
                this_param, string
                path, out string
                driveName)
                {
                    var return_v = this_param.IsAbsolutePath(path, out driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 40078, 40126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 39916, 40138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 39916, 40138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Combine(string parent, string child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 41448, 41831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 41523, 41684);

                f_1310_41523_41683(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 41775, 41820);

                return f_1310_41782_41819(_sessionState, parent, child);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 41448, 41831);

                int
                f_1310_41523_41683(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 41523, 41683);
                    return 0;
                }


                string
                f_1310_41782_41819(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child)
                {
                    var return_v = this_param.MakePath(parent, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 41782, 41819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 41448, 41831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 41448, 41831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Combine(string parent, string child, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 43234, 43659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 43342, 43503);

                f_1310_43342_43502(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 43594, 43648);

                return f_1310_43601_43647(_sessionState, parent, child, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 43234, 43659);

                int
                f_1310_43342_43502(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 43342, 43502);
                    return 0;
                }


                string
                f_1310_43601_43647(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 43601, 43647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 43234, 43659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 43234, 43659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ParseParent(string path, string root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 44781, 45167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 44857, 45018);

                f_1310_44857_45017(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 45109, 45156);

                return f_1310_45116_45155(_sessionState, path, root);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 44781, 45167);

                int
                f_1310_44857_45017(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 44857, 45017);
                    return 0;
                }


                string
                f_1310_45116_45155(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                root)
                {
                    var return_v = this_param.GetParentPath(path, root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 45116, 45155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 44781, 45167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 44781, 45167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string ParseParent(
                    string path,
                    string root,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 46347, 46822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 46496, 46657);

                f_1310_46496_46656(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 46748, 46811);

                return f_1310_46755_46810(_sessionState, path, root, context, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 46347, 46822);

                int
                f_1310_46496_46656(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 46496, 46656);
                    return 0;
                }


                string
                f_1310_46755_46810(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetParentPath(path, root, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 46755, 46810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 46347, 46822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 46347, 46822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string ParseParent(
                    string path,
                    string root,
                    CmdletProviderContext context,
                    bool useDefaultProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 48265, 48791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 48452, 48613);

                f_1310_48452_48612(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 48704, 48780);

                return f_1310_48711_48779(_sessionState, path, root, context, useDefaultProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 48265, 48791);

                int
                f_1310_48452_48612(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 48452, 48612);
                    return 0;
                }


                string
                f_1310_48711_48779(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetParentPath(path, root, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 48711, 48779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 48265, 48791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 48265, 48791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ParseChildName(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 49973, 50342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 50039, 50200);

                f_1310_50039_50199(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 50291, 50331);

                return f_1310_50298_50330(_sessionState, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 49973, 50342);

                int
                f_1310_50039_50199(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 50039, 50199);
                    return 0;
                }


                string
                f_1310_50298_50330(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.GetChildName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 50298, 50330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 49973, 50342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 49973, 50342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string ParseChildName(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 51575, 52020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 51701, 51862);

                f_1310_51701_51861(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 51953, 52009);

                return f_1310_51960_52008(_sessionState, path, context, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 51575, 52020);

                int
                f_1310_51701_51861(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 51701, 51861);
                    return 0;
                }


                string
                f_1310_51960_52008(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetChildName(path, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 51960, 52008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 51575, 52020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 51575, 52020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string ParseChildName(
                    string path,
                    CmdletProviderContext context,
                    bool useDefaultProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 53516, 54012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 53680, 53841);

                f_1310_53680_53840(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 53932, 54001);

                return f_1310_53939_54000(_sessionState, path, context, useDefaultProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 53516, 54012);

                int
                f_1310_53680_53840(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 53680, 53840);
                    return 0;
                }


                string
                f_1310_53939_54000(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetChildName(path, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 53939, 54000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 53516, 54012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 53516, 54012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string NormalizeRelativePath(string path, string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 55313, 55725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 55403, 55564);

                f_1310_55403_55563(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 55655, 55714);

                return f_1310_55662_55713(_sessionState, path, basePath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 55313, 55725);

                int
                f_1310_55403_55563(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 55403, 55563);
                    return 0;
                }


                string
                f_1310_55662_55713(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 55662, 55713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 55313, 55725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 55313, 55725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string NormalizeRelativePath(
                    string path,
                    string basePath,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 57067, 57561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 57230, 57391);

                f_1310_57230_57390(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 57482, 57550);

                return f_1310_57489_57549(_sessionState, path, basePath, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 57067, 57561);

                int
                f_1310_57230_57390(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 57230, 57390);
                    return 0;
                }


                string
                f_1310_57489_57549(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 57489, 57549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 57067, 57561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 57067, 57561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsValid(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 58845, 59204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 58902, 59063);

                f_1310_58902_59062(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 59154, 59193);

                return f_1310_59161_59192(_sessionState, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 58845, 59204);

                int
                f_1310_58902_59062(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 58902, 59062);
                    return 0;
                }


                bool
                f_1310_59161_59192(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.IsValidPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 59161, 59192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 58845, 59204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 58845, 59204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsValid(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 60536, 60964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 60653, 60814);

                f_1310_60653_60813(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 60905, 60953);

                return f_1310_60912_60952(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 60536, 60964);

                int
                f_1310_60653_60813(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 60653, 60813);
                    return 0;
                }


                bool
                f_1310_60912_60952(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsValidPath(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 60912, 60952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 60536, 60964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 60536, 60964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocationGlobber PathResolver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1310, 61136, 61465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61172, 61341);

                    f_1310_61172_61340(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1310, 61361, 61450);

                    return _pathResolver ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.LocationGlobber>(1310, 61368, 61449) ?? (_pathResolver = f_1310_61402_61448(f_1310_61402_61432(_sessionState))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1310, 61136, 61465);

                    int
                    f_1310_61172_61340(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 61172, 61340);
                        return 0;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1310_61402_61432(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 61402, 61432);
                        return return_v;
                    }


                    System.Management.Automation.LocationGlobber
                    f_1310_61402_61448(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.LocationGlobber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1310, 61402, 61448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1310, 61075, 61476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 61075, 61476);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LocationGlobber _pathResolver;

        private SessionStateInternal _sessionState;

        static PathIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1310, 355, 61621);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1310, 355, 61621);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1310, 355, 61621);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1310, 355, 61621);

        int
        f_1310_629_815(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 629, 815);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1310_1453_1507(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1310, 1453, 1507);
            return return_v;
        }

    }
}

