// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class ItemCmdletProviderIntrinsics
    {
        private ItemCmdletProviderIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1285, 668, 929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89046, 89053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89093, 89106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 731, 918);

                f_1285_731_917(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1285, 668, 929);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 668, 929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 668, 929);
            }
        }

        internal ItemCmdletProviderIntrinsics(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1285, 1284, 1591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89046, 89053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89093, 89106);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 1361, 1483) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1285, 1361, 1483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 1413, 1468);

                    throw f_1285_1419_1467("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1285, 1361, 1483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 1499, 1516);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 1530, 1580);

                _sessionState = f_1285_1546_1579(f_1285_1546_1560(cmdlet));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1285, 1284, 1591);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 1284, 1591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 1284, 1591);
            }
        }

        internal ItemCmdletProviderIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1285, 1978, 2265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89046, 89053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 89093, 89106);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 2075, 2209) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1285, 2075, 2209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 2133, 2194);

                    throw f_1285_2139_2193("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1285, 2075, 2209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 2225, 2254);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1285, 1978, 2265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 1978, 2265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 1978, 2265);
            }
        }

        public Collection<PSObject> Get(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 3754, 4152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 3823, 3984);

                f_1285_3823_3983(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 4075, 4141);

                return f_1285_4082_4140(_sessionState, new string[] { path }, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 3754, 4152);

                int
                f_1285_3823_3983(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 3823, 3983);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_4082_4140(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetItem(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 4082, 4140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 3754, 4152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 3754, 4152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Get(string[] path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 5784, 6203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 5885, 6046);

                f_1285_5885_6045(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 6137, 6192);

                return f_1285_6144_6191(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 5784, 6203);

                int
                f_1285_5885_6045(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 5885, 6045);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_6144_6191(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetItem(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 6144, 6191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 5784, 6203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 5784, 6203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Get(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 7751, 8154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 7837, 7998);

                f_1285_7837_7997(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 8089, 8143);

                f_1285_8089_8142(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 7751, 8154);

                int
                f_1285_7837_7997(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 7837, 7997);
                    return 0;
                }


                int
                f_1285_8089_8142(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.GetItem(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 8089, 8142);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 7751, 8154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 7751, 8154);
            }
        }

        internal object GetItemDynamicParameters(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 9567, 10000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 9676, 9837);

                f_1285_9676_9836(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 9928, 9989);

                return f_1285_9935_9988(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 9567, 10000);

                int
                f_1285_9676_9836(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 9676, 9836);
                    return 0;
                }


                object
                f_1285_9935_9988(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetItemDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 9935, 9988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 9567, 10000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 9567, 10000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Set(string path, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 11552, 11971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 11635, 11796);

                f_1285_11635_11795(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 11887, 11960);

                return f_1285_11894_11959(_sessionState, new string[] { path }, value, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 11552, 11971);

                int
                f_1285_11635_11795(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 11635, 11795);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_11894_11959(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, object
                value, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.SetItem(paths, value, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 11894, 11959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 11552, 11971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 11552, 11971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Set(string[] path, object value, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 13701, 14141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 13816, 13977);

                f_1285_13816_13976(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 14068, 14130);

                return f_1285_14075_14129(_sessionState, path, value, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 13701, 14141);

                int
                f_1285_13816_13976(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 13816, 13976);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_14075_14129(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, object
                value, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.SetItem(paths, value, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 14075, 14129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 13701, 14141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 13701, 14141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Set(string path, object value, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 15791, 16215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 15891, 16052);

                f_1285_15891_16051(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 16143, 16204);

                f_1285_16143_16203(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, value, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 15791, 16215);

                int
                f_1285_15891_16051(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 15891, 16051);
                    return 0;
                }


                int
                f_1285_16143_16203(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, object
                value, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.SetItem(paths, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 16143, 16203);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 15791, 16215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 15791, 16215);
            }
        }

        internal object SetItemDynamicParameters(
                    string path,
                    object value,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 17746, 18240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 17909, 18070);

                f_1285_17909_18069(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 18161, 18229);

                return f_1285_18168_18228(_sessionState, path, value, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 17746, 18240);

                int
                f_1285_17909_18069(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 17909, 18069);
                    return 0;
                }


                object
                f_1285_18168_18228(System.Management.Automation.SessionStateInternal
                this_param, string
                path, object
                value, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.SetItemDynamicParameters(path, value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 18168, 18228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 17746, 18240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 17746, 18240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Clear(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 19699, 20101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 19770, 19931);

                f_1285_19770_19930(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 20022, 20090);

                return f_1285_20029_20089(_sessionState, new string[] { path }, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 19699, 20101);

                int
                f_1285_19770_19930(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 19770, 19930);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_20029_20089(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.ClearItem(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 20029, 20089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 19699, 20101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 19699, 20101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Clear(string[] path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 21732, 22155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 21835, 21996);

                f_1285_21835_21995(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 22087, 22144);

                return f_1285_22094_22143(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 21732, 22155);

                int
                f_1285_21835_21995(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 21835, 21995);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_22094_22143(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.ClearItem(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 22094, 22143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 21732, 22155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 21732, 22155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Clear(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 23715, 24122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 23803, 23964);

                f_1285_23803_23963(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 24055, 24111);

                f_1285_24055_24110(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 23715, 24122);

                int
                f_1285_23803_23963(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 23803, 23963);
                    return 0;
                }


                int
                f_1285_24055_24110(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.ClearItem(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 24055, 24110);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 23715, 24122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 23715, 24122);
            }
        }

        internal object ClearItemDynamicParameters(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 25537, 25974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 25648, 25809);

                f_1285_25648_25808(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 25900, 25963);

                return f_1285_25907_25962(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 25537, 25974);

                int
                f_1285_25648_25808(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 25648, 25808);
                    return 0;
                }


                object
                f_1285_25907_25962(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ClearItemDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 25907, 25962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 25537, 25974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 25537, 25974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Invoke(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 27364, 27747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 27420, 27581);

                f_1285_27420_27580(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 27672, 27736);

                f_1285_27672_27735(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 27364, 27747);

                int
                f_1285_27420_27580(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 27420, 27580);
                    return 0;
                }


                int
                f_1285_27672_27735(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                literalPath)
                {
                    this_param.InvokeDefaultAction(paths, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 27672, 27735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 27364, 27747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 27364, 27747);
            }
        }

        public void Invoke(string[] path, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 29194, 29586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 29270, 29431);

                f_1285_29270_29430(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 29522, 29575);

                f_1285_29522_29574(
                            // Parameter validation is done in the session state object

                            _sessionState, path, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 29194, 29586);

                int
                f_1285_29270_29430(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 29270, 29430);
                    return 0;
                }


                int
                f_1285_29522_29574(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                literalPath)
                {
                    this_param.InvokeDefaultAction(paths, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 29522, 29574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 29194, 29586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 29194, 29586);
            }
        }

        internal void Invoke(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 31029, 31447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 31118, 31279);

                f_1285_31118_31278(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 31370, 31436);

                f_1285_31370_31435(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 31029, 31447);

                int
                f_1285_31118_31278(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 31118, 31278);
                    return 0;
                }


                int
                f_1285_31370_31435(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.InvokeDefaultAction(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 31370, 31435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 31029, 31447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 31029, 31447);
            }
        }

        internal object InvokeItemDynamicParameters(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 32863, 33311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 32975, 33136);

                f_1285_32975_33135(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 33227, 33300);

                return f_1285_33234_33299(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 32863, 33311);

                int
                f_1285_32975_33135(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 32975, 33135);
                    return 0;
                }


                object
                f_1285_33234_33299(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.InvokeDefaultActionDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 33234, 33299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 32863, 33311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 32863, 33311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Rename(string path, string newName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 34902, 35307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 34990, 35151);

                f_1285_34990_35150(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 35242, 35296);

                return f_1285_35249_35295(_sessionState, path, newName, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 34902, 35307);

                int
                f_1285_34990_35150(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 34990, 35150);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_35249_35295(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                newName, bool
                force)
                {
                    var return_v = this_param.RenameItem(path, newName, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 35249, 35295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 34902, 35307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 34902, 35307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Rename(string path, string newName, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 36939, 37356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 37039, 37200);

                f_1285_37039_37199(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 37291, 37345);

                return f_1285_37298_37344(_sessionState, path, newName, force);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 36939, 37356);

                int
                f_1285_37039_37199(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 37039, 37199);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_37298_37344(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                newName, bool
                force)
                {
                    var return_v = this_param.RenameItem(path, newName, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 37298, 37344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 36939, 37356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 36939, 37356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Rename(
                    string path,
                    string newName,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 39030, 39487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 39175, 39336);

                f_1285_39175_39335(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 39427, 39476);

                f_1285_39427_39475(
                            // Parameter validation is done in the session state object

                            _sessionState, path, newName, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 39030, 39487);

                int
                f_1285_39175_39335(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 39175, 39335);
                    return 0;
                }


                int
                f_1285_39427_39475(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                newName, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RenameItem(path, newName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 39427, 39475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 39030, 39487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 39030, 39487);
            }
        }

        internal object RenameItemDynamicParameters(
                    string path,
                    string newName,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 41000, 41504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 41168, 41329);

                f_1285_41168_41328(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 41420, 41493);

                return f_1285_41427_41492(_sessionState, path, newName, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 41000, 41504);

                int
                f_1285_41168_41328(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 41168, 41328);
                    return 0;
                }


                object
                f_1285_41427_41492(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                newName, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.RenameItemDynamicParameters(path, newName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 41427, 41492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 41000, 41504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 41000, 41504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> New(
                    string path,
                    string name,
                    string itemTypeName,
                    object content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 43323, 43846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 43495, 43656);

                f_1285_43495_43655(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 43747, 43835);

                return f_1285_43754_43834(_sessionState, new string[] { path }, name, itemTypeName, content, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 43323, 43846);

                int
                f_1285_43495_43655(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 43495, 43655);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_43754_43834(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                name, string
                type, object
                content, bool
                force)
                {
                    var return_v = this_param.NewItem(paths, name, type, content, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 43754, 43834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 43323, 43846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 43323, 43846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> New(
                    string[] path,
                    string name,
                    string itemTypeName,
                    object content,
                    bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 45724, 46257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 45923, 46084);

                f_1285_45923_46083(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 46175, 46246);

                return f_1285_46182_46245(_sessionState, path, name, itemTypeName, content, force);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 45724, 46257);

                int
                f_1285_45923_46083(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 45923, 46083);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_46182_46245(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                name, string
                type, object
                content, bool
                force)
                {
                    var return_v = this_param.NewItem(paths, name, type, content, force);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 46182, 46245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 45724, 46257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 45724, 46257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void New(
                    string path,
                    string name,
                    string type,
                    object content,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 48150, 48682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 48344, 48505);

                f_1285_48344_48504(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 48596, 48671);

                f_1285_48596_48670(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, name, type, content, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 48150, 48682);

                int
                f_1285_48344_48504(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 48344, 48504);
                    return 0;
                }


                int
                f_1285_48596_48670(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                name, string
                type, object
                content, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.NewItem(paths, name, type, content, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 48596, 48670);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 48150, 48682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 48150, 48682);
            }
        }

        internal object NewItemDynamicParameters(
                    string path,
                    string type,
                    object content,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 50309, 50839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 50500, 50661);

                f_1285_50500_50660(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 50752, 50828);

                return f_1285_50759_50827(_sessionState, path, type, content, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 50309, 50839);

                int
                f_1285_50500_50660(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 50500, 50660);
                    return 0;
                }


                object
                f_1285_50759_50827(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                type, object
                newItemValue, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NewItemDynamicParameters(path, type, newItemValue, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 50759, 50827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 50309, 50839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 50309, 50839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Remove(string path, bool recurse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 52452, 52856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 52522, 52683);

                f_1285_52522_52682(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 52774, 52845);

                f_1285_52774_52844(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, recurse, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 52452, 52856);

                int
                f_1285_52522_52682(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 52522, 52682);
                    return 0;
                }


                int
                f_1285_52774_52844(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, bool
                force, bool
                literalPath)
                {
                    this_param.RemoveItem(paths, recurse, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 52774, 52844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 52452, 52856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 52452, 52856);
            }
        }

        public void Remove(string[] path, bool recurse, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 54644, 55069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 54746, 54907);

                f_1285_54746_54906(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 54998, 55058);

                f_1285_54998_55057(
                            // Parameter validation is done in the session state object

                            _sessionState, path, recurse, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 54644, 55069);

                int
                f_1285_54746_54906(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 54746, 54906);
                    return 0;
                }


                int
                f_1285_54998_55057(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, bool
                force, bool
                literalPath)
                {
                    this_param.RemoveItem(paths, recurse, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 54998, 55057);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 54644, 55069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 54644, 55069);
            }
        }

        internal void Remove(
                    string path,
                    bool recurse,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 56612, 57084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 56755, 56916);

                f_1285_56755_56915(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 57007, 57073);

                f_1285_57007_57072(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, recurse, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 56612, 57084);

                int
                f_1285_56755_56915(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 56755, 56915);
                    return 0;
                }


                int
                f_1285_57007_57072(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RemoveItem(paths, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 57007, 57072);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 56612, 57084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 56612, 57084);
            }
        }

        internal object RemoveItemDynamicParameters(
                    string path,
                    bool recurse,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 58759, 59261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 58925, 59086);

                f_1285_58925_59085(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 59177, 59250);

                return f_1285_59184_59249(_sessionState, path, recurse, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 58759, 59261);

                int
                f_1285_58925_59085(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 58925, 59085);
                    return 0;
                }


                object
                f_1285_59184_59249(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.RemoveItemDynamicParameters(path, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 59184, 59249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 58759, 59261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 58759, 59261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Copy(
                    string path,
                    string destinationPath,
                    bool recurse,
                    CopyContainers copyContainers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 61167, 61731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 61359, 61520);

                f_1285_61359_61519(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 61611, 61720);

                return f_1285_61618_61719(_sessionState, new string[] { path }, destinationPath, recurse, copyContainers, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 61167, 61731);

                int
                f_1285_61359_61519(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 61359, 61519);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_61618_61719(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                copyPath, bool
                recurse, System.Management.Automation.CopyContainers
                copyContainers, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.CopyItem(paths, copyPath, recurse, copyContainers, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 61618, 61719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 61167, 61731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 61167, 61731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Copy(
                    string[] path,
                    string destinationPath,
                    bool recurse,
                    CopyContainers copyContainers,
                    bool force,
                    bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 63812, 64423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 64062, 64223);

                f_1285_64062_64222(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 64314, 64412);

                return f_1285_64321_64411(_sessionState, path, destinationPath, recurse, copyContainers, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 63812, 64423);

                int
                f_1285_64062_64222(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 64062, 64222);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_64321_64411(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                copyPath, bool
                recurse, System.Management.Automation.CopyContainers
                copyContainers, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.CopyItem(paths, copyPath, recurse, copyContainers, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 64321, 64411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 63812, 64423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 63812, 64423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Copy(
                    string path,
                    string destinationPath,
                    bool recurse,
                    CopyContainers copyContainers,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 66423, 67005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 66645, 66806);

                f_1285_66645_66805(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 66897, 66994);

                f_1285_66897_66993(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, destinationPath, recurse, copyContainers, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 66423, 67005);

                int
                f_1285_66645_66805(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 66645, 66805);
                    return 0;
                }


                int
                f_1285_66897_66993(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                copyPath, bool
                recurse, System.Management.Automation.CopyContainers
                copyContainers, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.CopyItem(paths, copyPath, recurse, copyContainers, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 66897, 66993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 66423, 67005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 66423, 67005);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 68737, 69281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 68934, 69095);

                f_1285_68934_69094(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 69186, 69270);

                return f_1285_69193_69269(_sessionState, path, destination, recurse, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 68737, 69281);

                int
                f_1285_68934_69094(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 68934, 69094);
                    return 0;
                }


                object
                f_1285_69193_69269(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                destination, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.CopyItemDynamicParameters(path, destination, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 69193, 69269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 68737, 69281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 68737, 69281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Move(string path, string destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 71231, 71664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 71321, 71482);

                f_1285_71321_71481(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 71573, 71653);

                return f_1285_71580_71652(_sessionState, new string[] { path }, destination, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 71231, 71664);

                int
                f_1285_71321_71481(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 71321, 71481);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_71580_71652(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                destination, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.MoveItem(paths, destination, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 71580, 71652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 71231, 71664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 71231, 71664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Move(string[] path, string destination, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 73786, 74240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 73908, 74069);

                f_1285_73908_74068(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 74160, 74229);

                return f_1285_74167_74228(_sessionState, path, destination, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 73786, 74240);

                int
                f_1285_73908_74068(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 73908, 74068);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1285_74167_74228(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                destination, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.MoveItem(paths, destination, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 74167, 74228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 73786, 74240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 73786, 74240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Move(
                    string path,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 75840, 76318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 75987, 76148);

                f_1285_75987_76147(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 76239, 76307);

                f_1285_76239_76306(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, destination, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 75840, 76318);

                int
                f_1285_75987_76147(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 75987, 76147);
                    return 0;
                }


                int
                f_1285_76239_76306(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.MoveItem(paths, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 76239, 76306);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 75840, 76318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 75840, 76318);
            }
        }

        internal object MoveItemDynamicParameters(
                    string path,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 77837, 78345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 78007, 78168);

                f_1285_78007_78167(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 78259, 78334);

                return f_1285_78266_78333(_sessionState, path, destination, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 77837, 78345);

                int
                f_1285_78007_78167(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 78007, 78167);
                    return 0;
                }


                object
                f_1285_78266_78333(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MoveItemDynamicParameters(path, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 78266, 78333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 77837, 78345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 77837, 78345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Exists(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 79656, 80027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 79712, 79873);

                f_1285_79712_79872(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 79964, 80016);

                return f_1285_79971_80015(_sessionState, path, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 79656, 80027);

                int
                f_1285_79712_79872(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 79712, 79872);
                    return 0;
                }


                bool
                f_1285_79971_80015(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.ItemExists(path, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 79971, 80015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 79656, 80027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 79656, 80027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Exists(string path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 81509, 81916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 81595, 81756);

                f_1285_81595_81755(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 81847, 81905);

                return f_1285_81854_81904(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 81509, 81916);

                int
                f_1285_81595_81755(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 81595, 81755);
                    return 0;
                }


                bool
                f_1285_81854_81904(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.ItemExists(path, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 81854, 81904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 81509, 81916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 81509, 81916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Exists(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 83289, 83715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 83405, 83566);

                f_1285_83405_83565(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 83657, 83704);

                return f_1285_83664_83703(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 83289, 83715);

                int
                f_1285_83405_83565(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 83405, 83565);
                    return 0;
                }


                bool
                f_1285_83664_83703(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExists(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 83664, 83703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 83289, 83715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 83289, 83715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object ItemExistsDynamicParameters(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 85068, 85534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 85207, 85368);

                f_1285_85207_85367(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 85459, 85523);

                return f_1285_85466_85522(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 85068, 85534);

                int
                f_1285_85207_85367(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 85207, 85367);
                    return 0;
                }


                object
                f_1285_85466_85522(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ItemExistsDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 85466, 85522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 85068, 85534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 85068, 85534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsContainer(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 86793, 87160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 86854, 87015);

                f_1285_86854_87014(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 87106, 87149);

                return f_1285_87113_87148(_sessionState, path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 86793, 87160);

                int
                f_1285_86854_87014(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 86854, 87014);
                    return 0;
                }


                bool
                f_1285_87113_87148(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.IsItemContainer(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 87113, 87148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 86793, 87160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 86793, 87160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsContainer(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1285, 88476, 88912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 88597, 88758);

                f_1285_88597_88757(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1285, 88849, 88901);

                return f_1285_88856_88900(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1285, 88476, 88912);

                int
                f_1285_88597_88757(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 88597, 88757);
                    return 0;
                }


                bool
                f_1285_88856_88900(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.IsItemContainer(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 88856, 88900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1285, 88476, 88912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 88476, 88912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cmdlet _cmdlet;

        private SessionStateInternal _sessionState;

        static ItemCmdletProviderIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1285, 429, 89149);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1285, 429, 89149);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1285, 429, 89149);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1285, 429, 89149);

        int
        f_1285_731_917(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 731, 917);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1285_1419_1467(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 1419, 1467);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1285_1546_1560(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1285, 1546, 1560);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1285_1546_1579(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1285, 1546, 1579);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1285_2139_2193(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1285, 2139, 2193);
            return return_v;
        }

    }

    /// <summary>
    /// Determines how the source container of a copy operation
    /// will be used.
    /// </summary>
    public enum CopyContainers
    {
        /// <summary>
        /// The source container is copied.
        /// </summary>
        CopyTargetContainer,

        /// <summary>
        /// The children of the source container are copied.
        /// </summary>
        CopyChildrenOfTargetContainer
    }
}

