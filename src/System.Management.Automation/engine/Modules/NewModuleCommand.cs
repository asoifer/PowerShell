// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.New, "Module", DefaultParameterSetName = "ScriptBlock", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096698")]
    [OutputType(typeof(PSModuleInfo))]
    public sealed class NewModuleCommand : ModuleCmdletBase
    {
        [Parameter(ParameterSetName = "Name", Mandatory = true, ValueFromPipeline = true, Position = 0)]
        public string Name
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 1024, 1046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1030, 1044);

                    _name = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 1024, 1046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 875, 1094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 875, 1094);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 1062, 1083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1068, 1081);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 1062, 1083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 875, 1094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 875, 1094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _name;

        [Parameter(ParameterSetName = "Name", Mandatory = true, Position = 1)]
        [Parameter(ParameterSetName = "ScriptBlock", Mandatory = true, Position = 0)]
        [ValidateNotNull]
        public ScriptBlock ScriptBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 1500, 1528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1506, 1526);

                    return _scriptBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 1500, 1528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 1251, 1627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 1251, 1627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 1544, 1616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1580, 1601);

                    _scriptBlock = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 1544, 1616);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 1251, 1627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 1251, 1627);
                }
            }
        }

        private ScriptBlock _scriptBlock;

        [Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Function
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 2079, 2658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2115, 2162) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 2115, 2162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2155, 2162);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 2115, 2162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2182, 2210);

                    _functionImportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2384, 2435);

                    BaseFunctionPatterns = f_1535_2407_2434();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2453, 2643);
                        foreach (string pattern in f_1535_2480_2499_I(_functionImportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 2453, 2643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2541, 2624);

                            f_1535_2541_2623(f_1535_2541_2561(), f_1535_2566_2622(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 2453, 2643);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1535, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1535, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 2079, 2658);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1535_2407_2434()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 2407, 2434);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1535_2541_2561()
                    {
                        var return_v = BaseFunctionPatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 2541, 2561);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1535_2566_2622(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 2566, 2622);
                        return return_v;
                    }


                    int
                    f_1535_2541_2623(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 2541, 2623);
                        return 0;
                    }


                    string[]
                    f_1535_2480_2499_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 2480, 2499);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 1834, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 1834, 2720);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 2674, 2709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2680, 2707);

                    return _functionImportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 2674, 2709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 1834, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 1834, 2720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _functionImportList;

        [Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Cmdlet
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 3196, 3767);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3232, 3279) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 3232, 3279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3272, 3279);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 3232, 3279);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3299, 3325);

                    _cmdletImportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3499, 3548);

                    BaseCmdletPatterns = f_1535_3520_3547();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3566, 3752);
                        foreach (string pattern in f_1535_3593_3610_I(_cmdletImportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 3566, 3752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3652, 3733);

                            f_1535_3652_3732(f_1535_3652_3670(), f_1535_3675_3731(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 3566, 3752);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1535, 1, 187);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1535, 1, 187);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 3196, 3767);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1535_3520_3547()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 3520, 3547);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1535_3652_3670()
                    {
                        var return_v = BaseCmdletPatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 3652, 3670);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1535_3675_3731(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 3675, 3731);
                        return return_v;
                    }


                    int
                    f_1535_3652_3732(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 3652, 3732);
                        return 0;
                    }


                    string[]
                    f_1535_3593_3610_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 3593, 3610);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 2953, 3827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 2953, 3827);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 3783, 3816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3789, 3814);

                    return _cmdletImportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 3783, 3816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 2953, 3827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 2953, 3827);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _cmdletImportList;

        [Parameter]
        public SwitchParameter ReturnResult
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 4117, 4163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4123, 4161);

                    return (SwitchParameter)_returnResult;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 4117, 4163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4036, 4220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4036, 4220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 4179, 4209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4185, 4207);

                    _returnResult = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 4179, 4209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4036, 4220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4036, 4220);
                }
            }
        }

        private bool _returnResult;

        [Parameter]
        public SwitchParameter AsCustomObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 4480, 4528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4486, 4526);

                    return (SwitchParameter)_asCustomObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 4480, 4528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4397, 4587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4397, 4587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 4544, 4576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4550, 4574);

                    _asCustomObject = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 4544, 4576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4397, 4587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4397, 4587);
                }
            }
        }

        private bool _asCustomObject;

        [Parameter(ValueFromRemainingArguments = true)]
        [Alias("Args")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public object[] ArgumentList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 5051, 5077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5057, 5075);

                    return _arguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 5051, 5077);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4768, 5131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4768, 5131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 5093, 5120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5099, 5118);

                    _arguments = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 5093, 5120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 4768, 5131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 4768, 5131);
                }
            }
        }

        private object[] _arguments;

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1535, 5268, 9135);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5386, 9124) || true) && (_scriptBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 5386, 9124);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5640, 6191) || true) && (f_1535_5644_5664(f_1535_5644_5651()) == PSLanguageMode.ConstrainedLanguage && (DynAbs.Tracing.TraceSender.Expression_True(1535, 5644, 5783) && f_1535_5727_5752(_scriptBlock) == PSLanguageMode.FullLanguage))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 5640, 6191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5825, 6172);

                        f_1535_5825_6171(this, f_1535_5878_6170(f_1535_5924_5990(f_1535_5948_5989()), "Modules_CannotCreateModuleWithFullLanguageScriptBlock", ErrorCategory.SecurityError, null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 5640, 6191);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6211, 6256);

                    string
                    gs = System.Guid.NewGuid().ToString()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6274, 6418) || true) && (f_1535_6278_6305(_name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 6274, 6418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6347, 6399);

                        _name = PSModuleInfo.DynamicModulePrefixString + gs;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 6274, 6418);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6482, 6539);

                        f_1535_6482_6538(f_1535_6482_6497(f_1535_6482_6489()), this, _name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6563, 6591);

                        List<object>
                        results = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6613, 6645);

                        PSModuleInfo
                        localModule = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 6810, 6909);

                            localModule = f_1535_6824_6908(f_1535_6824_6839(f_1535_6824_6831()), _name, gs, _scriptBlock, null, out results, _arguments);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7032, 7600) || true) && (f_1535_7036_7084_M(!f_1535_7037_7070(f_1535_7037_7061(localModule)).UseExportList))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 7032, 7600);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7142, 7212);

                                List<WildcardPattern>
                                cmdletPatterns = f_1535_7181_7199() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.WildcardPattern>>(1535, 7181, 7211) ?? f_1535_7203_7211())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7242, 7316);

                                List<WildcardPattern>
                                functionPatterns = f_1535_7283_7303() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.WildcardPattern>>(1535, 7283, 7315) ?? f_1535_7307_7315())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7348, 7573);

                                f_1535_7348_7572(this, f_1535_7424_7457(f_1535_7424_7448(localModule)), functionPatterns, cmdletPatterns, f_1535_7526_7543(), f_1535_7545_7565(), null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 7032, 7600);
                            }
                        }
                        catch (RuntimeException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1535, 7645, 7916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7793, 7841);

                            f_1535_7793_7806(e).PreserveInvocationInfoOnce = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 7867, 7893);

                            f_1535_7867_7892(this, f_1535_7878_7891(e));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1535, 7645, 7916);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8031, 8932) || true) && (localModule != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 8031, 8932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8104, 8909) || true) && (_returnResult)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 8104, 8909);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8243, 8329);

                                f_1535_8243_8328(this, localModule, string.Empty);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8359, 8386);

                                f_1535_8359_8385(this, results, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 8104, 8909);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 8104, 8909);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8444, 8909) || true) && (_asCustomObject)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 8444, 8909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8521, 8563);

                                    f_1535_8521_8562(this, f_1535_8533_8561(localModule));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 8444, 8909);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1535, 8444, 8909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8741, 8827);

                                    f_1535_8741_8826(this, localModule, string.Empty);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 8857, 8882);

                                    f_1535_8857_8881(this, localModule);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 8444, 8909);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 8104, 8909);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 8031, 8932);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1535, 8969, 9082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 9017, 9063);

                        f_1535_9017_9062(f_1535_9017_9032(f_1535_9017_9024()));
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1535, 8969, 9082);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 9102, 9109);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1535, 5386, 9124);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1535, 5268, 9135);

                System.Management.Automation.ExecutionContext
                f_1535_5644_5651()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 5644, 5651);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1535_5644_5664(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 5644, 5664);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode?
                f_1535_5727_5752(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 5727, 5752);
                    return return_v;
                }


                string
                f_1535_5948_5989()
                {
                    var return_v = Modules.CannotCreateModuleWithScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 5948, 5989);
                    return return_v;
                }


                System.Management.Automation.PSSecurityException
                f_1535_5924_5990(string
                message)
                {
                    var return_v = new System.Management.Automation.PSSecurityException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 5924, 5990);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1535_5878_6170(System.Management.Automation.PSSecurityException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 5878, 6170);
                    return return_v;
                }


                int
                f_1535_5825_6171(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 5825, 6171);
                    return 0;
                }


                bool
                f_1535_6278_6305(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 6278, 6305);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1535_6482_6489()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 6482, 6489);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1535_6482_6497(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 6482, 6497);
                    return return_v;
                }


                int
                f_1535_6482_6538(System.Management.Automation.ModuleIntrinsics
                this_param, Microsoft.PowerShell.Commands.NewModuleCommand
                cmdlet, string
                path)
                {
                    this_param.IncrementModuleNestingDepth((System.Management.Automation.PSCmdlet)cmdlet, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 6482, 6538);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1535_6824_6831()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 6824, 6831);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1535_6824_6839(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 6824, 6839);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1535_6824_6908(System.Management.Automation.ModuleIntrinsics
                this_param, string
                name, string
                path, System.Management.Automation.ScriptBlock
                scriptBlock, System.Management.Automation.SessionState
                ss, out System.Collections.Generic.List<object>
                results, params object[]
                arguments)
                {
                    var return_v = this_param.CreateModule(name, path, scriptBlock, ss, out results, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 6824, 6908);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1535_7037_7061(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7037, 7061);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1535_7037_7070(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7037, 7070);
                    return return_v;
                }


                bool
                f_1535_7036_7084_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7036, 7084);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7181_7199()
                {
                    var return_v = BaseCmdletPatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7181, 7199);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7203_7211()
                {
                    var return_v = MatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7203, 7211);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7283_7303()
                {
                    var return_v = BaseFunctionPatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7283, 7303);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7307_7315()
                {
                    var return_v = MatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7307, 7315);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1535_7424_7448(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7424, 7448);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1535_7424_7457(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7424, 7457);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7526_7543()
                {
                    var return_v = BaseAliasPatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7526, 7543);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                f_1535_7545_7565()
                {
                    var return_v = BaseVariablePatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7545, 7565);
                    return return_v;
                }


                int
                f_1535_7348_7572(Microsoft.PowerShell.Commands.NewModuleCommand
                cmdlet, System.Management.Automation.SessionStateInternal
                sessionState, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                functionPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                cmdletPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                aliasPatterns, System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                variablePatterns, System.Collections.Generic.List<string>
                doNotExportCmdlets)
                {
                    ModuleIntrinsics.ExportModuleMembers((System.Management.Automation.PSCmdlet)cmdlet, sessionState, functionPatterns, cmdletPatterns, aliasPatterns, variablePatterns, doNotExportCmdlets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 7348, 7572);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1535_7793_7806(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7793, 7806);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1535_7878_7891(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 7878, 7891);
                    return return_v;
                }


                int
                f_1535_7867_7892(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 7867, 7892);
                    return 0;
                }


                int
                f_1535_8243_8328(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sourceModule, string
                prefix)
                {
                    this_param.ImportModuleMembers(sourceModule, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8243, 8328);
                    return 0;
                }


                int
                f_1535_8359_8385(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Collections.Generic.List<object>
                sendToPipeline, bool
                enumerateCollection)
                {
                    this_param.WriteObject((object)sendToPipeline, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8359, 8385);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1535_8533_8561(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AsCustomObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8533, 8561);
                    return return_v;
                }


                int
                f_1535_8521_8562(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8521, 8562);
                    return 0;
                }


                int
                f_1535_8741_8826(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sourceModule, string
                prefix)
                {
                    this_param.ImportModuleMembers(sourceModule, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8741, 8826);
                    return 0;
                }


                int
                f_1535_8857_8881(Microsoft.PowerShell.Commands.NewModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 8857, 8881);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1535_9017_9024()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 9017, 9024);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1535_9017_9032(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1535, 9017, 9032);
                    return return_v;
                }


                int
                f_1535_9017_9062(System.Management.Automation.ModuleIntrinsics
                this_param)
                {
                    this_param.DecrementModuleNestingCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 9017, 9062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1535, 5268, 9135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 5268, 9135);
            }
        }

        public NewModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1535, 493, 9142);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1121, 1126);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 1659, 1671);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 2749, 2792);
            this._functionImportList = f_1535_2771_2792();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 3856, 3897);
            this._cmdletImportList = f_1535_3876_3897();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4245, 4258);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 4612, 4627);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1535, 5160, 5170);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1535, 493, 9142);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 493, 9142);
        }


        static NewModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1535, 493, 9142);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1535, 493, 9142);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1535, 493, 9142);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1535, 493, 9142);

        string[]
        f_1535_2771_2792()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 2771, 2792);
            return return_v;
        }


        string[]
        f_1535_3876_3897()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1535, 3876, 3897);
            return return_v;
        }

    }

}
