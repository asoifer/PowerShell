// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Security;
using System.Threading;

using Microsoft.Management.Infrastructure;
using Microsoft.PowerShell.Cmdletization;
using Microsoft.PowerShell.Telemetry;

using Dbg = System.Management.Automation.Diagnostics;
using Parser = System.Management.Automation.Language.Parser;
using ScriptBlock = System.Management.Automation.ScriptBlock;
using Token = System.Management.Automation.Language.Token;


//
// Now define the set of commands for manipulating modules.
//
namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsData.Import, "Module", DefaultParameterSetName = ParameterSet_Name, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096585")]
    [OutputType(typeof(PSModuleInfo))]
    public sealed class ImportModuleCommand : ModuleCmdletBase, IDisposable
    {
        private const string
        ParameterSet_Name = "Name"
        ;

        private const string
        ParameterSet_FQName = "FullyQualifiedName"
        ;

        private const string
        ParameterSet_ModuleInfo = "ModuleInfo"
        ;

        private const string
        ParameterSet_Assembly = "Assembly"
        ;

        private const string
        ParameterSet_ViaPsrpSession = "PSSession"
        ;

        private const string
        ParameterSet_ViaCimSession = "CimSession"
        ;

        private const string
        ParameterSet_FQName_ViaPsrpSession = "FullyQualifiedNameAndPSSession"
        ;

        private const string
        ParameterSet_ViaWinCompat = "WinCompat"
        ;

        private const string
        ParameterSet_FQName_ViaWinCompat = "FullyQualifiedNameAndWinCompat"
        ;

        [Parameter]
        public SwitchParameter Global
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 2536, 2568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2542, 2566);

                    base.BaseGlobal = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 2536, 2568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 2461, 2626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 2461, 2626);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 2584, 2615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2590, 2613);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.BaseGlobal, 1530, 2597, 2612);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 2584, 2615);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 2461, 2626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 2461, 2626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Parameter]
        [ValidateNotNull]
        public string Prefix
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 2868, 2895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2874, 2893);

                    BasePrefix = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 2868, 2895);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 2775, 2948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 2775, 2948);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 2911, 2937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2917, 2935);

                    return f_1530_2924_2934();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 2911, 2937);

                    string
                    f_1530_2924_2934()
                    {
                        var return_v = BasePrefix;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 2924, 2934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 2775, 2948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 2775, 2948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Parameter(ParameterSetName = ParameterSet_Name, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_ViaCimSession, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_ViaWinCompat, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [ValidateTrustedData]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Name { set; get; }

        [Parameter(ParameterSetName = ParameterSet_FQName, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_FQName_ViaPsrpSession, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_FQName_ViaWinCompat, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [ValidateTrustedData]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public ModuleSpecification[] FullyQualifiedName { get; set; }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        [Parameter(ParameterSetName = ParameterSet_Assembly, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [ValidateTrustedData]
        public Assembly[] Assembly { get; set; }

        [Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Function
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 5399, 5976);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5435, 5482) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 5435, 5482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5475, 5482);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 5435, 5482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5500, 5528);

                    _functionImportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5702, 5753);

                    BaseFunctionPatterns = f_1530_5725_5752();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5771, 5961);
                        foreach (string pattern in f_1530_5798_5817_I(_functionImportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 5771, 5961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5859, 5942);

                            f_1530_5859_5941(f_1530_5859_5879(), f_1530_5884_5940(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 5771, 5961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 5399, 5976);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_5725_5752()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 5725, 5752);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_5859_5879()
                    {
                        var return_v = BaseFunctionPatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 5859, 5879);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1530_5884_5940(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 5884, 5940);
                        return return_v;
                    }


                    int
                    f_1530_5859_5941(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 5859, 5941);
                        return 0;
                    }


                    string[]
                    f_1530_5798_5817_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 5798, 5817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 5154, 6038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 5154, 6038);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 5992, 6027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 5998, 6025);

                    return _functionImportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 5992, 6027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 5154, 6038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 5154, 6038);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 6499, 7070);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6535, 6582) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 6535, 6582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6575, 6582);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 6535, 6582);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6602, 6628);

                    _cmdletImportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6802, 6851);

                    BaseCmdletPatterns = f_1530_6823_6850();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6869, 7055);
                        foreach (string pattern in f_1530_6896_6913_I(_cmdletImportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 6869, 7055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6955, 7036);

                            f_1530_6955_7035(f_1530_6955_6973(), f_1530_6978_7034(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 6869, 7055);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 187);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 187);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 6499, 7070);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_6823_6850()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 6823, 6850);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_6955_6973()
                    {
                        var return_v = BaseCmdletPatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 6955, 6973);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1530_6978_7034(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 6978, 7034);
                        return return_v;
                    }


                    int
                    f_1530_6955_7035(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 6955, 7035);
                        return 0;
                    }


                    string[]
                    f_1530_6896_6913_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 6896, 6913);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 6256, 7130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 6256, 7130);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 7086, 7119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7092, 7117);

                    return _cmdletImportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 7086, 7119);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 6256, 7130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 6256, 7130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _cmdletImportList;

        [Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Variable
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 7586, 8163);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7622, 7669) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 7622, 7669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7662, 7669);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 7622, 7669);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7687, 7715);

                    _variableExportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7889, 7940);

                    BaseVariablePatterns = f_1530_7912_7939();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7958, 8148);
                        foreach (string pattern in f_1530_7985_8004_I(_variableExportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 7958, 8148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8046, 8129);

                            f_1530_8046_8128(f_1530_8046_8066(), f_1530_8071_8127(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 7958, 8148);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 7586, 8163);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_7912_7939()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 7912, 7939);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_8046_8066()
                    {
                        var return_v = BaseVariablePatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 8046, 8066);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1530_8071_8127(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 8071, 8127);
                        return return_v;
                    }


                    int
                    f_1530_8046_8128(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 8046, 8128);
                        return 0;
                    }


                    string[]
                    f_1530_7985_8004_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 7985, 8004);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 7341, 8225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 7341, 8225);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 8179, 8214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8185, 8212);

                    return _variableExportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 8179, 8214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 7341, 8225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 7341, 8225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _variableExportList;

        [Parameter]
        [ValidateNotNull]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public string[] Alias
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 8654, 9221);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8690, 8737) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 8690, 8737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8730, 8737);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 8690, 8737);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8757, 8782);

                    _aliasExportList = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8956, 9004);

                    BaseAliasPatterns = f_1530_8976_9003();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9022, 9206);
                        foreach (string pattern in f_1530_9049_9065_I(_aliasExportList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 9022, 9206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9107, 9187);

                            f_1530_9107_9186(f_1530_9107_9124(), f_1530_9129_9185(pattern, WildcardOptions.IgnoreCase));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 9022, 9206);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 185);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 185);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 8654, 9221);

                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_8976_9003()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.WildcardPattern>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 8976, 9003);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    f_1530_9107_9124()
                    {
                        var return_v = BaseAliasPatterns;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 9107, 9124);
                        return return_v;
                    }


                    System.Management.Automation.WildcardPattern
                    f_1530_9129_9185(string
                    pattern, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = WildcardPattern.Get(pattern, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 9129, 9185);
                        return return_v;
                    }


                    int
                    f_1530_9107_9186(System.Collections.Generic.List<System.Management.Automation.WildcardPattern>
                    this_param, System.Management.Automation.WildcardPattern
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 9107, 9186);
                        return 0;
                    }


                    string[]
                    f_1530_9049_9065_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 9049, 9065);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 8412, 9280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 8412, 9280);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 9237, 9269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9243, 9267);

                    return _aliasExportList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 9237, 9269);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 8412, 9280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 8412, 9280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string[] _aliasExportList;

        [Parameter]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 9547, 9589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9553, 9587);

                    return (SwitchParameter)f_1530_9577_9586();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 9547, 9589);

                    bool
                    f_1530_9577_9586()
                    {
                        var return_v = BaseForce;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 9577, 9586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 9473, 9642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 9473, 9642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 9605, 9631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9611, 9629);

                    BaseForce = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 9605, 9631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 9473, 9642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 9473, 9642);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_Name)]
        [Parameter(ParameterSetName = ParameterSet_FQName)]
        [Parameter(ParameterSetName = ParameterSet_ModuleInfo)]
        [Parameter(ParameterSetName = ParameterSet_Assembly)]
        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaCimSession)]
        [Parameter(ParameterSetName = ParameterSet_FQName_ViaPsrpSession)]
        public SwitchParameter SkipEditionCheck
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 10406, 10459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 10412, 10457);

                    return (SwitchParameter)f_1530_10436_10456();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 10406, 10459);

                    bool
                    f_1530_10436_10456()
                    {
                        var return_v = BaseSkipEditionCheck;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 10436, 10456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 9881, 10523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 9881, 10523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 10475, 10512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 10481, 10510);

                    BaseSkipEditionCheck = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 10475, 10512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 9881, 10523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 9881, 10523);
                }
            }
        }

        [Parameter]
        public SwitchParameter PassThru
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 10738, 10783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 10744, 10781);

                    return (SwitchParameter)f_1530_10768_10780();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 10738, 10783);

                    bool
                    f_1530_10768_10780()
                    {
                        var return_v = BasePassThru;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 10768, 10780);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 10661, 10839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 10661, 10839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 10799, 10828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 10805, 10826);

                    BasePassThru = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 10799, 10828);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 10661, 10839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 10661, 10839);
                }
            }
        }

        [Parameter]
        public SwitchParameter AsCustomObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 11079, 11130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 11085, 11128);

                    return (SwitchParameter)f_1530_11109_11127();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 11079, 11130);

                    bool
                    f_1530_11109_11127()
                    {
                        var return_v = BaseAsCustomObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 11109, 11127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 10996, 11192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 10996, 11192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 11146, 11181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 11152, 11179);

                    BaseAsCustomObject = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 11146, 11181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 10996, 11192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 10996, 11192);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_Name)]
        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaCimSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaWinCompat)]
        [Alias("Version")]
        public Version MinimumVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 11652, 11686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 11658, 11684);

                    return f_1530_11665_11683();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 11652, 11686);

                    System.Version
                    f_1530_11665_11683()
                    {
                        var return_v = BaseMinimumVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 11665, 11683);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 11307, 11748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 11307, 11748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 11702, 11737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 11708, 11735);

                    BaseMinimumVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 11702, 11737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 11307, 11748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 11307, 11748);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_Name)]
        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaCimSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaWinCompat)]
        public string MaximumVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 12179, 12376);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12215, 12361) || true) && (f_1530_12219_12237() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 12215, 12361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12268, 12280);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 12215, 12361);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 12215, 12361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12324, 12361);

                        return f_1530_12331_12360(f_1530_12331_12349());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 12215, 12361);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 12179, 12376);

                    System.Version
                    f_1530_12219_12237()
                    {
                        var return_v = BaseMaximumVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 12219, 12237);
                        return return_v;
                    }


                    System.Version
                    f_1530_12331_12349()
                    {
                        var return_v = BaseMaximumVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 12331, 12349);
                        return return_v;
                    }


                    string
                    f_1530_12331_12360(System.Version
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 12331, 12360);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 11863, 12705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 11863, 12705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 12392, 12694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12428, 12679) || true) && (f_1530_12432_12464(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 12428, 12679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12506, 12532);

                        BaseMaximumVersion = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 12428, 12679);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 12428, 12679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 12614, 12660);

                        BaseMaximumVersion = f_1530_12635_12659(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 12428, 12679);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 12392, 12694);

                    bool
                    f_1530_12432_12464(string
                    value)
                    {
                        var return_v = string.IsNullOrWhiteSpace(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 12432, 12464);
                        return return_v;
                    }


                    System.Version
                    f_1530_12635_12659(string
                    stringVersion)
                    {
                        var return_v = GetMaximumVersion(stringVersion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 12635, 12659);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 11863, 12705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 11863, 12705);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_Name)]
        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaCimSession)]
        [Parameter(ParameterSetName = ParameterSet_ViaWinCompat)]
        public Version RequiredVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 13130, 13165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 13136, 13163);

                    return f_1530_13143_13162();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 13130, 13165);

                    System.Version
                    f_1530_13143_13162()
                    {
                        var return_v = BaseRequiredVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 13143, 13162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 12812, 13228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 12812, 13228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 13181, 13217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 13187, 13215);

                    BaseRequiredVersion = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 13181, 13217);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 12812, 13228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 12812, 13228);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_ModuleInfo, Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [ValidateTrustedData]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public PSModuleInfo[] ModuleInfo { set; get; }

        [Parameter]
        [Alias("Args")]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Cmdlets use arrays for parameters.")]
        public object[] ArgumentList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 14096, 14128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 14102, 14126);

                    return f_1530_14109_14125();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 14096, 14128);

                    object[]
                    f_1530_14109_14125()
                    {
                        var return_v = BaseArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 14109, 14125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 13849, 14188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 13849, 14188);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 14144, 14177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 14150, 14175);

                    BaseArgumentList = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 14144, 14177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 13849, 14188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 13849, 14188);
                }
            }
        }

        [Parameter]
        public SwitchParameter DisableNameChecking
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 14476, 14515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 14482, 14513);

                    return f_1530_14489_14512();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 14476, 14515);

                    bool
                    f_1530_14489_14512()
                    {
                        var return_v = BaseDisableNameChecking;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 14489, 14512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 14388, 14582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 14388, 14582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 14531, 14571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 14537, 14569);

                    BaseDisableNameChecking = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 14531, 14571);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 14388, 14582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 14388, 14582);
                }
            }
        }

        [Parameter, Alias("NoOverwrite")]
        public SwitchParameter NoClobber { get; set; }

        [Parameter]
        [ValidateSet("Local", "Global")]
        public string Scope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 15053, 15075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15059, 15073);

                    return _scope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 15053, 15075);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 14946, 15211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 14946, 15211);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 15091, 15200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15127, 15142);

                    _scope = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15160, 15185);

                    _isScopeSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 15091, 15200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 14946, 15211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 14946, 15211);
                }
            }
        }

        private string _scope;

        private bool _isScopeSpecified;

        [Parameter(ParameterSetName = ParameterSet_ViaPsrpSession, Mandatory = true)]
        [Parameter(ParameterSetName = ParameterSet_FQName_ViaPsrpSession, Mandatory = true)]
        [ValidateNotNull]
        public PSSession PSSession { get; set; }

        public ImportModuleCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1530, 15823, 15924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 3061, 3794);
                this.Name = f_1530_3772_3793();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 3920, 4545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 4667, 5007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 6067, 6110);
                this._functionImportList = f_1530_6089_6110();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 7159, 7200);
                this._cmdletImportList = f_1530_7179_7200();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 8254, 8273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 9309, 9325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 13354, 13733);
                this.ModuleInfo = f_1530_13705_13732();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15238, 15259);
                this._scope = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15283, 15308);
                this._isScopeSpecified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15508, 15756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 16119, 16274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 16433, 16586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 16742, 16903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77717, 77773);
                this._cancellationTokenSource = f_1530_77744_77773();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79120, 79129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 15876, 15913);

                base.BaseDisableNameChecking = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1530, 15823, 15924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 15823, 15924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 15823, 15924);
            }
        }

        [Parameter(ParameterSetName = ParameterSet_ViaCimSession, Mandatory = true)]
        [ValidateNotNull]
        public CimSession CimSession { get; set; }

        [Parameter(ParameterSetName = ParameterSet_ViaCimSession, Mandatory = false)]
        [ValidateNotNull]
        public Uri CimResourceUri { get; set; }

        [Parameter(ParameterSetName = ParameterSet_ViaCimSession, Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string CimNamespace { get; set; }

        [Parameter(ParameterSetName = ParameterSet_ViaWinCompat, Mandatory = true)]
        [Parameter(ParameterSetName = ParameterSet_FQName_ViaWinCompat, Mandatory = true)]
        [Alias("UseWinPS")]
        public SwitchParameter UseWindowsPowerShell { get; set; }

        private void ImportModule_ViaLocalModuleInfo(ImportModuleOptions importModuleOptions, PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 17464, 22375);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 17631, 17671);

                    PSModuleInfo
                    alreadyLoadedModule = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 17689, 17749);

                    f_1530_17689_17748(this, f_1530_17711_17722(module), out alreadyLoadedModule);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 17767, 22166) || true) && (f_1530_17771_17781_M(!BaseForce) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 17771, 17847) && f_1530_17785_17847(this, alreadyLoadedModule)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 17767, 22166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 17889, 17982);

                        f_1530_17889_17981(f_1530_17913_17925(this), f_1530_17927_17959(f_1530_17927_17950(this)), alreadyLoadedModule);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18098, 18177);

                        f_1530_18098_18176(this, alreadyLoadedModule, f_1530_18139_18154(this), importModuleOptions);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18201, 19232) || true) && (f_1530_18205_18223())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 18201, 19232);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18273, 19060) || true) && (f_1530_18277_18307(alreadyLoadedModule) != ModuleType.Script)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 18273, 19060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18386, 18494);

                                string
                                message = f_1530_18403_18493(f_1530_18421_18466(), f_1530_18468_18492(alreadyLoadedModule))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18524, 18601);

                                InvalidOperationException
                                invalidOp = f_1530_18562_18600(message)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18631, 18824);

                                ErrorRecord
                                er = f_1530_18648_18823(invalidOp, "Modules_CantUseAsCustomObjectWithBinaryModule", ErrorCategory.PermissionDenied, null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18854, 18869);

                                f_1530_18854_18868(this, er);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 18273, 19060);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 18273, 19060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 18983, 19033);

                                f_1530_18983_19032(this, f_1530_18995_19031(alreadyLoadedModule));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 18273, 19060);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 18201, 19232);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 18201, 19232);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19110, 19232) || true) && (f_1530_19114_19126())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 19110, 19232);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19176, 19209);

                                f_1530_19176_19208(this, alreadyLoadedModule);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 19110, 19232);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 18201, 19232);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 17767, 22166);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 17767, 22166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19314, 19342);

                        PSModuleInfo
                        moduleToRemove
                        = default(PSModuleInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19364, 19648) || true) && (f_1530_19368_19438(this, f_1530_19390_19401(module), out moduleToRemove, toRemove: true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 19364, 19648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19488, 19570);

                            f_1530_19488_19569(f_1530_19499_19508(), "We should only remove and reload if -Force was specified");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19596, 19625);

                            f_1530_19596_19624(this, moduleToRemove);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 19364, 19648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 19672, 19710);

                        PSModuleInfo
                        moduleToProcess = module
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20097, 22037) || true) && (f_1530_20101_20120(module) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 20097, 22037);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20186, 20900) || true) && (f_1530_20190_20214(f_1530_20202_20213(module)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 20186, 20900);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20280, 20291);

                                    bool
                                    found
                                    = default(bool);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20325, 20754);

                                    moduleToProcess = f_1530_20343_20753(this, f_1530_20354_20365(module), null, f_1530_20373_20388(this), null, ref importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out found);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20788, 20869);

                                    f_1530_20788_20868(found, "Module should be found when referenced by its absolute path");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 20186, 20900);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 20097, 22037);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 20097, 22037);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 20958, 22037) || true) && (!f_1530_20963_20996(f_1530_20984_20995(module)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 20958, 22037);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21272, 21361);

                                    f_1530_21272_21360(f_1530_21296_21308(this), f_1530_21310_21342(f_1530_21310_21333(this)), moduleToProcess);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21393, 21605) || true) && (f_1530_21397_21425(moduleToProcess) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 21393, 21605);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21499, 21574);

                                        f_1530_21499_21573(this, moduleToProcess, f_1530_21536_21551(this), importModuleOptions);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 21393, 21605);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21637, 22010) || true) && (f_1530_21641_21659() && (DynAbs.Tracing.TraceSender.Expression_True(1530, 21641, 21699) && f_1530_21663_21691(moduleToProcess) != null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 21637, 22010);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21765, 21802);

                                        f_1530_21765_21801(this, f_1530_21777_21800(module));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 21637, 22010);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 21637, 22010);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21868, 22010) || true) && (f_1530_21872_21884())
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 21868, 22010);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 21950, 21979);

                                            f_1530_21950_21978(this, moduleToProcess);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 21868, 22010);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 21637, 22010);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 20958, 22037);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 20097, 22037);
                            }
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 22082, 22147);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 22082, 22147);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 17767, 22166);
                    }
                }
                catch (PSInvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 22195, 22364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22265, 22316);

                    ErrorRecord
                    er = f_1530_22282_22315(f_1530_22298_22311(e), e)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22334, 22349);

                    f_1530_22334_22348(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 22195, 22364);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 17464, 22375);

                string
                f_1530_17711_17722(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 17711, 17722);
                    return return_v;
                }


                bool
                f_1530_17689_17748(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                moduleInfo)
                {
                    var return_v = this_param.TryGetFromModuleTable(key, out moduleInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 17689, 17748);
                    return return_v;
                }


                bool
                f_1530_17771_17781_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 17771, 17781);
                    return return_v;
                }


                bool
                f_1530_17785_17847(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                alreadyLoadedModule)
                {
                    var return_v = this_param.DoesAlreadyLoadedModuleSatisfyConstraints(alreadyLoadedModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 17785, 17847);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_17913_17925(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 17913, 17925);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_17927_17950(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.TargetSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 17927, 17950);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_17927_17959(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 17927, 17959);
                    return return_v;
                }


                int
                f_1530_17889_17981(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                targetSessionState, System.Management.Automation.PSModuleInfo
                module)
                {
                    AddModuleToModuleTables(context, targetSessionState, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 17889, 17981);
                    return 0;
                }


                string
                f_1530_18139_18154(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 18139, 18154);
                    return return_v;
                }


                int
                f_1530_18098_18176(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sourceModule, string
                prefix, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options)
                {
                    this_param.ImportModuleMembers(sourceModule, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18098, 18176);
                    return 0;
                }


                bool
                f_1530_18205_18223()
                {
                    var return_v = BaseAsCustomObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 18205, 18223);
                    return return_v;
                }


                System.Management.Automation.ModuleType
                f_1530_18277_18307(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 18277, 18307);
                    return return_v;
                }


                string
                f_1530_18421_18466()
                {
                    var return_v = Modules.CantUseAsCustomObjectWithBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 18421, 18466);
                    return return_v;
                }


                string
                f_1530_18468_18492(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 18468, 18492);
                    return return_v;
                }


                string
                f_1530_18403_18493(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18403, 18493);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_18562_18600(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18562, 18600);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_18648_18823(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18648, 18823);
                    return return_v;
                }


                int
                f_1530_18854_18868(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18854, 18868);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1530_18995_19031(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AsCustomObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18995, 19031);
                    return return_v;
                }


                int
                f_1530_18983_19032(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 18983, 19032);
                    return 0;
                }


                bool
                f_1530_19114_19126()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 19114, 19126);
                    return return_v;
                }


                int
                f_1530_19176_19208(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 19176, 19208);
                    return 0;
                }


                string
                f_1530_19390_19401(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 19390, 19401);
                    return return_v;
                }


                bool
                f_1530_19368_19438(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                moduleInfo, bool
                toRemove)
                {
                    var return_v = this_param.TryGetFromModuleTable(key, out moduleInfo, toRemove: toRemove);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 19368, 19438);
                    return return_v;
                }


                bool
                f_1530_19499_19508()
                {
                    var return_v = BaseForce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 19499, 19508);
                    return return_v;
                }


                int
                f_1530_19488_19569(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 19488, 19569);
                    return 0;
                }


                int
                f_1530_19596_19624(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module)
                {
                    this_param.RemoveModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 19596, 19624);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1530_20101_20120(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 20101, 20120);
                    return return_v;
                }


                string
                f_1530_20202_20213(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 20202, 20213);
                    return return_v;
                }


                bool
                f_1530_20190_20214(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 20190, 20214);
                    return return_v;
                }


                string
                f_1530_20354_20365(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 20354, 20365);
                    return return_v;
                }


                string
                f_1530_20373_20388(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 20373, 20388);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_20343_20753(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                fileName, string
                moduleBase, string
                prefix, System.Management.Automation.SessionState
                ss, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out bool
                found)
                {
                    var return_v = this_param.LoadModule(fileName, moduleBase, prefix, ss, ref options, manifestProcessingFlags, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 20343, 20753);
                    return return_v;
                }


                int
                f_1530_20788_20868(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 20788, 20868);
                    return 0;
                }


                string
                f_1530_20984_20995(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 20984, 20995);
                    return return_v;
                }


                bool
                f_1530_20963_20996(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 20963, 20996);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_21296_21308(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21296, 21308);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_21310_21333(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.TargetSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21310, 21333);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_21310_21342(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21310, 21342);
                    return return_v;
                }


                int
                f_1530_21272_21360(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                targetSessionState, System.Management.Automation.PSModuleInfo
                module)
                {
                    AddModuleToModuleTables(context, targetSessionState, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 21272, 21360);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1530_21397_21425(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21397, 21425);
                    return return_v;
                }


                string
                f_1530_21536_21551(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21536, 21551);
                    return return_v;
                }


                int
                f_1530_21499_21573(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sourceModule, string
                prefix, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options)
                {
                    this_param.ImportModuleMembers(sourceModule, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 21499, 21573);
                    return 0;
                }


                bool
                f_1530_21641_21659()
                {
                    var return_v = BaseAsCustomObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21641, 21659);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_21663_21691(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21663, 21691);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1530_21777_21800(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AsCustomObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 21777, 21800);
                    return return_v;
                }


                int
                f_1530_21765_21801(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 21765, 21801);
                    return 0;
                }


                bool
                f_1530_21872_21884()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 21872, 21884);
                    return return_v;
                }


                int
                f_1530_21950_21978(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 21950, 21978);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1530_22298_22311(System.Management.Automation.PSInvalidOperationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22298, 22311);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_22282_22315(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.PSInvalidOperationException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 22282, 22315);
                    return return_v;
                }


                int
                f_1530_22334_22348(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 22334, 22348);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 17464, 22375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 17464, 22375);
            }
        }

        private void ImportModule_ViaAssembly(ImportModuleOptions importModuleOptions, Assembly suppliedAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 22387, 24974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22517, 22543);

                bool
                moduleLoaded = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22650, 24109) || true) && (suppliedAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 22654, 22717) && f_1530_22682_22709(f_1530_22682_22697(f_1530_22682_22689())) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 22650, 24109);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22751, 24094);
                        foreach (KeyValuePair<string, PSModuleInfo> pair in f_1530_22803_22830_I(f_1530_22803_22830(f_1530_22803_22818(f_1530_22803_22810()))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 22751, 24094);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 22992, 23054);

                            string
                            moduleName = "dynamic_code_module_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (suppliedAssembly).ToString(), 1530, 23037, 23053)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23076, 23684) || true) && (f_1530_23080_23095(pair.Value) == string.Empty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23076, 23684);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23161, 23661) || true) && (f_1530_23165_23228(pair.Key, moduleName, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23161, 23661);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23286, 23306);

                                    moduleLoaded = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23336, 23473) || true) && (f_1530_23340_23352())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23336, 23473);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23418, 23442);

                                        f_1530_23418_23441(this, pair.Value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23336, 23473);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1530, 23505, 23511);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23161, 23661);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23161, 23661);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23625, 23634);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23161, 23661);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23076, 23684);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23708, 24075) || true) && (f_1530_23712_23797(f_1530_23712_23727(pair.Value), f_1530_23735_23760(suppliedAssembly), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23708, 24075);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23847, 23867);

                                moduleLoaded = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23893, 24018) || true) && (f_1530_23897_23909())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 23893, 24018);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 23967, 23991);

                                    f_1530_23967_23990(this, pair.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23893, 24018);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(1530, 24046, 24052);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 23708, 24075);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 22751, 24094);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 1344);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 1344);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 22650, 24109);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24125, 24963) || true) && (!moduleLoaded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 24125, 24963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24176, 24187);

                    bool
                    found
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24205, 24573);

                    PSModuleInfo
                    module = f_1530_24227_24572(this, false, null, null, suppliedAssembly, null, null, importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, f_1530_24496_24511(this), false, false, out found)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24593, 24948) || true) && (found && (DynAbs.Tracing.TraceSender.Expression_True(1530, 24597, 24620) && module != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 24593, 24948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24718, 24798);

                        f_1530_24718_24797(f_1530_24742_24754(this), f_1530_24756_24788(f_1530_24756_24779(this)), module);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24820, 24929) || true) && (f_1530_24824_24836())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 24820, 24929);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 24886, 24906);

                            f_1530_24886_24905(this, module);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 24820, 24929);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 24593, 24948);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 24125, 24963);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 22387, 24974);

                System.Management.Automation.ExecutionContext
                f_1530_22682_22689()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22682, 22689);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1530_22682_22697(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22682, 22697);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1530_22682_22709(System.Management.Automation.ModuleIntrinsics
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22682, 22709);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_22803_22810()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22803, 22810);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1530_22803_22818(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22803, 22818);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1530_22803_22830(System.Management.Automation.ModuleIntrinsics
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 22803, 22830);
                    return return_v;
                }


                string
                f_1530_23080_23095(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 23080, 23095);
                    return return_v;
                }


                bool
                f_1530_23165_23228(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 23165, 23228);
                    return return_v;
                }


                bool
                f_1530_23340_23352()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 23340, 23352);
                    return return_v;
                }


                int
                f_1530_23418_23441(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 23418, 23441);
                    return 0;
                }


                string
                f_1530_23712_23727(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 23712, 23727);
                    return return_v;
                }


                string
                f_1530_23735_23760(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 23735, 23760);
                    return return_v;
                }


                bool
                f_1530_23712_23797(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 23712, 23797);
                    return return_v;
                }


                bool
                f_1530_23897_23909()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 23897, 23909);
                    return return_v;
                }


                int
                f_1530_23967_23990(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 23967, 23990);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1530_22803_22830_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 22803, 22830);
                    return return_v;
                }


                string
                f_1530_24496_24511(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 24496, 24511);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_24227_24572(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, bool
                trySnapInName, string
                moduleName, string
                fileName, System.Reflection.Assembly
                assemblyToLoad, string
                moduleBase, System.Management.Automation.SessionState
                ss, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, string
                prefix, bool
                loadTypes, bool
                loadFormats, out bool
                found)
                {
                    var return_v = this_param.LoadBinaryModule(trySnapInName, moduleName, fileName, assemblyToLoad, moduleBase, ss, options, manifestProcessingFlags, prefix, loadTypes, loadFormats, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 24227, 24572);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_24742_24754(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 24742, 24754);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_24756_24779(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.TargetSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 24756, 24779);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_24756_24788(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 24756, 24788);
                    return return_v;
                }


                int
                f_1530_24718_24797(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                targetSessionState, System.Management.Automation.PSModuleInfo
                module)
                {
                    AddModuleToModuleTables(context, targetSessionState, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 24718, 24797);
                    return 0;
                }


                bool
                f_1530_24824_24836()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 24824, 24836);
                    return return_v;
                }


                int
                f_1530_24886_24905(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 24886, 24905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 22387, 24974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 22387, 24974);
            }
        }

        private PSModuleInfo ImportModule_LocallyViaName_WithTelemetry(ImportModuleOptions importModuleOptions, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 24986, 25903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25127, 25209);

                PSModuleInfo
                foundModule = f_1530_25154_25208(this, importModuleOptions, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25223, 25857) || true) && (foundModule != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 25223, 25857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25280, 25342);

                    f_1530_25280_25341(this, f_1530_25310_25326(foundModule), f_1530_25328_25340(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25546, 25842) || true) && (f_1530_25550_25594_M(!foundModule.IsWindowsPowerShellCompatModule))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 25546, 25842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25636, 25729);

                        f_1530_25636_25728(TelemetryType.ModuleLoad, f_1530_25711_25727(foundModule));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 25546, 25842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 25223, 25857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 25873, 25892);

                return foundModule;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 24986, 25903);

                System.Management.Automation.PSModuleInfo
                f_1530_25154_25208(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                name)
                {
                    var return_v = this_param.ImportModule_LocallyViaName(importModuleOptions, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 25154, 25208);
                    return return_v;
                }


                string
                f_1530_25310_25326(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 25310, 25326);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_25328_25340(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 25328, 25340);
                    return return_v;
                }


                int
                f_1530_25280_25341(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleName, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetModuleBaseForEngineModules(moduleName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 25280, 25341);
                    return 0;
                }


                bool
                f_1530_25550_25594_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 25550, 25594);
                    return return_v;
                }


                string
                f_1530_25711_25727(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 25711, 25727);
                    return return_v;
                }


                int
                f_1530_25636_25728(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 25636, 25728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 24986, 25903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 24986, 25903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo ImportModule_LocallyViaName(ImportModuleOptions importModuleOptions, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 25915, 38588);
                System.Management.Automation.PSModuleInfo module = default(System.Management.Automation.PSModuleInfo);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26078, 26097);

                    bool
                    found = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26115, 26147);

                    PSModuleInfo
                    foundModule = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26167, 26192);

                    string
                    cachedPath = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26210, 26235);

                    string
                    rootedPath = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26415, 26796) || true) && (f_1530_26419_26438(this) == null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 26419, 26477) && f_1530_26450_26469(this) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 26419, 26509) && f_1530_26481_26501(this) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 26419, 26554) && f_1530_26513_26554()) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 26419, 26573) && f_1530_26558_26573_M(!this.BaseForce)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 26415, 26796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26707, 26777);

                        cachedPath = f_1530_26720_26776(name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 26415, 26796);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26816, 27185) || true) && (!f_1530_26821_26853(cachedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 26816, 27185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26895, 27166) || true) && (f_1530_26899_26922(cachedPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 26895, 27166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 26972, 26996);

                            rootedPath = cachedPath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 26895, 27166);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 26895, 27166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 27094, 27143);

                            f_1530_27094_27142(name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 26895, 27166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 26816, 27185);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 27205, 27428) || true) && (rootedPath == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 27205, 27428);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 27354, 27409);

                        rootedPath = f_1530_27367_27408(name, f_1530_27395_27407(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 27205, 27428);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 27448, 27475);

                    bool
                    alreadyLoaded = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 27493, 36345) || true) && (!f_1530_27498_27530(rootedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 27493, 36345);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28141, 30048) || true) && (f_1530_28145_28155_M(!BaseForce) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 28145, 28217) && f_1530_28159_28217(this, rootedPath, out module)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28141, 30048);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28267, 30025) || true) && (f_1530_28271_28288(module) != ModuleType.Manifest
                            || (DynAbs.Tracing.TraceSender.Expression_False(1530, 28271, 28462) || f_1530_28344_28462(f_1530_28390_28404(module), f_1530_28406_28421(), f_1530_28423_28441(), f_1530_28443_28461())))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28267, 30025);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28520, 28541);

                                alreadyLoaded = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28571, 28651);

                                f_1530_28571_28650(f_1530_28595_28607(this), f_1530_28609_28641(f_1530_28609_28632(this)), module);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28681, 28747);

                                f_1530_28681_28746(this, module, f_1530_28709_28724(this), importModuleOptions);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28779, 29902) || true) && (f_1530_28783_28801())
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28779, 29902);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28867, 29703) || true) && (f_1530_28871_28888(module) != ModuleType.Script)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28867, 29703);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 28983, 29078);

                                        string
                                        message = f_1530_29000_29077(f_1530_29018_29063(), f_1530_29065_29076(module))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29116, 29193);

                                        InvalidOperationException
                                        invalidOp = f_1530_29154_29192(message)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29231, 29432);

                                        ErrorRecord
                                        er = f_1530_29248_29431(invalidOp, "Modules_CantUseAsCustomObjectWithBinaryModule", ErrorCategory.PermissionDenied, null)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29470, 29485);

                                        f_1530_29470_29484(this, er);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28867, 29703);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28867, 29703);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29631, 29668);

                                        f_1530_29631_29667(this, f_1530_29643_29666(module));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28867, 29703);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28779, 29902);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 28779, 29902);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29769, 29902) || true) && (f_1530_29773_29785())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 29769, 29902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29851, 29871);

                                        f_1530_29851_29870(this, module);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 29769, 29902);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28779, 29902);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29934, 29947);

                                found = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 29977, 29998);

                                foundModule = module;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28267, 30025);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 28141, 30048);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30072, 32932) || true) && (!alreadyLoaded)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 30072, 32932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30212, 32909) || true) && (f_1530_30216_30239(rootedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 30212, 32909);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30297, 30325);

                                PSModuleInfo
                                moduleToRemove
                                = default(PSModuleInfo);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30355, 30554) || true) && (f_1530_30359_30428(this, rootedPath, out moduleToRemove, toRemove: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 30355, 30554);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30494, 30523);

                                    f_1530_30494_30522(this, moduleToRemove);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 30355, 30554);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30586, 30915);

                                foundModule = f_1530_30600_30914(this, rootedPath, null, f_1530_30629_30644(this), null, ref importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out found);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 30212, 32909);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 30212, 32909);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 30973, 32909) || true) && (f_1530_30977_31005(rootedPath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 30973, 32909);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 31150, 31346) || true) && (f_1530_31154_31202(rootedPath, Path.DirectorySeparatorChar))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 31150, 31346);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 31268, 31315);

                                        rootedPath = f_1530_31281_31314(rootedPath);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 31150, 31346);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 31482, 31999);

                                    foundModule = f_1530_31496_31998(this, rootedPath, ManifestProcessingFlags.LoadElements |
                                                                                                                ManifestProcessingFlags.WriteErrors |
                                                                                                                ManifestProcessingFlags.NullOnFirstError, importModuleOptions, out found);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 32031, 32882) || true) && (!found)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 32031, 32882);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 32281, 32349);

                                        rootedPath = f_1530_32294_32348(rootedPath, f_1530_32319_32347(rootedPath));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 32383, 32851);

                                        foundModule = f_1530_32397_32850(this, null, rootedPath, rootedPath, null, null, f_1530_32459_32474(this), null, importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out found);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 32031, 32882);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 30973, 32909);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 30212, 32909);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 30072, 32932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 27493, 36345);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 27493, 36345);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33132, 33962) || true) && (f_1530_33136_33176(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 33132, 33962);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33226, 33296);

                            PSSnapInInfo
                            snapin = f_1530_33248_33295(f_1530_33281_33288(), name)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33392, 33939) || true) && (snapin != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 33392, 33939);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33549, 33761);

                                string
                                warningMessage = f_1530_33573_33760(f_1530_33621_33649(), f_1530_33684_33713(), f_1530_33748_33759(snapin))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33791, 33820);

                                f_1530_33791_33819(this, warningMessage);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33850, 33863);

                                found = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 33893, 33912);

                                return foundModule;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 33392, 33939);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 33132, 33962);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 34275, 36326) || true) && (f_1530_34279_34293(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 34275, 36326);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 34439, 35455) || true) && (!f_1530_34444_34489(f_1530_34465_34488(name)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 34439, 35455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 34547, 34870);

                                foundModule = f_1530_34561_34869(this, name, null, f_1530_34584_34599(this), null, ref importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out found);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 34439, 35455);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 34439, 35455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 34984, 35428);

                                foundModule = f_1530_34998_35427(this, null, name, name, null, null, f_1530_35048_35063(this), null, importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out found);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 34439, 35455);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 34275, 36326);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 34275, 36326);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 35553, 35638);

                            IEnumerable<string>
                            modulePath = f_1530_35586_35637(false, f_1530_35624_35636(this))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 35666, 35882) || true) && (f_1530_35670_35689(this) == null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 35670, 35729) && f_1530_35701_35721(this) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 35670, 35760) && f_1530_35733_35752(this) == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 35666, 35882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 35818, 35855);

                                this.AddToAppDomainLevelCache = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 35666, 35882);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 35910, 36303);

                            found = f_1530_35918_36302(this, found, modulePath, name, null, importModuleOptions, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, out foundModule);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 34275, 36326);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 27493, 36345);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36365, 38312) || true) && (!found)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 36365, 38312);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36417, 36439);

                        ErrorRecord
                        er = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36461, 36483);

                        string
                        message = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36505, 37417) || true) && (f_1530_36509_36528() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 36505, 37417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36586, 36676);

                            message = f_1530_36596_36675(f_1530_36614_36647(), name, f_1530_36655_36674());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 36505, 37417);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 36505, 37417);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36726, 37417) || true) && (f_1530_36730_36748() != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 36730, 36786) && f_1530_36760_36778() != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 36726, 37417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 36836, 36959);

                                message = f_1530_36846_36958(f_1530_36864_36911(), name, f_1530_36919_36937(), f_1530_36939_36957());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 36726, 37417);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 36726, 37417);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37009, 37417) || true) && (f_1530_37013_37031() != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 37009, 37417);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37089, 37178);

                                    message = f_1530_37099_37177(f_1530_37117_37150(), name, f_1530_37158_37176());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 37009, 37417);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 37009, 37417);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37228, 37417) || true) && (f_1530_37232_37250() != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 37228, 37417);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37308, 37394);

                                        message = f_1530_37318_37393(f_1530_37336_37366(), name, f_1530_37374_37392());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 37228, 37417);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 37009, 37417);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 36726, 37417);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 36505, 37417);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37441, 38254) || true) && (f_1530_37445_37464() != null || (DynAbs.Tracing.TraceSender.Expression_False(1530, 37445, 37502) || f_1530_37476_37494() != null) || (DynAbs.Tracing.TraceSender.Expression_False(1530, 37445, 37532) || f_1530_37506_37524() != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 37441, 38254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37582, 37645);

                            FileNotFoundException
                            fnf = f_1530_37610_37644(message)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37671, 37821);

                            er = f_1530_37676_37820(fnf, "Modules_ModuleWithVersionNotFound", ErrorCategory.ResourceUnavailable, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 37441, 38254);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 37441, 38254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 37919, 37977);

                            message = f_1530_37929_37976(f_1530_37947_37969(), name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38003, 38066);

                            FileNotFoundException
                            fnf = f_1530_38031_38065(message)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38092, 38231);

                            er = f_1530_38097_38230(fnf, "Modules_ModuleNotFound", ErrorCategory.ResourceUnavailable, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 37441, 38254);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38278, 38293);

                        f_1530_38278_38292(this, er);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 36365, 38312);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38332, 38351);

                    return foundModule;
                }
                catch (PSInvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 38380, 38549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38450, 38501);

                    ErrorRecord
                    er = f_1530_38467_38500(f_1530_38483_38496(e), e)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38519, 38534);

                    f_1530_38519_38533(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 38380, 38549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38565, 38577);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 25915, 38588);

                System.Version
                f_1530_26419_26438(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 26419, 26438);
                    return return_v;
                }


                string
                f_1530_26450_26469(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 26450, 26469);
                    return return_v;
                }


                System.Version
                f_1530_26481_26501(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 26481, 26501);
                    return return_v;
                }


                bool
                f_1530_26513_26554()
                {
                    var return_v = PSModuleInfo.UseAppDomainLevelModuleCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 26513, 26554);
                    return return_v;
                }


                bool
                f_1530_26558_26573_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 26558, 26573);
                    return return_v;
                }


                string
                f_1530_26720_26776(string
                moduleName)
                {
                    var return_v = PSModuleInfo.ResolveUsingAppDomainLevelModuleCache(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 26720, 26776);
                    return return_v;
                }


                bool
                f_1530_26821_26853(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 26821, 26853);
                    return return_v;
                }


                bool
                f_1530_26899_26922(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 26899, 26922);
                    return return_v;
                }


                bool
                f_1530_27094_27142(string
                moduleName)
                {
                    var return_v = PSModuleInfo.RemoveFromAppDomainLevelCache(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 27094, 27142);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_27395_27407(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 27395, 27407);
                    return return_v;
                }


                string
                f_1530_27367_27408(string
                filePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ResolveRootedFilePath(filePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 27367, 27408);
                    return return_v;
                }


                bool
                f_1530_27498_27530(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 27498, 27530);
                    return return_v;
                }


                bool
                f_1530_28145_28155_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28145, 28155);
                    return return_v;
                }


                bool
                f_1530_28159_28217(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                moduleInfo)
                {
                    var return_v = this_param.TryGetFromModuleTable(key, out moduleInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 28159, 28217);
                    return return_v;
                }


                System.Management.Automation.ModuleType
                f_1530_28271_28288(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28271, 28288);
                    return return_v;
                }


                System.Version
                f_1530_28390_28404(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28390, 28404);
                    return return_v;
                }


                System.Version
                f_1530_28406_28421()
                {
                    var return_v = RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28406, 28421);
                    return return_v;
                }


                System.Version
                f_1530_28423_28441()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28423, 28441);
                    return return_v;
                }


                System.Version
                f_1530_28443_28461()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28443, 28461);
                    return return_v;
                }


                bool
                f_1530_28344_28462(System.Version
                version, System.Version
                requiredVersion, System.Version
                minimumVersion, System.Version
                maximumVersion)
                {
                    var return_v = ModuleIntrinsics.IsVersionMatchingConstraints(version, requiredVersion, minimumVersion, maximumVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 28344, 28462);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_28595_28607(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28595, 28607);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_28609_28632(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.TargetSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28609, 28632);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_28609_28641(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28609, 28641);
                    return return_v;
                }


                int
                f_1530_28571_28650(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                targetSessionState, System.Management.Automation.PSModuleInfo
                module)
                {
                    AddModuleToModuleTables(context, targetSessionState, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 28571, 28650);
                    return 0;
                }


                string
                f_1530_28709_28724(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28709, 28724);
                    return return_v;
                }


                int
                f_1530_28681_28746(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sourceModule, string
                prefix, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options)
                {
                    this_param.ImportModuleMembers(sourceModule, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 28681, 28746);
                    return 0;
                }


                bool
                f_1530_28783_28801()
                {
                    var return_v = BaseAsCustomObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28783, 28801);
                    return return_v;
                }


                System.Management.Automation.ModuleType
                f_1530_28871_28888(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 28871, 28888);
                    return return_v;
                }


                string
                f_1530_29018_29063()
                {
                    var return_v = Modules.CantUseAsCustomObjectWithBinaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 29018, 29063);
                    return return_v;
                }


                string
                f_1530_29065_29076(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 29065, 29076);
                    return return_v;
                }


                string
                f_1530_29000_29077(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29000, 29077);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_29154_29192(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29154, 29192);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_29248_29431(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29248, 29431);
                    return return_v;
                }


                int
                f_1530_29470_29484(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29470, 29484);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1530_29643_29666(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.AsCustomObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29643, 29666);
                    return return_v;
                }


                int
                f_1530_29631_29667(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29631, 29667);
                    return 0;
                }


                bool
                f_1530_29773_29785()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 29773, 29785);
                    return return_v;
                }


                int
                f_1530_29851_29870(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 29851, 29870);
                    return 0;
                }


                bool
                f_1530_30216_30239(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 30216, 30239);
                    return return_v;
                }


                bool
                f_1530_30359_30428(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                moduleInfo, bool
                toRemove)
                {
                    var return_v = this_param.TryGetFromModuleTable(key, out moduleInfo, toRemove: toRemove);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 30359, 30428);
                    return return_v;
                }


                int
                f_1530_30494_30522(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                module)
                {
                    this_param.RemoveModule(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 30494, 30522);
                    return 0;
                }


                string
                f_1530_30629_30644(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 30629, 30644);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_30600_30914(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                fileName, string
                moduleBase, string
                prefix, System.Management.Automation.SessionState
                ss, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out bool
                found)
                {
                    var return_v = this_param.LoadModule(fileName, moduleBase, prefix, ss, ref options, manifestProcessingFlags, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 30600, 30914);
                    return return_v;
                }


                bool
                f_1530_30977_31005(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 30977, 31005);
                    return return_v;
                }


                bool
                f_1530_31154_31202(string
                this_param, char
                value)
                {
                    var return_v = this_param.EndsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 31154, 31202);
                    return return_v;
                }


                string?
                f_1530_31281_31314(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 31281, 31314);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_31496_31998(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleBase, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, out bool
                found)
                {
                    var return_v = this_param.LoadUsingMultiVersionModuleBase(moduleBase, manifestProcessingFlags, importModuleOptions, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 31496, 31998);
                    return return_v;
                }


                string?
                f_1530_32319_32347(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 32319, 32347);
                    return return_v;
                }


                string
                f_1530_32294_32348(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 32294, 32348);
                    return return_v;
                }


                string
                f_1530_32459_32474(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 32459, 32474);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_32397_32850(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                parentModule, string
                moduleName, string
                fileBaseName, string
                extension, string
                moduleBase, string
                prefix, System.Management.Automation.SessionState
                ss, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out bool
                found)
                {
                    var return_v = this_param.LoadUsingExtensions(parentModule, moduleName, fileBaseName, extension, moduleBase, prefix, ss, options, manifestProcessingFlags, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 32397, 32850);
                    return return_v;
                }


                bool
                f_1530_33136_33176(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 33136, 33176);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_33281_33288()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 33281, 33288);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1530_33248_33295(System.Management.Automation.ExecutionContext
                context, string
                name)
                {
                    var return_v = ModuleCmdletBase.GetEngineSnapIn(context, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 33248, 33295);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_33621_33649()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 33621, 33649);
                    return return_v;
                }


                string
                f_1530_33684_33713()
                {
                    var return_v = Modules.ModuleLoadedAsASnapin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 33684, 33713);
                    return return_v;
                }


                string
                f_1530_33748_33759(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 33748, 33759);
                    return return_v;
                }


                string
                f_1530_33573_33760(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 33573, 33760);
                    return return_v;
                }


                int
                f_1530_33791_33819(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 33791, 33819);
                    return 0;
                }


                bool
                f_1530_34279_34293(string
                filePath)
                {
                    var return_v = IsRooted(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 34279, 34293);
                    return return_v;
                }


                string?
                f_1530_34465_34488(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 34465, 34488);
                    return return_v;
                }


                bool
                f_1530_34444_34489(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 34444, 34489);
                    return return_v;
                }


                string
                f_1530_34584_34599(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 34584, 34599);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_34561_34869(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                fileName, string
                moduleBase, string
                prefix, System.Management.Automation.SessionState
                ss, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out bool
                found)
                {
                    var return_v = this_param.LoadModule(fileName, moduleBase, prefix, ss, ref options, manifestProcessingFlags, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 34561, 34869);
                    return return_v;
                }


                string
                f_1530_35048_35063(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 35048, 35063);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_34998_35427(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                parentModule, string
                moduleName, string
                fileBaseName, string
                extension, string
                moduleBase, string
                prefix, System.Management.Automation.SessionState
                ss, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out bool
                found)
                {
                    var return_v = this_param.LoadUsingExtensions(parentModule, moduleName, fileBaseName, extension, moduleBase, prefix, ss, options, manifestProcessingFlags, out found);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 34998, 35427);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_35624_35636(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 35624, 35636);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_35586_35637(bool
                includeSystemModulePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = ModuleIntrinsics.GetModulePath(includeSystemModulePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 35586, 35637);
                    return return_v;
                }


                System.Version
                f_1530_35670_35689(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 35670, 35689);
                    return return_v;
                }


                System.Version
                f_1530_35701_35721(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 35701, 35721);
                    return return_v;
                }


                string
                f_1530_35733_35752(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 35733, 35752);
                    return return_v;
                }


                bool
                f_1530_35918_36302(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, bool
                found, System.Collections.Generic.IEnumerable<string>
                modulePath, string
                name, System.Management.Automation.SessionState
                ss, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, out System.Management.Automation.PSModuleInfo
                module)
                {
                    var return_v = this_param.LoadUsingModulePath(found, modulePath, name, ss, options, manifestProcessingFlags, out module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 35918, 36302);
                    return return_v;
                }


                System.Version
                f_1530_36509_36528()
                {
                    var return_v = BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36509, 36528);
                    return return_v;
                }


                string
                f_1530_36614_36647()
                {
                    var return_v = Modules.ModuleWithVersionNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36614, 36647);
                    return return_v;
                }


                System.Version
                f_1530_36655_36674()
                {
                    var return_v = BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36655, 36674);
                    return return_v;
                }


                string
                f_1530_36596_36675(string
                formatSpec, string
                o1, System.Version
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 36596, 36675);
                    return return_v;
                }


                System.Version
                f_1530_36730_36748()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36730, 36748);
                    return return_v;
                }


                System.Version
                f_1530_36760_36778()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36760, 36778);
                    return return_v;
                }


                string
                f_1530_36864_36911()
                {
                    var return_v = Modules.MinimumVersionAndMaximumVersionNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36864, 36911);
                    return return_v;
                }


                System.Version
                f_1530_36919_36937()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36919, 36937);
                    return return_v;
                }


                System.Version
                f_1530_36939_36957()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 36939, 36957);
                    return return_v;
                }


                string
                f_1530_36846_36958(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 36846, 36958);
                    return return_v;
                }


                System.Version
                f_1530_37013_37031()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37013, 37031);
                    return return_v;
                }


                string
                f_1530_37117_37150()
                {
                    var return_v = Modules.ModuleWithVersionNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37117, 37150);
                    return return_v;
                }


                System.Version
                f_1530_37158_37176()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37158, 37176);
                    return return_v;
                }


                string
                f_1530_37099_37177(string
                formatSpec, string
                o1, System.Version
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 37099, 37177);
                    return return_v;
                }


                System.Version
                f_1530_37232_37250()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37232, 37250);
                    return return_v;
                }


                string
                f_1530_37336_37366()
                {
                    var return_v = Modules.MaximumVersionNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37336, 37366);
                    return return_v;
                }


                System.Version
                f_1530_37374_37392()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37374, 37392);
                    return return_v;
                }


                string
                f_1530_37318_37393(string
                formatSpec, string
                o1, System.Version
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 37318, 37393);
                    return return_v;
                }


                System.Version
                f_1530_37445_37464()
                {
                    var return_v = BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37445, 37464);
                    return return_v;
                }


                System.Version
                f_1530_37476_37494()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37476, 37494);
                    return return_v;
                }


                System.Version
                f_1530_37506_37524()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37506, 37524);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1530_37610_37644(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 37610, 37644);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_37676_37820(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 37676, 37820);
                    return return_v;
                }


                string
                f_1530_37947_37969()
                {
                    var return_v = Modules.ModuleNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 37947, 37969);
                    return return_v;
                }


                string
                f_1530_37929_37976(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 37929, 37976);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1530_38031_38065(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38031, 38065);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_38097_38230(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38097, 38230);
                    return return_v;
                }


                int
                f_1530_38278_38292(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38278, 38292);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1530_38483_38496(System.Management.Automation.PSInvalidOperationException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 38483, 38496);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_38467_38500(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.PSInvalidOperationException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38467, 38500);
                    return return_v;
                }


                int
                f_1530_38519_38533(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38519, 38533);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 25915, 38588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 25915, 38588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo ImportModule_LocallyViaFQName(ImportModuleOptions importModuleOptions, ModuleSpecification modulespec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 38600, 39357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38748, 38793);

                RequiredVersion = f_1530_38766_38792(modulespec);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38807, 38843);

                MinimumVersion = f_1530_38824_38842(modulespec);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38857, 38900);

                MaximumVersion = f_1530_38874_38899(modulespec);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38914, 38941);

                BaseGuid = f_1530_38925_38940(modulespec);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 38957, 39050);

                PSModuleInfo
                foundModule = f_1530_38984_39049(this, importModuleOptions, f_1530_39033_39048(modulespec))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39066, 39311) || true) && (foundModule != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 39066, 39311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39123, 39216);

                    f_1530_39123_39215(TelemetryType.ModuleLoad, f_1530_39198_39214(foundModule));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39234, 39296);

                    f_1530_39234_39295(this, f_1530_39264_39280(foundModule), f_1530_39282_39294(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 39066, 39311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39327, 39346);

                return foundModule;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 38600, 39357);

                System.Version
                f_1530_38766_38792(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 38766, 38792);
                    return return_v;
                }


                System.Version
                f_1530_38824_38842(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 38824, 38842);
                    return return_v;
                }


                string
                f_1530_38874_38899(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 38874, 38899);
                    return return_v;
                }


                System.Guid?
                f_1530_38925_38940(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 38925, 38940);
                    return return_v;
                }


                string
                f_1530_39033_39048(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 39033, 39048);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_38984_39049(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                name)
                {
                    var return_v = this_param.ImportModule_LocallyViaName(importModuleOptions, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 38984, 39049);
                    return return_v;
                }


                string
                f_1530_39198_39214(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 39198, 39214);
                    return return_v;
                }


                int
                f_1530_39123_39215(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 39123, 39215);
                    return 0;
                }


                string
                f_1530_39264_39280(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 39264, 39280);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_39282_39294(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 39282, 39294);
                    return return_v;
                }


                int
                f_1530_39234_39295(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleName, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetModuleBaseForEngineModules(moduleName, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 39234, 39295);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 38600, 39357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 38600, 39357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IList<PSModuleInfo> ImportModule_RemotelyViaPsrpSession(
                    ImportModuleOptions importModuleOptions,
                    IEnumerable<string> moduleNames,
                    IEnumerable<ModuleSpecification> fullyQualifiedNames,
                    PSSession psSession,
                    bool usingWinCompat = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 39479, 40967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39811, 39866);

                var
                remotelyImportedModules = f_1530_39841_39865()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39880, 40210) || true) && (moduleNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 39880, 40210);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 39937, 40195);
                        foreach (string moduleName in f_1530_39967_39978_I(moduleNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 39937, 40195);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40020, 40116);

                            var
                            tmp = f_1530_40030_40115(this, importModuleOptions, moduleName, null, psSession)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40138, 40176);

                            f_1530_40138_40175(remotelyImportedModules, tmp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 39937, 40195);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 259);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 39880, 40210);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40226, 40585) || true) && (fullyQualifiedNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 40226, 40585);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40291, 40570);
                        foreach (var fullyQualifiedName in f_1530_40326_40345_I(fullyQualifiedNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 40291, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40387, 40491);

                            var
                            tmp = f_1530_40397_40490(this, importModuleOptions, null, fullyQualifiedName, psSession)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40513, 40551);

                            f_1530_40513_40550(remotelyImportedModules, tmp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 40291, 40570);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 280);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 280);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 40226, 40585);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40656, 40909);
                    foreach (PSModuleInfo moduleInfo in f_1530_40692_40715_I(remotelyImportedModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 40656, 40909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40749, 40894);

                        f_1530_40749_40893((DynAbs.Tracing.TraceSender.Conditional_F1(1530, 40798, 40812) || ((usingWinCompat && DynAbs.Tracing.TraceSender.Conditional_F2(1530, 40815, 40848)) || DynAbs.Tracing.TraceSender.Conditional_F3(1530, 40851, 40875))) ? TelemetryType.WinCompatModuleLoad : TelemetryType.ModuleLoad, f_1530_40877_40892(moduleInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 40656, 40909);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 40925, 40956);

                return remotelyImportedModules;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 39479, 40967);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1530_39841_39865()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 39841, 39865);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_40030_40115(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                moduleName, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession(importModuleOptions, moduleName, fullyQualifiedName, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40030, 40115);
                    return return_v;
                }


                int
                f_1530_40138_40175(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40138, 40175);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_39967_39978_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 39967, 39978);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_40397_40490(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                moduleName, Microsoft.PowerShell.Commands.ModuleSpecification
                fullyQualifiedName, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession(importModuleOptions, moduleName, fullyQualifiedName, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40397, 40490);
                    return return_v;
                }


                int
                f_1530_40513_40550(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40513, 40550);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1530_40326_40345_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40326, 40345);
                    return return_v;
                }


                string
                f_1530_40877_40892(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 40877, 40892);
                    return return_v;
                }


                int
                f_1530_40749_40893(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40749, 40893);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1530_40692_40715_I(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 40692, 40715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 39479, 40967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 39479, 40967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IList<PSModuleInfo> ImportModule_RemotelyViaPsrpSession(
                    ImportModuleOptions importModuleOptions,
                    string moduleName,
                    ModuleSpecification fullyQualifiedName,
                    PSSession psSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 40979, 46635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41335, 41374);

                List<PSObject>
                remotelyImportedModules
                = default(List<PSObject>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41388, 43470);
                using (var
                powerShell = f_1530_41412_41460()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41494, 41535);

                    powerShell.Runspace = f_1530_41516_41534(psSession);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41553, 41592);

                    f_1530_41553_41591(powerShell, "Import-Module");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41610, 41683);

                    f_1530_41610_41682(powerShell, "DisableNameChecking", f_1530_41657_41681(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41701, 41743);

                    f_1530_41701_41742(powerShell, "PassThru", true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41763, 42615) || true) && (fullyQualifiedName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 41763, 42615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41835, 41901);

                        f_1530_41835_41900(powerShell, "FullyQualifiedName", fullyQualifiedName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 41763, 42615);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 41763, 42615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 41983, 42027);

                        f_1530_41983_42026(powerShell, "Name", moduleName);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42051, 42211) || true) && (f_1530_42055_42074(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 42051, 42211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42132, 42188);

                            f_1530_42132_42187(powerShell, "Version", f_1530_42167_42186(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 42051, 42211);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42235, 42405) || true) && (f_1530_42239_42259(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 42235, 42405);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42317, 42382);

                            f_1530_42317_42381(powerShell, "RequiredVersion", f_1530_42360_42380(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 42235, 42405);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42429, 42596) || true) && (f_1530_42433_42452(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 42429, 42596);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42510, 42573);

                            f_1530_42510_42572(powerShell, "MaximumVersion", f_1530_42552_42571(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 42429, 42596);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 41763, 42615);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42635, 42784) || true) && (f_1530_42639_42656(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 42635, 42784);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42706, 42765);

                        f_1530_42706_42764(powerShell, "ArgumentList", f_1530_42746_42763(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 42635, 42784);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42804, 42922) || true) && (f_1530_42808_42822(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 42804, 42922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42864, 42903);

                        f_1530_42864_42902(powerShell, "Force", true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 42804, 42922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 42942, 43214);

                    string
                    errorMessageTemplate = f_1530_42972_43213(f_1530_43008_43036(), f_1530_43059_43105(), f_1530_43128_43212(f_1530_43142_43170(), "Import-Module -Name '{0}'", moduleName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43232, 43455);

                    remotelyImportedModules = f_1530_43258_43454(f_1530_43258_43445(powerShell, f_1530_43352_43374(this), this, errorMessageTemplate));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1530, 41388, 43470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43486, 43539);

                List<PSModuleInfo>
                result = f_1530_43514_43538()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43553, 46594);
                    foreach (PSObject remotelyImportedModule in f_1530_43597_43620_I(remotelyImportedModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 43553, 46594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43654, 43726);

                        PSPropertyInfo
                        nameProperty = f_1530_43684_43725(f_1530_43684_43717(remotelyImportedModule), "Name")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43744, 46579) || true) && (nameProperty != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 43744, 46579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 43810, 44015);

                            string
                            remoteModuleName = (string)f_1530_43844_44014(f_1530_43899_43917(nameProperty), typeof(string), f_1530_43985_44013())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44039, 44122);

                            PSPropertyInfo
                            helpInfoProperty = f_1530_44073_44121(f_1530_44073_44106(remotelyImportedModule), "HelpInfoUri")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44144, 44176);

                            string
                            remoteHelpInfoUri = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44198, 44514) || true) && (helpInfoProperty != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 44198, 44514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44276, 44491);

                                remoteHelpInfoUri = (string)f_1530_44304_44490(f_1530_44363_44385(helpInfoProperty), typeof(string), f_1530_44461_44489());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 44198, 44514);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44538, 44610);

                            PSPropertyInfo
                            guidProperty = f_1530_44568_44609(f_1530_44568_44601(remotelyImportedModule), "Guid")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44632, 44667);

                            Guid
                            remoteModuleGuid = Guid.Empty
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44689, 44860) || true) && (guidProperty != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 44689, 44860);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44763, 44837);

                                f_1530_44763_44836(f_1530_44795_44813(guidProperty), out remoteModuleGuid);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 44689, 44860);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44884, 44962);

                            PSPropertyInfo
                            versionProperty = f_1530_44917_44961(f_1530_44917_44950(remotelyImportedModule), "Version")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 44984, 45019);

                            Version
                            remoteModuleVersion = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45041, 45396) || true) && (versionProperty != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 45041, 45396);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45118, 45130);

                                Version
                                tmp
                                = default(Version);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45156, 45373) || true) && (f_1530_45160_45262(f_1530_45201_45222(versionProperty), f_1530_45224_45252(), out tmp))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 45156, 45373);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45320, 45346);

                                    remoteModuleVersion = tmp;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 45156, 45373);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 45041, 45396);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45420, 45678);

                            PSModuleInfo
                            moduleInfo = f_1530_45446_45677(this, importModuleOptions, remoteModuleName, remoteModuleVersion, psSession)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 45889, 46560) || true) && (moduleInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 45889, 46560);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46024, 46246) || true) && (f_1530_46028_46072(f_1530_46049_46071(moduleInfo)) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 46028, 46116) && !f_1530_46077_46116(remoteHelpInfoUri)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 46024, 46246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46174, 46219);

                                    f_1530_46174_46218(moduleInfo, remoteHelpInfoUri);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 46024, 46246);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46330, 46486) || true) && (remoteModuleGuid != Guid.Empty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 46330, 46486);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46422, 46459);

                                    f_1530_46422_46458(moduleInfo, remoteModuleGuid);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 46330, 46486);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46514, 46537);

                                f_1530_46514_46536(
                                                        result, moduleInfo);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 45889, 46560);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 43744, 46579);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 43553, 46594);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 3042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 3042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46610, 46624);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 40979, 46635);

                System.Management.Automation.PowerShell
                f_1530_41412_41460()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41412, 41460);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1530_41516_41534(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 41516, 41534);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_41553_41591(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41553, 41591);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1530_41657_41681(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.DisableNameChecking;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 41657, 41681);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_41610_41682(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.SwitchParameter
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41610, 41682);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_41701_41742(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41701, 41742);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_41835_41900(System.Management.Automation.PowerShell
                this_param, string
                parameterName, Microsoft.PowerShell.Commands.ModuleSpecification
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41835, 41900);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_41983_42026(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 41983, 42026);
                    return return_v;
                }


                System.Version
                f_1530_42055_42074(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42055, 42074);
                    return return_v;
                }


                System.Version
                f_1530_42167_42186(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42167, 42186);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_42132_42187(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Version
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42132, 42187);
                    return return_v;
                }


                System.Version
                f_1530_42239_42259(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42239, 42259);
                    return return_v;
                }


                System.Version
                f_1530_42360_42380(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42360, 42380);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_42317_42381(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Version
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42317, 42381);
                    return return_v;
                }


                string
                f_1530_42433_42452(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42433, 42452);
                    return return_v;
                }


                string
                f_1530_42552_42571(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42552, 42571);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_42510_42572(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42510, 42572);
                    return return_v;
                }


                object[]
                f_1530_42639_42656(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42639, 42656);
                    return return_v;
                }


                object[]
                f_1530_42746_42763(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42746, 42763);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_42706_42764(System.Management.Automation.PowerShell
                this_param, string
                parameterName, object[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42706, 42764);
                    return return_v;
                }


                bool
                f_1530_42808_42822(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BaseForce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 42808, 42822);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_42864_42902(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42864, 42902);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_43008_43036()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43008, 43036);
                    return return_v;
                }


                string
                f_1530_43059_43105()
                {
                    var return_v = Modules.RemoteDiscoveryRemotePsrpCommandFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43059, 43105);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_43142_43170()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43142, 43170);
                    return return_v;
                }


                string
                f_1530_43128_43212(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43128, 43212);
                    return return_v;
                }


                string
                f_1530_42972_43213(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 42972, 43213);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_1530_43352_43374(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43352, 43374);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1530_43258_43445(System.Management.Automation.PowerShell
                powerShell, System.Threading.CancellationToken
                cancellationToken, Microsoft.PowerShell.Commands.ImportModuleCommand
                cmdlet, string
                errorMessageTemplate)
                {
                    var return_v = RemoteDiscoveryHelper.InvokePowerShell(powerShell, cancellationToken, (System.Management.Automation.PSCmdlet)cmdlet, errorMessageTemplate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43258, 43445);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1530_43258_43454(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43258, 43454);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1530_43514_43538()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43514, 43538);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1530_43684_43717(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43684, 43717);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1530_43684_43725(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43684, 43725);
                    return return_v;
                }


                object
                f_1530_43899_43917(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43899, 43917);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_43985_44013()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 43985, 44013);
                    return return_v;
                }


                object
                f_1530_43844_44014(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43844, 44014);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1530_44073_44106(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44073, 44106);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1530_44073_44121(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44073, 44121);
                    return return_v;
                }


                object
                f_1530_44363_44385(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44363, 44385);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_44461_44489()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44461, 44489);
                    return return_v;
                }


                object
                f_1530_44304_44490(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 44304, 44490);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1530_44568_44601(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44568, 44601);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1530_44568_44609(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44568, 44609);
                    return return_v;
                }


                object
                f_1530_44795_44813(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44795, 44813);
                    return return_v;
                }


                bool
                f_1530_44763_44836(object
                valueToConvert, out System.Guid
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 44763, 44836);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1530_44917_44950(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44917, 44950);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1530_44917_44961(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 44917, 44961);
                    return return_v;
                }


                object
                f_1530_45201_45222(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 45201, 45222);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_45224_45252()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 45224, 45252);
                    return return_v;
                }


                bool
                f_1530_45160_45262(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out System.Version
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<Version>(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 45160, 45262);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_45446_45677(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                remoteModuleName, System.Version
                remoteModuleVersion, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession_SinglePreimportedModule(importModuleOptions, remoteModuleName, remoteModuleVersion, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 45446, 45677);
                    return return_v;
                }


                string
                f_1530_46049_46071(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.HelpInfoUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 46049, 46071);
                    return return_v;
                }


                bool
                f_1530_46028_46072(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46028, 46072);
                    return return_v;
                }


                bool
                f_1530_46077_46116(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46077, 46116);
                    return return_v;
                }


                int
                f_1530_46174_46218(System.Management.Automation.PSModuleInfo
                this_param, string
                uri)
                {
                    this_param.SetHelpInfoUri(uri);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46174, 46218);
                    return 0;
                }


                int
                f_1530_46422_46458(System.Management.Automation.PSModuleInfo
                this_param, System.Guid
                guid)
                {
                    this_param.SetGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46422, 46458);
                    return 0;
                }


                int
                f_1530_46514_46536(System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                this_param, System.Management.Automation.PSModuleInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46514, 46536);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1530_43597_43620_I(System.Collections.Generic.List<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 43597, 43620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 40979, 46635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 40979, 46635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo ImportModule_RemotelyViaPsrpSession_SinglePreimportedModule(
                    ImportModuleOptions importModuleOptions,
                    string remoteModuleName,
                    Version remoteModuleVersion,
                    PSSession psSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 46647, 53442);
                System.Management.Automation.PSModuleInfo moduleInfo = default(System.Management.Automation.PSModuleInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 46921, 47148);

                string
                temporaryModulePath = f_1530_46950_47147(remoteModuleName, remoteModuleVersion, f_1530_47077_47099(psSession), f_1530_47118_47146(f_1530_47118_47130(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47162, 47235);

                string
                wildcardEscapedPath = f_1530_47191_47234(temporaryModulePath)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47376, 47482);

                    string
                    localPsm1File = f_1530_47399_47481(temporaryModulePath, f_1530_47433_47470(temporaryModulePath) + ".psm1")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47500, 47671);

                    PSModuleInfo
                    alreadyImportedModule = f_1530_47537_47670(this, localPsm1File, f_1530_47633_47648(this), importModuleOptions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47689, 47812) || true) && (alreadyImportedModule != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 47689, 47812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47764, 47793);

                        return alreadyImportedModule;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 47689, 47812);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 47934, 49327);
                    using (var
                    powerShell = f_1530_47958_48034(RunspaceMode.CurrentRunspace)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48076, 48118);

                        f_1530_48076_48117(powerShell, "Export-PSSession");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48140, 48201);

                        f_1530_48140_48200(powerShell, "OutputModule", wildcardEscapedPath);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48223, 48391) || true) && (!importModuleOptions.NoClobberExportPSSession)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 48223, 48391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48322, 48368);

                            f_1530_48322_48367(powerShell, "AllowClobber", true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 48223, 48391);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48413, 48465);

                        f_1530_48413_48464(powerShell, "Module", remoteModuleName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48569, 48608);

                        f_1530_48569_48607(powerShell, "Force", true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48630, 48677);

                        f_1530_48630_48676(powerShell, "FormatTypeName", "*");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48699, 48745);

                        f_1530_48699_48744(powerShell, "Session", psSession);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 48769, 48998);

                        string
                        errorMessageTemplate = f_1530_48799_48997(f_1530_48839_48867(), f_1530_48894_48953(), remoteModuleName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49020, 49165);

                        int
                        numberOfLocallyCreatedFiles = f_1530_49054_49164(f_1530_49054_49156(powerShell, f_1530_49105_49127(this), this, errorMessageTemplate))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49187, 49308) || true) && (numberOfLocallyCreatedFiles == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 49187, 49308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49273, 49285);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 49187, 49308);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1530, 47934, 49327);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49428, 49513);

                    string
                    localPsd1File = f_1530_49451_49512(temporaryModulePath, remoteModuleName + ".psd1")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49531, 49649) || true) && (f_1530_49535_49561(localPsd1File))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 49531, 49649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49603, 49630);

                        f_1530_49603_49629(localPsd1File);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 49531, 49649);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49669, 49851);

                    f_1530_49669_49850(sourceFileName: f_1530_49717_49799(temporaryModulePath, f_1530_49751_49788(temporaryModulePath) + ".psd1"), destFileName: localPsd1File);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 49869, 49940);

                    string
                    wildcardEscapedPsd1Path = f_1530_49902_49939(localPsd1File)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50075, 50120);

                    object[]
                    oldArgumentList = f_1530_50102_50119(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50138, 50194);

                    Version
                    originalBaseMinimumVersion = f_1530_50175_50193()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50212, 50268);

                    Version
                    originalBaseMaximumVersion = f_1530_50249_50267()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50286, 50344);

                    Version
                    originalBaseRequiredVersion = f_1530_50324_50343()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50406, 50453);

                        this.ArgumentList = new object[] { psSession };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50902, 50928);

                        BaseMinimumVersion = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50950, 50976);

                        BaseMaximumVersion = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 50998, 51025);

                        BaseRequiredVersion = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51047, 51121);

                        f_1530_51047_51120(this, importModuleOptions, wildcardEscapedPsd1Path);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1530, 51158, 51473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51206, 51242);

                        this.ArgumentList = oldArgumentList;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51264, 51312);

                        BaseMinimumVersion = originalBaseMinimumVersion;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51334, 51382);

                        BaseMaximumVersion = originalBaseMaximumVersion;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51404, 51454);

                        BaseRequiredVersion = originalBaseRequiredVersion;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1530, 51158, 51473);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51624, 51725);

                    string
                    psm1Path = f_1530_51642_51724(temporaryModulePath, f_1530_51676_51713(temporaryModulePath) + ".psm1")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51743, 52090) || true) && (!f_1530_51748_51824(this, psm1Path, out moduleInfo, toRemove: true))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 51743, 52090);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51866, 52035) || true) && (f_1530_51870_51907(temporaryModulePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 51866, 52035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 51957, 52012);

                            f_1530_51957_52011(temporaryModulePath, recursive: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 51866, 52035);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52059, 52071);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 51743, 52090);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52110, 52588);

                    const string
                    onRemoveScriptBody = @"
                    Microsoft.PowerShell.Management\Remove-Item `
                        -LiteralPath $temporaryModulePath `
                        -Force `
                        -Recurse `
                        -ErrorAction SilentlyContinue

                    if ($null -ne $previousOnRemoveScript)
                    {
                        & $previousOnRemoveScript $args
                    }
                    "
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52606, 52704);

                    ScriptBlock
                    onRemoveScriptBlock = f_1530_52640_52703(f_1530_52640_52659(f_1530_52640_52652(this)), onRemoveScriptBody, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52722, 52780);

                    onRemoveScriptBlock = f_1530_52744_52779(onRemoveScriptBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52849, 52948);

                    f_1530_52849_52947(f_1530_52849_52899(f_1530_52849_52888(f_1530_52849_52875(onRemoveScriptBlock))), "temporaryModulePath", temporaryModulePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 52966, 53068);

                    f_1530_52966_53067(f_1530_52966_53016(f_1530_52966_53005(f_1530_52966_52992(onRemoveScriptBlock))), "previousOnRemoveScript", f_1530_53047_53066(moduleInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53086, 53128);

                    moduleInfo.OnRemove = onRemoveScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53148, 53166);

                    return moduleInfo;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 53195, 53431);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53233, 53390) || true) && (f_1530_53237_53274(temporaryModulePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 53233, 53390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53316, 53371);

                        f_1530_53316_53370(temporaryModulePath, recursive: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 53233, 53390);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53410, 53416);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 53195, 53431);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 46647, 53442);

                string
                f_1530_47077_47099(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 47077, 47099);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_47118_47130(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 47118, 47130);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1530_47118_47146(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 47118, 47146);
                    return return_v;
                }


                string
                f_1530_46950_47147(string
                remoteModuleName, System.Version
                remoteModuleVersion, string
                computerName, System.Management.Automation.Runspaces.Runspace
                localRunspace)
                {
                    var return_v = RemoteDiscoveryHelper.GetModulePath(remoteModuleName, remoteModuleVersion, computerName, localRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 46950, 47147);
                    return return_v;
                }


                string
                f_1530_47191_47234(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 47191, 47234);
                    return return_v;
                }


                string?
                f_1530_47433_47470(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 47433, 47470);
                    return return_v;
                }


                string
                f_1530_47399_47481(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 47399, 47481);
                    return return_v;
                }


                string
                f_1530_47633_47648(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 47633, 47648);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_47537_47670(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                modulePath, string
                prefix, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options)
                {
                    var return_v = this_param.IsModuleImportUnnecessaryBecauseModuleIsAlreadyLoaded(modulePath, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 47537, 47670);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_47958_48034(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 47958, 48034);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48076_48117(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48076, 48117);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48140_48200(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48140, 48200);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48322_48367(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48322, 48367);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48413_48464(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48413, 48464);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48569_48607(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48569, 48607);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48630_48676(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48630, 48676);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1530_48699_48744(System.Management.Automation.PowerShell
                this_param, string
                parameterName, System.Management.Automation.Runspaces.PSSession
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48699, 48744);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_48839_48867()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 48839, 48867);
                    return return_v;
                }


                string
                f_1530_48894_48953()
                {
                    var return_v = Modules.RemoteDiscoveryFailedToGenerateProxyForRemoteModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 48894, 48953);
                    return return_v;
                }


                string
                f_1530_48799_48997(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 48799, 48997);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_1530_49105_49127(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 49105, 49127);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1530_49054_49156(System.Management.Automation.PowerShell
                powerShell, System.Threading.CancellationToken
                cancellationToken, Microsoft.PowerShell.Commands.ImportModuleCommand
                cmdlet, string
                errorMessageTemplate)
                {
                    var return_v = RemoteDiscoveryHelper.InvokePowerShell(powerShell, cancellationToken, (System.Management.Automation.PSCmdlet)cmdlet, errorMessageTemplate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49054, 49156);
                    return return_v;
                }


                int
                f_1530_49054_49164(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                source)
                {
                    var return_v = source.Count<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49054, 49164);
                    return return_v;
                }


                string
                f_1530_49451_49512(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49451, 49512);
                    return return_v;
                }


                bool
                f_1530_49535_49561(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49535, 49561);
                    return return_v;
                }


                int
                f_1530_49603_49629(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49603, 49629);
                    return 0;
                }


                string?
                f_1530_49751_49788(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49751, 49788);
                    return return_v;
                }


                string
                f_1530_49717_49799(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49717, 49799);
                    return return_v;
                }


                int
                f_1530_49669_49850(string
                sourceFileName, string
                destFileName)
                {
                    File.Move(sourceFileName: sourceFileName, destFileName: destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49669, 49850);
                    return 0;
                }


                string
                f_1530_49902_49939(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 49902, 49939);
                    return return_v;
                }


                object[]
                f_1530_50102_50119(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 50102, 50119);
                    return return_v;
                }


                System.Version
                f_1530_50175_50193()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 50175, 50193);
                    return return_v;
                }


                System.Version
                f_1530_50249_50267()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 50249, 50267);
                    return return_v;
                }


                System.Version
                f_1530_50324_50343()
                {
                    var return_v = BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 50324, 50343);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_51047_51120(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                name)
                {
                    var return_v = this_param.ImportModule_LocallyViaName(importModuleOptions, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51047, 51120);
                    return return_v;
                }


                string?
                f_1530_51676_51713(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51676, 51713);
                    return return_v;
                }


                string
                f_1530_51642_51724(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51642, 51724);
                    return return_v;
                }


                bool
                f_1530_51748_51824(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                moduleInfo, bool
                toRemove)
                {
                    var return_v = this_param.TryGetFromModuleTable(key, out moduleInfo, toRemove: toRemove);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51748, 51824);
                    return return_v;
                }


                bool
                f_1530_51870_51907(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51870, 51907);
                    return return_v;
                }


                int
                f_1530_51957_52011(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 51957, 52011);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1530_52640_52652(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52640, 52652);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_1530_52640_52659(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52640, 52659);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_52640_52703(System.Management.Automation.AutomationEngine
                this_param, string
                script, bool
                addToHistory)
                {
                    var return_v = this_param.ParseScriptBlock(script, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 52640, 52703);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_52744_52779(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetNewClosure();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 52744, 52779);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_52849_52875(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52849, 52875);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_52849_52888(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52849, 52888);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1530_52849_52899(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52849, 52899);
                    return return_v;
                }


                int
                f_1530_52849_52947(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, string
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 52849, 52947);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_52966_52992(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52966, 52992);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_52966_53005(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52966, 53005);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1530_52966_53016(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 52966, 53016);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_53047_53066(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.OnRemove;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 53047, 53066);
                    return return_v;
                }


                int
                f_1530_52966_53067(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Management.Automation.ScriptBlock
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 52966, 53067);
                    return 0;
                }


                bool
                f_1530_53237_53274(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 53237, 53274);
                    return return_v;
                }


                int
                f_1530_53316_53370(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 53316, 53370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 46647, 53442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 46647, 53442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNonEmptyManifestField(Hashtable manifestData, string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1530, 53542, 54063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53646, 53679);

                object
                value = f_1530_53661_53678(manifestData, key)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53693, 53772) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 53693, 53772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53744, 53757);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 53693, 53772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53788, 53803);

                object[]
                array
                = default(object[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53817, 54052) || true) && (f_1530_53821_53900(value, f_1530_53860_53888(), out array))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 53817, 54052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 53934, 53959);

                    return f_1530_53941_53953(array) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 53817, 54052);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 53817, 54052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54025, 54037);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 53817, 54052);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1530, 53542, 54063);

                object
                f_1530_53661_53678(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 53661, 53678);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_53860_53888()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 53860, 53888);
                    return return_v;
                }


                bool
                f_1530_53821_53900(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out object[]
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 53821, 53900);
                    return return_v;
                }


                int
                f_1530_53941_53953(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 53941, 53953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 53542, 54063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 53542, 54063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsMixedModePsCimModule(RemoteDiscoveryHelper.CimModule cimModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 54075, 57011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54178, 54323);

                string
                temporaryModuleManifestPath = f_1530_54215_54322(f_1530_54251_54271(cimModule), null, string.Empty, f_1530_54293_54321(f_1530_54293_54305(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54337, 54366);

                bool
                containedErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54380, 54458);

                RemoteDiscoveryHelper.CimModuleFile
                mainManifestFile = f_1530_54435_54457(cimModule)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54472, 54561) || true) && (mainManifestFile == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 54472, 54561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54534, 54546);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 54472, 54561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54577, 54823);

                Hashtable
                manifestData = f_1530_54602_54822(mainManifestFile, temporaryModuleManifestPath, this, ref containedErrors)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54839, 54944) || true) && (containedErrors || (DynAbs.Tracing.TraceSender.Expression_False(1530, 54843, 54882) || manifestData == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 54839, 54944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54916, 54929);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 54839, 54944);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 54960, 55162) || true) && (f_1530_54964_55021(manifestData, "ScriptsToProcess") || (DynAbs.Tracing.TraceSender.Expression_False(1530, 54964, 55101) || f_1530_55042_55101(manifestData, "RequiredAssemblies")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 54960, 55162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55135, 55147);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 54960, 55162);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55178, 55205);

                int
                numberOfSubmodules = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55221, 55251);

                string[]
                nestedModules = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55265, 55558) || true) && (f_1530_55269_55380(f_1530_55301_55330(manifestData, "NestedModules"), f_1530_55332_55360(), out nestedModules))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55265, 55558);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55414, 55543) || true) && (nestedModules != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55414, 55543);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55481, 55524);

                        numberOfSubmodules += f_1530_55503_55523(nestedModules);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55414, 55543);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55265, 55558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55574, 55626);

                object
                rootModuleValue = f_1530_55599_55625(manifestData, "RootModule")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55640, 56572) || true) && (rootModuleValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55640, 56572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55701, 55719);

                    string
                    rootModule
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55737, 56030) || true) && (f_1530_55741_55835(rootModuleValue, f_1530_55790_55818(), out rootModule))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55737, 56030);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55877, 56011) || true) && (!f_1530_55882_55914(rootModule))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55877, 56011);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 55964, 55988);

                            numberOfSubmodules += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55877, 56011);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55737, 56030);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55640, 56572);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 55640, 56572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56096, 56158);

                    object
                    moduleToProcessValue = f_1530_56126_56157(manifestData, "ModuleToProcess")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56176, 56199);

                    string
                    moduleToProcess
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56217, 56557) || true) && (moduleToProcessValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 56221, 56357) && f_1530_56253_56357(moduleToProcessValue, f_1530_56307_56335(), out moduleToProcess)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 56217, 56557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56399, 56538) || true) && (!f_1530_56404_56441(moduleToProcess))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 56399, 56538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56491, 56515);

                            numberOfSubmodules += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 56399, 56538);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 56217, 56557);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 55640, 56572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56588, 56623);

                int
                numberOfCmdletizationFiles = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56637, 56862);
                    foreach (var moduleFile in f_1530_56664_56685_I(f_1530_56664_56685(cimModule)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 56637, 56862);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56719, 56847) || true) && (f_1530_56723_56742(moduleFile) == RemoteDiscoveryHelper.CimFileCode.CmdletizationV1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 56719, 56847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56818, 56847);

                            numberOfCmdletizationFiles++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 56719, 56847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 56637, 56862);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56878, 56956);

                bool
                isMixedModePsCimModule = numberOfSubmodules > numberOfCmdletizationFiles
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 56970, 57000);

                return isMixedModePsCimModule;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 54075, 57011);

                string
                f_1530_54251_54271(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 54251, 54271);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_54293_54305(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 54293, 54305);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1530_54293_54321(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 54293, 54321);
                    return return_v;
                }


                string
                f_1530_54215_54322(string
                remoteModuleName, System.Version
                remoteModuleVersion, string
                computerName, System.Management.Automation.Runspaces.Runspace
                localRunspace)
                {
                    var return_v = RemoteDiscoveryHelper.GetModulePath(remoteModuleName, remoteModuleVersion, computerName, localRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 54215, 54322);
                    return return_v;
                }


                System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                f_1530_54435_54457(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.MainManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 54435, 54457);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1530_54602_54822(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, string
                temporaryModuleManifestPath, Microsoft.PowerShell.Commands.ImportModuleCommand
                cmdlet, ref bool
                containedErrors)
                {
                    var return_v = RemoteDiscoveryHelper.ConvertCimModuleFileToManifestHashtable(cimModuleFile, temporaryModuleManifestPath, (Microsoft.PowerShell.Commands.ModuleCmdletBase)cmdlet, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 54602, 54822);
                    return return_v;
                }


                bool
                f_1530_54964_55021(System.Collections.Hashtable
                manifestData, string
                key)
                {
                    var return_v = IsNonEmptyManifestField(manifestData, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 54964, 55021);
                    return return_v;
                }


                bool
                f_1530_55042_55101(System.Collections.Hashtable
                manifestData, string
                key)
                {
                    var return_v = IsNonEmptyManifestField(manifestData, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 55042, 55101);
                    return return_v;
                }


                object
                f_1530_55301_55330(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 55301, 55330);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_55332_55360()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 55332, 55360);
                    return return_v;
                }


                bool
                f_1530_55269_55380(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out string[]
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 55269, 55380);
                    return return_v;
                }


                int
                f_1530_55503_55523(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 55503, 55523);
                    return return_v;
                }


                object
                f_1530_55599_55625(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 55599, 55625);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_55790_55818()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 55790, 55818);
                    return return_v;
                }


                bool
                f_1530_55741_55835(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 55741, 55835);
                    return return_v;
                }


                bool
                f_1530_55882_55914(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 55882, 55914);
                    return return_v;
                }


                object
                f_1530_56126_56157(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 56126, 56157);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_56307_56335()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 56307, 56335);
                    return return_v;
                }


                bool
                f_1530_56253_56357(object
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 56253, 56357);
                    return return_v;
                }


                bool
                f_1530_56404_56441(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 56404, 56441);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                f_1530_56664_56685(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 56664, 56685);
                    return return_v;
                }


                System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                f_1530_56723_56742(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 56723, 56742);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                f_1530_56664_56685_I(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 56664, 56685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 54075, 57011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 54075, 57011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ImportModule_RemotelyViaCimSession(
                    ImportModuleOptions importModuleOptions,
                    string[] moduleNames,
                    CimSession cimSession,
                    Uri resourceUri,
                    string cimNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 57023, 60110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 57364, 57699);

                IEnumerable<RemoteDiscoveryHelper.CimModule>
                remoteModules = f_1530_57425_57698(f_1530_57425_57689(cimSession, resourceUri, cimNamespace, moduleNames, false, this, f_1530_57666_57688(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 57715, 57839);

                IEnumerable<RemoteDiscoveryHelper.CimModule>
                remotePsCimModules = f_1530_57781_57838(remoteModules, cimModule => cimModule.IsPsCimModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 57853, 57998);

                IEnumerable<string>
                remotePsrpModuleNames = f_1530_57897_57997(f_1530_57897_57955(remoteModules, cimModule => !cimModule.IsPsCimModule), cimModule => cimModule.ModuleName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58012, 58606);
                    foreach (string psrpModuleName in f_1530_58046_58067_I(remotePsrpModuleNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 58012, 58606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58101, 58284);

                        string
                        errorMessage = f_1530_58123_58283(f_1530_58159_58187(), f_1530_58210_58245(), psrpModuleName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58302, 58544);

                        ErrorRecord
                        errorRecord = f_1530_58328_58543(f_1530_58366_58401(errorMessage), "PsModuleOverCimSessionError", ErrorCategory.InvalidArgument, psrpModuleName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58562, 58591);

                        f_1530_58562_58590(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 58012, 58606);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58717, 58824);

                IEnumerable<string>
                allFoundModuleNames = f_1530_58759_58823(f_1530_58759_58814(remoteModules, cimModule => cimModule.ModuleName))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58838, 59673);
                    foreach (string requestedModuleName in f_1530_58877_58888_I(moduleNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 58838, 59673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 58922, 59048);

                        var
                        wildcardPattern = f_1530_58944_59047(requestedModuleName, WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59066, 59182);

                        bool
                        requestedModuleWasFound = f_1530_59097_59181(allFoundModuleNames, foundModuleName => wildcardPattern.IsMatch(foundModuleName))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59200, 59658) || true) && (!requestedModuleWasFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 59200, 59658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59270, 59350);

                            string
                            message = f_1530_59287_59349(f_1530_59305_59327(), requestedModuleName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59372, 59435);

                            FileNotFoundException
                            fnf = f_1530_59400_59434(message)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59457, 59602);

                            ErrorRecord
                            er = f_1530_59474_59601(fnf, "Modules_ModuleNotFound", ErrorCategory.ResourceUnavailable, requestedModuleName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59624, 59639);

                            f_1530_59624_59638(this, er);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 59200, 59658);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 58838, 59673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 836);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59763, 60099);
                    foreach (RemoteDiscoveryHelper.CimModule remoteCimModule in f_1530_59823_59841_I(remotePsCimModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 59763, 60099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59875, 59963);

                        f_1530_59875_59962(this, importModuleOptions, remoteCimModule, cimSession);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 59981, 60084);

                        f_1530_59981_60083(TelemetryType.ModuleLoad, f_1530_60056_60082(remoteCimModule));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 59763, 60099);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 337);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 57023, 60110);

                System.Threading.CancellationToken
                f_1530_57666_57688(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 57666, 57688);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1530_57425_57689(Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace, string[]
                moduleNamePatterns, bool
                onlyManifests, Microsoft.PowerShell.Commands.ImportModuleCommand
                cmdlet, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = RemoteDiscoveryHelper.GetCimModules(cimSession, resourceUri, cimNamespace, (System.Collections.Generic.IEnumerable<string>)moduleNamePatterns, onlyManifests, (System.Management.Automation.Cmdlet)cmdlet, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 57425, 57689);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1530_57425_57698(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.RemoteDiscoveryHelper.CimModule>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 57425, 57698);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1530_57781_57838(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.RemoteDiscoveryHelper.CimModule>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 57781, 57838);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1530_57897_57955(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.RemoteDiscoveryHelper.CimModule>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 57897, 57955);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_57897_57997(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, string>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.RemoteDiscoveryHelper.CimModule, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 57897, 57997);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_58159_58187()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 58159, 58187);
                    return return_v;
                }


                string
                f_1530_58210_58245()
                {
                    var return_v = Modules.PsModuleOverCimSessionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 58210, 58245);
                    return return_v;
                }


                string
                f_1530_58123_58283(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58123, 58283);
                    return return_v;
                }


                System.ArgumentException
                f_1530_58366_58401(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58366, 58401);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_58328_58543(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58328, 58543);
                    return return_v;
                }


                int
                f_1530_58562_58590(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58562, 58590);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_58046_58067_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58046, 58067);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_58759_58814(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, string>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.RemoteDiscoveryHelper.CimModule, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58759, 58814);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_58759_58823(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58759, 58823);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1530_58944_59047(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58944, 59047);
                    return return_v;
                }


                bool
                f_1530_59097_59181(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Any<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59097, 59181);
                    return return_v;
                }


                string
                f_1530_59305_59327()
                {
                    var return_v = Modules.ModuleNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 59305, 59327);
                    return return_v;
                }


                string
                f_1530_59287_59349(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59287, 59349);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1530_59400_59434(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59400, 59434);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_59474_59601(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59474, 59601);
                    return return_v;
                }


                int
                f_1530_59624_59638(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59624, 59638);
                    return 0;
                }


                string[]
                f_1530_58877_58888_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 58877, 58888);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_59875_59962(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                remoteCimModule, Microsoft.Management.Infrastructure.CimSession
                cimSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaCimModuleData(importModuleOptions, remoteCimModule, cimSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59875, 59962);
                    return return_v;
                }


                string
                f_1530_60056_60082(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 60056, 60082);
                    return return_v;
                }


                int
                f_1530_59981_60083(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59981, 60083);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1530_59823_59841_I(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 59823, 59841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 57023, 60110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 57023, 60110);
            }
        }

        private bool IsPs1xmlFileHelper_IsPresentInEntries(RemoteDiscoveryHelper.CimModuleFile cimModuleFile, IEnumerable<string> manifestEntries)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 60122, 60728);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60285, 60446) || true) && (f_1530_60289_60385(manifestEntries, s => s.EndsWith(cimModuleFile.FileName, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 60285, 60446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60419, 60431);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 60285, 60446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60462, 60688) || true) && (f_1530_60466_60627(manifestEntries, s => FixupFileName(string.Empty, s, ".ps1xml", isImportingModule: true).EndsWith(cimModuleFile.FileName, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 60462, 60688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60661, 60673);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 60462, 60688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60704, 60717);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 60122, 60728);

                bool
                f_1530_60289_60385(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Any<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 60289, 60385);
                    return return_v;
                }


                bool
                f_1530_60466_60627(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Any<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 60466, 60627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 60122, 60728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 60122, 60728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPs1xmlFileHelper(RemoteDiscoveryHelper.CimModuleFile cimModuleFile, Hashtable manifestData, string goodKey, string badKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 60740, 62033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 60902, 61064) || true) && (!f_1530_60907_61002(f_1530_60907_60948(f_1530_60925_60947(cimModuleFile)), ".ps1xml", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 60902, 61064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61036, 61049);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 60902, 61064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61080, 61105);

                List<string>
                goodEntries
                = default(List<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61119, 61284) || true) && (!f_1530_61124_61202(this, manifestData, null, goodKey, 0, out goodEntries))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 61119, 61284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61236, 61269);

                    goodEntries = f_1530_61250_61268();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 61119, 61284);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61300, 61405) || true) && (goodEntries == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 61300, 61405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61357, 61390);

                    goodEntries = f_1530_61371_61389();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 61300, 61405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61421, 61445);

                List<string>
                badEntries
                = default(List<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61459, 61621) || true) && (!f_1530_61464_61540(this, manifestData, null, badKey, 0, out badEntries))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 61459, 61621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61574, 61606);

                    badEntries = f_1530_61587_61605();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 61459, 61621);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61637, 61740) || true) && (badEntries == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 61637, 61740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61693, 61725);

                    badEntries = f_1530_61706_61724();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 61637, 61740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61756, 61850);

                bool
                presentInGoodEntries = f_1530_61784_61849(this, cimModuleFile, goodEntries)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61864, 61956);

                bool
                presentInBadEntries = f_1530_61891_61955(this, cimModuleFile, badEntries)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 61970, 62022);

                return presentInGoodEntries && (DynAbs.Tracing.TraceSender.Expression_True(1530, 61977, 62021) && !presentInBadEntries);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 60740, 62033);

                string
                f_1530_60925_60947(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 60925, 60947);
                    return return_v;
                }


                string?
                f_1530_60907_60948(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 60907, 60948);
                    return return_v;
                }


                bool
                f_1530_60907_61002(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 60907, 61002);
                    return return_v;
                }


                bool
                f_1530_61124_61202(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, int
                manifestProcessingFlags, out System.Collections.Generic.List<string>
                list)
                {
                    var return_v = this_param.GetListOfStringsFromData(data, moduleManifestPath, key, (Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags)manifestProcessingFlags, out list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61124, 61202);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_61250_61268()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61250, 61268);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_61371_61389()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61371, 61389);
                    return return_v;
                }


                bool
                f_1530_61464_61540(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, int
                manifestProcessingFlags, out System.Collections.Generic.List<string>
                list)
                {
                    var return_v = this_param.GetListOfStringsFromData(data, moduleManifestPath, key, (Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags)manifestProcessingFlags, out list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61464, 61540);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_61587_61605()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61587, 61605);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_61706_61724()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61706, 61724);
                    return return_v;
                }


                bool
                f_1530_61784_61849(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, System.Collections.Generic.List<string>
                manifestEntries)
                {
                    var return_v = this_param.IsPs1xmlFileHelper_IsPresentInEntries(cimModuleFile, (System.Collections.Generic.IEnumerable<string>)manifestEntries);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61784, 61849);
                    return return_v;
                }


                bool
                f_1530_61891_61955(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, System.Collections.Generic.List<string>
                manifestEntries)
                {
                    var return_v = this_param.IsPs1xmlFileHelper_IsPresentInEntries(cimModuleFile, (System.Collections.Generic.IEnumerable<string>)manifestEntries);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 61891, 61955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 60740, 62033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 60740, 62033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsTypesPs1XmlFile(RemoteDiscoveryHelper.CimModuleFile cimModuleFile, Hashtable manifestData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 62045, 62296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 62175, 62285);

                return f_1530_62182_62284(this, cimModuleFile, manifestData, goodKey: "TypesToProcess", badKey: "FormatsToProcess");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 62045, 62296);

                bool
                f_1530_62182_62284(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, System.Collections.Hashtable
                manifestData, string
                goodKey, string
                badKey)
                {
                    var return_v = this_param.IsPs1xmlFileHelper(cimModuleFile, manifestData, goodKey: goodKey, badKey: badKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 62182, 62284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 62045, 62296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 62045, 62296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsFormatPs1XmlFile(RemoteDiscoveryHelper.CimModuleFile cimModuleFile, Hashtable manifestData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 62308, 62560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 62439, 62549);

                return f_1530_62446_62548(this, cimModuleFile, manifestData, goodKey: "FormatsToProcess", badKey: "TypesToProcess");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 62308, 62560);

                bool
                f_1530_62446_62548(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, System.Collections.Hashtable
                manifestData, string
                goodKey, string
                badKey)
                {
                    var return_v = this_param.IsPs1xmlFileHelper(cimModuleFile, manifestData, goodKey: goodKey, badKey: badKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 62446, 62548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 62308, 62560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 62308, 62560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCmdletizationFile(RemoteDiscoveryHelper.CimModuleFile cimModuleFile)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1530, 62572, 62781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 62687, 62770);

                return f_1530_62694_62716(cimModuleFile) == RemoteDiscoveryHelper.CimFileCode.CmdletizationV1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1530, 62572, 62781);

                System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                f_1530_62694_62716(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 62694, 62716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 62572, 62781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 62572, 62781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> CreateCimModuleFiles(
                    RemoteDiscoveryHelper.CimModule remoteCimModule,
                    RemoteDiscoveryHelper.CimFileCode fileCode,
                    Func<RemoteDiscoveryHelper.CimModuleFile, bool> filesFilter,
                    string temporaryModuleDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 62793, 64896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63106, 63137);

                string
                fileNameTemplate = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63151, 63792);

                switch (fileCode)
                {

                    case RemoteDiscoveryHelper.CimFileCode.CmdletizationV1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63151, 63792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63278, 63313);

                        fileNameTemplate = "{0}_{1}.cdxml";
                        DynAbs.Tracing.TraceSender.TraceBreak(1530, 63335, 63341);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63151, 63792);

                    case RemoteDiscoveryHelper.CimFileCode.TypesV1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63151, 63792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63428, 63470);

                        fileNameTemplate = "{0}_{1}.types.ps1xml";
                        DynAbs.Tracing.TraceSender.TraceBreak(1530, 63492, 63498);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63151, 63792);

                    case RemoteDiscoveryHelper.CimFileCode.FormatV1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63151, 63792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63586, 63629);

                        fileNameTemplate = "{0}_{1}.format.ps1xml";
                        DynAbs.Tracing.TraceSender.TraceBreak(1530, 63651, 63657);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63151, 63792);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63151, 63792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63705, 63749);

                        f_1530_63705_63748(false, "Unrecognized file code");
                        DynAbs.Tracing.TraceSender.TraceBreak(1530, 63771, 63777);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63151, 63792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63808, 63870);

                List<string>
                relativePathsToCreatedFiles = f_1530_63851_63869()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63884, 64834);
                    foreach (RemoteDiscoveryHelper.CimModuleFile file in f_1530_63937_63964_I(f_1530_63937_63964(remoteCimModule)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63884, 64834);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 63998, 64090) || true) && (!f_1530_64003_64020(filesFilter, file))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 63998, 64090);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64062, 64071);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63998, 64090);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64110, 64168);

                        string
                        originalFileName = f_1530_64136_64167(f_1530_64153_64166(file))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64186, 64447);

                        string
                        fileName = f_1530_64204_64446(f_1530_64240_64268(), fileNameTemplate, f_1530_64330_64398(originalFileName, 0, f_1530_64360_64397(f_1530_64369_64392(originalFileName), 20)), f_1530_64421_64445())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64465, 64507);

                        f_1530_64465_64506(relativePathsToCreatedFiles, fileName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64527, 64594);

                        string
                        fullPath = f_1530_64545_64593(temporaryModuleDirectory, fileName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64612, 64702);

                        f_1530_64612_64701(fullPath, f_1530_64684_64700(file));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64733, 64811);

                        f_1530_64733_64810(fullPath, SecurityZone.Intranet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 63884, 64834);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 64850, 64885);

                return relativePathsToCreatedFiles;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 62793, 64896);

                int
                f_1530_63705_63748(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 63705, 63748);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1530_63851_63869()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 63851, 63869);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                f_1530_63937_63964(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 63937, 63964);
                    return return_v;
                }


                bool
                f_1530_64003_64020(System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile, bool>
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64003, 64020);
                    return return_v;
                }


                string
                f_1530_64153_64166(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 64153, 64166);
                    return return_v;
                }


                string?
                f_1530_64136_64167(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64136, 64167);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_64240_64268()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 64240, 64268);
                    return return_v;
                }


                int
                f_1530_64369_64392(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 64369, 64392);
                    return return_v;
                }


                int
                f_1530_64360_64397(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64360, 64397);
                    return return_v;
                }


                string
                f_1530_64330_64398(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64330, 64398);
                    return return_v;
                }


                string
                f_1530_64421_64445()
                {
                    var return_v = Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64421, 64445);
                    return return_v;
                }


                string
                f_1530_64204_64446(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64204, 64446);
                    return return_v;
                }


                int
                f_1530_64465_64506(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64465, 64506);
                    return 0;
                }


                string
                f_1530_64545_64593(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64545, 64593);
                    return return_v;
                }


                byte[]
                f_1530_64684_64700(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.RawFileData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 64684, 64700);
                    return return_v;
                }


                int
                f_1530_64612_64701(string
                path, byte[]
                bytes)
                {
                    File.WriteAllBytes(path, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64612, 64701);
                    return 0;
                }


                int
                f_1530_64733_64810(string
                path, System.Security.SecurityZone
                securityZone)
                {
                    AlternateDataStreamUtilities.SetZoneOfOrigin(path, securityZone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 64733, 64810);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                f_1530_63937_63964_I(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 63937, 63964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 62793, 64896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 62793, 64896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo ImportModule_RemotelyViaCimModuleData(
                    ImportModuleOptions importModuleOptions,
                    RemoteDiscoveryHelper.CimModule remoteCimModule,
                    CimSession cimSession)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 64908, 77542);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65180, 65632) || true) && (f_1530_65184_65212(remoteCimModule) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 65180, 65632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65262, 65471);

                        string
                        errorMessage = f_1530_65284_65470(f_1530_65324_65352(), f_1530_65379_65406(), f_1530_65433_65459(remoteCimModule) + ".psd1")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65493, 65567);

                        ArgumentException
                        argumentException = f_1530_65531_65566(errorMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65589, 65613);

                        throw argumentException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 65180, 65632);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65652, 65681);

                    bool
                    containedErrors = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65699, 65730);

                    PSModuleInfo
                    moduleInfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 65837, 66081);

                    string
                    temporaryModuleDirectory = f_1530_65871_66080(f_1530_65929_65955(remoteCimModule), null, f_1530_66005_66028(cimSession), f_1530_66051_66079(f_1530_66051_66063(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66099, 66256);

                    string
                    temporaryModuleManifestPath = f_1530_66136_66255(temporaryModuleDirectory, f_1530_66218_66244(remoteCimModule) + ".psd1")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66276, 66298);

                    Hashtable
                    data = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66316, 66347);

                    Hashtable
                    localizedData = null
                    ;
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66388, 66425);

                        ScriptBlockAst
                        scriptBlockAst = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66447, 66471);

                        Token[]
                        throwAwayTokens
                        = default(Token[]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66493, 66518);

                        ParseError[]
                        parseErrors
                        = default(ParseError[]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66540, 66782);

                        scriptBlockAst = f_1530_66557_66781(f_1530_66601_66638(f_1530_66601_66629(remoteCimModule)), temporaryModuleManifestPath, out throwAwayTokens, out parseErrors);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66804, 67019) || true) && ((scriptBlockAst == null) || (DynAbs.Tracing.TraceSender.Expression_False(1530, 66808, 66908) || (parseErrors != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 66862, 66907) && f_1530_66885_66903(parseErrors) > 0))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 66804, 67019);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 66958, 66996);

                            throw f_1530_66964_66995(parseErrors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 66804, 67019);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67043, 67118);

                        ScriptBlock
                        scriptBlock = f_1530_67069_67117(scriptBlockAst, isFilter: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67140, 67490);

                        data = f_1530_67147_67489(this, temporaryModuleManifestPath, scriptBlock, ModuleManifestMembers, ManifestProcessingFlags.NullOnFirstError | ManifestProcessingFlags.WriteErrors, ref containedErrors);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67514, 67636) || true) && ((data == null) || (DynAbs.Tracing.TraceSender.Expression_False(1530, 67518, 67551) || containedErrors))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 67514, 67636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67601, 67613);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 67514, 67636);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67660, 67681);

                        localizedData = data;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 67970, 67992);

                    Version
                    moduleVersion
                    = default(Version);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68010, 68174) || true) && (!f_1530_68015_68092(this, data, null, "ModuleVersion", 0, out moduleVersion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 68010, 68174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68134, 68155);

                        moduleVersion = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 68010, 68174);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68194, 68440);

                    temporaryModuleDirectory = f_1530_68221_68439(f_1530_68279_68305(remoteCimModule), moduleVersion, f_1530_68364_68387(cimSession), f_1530_68410_68438(f_1530_68410_68422(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68458, 68608);

                    temporaryModuleManifestPath = f_1530_68488_68607(temporaryModuleDirectory, f_1530_68570_68596(remoteCimModule) + ".psd1");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68685, 68870);

                    PSModuleInfo
                    alreadyImportedModule = f_1530_68722_68869(this, temporaryModuleManifestPath, f_1530_68832_68847(this), importModuleOptions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68888, 69011) || true) && (alreadyImportedModule != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 68888, 69011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 68963, 68992);

                        return alreadyImportedModule;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 68888, 69011);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 69075, 69127);

                        f_1530_69075_69126(temporaryModuleDirectory);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 69151, 69453);

                        IEnumerable<string>
                        typesToProcess = f_1530_69188_69452(this, remoteCimModule, RemoteDiscoveryHelper.CimFileCode.TypesV1, cimModuleFile => IsTypesPs1XmlFile(cimModuleFile, data), temporaryModuleDirectory)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 69475, 69781);

                        IEnumerable<string>
                        formatsToProcess = f_1530_69514_69780(this, remoteCimModule, RemoteDiscoveryHelper.CimFileCode.FormatV1, cimModuleFile => IsFormatPs1XmlFile(cimModuleFile, data), temporaryModuleDirectory)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 69803, 70076);

                        IEnumerable<string>
                        nestedModules = f_1530_69839_70075(this, remoteCimModule, RemoteDiscoveryHelper.CimFileCode.CmdletizationV1, IsCmdletizationFile, temporaryModuleDirectory)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 70098, 70348);

                        data = f_1530_70105_70347(data, nestedModules: nestedModules, typesToProcess: typesToProcess, formatsToProcess: formatsToProcess);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 70370, 70439);

                        localizedData = f_1530_70386_70438(localizedData);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 70732, 71346);

                        moduleInfo = f_1530_70745_71345(this, temporaryModuleManifestPath, null, data, localizedData, ManifestProcessingFlags.LoadElements | ManifestProcessingFlags.WriteErrors | ManifestProcessingFlags.NullOnFirstError, f_1530_71104_71122(), f_1530_71149_71167(), f_1530_71194_71213(), f_1530_71240_71248(), ref importModuleOptions, ref containedErrors);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71368, 71475) || true) && (moduleInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 71368, 71475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71440, 71452);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 71368, 71475);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71499, 72947);
                            foreach (PSModuleInfo nestedModule in f_1530_71537_71561_I(f_1530_71537_71561(moduleInfo)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 71499, 72947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71611, 71630);

                                Type
                                cmdletAdapter
                                = default(Type);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71656, 71929);

                                bool
                                gotCmdletAdapter = f_1530_71680_71928(f_1530_71743_71767(nestedModule) as IDictionary, out cmdletAdapter, "CmdletsOverObjects", "CmdletAdapter")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 71955, 72047);

                                f_1530_71955_72046(gotCmdletAdapter, "PrivateData from cdxml should always include cmdlet adapter");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 72073, 72924) || true) && (!f_1530_72078_72193(f_1530_72078_72113(cmdletAdapter), StringLiterals.DefaultCmdletAdapter, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 72073, 72924);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 72251, 72507);

                                    string
                                    errorMessage = f_1530_72273_72506(f_1530_72321_72349(), f_1530_72384_72448(), f_1530_72483_72505(cmdletAdapter))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 72537, 72827);

                                    ErrorRecord
                                    errorRecord = f_1530_72563_72826(f_1530_72613_72656(errorMessage), "UnsupportedCmdletAdapter", ErrorCategory.InvalidData, cmdletAdapter)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 72857, 72897);

                                    f_1530_72857_72896(this, errorRecord);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 72073, 72924);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 71499, 72947);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 1449);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 1449);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 72971, 73448) || true) && (f_1530_72975_73014(this, remoteCimModule))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 72971, 73448);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 73139, 73365);

                            string
                            warningMessage = f_1530_73163_73364(f_1530_73207_73235(), f_1530_73266_73306(), f_1530_73337_73363(remoteCimModule))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 73391, 73425);

                            f_1530_73391_73424(this, warningMessage);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 72971, 73448);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 73570, 73689);

                        f_1530_73570_73688(f_1530_73581_73602(moduleInfo) == ModuleType.Manifest, "Remote discovery should always produce a 'manifest' module");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 73711, 73844);

                        f_1530_73711_73843(f_1530_73722_73746(moduleInfo) != null, "Remote discovery should always produce a 'manifest' module with nested modules entry");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 73866, 74000);

                        f_1530_73866_73999(f_1530_73877_73907(f_1530_73877_73901(moduleInfo)) > 0, "Remote discovery should always produce a 'manifest' module with some nested modules");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74022, 74777);
                            foreach (PSModuleInfo nestedModule in f_1530_74060_74084_I(f_1530_74060_74084(moduleInfo)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 74022, 74777);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74134, 74176);

                                IDictionary
                                cmdletsOverObjectsPrivateData
                                = default(IDictionary);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74202, 74505);

                                bool
                                cmdletsOverObjectsPrivateDataWasFound = f_1530_74247_74504(f_1530_74323_74347(nestedModule) as IDictionary, out cmdletsOverObjectsPrivateData, ScriptWriter.PrivateDataKey_CmdletsOverObjects)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74531, 74641);

                                f_1530_74531_74640(cmdletsOverObjectsPrivateDataWasFound, "Cmdletization should always set the PrivateData properly");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74667, 74754);

                                cmdletsOverObjectsPrivateData[ScriptWriter.PrivateDataKey_DefaultSession] = cimSession;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 74022, 74777);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 756);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 756);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 74944, 75487);

                        const string
                        onRemoveScriptBody =
                                                @"
                        Microsoft.PowerShell.Management\Remove-Item `
                            -LiteralPath $temporaryModulePath `
                            -Force `
                            -Recurse `
                            -ErrorAction SilentlyContinue

                        if ($null -ne $previousOnRemoveScript)
                        {
                            & $previousOnRemoveScript $args
                        }
                        "
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 75509, 75607);

                        ScriptBlock
                        onRemoveScriptBlock = f_1530_75543_75606(f_1530_75543_75562(f_1530_75543_75555(this)), onRemoveScriptBody, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 75629, 75687);

                        onRemoveScriptBlock = f_1530_75651_75686(onRemoveScriptBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 75781, 75885);

                        f_1530_75781_75884(f_1530_75781_75831(f_1530_75781_75820(f_1530_75781_75807(onRemoveScriptBlock))), "temporaryModulePath", temporaryModuleDirectory);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 75907, 76009);

                        f_1530_75907_76008(f_1530_75907_75957(f_1530_75907_75946(f_1530_75907_75933(onRemoveScriptBlock))), "previousOnRemoveScript", f_1530_75988_76007(moduleInfo));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76031, 76073);

                        moduleInfo.OnRemove = onRemoveScriptBlock;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76221, 76381);

                        f_1530_76221_76380(f_1530_76271_76283(this), f_1530_76310_76342(f_1530_76310_76333(this)), moduleInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76403, 76516) || true) && (f_1530_76407_76419())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 76403, 76516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76469, 76493);

                            f_1530_76469_76492(this, moduleInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 76403, 76516);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76540, 76558);

                        return moduleInfo;
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 76595, 76869);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76641, 76820) || true) && (f_1530_76645_76687(temporaryModuleDirectory))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 76641, 76820);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76737, 76797);

                            f_1530_76737_76796(temporaryModuleDirectory, recursive: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 76641, 76820);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76844, 76850);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 76595, 76869);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1530, 76887, 77240);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 76935, 77221) || true) && (moduleInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 76935, 77221);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77007, 77198) || true) && (f_1530_77011_77053(temporaryModuleDirectory))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 77007, 77198);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77111, 77171);

                                f_1530_77111_77170(temporaryModuleDirectory, recursive: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 77007, 77198);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 76935, 77221);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1530, 76887, 77240);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1530, 77269, 77531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77321, 77439);

                    ErrorRecord
                    errorRecord = f_1530_77347_77438(e, f_1530_77411_77437(remoteCimModule))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77457, 77486);

                    f_1530_77457_77485(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77504, 77516);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1530, 77269, 77531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 64908, 77542);

                System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                f_1530_65184_65212(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.MainManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 65184, 65212);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_65324_65352()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 65324, 65352);
                    return return_v;
                }


                string
                f_1530_65379_65406()
                {
                    var return_v = Modules.EmptyModuleManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 65379, 65406);
                    return return_v;
                }


                string
                f_1530_65433_65459(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 65433, 65459);
                    return return_v;
                }


                string
                f_1530_65284_65470(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 65284, 65470);
                    return return_v;
                }


                System.ArgumentException
                f_1530_65531_65566(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 65531, 65566);
                    return return_v;
                }


                string
                f_1530_65929_65955(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 65929, 65955);
                    return return_v;
                }


                string
                f_1530_66005_66028(Microsoft.Management.Infrastructure.CimSession
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66005, 66028);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_66051_66063(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66051, 66063);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1530_66051_66079(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66051, 66079);
                    return return_v;
                }


                string
                f_1530_65871_66080(string
                remoteModuleName, System.Version
                remoteModuleVersion, string
                computerName, System.Management.Automation.Runspaces.Runspace
                localRunspace)
                {
                    var return_v = RemoteDiscoveryHelper.GetModulePath(remoteModuleName, remoteModuleVersion, computerName, localRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 65871, 66080);
                    return return_v;
                }


                string
                f_1530_66218_66244(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66218, 66244);
                    return return_v;
                }


                string
                f_1530_66136_66255(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 66136, 66255);
                    return return_v;
                }


                System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                f_1530_66601_66629(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.MainManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66601, 66629);
                    return return_v;
                }


                string
                f_1530_66601_66638(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                this_param)
                {
                    var return_v = this_param.FileData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66601, 66638);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1530_66557_66781(string
                input, string
                fileName, out System.Management.Automation.Language.Token[]
                tokens, out System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = Parser.ParseInput(input, fileName, out tokens, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 66557, 66781);
                    return return_v;
                }


                int
                f_1530_66885_66903(System.Management.Automation.Language.ParseError[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 66885, 66903);
                    return return_v;
                }


                System.Management.Automation.ParseException
                f_1530_66964_66995(System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = new System.Management.Automation.ParseException(errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 66964, 66995);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_67069_67117(System.Management.Automation.Language.ScriptBlockAst
                ast, bool
                isFilter)
                {
                    var return_v = new System.Management.Automation.ScriptBlock((System.Management.Automation.Language.IParameterMetadataProvider)ast, isFilter: isFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 67069, 67117);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1530_67147_67489(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleManifestPath, System.Management.Automation.ScriptBlock
                scriptBlock, string[]
                validMembers, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, ref bool
                containedErrors)
                {
                    var return_v = this_param.LoadModuleManifestData(moduleManifestPath, scriptBlock, validMembers, manifestProcessingFlags, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 67147, 67489);
                    return return_v;
                }


                bool
                f_1530_68015_68092(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Collections.Hashtable
                data, string
                moduleManifestPath, string
                key, int
                manifestProcessingFlags, out System.Version
                result)
                {
                    var return_v = this_param.GetScalarFromData<System.Version>(data, moduleManifestPath, key, (Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags)manifestProcessingFlags, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 68015, 68092);
                    return return_v;
                }


                string
                f_1530_68279_68305(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68279, 68305);
                    return return_v;
                }


                string
                f_1530_68364_68387(Microsoft.Management.Infrastructure.CimSession
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68364, 68387);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_68410_68422(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68410, 68422);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1530_68410_68438(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68410, 68438);
                    return return_v;
                }


                string
                f_1530_68221_68439(string
                remoteModuleName, System.Version
                remoteModuleVersion, string
                computerName, System.Management.Automation.Runspaces.Runspace
                localRunspace)
                {
                    var return_v = RemoteDiscoveryHelper.GetModulePath(remoteModuleName, remoteModuleVersion, computerName, localRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 68221, 68439);
                    return return_v;
                }


                string
                f_1530_68570_68596(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68570, 68596);
                    return return_v;
                }


                string
                f_1530_68488_68607(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 68488, 68607);
                    return return_v;
                }


                string
                f_1530_68832_68847(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.BasePrefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 68832, 68847);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_68722_68869(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                modulePath, string
                prefix, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options)
                {
                    var return_v = this_param.IsModuleImportUnnecessaryBecauseModuleIsAlreadyLoaded(modulePath, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 68722, 68869);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1530_69075_69126(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 69075, 69126);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_69188_69452(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                remoteCimModule, System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                fileCode, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile, bool>
                filesFilter, string
                temporaryModuleDirectory)
                {
                    var return_v = this_param.CreateCimModuleFiles(remoteCimModule, fileCode, filesFilter, temporaryModuleDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 69188, 69452);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_69514_69780(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                remoteCimModule, System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                fileCode, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile, bool>
                filesFilter, string
                temporaryModuleDirectory)
                {
                    var return_v = this_param.CreateCimModuleFiles(remoteCimModule, fileCode, filesFilter, temporaryModuleDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 69514, 69780);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1530_69839_70075(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                remoteCimModule, System.Management.Automation.RemoteDiscoveryHelper.CimFileCode
                fileCode, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile, bool>
                filesFilter, string
                temporaryModuleDirectory)
                {
                    var return_v = this_param.CreateCimModuleFiles(remoteCimModule, fileCode, filesFilter, temporaryModuleDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 69839, 70075);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1530_70105_70347(System.Collections.Hashtable
                originalManifest, System.Collections.Generic.IEnumerable<string>
                nestedModules, System.Collections.Generic.IEnumerable<string>
                typesToProcess, System.Collections.Generic.IEnumerable<string>
                formatsToProcess)
                {
                    var return_v = RemoteDiscoveryHelper.RewriteManifest(originalManifest, nestedModules: nestedModules, typesToProcess: typesToProcess, formatsToProcess: formatsToProcess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 70105, 70347);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1530_70386_70438(System.Collections.Hashtable
                originalManifest)
                {
                    var return_v = RemoteDiscoveryHelper.RewriteManifest(originalManifest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 70386, 70438);
                    return return_v;
                }


                System.Version
                f_1530_71104_71122()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71104, 71122);
                    return return_v;
                }


                System.Version
                f_1530_71149_71167()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71149, 71167);
                    return return_v;
                }


                System.Version
                f_1530_71194_71213()
                {
                    var return_v = BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71194, 71213);
                    return return_v;
                }


                System.Guid?
                f_1530_71240_71248()
                {
                    var return_v = BaseGuid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71240, 71248);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_70745_71345(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleManifestPath, System.Management.Automation.ExternalScriptInfo
                manifestScriptInfo, System.Collections.Hashtable
                data, System.Collections.Hashtable
                localizedData, Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags
                manifestProcessingFlags, System.Version
                minimumVersion, System.Version
                maximumVersion, System.Version
                requiredVersion, System.Guid?
                requiredModuleGuid, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, ref bool
                containedErrors)
                {
                    var return_v = this_param.LoadModuleManifest(moduleManifestPath, manifestScriptInfo, data, localizedData, manifestProcessingFlags, minimumVersion, maximumVersion, requiredVersion, requiredModuleGuid, ref options, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 70745, 71345);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_71537_71561(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71537, 71561);
                    return return_v;
                }


                object
                f_1530_71743_71767(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 71743, 71767);
                    return return_v;
                }


                bool
                f_1530_71680_71928(object
                data, out System.Type
                result, params string[]
                keys)
                {
                    var return_v = PSPrimitiveDictionary.TryPathGet((System.Collections.IDictionary)data, out result, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 71680, 71928);
                    return return_v;
                }


                int
                f_1530_71955_72046(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 71955, 72046);
                    return 0;
                }


                string
                f_1530_72078_72113(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 72078, 72113);
                    return return_v;
                }


                bool
                f_1530_72078_72193(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72078, 72193);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_72321_72349()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 72321, 72349);
                    return return_v;
                }


                string
                f_1530_72384_72448()
                {
                    var return_v = CmdletizationCoreResources.ImportModule_UnsupportedCmdletAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 72384, 72448);
                    return return_v;
                }


                string
                f_1530_72483_72505(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 72483, 72505);
                    return return_v;
                }


                string
                f_1530_72273_72506(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72273, 72506);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_72613_72656(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72613, 72656);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_72563_72826(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Type
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72563, 72826);
                    return return_v;
                }


                int
                f_1530_72857_72896(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72857, 72896);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_71537_71561_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 71537, 71561);
                    return return_v;
                }


                bool
                f_1530_72975_73014(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                cimModule)
                {
                    var return_v = this_param.IsMixedModePsCimModule(cimModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 72975, 73014);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_73207_73235()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73207, 73235);
                    return return_v;
                }


                string
                f_1530_73266_73306()
                {
                    var return_v = Modules.MixedModuleOverCimSessionWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73266, 73306);
                    return return_v;
                }


                string
                f_1530_73337_73363(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73337, 73363);
                    return return_v;
                }


                string
                f_1530_73163_73364(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 73163, 73364);
                    return return_v;
                }


                int
                f_1530_73391_73424(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 73391, 73424);
                    return 0;
                }


                System.Management.Automation.ModuleType
                f_1530_73581_73602(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ModuleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73581, 73602);
                    return return_v;
                }


                int
                f_1530_73570_73688(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 73570, 73688);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_73722_73746(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73722, 73746);
                    return return_v;
                }


                int
                f_1530_73711_73843(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 73711, 73843);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_73877_73901(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73877, 73901);
                    return return_v;
                }


                int
                f_1530_73877_73907(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 73877, 73907);
                    return return_v;
                }


                int
                f_1530_73866_73999(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 73866, 73999);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_74060_74084(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 74060, 74084);
                    return return_v;
                }


                object
                f_1530_74323_74347(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.PrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 74323, 74347);
                    return return_v;
                }


                bool
                f_1530_74247_74504(object
                data, out System.Collections.IDictionary
                result, params string[]
                keys)
                {
                    var return_v = PSPrimitiveDictionary.TryPathGet<IDictionary>((System.Collections.IDictionary)data, out result, keys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 74247, 74504);
                    return return_v;
                }


                int
                f_1530_74531_74640(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 74531, 74640);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_74060_74084_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 74060, 74084);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1530_75543_75555(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75543, 75555);
                    return return_v;
                }


                System.Management.Automation.AutomationEngine
                f_1530_75543_75562(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Engine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75543, 75562);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_75543_75606(System.Management.Automation.AutomationEngine
                this_param, string
                script, bool
                addToHistory)
                {
                    var return_v = this_param.ParseScriptBlock(script, addToHistory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 75543, 75606);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_75651_75686(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.GetNewClosure();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 75651, 75686);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_75781_75807(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75781, 75807);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_75781_75820(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75781, 75820);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1530_75781_75831(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75781, 75831);
                    return return_v;
                }


                int
                f_1530_75781_75884(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, string
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 75781, 75884);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_75907_75933(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75907, 75933);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_75907_75946(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75907, 75946);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1530_75907_75957(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75907, 75957);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1530_75988_76007(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.OnRemove;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 75988, 76007);
                    return return_v;
                }


                int
                f_1530_75907_76008(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Management.Automation.ScriptBlock
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 75907, 76008);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1530_76271_76283(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 76271, 76283);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_76310_76333(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.TargetSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 76310, 76333);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_76310_76342(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 76310, 76342);
                    return return_v;
                }


                int
                f_1530_76221_76380(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionStateInternal
                targetSessionState, System.Management.Automation.PSModuleInfo
                module)
                {
                    AddModuleToModuleTables(context, targetSessionState, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 76221, 76380);
                    return 0;
                }


                bool
                f_1530_76407_76419()
                {
                    var return_v = BasePassThru;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 76407, 76419);
                    return return_v;
                }


                int
                f_1530_76469_76492(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 76469, 76492);
                    return 0;
                }


                bool
                f_1530_76645_76687(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 76645, 76687);
                    return return_v;
                }


                int
                f_1530_76737_76796(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 76737, 76796);
                    return 0;
                }


                bool
                f_1530_77011_77053(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 77011, 77053);
                    return return_v;
                }


                int
                f_1530_77111_77170(string
                path, bool
                recursive)
                {
                    Directory.Delete(path, recursive: recursive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 77111, 77170);
                    return 0;
                }


                string
                f_1530_77411_77437(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 77411, 77437);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_77347_77438(System.Exception
                innerException, string
                moduleName)
                {
                    var return_v = RemoteDiscoveryHelper.GetErrorRecordForProcessingOfCimModule(innerException, moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 77347, 77438);
                    return return_v;
                }


                int
                f_1530_77457_77485(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 77457, 77485);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 64908, 77542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 64908, 77542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly CancellationTokenSource _cancellationTokenSource;

        private CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 77852, 77941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 77888, 77926);

                    return f_1530_77895_77925(_cancellationTokenSource);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 77852, 77941);

                    System.Threading.CancellationToken
                    f_1530_77895_77925(System.Threading.CancellationTokenSource
                    this_param)
                    {
                        var return_v = this_param.Token;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 77895, 77925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 77784, 77952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 77784, 77952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 78281, 78391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78346, 78380);

                f_1530_78346_78379(_cancellationTokenSource);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 78281, 78391);

                int
                f_1530_78346_78379(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 78346, 78379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 78281, 78391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 78281, 78391);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 78572, 78688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78618, 78637);

                f_1530_78618_78636(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78651, 78677);

                f_1530_78651_78676(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 78572, 78688);

                int
                f_1530_78618_78636(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 78618, 78636);
                    return 0;
                }


                int
                f_1530_78651_78676(Microsoft.PowerShell.Commands.ImportModuleCommand
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 78651, 78676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 78572, 78688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 78572, 78688);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 78808, 79095);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78869, 78938) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 78869, 78938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78916, 78923);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 78869, 78938);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 78954, 79051) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 78954, 79051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79001, 79036);

                    f_1530_79001_79035(_cancellationTokenSource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 78954, 79051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79067, 79084);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 78808, 79095);

                int
                f_1530_79001_79035(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79001, 79035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 78808, 79095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 78808, 79095);
            }
        }

        private bool _disposed;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 79250, 80053);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79389, 79847) || true) && (f_1530_79393_79399().IsPresent && (DynAbs.Tracing.TraceSender.Expression_True(1530, 79393, 79430) && _isScopeSpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 79389, 79847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79464, 79584);

                    InvalidOperationException
                    ioe = f_1530_79496_79583(f_1530_79526_79582())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79602, 79788);

                    ErrorRecord
                    er = f_1530_79619_79787(ioe, "Modules_GlobalAndScopeParameterCannotBeSpecifiedTogether", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79806, 79832);

                    f_1530_79806_79831(this, er);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 79389, 79847);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 79863, 80042) || true) && (!f_1530_79868_79895(f_1530_79889_79894()) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 79867, 79970) && f_1530_79899_79970(f_1530_79899_79904(), StringLiterals.Global, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 79863, 80042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 80004, 80027);

                    base.BaseGlobal = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 79863, 80042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 79250, 80053);

                System.Management.Automation.SwitchParameter
                f_1530_79393_79399()
                {
                    var return_v = Global;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 79393, 79399);
                    return return_v;
                }


                string
                f_1530_79526_79582()
                {
                    var return_v = Modules.GlobalAndScopeParameterCannotBeSpecifiedTogether;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 79526, 79582);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_79496_79583(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79496, 79583);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_79619_79787(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79619, 79787);
                    return return_v;
                }


                int
                f_1530_79806_79831(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79806, 79831);
                    return 0;
                }


                string
                f_1530_79889_79894()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 79889, 79894);
                    return return_v;
                }


                bool
                f_1530_79868_79895(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79868, 79895);
                    return return_v;
                }


                string
                f_1530_79899_79904()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 79899, 79904);
                    return return_v;
                }


                bool
                f_1530_79899_79970(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 79899, 79970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 79250, 80053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 79250, 80053);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 80998, 86250);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81062, 81409) || true) && (f_1530_81066_81084() != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 81066, 81122) && f_1530_81096_81114() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 81066, 81165) && f_1530_81126_81144() < f_1530_81147_81165()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 81062, 81409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81199, 81327);

                    string
                    message = f_1530_81216_81326(f_1530_81234_81285(), f_1530_81287_81305(), f_1530_81307_81325())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81345, 81394);

                    throw f_1530_81351_81393(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 81062, 81409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81425, 81493);

                ImportModuleOptions
                importModuleOptions = f_1530_81467_81492()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81507, 81549);

                importModuleOptions.NoClobber = f_1530_81539_81548();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81563, 81751) || true) && (!f_1530_81568_81595(f_1530_81589_81594()) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 81567, 81669) && f_1530_81599_81669(f_1530_81599_81604(), StringLiterals.Local, StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 81563, 81751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81703, 81736);

                    importModuleOptions.Local = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 81563, 81751);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 81767, 86239) || true) && (f_1530_81771_81860(f_1530_81771_81792(this), ParameterSet_ModuleInfo, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 81767, 86239);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 82058, 83346);
                        foreach (PSModuleInfo module in f_1530_82090_82100_I(f_1530_82090_82100()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 82058, 83346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 82142, 82230);

                            f_1530_82142_82229(TelemetryType.ModuleLoad, f_1530_82217_82228(module));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 82252, 83327);

                            f_1530_82252_83326(module, localAction: delegate ()
                                                                     {
                                                                         ImportModule_ViaLocalModuleInfo(importModuleOptions, module);
                                                                         SetModuleBaseForEngineModules(module.Name, this.Context);
                                                                     }, cimSessionAction: (cimSession, resourceUri, cimNamespace) => ImportModule_RemotelyViaCimSession(
                                                        importModuleOptions,
                                                        new string[] { module.Name },
                                                        cimSession,
                                                        resourceUri,
                                                        cimNamespace), psSessionAction: psSession => ImportModule_RemotelyViaPsrpSession(
                                                        importModuleOptions,
                                                        new string[] { module.Path },
                                                        null,
                                                        psSession));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 82058, 83346);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 1289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 1289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 81767, 86239);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 81767, 86239);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 83380, 86239) || true) && (f_1530_83384_83471(f_1530_83384_83405(this), ParameterSet_Assembly, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 83380, 86239);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 83568, 83966) || true) && (f_1530_83572_83580() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 83568, 83966);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 83630, 83947);
                                foreach (Assembly suppliedAssembly in f_1530_83668_83676_I(f_1530_83668_83676()))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 83630, 83947);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 83726, 83834);

                                    f_1530_83726_83833(TelemetryType.ModuleLoad, f_1530_83801_83832(f_1530_83801_83827(suppliedAssembly)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 83860, 83924);

                                    f_1530_83860_83923(this, importModuleOptions, suppliedAssembly);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 83630, 83947);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 318);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 318);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 83568, 83966);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 83380, 86239);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 83380, 86239);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84000, 86239) || true) && (f_1530_84004_84087(f_1530_84004_84025(this), ParameterSet_Name, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84000, 86239);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84121, 84279);
                                foreach (string name in f_1530_84145_84149_I(f_1530_84145_84149()))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84121, 84279);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84191, 84260);

                                    f_1530_84191_84259(this, importModuleOptions, name);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84121, 84279);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 159);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 159);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84000, 86239);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84000, 86239);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84313, 86239) || true) && (f_1530_84317_84410(f_1530_84317_84338(this), ParameterSet_ViaPsrpSession, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84313, 86239);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84444, 84534);

                                f_1530_84444_84533(this, importModuleOptions, f_1530_84501_84510(this), null, f_1530_84518_84532(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84313, 86239);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84313, 86239);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84568, 86239) || true) && (f_1530_84572_84664(f_1530_84572_84593(this), ParameterSet_ViaCimSession, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84568, 86239);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84698, 84822);

                                    f_1530_84698_84821(this, importModuleOptions, f_1530_84754_84763(this), f_1530_84765_84780(this), f_1530_84782_84801(this), f_1530_84803_84820(this));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84568, 86239);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84568, 86239);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84856, 86239) || true) && (f_1530_84860_84945(f_1530_84860_84881(this), ParameterSet_FQName, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84856, 86239);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 84979, 85148);
                                            foreach (var modulespec in f_1530_85006_85024_I(f_1530_85006_85024()))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84979, 85148);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85066, 85129);

                                                f_1530_85066_85128(this, importModuleOptions, modulespec);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84979, 85148);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 170);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 170);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84856, 86239);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 84856, 86239);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85182, 86239) || true) && (f_1530_85186_85286(f_1530_85186_85207(this), ParameterSet_FQName_ViaPsrpSession, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85182, 86239);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85320, 85419);

                                            f_1530_85320_85418(this, importModuleOptions, null, f_1530_85383_85401(), f_1530_85403_85417(this));
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85437, 85651);
                                                foreach (ModuleSpecification modulespec in f_1530_85480_85498_I(f_1530_85480_85498()))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85437, 85651);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85540, 85632);

                                                    f_1530_85540_85631(TelemetryType.ModuleLoad, f_1530_85615_85630(modulespec));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85437, 85651);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 215);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 215);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85182, 86239);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85182, 86239);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85685, 86239) || true) && (f_1530_85689_85780(f_1530_85689_85710(this), ParameterSet_ViaWinCompat, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1530, 85689, 85901) || f_1530_85803_85901(f_1530_85803_85824(this), ParameterSet_FQName_ViaWinCompat, StringComparison.OrdinalIgnoreCase)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85685, 86239);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 85935, 86110) || true) && (f_1530_85939_85964(this))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85935, 86110);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86006, 86091);

                                                    f_1530_86006_86090(this, f_1530_86034_86043(this), f_1530_86045_86068(this), importModuleOptions);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85935, 86110);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85685, 86239);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 85685, 86239);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86176, 86224);

                                                f_1530_86176_86223(false, "Unrecognized parameter set");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85685, 86239);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 85182, 86239);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84856, 86239);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84568, 86239);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84313, 86239);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 84000, 86239);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 83380, 86239);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 81767, 86239);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 80998, 86250);

                System.Version
                f_1530_81066_81084()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81066, 81084);
                    return return_v;
                }


                System.Version
                f_1530_81096_81114()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81096, 81114);
                    return return_v;
                }


                System.Version
                f_1530_81126_81144()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81126, 81144);
                    return return_v;
                }


                System.Version
                f_1530_81147_81165()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81147, 81165);
                    return return_v;
                }


                string
                f_1530_81234_81285()
                {
                    var return_v = Modules.MinimumVersionAndMaximumVersionInvalidRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81234, 81285);
                    return return_v;
                }


                System.Version
                f_1530_81287_81305()
                {
                    var return_v = BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81287, 81305);
                    return return_v;
                }


                System.Version
                f_1530_81307_81325()
                {
                    var return_v = BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81307, 81325);
                    return return_v;
                }


                string
                f_1530_81216_81326(string
                formatSpec, System.Version
                o1, System.Version
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81216, 81326);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1530_81351_81393(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81351, 81393);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                f_1530_81467_81492()
                {
                    var return_v = new Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81467, 81492);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1530_81539_81548()
                {
                    var return_v = NoClobber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81539, 81548);
                    return return_v;
                }


                string
                f_1530_81589_81594()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81589, 81594);
                    return return_v;
                }


                bool
                f_1530_81568_81595(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81568, 81595);
                    return return_v;
                }


                string
                f_1530_81599_81604()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81599, 81604);
                    return return_v;
                }


                bool
                f_1530_81599_81669(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81599, 81669);
                    return return_v;
                }


                string
                f_1530_81771_81792(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 81771, 81792);
                    return return_v;
                }


                bool
                f_1530_81771_81860(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 81771, 81860);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo[]
                f_1530_82090_82100()
                {
                    var return_v = ModuleInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 82090, 82100);
                    return return_v;
                }


                string
                f_1530_82217_82228(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 82217, 82228);
                    return return_v;
                }


                int
                f_1530_82142_82229(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 82142, 82229);
                    return 0;
                }


                int
                f_1530_82252_83326(System.Management.Automation.PSModuleInfo
                moduleInfo, System.Action
                localAction, System.Action<Microsoft.Management.Infrastructure.CimSession, System.Uri, string>
                cimSessionAction, System.Action<System.Management.Automation.Runspaces.PSSession>
                psSessionAction)
                {
                    RemoteDiscoveryHelper.DispatchModuleInfoProcessing(moduleInfo, localAction: localAction, cimSessionAction: cimSessionAction, psSessionAction: psSessionAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 82252, 83326);
                    return 0;
                }


                System.Management.Automation.PSModuleInfo[]
                f_1530_82090_82100_I(System.Management.Automation.PSModuleInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 82090, 82100);
                    return return_v;
                }


                string
                f_1530_83384_83405(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 83384, 83405);
                    return return_v;
                }


                bool
                f_1530_83384_83471(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 83384, 83471);
                    return return_v;
                }


                System.Reflection.Assembly[]
                f_1530_83572_83580()
                {
                    var return_v = Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 83572, 83580);
                    return return_v;
                }


                System.Reflection.Assembly[]
                f_1530_83668_83676()
                {
                    var return_v = Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 83668, 83676);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1530_83801_83827(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 83801, 83827);
                    return return_v;
                }


                string
                f_1530_83801_83832(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 83801, 83832);
                    return return_v;
                }


                int
                f_1530_83726_83833(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 83726, 83833);
                    return 0;
                }


                int
                f_1530_83860_83923(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, System.Reflection.Assembly
                suppliedAssembly)
                {
                    this_param.ImportModule_ViaAssembly(importModuleOptions, suppliedAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 83860, 83923);
                    return 0;
                }


                System.Reflection.Assembly[]
                f_1530_83668_83676_I(System.Reflection.Assembly[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 83668, 83676);
                    return return_v;
                }


                string
                f_1530_84004_84025(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84004, 84025);
                    return return_v;
                }


                bool
                f_1530_84004_84087(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84004, 84087);
                    return return_v;
                }


                string[]
                f_1530_84145_84149()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84145, 84149);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_84191_84259(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                name)
                {
                    var return_v = this_param.ImportModule_LocallyViaName_WithTelemetry(importModuleOptions, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84191, 84259);
                    return return_v;
                }


                string[]
                f_1530_84145_84149_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84145, 84149);
                    return return_v;
                }


                string
                f_1530_84317_84338(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84317, 84338);
                    return return_v;
                }


                bool
                f_1530_84317_84410(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84317, 84410);
                    return return_v;
                }


                string[]
                f_1530_84501_84510(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84501, 84510);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSession
                f_1530_84518_84532(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.PSSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84518, 84532);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_84444_84533(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string[]
                moduleNames, System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                fullyQualifiedNames, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession(importModuleOptions, (System.Collections.Generic.IEnumerable<string>)moduleNames, fullyQualifiedNames, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84444, 84533);
                    return return_v;
                }


                string
                f_1530_84572_84593(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84572, 84593);
                    return return_v;
                }


                bool
                f_1530_84572_84664(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84572, 84664);
                    return return_v;
                }


                string[]
                f_1530_84754_84763(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84754, 84763);
                    return return_v;
                }


                Microsoft.Management.Infrastructure.CimSession
                f_1530_84765_84780(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CimSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84765, 84780);
                    return return_v;
                }


                System.Uri
                f_1530_84782_84801(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CimResourceUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84782, 84801);
                    return return_v;
                }


                string
                f_1530_84803_84820(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.CimNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84803, 84820);
                    return return_v;
                }


                int
                f_1530_84698_84821(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string[]
                moduleNames, Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace)
                {
                    this_param.ImportModule_RemotelyViaCimSession(importModuleOptions, moduleNames, cimSession, resourceUri, cimNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84698, 84821);
                    return 0;
                }


                string
                f_1530_84860_84881(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 84860, 84881);
                    return return_v;
                }


                bool
                f_1530_84860_84945(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 84860, 84945);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_85006_85024()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85006, 85024);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_85066_85128(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, Microsoft.PowerShell.Commands.ModuleSpecification
                modulespec)
                {
                    var return_v = this_param.ImportModule_LocallyViaFQName(importModuleOptions, modulespec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85066, 85128);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_85006_85024_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85006, 85024);
                    return return_v;
                }


                string
                f_1530_85186_85207(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85186, 85207);
                    return return_v;
                }


                bool
                f_1530_85186_85286(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85186, 85286);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_85383_85401()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85383, 85401);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSession
                f_1530_85403_85417(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.PSSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85403, 85417);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_85320_85418(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, System.Collections.Generic.IEnumerable<string>
                moduleNames, Microsoft.PowerShell.Commands.ModuleSpecification[]
                fullyQualifiedNames, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession(importModuleOptions, moduleNames, (System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)fullyQualifiedNames, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85320, 85418);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_85480_85498()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85480, 85498);
                    return return_v;
                }


                string
                f_1530_85615_85630(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85615, 85630);
                    return return_v;
                }


                int
                f_1530_85540_85631(Microsoft.PowerShell.Telemetry.TelemetryType
                metricId, string
                data)
                {
                    ApplicationInsightsTelemetry.SendTelemetryMetric(metricId, data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85540, 85631);
                    return 0;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_85480_85498_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85480, 85498);
                    return return_v;
                }


                string
                f_1530_85689_85710(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85689, 85710);
                    return return_v;
                }


                bool
                f_1530_85689_85780(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85689, 85780);
                    return return_v;
                }


                string
                f_1530_85803_85824(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85803, 85824);
                    return return_v;
                }


                bool
                f_1530_85803_85901(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 85803, 85901);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1530_85939_85964(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.UseWindowsPowerShell;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 85939, 85964);
                    return return_v;
                }


                string[]
                f_1530_86034_86043(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 86034, 86043);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1530_86045_86068(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 86045, 86068);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_86006_86090(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string[]
                moduleNames, Microsoft.PowerShell.Commands.ModuleSpecification[]
                moduleFullyQualifiedNames, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions)
                {
                    var return_v = this_param.ImportModulesUsingWinCompat((System.Collections.Generic.IEnumerable<string>)moduleNames, (System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)moduleFullyQualifiedNames, importModuleOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86006, 86090);
                    return return_v;
                }


                int
                f_1530_86176_86223(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86176, 86223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 80998, 86250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 80998, 86250);
            }
        }

        private bool IsModuleInDenyList(string[] moduleDenyList, string moduleName, ModuleSpecification moduleSpec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 86262, 87663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86394, 86517);

                f_1530_86394_86516(f_1530_86407_86439(moduleName) ^ (moduleSpec == null), "Either moduleName or moduleSpec must be specified");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86671, 86778);

                string
                exactModuleName = f_1530_86696_86777((DynAbs.Tracing.TraceSender.Conditional_F1(1530, 86727, 86745) || ((moduleSpec == null && DynAbs.Tracing.TraceSender.Conditional_F2(1530, 86748, 86758)) || DynAbs.Tracing.TraceSender.Conditional_F3(1530, 86761, 86776))) ? moduleName : f_1530_86761_86776(moduleSpec))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86792, 86811);

                bool
                match = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86827, 87611);
                    foreach (var deniedModuleName in f_1530_86860_86874_I(moduleDenyList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 86827, 87611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 86972, 87066);

                        match = f_1530_86980_87065(exactModuleName, deniedModuleName, StringComparison.InvariantCultureIgnoreCase);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87084, 87596) || true) && (match)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 87084, 87596);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87135, 87253);

                            string
                            errorMessage = f_1530_87157_87252(f_1530_87171_87199(), f_1530_87201_87234(), exactModuleName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87275, 87357);

                            InvalidOperationException
                            exception = f_1530_87313_87356(errorMessage)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87379, 87512);

                            ErrorRecord
                            er = f_1530_87396_87511(exception, "Modules_ModuleInWinCompatDenyList", ErrorCategory.ResourceUnavailable, exactModuleName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87534, 87549);

                            f_1530_87534_87548(this, er);
                            DynAbs.Tracing.TraceSender.TraceBreak(1530, 87571, 87577);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 87084, 87596);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 86827, 87611);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 785);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 87639, 87652);

                return match;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 86262, 87663);

                bool
                f_1530_86407_86439(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86407, 86439);
                    return return_v;
                }


                int
                f_1530_86394_86516(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86394, 86516);
                    return 0;
                }


                string
                f_1530_86761_86776(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 86761, 86776);
                    return return_v;
                }


                string
                f_1530_86696_86777(string
                path)
                {
                    var return_v = ModuleIntrinsics.GetModuleName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86696, 86777);
                    return return_v;
                }


                bool
                f_1530_86980_87065(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86980, 87065);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_87171_87199()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 87171, 87199);
                    return return_v;
                }


                string
                f_1530_87201_87234()
                {
                    var return_v = Modules.WinCompatModuleInDenyList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 87201, 87234);
                    return return_v;
                }


                string
                f_1530_87157_87252(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 87157, 87252);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_87313_87356(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 87313, 87356);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1530_87396_87511(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 87396, 87511);
                    return return_v;
                }


                int
                f_1530_87534_87548(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 87534, 87548);
                    return 0;
                }


                string[]
                f_1530_86860_86874_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 86860, 86874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 86262, 87663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 86262, 87663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<T> FilterModuleCollection<T>(IEnumerable<T> moduleCollection)
        {
            List<T> filteredModuleCollection = null;
            if (moduleCollection != null)
            {
                // the ModuleDeny list is cached in PowerShellConfig object
                string[] moduleDenyList = PowerShellConfig.Instance.GetWindowsPowerShellCompatibilityModuleDenyList();
                if (moduleDenyList?.Any() != true)
                {
                    filteredModuleCollection = new List<T>(moduleCollection);
                }
                else
                {
                    filteredModuleCollection = new List<T>();
                    foreach (var module in moduleCollection)
                    {
                        if (!IsModuleInDenyList(moduleDenyList, module as string, module as ModuleSpecification))
                        {
                            filteredModuleCollection.Add(module);
                        }
                    }
                }
            }

            return filteredModuleCollection;
        }

        private void PrepareNoClobberWinCompatModuleImport(string moduleName, ModuleSpecification moduleSpec, ref ImportModuleOptions importModuleOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 88791, 91235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 88962, 89085);

                f_1530_88962_89084(f_1530_88975_89007(moduleName) ^ (moduleSpec == null), "Either moduleName or moduleSpec must be specified");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 89239, 89347);

                string
                coreModuleToLoad = f_1530_89265_89346((DynAbs.Tracing.TraceSender.Conditional_F1(1530, 89296, 89314) || ((moduleSpec == null && DynAbs.Tracing.TraceSender.Conditional_F2(1530, 89317, 89327)) || DynAbs.Tracing.TraceSender.Conditional_F3(1530, 89330, 89345))) ? moduleName : f_1530_89330_89345(moduleSpec))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 89375, 89461);

                var
                isModuleToLoadEngineModule = f_1530_89408_89460(coreModuleToLoad)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 89475, 89587);

                string[]
                noClobberModuleList = f_1530_89506_89586(PowerShellConfig.Instance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 89601, 91224) || true) && (isModuleToLoadEngineModule || (DynAbs.Tracing.TraceSender.Expression_False(1530, 89605, 89750) || ((noClobberModuleList != null) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 89636, 89749) && f_1530_89669_89749(noClobberModuleList, coreModuleToLoad, f_1530_89716_89748())))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 89601, 91224);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90007, 90382) || true) && (isModuleToLoadEngineModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 90007, 90382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90079, 90182);

                        string
                        expectedCoreModulePath = f_1530_90111_90181(f_1530_90124_90162(), coreModuleToLoad)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90204, 90363) || true) && (f_1530_90208_90248(expectedCoreModulePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 90204, 90363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90298, 90340);

                            coreModuleToLoad = expectedCoreModulePath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 90204, 90363);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 90007, 90382);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90402, 91137) || true) && (moduleSpec == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 90402, 91137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90466, 90547);

                        f_1530_90466_90546(this, importModuleOptions, coreModuleToLoad);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 90402, 91137);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 90402, 91137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 90629, 91030);

                        ModuleSpecification
                        tmpModuleSpec = new ModuleSpecification()
                        {
                            Guid = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1530_90746_90761(moduleSpec), 1530, 90665, 91029),
                            MaximumVersion = f_1530_90805_90830(moduleSpec),
                            Version = f_1530_90867_90885(moduleSpec),
                            RequiredVersion = f_1530_90930_90956(moduleSpec),
                            Name = coreModuleToLoad
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 91052, 91118);

                        f_1530_91052_91117(this, importModuleOptions, tmpModuleSpec);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 90402, 91137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 91157, 91209);

                    importModuleOptions.NoClobberExportPSSession = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 89601, 91224);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 88791, 91235);

                bool
                f_1530_88975_89007(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 88975, 89007);
                    return return_v;
                }


                int
                f_1530_88962_89084(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 88962, 89084);
                    return 0;
                }


                string
                f_1530_89330_89345(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 89330, 89345);
                    return return_v;
                }


                string
                f_1530_89265_89346(string
                path)
                {
                    var return_v = ModuleIntrinsics.GetModuleName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 89265, 89346);
                    return return_v;
                }


                bool
                f_1530_89408_89460(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 89408, 89460);
                    return return_v;
                }


                string[]
                f_1530_89506_89586(System.Management.Automation.Configuration.PowerShellConfig
                this_param)
                {
                    var return_v = this_param.GetWindowsPowerShellCompatibilityNoClobberModuleList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 89506, 89586);
                    return return_v;
                }


                System.StringComparer
                f_1530_89716_89748()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 89716, 89748);
                    return return_v;
                }


                bool
                f_1530_89669_89749(string[]
                source, string
                value, System.StringComparer
                comparer)
                {
                    var return_v = source.Contains<string>(value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 89669, 89749);
                    return return_v;
                }


                string
                f_1530_90124_90162()
                {
                    var return_v = ModuleIntrinsics.GetPSHomeModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 90124, 90162);
                    return return_v;
                }


                string
                f_1530_90111_90181(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 90111, 90181);
                    return return_v;
                }


                bool
                f_1530_90208_90248(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 90208, 90248);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_90466_90546(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, string
                name)
                {
                    var return_v = this_param.ImportModule_LocallyViaName_WithTelemetry(importModuleOptions, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 90466, 90546);
                    return return_v;
                }


                System.Guid?
                f_1530_90746_90761(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 90746, 90761);
                    return return_v;
                }


                string
                f_1530_90805_90830(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 90805, 90830);
                    return return_v;
                }


                System.Version
                f_1530_90867_90885(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 90867, 90885);
                    return return_v;
                }


                System.Version
                f_1530_90930_90956(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 90930, 90956);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1530_91052_91117(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, Microsoft.PowerShell.Commands.ModuleSpecification
                modulespec)
                {
                    var return_v = this_param.ImportModule_LocallyViaFQName(importModuleOptions, modulespec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 91052, 91117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 88791, 91235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 88791, 91235);
            }
        }

        internal override IList<PSModuleInfo> ImportModulesUsingWinCompat(IEnumerable<string> moduleNames, IEnumerable<ModuleSpecification> moduleFullyQualifiedNames, ImportModuleOptions importModuleOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 91247, 95718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 91471, 91534);

                IList<PSModuleInfo>
                moduleProxyList = f_1530_91509_91533()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 91722, 91793);

                List<string>
                filteredModuleNames = f_1530_91757_91792(this, moduleNames)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 91807, 91919);

                List<ModuleSpecification>
                filteredModuleFullyQualifiedNames = f_1530_91869_91918(this, moduleFullyQualifiedNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92150, 92390) || true) && ((filteredModuleNames == null || (DynAbs.Tracing.TraceSender.Expression_False(1530, 92155, 92219) || f_1530_92186_92211(filteredModuleNames) != true)) && (DynAbs.Tracing.TraceSender.Expression_True(1530, 92154, 92318) && (filteredModuleFullyQualifiedNames == null || (DynAbs.Tracing.TraceSender.Expression_False(1530, 92225, 92317) || f_1530_92270_92309(filteredModuleFullyQualifiedNames) != true))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 92150, 92390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92352, 92375);

                    return moduleProxyList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 92150, 92390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92406, 92479);

                var
                winPSVersionString = f_1530_92431_92478()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92493, 92811) || true) && (!f_1530_92498_92570(winPSVersionString, "5.1", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 92493, 92811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92604, 92728);

                    string
                    errorMessage = f_1530_92626_92727(f_1530_92640_92668(), f_1530_92670_92706(), winPSVersionString)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92746, 92796);

                    throw f_1530_92752_92795(errorMessage);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 92493, 92811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92827, 92919);

                PSSession
                WindowsPowerShellCompatRemotingSession = f_1530_92878_92918()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 92933, 93064) || true) && (WindowsPowerShellCompatRemotingSession == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 92933, 93064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93017, 93049);

                    return f_1530_93024_93048();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 92933, 93064);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93176, 93446) || true) && (filteredModuleNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 93176, 93446);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93241, 93431);
                        foreach (string moduleName in f_1530_93270_93289_I(filteredModuleNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 93241, 93431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93331, 93412);

                            f_1530_93331_93411(this, moduleName, null, ref importModuleOptions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 93241, 93431);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 93176, 93446);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93462, 93757) || true) && (filteredModuleFullyQualifiedNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 93462, 93757);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93541, 93742);
                        foreach (var moduleSpec in f_1530_93567_93600_I(filteredModuleFullyQualifiedNames))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 93541, 93742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93642, 93723);

                            f_1530_93642_93722(this, null, moduleSpec, ref importModuleOptions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 93541, 93742);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 202);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 93462, 93757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 93834, 94027);

                moduleProxyList = f_1530_93852_94026(this, importModuleOptions, filteredModuleNames, filteredModuleFullyQualifiedNames, WindowsPowerShellCompatRemotingSession, usingWinCompat: true);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94043, 94485);
                    foreach (PSModuleInfo moduleProxy in f_1530_94080_94095_I(moduleProxyList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 94043, 94485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94129, 94180);

                        moduleProxy.IsWindowsPowerShellCompatModule = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94198, 94280);

                        f_1530_94198_94279(ref s_WindowsPowerShellCompatUsageCounter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94300, 94430);

                        string
                        message = f_1530_94317_94429(f_1530_94335_94365(), f_1530_94367_94383(moduleProxy), f_1530_94385_94428(WindowsPowerShellCompatRemotingSession))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94448, 94470);

                        f_1530_94448_94469(this, message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 94043, 94485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 443);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94612, 95662) || true) && (f_1530_94616_94637(moduleProxyList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 94612, 95662);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94791, 94910) || true) && (SyncCurrentLocationDelegate == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 94791, 94910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94853, 94910);

                        SyncCurrentLocationDelegate = SyncCurrentLocationHandler;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 94791, 94910);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 94957, 95022);

                    var
                    temp = f_1530_94968_95021(f_1530_94968_94999(f_1530_94968_94985(this)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 95040, 95143);

                    var
                    alreadyregistered = temp != null && (DynAbs.Tracing.TraceSender.Expression_True(1530, 95064, 95142) && f_1530_95080_95142(f_1530_95080_95104(temp), SyncCurrentLocationDelegate))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 95214, 95647) || true) && (temp == null || (DynAbs.Tracing.TraceSender.Expression_False(1530, 95218, 95252) || !alreadyregistered))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 95214, 95647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 95294, 95379);

                        f_1530_95294_95325(f_1530_95294_95311(this)).LocationChangedAction += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => SyncCurrentLocationDelegate, 1530, 95294, 95347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 95467, 95628);

                        f_1530_95467_95627(sender: this, args: f_1530_95514_95626(sessionState: null, oldPath: null, newPath: f_1530_95587_95625(f_1530_95587_95609(f_1530_95587_95604(this)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 95214, 95647);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 94612, 95662);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 95684, 95707);

                return moduleProxyList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 91247, 95718);

                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1530_91509_91533()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 91509, 91533);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1530_91757_91792(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Collections.Generic.IEnumerable<string>
                moduleCollection)
                {
                    var return_v = this_param.FilterModuleCollection<string>(moduleCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 91757, 91792);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1530_91869_91918(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleCollection)
                {
                    var return_v = this_param.FilterModuleCollection<Microsoft.PowerShell.Commands.ModuleSpecification>(moduleCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 91869, 91918);
                    return return_v;
                }


                bool
                f_1530_92186_92211(System.Collections.Generic.List<string>
                source)
                {
                    var return_v = source.Any<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92186, 92211);
                    return return_v;
                }


                bool
                f_1530_92270_92309(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                source)
                {
                    var return_v = source.Any<Microsoft.PowerShell.Commands.ModuleSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92270, 92309);
                    return return_v;
                }


                string
                f_1530_92431_92478()
                {
                    var return_v = Utils.GetWindowsPowerShellVersionFromRegistry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92431, 92478);
                    return return_v;
                }


                bool
                f_1530_92498_92570(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92498, 92570);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1530_92640_92668()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 92640, 92668);
                    return return_v;
                }


                string
                f_1530_92670_92706()
                {
                    var return_v = Modules.WinCompatRequredVersionError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 92670, 92706);
                    return return_v;
                }


                string
                f_1530_92626_92727(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92626, 92727);
                    return return_v;
                }


                System.InvalidOperationException
                f_1530_92752_92795(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92752, 92795);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PSSession
                f_1530_92878_92918()
                {
                    var return_v = CreateWindowsPowerShellCompatResources();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 92878, 92918);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1530_93024_93048()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93024, 93048);
                    return return_v;
                }


                int
                f_1530_93331_93411(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleName, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions)
                {
                    this_param.PrepareNoClobberWinCompatModuleImport(moduleName, moduleSpec, ref importModuleOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93331, 93411);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1530_93270_93289_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93270, 93289);
                    return return_v;
                }


                int
                f_1530_93642_93722(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                moduleName, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions)
                {
                    this_param.PrepareNoClobberWinCompatModuleImport(moduleName, moduleSpec, ref importModuleOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93642, 93722);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1530_93567_93600_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93567, 93600);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_93852_94026(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                importModuleOptions, System.Collections.Generic.List<string>
                moduleNames, System.Collections.Generic.List<Microsoft.PowerShell.Commands.ModuleSpecification>
                fullyQualifiedNames, System.Management.Automation.Runspaces.PSSession
                psSession, bool
                usingWinCompat)
                {
                    var return_v = this_param.ImportModule_RemotelyViaPsrpSession(importModuleOptions, (System.Collections.Generic.IEnumerable<string>)moduleNames, (System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)fullyQualifiedNames, psSession, usingWinCompat: usingWinCompat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 93852, 94026);
                    return return_v;
                }


                int
                f_1530_94198_94279(ref int
                location)
                {
                    var return_v = System.Threading.Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 94198, 94279);
                    return return_v;
                }


                string
                f_1530_94335_94365()
                {
                    var return_v = Modules.WinCompatModuleWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94335, 94365);
                    return return_v;
                }


                string
                f_1530_94367_94383(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94367, 94383);
                    return return_v;
                }


                string
                f_1530_94385_94428(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94385, 94428);
                    return return_v;
                }


                string
                f_1530_94317_94429(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 94317, 94429);
                    return return_v;
                }


                int
                f_1530_94448_94469(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 94448, 94469);
                    return 0;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                f_1530_94080_94095_I(System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 94080, 94095);
                    return return_v;
                }


                int
                f_1530_94616_94637(System.Collections.Generic.IList<System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94616, 94637);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_94968_94985(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94968, 94985);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1530_94968_94999(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94968, 94999);
                    return return_v;
                }


                System.EventHandler<System.Management.Automation.LocationChangedEventArgs>
                f_1530_94968_95021(System.Management.Automation.CommandInvocationIntrinsics
                this_param)
                {
                    var return_v = this_param.LocationChangedAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 94968, 95021);
                    return return_v;
                }


                System.Delegate[]
                f_1530_95080_95104(System.EventHandler<System.Management.Automation.LocationChangedEventArgs>
                this_param)
                {
                    var return_v = this_param.GetInvocationList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 95080, 95104);
                    return return_v;
                }


                bool
                f_1530_95080_95142(System.Delegate[]
                source, System.EventHandler<System.Management.Automation.LocationChangedEventArgs>
                value)
                {
                    var return_v = source.Contains<System.Delegate>((System.Delegate)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 95080, 95142);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_95294_95311(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 95294, 95311);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1530_95294_95325(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 95294, 95325);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1530_95587_95604(Microsoft.PowerShell.Commands.ImportModuleCommand
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 95587, 95604);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1530_95587_95609(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 95587, 95609);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1530_95587_95625(System.Management.Automation.PathIntrinsics
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 95587, 95625);
                    return return_v;
                }


                System.Management.Automation.LocationChangedEventArgs
                f_1530_95514_95626(System.Management.Automation.SessionState
                sessionState, System.Management.Automation.PathInfo
                oldPath, System.Management.Automation.PathInfo
                newPath)
                {
                    var return_v = new System.Management.Automation.LocationChangedEventArgs(sessionState: sessionState, oldPath: oldPath, newPath: newPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 95514, 95626);
                    return return_v;
                }


                int
                f_1530_95467_95627(Microsoft.PowerShell.Commands.ImportModuleCommand
                sender, System.Management.Automation.LocationChangedEventArgs
                args)
                {
                    SyncCurrentLocationHandler(sender: (object)sender, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 95467, 95627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 91247, 95718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 91247, 95718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetModuleBaseForEngineModules(string moduleName, System.Management.Automation.ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1530, 95730, 97347);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96008, 97336) || true) && (f_1530_96012_96058(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96008, 97336);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96092, 96702);
                        foreach (var m in f_1530_96110_96155_I(f_1530_96110_96155(f_1530_96110_96148(f_1530_96110_96136(context)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96092, 96702);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96197, 96683) || true) && (f_1530_96201_96262(f_1530_96201_96207(m), moduleName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96197, 96683);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96312, 96360);

                                f_1530_96312_96359(m, f_1530_96328_96358());
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96472, 96660);
                                    foreach (var nestedModule in f_1530_96501_96516_I(f_1530_96501_96516(m)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96472, 96660);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96574, 96633);

                                        f_1530_96574_96632(nestedModule, f_1530_96601_96631());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96472, 96660);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 189);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 189);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96197, 96683);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96092, 96702);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 611);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 611);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96722, 97321);
                        foreach (var m in f_1530_96740_96774_I(f_1530_96740_96774(f_1530_96740_96767(f_1530_96740_96755(context)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96722, 97321);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96816, 97302) || true) && (f_1530_96820_96881(f_1530_96820_96826(m), moduleName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 96816, 97302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 96931, 96979);

                                f_1530_96931_96978(m, f_1530_96947_96977());
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 97091, 97279);
                                    foreach (var nestedModule in f_1530_97120_97135_I(f_1530_97120_97135(m)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1530, 97091, 97279);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 97193, 97252);

                                        f_1530_97193_97251(nestedModule, f_1530_97220_97250());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 97091, 97279);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 189);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 189);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96816, 97302);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96722, 97321);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1530, 1, 600);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1530, 1, 600);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1530, 96008, 97336);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1530, 95730, 97347);

                bool
                f_1530_96012_96058(string
                moduleName)
                {
                    var return_v = InitialSessionState.IsEngineModule(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96012, 96058);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1530_96110_96136(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96110, 96136);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1530_96110_96148(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96110, 96148);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1530_96110_96155(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96110, 96155);
                    return return_v;
                }


                string
                f_1530_96201_96207(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96201, 96207);
                    return return_v;
                }


                bool
                f_1530_96201_96262(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96201, 96262);
                    return return_v;
                }


                string
                f_1530_96328_96358()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96328, 96358);
                    return return_v;
                }


                int
                f_1530_96312_96359(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96312, 96359);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_96501_96516(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96501, 96516);
                    return return_v;
                }


                string
                f_1530_96601_96631()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96601, 96631);
                    return return_v;
                }


                int
                f_1530_96574_96632(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96574, 96632);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_96501_96516_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96501, 96516);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1530_96110_96155_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96110, 96155);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1530_96740_96755(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96740, 96755);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1530_96740_96767(System.Management.Automation.ModuleIntrinsics
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96740, 96767);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1530_96740_96774(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96740, 96774);
                    return return_v;
                }


                string
                f_1530_96820_96826(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96820, 96826);
                    return return_v;
                }


                bool
                f_1530_96820_96881(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96820, 96881);
                    return return_v;
                }


                string
                f_1530_96947_96977()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 96947, 96977);
                    return return_v;
                }


                int
                f_1530_96931_96978(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96931, 96978);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_97120_97135(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.NestedModules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 97120, 97135);
                    return return_v;
                }


                string
                f_1530_97220_97250()
                {
                    var return_v = Utils.DefaultPowerShellAppBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1530, 97220, 97250);
                    return return_v;
                }


                int
                f_1530_97193_97251(System.Management.Automation.PSModuleInfo
                this_param, string
                moduleBase)
                {
                    this_param.SetModuleBase(moduleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 97193, 97251);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                f_1530_97120_97135_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 97120, 97135);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                f_1530_96740_96774_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 96740, 96774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1530, 95730, 97347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 95730, 97347);
            }
        }

        static ImportModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1530, 1270, 97354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1604, 1630);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1662, 1704);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1736, 1774);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1806, 1840);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1874, 1915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 1947, 1988);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2020, 2089);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2121, 2160);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1530, 2192, 2259);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1530, 1270, 97354);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1530, 1270, 97354);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1530, 1270, 97354);

        string[]
        f_1530_3772_3793()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 3772, 3793);
            return return_v;
        }


        string[]
        f_1530_6089_6110()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 6089, 6110);
            return return_v;
        }


        string[]
        f_1530_7179_7200()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 7179, 7200);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo[]
        f_1530_13705_13732()
        {
            var return_v = Array.Empty<PSModuleInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 13705, 13732);
            return return_v;
        }


        System.Threading.CancellationTokenSource
        f_1530_77744_77773()
        {
            var return_v = new System.Threading.CancellationTokenSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1530, 77744, 77773);
            return return_v;
        }

    }
}
