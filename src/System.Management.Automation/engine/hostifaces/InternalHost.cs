// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation.Host;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;

using Dbg = System.Management.Automation.Diagnostics;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation.Internal.Host
{
    internal class InternalHost : PSHost, IHostSupportsInteractiveSession
    {
        internal InternalHost(PSHost externalHost, ExecutionContext executionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1463, 2049, 2813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17237, 17295);
                this.DebuggerEnabled = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21203, 21245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21414, 21466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21534, 21550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21606, 21620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21679, 21690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21717, 21731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21808, 21854);
                this._contextStack = f_1463_21824_21854();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2151, 2209);

                f_1463_2151_2208(externalHost != null, "must supply an PSHost");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2223, 2326);

                f_1463_2223_2325(!(externalHost is InternalHost), "try to create an InternalHost from another InternalHost");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2342, 2414);

                f_1463_2342_2413(executionContext != null, "must supply an ExecutionContext");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2430, 2485);

                _externalHostRef = f_1463_2449_2484(externalHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2499, 2526);

                Context = executionContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2542, 2583);

                PSHostUserInterface
                ui = f_1463_2567_2582(externalHost)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2599, 2698);

                _internalUIRef = f_1463_2616_2697(f_1463_2657_2696(ui, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2712, 2766);

                _zeroGuid = f_1463_2724_2765(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 2780, 2802);

                _idResult = _zeroGuid;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1463, 2049, 2813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 2049, 2813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 2049, 2813);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 3126, 3601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3162, 3547) || true) && (f_1463_3166_3199(_nameResult))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 3162, 3547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3241, 3283);

                        _nameResult = f_1463_3255_3282(f_1463_3255_3277(_externalHostRef));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3338, 3497) || true) && (f_1463_3342_3375(_nameResult))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 3338, 3497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3425, 3474);

                            throw f_1463_3431_3473();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 3338, 3497);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 3162, 3547);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3567, 3586);

                    return _nameResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 3126, 3601);

                    bool
                    f_1463_3166_3199(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 3166, 3199);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHost
                    f_1463_3255_3277(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 3255, 3277);
                        return return_v;
                    }


                    string
                    f_1463_3255_3282(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 3255, 3282);
                        return return_v;
                    }


                    bool
                    f_1463_3342_3375(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 3342, 3375);
                        return return_v;
                    }


                    System.Management.Automation.PSNotImplementedException
                    f_1463_3431_3473()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 3431, 3473);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 3074, 3612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 3074, 3612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 3930, 4392);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 3966, 4335) || true) && (_versionResult == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 3966, 4335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4034, 4082);

                        _versionResult = f_1463_4051_4081(f_1463_4051_4073(_externalHostRef));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4137, 4285) || true) && (_versionResult == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 4137, 4285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4213, 4262);

                            throw f_1463_4219_4261();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 4137, 4285);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 3966, 4335);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4355, 4377);

                    return _versionResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 3930, 4392);

                    System.Management.Automation.Host.PSHost
                    f_1463_4051_4073(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 4051, 4073);
                        return return_v;
                    }


                    System.Version
                    f_1463_4051_4081(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 4051, 4081);
                        return return_v;
                    }


                    System.Management.Automation.PSNotImplementedException
                    f_1463_4219_4261()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 4219, 4261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 3867, 4403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 3867, 4403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Guid InstanceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 4731, 5186);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4767, 5134) || true) && (_idResult == _zeroGuid)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 4767, 5134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4835, 4881);

                        _idResult = f_1463_4847_4880(f_1463_4847_4869(_externalHostRef));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 4936, 5084) || true) && (_idResult == _zeroGuid)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 4936, 5084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 5012, 5061);

                            throw f_1463_5018_5060();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 4936, 5084);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 4767, 5134);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 5154, 5171);

                    return _idResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 4731, 5186);

                    System.Management.Automation.Host.PSHost
                    f_1463_4847_4869(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 4847, 4869);
                        return return_v;
                    }


                    System.Guid
                    f_1463_4847_4880(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.InstanceId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 4847, 4880);
                        return return_v;
                    }


                    System.Management.Automation.PSNotImplementedException
                    f_1463_5018_5060()
                    {
                        var return_v = PSTraceSource.NewNotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 5018, 5060);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 4668, 5197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 4668, 5197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Management.Automation.Host.PSHostUserInterface UI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 5425, 5504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 5461, 5489);

                    return f_1463_5468_5488(_internalUIRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 5425, 5504);

                    System.Management.Automation.Internal.Host.InternalHostUserInterface
                    f_1463_5468_5488(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 5468, 5488);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 5328, 5515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 5328, 5515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal InternalHostUserInterface InternalUI
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 5897, 5976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 5933, 5961);

                    return f_1463_5940_5960(_internalUIRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 5897, 5976);

                    System.Management.Automation.Internal.Host.InternalHostUserInterface
                    f_1463_5940_5960(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 5940, 5960);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 5827, 5987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 5827, 5987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override System.Globalization.CultureInfo CurrentCulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 6351, 6519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 6387, 6474);

                    CultureInfo
                    ci = f_1463_6404_6441(f_1463_6404_6426(_externalHostRef)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo>(1463, 6404, 6473) ?? f_1463_6445_6473())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 6494, 6504);

                    return ci;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 6351, 6519);

                    System.Management.Automation.Host.PSHost
                    f_1463_6404_6426(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6404, 6426);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1463_6404_6441(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6404, 6441);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1463_6445_6473()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6445, 6473);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 6263, 6530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 6263, 6530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override CultureInfo CurrentUICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 6874, 7044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 6910, 7001);

                    CultureInfo
                    ci = f_1463_6927_6966(f_1463_6927_6949(_externalHostRef)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo>(1463, 6927, 7000) ?? f_1463_6970_7000())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 7019, 7029);

                    return ci;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 6874, 7044);

                    System.Management.Automation.Host.PSHost
                    f_1463_6927_6949(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6927, 6949);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1463_6927_6966(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6927, 6966);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1463_6970_7000()
                    {
                        var return_v = CultureInfo.InstalledUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 6970, 7000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 6805, 7055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 6805, 7055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void SetShouldExit(int exitCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 7188, 7319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 7261, 7308);

                f_1463_7261_7307(f_1463_7261_7283(_externalHostRef), exitCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 7188, 7319);

                System.Management.Automation.Host.PSHost
                f_1463_7261_7283(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 7261, 7283);
                    return return_v;
                }


                int
                f_1463_7261_7307(System.Management.Automation.Host.PSHost
                this_param, int
                exitCode)
                {
                    this_param.SetShouldExit(exitCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 7261, 7307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 7188, 7319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 7188, 7319);
            }
        }

        public override void EnterNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 7454, 7554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 7519, 7543);

                f_1463_7519_7542(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 7454, 7554);

                int
                f_1463_7519_7542(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Internal.InternalCommand
                callingCommand)
                {
                    this_param.EnterNestedPrompt(callingCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 7519, 7542);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 7454, 7554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 7454, 7554);
            }
        }

        private struct PromptContextData
        {

            public object SavedCurrentlyExecutingCommandVarValue;

            public object SavedPSBoundParametersVarValue;

            public ExecutionContext.SavedContextData SavedContextData;

            public RunspaceAvailability RunspaceAvailability;

            public PSLanguageMode LanguageMode;
            static PromptContextData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1463, 7566, 7930);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1463, 7566, 7930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 7566, 7930);
            }
        }

        internal void EnterNestedPrompt(InternalCommand callingCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 8091, 14395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8236, 8271);

                LocalRunspace
                localRunspace = null
                ;

                // This needs to be in a try / catch, since the LocalRunspace cast
                // tries to verify that the host supports interactive sessions.
                // Tests hosts do not.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8486, 8533);

                    localRunspace = f_1463_8502_8515(this) as LocalRunspace;
                }
                catch (PSNotImplementedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1463, 8549, 8586);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1463, 8549, 8586);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8602, 8957) || true) && (localRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 8602, 8957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8661, 8741);

                    Pipeline
                    currentlyRunningPipeline = f_1463_8697_8740(f_1463_8697_8710(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8761, 8942) || true) && ((currentlyRunningPipeline != null) && (DynAbs.Tracing.TraceSender.Expression_True(1463, 8765, 8881) && (currentlyRunningPipeline == f_1463_8853_8880(localRunspace))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 8761, 8942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 8904, 8942);

                        throw f_1463_8910_8941();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 8761, 8942);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 8602, 8957);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 9310, 9594) || true) && (f_1463_9314_9331() < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 9310, 9594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 9369, 9438);

                    f_1463_9369_9437(false, "nested prompt counter should never be negative.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 9456, 9579);

                    throw f_1463_9462_9578(f_1463_9527_9577());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 9310, 9594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 9930, 9950);

                f_1463_9930_9949_M(++NestedPromptCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 9964, 10048);

                f_1463_9964_10047(f_1463_9964_9971(), SpecialVariables.NestedPromptCounterVarPath, f_1463_10029_10046());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10161, 10217);

                PromptContextData
                contextData = f_1463_10193_10216()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10231, 10288);

                contextData.SavedContextData = f_1463_10262_10287(f_1463_10262_10269());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10302, 10431);

                contextData.SavedCurrentlyExecutingCommandVarValue = f_1463_10355_10430(f_1463_10355_10362(), SpecialVariables.CurrentlyExecutingCommandVarPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10445, 10558);

                contextData.SavedPSBoundParametersVarValue = f_1463_10490_10557(f_1463_10490_10497(), SpecialVariables.PSBoundParametersVarPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10572, 10657);

                contextData.RunspaceAvailability = f_1463_10607_10656(f_1463_10607_10635(f_1463_10607_10619(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10671, 10719);

                contextData.LanguageMode = f_1463_10698_10718(f_1463_10698_10705());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10735, 10777);

                PSPropertyInfo
                commandInfoProperty = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10791, 10832);

                PSPropertyInfo
                stackTraceProperty = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10846, 10875);

                object
                oldCommandInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10889, 10917);

                object
                oldStackTrace = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10931, 12653) || true) && (callingCommand != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 10931, 12653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 10991, 11080);

                    f_1463_10991_11079(f_1463_11002_11024(callingCommand) == f_1463_11028_11035(), "I expect that the contexts should match");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11518, 11574);

                    PSObject
                    newValue = f_1463_11538_11573(callingCommand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11594, 11651);

                    commandInfoProperty = f_1463_11616_11650(f_1463_11616_11635(newValue), "CommandInfo");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11669, 12050) || true) && (commandInfoProperty == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 11669, 12050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11742, 11829);

                        f_1463_11742_11828(f_1463_11742_11761(newValue), f_1463_11766_11827("CommandInfo", f_1463_11800_11826(callingCommand)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 11669, 12050);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 11669, 12050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11911, 11954);

                        oldCommandInfo = f_1463_11928_11953(commandInfoProperty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 11976, 12031);

                        commandInfoProperty.Value = f_1463_12004_12030(callingCommand);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 11669, 12050);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12070, 12125);

                    stackTraceProperty = f_1463_12091_12124(f_1463_12091_12110(newValue), "StackTrace");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12143, 12537) || true) && (stackTraceProperty == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 12143, 12537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12215, 12310);

                        f_1463_12215_12309(f_1463_12215_12234(newValue), f_1463_12239_12308("StackTrace", f_1463_12272_12307()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 12143, 12537);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 12143, 12537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12392, 12433);

                        oldStackTrace = f_1463_12408_12432(stackTraceProperty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12455, 12518);

                        stackTraceProperty.Value = f_1463_12482_12517();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 12143, 12537);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12557, 12638);

                    f_1463_12557_12637(f_1463_12557_12564(), SpecialVariables.CurrentlyExecutingCommandVarPath, newValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 10931, 12653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12669, 12701);

                f_1463_12669_12700(
                            _contextStack, contextData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12715, 12823);

                f_1463_12715_12822(f_1463_12726_12745(_contextStack) == f_1463_12749_12766(), "number of saved contexts should equal nesting count");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12839, 12872);

                f_1463_12839_12846().PSDebugTraceStep = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12886, 12916);

                f_1463_12886_12893().PSDebugTraceLevel = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 12930, 12974);

                f_1463_12930_12973(f_1463_12930_12937());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13050, 13211) || true) && (f_1463_13054_13104(f_1463_13054_13061()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 13050, 13211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13138, 13196);

                    f_1463_13138_13145().LanguageMode = PSLanguageMode.ConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 13050, 13211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13227, 13337);

                f_1463_13227_13336(f_1463_13227_13255(f_1463_13227_13239(this)), RunspaceAvailability.AvailableForNestedCommand, true);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13389, 13432);

                    f_1463_13389_13431(f_1463_13389_13411(_externalHostRef));
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1463, 13461, 13917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13853, 13878);

                    f_1463_13853_13877(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13896, 13902);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1463, 13461, 13917);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1463, 13931, 14273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 13971, 14106) || true) && (commandInfoProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 13971, 14106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14044, 14087);

                        commandInfoProperty.Value = oldCommandInfo;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 13971, 14106);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14126, 14258) || true) && (stackTraceProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 14126, 14258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14198, 14239);

                        stackTraceProperty.Value = oldStackTrace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 14126, 14258);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1463, 13931, 14273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14289, 14384);

                f_1463_14289_14383(f_1463_14300_14317() >= 0, "nestedPromptCounter should be greater than or equal to 0");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 8091, 14395);

                System.Management.Automation.Runspaces.Runspace
                f_1463_8502_8515(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 8502, 8515);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1463_8697_8710(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 8697, 8710);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Pipeline
                f_1463_8697_8740(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.GetCurrentlyRunningPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 8697, 8740);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PipelineBase
                f_1463_8853_8880(System.Management.Automation.Runspaces.LocalRunspace
                this_param)
                {
                    var return_v = this_param.PulsePipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 8853, 8880);
                    return return_v;
                }


                System.InvalidOperationException
                f_1463_8910_8941()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 8910, 8941);
                    return return_v;
                }


                int
                f_1463_9314_9331()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 9314, 9331);
                    return return_v;
                }


                int
                f_1463_9369_9437(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 9369, 9437);
                    return 0;
                }


                string
                f_1463_9527_9577()
                {
                    var return_v = InternalHostStrings.EnterExitNestedPromptOutOfSync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 9527, 9577);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1463_9462_9578(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 9462, 9578);
                    return return_v;
                }


                int
                f_1463_9930_9949_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 9930, 9949);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_9964_9971()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 9964, 9971);
                    return return_v;
                }


                int
                f_1463_10029_10046()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10029, 10046);
                    return return_v;
                }


                int
                f_1463_9964_10047(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 9964, 10047);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHost.PromptContextData
                f_1463_10193_10216()
                {
                    var return_v = new System.Management.Automation.Internal.Host.InternalHost.PromptContextData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 10193, 10216);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_10262_10269()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10262, 10269);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext.SavedContextData
                f_1463_10262_10287(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SaveContextData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 10262, 10287);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_10355_10362()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10355, 10362);
                    return return_v;
                }


                object
                f_1463_10355_10430(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 10355, 10430);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_10490_10497()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10490, 10497);
                    return return_v;
                }


                object
                f_1463_10490_10557(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 10490, 10557);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_10607_10619(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10607, 10619);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1463_10607_10635(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10607, 10635);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1463_10607_10656(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10607, 10656);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_10698_10705()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10698, 10705);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1463_10698_10718(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 10698, 10718);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_11002_11024(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11002, 11024);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_11028_11035()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11028, 11035);
                    return return_v;
                }


                int
                f_1463_10991_11079(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 10991, 11079);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1463_11538_11573(System.Management.Automation.Internal.InternalCommand
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 11538, 11573);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1463_11616_11635(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11616, 11635);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1463_11616_11650(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11616, 11650);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1463_11742_11761(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11742, 11761);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1463_11800_11826(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11800, 11826);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1463_11766_11827(string
                name, System.Management.Automation.CommandInfo
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 11766, 11827);
                    return return_v;
                }


                int
                f_1463_11742_11828(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 11742, 11828);
                    return 0;
                }


                object
                f_1463_11928_11953(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 11928, 11953);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1463_12004_12030(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12004, 12030);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1463_12091_12110(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12091, 12110);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1463_12091_12124(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12091, 12124);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1463_12215_12234(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12215, 12234);
                    return return_v;
                }


                System.Diagnostics.StackTrace
                f_1463_12272_12307()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12272, 12307);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1463_12239_12308(string
                name, System.Diagnostics.StackTrace
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12239, 12308);
                    return return_v;
                }


                int
                f_1463_12215_12309(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12215, 12309);
                    return 0;
                }


                object
                f_1463_12408_12432(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12408, 12432);
                    return return_v;
                }


                System.Diagnostics.StackTrace
                f_1463_12482_12517()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12482, 12517);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_12557_12564()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12557, 12564);
                    return return_v;
                }


                int
                f_1463_12557_12637(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, System.Management.Automation.PSObject
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12557, 12637);
                    return 0;
                }


                int
                f_1463_12669_12700(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param, System.Management.Automation.Internal.Host.InternalHost.PromptContextData
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12669, 12700);
                    return 0;
                }


                int
                f_1463_12726_12745(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12726, 12745);
                    return return_v;
                }


                int
                f_1463_12749_12766()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12749, 12766);
                    return return_v;
                }


                int
                f_1463_12715_12822(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12715, 12822);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1463_12839_12846()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12839, 12846);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_12886_12893()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12886, 12893);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_12930_12937()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 12930, 12937);
                    return return_v;
                }


                int
                f_1463_12930_12973(System.Management.Automation.ExecutionContext
                this_param)
                {
                    this_param.ResetShellFunctionErrorOutputPipe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 12930, 12973);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1463_13054_13061()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13054, 13061);
                    return return_v;
                }


                bool
                f_1463_13054_13104(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.HasRunspaceEverUsedConstrainedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13054, 13104);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_13138_13145()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13138, 13145);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_13227_13239(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13227, 13239);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1463_13227_13255(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13227, 13255);
                    return return_v;
                }


                int
                f_1463_13227_13336(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailability
                availability, bool
                raiseEvent)
                {
                    this_param.UpdateRunspaceAvailability(availability, raiseEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 13227, 13336);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1463_13389_13411(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 13389, 13411);
                    return return_v;
                }


                int
                f_1463_13389_13431(System.Management.Automation.Host.PSHost
                this_param)
                {
                    this_param.EnterNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 13389, 13431);
                    return 0;
                }


                int
                f_1463_13853_13877(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.ExitNestedPromptHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 13853, 13877);
                    return 0;
                }


                int
                f_1463_14300_14317()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14300, 14317);
                    return return_v;
                }


                int
                f_1463_14289_14383(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 14289, 14383);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 8091, 14395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 8091, 14395);
            }
        }

        private void ExitNestedPromptHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 14407, 15491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14469, 14489);

                f_1463_14469_14488_M(--NestedPromptCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14503, 14587);

                f_1463_14503_14586(f_1463_14503_14510(), SpecialVariables.NestedPromptCounterVarPath, f_1463_14568_14585());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14647, 14737);

                f_1463_14647_14736(f_1463_14658_14677(_contextStack) > 0, "ExitNestedPrompt: called without any saved context");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14753, 15356) || true) && (f_1463_14757_14776(_contextStack) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 14753, 15356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14814, 14858);

                    PromptContextData
                    pcd = f_1463_14838_14857(_contextStack)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14878, 14927);

                    f_1463_14878_14926(
                                    pcd.SavedContextData, f_1463_14918_14925());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 14945, 14985);

                    f_1463_14945_14952().LanguageMode = pcd.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15003, 15118);

                    f_1463_15003_15117(f_1463_15003_15010(), SpecialVariables.CurrentlyExecutingCommandVarPath, pcd.SavedCurrentlyExecutingCommandVarValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15136, 15235);

                    f_1463_15136_15234(f_1463_15136_15143(), SpecialVariables.PSBoundParametersVarPath, pcd.SavedPSBoundParametersVarValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15253, 15341);

                    f_1463_15253_15340(f_1463_15253_15281(f_1463_15253_15265(this)), pcd.RunspaceAvailability, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 14753, 15356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15372, 15480);

                f_1463_15372_15479(f_1463_15383_15402(_contextStack) == f_1463_15406_15423(), "number of saved contexts should equal nesting count");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 14407, 15491);

                int
                f_1463_14469_14488_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14469, 14488);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_14503_14510()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14503, 14510);
                    return return_v;
                }


                int
                f_1463_14568_14585()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14568, 14585);
                    return return_v;
                }


                int
                f_1463_14503_14586(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, int
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 14503, 14586);
                    return 0;
                }


                int
                f_1463_14658_14677(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14658, 14677);
                    return return_v;
                }


                int
                f_1463_14647_14736(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 14647, 14736);
                    return 0;
                }


                int
                f_1463_14757_14776(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14757, 14776);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost.PromptContextData
                f_1463_14838_14857(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 14838, 14857);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_14918_14925()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14918, 14925);
                    return return_v;
                }


                int
                f_1463_14878_14926(System.Management.Automation.ExecutionContext.SavedContextData
                this_param, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.RestoreContextData(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 14878, 14926);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1463_14945_14952()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 14945, 14952);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1463_15003_15010()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15003, 15010);
                    return return_v;
                }


                int
                f_1463_15003_15117(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, object
                newValue)
                {
                    this_param.SetVariable(path, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15003, 15117);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1463_15136_15143()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15136, 15143);
                    return return_v;
                }


                int
                f_1463_15136_15234(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, object
                newValue)
                {
                    this_param.SetVariable(path, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15136, 15234);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1463_15253_15265(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15253, 15265);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1463_15253_15281(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15253, 15281);
                    return return_v;
                }


                int
                f_1463_15253_15340(System.Management.Automation.Runspaces.Runspace
                this_param, System.Management.Automation.Runspaces.RunspaceAvailability
                availability, bool
                raiseEvent)
                {
                    this_param.UpdateRunspaceAvailability(availability, raiseEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15253, 15340);
                    return 0;
                }


                int
                f_1463_15383_15402(System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15383, 15402);
                    return return_v;
                }


                int
                f_1463_15406_15423()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15406, 15423);
                    return return_v;
                }


                int
                f_1463_15372_15479(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15372, 15479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 14407, 15491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 14407, 15491);
            }
        }

        public override void ExitNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 15629, 16176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15693, 15788);

                f_1463_15693_15787(f_1463_15704_15721() >= 0, "nestedPromptCounter should be greater than or equal to 0");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15804, 15856) || true) && (f_1463_15808_15825() == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 15804, 15856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15849, 15856);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 15804, 15856);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 15908, 15950);

                    f_1463_15908_15949(f_1463_15908_15930(_externalHostRef));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1463, 15979, 16059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16019, 16044);

                    f_1463_16019_16043(this);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1463, 15979, 16059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16075, 16140);

                ExitNestedPromptException
                enpe = f_1463_16108_16139()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16154, 16165);

                throw enpe;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 15629, 16176);

                int
                f_1463_15704_15721()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15704, 15721);
                    return return_v;
                }


                int
                f_1463_15693_15787(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15693, 15787);
                    return 0;
                }


                int
                f_1463_15808_15825()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15808, 15825);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1463_15908_15930(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 15908, 15930);
                    return return_v;
                }


                int
                f_1463_15908_15949(System.Management.Automation.Host.PSHost
                this_param)
                {
                    this_param.ExitNestedPrompt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 15908, 15949);
                    return 0;
                }


                int
                f_1463_16019_16043(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    this_param.ExitNestedPromptHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 16019, 16043);
                    return 0;
                }


                System.Management.Automation.ExitNestedPromptException
                f_1463_16108_16139()
                {
                    var return_v = new System.Management.Automation.ExitNestedPromptException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 16108, 16139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 15629, 16176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 15629, 16176);
            }
        }

        public override PSObject PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 16325, 16461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16361, 16414);

                    PSObject
                    result = f_1463_16379_16413(f_1463_16379_16401(_externalHostRef))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16432, 16446);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 16325, 16461);

                    System.Management.Automation.Host.PSHost
                    f_1463_16379_16401(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 16379, 16401);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1463_16379_16413(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.PrivateData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 16379, 16413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 16264, 16472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 16264, 16472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void NotifyBeginApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 16611, 16740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 16681, 16729);

                f_1463_16681_16728(f_1463_16681_16703(_externalHostRef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 16611, 16740);

                System.Management.Automation.Host.PSHost
                f_1463_16681_16703(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 16681, 16703);
                    return return_v;
                }


                int
                f_1463_16681_16728(System.Management.Automation.Host.PSHost
                this_param)
                {
                    this_param.NotifyBeginApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 16681, 16728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 16611, 16740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 16611, 16740);
            }
        }

        public override void NotifyEndApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 16960, 17085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17028, 17074);

                f_1463_17028_17073(f_1463_17028_17050(_externalHostRef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 16960, 17085);

                System.Management.Automation.Host.PSHost
                f_1463_17028_17050(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 17028, 17050);
                    return return_v;
                }


                int
                f_1463_17028_17073(System.Management.Automation.Host.PSHost
                this_param)
                {
                    this_param.NotifyEndApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 17028, 17073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 16960, 17085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 16960, 17085);
            }
        }

        public override bool DebuggerEnabled { get; set; }

        private IHostSupportsInteractiveSession GetIHostSupportsInteractiveSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 17505, 17859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17606, 17703);

                IHostSupportsInteractiveSession
                host = f_1463_17645_17667(_externalHostRef) as IHostSupportsInteractiveSession
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17717, 17820) || true) && (host == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 17717, 17820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17767, 17805);

                    throw f_1463_17773_17804();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 17717, 17820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 17836, 17848);

                return host;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 17505, 17859);

                System.Management.Automation.Host.PSHost
                f_1463_17645_17667(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 17645, 17667);
                    return return_v;
                }


                System.Management.Automation.PSNotImplementedException
                f_1463_17773_17804()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 17773, 17804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 17505, 17859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 17505, 17859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void PushRunspace(System.Management.Automation.Runspaces.Runspace runspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 18055, 18291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18162, 18238);

                IHostSupportsInteractiveSession
                host = f_1463_18201_18237(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18252, 18280);

                f_1463_18252_18279(host, runspace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 18055, 18291);

                System.Management.Automation.Host.IHostSupportsInteractiveSession
                f_1463_18201_18237(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.GetIHostSupportsInteractiveSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 18201, 18237);
                    return return_v;
                }


                int
                f_1463_18252_18279(System.Management.Automation.Host.IHostSupportsInteractiveSession
                this_param, System.Management.Automation.Runspaces.Runspace
                runspace)
                {
                    this_param.PushRunspace(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 18252, 18279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 18055, 18291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 18055, 18291);
            }
        }

        public void PopRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 18487, 18657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18537, 18613);

                IHostSupportsInteractiveSession
                host = f_1463_18576_18612(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18627, 18646);

                f_1463_18627_18645(host);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 18487, 18657);

                System.Management.Automation.Host.IHostSupportsInteractiveSession
                f_1463_18576_18612(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.GetIHostSupportsInteractiveSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 18576, 18612);
                    return return_v;
                }


                int
                f_1463_18627_18645(System.Management.Automation.Host.IHostSupportsInteractiveSession
                this_param)
                {
                    this_param.PopRunspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 18627, 18645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 18487, 18657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 18487, 18657);
            }
        }

        public bool IsRunspacePushed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 18829, 19003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18865, 18941);

                    IHostSupportsInteractiveSession
                    host = f_1463_18904_18940(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 18959, 18988);

                    return f_1463_18966_18987(host);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 18829, 19003);

                    System.Management.Automation.Host.IHostSupportsInteractiveSession
                    f_1463_18904_18940(System.Management.Automation.Internal.Host.InternalHost
                    this_param)
                    {
                        var return_v = this_param.GetIHostSupportsInteractiveSession();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 18904, 18940);
                        return return_v;
                    }


                    bool
                    f_1463_18966_18987(System.Management.Automation.Host.IHostSupportsInteractiveSession
                    this_param)
                    {
                        var return_v = this_param.IsRunspacePushed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 18966, 18987);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 18776, 19014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 18776, 19014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Runspace Runspace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 19191, 19357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 19227, 19303);

                    IHostSupportsInteractiveSession
                    host = f_1463_19266_19302(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 19321, 19342);

                    return f_1463_19328_19341(host);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 19191, 19357);

                    System.Management.Automation.Host.IHostSupportsInteractiveSession
                    f_1463_19266_19302(System.Management.Automation.Internal.Host.InternalHost
                    this_param)
                    {
                        var return_v = this_param.GetIHostSupportsInteractiveSession();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 19266, 19302);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.Runspace
                    f_1463_19328_19341(System.Management.Automation.Host.IHostSupportsInteractiveSession
                    this_param)
                    {
                        var return_v = this_param.Runspace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 19328, 19341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 19142, 19368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 19142, 19368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HostInNestedPrompt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 19576, 19811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 19635, 19800) || true) && (f_1463_19639_19656() > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 19635, 19800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 19694, 19706);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 19635, 19800);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 19635, 19800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 19772, 19785);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 19635, 19800);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 19576, 19811);

                int
                f_1463_19639_19656()
                {
                    var return_v = NestedPromptCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 19639, 19656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 19576, 19811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 19576, 19811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetHostRef(PSHost psHost)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 20258, 20453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20322, 20356);

                f_1463_20322_20355(_externalHostRef, psHost);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20370, 20442);

                f_1463_20370_20441(_internalUIRef, f_1463_20394_20440(f_1463_20424_20433(psHost), this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 20258, 20453);

                int
                f_1463_20322_20355(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param, System.Management.Automation.Host.PSHost
                newValue)
                {
                    this_param.Override(newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 20322, 20355);
                    return 0;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1463_20424_20433(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 20424, 20433);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1463_20394_20440(System.Management.Automation.Host.PSHostUserInterface
                externalUI, System.Management.Automation.Internal.Host.InternalHost
                parentHost)
                {
                    var return_v = new System.Management.Automation.Internal.Host.InternalHostUserInterface(externalUI, parentHost);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 20394, 20440);
                    return return_v;
                }


                int
                f_1463_20370_20441(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>
                this_param, System.Management.Automation.Internal.Host.InternalHostUserInterface
                newValue)
                {
                    this_param.Override(newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 20370, 20441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 20258, 20453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 20258, 20453);
            }
        }

        internal void RevertHostRef()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 20666, 20905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20784, 20814) || true) && (f_1463_20788_20801_M(!IsHostRefSet))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1463, 20784, 20814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20805, 20812);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1463, 20784, 20814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20830, 20856);

                f_1463_20830_20855(
                            _externalHostRef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 20870, 20894);

                f_1463_20870_20893(_internalUIRef);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 20666, 20905);

                bool
                f_1463_20788_20801_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 20788, 20801);
                    return return_v;
                }


                int
                f_1463_20830_20855(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                this_param)
                {
                    this_param.Revert();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 20830, 20855);
                    return 0;
                }


                int
                f_1463_20870_20893(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>
                this_param)
                {
                    this_param.Revert();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 20870, 20893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 20666, 20905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 20666, 20905);
            }
        }

        internal bool IsHostRefSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 21135, 21180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21141, 21178);

                    return f_1463_21148_21177(_externalHostRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 21135, 21180);

                    bool
                    f_1463_21148_21177(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.IsOverridden;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 21148, 21177);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 21084, 21191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 21084, 21191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ExecutionContext Context { get; }

        internal PSHost ExternalHost
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1463, 21310, 21391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1463, 21346, 21376);

                    return f_1463_21353_21375(_externalHostRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1463, 21310, 21391);

                    System.Management.Automation.Host.PSHost
                    f_1463_21353_21375(System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 21353, 21375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1463, 21257, 21402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 21257, 21402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int NestedPromptCount { get; private set; }

        private ObjectRef<PSHost> _externalHostRef;

        private ObjectRef<InternalHostUserInterface> _internalUIRef;

        private string _nameResult;

        private Version _versionResult;

        private Guid _idResult;

        private Stack<PromptContextData> _contextStack;

        private readonly Guid _zeroGuid;

        static InternalHost()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1463, 1136, 21906);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1463, 1136, 21906);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1463, 1136, 21906);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1463, 1136, 21906);

        int
        f_1463_2151_2208(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2151, 2208);
            return 0;
        }


        int
        f_1463_2223_2325(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2223, 2325);
            return 0;
        }


        int
        f_1463_2342_2413(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2342, 2413);
            return 0;
        }


        System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>
        f_1463_2449_2484(System.Management.Automation.Host.PSHost
        oldValue)
        {
            var return_v = new System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Host.PSHost>(oldValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2449, 2484);
            return return_v;
        }


        System.Management.Automation.Host.PSHostUserInterface
        f_1463_2567_2582(System.Management.Automation.Host.PSHost
        this_param)
        {
            var return_v = this_param.UI;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1463, 2567, 2582);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHostUserInterface
        f_1463_2657_2696(System.Management.Automation.Host.PSHostUserInterface
        externalUI, System.Management.Automation.Internal.Host.InternalHost
        parentHost)
        {
            var return_v = new System.Management.Automation.Internal.Host.InternalHostUserInterface(externalUI, parentHost);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2657, 2696);
            return return_v;
        }


        System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>
        f_1463_2616_2697(System.Management.Automation.Internal.Host.InternalHostUserInterface
        oldValue)
        {
            var return_v = new System.Management.Automation.Remoting.ObjectRef<System.Management.Automation.Internal.Host.InternalHostUserInterface>(oldValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2616, 2697);
            return return_v;
        }


        System.Guid
        f_1463_2724_2765(int
        a, int
        b, int
        c, int
        d, int
        e, int
        f, int
        g, int
        h, int
        i, int
        j, int
        k)
        {
            var return_v = new System.Guid(a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 2724, 2765);
            return return_v;
        }


        System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>
        f_1463_21824_21854()
        {
            var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Internal.Host.InternalHost.PromptContextData>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1463, 21824, 21854);
            return return_v;
        }

    }
}
