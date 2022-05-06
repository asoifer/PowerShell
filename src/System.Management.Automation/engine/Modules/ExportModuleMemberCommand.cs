// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;
using System.Management.Automation.Internal;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsData.Export, "ModuleMember", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096578")]
    public sealed class ExportModuleMemberCommand : PSCmdlet
    {
        [Parameter(ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, Position = 0)]
        [AllowEmptyCollection]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Function
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 1156, 1748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1192, 1214);

                    _functionList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1388, 1436);

                    _functionPatterns = f_1528_1408_1435();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1454, 1733) || true) && (_functionList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 1454, 1733);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1521, 1714);
                            foreach (string pattern in f_1528_1548_1561_I(_functionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 1521, 1714);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1611, 1691);

                                f_1528_1611_1690(_functionPatterns, f_1528_1633_1689(pattern, WildcardOptions.IgnoreCase));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 1521, 1714);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1528, 1, 194);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1528, 1, 194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 1454, 1733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 1156, 1748);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1528_1408_1435()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 1408, 1435);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1528_1633_1689(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 1633, 1689);
                        return return_v;
                    }


                    int
                    f_1528_1611_1690(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 1611, 1690);
                        return 0;
                    }


                    string[]
                    f_1528_1548_1561_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 1548, 1561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 826, 1804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 826, 1804);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 1764, 1793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1770, 1791);

                    return _functionList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 1764, 1793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 826, 1804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 826, 1804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _functionList;

        private List<WildcardPattern> _functionPatterns;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        [AllowEmptyCollection]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Cmdlet
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 2333, 2915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2369, 2389);

                    _cmdletList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2563, 2609);

                    _cmdletPatterns = f_1528_2581_2608();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2627, 2900) || true) && (_cmdletList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 2627, 2900);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2692, 2881);
                            foreach (string pattern in f_1528_2719_2730_I(_cmdletList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 2692, 2881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2780, 2858);

                                f_1528_2780_2857(_cmdletPatterns, f_1528_2800_2856(pattern, WildcardOptions.IgnoreCase));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 2692, 2881);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1528, 1, 190);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1528, 1, 190);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 2627, 2900);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 2333, 2915);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1528_2581_2608()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 2581, 2608);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1528_2800_2856(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 2800, 2856);
                        return return_v;
                    }


                    int
                    f_1528_2780_2857(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 2780, 2857);
                        return 0;
                    }


                    string[]
                    f_1528_2719_2730_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 2719, 2730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 2045, 2969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 2045, 2969);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 2931, 2958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2937, 2956);

                    return _cmdletList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 2931, 2958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 2045, 2969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 2045, 2969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _cmdletList;

        private List<WildcardPattern> _cmdletPatterns;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Variable
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 3491, 4101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3527, 3555);

                    _variableExportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3729, 3777);

                    _variablePatterns = f_1528_3749_3776();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3795, 4086) || true) && (_variableExportList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 3795, 4086);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3868, 4067);
                            foreach (string pattern in f_1528_3895_3914_I(_variableExportList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 3868, 4067);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3964, 4044);

                                f_1528_3964_4043(_variablePatterns, f_1528_3986_4042(pattern, WildcardOptions.IgnoreCase));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 3868, 4067);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1528, 1, 200);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1528, 1, 200);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 3795, 4086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 3491, 4101);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1528_3749_3776()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 3749, 3776);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1528_3986_4042(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 3986, 4042);
                        return return_v;
                    }


                    int
                    f_1528_3964_4043(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 3964, 4043);
                        return 0;
                    }


                    string[]
                    f_1528_3895_3914_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 3895, 3914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 3206, 4163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 3206, 4163);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 4117, 4152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4123, 4150);

                    return _variableExportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 4117, 4152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 3206, 4163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 3206, 4163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _variableExportList;

        private List<WildcardPattern> _variablePatterns;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Alias
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 4690, 5285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4726, 4751);

                    _aliasExportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4925, 4970);

                    _aliasPatterns = f_1528_4942_4969();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4988, 5270) || true) && (_aliasExportList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 4988, 5270);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5058, 5251);
                            foreach (string pattern in f_1528_5085_5101_I(_aliasExportList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 5058, 5251);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5151, 5228);

                                f_1528_5151_5227(_aliasPatterns, f_1528_5170_5226(pattern, WildcardOptions.IgnoreCase));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 5058, 5251);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1528, 1, 194);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1528, 1, 194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 4988, 5270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 4690, 5285);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1528_4942_4969()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 4942, 4969);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1528_5170_5226(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5170, 5226);
                        return return_v;
                    }


                    int
                    f_1528_5151_5227(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5151, 5227);
                        return 0;
                    }


                    string[]
                    f_1528_5085_5101_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5085, 5101);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 4408, 5344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 4408, 5344);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 5301, 5333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5307, 5331);

                    return _aliasExportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 5301, 5333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 4408, 5344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 4408, 5344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _aliasExportList;

        private List<WildcardPattern> _aliasPatterns;

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1528, 5551, 7067);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5615, 6118) || true) && (f_1528_5619_5645(f_1528_5619_5626()) == f_1528_5649_5677(f_1528_5649_5656()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 5615, 6118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5711, 5786);

                    string
                    message = f_1528_5728_5785(f_1528_5746_5784())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5804, 5881);

                    InvalidOperationException
                    invalidOp = f_1528_5842_5880(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5899, 6059);

                    ErrorRecord
                    er = f_1528_5916_6058(invalidOp, "Modules_CanOnlyExecuteExportModuleMemberInsideAModule", ErrorCategory.PermissionDenied, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6077, 6103);

                    f_1528_6077_6102(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 5615, 6118);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6385, 6853) || true) && (f_1528_6389_6436_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1528_6389_6422(f_1528_6389_6415(f_1528_6389_6396())), 1528, 6389, 6436)?.LanguageMode) != null && (DynAbs.Tracing.TraceSender.Expression_True(1528, 6389, 6535) && f_1528_6465_6485(f_1528_6465_6472()) != f_1528_6489_6535(f_1528_6489_6522(f_1528_6489_6515(f_1528_6489_6496())))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1528, 6385, 6853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6569, 6656);

                    var
                    se = f_1528_6578_6655(f_1528_6602_6654())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6674, 6794);

                    var
                    er = f_1528_6683_6793(se, "Modules_CannotExportMembersAccrossLanguageBoundaries", ErrorCategory.SecurityError, this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6812, 6838);

                    f_1528_6812_6837(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1528, 6385, 6853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 6869, 7056);

                f_1528_6869_7055(this, f_1528_6929_6960(f_1528_6929_6941(this)), _functionPatterns, _cmdletPatterns, _aliasPatterns, _variablePatterns, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1528, 5551, 7067);

                System.Management.Automation.ExecutionContext
                f_1528_5619_5626()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 5619, 5626);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1528_5619_5645(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 5619, 5645);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1528_5649_5656()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 5649, 5656);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1528_5649_5677(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TopLevelSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 5649, 5677);
                    return return_v;
                }


                string
                f_1528_5746_5784()
                {
                    var return_v = Modules.CanOnlyBeUsedFromWithinAModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 5746, 5784);
                    return return_v;
                }


                string
                f_1528_5728_5785(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5728, 5785);
                    return return_v;
                }


                System.InvalidOperationException
                f_1528_5842_5880(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5842, 5880);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1528_5916_6058(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 5916, 6058);
                    return return_v;
                }


                int
                f_1528_6077_6102(Microsoft.PowerShell.Commands.ExportModuleMemberCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 6077, 6102);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1528_6389_6396()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6389, 6396);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1528_6389_6415(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6389, 6415);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1528_6389_6422(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6389, 6422);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1528_6389_6436_M(System.Management.Automation.PSLanguageMode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6389, 6436);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1528_6465_6472()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6465, 6472);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1528_6465_6485(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6465, 6485);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1528_6489_6496()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6489, 6496);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1528_6489_6515(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6489, 6515);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1528_6489_6522(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6489, 6522);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1528_6489_6535(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6489, 6535);
                    return return_v;
                }


                string
                f_1528_6602_6654()
                {
                    var return_v = Modules.CannotExportMembersAccrossLanguageBoundaries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6602, 6654);
                    return return_v;
                }


                System.Management.Automation.PSSecurityException
                f_1528_6578_6655(string
                message)
                {
                    var return_v = new System.Management.Automation.PSSecurityException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 6578, 6655);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1528_6683_6793(System.Management.Automation.PSSecurityException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ExportModuleMemberCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 6683, 6793);
                    return return_v;
                }


                int
                f_1528_6812_6837(Microsoft.PowerShell.Commands.ExportModuleMemberCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 6812, 6837);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1528_6929_6941(Microsoft.PowerShell.Commands.ExportModuleMemberCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6929, 6941);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1528_6929_6960(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1528, 6929, 6960);
                    return return_v;
                }


                int
                f_1528_6869_7055(Microsoft.PowerShell.Commands.ExportModuleMemberCommand
                cmdlet, System.Management.Automation.SessionStateInternal
                sessionState, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                functionPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                cmdletPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                aliasPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                variablePatterns, System.Collections.Generic.List<string>
                doNotExportCmdlets)
                {
                    ModuleIntrinsics.ExportModuleMembers((System.Management.Automation.PSCmdlet)cmdlet, sessionState, functionPatterns, cmdletPatterns, aliasPatterns, variablePatterns, doNotExportCmdlets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1528, 6869, 7055);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1528, 5551, 7067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 5551, 7067);
            }
        }

        public ExportModuleMemberCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1528, 516, 7074);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1833, 1846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 1887, 1904);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 2998, 3009);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 3050, 3065);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4192, 4211);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 4252, 4269);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5373, 5389);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1528, 5430, 5444);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1528, 516, 7074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 516, 7074);
        }


        static ExportModuleMemberCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1528, 516, 7074);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1528, 516, 7074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1528, 516, 7074);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1528, 516, 7074);
    }
}
