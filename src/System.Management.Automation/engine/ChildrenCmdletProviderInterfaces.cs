// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class ChildItemCmdletProviderIntrinsics
    {
        private ChildItemCmdletProviderIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1239, 677, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33687, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33734, 33747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 745, 932);

                f_1239_745_931(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1239, 677, 943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 677, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 677, 943);
            }
        }

        internal ChildItemCmdletProviderIntrinsics(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1239, 1209, 1521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33687, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33734, 33747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 1291, 1413) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1239, 1291, 1413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 1343, 1398);

                    throw f_1239_1349_1397("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1239, 1291, 1413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 1429, 1446);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 1460, 1510);

                _sessionState = f_1239_1476_1509(f_1239_1476_1490(cmdlet));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1239, 1209, 1521);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 1209, 1521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 1209, 1521);
            }
        }

        internal ChildItemCmdletProviderIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1239, 1902, 2194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33687, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33734, 33747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 2004, 2138) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1239, 2004, 2138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 2062, 2123);

                    throw f_1239_2068_2122("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1239, 2004, 2138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 2154, 2183);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1239, 1902, 2194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 1902, 2194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 1902, 2194);
            }
        }

        public Collection<PSObject> Get(string path, bool recurse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 4113, 4555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 4196, 4357);

                f_1239_4196_4356(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 4448, 4544);

                return f_1239_4455_4543(_sessionState, new string[] { path }, recurse, uint.MaxValue, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 4113, 4555);

                int
                f_1239_4196_4356(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 4196, 4356);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1239_4455_4543(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetChildItems(paths, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 4455, 4543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 4113, 4555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 4113, 4555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Get(string[] path, bool recurse, uint depth, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 6751, 7218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 6878, 7039);

                f_1239_6878_7038(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 7130, 7207);

                return f_1239_7137_7206(_sessionState, path, recurse, depth, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 6751, 7218);

                int
                f_1239_6878_7038(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 6878, 7038);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1239_7137_7206(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetChildItems(paths, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 7137, 7206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 6751, 7218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 6751, 7218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<PSObject> Get(string[] path, bool recurse, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 9275, 9719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 9390, 9551);

                f_1239_9390_9550(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 9642, 9708);

                return f_1239_9649_9707(this, path, recurse, uint.MaxValue, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 9275, 9719);

                int
                f_1239_9390_9550(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 9390, 9550);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1239_9649_9707(System.Management.Automation.ChildItemCmdletProviderIntrinsics
                this_param, string[]
                path, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.Get(path, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 9649, 9707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 9275, 9719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 9275, 9719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Get(
                    string path,
                    bool recurse,
                    uint depth,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 11725, 12212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 11890, 12051);

                f_1239_11890_12050(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 12142, 12201);

                f_1239_12142_12200(
                            // Parameter validation is done in the session state object

                            _sessionState, path, recurse, depth, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 11725, 12212);

                int
                f_1239_11890_12050(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 11890, 12050);
                    return 0;
                }


                int
                f_1239_12142_12200(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                recurse, uint
                depth, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.GetChildItems(path, recurse, depth, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 12142, 12200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 11725, 12212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 11725, 12212);
            }
        }

        internal object GetChildItemsDynamicParameters(
                    string path,
                    bool recurse,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 13883, 14391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 14052, 14213);

                f_1239_14052_14212(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 14304, 14380);

                return f_1239_14311_14379(_sessionState, path, recurse, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 13883, 14391);

                int
                f_1239_14052_14212(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 14052, 14212);
                    return 0;
                }


                object
                f_1239_14311_14379(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                recurse, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildItemsDynamicParameters(path, recurse, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 14311, 14379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 13883, 14391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 13883, 14391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetNames(
                    string path,
                    ReturnContainers returnContainers,
                    bool recurse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 16521, 17059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 16682, 16843);

                f_1239_16682_16842(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 16934, 17048);

                return f_1239_16941_17047(_sessionState, new string[] { path }, returnContainers, recurse, uint.MaxValue, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 16521, 17059);

                int
                f_1239_16682_16842(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 16682, 16842);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1239_16941_17047(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.ReturnContainers
                returnContainers, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetChildNames(paths, returnContainers, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 16941, 17047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 16521, 17059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 16521, 17059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetNames(
                    string[] path,
                    ReturnContainers returnContainers,
                    bool recurse,
                    bool force,
                    bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 19355, 19865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 19574, 19735);

                f_1239_19574_19734(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 19751, 19854);

                return f_1239_19758_19853(_sessionState, path, returnContainers, recurse, uint.MaxValue, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 19355, 19865);

                int
                f_1239_19574_19734(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 19574, 19734);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1239_19758_19853(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.ReturnContainers
                returnContainers, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetChildNames(paths, returnContainers, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 19758, 19853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 19355, 19865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 19355, 19865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<string> GetNames(
                    string[] path,
                    ReturnContainers returnContainers,
                    bool recurse,
                    uint depth,
                    bool force,
                    bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 22300, 22827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 22544, 22705);

                f_1239_22544_22704(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 22721, 22816);

                return f_1239_22728_22815(_sessionState, path, returnContainers, recurse, depth, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 22300, 22827);

                int
                f_1239_22544_22704(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 22544, 22704);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1239_22728_22815(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.ReturnContainers
                returnContainers, bool
                recurse, uint
                depth, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetChildNames(paths, returnContainers, recurse, depth, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 22728, 22815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 22300, 22827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 22300, 22827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetNames(
                    string path,
                    ReturnContainers returnContainers,
                    bool recurse,
                    uint depth,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 25077, 25635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 25295, 25456);

                f_1239_25295_25455(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 25547, 25624);

                f_1239_25547_25623(
                            // Parameter validation is done in the session state object

                            _sessionState, path, returnContainers, recurse, depth, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 25077, 25635);

                int
                f_1239_25295_25455(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 25295, 25455);
                    return 0;
                }


                int
                f_1239_25547_25623(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.ReturnContainers
                returnContainers, bool
                recurse, uint
                depth, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.GetChildNames(path, returnContainers, recurse, depth, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 25547, 25623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 25077, 25635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 25077, 25635);
            }
        }

        internal object GetChildNamesDynamicParameters(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 27059, 27531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 27201, 27362);

                f_1239_27201_27361(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 27453, 27520);

                return f_1239_27460_27519(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 27059, 27531);

                int
                f_1239_27201_27361(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 27201, 27361);
                    return 0;
                }


                object
                f_1239_27460_27519(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildNamesDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 27460, 27519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 27059, 27531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 27059, 27531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasChild(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 29063, 29439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 29121, 29282);

                f_1239_29121_29281(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 29373, 29428);

                return f_1239_29380_29427(_sessionState, path, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 29063, 29439);

                int
                f_1239_29121_29281(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 29121, 29281);
                    return 0;
                }


                bool
                f_1239_29380_29427(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.HasChildItems(path, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 29380, 29427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 29063, 29439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 29063, 29439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasChild(string path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 31130, 31542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 31218, 31379);

                f_1239_31218_31378(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 31470, 31531);

                return f_1239_31477_31530(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 31130, 31542);

                int
                f_1239_31218_31378(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 31218, 31378);
                    return 0;
                }


                bool
                f_1239_31477_31530(System.Management.Automation.SessionStateInternal
                this_param, string
                path, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.HasChildItems(path, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 31477, 31530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 31130, 31542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 31130, 31542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasChild(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1239, 33124, 33555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33242, 33403);

                f_1239_33242_33402(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1239, 33494, 33544);

                return f_1239_33501_33543(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1239, 33124, 33555);

                int
                f_1239_33242_33402(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 33242, 33402);
                    return 0;
                }


                bool
                f_1239_33501_33543(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.HasChildItems(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 33501, 33543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1239, 33124, 33555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 33124, 33555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cmdlet _cmdlet;

        private SessionStateInternal _sessionState;

        static ChildItemCmdletProviderIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1239, 433, 33790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1239, 433, 33790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1239, 433, 33790);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1239, 433, 33790);

        int
        f_1239_745_931(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 745, 931);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1239_1349_1397(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 1349, 1397);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1239_1476_1490(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1239, 1476, 1490);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1239_1476_1509(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1239, 1476, 1509);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1239_2068_2122(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1239, 2068, 2122);
            return return_v;
        }

    }

    /// <summary>
    /// This enum determines which types of containers are returned from some of
    /// the provider methods.
    /// </summary>
    public enum ReturnContainers
    {
        /// <summary>
        /// Only containers that match the filter(s) are returned.
        /// </summary>
        ReturnMatchingContainers,

        /// <summary>
        /// All containers are returned even if they don't match the filter(s).
        /// </summary>
        ReturnAllContainers
    }
}

