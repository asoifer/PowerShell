// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;

namespace System.Management.Automation
{
    public class PSVariable : IHasSessionStateEntryVisibility
    {
        public PSVariable(string name)
        : this(f_1361_934_938_C(name), null, ScopedItemOptions.None, (Collection<Attribute>)null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 883, 1020);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 883, 1020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 883, 1020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 883, 1020);
            }
        }

        public PSVariable(string name, object value)
        : this(f_1361_1535_1539_C(name), value, ScopedItemOptions.None, (Collection<Attribute>)null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 1470, 1622);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 1470, 1622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 1470, 1622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 1470, 1622);
            }
        }

        public PSVariable(string name, object value, ScopedItemOptions options)
        : this(f_1361_2352_2356_C(name), value, options, (Collection<Attribute>)null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 2260, 2424);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 2260, 2424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 2260, 2424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 2260, 2424);
            }
        }

        internal PSVariable(string name, object value, ScopedItemOptions options, string description)
        : this(f_1361_3298_3302_C(name), value, options, (Collection<Attribute>)null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 3184, 3411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 3373, 3400);

                _description = description;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 3184, 3411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 3184, 3411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 3184, 3411);
            }
        }

        internal PSVariable(
                    string name,
                    object value,
                    ScopedItemOptions options,
                    Collection<Attribute> attributes,
                    string description)
        : this(f_1361_4606_4610_C(name), value, options, attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 4388, 4702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 4664, 4691);

                _description = description;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 4388, 4702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 4388, 4702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 4388, 4702);
            }
        }

        public PSVariable(
                    string name,
                    object value,
                    ScopedItemOptions options,
                    Collection<Attribute> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 5773, 6838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7433, 7476);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7849, 7876);
                this._description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9494, 9500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9634, 9731);
                this.Visibility = SessionStateEntryVisibility.Public;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9847, 9895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13317, 13350);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13876, 13887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21139, 21150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21163, 21219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24143, 24261);
                this._copyMutableValueSite = f_1361_24180_24261(f_1361_24228_24260());
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 5956, 6084) || true) && (f_1361_5960_5986(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 5956, 6084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6020, 6069);

                    throw f_1361_6026_6068("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 5956, 6084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6100, 6112);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6128, 6182);

                _attributes = f_1361_6142_6181(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6349, 6378);

                f_1361_6349_6377(this, value, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6394, 6595) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 6394, 6595);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6450, 6580);
                        foreach (Attribute attribute in f_1361_6482_6492_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 6450, 6580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6534, 6561);

                            f_1361_6534_6560(_attributes, attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 6450, 6580);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1361, 1, 131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1361, 1, 131);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 6394, 6595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6676, 6695);

                _options = options;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6711, 6827) || true) && (f_1361_6715_6725())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 6711, 6827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 6759, 6812);

                    f_1361_6759_6811(name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 6711, 6827);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 5773, 6838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 5773, 6838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 5773, 6838);
            }
        }

        internal PSVariable(string name, bool dummy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 7211, 7303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7433, 7476);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7849, 7876);
                this._description = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9494, 9500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9634, 9731);
                this.Visibility = SessionStateEntryVisibility.Public;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9847, 9895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13317, 13350);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13876, 13887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21139, 21150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21163, 21219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24143, 24261);
                this._copyMutableValueSite = f_1361_24180_24261(f_1361_24228_24260());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7280, 7292);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 7211, 7303);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 7211, 7303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 7211, 7303);
            }
        }

        public string Name { get; }

        public virtual string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 7652, 7723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7688, 7708);

                    return _description;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 7652, 7723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 7594, 7822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 7594, 7822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 7739, 7811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7775, 7796);

                    _description = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 7739, 7811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 7594, 7822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 7594, 7822);
                }
            }
        }

        private string _description;

        internal void DebuggerCheckVariableRead()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 7889, 8293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 7955, 8129);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(1361, 7969, 7989) || ((f_1361_7969_7981() != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1361, 8023, 8052)) || DynAbs.Tracing.TraceSender.Conditional_F3(1361, 8086, 8128))) ? f_1361_8023_8052(f_1361_8023_8035()) : f_1361_8086_8128()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 8143, 8282) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1361, 8147, 8192) && context._debuggingMode > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 8143, 8282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 8226, 8267);

                    f_1361_8226_8266(f_1361_8226_8242(context), f_1361_8261_8265());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 8143, 8282);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 7889, 8293);

                System.Management.Automation.SessionStateInternal
                f_1361_7969_7981()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 7969, 7981);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1361_8023_8035()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8023, 8035);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1361_8023_8052(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8023, 8052);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1361_8086_8128()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 8086, 8128);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1361_8226_8242(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8226, 8242);
                    return return_v;
                }


                string
                f_1361_8261_8265()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8261, 8265);
                    return return_v;
                }


                int
                f_1361_8226_8266(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableRead(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 8226, 8266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 7889, 8293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 7889, 8293);
            }
        }

        internal void DebuggerCheckVariableWrite()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 8305, 8711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 8372, 8546);

                var
                context = (DynAbs.Tracing.TraceSender.Conditional_F1(1361, 8386, 8406) || ((f_1361_8386_8398() != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1361, 8440, 8469)) || DynAbs.Tracing.TraceSender.Conditional_F3(1361, 8503, 8545))) ? f_1361_8440_8469(f_1361_8440_8452()) : f_1361_8503_8545()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 8560, 8700) || true) && (context != null && (DynAbs.Tracing.TraceSender.Expression_True(1361, 8564, 8609) && context._debuggingMode > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 8560, 8700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 8643, 8685);

                    f_1361_8643_8684(f_1361_8643_8659(context), f_1361_8679_8683());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 8560, 8700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 8305, 8711);

                System.Management.Automation.SessionStateInternal
                f_1361_8386_8398()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8386, 8398);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1361_8440_8452()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8440, 8452);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1361_8440_8469(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8440, 8469);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1361_8503_8545()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 8503, 8545);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1361_8643_8659(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8643, 8659);
                    return return_v;
                }


                string
                f_1361_8679_8683()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 8679, 8683);
                    return return_v;
                }


                int
                f_1361_8643_8684(System.Management.Automation.ScriptDebugger
                this_param, string
                variableName)
                {
                    this_param.CheckVariableWrite(variableName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 8643, 8684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 8305, 8711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 8305, 8711);
            }
        }

        public virtual object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 9262, 9373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9298, 9326);

                    f_1361_9298_9325(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9344, 9358);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 9262, 9373);

                    int
                    f_1361_9298_9325(System.Management.Automation.PSVariable
                    this_param)
                    {
                        this_param.DebuggerCheckVariableRead();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 9298, 9325);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 9210, 9467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 9210, 9467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 9389, 9456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9425, 9441);

                    f_1361_9425_9440(this, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 9389, 9456);

                    int
                    f_1361_9425_9440(System.Management.Automation.PSVariable
                    this_param, object
                    value)
                    {
                        this_param.SetValue(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 9425, 9440);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 9210, 9467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 9210, 9467);
                }
            }
        }

        private object _value;

        public SessionStateEntryVisibility Visibility { get; set; }

        public PSModuleInfo Module { get; private set; }

        internal void SetModule(PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 9907, 10003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 9976, 9992);

                Module = module;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 9907, 10003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 9907, 10003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 9907, 10003);
            }
        }

        public string ModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 10175, 10324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 10211, 10271) || true) && (f_1361_10215_10221() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 10211, 10271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 10252, 10271);

                        return f_1361_10259_10270(f_1361_10259_10265());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 10211, 10271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 10289, 10309);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 10175, 10324);

                    System.Management.Automation.PSModuleInfo
                    f_1361_10215_10221()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 10215, 10221);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1361_10259_10265()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 10259, 10265);
                        return return_v;
                    }


                    string
                    f_1361_10259_10270(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 10259, 10270);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 10126, 10335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 10126, 10335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 10741, 10808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 10777, 10793);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 10741, 10808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 10676, 10911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 10676, 10911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 10824, 10900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 10860, 10885);

                    f_1361_10860_10884(this, value, false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 10824, 10900);

                    int
                    f_1361_10860_10884(System.Management.Automation.PSVariable
                    this_param, System.Management.Automation.ScopedItemOptions
                    newOptions, bool
                    force)
                    {
                        this_param.SetOptions(newOptions, force);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 10860, 10884);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 10676, 10911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 10676, 10911);
                }
            }
        }

        internal void SetOptions(ScopedItemOptions newOptions, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 10923, 13279);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 11166, 11610) || true) && (f_1361_11170_11180() || (DynAbs.Tracing.TraceSender.Expression_False(1361, 11170, 11206) || (!force && (DynAbs.Tracing.TraceSender.Expression_True(1361, 11185, 11205) && f_1361_11195_11205()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 11166, 11610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 11240, 11567);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1361_11305_11566(f_1361_11379_11383(), SessionStateCategory.Variable, "VariableNotWritable", f_1361_11526_11565())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 11587, 11595);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 11166, 11610);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 11791, 12414) || true) && ((newOptions & ScopedItemOptions.Constant) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 11791, 12414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 12026, 12371);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1361_12091_12370(f_1361_12165_12169(), SessionStateCategory.Variable, "VariableCannotBeMadeConstant", f_1361_12321_12369())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 12391, 12399);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 11791, 12414);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 12585, 13230) || true) && (f_1361_12589_12599() && (DynAbs.Tracing.TraceSender.Expression_True(1361, 12589, 12651) && ((newOptions & ScopedItemOptions.AllScope) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 12585, 13230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 12824, 13187);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1361_12889_13186(f_1361_12963_12967(), SessionStateCategory.Variable, "VariableAllScopeOptionCannotBeRemoved", f_1361_13128_13185())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13207, 13215);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 12585, 13230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13246, 13268);

                _options = newOptions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 10923, 13279);

                bool
                f_1361_11170_11180()
                {
                    var return_v = IsConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 11170, 11180);
                    return return_v;
                }


                bool
                f_1361_11195_11205()
                {
                    var return_v = IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 11195, 11205);
                    return return_v;
                }


                string
                f_1361_11379_11383()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 11379, 11383);
                    return return_v;
                }


                string
                f_1361_11526_11565()
                {
                    var return_v = SessionStateStrings.VariableNotWritable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 11526, 11565);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1361_11305_11566(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 11305, 11566);
                    return return_v;
                }


                string
                f_1361_12165_12169()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 12165, 12169);
                    return return_v;
                }


                string
                f_1361_12321_12369()
                {
                    var return_v = SessionStateStrings.VariableCannotBeMadeConstant;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 12321, 12369);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1361_12091_12370(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 12091, 12370);
                    return return_v;
                }


                bool
                f_1361_12589_12599()
                {
                    var return_v = IsAllScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 12589, 12599);
                    return return_v;
                }


                string
                f_1361_12963_12967()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 12963, 12967);
                    return return_v;
                }


                string
                f_1361_13128_13185()
                {
                    var return_v = SessionStateStrings.VariableAllScopeOptionCannotBeRemoved;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 13128, 13185);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1361_12889_13186(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 12889, 13186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 10923, 13279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 10923, 13279);
            }
        }

        private ScopedItemOptions _options;

        public Collection<Attribute> Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 13729, 13815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 13735, 13813);

                    return _attributes ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSVariableAttributeCollection>(1361, 13742, 13812) ?? (_attributes = f_1361_13772_13811(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 13729, 13815);

                    System.Management.Automation.PSVariableAttributeCollection
                    f_1361_13772_13811(System.Management.Automation.PSVariable
                    variable)
                    {
                        var return_v = new System.Management.Automation.PSVariableAttributeCollection(variable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 13772, 13811);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 13665, 13826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 13665, 13826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSVariableAttributeCollection _attributes;

        public virtual bool IsValidValue(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 14466, 14588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 14537, 14577);

                return f_1361_14544_14576(_attributes, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 14466, 14588);

                bool
                f_1361_14544_14576(System.Management.Automation.PSVariableAttributeCollection
                attributes, object
                value)
                {
                    var return_v = IsValidValue((System.Collections.Generic.IEnumerable<System.Attribute>)attributes, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 14544, 14576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 14466, 14588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 14466, 14588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidValue(IEnumerable<Attribute> attributes, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1361, 14600, 15041);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 14707, 15002) || true) && (attributes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 14707, 15002);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 14763, 14987);
                        foreach (Attribute attribute in f_1361_14795_14805_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 14763, 14987);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 14847, 14968) || true) && (!f_1361_14852_14882(value, attribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 14847, 14968);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 14932, 14945);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 14847, 14968);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 14763, 14987);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1361, 1, 225);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1361, 1, 225);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 14707, 15002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 15018, 15030);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1361, 14600, 15041);

                bool
                f_1361_14852_14882(object
                value, System.Attribute
                attribute)
                {
                    var return_v = IsValidValue(value, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 14852, 14882);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Attribute>
                f_1361_14795_14805_I(System.Collections.Generic.IEnumerable<System.Attribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 14795, 14805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 14600, 15041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 14600, 15041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidValue(object value, Attribute attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1361, 15532, 16526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 15625, 15644);

                bool
                result = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 15660, 15749);

                ValidateArgumentsAttribute
                validationAttribute = attribute as ValidateArgumentsAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 15763, 16485) || true) && (validationAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 15763, 16485);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 15964, 16044);

                        ExecutionContext
                        context = f_1361_15991_16043()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16066, 16097);

                        EngineIntrinsics
                        engine = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16121, 16247) || true) && (context != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 16121, 16247);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16190, 16224);

                            engine = f_1361_16199_16223(context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 16121, 16247);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16271, 16323);

                        f_1361_16271_16322(
                                            validationAttribute, value, engine);
                    }
                    catch (ValidationMetadataException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1361, 16360, 16470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16436, 16451);

                        result = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1361, 16360, 16470);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 15763, 16485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 16501, 16515);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1361, 15532, 16526);

                System.Management.Automation.ExecutionContext
                f_1361_15991_16043()
                {
                    var return_v = Runspaces.LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 15991, 16043);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1361_16199_16223(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 16199, 16223);
                    return return_v;
                }


                int
                f_1361_16271_16322(System.Management.Automation.ValidateArgumentsAttribute
                this_param, object
                o, System.Management.Automation.EngineIntrinsics
                engineIntrinsics)
                {
                    this_param.InternalValidate(o, engineIntrinsics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 16271, 16322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 15532, 16526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 15532, 16526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object TransformValue(IEnumerable<Attribute> attributes, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1361, 17216, 18243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17327, 17409);

                f_1361_17327_17408(attributes != null, "caller to verify attributes is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17425, 17447);

                object
                result = value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17547, 17627);

                ExecutionContext
                context = f_1361_17574_17626()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17641, 17672);

                EngineIntrinsics
                engine = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17688, 17790) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 17688, 17790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17741, 17775);

                    engine = f_1361_17750_17774(context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 17688, 17790);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17806, 18202);
                    foreach (Attribute attribute in f_1361_17838_17848_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 17806, 18202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 17882, 18006);

                        ArgumentTransformationAttribute
                        transformationAttribute =
                                            attribute as ArgumentTransformationAttribute
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 18024, 18187) || true) && (transformationAttribute != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 18024, 18187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 18101, 18168);

                            result = f_1361_18110_18167(transformationAttribute, engine, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 18024, 18187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 17806, 18202);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1361, 1, 397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1361, 1, 397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 18218, 18232);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1361, 17216, 18243);

                int
                f_1361_17327_17408(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 17327, 17408);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1361_17574_17626()
                {
                    var return_v = Runspaces.LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 17574, 17626);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1361_17750_17774(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 17750, 17774);
                    return return_v;
                }


                object
                f_1361_18110_18167(System.Management.Automation.ArgumentTransformationAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData)
                {
                    var return_v = this_param.TransformInternal(engineIntrinsics, inputData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 18110, 18167);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Attribute>
                f_1361_17838_17848_I(System.Collections.Generic.IEnumerable<System.Attribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 17838, 17848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 17216, 18243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 17216, 18243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddParameterAttributesNoChecks(Collection<Attribute> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 18615, 18863);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 18718, 18852);
                    foreach (Attribute attribute in f_1361_18750_18760_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 18718, 18852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 18794, 18837);

                        f_1361_18794_18836(_attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 18718, 18852);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1361, 1, 135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1361, 1, 135);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 18615, 18863);

                int
                f_1361_18794_18836(System.Management.Automation.PSVariableAttributeCollection
                this_param, System.Attribute
                item)
                {
                    this_param.AddAttributeNoCheck(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 18794, 18836);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1361_18750_18760_I(System.Collections.ObjectModel.Collection<System.Attribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 18750, 18760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 18615, 18863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 18615, 18863);
            }
        }

        internal bool IsConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 19130, 19233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 19166, 19218);

                    return (_options & ScopedItemOptions.Constant) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 19130, 19233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 19081, 19244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 19081, 19244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 19475, 19578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 19511, 19563);

                    return (_options & ScopedItemOptions.ReadOnly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 19475, 19578);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 19426, 19589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 19426, 19589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsPrivate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 19818, 19920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 19854, 19905);

                    return (_options & ScopedItemOptions.Private) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 19818, 19920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 19770, 19931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 19770, 19931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsAllScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 20151, 20254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20187, 20239);

                    return (_options & ScopedItemOptions.AllScope) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 20151, 20254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 20102, 20265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 20102, 20265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool WasRemoved
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 20645, 20715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20681, 20700);

                    return _wasRemoved;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 20645, 20715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 20596, 21114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 20596, 21114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 20731, 21103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20767, 20787);

                    _wasRemoved = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20866, 21088) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 20866, 21088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20917, 20951);

                        _options = ScopedItemOptions.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 20973, 20987);

                        _value = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21009, 21028);

                        _wasRemoved = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21050, 21069);

                        _attributes = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 20866, 21088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 20731, 21103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 20596, 21114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 20596, 21114);
                }
            }
        }

        private bool _wasRemoved;

        internal SessionStateInternal SessionState { get; set; }

        private void SetValue(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 21849, 23610);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 21968, 22472) || true) && ((_options & (ScopedItemOptions.ReadOnly | ScopedItemOptions.Constant)) != ScopedItemOptions.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 21968, 22472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22102, 22429);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1361_22167_22428(f_1361_22241_22245(), SessionStateCategory.Variable, "VariableNotWritable", f_1361_22388_22427())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22449, 22457);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 21968, 22472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22560, 22592);

                object
                transformedValue = value
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22606, 23294) || true) && (_attributes != null && (DynAbs.Tracing.TraceSender.Expression_True(1361, 22610, 22654) && f_1361_22633_22650(_attributes) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 22606, 23294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22688, 22742);

                    transformedValue = f_1361_22707_22741(_attributes, value);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22827, 23279) || true) && (!f_1361_22832_22862(this, transformedValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 22827, 23279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 22904, 23228);

                        ValidationMetadataException
                        e = f_1361_22936_23227("ValidateSetFailure", null, f_1361_23072_23100(), f_1361_23127_23131(), ((DynAbs.Tracing.TraceSender.Conditional_F1(1361, 23159, 23185) || (((transformedValue != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1361, 23188, 23215)) || DynAbs.Tracing.TraceSender.Conditional_F3(1361, 23218, 23225))) ? f_1361_23188_23215(transformedValue) : "$null"))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23252, 23260);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 22827, 23279);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 22606, 23294);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23310, 23442) || true) && (transformedValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 23310, 23442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23372, 23427);

                    transformedValue = f_1361_23391_23426(this, transformedValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 23310, 23442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23528, 23554);

                _value = transformedValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23570, 23599);

                f_1361_23570_23598(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 21849, 23610);

                string
                f_1361_22241_22245()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 22241, 22245);
                    return return_v;
                }


                string
                f_1361_22388_22427()
                {
                    var return_v = SessionStateStrings.VariableNotWritable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 22388, 22427);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1361_22167_22428(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 22167, 22428);
                    return return_v;
                }


                int
                f_1361_22633_22650(System.Management.Automation.PSVariableAttributeCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 22633, 22650);
                    return return_v;
                }


                object
                f_1361_22707_22741(System.Management.Automation.PSVariableAttributeCollection
                attributes, object
                value)
                {
                    var return_v = TransformValue((System.Collections.Generic.IEnumerable<System.Attribute>)attributes, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 22707, 22741);
                    return return_v;
                }


                bool
                f_1361_22832_22862(System.Management.Automation.PSVariable
                this_param, object
                value)
                {
                    var return_v = this_param.IsValidValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 22832, 22862);
                    return return_v;
                }


                string
                f_1361_23072_23100()
                {
                    var return_v = Metadata.InvalidValueFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 23072, 23100);
                    return return_v;
                }


                string
                f_1361_23127_23131()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 23127, 23131);
                    return return_v;
                }


                string?
                f_1361_23188_23215(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 23188, 23215);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1361_22936_23227(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 22936, 23227);
                    return return_v;
                }


                object
                f_1361_23391_23426(System.Management.Automation.PSVariable
                this_param, object
                o)
                {
                    var return_v = this_param.CopyMutableValues(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 23391, 23426);
                    return return_v;
                }


                int
                f_1361_23570_23598(System.Management.Automation.PSVariable
                this_param)
                {
                    this_param.DebuggerCheckVariableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 23570, 23598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 21849, 23610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 21849, 23610);
            }
        }

        private void SetValueRawImpl(object newValue, bool preserveValueTypeSemantics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 23622, 23888);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23725, 23843) || true) && (preserveValueTypeSemantics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 23725, 23843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23789, 23828);

                    newValue = f_1361_23800_23827(this, newValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 23725, 23843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 23859, 23877);

                _value = newValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 23622, 23888);

                object
                f_1361_23800_23827(System.Management.Automation.PSVariable
                this_param, object
                o)
                {
                    var return_v = this_param.CopyMutableValues(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 23800, 23827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 23622, 23888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 23622, 23888);
            }
        }

        internal virtual void SetValueRaw(object newValue, bool preserveValueTypeSemantics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 23900, 24073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24008, 24062);

                f_1361_24008_24061(this, newValue, preserveValueTypeSemantics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 23900, 24073);

                int
                f_1361_24008_24061(System.Management.Automation.PSVariable
                this_param, object
                newValue, bool
                preserveValueTypeSemantics)
                {
                    this_param.SetValueRawImpl(newValue, preserveValueTypeSemantics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24008, 24061);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 23900, 24073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 23900, 24073);
            }
        }

        private readonly CallSite<Func<CallSite, object, object>> _copyMutableValueSite;

        internal object CopyMutableValues(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 24272, 24521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24441, 24510);

                // LAFHIS
                //return f_1361_24448_24509(_copyMutableValueSite.Target, _copyMutableValueSite, o);
                var temp = _copyMutableValueSite.Target.Invoke(_copyMutableValueSite, o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24448, 24509);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 24272, 24521);

                object
                f_1361_24448_24509(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24448, 24509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 24272, 24521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 24272, 24521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void WrapValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 24533, 24779);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24583, 24768) || true) && (f_1361_24587_24603_M(!this.IsConstant))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 24583, 24768);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24637, 24753) || true) && (_value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 24637, 24753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 24697, 24734);

                        _value = f_1361_24706_24733(_value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 24637, 24753);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 24583, 24768);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 24533, 24779);

                bool
                f_1361_24587_24603_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 24587, 24603);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1361_24706_24733(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24706, 24733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 24533, 24779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 24533, 24779);
            }
        }

        static PSVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1361, 454, 26043);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1361, 454, 26043);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 454, 26043);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1361, 454, 26043);

        static string
        f_1361_934_938_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 883, 1020);
            return return_v;
        }


        static string
        f_1361_1535_1539_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 1470, 1622);
            return return_v;
        }


        static string
        f_1361_2352_2356_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 2260, 2424);
            return return_v;
        }


        static string
        f_1361_3298_3302_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 3184, 3411);
            return return_v;
        }


        static string
        f_1361_4606_4610_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 4388, 4702);
            return return_v;
        }


        bool
        f_1361_5960_5986(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 5960, 5986);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1361_6026_6068(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6026, 6068);
            return return_v;
        }


        System.Management.Automation.PSVariableAttributeCollection
        f_1361_6142_6181(System.Management.Automation.PSVariable
        variable)
        {
            var return_v = new System.Management.Automation.PSVariableAttributeCollection(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6142, 6181);
            return return_v;
        }


        int
        f_1361_6349_6377(System.Management.Automation.PSVariable
        this_param, object
        newValue, bool
        preserveValueTypeSemantics)
        {
            this_param.SetValueRawImpl(newValue, preserveValueTypeSemantics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6349, 6377);
            return 0;
        }


        int
        f_1361_6534_6560(System.Management.Automation.PSVariableAttributeCollection
        this_param, System.Attribute
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6534, 6560);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1361_6482_6492_I(System.Collections.ObjectModel.Collection<System.Attribute>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6482, 6492);
            return return_v;
        }


        bool
        f_1361_6715_6725()
        {
            var return_v = IsAllScope;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 6715, 6725);
            return return_v;
        }


        int
        f_1361_6759_6811(string
        variableName)
        {
            Language.VariableAnalysis.NoteAllScopeVariable(variableName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 6759, 6811);
            return 0;
        }


        System.Management.Automation.Language.PSVariableAssignmentBinder
        f_1361_24228_24260()
        {
            var return_v = PSVariableAssignmentBinder.Get();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24228, 24260);
            return return_v;
        }


        System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
        f_1361_24180_24261(System.Management.Automation.Language.PSVariableAssignmentBinder
        binder)
        {
            var return_v = CallSite<Func<CallSite, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 24180, 24261);
            return return_v;
        }

    }
    internal class LocalVariable : PSVariable
    {
        private readonly MutableTuple _tuple;

        private readonly int _tupleSlot;

        public LocalVariable(string name, MutableTuple tuple, int tupleSlot)
        : base(f_1361_26289_26293_C(name), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 26200, 26389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26139, 26145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26177, 26187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26326, 26341);

                _tuple = tuple;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26355, 26378);

                _tupleSlot = tupleSlot;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 26200, 26389);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 26200, 26389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 26200, 26389);
            }
        }

        public override ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 26467, 26495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26473, 26493);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Options, 1361, 26480, 26492);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 26467, 26495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 26401, 27117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 26401, 27117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 26511, 27106);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26628, 27091) || true) && (value != DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Options, 1361, 26641, 26653))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 26628, 27091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 26695, 27040);

                        SessionStateUnauthorizedAccessException
                        e =
                        f_1361_26764_27039(f_1361_26838_26842(), SessionStateCategory.Variable, "VariableOptionsNotSettable", f_1361_26992_27038())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27064, 27072);

                        throw e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 26628, 27091);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 26511, 27106);

                    string
                    f_1361_26838_26842()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 26838, 26842);
                        return return_v;
                    }


                    string
                    f_1361_26992_27038()
                    {
                        var return_v = SessionStateStrings.VariableOptionsNotSettable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 26992, 27038);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateUnauthorizedAccessException
                    f_1361_26764_27039(string
                    itemName, System.Management.Automation.SessionStateCategory
                    sessionStateCategory, string
                    errorIdAndResourceId, string
                    resourceStr)
                    {
                        var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 26764, 27039);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 26401, 27117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 26401, 27117);
                }
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 27182, 27314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27218, 27246);

                    f_1361_27218_27245(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27264, 27299);

                    return f_1361_27271_27298(_tuple, _tupleSlot);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 27182, 27314);

                    int
                    f_1361_27218_27245(System.Management.Automation.LocalVariable
                    this_param)
                    {
                        this_param.DebuggerCheckVariableRead();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 27218, 27245);
                        return 0;
                    }


                    object
                    f_1361_27271_27298(System.Management.Automation.MutableTuple
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetValue(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 27271, 27298);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 27129, 27474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 27129, 27474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 27330, 27463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27366, 27401);

                    f_1361_27366_27400(_tuple, _tupleSlot, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27419, 27448);

                    f_1361_27419_27447(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 27330, 27463);

                    int
                    f_1361_27366_27400(System.Management.Automation.MutableTuple
                    this_param, int
                    index, object
                    value)
                    {
                        this_param.SetValue(index, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 27366, 27400);
                        return 0;
                    }


                    int
                    f_1361_27419_27447(System.Management.Automation.LocalVariable
                    this_param)
                    {
                        this_param.DebuggerCheckVariableWrite();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 27419, 27447);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 27129, 27474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 27129, 27474);
                }
            }
        }

        internal override void SetValueRaw(object newValue, bool preserveValueTypeSemantics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 27486, 27762);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27595, 27713) || true) && (preserveValueTypeSemantics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1361, 27595, 27713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27659, 27698);

                    newValue = f_1361_27670_27697(this, newValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1361, 27595, 27713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 27729, 27751);

                this.Value = newValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 27486, 27762);

                object
                f_1361_27670_27697(System.Management.Automation.LocalVariable
                this_param, object
                o)
                {
                    var return_v = this_param.CopyMutableValues(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1361, 27670, 27697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 27486, 27762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 27486, 27762);
            }
        }

        static LocalVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1361, 26051, 27769);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1361, 26051, 27769);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 26051, 27769);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1361, 26051, 27769);

        static string
        f_1361_26289_26293_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 26200, 26389);
            return return_v;
        }

    }
    internal class NullVariable : PSVariable
    {
        internal NullVariable() : base(f_1361_28200_28219_C(StringLiterals.Null), null, ScopedItemOptions.Constant | ScopedItemOptions.AllScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1361, 28169, 28305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 29024, 29036);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1361, 28169, 28305);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 28169, 28305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 28169, 28305);
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 28522, 28585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 28558, 28570);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 28522, 28585);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 28469, 28693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 28469, 28693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 28601, 28682);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 28601, 28682);
                    // All values are just ignored
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 28469, 28693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 28469, 28693);
                }
            }
        }

        public override string Description
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 28856, 28946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 28862, 28944);

                    return _description ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1361, 28869, 28943) ?? (_description = f_1361_28901_28942()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 28856, 28946);

                    string
                    f_1361_28901_28942()
                    {
                        var return_v = SessionStateStrings.DollarNullDescription;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1361, 28901, 28942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 28797, 28997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 28797, 28997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                { /* Do nothing */
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 28962, 28986);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 28962, 28986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 28797, 28997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 28797, 28997);
                }
            }
        }

        private string _description;

        public override ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 29230, 29268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1361, 29236, 29266);

                    return ScopedItemOptions.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 29230, 29268);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 29164, 29319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 29164, 29319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                { /* Do nothing */
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1361, 29284, 29308);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1361, 29284, 29308);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1361, 29164, 29319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 29164, 29319);
                }
            }
        }

        static NullVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1361, 27956, 29326);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1361, 27956, 29326);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1361, 27956, 29326);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1361, 27956, 29326);

        static string
        f_1361_28200_28219_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1361, 28169, 28305);
            return return_v;
        }

    }

    /// <summary>
    /// The options that define some of the constraints for session state items like
    /// variables, aliases, and functions.
    /// </summary>
    [Flags]
    public enum ScopedItemOptions
    {
        /// <summary>
        /// There are no constraints on the item.
        /// </summary>
        None = 0,

        /// <summary>
        /// The item is readonly. It can be removed but cannot be changed.
        /// </summary>
        ReadOnly = 0x1,

        /// <summary>
        /// The item cannot be removed or changed.
        /// This flag can only be set a variable creation.
        /// </summary>
        Constant = 0x2,

        /// <summary>
        /// The item is private to the scope it was created in and
        /// cannot be seen from child scopes.
        /// </summary>
        Private = 0x4,

        /// <summary>
        /// The item is propagated to each new child scope created.
        /// </summary>
        AllScope = 0x8,

        /// <summary>
        /// The option is not specified by the user.
        /// </summary>
        Unspecified = 0x10
    }
}

