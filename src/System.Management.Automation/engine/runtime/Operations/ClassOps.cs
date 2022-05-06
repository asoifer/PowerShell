// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;

// These APIs are not part of the public contract.
// They are implementation details and intended to be called from generated assemblies for PS classes.
//
// Because they are called from other assemblies, we have to make them public.
// We put them in Internal namespace to emphasise that despite the fact that they are public, it's not part of API contract.

namespace System.Management.Automation.Internal
{
    public class SessionStateKeeper
    {
        private readonly ConditionalWeakTable<Runspace, SessionStateInternal> _stateMap;

        internal SessionStateKeeper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1663, 2011, 2147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 1989, 1998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2065, 2136);

                _stateMap = f_1663_2077_2135();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1663, 2011, 2147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 2011, 2147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 2011, 2147);
            }
        }

        internal void RegisterRunspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 2159, 3624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2216, 2262);

                SessionStateInternal
                sessionStateInMap = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2276, 2326);

                Runspace
                runspaceToUse = f_1663_2301_2325()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2340, 2431);

                SessionStateInternal
                sessionStateToUse = f_1663_2381_2430(f_1663_2381_2411(runspaceToUse))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2668, 3508) || true) && (!f_1663_2673_2732(_stateMap, runspaceToUse, out sessionStateInMap))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 2668, 3508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2823, 2871);

                    f_1663_2823_2870(                // If the key doesn't exist yet, add it
                                    _stateMap, runspaceToUse, sessionStateToUse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 2668, 3508);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 2668, 3508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 2905, 3508) || true) && (sessionStateInMap != sessionStateToUse)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 2905, 3508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 3437, 3493);

                        f_1663_3437_3492(                // If the key exists but the corresponding value is not what we should use, then remove the key/value pair and add the new pair.
                                                         // This could happen when a powershell class is defined in a module and the module gets reloaded. In such case, the same TypeDefinitionAst
                                                         // instance will get reused, but should be associated with the SessionState from the new module, instead of the one from the old module.
                                        _stateMap, runspaceToUse, sessionStateToUse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 2905, 3508);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 2668, 3508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 2159, 3624);

                System.Management.Automation.Runspaces.Runspace
                f_1663_2301_2325()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 2301, 2325);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1663_2381_2411(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 2381, 2411);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1663_2381_2430(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 2381, 2430);
                    return return_v;
                }


                bool
                f_1663_2673_2732(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>
                this_param, System.Management.Automation.Runspaces.Runspace
                key, out System.Management.Automation.SessionStateInternal
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 2673, 2732);
                    return return_v;
                }


                int
                f_1663_2823_2870(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>
                this_param, System.Management.Automation.Runspaces.Runspace
                key, System.Management.Automation.SessionStateInternal
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 2823, 2870);
                    return 0;
                }


                int
                f_1663_3437_3492(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>
                this_param, System.Management.Automation.Runspaces.Runspace
                key, System.Management.Automation.SessionStateInternal
                value)
                {
                    this_param.AddOrUpdate(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 3437, 3492);
                    return 0;
                }

                // If the key exists and the corresponding value is the one we should use, then do nothing.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 2159, 3624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 2159, 3624);
            }
        }

        public object GetSessionState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 4722, 5358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 4778, 4809);

                SessionStateInternal
                ss = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5132, 5184);

                Runspace
                defaultRunspace = f_1663_5159_5183()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5198, 5321) || true) && (defaultRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 5198, 5321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5259, 5306);

                    f_1663_5259_5305(_stateMap, defaultRunspace, out ss);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 5198, 5321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5337, 5347);

                return ss;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 4722, 5358);

                System.Management.Automation.Runspaces.Runspace
                f_1663_5159_5183()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 5159, 5183);
                    return return_v;
                }


                bool
                f_1663_5259_5305(System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>
                this_param, System.Management.Automation.Runspaces.Runspace
                key, out System.Management.Automation.SessionStateInternal
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 5259, 5305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 4722, 5358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 4722, 5358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SessionStateKeeper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1663, 1693, 5365);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1663, 1693, 5365);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 1693, 5365);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1663, 1693, 5365);

        System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>
        f_1663_2077_2135()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<System.Management.Automation.Runspaces.Runspace, System.Management.Automation.SessionStateInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 2077, 2135);
            return return_v;
        }

    }
    public class ScriptBlockMemberMethodWrapper
    {
        public static readonly object[] _emptyArgumentArray;

        private readonly bool _isStatic;

        private readonly SessionStateKeeper _sessionStateKeeper;

        private readonly WeakReference<SessionStateInternal> _defaultSessionStateToUse;

        private readonly IParameterMetadataProvider _ast;

        private readonly Lazy<ScriptBlock> _scriptBlock;

        private readonly ThreadLocal<ScriptBlock> _boundScriptBlock;

        internal ScriptBlockMemberMethodWrapper(IParameterMetadataProvider ast, SessionStateKeeper sessionStateKeeper)
        : this(f_1663_7587_7590_C(ast))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1663, 7456, 7787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 7616, 7633);

                _isStatic = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 7647, 7688);

                _sessionStateKeeper = sessionStateKeeper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 7702, 7776);

                _defaultSessionStateToUse = f_1663_7730_7775(null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1663, 7456, 7787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 7456, 7787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 7456, 7787);
            }
        }

        internal ScriptBlockMemberMethodWrapper(IParameterMetadataProvider ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1663, 7935, 8377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5776, 5785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 6053, 6072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 6714, 6739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 6891, 6895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 7079, 7091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 7293, 7310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 8031, 8042);

                _ast = ast;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 8186, 8269);

                _scriptBlock = f_1663_8201_8268(() => new ScriptBlock(_ast, isFilter: false));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 8283, 8366);

                _boundScriptBlock = f_1663_8303_8365(() => _scriptBlock.Value.Clone());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1663, 7935, 8377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 7935, 8377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 7935, 8377);
            }
        }

        internal void InitAtRuntime()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 9626, 10201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 9680, 10190) || true) && (_isStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 9680, 10190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 9947, 9972);
                    // WeakReference<T>'s instance methods are not thread-safe, so we need the lock to guarantee
                    // 'SetTarget' and 'TryGetTarget' are not called by multiple threads at the same time.
                    lock (_defaultSessionStateToUse)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 10014, 10070);

                        var
                        context = f_1663_10028_10069(f_1663_10028_10052())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 10092, 10156);

                        f_1663_10092_10155(_defaultSessionStateToUse, f_1663_10128_10154(context));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 9680, 10190);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 9626, 10201);

                System.Management.Automation.Runspaces.Runspace
                f_1663_10028_10052()
                {
                    var return_v = Runspace.DefaultRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 10028, 10052);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1663_10028_10069(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 10028, 10069);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1663_10128_10154(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 10128, 10154);
                    return return_v;
                }


                int
                f_1663_10092_10155(System.WeakReference<System.Management.Automation.SessionStateInternal>
                this_param, System.Management.Automation.SessionStateInternal
                target)
                {
                    this_param.SetTarget(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 10092, 10155);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 9626, 10201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 9626, 10201);
            }
        }

        private void PrepareScriptBlockToInvoke(object instance, object sessionStateInternal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 10329, 11940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 10439, 10485);

                SessionStateInternal
                sessionStateToUse = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 10499, 11848) || true) && (instance != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 10499, 11848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 10652, 10715);

                    sessionStateToUse = (SessionStateInternal)sessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 10499, 11848);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 10499, 11848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 11479, 11559);

                    sessionStateToUse = (SessionStateInternal)f_1663_11521_11558(_sessionStateKeeper);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 11577, 11833) || true) && (sessionStateToUse == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 11577, 11833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 11654, 11679);
                        lock (_defaultSessionStateToUse)
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 11729, 11791);

                            f_1663_11729_11790(_defaultSessionStateToUse, out sessionStateToUse);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 11577, 11833);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 10499, 11848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 11864, 11929);

                f_1663_11864_11887(_boundScriptBlock).SessionStateInternal = sessionStateToUse;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 10329, 11940);

                object
                f_1663_11521_11558(System.Management.Automation.Internal.SessionStateKeeper
                this_param)
                {
                    var return_v = this_param.GetSessionState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 11521, 11558);
                    return return_v;
                }


                bool
                f_1663_11729_11790(System.WeakReference<System.Management.Automation.SessionStateInternal>
                this_param, out System.Management.Automation.SessionStateInternal
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 11729, 11790);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1663_11864_11887(System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 11864, 11887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 10329, 11940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 10329, 11940);
            }
        }

        public void InvokeHelper(object instance, object sessionStateInternal, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 12256, 13005);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 12402, 12461);

                    f_1663_12402_12460(this, instance, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 12479, 12542);

                    f_1663_12479_12541(f_1663_12479_12502(_boundScriptBlock), instance, args);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1663, 12571, 12994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 12927, 12979);

                    f_1663_12927_12950(_boundScriptBlock).SessionStateInternal = null;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1663, 12571, 12994);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 12256, 13005);

                int
                f_1663_12402_12460(System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                this_param, object
                instance, object
                sessionStateInternal)
                {
                    this_param.PrepareScriptBlockToInvoke(instance, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 12402, 12460);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1663_12479_12502(System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 12479, 12502);
                    return return_v;
                }


                int
                f_1663_12479_12541(System.Management.Automation.ScriptBlock
                this_param, object
                instance, object[]
                args)
                {
                    this_param.InvokeAsMemberFunction(instance, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 12479, 12541);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1663_12927_12950(System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 12927, 12950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 12256, 13005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 12256, 13005);
            }
        }

        public T InvokeHelperT<T>(object instance, object sessionStateInternal, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1663, 13400, 14161);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 13547, 13606);

                    f_1663_13547_13605(this, instance, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 13624, 13698);

                    return f_1663_13631_13697(f_1663_13631_13654(_boundScriptBlock), instance, args);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1663, 13727, 14150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 14083, 14135);

                    f_1663_14083_14106(_boundScriptBlock).SessionStateInternal = null;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1663, 13727, 14150);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1663, 13400, 14161);

                int
                f_1663_13547_13605(System.Management.Automation.Internal.ScriptBlockMemberMethodWrapper
                this_param, object
                instance, object
                sessionStateInternal)
                {
                    this_param.PrepareScriptBlockToInvoke(instance, sessionStateInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 13547, 13605);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1663_13631_13654(System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 13631, 13654);
                    return return_v;
                }


                T
                f_1663_13631_13697(System.Management.Automation.ScriptBlock
                this_param, object
                instance, object[]
                args)
                {
                    var return_v = this_param.InvokeAsMemberFunctionT<T>(instance, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 13631, 13697);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1663_14083_14106(System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 14083, 14106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 13400, 14161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 13400, 14161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptBlockMemberMethodWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1663, 5393, 14168);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 5533, 5576);
            _emptyArgumentArray = f_1663_5555_5576();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1663, 5393, 14168);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 5393, 14168);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1663, 5393, 14168);

        static object[]
        f_1663_5555_5576()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 5555, 5576);
            return return_v;
        }


        System.WeakReference<System.Management.Automation.SessionStateInternal>
        f_1663_7730_7775(System.Management.Automation.SessionStateInternal
        target)
        {
            var return_v = new System.WeakReference<System.Management.Automation.SessionStateInternal>(target);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 7730, 7775);
            return return_v;
        }


        static System.Management.Automation.Language.IParameterMetadataProvider
        f_1663_7587_7590_C(System.Management.Automation.Language.IParameterMetadataProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1663, 7456, 7787);
            return return_v;
        }


        System.Lazy<System.Management.Automation.ScriptBlock>
        f_1663_8201_8268(System.Func<System.Management.Automation.ScriptBlock>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Management.Automation.ScriptBlock>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 8201, 8268);
            return return_v;
        }


        System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>
        f_1663_8303_8365(System.Func<System.Management.Automation.ScriptBlock>
        valueFactory)
        {
            var return_v = new System.Threading.ThreadLocal<System.Management.Automation.ScriptBlock>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 8303, 8365);
            return return_v;
        }

    }
    public static class ClassOps
    {
        public static void ValidateSetProperty(Type type, string propertyName, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 14671, 15257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 14780, 14886);

                var
                validateAttributes = f_1663_14805_14885(f_1663_14805_14835(type, propertyName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 14900, 14966);

                var
                executionContext = f_1663_14923_14965()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 14980, 15071);

                var
                engineIntrinsics = (DynAbs.Tracing.TraceSender.Conditional_F1(1663, 15003, 15027) || ((executionContext == null && DynAbs.Tracing.TraceSender.Conditional_F2(1663, 15030, 15034)) || DynAbs.Tracing.TraceSender.Conditional_F3(1663, 15037, 15070))) ? null : f_1663_15037_15070(executionContext)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 15085, 15246);
                    foreach (var validateAttribute in f_1663_15119_15137_I(validateAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 15085, 15246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 15171, 15231);

                        f_1663_15171_15230(validateAttribute, value, engineIntrinsics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 15085, 15246);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1663, 1, 162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1663, 1, 162);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 14671, 15257);

                System.Reflection.PropertyInfo?
                f_1663_14805_14835(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 14805, 14835);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ValidateArgumentsAttribute>
                f_1663_14805_14885(System.Reflection.PropertyInfo
                element)
                {
                    var return_v = element.GetCustomAttributes<System.Management.Automation.ValidateArgumentsAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 14805, 14885);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1663_14923_14965()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 14923, 14965);
                    return return_v;
                }


                System.Management.Automation.EngineIntrinsics
                f_1663_15037_15070(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineIntrinsics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 15037, 15070);
                    return return_v;
                }


                int
                f_1663_15171_15230(System.Management.Automation.ValidateArgumentsAttribute
                this_param, object
                o, System.Management.Automation.EngineIntrinsics
                engineIntrinsics)
                {
                    this_param.InternalValidate(o, engineIntrinsics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 15171, 15230);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ValidateArgumentsAttribute>
                f_1663_15119_15137_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ValidateArgumentsAttribute>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 15119, 15137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 14671, 15257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 14671, 15257);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        public static void CallBaseCtor(object target, ConstructorInfo ci, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 15566, 15801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 15766, 15790);

                f_1663_15766_15789(ci, target, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 15566, 15801);

                object?
                f_1663_15766_15789(System.Reflection.ConstructorInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 15766, 15789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 15566, 15801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 15566, 15801);
            }
        }

        public static object CallMethodNonVirtually(object target, MethodInfo mi, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 16181, 16357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 16294, 16346);

                return f_1663_16301_16345(target, mi, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 16181, 16357);

                object
                f_1663_16301_16345(object
                target, System.Reflection.MethodInfo
                mi, object[]
                args)
                {
                    var return_v = CallMethodNonVirtuallyImpl(target, mi, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 16301, 16345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 16181, 16357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 16181, 16357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void CallVoidMethodNonVirtually(object target, MethodInfo mi, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 16724, 16895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 16839, 16884);

                f_1663_16839_16883(target, mi, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 16724, 16895);

                object
                f_1663_16839_16883(object
                target, System.Reflection.MethodInfo
                mi, object[]
                args)
                {
                    var return_v = CallMethodNonVirtuallyImpl(target, mi, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 16839, 16883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 16724, 16895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 16724, 16895);
            }
        }

        private static readonly ConditionalWeakTable<MethodInfo, DynamicMethod> s_nonVirtualCallCache;

        private static object CallMethodNonVirtuallyImpl(object target, MethodInfo mi, object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 17602, 18079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 17720, 17795);

                DynamicMethod
                dm = f_1663_17739_17794(s_nonVirtualCallCache, mi, CreateDynamicMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 17914, 17973);

                var
                newArgs = new List<object>(f_1663_17945_17956(args) + 1) { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => target, 1663, 17928, 17972) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 17987, 18010);

                f_1663_17987_18009(newArgs, args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18026, 18068);

                return f_1663_18033_18067(dm, null, f_1663_18049_18066(newArgs));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 17602, 18079);

                System.Reflection.Emit.DynamicMethod
                f_1663_17739_17794(System.Runtime.CompilerServices.ConditionalWeakTable<System.Reflection.MethodInfo, System.Reflection.Emit.DynamicMethod>
                this_param, System.Reflection.MethodInfo
                key, System.Runtime.CompilerServices.ConditionalWeakTable<System.Reflection.MethodInfo, System.Reflection.Emit.DynamicMethod>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 17739, 17794);
                    return return_v;
                }


                int
                f_1663_17945_17956(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 17945, 17956);
                    return return_v;
                }


                int
                f_1663_17987_18009(System.Collections.Generic.List<object>
                this_param, object[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 17987, 18009);
                    return 0;
                }


                object[]
                f_1663_18049_18066(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18049, 18066);
                    return return_v;
                }


                object?
                f_1663_18033_18067(System.Reflection.Emit.DynamicMethod
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18033, 18067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 17602, 18079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 17602, 18079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DynamicMethod CreateDynamicMethod(MethodInfo mi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1663, 18230, 19049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18439, 18492);

                var
                paramTypes = new List<Type> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1663_18473_18489(mi), 1663, 18456, 18491) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18506, 18575);

                f_1663_18506_18574(paramTypes, f_1663_18526_18573(f_1663_18526_18544(mi), x => x.ParameterType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18591, 18704);

                var
                dm = f_1663_18600_18703("PSNonVirtualCall_" + f_1663_18640_18647(mi), f_1663_18649_18662(mi), f_1663_18664_18684(paramTypes), f_1663_18686_18702(mi))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18718, 18755);

                ILGenerator
                il = f_1663_18735_18754(dm)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18778, 18783);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18769, 18885) || true) && (i < f_1663_18789_18805(paramTypes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18807, 18810)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1663, 18769, 18885))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1663, 18769, 18885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18844, 18870);

                        f_1663_18844_18869(il, OpCodes.Ldarg, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1663, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1663, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18901, 18927);

                f_1663_18901_18926(
                            il, OpCodes.Tailcall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18941, 18977);

                f_1663_18941_18976(il, OpCodes.Call, mi, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 18991, 19012);

                f_1663_18991_19011(il, OpCodes.Ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 19028, 19038);

                return dm;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1663, 18230, 19049);

                System.Type
                f_1663_18473_18489(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 18473, 18489);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1663_18526_18544(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18526, 18544);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1663_18526_18573(System.Reflection.ParameterInfo[]
                source, System.Func<System.Reflection.ParameterInfo, System.Type>
                selector)
                {
                    var return_v = source.Select<System.Reflection.ParameterInfo, System.Type>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18526, 18573);
                    return return_v;
                }


                int
                f_1663_18506_18574(System.Collections.Generic.List<System.Type>
                this_param, System.Collections.Generic.IEnumerable<System.Type>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18506, 18574);
                    return 0;
                }


                string
                f_1663_18640_18647(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 18640, 18647);
                    return return_v;
                }


                System.Type
                f_1663_18649_18662(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 18649, 18662);
                    return return_v;
                }


                System.Type[]
                f_1663_18664_18684(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18664, 18684);
                    return return_v;
                }


                System.Type
                f_1663_18686_18702(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 18686, 18702);
                    return return_v;
                }


                System.Reflection.Emit.DynamicMethod
                f_1663_18600_18703(string
                name, System.Type
                returnType, System.Type[]
                parameterTypes, System.Type
                owner)
                {
                    var return_v = new System.Reflection.Emit.DynamicMethod(name, returnType, parameterTypes, owner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18600, 18703);
                    return return_v;
                }


                System.Reflection.Emit.ILGenerator
                f_1663_18735_18754(System.Reflection.Emit.DynamicMethod
                this_param)
                {
                    var return_v = this_param.GetILGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18735, 18754);
                    return return_v;
                }


                int
                f_1663_18789_18805(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1663, 18789, 18805);
                    return return_v;
                }


                int
                f_1663_18844_18869(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, int
                arg)
                {
                    this_param.Emit(opcode, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18844, 18869);
                    return 0;
                }


                int
                f_1663_18901_18926(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18901, 18926);
                    return 0;
                }


                int
                f_1663_18941_18976(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.MethodInfo
                methodInfo, System.Type[]?
                optionalParameterTypes)
                {
                    this_param.EmitCall(opcode, methodInfo, optionalParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18941, 18976);
                    return 0;
                }


                int
                f_1663_18991_19011(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 18991, 19011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1663, 18230, 19049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 18230, 19049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ClassOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1663, 14264, 19056);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1663, 17199, 17289);
            s_nonVirtualCallCache = f_1663_17236_17289();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1663, 14264, 19056);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1663, 14264, 19056);
        }


        static System.Runtime.CompilerServices.ConditionalWeakTable<System.Reflection.MethodInfo, System.Reflection.Emit.DynamicMethod>
        f_1663_17236_17289()
        {
            var return_v = new System.Runtime.CompilerServices.ConditionalWeakTable<System.Reflection.MethodInfo, System.Reflection.Emit.DynamicMethod>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1663, 17236, 17289);
            return return_v;
        }

    }
}
