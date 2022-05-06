// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;

namespace System.Management.Automation
{
    internal class ScriptParameterBinder : ParameterBinderBase
    {
        internal ScriptParameterBinder(
                    ScriptBlock script,
                    InvocationInfo invocationInfo,
                    ExecutionContext context,
                    InternalCommand command,
                    SessionStateScope localScope) : base(f_1334_1559_1573_C(invocationInfo), context, command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1334, 1323, 1783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 1853, 1971);
                this._copyMutableValueSite = f_1334_1890_1971(f_1334_1938_1970());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6648, 6697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6709, 6760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 1617, 1692);

                f_1334_1617_1691(script != null, "caller to verify script is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 1708, 1729);

                this.Script = script;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 1743, 1772);

                this.LocalScope = localScope;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1334, 1323, 1783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1334, 1323, 1783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 1323, 1783);
            }
        }

        private readonly CallSite<Func<CallSite, object, object>> _copyMutableValueSite;

        internal object CopyMutableValues(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1334, 1982, 2231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 2151, 2220);

                // LAFHIS
                //return f_1334_2158_2219(_copyMutableValueSite.Target, _copyMutableValueSite, o);
                var temp = _copyMutableValueSite.Target.Invoke(_copyMutableValueSite, o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 2158, 2219);
                return temp;


                DynAbs.Tracing.TraceSender.TraceExitMethod(1334, 1982, 2231);

                object
                f_1334_2158_2219(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 2158, 2219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1334, 1982, 2231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 1982, 2231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override object GetDefaultParameterValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1334, 2787, 3169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 2874, 2922);

                RuntimeDefinedParameter
                runtimeDefinedParameter
                = default(RuntimeDefinedParameter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 2936, 3130) || true) && (f_1334_2940_3018(f_1334_2940_2971(f_1334_2940_2946()), name, out runtimeDefinedParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1334, 2936, 3130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 3052, 3115);

                    return f_1334_3059_3114(this, runtimeDefinedParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1334, 2936, 3130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 3146, 3158);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1334, 2787, 3169);

                System.Management.Automation.ScriptBlock
                f_1334_2940_2946()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 2940, 2946);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1334_2940_2971(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 2940, 2971);
                    return return_v;
                }


                bool
                f_1334_2940_3018(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param, string
                key, out System.Management.Automation.RuntimeDefinedParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 2940, 3018);
                    return return_v;
                }


                object
                f_1334_3059_3114(System.Management.Automation.ScriptParameterBinder
                this_param, System.Management.Automation.RuntimeDefinedParameter
                parameter)
                {
                    var return_v = this_param.GetDefaultScriptParameterValue(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 3059, 3114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1334, 2787, 3169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 2787, 3169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void BindParameter(string name, object value, CompiledCommandParameter parameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1334, 3854, 5770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 3986, 4116) || true) && (value == f_1334_3999_4019() || (DynAbs.Tracing.TraceSender.Expression_False(1334, 3990, 4054) || value == f_1334_4032_4054()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1334, 3986, 4116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 4088, 4101);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1334, 3986, 4116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 4132, 4215);

                f_1334_4132_4214(name != null, "The caller should verify that name is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 4231, 4296);

                var
                varPath = f_1334_4245_4295(name, VariablePathFlags.Variable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 4415, 4642) || true) && (f_1334_4419_4429() != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1334, 4419, 4478) && f_1334_4458_4478(varPath)) && (DynAbs.Tracing.TraceSender.Expression_True(1334, 4419, 4586) && f_1334_4499_4586(f_1334_4499_4509(), f_1334_4536_4559(varPath), f_1334_4561_4585(this, value))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1334, 4415, 4642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 4620, 4627);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1334, 4415, 4642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 5049, 5240);

                PSVariable
                variable = f_1334_5071_5239(f_1334_5086_5109(varPath), value, (DynAbs.Tracing.TraceSender.Conditional_F1(1334, 5168, 5185) || ((f_1334_5168_5185(varPath) && DynAbs.Tracing.TraceSender.Conditional_F2(1334, 5188, 5213)) || DynAbs.Tracing.TraceSender.Conditional_F3(1334, 5216, 5238))) ? ScopedItemOptions.Private : ScopedItemOptions.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 5254, 5343);

                f_1334_5254_5342(f_1334_5254_5280(f_1334_5254_5261()), varPath, variable, false, CommandOrigin.Internal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 5357, 5405);

                RuntimeDefinedParameter
                runtimeDefinedParameter
                = default(RuntimeDefinedParameter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 5419, 5759) || true) && (f_1334_5423_5501(f_1334_5423_5454(f_1334_5423_5429()), name, out runtimeDefinedParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1334, 5419, 5759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 5668, 5744);

                    f_1334_5668_5743(                // The attributes have already been checked and conversions run, so it is wrong
                                                     // to do so again.
                                    variable, f_1334_5708_5742(runtimeDefinedParameter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1334, 5419, 5759);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1334, 3854, 5770);

                System.Management.Automation.PSObject
                f_1334_3999_4019()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 3999, 4019);
                    return return_v;
                }


                object
                f_1334_4032_4054()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 4032, 4054);
                    return return_v;
                }


                int
                f_1334_4132_4214(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 4132, 4214);
                    return 0;
                }


                System.Management.Automation.VariablePath
                f_1334_4245_4295(string
                path, System.Management.Automation.VariablePathFlags
                knownFlags)
                {
                    var return_v = new System.Management.Automation.VariablePath(path, knownFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 4245, 4295);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1334_4419_4429()
                {
                    var return_v = LocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 4419, 4429);
                    return return_v;
                }


                bool
                f_1334_4458_4478(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 4458, 4478);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1334_4499_4509()
                {
                    var return_v = LocalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 4499, 4509);
                    return return_v;
                }


                string
                f_1334_4536_4559(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 4536, 4559);
                    return return_v;
                }


                object
                f_1334_4561_4585(System.Management.Automation.ScriptParameterBinder
                this_param, object
                o)
                {
                    var return_v = this_param.CopyMutableValues(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 4561, 4585);
                    return return_v;
                }


                bool
                f_1334_4499_4586(System.Management.Automation.SessionStateScope
                this_param, string
                name, object
                value)
                {
                    var return_v = this_param.TrySetLocalParameterValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 4499, 4586);
                    return return_v;
                }


                string
                f_1334_5086_5109(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5086, 5109);
                    return return_v;
                }


                bool
                f_1334_5168_5185(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5168, 5185);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1334_5071_5239(string
                name, object
                value, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.PSVariable(name, value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 5071, 5239);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1334_5254_5261()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5254, 5261);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1334_5254_5280(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5254, 5280);
                    return return_v;
                }


                object
                f_1334_5254_5342(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.VariablePath
                variablePath, System.Management.Automation.PSVariable
                newValue, bool
                asValue, System.Management.Automation.CommandOrigin
                origin)
                {
                    var return_v = this_param.SetVariable(variablePath, (object)newValue, asValue, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 5254, 5342);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1334_5423_5429()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5423, 5429);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1334_5423_5454(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5423, 5454);
                    return return_v;
                }


                bool
                f_1334_5423_5501(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param, string
                key, out System.Management.Automation.RuntimeDefinedParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 5423, 5501);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1334_5708_5742(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 5708, 5742);
                    return return_v;
                }


                int
                f_1334_5668_5743(System.Management.Automation.PSVariable
                this_param, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes)
                {
                    this_param.AddParameterAttributesNoChecks(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 5668, 5743);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1334, 3854, 5770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 3854, 5770);
            }
        }

        internal object GetDefaultScriptParameterValue(RuntimeDefinedParameter parameter, IDictionary implicitUsingParameters = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1334, 5930, 6427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6080, 6112);

                object
                result = f_1334_6096_6111(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6128, 6199);

                var
                compiledDefault = result as Compiler.DefaultValueExpressionWrapper
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6213, 6386) || true) && (compiledDefault != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1334, 6213, 6386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6274, 6371);

                    result = f_1334_6283_6370(compiledDefault, f_1334_6308_6315(), f_1334_6317_6344(f_1334_6317_6323()), implicitUsingParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1334, 6213, 6386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1334, 6402, 6416);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1334, 5930, 6427);

                object
                f_1334_6096_6111(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 6096, 6111);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1334_6308_6315()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 6308, 6315);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1334_6317_6323()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 6317, 6323);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1334_6317_6344(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1334, 6317, 6344);
                    return return_v;
                }


                object
                f_1334_6283_6370(System.Management.Automation.Language.Compiler.DefaultValueExpressionWrapper
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                sessionStateInternal, System.Collections.IDictionary
                usingValues)
                {
                    var return_v = this_param.GetValue(context, sessionStateInternal, usingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 6283, 6370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1334, 5930, 6427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 5930, 6427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ScriptBlock Script { get; private set; }

        internal SessionStateScope LocalScope { get; set; }

        static ScriptParameterBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1334, 398, 6805);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1334, 398, 6805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1334, 398, 6805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1334, 398, 6805);

        int
        f_1334_1617_1691(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 1617, 1691);
            return 0;
        }


        static System.Management.Automation.InvocationInfo
        f_1334_1559_1573_C(System.Management.Automation.InvocationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1334, 1323, 1783);
            return return_v;
        }


        System.Management.Automation.Language.PSVariableAssignmentBinder
        f_1334_1938_1970()
        {
            var return_v = PSVariableAssignmentBinder.Get();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 1938, 1970);
            return return_v;
        }


        System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
        f_1334_1890_1971(System.Management.Automation.Language.PSVariableAssignmentBinder
        binder)
        {
            var return_v = CallSite<Func<CallSite, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1334, 1890, 1971);
            return return_v;
        }

    }
}
