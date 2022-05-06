// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public sealed class PSVariableIntrinsics
    {
        private PSVariableIntrinsics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1374, 529, 782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 18744, 18757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 584, 771);

                f_1374_584_770(false, "This constructor should never be called. Only the constructor that takes an instance of SessionState should be called.");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1374, 529, 782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 529, 782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 529, 782);
            }
        }

        internal PSVariableIntrinsics(SessionStateInternal sessionState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1374, 1154, 1429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 18744, 18757);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 1243, 1373) || true) && (sessionState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1374, 1243, 1373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 1301, 1358);

                    throw f_1374_1307_1357("sessionState");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1374, 1243, 1373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 1389, 1418);

                _sessionState = sessionState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1374, 1154, 1429);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 1154, 1429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 1154, 1429);
            }
        }

        public PSVariable Get(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 2031, 3055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 2090, 2251);

                f_1374_2090_2250(_sessionState != null, "The only constructor for this class should always set the sessionState field");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 2883, 2989) || true) && (name != null && (DynAbs.Tracing.TraceSender.Expression_True(1374, 2887, 2928) && f_1374_2903_2928(name, string.Empty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1374, 2883, 2989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 2962, 2974);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1374, 2883, 2989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 3005, 3044);

                return f_1374_3012_3043(_sessionState, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 2031, 3055);

                int
                f_1374_2090_2250(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 2090, 2250);
                    return 0;
                }


                bool
                f_1374_2903_2928(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 2903, 2928);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1374_3012_3043(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 3012, 3043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 2031, 3055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 2031, 3055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable GetAtScope(string name, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 4265, 4663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 4347, 4508);

                f_1374_4347_4507(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 4599, 4652);

                return f_1374_4606_4651(_sessionState, name, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 4265, 4663);

                int
                f_1374_4347_4507(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 4347, 4507);
                    return 0;
                }


                System.Management.Automation.PSVariable
                f_1374_4606_4651(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID)
                {
                    var return_v = this_param.GetVariableAtScope(name, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 4606, 4651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 4265, 4663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 4265, 4663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 5890, 6257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 5950, 6111);

                f_1374_5950_6110(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 6202, 6246);

                return f_1374_6209_6245(_sessionState, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 5890, 6257);

                int
                f_1374_5950_6110(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 5950, 6110);
                    return 0;
                }


                object
                f_1374_6209_6245(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariableValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 6209, 6245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 5890, 6257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 5890, 6257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetValue(string name, object defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 7753, 8157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 7834, 7995);

                f_1374_7834_7994(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 8086, 8146);

                return f_1374_8093_8129(_sessionState, name) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1374, 8093, 8145) ?? defaultValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 7753, 8157);

                int
                f_1374_7834_7994(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 7834, 7994);
                    return 0;
                }


                object
                f_1374_8093_8129(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetVariableValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 8093, 8129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 7753, 8157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 7753, 8157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetValueAtScope(string name, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 10055, 10459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 10138, 10299);

                f_1374_10138_10298(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 10390, 10448);

                return f_1374_10397_10447(_sessionState, name, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 10055, 10459);

                int
                f_1374_10138_10298(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 10138, 10298);
                    return 0;
                }


                object
                f_1374_10397_10447(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID)
                {
                    var return_v = this_param.GetVariableValueAtScope(name, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 10397, 10447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 10055, 10459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 10055, 10459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Set(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 11836, 12234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 11903, 12064);

                f_1374_11903_12063(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 12155, 12223);

                f_1374_12155_12222(
                            // Parameter validation is done in the session state object

                            _sessionState, name, value, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 11836, 12234);

                int
                f_1374_11903_12063(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 11903, 12063);
                    return 0;
                }


                int
                f_1374_12155_12222(System.Management.Automation.SessionStateInternal
                this_param, string
                name, object
                newValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    this_param.SetVariableValue(name, newValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 12155, 12222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 11836, 12234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 11836, 12234);
            }
        }

        public void Set(PSVariable variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 12703, 13094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 12764, 12925);

                f_1374_12764_12924(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 13016, 13083);

                f_1374_13016_13082(
                            // Parameter validation is done in the session state object

                            _sessionState, variable, false, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 12703, 13094);

                int
                f_1374_12764_12924(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 12764, 12924);
                    return 0;
                }


                object
                f_1374_13016_13082(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, bool
                force, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variable, force, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 13016, 13082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 12703, 13094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 12703, 13094);
            }
        }

        public void Remove(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 14368, 14722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 14424, 14585);

                f_1374_14424_14584(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 14676, 14711);

                f_1374_14676_14710(
                            // Parameter validation is done in the session state object

                            _sessionState, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 14368, 14722);

                int
                f_1374_14424_14584(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 14424, 14584);
                    return 0;
                }


                int
                f_1374_14676_14710(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    this_param.RemoveVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 14676, 14710);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 14368, 14722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 14368, 14722);
            }
        }

        public void Remove(PSVariable variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 15267, 15633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 15331, 15492);

                f_1374_15331_15491(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 15583, 15622);

                f_1374_15583_15621(
                            // Parameter validation is done in the session state object

                            _sessionState, variable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 15267, 15633);

                int
                f_1374_15331_15491(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 15331, 15491);
                    return 0;
                }


                int
                f_1374_15583_15621(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable)
                {
                    this_param.RemoveVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 15583, 15621);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 15267, 15633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 15267, 15633);
            }
        }

        internal void RemoveAtScope(string name, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 16820, 17211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 16899, 17060);

                f_1374_16899_17059(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 17151, 17200);

                f_1374_17151_17199(
                            // Parameter validation is done in the session state object

                            _sessionState, name, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 16820, 17211);

                int
                f_1374_16899_17059(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 16899, 17059);
                    return 0;
                }


                int
                f_1374_17151_17199(System.Management.Automation.SessionStateInternal
                this_param, string
                name, string
                scopeID)
                {
                    this_param.RemoveVariableAtScope(name, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 17151, 17199);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 16820, 17211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 16820, 17211);
            }
        }

        internal void RemoveAtScope(PSVariable variable, string scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1374, 18231, 18634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 18318, 18479);

                f_1374_18318_18478(_sessionState != null, "The only constructor for this class should always set the sessionState field");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1374, 18570, 18623);

                f_1374_18570_18622(
                            // Parameter validation is done in the session state object

                            _sessionState, variable, scope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1374, 18231, 18634);

                int
                f_1374_18318_18478(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 18318, 18478);
                    return 0;
                }


                int
                f_1374_18570_18622(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.PSVariable
                variable, string
                scopeID)
                {
                    this_param.RemoveVariableAtScope(variable, scopeID);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 18570, 18622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1374, 18231, 18634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 18231, 18634);
            }
        }

        private SessionStateInternal _sessionState;

        static PSVariableIntrinsics()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1374, 298, 18800);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1374, 298, 18800);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1374, 298, 18800);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1374, 298, 18800);

        int
        f_1374_584_770(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 584, 770);
            return 0;
        }


        System.Management.Automation.PSArgumentException
        f_1374_1307_1357(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1374, 1307, 1357);
            return return_v;
        }

    }
}

