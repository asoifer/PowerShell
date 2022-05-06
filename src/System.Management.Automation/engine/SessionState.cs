// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Security;

using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    [SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "This is a bridge class between internal classes and a public interface. It requires this much coupling.")]
    internal sealed partial class SessionStateInternal
    {
        [Dbg.TraceSourceAttribute(
                     "SessionState",
                     "SessionState Class")]
        private static Dbg.PSTraceSource s_tracer;

        internal SessionStateInternal(ExecutionContext context) : this(f_1340_1844_1848_C(null), false, context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1340, 1781, 1887);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1340, 1781, 1887);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 1781, 1887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 1781, 1887);
            }
        }

        internal SessionStateInternal(SessionStateInternal parent, bool linkToGlobal, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1340, 1899, 4059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6213, 6228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6373, 6424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6822, 6841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 7156, 7171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 7303, 7353);
                this.Module = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 7537, 7573);
                this.ModuleTableKeys = f_1340_7555_7573();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 7704, 7840);
                this.ModuleTable = f_1340_7769_7839(f_1340_7806_7838());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 8811, 8889);
                this.Scripts = f_1340_8850_8888(new string[] { "*" });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 9507, 9590);
                this.Applications = f_1340_9551_9589(new string[] { "*" });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 9732, 9808);
                this.ExportedCmdlets = f_1340_9785_9807();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 10080, 10141);
                this.DefaultCommandVisibility = SessionStateEntryVisibility.Public;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1341, 4376, 4450);
                this.ExportedAliases = f_1341_4428_4449();

                static List<AliasInfo> f_1341_4428_4449()
                {
                    var r = new List<AliasInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1341, 4428, 4449);
                    return r;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345, 824, 837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4147, 4229);
                this.ExportedFunctions = f_1347_4204_4228();

                static List<FunctionInfo> f_1347_4204_4228()
                {
                    var r = new List<FunctionInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1347, 4204, 4228);
                    return r;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4241, 4291);
                this.UseExportList = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 4454, 4499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 5101, 5131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1347, 5313, 5375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 32134, 32153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 32317, 32338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 32534, 32578);
                this._defaultStackName = startingDefaultStackName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 1209, 1382);
                this._providers = f_1352_1235_1382(SessionStateConstants.DefaultDictionaryCapacity, f_1352_1349_1381());

                static StringComparer f_1352_1349_1381()
                {
                    var r = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 1349, 1381);
                    return r;
                }

                static Dictionary<string, List<ProviderInfo>> f_1352_1235_1382(int a, StringComparer b)
                {
                    var r = new Dictionary<string, List<ProviderInfo>>(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 1235, 1382);
                    return r;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1352, 2041, 2116);
                this._providersCurrentWorkingDrive = f_1352_2073_2116();

                static Dictionary<ProviderInfo, PSDriveInfo> f_1352_2073_2116()
                {
                    var r = new Dictionary<ProviderInfo, PSDriveInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1352, 2073, 2116);
                    return r;
                }

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355, 766, 779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355, 6202, 6249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355, 6451, 6498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1360, 74935, 75013);
                this.ExportedVariables = f_1360_74990_75012();

                static List<PSVariable> f_1360_74990_75012()
                {
                    var r = new List<PSVariable>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1360, 74990, 75012);
                    return r;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2027, 2151) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 2027, 2151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2080, 2136);

                    throw f_1340_2086_2135("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 2027, 2151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2167, 2194);

                ExecutionContext = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2325, 2423);

                _workingLocationStack = f_1340_2349_2422(f_1340_2389_2421());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2566, 2603);

                const uint
                locationHistoryLimit = 20
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2617, 2688);

                _setLocationHistory = f_1340_2639_2687(locationHistoryLimit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2704, 2746);

                GlobalScope = f_1340_2718_2745(null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2760, 2786);

                ModuleScope = f_1340_2774_2785();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2800, 2828);

                _currentScope = f_1340_2816_2827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 2844, 2898);

                f_1340_2844_2897(this, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3117, 3155);

                f_1340_3117_3128().ScriptScope = f_1340_3143_3154();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3171, 4048) || true) && (parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 3171, 4048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3223, 3263);

                    f_1340_3223_3234().Parent = f_1340_3244_3262(parent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3352, 3374);

                    f_1340_3352_3373(this, parent);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3528, 3668) || true) && (f_1340_3532_3541() != null && (DynAbs.Tracing.TraceSender.Expression_True(1340, 3532, 3572) && f_1340_3553_3568(f_1340_3553_3562()) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 3528, 3668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3614, 3649);

                        CurrentDrive = f_1340_3629_3648(parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 3528, 3668);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3739, 3849) || true) && (linkToGlobal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 3739, 3849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3797, 3830);

                        GlobalScope = f_1340_3811_3829(parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 3739, 3849);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 3171, 4048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 3171, 4048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 3915, 4033);

                    _currentScope.LocalsTuple = f_1340_3943_4032(Compiler.DottedLocalsTupleType, Compiler.DottedLocalsNameIndexMap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 3171, 4048);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1340, 1899, 4059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 1899, 4059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 1899, 4059);
            }
        }

        internal void InitializeSessionStateInternalSpecialVariables(bool clearVariablesTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 4291, 5819);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 4402, 4680) || true) && (clearVariablesTable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 4402, 4680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 4504, 4534);

                    f_1340_4504_4533(f_1340_4504_4525(f_1340_4504_4515()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 4614, 4665);

                    f_1340_4614_4664(f_1340_4614_4625());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 4402, 4680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 4732, 4828);

                PSVariable
                errorvariable = f_1340_4759_4827("Error", f_1340_4783_4798(), ScopedItemOptions.Constant)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 4842, 4937);

                f_1340_4842_4936(f_1340_4842_4853(), f_1340_4866_4884(errorvariable), errorvariable, false, false, this, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 5008, 5071);

                Collection<Attribute>
                attributes = f_1340_5043_5070()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 5085, 5201);

                f_1340_5085_5200(attributes, f_1340_5100_5199(typeof(System.Management.Automation.DefaultParameterDictionary)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 5215, 5661);

                PSVariable
                psDefaultParameterValuesVariable = f_1340_5261_5660(SpecialVariables.PSDefaultParameterValues, f_1340_5393_5425(), ScopedItemOptions.None, attributes, f_1340_5611_5659())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 5675, 5808);

                f_1340_5675_5807(f_1340_5675_5686(), f_1340_5699_5736(psDefaultParameterValuesVariable), psDefaultParameterValuesVariable, false, false, this, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 4291, 5819);

                System.Management.Automation.SessionStateScope
                f_1340_4504_4515()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 4504, 4515);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                f_1340_4504_4525(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 4504, 4525);
                    return return_v;
                }


                int
                f_1340_4504_4533(System.Collections.Generic.IDictionary<string, System.Management.Automation.PSVariable>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 4504, 4533);
                    return 0;
                }


                System.Management.Automation.SessionStateScope
                f_1340_4614_4625()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 4614, 4625);
                    return return_v;
                }


                int
                f_1340_4614_4664(System.Management.Automation.SessionStateScope
                this_param)
                {
                    this_param.AddSessionStateScopeDefaultVariables();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 4614, 4664);
                    return 0;
                }


                System.Collections.ArrayList
                f_1340_4783_4798()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 4783, 4798);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_4759_4827(string
                name, System.Collections.ArrayList
                value, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 4759, 4827);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_4842_4853()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 4842, 4853);
                    return return_v;
                }


                string
                f_1340_4866_4884(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 4866, 4884);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_4842_4936(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue, force, sessionState, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 4842, 4936);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1340_5043_5070()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5043, 5070);
                    return return_v;
                }


                System.Management.Automation.ArgumentTypeConverterAttribute
                f_1340_5100_5199(params System.Type[]
                types)
                {
                    var return_v = new System.Management.Automation.ArgumentTypeConverterAttribute(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5100, 5199);
                    return return_v;
                }


                int
                f_1340_5085_5200(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ArgumentTypeConverterAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5085, 5200);
                    return 0;
                }


                System.Management.Automation.DefaultParameterDictionary
                f_1340_5393_5425()
                {
                    var return_v = new System.Management.Automation.DefaultParameterDictionary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5393, 5425);
                    return return_v;
                }


                string
                f_1340_5611_5659()
                {
                    var return_v = RunspaceInit.PSDefaultParameterValuesDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 5611, 5659);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_5261_5660(string
                name, System.Management.Automation.DefaultParameterDictionary
                value, System.Management.Automation.ScopedItemOptions
                options, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, attributes, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5261, 5660);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_5675_5686()
                {
                    var return_v = GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 5675, 5686);
                    return return_v;
                }


                string
                f_1340_5699_5736(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 5699, 5736);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_5675_5807(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue, force, sessionState, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 5675, 5807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 4291, 5819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 4291, 5819);
            }
        }

        internal LocationGlobber Globber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 6079, 6166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6085, 6164);

                    return _globberPrivate ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.LocationGlobber>(1340, 6092, 6163) ?? (_globberPrivate = f_1340_6130_6162(f_1340_6130_6146())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 6079, 6166);

                    System.Management.Automation.ExecutionContext
                    f_1340_6130_6146()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 6130, 6146);
                        return return_v;
                    }


                    System.Management.Automation.LocationGlobber
                    f_1340_6130_6162(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.LocationGlobber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 6130, 6162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 6022, 6177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 6022, 6177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LocationGlobber _globberPrivate;

        internal ExecutionContext ExecutionContext { get; }

        internal SessionState PublicSessionState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 6641, 6726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6647, 6724);

                    return _publicSessionState ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionState>(1340, 6654, 6723) ?? (_publicSessionState = f_1340_6700_6722(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 6641, 6726);

                    System.Management.Automation.SessionState
                    f_1340_6700_6722(System.Management.Automation.SessionStateInternal
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.SessionState(sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 6700, 6722);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 6576, 6789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 6576, 6789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 6742, 6778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 6748, 6776);

                    _publicSessionState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 6742, 6778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 6576, 6789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 6576, 6789);
                }
            }
        }

        private SessionState _publicSessionState;

        internal ProviderIntrinsics InvokeProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 7023, 7106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 7029, 7104);

                    return _invokeProvider ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ProviderIntrinsics>(1340, 7036, 7103) ?? (_invokeProvider = f_1340_7074_7102(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 7023, 7106);

                    System.Management.Automation.ProviderIntrinsics
                    f_1340_7074_7102(System.Management.Automation.SessionStateInternal
                    sessionState)
                    {
                        var return_v = new System.Management.Automation.ProviderIntrinsics(sessionState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 7074, 7102);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 6956, 7117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 6956, 7117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ProviderIntrinsics _invokeProvider;

        internal PSModuleInfo Module { get; set; }

        internal List<string> ModuleTableKeys;

        internal Dictionary<string, PSModuleInfo> ModuleTable { get; }

        internal PSLanguageMode LanguageMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 8025, 8113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 8061, 8098);

                    return f_1340_8068_8097(f_1340_8068_8084());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 8025, 8113);

                    System.Management.Automation.ExecutionContext
                    f_1340_8068_8084()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 8068, 8084);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode
                    f_1340_8068_8097(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 8068, 8097);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 7964, 8229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 7964, 8229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 8129, 8218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 8165, 8203);

                    f_1340_8165_8181().LanguageMode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 8129, 8218);

                    System.Management.Automation.ExecutionContext
                    f_1340_8165_8181()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 8165, 8181);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 7964, 8229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 7964, 8229);
                }
            }
        }

        internal bool UseFullLanguageModeInDebugger
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 8478, 8583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 8514, 8568);

                    return f_1340_8521_8567(f_1340_8521_8537());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 8478, 8583);

                    System.Management.Automation.ExecutionContext
                    f_1340_8521_8537()
                    {
                        var return_v = ExecutionContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 8521, 8537);
                        return return_v;
                    }


                    bool
                    f_1340_8521_8567(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.UseFullLanguageModeInDebugger;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 8521, 8567);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 8410, 8594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 8410, 8594);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<string> Scripts { get; }

        internal SessionStateEntryVisibility CheckScriptVisibility(string scriptPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 9119, 9280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 9221, 9269);

                return f_1340_9228_9268(this, f_1340_9248_9255(), scriptPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 9119, 9280);

                System.Collections.Generic.List<string>
                f_1340_9248_9255()
                {
                    var return_v = Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 9248, 9255);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1340_9228_9268(System.Management.Automation.SessionStateInternal
                this_param, System.Collections.Generic.List<string>
                list, string
                path)
                {
                    var return_v = this_param.checkPathVisibility(list, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 9228, 9268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 9119, 9280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 9119, 9280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<string> Applications { get; }

        internal List<CmdletInfo> ExportedCmdlets { get; }

        internal SessionStateEntryVisibility DefaultCommandVisibility;

        internal void AddSessionStateEntry(SessionStateCmdletEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 10342, 10487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 10432, 10476);

                f_1340_10432_10475(this, entry, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 10342, 10487);

                int
                f_1340_10432_10475(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Runspaces.SessionStateCmdletEntry
                entry, bool
                local)
                {
                    this_param.AddSessionStateEntry(entry, local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 10432, 10475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 10342, 10487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 10342, 10487);
            }
        }

        internal void AddSessionStateEntry(SessionStateCmdletEntry entry, bool local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 10794, 10989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 10896, 10978);

                f_1340_10896_10977(f_1340_10896_10929(f_1340_10896_10912()), entry, local);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 10794, 10989);

                System.Management.Automation.ExecutionContext
                f_1340_10896_10912()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 10896, 10912);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1340_10896_10929(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 10896, 10929);
                    return return_v;
                }


                int
                f_1340_10896_10977(System.Management.Automation.CommandDiscovery
                this_param, System.Management.Automation.Runspaces.SessionStateCmdletEntry
                entry, bool
                local)
                {
                    this_param.AddSessionStateCmdletEntryToCache(entry, local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 10896, 10977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 10794, 10989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 10794, 10989);
            }
        }

        internal void AddSessionStateEntry(SessionStateApplicationEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 11189, 11329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 11284, 11318);

                f_1340_11284_11317(f_1340_11284_11301(this), f_1340_11306_11316(entry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 11189, 11329);

                System.Collections.Generic.List<string>
                f_1340_11284_11301(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 11284, 11301);
                    return return_v;
                }


                string
                f_1340_11306_11316(System.Management.Automation.Runspaces.SessionStateApplicationEntry
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 11306, 11316);
                    return return_v;
                }


                int
                f_1340_11284_11317(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 11284, 11317);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 11189, 11329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 11189, 11329);
            }
        }

        internal void AddSessionStateEntry(SessionStateScriptEntry entry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 11529, 11659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 11619, 11648);

                f_1340_11619_11647(f_1340_11619_11631(this), f_1340_11636_11646(entry));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 11529, 11659);

                System.Collections.Generic.List<string>
                f_1340_11619_11631(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Scripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 11619, 11631);
                    return return_v;
                }


                string
                f_1340_11636_11646(System.Management.Automation.Runspaces.SessionStateScriptEntry
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 11636, 11646);
                    return return_v;
                }


                int
                f_1340_11619_11647(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 11619, 11647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 11529, 11659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 11529, 11659);
            }
        }

        internal void InitializeFixedVariables()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 11807, 16630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 12056, 12321);

                PSVariable
                v = f_1340_12071_12320(SpecialVariables.Host, f_1340_12152_12188(f_1340_12152_12168()), ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_12289_12319())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 12335, 12450);

                f_1340_12335_12449(f_1340_12335_12351(this), f_1340_12364_12370(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 12644, 12747);

                string
                home = f_1340_12658_12730(Platform.CommonEnvVariableNames.Home) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1340, 12658, 12746) ?? string.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 12761, 12959);

                v = f_1340_12765_12958(SpecialVariables.Home, home, ScopedItemOptions.ReadOnly | ScopedItemOptions.AllScope, f_1340_12929_12957());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 12973, 13088);

                f_1340_12973_13087(f_1340_12973_12989(this), f_1340_13002_13008(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 13138, 13389);

                v = f_1340_13142_13388(SpecialVariables.ExecutionContext, f_1340_13213_13246(f_1340_13213_13229()), ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_13347_13387());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 13403, 13518);

                f_1340_13403_13517(f_1340_13403_13419(this), f_1340_13432_13438(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 13566, 13813);

                v = f_1340_13570_13812(SpecialVariables.PSVersionTable, f_1340_13639_13672(), ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_13773_13811());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 13827, 13942);

                f_1340_13827_13941(f_1340_13827_13843(this), f_1340_13856_13862(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 13985, 14217);

                v = f_1340_13989_14216(SpecialVariables.PSEdition, PSVersionInfo.PSEditionValue, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_14182_14215());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14231, 14346);

                f_1340_14231_14345(f_1340_14231_14247(this), f_1340_14260_14266(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14383, 14436);

                Process
                currentProcess = f_1340_14408_14435()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14450, 14681);

                v = f_1340_14454_14680(SpecialVariables.PID, f_1340_14534_14551(currentProcess), ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_14652_14679());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14695, 14810);

                f_1340_14695_14809(f_1340_14695_14711(this), f_1340_14724_14730(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14853, 14881);

                v = f_1340_14857_14880();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14895, 14938);

                f_1340_14895_14937(f_1340_14895_14911(this), v, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 14983, 15013);

                v = f_1340_14987_15012();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15027, 15070);

                f_1340_15027_15069(f_1340_15027_15043(this), v, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15105, 15157);

                v = f_1340_15109_15156(f_1340_15134_15155(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15171, 15214);

                f_1340_15171_15213(f_1340_15171_15187(this), v, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15312, 15354);

                string
                shellId = f_1340_15329_15353(f_1340_15329_15345())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15368, 15556);

                v = f_1340_15372_15555(SpecialVariables.ShellId, shellId, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_15520_15554());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15570, 15685);

                f_1340_15570_15684(f_1340_15570_15586(this), f_1340_15599_15605(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15725, 15781);

                string
                applicationBase = f_1340_15750_15780()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 15795, 15987);

                v = f_1340_15799_15986(SpecialVariables.PSHome, applicationBase, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_15955_15985());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 16001, 16116);

                f_1340_16001_16115(f_1340_16001_16017(this), f_1340_16030_16036(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 16177, 16490);

                v = f_1340_16181_16489(SpecialVariables.EnabledExperimentalFeatures, ExperimentalFeature.EnabledExperimentalFeatureNames, ScopedItemOptions.Constant | ScopedItemOptions.AllScope, f_1340_16448_16488());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 16504, 16619);

                f_1340_16504_16618(f_1340_16504_16520(this), f_1340_16533_16539(v), v, asValue: false, force: true, this, CommandOrigin.Internal, fastPath: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 11807, 16630);

                System.Management.Automation.ExecutionContext
                f_1340_12152_12168()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12152, 12168);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1340_12152_12188(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12152, 12188);
                    return return_v;
                }


                string
                f_1340_12289_12319()
                {
                    var return_v = RunspaceInit.PSHostDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12289, 12319);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_12071_12320(string
                name, System.Management.Automation.Internal.Host.InternalHost
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 12071, 12320);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_12335_12351(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12335, 12351);
                    return return_v;
                }


                string
                f_1340_12364_12370(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12364, 12370);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_12335_12449(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 12335, 12449);
                    return return_v;
                }


                string?
                f_1340_12658_12730(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 12658, 12730);
                    return return_v;
                }


                string
                f_1340_12929_12957()
                {
                    var return_v = RunspaceInit.HOMEDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12929, 12957);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_12765_12958(string
                name, string
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 12765, 12958);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_12973_12989(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 12973, 12989);
                    return return_v;
                }


                string
                f_1340_13002_13008(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13002, 13008);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_12973_13087(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 12973, 13087);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1340_13213_13229()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13213, 13229);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1340_13213_13246(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13213, 13246);
                    return return_v;
                }


                string
                f_1340_13347_13387()
                {
                    var return_v = RunspaceInit.ExecutionContextDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13347, 13387);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_13142_13388(string
                name, System.Management.Automation.EngineIntrinsics
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13142, 13388);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_13403_13419(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13403, 13419);
                    return return_v;
                }


                string
                f_1340_13432_13438(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13432, 13438);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_13403_13517(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13403, 13517);
                    return return_v;
                }


                System.Management.Automation.PSVersionHashTable
                f_1340_13639_13672()
                {
                    var return_v = PSVersionInfo.GetPSVersionTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13639, 13672);
                    return return_v;
                }


                string
                f_1340_13773_13811()
                {
                    var return_v = RunspaceInit.PSVersionTableDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13773, 13811);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_13570_13812(string
                name, System.Management.Automation.PSVersionHashTable
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13570, 13812);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_13827_13843(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13827, 13843);
                    return return_v;
                }


                string
                f_1340_13856_13862(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 13856, 13862);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_13827_13941(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13827, 13941);
                    return return_v;
                }


                string
                f_1340_14182_14215()
                {
                    var return_v = RunspaceInit.PSEditionDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14182, 14215);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_13989_14216(string
                name, string
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 13989, 14216);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_14231_14247(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14231, 14247);
                    return return_v;
                }


                string
                f_1340_14260_14266(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14260, 14266);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_14231_14345(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14231, 14345);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1340_14408_14435()
                {
                    var return_v = Process.GetCurrentProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14408, 14435);
                    return return_v;
                }


                int
                f_1340_14534_14551(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14534, 14551);
                    return return_v;
                }


                string
                f_1340_14652_14679()
                {
                    var return_v = RunspaceInit.PIDDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14652, 14679);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_14454_14680(string
                name, int
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14454, 14680);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_14695_14711(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14695, 14711);
                    return return_v;
                }


                string
                f_1340_14724_14730(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14724, 14730);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_14695_14809(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14695, 14809);
                    return return_v;
                }


                System.Management.Automation.PSCultureVariable
                f_1340_14857_14880()
                {
                    var return_v = new System.Management.Automation.PSCultureVariable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14857, 14880);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_14895_14911(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 14895, 14911);
                    return return_v;
                }


                int
                f_1340_14895_14937(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSVariable
                variableToSet, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    this_param.SetVariableForce(variableToSet, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14895, 14937);
                    return 0;
                }


                System.Management.Automation.PSUICultureVariable
                f_1340_14987_15012()
                {
                    var return_v = new System.Management.Automation.PSUICultureVariable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 14987, 15012);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_15027_15043(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15027, 15043);
                    return return_v;
                }


                int
                f_1340_15027_15069(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSVariable
                variableToSet, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    this_param.SetVariableForce(variableToSet, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15027, 15069);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1340_15134_15155(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15134, 15155);
                    return return_v;
                }


                System.Management.Automation.QuestionMarkVariable
                f_1340_15109_15156(System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.QuestionMarkVariable(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15109, 15156);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_15171_15187(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15171, 15187);
                    return return_v;
                }


                int
                f_1340_15171_15213(System.Management.Automation.SessionStateScope
                this_param, System.Management.Automation.PSVariable
                variableToSet, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    this_param.SetVariableForce(variableToSet, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15171, 15213);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1340_15329_15345()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15329, 15345);
                    return return_v;
                }


                string
                f_1340_15329_15353(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ShellID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15329, 15353);
                    return return_v;
                }


                string
                f_1340_15520_15554()
                {
                    var return_v = RunspaceInit.MshShellIdDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15520, 15554);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_15372_15555(string
                name, string
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15372, 15555);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_15570_15586(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15570, 15586);
                    return return_v;
                }


                string
                f_1340_15599_15605(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15599, 15605);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_15570_15684(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15570, 15684);
                    return return_v;
                }


                string
                f_1340_15750_15780()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15750, 15780);
                    return return_v;
                }


                string
                f_1340_15955_15985()
                {
                    var return_v = RunspaceInit.PSHOMEDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 15955, 15985);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_15799_15986(string
                name, string
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 15799, 15986);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_16001_16017(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 16001, 16017);
                    return return_v;
                }


                string
                f_1340_16030_16036(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 16030, 16036);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_16001_16115(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 16001, 16115);
                    return return_v;
                }


                string
                f_1340_16448_16488()
                {
                    var return_v = RunspaceInit.EnabledExperimentalFeatures;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 16448, 16488);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_16181_16489(string
                name, System.Management.Automation.Internal.ReadOnlyBag<string>
                value, System.Management.Automation.ScopedItemOptions
                options, string
                description)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, (object)value, options, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 16181, 16489);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1340_16504_16520(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 16504, 16520);
                    return return_v;
                }


                string
                f_1340_16533_16539(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 16533, 16539);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1340_16504_16618(System.Management.Automation.SessionStateScope
                this_param, string
                name, System.Management.Automation.PSVariable
                value, bool
                asValue, bool
                force, System.Management.Automation.SessionStateInternal
                sessionState, System.Management.Automation.CommandOrigin
                origin, bool
                fastPath)
                {
                    var return_v = this_param.SetVariable(name, (object)value, asValue: asValue, force: force, sessionState, origin, fastPath: fastPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 16504, 16618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 11807, 16630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 11807, 16630);
            }
        }

        internal SessionStateEntryVisibility CheckApplicationVisibility(string applicationPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 16910, 17091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17022, 17080);

                return f_1340_17029_17079(this, f_1340_17049_17061(), applicationPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 16910, 17091);

                System.Collections.Generic.List<string>
                f_1340_17049_17061()
                {
                    var return_v = Applications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 17049, 17061);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1340_17029_17079(System.Management.Automation.SessionStateInternal
                this_param, System.Collections.Generic.List<string>
                list, string
                path)
                {
                    var return_v = this_param.checkPathVisibility(list, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17029, 17079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 16910, 17091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 16910, 17091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SessionStateEntryVisibility checkPathVisibility(List<string> list, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 17103, 18120);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17215, 17295) || true) && (list == null || (DynAbs.Tracing.TraceSender.Expression_False(1340, 17219, 17250) || f_1340_17235_17245(list) == 0))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17215, 17295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17252, 17295);

                    return SessionStateEntryVisibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17215, 17295);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17309, 17384) || true) && (f_1340_17313_17339(path))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17309, 17384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17341, 17384);

                    return SessionStateEntryVisibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17309, 17384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17400, 17466) || true) && (f_1340_17404_17422(list, "*"))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17400, 17466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17424, 17466);

                    return SessionStateEntryVisibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17400, 17466);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17480, 18050);
                    foreach (string p in f_1340_17501_17505_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17480, 18050);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17539, 17666) || true) && (f_1340_17543_17601(p, path, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17539, 17666);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17624, 17666);

                            return SessionStateEntryVisibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17539, 17666);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17686, 18035) || true) && (f_1340_17690_17735(p))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17686, 18035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17777, 17854);

                            WildcardPattern
                            pattern = f_1340_17803_17853(p, WildcardOptions.IgnoreCase)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17876, 18016) || true) && (f_1340_17880_17901(pattern, path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 17876, 18016);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 17951, 17993);

                                return SessionStateEntryVisibility.Public;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17876, 18016);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17686, 18035);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 17480, 18050);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1340, 1, 571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1340, 1, 571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 18066, 18109);

                return SessionStateEntryVisibility.Private;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 17103, 18120);

                int
                f_1340_17235_17245(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 17235, 17245);
                    return return_v;
                }


                bool
                f_1340_17313_17339(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17313, 17339);
                    return return_v;
                }


                bool
                f_1340_17404_17422(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17404, 17422);
                    return return_v;
                }


                bool
                f_1340_17543_17601(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17543, 17601);
                    return return_v;
                }


                bool
                f_1340_17690_17735(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17690, 17735);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1340_17803_17853(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17803, 17853);
                    return return_v;
                }


                bool
                f_1340_17880_17901(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17880, 17901);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1340_17501_17505_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 17501, 17505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 17103, 18120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 17103, 18120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RunspaceClosingNotification()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 18311, 18876);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 18379, 18865) || true) && (this != f_1340_18391_18428(f_1340_18391_18407()) && (DynAbs.Tracing.TraceSender.Expression_True(1340, 18383, 18451) && f_1340_18432_18447(f_1340_18432_18441()) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 18379, 18865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 18548, 18629);

                    CmdletProviderContext
                    context = f_1340_18580_18628(f_1340_18606_18627(this))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 18649, 18850);
                        foreach (string providerName in f_1340_18681_18695_I(f_1340_18681_18695(f_1340_18681_18690())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 18649, 18850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 18787, 18831);

                            f_1340_18787_18830(this, providerName, true, context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 18649, 18850);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1340, 1, 202);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1340, 1, 202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 18379, 18865);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 18311, 18876);

                System.Management.Automation.ExecutionContext
                f_1340_18391_18407()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18391, 18407);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1340_18391_18428(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18391, 18428);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1340_18432_18441()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18432, 18441);
                    return return_v;
                }


                int
                f_1340_18432_18447(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18432, 18447);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1340_18606_18627(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18606, 18627);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1340_18580_18628(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 18580, 18628);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                f_1340_18681_18690()
                {
                    var return_v = Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18681, 18690);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.KeyCollection
                f_1340_18681_18695(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 18681, 18695);
                    return return_v;
                }


                int
                f_1340_18787_18830(System.Management.Automation.SessionStateInternal
                this_param, string
                providerName, bool
                force, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.RemoveProvider(providerName, force, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 18787, 18830);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.KeyCollection
                f_1340_18681_18695_I(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 18681, 18695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 18311, 18876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 18311, 18876);
            }
        }

        internal ProviderInvocationException NewProviderInvocationException(
                    string resourceId,
                    string resourceStr,
                    ProviderInfo provider,
                    string path,
                    Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 20144, 20489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 20390, 20478);

                return f_1340_20397_20477(this, resourceId, resourceStr, provider, path, e, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 20144, 20489);

                System.Management.Automation.ProviderInvocationException
                f_1340_20397_20477(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e, bool
                useInnerExceptionErrorMessage)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e, useInnerExceptionErrorMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 20397, 20477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 20144, 20489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 20144, 20489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ProviderInvocationException NewProviderInvocationException(
                    string resourceId,
                    string resourceStr,
                    ProviderInfo provider,
                    string path,
                    Exception e,
                    bool useInnerExceptionErrorMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1340, 21991, 23098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22511, 22578);

                ProviderInvocationException
                pie = e as ProviderInvocationException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22592, 22714) || true) && (pie != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1340, 22592, 22714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22641, 22670);

                    pie._providerInfo = provider;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22688, 22699);

                    return pie;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1340, 22592, 22714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22730, 22843);

                pie = f_1340_22736_22842(resourceId, resourceStr, provider, path, e, useInnerExceptionErrorMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 22905, 23060);

                f_1340_22905_23059(f_1340_22953_22969(), f_1340_22988_23001(provider), pie, Severity.Warning);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 23076, 23087);

                return pie;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1340, 21991, 23098);

                System.Management.Automation.ProviderInvocationException
                f_1340_22736_22842(string
                errorId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                innerException, bool
                useInnerExceptionMessage)
                {
                    var return_v = new System.Management.Automation.ProviderInvocationException(errorId, resourceStr, provider, path, innerException, useInnerExceptionMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 22736, 22842);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1340_22953_22969()
                {
                    var return_v = ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 22953, 22969);
                    return return_v;
                }


                string
                f_1340_22988_23001(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 22988, 23001);
                    return return_v;
                }


                int
                f_1340_22905_23059(System.Management.Automation.ExecutionContext
                executionContext, string
                providerName, System.Management.Automation.ProviderInvocationException
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogProviderHealthEvent(executionContext, providerName, (System.Exception)exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 22905, 23059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1340, 21991, 23098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 21991, 23098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SessionStateInternal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1340, 617, 23132);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1340, 1231, 1334);
            s_tracer = f_1340_1255_1334("SessionState", "SessionState Class");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1345, 9330, 9402);
            s_charactersInvalidInDriveName = new char[] { ':', '/', '\\', '.', '~' };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1349, 32372, 32408);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1355, 949, 977);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1340, 617, 23132);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1340, 617, 23132);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1340, 617, 23132);

        static System.Management.Automation.PSTraceSource
        f_1340_1255_1334(string
        name, string
        description)
        {
            var return_v = Dbg.PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 1255, 1334);
            return return_v;
        }


        static System.Management.Automation.SessionStateInternal
        f_1340_1844_1848_C(System.Management.Automation.SessionStateInternal
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1340, 1781, 1887);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1340_2086_2135(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 2086, 2135);
            return return_v;
        }


        System.StringComparer
        f_1340_2389_2421()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 2389, 2421);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>
        f_1340_2349_2422(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.Stack<System.Management.Automation.PathInfo>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 2349, 2422);
            return return_v;
        }


        System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>
        f_1340_2639_2687(uint
        capacity)
        {
            var return_v = new System.Management.Automation.Internal.HistoryStack<System.Management.Automation.PathInfo>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 2639, 2687);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_2718_2745(System.Management.Automation.SessionStateScope
        parentScope)
        {
            var return_v = new System.Management.Automation.SessionStateScope(parentScope);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 2718, 2745);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_2774_2785()
        {
            var return_v = GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 2774, 2785);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_2816_2827()
        {
            var return_v = GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 2816, 2827);
            return return_v;
        }


        int
        f_1340_2844_2897(System.Management.Automation.SessionStateInternal
        this_param, bool
        clearVariablesTable)
        {
            this_param.InitializeSessionStateInternalSpecialVariables(clearVariablesTable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 2844, 2897);
            return 0;
        }


        System.Management.Automation.SessionStateScope
        f_1340_3117_3128()
        {
            var return_v = GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3117, 3128);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_3143_3154()
        {
            var return_v = GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3143, 3154);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_3223_3234()
        {
            var return_v = GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3223, 3234);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_3244_3262(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3244, 3262);
            return return_v;
        }


        int
        f_1340_3352_3373(System.Management.Automation.SessionStateInternal
        this_param, System.Management.Automation.SessionStateInternal
        ss)
        {
            this_param.CopyProviders(ss);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 3352, 3373);
            return 0;
        }


        System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
        f_1340_3532_3541()
        {
            var return_v = Providers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3532, 3541);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
        f_1340_3553_3562()
        {
            var return_v = Providers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3553, 3562);
            return return_v;
        }


        int
        f_1340_3553_3568(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Management.Automation.ProviderInfo>>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3553, 3568);
            return return_v;
        }


        System.Management.Automation.PSDriveInfo
        f_1340_3629_3648(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.CurrentDrive;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3629, 3648);
            return return_v;
        }


        System.Management.Automation.SessionStateScope
        f_1340_3811_3829(System.Management.Automation.SessionStateInternal
        this_param)
        {
            var return_v = this_param.GlobalScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 3811, 3829);
            return return_v;
        }


        System.Management.Automation.MutableTuple
        f_1340_3943_4032(System.Type
        tupleType, System.Collections.Generic.Dictionary<string, int>
        nameToIndexMap)
        {
            var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 3943, 4032);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1340_7555_7573()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 7555, 7573);
            return return_v;
        }


        System.StringComparer
        f_1340_7806_7838()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1340, 7806, 7838);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
        f_1340_7769_7839(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 7769, 7839);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1340_8850_8888(string[]
        collection)
        {
            var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 8850, 8888);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1340_9551_9589(string[]
        collection)
        {
            var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 9551, 9589);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CmdletInfo>
        f_1340_9785_9807()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CmdletInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1340, 9785, 9807);
            return return_v;
        }

    }
}
