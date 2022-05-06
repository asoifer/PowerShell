// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class ContentCmdletProviderIntrinsics
    {
        private ContentCmdletProviderIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1257, 721, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24649, 24656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24696, 24709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 787, 974);

                f_1257_787_973(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1257, 721, 985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 721, 985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 721, 985);
            }
        }

        internal ContentCmdletProviderIntrinsics(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1257, 1340, 1650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24649, 24656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24696, 24709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 1420, 1542) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1257, 1420, 1542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 1472, 1527);

                    throw f_1257_1478_1526("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1257, 1420, 1542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 1558, 1575);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 1589, 1639);

                _sessionState = f_1257_1605_1638(f_1257_1605_1619(cmdlet));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1257, 1340, 1650);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 1340, 1650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 1340, 1650);
            }
        }

        internal ContentCmdletProviderIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1257, 2023, 2313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24649, 24656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24696, 24709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 2123, 2257) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1257, 2123, 2257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 2181, 2242);

                    throw f_1257_2187_2241("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1257, 2123, 2257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 2273, 2302);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1257, 2023, 2313);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 2023, 2313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 2023, 2313);
            }
        }

        public Collection<IContentReader> GetReader(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 3782, 4201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 3863, 4024);

                f_1257_3863_4023(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 4115, 4190);

                return f_1257_4122_4189(_sessionState, new string[] { path }, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 3782, 4201);

                int
                f_1257_3863_4023(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 3863, 4023);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1257_4122_4189(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetContentReader(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 4122, 4189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 3782, 4201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 3782, 4201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<IContentReader> GetReader(string[] path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 5799, 6239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 5912, 6073);

                f_1257_5912_6072(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 6164, 6228);

                return f_1257_6171_6227(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 5799, 6239);

                int
                f_1257_5912_6072(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 5912, 6072);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1257_6171_6227(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetContentReader(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 6171, 6227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 5799, 6239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 5799, 6239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<IContentReader> GetReader(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 7452, 7926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 7593, 7754);

                f_1257_7593_7753(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 7845, 7915);

                return f_1257_7852_7914(_sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 7452, 7926);

                int
                f_1257_7593_7753(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 7593, 7753);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentReader>
                f_1257_7852_7914(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentReader(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 7852, 7914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 7452, 7926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 7452, 7926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetContentReaderDynamicParameters(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 9342, 9820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 9487, 9648);

                f_1257_9487_9647(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 9739, 9809);

                return f_1257_9746_9808(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 9342, 9820);

                int
                f_1257_9487_9647(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 9487, 9647);
                    return 0;
                }


                object
                f_1257_9746_9808(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentReaderDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 9746, 9808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 9342, 9820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 9342, 9820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<IContentWriter> GetWriter(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 11265, 11684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 11346, 11507);

                f_1257_11346_11506(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 11598, 11673);

                return f_1257_11605_11672(_sessionState, new string[] { path }, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 11265, 11684);

                int
                f_1257_11346_11506(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 11346, 11506);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1257_11605_11672(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetContentWriter(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 11605, 11672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 11265, 11684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 11265, 11684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<IContentWriter> GetWriter(string[] path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 13285, 13725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 13398, 13559);

                f_1257_13398_13558(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 13650, 13714);

                return f_1257_13657_13713(_sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 13285, 13725);

                int
                f_1257_13398_13558(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 13398, 13558);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1257_13657_13713(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    var return_v = this_param.GetContentWriter(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 13657, 13713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 13285, 13725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 13285, 13725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<IContentWriter> GetWriter(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 14938, 15412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 15079, 15240);

                f_1257_15079_15239(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 15331, 15401);

                return f_1257_15338_15400(_sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 14938, 15412);

                int
                f_1257_15079_15239(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 15079, 15239);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Provider.IContentWriter>
                f_1257_15338_15400(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentWriter(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 15338, 15400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 14938, 15412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 14938, 15412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetContentWriterDynamicParameters(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 16844, 17322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 16989, 17150);

                f_1257_16989_17149(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 17241, 17311);

                return f_1257_17248_17310(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 16844, 17322);

                int
                f_1257_16989_17149(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 16989, 17149);
                    return 0;
                }


                object
                f_1257_17248_17310(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetContentWriterDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 17248, 17310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 16844, 17322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 16844, 17322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Clear(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 18637, 19019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 18692, 18853);

                f_1257_18692_18852(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 18944, 19008);

                f_1257_18944_19007(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, false, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 18637, 19019);

                int
                f_1257_18692_18852(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 18692, 18852);
                    return 0;
                }


                int
                f_1257_18944_19007(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    this_param.ClearContent(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 18944, 19007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 18637, 19019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 18637, 19019);
            }
        }

        public void Clear(string[] path, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 20494, 20897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 20581, 20742);

                f_1257_20581_20741(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 20833, 20886);

                f_1257_20833_20885(
                            // Parameter validation is done in the session state object

                            _sessionState, path, force, literalPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 20494, 20897);

                int
                f_1257_20581_20741(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 20581, 20741);
                    return 0;
                }


                int
                f_1257_20833_20885(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, bool
                force, bool
                literalPath)
                {
                    this_param.ClearContent(paths, force, literalPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 20833, 20885);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 20494, 20897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 20494, 20897);
            }
        }

        internal void Clear(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 22247, 22657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 22335, 22496);

                f_1257_22335_22495(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 22587, 22646);

                f_1257_22587_22645(
                            // Parameter validation is done in the session state object

                            _sessionState, new string[] { path }, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 22247, 22657);

                int
                f_1257_22335_22495(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 22335, 22495);
                    return 0;
                }


                int
                f_1257_22587_22645(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.ClearContent(paths, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 22587, 22645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 22247, 22657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 22247, 22657);
            }
        }

        internal object ClearContentDynamicParameters(string path, CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1257, 24075, 24518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24189, 24350);

                f_1257_24189_24349(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1257, 24441, 24507);

                return f_1257_24448_24506(_sessionState, path, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1257, 24075, 24518);

                int
                f_1257_24189_24349(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 24189, 24349);
                    return 0;
                }


                object
                f_1257_24448_24506(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.ClearContentDynamicParameters(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 24448, 24506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1257, 24075, 24518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 24075, 24518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cmdlet _cmdlet;

        private SessionStateInternal _sessionState;

        static ContentCmdletProviderIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1257, 479, 24752);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1257, 479, 24752);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1257, 479, 24752);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1257, 479, 24752);

        int
        f_1257_787_973(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 787, 973);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1257_1478_1526(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 1478, 1526);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1257_1605_1619(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1257, 1605, 1619);
            return return_v;
        }


        System.Management.Automation.SessionStateInternal
        f_1257_1605_1638(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineSessionState;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1257, 1605, 1638);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1257_2187_2241(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1257, 2187, 2241);
            return return_v;
        }

    }
}

