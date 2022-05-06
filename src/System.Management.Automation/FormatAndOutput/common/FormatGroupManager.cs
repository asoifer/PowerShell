// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class GroupingInfoManager
    {
        internal void Initialize(PSPropertyExpression groupingExpression, string displayLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1086, 787, 989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 898, 942);

                _groupingKeyExpression = groupingExpression;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 956, 978);

                _label = displayLabel;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1086, 787, 989);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1086, 787, 989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 787, 989);
            }
        }

        internal object CurrentGroupingKeyPropertyValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1086, 1073, 1121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1079, 1119);

                    return _currentGroupingKeyPropertyValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1086, 1073, 1121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1086, 1001, 1132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 1001, 1132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string GroupingKeyDisplayName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1086, 1207, 1362);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1243, 1298) || true) && (_label != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1086, 1243, 1298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1284, 1298);

                        return _label;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1086, 1243, 1298);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1316, 1347);

                    return _groupingKeyDisplayName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1086, 1207, 1362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1086, 1144, 1373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 1144, 1373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool UpdateGroupingKeyValue(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1086, 1640, 3168);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1714, 1780) || true) && (_groupingKeyExpression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1086, 1714, 1780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1767, 1780);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1086, 1714, 1780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1796, 1876);

                List<PSPropertyExpressionResult>
                results = f_1086_1839_1875(_groupingKeyExpression, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 1972, 2734) || true) && (f_1086_1976_1989(results) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1086, 1976, 2025) && f_1086_1997_2017(f_1086_1997_2007(results, 0)) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1086, 1972, 2734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2121, 2157);

                    object
                    newValue = f_1086_2139_2156(f_1086_2139_2149(results, 0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2175, 2226);

                    object
                    oldValue = _currentGroupingKeyPropertyValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2246, 2290);

                    _currentGroupingKeyPropertyValue = newValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2352, 2509);

                    bool
                    update = !(f_1086_2368_2419(_currentGroupingKeyPropertyValue, oldValue) || (DynAbs.Tracing.TraceSender.Expression_False(1086, 2368, 2507) || f_1086_2456_2507(oldValue, _currentGroupingKeyPropertyValue)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2529, 2685) || true) && (update && (DynAbs.Tracing.TraceSender.Expression_True(1086, 2533, 2557) && _label == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1086, 2529, 2685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2599, 2666);

                        _groupingKeyDisplayName = f_1086_2625_2665(f_1086_2625_2654(f_1086_2625_2635(results, 0)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1086, 2529, 2685);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 2705, 2719);

                    return update;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1086, 1972, 2734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3144, 3157);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1086, 1640, 3168);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1086_1839_1875(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 1839, 1875);
                    return return_v;
                }


                int
                f_1086_1976_1989(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 1976, 1989);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1086_1997_2007(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 1997, 2007);
                    return return_v;
                }


                System.Exception
                f_1086_1997_2017(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 1997, 2017);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1086_2139_2149(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 2139, 2149);
                    return return_v;
                }


                object
                f_1086_2139_2156(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 2139, 2156);
                    return return_v;
                }


                bool
                f_1086_2368_2419(object
                first, object
                second)
                {
                    var return_v = IsEqual(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 2368, 2419);
                    return return_v;
                }


                bool
                f_1086_2456_2507(object
                first, object
                second)
                {
                    var return_v = IsEqual(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 2456, 2507);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1086_2625_2635(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 2625, 2635);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1086_2625_2654(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 2625, 2654);
                    return return_v;
                }


                string
                f_1086_2625_2665(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 2625, 2665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1086, 1640, 3168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 1640, 3168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEqual(object first, object second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1086, 3180, 3973);
                int result = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3261, 3427) || true) && (f_1086_3265_3359(first, second, true, f_1086_3316_3342(), out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1086, 3261, 3427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3393, 3412);

                    return result == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1086, 3261, 3427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3715, 3774);

                string
                firstString = f_1086_3736_3773(f_1086_3736_3762(first))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3788, 3849);

                string
                secondString = f_1086_3810_3848(f_1086_3810_3837(second))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 3865, 3962);

                return f_1086_3872_3956(firstString, secondString, StringComparison.CurrentCultureIgnoreCase) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1086, 3180, 3973);

                System.Globalization.CultureInfo
                f_1086_3316_3342()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 3316, 3342);
                    return return_v;
                }


                bool
                f_1086_3265_3359(object
                first, object
                second, bool
                ignoreCase, System.Globalization.CultureInfo
                formatProvider, out int
                result)
                {
                    var return_v = LanguagePrimitives.TryCompare(first, second, ignoreCase, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3265, 3359);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1086_3736_3762(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3736, 3762);
                    return return_v;
                }


                string
                f_1086_3736_3773(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3736, 3773);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1086_3810_3837(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3810, 3837);
                    return return_v;
                }


                string
                f_1086_3810_3848(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3810, 3848);
                    return return_v;
                }


                int
                f_1086_3872_3956(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1086, 3872, 3956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1086, 3180, 3973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 3180, 3973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string _label;

        private string _groupingKeyDisplayName;

        private PSPropertyExpression _groupingKeyExpression;

        private object _currentGroupingKeyPropertyValue;

        public GroupingInfoManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1086, 462, 4626);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 4098, 4111);
            this._label = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 4241, 4271);
            this._groupingKeyDisplayName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 4407, 4436);
            this._groupingKeyExpression = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1086, 4563, 4618);
            this._currentGroupingKeyPropertyValue = f_1086_4598_4618();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1086, 462, 4626);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 462, 4626);
        }


        static GroupingInfoManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1086, 462, 4626);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1086, 462, 4626);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1086, 462, 4626);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1086, 462, 4626);

        System.Management.Automation.PSObject
        f_1086_4598_4618()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1086, 4598, 4618);
            return return_v;
        }

    }
}

