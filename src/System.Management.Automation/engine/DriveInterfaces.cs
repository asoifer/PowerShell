// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class DriveManagementIntrinsics
    {
        private DriveManagementIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1264, 666, 924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 15383, 15396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 726, 913);

                f_1264_726_912(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1264, 666, 924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 666, 924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 666, 924);
            }
        }

        internal DriveManagementIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1264, 1296, 1580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 15383, 15396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 1390, 1524) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1264, 1390, 1524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 1448, 1509);

                    throw f_1264_1454_1508("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1264, 1390, 1524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 1540, 1569);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1264, 1296, 1580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 1296, 1580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 1296, 1580);
            }
        }

        public PSDriveInfo Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 1983, 2257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 2019, 2188);

                    f_1264_2019_2187(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 2208, 2242);

                    return f_1264_2215_2241(_sessionState);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 1983, 2257);

                    int
                    f_1264_2019_2187(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 2019, 2187);
                        return 0;
                    }


                    System.Management.Automation.PSDriveInfo
                    f_1264_2215_2241(System.Management.Automation.SessionStateInternal
                    this_param)
                    {
                        var return_v = this_param.CurrentDrive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1264, 2215, 2241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 1932, 2268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 1932, 2268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSDriveInfo New(PSDriveInfo drive, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 3758, 4145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 3838, 3999);

                f_1264_3838_3998(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 4090, 4134);

                return f_1264_4097_4133(_sessionState, drive, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 3758, 4145);

                int
                f_1264_3838_3998(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 3838, 3998);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1264_4097_4133(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSDriveInfo
                drive, string
                scopeID)
                {
                    var return_v = this_param.NewDrive(drive, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 4097, 4133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 3758, 4145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 3758, 4145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void New(
                    PSDriveInfo drive,
                    string scope,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 5795, 6250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 5941, 6102);

                f_1264_5941_6101(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 6193, 6239);

                f_1264_6193_6238(
                            // Parameter validation is done in the session state object

                            _sessionState, drive, scope, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 5795, 6250);

                int
                f_1264_5941_6101(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 5941, 6101);
                    return 0;
                }


                int
                f_1264_6193_6238(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSDriveInfo
                drive, string
                scopeID, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.NewDrive(drive, scopeID, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 6193, 6238);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 5795, 6250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 5795, 6250);
            }
        }

        internal object NewDriveDynamicParameters(
                    string providerId,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 7169, 7643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 7312, 7473);

                f_1264_7312_7472(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 7564, 7632);

                return f_1264_7571_7631(_sessionState, providerId, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 7169, 7643);

                int
                f_1264_7312_7472(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 7312, 7472);
                    return 0;
                }


                object
                f_1264_7571_7631(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NewDriveDynamicParameters(providerId, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 7571, 7631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 7169, 7643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 7169, 7643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Remove(string driveName, bool force, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 8412, 8813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 8499, 8660);

                f_1264_8499_8659(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 8751, 8802);

                f_1264_8751_8801(
                            // Parameter validation is done in the session state object

                            _sessionState, driveName, force, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 8412, 8813);

                int
                f_1264_8499_8659(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 8499, 8659);
                    return 0;
                }


                int
                f_1264_8751_8801(System.Management.Automation.SessionStateInternal
                this_param, string
                driveName, bool
                force, string
                scopeID)
                {
                    this_param.RemoveDrive(driveName, force, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 8751, 8801);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 8412, 8813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 8412, 8813);
            }
        }

        internal void Remove(
                    string driveName,
                    bool force,
                    string scope,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 9650, 10146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 9823, 9984);

                f_1264_9823_9983(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 10075, 10135);

                f_1264_10075_10134(
                            // Parameter validation is done in the session state object

                            _sessionState, driveName, force, scope, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 9650, 10146);

                int
                f_1264_9823_9983(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 9823, 9983);
                    return 0;
                }


                int
                f_1264_10075_10134(System.Management.Automation.SessionStateInternal
                this_param, string
                driveName, bool
                force, string
                scopeID, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RemoveDrive(driveName, force, scopeID, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 10075, 10134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 9650, 10146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 9650, 10146);
            }
        }

        public PSDriveInfo Get(string driveName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 10874, 11243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 10939, 11100);

                f_1264_10939_11099(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 11191, 11232);

                return f_1264_11198_11231(_sessionState, driveName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 10874, 11243);

                int
                f_1264_10939_11099(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 10939, 11099);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1264_11198_11231(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetDrive(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 11198, 11231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 10874, 11243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 10874, 11243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSDriveInfo GetAtScope(string driveName, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 12553, 12950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 12639, 12800);

                f_1264_12639_12799(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 12891, 12939);

                return f_1264_12898_12938(_sessionState, driveName, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 12553, 12950);

                int
                f_1264_12639_12799(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 12639, 12799);
                    return 0;
                }


                System.Management.Automation.PSDriveInfo
                f_1264_12898_12938(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID)
                {
                    var return_v = this_param.GetDrive(name, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 12898, 12938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 12553, 12950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 12553, 12950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSDriveInfo> GetAll()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 13071, 13357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 13135, 13296);

                f_1264_13135_13295(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 13312, 13346);

                return f_1264_13319_13345(_sessionState, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 13071, 13357);

                int
                f_1264_13135_13295(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 13135, 13295);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1264_13319_13345(System.Management.Automation.SessionStateInternal
                this_param, string
                scope)
                {
                    var return_v = this_param.Drives(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 13319, 13345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 13071, 13357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 13071, 13357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSDriveInfo> GetAllAtScope(string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 14085, 14391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 14168, 14329);

                f_1264_14168_14328(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 14345, 14380);

                return f_1264_14352_14379(_sessionState, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 14085, 14391);

                int
                f_1264_14168_14328(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 14168, 14328);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1264_14352_14379(System.Management.Automation.SessionStateInternal
                this_param, string
                scope)
                {
                    var return_v = this_param.Drives(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 14352, 14379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 14085, 14391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 14085, 14391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSDriveInfo> GetAllForProvider(string providerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1264, 14752, 15165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 14846, 15007);

                f_1264_14846_15006(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1264, 15098, 15154);

                return f_1264_15105_15153(_sessionState, providerName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1264, 14752, 15165);

                int
                f_1264_14846_15006(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 14846, 15006);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSDriveInfo>
                f_1264_15105_15153(System.Management.Automation.SessionStateInternal
                this_param, string
                providerId)
                {
                    var return_v = this_param.GetDrivesForProvider(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 15105, 15153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1264, 14752, 15165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 14752, 15165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SessionStateInternal _sessionState;

        static DriveManagementIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1264, 430, 15439);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1264, 430, 15439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1264, 430, 15439);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1264, 430, 15439);

        int
        f_1264_726_912(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 726, 912);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1264_1454_1508(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1264, 1454, 1508);
            return return_v;
        }

    }
}

