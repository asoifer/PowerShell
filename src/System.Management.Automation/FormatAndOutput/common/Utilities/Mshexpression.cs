// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;

namespace Microsoft.PowerShell.Commands
{
    public class PSPropertyExpressionResult
    {
        public PSPropertyExpressionResult(object res, PSPropertyExpression re, Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1136, 855, 1053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 1195, 1232);
                this.Result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 1353, 1416);
                this.ResolvedExpression = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 1542, 1585);
                this.Exception = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 963, 976);

                Result = res;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 990, 1014);

                ResolvedExpression = re;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 1028, 1042);

                Exception = e;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1136, 855, 1053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 855, 1053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 855, 1053);
            }
        }

        public object Result { get; }

        public PSPropertyExpression ResolvedExpression { get; }

        public Exception Exception { get; }

        static PSPropertyExpressionResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1136, 575, 1592);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1136, 575, 1592);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 575, 1592);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1136, 575, 1592);
    }
    public class PSPropertyExpression
    {
        public PSPropertyExpression(string s)
        : this(f_1136_2202_2203_C(s), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1136, 2144, 2233);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1136, 2144, 2233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 2144, 2233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 2144, 2233);
            }
        }

        public PSPropertyExpression(string s, bool isResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1136, 2612, 2900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3596, 3638);
                this.Script = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11624, 11644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13919, 13931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13955, 13974);
                this._isResolved = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 2691, 2817) || true) && (f_1136_2695_2718(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 2691, 2817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 2752, 2802);

                    throw f_1136_2758_2801("s");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 2691, 2817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 2833, 2850);

                _stringValue = s;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 2864, 2889);

                _isResolved = isResolved;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1136, 2612, 2900);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 2612, 2900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 2612, 2900);
            }
        }

        public PSPropertyExpression(ScriptBlock scriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1136, 3209, 3466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3596, 3638);
                this.Script = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11624, 11644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13919, 13931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13955, 13974);
                this._isResolved = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3286, 3418) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 3286, 3418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3343, 3403);

                    throw f_1136_3349_3402("scriptBlock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 3286, 3418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3434, 3455);

                Script = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1136, 3209, 3466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 3209, 3466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 3209, 3466);
            }
        }

        public ScriptBlock Script { get; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 3765, 3932);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3823, 3885) || true) && (f_1136_3827_3833() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 3823, 3885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3860, 3885);

                    return f_1136_3867_3884(f_1136_3867_3873());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 3823, 3885);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 3901, 3921);

                return _stringValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 3765, 3932);

                System.Management.Automation.ScriptBlock
                f_1136_3827_3833()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 3827, 3833);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1136_3867_3873()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 3867, 3873);
                    return return_v;
                }


                string
                f_1136_3867_3884(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 3867, 3884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 3765, 3932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 3765, 3932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<PSPropertyExpression> ResolveNames(PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 4140, 4273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 4228, 4262);

                return f_1136_4235_4261(this, target, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 4140, 4273);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1136_4235_4261(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target, bool
                expand)
                {
                    var return_v = this_param.ResolveNames(target, expand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 4235, 4261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 4140, 4273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 4140, 4273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasWildCardCharacters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 4535, 4722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 4571, 4625) || true) && (f_1136_4575_4581() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 4571, 4625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 4612, 4625);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 4571, 4625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 4643, 4707);

                    return f_1136_4650_4706(_stringValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 4535, 4722);

                    System.Management.Automation.ScriptBlock
                    f_1136_4575_4581()
                    {
                        var return_v = Script;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 4575, 4581);
                        return return_v;
                    }


                    bool
                    f_1136_4650_4706(string
                    pattern)
                    {
                        var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 4650, 4706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 4477, 4733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 4477, 4733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<PSPropertyExpression> ResolveNames(PSObject target, bool expand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 5041, 9559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5142, 5211);

                List<PSPropertyExpression>
                retVal = f_1136_5178_5210()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5227, 5340) || true) && (_isResolved)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 5227, 5340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5276, 5293);

                    f_1136_5276_5292(retVal, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5311, 5325);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 5227, 5340);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5356, 5659) || true) && (f_1136_5360_5366() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 5356, 5659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5478, 5537);

                    PSPropertyExpression
                    ex = f_1136_5504_5536(f_1136_5529_5535())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5557, 5579);

                    ex._isResolved = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5597, 5612);

                    f_1136_5597_5611(retVal, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5630, 5644);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 5356, 5659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5827, 5876);

                target = f_1136_5836_5875(this, target);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5931, 5972);

                IEnumerable<PSMemberInfo>
                members = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 5986, 7187) || true) && (f_1136_5990_6011())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 5986, 7187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 6136, 6304);

                    members = f_1136_6146_6303(f_1136_6146_6160(target), _stringValue, PSMemberTypes.Properties | PSMemberTypes.PropertySet | PSMemberTypes.Dynamic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 5986, 7187);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 5986, 7187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 6456, 6502);

                    PSMemberInfo
                    x = f_1136_6473_6501(f_1136_6473_6487(target), _stringValue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 6522, 6962) || true) && ((x == null) && (DynAbs.Tracing.TraceSender.Expression_True(1136, 6526, 6605) && (f_1136_6542_6559(target) is System.Dynamic.IDynamicMetaObjectProvider)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 6522, 6962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 6905, 6943);

                        x = f_1136_6909_6942(_stringValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 6522, 6962);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 6982, 7033);

                    List<PSMemberInfo>
                    temp = f_1136_7008_7032()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7051, 7137) || true) && (x != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 7051, 7137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7106, 7118);

                        f_1136_7106_7117(temp, x);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 7051, 7137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7157, 7172);

                    members = temp;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 5986, 7187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7320, 7386);

                List<PSMemberInfo>
                temporaryMemberList = f_1136_7361_7385()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7402, 8957);
                    foreach (PSMemberInfo member in f_1136_7434_7441_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 7402, 8957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7520, 7572);

                        PSPropertySet
                        propertySet = member as PSPropertySet
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7590, 8942) || true) && (propertySet != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 7590, 8942);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7655, 8546) || true) && (expand)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 7655, 8546);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 7927, 7995);

                                Collection<string>
                                references = f_1136_7959_7994(propertySet)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8032, 8037);

                                    for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8023, 8523) || true) && (j < f_1136_8043_8059(references))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8061, 8064)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 8023, 8523))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 8023, 8523);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8122, 8275);

                                        ReadOnlyPSMemberInfoCollection<PSPropertyInfo>
                                        propertyMembers =
                                        f_1136_8236_8274(f_1136_8236_8253(target), f_1136_8260_8273(references, j))
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8314, 8320);
                                            for (int
                jj = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8305, 8496) || true) && (jj < f_1136_8327_8348(propertyMembers))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8350, 8354)
                , jj++, DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 8305, 8496))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 8305, 8496);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8420, 8465);

                                                f_1136_8420_8464(temporaryMemberList, f_1136_8444_8463(propertyMembers, jj));
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1136, 1, 192);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1136, 1, 192);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1136, 1, 501);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1136, 1, 501);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 7655, 8546);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 7590, 8942);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 7590, 8942);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8629, 8942) || true) && (member is PSPropertyInfo)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 8629, 8942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8699, 8731);

                                f_1136_8699_8730(temporaryMemberList, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 8629, 8942);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 8629, 8942);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8820, 8942) || true) && (member is PSDynamicMember)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 8820, 8942);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8891, 8923);

                                    f_1136_8891_8922(temporaryMemberList, member);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 8820, 8942);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 8629, 8942);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 7590, 8942);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 7402, 8957);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1136, 1, 1556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1136, 1, 1556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 8973, 9006);

                Hashtable
                hash = f_1136_8990_9005()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9146, 9518);
                    foreach (PSMemberInfo m in f_1136_9173_9192_I(temporaryMemberList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 9146, 9518);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9226, 9503) || true) && (!f_1136_9231_9255(hash, f_1136_9248_9254(m)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 9226, 9503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9297, 9356);

                            PSPropertyExpression
                            ex = f_1136_9323_9355(f_1136_9348_9354(m))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9380, 9402);

                            ex._isResolved = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9424, 9439);

                            f_1136_9424_9438(retVal, ex);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9461, 9484);

                            f_1136_9461_9483(hash, f_1136_9470_9476(m), null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 9226, 9503);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 9146, 9518);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1136, 1, 373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1136, 1, 373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9534, 9548);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 5041, 9559);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1136_5178_5210()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 5178, 5210);
                    return return_v;
                }


                int
                f_1136_5276_5292(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 5276, 5292);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1136_5360_5366()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 5360, 5366);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1136_5529_5535()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 5529, 5535);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1136_5504_5536(System.Management.Automation.ScriptBlock
                scriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 5504, 5536);
                    return return_v;
                }


                int
                f_1136_5597_5611(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 5597, 5611);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1136_5836_5875(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.IfHashtableWrapAsPSCustomObject(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 5836, 5875);
                    return return_v;
                }


                bool
                f_1136_5990_6011()
                {
                    var return_v = HasWildCardCharacters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 5990, 6011);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1136_6146_6160(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 6146, 6160);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1136_6146_6303(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 6146, 6303);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1136_6473_6487(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 6473, 6487);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1136_6473_6501(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 6473, 6501);
                    return return_v;
                }


                object
                f_1136_6542_6559(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 6542, 6559);
                    return return_v;
                }


                System.Management.Automation.PSDynamicMember
                f_1136_6909_6942(string
                name)
                {
                    var return_v = new System.Management.Automation.PSDynamicMember(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 6909, 6942);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                f_1136_7008_7032()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 7008, 7032);
                    return return_v;
                }


                int
                f_1136_7106_7117(System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 7106, 7117);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                f_1136_7361_7385()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 7361, 7385);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1136_7959_7994(System.Management.Automation.PSPropertySet
                this_param)
                {
                    var return_v = this_param.ReferencedPropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 7959, 7994);
                    return return_v;
                }


                int
                f_1136_8043_8059(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 8043, 8059);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1136_8236_8253(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 8236, 8253);
                    return return_v;
                }


                string
                f_1136_8260_8273(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 8260, 8273);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1136_8236_8274(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                name)
                {
                    var return_v = this_param.Match(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 8236, 8274);
                    return return_v;
                }


                int
                f_1136_8327_8348(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 8327, 8348);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1136_8444_8463(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 8444, 8463);
                    return return_v;
                }


                int
                f_1136_8420_8464(System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSPropertyInfo
                item)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 8420, 8464);
                    return 0;
                }


                int
                f_1136_8699_8730(System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 8699, 8730);
                    return 0;
                }


                int
                f_1136_8891_8922(System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 8891, 8922);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>
                f_1136_7434_7441_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 7434, 7441);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1136_8990_9005()
                {
                    var return_v = new System.Collections.Hashtable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 8990, 9005);
                    return return_v;
                }


                string
                f_1136_9248_9254(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 9248, 9254);
                    return return_v;
                }


                bool
                f_1136_9231_9255(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9231, 9255);
                    return return_v;
                }


                string
                f_1136_9348_9354(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 9348, 9354);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1136_9323_9355(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9323, 9355);
                    return return_v;
                }


                int
                f_1136_9424_9438(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9424, 9438);
                    return 0;
                }


                string
                f_1136_9470_9476(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 9470, 9476);
                    return return_v;
                }


                int
                f_1136_9461_9483(System.Collections.Hashtable
                this_param, string
                key, object?
                value)
                {
                    this_param.Add((object)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9461, 9483);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                f_1136_9173_9192_I(System.Collections.Generic.List<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9173, 9192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 5041, 9559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 5041, 9559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<PSPropertyExpressionResult> GetValues(PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 9771, 9910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 9862, 9899);

                return f_1136_9869_9898(this, target, true, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 9771, 9910);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1136_9869_9898(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target, bool
                expand, bool
                eatExceptions)
                {
                    var return_v = this_param.GetValues(target, expand, eatExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 9869, 9898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 9771, 9910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 9771, 9910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public List<PSPropertyExpressionResult> GetValues(PSObject target, bool expand, bool eatExceptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 10345, 11528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 10469, 10550);

                List<PSPropertyExpressionResult>
                retVal = f_1136_10511_10549()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 10718, 10767);

                target = f_1136_10727_10766(this, target);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 10823, 11125) || true) && (f_1136_10827_10833() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 10823, 11125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 10875, 10948);

                    PSPropertyExpression
                    scriptExpression = f_1136_10915_10947(f_1136_10940_10946())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 10966, 11046);

                    PSPropertyExpressionResult
                    r = f_1136_10997_11045(scriptExpression, target, eatExceptions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11064, 11078);

                    f_1136_11064_11077(retVal, r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11096, 11110);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 10823, 11125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11180, 11266);

                List<PSPropertyExpression>
                resolvedExpressionList = f_1136_11232_11265(this, target, expand)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11282, 11487);
                    foreach (PSPropertyExpression re in f_1136_11318_11340_I(resolvedExpressionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 11282, 11487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11374, 11440);

                        PSPropertyExpressionResult
                        r = f_1136_11405_11439(re, target, eatExceptions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11458, 11472);

                        f_1136_11458_11471(retVal, r);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 11282, 11487);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1136, 1, 206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1136, 1, 206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11503, 11517);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 10345, 11528);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1136_10511_10549()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 10511, 10549);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1136_10727_10766(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.IfHashtableWrapAsPSCustomObject(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 10727, 10766);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1136_10827_10833()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 10827, 10833);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1136_10940_10946()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 10940, 10946);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1136_10915_10947(System.Management.Automation.ScriptBlock
                scriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 10915, 10947);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1136_10997_11045(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target, bool
                eatExceptions)
                {
                    var return_v = this_param.GetValue(target, eatExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 10997, 11045);
                    return return_v;
                }


                int
                f_1136_11064_11077(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11064, 11077);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1136_11232_11265(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target, bool
                expand)
                {
                    var return_v = this_param.ResolveNames(target, expand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11232, 11265);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1136_11405_11439(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target, bool
                eatExceptions)
                {
                    var return_v = this_param.GetValue(target, eatExceptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11405, 11439);
                    return return_v;
                }


                int
                f_1136_11458_11471(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11458, 11471);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1136_11318_11340_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11318, 11340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 10345, 11528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 10345, 11528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CallSite<Func<CallSite, object, object>> _getValueDynamicSite;

        private PSPropertyExpressionResult GetValue(PSObject target, bool eatExceptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 11657, 13356);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11798, 11819);

                    object
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11839, 12945) || true) && (f_1136_11843_11849() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 11839, 12945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 11899, 12302);

                        result = f_1136_11908_12301(f_1136_11908_11914(), useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: target, input: f_1136_12167_12187(), scriptThis: f_1136_12226_12246(), args: f_1136_12279_12300());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 11839, 12945);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 11839, 12945);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 12384, 12828) || true) && (_getValueDynamicSite == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 12384, 12828);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 12466, 12805);

                            _getValueDynamicSite =
                            f_1136_12518_12804(f_1136_12604_12803(_stringValue, null, @static: false));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 12384, 12828);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 12852, 12926);

                        // LAFHIS
                        result = _getValueDynamicSite.Target.Invoke(_getValueDynamicSite, target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 12861, 12925);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 11839, 12945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 12965, 13023);

                    return f_1136_12972_13022(result, this, null);
                }
                catch (RuntimeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1136, 13052, 13345);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13111, 13330) || true) && (eatExceptions)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 13111, 13330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13170, 13223);

                        return f_1136_13177_13222(null, this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 13111, 13330);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 13111, 13330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13305, 13311);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 13111, 13330);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1136, 13052, 13345);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 11657, 13356);

                System.Management.Automation.ScriptBlock
                f_1136_11843_11849()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 11843, 11849);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1136_11908_11914()
                {
                    var return_v = Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 11908, 11914);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1136_12167_12187()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 12167, 12187);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1136_12226_12246()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1136, 12226, 12246);
                    return return_v;
                }


                object[]
                f_1136_12279_12300()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 12279, 12300);
                    return return_v;
                }


                object
                f_1136_11908_12301(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 11908, 12301);
                    return return_v;
                }


                System.Management.Automation.Language.PSGetMemberBinder
                f_1136_12604_12803(string
                memberName, System.Type
                classScope, bool
                @static)
                {
                    var return_v = PSGetMemberBinder.Get(memberName, classScope: classScope, @static: @static);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 12604, 12803);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                f_1136_12518_12804(System.Management.Automation.Language.PSGetMemberBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 12518, 12804);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1136_12972_13022(object
                res, Microsoft.PowerShell.Commands.PSPropertyExpression
                re, System.Exception
                e)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpressionResult(res, re, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 12972, 13022);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1136_13177_13222(object
                res, Microsoft.PowerShell.Commands.PSPropertyExpression
                re, System.Management.Automation.RuntimeException
                e)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpressionResult(res, re, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 13177, 13222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 11657, 13356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 11657, 13356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSObject IfHashtableWrapAsPSCustomObject(PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1136, 13368, 13864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13610, 13823) || true) && (f_1136_13614_13635(target) is Hashtable targetAsHash)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1136, 13610, 13823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13695, 13808);

                    target = (PSObject)(f_1136_13715_13806(targetAsHash, typeof(PSObject), false, null, true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1136, 13610, 13823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1136, 13839, 13853);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1136, 13368, 13864);

                object
                f_1136_13614_13635(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 13614, 13635);
                    return return_v;
                }


                object
                f_1136_13715_13806(System.Collections.Hashtable
                valueToConvert, System.Type
                resultType, bool
                recursion, System.IFormatProvider
                formatProvider, bool
                ignoreUnknownMembers)
                {
                    var return_v = LanguagePrimitives.ConvertPSObjectToType((System.Management.Automation.PSObject)valueToConvert, resultType, recursion, formatProvider, ignoreUnknownMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 13715, 13806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1136, 13368, 13864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 13368, 13864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string _stringValue;

        private bool _isResolved;

        static PSPropertyExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1136, 1906, 14020);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1136, 1906, 14020);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1136, 1906, 14020);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1136, 1906, 14020);

        static string
        f_1136_2202_2203_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1136, 2144, 2233);
            return return_v;
        }


        bool
        f_1136_2695_2718(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 2695, 2718);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1136_2758_2801(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 2758, 2801);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1136_3349_3402(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1136, 3349, 3402);
            return return_v;
        }

    }
}

