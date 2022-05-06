// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Text;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal static class DisplayCondition
    {
        internal static bool Evaluate(PSObject obj, PSPropertyExpression ex, out PSPropertyExpressionResult expressionResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 423, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 565, 589);

                expressionResult = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 603, 660);

                List<PSPropertyExpressionResult>
                res = f_1128_642_659(ex, obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 674, 724) || true) && (f_1128_678_687(res) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 674, 724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 711, 724);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 674, 724);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 738, 872) || true) && (f_1128_742_758(f_1128_742_748(res, 0)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 738, 872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 800, 826);

                    expressionResult = f_1128_819_825(res, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 844, 857);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 738, 872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 888, 936);

                return f_1128_895_935(f_1128_921_934(f_1128_921_927(res, 0)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 423, 947);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1128_642_659(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 642, 659);
                    return return_v;
                }


                int
                f_1128_678_687(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 678, 687);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1128_742_748(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 742, 748);
                    return return_v;
                }


                System.Exception
                f_1128_742_758(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 742, 758);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1128_819_825(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 819, 825);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1128_921_927(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 921, 927);
                    return return_v;
                }


                object
                f_1128_921_934(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 921, 934);
                    return return_v;
                }


                bool
                f_1128_895_935(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 895, 935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 423, 947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 423, 947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DisplayCondition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1128, 368, 954);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1128, 368, 954);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 368, 954);
        }

    }
    internal sealed class TypeMatchItem
    {
        internal TypeMatchItem(object obj, AppliesTo a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1128, 1217, 1339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1553, 1582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1594, 1631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1643, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1289, 1300);

                Item = obj;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1314, 1328);

                AppliesTo = a;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1128, 1217, 1339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 1217, 1339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 1217, 1339);
            }
        }

        internal TypeMatchItem(object obj, AppliesTo a, PSObject currentObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1128, 1351, 1541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1553, 1582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1594, 1631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1643, 1683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1447, 1458);

                Item = obj;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1472, 1486);

                AppliesTo = a;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 1500, 1530);

                CurrentObject = currentObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1128, 1351, 1541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 1351, 1541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 1351, 1541);
            }
        }

        internal object Item { get; }

        internal AppliesTo AppliesTo { get; }

        internal PSObject CurrentObject { get; }

        static TypeMatchItem()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1128, 1165, 1690);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1128, 1165, 1690);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 1165, 1690);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1128, 1165, 1690);
    }
    internal sealed class TypeMatch
    {
        [TraceSource("TypeMatch", "F&O TypeMatch")]
        private static readonly PSTraceSource s_classTracer;

        private static PSTraceSource s_activeTracer;

        private static PSTraceSource ActiveTracer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 2242, 2332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2278, 2317);

                    return s_activeTracer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSTraceSource>(1128, 2285, 2316) ?? s_classTracer);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 2242, 2332);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 2176, 2343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 2176, 2343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void SetTracer(PSTraceSource t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 2355, 2457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2427, 2446);

                s_activeTracer = t;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 2355, 2457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 2355, 2457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 2355, 2457);
            }
        }

        internal static void ResetTracer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 2469, 2570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2528, 2559);

                s_activeTracer = s_classTracer;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 2469, 2570);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 2469, 2570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 2469, 2570);
            }
        }

        internal TypeMatch(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1128, 2609, 2905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7515, 7533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7569, 7572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7610, 7628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7652, 7667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7692, 7733);
                this._bestMatchIndex = BestMatchIndexUndefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7766, 7780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2750, 2789);

                _expressionFactory = expressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2803, 2812);

                _db = db;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2826, 2857);

                _typeNameHierarchy = typeNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2871, 2894);

                _useInheritance = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1128, 2609, 2905);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 2609, 2905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 2609, 2905);
            }
        }

        internal TypeMatch(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, Collection<string> typeNames, bool useInheritance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1128, 2917, 3244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7515, 7533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7569, 7572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7610, 7628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7652, 7667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7692, 7733);
                this._bestMatchIndex = BestMatchIndexUndefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7766, 7780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3079, 3118);

                _expressionFactory = expressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3132, 3141);

                _db = db;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3155, 3186);

                _typeNameHierarchy = typeNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3200, 3233);

                _useInheritance = useInheritance;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1128, 2917, 3244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 2917, 3244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 2917, 3244);
            }
        }

        internal bool PerfectMatch(TypeMatchItem item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 3256, 3768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3327, 3392);

                int
                match = f_1128_3339_3391(this, f_1128_3356_3370(item), f_1128_3372_3390(item))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3406, 3474) || true) && (match == BestMatchIndexUndefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 3406, 3474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3461, 3474);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 3406, 3474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3490, 3693) || true) && (_bestMatchIndex == BestMatchIndexUndefined || (DynAbs.Tracing.TraceSender.Expression_False(1128, 3494, 3580) || match < _bestMatchIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 3490, 3693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3614, 3638);

                    _bestMatchIndex = match;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3656, 3678);

                    _bestMatchItem = item;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 3490, 3693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3709, 3757);

                return _bestMatchIndex == BestMatchIndexPerfect;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 3256, 3768);

                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1128_3356_3370(Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                this_param)
                {
                    var return_v = this_param.AppliesTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 3356, 3370);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1128_3372_3390(Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                this_param)
                {
                    var return_v = this_param.CurrentObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 3372, 3390);
                    return return_v;
                }


                int
                f_1128_3339_3391(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                appliesTo, System.Management.Automation.PSObject
                currentObject)
                {
                    var return_v = this_param.ComputeBestMatch(appliesTo, currentObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 3339, 3391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 3256, 3768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 3256, 3768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object BestMatch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 3830, 3987);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3866, 3927) || true) && (_bestMatchItem == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 3866, 3927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3915, 3927);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 3866, 3927);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 3945, 3972);

                    return f_1128_3952_3971(_bestMatchItem);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 3830, 3987);

                    object
                    f_1128_3952_3971(Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                    this_param)
                    {
                        var return_v = this_param.Item;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 3952, 3971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 3780, 3998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 3780, 3998);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int ComputeBestMatch(AppliesTo appliesTo, PSObject currentObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 4010, 5703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4108, 4143);

                int
                best = BestMatchIndexUndefined
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4157, 5664);
                    foreach (TypeOrGroupReference r in f_1128_4192_4215_I(appliesTo.referenceList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 4157, 5664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4249, 4280);

                        PSPropertyExpression
                        ex = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4298, 4455) || true) && (r.conditionToken != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 4298, 4455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4368, 4436);

                            ex = f_1128_4373_4435(_expressionFactory, r.conditionToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 4298, 4455);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4475, 4518);

                        int
                        currentMatch = BestMatchIndexUndefined
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4536, 4574);

                        TypeReference
                        tr = r as TypeReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4594, 5386) || true) && (tr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 4594, 5386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4689, 4747);

                            currentMatch = f_1128_4704_4746(this, tr.name, currentObject, ex);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 4594, 5386);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 4594, 5386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 4884, 4933);

                            TypeGroupReference
                            tgr = r as TypeGroupReference
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5036, 5114);

                            TypeGroupDefinition
                            tgd = f_1128_5062_5113(_db, tgr.name)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5138, 5367) || true) && (tgd != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 5138, 5367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5281, 5344);

                                currentMatch = f_1128_5296_5343(this, tgd, currentObject, ex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 5138, 5367);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 4594, 5386);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5406, 5490) || true) && (currentMatch == BestMatchIndexPerfect)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 5406, 5490);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5470, 5490);

                            return currentMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 5406, 5490);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5510, 5649) || true) && (best == BestMatchIndexUndefined || (DynAbs.Tracing.TraceSender.Expression_False(1128, 5514, 5568) || best < currentMatch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 5510, 5649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5610, 5630);

                            best = currentMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 5510, 5649);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 4157, 5664);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 1508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 1508);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5680, 5692);

                return best;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 4010, 5703);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1128_4373_4435(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et)
                {
                    var return_v = this_param.CreateFromExpressionToken(et);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 4373, 4435);
                    return return_v;
                }


                int
                f_1128_4704_4746(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, string
                typeName, System.Management.Automation.PSObject
                currentObject, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = this_param.MatchTypeIndex(typeName, currentObject, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 4704, 4746);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                f_1128_5062_5113(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, string
                groupName)
                {
                    var return_v = DisplayDataQuery.FindGroupDefinition(db, groupName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 5062, 5113);
                    return return_v;
                }


                int
                f_1128_5296_5343(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                tgd, System.Management.Automation.PSObject
                currentObject, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = this_param.ComputeBestMatchInGroup(tgd, currentObject, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 5296, 5343);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                f_1128_4192_4215_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 4192, 4215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 4010, 5703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 4010, 5703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int ComputeBestMatchInGroup(TypeGroupDefinition tgd, PSObject currentObject, PSPropertyExpression ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 5715, 6407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5849, 5884);

                int
                best = BestMatchIndexUndefined
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5898, 5908);

                int
                k = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 5922, 6368);
                    foreach (TypeReference tr in f_1128_5951_5972_I(tgd.typeReferenceList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 5922, 6368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6006, 6068);

                        int
                        currentMatch = f_1128_6025_6067(this, tr.name, currentObject, ex)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6086, 6170) || true) && (currentMatch == BestMatchIndexPerfect)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6086, 6170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6150, 6170);

                            return currentMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6086, 6170);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6190, 6329) || true) && (best == BestMatchIndexUndefined || (DynAbs.Tracing.TraceSender.Expression_False(1128, 6194, 6248) || best < currentMatch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6190, 6329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6290, 6310);

                            best = currentMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6190, 6329);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6349, 6353);

                        k++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 5922, 6368);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6384, 6396);

                return best;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 5715, 6407);

                int
                f_1128_6025_6067(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, string
                typeName, System.Management.Automation.PSObject
                currentObject, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = this_param.MatchTypeIndex(typeName, currentObject, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 6025, 6067);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
                f_1128_5951_5972_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 5951, 5972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 5715, 6407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 5715, 6407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int MatchTypeIndex(string typeName, PSObject currentObject, PSPropertyExpression ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 6419, 7113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6536, 6620) || true) && (f_1128_6540_6570(typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6536, 6620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6589, 6620);

                    return BestMatchIndexUndefined;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6536, 6620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6634, 6644);

                int
                k = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6658, 7055);
                    foreach (string name in f_1128_6682_6700_I(_typeNameHierarchy))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6658, 7055);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6734, 6939) || true) && (f_1128_6738_6803(name, typeName, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1128, 6738, 6869) && f_1128_6836_6869(this, currentObject, ex)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6734, 6939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6911, 6920);

                            return k;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6734, 6939);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 6959, 7018) || true) && (k == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1128, 6963, 6989) && !_useInheritance))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 6959, 7018);
                            DynAbs.Tracing.TraceSender.TraceBreak(1128, 7012, 7018);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6959, 7018);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7036, 7040);

                        k++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 6658, 7055);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7071, 7102);

                return BestMatchIndexUndefined;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 6419, 7113);

                bool
                f_1128_6540_6570(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 6540, 6570);
                    return return_v;
                }


                bool
                f_1128_6738_6803(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 6738, 6803);
                    return return_v;
                }


                bool
                f_1128_6836_6869(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, System.Management.Automation.PSObject
                currentObject, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = this_param.MatchCondition(currentObject, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 6836, 6869);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_6682_6700_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 6682, 6700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 6419, 7113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 6419, 7113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MatchCondition(PSObject currentObject, PSPropertyExpression ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1128, 7125, 7467);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7226, 7271) || true) && (ex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 7226, 7271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7259, 7271);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 7226, 7271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7287, 7331);

                PSPropertyExpressionResult
                expressionResult
                = default(PSPropertyExpressionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7345, 7426);

                bool
                retVal = f_1128_7359_7425(currentObject, ex, out expressionResult)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7442, 7456);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1128, 7125, 7467);

                bool
                f_1128_7359_7425(System.Management.Automation.PSObject
                obj, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                expressionResult)
                {
                    var return_v = DisplayCondition.Evaluate(obj, ex, out expressionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 7359, 7425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 7125, 7467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 7125, 7467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSPropertyExpressionFactory _expressionFactory;

        private TypeInfoDataBase _db;

        private Collection<string> _typeNameHierarchy;

        private bool _useInheritance;

        private int _bestMatchIndex;

        private TypeMatchItem _bestMatchItem;

        private const int
        BestMatchIndexUndefined = -1
        ;

        private const int
        BestMatchIndexPerfect = 0
        ;

        static TypeMatch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1128, 1853, 7901);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2018, 2100);
            s_classTracer = f_1128_2047_2100("TypeMatch", "F&O TypeMatch");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 2142, 2163);
            s_activeTracer = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7811, 7839);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 7868, 7893);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1128, 1853, 7901);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 1853, 7901);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1128, 1853, 7901);

        static System.Management.Automation.PSTraceSource
        f_1128_2047_2100(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 2047, 2100);
            return return_v;
        }

    }
    internal static class DisplayDataQuery
    {
        [TraceSource("DisplayDataQuery", "DisplayDataQuery")]
        private static readonly PSTraceSource s_classTracer;

        private static PSTraceSource s_activeTracer;

        private static PSTraceSource ActiveTracer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 8325, 8415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8361, 8400);

                    return s_activeTracer ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSTraceSource>(1128, 8368, 8399) ?? s_classTracer);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 8325, 8415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 8259, 8426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 8259, 8426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void SetTracer(PSTraceSource t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 8438, 8540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8510, 8529);

                s_activeTracer = t;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 8438, 8540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 8438, 8540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 8438, 8540);
            }
        }

        internal static void ResetTracer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 8552, 8653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8611, 8642);

                s_activeTracer = s_classTracer;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 8552, 8653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 8552, 8653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 8552, 8653);
            }
        }

        internal static EnumerableExpansion GetEnumerableExpansionFromType(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 8692, 10034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8881, 8947);

                TypeMatch
                match = f_1128_8899_8946(expressionFactory, db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8961, 9326);
                    foreach (EnumerableExpansionDirective expansionDirective in f_1128_9021_9079_I(db.defaultSettingsSection.enumerableExpansionDirectiveList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 8961, 9326);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9113, 9311) || true) && (f_1128_9117_9204(match, f_1128_9136_9203(expansionDirective, expansionDirective.appliesTo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 9113, 9311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9246, 9292);

                            return expansionDirective.enumerableExpansion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 9113, 9311);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 8961, 9326);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 366);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9342, 10023) || true) && (f_1128_9346_9361(match) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 9342, 10023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9403, 9480);

                    return ((EnumerableExpansionDirective)(f_1128_9442_9457(match))).enumerableExpansion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 9342, 10023);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 9342, 10023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9546, 9636);

                    Collection<string>
                    typesWithoutPrefix = f_1128_9586_9635(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9654, 9884) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 9654, 9884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9726, 9829);

                        EnumerableExpansion
                        result = f_1128_9755_9828(expressionFactory, db, typesWithoutPrefix)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9851, 9865);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 9654, 9884);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 9972, 10008);

                    return EnumerableExpansion.EnumOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 9342, 10023);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 8692, 10034);

                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1128_8899_8946(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 8899, 8946);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1128_9136_9203(Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 9136, 9203);
                    return return_v;
                }


                bool
                f_1128_9117_9204(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 9117, 9204);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
                f_1128_9021_9079_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansionDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 9021, 9079);
                    return return_v;
                }


                object
                f_1128_9346_9361(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 9346, 9361);
                    return return_v;
                }


                object
                f_1128_9442_9457(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 9442, 9457);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_9586_9635(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 9586, 9635);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                f_1128_9755_9828(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = GetEnumerableExpansionFromType(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 9755, 9828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 8692, 10034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 8692, 10034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FormatShape GetShapeFromType(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 10046, 11399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10213, 10307);

                ShapeSelectionDirectives
                shapeDirectives = db.defaultSettingsSection.shapeSelectionDirectives
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10323, 10389);

                TypeMatch
                match = f_1128_10341_10388(expressionFactory, db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10403, 10730);
                    foreach (FormatShapeSelectionOnType shapeSelOnType in f_1128_10457_10503_I(shapeDirectives.formatShapeSelectionOnTypeList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 10403, 10730);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10537, 10715) || true) && (f_1128_10541_10620(match, f_1128_10560_10619(shapeSelOnType, shapeSelOnType.appliesTo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 10537, 10715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10662, 10696);

                            return shapeSelOnType.formatShape;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 10537, 10715);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 10403, 10730);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 328);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10746, 11388) || true) && (f_1128_10750_10765(match) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 10746, 11388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10807, 10874);

                    return ((FormatShapeSelectionOnType)(f_1128_10844_10859(match))).formatShape;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 10746, 11388);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 10746, 11388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 10940, 11030);

                    Collection<string>
                    typesWithoutPrefix = f_1128_10980_11029(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11048, 11256) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 11048, 11256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11120, 11201);

                        FormatShape
                        result = f_1128_11141_11200(expressionFactory, db, typesWithoutPrefix)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11223, 11237);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 11048, 11256);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11344, 11373);

                    return FormatShape.Undefined;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 10746, 11388);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 10046, 11399);

                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1128_10341_10388(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 10341, 10388);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1128_10560_10619(Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 10560, 10619);
                    return return_v;
                }


                bool
                f_1128_10541_10620(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 10541, 10620);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType>
                f_1128_10457_10503_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatShapeSelectionOnType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 10457, 10503);
                    return return_v;
                }


                object
                f_1128_10750_10765(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 10750, 10765);
                    return return_v;
                }


                object
                f_1128_10844_10859(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 10844, 10859);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_10980_11029(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 10980, 11029);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                f_1128_11141_11200(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = GetShapeFromType(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 11141, 11200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 10046, 11399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 10046, 11399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FormatShape GetShapeFromPropertyCount(TypeInfoDataBase db, int propertyCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 11411, 11717);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11529, 11666) || true) && (propertyCount <= f_1128_11550_11622(db.defaultSettingsSection.shapeSelectionDirectives))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 11529, 11666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11641, 11666);

                    return FormatShape.Table;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 11529, 11666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11682, 11706);

                return FormatShape.List;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 11411, 11717);

                int
                f_1128_11550_11622(Microsoft.PowerShell.Commands.Internal.Format.ShapeSelectionDirectives
                this_param)
                {
                    var return_v = this_param.PropertyCountForTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 11550, 11622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 11411, 11717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 11411, 11717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ViewDefinition GetViewByShapeAndType(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db,
                        FormatShape shape, Collection<string> typeNames, string viewName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 11729, 12990);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 11957, 12096) || true) && (shape == FormatShape.Undefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 11957, 12096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12025, 12081);

                    return f_1128_12032_12080(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 11957, 12096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12184, 12205);

                System.Type
                t = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12219, 12901) || true) && (shape == FormatShape.Table)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12219, 12901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12283, 12312);

                    t = typeof(TableControlBody);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12219, 12901);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12219, 12901);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12346, 12901) || true) && (shape == FormatShape.List)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12346, 12901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12409, 12437);

                        t = typeof(ListControlBody);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12346, 12901);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12346, 12901);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12471, 12901) || true) && (shape == FormatShape.Wide)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12471, 12901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12534, 12562);

                            t = typeof(WideControlBody);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12471, 12901);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12471, 12901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12596, 12901) || true) && (shape == FormatShape.Complex)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12596, 12901);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12662, 12693);

                                t = typeof(ComplexControlBody);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12596, 12901);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 12596, 12901);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12759, 12856);

                                f_1128_12759_12855(false, "unknown shape: this should never happen unless a new shape is added");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12874, 12886);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12596, 12901);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12471, 12901);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12346, 12901);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 12219, 12901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 12917, 12979);

                return f_1128_12924_12978(expressionFactory, db, t, typeNames, viewName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 11729, 12990);

                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_12032_12080(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = GetDefaultView(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 12032, 12080);
                    return return_v;
                }


                int
                f_1128_12759_12855(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 12759, 12855);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_12924_12978(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Type
                mainControlType, System.Collections.ObjectModel.Collection<string>
                typeNames, string
                viewName)
                {
                    var return_v = GetView(expressionFactory, db, mainControlType, typeNames, viewName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 12924, 12978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 11729, 12990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 11729, 12990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ViewDefinition GetOutOfBandView(PSPropertyExpressionFactory expressionFactory,
                                                                TypeInfoDataBase db, Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 13002, 14312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13229, 13295);

                TypeMatch
                match = f_1128_13247_13294(expressionFactory, db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13309, 13636);
                    foreach (ViewDefinition vd in f_1128_13339_13383_I(db.viewDefinitionsSection.viewDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 13309, 13636);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13417, 13473) || true) && (!f_1128_13422_13441(vd))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 13417, 13473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13464, 13473);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 13417, 13473);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13491, 13621) || true) && (f_1128_13495_13550(match, f_1128_13514_13549(vd, vd.appliesTo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 13491, 13621);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13592, 13602);

                            return vd;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 13491, 13621);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 13309, 13636);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13698, 13756);

                ViewDefinition
                result = f_1128_13722_13737(match) as ViewDefinition
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13936, 14271) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 13936, 14271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 13988, 14078);

                    Collection<string>
                    typesWithoutPrefix = f_1128_14028_14077(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14096, 14256) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 14096, 14256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14168, 14237);

                        result = f_1128_14177_14236(expressionFactory, db, typesWithoutPrefix);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 14096, 14256);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 13936, 14271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14287, 14301);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 13002, 14312);

                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1128_13247_13294(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 13247, 13294);
                    return return_v;
                }


                bool
                f_1128_13422_13441(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd)
                {
                    var return_v = IsOutOfBandView(vd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 13422, 13441);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1128_13514_13549(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 13514, 13549);
                    return return_v;
                }


                bool
                f_1128_13495_13550(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 13495, 13550);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                f_1128_13339_13383_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 13339, 13383);
                    return return_v;
                }


                object
                f_1128_13722_13737(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 13722, 13737);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_14028_14077(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14028, 14077);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_14177_14236(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = GetOutOfBandView(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14177, 14236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 13002, 14312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 13002, 14312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ViewDefinition GetView(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, System.Type mainControlType, Collection<string> typeNames, string viewName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 14324, 17427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14530, 14596);

                TypeMatch
                match = f_1128_14548_14595(expressionFactory, db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14610, 16745);
                    foreach (ViewDefinition vd in f_1128_14640_14684_I(db.viewDefinitionsSection.viewDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 14610, 16745);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14718, 15061) || true) && (vd == null || (DynAbs.Tracing.TraceSender.Expression_False(1128, 14722, 14779) || mainControlType != f_1128_14755_14779(vd.mainControl)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 14718, 15061);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 14821, 15011);

                            f_1128_14821_15010(f_1128_14821_14833(), "NOT MATCH {0}  NAME: {1}", f_1128_14923_14970(vd.mainControl), ((DynAbs.Tracing.TraceSender.Conditional_F1(1128, 14973, 14983) || ((vd != null && DynAbs.Tracing.TraceSender.Conditional_F2(1128, 14986, 14993)) || DynAbs.Tracing.TraceSender.Conditional_F3(1128, 14996, 15008))) ? vd.name : string.Empty));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15033, 15042);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 14718, 15061);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15081, 15366) || true) && (f_1128_15085_15104(vd))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 15081, 15366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15146, 15316);

                            f_1128_15146_15315(f_1128_15146_15158(), "NOT MATCH OutOfBand {0}  NAME: {1}", f_1128_15258_15305(vd.mainControl), vd.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15338, 15347);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 15081, 15366);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15386, 15683) || true) && (vd.appliesTo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 15386, 15683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15452, 15633);

                            f_1128_15452_15632(f_1128_15452_15464(), "NOT MATCH {0}  NAME: {1}  No applicable types", f_1128_15575_15622(vd.mainControl), vd.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15655, 15664);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 15386, 15683);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15812, 16157) || true) && (viewName != null && (DynAbs.Tracing.TraceSender.Expression_True(1128, 15816, 15905) && !f_1128_15837_15905(vd.name, viewName, StringComparison.OrdinalIgnoreCase)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 15812, 16157);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 15947, 16107);

                            f_1128_15947_16106(f_1128_15947_15959(), "NOT MATCH {0}  NAME: {1}", f_1128_16049_16096(vd.mainControl), vd.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16129, 16138);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 15812, 16157);
                        }

                        // check if we have a perfect match
                        // if so, we are done
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16313, 16347);

                            f_1128_16313_16346(f_1128_16333_16345());

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16369, 16559) || true) && (f_1128_16373_16428(match, f_1128_16392_16427(vd, vd.appliesTo)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 16369, 16559);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16478, 16500);

                                f_1128_16478_16499(vd, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16526, 16536);

                                return vd;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 16369, 16559);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1128, 16596, 16687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16644, 16668);

                            f_1128_16644_16667();
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1128, 16596, 16687);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16707, 16730);

                        f_1128_16707_16729(vd, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 14610, 16745);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 2136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 2136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 16807, 16851);

                ViewDefinition
                result = f_1128_16831_16850(match)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17033, 17386) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17033, 17386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17085, 17175);

                    Collection<string>
                    typesWithoutPrefix = f_1128_17125_17174(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17193, 17371) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17193, 17371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17265, 17352);

                        result = f_1128_17274_17351(expressionFactory, db, mainControlType, typesWithoutPrefix, viewName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17193, 17371);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17033, 17386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17402, 17416);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 14324, 17427);

                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1128_14548_14595(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14548, 14595);
                    return return_v;
                }


                System.Type
                f_1128_14755_14779(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14755, 14779);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1128_14821_14833()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 14821, 14833);
                    return return_v;
                }


                string
                f_1128_14923_14970(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14923, 14970);
                    return return_v;
                }


                int
                f_1128_14821_15010(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14821, 15010);
                    return 0;
                }


                bool
                f_1128_15085_15104(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd)
                {
                    var return_v = IsOutOfBandView(vd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15085, 15104);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1128_15146_15158()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 15146, 15158);
                    return return_v;
                }


                string
                f_1128_15258_15305(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15258, 15305);
                    return return_v;
                }


                int
                f_1128_15146_15315(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15146, 15315);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1128_15452_15464()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 15452, 15464);
                    return return_v;
                }


                string
                f_1128_15575_15622(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15575, 15622);
                    return return_v;
                }


                int
                f_1128_15452_15632(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15452, 15632);
                    return 0;
                }


                bool
                f_1128_15837_15905(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15837, 15905);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1128_15947_15959()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 15947, 15959);
                    return return_v;
                }


                string
                f_1128_16049_16096(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16049, 16096);
                    return return_v;
                }


                int
                f_1128_15947_16106(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 15947, 16106);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1128_16333_16345()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 16333, 16345);
                    return return_v;
                }


                int
                f_1128_16313_16346(System.Management.Automation.PSTraceSource
                t)
                {
                    TypeMatch.SetTracer(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16313, 16346);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1128_16392_16427(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16392, 16427);
                    return return_v;
                }


                bool
                f_1128_16373_16428(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16373, 16428);
                    return return_v;
                }


                int
                f_1128_16478_16499(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd, bool
                isMatched)
                {
                    TraceHelper(vd, isMatched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16478, 16499);
                    return 0;
                }


                int
                f_1128_16644_16667()
                {
                    TypeMatch.ResetTracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16644, 16667);
                    return 0;
                }


                int
                f_1128_16707_16729(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd, bool
                isMatched)
                {
                    TraceHelper(vd, isMatched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16707, 16729);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                f_1128_14640_14684_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 14640, 14684);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_16831_16850(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                match)
                {
                    var return_v = GetBestMatch(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 16831, 16850);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_17125_17174(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17125, 17174);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_17274_17351(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Type
                mainControlType, System.Collections.ObjectModel.Collection<string>
                typeNames, string
                viewName)
                {
                    var return_v = GetView(expressionFactory, db, mainControlType, typeNames, viewName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17274, 17351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 14324, 17427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 14324, 17427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void TraceHelper(ViewDefinition vd, bool isMatched)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 17439, 18645);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17530, 18634) || true) && ((f_1128_17535_17555(f_1128_17535_17547()) & PSTraceSourceOptions.WriteLine) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17530, 18634);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17628, 18619);
                        foreach (TypeOrGroupReference togr in f_1128_17666_17692_I(vd.appliesTo.referenceList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17628, 18619);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17734, 17773);

                            StringBuilder
                            sb = f_1128_17753_17772()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17795, 17836);

                            TypeReference
                            tr = togr as TypeReference
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17858, 17909);

                            f_1128_17858_17908(sb, (DynAbs.Tracing.TraceSender.Conditional_F1(1128, 17868, 17877) || ((isMatched && DynAbs.Tracing.TraceSender.Conditional_F2(1128, 17880, 17893)) || DynAbs.Tracing.TraceSender.Conditional_F3(1128, 17896, 17907))) ? "MATCH FOUND" : "NOT MATCH");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17931, 18538) || true) && (tr != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17931, 18538);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 17995, 18166);

                                f_1128_17995_18165(sb, f_1128_18011_18039(), " {0} NAME: {1}  TYPE: {2}", f_1128_18099_18146(vd.mainControl), vd.name, tr.name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17931, 18538);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 17931, 18538);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18264, 18316);

                                TypeGroupReference
                                tgr = togr as TypeGroupReference
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18342, 18515);

                                f_1128_18342_18514(sb, f_1128_18358_18386(), " {0} NAME: {1}  GROUP: {2}", f_1128_18447_18494(vd.mainControl), vd.name, tgr.name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17931, 18538);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18562, 18600);

                            f_1128_18562_18599(f_1128_18562_18574(), f_1128_18585_18598(sb));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17628, 18619);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 992);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 17530, 18634);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 17439, 18645);

                System.Management.Automation.PSTraceSource
                f_1128_17535_17547()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 17535, 17547);
                    return return_v;
                }


                System.Management.Automation.PSTraceSourceOptions
                f_1128_17535_17555(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 17535, 17555);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1128_17753_17772()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17753, 17772);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1128_17858_17908(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17858, 17908);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1128_18011_18039()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 18011, 18039);
                    return return_v;
                }


                string
                f_1128_18099_18146(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18099, 18146);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1128_17995_18165(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17995, 18165);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1128_18358_18386()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 18358, 18386);
                    return return_v;
                }


                string
                f_1128_18447_18494(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18447, 18494);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1128_18342_18514(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18342, 18514);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1128_18562_18574()
                {
                    var return_v =
                                        ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 18562, 18574);
                    return return_v;
                }


                string
                f_1128_18585_18598(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18585, 18598);
                    return return_v;
                }


                int
                f_1128_18562_18599(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18562, 18599);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                f_1128_17666_17692_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 17666, 17692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 17439, 18645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 17439, 18645);
            }
        }

        private static ViewDefinition GetBestMatch(TypeMatch match)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 18657, 18975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18741, 18806);

                ViewDefinition
                bestMatchedVD = f_1128_18772_18787(match) as ViewDefinition
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18820, 18927) || true) && (bestMatchedVD != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 18820, 18927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18879, 18912);

                    f_1128_18879_18911(bestMatchedVD, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 18820, 18927);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 18943, 18964);

                return bestMatchedVD;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 18657, 18975);

                object
                f_1128_18772_18787(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 18772, 18787);
                    return return_v;
                }


                int
                f_1128_18879_18911(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd, bool
                isMatched)
                {
                    TraceHelper(vd, isMatched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 18879, 18911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 18657, 18975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 18657, 18975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ViewDefinition GetDefaultView(PSPropertyExpressionFactory expressionFactory, TypeInfoDataBase db, Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 18987, 21166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19154, 19220);

                TypeMatch
                match = f_1128_19172_19219(expressionFactory, db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19236, 20508);
                    foreach (ViewDefinition vd in f_1128_19266_19310_I(db.viewDefinitionsSection.viewDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 19236, 20508);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19344, 19390) || true) && (vd == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 19344, 19390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19381, 19390);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 19344, 19390);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19410, 19695) || true) && (f_1128_19414_19433(vd))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 19410, 19695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19475, 19645);

                            f_1128_19475_19644(f_1128_19475_19487(), "NOT MATCH OutOfBand {0}  NAME: {1}", f_1128_19587_19634(vd.mainControl), vd.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19667, 19676);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 19410, 19695);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19715, 20012) || true) && (vd.appliesTo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 19715, 20012);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19781, 19962);

                            f_1128_19781_19961(f_1128_19781_19793(), "NOT MATCH {0}  NAME: {1}  No applicable types", f_1128_19904_19951(vd.mainControl), vd.name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 19984, 19993);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 19715, 20012);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20076, 20110);

                            f_1128_20076_20109(f_1128_20096_20108());

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20132, 20322) || true) && (f_1128_20136_20191(match, f_1128_20155_20190(vd, vd.appliesTo)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 20132, 20322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20241, 20263);

                                f_1128_20241_20262(vd, true);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20289, 20299);

                                return vd;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 20132, 20322);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1128, 20359, 20450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20407, 20431);

                            f_1128_20407_20430();
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1128, 20359, 20450);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20470, 20493);

                        f_1128_20470_20492(vd, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 19236, 20508);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 1273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 1273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20568, 20612);

                ViewDefinition
                result = f_1128_20592_20611(match)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20792, 21125) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 20792, 21125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20844, 20934);

                    Collection<string>
                    typesWithoutPrefix = f_1128_20884_20933(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 20952, 21110) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 20952, 21110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 21024, 21091);

                        result = f_1128_21033_21090(expressionFactory, db, typesWithoutPrefix);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 20952, 21110);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 20792, 21125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 21141, 21155);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 18987, 21166);

                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1128_19172_19219(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19172, 19219);
                    return return_v;
                }


                bool
                f_1128_19414_19433(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd)
                {
                    var return_v = IsOutOfBandView(vd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19414, 19433);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1128_19475_19487()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 19475, 19487);
                    return return_v;
                }


                string
                f_1128_19587_19634(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19587, 19634);
                    return return_v;
                }


                int
                f_1128_19475_19644(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19475, 19644);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1128_19781_19793()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 19781, 19793);
                    return return_v;
                }


                string
                f_1128_19904_19951(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19904, 19951);
                    return return_v;
                }


                int
                f_1128_19781_19961(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19781, 19961);
                    return 0;
                }


                System.Management.Automation.PSTraceSource
                f_1128_20096_20108()
                {
                    var return_v = ActiveTracer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 20096, 20108);
                    return return_v;
                }


                int
                f_1128_20076_20109(System.Management.Automation.PSTraceSource
                t)
                {
                    TypeMatch.SetTracer(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20076, 20109);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1128_20155_20190(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20155, 20190);
                    return return_v;
                }


                bool
                f_1128_20136_20191(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20136, 20191);
                    return return_v;
                }


                int
                f_1128_20241_20262(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd, bool
                isMatched)
                {
                    TraceHelper(vd, isMatched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20241, 20262);
                    return 0;
                }


                int
                f_1128_20407_20430()
                {
                    TypeMatch.ResetTracer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20407, 20430);
                    return 0;
                }


                int
                f_1128_20470_20492(Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                vd, bool
                isMatched)
                {
                    TraceHelper(vd, isMatched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20470, 20492);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                f_1128_19266_19310_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 19266, 19310);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_20592_20611(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                match)
                {
                    var return_v = GetBestMatch(match);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20592, 20611);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1128_20884_20933(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 20884, 20933);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1128_21033_21090(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = GetDefaultView(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 21033, 21090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 18987, 21166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 18987, 21166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsOutOfBandView(ViewDefinition vd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 21178, 21367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 21257, 21356);

                return (vd.mainControl is ComplexControlBody || (DynAbs.Tracing.TraceSender.Expression_False(1128, 21265, 21338) || vd.mainControl is ListControlBody)) && (DynAbs.Tracing.TraceSender.Expression_True(1128, 21264, 21355) && vd.outOfBand);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 21178, 21367);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 21178, 21367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 21178, 21367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AppliesTo GetAllApplicableTypes(TypeInfoDataBase db, AppliesTo appliesTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 21704, 23334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 21818, 21887);

                Hashtable
                allTypes = f_1128_21839_21886(f_1128_21853_21885())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 21903, 23100);
                    foreach (TypeOrGroupReference r in f_1128_21938_21961_I(appliesTo.referenceList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 21903, 23100);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22065, 22103);

                        TypeReference
                        tr = r as TypeReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22121, 23085) || true) && (tr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22121, 23085);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22177, 22266) || true) && (!f_1128_22182_22211(allTypes, tr.name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22177, 22266);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22238, 22266);

                                f_1128_22238_22265(allTypes, tr.name, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22177, 22266);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22121, 23085);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22121, 23085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22412, 22461);

                            TypeGroupReference
                            tgr = r as TypeGroupReference
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22485, 22536) || true) && (tgr == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22485, 22536);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22527, 22536);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22485, 22536);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22639, 22699);

                            TypeGroupDefinition
                            tgd = f_1128_22665_22698(db, tgr.name)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22723, 22774) || true) && (tgd == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22723, 22774);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22765, 22774);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22723, 22774);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22853, 23066);
                                foreach (TypeReference x in f_1128_22881_22902_I(tgd.typeReferenceList))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22853, 23066);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 22952, 23043) || true) && (!f_1128_22957_22985(allTypes, x.name))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 22952, 23043);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23016, 23043);

                                        f_1128_23016_23042(allTypes, x.name, null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22952, 23043);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22853, 23066);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 214);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 214);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 22121, 23085);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 21903, 23100);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 1198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 1198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23116, 23151);

                AppliesTo
                retVal = f_1128_23135_23150()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23165, 23293);
                    foreach (DictionaryEntry x in f_1128_23195_23203_I(allTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 23165, 23293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23237, 23278);

                        f_1128_23237_23277(retVal, x.Key as string);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 23165, 23293);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23309, 23323);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 21704, 23334);

                System.StringComparer
                f_1128_21853_21885()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1128, 21853, 21885);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1128_21839_21886(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 21839, 21886);
                    return return_v;
                }


                bool
                f_1128_22182_22211(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 22182, 22211);
                    return return_v;
                }


                int
                f_1128_22238_22265(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 22238, 22265);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition
                f_1128_22665_22698(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, string
                groupName)
                {
                    var return_v = FindGroupDefinition(db, groupName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 22665, 22698);
                    return return_v;
                }


                bool
                f_1128_22957_22985(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 22957, 22985);
                    return return_v;
                }


                int
                f_1128_23016_23042(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23016, 23042);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
                f_1128_22881_22902_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 22881, 22902);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                f_1128_21938_21961_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 21938, 21961);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1128_23135_23150()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AppliesTo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23135, 23150);
                    return return_v;
                }


                int
                f_1128_23237_23277(Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                this_param, object
                typeName)
                {
                    this_param.AddAppliesToType((string)typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23237, 23277);
                    return 0;
                }


                System.Collections.Hashtable
                f_1128_23195_23203_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23195, 23203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 21704, 23334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 21704, 23334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeGroupDefinition FindGroupDefinition(TypeInfoDataBase db, string groupName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 23346, 23740);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23465, 23701);
                    foreach (TypeGroupDefinition tgd in f_1128_23501_23544_I(db.typeGroupSection.typeGroupDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 23465, 23701);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23578, 23686) || true) && (f_1128_23582_23652(tgd.name, groupName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 23578, 23686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23675, 23686);

                            return tgd;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 23578, 23686);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 23465, 23701);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 23717, 23729);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 23346, 23740);

                bool
                f_1128_23582_23652(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23582, 23652);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition>
                f_1128_23501_23544_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeGroupDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 23501, 23544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 23346, 23740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 23346, 23740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ControlBody ResolveControlReference(TypeInfoDataBase db, List<ControlDefinition> viewControlDefinitionList,
                                                                    ControlReference controlReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 23752, 24448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24065, 24183);

                ControlBody
                controlBody = f_1128_24091_24182(controlReference, viewControlDefinitionList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24197, 24258) || true) && (controlBody != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 24197, 24258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24239, 24258);

                    return controlBody;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 24197, 24258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24326, 24437);

                return f_1128_24333_24436(controlReference, db.formatControlDefinitionHolder.controlDefinitionList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 23752, 24448);

                Microsoft.PowerShell.Commands.Internal.Format.ControlBody
                f_1128_24091_24182(Microsoft.PowerShell.Commands.Internal.Format.ControlReference
                controlReference, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList)
                {
                    var return_v = ResolveControlReferenceInList(controlReference, controlDefinitionList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 24091, 24182);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBody
                f_1128_24333_24436(Microsoft.PowerShell.Commands.Internal.Format.ControlReference
                controlReference, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList)
                {
                    var return_v = ResolveControlReferenceInList(controlReference, controlDefinitionList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 24333, 24436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 23752, 24448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 23752, 24448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ControlBody ResolveControlReferenceInList(ControlReference controlReference,
                                                List<ControlDefinition> controlDefinitionList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1128, 24460, 25048);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24664, 25009);
                    foreach (ControlDefinition x in f_1128_24696_24717_I(controlDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 24664, 25009);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24751, 24842) || true) && (f_1128_24755_24778(x.controlBody) != controlReference.controlType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 24751, 24842);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24833, 24842);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 24751, 24842);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24860, 24994) || true) && (f_1128_24864_24945(controlReference.name, x.name, StringComparison.OrdinalIgnoreCase) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1128, 24860, 24994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 24973, 24994);

                            return x.controlBody;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 24860, 24994);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1128, 24664, 25009);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1128, 1, 346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1128, 1, 346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 25025, 25037);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1128, 24460, 25048);

                System.Type
                f_1128_24755_24778(Microsoft.PowerShell.Commands.Internal.Format.ControlBody
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 24755, 24778);
                    return return_v;
                }


                int
                f_1128_24864_24945(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 24864, 24945);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                f_1128_24696_24717_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 24696, 24717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1128, 24460, 25048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 24460, 25048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DisplayDataQuery()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1128, 7909, 25055);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8091, 8183);
            s_classTracer = f_1128_8120_8183("DisplayDataQuery", "DisplayDataQuery");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1128, 8225, 8246);
            s_activeTracer = null;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1128, 7909, 25055);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1128, 7909, 25055);
        }


        static System.Management.Automation.PSTraceSource
        f_1128_8120_8183(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1128, 8120, 8183);
            return return_v;
        }

    }
}
