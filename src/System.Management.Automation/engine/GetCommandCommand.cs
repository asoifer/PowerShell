// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Get, "Command", DefaultParameterSetName = "CmdletSet", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096579")]
    [OutputType(typeof(AliasInfo), typeof(ApplicationInfo), typeof(FunctionInfo),
                    typeof(CmdletInfo), typeof(ExternalScriptInfo), typeof(FilterInfo),
                    typeof(string), typeof(PSObject))]
    public sealed class GetCommandCommand : PSCmdlet
    {
        [Parameter(
                    Position = 0,
                    ValueFromPipeline = true,
                    ValueFromPipelineByPropertyName = true,
                    ParameterSetName = "AllCommandSet")]
        [ValidateNotNullOrEmpty]
        public string[] Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 1662, 1727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 1698, 1712);

                    return _names;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 1662, 1727);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 1393, 2284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 1393, 2284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 1743, 2273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 1779, 1809);

                    _nameContainsWildcard = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 1827, 1842);

                    _names = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 1862, 2258) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 1862, 2258);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 1921, 2239);
                            foreach (string commandName in f_1279_1952_1957_I(value))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 1921, 2239);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2007, 2216) || true) && (f_1279_2011_2066(commandName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 2007, 2216);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2124, 2153);

                                    _nameContainsWildcard = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1279, 2183, 2189);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 2007, 2216);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 1921, 2239);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 319);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 319);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 1862, 2258);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 1743, 2273);

                    bool
                    f_1279_2011_2066(string
                    pattern)
                    {
                        var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 2011, 2066);
                        return return_v;
                    }


                    string[]
                    f_1279_1952_1957_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 1952, 1957);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 1393, 2284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 1393, 2284);
                }
            }
        }

        private string[] _names;

        private bool _nameContainsWildcard;

        [Parameter(ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletSet")]
        public string[] Verb
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 2622, 2687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2658, 2672);

                    return _verbs;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 2622, 2687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 2484, 2947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 2484, 2947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 2703, 2936);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2739, 2847) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 2739, 2847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2798, 2828);

                        value = f_1279_2806_2827();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 2739, 2847);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2867, 2882);

                    _verbs = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2900, 2921);

                    _verbPatterns = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 2703, 2936);

                    string[]
                    f_1279_2806_2827()
                    {
                        var return_v = Array.Empty<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 2806, 2827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 2484, 2947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 2484, 2947);
                }
            }
        }

        private string[] _verbs;

        [Parameter(ValueFromPipelineByPropertyName = true, ParameterSetName = "CmdletSet")]
        [ArgumentCompleter(typeof(NounArgumentCompleter))]
        public string[] Noun
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 3324, 3389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3360, 3374);

                    return _nouns;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 3324, 3389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 3126, 3649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 3126, 3649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 3405, 3638);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3441, 3549) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 3441, 3549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3500, 3530);

                        value = f_1279_3508_3529();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 3441, 3549);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3569, 3584);

                    _nouns = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3602, 3623);

                    _nounPatterns = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 3405, 3638);

                    string[]
                    f_1279_3508_3529()
                    {
                        var return_v = Array.Empty<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 3508, 3529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 3126, 3649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 3126, 3649);
                }
            }
        }

        private string[] _nouns;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("PSSnapin")]
        public string[] Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 3976, 4043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4012, 4028);

                    return _modules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 3976, 4043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 3839, 4353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 3839, 4353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 4059, 4342);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4095, 4203) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 4095, 4203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4154, 4184);

                        value = f_1279_4162_4183();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 4095, 4203);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4223, 4240);

                    _modules = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4258, 4281);

                    _modulePatterns = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4301, 4327);

                    _isModuleSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 4059, 4342);

                    string[]
                    f_1279_4162_4183()
                    {
                        var return_v = Array.Empty<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 4162, 4183);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 3839, 4353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 3839, 4353);
                }
            }
        }

        private string[] _modules;

        private bool _isModuleSpecified;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public ModuleSpecification[] FullyQualifiedModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 4735, 4815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4771, 4800);

                    return _moduleSpecifications;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 4735, 4815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 4600, 5061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 4600, 5061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 4831, 5050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4867, 4975) || true) && (value != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 4867, 4975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4926, 4956);

                        _moduleSpecifications = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 4867, 4975);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4995, 5035);

                    _isFullyQualifiedModuleSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 4831, 5050);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 4600, 5061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 4600, 5061);
                }
            }
        }

        private ModuleSpecification[] _moduleSpecifications;

        private bool _isFullyQualifiedModuleSpecified;

        [Parameter(ValueFromPipelineByPropertyName = true, ParameterSetName = "AllCommandSet")]
        [Alias("Type")]
        public CommandTypes CommandType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 5521, 5592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5557, 5577);

                    return _commandType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 5521, 5592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 5343, 5740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 5343, 5740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 5608, 5729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5644, 5665);

                    _commandType = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5683, 5714);

                    _isCommandTypeSpecified = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 5608, 5729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 5343, 5740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 5343, 5740);
                }
            }
        }

        private CommandTypes _commandType;

        private bool _isCommandTypeSpecified;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public int TotalCount { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 6507, 6572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 6543, 6557);

                    return _usage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 6507, 6572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 6392, 6665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 6392, 6665);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 6588, 6654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 6624, 6639);

                    _usage = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 6588, 6654);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 6392, 6665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 6392, 6665);
                }
            }
        }

        private bool _usage;

        [Parameter()]
        public SwitchParameter ShowCommandInfo { get; set; }

        [Parameter(Position = 1, ValueFromRemainingArguments = true)]
        [AllowNull]
        [AllowEmptyCollection]
        [Alias("Args")]
        public object[] ArgumentList { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter All
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 7765, 7785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 7771, 7783);

                    return _all;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 7765, 7785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 7653, 7833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 7653, 7833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 7801, 7822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 7807, 7820);

                    _all = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 7801, 7822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 7653, 7833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 7653, 7833);
                }
            }
        }

        private bool _all;

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter ListImported
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 8249, 8321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8285, 8306);

                    return _listImported;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 8249, 8321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 8128, 8421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 8128, 8421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 8337, 8410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8373, 8395);

                    _listImported = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 8337, 8410);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 8128, 8421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 8128, 8421);
                }
            }
        }

        private bool _listImported;

        [Parameter]
        [ValidateNotNullOrEmpty]
        public string[] ParameterName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 8796, 8827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8802, 8825);

                    return _parameterNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 8796, 8827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 8687, 9284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 8687, 9284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 8843, 9273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8879, 8998) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 8879, 8998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8938, 8979);

                        throw f_1279_8944_8978("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 8879, 8998);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9018, 9042);

                    _parameterNames = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9060, 9258);

                    _parameterNameWildcards = f_1279_9086_9257(_parameterNames, WildcardOptions.CultureInvariant | WildcardOptions.IgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 8843, 9273);

                    System.ArgumentNullException
                    f_1279_8944_8978(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 8944, 8978);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                    f_1279_9086_9257(string[]
                    globPatterns, System.Management.Automation.WildcardOptions
                    options)
                    {
                        var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 9086, 9257);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 8687, 9284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 8687, 9284);
                }
            }
        }

        private Collection<WildcardPattern> _parameterNameWildcards;

        private string[] _parameterNames;

        private HashSet<string> _matchedParameterNames;

        [Parameter]
        [ValidateNotNullOrEmpty]
        public PSTypeName[] ParameterType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 9794, 9868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9830, 9853);

                    return _parameterTypes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 9794, 9868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 9681, 10915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 9681, 10915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 9884, 10904);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9920, 10039) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 9920, 10039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9979, 10020);

                        throw f_1279_9985_10019("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 9920, 10039);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10157, 10234);

                    List<PSTypeName>
                    filteredParameterTypes = f_1279_10199_10233(f_1279_10220_10232(value))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10261, 10266);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10252, 10818) || true) && (i < f_1279_10272_10284(value))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10286, 10289)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 10252, 10818))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 10252, 10818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10331, 10357);

                            PSTypeName
                            ptn = value[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10381, 10566) || true) && (f_1279_10385_10484(value, otherPtn => otherPtn.Name.StartsWith(ptn.Name + "#", StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 10381, 10566);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10534, 10543);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 10381, 10566);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10590, 10743) || true) && ((i != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 10594, 10624) && (f_1279_10607_10615(ptn) != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 10594, 10661) && (f_1279_10629_10660(f_1279_10629_10637(ptn), typeof(object)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 10590, 10743);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10711, 10720);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 10590, 10743);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10767, 10799);

                            f_1279_10767_10798(
                                                filteredParameterTypes, ptn);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 567);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 567);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10838, 10889);

                    _parameterTypes = f_1279_10856_10888(filteredParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 9884, 10904);

                    System.ArgumentNullException
                    f_1279_9985_10019(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 9985, 10019);
                        return return_v;
                    }


                    int
                    f_1279_10220_10232(System.Management.Automation.PSTypeName[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 10220, 10232);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    f_1279_10199_10233(int
                    capacity)
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 10199, 10233);
                        return return_v;
                    }


                    int
                    f_1279_10272_10284(System.Management.Automation.PSTypeName[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 10272, 10284);
                        return return_v;
                    }


                    bool
                    f_1279_10385_10484(System.Management.Automation.PSTypeName[]
                    source, System.Func<System.Management.Automation.PSTypeName, bool>
                    predicate)
                    {
                        var return_v = source.Any<System.Management.Automation.PSTypeName>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 10385, 10484);
                        return return_v;
                    }


                    System.Type
                    f_1279_10607_10615(System.Management.Automation.PSTypeName
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 10607, 10615);
                        return return_v;
                    }


                    System.Type
                    f_1279_10629_10637(System.Management.Automation.PSTypeName
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 10629, 10637);
                        return return_v;
                    }


                    bool
                    f_1279_10629_10660(System.Type
                    this_param, System.Type
                    o)
                    {
                        var return_v = this_param.Equals(o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 10629, 10660);
                        return return_v;
                    }


                    int
                    f_1279_10767_10798(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param, System.Management.Automation.PSTypeName
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 10767, 10798);
                        return 0;
                    }


                    System.Management.Automation.PSTypeName[]
                    f_1279_10856_10888(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param)
                    {
                        var return_v = this_param.ToArray();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 10856, 10888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 9681, 10915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 9681, 10915);
                }
            }
        }

        private PSTypeName[] _parameterTypes;

        [Parameter(ParameterSetName = "AllCommandSet")]
        public SwitchParameter UseFuzzyMatching { get; set; }

        private List<CommandScore> _commandScores;

        [Parameter(ValueFromPipelineByPropertyName = true, ParameterSetName = "AllCommandSet")]
        public SwitchParameter UseAbbreviationExpansion { get; set; }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 11961, 12573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 12085, 12108);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1279, 12085, 12107);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 12124, 12562) || true) && (f_1279_12128_12143().IsPresent && (DynAbs.Tracing.TraceSender.Expression_True(1279, 12128, 12173) && f_1279_12157_12163().IsPresent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 12124, 12562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 12207, 12547);

                    f_1279_12207_12546(this, f_1279_12251_12545(f_1279_12293_12373(f_1279_12317_12372()), "GetCommandCannotSpecifySyntaxAndShowCommandInfoTogether", ErrorCategory.InvalidArgument, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 12124, 12562);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 11961, 12573);

                System.Management.Automation.SwitchParameter
                f_1279_12128_12143()
                {
                    var return_v = ShowCommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 12128, 12143);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_12157_12163()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 12157, 12163);
                    return return_v;
                }


                string
                f_1279_12317_12372()
                {
                    var return_v = DiscoveryExceptions.GetCommandShowCommandInfoParamError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 12317, 12372);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1279_12293_12373(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 12293, 12373);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_12251_12545(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 12251, 12545);
                    return return_v;
                }


                int
                f_1279_12207_12546(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 12207, 12546);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 11961, 12573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 11961, 12573);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 12681, 14227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 12745, 12770);

                f_1279_12745_12769(_commandsWritten);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 12941, 13435) || true) && (_isModuleSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1279, 12945, 12999) && _isFullyQualifiedModuleSpecified))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 12941, 13435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13033, 13184);

                    string
                    errMsg = f_1279_13049_13183(f_1279_13063_13091(), f_1279_13093_13148(), "Module", "FullyQualifiedModule")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13202, 13373);

                    ErrorRecord
                    error = f_1279_13222_13372(f_1279_13238_13275(errMsg), "ModuleAndFullyQualifiedModuleCannotBeSpecifiedTogether", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13391, 13420);

                    f_1279_13391_13419(this, error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 12941, 13435);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13498, 13712) || true) && (_modulePatterns == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 13498, 13712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13559, 13697);

                    _modulePatterns = f_1279_13577_13696(f_1279_13626_13632(), WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 13498, 13712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13728, 14216);

                switch (f_1279_13736_13752())
                {

                    case "CmdletSet":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 13728, 14216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13825, 13853);

                        f_1279_13825_13852(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 13875, 13881);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 13728, 14216);

                    case "AllCommandSet":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 13728, 14216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 13944, 13973);

                        f_1279_13944_13972(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 13995, 14001);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 13728, 14216);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 13728, 14216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14051, 14173);

                        f_1279_14051_14172(false, "Only the valid parameter set names should be used");
                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 14195, 14201);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 13728, 14216);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 12681, 14227);

                int
                f_1279_12745_12769(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 12745, 12769);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1279_13063_13091()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 13063, 13091);
                    return return_v;
                }


                string
                f_1279_13093_13148()
                {
                    var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 13093, 13148);
                    return return_v;
                }


                string
                f_1279_13049_13183(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13049, 13183);
                    return return_v;
                }


                System.InvalidOperationException
                f_1279_13238_13275(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13238, 13275);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_13222_13372(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13222, 13372);
                    return return_v;
                }


                int
                f_1279_13391_13419(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13391, 13419);
                    return 0;
                }


                string[]
                f_1279_13626_13632()
                {
                    var return_v = Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 13626, 13632);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1279_13577_13696(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13577, 13696);
                    return return_v;
                }


                string
                f_1279_13736_13752()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 13736, 13752);
                    return return_v;
                }


                int
                f_1279_13825_13852(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    this_param.AccumulateMatchingCmdlets();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13825, 13852);
                    return 0;
                }


                int
                f_1279_13944_13972(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    this_param.AccumulateMatchingCommands();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 13944, 13972);
                    return 0;
                }


                int
                f_1279_14051_14172(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 14051, 14172);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 12681, 14227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 12681, 14227);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 14345, 18377);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14607, 15534) || true) && ((f_1279_14612_14621(this) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 14611, 14641) && (!_all)) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 14611, 14661) && f_1279_14645_14655() == -1) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 14611, 14682) && f_1279_14665_14682_M(!UseFuzzyMatching)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 14607, 15534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14716, 14754);

                    CommandTypes
                    commandTypesToIgnore = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14774, 14975) || true) && (((f_1279_14780_14796(this) & CommandTypes.Alias) != CommandTypes.Alias) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 14778, 14871) || (!_isCommandTypeSpecified)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 14774, 14975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14913, 14956);

                        commandTypesToIgnore |= CommandTypes.Alias;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 14774, 14975);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 14995, 15231) || true) && (((_commandType & CommandTypes.Application) != CommandTypes.Application) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 14999, 15121) || (!_isCommandTypeSpecified)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 14995, 15231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15163, 15212);

                        commandTypesToIgnore |= CommandTypes.Application;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 14995, 15231);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15251, 15519);

                    _accumulatedResults =
                    f_1279_15294_15518(f_1279_15294_15509(_accumulatedResults, commandInfo =>
                                            (((commandInfo.CommandType & commandTypesToIgnore) == 0) ||
                                             (commandInfo.Name.IndexOf('-') > 0))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 14607, 15534);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15636, 16765) || true) && ((_matchedParameterNames != null) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 15640, 15699) && (f_1279_15677_15690() != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 15636, 16765);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15733, 16750);
                        foreach (string requestedParameterName in f_1279_15775_15788_I(f_1279_15775_15788()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 15733, 16750);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15830, 15982) || true) && (f_1279_15834_15900(requestedParameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 15830, 15982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 15950, 15959);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 15830, 15982);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16006, 16147) || true) && (f_1279_16010_16065(_matchedParameterNames, requestedParameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 16006, 16147);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16115, 16124);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 16006, 16147);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16171, 16383);

                            string
                            errorMessage = f_1279_16193_16382(f_1279_16233_16261(), f_1279_16288_16332(), requestedParameterName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16405, 16481);

                            var
                            exception = f_1279_16421_16480(errorMessage, requestedParameterName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16503, 16685);

                            var
                            errorRecord = f_1279_16521_16684(exception, "CommandParameterNotFound", ErrorCategory.ObjectNotFound, requestedParameterName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16707, 16731);

                            f_1279_16707_16730(this, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 15733, 16750);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 1018);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 1018);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 15636, 16765);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16844, 17101) || true) && ((_names == null) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 16848, 16891) || (_nameContainsWildcard)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 16844, 17101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 16992, 17086);

                    _accumulatedResults = f_1279_17014_17085(f_1279_17014_17076(_accumulatedResults, a => a, f_1279_17050_17075()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 16844, 17101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 17117, 17158);

                f_1279_17117_17157(this, _accumulatedResults);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 17174, 17259);

                object
                pssenderInfo = f_1279_17196_17258(f_1279_17196_17203(), SpecialVariables.PSSenderInfoVarPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 17273, 18366) || true) && ((pssenderInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 17277, 17371) && (pssenderInfo is System.Management.Automation.Remoting.PSSenderInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 17273, 18366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18311, 18351);

                    f_1279_18311_18350(f_1279_18311_18329(f_1279_18311_18318()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 17273, 18366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 14345, 18377);

                string[]
                f_1279_14612_14621(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 14612, 14621);
                    return return_v;
                }


                int
                f_1279_14645_14655()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 14645, 14655);
                    return return_v;
                }


                bool
                f_1279_14665_14682_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 14665, 14682);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_14780_14796(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 14780, 14796);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_15294_15509(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                source, System.Func<System.Management.Automation.CommandInfo, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.CommandInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 15294, 15509);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                f_1279_15294_15518(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 15294, 15518);
                    return return_v;
                }


                string[]
                f_1279_15677_15690()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 15677, 15690);
                    return return_v;
                }


                string[]
                f_1279_15775_15788()
                {
                    var return_v = ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 15775, 15788);
                    return return_v;
                }


                bool
                f_1279_15834_15900(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 15834, 15900);
                    return return_v;
                }


                bool
                f_1279_16010_16065(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 16010, 16065);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1279_16233_16261()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 16233, 16261);
                    return return_v;
                }


                string
                f_1279_16288_16332()
                {
                    var return_v = DiscoveryExceptions.CommandParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 16288, 16332);
                    return return_v;
                }


                string
                f_1279_16193_16382(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 16193, 16382);
                    return return_v;
                }


                System.ArgumentException
                f_1279_16421_16480(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 16421, 16480);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_16521_16684(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 16521, 16684);
                    return return_v;
                }


                int
                f_1279_16707_16730(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 16707, 16730);
                    return 0;
                }


                string[]
                f_1279_15775_15788_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 15775, 15788);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.GetCommandCommand.CommandInfoComparer
                f_1279_17050_17075()
                {
                    var return_v = new Microsoft.PowerShell.Commands.GetCommandCommand.CommandInfoComparer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 17050, 17075);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.CommandInfo>
                f_1279_17014_17076(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                source, System.Func<System.Management.Automation.CommandInfo, System.Management.Automation.CommandInfo>
                keySelector, Microsoft.PowerShell.Commands.GetCommandCommand.CommandInfoComparer
                comparer)
                {
                    var return_v = source.OrderBy<System.Management.Automation.CommandInfo, System.Management.Automation.CommandInfo>(keySelector, (System.Collections.Generic.IComparer<System.Management.Automation.CommandInfo>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 17014, 17076);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                f_1279_17014_17085(System.Linq.IOrderedEnumerable<System.Management.Automation.CommandInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 17014, 17085);
                    return return_v;
                }


                int
                f_1279_17117_17157(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                results)
                {
                    this_param.OutputResultsHelper((System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>)results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 17117, 17157);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1279_17196_17203()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 17196, 17203);
                    return return_v;
                }


                object
                f_1279_17196_17258(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 17196, 17258);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_18311_18318()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 18311, 18318);
                    return return_v;
                }


                System.Management.Automation.HelpSystem
                f_1279_18311_18329(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.HelpSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 18311, 18329);
                    return return_v;
                }


                int
                f_1279_18311_18350(System.Management.Automation.HelpSystem
                this_param)
                {
                    this_param.ResetHelpProviders();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18311, 18350);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 14345, 18377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 14345, 18377);
            }
        }

        private void OutputResultsHelper(IEnumerable<CommandInfo> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 18446, 21119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18537, 18592);

                CommandOrigin
                origin = f_1279_18560_18591(f_1279_18560_18577(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18608, 18756) || true) && (f_1279_18612_18628())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 18608, 18756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18662, 18741);

                    results = f_1279_18672_18740(f_1279_18672_18731(f_1279_18672_18708(_commandScores, x => x.Score), x => x.Command));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 18608, 18756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18772, 18786);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18800, 20201);
                    foreach (CommandInfo result in f_1279_18831_18838_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 18800, 20201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18872, 18883);

                        count += 1;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 18978, 20186) || true) && (f_1279_18982_19020(origin, result))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 18978, 20186);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19214, 20167) || true) && (f_1279_19218_19224())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 19214, 20167);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19274, 19563) || true) && (!f_1279_19279_19314(f_1279_19300_19313(result)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 19274, 19563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19372, 19425);

                                    PSObject
                                    syntax = f_1279_19390_19424(f_1279_19410_19423(result))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19457, 19484);

                                    syntax.IsHelpObject = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19516, 19536);

                                    f_1279_19516_19535(this, syntax);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 19274, 19563);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 19214, 20167);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 19214, 20167);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19661, 20144) || true) && (f_1279_19665_19680().IsPresent)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 19661, 20144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 19827, 19907);

                                    f_1279_19827_19906(this, f_1279_19873_19905(result));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 19661, 20144);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 19661, 20144);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 20097, 20117);

                                    f_1279_20097_20116(this, result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 19661, 20144);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 19214, 20167);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 18978, 20186);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 18800, 20201);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 1402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 1402);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 18446, 21119);

                System.Management.Automation.InvocationInfo
                f_1279_18560_18577(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 18560, 18577);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1279_18560_18591(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 18560, 18591);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_18612_18628()
                {
                    var return_v = UseFuzzyMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 18612, 18628);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.Internal.CommandScore>
                f_1279_18672_18708(System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>
                source, System.Func<System.Management.Automation.Internal.CommandScore, int>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Management.Automation.Internal.CommandScore, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18672, 18708);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_18672_18731(System.Linq.IOrderedEnumerable<System.Management.Automation.Internal.CommandScore>
                source, System.Func<System.Management.Automation.Internal.CommandScore, System.Management.Automation.CommandInfo>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.Internal.CommandScore, System.Management.Automation.CommandInfo>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18672, 18731);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                f_1279_18672_18740(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18672, 18740);
                    return return_v;
                }


                bool
                f_1279_18982_19020(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18982, 19020);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_19218_19224()
                {
                    var return_v = Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 19218, 19224);
                    return return_v;
                }


                string
                f_1279_19300_19313(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 19300, 19313);
                    return return_v;
                }


                bool
                f_1279_19279_19314(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 19279, 19314);
                    return return_v;
                }


                string
                f_1279_19410_19423(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 19410, 19423);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_19390_19424(string
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 19390, 19424);
                    return return_v;
                }


                int
                f_1279_19516_19535(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 19516, 19535);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1279_19665_19680()
                {
                    var return_v = ShowCommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 19665, 19680);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_19873_19905(System.Management.Automation.CommandInfo
                cmdInfo)
                {
                    var return_v = ConvertToShowCommandInfo(cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 19873, 19905);
                    return return_v;
                }


                int
                f_1279_19827_19906(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 19827, 19906);
                    return 0;
                }


                int
                f_1279_20097_20116(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 20097, 20116);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_18831_18838_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 18831, 18838);
                    return return_v;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 18446, 21119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 18446, 21119);
            }
        }
        private class CommandInfoComparer : IComparer<CommandInfo>
        {
            public int Compare(CommandInfo x, CommandInfo y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 21680, 22182);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 21761, 22167) || true) && ((int)f_1279_21770_21783(x) < (int)f_1279_21791_21804(y))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 21761, 22167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 21846, 21856);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 21761, 22167);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 21761, 22167);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 21898, 22167) || true) && ((int)f_1279_21907_21920(x) > (int)f_1279_21928_21941(y))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 21898, 22167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 21983, 21992);

                            return 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 21898, 22167);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 21898, 22167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22074, 22148);

                            return f_1279_22081_22147(f_1279_22096_22102(x), f_1279_22104_22110(y), StringComparison.OrdinalIgnoreCase);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 21898, 22167);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 21761, 22167);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 21680, 22182);

                    System.Management.Automation.CommandTypes
                    f_1279_21770_21783(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 21770, 21783);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1279_21791_21804(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 21791, 21804);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1279_21907_21920(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 21907, 21920);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1279_21928_21941(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 21928, 21941);
                        return return_v;
                    }


                    string
                    f_1279_22096_22102(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 22096, 22102);
                        return return_v;
                    }


                    string
                    f_1279_22104_22110(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 22104, 22110);
                        return return_v;
                    }


                    int
                    f_1279_22081_22147(string
                    strA, string
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 22081, 22147);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 21680, 22182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 21680, 22182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public CommandInfoComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1279, 21252, 22193);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1279, 21252, 22193);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 21252, 22193);
            }


            static CommandInfoComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1279, 21252, 22193);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1279, 21252, 22193);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 21252, 22193);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1279, 21252, 22193);
        }

        private void AccumulateMatchingCmdlets()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 22205, 22578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22270, 22401);

                _commandType = CommandTypes.Cmdlet | CommandTypes.Function | CommandTypes.Filter | CommandTypes.Alias | CommandTypes.Configuration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22417, 22476);

                Collection<string>
                commandNames = f_1279_22451_22475()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22490, 22512);

                f_1279_22490_22511(commandNames, "*");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22526, 22567);

                f_1279_22526_22566(this, commandNames);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 22205, 22578);

                System.Collections.ObjectModel.Collection<string>
                f_1279_22451_22475()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 22451, 22475);
                    return return_v;
                }


                int
                f_1279_22490_22511(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 22490, 22511);
                    return 0;
                }


                int
                f_1279_22526_22566(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Collections.ObjectModel.Collection<string>
                commandNames)
                {
                    this_param.AccumulateMatchingCommands((System.Collections.Generic.IEnumerable<string>)commandNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 22526, 22566);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 22205, 22578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 22205, 22578);
            }
        }

        private bool IsNounVerbMatch(CommandInfo command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 22590, 25232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22664, 22684);

                bool
                result = false
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 22700, 25191);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22749, 22969) || true) && (_verbPatterns == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 22749, 22969);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22816, 22950);

                                _verbPatterns = f_1279_22832_22949(f_1279_22881_22885(), WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 22749, 22969);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22989, 23209) || true) && (_nounPatterns == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 22989, 23209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 23056, 23190);

                                _nounPatterns = f_1279_23072_23189(f_1279_23121_23125(), WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 22989, 23209);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 23229, 24282) || true) && (!f_1279_23234_23274(f_1279_23255_23273(command)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23229, 24282);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 23316, 23919) || true) && (_isFullyQualifiedModuleSpecified)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23316, 23919);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 23402, 23695) || true) && (!f_1279_23407_23604(_moduleSpecifications, moduleSpecification =>
                                                                      ModuleIntrinsics.IsModuleMatchingModuleSpec(command.Module, moduleSpecification)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23402, 23695);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 23662, 23668);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23402, 23695);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23316, 23919);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23316, 23919);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 23745, 23919) || true) && (!f_1279_23750_23840(f_1279_23798_23816(command), _modulePatterns, true))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23745, 23919);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 23890, 23896);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23745, 23919);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23316, 23919);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23229, 24282);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 23229, 24282);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24001, 24263) || true) && (f_1279_24005_24026(_modulePatterns) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1279, 24005, 24061) || f_1279_24034_24061(_moduleSpecifications)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24001, 24263);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1279, 24234, 24240);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24001, 24263);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 23229, 24282);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24356, 24368);

                            string
                            verb
                            = default(string);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24386, 24398);

                            string
                            noun
                            = default(string);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24416, 24458);

                            CmdletInfo
                            cmdlet = command as CmdletInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24476, 24795) || true) && (cmdlet != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24476, 24795);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24536, 24555);

                                verb = f_1279_24543_24554(cmdlet);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24577, 24596);

                                noun = f_1279_24584_24595(cmdlet);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24476, 24795);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24476, 24795);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24678, 24776) || true) && (!f_1279_24683_24743(f_1279_24710_24722(command), out verb, out noun))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24678, 24776);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1279, 24770, 24776);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24678, 24776);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24476, 24795);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24815, 24961) || true) && (!f_1279_24820_24894(verb, _verbPatterns, true))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24815, 24961);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 24936, 24942);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24815, 24961);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 24981, 25127) || true) && (!f_1279_24986_25060(noun, _nounPatterns, true))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 24981, 25127);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 25102, 25108);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 24981, 25127);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25147, 25161);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 22700, 25191);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 22700, 25191) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 22700, 25191);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 22700, 25191);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25207, 25221);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 22590, 25232);

                string[]
                f_1279_22881_22885()
                {
                    var return_v = Verb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 22881, 22885);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1279_22832_22949(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 22832, 22949);
                    return return_v;
                }


                string[]
                f_1279_23121_23125()
                {
                    var return_v = Noun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 23121, 23125);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1279_23072_23189(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 23072, 23189);
                    return return_v;
                }


                string
                f_1279_23255_23273(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 23255, 23273);
                    return return_v;
                }


                bool
                f_1279_23234_23274(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 23234, 23274);
                    return return_v;
                }


                bool
                f_1279_23407_23604(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source, System.Func<Microsoft.PowerShell.Commands.ModuleSpecification, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.PowerShell.Commands.ModuleSpecification>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 23407, 23604);
                    return return_v;
                }


                string
                f_1279_23798_23816(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 23798, 23816);
                    return return_v;
                }


                bool
                f_1279_23750_23840(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 23750, 23840);
                    return return_v;
                }


                int
                f_1279_24005_24026(System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 24005, 24026);
                    return return_v;
                }


                bool
                f_1279_24034_24061(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source)
                {
                    var return_v = source.Any<Microsoft.PowerShell.Commands.ModuleSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 24034, 24061);
                    return return_v;
                }


                string
                f_1279_24543_24554(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Verb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 24543, 24554);
                    return return_v;
                }


                string
                f_1279_24584_24595(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Noun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 24584, 24595);
                    return return_v;
                }


                string
                f_1279_24710_24722(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 24710, 24722);
                    return return_v;
                }


                bool
                f_1279_24683_24743(string
                name, out string
                verb, out string
                noun)
                {
                    var return_v = CmdletInfo.SplitCmdletName(name, out verb, out noun);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 24683, 24743);
                    return return_v;
                }


                bool
                f_1279_24820_24894(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 24820, 24894);
                    return return_v;
                }


                bool
                f_1279_24986_25060(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 24986, 25060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 22590, 25232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 22590, 25232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AccumulateMatchingCommands()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 25383, 25748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25449, 25566);

                Collection<string>
                commandNames =
                f_1279_25500_25565(f_1279_25555_25564(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25582, 25680) || true) && (f_1279_25586_25604(commandNames) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 25582, 25680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25643, 25665);

                    f_1279_25643_25664(commandNames, "*");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 25582, 25680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25696, 25737);

                f_1279_25696_25736(this, commandNames);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 25383, 25748);

                string[]
                f_1279_25555_25564(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 25555, 25564);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1279_25500_25565(string[]
                array)
                {
                    var return_v = SessionStateUtilities.ConvertArrayToCollection<string>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 25500, 25565);
                    return return_v;
                }


                int
                f_1279_25586_25604(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 25586, 25604);
                    return return_v;
                }


                int
                f_1279_25643_25664(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 25643, 25664);
                    return 0;
                }


                int
                f_1279_25696_25736(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Collections.ObjectModel.Collection<string>
                commandNames)
                {
                    this_param.AccumulateMatchingCommands((System.Collections.Generic.IEnumerable<string>)commandNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 25696, 25736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 25383, 25748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 25383, 25748);
            }
        }

        private void AccumulateMatchingCommands(IEnumerable<string> commandNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 25760, 33994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25905, 25968);

                SearchResolutionOptions
                options = SearchResolutionOptions.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 25982, 26088) || true) && (f_1279_25986_25989())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 25982, 26088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26023, 26073);

                    options = SearchResolutionOptions.SearchAllScopes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 25982, 26088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26104, 26241) || true) && (f_1279_26108_26132())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 26104, 26241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26166, 26226);

                    options |= SearchResolutionOptions.UseAbbreviationExpansion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 26104, 26241);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26257, 26372) || true) && (f_1279_26261_26277())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 26257, 26372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26311, 26357);

                    options |= SearchResolutionOptions.FuzzyMatch;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 26257, 26372);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26388, 26541) || true) && ((f_1279_26393_26409(this) & CommandTypes.Alias) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 26388, 26541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26470, 26526);

                    options |= SearchResolutionOptions.ResolveAliasPatterns;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 26388, 26541);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26557, 26769) || true) && ((f_1279_26562_26578(this) & (CommandTypes.Function | CommandTypes.Filter | CommandTypes.Configuration)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 26557, 26769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26695, 26754);

                    options |= SearchResolutionOptions.ResolveFunctionPatterns;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 26557, 26769);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 26785, 33983);
                    foreach (string commandName in f_1279_26816_26828_I(commandNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 26785, 33983);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27051, 27069);

                            string
                            moduleName
                            = default(string);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27091, 27169);

                            string
                            plainCommandName = f_1279_27117_27168(commandName, out moduleName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27191, 27237);

                            bool
                            isModuleQualified = (moduleName != null)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27420, 27615) || true) && ((f_1279_27425_27443(f_1279_27425_27436(this)) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 27424, 27514) && (!f_1279_27455_27513(f_1279_27498_27509(this)[0]))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 27420, 27615);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27564, 27592);

                                moduleName = f_1279_27577_27588(this)[0];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 27420, 27615);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27639, 27765);

                            bool
                            isPattern = f_1279_27656_27716(plainCommandName) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 27656, 27744) || f_1279_27720_27744()) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 27656, 27764) || f_1279_27748_27764())
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27787, 27929) || true) && (isPattern)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 27787, 27929);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 27850, 27906);

                                options |= SearchResolutionOptions.CommandNameIsPattern;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 27787, 27929);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28037, 28051);

                            int
                            count = 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28073, 28090);

                            bool
                            isDuplicate
                            = default(bool);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28112, 28217);

                            bool
                            resultFound = f_1279_28131_28216(this, options, commandName, isPattern, true, ref count, out isDuplicate)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28386, 32716) || true) && (!resultFound || (DynAbs.Tracing.TraceSender.Expression_False(1279, 28390, 28415) || isPattern))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 28386, 32716);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28731, 32693) || true) && ((!isPattern) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 28735, 28786) || (!f_1279_28753_28785(moduleName))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 28731, 32693);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28844, 28881);

                                    string
                                    tempCommandName = commandName
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 28911, 29121) || true) && ((!isModuleQualified) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 28915, 28974) && (!f_1279_28941_28973(moduleName))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 28911, 29121);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 29040, 29090);

                                        tempCommandName = moduleName + "\\" + commandName;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 28911, 29121);
                                    }

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 29221, 29320);

                                        f_1279_29221_29319(tempCommandName, f_1279_29273_29304(f_1279_29273_29290(this)), f_1279_29306_29318(this));
                                    }
                                    catch (CommandNotFoundException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 29381, 29563);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 29381, 29563);
                                        // Ignore, LookupCommandInfo doesn't handle wildcards.
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 29595, 29696);

                                    resultFound = f_1279_29609_29695(this, options, commandName, isPattern, false, ref count, out isDuplicate);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 28731, 32693);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 28731, 32693);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 29868, 32693) || true) && (f_1279_29872_29885_M(!ListImported))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 29868, 32693);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 29943, 32666) || true) && (f_1279_29947_29957() < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1279, 29947, 29983) || count < f_1279_29973_29983()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 29943, 32666);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 30049, 30083);

                                            IEnumerable<CommandInfo>
                                            commands
                                            = default(IEnumerable<CommandInfo>);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 30117, 31643) || true) && (f_1279_30121_30137())
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 30117, 31643);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 30211, 30829);
                                                    foreach (var commandScore in f_1279_30240_30675_I(f_1279_30240_30675(plainCommandName, f_1279_30416_30428(this), f_1279_30471_30502(f_1279_30471_30488(this)), rediscoverImportedModules: true, moduleVersionRequired: _isFullyQualifiedModuleSpecified)))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 30211, 30829);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 30757, 30790);

                                                        f_1279_30757_30789(_commandScores, commandScore);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 30211, 30829);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 619);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 619);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 30869, 30927);

                                                commands = f_1279_30880_30926(f_1279_30880_30917(_commandScores, x => x.Command));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 30117, 31643);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 30117, 31643);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 31073, 31608);

                                                commands = f_1279_31084_31607(plainCommandName, f_1279_31255_31267(this), f_1279_31310_31341(f_1279_31310_31327(this)), rediscoverImportedModules: true, moduleVersionRequired: _isFullyQualifiedModuleSpecified, useAbbreviationExpansion: f_1279_31582_31606());
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 30117, 31643);
                                            }
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 31679, 32635);
                                                foreach (CommandInfo command in f_1279_31711_31719_I(commands))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 31679, 32635);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 31894, 31924);

                                                    CommandInfo
                                                    current = command
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 31964, 32600) || true) && (f_1279_31968_32012(this, ref current, out isDuplicate) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 31968, 32045) && (!f_1279_32018_32044(this, current))) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 31968, 32074) && f_1279_32049_32074(this, current)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 31964, 32600);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 32156, 32189);

                                                        f_1279_32156_32188(_accumulatedResults, current);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 32328, 32336);

                                                        ++count;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 32380, 32561) || true) && (f_1279_32384_32394() >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1279, 32384, 32422) && count >= f_1279_32412_32422()))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 32380, 32561);
                                                            DynAbs.Tracing.TraceSender.TraceBreak(1279, 32512, 32518);

                                                            break;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 32380, 32561);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 31964, 32600);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 31679, 32635);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 957);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 957);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 29943, 32666);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 29868, 32693);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 28731, 32693);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 28386, 32716);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 32919, 33682) || true) && (!isDuplicate)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 32919, 33682);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 32985, 33659) || true) && (!resultFound && (DynAbs.Tracing.TraceSender.Expression_True(1279, 32989, 33015) && !isPattern))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 32985, 33659);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 33073, 33406);

                                    CommandNotFoundException
                                    e =
                                    f_1279_33135_33405(commandName, null, "CommandNotFoundException", f_1279_33360_33404())
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 33438, 33593);

                                    f_1279_33438_33592(this, f_1279_33483_33591(f_1279_33537_33550(e), e));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 33623, 33632);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 32985, 33659);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 32919, 33682);
                            }
                        }
                        catch (CommandNotFoundException exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 33719, 33968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 33802, 33949);

                            f_1279_33802_33948(this, f_1279_33839_33947(f_1279_33885_33906(exception), exception));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 33719, 33968);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 26785, 33983);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 7199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 7199);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 25760, 33994);

                System.Management.Automation.SwitchParameter
                f_1279_25986_25989()
                {
                    var return_v = All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 25986, 25989);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_26108_26132()
                {
                    var return_v = UseAbbreviationExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 26108, 26132);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_26261_26277()
                {
                    var return_v = UseFuzzyMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 26261, 26277);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_26393_26409(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 26393, 26409);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_26562_26578(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 26562, 26578);
                    return return_v;
                }


                string
                f_1279_27117_27168(string
                commandName, out string
                moduleName)
                {
                    var return_v = Utils.ParseCommandName(commandName, out moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 27117, 27168);
                    return return_v;
                }


                string[]
                f_1279_27425_27436(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27425, 27436);
                    return return_v;
                }


                int
                f_1279_27425_27443(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27425, 27443);
                    return return_v;
                }


                string[]
                f_1279_27498_27509(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27498, 27509);
                    return return_v;
                }


                bool
                f_1279_27455_27513(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 27455, 27513);
                    return return_v;
                }


                string[]
                f_1279_27577_27588(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27577, 27588);
                    return return_v;
                }


                bool
                f_1279_27656_27716(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 27656, 27716);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_27720_27744()
                {
                    var return_v = UseAbbreviationExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27720, 27744);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_27748_27764()
                {
                    var return_v = UseFuzzyMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 27748, 27764);
                    return return_v;
                }


                bool
                f_1279_28131_28216(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.SearchResolutionOptions
                options, string
                commandName, bool
                isPattern, bool
                emitErrors, ref int
                currentCount, out bool
                isDuplicate)
                {
                    var return_v = this_param.FindCommandForName(options, commandName, isPattern, emitErrors, ref currentCount, out isDuplicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 28131, 28216);
                    return return_v;
                }


                bool
                f_1279_28753_28785(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 28753, 28785);
                    return return_v;
                }


                bool
                f_1279_28941_28973(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 28941, 28973);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1279_29273_29290(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29273, 29290);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1279_29273_29304(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29273, 29304);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_29306_29318(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29306, 29318);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1279_29221_29319(string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = CommandDiscovery.LookupCommandInfo(commandName, commandOrigin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 29221, 29319);
                    return return_v;
                }


                bool
                f_1279_29609_29695(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.SearchResolutionOptions
                options, string
                commandName, bool
                isPattern, bool
                emitErrors, ref int
                currentCount, out bool
                isDuplicate)
                {
                    var return_v = this_param.FindCommandForName(options, commandName, isPattern, emitErrors, ref currentCount, out isDuplicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 29609, 29695);
                    return return_v;
                }


                bool
                f_1279_29872_29885_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29872, 29885);
                    return return_v;
                }


                int
                f_1279_29947_29957()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29947, 29957);
                    return return_v;
                }


                int
                f_1279_29973_29983()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 29973, 29983);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_30121_30137()
                {
                    var return_v = UseFuzzyMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 30121, 30137);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_30416_30428(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 30416, 30428);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1279_30471_30488(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 30471, 30488);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1279_30471_30502(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 30471, 30502);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.CommandScore>
                f_1279_30240_30675(string
                pattern, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                rediscoverImportedModules, bool
                moduleVersionRequired)
                {
                    var return_v = System.Management.Automation.Internal.ModuleUtils.GetFuzzyMatchingCommands(pattern, context, commandOrigin, rediscoverImportedModules: rediscoverImportedModules, moduleVersionRequired: moduleVersionRequired);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 30240, 30675);
                    return return_v;
                }


                int
                f_1279_30757_30789(System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>
                this_param, System.Management.Automation.Internal.CommandScore
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 30757, 30789);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.CommandScore>
                f_1279_30240_30675_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Internal.CommandScore>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 30240, 30675);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_30880_30917(System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>
                source, System.Func<System.Management.Automation.Internal.CommandScore, System.Management.Automation.CommandInfo>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.Internal.CommandScore, System.Management.Automation.CommandInfo>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 30880, 30917);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                f_1279_30880_30926(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 30880, 30926);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_31255_31267(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 31255, 31267);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1279_31310_31327(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 31310, 31327);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1279_31310_31341(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 31310, 31341);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_31582_31606()
                {
                    var return_v = UseAbbreviationExpansion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 31582, 31606);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_31084_31607(string
                pattern, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.CommandOrigin
                commandOrigin, bool
                rediscoverImportedModules, bool
                moduleVersionRequired, System.Management.Automation.SwitchParameter
                useAbbreviationExpansion)
                {
                    var return_v = System.Management.Automation.Internal.ModuleUtils.GetMatchingCommands(pattern, context, commandOrigin, rediscoverImportedModules: rediscoverImportedModules, moduleVersionRequired: moduleVersionRequired, useAbbreviationExpansion: (bool)useAbbreviationExpansion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 31084, 31607);
                    return return_v;
                }


                bool
                f_1279_31968_32012(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, ref System.Management.Automation.CommandInfo
                current, out bool
                isDuplicate)
                {
                    var return_v = this_param.IsCommandMatch(ref current, out isDuplicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 31968, 32012);
                    return return_v;
                }


                bool
                f_1279_32018_32044(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                command)
                {
                    var return_v = this_param.IsCommandInResult(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 32018, 32044);
                    return return_v;
                }


                bool
                f_1279_32049_32074(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.IsParameterMatch(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 32049, 32074);
                    return return_v;
                }


                int
                f_1279_32156_32188(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                this_param, System.Management.Automation.CommandInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 32156, 32188);
                    return 0;
                }


                int
                f_1279_32384_32394()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 32384, 32394);
                    return return_v;
                }


                int
                f_1279_32412_32422()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 32412, 32422);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_31711_31719_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 31711, 31719);
                    return return_v;
                }


                string
                f_1279_33360_33404()
                {
                    var return_v = DiscoveryExceptions.CommandNotFoundException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 33360, 33404);
                    return return_v;
                }


                System.Management.Automation.CommandNotFoundException
                f_1279_33135_33405(string
                commandName, System.Exception
                innerException, string
                errorIdAndResourceId, string
                resourceStr, params object[]
                messageArgs)
                {
                    var return_v = new System.Management.Automation.CommandNotFoundException(commandName, innerException, errorIdAndResourceId, resourceStr, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 33135, 33405);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_33537_33550(System.Management.Automation.CommandNotFoundException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 33537, 33550);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_33483_33591(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.CommandNotFoundException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 33483, 33591);
                    return return_v;
                }


                int
                f_1279_33438_33592(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 33438, 33592);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_33885_33906(System.Management.Automation.CommandNotFoundException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 33885, 33906);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_33839_33947(System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.CommandNotFoundException
                replaceParentContainsErrorRecordException)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(errorRecord, (System.Exception)replaceParentContainsErrorRecordException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 33839, 33947);
                    return return_v;
                }


                int
                f_1279_33802_33948(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 33802, 33948);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1279_26816_26828_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 26816, 26828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 25760, 33994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 25760, 33994);
            }
        }

        private bool FindCommandForName(SearchResolutionOptions options, string commandName, bool isPattern, bool emitErrors, ref int currentCount, out bool isDuplicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 34006, 39760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34192, 34415);

                CommandSearcher
                searcher =
                f_1279_34240_34414(commandName, options, f_1279_34358_34374(this), f_1279_34401_34413(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34431, 34456);

                bool
                resultFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34470, 34490);

                isDuplicate = false;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 34506, 38691);
                            try
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34585, 34688) || true) && (!f_1279_34590_34609(searcher))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 34585, 34688);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1279, 34659, 34665);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 34585, 34688);
                                }
                            }
                            catch (ArgumentException argumentException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 34725, 35057);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34809, 35005) || true) && (emitErrors)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 34809, 35005);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34873, 34982);

                                    f_1279_34873_34981(this, f_1279_34884_34980(argumentException, "GetCommandInvalidArgument", ErrorCategory.SyntaxError, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 34809, 35005);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35029, 35038);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 34725, 35057);
                            }
                            catch (PathTooLongException pathTooLong)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 35075, 35398);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35156, 35346) || true) && (emitErrors)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 35156, 35346);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35220, 35323);

                                    f_1279_35220_35322(this, f_1279_35231_35321(pathTooLong, "GetCommandInvalidArgument", ErrorCategory.SyntaxError, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 35156, 35346);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35370, 35379);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 35075, 35398);
                            }
                            catch (FileLoadException fileLoadException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 35416, 35744);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35500, 35692) || true) && (emitErrors)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 35500, 35692);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35564, 35669);

                                    f_1279_35564_35668(this, f_1279_35575_35667(fileLoadException, "GetCommandFileLoadError", ErrorCategory.ReadError, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 35500, 35692);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35716, 35725);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 35416, 35744);
                            }
                            catch (MetadataException metadataException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 35762, 36094);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35846, 36042) || true) && (emitErrors)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 35846, 36042);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 35910, 36019);

                                    f_1279_35910_36018(this, f_1279_35921_36017(metadataException, "GetCommandMetadataError", ErrorCategory.MetadataError, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 35846, 36042);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36066, 36075);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 35762, 36094);
                            }
                            catch (FormatException formatException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 36112, 36436);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36192, 36384) || true) && (emitErrors)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 36192, 36384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36256, 36361);

                                    f_1279_36256_36360(this, f_1279_36267_36359(formatException, "GetCommandBadFileFormat", ErrorCategory.InvalidData, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 36192, 36384);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36408, 36417);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 36112, 36436);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36456, 36523);

                            CommandInfo
                            current = f_1279_36478_36522(((IEnumerator<CommandInfo>)searcher))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36776, 36831);

                            CommandOrigin
                            origin = f_1279_36799_36830(f_1279_36799_36816(this))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36849, 36963) || true) && (!f_1279_36854_36893(origin, current))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 36849, 36963);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36935, 36944);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 36849, 36963);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 36983, 37051);

                            bool
                            tempResultFound = f_1279_37006_37050(this, ref current, out isDuplicate)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37071, 38662) || true) && (tempResultFound && (DynAbs.Tracing.TraceSender.Expression_True(1279, 37075, 37123) && (!f_1279_37096_37122(this, current))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 37071, 38662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37165, 37184);

                                resultFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37206, 38203) || true) && (f_1279_37210_37235(this, current))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 37206, 38203);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37364, 37379);

                                    ++currentCount;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37407, 37546) || true) && (f_1279_37411_37421() >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1279, 37411, 37455) && currentCount > f_1279_37445_37455()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 37407, 37546);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 37513, 37519);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 37407, 37546);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37574, 37844) || true) && (f_1279_37578_37594())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 37574, 37844);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37652, 37734);

                                        int
                                        score = f_1279_37664_37733(f_1279_37707_37719(current), commandName)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37764, 37817);

                                        f_1279_37764_37816(_commandScores, f_1279_37783_37815(current, score));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 37574, 37844);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37872, 37905);

                                    f_1279_37872_37904(
                                                            _accumulatedResults, current);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 37933, 38180) || true) && (f_1279_37937_37949() != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 37933, 38180);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 38147, 38153);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 37933, 38180);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 37206, 38203);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38332, 38643) || true) && (isPattern || (DynAbs.Tracing.TraceSender.Expression_False(1279, 38336, 38352) || f_1279_38349_38352()) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 38336, 38372) || f_1279_38356_38366() != -1) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 38336, 38399) || _isCommandTypeSpecified) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 38336, 38421) || _isModuleSpecified) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 38336, 38457) || _isFullyQualifiedModuleSpecified))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 38332, 38643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38507, 38516);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 38332, 38643);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 38332, 38643);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1279, 38614, 38620);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 38332, 38643);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 37071, 38662);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 34506, 38691);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 34506, 38691) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 34506, 38691);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 34506, 38691);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38707, 39714) || true) && (f_1279_38711_38714())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 38707, 39714);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38821, 39699);
                        foreach (CommandInfo command in f_1279_38853_38896_I(f_1279_38853_38896(this, commandName)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 38821, 39699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38938, 38962);

                            CommandInfo
                            c = command
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 38984, 39046);

                            bool
                            tempResultFound = f_1279_39007_39045(this, ref c, out isDuplicate)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39068, 39680) || true) && (tempResultFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 39068, 39680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39137, 39156);

                                resultFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39182, 39578) || true) && (!f_1279_39187_39213(this, command) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 39186, 39236) && f_1279_39217_39236(this, c)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 39182, 39578);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39294, 39309);

                                    ++currentCount;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39341, 39492) || true) && (f_1279_39345_39355() >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1279, 39345, 39389) && currentCount > f_1279_39379_39389()))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 39341, 39492);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 39455, 39461);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 39341, 39492);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39524, 39551);

                                    f_1279_39524_39550(
                                                                _accumulatedResults, c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 39182, 39578);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 39068, 39680);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 38821, 39699);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 879);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 879);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 38707, 39714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 39730, 39749);

                return resultFound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 34006, 39760);

                System.Management.Automation.CommandTypes
                f_1279_34358_34374(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 34358, 34374);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_34401_34413(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 34401, 34413);
                    return return_v;
                }


                System.Management.Automation.CommandSearcher
                f_1279_34240_34414(string
                commandName, System.Management.Automation.SearchResolutionOptions
                options, System.Management.Automation.CommandTypes
                commandTypes, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandSearcher(commandName, options, commandTypes, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 34240, 34414);
                    return return_v;
                }


                bool
                f_1279_34590_34609(System.Management.Automation.CommandSearcher
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 34590, 34609);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_34884_34980(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 34884, 34980);
                    return return_v;
                }


                int
                f_1279_34873_34981(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 34873, 34981);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_35231_35321(System.IO.PathTooLongException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35231, 35321);
                    return return_v;
                }


                int
                f_1279_35220_35322(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35220, 35322);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_35575_35667(System.IO.FileLoadException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35575, 35667);
                    return return_v;
                }


                int
                f_1279_35564_35668(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35564, 35668);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_35921_36017(System.Management.Automation.MetadataException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35921, 36017);
                    return return_v;
                }


                int
                f_1279_35910_36018(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 35910, 36018);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_36267_36359(System.FormatException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 36267, 36359);
                    return return_v;
                }


                int
                f_1279_36256_36360(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 36256, 36360);
                    return 0;
                }


                System.Management.Automation.CommandInfo
                f_1279_36478_36522(System.Collections.Generic.IEnumerator<System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 36478, 36522);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1279_36799_36816(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 36799, 36816);
                    return return_v;
                }


                System.Management.Automation.CommandOrigin
                f_1279_36799_36830(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.CommandOrigin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 36799, 36830);
                    return return_v;
                }


                bool
                f_1279_36854_36893(System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = SessionState.IsVisible(origin, commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 36854, 36893);
                    return return_v;
                }


                bool
                f_1279_37006_37050(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, ref System.Management.Automation.CommandInfo
                current, out bool
                isDuplicate)
                {
                    var return_v = this_param.IsCommandMatch(ref current, out isDuplicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37006, 37050);
                    return return_v;
                }


                bool
                f_1279_37096_37122(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                command)
                {
                    var return_v = this_param.IsCommandInResult(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37096, 37122);
                    return return_v;
                }


                bool
                f_1279_37210_37235(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.IsParameterMatch(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37210, 37235);
                    return return_v;
                }


                int
                f_1279_37411_37421()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 37411, 37421);
                    return return_v;
                }


                int
                f_1279_37445_37455()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 37445, 37455);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_37578_37594()
                {
                    var return_v = UseFuzzyMatching;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 37578, 37594);
                    return return_v;
                }


                string
                f_1279_37707_37719(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 37707, 37719);
                    return return_v;
                }


                int
                f_1279_37664_37733(string
                string1, string
                string2)
                {
                    var return_v = FuzzyMatcher.GetDamerauLevenshteinDistance(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37664, 37733);
                    return return_v;
                }


                System.Management.Automation.Internal.CommandScore
                f_1279_37783_37815(System.Management.Automation.CommandInfo
                command, int
                score)
                {
                    var return_v = new System.Management.Automation.Internal.CommandScore(command, score);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37783, 37815);
                    return return_v;
                }


                int
                f_1279_37764_37816(System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>
                this_param, System.Management.Automation.Internal.CommandScore
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37764, 37816);
                    return 0;
                }


                int
                f_1279_37872_37904(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                this_param, System.Management.Automation.CommandInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 37872, 37904);
                    return 0;
                }


                object[]
                f_1279_37937_37949()
                {
                    var return_v = ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 37937, 37949);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_38349_38352()
                {
                    var return_v = All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 38349, 38352);
                    return return_v;
                }


                int
                f_1279_38356_38366()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 38356, 38366);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1279_38711_38714()
                {
                    var return_v = All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 38711, 38714);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_38853_38896(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, string
                commandName)
                {
                    var return_v = this_param.GetMatchingCommandsFromModules(commandName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 38853, 38896);
                    return return_v;
                }


                bool
                f_1279_39007_39045(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, ref System.Management.Automation.CommandInfo
                current, out bool
                isDuplicate)
                {
                    var return_v = this_param.IsCommandMatch(ref current, out isDuplicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 39007, 39045);
                    return return_v;
                }


                bool
                f_1279_39187_39213(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                command)
                {
                    var return_v = this_param.IsCommandInResult(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 39187, 39213);
                    return return_v;
                }


                bool
                f_1279_39217_39236(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                commandInfo)
                {
                    var return_v = this_param.IsParameterMatch(commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 39217, 39236);
                    return return_v;
                }


                int
                f_1279_39345_39355()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 39345, 39355);
                    return return_v;
                }


                int
                f_1279_39379_39389()
                {
                    var return_v = TotalCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 39379, 39389);
                    return return_v;
                }


                int
                f_1279_39524_39550(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                this_param, System.Management.Automation.CommandInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 39524, 39550);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                f_1279_38853_38896_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 38853, 38896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 34006, 39760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 34006, 39760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDuplicate(CommandInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 40182, 41630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40249, 40269);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40283, 40301);

                string
                key = null
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 40317, 41283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40366, 40416);

                            ApplicationInfo
                            appInfo = info as ApplicationInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40434, 40561) || true) && (appInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 40434, 40561);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40495, 40514);

                                key = f_1279_40501_40513(appInfo);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 40536, 40542);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 40434, 40561);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40581, 40624);

                            CmdletInfo
                            cmdletInfo = info as CmdletInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40642, 40779) || true) && (cmdletInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 40642, 40779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40706, 40732);

                                key = f_1279_40712_40731(cmdletInfo);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 40754, 40760);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 40642, 40779);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40799, 40842);

                            ScriptInfo
                            scriptInfo = info as ScriptInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40860, 40999) || true) && (scriptInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 40860, 40999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40924, 40952);

                                key = f_1279_40930_40951(scriptInfo);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 40974, 40980);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 40860, 40999);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41019, 41086);

                            ExternalScriptInfo
                            externalScriptInfo = info as ExternalScriptInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41104, 41253) || true) && (externalScriptInfo != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41104, 41253);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41176, 41206);

                                key = f_1279_41182_41205(externalScriptInfo);
                                DynAbs.Tracing.TraceSender.TraceBreak(1279, 41228, 41234);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41104, 41253);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 40317, 41283);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 40317, 41283) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 40317, 41283);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 40317, 41283);
                    }
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41299, 41589) || true) && (key != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41299, 41589);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41348, 41574) || true) && (f_1279_41352_41385(_commandsWritten, key))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41348, 41574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41427, 41441);

                        result = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41348, 41574);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41348, 41574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41523, 41555);

                        f_1279_41523_41554(_commandsWritten, key, info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41348, 41574);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41299, 41589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41605, 41619);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 40182, 41630);

                string
                f_1279_40501_40513(System.Management.Automation.ApplicationInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 40501, 40513);
                    return return_v;
                }


                string
                f_1279_40712_40731(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 40712, 40731);
                    return return_v;
                }


                string
                f_1279_40930_40951(System.Management.Automation.ScriptInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 40930, 40951);
                    return return_v;
                }


                string
                f_1279_41182_41205(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 41182, 41205);
                    return return_v;
                }


                bool
                f_1279_41352_41385(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 41352, 41385);
                    return return_v;
                }


                int
                f_1279_41523_41554(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param, string
                key, System.Management.Automation.CommandInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 41523, 41554);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 40182, 41630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 40182, 41630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsParameterMatch(CommandInfo commandInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 41642, 43434);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41721, 41846) || true) && ((f_1279_41726_41744(this) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 41725, 41785) && (f_1279_41758_41776(this) == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41721, 41846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41819, 41831);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41721, 41846);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41862, 42024) || true) && (_matchedParameterNames == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 41862, 42024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 41930, 42009);

                    _matchedParameterNames = f_1279_41955_42008(f_1279_41975_42007());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 41862, 42024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42040, 42096);

                IEnumerable<ParameterMetadata>
                commandParameters = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42146, 42214);

                    IDictionary<string, ParameterMetadata>
                    tmp = f_1279_42191_42213(commandInfo)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42232, 42339) || true) && (tmp != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 42232, 42339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42289, 42320);

                        commandParameters = f_1279_42309_42319(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 42232, 42339);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 42368, 42610);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 42368, 42610);
                    // ignore all exceptions when getting parameter metadata (i.e. parse exceptions, dangling alias exceptions)
                    // and proceed as if there was no parameter metadata
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42626, 43423) || true) && (commandParameters == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 42626, 43423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42813, 42826);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 42626, 43423);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 42626, 43423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42892, 42928);

                    bool
                    foundMatchingParameter = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 42946, 43358);
                        foreach (ParameterMetadata parameterMetadata in f_1279_42994_43011_I(commandParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 42946, 43358);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43053, 43339) || true) && (f_1279_43057_43092(this, parameterMetadata))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 43053, 43339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43142, 43172);

                                foundMatchingParameter = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 43053, 43339);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 42946, 43358);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 413);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 413);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43378, 43408);

                    return foundMatchingParameter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 42626, 43423);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 41642, 43434);

                string[]
                f_1279_41726_41744(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 41726, 41744);
                    return return_v;
                }


                System.Management.Automation.PSTypeName[]
                f_1279_41758_41776(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 41758, 41776);
                    return return_v;
                }


                System.StringComparer
                f_1279_41975_42007()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 41975, 42007);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1279_41955_42008(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 41955, 42008);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1279_42191_42213(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 42191, 42213);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.ParameterMetadata>
                f_1279_42309_42319(System.Collections.Generic.IDictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 42309, 42319);
                    return return_v;
                }


                bool
                f_1279_43057_43092(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ParameterMetadata
                parameterMetadata)
                {
                    var return_v = this_param.IsParameterMatch(parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 43057, 43092);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterMetadata>
                f_1279_42994_43011_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 42994, 43011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 41642, 43434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 41642, 43434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsParameterMatch(ParameterMetadata parameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 43446, 45156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43610, 43743);

                bool
                nameIsDirectlyMatching = f_1279_43640_43742(f_1279_43688_43710(parameterMetadata), _parameterNameWildcards, true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43759, 43795);

                bool
                oneOfAliasesIsMatching = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43809, 44296);
                    foreach (string alias in f_1279_43834_43889_I(f_1279_43834_43859(parameterMetadata) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<string>>(1279, 43834, 43889) ?? f_1279_43863_43889())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 43809, 44296);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 43923, 44281) || true) && (f_1279_43927_44012(alias, _parameterNameWildcards, true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 43923, 44281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44054, 44088);

                            f_1279_44054_44087(_matchedParameterNames, alias);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44110, 44140);

                            oneOfAliasesIsMatching = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 43923, 44281);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 43809, 44296);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44312, 44383);

                bool
                nameIsMatching = nameIsDirectlyMatching || (DynAbs.Tracing.TraceSender.Expression_False(1279, 44334, 44382) || oneOfAliasesIsMatching)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44397, 44515) || true) && (nameIsMatching)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 44397, 44515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44449, 44500);

                    f_1279_44449_44499(_matchedParameterNames, f_1279_44476_44498(parameterMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 44397, 44515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44604, 44624);

                bool
                typeIsMatching
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44638, 45089) || true) && ((_parameterTypes == null) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 44642, 44700) || (f_1279_44672_44694(_parameterTypes) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 44638, 45089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44734, 44756);

                    typeIsMatching = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 44638, 45089);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 44638, 45089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44822, 44845);

                    typeIsMatching = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44863, 45074) || true) && (_parameterTypes != null && (DynAbs.Tracing.TraceSender.Expression_True(1279, 44867, 44941) && f_1279_44915_44937(_parameterTypes) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 44863, 45074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 44983, 45055);

                        typeIsMatching |= f_1279_45001_45054(_parameterTypes, parameterMetadata.IsMatchingType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 44863, 45074);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 44638, 45089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45105, 45145);

                return nameIsMatching && (DynAbs.Tracing.TraceSender.Expression_True(1279, 45112, 45144) && typeIsMatching);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 43446, 45156);

                string
                f_1279_43688_43710(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 43688, 43710);
                    return return_v;
                }


                bool
                f_1279_43640_43742(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 43640, 43742);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1279_43834_43859(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 43834, 43859);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1279_43863_43889()
                {
                    var return_v = Enumerable.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 43863, 43889);
                    return return_v;
                }


                bool
                f_1279_43927_44012(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 43927, 44012);
                    return return_v;
                }


                bool
                f_1279_44054_44087(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 44054, 44087);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1279_43834_43889_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 43834, 43889);
                    return return_v;
                }


                string
                f_1279_44476_44498(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 44476, 44498);
                    return return_v;
                }


                bool
                f_1279_44449_44499(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 44449, 44499);
                    return return_v;
                }


                int
                f_1279_44672_44694(System.Management.Automation.PSTypeName[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 44672, 44694);
                    return return_v;
                }


                int
                f_1279_44915_44937(System.Management.Automation.PSTypeName[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 44915, 44937);
                    return return_v;
                }


                bool
                f_1279_45001_45054(System.Management.Automation.PSTypeName[]
                source, System.Func<System.Management.Automation.PSTypeName, bool>
                predicate)
                {
                    var return_v = source.Any<System.Management.Automation.PSTypeName>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 45001, 45054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 43446, 45156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 43446, 45156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCommandMatch(ref CommandInfo current, out bool isDuplicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 45168, 52271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45267, 45295);

                bool
                isCommandMatch = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45309, 45329);

                isDuplicate = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45414, 52222) || true) && (!f_1279_45419_45439(this, current))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 45414, 52222);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45473, 45605) || true) && ((f_1279_45478_45497(current) & f_1279_45500_45516(this)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 45473, 45605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45564, 45586);

                        isCommandMatch = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 45473, 45605);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 45817, 47551) || true) && (f_1279_45821_45840(current) == CommandTypes.Cmdlet || (DynAbs.Tracing.TraceSender.Expression_False(1279, 45821, 46215) || ((f_1279_45890_45903(_verbs) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1279, 45890, 45928) || f_1279_45911_45924(_nouns) > 0)) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 45889, 46214) && (f_1279_45956_45975(current) == CommandTypes.Function || (DynAbs.Tracing.TraceSender.Expression_False(1279, 45956, 46069) || f_1279_46027_46046(current) == CommandTypes.Filter) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 45956, 46145) || f_1279_46096_46115(current) == CommandTypes.Configuration) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 45956, 46213) || f_1279_46172_46191(current) == CommandTypes.Alias))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 45817, 47551);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46257, 46382) || true) && (!f_1279_46262_46286(this, current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 46257, 46382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46336, 46359);

                            isCommandMatch = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 46257, 46382);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 45817, 47551);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 45817, 47551);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46464, 47532) || true) && (_isFullyQualifiedModuleSpecified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 46464, 47532);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46550, 46580);

                            bool
                            foundModuleMatch = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46606, 46993);
                                foreach (var moduleSpecification in f_1279_46642_46663_I(_moduleSpecifications))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 46606, 46993);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46721, 46966) || true) && (f_1279_46725_46805(f_1279_46769_46783(current), moduleSpecification))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 46721, 46966);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 46871, 46895);

                                        foundModuleMatch = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1279, 46929, 46935);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 46721, 46966);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 46606, 46993);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 388);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 388);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47021, 47150) || true) && (!foundModuleMatch)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47021, 47150);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47100, 47123);

                                isCommandMatch = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47021, 47150);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 46464, 47532);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 46464, 47532);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47200, 47532) || true) && (_modulePatterns != null && (DynAbs.Tracing.TraceSender.Expression_True(1279, 47204, 47256) && f_1279_47231_47252(_modulePatterns) > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47200, 47532);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47306, 47509) || true) && (!f_1279_47311_47401(f_1279_47359_47377(current), _modulePatterns, true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47306, 47509);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47459, 47482);

                                    isCommandMatch = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47306, 47509);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47200, 47532);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 46464, 47532);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 45817, 47551);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47571, 52122) || true) && (isCommandMatch)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47571, 52122);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47631, 49001) || true) && (f_1279_47635_47647() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47631, 49001);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47705, 47741);

                            AliasInfo
                            ai = current as AliasInfo
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47767, 48978) || true) && (ai != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47767, 48978);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 47995, 48024);

                                current = f_1279_48005_48023(ai);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 48054, 48183) || true) && (current == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 48054, 48183);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 48139, 48152);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 48054, 48183);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47767, 48978);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 47767, 48978);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 48241, 48978) || true) && (!(current is CmdletInfo || (DynAbs.Tracing.TraceSender.Expression_False(1279, 48247, 48301) || current is IScriptCommandInfo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 48241, 48978);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 48468, 48951);

                                    f_1279_48468_48950(this, f_1279_48524_48949(f_1279_48578_48763("ArgumentList", f_1279_48712_48762()), "CommandArgsOnlyForSingleCmdlet", ErrorCategory.InvalidArgument, current));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 48241, 48978);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47767, 48978);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47631, 49001);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 49301, 49323);

                        bool
                        needCopy = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 49550, 49597);

                            needCopy = f_1279_49561_49596(current);
                        }
                        catch (PSSecurityException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 49642, 49871);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 49642, 49871);
                            // Ignore execution policies in get-command, those will get
                            // raised when trying to run the real command
                        }
                        catch (RuntimeException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 49893, 50118);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 49893, 50118);
                            // Ignore parse/runtime exceptions.  Again, they will get
                            // raised again if the script is actually run.
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 50142, 52103) || true) && (needCopy)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 50142, 52103);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 50264, 50332);

                                CommandInfo
                                newCurrent = f_1279_50289_50331(current, f_1279_50318_50330())
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 50364, 50893) || true) && (f_1279_50368_50380() != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 50364, 50893);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 50740, 50862);

                                    ReadOnlyCollection<CommandParameterSetInfo>
                                    parameterSets =
                                    f_1279_50837_50861(newCurrent)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 50364, 50893);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 50925, 50946);

                                current = newCurrent;
                            }
                            catch (MetadataException metadataException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 50999, 51459);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 51264, 51432);

                                f_1279_51264_51431(this, f_1279_51275_51430(metadataException, "GetCommandMetadataError", ErrorCategory.MetadataError, current));
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 50999, 51459);
                            }
                            catch (ParameterBindingException parameterBindingException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 51485, 52080);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 51782, 52053) || true) && (!f_1279_51787_51950(f_1279_51787_51846(f_1279_51787_51824(parameterBindingException)), "GetDynamicParametersException", StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 51782, 52053);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52016, 52022);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 51782, 52053);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 51485, 52080);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 50142, 52103);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 47571, 52122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 45414, 52222);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 45414, 52222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52188, 52207);

                    isDuplicate = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 45414, 52222);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52238, 52260);

                return isCommandMatch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 45168, 52271);

                bool
                f_1279_45419_45439(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                info)
                {
                    var return_v = this_param.IsDuplicate(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 45419, 45439);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_45478_45497(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45478, 45497);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_45500_45516(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45500, 45516);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_45821_45840(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45821, 45840);
                    return return_v;
                }


                int
                f_1279_45890_45903(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45890, 45903);
                    return return_v;
                }


                int
                f_1279_45911_45924(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45911, 45924);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_45956_45975(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 45956, 45975);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_46027_46046(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 46027, 46046);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_46096_46115(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 46096, 46115);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_46172_46191(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 46172, 46191);
                    return return_v;
                }


                bool
                f_1279_46262_46286(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.CommandInfo
                command)
                {
                    var return_v = this_param.IsNounVerbMatch(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 46262, 46286);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_46769_46783(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 46769, 46783);
                    return return_v;
                }


                bool
                f_1279_46725_46805(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec)
                {
                    var return_v = ModuleIntrinsics.IsModuleMatchingModuleSpec(moduleInfo, moduleSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 46725, 46805);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1279_46642_46663_I(Microsoft.PowerShell.Commands.ModuleSpecification[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 46642, 46663);
                    return return_v;
                }


                int
                f_1279_47231_47252(System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 47231, 47252);
                    return return_v;
                }


                string
                f_1279_47359_47377(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 47359, 47377);
                    return return_v;
                }


                bool
                f_1279_47311_47401(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 47311, 47401);
                    return return_v;
                }


                object[]
                f_1279_47635_47647()
                {
                    var return_v = ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 47635, 47647);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1279_48005_48023(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.ResolvedCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 48005, 48023);
                    return return_v;
                }


                string
                f_1279_48712_48762()
                {
                    var return_v = DiscoveryExceptions.CommandArgsOnlyForSingleCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 48712, 48762);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1279_48578_48763(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 48578, 48763);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_48524_48949(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.CommandInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 48524, 48949);
                    return return_v;
                }


                int
                f_1279_48468_48950(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 48468, 48950);
                    return 0;
                }


                bool
                f_1279_49561_49596(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 49561, 49596);
                    return return_v;
                }


                object[]
                f_1279_50318_50330()
                {
                    var return_v = ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 50318, 50330);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1279_50289_50331(System.Management.Automation.CommandInfo
                this_param, object[]
                argumentList)
                {
                    var return_v = this_param.CreateGetCommandCopy(argumentList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 50289, 50331);
                    return return_v;
                }


                object[]
                f_1279_50368_50380()
                {
                    var return_v = ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 50368, 50380);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                f_1279_50837_50861(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 50837, 50861);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1279_51275_51430(System.Management.Automation.MetadataException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.CommandInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 51275, 51430);
                    return return_v;
                }


                int
                f_1279_51264_51431(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 51264, 51431);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1279_51787_51824(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 51787, 51824);
                    return return_v;
                }


                string
                f_1279_51787_51846(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 51787, 51846);
                    return return_v;
                }


                bool
                f_1279_51787_51950(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 51787, 51950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 45168, 52271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 45168, 52271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<CommandInfo> GetMatchingCommandsFromModules(string commandName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 52588, 56046);

                var listYield = new List<CommandInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52696, 52866);

                WildcardPattern
                matcher = f_1279_52722_52865(commandName, WildcardOptions.IgnoreCase)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52949, 53005);

                    // Use ModuleTableKeys list in reverse order
                    for (int
        i = f_1279_52953_53001(f_1279_52953_52979(f_1279_52953_52960()).ModuleTableKeys) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 52940, 56035) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53015, 53018)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 52940, 56035))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 52940, 56035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53052, 53079);

                        PSModuleInfo
                        module = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53099, 56020) || true) && (f_1279_53103_53212(f_1279_53103_53141(f_1279_53103_53129(f_1279_53103_53110())), f_1279_53154_53199(f_1279_53154_53180(f_1279_53154_53161()).ModuleTableKeys, i), out module) == false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53099, 56020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53263, 53335);

                            f_1279_53263_53334(false, "ModuleTableKeys should be in sync with ModuleTable");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53099, 56020);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53099, 56020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53417, 53444);

                            bool
                            isModuleMatch = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53466, 53923) || true) && (!_isFullyQualifiedModuleSpecified)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53466, 53923);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53553, 53653);

                                isModuleMatch = f_1279_53569_53652(f_1279_53617_53628(module), _modulePatterns, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53466, 53923);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53466, 53923);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53703, 53923) || true) && (f_1279_53707_53829(_moduleSpecifications, moduleSpecification => ModuleIntrinsics.IsModuleMatchingModuleSpec(module, moduleSpecification)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53703, 53923);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53879, 53900);

                                    isModuleMatch = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53703, 53923);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53466, 53923);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 53947, 56001) || true) && (isModuleMatch)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 53947, 56001);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54014, 55978) || true) && (f_1279_54018_54037(module) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 54014, 55978);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54158, 55102) || true) && ((f_1279_54163_54179(this) & (CommandTypes.Function | CommandTypes.Filter | CommandTypes.Configuration)) != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 54158, 55102);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54328, 55071);
                                            foreach (DictionaryEntry function in f_1279_54365_54412_I(f_1279_54365_54412(f_1279_54365_54393(f_1279_54365_54384(module)))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 54328, 55071);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54486, 54535);

                                                FunctionInfo
                                                func = (FunctionInfo)function.Value
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54575, 55036) || true) && (f_1279_54579_54616(matcher, function.Key) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 54579, 54635) && f_1279_54620_54635(func)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 54575, 55036);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54833, 54997) || true) && (f_1279_54837_54909(f_1279_54837_54853(f_1279_54837_54848(func)), f_1279_54861_54872(module), StringComparison.OrdinalIgnoreCase))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 54833, 54997);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 54956, 54997);

                                                        listYield.Add((CommandInfo)function.Value);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 54833, 54997);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 54575, 55036);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 54328, 55071);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 744);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 744);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 54158, 55102);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 55186, 55951) || true) && ((f_1279_55191_55207(this) & CommandTypes.Alias) != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 55186, 55951);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 55300, 55920);
                                            foreach (var alias in f_1279_55322_55366_I(f_1279_55322_55366(f_1279_55322_55350(f_1279_55322_55341(module)))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 55300, 55920);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 55440, 55885) || true) && (f_1279_55444_55470(matcher, alias.Key) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 55444, 55496) && f_1279_55474_55496(alias.Value)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 55440, 55885);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 55691, 55846) || true) && (f_1279_55695_55774(f_1279_55695_55718(f_1279_55695_55713(alias.Value)), f_1279_55726_55737(module), StringComparison.OrdinalIgnoreCase))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 55691, 55846);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 55821, 55846);

                                                        listYield.Add(alias.Value);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 55691, 55846);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 55440, 55885);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 55300, 55920);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 621);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 621);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 55186, 55951);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 54014, 55978);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53947, 56001);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 53099, 56020);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 3096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 3096);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 52588, 56046);

                return listYield;

                System.Management.Automation.WildcardPattern
                f_1279_52722_52865(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 52722, 52865);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_52953_52960()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 52953, 52960);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1279_52953_52979(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 52953, 52979);
                    return return_v;
                }


                int
                f_1279_52953_53001(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 52953, 53001);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_53103_53110()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53103, 53110);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1279_53103_53129(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53103, 53129);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                f_1279_53103_53141(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ModuleTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53103, 53141);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1279_53154_53161()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53154, 53161);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1279_53154_53180(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53154, 53180);
                    return return_v;
                }


                string
                f_1279_53154_53199(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53154, 53199);
                    return return_v;
                }


                bool
                f_1279_53103_53212(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSModuleInfo>
                this_param, string
                key, out System.Management.Automation.PSModuleInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 53103, 53212);
                    return return_v;
                }


                int
                f_1279_53263_53334(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 53263, 53334);
                    return 0;
                }


                string
                f_1279_53617_53628(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 53617, 53628);
                    return return_v;
                }


                bool
                f_1279_53569_53652(string
                text, System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                patterns, bool
                defaultValue)
                {
                    var return_v = SessionStateUtilities.MatchesAnyWildcardPattern(text, (System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>)patterns, defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 53569, 53652);
                    return return_v;
                }


                bool
                f_1279_53707_53829(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source, System.Func<Microsoft.PowerShell.Commands.ModuleSpecification, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.PowerShell.Commands.ModuleSpecification>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 53707, 53829);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1279_54018_54037(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54018, 54037);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_54163_54179(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54163, 54179);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1279_54365_54384(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54365, 54384);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1279_54365_54393(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54365, 54393);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1279_54365_54412(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetFunctionTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 54365, 54412);
                    return return_v;
                }


                bool
                f_1279_54579_54616(System.Management.Automation.WildcardPattern
                this_param, object
                input)
                {
                    var return_v = this_param.IsMatch((string)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 54579, 54616);
                    return return_v;
                }


                bool
                f_1279_54620_54635(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.IsImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54620, 54635);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_54837_54848(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54837, 54848);
                    return return_v;
                }


                string
                f_1279_54837_54853(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54837, 54853);
                    return return_v;
                }


                string
                f_1279_54861_54872(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 54861, 54872);
                    return return_v;
                }


                bool
                f_1279_54837_54909(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 54837, 54909);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1279_54365_54412_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 54365, 54412);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_55191_55207(Microsoft.PowerShell.Commands.GetCommandCommand
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55191, 55207);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1279_55322_55341(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55322, 55341);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1279_55322_55350(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55322, 55350);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1279_55322_55366(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GetAliasTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 55322, 55366);
                    return return_v;
                }


                bool
                f_1279_55444_55470(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 55444, 55470);
                    return return_v;
                }


                bool
                f_1279_55474_55496(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.IsImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55474, 55496);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_55695_55713(System.Management.Automation.AliasInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55695, 55713);
                    return return_v;
                }


                string
                f_1279_55695_55718(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55695, 55718);
                    return return_v;
                }


                string
                f_1279_55726_55737(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 55726, 55737);
                    return return_v;
                }


                bool
                f_1279_55695_55774(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 55695, 55774);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                f_1279_55322_55366_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.AliasInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 55322, 55366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 52588, 56046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 52588, 56046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCommandInResult(CommandInfo command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 56464, 57993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 56540, 56563);

                bool
                isPresent = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 56577, 56624);

                bool
                commandHasModule = f_1279_56601_56615(command) != null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 56638, 57949);
                    foreach (CommandInfo commandInfo in f_1279_56674_56693_I(_accumulatedResults))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 56638, 57949);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 56727, 57934) || true) && ((f_1279_56732_56751(command) == f_1279_56755_56778(commandInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 56732, 57301) && (f_1279_56805_56887(f_1279_56820_56832(command), f_1279_56834_56850(commandInfo), StringComparison.OrdinalIgnoreCase) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1279, 56805, 57300) || f_1279_57147_57295(f_1279_57162_57244(f_1279_57207_57223(commandInfo), f_1279_57225_57243(commandInfo)), f_1279_57246_57258(command), StringComparison.OrdinalIgnoreCase) == 0))
                        )) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 56731, 57354) && f_1279_57328_57346(commandInfo) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 56731, 57374) && commandHasModule) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 56731, 57828) && ( // We do reference equal comparison if both command are imported. If either one is not imported, we compare the module path
                                             (f_1279_57548_57570(commandInfo) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 57548, 57592) && f_1279_57574_57592(command)) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 57548, 57637) && f_1279_57596_57637(f_1279_57596_57614(commandInfo), f_1279_57622_57636(command)))) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 57547, 57805) || ((f_1279_57666_57689_M(!commandInfo.IsImported) || (DynAbs.Tracing.TraceSender.Expression_False(1279, 57666, 57712) || f_1279_57693_57712_M(!command.IsImported))) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 57665, 57804) && f_1279_57717_57804(f_1279_57717_57740(f_1279_57717_57735(commandInfo)), f_1279_57748_57767(f_1279_57748_57762(command)), StringComparison.OrdinalIgnoreCase)))
                        ))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 56727, 57934);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 57870, 57887);

                            isPresent = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1279, 57909, 57915);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 56727, 57934);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 56638, 57949);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 1312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 1312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 57965, 57982);

                return isPresent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 56464, 57993);

                System.Management.Automation.PSModuleInfo
                f_1279_56601_56615(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 56601, 56615);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_56732_56751(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 56732, 56751);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_56755_56778(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 56755, 56778);
                    return return_v;
                }


                string
                f_1279_56820_56832(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 56820, 56832);
                    return return_v;
                }


                string
                f_1279_56834_56850(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 56834, 56850);
                    return return_v;
                }


                int
                f_1279_56805_56887(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 56805, 56887);
                    return return_v;
                }


                string
                f_1279_57207_57223(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57207, 57223);
                    return return_v;
                }


                string
                f_1279_57225_57243(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57225, 57243);
                    return return_v;
                }


                string
                f_1279_57162_57244(string
                commandName, string
                prefix)
                {
                    var return_v = ModuleCmdletBase.RemovePrefixFromCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 57162, 57244);
                    return return_v;
                }


                string
                f_1279_57246_57258(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57246, 57258);
                    return return_v;
                }


                int
                f_1279_57147_57295(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 57147, 57295);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_57328_57346(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57328, 57346);
                    return return_v;
                }


                bool
                f_1279_57548_57570(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.IsImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57548, 57570);
                    return return_v;
                }


                bool
                f_1279_57574_57592(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.IsImported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57574, 57592);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_57596_57614(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57596, 57614);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_57622_57636(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57622, 57636);
                    return return_v;
                }


                bool
                f_1279_57596_57637(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.PSModuleInfo
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 57596, 57637);
                    return return_v;
                }


                bool
                f_1279_57666_57689_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57666, 57689);
                    return return_v;
                }


                bool
                f_1279_57693_57712_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57693, 57712);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_57717_57735(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57717, 57735);
                    return return_v;
                }


                string
                f_1279_57717_57740(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57717, 57740);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_57748_57762(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57748, 57762);
                    return return_v;
                }


                string
                f_1279_57748_57767(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 57748, 57767);
                    return return_v;
                }


                bool
                f_1279_57717_57804(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 57717, 57804);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                f_1279_56674_56693_I(System.Collections.Generic.List<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 56674, 56693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 56464, 57993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 56464, 57993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, CommandInfo> _commandsWritten;

        private List<CommandInfo> _accumulatedResults;

        private Collection<WildcardPattern> _verbPatterns;

        private Collection<WildcardPattern> _nounPatterns;

        private Collection<WildcardPattern> _modulePatterns;

        private static PSObject ConvertToShowCommandInfo(CommandInfo cmdInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1279, 58778, 59558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58872, 58914);

                PSObject
                showCommandInfo = f_1279_58899_58913()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58928, 59001);

                f_1279_58928_59000(f_1279_58928_58954(showCommandInfo), f_1279_58959_58999("Name", f_1279_58986_58998(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59015, 59100);

                f_1279_59015_59099(f_1279_59015_59041(showCommandInfo), f_1279_59046_59098("ModuleName", f_1279_59079_59097(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59114, 59199);

                f_1279_59114_59198(f_1279_59114_59140(showCommandInfo), f_1279_59145_59197("Module", f_1279_59174_59196(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59213, 59300);

                f_1279_59213_59299(f_1279_59213_59239(showCommandInfo), f_1279_59244_59298("CommandType", f_1279_59278_59297(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59314, 59399);

                f_1279_59314_59398(f_1279_59314_59340(showCommandInfo), f_1279_59345_59397("Definition", f_1279_59378_59396(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59413, 59508);

                f_1279_59413_59507(f_1279_59413_59439(showCommandInfo), f_1279_59444_59506("ParameterSets", f_1279_59480_59505(cmdInfo)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59524, 59547);

                return showCommandInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1279, 58778, 59558);

                System.Management.Automation.PSObject
                f_1279_58899_58913()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 58899, 58913);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_58928_58954(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 58928, 58954);
                    return return_v;
                }


                string
                f_1279_58986_58998(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 58986, 58998);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_58959_58999(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 58959, 58999);
                    return return_v;
                }


                int
                f_1279_58928_59000(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 58928, 59000);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59015_59041(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59015, 59041);
                    return return_v;
                }


                string
                f_1279_59079_59097(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59079, 59097);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59046_59098(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59046, 59098);
                    return return_v;
                }


                int
                f_1279_59015_59099(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59015, 59099);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59114_59140(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59114, 59140);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_59174_59196(System.Management.Automation.CommandInfo
                cmdInfo)
                {
                    var return_v = GetModuleInfo(cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59174, 59196);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59145_59197(string
                name, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59145, 59197);
                    return return_v;
                }


                int
                f_1279_59114_59198(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59114, 59198);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59213_59239(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59213, 59239);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1279_59278_59297(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59278, 59297);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59244_59298(string
                name, System.Management.Automation.CommandTypes
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59244, 59298);
                    return return_v;
                }


                int
                f_1279_59213_59299(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59213, 59299);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59314_59340(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59314, 59340);
                    return return_v;
                }


                string
                f_1279_59378_59396(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59378, 59396);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59345_59397(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59345, 59397);
                    return return_v;
                }


                int
                f_1279_59314_59398(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59314, 59398);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59413_59439(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59413, 59439);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1279_59480_59505(System.Management.Automation.CommandInfo
                cmdInfo)
                {
                    var return_v = GetParameterSets(cmdInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59480, 59505);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59444_59506(string
                name, System.Management.Automation.PSObject[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59444, 59506);
                    return return_v;
                }


                int
                f_1279_59413_59507(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59413, 59507);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 58778, 59558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 58778, 59558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject GetModuleInfo(CommandInfo cmdInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1279, 59570, 59911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59653, 59690);

                PSObject
                moduleInfo = f_1279_59675_59689()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59704, 59786);

                string
                moduleName = (DynAbs.Tracing.TraceSender.Conditional_F1(1279, 59724, 59748) || (((f_1279_59725_59739(cmdInfo) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1279, 59751, 59770)) || DynAbs.Tracing.TraceSender.Conditional_F3(1279, 59773, 59785))) ? f_1279_59751_59770(f_1279_59751_59765(cmdInfo)) : string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59800, 59866);

                f_1279_59800_59865(f_1279_59800_59821(moduleInfo), f_1279_59826_59864("Name", moduleName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 59882, 59900);

                return moduleInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1279, 59570, 59911);

                System.Management.Automation.PSObject
                f_1279_59675_59689()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59675, 59689);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_59725_59739(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59725, 59739);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1279_59751_59765(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59751, 59765);
                    return return_v;
                }


                string
                f_1279_59751_59770(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59751, 59770);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_59800_59821(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 59800, 59821);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_59826_59864(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59826, 59864);
                    return return_v;
                }


                int
                f_1279_59800_59865(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 59800, 59865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 59570, 59911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 59570, 59911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject[] GetParameterSets(CommandInfo cmdInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1279, 59923, 61284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60011, 60076);

                ReadOnlyCollection<CommandParameterSetInfo>
                parameterSets = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60126, 60258) || true) && (f_1279_60130_60151(cmdInfo) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 60126, 60258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60201, 60239);

                        parameterSets = f_1279_60217_60238(cmdInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 60126, 60258);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 60287, 60324);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 60287, 60324);
                }
                catch (PSNotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 60338, 60373);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 60338, 60373);
                }
                catch (PSNotImplementedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1279, 60387, 60424);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1279, 60387, 60424);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60440, 60545) || true) && (parameterSets == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 60440, 60545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60499, 60530);

                    return f_1279_60506_60529();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 60440, 60545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60561, 60646);

                List<PSObject>
                returnParameterSets = f_1279_60598_60645(f_1279_60617_60644(f_1279_60617_60638(cmdInfo)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60662, 61220);
                    foreach (CommandParameterSetInfo parameterSetInfo in f_1279_60715_60728_I(parameterSets))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 60662, 61220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60762, 60804);

                        PSObject
                        parameterSetObj = f_1279_60789_60803()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60822, 60904);

                        f_1279_60822_60903(f_1279_60822_60848(parameterSetObj), f_1279_60853_60902("Name", f_1279_60880_60901(parameterSetInfo)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 60922, 61014);

                        f_1279_60922_61013(f_1279_60922_60948(parameterSetObj), f_1279_60953_61012("IsDefault", f_1279_60985_61011(parameterSetInfo)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61032, 61144);

                        f_1279_61032_61143(f_1279_61032_61058(parameterSetObj), f_1279_61063_61142("Parameters", f_1279_61096_61141(f_1279_61113_61140(parameterSetInfo))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61164, 61205);

                        f_1279_61164_61204(
                                        returnParameterSets, parameterSetObj);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 60662, 61220);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61236, 61273);

                return f_1279_61243_61272(returnParameterSets);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1279, 59923, 61284);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                f_1279_60130_60151(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60130, 60151);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                f_1279_60217_60238(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60217, 60238);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1279_60506_60529()
                {
                    var return_v = Array.Empty<PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60506, 60529);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                f_1279_60617_60638(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60617, 60638);
                    return return_v;
                }


                int
                f_1279_60617_60644(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60617, 60644);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1279_60598_60645(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60598, 60645);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_60789_60803()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60789, 60803);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_60822_60848(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60822, 60848);
                    return return_v;
                }


                string
                f_1279_60880_60901(System.Management.Automation.CommandParameterSetInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60880, 60901);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_60853_60902(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60853, 60902);
                    return return_v;
                }


                int
                f_1279_60822_60903(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60822, 60903);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_60922_60948(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60922, 60948);
                    return return_v;
                }


                bool
                f_1279_60985_61011(System.Management.Automation.CommandParameterSetInfo
                this_param)
                {
                    var return_v = this_param.IsDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 60985, 61011);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_60953_61012(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60953, 61012);
                    return return_v;
                }


                int
                f_1279_60922_61013(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60922, 61013);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_61032_61058(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61032, 61058);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
                f_1279_61113_61140(System.Management.Automation.CommandParameterSetInfo
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61113, 61140);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1279_61096_61141(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
                parameters)
                {
                    var return_v = GetParameterInfo(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61096, 61141);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_61063_61142(string
                name, System.Management.Automation.PSObject[]
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61063, 61142);
                    return return_v;
                }


                int
                f_1279_61032_61143(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61032, 61143);
                    return 0;
                }


                int
                f_1279_61164_61204(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61164, 61204);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                f_1279_60715_60728_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 60715, 60728);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1279_61243_61272(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61243, 61272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 59923, 61284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 59923, 61284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject[] GetParameterInfo(ReadOnlyCollection<CommandParameterInfo> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1279, 61296, 62957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61416, 61484);

                List<PSObject>
                parameterObjs = f_1279_61447_61483(f_1279_61466_61482(parameters))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61498, 62899);
                    foreach (CommandParameterInfo parameter in f_1279_61541_61551_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 61498, 62899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61585, 61624);

                        PSObject
                        parameterObj = f_1279_61609_61623()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61642, 61714);

                        f_1279_61642_61713(f_1279_61642_61665(parameterObj), f_1279_61670_61712("Name", f_1279_61697_61711(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61732, 61818);

                        f_1279_61732_61817(f_1279_61732_61755(parameterObj), f_1279_61760_61816("IsMandatory", f_1279_61794_61815(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61836, 61934);

                        f_1279_61836_61933(f_1279_61836_61859(parameterObj), f_1279_61864_61932("ValueFromPipeline", f_1279_61904_61931(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 61952, 62032);

                        f_1279_61952_62031(f_1279_61952_61975(parameterObj), f_1279_61980_62030("Position", f_1279_62011_62029(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62050, 62158);

                        f_1279_62050_62157(f_1279_62050_62073(parameterObj), f_1279_62078_62156("ParameterType", f_1279_62114_62155(f_1279_62131_62154(parameter))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62178, 62207);

                        bool
                        hasParameterSet = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62225, 62272);

                        IList<string>
                        validValues = f_1279_62253_62271()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62290, 62423);

                        var
                        validateSetAttribute = f_1279_62317_62422(f_1279_62317_62406(f_1279_62317_62377(f_1279_62317_62337(parameter), x => (x is ValidateSetAttribute))))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62441, 62626) || true) && (validateSetAttribute != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 62441, 62626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62515, 62538);

                            hasParameterSet = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62560, 62607);

                            validValues = f_1279_62574_62606(validateSetAttribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 62441, 62626);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62646, 62730);

                        f_1279_62646_62729(f_1279_62646_62669(parameterObj), f_1279_62674_62728("HasParameterSet", hasParameterSet));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62748, 62832);

                        f_1279_62748_62831(f_1279_62748_62771(parameterObj), f_1279_62776_62830("ValidParamSetValues", validValues));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62852, 62884);

                        f_1279_62852_62883(
                                        parameterObjs, parameterObj);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 61498, 62899);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 1402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 1402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 62915, 62946);

                return f_1279_62922_62945(parameterObjs);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1279, 61296, 62957);

                int
                f_1279_61466_61482(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61466, 61482);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1279_61447_61483(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61447, 61483);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_61609_61623()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61609, 61623);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_61642_61665(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61642, 61665);
                    return return_v;
                }


                string
                f_1279_61697_61711(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61697, 61711);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_61670_61712(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61670, 61712);
                    return return_v;
                }


                int
                f_1279_61642_61713(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61642, 61713);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_61732_61755(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61732, 61755);
                    return return_v;
                }


                bool
                f_1279_61794_61815(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.IsMandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61794, 61815);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_61760_61816(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61760, 61816);
                    return return_v;
                }


                int
                f_1279_61732_61817(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61732, 61817);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_61836_61859(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61836, 61859);
                    return return_v;
                }


                bool
                f_1279_61904_61931(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61904, 61931);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_61864_61932(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61864, 61932);
                    return return_v;
                }


                int
                f_1279_61836_61933(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61836, 61933);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_61952_61975(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 61952, 61975);
                    return return_v;
                }


                int
                f_1279_62011_62029(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62011, 62029);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_61980_62030(string
                name, int
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61980, 62030);
                    return return_v;
                }


                int
                f_1279_61952_62031(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61952, 62031);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_62050_62073(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62050, 62073);
                    return return_v;
                }


                System.Type
                f_1279_62131_62154(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62131, 62154);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_62114_62155(System.Type
                parameterType)
                {
                    var return_v = GetParameterType(parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62114, 62155);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_62078_62156(string
                name, System.Management.Automation.PSObject
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62078, 62156);
                    return return_v;
                }


                int
                f_1279_62050_62157(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62050, 62157);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1279_62253_62271()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62253, 62271);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
                f_1279_62317_62337(System.Management.Automation.CommandParameterInfo
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62317, 62337);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Attribute>
                f_1279_62317_62377(System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
                source, System.Func<System.Attribute, bool>
                predicate)
                {
                    var return_v = source.Where<System.Attribute>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62317, 62377);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ValidateSetAttribute>
                f_1279_62317_62406(System.Collections.Generic.IEnumerable<System.Attribute>
                source)
                {
                    var return_v = source.Cast<System.Management.Automation.ValidateSetAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62317, 62406);
                    return return_v;
                }


                System.Management.Automation.ValidateSetAttribute
                f_1279_62317_62422(System.Collections.Generic.IEnumerable<System.Management.Automation.ValidateSetAttribute>
                source)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.ValidateSetAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62317, 62422);
                    return return_v;
                }


                System.Collections.Generic.IList<string>
                f_1279_62574_62606(System.Management.Automation.ValidateSetAttribute
                this_param)
                {
                    var return_v = this_param.ValidValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62574, 62606);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_62646_62669(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62646, 62669);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_62674_62728(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62674, 62728);
                    return return_v;
                }


                int
                f_1279_62646_62729(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62646, 62729);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_62748_62771(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 62748, 62771);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_62776_62830(string
                name, System.Collections.Generic.IList<string>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62776, 62830);
                    return return_v;
                }


                int
                f_1279_62748_62831(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62748, 62831);
                    return 0;
                }


                int
                f_1279_62852_62883(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62852, 62883);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
                f_1279_61541_61551_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 61541, 61551);
                    return return_v;
                }


                System.Management.Automation.PSObject[]
                f_1279_62922_62945(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 62922, 62945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 61296, 62957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 61296, 62957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSObject GetParameterType(Type parameterType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1279, 62969, 64503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63054, 63100);

                PSObject
                returnParameterType = f_1279_63085_63099()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63114, 63149);

                bool
                isEnum = f_1279_63128_63148(parameterType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63163, 63200);

                bool
                isArray = f_1279_63178_63199(parameterType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63214, 63305);

                f_1279_63214_63304(f_1279_63214_63244(returnParameterType), f_1279_63249_63303("FullName", f_1279_63280_63302(parameterType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63319, 63392);

                f_1279_63319_63391(f_1279_63319_63349(returnParameterType), f_1279_63354_63390("IsEnum", isEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63406, 63481);

                f_1279_63406_63480(f_1279_63406_63436(returnParameterType), f_1279_63441_63479("IsArray", isArray));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63497, 63611);

                ArrayList
                enumValues = (DynAbs.Tracing.TraceSender.Conditional_F1(1279, 63520, 63528) || (((isEnum) && DynAbs.Tracing.TraceSender.Conditional_F2(1279, 63548, 63592)) || DynAbs.Tracing.TraceSender.Conditional_F3(1279, 63595, 63610))) ? f_1279_63548_63592(f_1279_63562_63591(parameterType)) : f_1279_63595_63610()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63625, 63706);

                f_1279_63625_63705(f_1279_63625_63655(returnParameterType), f_1279_63660_63704("EnumValues", enumValues));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63722, 63863);

                bool
                hasFlagAttribute = (DynAbs.Tracing.TraceSender.Conditional_F1(1279, 63746, 63755) || (((isArray) && DynAbs.Tracing.TraceSender.Conditional_F2(1279, 63775, 63854)) || DynAbs.Tracing.TraceSender.Conditional_F3(1279, 63857, 63862))) ? (f_1279_63776_63849((f_1279_63777_63840(parameterType, typeof(FlagsAttribute), true))) > 0) : false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 63877, 63970);

                f_1279_63877_63969(f_1279_63877_63907(returnParameterType), f_1279_63912_63968("HasFlagAttribute", hasFlagAttribute));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64031, 64137);

                object
                elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(1279, 64052, 64061) || (((isArray) && DynAbs.Tracing.TraceSender.Conditional_F2(1279, 64081, 64129)) || DynAbs.Tracing.TraceSender.Conditional_F3(1279, 64132, 64136))) ? f_1279_64081_64129(f_1279_64098_64128(parameterType)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64151, 64234);

                f_1279_64151_64233(f_1279_64151_64181(returnParameterType), f_1279_64186_64232("ElementType", elementType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64250, 64334);

                bool
                implementsDictionary = (!isEnum && (DynAbs.Tracing.TraceSender.Expression_True(1279, 64279, 64298) && !isArray) && (DynAbs.Tracing.TraceSender.Expression_True(1279, 64279, 64332) && (parameterType is IDictionary)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64348, 64449);

                f_1279_64348_64448(f_1279_64348_64378(returnParameterType), f_1279_64383_64447("ImplementsDictionary", implementsDictionary));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64465, 64492);

                return returnParameterType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1279, 62969, 64503);

                System.Management.Automation.PSObject
                f_1279_63085_63099()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63085, 63099);
                    return return_v;
                }


                bool
                f_1279_63128_63148(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63128, 63148);
                    return return_v;
                }


                bool
                f_1279_63178_63199(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63178, 63199);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_63214_63244(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63214, 63244);
                    return return_v;
                }


                string
                f_1279_63280_63302(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63280, 63302);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_63249_63303(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63249, 63303);
                    return return_v;
                }


                int
                f_1279_63214_63304(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63214, 63304);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_63319_63349(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63319, 63349);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_63354_63390(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63354, 63390);
                    return return_v;
                }


                int
                f_1279_63319_63391(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63319, 63391);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_63406_63436(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63406, 63436);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_63441_63479(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63441, 63479);
                    return return_v;
                }


                int
                f_1279_63406_63480(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63406, 63480);
                    return 0;
                }


                System.Array
                f_1279_63562_63591(System.Type
                enumType)
                {
                    var return_v = Enum.GetValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63562, 63591);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1279_63548_63592(System.Array
                c)
                {
                    var return_v = new System.Collections.ArrayList((System.Collections.ICollection)c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63548, 63592);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1279_63595_63610()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63595, 63610);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_63625_63655(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63625, 63655);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_63660_63704(string
                name, System.Collections.ArrayList
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63660, 63704);
                    return return_v;
                }


                int
                f_1279_63625_63705(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63625, 63705);
                    return 0;
                }


                object[]
                f_1279_63777_63840(System.Type
                this_param, System.Type
                attributeType, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(attributeType, inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63777, 63840);
                    return return_v;
                }


                int
                f_1279_63776_63849(object[]
                source)
                {
                    var return_v = source.Count<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63776, 63849);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_63877_63907(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 63877, 63907);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_63912_63968(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63912, 63968);
                    return return_v;
                }


                int
                f_1279_63877_63969(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 63877, 63969);
                    return 0;
                }


                System.Type?
                f_1279_64098_64128(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64098, 64128);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1279_64081_64129(System.Type
                parameterType)
                {
                    var return_v = GetParameterType(parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64081, 64129);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_64151_64181(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 64151, 64181);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_64186_64232(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64186, 64232);
                    return return_v;
                }


                int
                f_1279_64151_64233(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64151, 64233);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1279_64348_64378(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 64348, 64378);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1279_64383_64447(string
                name, bool
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64383, 64447);
                    return return_v;
                }


                int
                f_1279_64348_64448(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64348, 64448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 62969, 64503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 62969, 64503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GetCommandCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1279, 789, 64532);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2313, 2319);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2343, 2364);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 2976, 3006);
            this._verbs = f_1279_2985_3006();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 3678, 3708);
            this._nouns = f_1279_3687_3708();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4382, 4414);
            this._modules = f_1279_4393_4414();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 4438, 4464);
            this._isModuleSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5103, 5161);
            this._moduleSpecifications = f_1279_5127_5161();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5185, 5225);
            this._isFullyQualifiedModuleSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5773, 5804);
            this._commandType = CommandTypes.All;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 5828, 5859);
            this._isCommandTypeSpecified = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 6105, 6207);
            this.TotalCount = -1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 6690, 6696);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 7219, 7410);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 7858, 7862);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 8446, 8459);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9332, 9355);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9383, 9398);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 9433, 9455);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 10948, 10963);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 11247, 11288);
            this._commandScores = f_1279_11264_11288();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58094, 58195);
            this._commandsWritten = f_1279_58126_58195(f_1279_58162_58194());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58234, 58279);
            this._accumulatedResults = f_1279_58256_58279();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58414, 58427);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58474, 58487);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 58534, 58549);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1279, 789, 64532);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 789, 64532);
        }


        static GetCommandCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1279, 789, 64532);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1279, 789, 64532);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 789, 64532);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1279, 789, 64532);

        string[]
        f_1279_2985_3006()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 2985, 3006);
            return return_v;
        }


        string[]
        f_1279_3687_3708()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 3687, 3708);
            return return_v;
        }


        string[]
        f_1279_4393_4414()
        {
            var return_v = Array.Empty<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 4393, 4414);
            return return_v;
        }


        Microsoft.PowerShell.Commands.ModuleSpecification[]
        f_1279_5127_5161()
        {
            var return_v = Array.Empty<ModuleSpecification>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 5127, 5161);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>
        f_1279_11264_11288()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Internal.CommandScore>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 11264, 11288);
            return return_v;
        }


        System.StringComparer
        f_1279_58162_58194()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 58162, 58194);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
        f_1279_58126_58195(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 58126, 58195);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.CommandInfo>
        f_1279_58256_58279()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 58256, 58279);
            return return_v;
        }

    }
    public class NounArgumentCompleter : IArgumentCompleter
    {
        public IEnumerable<CompletionResult> CompleteArgument(string commandName, string parameterName, string wordToComplete, CommandAst commandAst, IDictionary fakeBoundParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1279, 64698, 66027);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64897, 65045) || true) && (fakeBoundParameters == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 64897, 65045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 64962, 65030);

                    throw f_1279_64968_65029("fakeBoundParameters");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 64897, 65045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65061, 65136);

                var
                commandInfo = f_1279_65079_65135("Get-Command", typeof(GetCommandCommand))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65150, 65339);

                var
                ps = f_1279_65159_65338(f_1279_65159_65277(f_1279_65159_65235(RunspaceMode.CurrentRunspace), commandInfo), "Noun", wordToComplete + "*")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65355, 65503) || true) && (f_1279_65359_65397(fakeBoundParameters, "Module"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 65355, 65503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65431, 65488);

                    f_1279_65431_65487(ps, "Module", f_1279_65457_65486(fakeBoundParameters, "Module"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 65355, 65503);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65519, 65565);

                HashSet<string>
                nouns = f_1279_65543_65564()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65579, 65618);

                var
                results = f_1279_65593_65617(ps)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65632, 65883);
                    foreach (var result in f_1279_65655_65662_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 65632, 65883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65696, 65732);

                        var
                        dash = f_1279_65707_65731(f_1279_65707_65718(result), '-')
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65750, 65868) || true) && (dash != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1279, 65750, 65868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65806, 65849);

                            f_1279_65806_65848(nouns, f_1279_65816_65847(f_1279_65816_65827(result), dash + 1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 65750, 65868);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1279, 65632, 65883);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1279, 1, 252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1279, 1, 252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1279, 65899, 66016);

                return f_1279_65906_66015(f_1279_65906_65933(nouns, noun => noun), noun => new CompletionResult(noun, noun, CompletionResultType.Text, noun));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1279, 64698, 66027);

                System.Management.Automation.PSArgumentNullException
                f_1279_64968_65029(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 64968, 65029);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1279_65079_65135(string
                name, System.Type
                implementingType)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65079, 65135);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1279_65159_65235(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65159, 65235);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1279_65159_65277(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.CmdletInfo
                commandInfo)
                {
                    var return_v = this_param.AddCommand((System.Management.Automation.CommandInfo)commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65159, 65277);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1279_65159_65338(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65159, 65338);
                    return return_v;
                }


                bool
                f_1279_65359_65397(System.Collections.IDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65359, 65397);
                    return return_v;
                }


                object
                f_1279_65457_65486(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 65457, 65486);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1279_65431_65487(System.Management.Automation.PowerShell
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65431, 65487);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1279_65543_65564()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65543, 65564);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                f_1279_65593_65617(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.CommandInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65593, 65617);
                    return return_v;
                }


                string
                f_1279_65707_65718(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 65707, 65718);
                    return return_v;
                }


                int
                f_1279_65707_65731(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65707, 65731);
                    return return_v;
                }


                string
                f_1279_65816_65827(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1279, 65816, 65827);
                    return return_v;
                }


                string
                f_1279_65816_65847(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65816, 65847);
                    return return_v;
                }


                bool
                f_1279_65806_65848(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65806, 65848);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                f_1279_65655_65662_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65655, 65662);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_1279_65906_65933(System.Collections.Generic.HashSet<string>
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65906, 65933);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1279_65906_66015(System.Linq.IOrderedEnumerable<string>
                source, System.Func<string, System.Management.Automation.CompletionResult>
                selector)
                {
                    var return_v = source.Select<string, System.Management.Automation.CompletionResult>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1279, 65906, 66015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1279, 64698, 66027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 64698, 66027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NounArgumentCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1279, 64579, 66034);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1279, 64579, 66034);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 64579, 66034);
        }


        static NounArgumentCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1279, 64579, 66034);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1279, 64579, 66034);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1279, 64579, 66034);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1279, 64579, 66034);
    }
}
