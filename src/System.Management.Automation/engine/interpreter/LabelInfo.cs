/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LabelInfo
    {
        private readonly LabelTarget _node;

        private BranchLabel _label;

        private object _definitions;

        private readonly List<LabelScopeInfo> _references;

        private bool _acrossBlockJump;

        internal LabelInfo(LabelTarget node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1505, 2070, 2155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 1241, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 1351, 1357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 1687, 1699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 1793, 1833);
                this._references = f_1505_1807_1833();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2041, 2057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2131, 2144);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1505, 2070, 2155);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 2070, 2155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 2070, 2155);
            }
        }

        internal BranchLabel GetLabel(LightCompiler compiler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 2167, 2306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2245, 2267);

                f_1505_2245_2266(this, compiler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2281, 2295);

                return _label;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 2167, 2306);

                int
                f_1505_2245_2266(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LightCompiler
                compiler)
                {
                    this_param.EnsureLabel(compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2245, 2266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 2167, 2306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 2167, 2306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Reference(LabelScopeInfo block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 2318, 2523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2388, 2411);

                f_1505_2388_2410(_references, block);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2425, 2512) || true) && (f_1505_2429_2443())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 2425, 2512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2477, 2497);

                    f_1505_2477_2496(this, block);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 2425, 2512);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 2318, 2523);

                int
                f_1505_2388_2410(System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2388, 2410);
                    return 0;
                }


                bool
                f_1505_2429_2443()
                {
                    var return_v = HasDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 2429, 2443);
                    return return_v;
                }


                int
                f_1505_2477_2496(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                reference)
                {
                    this_param.ValidateJump(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2477, 2496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 2318, 2523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 2318, 2523);
            }
        }

        internal void Define(LabelScopeInfo block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 2535, 4078);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2826, 2835);
                    // Prevent the label from being shadowed, which enforces cleaner
                    // trees. Also we depend on this for simplicity (keeping only one
                    // active IL Label per LabelInfo)
                    for (LabelScopeInfo
        j = block
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2806, 3127) || true) && (j != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2848, 2860)
        , j = j.Parent, DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 2806, 3127))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 2806, 3127);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2894, 3112) || true) && (f_1505_2898_2921(j, _node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 2894, 3112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 2963, 3093);

                            throw f_1505_2969_3092(f_1505_2999_3091(f_1505_3013_3041(), "Label target already defined: {0}", f_1505_3080_3090(_node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 2894, 3112);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3143, 3164);

                f_1505_3143_3163(this, block);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3178, 3210);

                f_1505_3178_3209(block, _node, this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3275, 4067) || true) && (f_1505_3279_3293() && (DynAbs.Tracing.TraceSender.Expression_True(1505, 3279, 3320) && f_1505_3297_3320_M(!HasMultipleDefinitions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 3275, 4067);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3354, 3460);
                        foreach (var r in f_1505_3372_3383_I(_references))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 3354, 3460);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3425, 3441);

                            f_1505_3425_3440(this, r);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 3354, 3460);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 107);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 3275, 4067);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 3275, 4067);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3640, 3775) || true) && (_acrossBlockJump)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 3640, 3775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 3702, 3756);

                        throw f_1505_3708_3755("Ambiguous jump");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 3640, 3775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4038, 4052);

                    _label = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 3275, 4067);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 2535, 4078);

                bool
                f_1505_2898_2921(System.Management.Automation.Interpreter.LabelScopeInfo
                this_param, System.Linq.Expressions.LabelTarget
                target)
                {
                    var return_v = this_param.ContainsTarget(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2898, 2921);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1505_3013_3041()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 3013, 3041);
                    return return_v;
                }


                string
                f_1505_3080_3090(System.Linq.Expressions.LabelTarget
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 3080, 3090);
                    return return_v;
                }


                string
                f_1505_2999_3091(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2999, 3091);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_2969_3092(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 2969, 3092);
                    return return_v;
                }


                int
                f_1505_3143_3163(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                scope)
                {
                    this_param.AddDefinition(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 3143, 3163);
                    return 0;
                }


                int
                f_1505_3178_3209(System.Management.Automation.Interpreter.LabelScopeInfo
                this_param, System.Linq.Expressions.LabelTarget
                target, System.Management.Automation.Interpreter.LabelInfo
                info)
                {
                    this_param.AddLabelInfo(target, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 3178, 3209);
                    return 0;
                }


                bool
                f_1505_3279_3293()
                {
                    var return_v = HasDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 3279, 3293);
                    return return_v;
                }


                bool
                f_1505_3297_3320_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 3297, 3320);
                    return return_v;
                }


                int
                f_1505_3425_3440(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                reference)
                {
                    this_param.ValidateJump(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 3425, 3440);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>
                f_1505_3372_3383_I(System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 3372, 3383);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_3708_3755(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 3708, 3755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 2535, 4078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 2535, 4078);
            }
        }

        private void ValidateJump(LabelScopeInfo reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 4090, 6023);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4229, 4242);
                    // look for a simple jump out
                    for (LabelScopeInfo
        j = reference
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4209, 4571) || true) && (j != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4255, 4267)
        , j = j.Parent, DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 4209, 4571))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 4209, 4571);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4301, 4434) || true) && (f_1505_4305_4317(this, j))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 4301, 4434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4408, 4415);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 4301, 4434);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4454, 4556) || true) && (j.Kind == LabelScopeKind.Filter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 4454, 4556);
                            DynAbs.Tracing.TraceSender.TraceBreak(1505, 4531, 4537);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 4454, 4556);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4587, 4611);

                _acrossBlockJump = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4627, 4817) || true) && (f_1505_4631_4653())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 4627, 4817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4687, 4802);

                    throw f_1505_4693_4801(f_1505_4723_4800(f_1505_4737_4765(), "Ambiguous jump {0}", f_1505_4789_4799(_node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 4627, 4817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4911, 4950);

                LabelScopeInfo
                def = f_1505_4932_4949(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 4964, 5030);

                LabelScopeInfo
                common = f_1505_4988_5029(def, reference, b => b.Parent)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5131, 5144);

                    // Validate that we aren't jumping across a finally
                    for (LabelScopeInfo
        j = reference
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5111, 5388) || true) && (j != common)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5159, 5171)
        , j = j.Parent, DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5111, 5388))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5111, 5388);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5205, 5373) || true) && (j.Kind == LabelScopeKind.Filter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5205, 5373);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5282, 5354);

                            throw f_1505_5288_5353("Control cannot leave filter test");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5205, 5373);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 278);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5502, 5509);

                    // Validate that we aren't jumping into a catch or an expression
                    for (LabelScopeInfo
        j = def
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5482, 6012) || true) && (j != common)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5524, 5536)
        , j = j.Parent, DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5482, 6012))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5482, 6012);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5570, 5997) || true) && (f_1505_5574_5588_M(!j.CanJumpInto))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5570, 5997);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5630, 5978) || true) && (j.Kind == LabelScopeKind.Expression)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5630, 5978);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5719, 5793);

                                throw f_1505_5725_5792("Control cannot enter an expression");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5630, 5978);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 5630, 5978);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 5891, 5955);

                                throw f_1505_5897_5954("Control cannot enter try");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5630, 5978);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 5570, 5997);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 4090, 6023);

                bool
                f_1505_4305_4317(System.Management.Automation.Interpreter.LabelInfo
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                scope)
                {
                    var return_v = this_param.DefinedIn(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 4305, 4317);
                    return return_v;
                }


                bool
                f_1505_4631_4653()
                {
                    var return_v = HasMultipleDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 4631, 4653);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1505_4737_4765()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 4737, 4765);
                    return return_v;
                }


                string
                f_1505_4789_4799(System.Linq.Expressions.LabelTarget
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 4789, 4799);
                    return return_v;
                }


                string
                f_1505_4723_4800(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 4723, 4800);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_4693_4801(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 4693, 4801);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelScopeInfo
                f_1505_4932_4949(System.Management.Automation.Interpreter.LabelInfo
                this_param)
                {
                    var return_v = this_param.FirstDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 4932, 4949);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LabelScopeInfo
                f_1505_4988_5029(System.Management.Automation.Interpreter.LabelScopeInfo
                first, System.Management.Automation.Interpreter.LabelScopeInfo
                second, System.Func<System.Management.Automation.Interpreter.LabelScopeInfo, System.Management.Automation.Interpreter.LabelScopeInfo>
                parent)
                {
                    var return_v = CommonNode(first, second, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 4988, 5029);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_5288_5353(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 5288, 5353);
                    return return_v;
                }


                bool
                f_1505_5574_5588_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 5574, 5588);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_5725_5792(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 5725, 5792);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_5897_5954(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 5897, 5954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 4090, 6023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 4090, 6023);
            }
        }

        internal void ValidateFinish()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 6035, 6335);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6169, 6324) || true) && (f_1505_6173_6190(_references) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1505, 6173, 6213) && f_1505_6198_6213_M(!HasDefinitions)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 6169, 6324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6247, 6309);

                    throw f_1505_6253_6308("label target undefined");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 6169, 6324);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 6035, 6335);

                int
                f_1505_6173_6190(System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 6173, 6190);
                    return return_v;
                }


                bool
                f_1505_6198_6213_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 6198, 6213);
                    return return_v;
                }


                System.InvalidOperationException
                f_1505_6253_6308(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 6253, 6308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 6035, 6335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 6035, 6335);
            }
        }

        private void EnsureLabel(LightCompiler compiler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 6347, 6541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6420, 6530) || true) && (_label == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 6420, 6530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6472, 6515);

                    _label = f_1505_6481_6514(f_1505_6481_6502(compiler));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 6420, 6530);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 6347, 6541);

                System.Management.Automation.Interpreter.InstructionList
                f_1505_6481_6502(System.Management.Automation.Interpreter.LightCompiler
                this_param)
                {
                    var return_v = this_param.Instructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 6481, 6502);
                    return return_v;
                }


                System.Management.Automation.Interpreter.BranchLabel
                f_1505_6481_6514(System.Management.Automation.Interpreter.InstructionList
                this_param)
                {
                    var return_v = this_param.MakeLabel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 6481, 6514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 6347, 6541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 6347, 6541);
            }
        }

        private bool DefinedIn(LabelScopeInfo scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 6553, 6963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6622, 6708) || true) && (_definitions == scope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 6622, 6708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6681, 6693);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 6622, 6708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6724, 6802);

                HashSet<LabelScopeInfo>
                definitions = _definitions as HashSet<LabelScopeInfo>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6816, 6923) || true) && (definitions != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 6816, 6923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6873, 6908);

                    return f_1505_6880_6907(definitions, scope);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 6816, 6923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 6939, 6952);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 6553, 6963);

                bool
                f_1505_6880_6907(System.Collections.Generic.HashSet<System.Management.Automation.Interpreter.LabelScopeInfo>
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 6880, 6907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 6553, 6963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 6553, 6963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 7027, 7106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7063, 7091);

                    return _definitions != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 7027, 7106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 6975, 7117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 6975, 7117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LabelScopeInfo FirstDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 7129, 7423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7194, 7248);

                LabelScopeInfo
                scope = _definitions as LabelScopeInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7262, 7341) || true) && (scope != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 7262, 7341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7313, 7326);

                    return scope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 7262, 7341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7357, 7412);

                return f_1505_7364_7411(((HashSet<LabelScopeInfo>)_definitions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 7129, 7423);

                System.Management.Automation.Interpreter.LabelScopeInfo
                f_1505_7364_7411(System.Collections.Generic.HashSet<System.Management.Automation.Interpreter.LabelScopeInfo>
                source)
                {
                    var return_v = source.First<System.Management.Automation.Interpreter.LabelScopeInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 7364, 7411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 7129, 7423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 7129, 7423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDefinition(LabelScopeInfo scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 7435, 7962);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7508, 7951) || true) && (_definitions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 7508, 7951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7566, 7587);

                    _definitions = scope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 7508, 7951);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 7508, 7951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7653, 7723);

                    HashSet<LabelScopeInfo>
                    set = _definitions as HashSet<LabelScopeInfo>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7741, 7901) || true) && (set == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 7741, 7901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7798, 7882);

                        _definitions = set = new HashSet<LabelScopeInfo>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (LabelScopeInfo)_definitions, 1505, 7819, 7881) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 7741, 7901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 7921, 7936);

                    f_1505_7921_7935(
                                    set, scope);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 7508, 7951);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 7435, 7962);

                bool
                f_1505_7921_7935(System.Collections.Generic.HashSet<System.Management.Automation.Interpreter.LabelScopeInfo>
                this_param, System.Management.Automation.Interpreter.LabelScopeInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 7921, 7935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 7435, 7962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 7435, 7962);
            }
        }

        private bool HasMultipleDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 8034, 8132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8070, 8117);

                    return _definitions is HashSet<LabelScopeInfo>;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 8034, 8132);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 7974, 8143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 7974, 8143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1505, 8155, 8806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8265, 8303);

                var
                cmp = f_1505_8275_8302()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8317, 8408) || true) && (f_1505_8321_8346(cmp, first, second))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 8317, 8408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8380, 8393);

                    return first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 8317, 8408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8424, 8454);

                var
                set = f_1505_8434_8453(cmp)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8475, 8484);
                    for (T
        t = first
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8468, 8570) || true) && (t != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8497, 8510)
        , t = f_1505_8501_8510(parent, t), DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 8468, 8570))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 8468, 8570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8544, 8555);

                        f_1505_8544_8554(set, t);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 103);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8593, 8603);

                    for (T
        t = second
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8586, 8767) || true) && (t != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8616, 8629)
        , t = f_1505_8620_8629(parent, t), DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 8586, 8767))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 8586, 8767);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8663, 8752) || true) && (f_1505_8667_8682(set, t))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 8663, 8752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8724, 8733);

                            return t;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 8663, 8752);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1505, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1505, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 8783, 8795);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1505, 8155, 8806);

                System.Collections.Generic.EqualityComparer<T>
                f_1505_8275_8302()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 8275, 8302);
                    return return_v;
                }


                bool
                f_1505_8321_8346(System.Collections.Generic.EqualityComparer<T>
                this_param, T
                x, T
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8321, 8346);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_1505_8434_8453(System.Collections.Generic.EqualityComparer<T>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>((System.Collections.Generic.IEqualityComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8434, 8453);
                    return return_v;
                }


                T
                f_1505_8501_8510(System.Func<T, T>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8501, 8510);
                    return return_v;
                }


                bool
                f_1505_8544_8554(System.Collections.Generic.HashSet<T>
                this_param, T
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8544, 8554);
                    return return_v;
                }


                T
                f_1505_8620_8629(System.Func<T, T>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8620, 8629);
                    return return_v;
                }


                bool
                f_1505_8667_8682(System.Collections.Generic.HashSet<T>
                this_param, T
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 8667, 8682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 8155, 8806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 8155, 8806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LabelInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1505, 1114, 8813);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1505, 1114, 8813);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 1114, 8813);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1505, 1114, 8813);

        System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>
        f_1505_1807_1833()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Interpreter.LabelScopeInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 1807, 1833);
            return return_v;
        }

    }

    internal enum LabelScopeKind
    {
        // any "statement like" node that can be jumped into
        Statement,

        // these correspond to the node of the same name
        Block,
        Switch,
        Lambda,
        Try,

        // these correspond to the part of the try block we're in
        Catch,
        Finally,
        Filter,

        // the catch-all value for any other expression type
        // (means we can't jump into it)
        Expression,
    }
    internal sealed class LabelScopeInfo
    {
        private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels;

        internal readonly LabelScopeKind Kind;

        internal readonly LabelScopeInfo Parent;

        internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1505, 10303, 10448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10112, 10119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10236, 10240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10284, 10290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10395, 10411);

                Parent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10425, 10437);

                Kind = kind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1505, 10303, 10448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 10303, 10448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 10303, 10448);
            }
        }

        internal bool CanJumpInto
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 10614, 10985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10650, 10937);

                    switch (Kind)
                    {

                        case LabelScopeKind.Block:
                        case LabelScopeKind.Statement:
                        case LabelScopeKind.Switch:
                        case LabelScopeKind.Lambda:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 10650, 10937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10906, 10918);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 10650, 10937);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 10957, 10970);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 10614, 10985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 10564, 10996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 10564, 10996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ContainsTarget(LabelTarget target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 11008, 11224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11081, 11162) || true) && (_labels == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 11081, 11162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11134, 11147);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 11081, 11162);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11178, 11213);

                return f_1505_11185_11212(_labels, target);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 11008, 11224);

                bool
                f_1505_11185_11212(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                this_param, System.Linq.Expressions.LabelTarget
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 11185, 11212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 11008, 11224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 11008, 11224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 11236, 11513);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11330, 11441) || true) && (_labels == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 11330, 11441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11383, 11395);

                    info = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11413, 11426);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 11330, 11441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11457, 11502);

                return f_1505_11464_11501(_labels, target, out info);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 11236, 11513);

                bool
                f_1505_11464_11501(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                this_param, System.Linq.Expressions.LabelTarget
                key, out System.Management.Automation.Interpreter.LabelInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 11464, 11501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 11236, 11513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 11236, 11513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddLabelInfo(LabelTarget target, LabelInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1505, 11525, 11838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11612, 11638);

                f_1505_11612_11637(f_1505_11625_11636());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11654, 11788) || true) && (_labels == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1505, 11654, 11788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11707, 11773);

                    _labels = f_1505_11717_11772();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1505, 11654, 11788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1505, 11804, 11827);

                _labels[target] = info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1505, 11525, 11838);

                bool
                f_1505_11625_11636()
                {
                    var return_v = CanJumpInto;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1505, 11625, 11636);
                    return return_v;
                }


                int
                f_1505_11612_11637(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 11612, 11637);
                    return 0;
                }


                System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>
                f_1505_11717_11772()
                {
                    var return_v = new System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.LabelInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1505, 11717, 11772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1505, 11525, 11838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 11525, 11838);
            }
        }

        static LabelScopeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1505, 10001, 11845);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1505, 10001, 11845);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1505, 10001, 11845);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1505, 10001, 11845);
    }
}
